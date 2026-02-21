using System;
using System.IO;
using System.Linq;
using System.Text;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using Mono.Linker;
using Mono.Linker.Steps;
using Mono.Tuner;
using MonoTouch.Tuner;

using Xamarin.Bundler;

#nullable enable

namespace Xamarin.Linker.Steps;

public class InlineDlfcnMethodsStep : ConfigurationAwareMarkHandler {

	protected override string Name { get; } = "Inline Dlfcn Methods";
	protected override int ErrorCode { get; } = 2250;

	HashSet<string> fields = new ();

	public override void Initialize (LinkContext context, MarkContext markContext)
	{
		base.Initialize (context);
		markContext.RegisterMarkMethodAction (Process);
		markContext.RegisterMarkAssemblyAction (Process);
		markContext.RegisterMarkAssemblyEndAction (ProcessAssemblyEnd);
	}

	void ProcessAssemblyEnd (AssemblyDefinition assembly)
	{
		abr.ClearCurrentAssembly ();

		if (string.IsNullOrEmpty (Configuration.IntermediateOutputPath)) {
			// Copilot TODO: warn that we're not generating native code because IntermediateOutputPath hasn't been set.
		} else {
			var dir = Path.Combine (Configuration.IntermediateOutputPath, "inlined-dlfcn");
			var path = Path.Combine (dir, $"{assembly.Name.Name}.c");
			Directory.CreateDirectory (dir);
			GenerateNativeCode (path);
			Configuration.NativeCodeToCompileAndLink.Add (path);
		}

		fields.Clear ();
	}

	void GenerateNativeCode (string path)
	{
		var sb = new StringBuilder ();
		sb.AppendLine ($"extern \"C\" {{");
		foreach (var field in fields) {
			sb.AppendLine ($"extern void* {field};");
			sb.AppendLine ($"void* xamarin_Dlfcn_{field}_Native ();");
			sb.AppendLine ($"void* xamarin_Dlfcn_{field}_Native () {{ return &{field}; }}");
		}
		sb.AppendLine ($"}}");

		var str = sb.ToString ();
		Driver.WriteIfDifferent (path, str);
	}

	protected override void Process (AssemblyDefinition assembly)
	{
		abr.SetCurrentAssembly (assembly);
	}

	protected override void Process (TypeDefinition type)
	{
		if (type.HasNestedTypes) {
			foreach (var nested in type.NestedTypes)
				ProcessType (nested);
		}

		if (type.HasMethods) {
			foreach (var method in type.Methods)
				ProcessMethod (method);
		}
	}

	TypeDefinition GetDlfcnType (ModuleDefinition module)
	{
		var dlfcn = module.Types.FirstOrDefault (t => t.Name == "Dlfcn" && t.Namespace == "ObjCRuntime");
		if (dlfcn is null) {
			dlfcn = new TypeDefinition ("ObjCRuntime", "Dlfcn", TypeAttributes.Public | TypeAttributes.Sealed, module.TypeSystem.Object);
			module.Types.Add (dlfcn);
		}
		return dlfcn;
	}

	MethodDefinition GetOrCreatePInvokeMethod (MethodDefinition callingMethod, string symbolName)
	{
		var dlfcn = GetDlfcnType (callingMethod.Module);
		var methodName = $"xamarin_Dlfcn_{symbolName}_Native";
		var nativeMethod = methodName;
		var rv = dlfcn.Methods.FirstOrDefault (m => m.Name == methodName);
		if (rv is not null)
			return rv; // already exists, no need to create it again

		// [DllImport ("__Internal")]
		// static extern IntPtr xamarin_Dlfcn_{symbolName}_Native ();

		rv = new MethodDefinition (methodName, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.PInvokeImpl, abr.System_IntPtr);
		var mod = callingMethod.Module.ModuleReferences.FirstOrDefault (mr => mr.Name == "__Internal");
		if (mod is null) {
			mod = new ModuleReference ("__Internal");
			callingMethod.Module.ModuleReferences.Add (mod);
		}
		rv.PInvokeInfo = new PInvokeInfo (PInvokeAttributes.CharSetNotSpec | PInvokeAttributes.CallConvCdecl, nativeMethod, mod);
		dlfcn.Methods.Add (rv);

		fields.Add (symbolName);

		return rv;
	}

