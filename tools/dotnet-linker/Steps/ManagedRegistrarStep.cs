using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

using Xamarin.Bundler;
using Xamarin.Utils;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;

using Registrar;
using System.Globalization;

#nullable enable

namespace Xamarin.Linker {
	public class AssemblyTrampolineInfos : Dictionary<AssemblyDefinition, AssemblyTrampolineInfo>
	{
		Dictionary<MethodDefinition, TrampolineInfo>? map;
		public bool TryFindInfo (MethodDefinition method, [NotNullWhen (true)] out TrampolineInfo? info)
		{
			if (map is null) {
				map = new Dictionary<MethodDefinition, TrampolineInfo> ();
				foreach (var kvp in this) {
					foreach (var ai in kvp.Value) {
						map.Add (ai.Target, ai);
					}
				}
			}
			return map.TryGetValue (method, out info);
		}
	}

	public class AssemblyTrampolineInfo : List<TrampolineInfo>
	{
		Dictionary<TypeDefinition, uint> registered_type_map = new ();

		public TypeDefinition? RegistrarType;

		public void RegisterType (TypeDefinition td, uint index)
		{
			registered_type_map.Add (td, index);
		}

		public bool TryGetRegisteredTypeIndex (TypeDefinition td, out uint index)
		{
			return registered_type_map.TryGetValue (td, out index);
		}

		public void SetIds ()
		{
			for (var i = 0; i < Count; i++)
				this [i].Id = i;
		}
	}

	public class TrampolineInfo {
		public MethodDefinition Trampoline;
		public MethodDefinition Target;
		public string UnmanagedCallersOnlyEntryPoint;
		public int Id;

		public TrampolineInfo (MethodDefinition trampoline, MethodDefinition target, string entryPoint)
		{
			this.Trampoline = trampoline;
			this.Target = target;
			this.UnmanagedCallersOnlyEntryPoint = entryPoint;
			this.Id = -1;
		}
	}
	
	public class ManagedRegistrarStep : ConfigurationAwareStep {
		protected override string Name { get; } = "ManagedRegistrar";
		protected override int ErrorCode { get; } = 2430;

		List<Exception> exceptions = new List<Exception> ();

		AppBundleRewriter abr { get { return Configuration.AppBundleRewriter; } }

		void AddException (Exception exception)
		{
			if (exceptions is null)
				exceptions = new List<Exception> ();
			exceptions.Add (exception);
		}

		protected override void TryProcess ()
		{
			base.TryProcess ();

			App.SelectRegistrar ();
			if (App.Registrar != RegistrarMode.ManagedStatic)
				return;
			
			Configuration.Target.StaticRegistrar.Register (Configuration.GetNonDeletedAssemblies (this));
		}

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			if (App.Registrar != RegistrarMode.ManagedStatic)
				return;

			if (exceptions is null)
				return;
			var warnings = exceptions.Where (v => (v as ProductException)?.Error == false).ToArray ();
			if (warnings.Length == exceptions.Count)
				return;

			if (exceptions.Count == 1)
				throw exceptions [0];
			throw new AggregateException (exceptions);
		}

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			base.TryProcessAssembly (assembly);

			if (App.Registrar != RegistrarMode.ManagedStatic)
				return;

			if (Annotations.GetAction (assembly) == AssemblyAction.Delete)
				return;

			// No SDK assemblies will have anything we need to register
			if (Configuration.Profile.IsSdkAssembly (assembly))
				return;

			if (!assembly.MainModule.HasAssemblyReferences)
				return;

			// In fact, unless an assembly references our platform assembly, then it won't have anything we need to register
			if (!Configuration.Profile.IsProductAssembly (assembly) && !assembly.MainModule.AssemblyReferences.Any (v => Configuration.Profile.IsProductAssembly (v.Name)))
				return;

			if (!assembly.MainModule.HasTypes)
				return;

			abr.SetCurrentAssembly (assembly);

			if (assembly == abr.PlatformAssembly) {
				Annotations.Mark (abr.System_Diagnostics_CodeAnalysis_DynamicallyAccessedMemberTypes.Resolve ());
			}

			var current_trampoline_lists = new AssemblyTrampolineInfo ();
			Configuration.AssemblyTrampolineInfos [assembly] = current_trampoline_lists;

			var modified = false;
			foreach (var type in assembly.MainModule.Types)
				modified |= ProcessType (type, current_trampoline_lists);

			// Make sure the linker saves any changes in the assembly.
			if (modified) {
				DerivedLinkContext.Annotations.SetCustomAnnotation ("ManagedRegistrarStep", assembly, current_trampoline_lists);
				Save (assembly);
			}

