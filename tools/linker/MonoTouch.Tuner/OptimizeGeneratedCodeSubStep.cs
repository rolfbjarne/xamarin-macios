// Copyright 2012-2014, 2016 Xamarin Inc. All rights reserved.
using System;
using Mono.Tuner;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Xamarin.Linker;
using Xamarin.Bundler;

namespace MonoTouch.Tuner {
	
	public class OptimizeGeneratedCodeSubStep : CoreOptimizeGeneratedCode {
		
		bool isdirectbinding_check_required;
		
		public OptimizeGeneratedCodeSubStep (LinkerOptions options)
		{
			Options = options;
#if DEBUG
			Console.WriteLine ("OptimizeGeneratedCodeSubStep Arch {0} Device: {1}, EnsureUiThread: {2}, FAT 32+64 {3}", Arch, Device, EnsureUIThread, IsDualBuild);
#endif
		}
		
		public int Arch {
			get { return Options.Arch; }
		}

		public bool Device {
			get { return Options.Device; }
		}
		
		public bool EnsureUIThread {
			get { return Options.EnsureUIThread; }
		}

		public bool IsDualBuild {
			get { return Options.IsDualBuild; }
		}

		MethodDefinition setupblock_def;
		MethodReference GetBlockSetupImpl (MethodDefinition caller)
		{
			if (setupblock_def == null) {
				var type = LinkContext.Target.ProductAssembly.MainModule.GetType (Namespaces.ObjCRuntime, "BlockLiteral");
				foreach (var method in type.Methods) {
					if (method.Name != "SetupBlockImpl")
						continue;
					setupblock_def = method;
					break;
				}
				if (setupblock_def == null)
					throw new NotImplementedException ();
			}
			return caller.Module.ImportReference (setupblock_def);
		}

		LinkerOptions Options { get; set; }

		bool ApplyIntPtrSizeOptimization { get; set; }

		protected override void Process (AssemblyDefinition assembly)
		{
			// The "get_Size" is a performance (over size) optimization.
			// It always makes sense for plaftorm assemblies because:
			// * Xamarin.TVOS.dll only ship the 64 bits code paths (all 32 bits code is extra weight better removed)
			// * Xamarin.WatchOS.dll only ship the 32 bits code paths (all 64 bits code is extra weight better removed)
			// * Xamarin.iOS.dll  ship different 32/64 bits versions of the assembly anyway (nint... support)
			//   Each is better to be optimized (it will be smaller anyway)
			//
			// However for fat (32/64) apps (i.e. iOS only right now) the optimization can duplicate the assembly
			// (metadata) for 3rd parties binding projects, increasing app size for very minimal performance gains.
			// For non-fat apps (the AppStore allows 64bits only iOS apps) then it's better to be applied
			//
			// TODO: we could make this an option "optimize for size vs optimize for speed" in the future
			ApplyIntPtrSizeOptimization = ((Profile.Current as BaseProfile).ProductAssembly == assembly.Name.Name) || !IsDualBuild;
			base.Process (assembly);
		}

		protected override void Process (TypeDefinition type)
		{
			if (!HasGeneratedCode)
				return;

			isdirectbinding_check_required = type.IsDirectBindingCheckRequired (LinkContext);
			base.Process (type);
		}

		protected override void Process (MethodDefinition method)
		{
			// special processing on generated methods from NSObject-inherited types
			// it would be too risky to apply on user-generated code
			if (!method.HasBody || !method.IsGeneratedCode (LinkContext) || (!IsExtensionType && !IsExport (method)))
				return;
			
			var instructions = method.Body.Instructions;
			for (int i = 0; i < instructions.Count; i++) {
				switch (instructions [i].OpCode.Code) {
				case Code.Call:
					i += ProcessCalls (method, i);
					break;
				case Code.Ldsfld:
					ProcessLoadStaticField (method, i);
					break;
				// for classic only (this is a property in unified)
				case Code.Ldfld:
					if (!isdirectbinding_check_required)
						ProcessLoadField (method, i);
					break;
				}
			}
		}

