//
// MonoMac.CoreServices.CFHTTPAuthentication
//
// Authors:
//      Martin Baulig (martin.baulig@gmail.com)
//
// Copyright 2012-2014 Xamarin Inc. (http://www.xamarin.com)
//

#nullable enable

using System;
using System.Net;
using System.Runtime.InteropServices;
using Foundation;
using CoreFoundation;
using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

// CFHTTPAuthentication is in CFNetwork.framework, no idea why it ended up in CoreServices when it was bound.
#if XAMCORE_4_0
namespace CFNetwork {
#else
namespace CoreServices {
#endif

	public class CFHTTPAuthentication : CFType {
		internal CFHTTPAuthentication (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.CFNetworkLibrary, EntryPoint="CFHTTPAuthenticationGetTypeID")]
		public extern static /* CFTypeID */ nint GetTypeID ();

		[DllImport (Constants.CFNetworkLibrary)]
		extern static /* CFHTTPAuthenticationRef */ IntPtr CFHTTPAuthenticationCreateFromResponse (/* CFAllocatorRef */ IntPtr alloc, /* CFHTTPMessageRef */ IntPtr response);

		public static CFHTTPAuthentication? CreateFromResponse (CFHTTPMessage response)
		{
			if (response is null)
				throw new ArgumentNullException (nameof (response));

			if (response.IsRequest)
				throw new InvalidOperationException ();

			var handle = CFHTTPAuthenticationCreateFromResponse (IntPtr.Zero, response.Handle);
			if (handle == IntPtr.Zero)
				return null;

			return new CFHTTPAuthentication (handle, true);
		}

		[DllImport (Constants.CFNetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static /* Boolean */ bool CFHTTPAuthenticationIsValid (/* CFHTTPAuthenticationRef */ IntPtr auth, /* CFStreamError* */ IntPtr error);

		public bool IsValid {
			get { return CFHTTPAuthenticationIsValid (Handle, IntPtr.Zero); }
		}

		[DllImport (Constants.CFNetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static /* Boolean */ bool CFHTTPAuthenticationAppliesToRequest (/* CFHTTPAuthenticationRef */ IntPtr auth, /* CFHTTPMessageRef */ IntPtr request);

		public bool AppliesToRequest (CFHTTPMessage request)
		{
			if (request is null)
				throw new ArgumentNullException (nameof (request));

			if (!request.IsRequest)
				throw new InvalidOperationException ();

			return CFHTTPAuthenticationAppliesToRequest (Handle, request.Handle);
		}

		[DllImport (Constants.CFNetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static /* Boolean */ bool CFHTTPAuthenticationRequiresAccountDomain (/* CFHTTPAuthenticationRef */ IntPtr auth);

		public bool RequiresAccountDomain {
			get { return CFHTTPAuthenticationRequiresAccountDomain (Handle); }
		}

		[DllImport (Constants.CFNetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static /* Boolean */ bool CFHTTPAuthenticationRequiresOrderedRequests (/* CFHTTPAuthenticationRef */ IntPtr auth);

		public bool RequiresOrderedRequests {
			get { return CFHTTPAuthenticationRequiresOrderedRequests (Handle); }
		}

		[DllImport (Constants.CFNetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static /* Boolean */ bool CFHTTPAuthenticationRequiresUserNameAndPassword (/* CFHTTPAuthenticationRef */ IntPtr auth);

		public bool RequiresUserNameAndPassword {
			get { return CFHTTPAuthenticationRequiresUserNameAndPassword (Handle); }
		}

		[DllImport (Constants.CFNetworkLibrary)]
		extern static /* CFString */ IntPtr CFHTTPAuthenticationCopyMethod (/* CFHTTPAuthenticationRef */ IntPtr auth);

		public string? GetMethod ()
		{
			var ptr = CFHTTPAuthenticationCopyMethod (Handle);
			return CFString.FromHandle (ptr, true);
		}
	}
}
