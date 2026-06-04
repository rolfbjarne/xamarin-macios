// 
// SecTrust.cs: Implements the managed SecTrust wrapper.
//
// Authors: 
//  Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2014 Xamarin Inc.
// Copyright 2019 Microsoft Corporation
//

#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using CoreFoundation;

namespace Security {

	public delegate void SecTrustCallback (SecTrust? trust, SecTrustResult trustResult);
	public delegate void SecTrustWithErrorCallback (SecTrust? trust, bool result, NSError? /* CFErrorRef _Nullable */ error);

	/// <summary>A trust level. A trust object combines a certificate with APolicy or policies. </summary>
	public partial class SecTrust {

		/// <param name="certificate">The certificate.</param>
		///         <param name="policy">The policy.</param>
		/// <summary>Creates a trust object for the specified certificate and policy.</summary>
		public SecTrust (SecCertificate certificate, SecPolicy policy)
		{
			if (certificate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (certificate));

			Initialize (certificate.Handle, policy);
			GC.KeepAlive (certificate);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static SecStatusCode /* OSStatus */ SecTrustCopyPolicies (IntPtr /* SecTrustRef */ trust, IntPtr* /* CFArrayRef* */ policies);

	/// <summary>Gets the policies associated with this trust object.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SecPolicy []? GetPolicies ()
		{
			IntPtr p = IntPtr.Zero;
			SecStatusCode result;
			unsafe {
				result = SecTrustCopyPolicies (Handle, &p);
			}
			if (result != SecStatusCode.Success)
				throw new InvalidOperationException (result.ToString ());
			return NSArray.ArrayFromHandleDropNullElements<SecPolicy> (p, releaseHandle: true);
		}

		[DllImport (Constants.SecurityLibrary)]
		extern static SecStatusCode /* OSStatus */ SecTrustSetPolicies (IntPtr /* SecTrustRef */ trust, IntPtr /* CFTypeRef */ policies);

		// the API accept the handle for a single policy or an array of them
		void SetPolicies (IntPtr policy)
		{
			SecStatusCode result = SecTrustSetPolicies (Handle, policy);
			if (result != SecStatusCode.Success)
				throw new InvalidOperationException (result.ToString ());
		}

		/// <param name="policy">The policy.</param>
		/// <summary>Sets the trust evaluation policy.</summary>
		public void SetPolicy (SecPolicy policy)
		{
			if (policy is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (policy));

			SetPolicies (policy.Handle);
			GC.KeepAlive (policy);
		}

		/// <param name="policies">The policies.</param>
		/// <summary>Sets the trust evaluation policies.</summary>
		public void SetPolicies (IEnumerable<SecPolicy> policies)
		{
			if (policies is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (policies));

			using (var array = NSArray.FromNSObjects (policies.ToArray ()))
				SetPolicies (array.Handle);
		}

		/// <param name="policies">The policies.</param>
		/// <summary>Sets the trust evaluation policies from an array.</summary>
		public void SetPolicies (NSArray policies)
		{
			if (policies is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (policies));

			SetPolicies (policies.Handle);
			GC.KeepAlive (policies);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static SecStatusCode /* OSStatus */ SecTrustGetNetworkFetchAllowed (IntPtr /* SecTrustRef */ trust, byte* /* Boolean* */ allowFetch);

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		extern static SecStatusCode /* OSStatus */ SecTrustSetNetworkFetchAllowed (IntPtr /* SecTrustRef */ trust, byte /* Boolean */ allowFetch);

	/// <summary>Gets or sets a value indicating whether network fetching is allowed during trust evaluation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public bool NetworkFetchAllowed {
			get {
				byte value;
				SecStatusCode result;
				unsafe {
					result = SecTrustGetNetworkFetchAllowed (Handle, &value);
				}
				if (result != SecStatusCode.Success)
					throw new InvalidOperationException (result.ToString ());
				return value != 0;
			}
			set {
				SecStatusCode result = SecTrustSetNetworkFetchAllowed (Handle, value.AsByte ());
				if (result != SecStatusCode.Success)
					throw new InvalidOperationException (result.ToString ());
			}
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static SecStatusCode /* OSStatus */ SecTrustCopyCustomAnchorCertificates (IntPtr /* SecTrustRef */ trust, IntPtr* /* CFArrayRef* */ anchors);

	/// <summary>Gets the custom anchor certificates used for trust evaluation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SecCertificate []? GetCustomAnchorCertificates ()
		{
			IntPtr p;
			SecStatusCode result;
			unsafe {
				result = SecTrustCopyCustomAnchorCertificates (Handle, &p);
			}
			if (result != SecStatusCode.Success)
				throw new InvalidOperationException (result.ToString ());
			return NSArray.ArrayFromHandleDropNullElements<SecCertificate> (p, releaseHandle: true);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[ObsoletedOSPlatform ("macos", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static SecStatusCode /* OSStatus */ SecTrustEvaluateAsync (IntPtr /* SecTrustRef */ trust, IntPtr /* dispatch_queue_t */ queue, BlockLiteral* block);

		[UnmanagedCallersOnly]
		static void TrampolineEvaluate (IntPtr block, IntPtr trust, SecTrustResult trustResult)
		{
			var del = BlockLiteral.GetTarget<SecTrustCallback> (block);
			if (del is not null) {
				var t = trust == IntPtr.Zero ? null : new SecTrust (trust, false);
				del (t, trustResult);
			}
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[ObsoletedOSPlatform ("macos", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
		[BindingImpl (BindingImplOptions.Optimizable)]
		public SecStatusCode Evaluate (DispatchQueue queue, SecTrustCallback handler)
		{
			// headers have `dispatch_queue_t _Nullable queue` but it crashes... don't trust headers, even for SecTrust
			if (queue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queue));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));

			unsafe {
				delegate* unmanaged<IntPtr, IntPtr, SecTrustResult, void> trampoline = &TrampolineEvaluate;
				using var block = new BlockLiteral (trampoline, handler, typeof (SecTrust), nameof (TrampolineEvaluate));
				SecStatusCode status = SecTrustEvaluateAsync (Handle, queue.Handle, &block);
				GC.KeepAlive (queue);
				return status;
			}
		}

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe static extern SecStatusCode SecTrustEvaluateAsyncWithError (IntPtr /* SecTrustRef */ trust, IntPtr /* dispatch_queue_t */ queue, BlockLiteral* block);

		[UnmanagedCallersOnly]
		static void TrampolineEvaluateError (IntPtr block, IntPtr trust, byte result, IntPtr /* CFErrorRef _Nullable */  error)
		{
			var del = BlockLiteral.GetTarget<SecTrustWithErrorCallback> (block);
			if (del is not null) {
				var t = trust == IntPtr.Zero ? null : new SecTrust (trust, false);
				var e = error == IntPtr.Zero ? null : new NSError (error);
				del (t, result != 0, e);
			}
		}

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.Optimizable)]
		public SecStatusCode Evaluate (DispatchQueue queue, SecTrustWithErrorCallback handler)
		{
			if (queue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queue));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));

			unsafe {
				delegate* unmanaged<IntPtr, IntPtr, byte, IntPtr, void> trampoline = &TrampolineEvaluateError;
				using var block = new BlockLiteral (trampoline, handler, typeof (SecTrust), nameof (TrampolineEvaluateError));
				SecStatusCode status = SecTrustEvaluateAsyncWithError (Handle, queue.Handle, &block);
				GC.KeepAlive (queue);
				return status;
			}
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static SecStatusCode /* OSStatus */ SecTrustGetTrustResult (IntPtr /* SecTrustRef */ trust, SecTrustResult* /* SecTrustResultType */ result);

	/// <summary>Gets the trust evaluation result.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SecTrustResult GetTrustResult ()
		{
			SecTrustResult trust_result;
			SecStatusCode result;
			unsafe {
				result = SecTrustGetTrustResult (Handle, &trust_result);
			}
			if (result != SecStatusCode.Success)
				throw new InvalidOperationException (result.ToString ());
			return trust_result;
		}

		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.SecurityLibrary)]
		unsafe static extern byte SecTrustEvaluateWithError (/* SecTrustRef */ IntPtr trust, /* CFErrorRef** */ IntPtr* error);