		TypeReference InflateType (GenericInstanceType git, TypeReference type)
		{
			var gt = type as GenericParameter;
			if (gt != null)
				return git.GenericArguments [gt.Position];
			if (type is TypeSpecification)
				throw new NotImplementedException ();
			return type;
		}

		MethodReference InflateMethod (TypeReference inflatedDeclaringType, MethodDefinition method)
		{
			var git = inflatedDeclaringType as GenericInstanceType;
			if (git == null)
				return method;
			var mr = new MethodReference (method.Name, InflateType (git, method.ReturnType), git);
			if (method.HasParameters) {
				for (int i = 0; i < method.Parameters.Count; i++) {
					var p = new ParameterDefinition (method.Parameters [i].Name, method.Parameters [i].Attributes, InflateType (git, method.Parameters [i].ParameterType));
					mr.Parameters.Add (p);
				}
			}
			return mr;
		}

		// returns the number of instructions added (if positive) or removed (if negative)
		int ProcessCalls (MethodDefinition caller, int i)
		{
			var instructions = caller.Body.Instructions;
			Instruction ins = instructions [i];
			var mr = ins.Operand as MethodReference;
			// if it could not be resolved to a definition then it won't be NSObject
			if (mr == null)
				return 0;

			switch (mr.Name) {
			case "SetupBlock":
			case "SetupBlockUnsafe":
				if (!mr.DeclaringType.Is (Namespaces.ObjCRuntime, "BlockLiteral"))
					return 0;
				var prev = ins.Previous;
				if (prev.OpCode.StackBehaviourPop != StackBehaviour.Pop0) {
					Driver.Log (1, "Failed to optimize {0} at index {1}: expected previous instruction to be Pop0, but got {2}", caller, i, prev.OpCode);
					return 0;
				} else if (prev.OpCode.StackBehaviourPush != StackBehaviour.Push1) {
					Driver.Log (1, "Failed to optimize {0} at index {1}: expected previous instruction to be Push1, but got {2}", caller, i, prev.OpCode);
					return 0;
				}
				prev = prev.Previous;
				TypeDefinition delegateType = null;

				if (prev.OpCode.StackBehaviourPop != StackBehaviour.Pop0) {
					Driver.Log (1, "Failed to optimize {0} at index {1}: expected second previous instruction to be Pop0, but got {2}", caller, i, prev.OpCode);
					return 0;
				} else if (prev.OpCode.StackBehaviourPush != StackBehaviour.Push1) {
					Driver.Log (1, "Failed to optimize {0} at index {1}: expected second previous instruction to be Push1, but got {2}", caller, i, prev.OpCode);
					return 0;
				} else if (prev.OpCode.Code == Code.Ldsfld) {
					delegateType = ((FieldReference) prev.Operand).Resolve ().FieldType.Resolve ();
				} else {
					Driver.Log (1, "Failed to optimize {0} at index {1}: expected second previous instruction to be Ldsfld, but got {2}", caller, i, prev.OpCode);
					return 0;
				}

				TypeReference userDelegateType = null;
				foreach (var attrib in delegateType.CustomAttributes) {
					var attribType = attrib.Constructor.DeclaringType;
					if (!attribType.Is (Namespaces.ObjCRuntime, "UserDelegateTypeAttribute"))
						continue;
					userDelegateType = attrib.ConstructorArguments [0].Value as TypeReference;
					break;
				}
				bool blockSignature;
				MethodReference userMethod = null;
				if (userDelegateType != null) {
					var userDelegateTypeDefinition = userDelegateType.Resolve ();
					MethodDefinition userMethodDefinition = null;
					foreach (var method in userDelegateTypeDefinition.Methods) {
						if (method.Name != "Invoke")
							continue;
						userMethodDefinition = method;
						break;
					}
					if (userMethodDefinition == null)
						throw new NotImplementedException ();
					blockSignature = true;
					userMethod = InflateMethod (userDelegateType, userMethodDefinition);
				} else {
					throw new NotImplementedException ();
				}
				string signature;
				try {
					var parameters = new TypeReference [userMethod.Parameters.Count];
					for (int p = 0; p < parameters.Length; p++)
						parameters [p] = userMethod.Parameters [p].ParameterType;
					signature = LinkContext.Target.StaticRegistrar.ComputeSignature (userMethod.DeclaringType, false, userMethod.ReturnType, parameters, isBlockSignature: blockSignature);
				} catch (Exception e) {
					Driver.Log (1, "Failed to optimize {0} at index {1}: {2}", caller, i, e.Message);
					signature = "BROKEN SIGNATURE"; // FIXME: fix the broken binding
				}

				instructions.Insert (i, Instruction.Create (OpCodes.Ldstr, signature));
				instructions.Insert (i, Instruction.Create (mr.Name == "SetupBlockUnsafe" ? OpCodes.Ldc_I4_0 : OpCodes.Ldc_I4_1));
				ins.Operand = GetBlockSetupImpl (caller);

				Driver.Log (1, "Optimized {0} at index {1}", caller, i);
				return 2;
			case "IsNewRefcountEnabled":
				// note: calling IsNSObject would check inheritance (time consuming)
				if (!mr.DeclaringType.Is (Namespaces.Foundation, "NSObject"))
					return 0;

				Nop (ins);							// call bool MonoTouch.Foundation.NSObject::IsNewRefcountEnabled()
				ins = instructions [++i];			// brtrue IL_x
				while (ins.OpCode.FlowControl != FlowControl.Cond_Branch)
					ins = instructions [++i];		// csc debug IL is quite not optimal as can include an _unneeded_ stloc/ldloc[.x] (ref: #32282)
				Instruction branch_to = (ins.Operand as Instruction);
				while (ins != branch_to) {
					//Console.WriteLine ("\t\t{0}", ins.OpCode.Code);
					Nop (ins);						// for getters: ldarg.0 + ldloc.0 + stfld
					ins = instructions [++i];		// for setters: ldarg.0 + ldarg.1 + stfld
				}
				break;
			case "EnsureUIThread":
				if (EnsureUIThread || !mr.DeclaringType.Is (Namespaces.UIKit, "UIApplication"))
					return 0;
#if DEBUG
				Console.WriteLine ("\t{0} EnsureUIThread {1}", caller, EnsureUIThread);
#endif						
				Nop (ins);								// call void MonoTouch.UIKit.UIApplication::EnsureUIThread()
				break;
			case "get_Size":
				if (!ApplyIntPtrSizeOptimization)
					return 0;
				// This will optimize code of following code:
				// if (IntPtr.Size == 8) { ... } else { ... }

				// only if we're linking bindings with architecture specific code paths
				if (!mr.DeclaringType.Is ("System", "IntPtr"))
					return 0;

				if (!(ins.Next.OpCode == OpCodes.Ldc_I4_8 && (ins.Next.Next.OpCode == OpCodes.Bne_Un || ins.Next.Next.OpCode == OpCodes.Bne_Un_S)))
					return 0;
#if DEBUG
				Console.WriteLine ("\t{0} get_Size {1} bits", caller, Arch * 8);
#endif

				// remove conditon check
				Nop (ins);								// call int32 [mscorlib]System.IntPtr::get_Size()
				ins = instructions [++i];
				if (ins.OpCode.Code != Code.Ldc_I4_8) {
#if DEBUG
					Console.WriteLine ("Unexpected code sequence for get_Size: {0}", ins);
#endif
					break; // unexpected code sequence, bail out
				}
				Nop (ins);								// ldc.i4.8
				ins = instructions [++i];
				Instruction bne = (ins.Operand as Instruction);
				if (ins.OpCode.Code != Code.Bne_Un && ins.OpCode.Code != Code.Bne_Un_S) {
#if DEBUG
					Console.WriteLine ("Unexpected code sequence for get_Size: {0}", ins);
#endif
					break; // unexpected code sequence, bail out
				}
				Nop (ins);								// bne.un XXXX
				// remove unused branch
				if (Arch == 8) {
					ins = bne;
					var end = bne.Previous.Operand as Instruction;
#if DEBUG
					if (end == null)
						Console.WriteLine ();
#endif
					// keep 64 bits branch and remove 32 bits branch
					while (ins != end && ins.OpCode.Code != Code.Ret && ins.OpCode.Code != Code.Leave && ins.OpCode.Code != Code.Leave_S) {
						Nop (ins);
						ins = ins.Next;
					}
				} else {
					// keep 32 bits branch and remove 64 bits branch
					ins = instructions [++i];
					bne = bne.Previous;
					while (ins != bne) {
						Nop (ins);
						ins = instructions [++i];
					}
					Nop (ins);
				}
				break;
			case "get_IsDirectBinding":
				// Unified use a property (getter) to check the condition (while Classic used a field)
				if (isdirectbinding_check_required)
					return 0;
				if (!mr.DeclaringType.Is (Namespaces.Foundation, "NSObject"))
					return 0;
#if DEBUG
				Console.WriteLine ("NSObject.get_IsDirectBinding called inside {0}", caller);
#endif
				ProcessIsDirectBinding (caller, ins);
				break;
			}

			return 0;
		}

