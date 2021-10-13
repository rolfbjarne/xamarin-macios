//
// NativeObject.cs: A base class for objects that have retain/release semantics plus
// a native handle.

// Authors:
//   Alex Soto
//   Miguel de Icaza
//
// Copyright 2018, 2020 Microsoft Corp
//
using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Foundation;

#nullable enable

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace CoreFoundation {
	//
	// The NativeObject class is intended to be a base class for many CoreFoundation
	// data types whose lifecycle is managed with retain and release operations, but
	// is not limited to CoreFoundation types.
	//
	// It provides the common boilerplate for this kind of objects and the Dispose
	// pattern.
	//
	// Overriding the Retain and Release methods allow for this
	// base class to be reused for other patterns that use other retain/release
	// systems.
	//
	public abstract class NativeObject : INativeObject, IDisposable {
		NativeHandle handle;
		public NativeHandle Handle {
			get => handle = ComputeHandle (handle);
			protected set => InitializeHandle (value);
		}

		protected NativeObject ()
		{
		}

		protected NativeObject (NativeHandle handle, bool owns)
			: this (handle, owns, true)
		{
		}

		protected NativeObject (IntPtr handle, bool owns, bool verify)
		{
			InitializeHandle (handle, verify);
			if (!owns && handle != IntPtr.Zero)
				Retain ();
		}

		~NativeObject ()
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

		protected void ClearHandle ()
		{
			handle = IntPtr.Zero;
		}

		// <quote>If cf is NULL, this will cause a runtime error and your application will crash.</quote>
		// https://developer.apple.com/documentation/corefoundation/1521269-cfretain?language=occ
		protected virtual void Retain () => CFObject.CFRetain (GetCheckedHandle ());

		// <quote>If cf is NULL, this will cause a runtime error and your application will crash.</quote>
		// https://developer.apple.com/documentation/corefoundation/1521153-cfrelease
		protected virtual void Release () => CFObject.CFRelease (GetCheckedHandle ());

		protected virtual NativeHandle ComputeHandle (NativeHandle current)
		{
			return current;
		}

		void InitializeHandle (NativeHandle handle, bool verify)
		{
#if !COREBUILD
			if (verify && handle == IntPtr.Zero && Class.ThrowOnInitFailure) {
				throw new Exception ($"Could not initialize an instance of the type '{GetType ().FullName}': handle is null.\n" +
				    "It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
			}
#endif
			this.handle = handle;
		}

		protected virtual void InitializeHandle (NativeHandle handle)
		{
			InitializeHandle (handle, true);
		}

		public NativeHandle GetCheckedHandle ()
		{
			if (handle == IntPtr.Zero)
				ObjCRuntime.ThrowHelper.ThrowObjectDisposedException (this);
			return handle;
		}
	}

	public abstract class NonRefcountedNativeObject : NativeObject {
		readonly bool owns;

		protected bool Owns { get => owns; }

#if COREBUILD
		protected NonRefcountedNativeObject () {} // Make it so that constructors in subclasses can stay inside a !COREBUILD block
#endif

		protected NonRefcountedNativeObject (IntPtr handle, bool owns)
			: base (handle, owns)
		{
			this.owns = owns;
		}

		protected sealed override void Retain ()
		{
			// Nothing to do here
		}

		protected sealed override void Release ()
		{
			// Nothing to do here
		}

#if COREBUILD
		protected virtual void Free () {} // Make this optional for COREBUILD
#else
		protected abstract void Free ();
#endif

		// Handle will be Zero after this call
		protected override void Dispose (bool disposing)
		{
			Free ();
			base.Dispose (disposing);
		}
	}
}
