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
	[Register("NENetworkRule", true)]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NENetworkRule : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDestinationHost_Protocol_X = "initWithDestinationHost:protocol:";
		static readonly NativeHandle selInitWithDestinationHost_Protocol_XHandle = Selector.GetHandle ("initWithDestinationHost:protocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDestinationHostEndpoint_Protocol_X = "initWithDestinationHostEndpoint:protocol:";
		static readonly NativeHandle selInitWithDestinationHostEndpoint_Protocol_XHandle = Selector.GetHandle ("initWithDestinationHostEndpoint:protocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDestinationNetwork_Prefix_Protocol_X = "initWithDestinationNetwork:prefix:protocol:";
		static readonly NativeHandle selInitWithDestinationNetwork_Prefix_Protocol_XHandle = Selector.GetHandle ("initWithDestinationNetwork:prefix:protocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDestinationNetworkEndpoint_Prefix_Protocol_X = "initWithDestinationNetworkEndpoint:prefix:protocol:";
		static readonly NativeHandle selInitWithDestinationNetworkEndpoint_Prefix_Protocol_XHandle = Selector.GetHandle ("initWithDestinationNetworkEndpoint:prefix:protocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_X = "initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:";
		static readonly NativeHandle selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_XHandle = Selector.GetHandle ("initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRemoteNetworkEndpoint_RemotePrefix_LocalNetworkEndpoint_LocalPrefix_Protocol_Direction_X = "initWithRemoteNetworkEndpoint:remotePrefix:localNetworkEndpoint:localPrefix:protocol:direction:";
		static readonly NativeHandle selInitWithRemoteNetworkEndpoint_RemotePrefix_LocalNetworkEndpoint_LocalPrefix_Protocol_Direction_XHandle = Selector.GetHandle ("initWithRemoteNetworkEndpoint:remotePrefix:localNetworkEndpoint:localPrefix:protocol:direction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchDirectionX = "matchDirection";
		static readonly NativeHandle selMatchDirectionXHandle = Selector.GetHandle ("matchDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchLocalNetworkX = "matchLocalNetwork";
		static readonly NativeHandle selMatchLocalNetworkXHandle = Selector.GetHandle ("matchLocalNetwork");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchLocalNetworkEndpointX = "matchLocalNetworkEndpoint";
		static readonly NativeHandle selMatchLocalNetworkEndpointXHandle = Selector.GetHandle ("matchLocalNetworkEndpoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchLocalPrefixX = "matchLocalPrefix";
		static readonly NativeHandle selMatchLocalPrefixXHandle = Selector.GetHandle ("matchLocalPrefix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchProtocolX = "matchProtocol";
		static readonly NativeHandle selMatchProtocolXHandle = Selector.GetHandle ("matchProtocol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchRemoteEndpointX = "matchRemoteEndpoint";
		static readonly NativeHandle selMatchRemoteEndpointXHandle = Selector.GetHandle ("matchRemoteEndpoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchRemoteHostOrNetworkEndpointX = "matchRemoteHostOrNetworkEndpoint";
		static readonly NativeHandle selMatchRemoteHostOrNetworkEndpointXHandle = Selector.GetHandle ("matchRemoteHostOrNetworkEndpoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchRemotePrefixX = "matchRemotePrefix";
		static readonly NativeHandle selMatchRemotePrefixXHandle = Selector.GetHandle ("matchRemotePrefix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NENetworkRule");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NENetworkRule (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NENetworkRule (NSObjectFlag t) : base (t)
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
		protected internal NENetworkRule (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDestinationNetwork:prefix:protocol:")]
		[ObsoletedOSPlatform ("macos15.0", "Call the constructor overload that takes an 'NENetworkRuleConstructorOption' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NENetworkRule (NWHostEndpoint networkEndpoint, nuint destinationPrefix, NENetworkRuleProtocol protocol)
			: base (NSObjectFlag.Empty)
		{
			var networkEndpoint__handle__ = networkEndpoint!.GetNonNullHandle (nameof (networkEndpoint));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selInitWithDestinationNetwork_Prefix_Protocol_XHandle, networkEndpoint__handle__, destinationPrefix, (IntPtr) (long) protocol), "initWithDestinationNetwork:prefix:protocol:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selInitWithDestinationNetwork_Prefix_Protocol_XHandle, networkEndpoint__handle__, destinationPrefix, (IntPtr) (long) protocol), "initWithDestinationNetwork:prefix:protocol:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (networkEndpoint);
		}
		[Export ("initWithDestinationHost:protocol:")]
		[ObsoletedOSPlatform ("macos15.0", "Call the constructor overload that takes an 'NENetworkRuleConstructorOption' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NENetworkRule (NWHostEndpoint hostEndpoint, NENetworkRuleProtocol protocol)
			: base (NSObjectFlag.Empty)
		{
			var hostEndpoint__handle__ = hostEndpoint!.GetNonNullHandle (nameof (hostEndpoint));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInitWithDestinationHost_Protocol_XHandle, hostEndpoint__handle__, (IntPtr) (long) protocol), "initWithDestinationHost:protocol:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInitWithDestinationHost_Protocol_XHandle, hostEndpoint__handle__, (IntPtr) (long) protocol), "initWithDestinationHost:protocol:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (hostEndpoint);
		}
		[Export ("initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:")]
		[ObsoletedOSPlatform ("macos15.0", "Call the constructor overload that takes an 'NENetworkRuleConstructorOption' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NENetworkRule (NWHostEndpoint? remoteNetwork, nuint remotePrefix, NWHostEndpoint? localNetwork, nuint localPrefix, NENetworkRuleProtocol protocol, NETrafficDirection direction)
			: base (NSObjectFlag.Empty)
		{
			var remoteNetwork__handle__ = remoteNetwork.GetHandle ();
			var localNetwork__handle__ = localNetwork.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_IntPtr_IntPtr (this.Handle, selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_XHandle, remoteNetwork__handle__, remotePrefix, localNetwork__handle__, localPrefix, (IntPtr) (long) protocol, (IntPtr) (long) direction), "initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_UIntPtr_IntPtr_IntPtr (&__objc_super__, selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_XHandle, remoteNetwork__handle__, remotePrefix, localNetwork__handle__, localPrefix, (IntPtr) (long) protocol, (IntPtr) (long) direction), "initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (remoteNetwork);
			GC.KeepAlive (localNetwork);
		}
		[Export ("initWithDestinationNetworkEndpoint:prefix:protocol:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NENetworkRule (global::Network.NWEndpoint networkEndpoint, nuint destinationPrefix, NENetworkRuleProtocol protocol)
			: base (NSObjectFlag.Empty)
		{
			var networkEndpoint__handle__ = networkEndpoint!.GetNonNullHandle (nameof (networkEndpoint));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selInitWithDestinationNetworkEndpoint_Prefix_Protocol_XHandle, networkEndpoint.Handle, destinationPrefix, (IntPtr) (long) protocol), "initWithDestinationNetworkEndpoint:prefix:protocol:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selInitWithDestinationNetworkEndpoint_Prefix_Protocol_XHandle, networkEndpoint.Handle, destinationPrefix, (IntPtr) (long) protocol), "initWithDestinationNetworkEndpoint:prefix:protocol:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (networkEndpoint);
		}
		[Export ("initWithDestinationHostEndpoint:protocol:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NENetworkRule (global::Network.NWEndpoint hostEndpoint, NENetworkRuleProtocol protocol)
			: base (NSObjectFlag.Empty)
		{
			var hostEndpoint__handle__ = hostEndpoint!.GetNonNullHandle (nameof (hostEndpoint));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInitWithDestinationHostEndpoint_Protocol_XHandle, hostEndpoint.Handle, (IntPtr) (long) protocol), "initWithDestinationHostEndpoint:protocol:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInitWithDestinationHostEndpoint_Protocol_XHandle, hostEndpoint.Handle, (IntPtr) (long) protocol), "initWithDestinationHostEndpoint:protocol:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (hostEndpoint);
		}
		[Export ("initWithRemoteNetworkEndpoint:remotePrefix:localNetworkEndpoint:localPrefix:protocol:direction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NENetworkRule (global::Network.NWEndpoint? remoteNetwork, nuint remotePrefix, global::Network.NWEndpoint? localNetwork, nuint localPrefix, NENetworkRuleProtocol protocol, NETrafficDirection direction)
			: base (NSObjectFlag.Empty)
		{
			var remoteNetwork__handle__ = remoteNetwork.GetHandle ();
			var localNetwork__handle__ = localNetwork.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_IntPtr_IntPtr (this.Handle, selInitWithRemoteNetworkEndpoint_RemotePrefix_LocalNetworkEndpoint_LocalPrefix_Protocol_Direction_XHandle, remoteNetwork__handle__, remotePrefix, localNetwork__handle__, localPrefix, (IntPtr) (long) protocol, (IntPtr) (long) direction), "initWithRemoteNetworkEndpoint:remotePrefix:localNetworkEndpoint:localPrefix:protocol:direction:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_UIntPtr_IntPtr_IntPtr (&__objc_super__, selInitWithRemoteNetworkEndpoint_RemotePrefix_LocalNetworkEndpoint_LocalPrefix_Protocol_Direction_XHandle, remoteNetwork__handle__, remotePrefix, localNetwork__handle__, localPrefix, (IntPtr) (long) protocol, (IntPtr) (long) direction), "initWithRemoteNetworkEndpoint:remotePrefix:localNetworkEndpoint:localPrefix:protocol:direction:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (remoteNetwork);
			GC.KeepAlive (localNetwork);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NETrafficDirection MatchDirection {
			[Export ("matchDirection")]
			get {
				NETrafficDirection ret;
				if (IsDirectBinding) {
					ret = (NETrafficDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMatchDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NETrafficDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMatchDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0", "Use 'MatchLocalNetworkEndpoint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NWHostEndpoint? MatchLocalNetwork {
			[Export ("matchLocalNetwork")]
			get {
				NWHostEndpoint? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NWHostEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchLocalNetworkXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NWHostEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchLocalNetworkXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual global::Network.NWEndpoint? MatchLocalNetworkEndpoint {
			[Export ("matchLocalNetworkEndpoint")]
			get {
				global::Network.NWEndpoint ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::Network.NWEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchLocalNetworkEndpointXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Network.NWEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchLocalNetworkEndpointXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MatchLocalPrefix {
			[Export ("matchLocalPrefix")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMatchLocalPrefixXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMatchLocalPrefixXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NENetworkRuleProtocol MatchProtocol {
			[Export ("matchProtocol")]
			get {
				NENetworkRuleProtocol ret;
				if (IsDirectBinding) {
					ret = (NENetworkRuleProtocol) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMatchProtocolXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NENetworkRuleProtocol) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMatchProtocolXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0", "Use 'MatchRemoteHostOrNetworkEndpoint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NWHostEndpoint? MatchRemoteEndpoint {
			[Export ("matchRemoteEndpoint")]
			get {
				NWHostEndpoint? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NWHostEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchRemoteEndpointXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NWHostEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchRemoteEndpointXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual global::Network.NWEndpoint? MatchRemoteHostOrNetworkEndpoint {
			[Export ("matchRemoteHostOrNetworkEndpoint")]
			get {
				global::Network.NWEndpoint ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::Network.NWEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchRemoteHostOrNetworkEndpointXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Network.NWEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchRemoteHostOrNetworkEndpointXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MatchRemotePrefix {
			[Export ("matchRemotePrefix")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMatchRemotePrefixXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMatchRemotePrefixXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NENetworkRule */
}
