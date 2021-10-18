//
// Protocol.cs
//
// Copyright 2014 Xamarin Inc. All rights reserved.
//

#nullable enable

using System;
using System.Runtime.InteropServices;

using CoreFoundation;
using Foundation;

namespace ObjCRuntime {
	public partial class Protocol : NonRefcountedNativeObject {
#if !COREBUILD
		public Protocol (string name)
			: base (objc_getProtocol (name), false)
		{
			if (Handle == IntPtr.Zero)
				throw new ArgumentException (String.Format ("'{0}' is an unknown protocol", name));
		}

		public Protocol (Type type)
			: base (Runtime.GetProtocolForType (type), false)
		{
		}

		public Protocol (IntPtr handle)
			: base (handle, false)
		{
		}

		[Preserve (Conditional = true)]
		internal Protocol (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		protected override void Free ()
		{
			// Nothing to do here, protocols can't be freed.
		}

		public string? Name {
			get {
				IntPtr ptr = protocol_getName (Handle);
				return Marshal.PtrToStringAuto (ptr);
			}
		}

		public static IntPtr GetHandle (string name)
		{
			return objc_getProtocol (name);
		}

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static IntPtr objc_getProtocol (string name);

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static IntPtr objc_allocateProtocol (string name);

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static void objc_registerProtocol (IntPtr protocol);

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static void protocol_addProperty (IntPtr protocol, string name, Class.objc_attribute_prop [] attributes, int count, [MarshalAs (UnmanagedType.I1)] bool isRequired, [MarshalAs (UnmanagedType.I1)] bool isInstance);

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static void protocol_addMethodDescription (IntPtr protocol, IntPtr nameSelector, string signature, [MarshalAs (UnmanagedType.I1)] bool isRequired, [MarshalAs (UnmanagedType.I1)] bool isInstance);

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static void protocol_addProtocol (IntPtr protocol, IntPtr addition);

		[DllImport ("/usr/lib/libobjc.dylib")]
		internal extern static IntPtr protocol_getName (IntPtr protocol);
#endif
	}
}
