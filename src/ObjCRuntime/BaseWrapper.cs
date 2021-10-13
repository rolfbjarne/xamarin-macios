// Copyright 2014, Xamarin Inc. All rights reserved.

#if !COREBUILD

using System;
using System.Runtime.InteropServices;
using Foundation;
using CoreFoundation;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace ObjCRuntime {

	public abstract class BaseWrapper : INativeObject, IDisposable {

		public BaseWrapper (NativeHandle handle, bool owns)
		{
			Handle = handle;
			if (!owns)
				Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}

		~BaseWrapper ()
		{
			Dispose (false);
		}

		public NativeHandle Handle { get; protected set; }

		public void Dispose ()
		{
			Dispose (true);
			GC.SuppressFinalize (this);
		}

		protected virtual void Dispose (bool disposing)
		{
			if (Handle != IntPtr.Zero) {
				Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("release"));
				Handle = IntPtr.Zero;
			}
		}
	}
}

#endif
