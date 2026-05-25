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
namespace Foundation {
	[Register("NSURLSessionConfiguration", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUrlSessionConfiguration : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHTTPAdditionalHeadersX = "HTTPAdditionalHeaders";
		static readonly NativeHandle selHTTPAdditionalHeadersXHandle = Selector.GetHandle ("HTTPAdditionalHeaders");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHTTPCookieAcceptPolicyX = "HTTPCookieAcceptPolicy";
		static readonly NativeHandle selHTTPCookieAcceptPolicyXHandle = Selector.GetHandle ("HTTPCookieAcceptPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHTTPCookieStorageX = "HTTPCookieStorage";
		static readonly NativeHandle selHTTPCookieStorageXHandle = Selector.GetHandle ("HTTPCookieStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHTTPMaximumConnectionsPerHostX = "HTTPMaximumConnectionsPerHost";
		static readonly NativeHandle selHTTPMaximumConnectionsPerHostXHandle = Selector.GetHandle ("HTTPMaximumConnectionsPerHost");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHTTPShouldSetCookiesX = "HTTPShouldSetCookies";
		static readonly NativeHandle selHTTPShouldSetCookiesXHandle = Selector.GetHandle ("HTTPShouldSetCookies");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHTTPShouldUsePipeliningX = "HTTPShouldUsePipelining";
		static readonly NativeHandle selHTTPShouldUsePipeliningXHandle = Selector.GetHandle ("HTTPShouldUsePipelining");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTLSMaximumSupportedProtocolX = "TLSMaximumSupportedProtocol";
		static readonly NativeHandle selTLSMaximumSupportedProtocolXHandle = Selector.GetHandle ("TLSMaximumSupportedProtocol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTLSMaximumSupportedProtocolVersionX = "TLSMaximumSupportedProtocolVersion";
		static readonly NativeHandle selTLSMaximumSupportedProtocolVersionXHandle = Selector.GetHandle ("TLSMaximumSupportedProtocolVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTLSMinimumSupportedProtocolX = "TLSMinimumSupportedProtocol";
		static readonly NativeHandle selTLSMinimumSupportedProtocolXHandle = Selector.GetHandle ("TLSMinimumSupportedProtocol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTLSMinimumSupportedProtocolVersionX = "TLSMinimumSupportedProtocolVersion";
		static readonly NativeHandle selTLSMinimumSupportedProtocolVersionXHandle = Selector.GetHandle ("TLSMinimumSupportedProtocolVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLCacheX = "URLCache";
		static readonly NativeHandle selURLCacheXHandle = Selector.GetHandle ("URLCache");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLCredentialStorageX = "URLCredentialStorage";
		static readonly NativeHandle selURLCredentialStorageXHandle = Selector.GetHandle ("URLCredentialStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCellularAccessX = "allowsCellularAccess";
		static readonly NativeHandle selAllowsCellularAccessXHandle = Selector.GetHandle ("allowsCellularAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsConstrainedNetworkAccessX = "allowsConstrainedNetworkAccess";
		static readonly NativeHandle selAllowsConstrainedNetworkAccessXHandle = Selector.GetHandle ("allowsConstrainedNetworkAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsExpensiveNetworkAccessX = "allowsExpensiveNetworkAccess";
		static readonly NativeHandle selAllowsExpensiveNetworkAccessXHandle = Selector.GetHandle ("allowsExpensiveNetworkAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsUltraConstrainedNetworkAccessX = "allowsUltraConstrainedNetworkAccess";
		static readonly NativeHandle selAllowsUltraConstrainedNetworkAccessXHandle = Selector.GetHandle ("allowsUltraConstrainedNetworkAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundSessionConfiguration_X = "backgroundSessionConfiguration:";
		static readonly NativeHandle selBackgroundSessionConfiguration_XHandle = Selector.GetHandle ("backgroundSessionConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundSessionConfigurationWithIdentifier_X = "backgroundSessionConfigurationWithIdentifier:";
		static readonly NativeHandle selBackgroundSessionConfigurationWithIdentifier_XHandle = Selector.GetHandle ("backgroundSessionConfigurationWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectionProxyDictionaryX = "connectionProxyDictionary";
		static readonly NativeHandle selConnectionProxyDictionaryXHandle = Selector.GetHandle ("connectionProxyDictionary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultSessionConfigurationX = "defaultSessionConfiguration";
		static readonly NativeHandle selDefaultSessionConfigurationXHandle = Selector.GetHandle ("defaultSessionConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnablesEarlyDataX = "enablesEarlyData";
		static readonly NativeHandle selEnablesEarlyDataXHandle = Selector.GetHandle ("enablesEarlyData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEphemeralSessionConfigurationX = "ephemeralSessionConfiguration";
		static readonly NativeHandle selEphemeralSessionConfigurationXHandle = Selector.GetHandle ("ephemeralSessionConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDiscretionaryX = "isDiscretionary";
		static readonly NativeHandle selIsDiscretionaryXHandle = Selector.GetHandle ("isDiscretionary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNetworkServiceTypeX = "networkServiceType";
		static readonly NativeHandle selNetworkServiceTypeXHandle = Selector.GetHandle ("networkServiceType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProtocolClassesX = "protocolClasses";
		static readonly NativeHandle selProtocolClassesXHandle = Selector.GetHandle ("protocolClasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProxyConfigurationsX = "proxyConfigurations";
		static readonly NativeHandle selProxyConfigurationsXHandle = Selector.GetHandle ("proxyConfigurations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestCachePolicyX = "requestCachePolicy";
		static readonly NativeHandle selRequestCachePolicyXHandle = Selector.GetHandle ("requestCachePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiresDNSSECValidationX = "requiresDNSSECValidation";
		static readonly NativeHandle selRequiresDNSSECValidationXHandle = Selector.GetHandle ("requiresDNSSECValidation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSessionSendsLaunchEventsX = "sessionSendsLaunchEvents";
		static readonly NativeHandle selSessionSendsLaunchEventsXHandle = Selector.GetHandle ("sessionSendsLaunchEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsCellularAccess_X = "setAllowsCellularAccess:";
		static readonly NativeHandle selSetAllowsCellularAccess_XHandle = Selector.GetHandle ("setAllowsCellularAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsConstrainedNetworkAccess_X = "setAllowsConstrainedNetworkAccess:";
		static readonly NativeHandle selSetAllowsConstrainedNetworkAccess_XHandle = Selector.GetHandle ("setAllowsConstrainedNetworkAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsExpensiveNetworkAccess_X = "setAllowsExpensiveNetworkAccess:";
		static readonly NativeHandle selSetAllowsExpensiveNetworkAccess_XHandle = Selector.GetHandle ("setAllowsExpensiveNetworkAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsUltraConstrainedNetworkAccess_X = "setAllowsUltraConstrainedNetworkAccess:";
		static readonly NativeHandle selSetAllowsUltraConstrainedNetworkAccess_XHandle = Selector.GetHandle ("setAllowsUltraConstrainedNetworkAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConnectionProxyDictionary_X = "setConnectionProxyDictionary:";
		static readonly NativeHandle selSetConnectionProxyDictionary_XHandle = Selector.GetHandle ("setConnectionProxyDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDiscretionary_X = "setDiscretionary:";
		static readonly NativeHandle selSetDiscretionary_XHandle = Selector.GetHandle ("setDiscretionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnablesEarlyData_X = "setEnablesEarlyData:";
		static readonly NativeHandle selSetEnablesEarlyData_XHandle = Selector.GetHandle ("setEnablesEarlyData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHTTPAdditionalHeaders_X = "setHTTPAdditionalHeaders:";
		static readonly NativeHandle selSetHTTPAdditionalHeaders_XHandle = Selector.GetHandle ("setHTTPAdditionalHeaders:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHTTPCookieAcceptPolicy_X = "setHTTPCookieAcceptPolicy:";
		static readonly NativeHandle selSetHTTPCookieAcceptPolicy_XHandle = Selector.GetHandle ("setHTTPCookieAcceptPolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHTTPCookieStorage_X = "setHTTPCookieStorage:";
		static readonly NativeHandle selSetHTTPCookieStorage_XHandle = Selector.GetHandle ("setHTTPCookieStorage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHTTPMaximumConnectionsPerHost_X = "setHTTPMaximumConnectionsPerHost:";
		static readonly NativeHandle selSetHTTPMaximumConnectionsPerHost_XHandle = Selector.GetHandle ("setHTTPMaximumConnectionsPerHost:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHTTPShouldSetCookies_X = "setHTTPShouldSetCookies:";
		static readonly NativeHandle selSetHTTPShouldSetCookies_XHandle = Selector.GetHandle ("setHTTPShouldSetCookies:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHTTPShouldUsePipelining_X = "setHTTPShouldUsePipelining:";
		static readonly NativeHandle selSetHTTPShouldUsePipelining_XHandle = Selector.GetHandle ("setHTTPShouldUsePipelining:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNetworkServiceType_X = "setNetworkServiceType:";
		static readonly NativeHandle selSetNetworkServiceType_XHandle = Selector.GetHandle ("setNetworkServiceType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProtocolClasses_X = "setProtocolClasses:";
		static readonly NativeHandle selSetProtocolClasses_XHandle = Selector.GetHandle ("setProtocolClasses:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProxyConfigurations_X = "setProxyConfigurations:";
		static readonly NativeHandle selSetProxyConfigurations_XHandle = Selector.GetHandle ("setProxyConfigurations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequestCachePolicy_X = "setRequestCachePolicy:";
		static readonly NativeHandle selSetRequestCachePolicy_XHandle = Selector.GetHandle ("setRequestCachePolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequiresDNSSECValidation_X = "setRequiresDNSSECValidation:";
		static readonly NativeHandle selSetRequiresDNSSECValidation_XHandle = Selector.GetHandle ("setRequiresDNSSECValidation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSessionSendsLaunchEvents_X = "setSessionSendsLaunchEvents:";
		static readonly NativeHandle selSetSessionSendsLaunchEvents_XHandle = Selector.GetHandle ("setSessionSendsLaunchEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSharedContainerIdentifier_X = "setSharedContainerIdentifier:";
		static readonly NativeHandle selSetSharedContainerIdentifier_XHandle = Selector.GetHandle ("setSharedContainerIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldUseExtendedBackgroundIdleMode_X = "setShouldUseExtendedBackgroundIdleMode:";
		static readonly NativeHandle selSetShouldUseExtendedBackgroundIdleMode_XHandle = Selector.GetHandle ("setShouldUseExtendedBackgroundIdleMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTLSMaximumSupportedProtocol_X = "setTLSMaximumSupportedProtocol:";
		static readonly NativeHandle selSetTLSMaximumSupportedProtocol_XHandle = Selector.GetHandle ("setTLSMaximumSupportedProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTLSMaximumSupportedProtocolVersion_X = "setTLSMaximumSupportedProtocolVersion:";
		static readonly NativeHandle selSetTLSMaximumSupportedProtocolVersion_XHandle = Selector.GetHandle ("setTLSMaximumSupportedProtocolVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTLSMinimumSupportedProtocol_X = "setTLSMinimumSupportedProtocol:";
		static readonly NativeHandle selSetTLSMinimumSupportedProtocol_XHandle = Selector.GetHandle ("setTLSMinimumSupportedProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTLSMinimumSupportedProtocolVersion_X = "setTLSMinimumSupportedProtocolVersion:";
		static readonly NativeHandle selSetTLSMinimumSupportedProtocolVersion_XHandle = Selector.GetHandle ("setTLSMinimumSupportedProtocolVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeoutIntervalForRequest_X = "setTimeoutIntervalForRequest:";
		static readonly NativeHandle selSetTimeoutIntervalForRequest_XHandle = Selector.GetHandle ("setTimeoutIntervalForRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeoutIntervalForResource_X = "setTimeoutIntervalForResource:";
		static readonly NativeHandle selSetTimeoutIntervalForResource_XHandle = Selector.GetHandle ("setTimeoutIntervalForResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetURLCache_X = "setURLCache:";
		static readonly NativeHandle selSetURLCache_XHandle = Selector.GetHandle ("setURLCache:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetURLCredentialStorage_X = "setURLCredentialStorage:";
		static readonly NativeHandle selSetURLCredentialStorage_XHandle = Selector.GetHandle ("setURLCredentialStorage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesClassicLoadingMode_X = "setUsesClassicLoadingMode:";
		static readonly NativeHandle selSetUsesClassicLoadingMode_XHandle = Selector.GetHandle ("setUsesClassicLoadingMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWaitsForConnectivity_X = "setWaitsForConnectivity:";
		static readonly NativeHandle selSetWaitsForConnectivity_XHandle = Selector.GetHandle ("setWaitsForConnectivity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedContainerIdentifierX = "sharedContainerIdentifier";
		static readonly NativeHandle selSharedContainerIdentifierXHandle = Selector.GetHandle ("sharedContainerIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldUseExtendedBackgroundIdleModeX = "shouldUseExtendedBackgroundIdleMode";
		static readonly NativeHandle selShouldUseExtendedBackgroundIdleModeXHandle = Selector.GetHandle ("shouldUseExtendedBackgroundIdleMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeoutIntervalForRequestX = "timeoutIntervalForRequest";
		static readonly NativeHandle selTimeoutIntervalForRequestXHandle = Selector.GetHandle ("timeoutIntervalForRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeoutIntervalForResourceX = "timeoutIntervalForResource";
		static readonly NativeHandle selTimeoutIntervalForResourceXHandle = Selector.GetHandle ("timeoutIntervalForResource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesClassicLoadingModeX = "usesClassicLoadingMode";
		static readonly NativeHandle selUsesClassicLoadingModeXHandle = Selector.GetHandle ("usesClassicLoadingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitsForConnectivityX = "waitsForConnectivity";
		static readonly NativeHandle selWaitsForConnectivityXHandle = Selector.GetHandle ("waitsForConnectivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSURLSessionConfiguration");
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
		protected NSUrlSessionConfiguration (NSObjectFlag t) : base (t)
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
		protected internal NSUrlSessionConfiguration (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("backgroundSessionConfiguration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlSessionConfiguration _BackgroundSessionConfiguration (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NSUrlSessionConfiguration? ret;
			ret =  Runtime.GetNSObject<NSUrlSessionConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBackgroundSessionConfiguration_XHandle, nsidentifier), false)!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("backgroundSessionConfigurationWithIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlSessionConfiguration _CreateBackgroundSessionConfiguration (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NSUrlSessionConfiguration? ret;
			ret =  Runtime.GetNSObject<NSUrlSessionConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBackgroundSessionConfigurationWithIdentifier_XHandle, nsidentifier), false)!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsCellularAccess {
			[Export ("allowsCellularAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCellularAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsCellularAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsCellularAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCellularAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsCellularAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsConstrainedNetworkAccess {
			[Export ("allowsConstrainedNetworkAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsConstrainedNetworkAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsConstrainedNetworkAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsConstrainedNetworkAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsConstrainedNetworkAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsConstrainedNetworkAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsExpensiveNetworkAccess {
			[Export ("allowsExpensiveNetworkAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsExpensiveNetworkAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsExpensiveNetworkAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsExpensiveNetworkAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsExpensiveNetworkAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsExpensiveNetworkAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.1")]
		[SupportedOSPlatform ("macos26.1")]
		[SupportedOSPlatform ("ios26.1")]
		[SupportedOSPlatform ("maccatalyst26.1")]
		public virtual bool AllowsUltraConstrainedNetworkAccess {
			[Export ("allowsUltraConstrainedNetworkAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsUltraConstrainedNetworkAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsUltraConstrainedNetworkAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsUltraConstrainedNetworkAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsUltraConstrainedNetworkAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsUltraConstrainedNetworkAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? ConnectionProxyDictionary {
			[Export ("connectionProxyDictionary", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConnectionProxyDictionaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConnectionProxyDictionaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConnectionProxyDictionary:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetConnectionProxyDictionary_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetConnectionProxyDictionary_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Whether background tasks can be scheduled at the discretion of the system in order to improve performance.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Discretionary {
			[Export ("isDiscretionary")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDiscretionaryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDiscretionaryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDiscretionary:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDiscretionary_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDiscretionary_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool EnablesEarlyData {
			[Export ("enablesEarlyData")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnablesEarlyDataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEnablesEarlyDataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnablesEarlyData:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnablesEarlyData_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnablesEarlyData_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? HttpAdditionalHeaders {
			[Export ("HTTPAdditionalHeaders", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHTTPAdditionalHeadersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHTTPAdditionalHeadersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHTTPAdditionalHeaders:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHTTPAdditionalHeaders_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHTTPAdditionalHeaders_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSHttpCookieAcceptPolicy HttpCookieAcceptPolicy {
			[Export ("HTTPCookieAcceptPolicy")]
			get {
				NSHttpCookieAcceptPolicy ret;
				if (IsDirectBinding) {
					ret = (NSHttpCookieAcceptPolicy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selHTTPCookieAcceptPolicyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSHttpCookieAcceptPolicy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selHTTPCookieAcceptPolicyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHTTPCookieAcceptPolicy:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetHTTPCookieAcceptPolicy_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetHTTPCookieAcceptPolicy_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSHttpCookieStorage? HttpCookieStorage {
			[Export ("HTTPCookieStorage", ArgumentSemantic.Retain)]
			get {
				NSHttpCookieStorage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSHttpCookieStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHTTPCookieStorageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSHttpCookieStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHTTPCookieStorageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHTTPCookieStorage:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHTTPCookieStorage_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHTTPCookieStorage_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint HttpMaximumConnectionsPerHost {
			[Export ("HTTPMaximumConnectionsPerHost")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHTTPMaximumConnectionsPerHostXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selHTTPMaximumConnectionsPerHostXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHTTPMaximumConnectionsPerHost:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHTTPMaximumConnectionsPerHost_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetHTTPMaximumConnectionsPerHost_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HttpShouldSetCookies {
			[Export ("HTTPShouldSetCookies")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHTTPShouldSetCookiesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHTTPShouldSetCookiesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHTTPShouldSetCookies:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHTTPShouldSetCookies_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHTTPShouldSetCookies_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios18.4", "Use HTTP/2 or HTTP/3 instead. Only supported when the classic loader is enabled.")]
		[ObsoletedOSPlatform ("tvos18.4", "Use HTTP/2 or HTTP/3 instead. Only supported when the classic loader is enabled.")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Use HTTP/2 or HTTP/3 instead. Only supported when the classic loader is enabled.")]
		[ObsoletedOSPlatform ("macos15.4", "Use HTTP/2 or HTTP/3 instead. Only supported when the classic loader is enabled.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool HttpShouldUsePipelining {
			[Export ("HTTPShouldUsePipelining")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHTTPShouldUsePipeliningXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHTTPShouldUsePipeliningXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHTTPShouldUsePipelining:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHTTPShouldUsePipelining_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHTTPShouldUsePipelining_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequestNetworkServiceType NetworkServiceType {
			[Export ("networkServiceType")]
			get {
				NSUrlRequestNetworkServiceType ret;
				if (IsDirectBinding) {
					ret = (NSUrlRequestNetworkServiceType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNetworkServiceTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUrlRequestNetworkServiceType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNetworkServiceTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setNetworkServiceType:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetNetworkServiceType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetNetworkServiceType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequestCachePolicy RequestCachePolicy {
			[Export ("requestCachePolicy")]
			get {
				NSUrlRequestCachePolicy ret;
				if (IsDirectBinding) {
					ret = (NSUrlRequestCachePolicy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRequestCachePolicyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUrlRequestCachePolicy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRequestCachePolicyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRequestCachePolicy:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRequestCachePolicy_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRequestCachePolicy_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual bool RequiresDnsSecValidation {
			[Export ("requiresDNSSECValidation")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequiresDNSSECValidationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRequiresDNSSECValidationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRequiresDNSSECValidation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRequiresDNSSECValidation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRequiresDNSSECValidation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool SessionSendsLaunchEvents {
			[Export ("sessionSendsLaunchEvents")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSessionSendsLaunchEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSessionSendsLaunchEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSessionSendsLaunchEvents:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSessionSendsLaunchEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSessionSendsLaunchEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? SharedContainerIdentifier {
			[Export ("sharedContainerIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharedContainerIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharedContainerIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSharedContainerIdentifier:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSharedContainerIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSharedContainerIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios18.4", "Not supported anymore.")]
		[ObsoletedOSPlatform ("tvos18.4", "Not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not supported anymore.")]
		[ObsoletedOSPlatform ("macos15.4", "Not supported anymore.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShouldUseExtendedBackgroundIdleMode {
			[Export ("shouldUseExtendedBackgroundIdleMode")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldUseExtendedBackgroundIdleModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldUseExtendedBackgroundIdleModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldUseExtendedBackgroundIdleMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldUseExtendedBackgroundIdleMode_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldUseExtendedBackgroundIdleMode_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_StrongConnectionProxyDictionary_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual ProxyConfigurationDictionary StrongConnectionProxyDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return new ProxyConfigurationDictionary (ConnectionProxyDictionary!);
			}
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				ConnectionProxyDictionary = value.GetDictionary ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Security.SslProtocol TLSMaximumSupportedProtocol {
			[Export ("TLSMaximumSupportedProtocol")]
			get {
				global::Security.SslProtocol ret;
				if (IsDirectBinding) {
					ret = (global::Security.SslProtocol) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTLSMaximumSupportedProtocolXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::Security.SslProtocol) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selTLSMaximumSupportedProtocolXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTLSMaximumSupportedProtocol:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetTLSMaximumSupportedProtocol_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetTLSMaximumSupportedProtocol_XHandle, (int)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Security.SslProtocol TLSMinimumSupportedProtocol {
			[Export ("TLSMinimumSupportedProtocol")]
			get {
				global::Security.SslProtocol ret;
				if (IsDirectBinding) {
					ret = (global::Security.SslProtocol) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTLSMinimumSupportedProtocolXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::Security.SslProtocol) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selTLSMinimumSupportedProtocolXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTLSMinimumSupportedProtocol:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetTLSMinimumSupportedProtocol_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetTLSMinimumSupportedProtocol_XHandle, (int)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeoutIntervalForRequest {
			[Export ("timeoutIntervalForRequest")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeoutIntervalForRequestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeoutIntervalForRequestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeoutIntervalForRequest:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTimeoutIntervalForRequest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTimeoutIntervalForRequest_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeoutIntervalForResource {
			[Export ("timeoutIntervalForResource")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeoutIntervalForResourceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeoutIntervalForResourceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeoutIntervalForResource:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTimeoutIntervalForResource_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTimeoutIntervalForResource_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Security.TlsProtocolVersion TlsMaximumSupportedProtocolVersion {
			[Export ("TLSMaximumSupportedProtocolVersion", ArgumentSemantic.Assign)]
			get {
				global::Security.TlsProtocolVersion ret;
				if (IsDirectBinding) {
					ret = (global::Security.TlsProtocolVersion) global::ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selTLSMaximumSupportedProtocolVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::Security.TlsProtocolVersion) global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (&__objc_super__, selTLSMaximumSupportedProtocolVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTLSMaximumSupportedProtocolVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt16 (this.Handle, selSetTLSMaximumSupportedProtocolVersion_XHandle, (UInt16)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt16 (&__objc_super__, selSetTLSMaximumSupportedProtocolVersion_XHandle, (UInt16)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Security.TlsProtocolVersion TlsMinimumSupportedProtocolVersion {
			[Export ("TLSMinimumSupportedProtocolVersion", ArgumentSemantic.Assign)]
			get {
				global::Security.TlsProtocolVersion ret;
				if (IsDirectBinding) {
					ret = (global::Security.TlsProtocolVersion) global::ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selTLSMinimumSupportedProtocolVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::Security.TlsProtocolVersion) global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (&__objc_super__, selTLSMinimumSupportedProtocolVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTLSMinimumSupportedProtocolVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt16 (this.Handle, selSetTLSMinimumSupportedProtocolVersion_XHandle, (UInt16)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt16 (&__objc_super__, selSetTLSMinimumSupportedProtocolVersion_XHandle, (UInt16)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlCache? URLCache {
			[Export ("URLCache", ArgumentSemantic.Retain)]
			get {
				NSUrlCache? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlCache> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLCacheXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrlCache> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLCacheXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setURLCache:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetURLCache_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetURLCache_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlCredentialStorage? URLCredentialStorage {
			[Export ("URLCredentialStorage", ArgumentSemantic.Retain)]
			get {
				NSUrlCredentialStorage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlCredentialStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLCredentialStorageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrlCredentialStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLCredentialStorageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setURLCredentialStorage:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetURLCredentialStorage_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetURLCredentialStorage_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public virtual bool UsesClassicLoadingMode {
			[Export ("usesClassicLoadingMode")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesClassicLoadingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesClassicLoadingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesClassicLoadingMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesClassicLoadingMode_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesClassicLoadingMode_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool WaitsForConnectivity {
			[Export ("waitsForConnectivity")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWaitsForConnectivityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWaitsForConnectivityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWaitsForConnectivity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetWaitsForConnectivity_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetWaitsForConnectivity_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray? WeakProtocolClasses {
			[Export ("protocolClasses", ArgumentSemantic.Copy)]
			get {
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProtocolClassesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProtocolClassesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setProtocolClasses:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProtocolClasses_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProtocolClasses_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlSessionConfiguration _DefaultSessionConfiguration {
			[Export ("defaultSessionConfiguration", ArgumentSemantic.Retain)]
			get {
				NSUrlSessionConfiguration? ret;
				ret =  Runtime.GetNSObject<NSUrlSessionConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultSessionConfigurationXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlSessionConfiguration _EphemeralSessionConfiguration {
			[Export ("ephemeralSessionConfiguration", ArgumentSemantic.Retain)]
			get {
				NSUrlSessionConfiguration? ret;
				ret =  Runtime.GetNSObject<NSUrlSessionConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selEphemeralSessionConfigurationXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _ProxyConfigurations {
			[Export ("proxyConfigurations", ArgumentSemantic.Copy)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selProxyConfigurationsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selProxyConfigurationsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setProxyConfigurations:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetProxyConfigurations_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetProxyConfigurations_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_StrongConnectionProxyDictionary_var = null;
			}
		}
	} /* class NSUrlSessionConfiguration */
}