			abr.ClearCurrentAssembly ();
		}

		void Save (AssemblyDefinition assembly)
		{
			var action = Context.Annotations.GetAction (assembly);
			if (action == AssemblyAction.Copy)
				Context.Annotations.SetAction (assembly, AssemblyAction.Save);
		}

		bool ProcessType (TypeDefinition type, AssemblyTrampolineInfo infos)
		{
			var modified = false;
			if (type.HasNestedTypes) {
				foreach (var nested in type.NestedTypes)
					modified |= ProcessType (nested, infos);
			}

			var process = false;

			process |= IsNSObject (type);
			process |= StaticRegistrar.GetCategoryAttribute (type) is not null;

			var registerAttribute = StaticRegistrar.GetRegisterAttribute (type);
			if (registerAttribute is not null && registerAttribute.IsWrapper)
				return modified;

			if (!process)
				return modified;

			var methods_to_wrap = new HashSet<MethodDefinition> ();
			if (type.HasMethods) {
				foreach (var method in type.Methods)
					ProcessMethod (method, methods_to_wrap);
			}

			if (type.HasProperties) {
				foreach (var prop in type.Properties) {
					ProcessProperty (prop, methods_to_wrap);
				}
			}

			foreach (var method in methods_to_wrap) {
				try {
					CreateUnmanagedCallersMethod (method, infos);
				} catch (Exception e) {
					Console.WriteLine (e);
					AddException (ErrorHelper.CreateError (99, e, "Failed process {0}: {1}", method.FullName, e.Message));
				}
			}

			return true;
		}

		void ProcessMethod (MethodDefinition method, HashSet<MethodDefinition> methods_to_wrap)
		{
			if (!(method.IsConstructor && !method.IsStatic)) {
				var ea = StaticRegistrar.GetExportAttribute (method);
				if (ea is null && !method.IsVirtual)
					return;
			}

			if (!StaticRegistrar.TryFindMethod (method, out _)) {
				Console.WriteLine ("Could not find method {0}, so no generating trampoline.", GetMethodSignature (method));
				return;
			}

			methods_to_wrap.Add (method);
		}

		void ProcessProperty (PropertyDefinition property, HashSet<MethodDefinition> methods_to_wrap)
		{
			var ea = StaticRegistrar.GetExportAttribute (property);
			if (ea is null)
				return;

			if (property.GetMethod is not null)
				methods_to_wrap.Add (property.GetMethod);

			if (property.SetMethod is not null)
				methods_to_wrap.Add (property.SetMethod);
		}

		static string Sanitize (string str)
		{
			str = str.Replace ('.', '_');
			str = str.Replace ('/', '_');
			str = str.Replace ('`', '_');
			str = str.Replace ('<', '_');
			str = str.Replace ('>', '_');
			str = str.Replace ('$', '_');
			str = str.Replace ('@', '_');
			str = StaticRegistrar.EncodeNonAsciiCharacters (str);
			str = str.Replace ('\\', '_');
			return str;
		}

		void Trace (ILProcessor il, string message)
		{
			var trace = !string.IsNullOrEmpty (Environment.GetEnvironmentVariable ("MSR_TRACE"));
			if (trace) {
				il.Emit (OpCodes.Ldstr, message);
				il.Emit (OpCodes.Call, abr.Runtime_TraceCaller);
			}
		}

		int counter;
		void CreateUnmanagedCallersMethod (MethodDefinition method, AssemblyTrampolineInfo infos)
		{
			var baseMethod = StaticRegistrar.GetBaseMethodInTypeHierarchy (method);
			var placeholderType = abr.System_IntPtr;
			var initialExceptionCount = exceptions.Count;
			ParameterDefinition? callSuperParameter = null;
			VariableDefinition? returnVariable = null;
			var leaveTryInstructions = new List<Instruction> ();
			var isVoid = method.ReturnType.Is ("System", "Void");

			var name = $"callback_{counter++}_{Sanitize (method.DeclaringType.FullName)}_{Sanitize (method.Name)}";

			var callbackType = method.DeclaringType.NestedTypes.SingleOrDefault (v => v.Name == "__Registrar_Callbacks__");
			if (callbackType is null) {
				callbackType = new TypeDefinition (string.Empty, "__Registrar_Callbacks__", TypeAttributes.NestedPrivate | TypeAttributes.Sealed | TypeAttributes.Class);
				callbackType.BaseType = abr.System_Object;
				method.DeclaringType.NestedTypes.Add (callbackType);
				DerivedLinkContext.Annotations.Mark (callbackType);
			}

			var callback = callbackType.AddMethod (name, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig, placeholderType);
			callback.CustomAttributes.Add (CreateUnmanagedCallersAttribute (name));
			// var entry = new LinkerConfiguration.UnmanagedCallersEntry (name, Configuration.UnmanagedCallersMap.Count, callback);
			// Configuration.UnmanagedCallersMap.Add (method, entry);
			infos.Add (new TrampolineInfo (callback, method, name));

			DerivedLinkContext.Annotations.Mark (callback);
			DerivedLinkContext.Annotations.AddPreservedMethod (method, callback);
			DerivedLinkContext.Annotations.AddPreservedMethod (callback, method);
			// method.CustomAttributes.Add (CreateDynamicDependencyAttribute (name));

			// FIXME
			var t = method.DeclaringType;
			while (t.IsNested) {
				t.IsNestedPublic = true;
				t = t.DeclaringType;
			}
			t.IsPublic = true;
			// END FIXME 

			var body = callback.CreateBody (out var il);
			var placeholderInstruction = il.Create (OpCodes.Nop);
			var placeholderNextInstruction = il.Create (OpCodes.Nop);
			var postProcessing = new List<Instruction> ();
			var categoryAttribute = StaticRegistrar.GetCategoryAttribute (method.DeclaringType);
			var isCategory = categoryAttribute is not null;
			var isInstanceCategory = isCategory && StaticRegistrar.HasThisAttribute (method);
			var isGeneric = method.DeclaringType.HasGenericParameters;
			VariableDefinition? selfVariable = null;
			try {
				Trace (il, $"ENTER");

				if (method.IsConstructor) {
					callback.AddParameter ("pobj", abr.ObjCRuntime_NativeHandle);
				} else {
					callback.AddParameter ("pobj", abr.System_IntPtr);
				}

				if (!isVoid || method.IsConstructor)
					returnVariable = body.AddVariable (placeholderType);

				if (isGeneric) {
					if (method.IsStatic)
						throw new NotImplementedException (); // probably an error?

					il.Emit (OpCodes.Ldtoken, method);
					// il.Emit (OpCodes.Ldtoken, Console_WriteLine); // DUMMY METHOD

					il.Emit (OpCodes.Ldarg_0);
					EmitConversion (method, il, method.DeclaringType, true, -1, out var nativeType, postProcessing, selfVariable);

					selfVariable = body.AddVariable (abr.System_Object);
					il.Emit (OpCodes.Stloc, selfVariable);
					il.Emit (OpCodes.Ldloc, selfVariable);
					// FIXME: throw if null
					// FIXME: can only be NSObject
					il.Emit (OpCodes.Ldtoken, method.DeclaringType);
					il.Emit (OpCodes.Ldtoken, method);
					il.Emit (OpCodes.Call, abr.Runtime_FindClosedMethod);
				}

				if (isInstanceCategory) {
					il.Emit (OpCodes.Ldarg_0);
					EmitConversion (method, il, method.Parameters [0].ParameterType, true, 0, out var nativeType, postProcessing, selfVariable);
				} else if (method.IsStatic) {
					// nothing to do
				} else if (method.IsConstructor) {
					callSuperParameter = new ParameterDefinition ("call_super", ParameterAttributes.None, new PointerType (abr.System_Byte));
					var callAllocateNSObject = il.Create (OpCodes.Ldarg_0);
					// if (Runtime.HasNSObject (p0)) {
					il.Emit (OpCodes.Ldarg_0);
					il.Emit (OpCodes.Call, abr.Runtime_HasNSObject);
					il.Emit (OpCodes.Brfalse, callAllocateNSObject);
					// *call_super = 1;
					il.Emit (OpCodes.Ldarg, callSuperParameter);
					il.Emit (OpCodes.Ldc_I4_1);
					il.Emit (OpCodes.Stind_I1);
					// return rv;
					il.Emit (OpCodes.Ldarg_0);
					il.Emit (OpCodes.Stloc, returnVariable);
					il.Emit (OpCodes.Leave, placeholderInstruction);
					// }
					leaveTryInstructions.Add (il.Body.Instructions.Last ());

					var git = new GenericInstanceMethod (abr.NSObject_AllocateNSObject);
					git.GenericArguments.Add (method.DeclaringType);
					il.Append (callAllocateNSObject); // ldarg_0
					il.Emit (OpCodes.Ldc_I4_2); // NSObject.Flags.NativeRef
					il.Emit (OpCodes.Call, git);
					il.Emit (OpCodes.Dup); // this is for the call to ObjCRuntime.NativeObjectExtensions::GetHandle after the call to the constructor
				} else {
					// instance method
					il.Emit (OpCodes.Ldarg_0);
					EmitConversion (method, il, method.DeclaringType, true, -1, out var nativeType, postProcessing, selfVariable);
					//if (nativeType != callback.Parameters [0].ParameterType)
					//	AddException (ErrorHelper.CreateWarning (99, "Unexpected parameter type for the first parameter. Expected {0}, got {1}. Method: {2}", callback.Parameters [0].ParameterType.FullName, nativeType?.FullName, GetMethodSignatureWithSourceCode (method)));
				}

				callback.AddParameter ("sel", abr.System_IntPtr);

				var managedParameterCount = 0;
				var nativeParameterOffset = isInstanceCategory ? 1 : 2;
				var parameterStart = isInstanceCategory ? 1 : 0;
				if (method.HasParameters)
					managedParameterCount = method.Parameters.Count;

				if (isGeneric) {
					il.Emit (OpCodes.Ldc_I4, managedParameterCount);
					il.Emit (OpCodes.Newarr, abr.System_Object);
				}

				if (method.HasParameters) {
					var isDynamicInvoke = isGeneric;
					for (var p = parameterStart; p < managedParameterCount; p++) {
						var nativeParameter = callback.AddParameter ($"p{p}", placeholderType);
						var nativeParameterIndex = p + nativeParameterOffset;
						var managedParameterType = method.Parameters [p].ParameterType;
						var baseParameter = baseMethod.Parameters [p];
						var isOutParameter = IsOutParameter (method, p, baseParameter);
						if (isDynamicInvoke && !isOutParameter) {
							if (parameterStart != 0)
								throw new NotImplementedException ("parameterStart");
							il.Emit (OpCodes.Dup);
							il.Emit (OpCodes.Ldc_I4, p);
						}
						if (!isOutParameter) {
							il.EmitLoadArgument (nativeParameterIndex);
						}
						if (EmitConversion (method, il, managedParameterType, true, p, out var nativeType, postProcessing, selfVariable, isOutParameter, nativeParameterIndex, isDynamicInvoke)) {
							nativeParameter.ParameterType = nativeType;
						} else {
							nativeParameter.ParameterType = placeholderType;
							AddException (ErrorHelper.CreateError (99, "Unable to emit conversion for parameter {2} of type {0}. Method: {1}", method.Parameters [p].ParameterType, GetMethodSignatureWithSourceCode (method), p));
						}
						if (isDynamicInvoke && !isOutParameter) {
							if (managedParameterType.IsValueType)
								il.Emit (OpCodes.Box, managedParameterType);
							il.Emit (OpCodes.Stelem_Ref);
						}
					}
				}

				if (callSuperParameter is not null)
					callback.Parameters.Add (callSuperParameter);

				callback.AddParameter ("exception_gchandle", new PointerType (abr.System_IntPtr));

				if (isGeneric) {
					il.Emit (OpCodes.Call, abr.MethodBase_Invoke);
					if (isVoid) {
						il.Emit (OpCodes.Pop);
					} else if (method.ReturnType.IsValueType) {
						il.Emit (OpCodes.Unbox_Any, method.ReturnType);
					} else {
						// il.Emit (OpCodes.Castclass, method.ReturnType);
					}
				} else if (method.IsStatic) {
					il.Emit (OpCodes.Call, method);
				} else {
					il.Emit (OpCodes.Callvirt, method);
				}

				if (returnVariable is not null) {
					if (EmitConversion (method, il, method.ReturnType, false, -1, out var nativeReturnType, postProcessing, selfVariable)) {
						returnVariable.VariableType = nativeReturnType;
						callback.ReturnType = nativeReturnType;
					} else {
						AddException (ErrorHelper.CreateError (99, "Unable to emit conversion for return value of type {0}. Method: {1}", method.ReturnType, GetMethodSignatureWithSourceCode (method)));
					}
					il.Emit (OpCodes.Stloc, returnVariable);
				} else {
					callback.ReturnType = abr.System_Void;
				}

				body.Instructions.AddRange (postProcessing);

				Trace (il, $"EXIT");

				il.Emit (OpCodes.Leave, placeholderInstruction);
				leaveTryInstructions.Add (il.Body.Instructions.Last ());

				AddExceptionHandler (il, returnVariable, placeholderNextInstruction, out var eh, out var leaveEHInstruction);

				// Generate code to return null/default value/void
				if (returnVariable is not null) {
					var returnType = returnVariable.VariableType!;
					if (returnType.IsValueType) {
						// return default(<struct type>)
						il.Emit (OpCodes.Ldloca, returnVariable);
						il.Emit (OpCodes.Initobj, returnType);
						il.Emit (OpCodes.Ldloc, returnVariable);
					} else {
						il.Emit (OpCodes.Ldnull);
					}
				}
				il.Emit (OpCodes.Ret);

				// Generate code to return the return value
				Instruction leaveTryInstructionOperand;
				if (returnVariable is not null) {
					il.Emit (OpCodes.Ldloc, returnVariable);
					leaveTryInstructionOperand = il.Body.Instructions.Last ();
					il.Emit (OpCodes.Ret);
				} else {
					// Here we can re-use the ret instruction from the previous block.
					leaveTryInstructionOperand = il.Body.Instructions.Last ();
				}

				// Replace any 'placeholderNextInstruction' operands with the actual next instruction.
				foreach (var instr in body.Instructions) {
					if (object.ReferenceEquals (instr.Operand, placeholderNextInstruction))
						instr.Operand = instr.Next;
				}

				foreach (var instr in leaveTryInstructions)
					instr.Operand = leaveTryInstructionOperand;
				eh.HandlerEnd = (Instruction) leaveEHInstruction.Operand;

				if (exceptions.Count != initialExceptionCount) {
					var newExceptions = exceptions.Skip (initialExceptionCount);
					body.Instructions.Insert (0, il.Create (OpCodes.Ldstr, $"Conversion not implemented. Exceptions during process:\n\t{string.Join ("\n\t", newExceptions.Select (v => v.ToString ()))}"));
					body.Instructions.Insert (1, il.Create (OpCodes.Newobj, abr.Exception_ctor_String));
					body.Instructions.Insert (2, il.Create (OpCodes.Throw));
					while (body.Instructions [3] != eh.TryEnd)
						body.Instructions.RemoveAt (3);
					exceptions.RemoveRange (initialExceptionCount, exceptions.Count - initialExceptionCount);
				}
			} catch (Exception e) {
				il.Emit (OpCodes.Ldstr, $"Exception occurred while creating trampoline: " + e);
				throw;
			}
		}

		void AddExceptionHandler (ILProcessor il, VariableDefinition? returnVariable, Instruction placeholderNextInstruction, out ExceptionHandler eh, out Instruction leaveEHInstruction)
		{
			var body = il.Body;
			var method = body.Method;

			// Exception handler
			eh = new ExceptionHandler (ExceptionHandlerType.Catch);
			eh.CatchType = abr.System_Exception;
			eh.TryStart = il.Body.Instructions [0];
			il.Body.ExceptionHandlers.Add (eh);

			var exceptionVariable = body.AddVariable (abr.System_Exception);
			il.Emit (OpCodes.Stloc, exceptionVariable);
			eh.HandlerStart = il.Body.Instructions.Last ();
			eh.TryEnd = eh.HandlerStart;
			il.Emit (OpCodes.Ldarg, method.Parameters.Count - 1);
			il.Emit (OpCodes.Ldloc, exceptionVariable);
			il.Emit (OpCodes.Call, abr.Runtime_AllocGCHandle);
			il.Emit (OpCodes.Stind_I);
			Trace (il, $"EXCEPTION");
			il.Emit (OpCodes.Leave, placeholderNextInstruction);
			leaveEHInstruction = body.Instructions.Last ();

			// Generate code to return null/default value/void
			if (returnVariable is not null) {
				var returnType = returnVariable.VariableType!;
				if (returnType.IsValueType) {
					// return default(<struct type>)
					il.Emit (OpCodes.Ldloca, returnVariable);
					il.Emit (OpCodes.Initobj, returnType);
					il.Emit (OpCodes.Ldloc, returnVariable);
				} else {
					il.Emit (OpCodes.Ldnull);
				}
			}
			il.Emit (OpCodes.Ret);
		}

		static string GetMethodSignature (MethodDefinition method)
		{
			return $"{method?.ReturnType?.FullName ?? "(null)"} {method?.DeclaringType?.FullName ?? "(null)"}::{method?.Name ?? "(null)"} ({string.Join (", ", method?.Parameters?.Select (v => v?.ParameterType?.FullName + " " + v?.Name) ?? Array.Empty<string> ())})";
		}

		static string GetMethodSignatureWithSourceCode (MethodDefinition method)
		{
			var rv = GetMethodSignature (method);
			if (method.HasBody && method.DebugInformation.HasSequencePoints) {
				var seq = method.DebugInformation.SequencePoints [0];
				rv += " " + seq.Document.Url + ":" + seq.StartLine.ToString () + " ";
			}
			return rv;
		}

		bool IsNSObject (TypeReference type)
		{
			if (type is ArrayType)
				return false;

			if (type is ByReferenceType)
				return false;

			if (type is PointerType)
				return false;

			if (type is GenericParameter)
				return false;

			return type.IsNSObject (DerivedLinkContext);
		}

		BindAsAttribute? GetBindAsAttribute (MethodDefinition method, int parameter)
		{
			if (StaticRegistrar.IsPropertyAccessor (method, out var property)) {
				return StaticRegistrar.GetBindAsAttribute (property);
			} else {
				return StaticRegistrar.GetBindAsAttribute (method, parameter);
			}
		}

		// This emits a conversion between the native and the managed representation of a parameter or return value,
		// and returns the corresponding native type. The returned nativeType will (must) be a blittable type.
		bool EmitConversion (MethodDefinition method, ILProcessor il, TypeReference type, bool toManaged, int parameter, [NotNullWhen (true)] out TypeReference? nativeType, List<Instruction> postProcessing, VariableDefinition? selfVariable, bool isOutParameter = false, int nativeParameterIndex = -1, bool isDynamicInvoke = false)
		{
			nativeType = null;

			if (!(parameter == -1 && !method.IsStatic && method.DeclaringType == type)) {
				var bindAsAttribute = GetBindAsAttribute (method, parameter);
				if (bindAsAttribute is not null) {
					if (toManaged) {
						// if (parameter != -1) {
						GenerateConversionToManaged (method, il, bindAsAttribute.OriginalType, type, "descriptiveMethodName", parameter, out nativeType);
						return true;
						// }
					} else {
						GenerateConversionToNative (method, il, type, bindAsAttribute.OriginalType, "descriptiveMethodName", out nativeType);
						return true;
					}
				}
			}

			if (type.Is ("System", "Void")) {
				if (parameter == -1 && method.IsConstructor) {
					if (toManaged) {
						AddException (ErrorHelper.CreateError (99, "Don't know how (9) to convert ctor. Method: {0}", GetMethodSignatureWithSourceCode (method)));
					} else {
						il.Emit (OpCodes.Call, abr.NativeObjectExtensions_GetHandle);
						nativeType = abr.ObjCRuntime_NativeHandle;
						return true;
					}
				}
				AddException (ErrorHelper.CreateError (99, "Can't convert System.Void. Method: {0}", GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (type.IsValueType) {
				if (type.Is ("System", "Boolean")) {
					if (toManaged) {
						// nothing to do I think
					} else {
						// FIXME: verify if this sequence is really necessary.
						var ldc_1 = il.Create (OpCodes.Ldc_I4_1);
						var nop = il.Create (OpCodes.Nop);
						il.Emit (OpCodes.Brtrue_S, ldc_1);
						il.Emit (OpCodes.Ldc_I4_0);
						il.Emit (OpCodes.Br_S, nop);
						il.Append (ldc_1);
						il.Append (nop);
					}
					nativeType = abr.System_Byte;
					return true;
				}

				if (type.Is ("System", "Char")) {
					// no conversion necessary either way
					nativeType = abr.System_UInt16;
					return true;
				}

				// no conversion necessary if we're any other value type
				nativeType = type;
				return true;
			}

			if (type is PointerType pt) {
				var elementType = pt.ElementType;
				if (!elementType.IsValueType)
					AddException (ErrorHelper.CreateError (99, "Unexpected pointer type {0}: must be a value type. Method: {1}", type, GetMethodSignatureWithSourceCode (method)));
				// no conversion necessary either way
				nativeType = type;
				return true;
			}

			if (type is ByReferenceType brt) {
				if (toManaged) {
					var elementType = brt.ElementType;
					if (elementType is GenericParameter gp) {
						if (!StaticRegistrar.VerifyIsConstrainedToNSObject (gp, out var constrained)) {
							AddException (ErrorHelper.CreateError (99, "Incorrectly constrained generic parameter. Method: {0}", GetMethodSignatureWithSourceCode (method)));
							return false;
						}
						elementType = constrained;
					}

					if (elementType.IsValueType) {
						// call !!0& [System.Runtime]System.Runtime.CompilerServices.Unsafe::AsRef<int32>(void*)
						var mr = new GenericInstanceMethod (abr.CurrentAssembly.MainModule.ImportReference (abr.Unsafe_AsRef));
						if (isOutParameter)
							il.EmitLoadArgument (nativeParameterIndex);
						mr.GenericArguments.Add (elementType);
						il.Emit (OpCodes.Call, mr);
						// reference types aren't blittable, so the managed signature must have be a pointer type
						nativeType = new PointerType (elementType);
						return true;
					}

					MethodReference? native_to_managed = null;
					MethodReference? managed_to_native = null;
					Instruction? addBeforeNativeToManagedCall = null;

					if (elementType is ArrayType elementArrayType) {
						// TODO: verify elementArrayType.ElementType?
						if (elementArrayType.ElementType.Is ("System", "String")) {
							native_to_managed = abr.RegistrarHelper_NSArray_string_native_to_managed;
							managed_to_native = abr.RegistrarHelper_NSArray_string_managed_to_native;
						} else {
							native_to_managed = abr.RegistrarHelper_NSArray_native_to_managed.CreateGenericInstanceMethod (elementArrayType.ElementType);
							managed_to_native = abr.RegistrarHelper_NSArray_managed_to_native.CreateGenericInstanceMethod (elementArrayType.ElementType);
						}
						nativeType = new PointerType (abr.ObjCRuntime_NativeHandle);
					} else if (elementType.Is ("System", "String")) {
						native_to_managed = abr.RegistrarHelper_string_native_to_managed;
						managed_to_native = abr.RegistrarHelper_string_managed_to_native;
						nativeType = new PointerType (abr.ObjCRuntime_NativeHandle);
					} else if (elementType.IsNSObject (DerivedLinkContext)) {
						native_to_managed = abr.RegistrarHelper_NSObject_native_to_managed.CreateGenericInstanceMethod (elementType);
						managed_to_native = abr.RegistrarHelper_NSObject_managed_to_native;
						nativeType = new PointerType (abr.System_IntPtr);
					} else if (StaticRegistrar.IsNativeObject (DerivedLinkContext, elementType)) {
						var nativeObjType = StaticRegistrar.GetInstantiableType (type.Resolve (), exceptions, GetMethodSignature (method));
						addBeforeNativeToManagedCall = il.Create (OpCodes.Ldtoken, method.Module.ImportReference (nativeObjType)); // implementation type
						native_to_managed = abr.RegistrarHelper_INativeObject_native_to_managed.CreateGenericInstanceMethod (elementType);
						managed_to_native = abr.RegistrarHelper_INativeObject_managed_to_native;
						nativeType = new PointerType (abr.System_IntPtr);
					} else {
						AddException (ErrorHelper.CreateError (99, "Don't know how (4) to convert {0} between managed and native code. Method: {1}", type.FullName, GetMethodSignatureWithSourceCode (method)));
						return false;
					}

					if (managed_to_native is not null && native_to_managed is not null) {
						EnsureVisible (method, managed_to_native);
						EnsureVisible (method, native_to_managed);

						var indirectVariable = il.Body.AddVariable (elementType);
						// We store a copy of the value in a separate variable, to detect if it changes.
						var copyIndirectVariable = il.Body.AddVariable (elementType);

						// We don't read the input for 'out' parameters, it might be garbage.
						if (!isOutParameter) {
							il.Emit (OpCodes.Ldloca, indirectVariable);
							il.Emit (OpCodes.Ldloca, copyIndirectVariable);
							if (addBeforeNativeToManagedCall is not null)
								il.Append (addBeforeNativeToManagedCall);
							il.Emit (OpCodes.Call, native_to_managed);
							if (isDynamicInvoke) {
								il.Emit (OpCodes.Ldloc, indirectVariable);
							} else {
								il.Emit (OpCodes.Ldloca, indirectVariable);
							}
						} else {
							if (!isDynamicInvoke)
								il.Emit (OpCodes.Ldloca, indirectVariable);
						}
						postProcessing.Add (il.CreateLoadArgument (nativeParameterIndex));
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Ldloc, copyIndirectVariable));
						postProcessing.Add (il.Create (isOutParameter));
						postProcessing.Add (il.Create (OpCodes.Call, managed_to_native));
						return true;
					}
				}

				AddException (ErrorHelper.CreateError (99, "Don't know how (2) to convert {0} between managed and native code. Method: {1}", type.FullName, GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (isOutParameter)
				throw new InvalidOperationException ($"Parameter must be ByReferenceType to be an out parameter");

			if (type is ArrayType at) {
				var elementType = at.GetElementType ();
				if (elementType.Is ("System", "String")) {
					il.Emit (OpCodes.Call, toManaged ? abr.CFArray_StringArrayFromHandle : abr.CFArray_Create);
					nativeType = abr.ObjCRuntime_NativeHandle;
					return true;
				}

				var isGenericParameter = false;
				if (elementType is GenericParameter gp) {
					if (!StaticRegistrar.VerifyIsConstrainedToNSObject (gp, out var constrained)) {
						AddException (ErrorHelper.CreateError (99, "Incorrectly constrained generic parameter. Method: {0}", GetMethodSignatureWithSourceCode (method)));
						return false;
					}
					elementType = constrained;
					isGenericParameter = true;
				}

				var isNSObject = elementType.IsNSObject (DerivedLinkContext);
				var isNativeObject = StaticRegistrar.IsNativeObject (elementType);
				if (isNSObject || isNativeObject) {
					if (toManaged) {
						if (isGenericParameter) {
							il.Emit (OpCodes.Ldloc, selfVariable);
							il.Emit (OpCodes.Ldtoken, method.DeclaringType);
							il.Emit (OpCodes.Ldtoken, method);
							il.Emit (OpCodes.Ldc_I4, parameter);
							il.Emit (OpCodes.Call, abr.Runtime_FindClosedParameterType);
							il.Emit (OpCodes.Call, abr.NSArray_ArrayFromHandle);
						} else {
							var gim = new GenericInstanceMethod (abr.NSArray_ArrayFromHandle_1);
							gim.GenericArguments.Add (elementType);
							il.Emit (OpCodes.Call, gim);
						}
					} else {
						var retain = StaticRegistrar.HasReleaseAttribute (method);
						il.Emit (retain ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
						il.Emit (OpCodes.Call, abr.RegistrarHelper_ManagedArrayToNSArray);
					}
					nativeType = abr.ObjCRuntime_NativeHandle;
					return true;
				}

				AddException (ErrorHelper.CreateError (99, "Don't know how (3) to convert array element type {1} for array type {0} between managed and native code. Method: {2}", type.FullName, elementType.FullName, GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (IsNSObject (type)) {
				if (toManaged) {
					if (type is GenericParameter gp || type is GenericInstanceType || type.HasGenericParameters) {
						il.Emit (OpCodes.Call, abr.Runtime_GetNSObject__System_IntPtr);
					} else {
						// FIXME: argument semantics
						il.Emit (OpCodes.Ldarg_1); // SEL
						il.Emit (OpCodes.Ldtoken, method);
						il.Emit (parameter == -1); // evenInFinalizerQueue
						il.Emit (OpCodes.Call, abr.Runtime_GetNSObject_T___System_IntPtr_System_IntPtr_System_RuntimeMethodHandle_bool.CreateGenericInstanceMethod (type));
						var tmpVariable = il.Body.AddVariable (type);
						il.Emit (OpCodes.Stloc, tmpVariable);
						il.Emit (OpCodes.Ldloc, tmpVariable);
					}
					nativeType = abr.System_IntPtr;
				} else {
					if (parameter == -1) {
						var retain = StaticRegistrar.HasReleaseAttribute (method);
						il.Emit (OpCodes.Dup);
						if (retain) {
							il.Emit (OpCodes.Call, abr.Runtime_RetainNSObject);
						} else {
							il.Emit (OpCodes.Call, abr.Runtime_RetainAndAutoreleaseNSObject);
						}
					} else {
						il.Emit (OpCodes.Call, abr.NativeObjectExtensions_GetHandle);
					}
					nativeType = abr.ObjCRuntime_NativeHandle;
				}
				return true;
			}

			if (StaticRegistrar.IsNativeObject (DerivedLinkContext, type)) {
				if (toManaged) {
					if (type is GenericParameter gp) {
						// FIXME: check that gp is constrained to NSObject
						// il.Emit (OpCodes.Ldarg_1);
						// il.Emit (OpCodes.Ldtoken, method);
						// il.Emit (OpCodes.Call, CreateGenericInstanceMethod (Runtime_GetNSObject_T___System_IntPtr_System_IntPtr_System_RuntimeMethodHandle_bool, type));
						// il.Emit (OpCodes.Call, CreateGenericInstanceMethod (Runtime_GetNSObject_T___System_IntPtr, type));
						il.Emit (OpCodes.Call, abr.Runtime_GetNSObject__System_IntPtr);
					} else {
						var nativeObjType = StaticRegistrar.GetInstantiableType (type.Resolve (), exceptions, GetMethodSignature (method));
						il.Emit (OpCodes.Ldc_I4_0); // false
						il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (type)); // target type
						il.Emit (OpCodes.Call, abr.Type_GetTypeFromHandle);
						il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (nativeObjType)); // implementation type
						il.Emit (OpCodes.Call, abr.Type_GetTypeFromHandle);
						il.Emit (OpCodes.Call, abr.Runtime_GetINativeObject__IntPtr_Boolean_Type_Type);
						il.Emit (OpCodes.Castclass, type);
					}
					nativeType = abr.System_IntPtr;
				} else {
					if (parameter == -1) {
						var retain = StaticRegistrar.HasReleaseAttribute (method);
						var isNSObject = IsNSObject (type);
						if (retain) {
							il.Emit (OpCodes.Call, isNSObject ? abr.Runtime_RetainNSObject : abr.Runtime_RetainNativeObject);
						} else {
							il.Emit (OpCodes.Call, isNSObject ? abr.Runtime_RetainAndAutoreleaseNSObject : abr.Runtime_RetainAndAutoreleaseNativeObject);
						}
					} else {
						il.Emit (OpCodes.Call, abr.NativeObjectExtensions_GetHandle);
					}
					nativeType = abr.ObjCRuntime_NativeHandle;
				}
				return true;
			}

			if (type.Is ("System", "String")) {
				il.Emit (OpCodes.Call, toManaged ? abr.CFString_FromHandle : abr.CFString_CreateNative);
				nativeType = abr.ObjCRuntime_NativeHandle;
				return true;
			}

			if (StaticRegistrar.IsDelegate (type.Resolve ())) {
				if (!StaticRegistrar.TryFindMethod (method, out var objcMethod)) {
					AddException (ErrorHelper.CreateError (99, "Unable to find method {0}", GetMethodSignature (method)));
					return false;
				}
				if (toManaged) {
					var createMethod = StaticRegistrar.GetBlockWrapperCreator (objcMethod, parameter);
					if (createMethod is null) {
						AddException (ErrorHelper.CreateWarning (App, 4174 /* Unable to locate the block to delegate conversion method for the method {0}'s parameter #{1}. */, method, Errors.MT4174, method.FullName, parameter + 1));
						var tmpVariable = il.Body.AddVariable (abr.System_IntPtr);
						il.Emit (OpCodes.Stloc, tmpVariable);
						il.Emit (OpCodes.Ldtoken, method);
						il.Emit (OpCodes.Call, abr.MethodBase_GetMethodFromHandle);
						il.Emit (OpCodes.Castclass, abr.System_Reflection_MethodInfo);
						il.Emit (OpCodes.Ldc_I4, parameter);
						il.Emit (OpCodes.Call, abr.Runtime_GetBlockWrapperCreator);
						il.Emit (OpCodes.Ldloc, tmpVariable);
						il.Emit (OpCodes.Call, abr.Runtime_CreateBlockProxy);
					} else {
						EnsureVisible (method, createMethod);
						il.Emit (OpCodes.Call, abr.BlockLiteral_Copy);
						il.Emit (OpCodes.Dup);
						il.Emit (OpCodes.Call, method.Module.ImportReference (createMethod));
						il.Emit (OpCodes.Call, abr.Runtime_ReleaseBlockWhenDelegateIsCollected);
					}
				} else {
					FieldDefinition? delegateProxyField = null;
					MethodDefinition? createBlockMethod = null;

					if (!DerivedLinkContext.StaticRegistrar.TryComputeBlockSignature (method, trampolineDelegateType: type, out var exception, out var signature)) {
						AddException (ErrorHelper.CreateWarning (99, "Error while converting block/delegates: FIXME better error: {0}", exception.ToString ()));
					} else {
						var delegateProxyType = StaticRegistrar.GetDelegateProxyType (objcMethod);
						if (delegateProxyType is null) {
							exceptions.Add (ErrorHelper.CreateWarning (App, 4176, method, Errors.MT4176 /* "Unable to locate the delegate to block conversion type for the return value of the method {0}." */, method.FullName));
						} else {
							createBlockMethod = StaticRegistrar.GetCreateBlockMethod (delegateProxyType);
							if (createBlockMethod is null) {
								delegateProxyField = delegateProxyType.Fields.SingleOrDefault (v => v.Name == "Handler");
								if (delegateProxyField is null) {
									AddException (ErrorHelper.CreateWarning (99, "No delegate proxy field on {0}", delegateProxyType.FullName)); // FIXME: better error message
								}
							}
						}
					}

					// the delegate is already on the stack
					if (createBlockMethod is not null) {
						EnsureVisible (method, createBlockMethod);
						il.Emit (OpCodes.Call, method.Module.ImportReference (createBlockMethod));
						il.Emit (OpCodes.Call, abr.RegistrarHelper_GetBlockPointer);
					} else if (delegateProxyField is not null) {
						EnsureVisible (method, delegateProxyField);
						il.Emit (OpCodes.Ldsfld, method.Module.ImportReference (delegateProxyField));
						il.Emit (OpCodes.Ldstr, signature);
						il.Emit (OpCodes.Call, abr.BlockLiteral_CreateBlockForDelegate);
					} else {
						il.Emit (OpCodes.Ldtoken, method);
						il.Emit (OpCodes.Call, abr.RegistrarHelper_GetBlockForDelegate);
					}
				}
				nativeType = abr.System_IntPtr;
				return true;
			}

			AddException (ErrorHelper.CreateError (99, "Don't know how (1) to convert {0} between managed and native code: {1}. Method: {2}", type.FullName, type.GetType ().FullName, GetMethodSignatureWithSourceCode (method)));
			return false;
		}

		void EnsureVisible (MethodDefinition caller, FieldDefinition field)
		{
			field.IsPublic = true;
			EnsureVisible (caller, field.DeclaringType);
		}

		void EnsureVisible (MethodDefinition caller, TypeDefinition type)
		{
			if (type.IsNested) {
				type.IsNestedPublic = true;
				EnsureVisible (caller, type.DeclaringType);
			} else {
				type.IsPublic = true;
			}
		}

		void EnsureVisible (MethodDefinition caller, MethodReference method)
		{
			var md = method.Resolve ();
			md.IsPublic = true;
			EnsureVisible (caller, md.DeclaringType);
		}

		bool IsOutParameter (MethodDefinition method, int parameter, ParameterDefinition baseParameter)
		{
			return method.Parameters [parameter].IsOut || baseParameter.IsOut;
		}

		StaticRegistrar StaticRegistrar {
			get { return DerivedLinkContext.StaticRegistrar; }
		}

		CustomAttribute CreateUnmanagedCallersAttribute (string entryPoint)
		{
			var unmanagedCallersAttribute = new CustomAttribute (abr.UnmanagedCallersOnlyAttribute_Constructor);
			unmanagedCallersAttribute.Fields.Add (new CustomAttributeNamedArgument ("EntryPoint", new CustomAttributeArgument (abr.System_String, "_" + entryPoint)));
			return unmanagedCallersAttribute;
		}

		void GenerateConversionToManaged (MethodDefinition method, ILProcessor il, TypeReference inputType, TypeReference outputType, string descriptiveMethodName, int parameter, out TypeReference nativeCallerType)
		{
			// This is a mirror of the native method xamarin_generate_conversion_to_managed (for the dynamic registrar).
			// It's also a mirror of the method ManagedRegistrarStep.GenerateConversionToManaged.
			// These methods must be kept in sync.
			var managedType = outputType;
			var nativeType = inputType;

			var isManagedNullable = StaticRegistrar.IsNullable (managedType);

			var underlyingManagedType = managedType;
			var underlyingNativeType = nativeType;

			var isManagedArray = StaticRegistrar.IsArray (managedType);
			var isNativeArray = StaticRegistrar.IsArray (nativeType);

			nativeCallerType = abr.System_IntPtr;

			if (isManagedArray != isNativeArray)
				throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");

			if (isManagedArray) {
				if (isManagedNullable)
					throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
				underlyingNativeType = StaticRegistrar.GetElementType (nativeType);
				underlyingManagedType = StaticRegistrar.GetElementType (managedType);
			} else if (isManagedNullable) {
				underlyingManagedType = StaticRegistrar.GetNullableType (managedType);
			}

			string? func = null;
			MethodReference? conversionFunction = null;
			MethodReference? conversionFunction2 = null;
			if (underlyingNativeType.Is ("Foundation", "NSNumber")) {
				func = StaticRegistrar.GetNSNumberToManagedFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName, out var _);
			} else if (underlyingNativeType.Is ("Foundation", "NSValue")) {
				func = StaticRegistrar.GetNSValueToManagedFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName, out var _);
			} else if (underlyingNativeType.Is ("Foundation", "NSString")) {
				if (!StaticRegistrar.IsSmartEnum (underlyingManagedType, out var getConstantMethod, out var getValueMethod)) {
					// method linked away!? this should already be verified
					AddException (ErrorHelper.CreateError (99, Errors.MX0099, $"the smart enum {underlyingManagedType.FullName} doesn't seem to be a smart enum after all"));
					return;
				}

				var gim = new GenericInstanceMethod (abr.Runtime_GetNSObject_T___System_IntPtr);
				gim.GenericArguments.Add (abr.Foundation_NSString);
				conversionFunction = gim;

				conversionFunction2 = abr.CurrentAssembly.MainModule.ImportReference (getValueMethod);
			} else {
				throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
			}

			if (func is not null) {
				conversionFunction = abr.GetMethodReference (abr.PlatformAssembly, abr.ObjCRuntime_BindAs, func, func, (v) =>
						v.IsStatic, out MethodDefinition conversionFunctionDefinition, ensurePublic: true);
				EnsureVisible (method, conversionFunctionDefinition.DeclaringType);
			}

			if (isManagedArray) {
				il.Emit (OpCodes.Ldftn, conversionFunction);
				if (conversionFunction2 is not null) {
					il.Emit (OpCodes.Ldftn, conversionFunction2);
					var gim = new GenericInstanceMethod (abr.BindAs_ConvertNSArrayToManagedArray2);
					gim.GenericArguments.Add (underlyingManagedType);
					gim.GenericArguments.Add (abr.Foundation_NSString);
					il.Emit (OpCodes.Call, gim);
				} else {
					var gim = new GenericInstanceMethod (abr.BindAs_ConvertNSArrayToManagedArray);
					gim.GenericArguments.Add (underlyingManagedType);
					il.Emit (OpCodes.Call, gim);
				}
				nativeCallerType = abr.System_IntPtr;
			} else {
				if (isManagedNullable) {
					il.Emit (OpCodes.Ldftn, conversionFunction);
					if (conversionFunction2 is not null) {
						il.Emit (OpCodes.Ldftn, conversionFunction2);
						var gim = new GenericInstanceMethod (abr.BindAs_CreateNullable2);
						gim.GenericArguments.Add (underlyingManagedType);
						gim.GenericArguments.Add (abr.Foundation_NSString);
						il.Emit (OpCodes.Call, gim);
					} else {
						var gim = new GenericInstanceMethod (abr.BindAs_CreateNullable);
						gim.GenericArguments.Add (underlyingManagedType);
						il.Emit (OpCodes.Call, gim);
					}
					nativeCallerType = abr.System_IntPtr;
				} else {
					il.Emit (OpCodes.Call, conversionFunction);
					if (conversionFunction2 is not null)
						il.Emit (OpCodes.Call, conversionFunction2);
					nativeCallerType = abr.System_IntPtr;
				}
			}
		}

		void GenerateConversionToNative (MethodDefinition method, ILProcessor il, TypeReference inputType, TypeReference outputType, string descriptiveMethodName, out TypeReference nativeCallerType)
		{
			// This is a mirror of the native method xamarin_generate_conversion_to_native (for the dynamic registrar).
			// These methods must be kept in sync.
			var managedType = inputType;
			var nativeType = outputType;

			var isManagedNullable = StaticRegistrar.IsNullable (managedType);

			var underlyingManagedType = managedType;
			var underlyingNativeType = nativeType;

			var isManagedArray = StaticRegistrar.IsArray (managedType);
			var isNativeArray = StaticRegistrar.IsArray (nativeType);

			nativeCallerType = abr.System_IntPtr;

			if (isManagedArray != isNativeArray)
				throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");

			if (isManagedArray) {
				if (isManagedNullable)
					throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
				underlyingNativeType = StaticRegistrar.GetElementType (nativeType);
				underlyingManagedType = StaticRegistrar.GetElementType (managedType);
			} else if (isManagedNullable) {
				underlyingManagedType = StaticRegistrar.GetNullableType (managedType);
			}

			string? func = null;
			MethodReference? conversionFunction = null;
			MethodReference? conversionFunction2 = null;
			MethodReference? conversionFunction3 = null;
			if (underlyingNativeType.Is ("Foundation", "NSNumber")) {
				func = StaticRegistrar.GetManagedToNSNumberFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName);
			} else if (underlyingNativeType.Is ("Foundation", "NSValue")) {
				func = StaticRegistrar.GetManagedToNSValueFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName);
			} else if (underlyingNativeType.Is ("Foundation", "NSString")) {
				if (!StaticRegistrar.IsSmartEnum (underlyingManagedType, out var getConstantMethod, out var getValueMethod)) {
					// method linked away!? this should already be verified
					ErrorHelper.Show (ErrorHelper.CreateError (99, Errors.MX0099, $"the smart enum {underlyingManagedType.FullName} doesn't seem to be a smart enum after all"));
					return;
				}

				conversionFunction = abr.CurrentAssembly.MainModule.ImportReference (getConstantMethod);
				conversionFunction2 = abr.NativeObjectExtensions_GetHandle;
				conversionFunction3 = abr.NativeObject_op_Implicit_IntPtr;
			} else {
				AddException (ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}"));
				return;
			}

			if (func is not null) {
				conversionFunction = abr.GetMethodReference (abr.PlatformAssembly, abr.ObjCRuntime_BindAs, func, func, (v) =>
						v.IsStatic, out MethodDefinition conversionFunctionDefinition, ensurePublic: true);
				EnsureVisible (method, conversionFunctionDefinition.DeclaringType);
			}

			if (isManagedArray) {
				il.Emit (OpCodes.Ldftn, conversionFunction);
				if (conversionFunction2 is not null) {
					il.Emit (OpCodes.Ldftn, conversionFunction2);
					var gim = new GenericInstanceMethod (abr.BindAs_ConvertManagedArrayToNSArray2);
					gim.GenericArguments.Add (underlyingManagedType);
					gim.GenericArguments.Add (abr.Foundation_NSString);
					il.Emit (OpCodes.Call, gim);
				} else {
					var gim = new GenericInstanceMethod (abr.BindAs_ConvertManagedArrayToNSArray);
					gim.GenericArguments.Add (underlyingManagedType);
					il.Emit (OpCodes.Call, gim);
				}
			} else {
				var tmpVariable = il.Body.AddVariable (managedType);

				var trueTarget = il.Create (OpCodes.Nop);
				var endTarget = il.Create (OpCodes.Nop);
				if (isManagedNullable) {
					il.Emit (OpCodes.Stloc, tmpVariable);
					il.Emit (OpCodes.Ldloca, tmpVariable);
					var mr = abr.System_Nullable_1.CreateMethodReferenceOnGenericType (abr.Nullable_HasValue, underlyingManagedType);
					il.Emit (OpCodes.Call, mr);
					il.Emit (OpCodes.Brtrue, trueTarget);
					il.Emit (OpCodes.Ldc_I4_0);
					il.Emit (OpCodes.Conv_I);
					il.Emit (OpCodes.Br, endTarget);
					il.Append (trueTarget);
					il.Emit (OpCodes.Ldloca, tmpVariable);
					il.Emit (OpCodes.Call, abr.System_Nullable_1.CreateMethodReferenceOnGenericType (abr.Nullable_Value, underlyingManagedType));
				}
				il.Emit (OpCodes.Call, conversionFunction);
				if (conversionFunction2 is not null) {
					il.Emit (OpCodes.Call, conversionFunction2);
					if (conversionFunction3 is not null)
						il.Emit (OpCodes.Call, conversionFunction3);
				}
				if (isManagedNullable)
					il.Append (endTarget);
			}
		}
	}
}
