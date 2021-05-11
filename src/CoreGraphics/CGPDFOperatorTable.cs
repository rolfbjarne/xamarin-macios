// 
// CGPDFOperatorTable.cs: Implement the managed CGPDFOperatorTable bindings
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//     
// Copyright 2014 Xamarin Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using CoreFoundation;

namespace CoreGraphics {

	// CGPDFOperatorTable.h
	public class CGPDFOperatorTable : INativeObject, IDisposable {

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFOperatorTableRef */ IntPtr CGPDFOperatorTableCreate ();

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFOperatorTableRef */ IntPtr CGPDFOperatorTableRetain (/* CGPDFOperatorTableRef */ IntPtr table);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static void CGPDFOperatorTableRelease (/* CGPDFOperatorTableRef */ IntPtr table);

		// CGPDFOperatorCallback
		delegate void CGPDFOperatorCallback (/* CGPDFScannerRef */ IntPtr scanner, /* void* */ IntPtr info);

		public CGPDFOperatorTable ()
		{
			Handle = CGPDFOperatorTableCreate ();
		}

		public CGPDFOperatorTable (IntPtr handle)
		{
			CGPDFOperatorTableRetain (handle);
			Handle = handle;
		}

		[Preserve (Conditional=true)]
		internal CGPDFOperatorTable (IntPtr handle, bool owns)
		{
			if (!owns)
				CGPDFOperatorTableRetain (handle);

			Handle = handle;
		}

		~CGPDFOperatorTable ()
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
			if (Handle != IntPtr.Zero) {
				CGPDFOperatorTableRelease (Handle);
				Handle = IntPtr.Zero;
			}
		}

		public IntPtr Handle { get; private set; }

		// We need this P/Invoke for legacy AOT scenarios (since we have public API taking a 'Action<IntPtr, IntPtr>', and with this particular native function we can't wrap the delegate)
		// Unfortunately CoreCLR doesn't support generic Action delegates in P/Invokes: https://github.com/dotnet/runtime/issues/32963
		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static void CGPDFOperatorTableSetCallback (/* CGPDFOperatorTableRef */ IntPtr table, /* const char */ string name, /* CGPDFOperatorCallback */ Action<IntPtr,IntPtr> callback);

#if NET
		// This signature requires C# 9 (so .NET), and results in ugly public API.
		[DllImport (Constants.CoreGraphicsLibrary)]
		unsafe extern static void CGPDFOperatorTableSetCallback (/* CGPDFOperatorTableRef */ IntPtr table, /* const char */ string name, /* CGPDFOperatorCallback */ delegate* unmanaged<IntPtr,IntPtr> callback);
#endif

		// This signature should work everywhere, but it results in ugly public API.
		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static void CGPDFOperatorTableSetCallback (/* CGPDFOperatorTableRef */ IntPtr table, /* const char */ string name, /* CGPDFOperatorCallback */ CGPDFOperatorCallback callback);

#if MONOMAC
		// this won't work with AOT since the callback must be decorated with [MonoPInvokeCallback]
		public void SetCallback (string name, Action<CGPDFScanner,object> callback)
		{
			if (name == null)
				throw new ArgumentNullException ("name");

			if (callback == null)
				CGPDFOperatorTableSetCallback (Handle, name, (CGPDFOperatorCallback) null);
			else
				CGPDFOperatorTableSetCallback (Handle, name, new CGPDFOperatorCallback (delegate (IntPtr reserved, IntPtr gchandle) {
					// we could do 'new CGPDFScanner (reserved, true)' but we would not get `UserInfo` (managed state) back
					// we could GCHandle `userInfo` but that would (even more) diverge both code bases :(
					var scanner = GetScannerFromInfo (gchandle);
					callback (scanner, scanner != null ? scanner.UserInfo : null);
				}));
		}

		[Advice ("Use the nicer SetCallback(string,Action<CGPDFScanner,object>) API when possible.")]
#endif

		// this API is ugly - but I do not see a better way with the AOT limitation
#if NET && !MONOMAC
		[Obsolete ("Use the overload that takes a function pointer ('delegate*<IntPtr,IntPtr>') instead.")]
#endif
		public void SetCallback (string name, Action<IntPtr,IntPtr> callback)
		{
			if (name == null)
				throw new ArgumentNullException ("name");

			CGPDFOperatorTableSetCallback (Handle, name, callback);
		}

#if NET
		// this signature requires C# 9
		public unsafe void SetCallback (string name, delegate* unmanaged<IntPtr,IntPtr> callback)
		{
			if (name == null)
				throw new ArgumentNullException (nameof (name));

			CGPDFOperatorTableSetCallback (Handle, name, callback);
		}
#endif

		static public CGPDFScanner GetScannerFromInfo (IntPtr gchandle)
		{
			return GCHandle.FromIntPtr (gchandle).Target as CGPDFScanner;
		}
	}
}
