//
// Copyright 2012-2014 Xamarin
//

#nullable enable

using System;
using System.Runtime.InteropServices;

using CoreFoundation;
using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace CoreFoundation {
	public class CFType : NativeObject, ICFType {
		[DllImport (Constants.CoreFoundationLibrary, EntryPoint="CFGetTypeID")]
		public static extern nint GetTypeID (IntPtr typeRef);

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static IntPtr CFCopyDescription (IntPtr ptr);

#if !XAMCORE_4_0
		public CFType ()
		{
		}
#endif

		internal CFType (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		public string? GetDescription (IntPtr handle)
		{
			if (handle == IntPtr.Zero)
				throw new ArgumentNullException (nameof (handle));
			
			return CFString.FromHandle (CFCopyDescription (handle));
		}
		
		[DllImport (Constants.CoreFoundationLibrary, EntryPoint="CFEqual")]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFEqual (/*CFTypeRef*/ IntPtr cf1, /*CFTypeRef*/ IntPtr cf2);

		public static bool Equal (IntPtr cf1, IntPtr cf2)
		{
			// CFEqual is not happy (but crashy) when it receive null
			if (cf1 == IntPtr.Zero)
				return cf2 == IntPtr.Zero;
			else if (cf2 == IntPtr.Zero)
				return false;
			return CFEqual (cf1, cf2);
		}
	}

	// FIXME: different file
	public class CFTypeObject : CFType, INativeObject, IDisposable, ICFType {
		NativeHandle handle;
		public NativeHandle Handle {
			get => handle;
			protected set => InitializeHandle (value);
		}

		protected CFTypeObject ()
		{
		}

		protected CFTypeObject (NativeHandle handle, bool owns)
			: this (handle, owns, false)
		{
		}

		protected CFTypeObject (NativeHandle handle, bool owns, bool verify)
		{
#if !COREBUILD
			if (verify && handle == NativeHandle.Zero && Class.ThrowOnInitFailure)
				throw new Exception ($"Could not initialize an instance of the type '{GetType ().FullName}': handle is null.\n" +
					"It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
#endif

			Handle = handle;
			if (!owns)
				Retain ();
		}

		~CFTypeObject ()
		{
			Dispose (false);
		}

		public void Dispose ()
		{
			Dispose (true);
			GC.SuppressFinalize (this);
		}

		protected virtual void Dispose (bool disposing)
		{
			if (handle != NativeHandle.Zero) {
				Release ();
				handle = NativeHandle.Zero;
			}
		}

		// <quote>If cf is NULL, this will cause a runtime error and your application will crash.</quote>
		// https://developer.apple.com/documentation/corefoundation/1521269-cfretain?language=occ
		protected virtual void Retain () => CFObject.CFRetain (GetCheckedHandle ());

		// <quote>If cf is NULL, this will cause a runtime error and your application will crash.</quote>
		// https://developer.apple.com/documentation/corefoundation/1521153-cfrelease
		protected virtual void Release () => CFObject.CFRelease (GetCheckedHandle ());

		protected virtual void InitializeHandle (IntPtr handle)
		{
#if !COREBUILD
			if (handle == IntPtr.Zero && Class.ThrowOnInitFailure) {
				throw new Exception ($"Could not initialize an instance of the type '{GetType ().FullName}': handle is null.\n" +
					"It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
			}
#endif
			this.handle = handle;
		}

		public NativeHandle GetCheckedHandle ()
		{
			if (handle == NativeHandle.Zero)
				ObjCRuntime.ThrowHelper.ThrowObjectDisposedException (this);
			return handle;
		}
	}

	public interface ICFType : INativeObject {
	}
}
