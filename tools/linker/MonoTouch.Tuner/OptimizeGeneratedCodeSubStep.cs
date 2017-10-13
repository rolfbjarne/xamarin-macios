// Copyright 2012-2014, 2016 Xamarin Inc. All rights reserved.
//#define TRACE
using System;
using Mono.Tuner;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Xamarin.Linker;
using Xamarin.Bundler;

namespace MonoTouch.Tuner
{

	public class OptimizeGeneratedCodeSubStep : CoreOptimizeGeneratedCode
	{

		bool? isdirectbinding_constant;

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
			// It always makes sense for platform assemblies because:
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
			if (!HasOptimizableCode)
				return;

			isdirectbinding_constant = type.IsNSObject (LinkContext) ? type.GetIsDirectBindingConstant (LinkContext) : null;
			base.Process (type);
		}

		protected override void Process (MethodDefinition method)
		{
			if (!method.HasBody)
				return;

			if (method.IsOptimizableCode (LinkContext)) {
				// We optimize methods that have the [LinkerOptimize] attribute,
			} else if (method.IsGeneratedCode (LinkContext) && (IsExtensionType || IsExport (method))) {
				// or that have the [GeneratedCodeAttribute] and is either an extension type or an exported method
			} else {
				// but it would be too risky to apply on user-generated code
				Console.WriteLine ($"Not optimizable: {method.FullName}");
				if (method.Name == "LookupClass" && method.DeclaringType.Name == "Class")
					Console.WriteLine ("STA");
				return; 
			}

			var instructions = method.Body.Instructions;
			for (int i = 0; i < instructions.Count; i++) {
				switch (instructions [i].OpCode.Code) {
				case Code.Call:
					i += ProcessCalls (method, i);
					break;
				case Code.Ldsfld:
					ProcessLoadStaticField (method, i);
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

		bool IsSubclassed (TypeDefinition type, TypeDefinition byType)
		{
			if (byType.Is (type.Namespace, type.Name))
				return true;
			if (byType.HasNestedTypes) {
				foreach (var ns in byType.NestedTypes) {
					if (IsSubclassed (type, ns))
						return true;
				}
			}
			return false;
		}

		bool IsSubclassed (TypeDefinition type)
		{
			foreach (var a in context.GetAssemblies ()) {
				foreach (var s in a.MainModule.Types) {
					if (IsSubclassed (type, s))
						return true;
				}
			}
			return false;
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
					Driver.Log (0, "Failed to optimize {0} at index {1}: could not find the UserDelegateTypeAttribute on {2}", caller, i, delegateType.FullName);
					return 0;
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

				Driver.Log (1, "Optimized {0} at index {1} with delegate type {2}", caller, i, delegateType.FullName);

				return 2;
			case "IsNewRefcountEnabled":
				// note: calling IsNSObject would check inheritance (time consuming)
				if (!mr.DeclaringType.Is (Namespaces.Foundation, "NSObject"))
					return 0;

				if (!ValidateInstruction (caller, ins, "inline NSObject.IsNewRefcountEnabled", Code.Call))
					return 0;

				if (!InlineBranchCondition (caller, "inline NSObject.IsNewRefcountEnabled", ins.Next, true))
					return 0;

				Nop (ins); // call bool Foundation.NSObject::IsNewRefcountEnabled()
				break;
			case "EnsureUIThread":
				if (EnsureUIThread || !mr.DeclaringType.Is (Namespaces.UIKit, "UIApplication"))
					return 0;
#if DEBUG
				Console.WriteLine ("\t{0} EnsureUIThread {1}", caller, EnsureUIThread);
#endif
				Nop (ins);                                                              // call void MonoTouch.UIKit.UIApplication::EnsureUIThread()
				break;
			case "get_Size":
				if (!ApplyIntPtrSizeOptimization)
					return 0;
				// This will optimize code of following code:
				// if (IntPtr.Size == 8) { ... } else { ... }

				// only if we're linking bindings with architecture specific code paths
				if (!mr.DeclaringType.Is ("System", "IntPtr"))
					return 0;

#if DEBUG
				Console.WriteLine ("\t{0} get_Size {1} bits", caller, Arch * 8);
#endif

				const string operation = "inline IntPtr.Size";
				if (!ValidateInstruction (caller, ins.Next, operation, Code.Ldc_I4_8))
					return 0;

				var branchInstruction = ins.Next.Next;
				if (!ValidateInstruction (caller, branchInstruction, operation, Code.Bne_Un, Code.Bne_Un_S))
					return 0;

				if (!InlineBranchCondition (caller, operation, branchInstruction, Arch == 8))
					return 0;

				// Clearing the branch succeeded, so clear the condition too
				Nop (ins);      // call int32 [mscorlib]System.IntPtr::get_Size()
				Nop (ins.Next); // ldc.i4.8
				break;
			case "get_IsDirectBinding":
				// Unified use a property (getter) to check the condition (while Classic used a field)
				if (!isdirectbinding_constant.HasValue)
					return 0;
				if (!mr.DeclaringType.Is (Namespaces.Foundation, "NSObject"))
					return 0;
#if DEBUG
				Console.WriteLine ("NSObject.get_IsDirectBinding called inside {0}", caller);
#endif
				ProcessIsDirectBinding (caller, ins, isdirectbinding_constant.Value);
				break;
			case "get_DynamicRegistrationSupported":
				if (LinkContext.DynamicRegistrationSupported)
					return 0;
				
				if (!mr.DeclaringType.Is (Namespaces.ObjCRuntime, "Runtime"))
					return 0;
				
				ProcessIsDynamicSupported (caller, ins, false);
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

		void ProcessIsDynamicSupported (MethodDefinition caller, Instruction ins, bool value)
		{
			const string operation = "inline Runtime.IsDynamicSupported";
			if (!ValidateInstruction (caller, ins, operation, Code.Call))
				return;

			var insBranch = ins.Next;
			if (!InlineBranchCondition (caller, operation, insBranch, value))
				return;

			// Clearing the branch succeeded, so clear the condition too
			Nop (ins);           // call void ObjCRuntime.Runtime::get_IsDynamicSupported()

#if TRACE
			Console.WriteLine ($"{caller} after inlining Runtime.IsDynamicSupported=false:");
			Console.WriteLine (string.Join<Instruction> ("\n", caller.Body.Instructions.ToArray ()));
#endif
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
			if (!ValidateInstruction (caller, ins, "inline Runtime.Arch", Code.Ldsfld))
				return;

			// Runtime.DEVICE = 0
			// Runtime.SIMULATOR = 1
			// Simulator: true
			if (!InlineBranchCondition (caller, "inline Runtime.Arch", ins.Next, !Device))
				return;

			// Clearing the branch succeeded, so clear the condition too
			Nop (ins); // ldsfld valuetype ObjCRuntime.Arch ObjCRuntime::Arch
		}

		static void ProcessIsDirectBinding (MethodDefinition caller, Instruction ins, bool value)
		{
			const string operation = "inline IsDirectBinding";
			if (!ValidateInstruction (caller, ins.Previous, operation, Code.Ldarg_0))
				return;
			if (!ValidateInstruction (caller, ins, operation, Code.Call))
				return;

			var insBranch = ins.Next;
			if (!InlineBranchCondition (caller, operation, insBranch, value))
				return;

			// Clearing the branch succeeded, so clear the condition too
			Nop (ins.Previous);  // ldarg.0
			Nop (ins);           // call System.Boolean Foundation.NSObject::get_IsDirectBinding()

#if TRACE
			Console.WriteLine ($"{caller} after inlining IsDirectBinding={value}:");
			Console.WriteLine (string.Join<Instruction> ("\n", caller.Body.Instructions.ToArray ()));
#endif
		}


		static bool ValidateInstruction (MethodDefinition caller, Instruction ins, string operation, Code expected)
		{
			if (ins.OpCode.Code != expected) {
				Driver.Log (1, "Could not {4} call in {0} at offset {1}, expected {2} got {3}", caller, ins.Offset, expected, ins, operation);
				return false;
			}

			return true;
		}

		static bool ValidateInstruction (MethodDefinition caller, Instruction ins, string operation, params Code [] expected)
		{
			foreach (var code in expected) {
				if (ins.OpCode.Code == code)
					return true;
			}

			Driver.Log (1, "Could not {3} call in {0} at offset {1}, expected {2} got {3}", caller, ins.Offset, expected, ins, operation);
			return false;
		}

		// Calculate the code blocks for both the true and false portion of a branch instruction.
		// Example:
		//   IL_0  brfalse IL_4
		//   IL_1  <true code block>
		//   IL_2  <true code block>
		//   IL_3  br IL_6
		//   IL_4  <false code block>
		//   IL_5  <false code block>
		//   IL_6  ret
		// equivalent to the following
		//   if (condition) {
		//     <true code block>
		//   } else {
		//     <false code block>
		//   }
		// return the ranges
		//    insTrueFirst: IL_1
		//    insTrueLast: IL_2
		//    insFalseFirst: IL_4
		//    insFalseLast: IL_5
		// 
		// The ins*Last instructions will be null if this is a condition without an 'else' block.
		static bool GetBranchRange (MethodDefinition caller, Instruction insBranch, string operation, out Instruction insTrueFirst, out Instruction insTrueLast, out Instruction insFalseFirst, out Instruction insFalseLast)
		{
			insTrueFirst = null;
			insTrueLast = null;
			insFalseFirst = null;
			insFalseLast = null;

			if (!ValidateInstruction (caller, insBranch, operation, Code.Brfalse, Code.Brfalse_S, Code.Brtrue, Code.Brtrue_S, Code.Bne_Un, Code.Bne_Un_S))
				return false;

			var branchTarget = (Instruction) insBranch.Operand;
			Instruction endTarget;

#if TRACE
			Console.WriteLine ($"{caller}");
			Console.WriteLine (string.Join<Instruction> ("\n", caller.Body.Instructions.ToArray ()));
#endif

			switch (branchTarget.Previous.OpCode.Code) {
			case Code.Br:
			case Code.Br_S:
				endTarget = (Instruction) branchTarget.Previous.Operand;
				endTarget = endTarget.Previous;
				break;
			case Code.Ret:
				endTarget = caller.Body.Instructions [caller.Body.Instructions.Count - 1];
				endTarget = endTarget.Previous;
				break;
			case Code.Leave:
				if (caller.Body.ExceptionHandlers.Count != 1) {
					Driver.Log (1, "Could not {3} call in {0} at offset {1} because there are not exactly 1 exception handlers (found {2})", caller, insBranch.Offset, caller.Body.ExceptionHandlers.Count, operation);
					return false;
				}
				endTarget = caller.Body.ExceptionHandlers [0].TryEnd;
				break;
			case Code.Call:
			case Code.Stsfld:
				// condition without 'else' clause
				// there are a lot more instructions that can go into this case statement, but keep a whitelist for now.
				endTarget = null;
				break;
			default:
				throw new NotImplementedException (branchTarget.Previous.ToString ());
			}
			switch (insBranch.OpCode.Code) {
			case Code.Brfalse:
			case Code.Brfalse_S:
			case Code.Bne_Un:
			case Code.Bne_Un_S:
				insTrueFirst = insBranch.Next;
				insTrueLast = branchTarget.Previous;
				insFalseFirst = branchTarget;
				insFalseLast = endTarget;
				break;
			case Code.Brtrue:
			case Code.Brtrue_S:
				insFalseFirst = insBranch.Next;
				insFalseLast = branchTarget.Previous;
				insTrueFirst = branchTarget;
				insTrueLast = endTarget;
				break;
			default:
				throw new NotImplementedException ();
			}

#if TRACE
			Console.WriteLine ($"Branch at offset {insBranch.Offset}:");
			Console.WriteLine ($"    True branch first/last:");
			Console.WriteLine ($"        {insTrueFirst}");
			Console.WriteLine ($"        {insTrueLast}");
			Console.WriteLine ($"    False branch first/last:");
			Console.WriteLine ($"        {insFalseFirst}");
			Console.WriteLine ($"        {insFalseLast}");
#endif
			return true;

		}

		// This method will clear out (Nop) the failing code block, depending on the constant value 'value'.
		// insBranch must be a conditional branch instruction (brtrue/brfalse).
		// The caller must clear out the instructions that calculates the value loaded on the stack for the branch instruction.
		static bool InlineBranchCondition (MethodDefinition caller, string operation, Instruction insBranch, bool constantValue)
		{
			Instruction insTrueFirst;
			Instruction insTrueLast;
			Instruction insFalseFirst;
			Instruction insFalseLast;
			if (!GetBranchRange (caller, insBranch, operation, out insTrueFirst, out insTrueLast, out insFalseFirst, out insFalseLast))
				return false;

			Instruction first = !constantValue ? insTrueFirst : insFalseFirst;
			Instruction last = !constantValue ? insTrueLast : insFalseLast;

			if (last == null) {
				// This is a condition without an 'else' block, and the 'else' block is the one we'd remove, which means there's nothing to do.
				return true;
			}
			
			// We have the information we need, now we can start clearing instructions
			Nop (insBranch);
			Instruction current = first;
			do {
				Nop (current);
				if (current == last)
					break;
				current = current.Next;
			} while (true);
			return true;
		}
	}
}