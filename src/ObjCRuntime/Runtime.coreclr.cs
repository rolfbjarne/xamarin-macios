//
// Runtime.coreclr.cs: Supporting managed code for the CoreCLR bridge
//
// Authors:
//   Rolf Bjarne Kvinge
//
// Copyright 2021 Microsoft Corp.

#if NET && !COREBUILD

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;

using Foundation;

namespace ObjCRuntime {

	public partial class Runtime {
		enum MonoObjectType {
			Unknown,
			MonoObject,
			MonoReflectionMethod,
			MonoReflectionAssembly,
			MonoReflectionType,
			MonoArray,
			MonoString,
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoObject {
			public int ReferenceCount;
			public MonoObjectType ObjectKind;
			public IntPtr GCHandle;
			public IntPtr TypeName;
			public IntPtr StructValue;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoString {
			public MonoObject Object;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoArray {
			public MonoObject Object;
			public ulong Length; /* uint64_t */
			public IntPtr Data; /* uint8_t */
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoReflectionMethod {
			public MonoObject Object;
			public IntPtr Method; /* MonoMethod* */
			IntPtr name;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoReflectionAssembly {
			public MonoObject Object;
			IntPtr name;
			public IntPtr Assembly; /* MonoAssembly* */
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoReflectionType {
			public MonoObject Object;
			IntPtr name; /* char */
			public IntPtr Type; /* MonoType* */
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoException {
			public MonoObject Object;
			IntPtr name; /* char */
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoMethod {
			public IntPtr Name; /* char* */
			public IntPtr Class; /* MonoClass* */
			public int ParameterCount;
			public IntPtr GCHandle; /* GCHandle */
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoAssembly {
			public IntPtr Name; /* char* */
			public IntPtr Image; /* MonoImage* */
			public IntPtr Object; /* MonoReflectionAssembly* */
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MonoType {
			public IntPtr FullName; /* char* */
			public IntPtr GCHandle; /* GCHandle */
			public IntPtr Name; /* char* */
			public IntPtr Namespace; /* char* */
			public int Type; /* MonoTypeEnum */
		}

		// Comment out the attribute to get all printfs
		[System.Diagnostics.Conditional ("UNDEFINED")]
		static void log_coreclr (string message)
		{
			xamarin_log (message);
		}

		static unsafe void InitializeCoreCLRBridge (InitializationOptions* options)
		{
            delegate* unmanaged<int, void> beginEndCallback = (delegate* unmanaged<int, void>) options->reference_tracking_begin_end_callback;
            delegate* unmanaged<IntPtr, int> isReferencedCallback = (delegate* unmanaged<IntPtr, int>) options->reference_tracking_is_referenced_callback;
            delegate* unmanaged<IntPtr, void> trackedObjectEnteredFinalization = (delegate* unmanaged<IntPtr, void>) options->reference_tracking_tracked_object_entered_finalization;
			Bridge.InitializeReferenceTracking (beginEndCallback, isReferencedCallback, trackedObjectEnteredFinalization);
		}

		// Size: 2 pointers
		struct TrackedObjectInfo {
			public IntPtr GCHandle;
			public unsafe NSObject.NSObjectData* Data;
		}

		internal static void RegisterToggleReferenceCoreCLR (NSObject obj, IntPtr handle, bool isCustomType)
		{
			var gchandle = Bridge.CreateReferenceTrackingHandle (obj, out var info);

			unsafe {
				TrackedObjectInfo* tracked_info = (TrackedObjectInfo*) info;
				tracked_info->GCHandle = GCHandle.ToIntPtr (gchandle);
				tracked_info->Data = obj.GetDataPointer ();
			}

			// Make sure the GCHandle we have is a weak one for custom types.
			if (isCustomType)
				xamarin_switch_gchandle (handle, true);
		}

		static IntPtr FindAssembly (IntPtr assembly_name)
		{
			var path = Marshal.PtrToStringAuto (assembly_name);
			var name = Path.GetFileNameWithoutExtension (path);
			log_coreclr ($"Runtime.FindAssembly (0x{assembly_name.ToString ("x")} = {name})");
			foreach (var asm in AppDomain.CurrentDomain.GetAssemblies ()) {
				log_coreclr ($"    Found in app domain: {asm.GetName ().Name}");
				if (asm.GetName ().Name == name) {
					log_coreclr ($"        Match!");
					return AllocGCHandle (asm);
				}
			}

			var loadedAssembly = Assembly.LoadFrom (path);
			if (loadedAssembly != null) {
				log_coreclr ($"    Loaded {loadedAssembly.GetName ().Name}");
				return AllocGCHandle (loadedAssembly);
			}

			log_coreclr ($"Found no assembly named {name}");
			throw new InvalidOperationException ($"Could not find any assemblies named {name}");
		}

		static IntPtr CreateGCHandle (IntPtr gchandle, GCHandleType type)
		{
			object obj = null;
			if (gchandle != IntPtr.Zero)
				obj = GetGCHandleTarget (gchandle);
			var rv = GCHandle.Alloc (obj, type);
			var rvptr = GCHandle.ToIntPtr (rv);
			return rvptr;
		}

		static void FreeGCHandle (IntPtr gchandle)
		{
			GCHandle.FromIntPtr (gchandle).Free ();
		}

		static IntPtr GetGCHandleType (IntPtr gchandle)
		{
			var obj = GCHandle.FromIntPtr (gchandle).Target;
			if (obj == null)
				return IntPtr.Zero;
			return Marshal.StringToHGlobalAuto (obj.GetType ().FullName);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct MethodParameter {
			public IntPtr TypeName;
			public IntPtr Type_GCHandle;
		}

		static unsafe IntPtr GetMethodSignature (IntPtr gchandle, ref int parameterCount)
		{
			var method = (MethodBase) GetGCHandleTarget (gchandle);
			if (method == null)
				throw new ArgumentNullException (nameof (gchandle));
			var parameters = method.GetParameters ();
			parameterCount = parameters.Length;
			var rv = Marshal.AllocHGlobal (sizeof (MethodParameter) * parameterCount);
			MethodParameter* mparams = (MethodParameter*) rv;
			for (var i = 0; i < parameters.Length; i++) {
				var p = parameters [i];
				mparams [i].Type_GCHandle = AllocGCHandle (p.ParameterType);
				mparams [i].TypeName = Marshal.StringToHGlobalAuto (p.ParameterType.FullName);
			}
			return rv;
		}

		static IntPtr GetMethodDeclaringType (IntPtr gchandle)
		{
			var method = (MethodBase) GCHandle.FromIntPtr (gchandle).Target;
			return AllocGCHandle (method.DeclaringType);
		}

		static IntPtr GetMethodReturnType (IntPtr gchandle)
		{
			var method = (MethodBase) GCHandle.FromIntPtr (gchandle).Target;
			object rv = null;
			if (method is MethodInfo minfo)
				rv = minfo.ReturnType;
			else if (method is ConstructorInfo cinfo)
				rv = cinfo.DeclaringType;

			log_coreclr ($"Return type for {method}: {rv}");

			return AllocGCHandle (rv);
		}

		static IntPtr CreateObject (IntPtr gchandle)
		{
			var type = (Type) GetGCHandleTarget (gchandle);
			var obj = RuntimeHelpers.GetUninitializedObject (type);
			return GetMonoObject (obj);
		}

		static void SetFlagsForNSObject (IntPtr gchandle, byte flags)
		{
			var obj = (NSObject) GetGCHandleTarget (gchandle);
			obj.SetFlagsDirectly (flags);
		}

		static byte GetFlagsForNSObject (IntPtr gchandle)
		{
			var obj = (NSObject) GetGCHandleTarget (gchandle);
			return obj.GetFlagsDirectly ();
		}

		static IntPtr GetTypeFullName (IntPtr gchandle)
		{
			var obj = (Type) GetGCHandleTarget (gchandle);
			return Marshal.StringToHGlobalAuto (obj?.FullName);
		}

		static IntPtr GetMethodName (IntPtr gchandle)
		{
			var obj = (MethodBase) GetGCHandleTarget (gchandle);
			return Marshal.StringToHGlobalAuto (obj?.Name);
		}

		// Return value: NULL or a MonoObject* that must be released with xamarin_mono_object_safe_release.
		// Any MonoObject* ref parameters must also be released with xamarin_mono_object_safe_release.
		static IntPtr InvokeMethod (IntPtr method_gchandle, IntPtr instance_gchandle, IntPtr native_parameters)
		{
			var method = (MethodBase) GetGCHandleTarget (method_gchandle);
			var instance = GetGCHandleTarget (instance_gchandle);

			var methodParameters = method.GetParameters ();
			var parameters = new object [methodParameters.Length];
			var inputParameters = new object [methodParameters.Length];

			log_coreclr ($"InvokeMethod (0x{method_gchandle.ToString ("x")} = {method.DeclaringType.FullName}::{method}, 0x{instance_gchandle.ToString ("x")} => {instance}, 0x{native_parameters.ToString ("x")})");
			unsafe {
				IntPtr* nativeParams = (IntPtr*) native_parameters;
				for (var i = 0; i < methodParameters.Length; i++) {
					var nativeParam = nativeParams [i];
					var p = methodParameters [i];
					var paramType = p.ParameterType;
					if (paramType.IsByRef)
						paramType = paramType.GetElementType ();
					log_coreclr ($"    Argument #{i + 1}: Type = {p.ParameterType.FullName} IsByRef: {p.ParameterType.IsByRef} IsOut: {p.IsOut} IsClass: {paramType.IsClass} IsInterface: {paramType.IsInterface} NativeParameter: 0x{nativeParam.ToString ("x")}");
				}
			}

			var anyUnknown = false;
			unsafe {
				IntPtr* nativeParams = (IntPtr*) native_parameters;
				for (var i = 0; i < methodParameters.Length; i++) {
					var nativeParam = nativeParams [i];
					var p = methodParameters [i];
					var paramType = p.ParameterType;
					var isByRef = paramType.IsByRef;
					if (isByRef)
						paramType = paramType.GetElementType ();
					log_coreclr ($"    Marshalling #{i + 1}: IntPtr => 0x{nativeParam.ToString ("x")} => {p.ParameterType.FullName} [...]");

					if (paramType == typeof (IntPtr)) {
						log_coreclr ($"        IntPtr");
						if (isByRef) {
							if (p.IsOut) {
								parameters [i] = Marshal.AllocHGlobal (IntPtr.Size);
							} else {
								parameters [i] = nativeParam == IntPtr.Zero ? IntPtr.Zero : Marshal.ReadIntPtr (nativeParam);
							}
						} else {
							parameters [i] = nativeParam == IntPtr.Zero ? IntPtr.Zero : Marshal.ReadIntPtr (nativeParam);
						}
						log_coreclr ($"        IntPtr: 0x{((IntPtr) parameters [i]).ToString ("x")}");
					} else if (paramType.IsClass || paramType.IsInterface || (paramType.IsValueType && IsNullable (paramType))) {
						log_coreclr ($"        IsClass/IsInterface/IsNullable IsByRef: {isByRef} IsOut: {p.IsOut}");
						var obj_gchandle = IntPtr.Zero;
						if (nativeParam != IntPtr.Zero) {
							unsafe {
								MonoObject* mono_obj;
								if (isByRef) {
									mono_obj = *(MonoObject**) nativeParam;
								} else {
									mono_obj = (MonoObject*) nativeParam;
								}
								if (mono_obj != null)
									obj_gchandle = mono_obj->GCHandle;
							}
							if (obj_gchandle != IntPtr.Zero)
								parameters [i] = GCHandle.FromIntPtr (obj_gchandle).Target;
						}
						if (parameters [i] is bool[] arr) {
							log_coreclr ($"        Bool array with length {arr.Length}: first element: {(arr.Length > 0 ? arr [0].ToString () : "N/A")}");
						}
						log_coreclr ($"        IsClass/IsInterface (GCHandle: 0x{obj_gchandle.ToString ("x")}): {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)}");
					} else if (paramType.IsValueType) {
						log_coreclr ($"        IsValueType IsByRef: {isByRef} IsOut: {p.IsOut}");
						object vt = null;
						IntPtr ptr = nativeParam;
						if (nativeParam != IntPtr.Zero) {
							if (ptr != IntPtr.Zero) {
								log_coreclr ($"        IsValueType IsByRef: {isByRef} IsOut: {p.IsOut} ptr: 0x{ptr.ToString ("x")} ParameterType: {paramType}");
								var structType = paramType;
								Type enumType = null;
								if (IsNullable (structType))
									structType = Nullable.GetUnderlyingType (structType);
								if (structType.IsEnum) {
									enumType = structType;
									structType = Enum.GetUnderlyingType (structType);
								}
								vt = PtrToStructure (ptr, structType);
								if (enumType != null)
									vt = Enum.ToObject (enumType, vt);
							}
						}
						parameters [i] = vt;
						log_coreclr ($"        IsValueType (ptr: 0x{ptr.ToString ("x")}): {(parameters [i] == null ? "<null>" : parameters [i].ToString ())}");
					} else {
						log_coreclr ($"        Marshalling unknown: {p.ParameterType.FullName}");
						anyUnknown = true;
					}
				}
			}

			parameters.CopyTo (inputParameters, 0);

			if (anyUnknown) {
				throw new NotImplementedException ($"Unknown method parameters!");
			}

			log_coreclr ($"InvokeMethod (0x{method_gchandle.ToString ("x")} = {method.DeclaringType.FullName}::{method}, 0x{instance_gchandle.ToString ("x")} => {instance}, 0x{native_parameters.ToString ("x")}) INVOKING");

			var rv = method.Invoke (instance, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance, null, parameters, null);

			var byrefParameterCount = 0;
			for (var i = 0; i < methodParameters.Length; i++) {
				var p = methodParameters [i];
				if (!p.IsOut && !p.ParameterType.IsByRef)
					continue;
				byrefParameterCount++;

				log_coreclr ($"    Marshalling #{i + 1} back (Type: {p.ParameterType.FullName}) value: {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)}");

				var parameterType = p.ParameterType.GetElementType ();
				var isMonoObject = parameterType.IsClass || parameterType.IsInterface || (parameterType.IsValueType && IsNullable (parameterType));

				if (parameters [i] == inputParameters [i]) {
					log_coreclr ($"        The argument didn't change, no marshalling required");
					if (parameters [i] != null && parameterType != typeof (IntPtr) && isMonoObject) {
						unsafe {
							IntPtr** nativeParams = (IntPtr**) native_parameters;
							IntPtr* nativeParam = nativeParams [i];
							xamarin_mono_object_retain (*nativeParam);
						}
					}
					continue;
				}

				if (parameterType == typeof (IntPtr)) {
					log_coreclr ($"        IntPtr: 0x{((IntPtr) parameters [i]).ToString ("x")} => Type: {parameters [i]?.GetType ()}");
					unsafe {
						IntPtr** nativeParams = (IntPtr**) native_parameters;
						IntPtr* nativeParam = nativeParams [i];
						if (nativeParam != null)
							*nativeParam = (IntPtr) parameters [i];
					}
				} else if (isMonoObject) {
					var ptr = GetMonoObject (parameters [i]);
					log_coreclr ($"        IsClass/IsInterface/IsNullable: {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)}");
					unsafe {
						IntPtr** nativeParams = (IntPtr**) native_parameters;
						IntPtr* nativeParam = nativeParams [i];
						log_coreclr ($"            nativeParam: 0x{((IntPtr) nativeParam).ToString ("x")}");
						if (nativeParam != null)
							*nativeParam = ptr;
					}
					log_coreclr ($"        IsClass/IsInterface: {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)} -> MonoObject: 0x{ptr.ToString ("x")}");
				} else if (parameterType.IsValueType) {
					log_coreclr ($"        IsValueType");
					IntPtr nativeParam;
					unsafe {
						IntPtr* nativeParams = (IntPtr*) native_parameters;
						nativeParam = nativeParams [i];
					}
					if (nativeParam != IntPtr.Zero) {
						log_coreclr ($"        IsValueType nativeParam: 0x{nativeParam.ToString ("x")}");
						StructureToPtr (parameters [i], nativeParam);
					}
					log_coreclr ($"        IsValueType nativeParam: 0x{nativeParam.ToString ("x")}): {(parameters [i] == null ? "<null>" : parameters [i].ToString ())}");
				} else {
					log_coreclr ($"        UNKNOWN BYREF PARAMETER TYPE: {p.ParameterType}");
					throw new NotImplementedException ($"Unknown byref parameter type: {p.ParameterType}");
				}
			}

			log_coreclr ($"InvokeMethod (0x{method_gchandle.ToString ("x")} = {method}, 0x{instance_gchandle.ToString ("x")} => {instance}, 0x{native_parameters.ToString ("x")}) Ref parameters: {byrefParameterCount} Return value of type {rv?.GetType ()} {(rv is bool ? rv : null)}");

			if (rv == null)
				return IntPtr.Zero;

			return GetMonoObject (rv);
		}

		static object PtrToStructure (IntPtr ptr, Type type)
		{
			if (ptr == IntPtr.Zero)
				return null;
			if (type == typeof (bool))
				return Marshal.ReadByte (ptr) != 0;
			else if (type == typeof (char))
				return (char) Marshal.ReadInt16 (ptr);
			return Marshal.PtrToStructure (ptr, type);
		}

		static void StructureToPtr (object obj, IntPtr ptr)
		{
			if (obj == null)
				return;

			if (obj is bool b)
				Marshal.WriteByte (ptr, b ? (byte) 1 : (byte) 0);
			else if (obj is char c)
				Marshal.WriteInt16 (ptr, (short) c);
			else
				Marshal.StructureToPtr (obj, ptr, false);
		}

		[DllImport ("__Internal")]
		static extern IntPtr xamarin_find_mono_class (IntPtr gchandle, string name_space, string name);

		[DllImport ("__Internal")]
		static extern void xamarin_mono_object_retain (IntPtr mono_object);

		[DllImport ("__Internal")]
		static extern void xamarin_switch_gchandle (IntPtr obj, [MarshalAs (UnmanagedType.I1)] bool to_weak);

		static IntPtr FindMonoClass (Type type)
		{
			var handle = GCHandle.Alloc (type);
			try {
				return xamarin_find_mono_class (GCHandle.ToIntPtr (handle), type.Namespace, type.Name);
			} finally {
				handle.Free ();
			}
		}

		static IntPtr CreateMonoMethod (IntPtr handle, MethodBase method)
		{
			var rv = new MonoMethod ();
			rv.Name = GetMethodName (handle);
			rv.Class = FindMonoClass (method.DeclaringType);
			rv.GCHandle = handle;
			return MarshalStructure (rv);
		}

		static IntPtr CreateMonoType (IntPtr handle)
		{
			var rv = new MonoType ();
			rv.FullName = TypeGetFullName (handle);
			rv.Name = rv.FullName;
			rv.GCHandle = handle;
			return MarshalStructure (rv);
		}

		static IntPtr GetMonoObject (IntPtr gchandle)
		{
			return GetMonoObject (GetGCHandleTarget (gchandle));
		}

		// Returns a retained MonoObject. Caller must release.
		internal static IntPtr GetMonoObject (object obj)
		{
			if (obj == null)
				return IntPtr.Zero;

			return GetMonoObjectImpl (obj);
		}

		static IntPtr GetMonoObjectImpl (object obj)
		{
			var handle = AllocGCHandle (obj);
			var typename = GetGCHandleType (handle);
			IntPtr rv;
			if (obj is MethodBase mb) {
				var mobj = new MonoReflectionMethod ();
				mobj.Object.ObjectKind = MonoObjectType.MonoReflectionMethod;
				mobj.Object.GCHandle = handle;
				mobj.Object.TypeName = typename;
				mobj.Method = CreateMonoMethod (handle, mb);
				rv = MarshalStructure (mobj);
				log_coreclr ($"GetMonoObject (0x{handle.ToString ("x")} => {typename}) => {mobj.Object.ObjectKind} => 0x{rv.ToString ("x")}");
			} else if (obj is Type) {
				var mobj = new MonoReflectionType ();
				mobj.Object.ObjectKind = MonoObjectType.MonoReflectionType;
				mobj.Object.GCHandle = handle;
				mobj.Object.TypeName = typename;
				mobj.Type = CreateMonoType (handle);
				rv = MarshalStructure (mobj);
				log_coreclr ($"GetMonoObject (0x{handle.ToString ("x")} => {typename}) => {mobj.Object.ObjectKind} => 0x{rv.ToString ("x")}");
			} else if (obj is Array array) {
				var mobj = new MonoArray ();
				mobj.Object.ObjectKind = MonoObjectType.MonoArray;
				mobj.Object.GCHandle = handle;
				mobj.Object.TypeName = typename;
				mobj.Length = (ulong) array.Length;
				rv = MarshalStructure (mobj);
				log_coreclr ($"GetMonoObject (0x{handle.ToString ("x")} => {typename}) => {mobj.Object.ObjectKind} => 0x{rv.ToString ("x")}");
			} else if (obj is string str) {
				var mobj = new MonoString ();
				mobj.Object.ObjectKind = MonoObjectType.MonoString;
				mobj.Object.GCHandle = handle;
				mobj.Object.TypeName = typename;
				rv = MarshalStructure (mobj);
				log_coreclr ($"GetMonoObject (0x{handle.ToString ("x")} => {typename}) => {mobj.Object.ObjectKind} => 0x{rv.ToString ("x")}");
			} else {
				var mobj = new MonoObject ();
				mobj.GCHandle = handle;
				mobj.TypeName = typename;
				mobj.StructValue = WriteStructure (handle);
				mobj.ObjectKind = MonoObjectType.MonoObject;
				rv = MarshalStructure (mobj);
				log_coreclr ($"GetMonoObject (0x{handle.ToString ("x")} => {typename}) => {mobj.ObjectKind} => 0x{rv.ToString ("x")}");
			}

			unsafe {
				((MonoObject*) rv)->ReferenceCount = 1;
			}

			// xamarin_bridge_log_monoobject (rv, Environment.StackTrace);

			return rv;
		}

		[DllImport ("__Internal", CharSet = CharSet.Auto)]
		static extern void xamarin_bridge_log_monoobject (IntPtr mono_object, string stack_trace);

		static IntPtr MarshalStructure<T> (T value) where T: struct
		{
			var rv = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (T)));
			StructureToPtr (value, rv);
			return rv;
		}

		static IntPtr GetManagedType (IntPtr type_name)
		{
			var tn = Marshal.PtrToStringAuto (type_name);
			log_coreclr ($"GetManagedType ({tn})");
			var tp = Type.GetType (tn, true);
			return AllocGCHandle (tp);
		}

		static IntPtr WriteStructure (IntPtr gchandle)
		{
			var obj = GetGCHandleTarget (gchandle);
			if (obj == null)
				return IntPtr.Zero;
			if (!obj.GetType ().IsValueType) {
				// log_coreclr ($"StructureToPtr (0x{gchandle.ToString ("x")} = {obj?.GetType ()?.FullName}, <not a value type>)");
				return IntPtr.Zero;
			}

			var structType = obj.GetType ();
			if (structType.IsEnum) {
				structType = Enum.GetUnderlyingType (structType);
				obj = Convert.ChangeType (obj, structType);
			}

			var size = SizeOf (obj.GetType ());
			var output = Marshal.AllocHGlobal (size);

			StructureToPtr (obj, output);

			var sb = new System.Text.StringBuilder ();
			var l = SizeOf (obj.GetType ());
			sb.Append ($"StructureToPtr (0x{gchandle.ToString ("x")} = {obj?.GetType ()?.FullName}, 0x{output.ToString ("x")}) Size: {l} -- ");
			for (var i = 0; i < l; i++)
				sb.Append ($" 0x{Marshal.ReadByte (output, i).ToString ("x")}");
			sb.AppendLine ();
			log_coreclr (sb.ToString ());
			return output;
		}

		static bool IsInstance (IntPtr obj_gchandle, IntPtr type_gchandle)
		{
			var obj = GCHandle.FromIntPtr (obj_gchandle).Target;
			if (obj == null)
				return false;

			var type = (Type) GCHandle.FromIntPtr (type_gchandle).Target;
			var rv = type.IsAssignableFrom (obj.GetType ());

			log_coreclr ($"IsInstance ({obj.GetType ()}, {type})");

			return rv;
		}

		static bool IsDelegate (IntPtr type_gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (type_gchandle).Target;
			var rv = typeof (MulticastDelegate).IsAssignableFrom (type);
			log_coreclr ($"IsDelegate ({type.FullName}) => {rv}");
			return rv;
		}

		// This is supposed to work like mono_class_is_subclass_of
		static bool IsSubclassOf (IntPtr type1_gchandle, IntPtr type2_gchandle, bool check_interfaces)
		{
			var sb = new System.Text.StringBuilder ();

			log_coreclr ($"IsSubclassOf (0x{type1_gchandle.ToString ("x")}, 0x{type2_gchandle.ToString ("x")}, {check_interfaces})");

			if (type1_gchandle == IntPtr.Zero)
				return false;

			if (type2_gchandle == IntPtr.Zero)
				return false;

			var type1 = (Type) GCHandle.FromIntPtr (type1_gchandle).Target;
			var type2 = (Type) GCHandle.FromIntPtr (type2_gchandle).Target;

			log_coreclr ($"IsSubclassOf (0x{type1_gchandle.ToString ("x")} = {type1.FullName}, 0x{type2_gchandle.ToString ("x")} = {type2.FullName}, {check_interfaces})");

			if (check_interfaces) {
				if (type2.IsAssignableFrom (type1)) {
					log_coreclr ($"IsSubclassOf (0x{type1_gchandle.ToString ("x")} = {type1.FullName}, 0x{type2_gchandle.ToString ("x")} = {type2.FullName}, {check_interfaces}) => type2 is assignable from type1");
					return true;
				}
			} else {
				if (!type2.IsInterface) {
					var baseClass = type1;
					while (baseClass != null && baseClass != typeof (object)) {
						log_coreclr ($"IsSubclassOf (0x{type1_gchandle.ToString ("x")} = {type1.FullName}, 0x{type2_gchandle.ToString ("x")} = {type2.FullName}, {check_interfaces}) => type2 is not an interface, checking base class {baseClass.FullName}");
						if (baseClass == type2)
							return true;
						baseClass = baseClass.BaseType;
					}
				}
			}

			if (type2 == typeof (object))
				return true;

			return false;
		}

		static bool IsByRef (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			return type.IsByRef;
		}

		static bool IsValueType (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			return type.IsValueType;
		}

		static bool IsEnum (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			return type.IsEnum;
		}

		static IntPtr GetEnumBaseType (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			var baseType = type.GetEnumUnderlyingType ();
			return AllocGCHandle (baseType);
		}

		static bool IsNullable (IntPtr gchandle)
		{
			return IsNullable ((Type) GCHandle.FromIntPtr (gchandle).Target);
		}

		static bool IsNullable (Type type)
		{
			if (Nullable.GetUnderlyingType (type) != null)
				return true;
			if (type.IsGenericType && type.GetGenericTypeDefinition () == typeof (Nullable<>))
				return true;
			return false;
		}

		static IntPtr ObjectToString (IntPtr gchandle)
		{
			var obj = GetGCHandleTarget (gchandle);
			if (obj == null)
				return IntPtr.Zero;
			return Marshal.StringToHGlobalAuto (obj.ToString ());
		}

		static IntPtr ObjectGetType (IntPtr gchandle)
		{
			var obj = GCHandle.FromIntPtr (gchandle).Target;
			if (obj == null) {
				log_coreclr ($"ObjectGetType (0x{gchandle.ToString ("x")}) => null object");
				return IntPtr.Zero;
			}
			return AllocGCHandle (obj.GetType ());
		}

		static void GetNameAndNamespace (IntPtr gchandle, ref IntPtr name_space, ref IntPtr name)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			name_space = Marshal.StringToHGlobalAuto (type.Namespace);
			name = Marshal.StringToHGlobalAuto (type.Name);
		}

		static IntPtr GetElementClass (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			return AllocGCHandle (type.GetElementType ());
		}

		// typedef void (* mono_reference_queue_callback) (void* user_data);
		delegate void mono_reference_queue_callback (IntPtr user_data);

		class ReferenceQueue {
			public mono_reference_queue_callback Callback;
			public ConditionalWeakTable<object, object> Table = new ConditionalWeakTable<object, object> ();
		}

		class ReferenceQueueEntry {
			public ReferenceQueue Queue;
			public IntPtr UserData;

			~ReferenceQueueEntry ()
			{
				Queue.Callback (UserData);
			}
		}

		static IntPtr CreateGCReferenceQueue (IntPtr callback)
		{
			var queue = new ReferenceQueue ();
			queue.Callback = Marshal.GetDelegateForFunctionPointer<mono_reference_queue_callback> (callback);
			return AllocGCHandle (queue);
		}

		static void GCReferenceQueueAdd (IntPtr queue_handle, IntPtr obj_handle, IntPtr user_data)
		{
			var queue = (ReferenceQueue) GetGCHandleTarget (queue_handle);
			var obj = GetGCHandleTarget (obj_handle);
			queue.Table.Add (obj, new ReferenceQueueEntry () { Queue = queue, UserData = user_data });
		}

		static IntPtr StringToUtf8 (IntPtr gchandle)
		{
			var str = (string) GCHandle.FromIntPtr (gchandle).Target;
			if (str == null)
				return IntPtr.Zero;
			return Marshal.StringToHGlobalAuto (str);
		}

		static IntPtr NewString (IntPtr text)
		{
			if (text == IntPtr.Zero)
				return IntPtr.Zero;

			return GetMonoObject (Marshal.PtrToStringAuto (text));
		}

		class MonoHashTable : IEqualityComparer<IntPtr> {
			Dictionary<IntPtr, object> Table;
			HashFunc Hash;
			EqualityFunc Compare;

			public delegate uint HashFunc (IntPtr ptr);
			public delegate bool EqualityFunc (IntPtr a, IntPtr b);

			public MonoHashTable (IntPtr hash_func, IntPtr compare_func)
			{
				Table = new Dictionary<IntPtr, object> ();
				Hash = Marshal.GetDelegateForFunctionPointer<HashFunc> (hash_func);
				Compare = Marshal.GetDelegateForFunctionPointer<EqualityFunc> (compare_func);
			}

			public void Insert (IntPtr key, object obj)
			{
				log_coreclr ($"MonoHashTable.Add (0x{key.ToString ("x")}, {obj?.GetType ()})");
				Table [key] = obj;
			}

			public object Lookup (IntPtr key)
			{
				if (Table.TryGetValue (key, out var value))
					return value;
				return null;
			}

			bool IEqualityComparer<IntPtr>.Equals (IntPtr x, IntPtr y)
			{
				return Compare (x, y);
			}

			int IEqualityComparer<IntPtr>.GetHashCode (IntPtr obj)
			{
				unchecked {
					return (int) Hash (obj);
				}
			}
		}

		static IntPtr CreateMonoHashTable (IntPtr hash_method, IntPtr compare_method, int type)
		{
			if (type != 2 /* MONO_HASH_VALUE_GC */)
				throw new NotSupportedException ($"Unknown hash table type: {type}");

			var dict = new MonoHashTable (hash_method, compare_method);
			return AllocGCHandle (dict);
		}

		static void MonoHashTableInsert (IntPtr gchandle, IntPtr key, IntPtr value_gchandle)
		{
			var dict = (MonoHashTable) GetGCHandleTarget (gchandle);
			var value = GetGCHandleTarget (value_gchandle);
			dict.Insert (key, value);
		}

		static IntPtr MonoHashTableLookup (IntPtr gchandle, IntPtr key)
		{
			var dict = (MonoHashTable) GetGCHandleTarget (gchandle);
			return GetMonoObject (dict.Lookup (key));
		}

		static IntPtr GetNullableElementType (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			var elementType = type.GetGenericArguments () [0];
			return AllocGCHandle (elementType);
		}

		static IntPtr CreateArray (IntPtr gchandle, ulong elements)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			var obj = Array.CreateInstance (type, (int) elements);
			return GetMonoObject (obj);
		}

		[DllImport ("libc")]
		static extern IntPtr memcpy (IntPtr dest, IntPtr src, nint n);

		static IntPtr GetArrayData (IntPtr gchandle)
		{
			if (gchandle == IntPtr.Zero)
				return IntPtr.Zero;

			var array = (Array) GCHandle.FromIntPtr (gchandle).Target;
			var elementSize = SizeOf (array.GetType ().GetElementType ());
			var dataSize = elementSize * array.Length;
			var rv = Marshal.AllocHGlobal (dataSize);

			log_coreclr ($"GetArrayData (0x{gchandle.ToString ("x")}) Type: {array.GetType ()} Array Length: {array.Length} Element Size: {elementSize} rv: 0x{rv.ToString ("x")}");

			if (array.Length > 0) {
				if (array is bool[] arr) {
					log_coreclr ($"        Bool array with length {arr.Length}: first element: {(arr.Length > 0 ? arr [0].ToString () : "N/A")}");
				}
				var arrayType = array.GetType ().GetElementType ();
				if (arrayType.IsEnum) {
					// this is quite slow... here we copy the enum array to an array of the underlying type
					// See: https://github.com/dotnet/runtime/issues/48907
					var enumType = Enum.GetUnderlyingType (arrayType);
					var integralArray = Array.CreateInstance (enumType, array.Length);
					for (var i = 0; i < array.Length; i++)
						integralArray.SetValue (Convert.ChangeType (array.GetValue (i), enumType), i);
					array = integralArray;
					log_coreclr ($" => converted to array of {enumType}");
				}

				var pinned = GCHandle.Alloc (array, GCHandleType.Pinned);
				try {
					var addr = pinned.AddrOfPinnedObject ();
					memcpy (rv, addr, dataSize);
				} finally {
					pinned.Free ();
				}
			}

			var sb = new System.Text.StringBuilder ();
			for (var i = 0; i < Math.Min (16, dataSize); i++) {
				sb.Append ($" 0x{Marshal.ReadByte (rv, i).ToString ("x")}");
			}
			log_coreclr ($"    => {sb.ToString ()}");

			return rv;
		}

		static ulong GetArrayLength (IntPtr gchandle)
		{
			var array = (Array) GCHandle.FromIntPtr (gchandle).Target;
			return (ulong) array.Length;
		}

		static void SetArrayObjectValue (IntPtr gchandle, int index, IntPtr obj_gchandle)
		{
			var array = (Array) GCHandle.FromIntPtr (gchandle).Target;
			var obj = GCHandle.FromIntPtr (obj_gchandle).Target;
			array.SetValue (obj, index);
			log_coreclr ($"SetArrayObjectValue (0x{gchandle.ToString ("x")}, {index}, {obj}) {obj?.GetType ()}");
		}

		static IntPtr GetArrayObjectValue (IntPtr gchandle, int index)
		{
			var array = (Array) GCHandle.FromIntPtr (gchandle).Target;
			var obj = array.GetValue (index);
			log_coreclr ($"GetArrayObjectValue (0x{gchandle.ToString ("x")}, {index}) => {obj} huh? {obj?.GetType ()}");
			return GetMonoObject (obj);
		}

		static IntPtr TypeRemoveByRef (IntPtr gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			if (type.IsByRef)
				type = type.GetElementType ();
			return AllocGCHandle (type);
		}

		static void ThrowException (IntPtr gchandle)
		{
			var exc = (Exception) GCHandle.FromIntPtr (gchandle).Target;
			throw exc;
		}

		static int SizeOf (IntPtr gchandle)
		{
			return SizeOf ((Type) GCHandle.FromIntPtr (gchandle).Target);
		}

		static int SizeOf (Type type)
		{
			if (type.IsEnum) // https://github.com/dotnet/runtime/issues/12258
				type = Enum.GetUnderlyingType (type);
			return Marshal.SizeOf (type);
		}

		static IntPtr Box (IntPtr gchandle, IntPtr value)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			log_coreclr ($"Box ({type}, 0x{value.ToString ("x")})");
			var structType = type;
			Type enumType = null;

			// We can have a nullable enum value
			if (IsNullable (structType)) {
				if (value == IntPtr.Zero)
					return AllocGCHandle (null);
				structType = Nullable.GetUnderlyingType (structType);
			}

			if (structType.IsEnum) {
				// Change to underlying enum type
				enumType = structType;
				structType = Enum.GetUnderlyingType (structType);
			}

			var boxed = PtrToStructure (value, structType);
			if (enumType != null) {
				// Convert to enum value
				boxed = Enum.ToObject (enumType, boxed);
			}

			if (boxed is bool)
				log_coreclr ($"     bool boxed value: {boxed}");

			return GetMonoObject (boxed);
		}

		static IntPtr FindMethod (IntPtr klass_handle, IntPtr name_ptr, int parameter_count)
		{
			var klass = (Type) GetGCHandleTarget (klass_handle);
			if (klass == null)
				throw new ArgumentNullException (nameof (klass_handle));
			var name = Marshal.PtrToStringAuto (name_ptr);
			var methods = klass.GetMethods (BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo rv = null;
			foreach (var method in methods) {
				if (method.GetParameters ().Length != parameter_count)
					continue;
				if (method.Name != name)
					continue;
				if (rv != null)
					throw new AmbiguousMatchException ($"Found more than one method named '{name}' in {klass.FullName}' with {parameter_count} parameters.");
				rv = method;
			}
			log_coreclr ($"FindMethod (0x{klass_handle.ToString ("x")} = {klass.FullName}, {name}, {parameter_count}) => {rv}");
			return AllocGCHandle (rv);
		}
	}
}

#endif // NET && !COREBUILD
