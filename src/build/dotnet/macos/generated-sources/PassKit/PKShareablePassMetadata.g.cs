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
namespace PassKit {
	[Register("PKShareablePassMetadata", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PKShareablePassMetadata : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccountHashX = "accountHash";
		static readonly NativeHandle selAccountHashXHandle = Selector.GetHandle ("accountHash");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCardConfigurationIdentifierX = "cardConfigurationIdentifier";
		static readonly NativeHandle selCardConfigurationIdentifierXHandle = Selector.GetHandle ("cardConfigurationIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCardTemplateIdentifierX = "cardTemplateIdentifier";
		static readonly NativeHandle selCardTemplateIdentifierXHandle = Selector.GetHandle ("cardTemplateIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCredentialIdentifierX = "credentialIdentifier";
		static readonly NativeHandle selCredentialIdentifierXHandle = Selector.GetHandle ("credentialIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProvisioningCredentialIdentifier_CardConfigurationIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_X = "initWithProvisioningCredentialIdentifier:cardConfigurationIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:";
		static readonly NativeHandle selInitWithProvisioningCredentialIdentifier_CardConfigurationIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_XHandle = Selector.GetHandle ("initWithProvisioningCredentialIdentifier:cardConfigurationIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardConfigurationIdentifier_Preview_X = "initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:cardConfigurationIdentifier:preview:";
		static readonly NativeHandle selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardConfigurationIdentifier_Preview_XHandle = Selector.GetHandle ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:cardConfigurationIdentifier:preview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardTemplateIdentifier_Preview_X = "initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:cardTemplateIdentifier:preview:";
		static readonly NativeHandle selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardTemplateIdentifier_Preview_XHandle = Selector.GetHandle ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:cardTemplateIdentifier:preview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_AccountHash_TemplateIdentifier_RelyingPartyIdentifier_RequiresUnifiedAccessCapableDevice_X = "initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:accountHash:templateIdentifier:relyingPartyIdentifier:requiresUnifiedAccessCapableDevice:";
		static readonly NativeHandle selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_AccountHash_TemplateIdentifier_RelyingPartyIdentifier_RequiresUnifiedAccessCapableDevice_XHandle = Selector.GetHandle ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:accountHash:templateIdentifier:relyingPartyIdentifier:requiresUnifiedAccessCapableDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionX = "localizedDescription";
		static readonly NativeHandle selLocalizedDescriptionXHandle = Selector.GetHandle ("localizedDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOwnerDisplayNameX = "ownerDisplayName";
		static readonly NativeHandle selOwnerDisplayNameXHandle = Selector.GetHandle ("ownerDisplayName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPassThumbnailImageX = "passThumbnailImage";
		static readonly NativeHandle selPassThumbnailImageXHandle = Selector.GetHandle ("passThumbnailImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewX = "preview";
		static readonly NativeHandle selPreviewXHandle = Selector.GetHandle ("preview");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelyingPartyIdentifierX = "relyingPartyIdentifier";
		static readonly NativeHandle selRelyingPartyIdentifierXHandle = Selector.GetHandle ("relyingPartyIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiresUnifiedAccessCapableDeviceX = "requiresUnifiedAccessCapableDevice";
		static readonly NativeHandle selRequiresUnifiedAccessCapableDeviceXHandle = Selector.GetHandle ("requiresUnifiedAccessCapableDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServerEnvironmentIdentifierX = "serverEnvironmentIdentifier";
		static readonly NativeHandle selServerEnvironmentIdentifierXHandle = Selector.GetHandle ("serverEnvironmentIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccountHash_X = "setAccountHash:";
		static readonly NativeHandle selSetAccountHash_XHandle = Selector.GetHandle ("setAccountHash:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRelyingPartyIdentifier_X = "setRelyingPartyIdentifier:";
		static readonly NativeHandle selSetRelyingPartyIdentifier_XHandle = Selector.GetHandle ("setRelyingPartyIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequiresUnifiedAccessCapableDevice_X = "setRequiresUnifiedAccessCapableDevice:";
		static readonly NativeHandle selSetRequiresUnifiedAccessCapableDevice_XHandle = Selector.GetHandle ("setRequiresUnifiedAccessCapableDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetServerEnvironmentIdentifier_X = "setServerEnvironmentIdentifier:";
		static readonly NativeHandle selSetServerEnvironmentIdentifier_XHandle = Selector.GetHandle ("setServerEnvironmentIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharingInstanceIdentifierX = "sharingInstanceIdentifier";
		static readonly NativeHandle selSharingInstanceIdentifierXHandle = Selector.GetHandle ("sharingInstanceIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemplateIdentifierX = "templateIdentifier";
		static readonly NativeHandle selTemplateIdentifierXHandle = Selector.GetHandle ("templateIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PKShareablePassMetadata");
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
		protected PKShareablePassMetadata (NSObjectFlag t) : base (t)
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
		protected internal PKShareablePassMetadata (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithProvisioningCredentialIdentifier:cardConfigurationIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKShareablePassMetadata (string credentialIdentifier, string cardConfigurationIdentifier, string sharingInstanceIdentifier, CGImage passThumbnailImage, string ownerDisplayName, string localizedDescription)
			: base (NSObjectFlag.Empty)
		{
			if (credentialIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (credentialIdentifier));
			if (cardConfigurationIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cardConfigurationIdentifier));
			if (sharingInstanceIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sharingInstanceIdentifier));
			var passThumbnailImage__handle__ = passThumbnailImage!.GetNonNullHandle (nameof (passThumbnailImage));
			if (ownerDisplayName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ownerDisplayName));
			if (localizedDescription is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedDescription));
			var nscredentialIdentifier = CFString.CreateNative (credentialIdentifier);
			var nscardConfigurationIdentifier = CFString.CreateNative (cardConfigurationIdentifier);
			var nssharingInstanceIdentifier = CFString.CreateNative (sharingInstanceIdentifier);
			var nsownerDisplayName = CFString.CreateNative (ownerDisplayName);
			var nslocalizedDescription = CFString.CreateNative (localizedDescription);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithProvisioningCredentialIdentifier_CardConfigurationIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_XHandle, nscredentialIdentifier, nscardConfigurationIdentifier, nssharingInstanceIdentifier, passThumbnailImage.Handle, nsownerDisplayName, nslocalizedDescription), "initWithProvisioningCredentialIdentifier:cardConfigurationIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithProvisioningCredentialIdentifier_CardConfigurationIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_XHandle, nscredentialIdentifier, nscardConfigurationIdentifier, nssharingInstanceIdentifier, passThumbnailImage.Handle, nsownerDisplayName, nslocalizedDescription), "initWithProvisioningCredentialIdentifier:cardConfigurationIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (passThumbnailImage);
			CFString.ReleaseNative (nscredentialIdentifier);
			CFString.ReleaseNative (nscardConfigurationIdentifier);
			CFString.ReleaseNative (nssharingInstanceIdentifier);
			CFString.ReleaseNative (nsownerDisplayName);
			CFString.ReleaseNative (nslocalizedDescription);
		}
		[Export ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:accountHash:templateIdentifier:relyingPartyIdentifier:requiresUnifiedAccessCapableDevice:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKShareablePassMetadata (string credentialIdentifier, string sharingInstanceIdentifier, CGImage passThumbnailImage, string ownerDisplayName, string localizedDescription, string accountHash, string templateIdentifier, string relyingPartyIdentifier, bool requiresUnifiedAccessCapableDevice)
			: base (NSObjectFlag.Empty)
		{
			if (credentialIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (credentialIdentifier));
			if (sharingInstanceIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sharingInstanceIdentifier));
			var passThumbnailImage__handle__ = passThumbnailImage!.GetNonNullHandle (nameof (passThumbnailImage));
			if (ownerDisplayName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ownerDisplayName));
			if (localizedDescription is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedDescription));
			if (accountHash is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountHash));
			if (templateIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (templateIdentifier));
			if (relyingPartyIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (relyingPartyIdentifier));
			var nscredentialIdentifier = CFString.CreateNative (credentialIdentifier);
			var nssharingInstanceIdentifier = CFString.CreateNative (sharingInstanceIdentifier);
			var nsownerDisplayName = CFString.CreateNative (ownerDisplayName);
			var nslocalizedDescription = CFString.CreateNative (localizedDescription);
			var nsaccountHash = CFString.CreateNative (accountHash);
			var nstemplateIdentifier = CFString.CreateNative (templateIdentifier);
			var nsrelyingPartyIdentifier = CFString.CreateNative (relyingPartyIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_AccountHash_TemplateIdentifier_RelyingPartyIdentifier_RequiresUnifiedAccessCapableDevice_XHandle, nscredentialIdentifier, nssharingInstanceIdentifier, passThumbnailImage.Handle, nsownerDisplayName, nslocalizedDescription, nsaccountHash, nstemplateIdentifier, nsrelyingPartyIdentifier, requiresUnifiedAccessCapableDevice ? (byte) 1 : (byte) 0), "initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:accountHash:templateIdentifier:relyingPartyIdentifier:requiresUnifiedAccessCapableDevice:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_PassThumbnailImage_OwnerDisplayName_LocalizedDescription_AccountHash_TemplateIdentifier_RelyingPartyIdentifier_RequiresUnifiedAccessCapableDevice_XHandle, nscredentialIdentifier, nssharingInstanceIdentifier, passThumbnailImage.Handle, nsownerDisplayName, nslocalizedDescription, nsaccountHash, nstemplateIdentifier, nsrelyingPartyIdentifier, requiresUnifiedAccessCapableDevice ? (byte) 1 : (byte) 0), "initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:accountHash:templateIdentifier:relyingPartyIdentifier:requiresUnifiedAccessCapableDevice:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (passThumbnailImage);
			CFString.ReleaseNative (nscredentialIdentifier);
			CFString.ReleaseNative (nssharingInstanceIdentifier);
			CFString.ReleaseNative (nsownerDisplayName);
			CFString.ReleaseNative (nslocalizedDescription);
			CFString.ReleaseNative (nsaccountHash);
			CFString.ReleaseNative (nstemplateIdentifier);
			CFString.ReleaseNative (nsrelyingPartyIdentifier);
		}
		[Export ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:cardConfigurationIdentifier:preview:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithCardConfiguration (string credentialIdentifier, string sharingInstanceIdentifier, string templateIdentifier, PKShareablePassMetadataPreview preview)
		{
			if (credentialIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (credentialIdentifier));
			if (sharingInstanceIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sharingInstanceIdentifier));
			if (templateIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (templateIdentifier));
			var preview__handle__ = preview!.GetNonNullHandle (nameof (preview));
			var nscredentialIdentifier = CFString.CreateNative (credentialIdentifier);
			var nssharingInstanceIdentifier = CFString.CreateNative (sharingInstanceIdentifier);
			var nstemplateIdentifier = CFString.CreateNative (templateIdentifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardConfigurationIdentifier_Preview_XHandle, nscredentialIdentifier, nssharingInstanceIdentifier, nstemplateIdentifier, preview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardConfigurationIdentifier_Preview_XHandle, nscredentialIdentifier, nssharingInstanceIdentifier, nstemplateIdentifier, preview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preview);
			CFString.ReleaseNative (nscredentialIdentifier);
			CFString.ReleaseNative (nssharingInstanceIdentifier);
			CFString.ReleaseNative (nstemplateIdentifier);
			return ret!;
		}
		[Export ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:cardTemplateIdentifier:preview:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithCardTemplate (string credentialIdentifier, string sharingInstanceIdentifier, string templateIdentifier, PKShareablePassMetadataPreview preview)
		{
			if (credentialIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (credentialIdentifier));
			if (sharingInstanceIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sharingInstanceIdentifier));
			if (templateIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (templateIdentifier));
			var preview__handle__ = preview!.GetNonNullHandle (nameof (preview));
			var nscredentialIdentifier = CFString.CreateNative (credentialIdentifier);
			var nssharingInstanceIdentifier = CFString.CreateNative (sharingInstanceIdentifier);
			var nstemplateIdentifier = CFString.CreateNative (templateIdentifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardTemplateIdentifier_Preview_XHandle, nscredentialIdentifier, nssharingInstanceIdentifier, nstemplateIdentifier, preview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithProvisioningCredentialIdentifier_SharingInstanceIdentifier_CardTemplateIdentifier_Preview_XHandle, nscredentialIdentifier, nssharingInstanceIdentifier, nstemplateIdentifier, preview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preview);
			CFString.ReleaseNative (nscredentialIdentifier);
			CFString.ReleaseNative (nssharingInstanceIdentifier);
			CFString.ReleaseNative (nstemplateIdentifier);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccountHash {
			[Export ("accountHash", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccountHashXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccountHashXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccountHash:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccountHash_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccountHash_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CardConfigurationIdentifier {
			[Export ("cardConfigurationIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCardConfigurationIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCardConfigurationIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual string CardTemplateIdentifier {
			[Export ("cardTemplateIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCardTemplateIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCardTemplateIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CredentialIdentifier {
			[Export ("credentialIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCredentialIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCredentialIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string LocalizedDescription {
			[Export ("localizedDescription", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string OwnerDisplayName {
			[Export ("ownerDisplayName", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOwnerDisplayNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOwnerDisplayNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CGImage PassThumbnailImage {
			[Export ("passThumbnailImage")]
			get {
				CGImage ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPassThumbnailImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPassThumbnailImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual PKShareablePassMetadataPreview Preview {
			[Export ("preview", ArgumentSemantic.Retain)]
			get {
				PKShareablePassMetadataPreview? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PKShareablePassMetadataPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PKShareablePassMetadataPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string RelyingPartyIdentifier {
			[Export ("relyingPartyIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRelyingPartyIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRelyingPartyIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRelyingPartyIdentifier:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRelyingPartyIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRelyingPartyIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool RequiresUnifiedAccessCapableDevice {
			[Export ("requiresUnifiedAccessCapableDevice")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequiresUnifiedAccessCapableDeviceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRequiresUnifiedAccessCapableDeviceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRequiresUnifiedAccessCapableDevice:")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRequiresUnifiedAccessCapableDevice_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRequiresUnifiedAccessCapableDevice_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual string ServerEnvironmentIdentifier {
			[Export ("serverEnvironmentIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServerEnvironmentIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServerEnvironmentIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setServerEnvironmentIdentifier:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetServerEnvironmentIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetServerEnvironmentIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SharingInstanceIdentifier {
			[Export ("sharingInstanceIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharingInstanceIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharingInstanceIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string TemplateIdentifier {
			[Export ("templateIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTemplateIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTemplateIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class PKShareablePassMetadata */
}
