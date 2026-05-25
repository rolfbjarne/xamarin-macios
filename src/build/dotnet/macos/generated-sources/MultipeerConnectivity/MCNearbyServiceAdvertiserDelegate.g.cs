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
	/// <summary>A delegate object that exposes events relating to advertising and invitations for multipeer connectivity for a <see cref="T:MultipeerConnectivity.MCNearbyServiceAdvertiser" /> object.</summary><remarks><para>For a discussion of the discovery process, see the remarks for <see cref="T:MultipeerConnectivity.MCSession" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceAdvertiserDelegateProtocolRef/index.html">Apple documentation for <c>MCNearbyServiceAdvertiserDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MCNearbyServiceAdvertiserDelegate", WrapperType = typeof (MCNearbyServiceAdvertiserDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveInvitationFromPeer", Selector = "advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCNearbyServiceAdvertiser), typeof (MultipeerConnectivity.MCPeerID), typeof (NSData), typeof (MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidNotStartAdvertisingPeer", Selector = "advertiser:didNotStartAdvertisingPeer:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCNearbyServiceAdvertiser), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMCNearbyServiceAdvertiserDelegate : INativeObject, IDisposable
	{
		/// <param name="advertiser">To be added.</param><param name="peerID">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="invitationHandler">Continuation that the app developer must call.</param><summary>Indicates an invitation has been received to join a session.</summary><remarks><para>When overriding this method, application developers must invoke the <paramref name="invitationHandler" />, passing in an appropriate <see cref="T:MultipeerConnectivity.MCSession" /> and a boolean indicating whether the invitation should be accepted or not.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// public override void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData context, MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		/// {
		/// 	parent.statusLbl.Text = "Received Invite";
		/// invitationHandler(true, parent.Session);
		/// }              
		/// ]]></code></example></remarks>
		[global::Foundation.RequiredMember]
		[Export ("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveInvitationFromPeer (MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))]MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="advertiser">To be added.</param><param name="peerID">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="invitationHandler">Continuation that the app developer must call.</param><summary>Indicates an invitation has been received to join a session.</summary><remarks><para>When overriding this method, application developers must invoke the <paramref name="invitationHandler" />, passing in an appropriate <see cref="T:MultipeerConnectivity.MCSession" /> and a boolean indicating whether the invitation should be accepted or not.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// public override void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData context, MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		/// {
		/// 	parent.statusLbl.Text = "Received Invite";
		/// invitationHandler(true, parent.Session);
		/// }              
		/// ]]></code></example></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveInvitationFromPeer (IMCNearbyServiceAdvertiserDelegate This, MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))]MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		{
			var advertiser__handle__ = advertiser!.GetNonNullHandle (nameof (advertiser));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var context__handle__ = context.GetHandle ();
			if (invitationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (invitationHandler));
			using var block_invitationHandler = Trampolines.SDMCNearbyServiceAdvertiserInvitationHandler.CreateBlock (invitationHandler);
			BlockLiteral *block_ptr_invitationHandler = &block_invitationHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:"), advertiser__handle__, peerID__handle__, context__handle__, (IntPtr) block_ptr_invitationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (advertiser);
			GC.KeepAlive (peerID);
			GC.KeepAlive (context);
		}
		/// <param name="advertiser">To be added.</param><param name="error">To be added.</param><summary>Indicates that advertising peer availability failed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("advertiser:didNotStartAdvertisingPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidNotStartAdvertisingPeer (MCNearbyServiceAdvertiser advertiser, NSError error)
		{
			_DidNotStartAdvertisingPeer (this, advertiser, error);
		}
		/// <param name="advertiser">To be added.</param><param name="error">To be added.</param><summary>Indicates that advertising peer availability failed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidNotStartAdvertisingPeer (IMCNearbyServiceAdvertiserDelegate This, MCNearbyServiceAdvertiser advertiser, NSError error)
		{
			var advertiser__handle__ = advertiser!.GetNonNullHandle (nameof (advertiser));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("advertiser:didNotStartAdvertisingPeer:"), advertiser__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (advertiser);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidNotStartAdvertisingPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,MultipeerConnectivity.MCPeerID,Foundation.NSData,MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCNearbyServiceAdvertiserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMCNearbyServiceAdvertiserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMCNearbyServiceAdvertiserDelegate" /> interface to support all the methods from the MCNearbyServiceAdvertiserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMCNearbyServiceAdvertiserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MCNearbyServiceAdvertiserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MCNearbyServiceAdvertiserDelegate_Extensions {
		/// <param name="advertiser">To be added.</param><param name="error">To be added.</param><summary>Indicates that advertising peer availability failed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidNotStartAdvertisingPeer (this IMCNearbyServiceAdvertiserDelegate This, MCNearbyServiceAdvertiser advertiser, NSError error)
		{
			var advertiser__handle__ = advertiser!.GetNonNullHandle (nameof (advertiser));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("advertiser:didNotStartAdvertisingPeer:"), advertiser__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (advertiser);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MCNearbyServiceAdvertiserDelegateWrapper : BaseWrapper, IMCNearbyServiceAdvertiserDelegate {
		public MCNearbyServiceAdvertiserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCNearbyServiceAdvertiserDelegateWrapper))]
		static MCNearbyServiceAdvertiserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="advertiser">To be added.</param><param name="peerID">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="invitationHandler">Continuation that the app developer must call.</param><summary>Indicates an invitation has been received to join a session.</summary><remarks><para>When overriding this method, application developers must invoke the <paramref name="invitationHandler" />, passing in an appropriate <see cref="T:MultipeerConnectivity.MCSession" /> and a boolean indicating whether the invitation should be accepted or not.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// public override void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData context, MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		/// {
		/// 	parent.statusLbl.Text = "Received Invite";
		/// invitationHandler(true, parent.Session);
		/// }              
		/// ]]></code></example></remarks>
		[Export ("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidReceiveInvitationFromPeer (MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))]MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		{
			var advertiser__handle__ = advertiser!.GetNonNullHandle (nameof (advertiser));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var context__handle__ = context.GetHandle ();
			if (invitationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (invitationHandler));
			using var block_invitationHandler = Trampolines.SDMCNearbyServiceAdvertiserInvitationHandler.CreateBlock (invitationHandler);
			BlockLiteral *block_ptr_invitationHandler = &block_invitationHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:"), advertiser__handle__, peerID__handle__, context__handle__, (IntPtr) block_ptr_invitationHandler);
			GC.KeepAlive (advertiser);
			GC.KeepAlive (peerID);
			GC.KeepAlive (context);
		}
	}
}
namespace MultipeerConnectivity {
	/// <summary>A delegate object that exposes events relating to advertising and invitations for multipeer connectivity for a <see cref="T:MultipeerConnectivity.MCNearbyServiceAdvertiser" /> object.</summary><remarks><para>For a discussion of the discovery process, see the remarks for <see cref="T:MultipeerConnectivity.MCSession" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceAdvertiserDelegateProtocolRef/index.html">Apple documentation for <c>MCNearbyServiceAdvertiserDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__MultipeerConnectivity_MCNearbyServiceAdvertiserDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MCNearbyServiceAdvertiserDelegate : NSObject, IMCNearbyServiceAdvertiserDelegate {
		/// <summary>Creates a new <see cref="MCNearbyServiceAdvertiserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MCNearbyServiceAdvertiserDelegate () : base (NSObjectFlag.Empty)
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
		protected MCNearbyServiceAdvertiserDelegate (NSObjectFlag t) : base (t)
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
		protected internal MCNearbyServiceAdvertiserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="advertiser">To be added.</param><param name="error">To be added.</param><summary>Indicates that advertising peer availability failed.</summary><remarks>To be added.</remarks>
		[Export ("advertiser:didNotStartAdvertisingPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidNotStartAdvertisingPeer (MCNearbyServiceAdvertiser advertiser, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="advertiser">To be added.</param><param name="peerID">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="invitationHandler">Continuation that the app developer must call.</param><summary>Indicates an invitation has been received to join a session.</summary><remarks><para>When overriding this method, application developers must invoke the <paramref name="invitationHandler" />, passing in an appropriate <see cref="T:MultipeerConnectivity.MCSession" /> and a boolean indicating whether the invitation should be accepted or not.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// public override void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData context, MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		/// {
		/// 	parent.statusLbl.Text = "Received Invite";
		/// invitationHandler(true, parent.Session);
		/// }              
		/// ]]></code></example></remarks>
		[Export ("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveInvitationFromPeer (MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))]MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MCNearbyServiceAdvertiserDelegate */
}