		static bool IsField (Instruction ins, string nspace, string type, string field)
		{
			FieldReference fr = (ins.Operand as FieldReference);
			if (fr.Name != field)
				return false;
			return fr.DeclaringType.Is (nspace, type);
		}
				
		// https://app.asana.com/0/77259014252/77812690163
		void ProcessLoadStaticField (MethodDefinition caller, int i)
		{
			var instructions = caller.Body.Instructions;
			Instruction ins = instructions [i];
			if (!IsField (ins, Namespaces.ObjCRuntime, "Runtime", "Arch"))
				return;
#if DEBUG
			Console.WriteLine ("Runtime.Arch checked inside {0}", caller);
#endif
			Nop (ins);									// ldsfld valuetype MonoTouch.ObjCRuntime.Arch MonoTouch.ObjCRuntime::Arch
			ins = instructions [++i];
			Instruction branch_to = null;
			if (Device) {
				// a direct brtrue IL_x (optimal) or a longer sequence to compare (likely csc without /optimize)
				while (ins.OpCode.FlowControl != FlowControl.Cond_Branch) {
					Nop (ins);
					ins = instructions [++i];
				}
				Instruction start = (ins.Operand as Instruction);
				Nop (ins);								// brtrue IL_x
				ins = start;
				branch_to = (ins.Previous.Operand as Instruction);
			} else {
				branch_to = (ins.Operand as Instruction);
			}
			// remove unused (device or simulator) block
			while (ins != branch_to) {
				Nop (ins);
				ins = ins.Next;
			}
		}

