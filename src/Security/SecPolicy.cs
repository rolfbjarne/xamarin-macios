// 
// SecPolicy.cs: Implements the managed SecPolicy wrapper.
//
// Authors: 
//  Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2014 Xamarin Inc.
//

#nullable enable

using CoreFoundation;

namespace Security {

	/// <summary>Encapsulates a security policy. A policy comprises a set of rules that specify how to evaluate a certificate for a certain level of trust.</summary>
	public partial class SecPolicy {
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		extern static IntPtr /* __nullable CFDictionaryRef */ SecPolicyCopyProperties (IntPtr /* SecPolicyRef */ policyRef);

		/// <summary>Gets properties.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSDictionary? GetProperties ()
		{
			var dict = SecPolicyCopyProperties (Handle);
			return Runtime.GetNSObject<NSDictionary> (dict, true);
		}

		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		extern static IntPtr /* __nullable SecPolicyRef */ SecPolicyCreateRevocation (/* CFOptionFlags */ nuint revocationFlags);

		/// <param name="revocationFlags">The revocation flags.</param>
		/// <summary>Creates a revocation policy with the specified flags.</summary>
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		static public SecPolicy? CreateRevocationPolicy (SecRevocation revocationFlags)
		{
			var policy = SecPolicyCreateRevocation ((nuint) (ulong) revocationFlags);
			return policy == IntPtr.Zero ? null : new SecPolicy (policy, true);
		}

		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		extern static IntPtr /* __nullable SecPolicyRef */ SecPolicyCreateWithProperties (IntPtr /* CFTypeRef */ policyIdentifier, IntPtr /* CFDictionaryRef */ properties);

		/// <param name="policyIdentifier">The policy identifier.</param>
		///         <param name="properties">The properties.</param>
		/// <summary>Creates a security policy with the specified identifier and properties.</summary>
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		static public SecPolicy CreatePolicy (NSString policyIdentifier, NSDictionary properties)
		{
			if (policyIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (policyIdentifier));
			IntPtr dh = properties.GetHandle ();

			// note: only accept known OIDs or return null (unit test will alert us if that change, FIXME in Apple code)
			// see: https://github.com/Apple-FOSS-Mirror/libsecurity_keychain/blob/master/lib/SecPolicy.cpp#L245
			IntPtr ph = SecPolicyCreateWithProperties (policyIdentifier.Handle, dh);
			GC.KeepAlive (properties);
			GC.KeepAlive (policyIdentifier);
			if (ph == IntPtr.Zero)
				throw new ArgumentException ("Unknown policyIdentifier");
			return new SecPolicy (ph, true);
		}
	}
}