	MethodDefinition GetOrCreateGetSymbolMethod (MethodDefinition callingMethod, string symbolName)
	{
		var dlfcn = GetDlfcnType (callingMethod.Module);
		var methodName = $"Get__{symbolName}";
		var symbolMethod = dlfcn.Methods.FirstOrDefault (m => m.Name == methodName);
		if (symbolMethod is not null)
			return symbolMethod; // already exists, no need to create it again

		// static IntPtr? Get__{symbolName}_Field;
		// static IntPtr Get__{symbolName} ()
		// {
		//     if (!Get__{symbolName}_Field.HasValue) {
		//         Get__{symbolName}_Field = Get__{symbolName} ();
		//     }
		//     return Get__{symbolName}_Field.Value;
		// }

		var managedFieldName = $"Get__{symbolName}_Field";
		var managedFieldType = abr.System_Nullable_1.MakeGenericInstanceType (abr.System_IntPtr);
		var managedField = new FieldDefinition (managedFieldName, FieldAttributes.Private | FieldAttributes.Static, callingMethod.Module.ImportReference (managedFieldType));
		dlfcn.Fields.Add (managedField);


		var nativeMethod = $"Get__{symbolName}";
		var intptr = abr.System_IntPtr;
		symbolMethod = new MethodDefinition (methodName, MethodAttributes.Private | MethodAttributes.Static, intptr);
		dlfcn.Methods.Add (symbolMethod);

		var body = symbolMethod.Body;
		var il = body.GetILProcessor ();

		var loadManagedFieldInstructionStart = il.Create (OpCodes.Ldsfld, managedField);

		// if (!Get__{symbolName}_Field.HasValue) {
		il.Append (il.Create (OpCodes.Ldsflda, managedField));
		il.Append (il.Create (OpCodes.Call, abr.System_Nullable_1.CreateMethodReferenceOnGenericType (abr.Nullable_HasValue, abr.System_IntPtr)));
		il.Append (il.Create (OpCodes.Brtrue, loadManagedFieldInstructionStart));

		//     Get__{symbolName}_Field = Get__symbolName ();
		il.Append (il.Create (OpCodes.Call, GetOrCreatePInvokeMethod (callingMethod, symbolName)));
		il.Append (il.Create (OpCodes.Newobj, abr.Nullable_ctor.CreateGenericInstanceMethod (abr.System_IntPtr)));
		il.Append (il.Create (OpCodes.Stsfld, managedField));

		//     return Get__{symbolName}_Field.Value;
		il.Append (loadManagedFieldInstructionStart); // il.Create (OpCodes.Ldsfld, managedField);
		il.Append (il.Create (OpCodes.Call, abr.System_Nullable_1.CreateMethodReferenceOnGenericType (abr.Nullable_Value, abr.System_IntPtr)));
		il.Append (il.Create (OpCodes.Ret));

		return symbolMethod;
	}

