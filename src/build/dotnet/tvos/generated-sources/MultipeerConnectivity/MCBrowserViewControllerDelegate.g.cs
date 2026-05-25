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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MultipeerConnectivity {
	#pragma warning disable CS1573
	/// <summary>A delegate object that provides events relating to the presentation of discovered peers and the application user's selection or cancellation of them.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCBrowserViewControllerDelegate/index.html">Apple documentation for <c>MCBrowserViewControllerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MCBrowserViewControllerDelegate", WrapperType = typeof (MCBrowserViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "browserViewControllerWasCancelled:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCBrowserViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "browserViewControllerDidFinish:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCBrowserViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentNearbyPeer", Selector = "browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MultipeerConnectivity.MCBrowserViewController), typeof (MultipeerConnectivity.MCPeerID), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IMCBrowserViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <paramref name="browserViewController" /> was dismissed when the user cancelled the presentation.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("browserViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (MCBrowserViewController browserViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <paramref name="browserViewController" /> was dismissed when the user cancelled the presentation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasCancelled (IMCBrowserViewControllerDelegate This, MCBrowserViewController browserViewController)
		{
			var browserViewController__handle__ = browserViewController!.GetNonNullHandle (nameof (browserViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserViewControllerWasCancelled:"), browserViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browserViewController);
		}
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <see cref="T:MultipeerConnectivity.MCBrowserViewController" /> was dismissed with peers connected.
		/// </summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("browserViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (MCBrowserViewController browserViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <see cref="T:MultipeerConnectivity.MCBrowserViewController" /> was dismissed with peers connected.
		/// </summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IMCBrowserViewControllerDelegate This, MCBrowserViewController browserViewController)
		{
			var browserViewController__handle__ = browserViewController!.GetNonNullHandle (nameof (browserViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserViewControllerDidFinish:"), browserViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browserViewController);
		}
		/// <param name="browserViewController">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates a new peer has been discovered. Can be used to avoid showing the invitation UI.</summary><returns><see langword="true" /> if the <paramref name="browserViewController" /> should be displayed to the app user.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentNearbyPeer (MCBrowserViewController browserViewController, MCPeerID peerID, NSDictionary? info)
		{
			return _ShouldPresentNearbyPeer (this, browserViewController, peerID, info);
		}
		/// <param name="browserViewController">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates a new peer has been discovered. Can be used to avoid showing the invitation UI.</summary><returns><see langword="true" /> if the <paramref name="browserViewController" /> should be displayed to the app user.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPresentNearbyPeer (IMCBrowserViewControllerDelegate This, MCBrowserViewController browserViewController, MCPeerID peerID, NSDictionary? info)
		{
			var browserViewController__handle__ = browserViewController!.GetNonNullHandle (nameof (browserViewController));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var info__handle__ = info.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:"), browserViewController__handle__, peerID__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browserViewController);
			GC.KeepAlive (peerID);
			GC.KeepAlive (info);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidFinish(MultipeerConnectivity.MCBrowserViewController)")]
		[DynamicDependencyAttribute ("ShouldPresentNearbyPeer(MultipeerConnectivity.MCBrowserViewController,MultipeerConnectivity.MCPeerID,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("WasCancelled(MultipeerConnectivity.MCBrowserViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCBrowserViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMCBrowserViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMCBrowserViewControllerDelegate" /> interface to support all the methods from the MCBrowserViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMCBrowserViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MCBrowserViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MCBrowserViewControllerDelegate_Extensions {
		/// <param name="browserViewController">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates a new peer has been discovered. Can be used to avoid showing the invitation UI.</summary><returns><see langword="true" /> if the <paramref name="browserViewController" /> should be displayed to the app user.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPresentNearbyPeer (this IMCBrowserViewControllerDelegate This, MCBrowserViewController browserViewController, MCPeerID peerID, NSDictionary? info)
		{
			var browserViewController__handle__ = browserViewController!.GetNonNullHandle (nameof (browserViewController));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var info__handle__ = info.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:"), browserViewController__handle__, peerID__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browserViewController);
			GC.KeepAlive (peerID);
			GC.KeepAlive (info);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MCBrowserViewControllerDelegateWrapper : BaseWrapper, IMCBrowserViewControllerDelegate {
		public MCBrowserViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCBrowserViewControllerDelegateWrapper))]
		static MCBrowserViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <paramref name="browserViewController" /> was dismissed when the user cancelled the presentation.</summary><remarks>To be added.</remarks>
		[Export ("browserViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WasCancelled (MCBrowserViewController browserViewController)
		{
			var browserViewController__handle__ = browserViewController!.GetNonNullHandle (nameof (browserViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("browserViewControllerWasCancelled:"), browserViewController__handle__);
			GC.KeepAlive (browserViewController);
		}
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <see cref="T:MultipeerConnectivity.MCBrowserViewController" /> was dismissed with peers connected.
		/// </summary><remarks>To be added.</remarks>
		[Export ("browserViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinish (MCBrowserViewController browserViewController)
		{
			var browserViewController__handle__ = browserViewController!.GetNonNullHandle (nameof (browserViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("browserViewControllerDidFinish:"), browserViewController__handle__);
			GC.KeepAlive (browserViewController);
		}
	}
}
namespace MultipeerConnectivity {
	/// <summary>A delegate object that provides events relating to the presentation of discovered peers and the application user's selection or cancellation of them.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCBrowserViewControllerDelegate/index.html">Apple documentation for <c>MCBrowserViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__MultipeerConnectivity_MCBrowserViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MCBrowserViewControllerDelegate : NSObject, IMCBrowserViewControllerDelegate {
		/// <summary>Creates a new <see cref="MCBrowserViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MCBrowserViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected MCBrowserViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal MCBrowserViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <see cref="T:MultipeerConnectivity.MCBrowserViewController" /> was dismissed with peers connected.
		/// </summary><remarks>To be added.</remarks>
		[Export ("browserViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (MCBrowserViewController browserViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browserViewController">To be added.</param><param name="peerID">To be added.</param><param name="info"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates a new peer has been discovered. Can be used to avoid showing the invitation UI.</summary><returns><see langword="true" /> if the <paramref name="browserViewController" /> should be displayed to the app user.</returns><remarks>To be added.</remarks>
		[Export ("browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentNearbyPeer (MCBrowserViewController browserViewController, MCPeerID peerID, NSDictionary? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browserViewController">To be added.</param><summary>Indicates that the <paramref name="browserViewController" /> was dismissed when the user cancelled the presentation.</summary><remarks>To be added.</remarks>
		[Export ("browserViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (MCBrowserViewController browserViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MCBrowserViewControllerDelegate */
}