		// this optimization only works on classic - where IsDirectBinding was a field (not a property)
		// https://app.asana.com/0/77259014252/108629697657
		static void ProcessLoadField (MethodDefinition caller, int i)
		{
			var instructions = caller.Body.Instructions;
			Instruction ins = instructions [i];
			if (!IsField (ins, Namespaces.Foundation, "NSObject", "IsDirectBinding"))
				return;

#if DEBUG
			Console.WriteLine ("NSObject.IsDirectBinding checked inside {0}", caller);
#endif
			ProcessIsDirectBinding (caller, ins);
		}

		static void ProcessIsDirectBinding (MethodDefinition caller, Instruction ins)
		{
			Nop (ins.Previous);					// ldarg.0
			Nop (ins);						// ldfld MonoTouch.Foundation.IsDirectBinding
			Instruction next = ins.Next;				// brfalse IL_x (SuperHandle processing)
			Instruction end = null;
			// unoptimized compiled code can produce a (unneeded) store/load combo
			while (next.OpCode.FlowControl != FlowControl.Cond_Branch) {
				Nop (next);
				next = next.Next;
			}
			ins = (next.Operand as Instruction).Previous;		// br end (ret)
			if (ins.OpCode.Code == Code.Ret) {			// if there's not branch but it returns immediately then do not remove the 'ret' instruction
				ins = ins.Next;
				end = (ins.Operand as Instruction);		// ret
			} else if (ins.OpCode.Code == Code.Leave) {		// if there's a try/catch, e.g. for a using like "using (x = new NSAutoreleasePool ())"
				ins = ins.Next;
				end = caller.Body.ExceptionHandlers [0].TryEnd;	// leave
			} else {
				end = (ins.Operand as Instruction);		// ret
			}
			Nop (next);
			while (ins != end) {					// remove the 'else' branch
				Nop (ins);
				ins = ins.Next;
			}
		}
	}
}