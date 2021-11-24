//
// SecCertificate2.cs: Bindings the Security's sec_trust_t
//
// The difference between SecCertificate2 and SecCertificate is that the
// SecCertificate2 is a binding for the new sec_trust_t API that was
// introduced on iOS 12/OSX Mojave, while SecCertificate is the older API
// that binds SecCertificateRef.
//
// Authors:
//   Miguel de Icaza (miguel@microsoft.com)
//
// Copyrigh 2018 Microsoft Inc
//
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using ObjCRuntime;
using Foundation;
using CoreFoundation;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace Security {

#if !NET
	[TV (12,0), Mac (10,14), iOS (12,0), Watch (5,0)]
#else
	[SupportedOSPlatform ("ios12.0")]
	[SupportedOSPlatform ("tvos12.0")]
	[SupportedOSPlatform ("macos10.14")]
#endif
	public class SecCertificate2 : NativeObject {
#if NET
		internal SecCertificate2 (NativeHandle handle, bool owns) : base (handle, owns) {}
#else
		public SecCertificate2 (NativeHandle handle, bool owns) : base (handle, owns) {}
#endif

		[DllImport (Constants.SecurityLibrary)]
		extern static IntPtr sec_certificate_create (IntPtr seccertificateHandle);

		public SecCertificate2 (SecCertificate certificate)
		{
			if (certificate == null)
				throw new ArgumentNullException (nameof (certificate));
			InitializeHandle (sec_certificate_create (certificate.Handle));
		}

		[DllImport (Constants.SecurityLibrary)]
		extern static /* SecCertificateRef */ IntPtr sec_certificate_copy_ref (/* OS_sec_certificate */ IntPtr handle);

		public SecCertificate Certificate => new SecCertificate (sec_certificate_copy_ref (GetCheckedHandle ()), owns: true);
	}
}
