//
// Runtime.CoreCLR.cs: Supporting managed code for the CoreCLR bridge
//
// Authors:
//   Rolf Bjarne Kvinge
//
// Copyright 2021 Microsoft Corp.

#if NET && !COREBUILD

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

using Foundation;

using Xamarin.Bundler;

using MonoObjectPtr=System.IntPtr;

namespace ObjCRuntime {

	public partial class Runtime {
		// This struct must be kept in sync with the _MonoObject struct in coreclr-bridge.h
		[StructLayout (LayoutKind.Sequential)]
		internal struct MonoObject {
			public int ReferenceCount;
			public IntPtr GCHandle;
		}

		// This struct must be kept in sync with the _MonoMethodSignature struct in coreclr-bridge.h
		[StructLayout (LayoutKind.Sequential)]
		unsafe struct MonoMethodSignature {
			public MonoObject* Method;
			public int ParameterCount;
			public MonoObject* ReturnType;
			public MonoObject* Parameters;
		}

		// Comment out the attribute to get all printfs
		[System.Diagnostics.Conditional ("UNDEFINED")]
		static void log_coreclr (string message)
		{
			NSLog (message);
		}

		// Returns a retained MonoObject. Caller must release.
		static IntPtr FindAssembly (IntPtr assembly_name)
		{
			var path = Marshal.PtrToStringAuto (assembly_name);
			var name = Path.GetFileNameWithoutExtension (path);

			log_coreclr ($"Runtime.FindAssembly (0x{assembly_name.ToString ("x")} = {name})");

			foreach (var asm in AppDomain.CurrentDomain.GetAssemblies ()) {
				log_coreclr ($"    Assembly from app domain: {asm.GetName ().Name}");
				if (asm.GetName ().Name == name) {
					log_coreclr ($"        Match!");
					return GetMonoObject (asm);
				}
			}

			log_coreclr ($"    Did not find the assembly in the app domain's loaded assemblies. Will try to load it.");

			var loadedAssembly = Assembly.LoadFrom (path);
			if (loadedAssembly != null) {
				log_coreclr ($"    Loaded {loadedAssembly.GetName ().Name}");
				return GetMonoObject (loadedAssembly);
			}

			log_coreclr ($"    Found no assembly named {name}");

			throw new InvalidOperationException ($"Could not find any assemblies named {name}");
		}

		static IntPtr CreateGCHandle (IntPtr gchandle, GCHandleType type)
		{
			// It's valid to create a GCHandle to a null value.
			object obj = null;
			if (gchandle != IntPtr.Zero)
				obj = GetGCHandleTarget (gchandle);
			var rv = GCHandle.Alloc (obj, type);
			return GCHandle.ToIntPtr (rv);
		}

		static void FreeGCHandle (IntPtr gchandle)
		{
			GCHandle.FromIntPtr (gchandle).Free ();
		}

		// Returns a retained MonoObject. Caller must release.
		static IntPtr GetMonoObject (IntPtr gchandle)
		{
			return GetMonoObject (GetGCHandleTarget (gchandle));
		}

		// Returns a retained MonoObject. Caller must release.
		static IntPtr GetMonoObject (object obj)
		{
			if (obj == null)
				return IntPtr.Zero;

			return GetMonoObjectImpl (obj);
		}

		// Returns a retained MonoObject. Caller must release.
		static IntPtr GetMonoObjectImpl (object obj)
		{
			var handle = AllocGCHandle (obj);

			var mobj = new MonoObject ();
			mobj.GCHandle = handle;
			mobj.ReferenceCount = 1;

			IntPtr rv = MarshalStructure (mobj);

			log_coreclr ($"GetMonoObjectImpl ({obj.GetType ()}) => 0x{rv.ToString ("x")} => GCHandle=0x{handle.ToString ("x")}");

			return rv;
		}

		static unsafe object GetMonoObjectTarget (MonoObject* mobj)
		{
			return GetMonoObjectTarget ((IntPtr) mobj);
		}

