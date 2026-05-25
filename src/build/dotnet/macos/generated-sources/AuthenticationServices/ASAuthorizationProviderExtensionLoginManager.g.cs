//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AuthenticationServices {
	[Register("ASAuthorizationProviderExtensionLoginManager", true)]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.0")]
	public unsafe partial class ASAuthorizationProviderExtensionLoginManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttestKey_ClientDataHash_Completion_X = "attestKey:clientDataHash:completion:";
		static readonly NativeHandle selAttestKey_ClientDataHash_Completion_XHandle = Selector.GetHandle ("attestKey:clientDataHash:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttestPendingKey_ClientDataHash_Completion_X = "attestPendingKey:clientDataHash:completion:";
		static readonly NativeHandle selAttestPendingKey_ClientDataHash_Completion_XHandle = Selector.GetHandle ("attestPendingKey:clientDataHash:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthenticationMethodX = "authenticationMethod";
		static readonly NativeHandle selAuthenticationMethodXHandle = Selector.GetHandle ("authenticationMethod");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginKeyRotationForKeyType_X = "beginKeyRotationForKeyType:";
		static readonly NativeHandle selBeginKeyRotationForKeyType_XHandle = Selector.GetHandle ("beginKeyRotationForKeyType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompleteKeyRotationForKeyType_X = "completeKeyRotationForKeyType:";
		static readonly NativeHandle selCompleteKeyRotationForKeyType_XHandle = Selector.GetHandle ("completeKeyRotationForKeyType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyIdentityForKeyType_X = "copyIdentityForKeyType:";
		static readonly NativeHandle selCopyIdentityForKeyType_XHandle = Selector.GetHandle ("copyIdentityForKeyType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyKeyForKeyType_X = "copyKeyForKeyType:";
		static readonly NativeHandle selCopyKeyForKeyType_XHandle = Selector.GetHandle ("copyKeyForKeyType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecryptionKeysNeedRepairX = "decryptionKeysNeedRepair";
		static readonly NativeHandle selDecryptionKeysNeedRepairXHandle = Selector.GetHandle ("decryptionKeysNeedRepair");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceRegistrationsNeedsRepairX = "deviceRegistrationsNeedsRepair";
		static readonly NativeHandle selDeviceRegistrationsNeedsRepairXHandle = Selector.GetHandle ("deviceRegistrationsNeedsRepair");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtensionDataX = "extensionData";
		static readonly NativeHandle selExtensionDataXHandle = Selector.GetHandle ("extensionData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDeviceRegisteredX = "isDeviceRegistered";
		static readonly NativeHandle selIsDeviceRegisteredXHandle = Selector.GetHandle ("isDeviceRegistered");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUserRegisteredX = "isUserRegistered";
		static readonly NativeHandle selIsUserRegisteredXHandle = Selector.GetHandle ("isUserRegistered");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginConfigurationX = "loginConfiguration";
		static readonly NativeHandle selLoginConfigurationXHandle = Selector.GetHandle ("loginConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginUserNameX = "loginUserName";
		static readonly NativeHandle selLoginUserNameXHandle = Selector.GetHandle ("loginUserName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentRegistrationViewControllerWithCompletion_X = "presentRegistrationViewControllerWithCompletion:";
		static readonly NativeHandle selPresentRegistrationViewControllerWithCompletion_XHandle = Selector.GetHandle ("presentRegistrationViewControllerWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegistrationTokenX = "registrationToken";
		static readonly NativeHandle selRegistrationTokenXHandle = Selector.GetHandle ("registrationToken");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetDeviceKeysX = "resetDeviceKeys";
		static readonly NativeHandle selResetDeviceKeysXHandle = Selector.GetHandle ("resetDeviceKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetKeysX = "resetKeys";
		static readonly NativeHandle selResetKeysXHandle = Selector.GetHandle ("resetKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetUserSecureEnclaveKeyX = "resetUserSecureEnclaveKey";
		static readonly NativeHandle selResetUserSecureEnclaveKeyXHandle = Selector.GetHandle ("resetUserSecureEnclaveKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveCertificate_KeyType_X = "saveCertificate:keyType:";
		static readonly NativeHandle selSaveCertificate_KeyType_XHandle = Selector.GetHandle ("saveCertificate:keyType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveLoginConfiguration_Error_X = "saveLoginConfiguration:error:";
		static readonly NativeHandle selSaveLoginConfiguration_Error_XHandle = Selector.GetHandle ("saveLoginConfiguration:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveUserLoginConfiguration_Error_X = "saveUserLoginConfiguration:error:";
		static readonly NativeHandle selSaveUserLoginConfiguration_Error_XHandle = Selector.GetHandle ("saveUserLoginConfiguration:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoginUserName_X = "setLoginUserName:";
		static readonly NativeHandle selSetLoginUserName_XHandle = Selector.GetHandle ("setLoginUserName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSsoTokens_X = "setSsoTokens:";
		static readonly NativeHandle selSetSsoTokens_XHandle = Selector.GetHandle ("setSsoTokens:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSsoTokensX = "ssoTokens";
		static readonly NativeHandle selSsoTokensXHandle = Selector.GetHandle ("ssoTokens");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserLoginConfigurationX = "userLoginConfiguration";
		static readonly NativeHandle selUserLoginConfigurationXHandle = Selector.GetHandle ("userLoginConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserNeedsReauthenticationWithCompletion_X = "userNeedsReauthenticationWithCompletion:";
		static readonly NativeHandle selUserNeedsReauthenticationWithCompletion_XHandle = Selector.GetHandle ("userNeedsReauthenticationWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserRegistrationsNeedsRepairX = "userRegistrationsNeedsRepair";
		static readonly NativeHandle selUserRegistrationsNeedsRepairXHandle = Selector.GetHandle ("userRegistrationsNeedsRepair");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ASAuthorizationProviderExtensionLoginManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ASAuthorizationProviderExtensionLoginManager (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ASAuthorizationProviderExtensionLoginManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("attestKey:clientDataHash:completion:")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AttestKey (ASAuthorizationProviderExtensionKeyType keyType, NSData clientDataHash, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionLoginManagerAttestCallback))]ASAuthorizationProviderExtensionLoginManagerAttestCallback completion)
		{
			var clientDataHash__handle__ = clientDataHash!.GetNonNullHandle (nameof (clientDataHash));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDASAuthorizationProviderExtensionLoginManagerAttestCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selAttestKey_ClientDataHash_Completion_XHandle, (IntPtr) (long) keyType, clientDataHash__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selAttestKey_ClientDataHash_Completion_XHandle, (IntPtr) (long) keyType, clientDataHash__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (clientDataHash);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray> AttestKeyAsync (ASAuthorizationProviderExtensionKeyType keyType, NSData clientDataHash)
		{
			var tcs = new TaskCompletionSource<NSArray> ();
			AttestKey(keyType, clientDataHash, (attestationCertificates_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (attestationCertificates_!);
			});
			return tcs.Task;
		}
		[Export ("attestPendingKey:clientDataHash:completion:")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AttestPendingKey (ASAuthorizationProviderExtensionKeyType keyType, NSData clientDataHash, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionLoginManagerAttestCallback))]ASAuthorizationProviderExtensionLoginManagerAttestCallback completion)
		{
			var clientDataHash__handle__ = clientDataHash!.GetNonNullHandle (nameof (clientDataHash));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDASAuthorizationProviderExtensionLoginManagerAttestCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selAttestPendingKey_ClientDataHash_Completion_XHandle, (IntPtr) (long) keyType, clientDataHash__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selAttestPendingKey_ClientDataHash_Completion_XHandle, (IntPtr) (long) keyType, clientDataHash__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (clientDataHash);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray> AttestPendingKeyAsync (ASAuthorizationProviderExtensionKeyType keyType, NSData clientDataHash)
		{
			var tcs = new TaskCompletionSource<NSArray> ();
			AttestPendingKey(keyType, clientDataHash, (attestationCertificates_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (attestationCertificates_!);
			});
			return tcs.Task;
		}
		[Export ("beginKeyRotationForKeyType:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Security.SecKey? BeginKeyRotation (ASAuthorizationProviderExtensionKeyType keyType)
		{
			global::Security.SecKey ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::Security.SecKey> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selBeginKeyRotationForKeyType_XHandle, (IntPtr) (long) keyType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::Security.SecKey> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selBeginKeyRotationForKeyType_XHandle, (IntPtr) (long) keyType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("completeKeyRotationForKeyType:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CompleteKeyRotation (ASAuthorizationProviderExtensionKeyType keyType)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCompleteKeyRotationForKeyType_XHandle, (IntPtr) (long) keyType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selCompleteKeyRotationForKeyType_XHandle, (IntPtr) (long) keyType);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("copyIdentityForKeyType:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Security.SecIdentity? CopyIdentity (ASAuthorizationProviderExtensionKeyType keyType)
		{
			global::Security.SecIdentity? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::Security.SecIdentity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selCopyIdentityForKeyType_XHandle, (IntPtr) (long) keyType), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::Security.SecIdentity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selCopyIdentityForKeyType_XHandle, (IntPtr) (long) keyType), true)!;
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Security.SecKey CopyKey (ASAuthorizationProviderExtensionKeyType keyType)
		{
			return new SecKey (_CopyKey (keyType), true);;
		}
		[Export ("decryptionKeysNeedRepair")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecryptionKeysNeedRepair ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDecryptionKeysNeedRepairXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDecryptionKeysNeedRepairXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deviceRegistrationsNeedsRepair")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeviceRegistrationsNeedsRepair ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeviceRegistrationsNeedsRepairXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDeviceRegistrationsNeedsRepairXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("presentRegistrationViewControllerWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentRegistrationViewController ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentRegistrationViewControllerWithCompletion_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentRegistrationViewControllerWithCompletion_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task PresentRegistrationViewControllerAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			PresentRegistrationViewController((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("resetDeviceKeys")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetDeviceKeys ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetDeviceKeysXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetDeviceKeysXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resetKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetKeys ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetKeysXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetKeysXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resetUserSecureEnclaveKey")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetUserSecureEnclaveKey ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetUserSecureEnclaveKeyXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetUserSecureEnclaveKeyXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("saveLoginConfiguration:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Save (ASAuthorizationProviderExtensionLoginConfiguration loginConfiguration, out NSError? error)
		{
			var loginConfiguration__handle__ = loginConfiguration!.GetNonNullHandle (nameof (loginConfiguration));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSaveLoginConfiguration_Error_XHandle, loginConfiguration__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSaveLoginConfiguration_Error_XHandle, loginConfiguration__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (loginConfiguration);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("saveUserLoginConfiguration:error:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveUserLoginConfiguration (ASAuthorizationProviderExtensionUserLoginConfiguration userLoginConfiguration, out NSError? error)
		{
			var userLoginConfiguration__handle__ = userLoginConfiguration!.GetNonNullHandle (nameof (userLoginConfiguration));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSaveUserLoginConfiguration_Error_XHandle, userLoginConfiguration__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSaveUserLoginConfiguration_Error_XHandle, userLoginConfiguration__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userLoginConfiguration);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("userNeedsReauthenticationWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UserNeedsReauthentication ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUserNeedsReauthenticationWithCompletion_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUserNeedsReauthenticationWithCompletion_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task UserNeedsReauthenticationAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			UserNeedsReauthentication((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("userRegistrationsNeedsRepair")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserRegistrationsNeedsRepair ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUserRegistrationsNeedsRepairXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUserRegistrationsNeedsRepairXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("copyKeyForKeyType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nint _CopyKey (ASAuthorizationProviderExtensionKeyType keyType)
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCopyKeyForKeyType_XHandle, (IntPtr) (long) keyType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selCopyKeyForKeyType_XHandle, (IntPtr) (long) keyType);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("saveCertificate:keyType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void _Save (nint certificate, ASAuthorizationProviderExtensionKeyType keyType)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSaveCertificate_KeyType_XHandle, certificate, (IntPtr) (long) keyType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selSaveCertificate_KeyType_XHandle, certificate, (IntPtr) (long) keyType);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionAuthenticationMethod AuthenticationMethod {
			[Export ("authenticationMethod")]
			get {
				ASAuthorizationProviderExtensionAuthenticationMethod ret;
				if (IsDirectBinding) {
					ret = (AuthenticationServices.ASAuthorizationProviderExtensionAuthenticationMethod) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAuthenticationMethodXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AuthenticationServices.ASAuthorizationProviderExtensionAuthenticationMethod) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAuthenticationMethodXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeviceRegistered {
			[Export ("isDeviceRegistered")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDeviceRegisteredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDeviceRegisteredXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSDictionary ExtensionData {
			[Export ("extensionData")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtensionDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtensionDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationProviderExtensionLoginConfiguration? LoginConfiguration {
			[Export ("loginConfiguration", ArgumentSemantic.Copy)]
			get {
				ASAuthorizationProviderExtensionLoginConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ASAuthorizationProviderExtensionLoginConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLoginConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<ASAuthorizationProviderExtensionLoginConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLoginConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos14.0", "Use 'UserLoginConfiguration.LoginUserName' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual string? LoginUserName {
			[Export ("loginUserName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLoginUserNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLoginUserNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLoginUserName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLoginUserName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLoginUserName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? RegistrationToken {
			[Export ("registrationToken")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRegistrationTokenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRegistrationTokenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? SsoTokens {
			[Export ("ssoTokens", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSsoTokensXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSsoTokensXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSsoTokens:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSsoTokens_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSsoTokens_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionUserLoginConfiguration? UserLoginConfiguration {
			[Export ("userLoginConfiguration", ArgumentSemantic.Copy)]
			get {
				ASAuthorizationProviderExtensionUserLoginConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ASAuthorizationProviderExtensionUserLoginConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserLoginConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<ASAuthorizationProviderExtensionUserLoginConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserLoginConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserRegistered {
			[Export ("isUserRegistered")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUserRegisteredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUserRegisteredXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class ASAuthorizationProviderExtensionLoginManager */
}