	MethodDefinition GetOrCreateGetNativeFieldMethod (MethodDefinition callingMethod, TypeReference fieldType, string symbolName)
	{
		var dlfcn = GetDlfcnType (callingMethod.Module);
		var methodName = $"Get__{symbolName}_{fieldType.Name}";
		var rv = dlfcn.Methods.FirstOrDefault (m => m.Name == methodName);
		if (rv is not null)
			return rv; // already exists, no need to create it again

		// static FieldType Get__{symbolName}_{fieldType} ()
		// {
		//     var ptr = Get__{symbolName} ();
		//     if (ptr == IntPtr.Zero)
		//	       return default;
		//
		//     /* if value type */
		//     return *(FieldType*)ptr;
		//
		//     /* if not value type */
		//     return Runtime.GetNSObject<FieldType> (*ptr);
		// }

		var importedFieldType = callingMethod.Module.ImportReference (fieldType);
		rv = new MethodDefinition (methodName, MethodAttributes.Public | MethodAttributes.Static, importedFieldType);
		dlfcn.Methods.Add (rv);

		var body = rv.Body;
		var il = body.GetILProcessor ();

		var ptrVariable = new VariableDefinition (abr.System_IntPtr);
		body.Variables.Add (ptrVariable);

		var loadPointerInstructionStart = il.Create (OpCodes.Ldloc, ptrVariable);

		//     var ptr = Get__{symbolName} ();
		il.Append (il.Create (OpCodes.Call, GetOrCreateGetSymbolMethod (callingMethod, symbolName)));
		il.Append (il.Create (OpCodes.Stloc, ptrVariable));

		// if (ptr == IntPtr.Zero)
		il.Append (il.Create (OpCodes.Ldloc, ptrVariable));
		il.Append (il.Create (OpCodes.Ldsfld, abr.System_IntPtr_Zero));
		il.Append (il.Create (OpCodes.Bne_Un, loadPointerInstructionStart));

		//   return default;
		var fullFieldTypeName = fieldType.FullName;
		switch (fullFieldTypeName) {
		case "System.Byte":
		case "System.SByte":
		case "System.Int16":
		case "System.UInt16":
		case "System.Int32":
		case "System.UInt32":
			il.Append (il.Create (OpCodes.Ldc_I4_0));
			break;
		case "System.Int64":
			il.Append (il.Create (OpCodes.Ldc_I4_0));
			il.Append (il.Create (OpCodes.Conv_I8));
			break;
		case "System.UInt64":
			il.Append (il.Create (OpCodes.Ldc_I4_0));
			il.Append (il.Create (OpCodes.Conv_U8));
			break;
		case "System.Single":
			il.Append (il.Create (OpCodes.Ldc_R4, 0f));
			break;
		case "System.Double":
			il.Append (il.Create (OpCodes.Ldc_R8, 0.0));
			break;
		case "System.IntPtr":
		case "System.UIntPtr":
			il.Append (il.Create (OpCodes.Ldc_I4_0));
			il.Append (il.Create (OpCodes.Conv_I));
			break;
		default:
			if (fieldType.IsValueType) {
				if (fieldType.IsPrimitive) {
					// Copilot TODO: create a warning instead of a log message, mentioning that sub-optimal (but functional) code will be generated, and to file an issue.
					Driver.Log ($"Unsupported primitive field type: {fieldType.FullName} for symbol: {symbolName} in method: {FormatMethod (callingMethod)}");
				}
				var defaultTemporary = new VariableDefinition (importedFieldType);
				body.Variables.Add (defaultTemporary);
				il.Append (il.Create (OpCodes.Ldloca, defaultTemporary));
				il.Append (il.Create (OpCodes.Initobj, importedFieldType));
				il.Append (il.Create (OpCodes.Ldloc, defaultTemporary));
			} else {
				il.Append (il.Create (OpCodes.Ldnull));
			}
			break;
		}
		il.Append (il.Create (OpCodes.Ret));

		// /* if value type */
		// return *(FieldType*)ptr;
		// /* if not value type */
		// return Runtime.GetNSObject<FieldType> (*(IntPtr*)ptr);
		il.Append (loadPointerInstructionStart); // il.Create (OpCodes.Ldloc_0));
		if (fieldType.IsValueType) {
			switch (fieldType.FullName) {
			case "System.Byte":
				il.Append (il.Create (OpCodes.Ldind_U1));
				break;
			case "System.SByte":
				il.Append (il.Create (OpCodes.Ldind_I1));
				break;
			case "System.Int16":
				il.Append (il.Create (OpCodes.Ldind_I2));
				break;
			case "System.UInt16":
				il.Append (il.Create (OpCodes.Ldind_U2));
				break;
			case "System.Int32":
				il.Append (il.Create (OpCodes.Ldind_I4));
				break;
			case "System.UInt32":
				il.Append (il.Create (OpCodes.Ldind_U4));
				break;
			case "System.Int64":
			case "System.UInt64":
				il.Append (il.Create (OpCodes.Ldind_I8));
				break;
			case "System.Single":
				il.Append (il.Create (OpCodes.Ldind_R4));
				break;
			case "System.Double":
				il.Append (il.Create (OpCodes.Ldind_R8));
				break;
			case "System.IntPtr":
			case "System.UIntPtr":
				il.Append (il.Create (OpCodes.Ldind_I));
				break;
			default:
				if (fieldType.IsPrimitive) {
					// Copilot TODO: create a warning instead of a log message, mentioning that sub-optimal (but functional) code will be generated, and to file an issue.
					Driver.Log ($"Unsupported primitive field type: {fieldType.FullName} for symbol: {symbolName} in method: {FormatMethod (callingMethod)}");
				}
				il.Append (il.Create (OpCodes.Ldobj, importedFieldType));
				break;
			}
		} else {
			// Copilot TODO: validate that the field type is actually a valid NSObject type (i.e. class that inherits from NSObject), and log an error if not
			il.Append (il.Create (OpCodes.Ldind_I));
			var getnsobject = abr.Runtime_GetNSObject_T___System_IntPtr.CreateGenericInstanceMethod (importedFieldType);
			il.Append (il.Create (OpCodes.Call, getnsobject));
		}
		il.Append (il.Create (OpCodes.Ret));

		return rv;
	}

