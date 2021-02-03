//
// Runtime.CoreCLR.cs: Supporting managed code for the CoreCLR bridge
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

using Xamarin.Bundler;

using MonoObjectPtr=System.IntPtr;

namespace ObjCRuntime {

	public partial class Runtime {
		// Keep in sync with XamarinLookupTypes in coreclr-bridge.h
		internal enum TypeLookup {
			System_Array,
			System_String,
			System_IntPtr,
			Foundation_NSNumber,
			Foundation_NSObject,
			Foundation_NSString,
			Foundation_NSValue,
			ObjCRuntime_INativeObject,
			ObjCRuntime_Runtime,
		}

		[StructLayout (LayoutKind.Sequential)]
		internal struct MonoObject {
			public int ReferenceCount;
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
		struct MonoAssembly {
			public IntPtr Name; /* char* */
			public IntPtr Image; /* MonoImage* */
		}

		// Comment out the attribute to get all printfs
		[System.Diagnostics.Conditional ("UNDEFINED")]
		static void log_coreclr (string message)
		{
			NSLog (message);
		}

		static unsafe void InitializeCoreCLRBridge (InitializationOptions* options)
		{
            delegate* unmanaged<void> beginEndCallback = (delegate* unmanaged<void>) options->reference_tracking_begin_end_callback;
            delegate* unmanaged<IntPtr, int> isReferencedCallback = (delegate* unmanaged<IntPtr, int>) options->reference_tracking_is_referenced_callback;
            delegate* unmanaged<IntPtr, void> trackedObjectEnteredFinalization = (delegate* unmanaged<IntPtr, void>) options->reference_tracking_tracked_object_entered_finalization;
			Bridge.InitializeReferenceTracking (beginEndCallback, isReferencedCallback, trackedObjectEnteredFinalization);

			Bridge.UnhandledExceptionPropagation += UnhandledExceptionPropagationHandler;

			if (options->xamarin_objc_msgsend != IntPtr.Zero)
				Bridge.SetMessageSendCallback (Bridge.MsgSendFunction.ObjCMsgSend, options->xamarin_objc_msgsend);

			if (options->xamarin_objc_msgsend_fpret != IntPtr.Zero)
				Bridge.SetMessageSendCallback (Bridge.MsgSendFunction.ObjCMsgSendFpret, options->xamarin_objc_msgsend_fpret);

			if (options->xamarin_objc_msgsend_stret != IntPtr.Zero)
				Bridge.SetMessageSendCallback (Bridge.MsgSendFunction.ObjCMsgSendStret, options->xamarin_objc_msgsend_stret);

			if (options->xamarin_objc_msgsend_super != IntPtr.Zero)
				Bridge.SetMessageSendCallback (Bridge.MsgSendFunction.ObjCMsgSendSuper, options->xamarin_objc_msgsend_super);

			if (options->xamarin_objc_msgsend_super_stret != IntPtr.Zero)
				Bridge.SetMessageSendCallback (Bridge.MsgSendFunction.ObjCMsgSendSuperStret, options->xamarin_objc_msgsend_super_stret);
		}

		static unsafe delegate* unmanaged<IntPtr, void> UnhandledExceptionPropagationHandler (Exception exception, RuntimeMethodHandle lastMethod, out IntPtr context)
		{
			var exceptionHandler = (delegate* unmanaged<IntPtr, void>) options->unhandled_exception_handler;
			context = AllocGCHandle (exception);
			return exceptionHandler;
		}

		static void SetPendingException (IntPtr gchandle)
		{
			var exc = (Exception) GetGCHandleTarget (gchandle);
			xamarin_log ($"Runtime.SetPendingException ({exc})");
			Bridge.SetMessageSendPendingExceptionForThread (exc);
		}

		// Size: 2 pointers
		internal struct TrackedObjectInfo {
			public IntPtr Handle;
			public NSObject.Flags Flags;
		}