		/// <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Evaluates the trust and returns whether the certificate chain is trusted.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool Evaluate (out NSError? error)
		{
			IntPtr err;
			bool result;
			unsafe {
				result = SecTrustEvaluateWithError (Handle, &err) != 0;
			}
			error = err == IntPtr.Zero ? null : new NSError (err);
			return result;
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		extern static IntPtr /* CFDictionaryRef */ SecTrustCopyResult (IntPtr /* SecTrustRef */ trust);

	/// <summary>Gets the result dictionary containing detailed trust evaluation information.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSDictionary GetResult ()
		{
			return new NSDictionary (SecTrustCopyResult (Handle), true);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.SecurityLibrary)]
		extern static SecStatusCode /* OSStatus */ SecTrustSetOCSPResponse (IntPtr /* SecTrustRef */ trust, IntPtr /* CFTypeRef */ responseData);

		// the API accept the handle for a single policy or an array of them
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		void SetOCSPResponse (IntPtr ocsp)
		{
			SecStatusCode result = SecTrustSetOCSPResponse (Handle, ocsp);
			if (result != SecStatusCode.Success)
				throw new InvalidOperationException (result.ToString ());
		}

		/// <param name="ocspResponse">The ocsp response.</param>
		/// <summary>Sets the OCSP response data for trust evaluation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public void SetOCSPResponse (NSData ocspResponse)
		{
			if (ocspResponse is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ocspResponse));