	MethodDefinition GetOrCreateSetNativeFieldMethod (MethodDefinition callingMethod, TypeReference fieldType, string symbolName)
	{
		var dlfcn = GetDlfcnType (callingMethod.Module);
		var methodName = $"Set__{symbolName}_{fieldType.Name}";
		var rv = dlfcn.Methods.FirstOrDefault (m => m.Name == methodName);
		if (rv is not null)
			return rv; // already exists, no need to create it again

		// static FieldType Set__{symbolName}_{fieldType} ({FieldType} value)
		// {
		//     var ptr = Get__{symbolName} ();
		//     if (ptr == IntPtr.Zero)
		//	       return;
		//
		//     /* if value type */
		//     *(FieldType*)ptr = value;
		//
		//     /* if not value type */
		//     *(IntPtr*)ptr = Runtime.DangerousRetain (value)
		// }

		var importedFieldType = callingMethod.Module.ImportReference (fieldType);
		rv = new MethodDefinition (methodName, MethodAttributes.Public | MethodAttributes.Static, abr.System_Void);
		rv.Parameters.Add (new ParameterDefinition ("value", ParameterAttributes.None, importedFieldType));
		dlfcn.Methods.Add (rv);

		var body = rv.Body;
		var il = body.GetILProcessor ();

		var ptrVariable = new VariableDefinition (abr.System_IntPtr);
		body.Variables.Add (ptrVariable);

		var loadPointerInstructionStart = il.Create (OpCodes.Ldloc, ptrVariable);

		//     var ptr = Get__{symbolName} ();
		il.Append (il.Create (OpCodes.Call, GetOrCreateGetSymbolMethod (callingMethod, symbolName)));
		il.Append (il.Create (OpCodes.Stloc, ptrVariable));

		// if (ptr == IntPtr.Zero)
		il.Append (il.Create (OpCodes.Ldloc, ptrVariable));
		il.Append (il.Create (OpCodes.Ldsfld, abr.System_IntPtr_Zero));
		il.Append (il.Create (OpCodes.Bne_Un, loadPointerInstructionStart));
		//   return;
		il.Append (il.Create (OpCodes.Ret));

		// /* if value type */
		// *(FieldType*)ptr = value;
		// /* if not value type */
		// *(IntPtr*)ptr = Runtime.RetainNSObject (value)
		il.Append (loadPointerInstructionStart); // il.Create (OpCodes.Ldloc, ptrVariable);
		il.Append (il.Create (OpCodes.Ldarg_0));
		if (fieldType.IsValueType) {
			switch (fieldType.FullName) {
			case "System.Byte":
			case "System.SByte":
				il.Append (il.Create (OpCodes.Stind_I1));
				break;
			case "System.Int16":
			case "System.UInt16":
				il.Append (il.Create (OpCodes.Stind_I2));
				break;
			case "System.Int32":
			case "System.UInt32":
				il.Append (il.Create (OpCodes.Stind_I4));
				break;
			case "System.Int64":
			case "System.UInt64":
				il.Append (il.Create (OpCodes.Stind_I8));
				break;
			case "System.Single":
				il.Append (il.Create (OpCodes.Stind_R4));
				break;
			case "System.Double":
				il.Append (il.Create (OpCodes.Stind_R8));
				break;
			case "System.IntPtr":
			case "System.UIntPtr":
				il.Append (il.Create (OpCodes.Stind_I));
				break;
			default:
				if (fieldType.IsPrimitive) {
					// Copilot TODO: create a warning instead of a log message, mentioning that sub-optimal (but functional) code will be generated, and to file an issue.
					Driver.Log ($"Unsupported primitive field type: {fieldType.FullName} for symbol: {symbolName} in method: {FormatMethod (callingMethod)}");
				}
				il.Append (il.Create (OpCodes.Stobj, importedFieldType));
				break;
			}
		} else {
			// Copilot TODO: validate that the field type is actually a valid NSObject type (i.e. class that inherits from NSObject), and log an error if not
			il.Append (il.Create (OpCodes.Call, abr.Runtime_RetainNSObject));
			il.Append (il.Create (OpCodes.Call, abr.NativeObject_op_Implicit_IntPtr));
			il.Append (il.Create (OpCodes.Stind_I));
		}
		il.Append (il.Create (OpCodes.Ret));

		return rv;
	}