		internal static void RegisterToggleReferenceCoreCLR (NSObject obj, IntPtr handle, bool isCustomType)
		{
			var gchandle = Bridge.CreateReferenceTrackingHandle (obj, out var info);

			unsafe {
				TrackedObjectInfo* tracked_info = (TrackedObjectInfo*) info;
				tracked_info->Handle = handle;
				tracked_info->Flags = obj.FlagsInternal;
				obj.tracked_object_info = tracked_info;
				obj.tracked_object_handle = gchandle;

				xamarin_log ($"RegisterToggleReferenceCoreCLR ({obj.GetType ().FullName}, 0x{handle.ToString ("x")}, {isCustomType}) => Info=0x{((IntPtr) info).ToString ("x")} Flags={tracked_info->Flags}");
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
		
		[StructLayout (LayoutKind.Sequential)]
		struct MethodParameter {
			public IntPtr TypeName;
			public MonoObjectPtr Type;
		}

		static unsafe IntPtr GetMethodSignature (MonoObject * methodobj, ref int parameterCount)
		{
			return GetMethodSignature ((MethodBase) GetMonoObjectTarget (methodobj), ref parameterCount);
		}

		static unsafe IntPtr GetMethodSignature (MethodBase method, ref int parameterCount)
		{
			var parameters = method.GetParameters ();
			parameterCount = parameters.Length;
			var rv = Marshal.AllocHGlobal (sizeof (MethodParameter) * parameterCount);
			MethodParameter* mparams = (MethodParameter*) rv;
			for (var i = 0; i < parameters.Length; i++) {
				var p = parameters [i];
				mparams [i].Type = GetMonoObject (p.ParameterType);
				mparams [i].TypeName = Marshal.StringToHGlobalAuto (p.ParameterType.FullName);
			}
			return rv;
		}

		static unsafe MonoObject* GetMethodReturnType (MonoObject* methodobj)
		{
			return (MonoObject *) GetMonoObject (GetMethodReturnType (GetMonoObjectTarget (methodobj)));
		}

		static object GetMethodReturnType (object method)
		{
			object rv = null;
			if (method is MethodInfo minfo)
				rv = minfo.ReturnType;
			else if (method is ConstructorInfo cinfo)
				rv = cinfo.DeclaringType;

			log_coreclr ($"Return type for {method}: {rv}");

			return rv;
		}

		static unsafe MonoObject * CreateObject (IntPtr gchandle)
		{
			var type = (Type) GetGCHandleTarget (gchandle);
			var obj = RuntimeHelpers.GetUninitializedObject (type);
			return (MonoObject *) GetMonoObject (obj);
		}

		static unsafe IntPtr GetTypeFullName (MonoObject* mobj)
		{
			return GetTypeFullName (GetMonoObjectTarget (mobj));
		}

		static IntPtr GetTypeFullName (object obj)
		{
			var type = (Type) obj;
			return Marshal.StringToHGlobalAuto (type?.FullName);
		}

		static unsafe IntPtr GetMethodFullName (MonoObject* mobj)
		{
			return GetMethodFullName (GetMonoObjectTarget (mobj));
		}

		static IntPtr GetMethodFullName (object obj)
		{
			var method = (MethodBase) obj;
			return Marshal.StringToHGlobalAuto (method?.ToString ());
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
		static extern void xamarin_mono_object_retain (IntPtr mono_object);

		[DllImport ("__Internal")]
		static extern void xamarin_switch_gchandle (IntPtr obj, [MarshalAs (UnmanagedType.I1)] bool to_weak);

		// Returns a retained MonoObject. Caller must release.
		static IntPtr GetMonoObject (IntPtr gchandle)
		{
			return GetMonoObject (GetGCHandleTarget (gchandle));
		}

		// Returns a retained MonoObject. Caller must release.
		internal static MonoObjectPtr GetMonoObject (object obj)
		{
			if (obj == null)
				return IntPtr.Zero;

			return GetMonoObjectImpl (obj);
		}

		static MonoObjectPtr GetMonoObjectImpl (object obj)
		{
			var handle = AllocGCHandle (obj);

			var mobj = new MonoObject ();
			mobj.GCHandle = handle;
			mobj.ReferenceCount = 1;
			mobj.TypeName = GetObjectTypeFullName (handle);
			mobj.StructValue = WriteStructure (handle);

			IntPtr rv = MarshalStructure (mobj);

			log_coreclr ($"GetMonoObject (0x{handle.ToString ("x")} => {Marshal.PtrToStringAuto (mobj.TypeName)}) => 0x{rv.ToString ("x")}");

			// xamarin_bridge_log_monoobject (rv, Environment.StackTrace);

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

		static bool IsDelegate (IntPtr type_gchandle)
		{
			var type = (Type) GCHandle.FromIntPtr (type_gchandle).Target;
			var rv = typeof (MulticastDelegate).IsAssignableFrom (type);
			log_coreclr ($"IsDelegate ({type.FullName}) => {rv}");
			return rv;
		}


		static unsafe bool IsSubclassOf (MonoObject* type1, MonoObject* type2, bool check_interfaces)
		{
			return IsSubclassOf ((Type) GetMonoObjectTarget (type1), (Type) GetMonoObjectTarget (type2), check_interfaces);
		}

		// This is supposed to work like mono_class_is_subclass_of
		static bool IsSubclassOf (Type type1, Type type2, bool check_interfaces)
		{
			log_coreclr ($"IsSubclassOf ({type1.FullName}, {type2.FullName}, {check_interfaces})");

			if (type1 == null || type2 == null)
				return false;

			if (check_interfaces) {
				if (type2.IsAssignableFrom (type1)) {
					log_coreclr ($"IsSubclassOf ({type1.FullName}, {type2.FullName}, {check_interfaces}) => type2 is assignable from type1");
					return true;
				}
			} else {
				if (!type2.IsInterface) {
					var baseClass = type1;
					while (baseClass != null && baseClass != typeof (object)) {
						log_coreclr ($"IsSubclassOf ({type1.FullName}, {type2.FullName}, {check_interfaces}) => type2 is not an interface, checking base class {baseClass.FullName}");
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

		static unsafe MonoObject* GetEnumBaseType (MonoObject* type)
		{
			return (MonoObject*) GetMonoObject (GetEnumBaseType ((Type) GetMonoObjectTarget (type)));
		}

		static Type GetEnumBaseType (Type type)
		{
			return type.GetEnumUnderlyingType ();
		}

		static IntPtr ObjectToString (IntPtr gchandle)
		{
			var obj = GetGCHandleTarget (gchandle);
			if (obj == null)
				return IntPtr.Zero;
			return Marshal.StringToHGlobalAuto (obj.ToString ());
		}

		static unsafe MonoObject* MonoObjectGetType (MonoObject* mobj)
		{
			return (MonoObject *) GetMonoObject (MonoObjectGetType (GetMonoObjectTarget (mobj)));
		}

		static Type MonoObjectGetType (object obj)
		{
			return obj?.GetType ();
		}

		static unsafe IntPtr GetTypeName (MonoObject* typeobj)
		{
			var type = (Type) GetMonoObjectTarget (typeobj);
			return Marshal.StringToHGlobalAuto (type?.Name);
		}

		static unsafe IntPtr GetTypeNamespace (MonoObject* typeobj)
		{
			var type = (Type) GetMonoObjectTarget (typeobj);
			return Marshal.StringToHGlobalAuto (type?.Namespace);
		}

		static unsafe MonoObject* GetElementClass (MonoObject* classobj)
		{
			var type = (Type) GetMonoObjectTarget (classobj);
			return (MonoObject*) GetMonoObject (type.GetElementType ());
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

		static unsafe IntPtr StringToUtf8 (MonoObject *obj)
		{
			var str = (string) GetMonoObjectTarget (obj);
			return Marshal.StringToHGlobalAuto (str);
		}

		static IntPtr NewString (IntPtr text)
		{
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

		static unsafe MonoObject* GetNullableElementType (MonoObject* typeobj)
		{
			var type = (Type) GetMonoObjectTarget (typeobj);
			var elementType = type.GetGenericArguments () [0];
			return (MonoObject*) GetMonoObject (elementType);
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

		static ulong GetArrayLength (MonoObjectPtr obj)
		{
			var array = (Array) GetMonoObjectTarget (obj);
			return (ulong) array.Length;
		}

		static void SetArrayObjectValue (IntPtr gchandle, int index, IntPtr obj_gchandle)
		{
			var array = (Array) GCHandle.FromIntPtr (gchandle).Target;
			var obj = GCHandle.FromIntPtr (obj_gchandle).Target;
			array.SetValue (obj, index);
			log_coreclr ($"SetArrayObjectValue (0x{gchandle.ToString ("x")}, {index}, {obj}) {obj?.GetType ()}");
		}

		static unsafe MonoObject* GetArrayObjectValue (IntPtr gchandle, int index)
		{
			var array = (Array) GCHandle.FromIntPtr (gchandle).Target;
			var obj = array.GetValue (index);
			log_coreclr ($"GetArrayObjectValue (0x{gchandle.ToString ("x")}, {index}) => {obj} huh? {obj?.GetType ()}");
			return (MonoObject*) GetMonoObject (obj);
		}

		static unsafe MonoObject* TypeToClass (MonoObject* typeobj)
		{
			var type = (Type) GetMonoObjectTarget (typeobj);
			if (type.IsByRef)
				type = type.GetElementType ();
			return (MonoObject*) GetMonoObject (type);
		}

		static int SizeOf (IntPtr gchandle)
		{
			return SizeOf ((Type) GetGCHandleTarget (gchandle));
		}

		static int SizeOf (Type type)
		{
			if (type.IsEnum) // https://github.com/dotnet/runtime/issues/12258
				type = Enum.GetUnderlyingType (type);
			return Marshal.SizeOf (type);
		}

		static unsafe MonoObject* Box (IntPtr gchandle, IntPtr value)
		{
			return (MonoObject *) GetMonoObject (BoxGCHandle (gchandle, value));
		}

		static object BoxGCHandle (IntPtr gchandle, IntPtr value)
		{
			var type = (Type) GCHandle.FromIntPtr (gchandle).Target;
			log_coreclr ($"BoxGCHandle ({type}, 0x{value.ToString ("x")})");
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

			return boxed;
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

		static unsafe MonoObject * GetMethodDeclaringType (MonoObject * mobj)
		{
			return (MonoObject *) GetMonoObject (GetMethodDeclaringType (GetMonoObjectTarget (mobj)));
		}

		static Type GetMethodDeclaringType (object obj)
		{
			var method = (MethodBase) obj;
			return method.DeclaringType;
		}

		static MonoObjectPtr LookupType (TypeLookup type)
		{
			Type rv;
			switch (type) {
			case TypeLookup.System_Array:
				rv = typeof (System.Array);
				break;
			case TypeLookup.System_String:
				rv = typeof (System.String);
				break;
			case TypeLookup.System_IntPtr:
				rv = typeof (System.IntPtr);
				break;
			case TypeLookup.Foundation_NSNumber:
				rv = typeof (Foundation.NSNumber);
				break;
			case TypeLookup.Foundation_NSObject:
				rv = typeof (Foundation.NSObject);
				break;
			case TypeLookup.Foundation_NSString:
				rv = typeof (Foundation.NSString);
				break;
			case TypeLookup.Foundation_NSValue:
				rv = typeof (Foundation.NSValue);
				break;
			case TypeLookup.ObjCRuntime_INativeObject:
				rv = typeof (ObjCRuntime.INativeObject);
				break;
			case TypeLookup.ObjCRuntime_Runtime:
				rv = typeof (ObjCRuntime.Runtime);
				break;
			default:
				throw new ArgumentOutOfRangeException (nameof (type));
			}
			return GetMonoObject (rv);
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

		[DllImport ("__Internal")]
		static extern void xamarin_mono_object_retain (ref IntPtr mono_object);
	}
}

#endif // NET && !COREBUILD