			SetOCSPResponse (ocspResponse.Handle);
			GC.KeepAlive (ocspResponse);
		}

		/// <param name="ocspResponses">The ocsp responses.</param>
		/// <summary>Sets the OCSP response data from a collection for trust evaluation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public void SetOCSPResponse (IEnumerable<NSData> ocspResponses)
		{
			if (ocspResponses is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ocspResponses));

			using (var array = NSArray.FromNSObjects (ocspResponses.ToArray ()))
				SetOCSPResponse (array.Handle);
		}

		/// <param name="ocspResponses">The ocsp responses.</param>
		/// <summary>Sets the OCSP response data from an array for trust evaluation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public void SetOCSPResponse (NSArray ocspResponses)
		{
			if (ocspResponses is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ocspResponses));

			SetOCSPResponse (ocspResponses.Handle);
			GC.KeepAlive (ocspResponses);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.SecurityLibrary)]
		static extern SecStatusCode /* OSStatus */ SecTrustSetSignedCertificateTimestamps (/* SecTrustRef* */ IntPtr trust, /* CFArrayRef* */ IntPtr sctArray);

		/// <param name="sct">The sct.</param>
		/// <summary>Sets the signed certificate timestamps for Certificate Transparency validation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public SecStatusCode SetSignedCertificateTimestamps (IEnumerable<NSData> sct)
		{
			if (sct is null)
				return SecTrustSetSignedCertificateTimestamps (Handle, IntPtr.Zero);

			using (var array = NSArray.FromNSObjects (sct.ToArray ()))
				return SecTrustSetSignedCertificateTimestamps (Handle, array.Handle);
		}

		/// <param name="sct">The sct.</param>
		/// <summary>Sets the signed certificate timestamps from an array for Certificate Transparency validation.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public SecStatusCode SetSignedCertificateTimestamps (NSArray<NSData> sct)
		{
			SecStatusCode status = SecTrustSetSignedCertificateTimestamps (Handle, sct.GetHandle ());
			GC.KeepAlive (sct);
			return status;
		}
	}
}