	MethodDefinition GetOrCreateSetNativeStringMethod (MethodDefinition callingMethod, string symbolName)
	{
		var dlfcn = GetDlfcnType (callingMethod.Module);
		var methodName = $"Set__{symbolName}_String";
		var rv = dlfcn.Methods.FirstOrDefault (m => m.Name == methodName);
		if (rv is not null)
			return rv; // already exists, no need to create it again

		// static FieldType Set__{symbolName}_String (string? value)
		// {
		//     var ptr = Get__{symbolName} ();
		//     if (ptr == IntPtr.Zero)
		//	       return;
		//
		//     *(IntPtr*)ptr = CFString.CreateNative (value);
		// }

		rv = new MethodDefinition (methodName, MethodAttributes.Public | MethodAttributes.Static, abr.System_Void);
		rv.Parameters.Add (new ParameterDefinition ("value", ParameterAttributes.None, abr.System_String));
		dlfcn.Methods.Add (rv);

		var body = rv.Body;
		var il = body.GetILProcessor ();

		var ptrVariable = new VariableDefinition (abr.System_IntPtr);
		body.Variables.Add (ptrVariable);

		var loadPointerInstructionStart = il.Create (OpCodes.Ldloc, ptrVariable);

		//     var ptr = Get__{symbolName} ();
		il.Append (il.Create (OpCodes.Call, GetOrCreateGetSymbolMethod (callingMethod, symbolName)));
		il.Append (il.Create (OpCodes.Stloc, ptrVariable));

		// if (ptr == IntPtr.Zero)
		il.Append (il.Create (OpCodes.Ldloc, ptrVariable));
		il.Append (il.Create (OpCodes.Ldsfld, abr.System_IntPtr_Zero));
		il.Append (il.Create (OpCodes.Bne_Un, loadPointerInstructionStart));
		//   return;
		il.Append (il.Create (OpCodes.Ret));

		// *(IntPtr*)ptr = CFString.CreateNative (value);
		il.Append (loadPointerInstructionStart); // il.Create (OpCodes.Ldloc, ptrVariable);
		il.Append (il.Create (OpCodes.Ldarg_0));
		il.Append (il.Create (OpCodes.Call, abr.CFString_CreateNative));
		il.Append (il.Create (OpCodes.Call, abr.NativeObject_op_Implicit_IntPtr));
		il.Append (il.Create (OpCodes.Stind_I));
		il.Append (il.Create (OpCodes.Ret));

		return rv;
	}