		static object GetMonoObjectTarget (MonoObjectPtr mobj)
		{
			if (mobj == IntPtr.Zero)
				return null;

			unsafe {
				MonoObject *monoobj = (MonoObject *) mobj;
				return GetGCHandleTarget (monoobj->GCHandle);
			}
		}

		static IntPtr MarshalStructure<T> (T value) where T: struct
		{
			var rv = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (T)));
			StructureToPtr (value, rv);
			return rv;
		}

		static void StructureToPtr (object obj, IntPtr ptr)
		{
			if (obj == null)
				return;

			Marshal.StructureToPtr (obj, ptr, false);
		}

		static IntPtr GetAssemblyName (IntPtr gchandle)
		{
			var asm = (Assembly) GetGCHandleTarget (gchandle);
			return Marshal.StringToHGlobalAuto (Path.GetFileName (asm.Location));
		}

		static void SetFlagsForNSObject (IntPtr gchandle, byte flags)
		{
			var obj = (NSObject) GetGCHandleTarget (gchandle);
			obj.FlagsInternal = (NSObject.Flags) flags;
		}

		static byte GetFlagsForNSObject (IntPtr gchandle)
		{
			var obj = (NSObject) GetGCHandleTarget (gchandle);
			return (byte) obj.FlagsInternal;
		}

		static IntPtr GetMethodDeclaringType (MonoObjectPtr mobj)
		{
			var method = (MethodBase) GetMonoObjectTarget (mobj);
			return GetMonoObject (method.DeclaringType);
		}

		static IntPtr ObjectGetType (MonoObjectPtr mobj)
		{
			var obj = GetMonoObjectTarget (mobj);
			if (obj == null) {
				log_coreclr ($"ObjectGetType (0x{mobj.ToString ("x")}) => null object");
				return IntPtr.Zero;
			}
			return GetMonoObject (obj.GetType ());
		}

		unsafe static bool IsDelegate (MonoObject* typeobj)
		{
			var type = (Type) GetMonoObjectTarget (typeobj);
			var rv = typeof (MulticastDelegate).IsAssignableFrom (type);
			log_coreclr ($"IsDelegate ({type.FullName}) => {rv}");
			return rv;
		}

		static bool IsInstance (MonoObjectPtr mobj, MonoObjectPtr mtype)
		{
			var obj = GetMonoObjectTarget (mobj);
			if (obj == null)
				return false;

			var type = (Type) GetMonoObjectTarget (mtype);
			var rv = type.IsAssignableFrom (obj.GetType ());

			log_coreclr ($"IsInstance ({obj.GetType ()}, {type})");

			return rv;
		}

		static unsafe IntPtr GetMethodSignature (MonoObject* methodobj)
		{
			var method = (MethodBase) GetMonoObjectTarget (methodobj);
			var parameters = method.GetParameters ();
			var parameterCount = parameters.Length;
			var rv = Marshal.AllocHGlobal (sizeof (MonoMethodSignature) + sizeof (MonoObjectPtr) * parameterCount);

			MonoMethodSignature* signature = (MonoMethodSignature *) rv;
			signature->Method = methodobj;
			xamarin_mono_object_retain (methodobj);
			signature->ParameterCount = parameterCount;
			signature->ReturnType = (MonoObject *) GetMonoObject (GetMethodReturnType (method));

			MonoObject** mparams = &signature->Parameters;
			for (var i = 0; i < parameterCount; i++) {
				var p = parameters [i];
				mparams [i] = (MonoObject *) GetMonoObject (p.ParameterType);
			}

			return rv;
		}

		static Type GetMethodReturnType (MethodBase method)
		{
			if (method is MethodInfo minfo)
				return minfo.ReturnType;

			// Constructors return the instance that was created, which is the declaring type of the constructor.
			if (method is ConstructorInfo cinfo)
				return cinfo.DeclaringType;

			return null;
		}

		// This should work like mono_class_from_mono_type.
		static unsafe MonoObject* TypeToClass (MonoObject* typeobj)
		{
			var type = (Type) GetMonoObjectTarget (typeobj);
			if (type.IsByRef)
				type = type.GetElementType ();
			return (MonoObject *) GetMonoObject (type);
		}

		static unsafe MonoObject* InvokeMethod (MonoObject* methodobj, MonoObject* instanceobj, IntPtr native_parameters)
		{
			var method = (MethodBase) GetMonoObjectTarget (methodobj);
			var instance = GetMonoObjectTarget (instanceobj);
			var rv = InvokeMethod (method, instance, native_parameters);
			return (MonoObject *) GetMonoObject (rv);
		}

		// Return value: NULL or a MonoObject* that must be released with xamarin_mono_object_safe_release.
		// Any MonoObject* ref parameters must also be retained and must be released with xamarin_mono_object_release.
		static object InvokeMethod (MethodBase method, object instance, IntPtr native_parameters)
		{
			var methodParameters = method.GetParameters ();
			var parameters = new object [methodParameters.Length];
			var inputParameters = new object [methodParameters.Length];
			var nativeParameters = new IntPtr [methodParameters.Length];

			// Copy native array of void* to managed array of IntPtr to make the subsequent code simpler.
			unsafe {
				IntPtr* nativeParams = (IntPtr*) native_parameters;
				for (var i = 0; i < methodParameters.Length; i++) {
					nativeParameters [i] = nativeParams [i];
				}
			}

			// Log our input
			log_coreclr ($"InvokeMethod ({method.DeclaringType.FullName}::{method}, {instance}, 0x{native_parameters.ToString ("x")})");
			for (var i = 0; i < methodParameters.Length; i++) {
				var nativeParam = nativeParameters [i];
				var p = methodParameters [i];
				var paramType = p.ParameterType;
				if (paramType.IsByRef)
					paramType = paramType.GetElementType ();
				log_coreclr ($"    Argument #{i + 1}: Type = {p.ParameterType.FullName} IsByRef: {p.ParameterType.IsByRef} IsOut: {p.IsOut} IsClass: {paramType.IsClass} IsInterface: {paramType.IsInterface} NativeParameter: 0x{nativeParam.ToString ("x")}");
			}

			// Process the arguments, and convert to what MethodBase.Invoke expects
			for (var i = 0; i < methodParameters.Length; i++) {
				var nativeParam = nativeParameters [i];
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
					log_coreclr ($"            => 0x{((IntPtr) parameters [i]).ToString ("x")}");
				} else if (paramType.IsClass || paramType.IsInterface || (paramType.IsValueType && IsNullable (paramType))) {
					log_coreclr ($"        IsClass/IsInterface/IsNullable IsByRef: {isByRef} IsOut: {p.IsOut} ParameterType: {paramType}");
					if (nativeParam != IntPtr.Zero) {
						unsafe {
							MonoObject* mono_obj = (MonoObject *) nativeParam;
							// dereference if it's a byref type
							if (isByRef)
								mono_obj = *(MonoObject**) mono_obj;
							// get the object
							parameters [i] = GetMonoObjectTarget (mono_obj);
						}
					}
					log_coreclr ($"            => {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)}");
				} else if (paramType.IsValueType) {
					log_coreclr ($"        IsValueType IsByRef: {isByRef} IsOut: {p.IsOut} nativeParam: 0x{nativeParam.ToString ("x")} ParameterType: {paramType}");
					if (nativeParam != IntPtr.Zero) {
						// We need to unwrap nullable types and enum types to their underlying struct type.
						var structType = paramType;
						Type enumType = null;
						if (IsNullable (structType))
							structType = Nullable.GetUnderlyingType (structType);
						if (structType.IsEnum) {
							enumType = structType;
							structType = Enum.GetUnderlyingType (structType);
						}
						// convert the pointer to the corresponding structure
						var vt = PtrToStructure (nativeParam, structType);
						// convert the structure to the enum type if that's what we need
						if (enumType != null)
							vt = Enum.ToObject (enumType, vt);
						parameters [i] = vt;
					}
					log_coreclr ($"            => {(parameters [i] == null ? "<null>" : parameters [i].ToString ())}");
				} else {
					throw ErrorHelper.CreateError (8037, Errors.MX8037 /* Don't know how to marshal the parameter of type {p.ParameterType.FullName} for parameter {p.Name} in call to {method} */, p.ParameterType.FullName, p.Name, method);
				}
			}

			// Make a copy of the array of parameters, so that we can figure out if there were any ref parameters that the method modified.
			parameters.CopyTo (inputParameters, 0);

			// Call the actual method
			log_coreclr ($"    Invoking...");

			var rv = method.Invoke (instance, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance, null, parameters, null);

			// Copy any byref parameters back out again
			var byrefParameterCount = 0;
			for (var i = 0; i < methodParameters.Length; i++) {
				var p = methodParameters [i];
				if (!p.IsOut && !p.ParameterType.IsByRef)
					continue;

				byrefParameterCount++;

				log_coreclr ($"    Marshalling #{i + 1} back (Type: {p.ParameterType.FullName}) value: {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)}");

				var parameterType = p.ParameterType.GetElementType ();
				var isMonoObject = parameterType.IsClass || parameterType.IsInterface || (parameterType.IsValueType && IsNullable (parameterType));

				var nativeParam = nativeParameters [i];

				if (nativeParam == IntPtr.Zero) {
					log_coreclr ($"    No output pointer was provided.");
					continue;
				}

				if (parameters [i] == inputParameters [i]) {
					log_coreclr ($"        The argument didn't change, no marshalling required");
					if (parameters [i] != null && parameterType != typeof (IntPtr) && isMonoObject) {
						// byref parameters must be retained
						xamarin_mono_object_retain (ref nativeParam);
					}
					continue;
				}

				if (parameterType == typeof (IntPtr)) {
					Marshal.WriteIntPtr (nativeParam, (IntPtr) parameters [i]);
					log_coreclr ($"        IntPtr: 0x{((IntPtr) parameters [i]).ToString ("x")} => Type: {parameters [i]?.GetType ()} nativeParam: 0x{nativeParam.ToString ("x")}");
				} else if (isMonoObject) {
					var ptr = GetMonoObject (parameters [i]);
					Marshal.WriteIntPtr (nativeParam, ptr);
					log_coreclr ($"        IsClass/IsInterface/IsNullable: {(parameters [i] == null ? "<null>" : parameters [i].GetType ().FullName)}  nativeParam: 0x{nativeParam.ToString ("x")} -> MonoObject: 0x{ptr.ToString ("x")}");
				} else if (parameterType.IsValueType) {
					StructureToPtr (parameters [i], nativeParam);
					log_coreclr ($"        IsValueType: {(parameters [i] == null ? "<null>" : parameters [i].ToString ())} nativeParam: 0x{nativeParam.ToString ("x")}");
				} else {
					throw ErrorHelper.CreateError (8038, Errors.MX8038 /* Don't know how to marshal back the parameter of type {p.ParameterType.FullName} for parameter {p.Name} in call to {method} */, p.ParameterType.FullName, p.Name, method);
				}
			}

			// we're done!
			log_coreclr ($"    Invoke complete with {byrefParameterCount} ref parameters and return value of type {rv?.GetType ()}");

			return rv;
		}

		static bool IsNullable (Type type)
		{
			if (Nullable.GetUnderlyingType (type) != null)
				return true;

			if (type.IsGenericType && type.GetGenericTypeDefinition () == typeof (Nullable<>))
				return true;

			return false;
		}

		static object PtrToStructure (IntPtr ptr, Type type)
		{
			if (ptr == IntPtr.Zero)
				return null;

			return Marshal.PtrToStructure (ptr, type);
		}

		[DllImport ("__Internal")]
		static extern void xamarin_mono_object_retain (ref IntPtr mono_object);

		[DllImport ("__Internal")]
		unsafe static extern void xamarin_mono_object_retain (MonoObject* mono_object);
	}
}

#endif // NET && !COREBUILD
