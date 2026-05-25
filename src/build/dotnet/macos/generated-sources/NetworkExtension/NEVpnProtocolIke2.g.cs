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
namespace NetworkExtension {
	/// <summary>IKEv2 protocol information for VPN connections</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEVPNProtocolIKEv2ClassRef/index.html">Apple documentation for <c>NEVPNProtocolIKEv2</c></related>
	[Register("NEVPNProtocolIKEv2", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NEVpnProtocolIke2 : NEVpnProtocolIpSec {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIKESecurityAssociationParametersX = "IKESecurityAssociationParameters";
		static readonly NativeHandle selIKESecurityAssociationParametersXHandle = Selector.GetHandle ("IKESecurityAssociationParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowPostQuantumKeyExchangeFallbackX = "allowPostQuantumKeyExchangeFallback";
		static readonly NativeHandle selAllowPostQuantumKeyExchangeFallbackXHandle = Selector.GetHandle ("allowPostQuantumKeyExchangeFallback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCertificateTypeX = "certificateType";
		static readonly NativeHandle selCertificateTypeXHandle = Selector.GetHandle ("certificateType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildSecurityAssociationParametersX = "childSecurityAssociationParameters";
		static readonly NativeHandle selChildSecurityAssociationParametersXHandle = Selector.GetHandle ("childSecurityAssociationParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeadPeerDetectionRateX = "deadPeerDetectionRate";
		static readonly NativeHandle selDeadPeerDetectionRateXHandle = Selector.GetHandle ("deadPeerDetectionRate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisableMOBIKEX = "disableMOBIKE";
		static readonly NativeHandle selDisableMOBIKEXHandle = Selector.GetHandle ("disableMOBIKE");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisableRedirectX = "disableRedirect";
		static readonly NativeHandle selDisableRedirectXHandle = Selector.GetHandle ("disableRedirect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnablePFSX = "enablePFS";
		static readonly NativeHandle selEnablePFSXHandle = Selector.GetHandle ("enablePFS");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableRevocationCheckX = "enableRevocationCheck";
		static readonly NativeHandle selEnableRevocationCheckXHandle = Selector.GetHandle ("enableRevocationCheck");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumTLSVersionX = "maximumTLSVersion";
		static readonly NativeHandle selMaximumTLSVersionXHandle = Selector.GetHandle ("maximumTLSVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumTLSVersionX = "minimumTLSVersion";
		static readonly NativeHandle selMinimumTLSVersionXHandle = Selector.GetHandle ("minimumTLSVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMtuX = "mtu";
		static readonly NativeHandle selMtuXHandle = Selector.GetHandle ("mtu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPpkConfigurationX = "ppkConfiguration";
		static readonly NativeHandle selPpkConfigurationXHandle = Selector.GetHandle ("ppkConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServerCertificateCommonNameX = "serverCertificateCommonName";
		static readonly NativeHandle selServerCertificateCommonNameXHandle = Selector.GetHandle ("serverCertificateCommonName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServerCertificateIssuerCommonNameX = "serverCertificateIssuerCommonName";
		static readonly NativeHandle selServerCertificateIssuerCommonNameXHandle = Selector.GetHandle ("serverCertificateIssuerCommonName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowPostQuantumKeyExchangeFallback_X = "setAllowPostQuantumKeyExchangeFallback:";
		static readonly NativeHandle selSetAllowPostQuantumKeyExchangeFallback_XHandle = Selector.GetHandle ("setAllowPostQuantumKeyExchangeFallback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCertificateType_X = "setCertificateType:";
		static readonly NativeHandle selSetCertificateType_XHandle = Selector.GetHandle ("setCertificateType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeadPeerDetectionRate_X = "setDeadPeerDetectionRate:";
		static readonly NativeHandle selSetDeadPeerDetectionRate_XHandle = Selector.GetHandle ("setDeadPeerDetectionRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisableMOBIKE_X = "setDisableMOBIKE:";
		static readonly NativeHandle selSetDisableMOBIKE_XHandle = Selector.GetHandle ("setDisableMOBIKE:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisableRedirect_X = "setDisableRedirect:";
		static readonly NativeHandle selSetDisableRedirect_XHandle = Selector.GetHandle ("setDisableRedirect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnablePFS_X = "setEnablePFS:";
		static readonly NativeHandle selSetEnablePFS_XHandle = Selector.GetHandle ("setEnablePFS:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnableRevocationCheck_X = "setEnableRevocationCheck:";
		static readonly NativeHandle selSetEnableRevocationCheck_XHandle = Selector.GetHandle ("setEnableRevocationCheck:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumTLSVersion_X = "setMaximumTLSVersion:";
		static readonly NativeHandle selSetMaximumTLSVersion_XHandle = Selector.GetHandle ("setMaximumTLSVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumTLSVersion_X = "setMinimumTLSVersion:";
		static readonly NativeHandle selSetMinimumTLSVersion_XHandle = Selector.GetHandle ("setMinimumTLSVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMtu_X = "setMtu:";
		static readonly NativeHandle selSetMtu_XHandle = Selector.GetHandle ("setMtu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPpkConfiguration_X = "setPpkConfiguration:";
		static readonly NativeHandle selSetPpkConfiguration_XHandle = Selector.GetHandle ("setPpkConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetServerCertificateCommonName_X = "setServerCertificateCommonName:";
		static readonly NativeHandle selSetServerCertificateCommonName_XHandle = Selector.GetHandle ("setServerCertificateCommonName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetServerCertificateIssuerCommonName_X = "setServerCertificateIssuerCommonName:";
		static readonly NativeHandle selSetServerCertificateIssuerCommonName_XHandle = Selector.GetHandle ("setServerCertificateIssuerCommonName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrictRevocationCheck_X = "setStrictRevocationCheck:";
		static readonly NativeHandle selSetStrictRevocationCheck_XHandle = Selector.GetHandle ("setStrictRevocationCheck:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUseConfigurationAttributeInternalIPSubnet_X = "setUseConfigurationAttributeInternalIPSubnet:";
		static readonly NativeHandle selSetUseConfigurationAttributeInternalIPSubnet_XHandle = Selector.GetHandle ("setUseConfigurationAttributeInternalIPSubnet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrictRevocationCheckX = "strictRevocationCheck";
		static readonly NativeHandle selStrictRevocationCheckXHandle = Selector.GetHandle ("strictRevocationCheck");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseConfigurationAttributeInternalIPSubnetX = "useConfigurationAttributeInternalIPSubnet";
		static readonly NativeHandle selUseConfigurationAttributeInternalIPSubnetXHandle = Selector.GetHandle ("useConfigurationAttributeInternalIPSubnet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NEVPNProtocolIKEv2");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NEVpnProtocolIke2" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NEVpnProtocolIke2 () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NEVpnProtocolIke2 (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

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
		protected NEVpnProtocolIke2 (NSObjectFlag t) : base (t)
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
		protected internal NEVpnProtocolIke2 (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool AllowPostQuantumKeyExchangeFallback {
			[Export ("allowPostQuantumKeyExchangeFallback")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowPostQuantumKeyExchangeFallbackXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowPostQuantumKeyExchangeFallbackXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowPostQuantumKeyExchangeFallback:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowPostQuantumKeyExchangeFallback_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowPostQuantumKeyExchangeFallback_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the certificate type.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NEVpnIke2CertificateType CertificateType {
			[Export ("certificateType")]
			get {
				NEVpnIke2CertificateType ret;
				if (IsDirectBinding) {
					ret = (NEVpnIke2CertificateType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCertificateTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NEVpnIke2CertificateType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCertificateTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCertificateType:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCertificateType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetCertificateType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the security association parameters for child IPSec security associations that will be negotiated with the IKEv2 server.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEVpnIke2SecurityAssociationParameters ChildSecurityAssociationParameters {
			[Export ("childSecurityAssociationParameters")]
			get {
				NEVpnIke2SecurityAssociationParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildSecurityAssociationParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildSecurityAssociationParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the rate at which the IKEv2 client will attempt to detect dead peers.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEVpnIke2DeadPeerDetectionRate DeadPeerDetectionRate {
			[Export ("deadPeerDetectionRate")]
			get {
				NEVpnIke2DeadPeerDetectionRate ret;
				if (IsDirectBinding) {
					ret = (NEVpnIke2DeadPeerDetectionRate) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDeadPeerDetectionRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NEVpnIke2DeadPeerDetectionRate) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDeadPeerDetectionRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDeadPeerDetectionRate:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDeadPeerDetectionRate_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDeadPeerDetectionRate_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that enables and disables MOBIKE.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool DisableMobike {
			[Export ("disableMOBIKE")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisableMOBIKEXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisableMOBIKEXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisableMOBIKE:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisableMOBIKE_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisableMOBIKE_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that enables and disables redirects by IKEv2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool DisableRedirect {
			[Export ("disableRedirect")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisableRedirectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisableRedirectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisableRedirect:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisableRedirect_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisableRedirect_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that enables and disables Perfect Forward Secrecy.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool EnablePfs {
			[Export ("enablePFS")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnablePFSXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEnablePFSXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnablePFS:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnablePFS_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnablePFS_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that enables and disables revocation checking.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool EnableRevocationCheck {
			[Export ("enableRevocationCheck")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableRevocationCheckXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEnableRevocationCheckXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnableRevocationCheck:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableRevocationCheck_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnableRevocationCheck_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the security association parameters for the initial negotiation with the IKEv2 server.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEVpnIke2SecurityAssociationParameters IKESecurityAssociationParameters {
			[Export ("IKESecurityAssociationParameters")]
			get {
				NEVpnIke2SecurityAssociationParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIKESecurityAssociationParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIKESecurityAssociationParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NEVpnIkev2TlsVersion MaximumTlsVersion {
			[Export ("maximumTLSVersion", ArgumentSemantic.Assign)]
			get {
				NEVpnIkev2TlsVersion ret;
				if (IsDirectBinding) {
					ret = (NEVpnIkev2TlsVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaximumTLSVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NEVpnIkev2TlsVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaximumTLSVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaximumTLSVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMaximumTLSVersion_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMaximumTLSVersion_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NEVpnIkev2TlsVersion MinimumTlsVersion {
			[Export ("minimumTLSVersion", ArgumentSemantic.Assign)]
			get {
				NEVpnIkev2TlsVersion ret;
				if (IsDirectBinding) {
					ret = (NEVpnIkev2TlsVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMinimumTLSVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NEVpnIkev2TlsVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMinimumTLSVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMinimumTLSVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMinimumTLSVersion_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMinimumTLSVersion_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint Mtu {
			[Export ("mtu")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMtuXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMtuXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMtu:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMtu_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMtu_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual NEVpnIkev2PpkConfiguration? PpkConfiguration {
			[Export ("ppkConfiguration", ArgumentSemantic.Copy)]
			get {
				NEVpnIkev2PpkConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NEVpnIkev2PpkConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPpkConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NEVpnIkev2PpkConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPpkConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPpkConfiguration:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPpkConfiguration_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPpkConfiguration_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the common name of the server certificate.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ServerCertificateCommonName {
			[Export ("serverCertificateCommonName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServerCertificateCommonNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServerCertificateCommonNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setServerCertificateCommonName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetServerCertificateCommonName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetServerCertificateCommonName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets or sets the common name of issuer of the server certificate.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ServerCertificateIssuerCommonName {
			[Export ("serverCertificateIssuerCommonName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServerCertificateIssuerCommonNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServerCertificateIssuerCommonNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setServerCertificateIssuerCommonName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetServerCertificateIssuerCommonName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetServerCertificateIssuerCommonName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets or sets a Boolean value that enables or disables strict revocation checks.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool StrictRevocationCheck {
			[Export ("strictRevocationCheck")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStrictRevocationCheckXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStrictRevocationCheckXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setStrictRevocationCheck:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStrictRevocationCheck_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetStrictRevocationCheck_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether to use the internal subnets that are sent by the IKEv2 server.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool UseConfigurationAttributeInternalIPSubnet {
			[Export ("useConfigurationAttributeInternalIPSubnet")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseConfigurationAttributeInternalIPSubnetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUseConfigurationAttributeInternalIPSubnetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUseConfigurationAttributeInternalIPSubnet:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseConfigurationAttributeInternalIPSubnet_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUseConfigurationAttributeInternalIPSubnet_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NEVpnProtocolIke2 */
}
