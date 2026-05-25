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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationProviderExtensionRegistrationHandler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.0")]
	[Protocol (Name = "ASAuthorizationProviderExtensionRegistrationHandler", WrapperType = typeof (ASAuthorizationProviderExtensionRegistrationHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginDeviceRegistration", Selector = "beginDeviceRegistrationUsingLoginManager:options:completion:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationProviderExtensionLoginManager), typeof (AuthenticationServices.ASAuthorizationProviderExtensionRequestOptions), typeof (global::System.Action<global::AuthenticationServices.ASAuthorizationProviderExtensionRegistrationResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V27) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginUserRegistration", Selector = "beginUserRegistrationUsingLoginManager:userName:authenticationMethod:options:completion:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationProviderExtensionLoginManager), typeof (string), typeof (AuthenticationServices.ASAuthorizationProviderExtensionAuthenticationMethod), typeof (AuthenticationServices.ASAuthorizationProviderExtensionRequestOptions), typeof (global::System.Action<global::AuthenticationServices.ASAuthorizationProviderExtensionRegistrationResult>) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V27) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegistrationDidComplete", Selector = "registrationDidComplete")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegistrationDidCancel", Selector = "registrationDidCancel")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "KeyWillRotateForKeyType", Selector = "keyWillRotateForKeyType:newKey:loginManager:completion:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationProviderExtensionKeyType), typeof (SecKey), typeof (AuthenticationServices.ASAuthorizationProviderExtensionLoginManager), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayNames", Selector = "displayNamesForGroups:loginManager:completion:", ParameterType = new Type [] { typeof (String[]), typeof (AuthenticationServices.ASAuthorizationProviderExtensionLoginManager), typeof (AuthenticationServices.ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetProfilePictureForUser", Selector = "profilePictureForUserUsingLoginManager:completion:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationProviderExtensionLoginManager), typeof (AuthenticationServices.ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportedGrantTypes", Selector = "supportedGrantTypes", PropertyType = typeof (AuthenticationServices.ASAuthorizationProviderExtensionSupportedGrantTypes), GetterSelector = "supportedGrantTypes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProtocolVersion", Selector = "protocolVersion", PropertyType = typeof (AuthenticationServices.ASAuthorizationProviderExtensionPlatformSSOProtocolVersion), GetterSelector = "protocolVersion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakSupportedDeviceSigningAlgorithms", Selector = "supportedDeviceSigningAlgorithms", PropertyType = typeof (NSNumber[]), GetterSelector = "supportedDeviceSigningAlgorithms", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakSupportedDeviceEncryptionAlgorithms", Selector = "supportedDeviceEncryptionAlgorithms", PropertyType = typeof (NSNumber[]), GetterSelector = "supportedDeviceEncryptionAlgorithms", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakSupportedUserSecureEnclaveKeySigningAlgorithms", Selector = "supportedUserSecureEnclaveKeySigningAlgorithms", PropertyType = typeof (NSNumber[]), GetterSelector = "supportedUserSecureEnclaveKeySigningAlgorithms", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IASAuthorizationProviderExtensionRegistrationHandler : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("beginDeviceRegistrationUsingLoginManager:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginDeviceRegistration (ASAuthorizationProviderExtensionLoginManager loginManager, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _BeginDeviceRegistration (IASAuthorizationProviderExtensionRegistrationHandler This, ASAuthorizationProviderExtensionLoginManager loginManager, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V27.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("beginDeviceRegistrationUsingLoginManager:options:completion:"), loginManager__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (loginManager);
		}
		[global::Foundation.RequiredMember]
		[Export ("beginUserRegistrationUsingLoginManager:userName:authenticationMethod:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginUserRegistration (ASAuthorizationProviderExtensionLoginManager loginManager, string? userName, ASAuthorizationProviderExtensionAuthenticationMethod authenticationMethod, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _BeginUserRegistration (IASAuthorizationProviderExtensionRegistrationHandler This, ASAuthorizationProviderExtensionLoginManager loginManager, string? userName, ASAuthorizationProviderExtensionAuthenticationMethod authenticationMethod, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsuserName = CFString.CreateNative (userName);
			using var block_handler = Trampolines.SDActionArity1V27.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("beginUserRegistrationUsingLoginManager:userName:authenticationMethod:options:completion:"), loginManager__handle__, nsuserName, (IntPtr) (long) authenticationMethod, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (loginManager);
			CFString.ReleaseNative (nsuserName);
		}
		[global::Foundation.OptionalMember]
		[Export ("registrationDidComplete")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegistrationDidComplete ()
		{
			_RegistrationDidComplete (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegistrationDidComplete (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("registrationDidComplete"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("registrationDidCancel")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegistrationDidCancel ()
		{
			_RegistrationDidCancel (this);
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegistrationDidCancel (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("registrationDidCancel"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("keyWillRotateForKeyType:newKey:loginManager:completion:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void KeyWillRotateForKeyType (ASAuthorizationProviderExtensionKeyType keyType, global::Security.SecKey newKey, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completion)
		{
			_KeyWillRotateForKeyType (this, keyType, newKey, loginManager, completion);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _KeyWillRotateForKeyType (IASAuthorizationProviderExtensionRegistrationHandler This, ASAuthorizationProviderExtensionKeyType keyType, global::Security.SecKey newKey, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completion)
		{
			var newKey__handle__ = newKey!.GetNonNullHandle (nameof (newKey));
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V2.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("keyWillRotateForKeyType:newKey:loginManager:completion:"), (IntPtr) (long) keyType, newKey.Handle, loginManager__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (newKey);
			GC.KeepAlive (loginManager);
		}
		[global::Foundation.OptionalMember]
		[Export ("displayNamesForGroups:loginManager:completion:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetDisplayNames (string[] groups, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback completion)
		{
			_GetDisplayNames (this, groups, loginManager, completion);
		}
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetDisplayNames (IASAuthorizationProviderExtensionRegistrationHandler This, string[] groups, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback completion)
		{
			if (groups is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groups));
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_groups = NSArray.FromStrings (groups);
			using var block_completion = Trampolines.SDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("displayNamesForGroups:loginManager:completion:"), nsa_groups.Handle, loginManager__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (loginManager);
		}
		[global::Foundation.OptionalMember]
		[Export ("profilePictureForUserUsingLoginManager:completion:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetProfilePictureForUser (ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback completion)
		{
			_GetProfilePictureForUser (this, loginManager, completion);
		}
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetProfilePictureForUser (IASAuthorizationProviderExtensionRegistrationHandler This, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback completion)
		{
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profilePictureForUserUsingLoginManager:completion:"), loginManager__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (loginManager);
		}
		[DynamicDependencyAttribute ("BeginDeviceRegistration(AuthenticationServices.ASAuthorizationProviderExtensionLoginManager,AuthenticationServices.ASAuthorizationProviderExtensionRequestOptions,System.Action{AuthenticationServices.ASAuthorizationProviderExtensionRegistrationResult})")]
		[DynamicDependencyAttribute ("BeginUserRegistration(AuthenticationServices.ASAuthorizationProviderExtensionLoginManager,System.String,AuthenticationServices.ASAuthorizationProviderExtensionAuthenticationMethod,AuthenticationServices.ASAuthorizationProviderExtensionRequestOptions,System.Action{AuthenticationServices.ASAuthorizationProviderExtensionRegistrationResult})")]
		[DynamicDependencyAttribute ("GetDisplayNames(System.String[],AuthenticationServices.ASAuthorizationProviderExtensionLoginManager,AuthenticationServices.ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback)")]
		[DynamicDependencyAttribute ("GetProfilePictureForUser(AuthenticationServices.ASAuthorizationProviderExtensionLoginManager,AuthenticationServices.ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback)")]
		[DynamicDependencyAttribute ("KeyWillRotateForKeyType(AuthenticationServices.ASAuthorizationProviderExtensionKeyType,Security.SecKey,AuthenticationServices.ASAuthorizationProviderExtensionLoginManager,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("ProtocolVersion")]
		[DynamicDependencyAttribute ("RegistrationDidCancel()")]
		[DynamicDependencyAttribute ("RegistrationDidComplete()")]
		[DynamicDependencyAttribute ("SupportedGrantTypes")]
		[DynamicDependencyAttribute ("WeakSupportedDeviceEncryptionAlgorithms")]
		[DynamicDependencyAttribute ("WeakSupportedDeviceSigningAlgorithms")]
		[DynamicDependencyAttribute ("WeakSupportedUserSecureEnclaveKeySigningAlgorithms")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationProviderExtensionRegistrationHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationProviderExtensionRegistrationHandler ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual ASAuthorizationProviderExtensionSupportedGrantTypes SupportedGrantTypes {
			[Export ("supportedGrantTypes")]
			get {
				return _GetSupportedGrantTypes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationProviderExtensionSupportedGrantTypes _GetSupportedGrantTypes (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			ASAuthorizationProviderExtensionSupportedGrantTypes ret;
			ret = (AuthenticationServices.ASAuthorizationProviderExtensionSupportedGrantTypes) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("supportedGrantTypes"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual ASAuthorizationProviderExtensionPlatformSSOProtocolVersion ProtocolVersion {
			[Export ("protocolVersion")]
			get {
				return _GetProtocolVersion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationProviderExtensionPlatformSSOProtocolVersion _GetProtocolVersion (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			ASAuthorizationProviderExtensionPlatformSSOProtocolVersion ret;
			ret = (AuthenticationServices.ASAuthorizationProviderExtensionPlatformSSOProtocolVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("protocolVersion"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSNumber[] WeakSupportedDeviceSigningAlgorithms {
			[Export ("supportedDeviceSigningAlgorithms")]
			get {
				return _GetWeakSupportedDeviceSigningAlgorithms (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetWeakSupportedDeviceSigningAlgorithms (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedDeviceSigningAlgorithms")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSNumber[] WeakSupportedDeviceEncryptionAlgorithms {
			[Export ("supportedDeviceEncryptionAlgorithms")]
			get {
				return _GetWeakSupportedDeviceEncryptionAlgorithms (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetWeakSupportedDeviceEncryptionAlgorithms (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedDeviceEncryptionAlgorithms")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSNumber[] WeakSupportedUserSecureEnclaveKeySigningAlgorithms {
			[Export ("supportedUserSecureEnclaveKeySigningAlgorithms")]
			get {
				return _GetWeakSupportedUserSecureEnclaveKeySigningAlgorithms (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetWeakSupportedUserSecureEnclaveKeySigningAlgorithms (IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedUserSecureEnclaveKeySigningAlgorithms")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IASAuthorizationProviderExtensionRegistrationHandler" /> interface to support all the methods from the ASAuthorizationProviderExtensionRegistrationHandler protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IASAuthorizationProviderExtensionRegistrationHandler" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ASAuthorizationProviderExtensionRegistrationHandler protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ASAuthorizationProviderExtensionRegistrationHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegistrationDidComplete (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("registrationDidComplete"));
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegistrationDidCancel (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("registrationDidCancel"));
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void KeyWillRotateForKeyType (this IASAuthorizationProviderExtensionRegistrationHandler This, ASAuthorizationProviderExtensionKeyType keyType, global::Security.SecKey newKey, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completion)
		{
			var newKey__handle__ = newKey!.GetNonNullHandle (nameof (newKey));
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V2.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("keyWillRotateForKeyType:newKey:loginManager:completion:"), (IntPtr) (long) keyType, newKey.Handle, loginManager__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (newKey);
			GC.KeepAlive (loginManager);
		}
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetDisplayNames (this IASAuthorizationProviderExtensionRegistrationHandler This, string[] groups, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback completion)
		{
			if (groups is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groups));
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_groups = NSArray.FromStrings (groups);
			using var block_completion = Trampolines.SDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("displayNamesForGroups:loginManager:completion:"), nsa_groups.Handle, loginManager__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (loginManager);
		}
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetProfilePictureForUser (this IASAuthorizationProviderExtensionRegistrationHandler This, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback completion)
		{
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profilePictureForUserUsingLoginManager:completion:"), loginManager__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (loginManager);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ASAuthorizationProviderExtensionSupportedGrantTypes GetSupportedGrantTypes (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			ASAuthorizationProviderExtensionSupportedGrantTypes ret;
			ret = (AuthenticationServices.ASAuthorizationProviderExtensionSupportedGrantTypes) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("supportedGrantTypes"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ASAuthorizationProviderExtensionPlatformSSOProtocolVersion GetProtocolVersion (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			ASAuthorizationProviderExtensionPlatformSSOProtocolVersion ret;
			ret = (AuthenticationServices.ASAuthorizationProviderExtensionPlatformSSOProtocolVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("protocolVersion"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] GetWeakSupportedDeviceSigningAlgorithms (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedDeviceSigningAlgorithms")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] GetWeakSupportedDeviceEncryptionAlgorithms (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedDeviceEncryptionAlgorithms")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] GetWeakSupportedUserSecureEnclaveKeySigningAlgorithms (this IASAuthorizationProviderExtensionRegistrationHandler This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedUserSecureEnclaveKeySigningAlgorithms")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationProviderExtensionRegistrationHandlerWrapper : BaseWrapper, IASAuthorizationProviderExtensionRegistrationHandler {
		public ASAuthorizationProviderExtensionRegistrationHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationProviderExtensionRegistrationHandlerWrapper))]
		static ASAuthorizationProviderExtensionRegistrationHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("beginDeviceRegistrationUsingLoginManager:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void BeginDeviceRegistration (ASAuthorizationProviderExtensionLoginManager loginManager, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V27.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("beginDeviceRegistrationUsingLoginManager:options:completion:"), loginManager__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			GC.KeepAlive (loginManager);
		}
		[Export ("beginUserRegistrationUsingLoginManager:userName:authenticationMethod:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void BeginUserRegistration (ASAuthorizationProviderExtensionLoginManager loginManager, string? userName, ASAuthorizationProviderExtensionAuthenticationMethod authenticationMethod, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			var loginManager__handle__ = loginManager!.GetNonNullHandle (nameof (loginManager));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsuserName = CFString.CreateNative (userName);
			using var block_handler = Trampolines.SDActionArity1V27.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("beginUserRegistrationUsingLoginManager:userName:authenticationMethod:options:completion:"), loginManager__handle__, nsuserName, (IntPtr) (long) authenticationMethod, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			GC.KeepAlive (loginManager);
			CFString.ReleaseNative (nsuserName);
		}
	}
}
namespace AuthenticationServices {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IASAuthorizationProviderExtensionRegistrationHandler" /> (for the protocol <c>ASAuthorizationProviderExtensionRegistrationHandler</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IASAuthorizationProviderExtensionRegistrationHandler" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AuthenticationServices_ASAuthorizationProviderExtensionRegistrationHandler", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.0")]
	public unsafe abstract partial class ASAuthorizationProviderExtensionRegistrationHandler : NSObject, IASAuthorizationProviderExtensionRegistrationHandler {
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
		protected ASAuthorizationProviderExtensionRegistrationHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal ASAuthorizationProviderExtensionRegistrationHandler (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("beginDeviceRegistrationUsingLoginManager:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginDeviceRegistration (ASAuthorizationProviderExtensionLoginManager loginManager, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("beginUserRegistrationUsingLoginManager:userName:authenticationMethod:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginUserRegistration (ASAuthorizationProviderExtensionLoginManager loginManager, string? userName, ASAuthorizationProviderExtensionAuthenticationMethod authenticationMethod, ASAuthorizationProviderExtensionRequestOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V27))]global::System.Action<ASAuthorizationProviderExtensionRegistrationResult> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("displayNamesForGroups:loginManager:completion:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetDisplayNames (string[] groups, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("profilePictureForUserUsingLoginManager:completion:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetProfilePictureForUser (ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback))]ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("keyWillRotateForKeyType:newKey:loginManager:completion:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void KeyWillRotateForKeyType (ASAuthorizationProviderExtensionKeyType keyType, global::Security.SecKey newKey, ASAuthorizationProviderExtensionLoginManager loginManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("registrationDidCancel")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegistrationDidCancel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("registrationDidComplete")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegistrationDidComplete ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionPlatformSSOProtocolVersion ProtocolVersion {
			[Export ("protocolVersion")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionEncryptionAlgorithm[] SupportedDeviceEncryptionAlgorithms {
			[SupportedOSPlatform ("macos15.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				return ASAuthorizationProviderExtensionEncryptionAlgorithmExtensions.ToEnumArray (WeakSupportedDeviceEncryptionAlgorithms)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionSigningAlgorithm[] SupportedDeviceSigningAlgorithms {
			[SupportedOSPlatform ("macos15.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				return ASAuthorizationProviderExtensionSigningAlgorithmExtensions.ToEnumArray (WeakSupportedDeviceSigningAlgorithms)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionSupportedGrantTypes SupportedGrantTypes {
			[Export ("supportedGrantTypes")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionSigningAlgorithm[] SupportedUserSecureEnclaveKeySigningAlgorithms {
			[SupportedOSPlatform ("macos15.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				return ASAuthorizationProviderExtensionSigningAlgorithmExtensions.ToEnumArray (WeakSupportedUserSecureEnclaveKeySigningAlgorithms)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSNumber[] WeakSupportedDeviceEncryptionAlgorithms {
			[Export ("supportedDeviceEncryptionAlgorithms")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSNumber[] WeakSupportedDeviceSigningAlgorithms {
			[Export ("supportedDeviceSigningAlgorithms")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSNumber[] WeakSupportedUserSecureEnclaveKeySigningAlgorithms {
			[Export ("supportedUserSecureEnclaveKeySigningAlgorithms")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class ASAuthorizationProviderExtensionRegistrationHandler */
}
