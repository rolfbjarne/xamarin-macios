#nullable enable

#if IOS || MONOMAC

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using ObjCRuntime;
using CoreFoundation;
using Foundation;

namespace Security {

	public static partial class SecSharedCredential {

		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static void SecAddSharedWebCredential (IntPtr /* CFStringRef */ fqdn, IntPtr /* CFStringRef */ account, IntPtr /* CFStringRef */ password,
			BlockLiteral* /* void (^completionHandler)( CFErrorRef error) ) */ completionHandler);
			
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V12 (IntPtr block, IntPtr obj);
		
		// This class bridges native block invocations that call into C#
		static internal class ActionTrampoline {
			static internal readonly DActionArity1V12 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V12))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSError?>) (descriptor->Target);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSError> (obj));
				}
			} 
		} 

		[BindingImpl (BindingImplOptions.Optimizable)]
		public static void AddSharedWebCredential (string domainName, string account, string password, Action<NSError> handler)
		{
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			if (account is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (account));
			// we need to create our own block literal. We can reuse the SDActionArity1V12 which is generated and takes a
			// NSError because a CFError is a toll-free bridget to CFError
			unsafe {
				using var nsDomain = new NSString (domainName);
				using var nsAccount = new NSString (account);
				using var nsPassword = (NSString?) password;
				using var block = new BlockLiteral ();
				block.SetupBlockUnsafe (ActionTrampoline.Handler, handler);
				SecAddSharedWebCredential (nsDomain.Handle, nsAccount.Handle, nsPassword.GetHandle (), &block);
			}
		}

#if NET
		[SupportedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("macos11.0")]
		[SupportedOSPlatform ("maccatalyst14.0")]
		[ObsoletedOSPlatform ("macos11.0")]
		[ObsoletedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
#else
		[Deprecated (PlatformName.iOS, 14,0)]
		[Deprecated (PlatformName.MacOSX, 11,0)]
#endif
		[DllImport (Constants.SecurityLibrary)]
		unsafe extern static void SecRequestSharedWebCredential ( IntPtr /* CFStringRef */ fqdn, IntPtr /* CFStringRef */ account,
			BlockLiteral* /* void (^completionHandler)( CFArrayRef credentials, CFErrorRef error) */ completionHandler);

		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void ArrayErrorAction (IntPtr block, IntPtr array, IntPtr err);

		//
		// This class bridges native block invocations that call into C# because we cannot use the decorator, we have to create
		// it for our use here.
		//
		static internal class ArrayErrorActionTrampoline {
			static internal readonly ArrayErrorAction Handler = Invoke;

			[MonoPInvokeCallback (typeof (ArrayErrorAction))]
			static unsafe void Invoke (IntPtr block, IntPtr array, IntPtr err) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSArray?, NSError?>) (descriptor->Target);
				if (del is not null)
					del ( Runtime.GetNSObject<NSArray> (array), Runtime.GetNSObject<NSError> (err));
			}
		}

#if !NET
		[Obsolete ("Use the overload accepting a 'SecSharedCredentialInfo' argument.")]
		public static void RequestSharedWebCredential (string domainName, string account, Action<string[], NSError> handler)
		{
			throw new InvalidOperationException ("Use correct delegate type");
		}
#endif

#if NET
		[SupportedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("macos11.0")]
		[SupportedOSPlatform ("maccatalyst14.0")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'ASAuthorizationPasswordRequest' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'ASAuthorizationPasswordRequest' instead.")]
		[UnsupportedOSPlatform ("tvos")]
#else
		[Deprecated (PlatformName.iOS, 14,0, message: "Use 'ASAuthorizationPasswordRequest' instead.")]
		[Deprecated (PlatformName.MacOSX, 11,0, message: "Use 'ASAuthorizationPasswordRequest' instead.")]
#endif
		[BindingImpl (BindingImplOptions.Optimizable)]
		public static void RequestSharedWebCredential (string domainName, string account, Action<SecSharedCredentialInfo[], NSError> handler)
		{
			Action<NSArray, NSError> onComplete = (NSArray a, NSError e) => {
				var creds = new SecSharedCredentialInfo [a.Count];
				int i = 0;
				foreach (var dict in NSArray.FromArrayNative<NSDictionary> (a)) {
					creds [i++] = new SecSharedCredentialInfo (dict);
				}
				handler (creds, e);
			};
			// we need to create our own block literal.
			using var nsDomain = (NSString?) domainName;
			using var nsAccount = (NSString?) account;

			unsafe {
				using var block = new BlockLiteral ();
				block.SetupBlockUnsafe (ArrayErrorActionTrampoline.Handler, onComplete);
				SecRequestSharedWebCredential (nsDomain.GetHandle (), nsAccount.GetHandle (), &block);
			}
		}

		[DllImport (Constants.SecurityLibrary)]
		extern static IntPtr /* CFStringRef */ SecCreateSharedWebCredentialPassword ();

		public static string? CreateSharedWebCredentialPassword ()
		{
			var handle = SecCreateSharedWebCredentialPassword ();
			var str = CFString.FromHandle (handle);
			NSObject.DangerousRelease (handle);
			return str;
		}
	}

}

#endif  // IOS