	protected override void Process (MethodDefinition method)
	{
		if (!method.HasBody)
			return;

		if (method.DeclaringType.Name == "Dlfcn" && method.DeclaringType.Namespace == "ObjCRuntime")
			return; // don't process the Dlfcn methods themselves

		foreach (var instr in method.Body.Instructions) {
			if (instr.Operand is not MethodReference mr)
				continue;
			if (mr.DeclaringType.Name != "Dlfcn" || mr.DeclaringType.Namespace != "ObjCRuntime")
				continue;

			// Handle Dlfcn functions of the form (libraryHandle, symbolName)
			if (mr.Parameters.Count == 2 && mr.Parameters [0].ParameterType.FullName == "System.IntPtr" && mr.Parameters [1].ParameterType.FullName == "System.String") {
				if (instr.Previous.OpCode != OpCodes.Ldstr) {
					Driver.Log ("Unknown Dlfcn code sequence for: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
					continue;
				}
				var symbolName = (string) instr.Previous.Operand!;
				instr.Previous.OpCode = OpCodes.Pop; // just pop the library handle, we don't need it
				instr.Previous.Operand = null;

				switch (mr.Name) {
				// primitive types
				case "GetDouble":
				case "GetFloat":
				case "GetNFloat":
				case "GetIntPtr":
				case "GetUIntPtr":
				case "GetNInt":
				case "GetNUInt":
				case "GetInt16":
				case "GetUInt16":
				case "GetInt32":
				case "GetUInt32":
				case "GetInt64":
				case "GetUInt64":
				// non-primitive value types
				case "GetCGSize":
				case "GetCGRect":
				// classes
				case "GetNSNumber":
				case "GetStringConstant":
					instr.OpCode = OpCodes.Call;
					instr.Operand = GetOrCreateGetNativeFieldMethod (method, mr.ReturnType, symbolName);

					abr.SaveCurrentAssembly ();
					continue;
				case "GetStruct":
					if (mr is not GenericInstanceMethod gim || gim.GenericArguments.Count != 1) {
						Driver.Log ("Unknown Dlfcn method signature: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
						continue;
					}
					var returnType = gim.GenericArguments [0];
					if (returnType.IsGenericInstance) {
						Driver.Log ("Unsupported generic return type in Dlfcn.GetStruct: {0} called in {1}", returnType.FullName, FormatMethod (method));
						continue;
					}
					instr.OpCode = OpCodes.Call;
					instr.Operand = GetOrCreateGetNativeFieldMethod (method, returnType, symbolName);

					abr.SaveCurrentAssembly ();
					continue;
				case "GetIndirect":
				case "dlsym":
					instr.OpCode = OpCodes.Call;
					instr.Operand = GetOrCreateGetSymbolMethod (method, symbolName);

					abr.SaveCurrentAssembly ();
					continue;
				}
			}

			// Handle Dlfcn functions of the form (RTLD, symbolName)
			if (mr.Parameters.Count == 2 && mr.Parameters [0].ParameterType.FullName == "ObjCRuntime.Dlfcn/RTLD" && mr.Parameters [1].ParameterType.FullName == "System.String") {
				if (instr.Previous.OpCode != OpCodes.Ldstr) {
					Driver.Log ("Unknown Dlfcn code sequence for: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
					continue;
				}
				var symbolName = (string) instr.Previous.Operand!;
				instr.Previous.OpCode = OpCodes.Pop; // just pop the library handle, we don't need it
				instr.Previous.Operand = null;

				switch (mr.Name) {
				case "dlsym":
					instr.OpCode = OpCodes.Call;
					instr.Operand = GetOrCreateGetSymbolMethod (method, symbolName);

					abr.SaveCurrentAssembly ();
					continue;
				}
			}

			// Handle Dlfcn functions of the form (libraryName, symbolName)
			if (mr.Parameters.Count == 2 && mr.Parameters [0].ParameterType.FullName == "System.String" && mr.Parameters [1].ParameterType.FullName == "System.String") {
				if (instr.Previous.OpCode != OpCodes.Ldstr) {
					Driver.Log ("Unknown Dlfcn code sequence for: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
					continue;
				}
				var symbolName = (string) instr.Previous.Operand!;
				instr.Previous.OpCode = OpCodes.Pop; // just pop the library handle, we don't need it
				instr.Previous.Operand = null;

				switch (mr.Name) {
				// primitive types
				case "SlowGetDouble":
				case "SlowGetIntPtr":
				case "SlowGetInt32":
				case "SlowGetInt64":
				// classes
				case "SlowGetStringConstant":
					instr.OpCode = OpCodes.Call;
					instr.Operand = GetOrCreateGetNativeFieldMethod (method, mr.ReturnType, symbolName);

					abr.SaveCurrentAssembly ();
					continue;
				}
			}

			// Handle Dlfcn functions of the form void (libraryHandle|libraryName, symbolName, value)
			if (mr.Parameters.Count == 3 && 
				(mr.Parameters [0].ParameterType.FullName == "System.String" || mr.Parameters [0].ParameterType.FullName == "System.IntPtr") &&
				mr.Parameters [1].ParameterType.FullName == "System.String") {
				var ldstr = instr.Previous.Previous;
				if (ldstr.OpCode != OpCodes.Ldstr) {
					Driver.Log ("Unknown Dlfcn code sequence for: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
					continue;
				}
				var symbolName = (string) ldstr.Operand!;

				ldstr.OpCode = OpCodes.Pop; // just pop the library handle/name, we don't need it
				ldstr.Operand = null;

				switch (mr.Name) {
				// primitive types
				case "SetUInt64":
					instr.OpCode = OpCodes.Call;
					instr.Operand = GetOrCreateSetNativeFieldMethod (method, mr.Parameters [2].ParameterType, symbolName);

					abr.SaveCurrentAssembly ();
					continue;
				// classes
				case "SetString":
					if (mr.Parameters [2].ParameterType.FullName == "System.String") {
						instr.OpCode = OpCodes.Call;
						instr.Operand = GetOrCreateSetNativeStringMethod (method, symbolName);
						abr.SaveCurrentAssembly ();
						continue;
					} else if (mr.Parameters [2].ParameterType.FullName == "Foundation.NSString") {
						instr.OpCode = OpCodes.Call;
						instr.Operand = GetOrCreateSetNativeFieldMethod (method, mr.Parameters [2].ParameterType, symbolName);
						abr.SaveCurrentAssembly ();
						continue;
					}

					Driver.Log ("Unknown Dlfcn method signature: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
					continue;
				case "CachePointer":
					// Copilot TODO: validate the last param type is *IntPtr
					// Copilot TODO: validate expected IL for:

/*

			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.XYZ.Handle, "...", storage);
			}

*/

					// we're going to replace the entire method body with something like:
					// 
					// var ptr = Get__{symbolName} ();
					// if (ptr == IntPtr.Zero)
					//    return IntPtr.Zero;
					// return *(IntPtr *) ptr;
					method.Body.Instructions.Clear ();
					var il = method.Body.GetILProcessor ();
					var ptrVariable = new VariableDefinition (abr.System_IntPtr);
					method.Body.Variables.Add (ptrVariable);
					var loadPointerInstructionStart = il.Create (OpCodes.Ldloc, ptrVariable);
					// var ptr = Get__{symbolName} ()
					il.Append (il.Create (OpCodes.Call, GetOrCreateGetSymbolMethod (method, symbolName)));
					il.Append (il.Create (OpCodes.Stloc, ptrVariable));
					// if (ptr == IntPtr.Zero)
					il.Append (il.Create (OpCodes.Ldloc, ptrVariable));
					il.Append (il.Create (OpCodes.Brtrue_S, loadPointerInstructionStart));
					//   return IntPtr.Zero;
					il.Append (il.Create (OpCodes.Ldc_I4_0));
					il.Append (il.Create (OpCodes.Conv_I));
					il.Append (il.Create (OpCodes.Ret));
					// return *(IntPtr *) ptr;
					il.Append (loadPointerInstructionStart); // il.Create (OpCodes.Ldloc, ptrVariable)
					il.Append (il.Create (OpCodes.Ldind_I));
					il.Append (il.Create (OpCodes.Ret));

					abr.SaveCurrentAssembly ();
					return; // we replace the whole method body, so no need to continue processing the method
				}
			}

			switch (mr.Name) {
			case "_dlopen":
			case "dlopen":
				continue;
			case "dlclose":
				// It might be possible to just remove these calls, because
				// (PENDING CONFIRMATION) I believe dlclose is a no-op on at least some Apple platforms.
				continue;
			default:
				Driver.Log ("Unknown Dlfcn method: {0} called in {1}", FormatMethod (mr), FormatMethod (method));
				continue;
			}
		}
	}

	static string FormatMethod (MethodReference method)
	{
		var rv = method.FullName;
		var idx = rv.IndexOf (' ');
		if (idx > 0)
			rv = rv.Substring (idx + 1);
		return rv;
	}
}
