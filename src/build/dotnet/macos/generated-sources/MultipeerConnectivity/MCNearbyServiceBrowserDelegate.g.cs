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
namespace MultipeerConnectivity {
	#pragma warning disable CS1573
	/// <summary>A delegate object that exposes peer-discovery events for a <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowser" /> object.</summary><remarks><para>For a discussion of peer discovery and connection, see <see cref="T:MultipeerConnectivity.MCSession" /> remarks.</para><para>Methods of <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowserDelegate" /> are typically called by the system on a background thread. Application developers who wish to modify the user interface must use, for instance, <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceBrowserDelegateRef/index.html">Apple documentation for <c>MCNearbyServiceBrowserDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MCNearbyServiceBrowserDelegate", WrapperType = typeof (MCNearbyServiceBrowserDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FoundPeer", Selector = "browser:foundPeer:withDiscoveryInfo:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCNearbyServiceBrowser), typeof (MultipeerConnectivity.MCPeerID), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LostPeer", Selector = "browser:lostPeer:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCNearbyServiceBrowser), typeof (MultipeerConnectivity.MCPeerID) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidNotStartBrowsingForPeers", Selector = "browser:didNotStartBrowsingForPeers:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCNearbyServiceBrowser), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMCNearbyServiceBrowserDelegate : INativeObject, IDisposable
	{
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that a peer has been found.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("browser:foundPeer:withDiscoveryInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundPeer (MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that a peer has been found.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FoundPeer (IMCNearbyServiceBrowserDelegate This, MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:foundPeer:withDiscoveryInfo:"), browser__handle__, peerID__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (peerID);
			GC.KeepAlive (info);
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><summary>Indicates that a peer has been lost.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("browser:lostPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LostPeer (MCNearbyServiceBrowser browser, MCPeerID peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><summary>Indicates that a peer has been lost.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LostPeer (IMCNearbyServiceBrowserDelegate This, MCNearbyServiceBrowser browser, MCPeerID peerID)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:lostPeer:"), browser__handle__, peerID__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (peerID);
		}
		/// <param name="browser">To be added.</param><param name="error">To be added.</param><summary>Indicates that browsing for peers failed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:didNotStartBrowsingForPeers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidNotStartBrowsingForPeers (MCNearbyServiceBrowser browser, NSError error)
		{
			_DidNotStartBrowsingForPeers (this, browser, error);
		}
		/// <param name="browser">To be added.</param><param name="error">To be added.</param><summary>Indicates that browsing for peers failed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidNotStartBrowsingForPeers (IMCNearbyServiceBrowserDelegate This, MCNearbyServiceBrowser browser, NSError error)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:didNotStartBrowsingForPeers:"), browser__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidNotStartBrowsingForPeers(MultipeerConnectivity.MCNearbyServiceBrowser,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FoundPeer(MultipeerConnectivity.MCNearbyServiceBrowser,MultipeerConnectivity.MCPeerID,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("LostPeer(MultipeerConnectivity.MCNearbyServiceBrowser,MultipeerConnectivity.MCPeerID)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCNearbyServiceBrowserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMCNearbyServiceBrowserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMCNearbyServiceBrowserDelegate" /> interface to support all the methods from the MCNearbyServiceBrowserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMCNearbyServiceBrowserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MCNearbyServiceBrowserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MCNearbyServiceBrowserDelegate_Extensions {
		/// <param name="browser">To be added.</param><param name="error">To be added.</param><summary>Indicates that browsing for peers failed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidNotStartBrowsingForPeers (this IMCNearbyServiceBrowserDelegate This, MCNearbyServiceBrowser browser, NSError error)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:didNotStartBrowsingForPeers:"), browser__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MCNearbyServiceBrowserDelegateWrapper : BaseWrapper, IMCNearbyServiceBrowserDelegate {
		public MCNearbyServiceBrowserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCNearbyServiceBrowserDelegateWrapper))]
		static MCNearbyServiceBrowserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that a peer has been found.</summary><remarks>To be added.</remarks>
		[Export ("browser:foundPeer:withDiscoveryInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FoundPeer (MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("browser:foundPeer:withDiscoveryInfo:"), browser__handle__, peerID__handle__, info__handle__);
			GC.KeepAlive (browser);
			GC.KeepAlive (peerID);
			GC.KeepAlive (info);
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><summary>Indicates that a peer has been lost.</summary><remarks>To be added.</remarks>
		[Export ("browser:lostPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void LostPeer (MCNearbyServiceBrowser browser, MCPeerID peerID)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("browser:lostPeer:"), browser__handle__, peerID__handle__);
			GC.KeepAlive (browser);
			GC.KeepAlive (peerID);
		}
	}
}
namespace MultipeerConnectivity {
	/// <summary>A delegate object that exposes peer-discovery events for a <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowser" /> object.</summary><remarks><para>For a discussion of peer discovery and connection, see <see cref="T:MultipeerConnectivity.MCSession" /> remarks.</para><para>Methods of <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowserDelegate" /> are typically called by the system on a background thread. Application developers who wish to modify the user interface must use, for instance, <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceBrowserDelegateRef/index.html">Apple documentation for <c>MCNearbyServiceBrowserDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__MultipeerConnectivity_MCNearbyServiceBrowserDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MCNearbyServiceBrowserDelegate : NSObject, IMCNearbyServiceBrowserDelegate {
		/// <summary>Creates a new <see cref="MCNearbyServiceBrowserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MCNearbyServiceBrowserDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
			}
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
		protected MCNearbyServiceBrowserDelegate (NSObjectFlag t) : base (t)
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
		protected internal MCNearbyServiceBrowserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="browser">To be added.</param><param name="error">To be added.</param><summary>Indicates that browsing for peers failed.</summary><remarks>To be added.</remarks>
		[Export ("browser:didNotStartBrowsingForPeers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidNotStartBrowsingForPeers (MCNearbyServiceBrowser browser, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that a peer has been found.</summary><remarks>To be added.</remarks>
		[Export ("browser:foundPeer:withDiscoveryInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundPeer (MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="peerID">To be added.</param><summary>Indicates that a peer has been lost.</summary><remarks>To be added.</remarks>
		[Export ("browser:lostPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LostPeer (MCNearbyServiceBrowser browser, MCPeerID peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MCNearbyServiceBrowserDelegate */
}
