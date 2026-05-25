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
	/// <summary>Represents a persistent connection between multiple devices.</summary><remarks><para>Multipeer Connectivity has two phases: discovery and the session. The role of the discovery phase is to associate an <see cref="T:MultipeerConnectivity.MCSession" /> object on each device with an <see cref="T:MultipeerConnectivity.MCSession" /> object on the peer devices. In the session phase, the <see cref="T:MultipeerConnectivity.MCSession" /> object is the channel through which devices communicate and its lifecycle events are associated with connections, disconnections, transmissions, and receptions.</para><para>The <see cref="T:MultipeerConnectivity.MCSession" /> is instantiated by the application developer. During the discovery phase, there are two roles: advertisers that broadcast their willingness to connect to a certain protocol and browsers that discover these advertisers and invite them to sessions. </para><para> Advertising is managed by either the stock <see cref="T:MultipeerConnectivity.MCAdvertiserAssistant" /> or custom controller that uses a <see cref="T:MultipeerConnectivity.MCNearbyServiceAdvertiser" />. Similarly, browsing is managed by a  <see cref="T:AppKit.NSViewController" />, either the stock <see cref="T:MultipeerConnectivity.MCBrowserViewController" /> or a custom controller that uses a <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowser" /> object to programmatically discover peers. Once a peer is discovered, an invitation is sent with <see cref="M:MultipeerConnectivity.MCNearbyServiceBrowser.InvitePeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSession,Foundation.NSData,System.Double)" />). The application user interacts with a system dialog informing them of the invitation. If they accept, the <see cref="T:MultipeerConnectivity.MCSession" /> connects.</para><para>The following image shows the sequence of functions with programmatic advertising and browsing:</para><para><img href="~/xml/MultipeerConnectivity/_images/MultipeerConnectivity.ProgrammaticAdvertisingAndDiscovery.png" alt="Sequence diagram showing advertising and discovery" /></para><para><list type="table"><listheader><term>Advertiser</term><description>Browser</description><description>Discussion</description></listheader><item><term>Create a new <see cref="T:MultipeerConnectivity.MCNearbyServiceAdvertiserDelegate" /> and assign it to the <see cref="P:MultipeerConnectivity.MCNearbyServiceAdvertiser.Delegate" /> property.</term><description>Create a new <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowserDelegate" /> and assign it to <see cref="P:MultipeerConnectivity.MCNearbyServiceBrowser.Delegate" /> property.</description><description>Discovery and connection is taken care of by the delegate objects for the <see cref="T:MultipeerConnectivity.MCNearbyServiceAdvertiser" /> and <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowser" />.</description></item><item><term>The advertiser may instantiate a new <see cref="T:MultipeerConnectivity.MCSession" /> now or wait until it receives an invitation.</term><description>Instantiate a new <see cref="T:MultipeerConnectivity.MCSession" />.</description><description>The browser should maintain a reference to a single <see cref="T:MultipeerConnectivity.MCSession" /> object no matter how many peers ultimately connect.</description></item><item><term><see cref="M:MultipeerConnectivity.MCNearbyServiceAdvertiser.StartAdvertisingPeer" /></term><description><see cref="M:MultipeerConnectivity.MCNearbyServiceBrowser.StartBrowsingForPeers" /></description><description>Advertiser and browser must use identical <c>serviceType</c> strings to identify their protocol / application. Peer IDs should be unique to each device.</description></item><item><term></term><description>The system will call <see cref="M:MultipeerConnectivity.MCNearbyServiceBrowserDelegate.FoundPeer(MultipeerConnectivity.MCNearbyServiceBrowser,MultipeerConnectivity.MCPeerID,Foundation.NSDictionary)" />, passing in a reference to the <see cref="T:MultipeerConnectivity.MCNearbyServiceBrowser" />. The application developer calls <see cref="M:MultipeerConnectivity.MCNearbyServiceBrowser.InvitePeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSession,Foundation.NSData,System.Double)" />, passing in a reference to the previously-created <see cref="T:MultipeerConnectivity.MCSession" />.</description><description>The callback is likely to occur on a background thread. If the application developer wishes to update the display, they must use <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</description></item><item><term>The system will call <see cref="M:MultipeerConnectivity.MCNearbyServiceAdvertiserDelegate.DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,MultipeerConnectivity.MCPeerID,Foundation.NSData,MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler)" />. To connect the devices, the application developer must invoke the passed-in <c>invitationHandler</c> with it's <c>context</c> argument set to <see langword="true" /> and it's <c>session</c> argument set to an <see cref="T:MultipeerConnectivity.MCSession" />.</term><description></description><description>The callback is likely to occur on a background thread. If the application developer wishes to update the display, they must use <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />. </description></item><item><term></term><description></description><description>Once the devices are connected, the <see cref="T:MultipeerConnectivity.MCSession" /> objects can be used to transmit messages and data between devices.</description></item></list></para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCSessionClassRef/index.html">Apple documentation for <c>MCSession</c></related>
	[Register("MCSession", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MCSession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelConnectPeer_X = "cancelConnectPeer:";
		static readonly NativeHandle selCancelConnectPeer_XHandle = Selector.GetHandle ("cancelConnectPeer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectPeer_WithNearbyConnectionData_X = "connectPeer:withNearbyConnectionData:";
		static readonly NativeHandle selConnectPeer_WithNearbyConnectionData_XHandle = Selector.GetHandle ("connectPeer:withNearbyConnectionData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectedPeersX = "connectedPeers";
		static readonly NativeHandle selConnectedPeersXHandle = Selector.GetHandle ("connectedPeers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectX = "disconnect";
		static readonly NativeHandle selDisconnectXHandle = Selector.GetHandle ("disconnect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncryptionPreferenceX = "encryptionPreference";
		static readonly NativeHandle selEncryptionPreferenceXHandle = Selector.GetHandle ("encryptionPreference");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPeer_X = "initWithPeer:";
		static readonly NativeHandle selInitWithPeer_XHandle = Selector.GetHandle ("initWithPeer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPeer_SecurityIdentity_EncryptionPreference_X = "initWithPeer:securityIdentity:encryptionPreference:";
		static readonly NativeHandle selInitWithPeer_SecurityIdentity_EncryptionPreference_XHandle = Selector.GetHandle ("initWithPeer:securityIdentity:encryptionPreference:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMyPeerIDX = "myPeerID";
		static readonly NativeHandle selMyPeerIDXHandle = Selector.GetHandle ("myPeerID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNearbyConnectionDataForPeer_WithCompletionHandler_X = "nearbyConnectionDataForPeer:withCompletionHandler:";
		static readonly NativeHandle selNearbyConnectionDataForPeer_WithCompletionHandler_XHandle = Selector.GetHandle ("nearbyConnectionDataForPeer:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecurityIdentityX = "securityIdentity";
		static readonly NativeHandle selSecurityIdentityXHandle = Selector.GetHandle ("securityIdentity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendData_ToPeers_WithMode_Error_X = "sendData:toPeers:withMode:error:";
		static readonly NativeHandle selSendData_ToPeers_WithMode_Error_XHandle = Selector.GetHandle ("sendData:toPeers:withMode:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_X = "sendResourceAtURL:withName:toPeer:withCompletionHandler:";
		static readonly NativeHandle selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_XHandle = Selector.GetHandle ("sendResourceAtURL:withName:toPeer:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartStreamWithName_ToPeer_Error_X = "startStreamWithName:toPeer:error:";
		static readonly NativeHandle selStartStreamWithName_ToPeer_Error_XHandle = Selector.GetHandle ("startStreamWithName:toPeer:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MCSession");
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
		protected MCSession (NSObjectFlag t) : base (t)
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
		protected internal MCSession (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="myPeerID">The identity of the local peer.</param><summary>Constructs a session with the specified identity for the local peer.</summary><remarks>To be added.</remarks>
		[Export ("initWithPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MCSession (MCPeerID myPeerID)
			: base (NSObjectFlag.Empty)
		{
			var myPeerID__handle__ = myPeerID!.GetNonNullHandle (nameof (myPeerID));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPeer_XHandle, myPeerID__handle__), "initWithPeer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPeer_XHandle, myPeerID__handle__), "initWithPeer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (myPeerID);
		}
		/// <param name="peerID">The ID of the peer whose connection should be cancelled.</param><summary>Cancel's a pending connection to the <paramref name="peerID" />.</summary><remarks>To be added.</remarks>
		[Export ("cancelConnectPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelConnectPeer (MCPeerID peerID)
		{
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCancelConnectPeer_XHandle, peerID__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCancelConnectPeer_XHandle, peerID__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (peerID);
		}
		/// <param name="peerID">The remote peer's identifier.</param><param name="data">To be added.</param><summary>Initiates a connection to a peer identified by <paramref name="peerID" />.</summary><remarks><para>Application developers may use a non-Multipeer Connectivity discovery technique, such as Bonjour / <see cref="T:Foundation.NSNetService" />, and manually manage peer connection. However, the <paramref name="peerID" /> used here and in <see cref="M:MultipeerConnectivity.MCSession.NearbyConnectionDataForPeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler)" /> must originate from a <see cref="T:Foundation.NSKeyedArchiver" /> serializing an <see cref="T:MultipeerConnectivity.MCPeerID" /> on the remote peer. (This raises the question: if discovery and enough message-passing code to transmit the <paramref name="peerID" /> is done by Bonjour, what's the advantage of using MPC for further communication? One answer might be the evolution of a legacy system, another answer might lie in the simpler message- and resource-passing of MPC.)</para></remarks>
		[Export ("connectPeer:withNearbyConnectionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectPeer (MCPeerID peerID, NSData data)
		{
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selConnectPeer_WithNearbyConnectionData_XHandle, peerID__handle__, data__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selConnectPeer_WithNearbyConnectionData_XHandle, peerID__handle__, data__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (peerID);
			GC.KeepAlive (data);
		}
		/// <summary>Disconnects this peer from the session.</summary><remarks>To be added.</remarks>
		[Export ("disconnect")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDisconnectXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="peerID">Created from data serialized on a remote peer.</param><param name="completionHandler">The completion handler called after processing is complete.</param><summary>Creates the necessary data for a  manually-managed peer connection.</summary><remarks><para>Application developers may use a non-Multipeer Connectivity discovery technique, such as Bonjour / <see cref="T:Foundation.NSNetService" />, and manually manage peer connection. However, the <paramref name="peerID" /> used here and in <see cref="M:MultipeerConnectivity.MCSession.ConnectPeer(MultipeerConnectivity.MCPeerID,Foundation.NSData)" /> must originate from a <see cref="T:Foundation.NSKeyedArchiver" /> serializing an <see cref="T:MultipeerConnectivity.MCPeerID" /> on the remote peer. (This raises the question: if discovery and enough message-passing code to transmit the <paramref name="peerID" /> is done by Bonjour, what's the advantage of using MPC for further communication? One answer might be the evolution of a legacy system, another answer might lie in the simpler message- and resource-passing of MPC.)</para><para>Once the application developer has the <paramref name="peerID" />, the rest of the code to connect a peer would be:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// //User code: Perhaps using Bonjour or other discovery and messaging service
		/// var peerID = DeserializedPeerID();
		/// //Request connection data, with completionHandler lambda as continuation
		/// session.NearbyConnectionDataForPeer(peerID, (connectionData, error) => { 
		/// if(error != null){
		/// //Note: peerID is serialized version, connectionData is passed in to continuation
		/// session.ConnectPeer(peerID, connectionData);
		/// }else{
		/// throw new Exception(error);
		/// }
		/// });              
		/// ]]></code></example></remarks>
		[Export ("nearbyConnectionDataForPeer:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NearbyConnectionDataForPeer (MCPeerID peerID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMCSessionNearbyConnectionDataForPeerCompletionHandler))]MCSessionNearbyConnectionDataForPeerCompletionHandler completionHandler)
		{
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMCSessionNearbyConnectionDataForPeerCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selNearbyConnectionDataForPeer_WithCompletionHandler_XHandle, peerID__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selNearbyConnectionDataForPeer_WithCompletionHandler_XHandle, peerID__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (peerID);
		}
		/// <param name="peerID">Created from data serialized on a remote peer.</param>
		/// <summary>Creates the necessary data for a  manually-managed peer connection.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous NearbyConnectionDataForPeer operation.   The value of the TResult parameter is a <see cref="MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The NearbyConnectionDataForPeerAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">Application developers may use a non-Multipeer Connectivity discovery technique, such as Bonjour / <see cref="Foundation.NSNetService" />, and manually manage peer connection. However, the <paramref name="peerID" /> used here and in <see cref="MultipeerConnectivity.MCSession.ConnectPeer(MultipeerConnectivity.MCPeerID,Foundation.NSData)" /> must originate from a <see cref="Foundation.NSKeyedArchiver" /> serializing an <see cref="MultipeerConnectivity.MCPeerID" /> on the remote peer. (This raises the question: if discovery and enough message-passing code to transmit the <paramref name="peerID" /> is done by Bonjour, what's the advantage of using MPC for further communication? One answer might be the evolution of a legacy system, another answer might lie in the simpler message- and resource-passing of MPC.)</para>
		///           <para copied="true">Once the application developer has the <paramref name="peerID" />, the rest of the code to connect a peer would be:</para>
		///           <example copied="true">
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //User code: Perhaps using Bonjour or other discovery and messaging service
		/// var peerID = DeserializedPeerID();
		/// //Request connection data, with completionHandler lambda as continuation
		/// session.NearbyConnectionDataForPeer(peerID, (connectionData, error) => { 
		///     if(error is not null){
		///         //Note: peerID is serialized version, connectionData is passed in to continuation
		///         session.ConnectPeer(peerID, connectionData);
		///     }else{
		///          throw new Exception(error);
		///     }
		/// });              
		///               ]]></code>
		///           </example>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> NearbyConnectionDataForPeerAsync (MCPeerID peerID)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			NearbyConnectionDataForPeer(peerID, (connectionData_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (connectionData_!);
			});
			return tcs.Task;
		}
		/// <param name="data">To be added.</param><param name="peerIDs">To be added.</param><param name="mode">To be added.</param><param name="error">To be added.</param><summary>Enqueues for delivery the <paramref name="data" /> to the peers in <paramref name="peerIDs" />.</summary><returns><see langword="true" /> if the message was enqueued for delivery.</returns><remarks><para>Note that the return value only indicates successful enqueueing of the data for transmission, not a confirmation of delivery.</para></remarks>
		[Export ("sendData:toPeers:withMode:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SendData (NSData data, MCPeerID[] peerIDs, MCSessionSendDataMode mode, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (peerIDs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerIDs));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_peerIDs = NSArray.FromNSObjects (peerIDs);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_ref_NativeHandle (this.Handle, selSendData_ToPeers_WithMode_Error_XHandle, data__handle__, nsa_peerIDs.Handle, (IntPtr) (long) mode, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_ref_NativeHandle (&__objc_super__, selSendData_ToPeers_WithMode_Error_XHandle, data__handle__, nsa_peerIDs.Handle, (IntPtr) (long) mode, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="resourceUrl">The URL to the resource.</param><param name="resourceName">The name of the resource.</param><param name="peerID">The ID of the receiving peer.</param><param name="completionHandler"><para>A handler that is run after delivery or failure.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Enqueues for delivery to <paramref name="peerID" /> the resource at <paramref name="resourceUrl" />.</summary><returns><see langword="true" /> if the resource was enqueued for delivery.</returns><remarks><para>Note that the return value only indicates successful enqueueing of the resource for transmission, not a confirmation of delivery. Delivery success or failure is passed in to the <paramref name="completionHandler" />.</para></remarks>
		[Export ("sendResourceAtURL:withName:toPeer:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? SendResource (NSUrl resourceUrl, string resourceName, MCPeerID peerID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var resourceUrl__handle__ = resourceUrl!.GetNonNullHandle (nameof (resourceUrl));
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var nsresourceName = CFString.CreateNative (resourceName);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_XHandle, resourceUrl__handle__, nsresourceName, peerID__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_XHandle, resourceUrl__handle__, nsresourceName, peerID__handle__, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resourceUrl);
			GC.KeepAlive (peerID);
			CFString.ReleaseNative (nsresourceName);
			return ret!;
		}
		/// <param name="resourceUrl">The URL to the resource.</param>
		/// <param name="resourceName">The name of the resource.</param>
		/// <param name="peerID">The ID of the receiving peer.</param>
		/// <summary>Enqueues for delivery to <paramref name="peerID" /> the resource at <paramref name="resourceUrl" />.</summary>
		/// <returns>A task that represents the asynchronous SendResource operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SendResourceAsync (NSUrl resourceUrl, string resourceName, MCPeerID peerID)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SendResource(resourceUrl, resourceName, peerID, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="resourceUrl">The URL to the resource.</param>
		/// <param name="resourceName">The name of the resource.</param>
		/// <param name="peerID">The ID of the receiving peer.</param>
		/// <param name="result">A progress result.</param>
		/// <summary>Asynchronously enqueues for delivery to <paramref name="resourceName" /> the resource at <paramref name="resourceUrl" />, returning a task that represents the operation.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SendResourceAsync (NSUrl resourceUrl, string resourceName, MCPeerID peerID, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<bool> ();
			result = SendResource(resourceUrl, resourceName, peerID, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			})!;
			return tcs.Task;
		}
		/// <param name="streamName">To be added.</param><param name="peerID">To be added.</param><param name="error">To be added.</param><summary>Creates a named stream to <paramref name="peerID" />.</summary><returns>A byte stream or <see langword="null" /> if the stream could not be created.</returns><remarks>To be added.</remarks>
		[Export ("startStreamWithName:toPeer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSOutputStream? StartStream (string streamName, MCPeerID peerID, out NSError error)
		{
			if (streamName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (streamName));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			NativeHandle errorValue = IntPtr.Zero;
			var nsstreamName = CFString.CreateNative (streamName);
			NSOutputStream? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSOutputStream> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selStartStreamWithName_ToPeer_Error_XHandle, nsstreamName, peerID__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSOutputStream> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selStartStreamWithName_ToPeer_Error_XHandle, nsstreamName, peerID__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (peerID);
			CFString.ReleaseNative (nsstreamName);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("initWithPeer:securityIdentity:encryptionPreference:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _Init (MCPeerID myPeerID, NSArray? identity, MCEncryptionPreference encryptionPreference)
		{
			var myPeerID__handle__ = myPeerID!.GetNonNullHandle (nameof (myPeerID));
			var identity__handle__ = identity.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selInitWithPeer_SecurityIdentity_EncryptionPreference_XHandle, myPeerID__handle__, identity__handle__, (IntPtr) (long) encryptionPreference);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selInitWithPeer_SecurityIdentity_EncryptionPreference_XHandle, myPeerID__handle__, identity__handle__, (IntPtr) (long) encryptionPreference);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (myPeerID);
			GC.KeepAlive (identity);
			return ret!;
		}
		/// <summary>An array of the currently connected devices.</summary><value>The array will be non-null, but of length 0, if no peers are connected.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MCPeerID[] ConnectedPeers {
			[Export ("connectedPeers")]
			get {
				MCPeerID[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MCPeerID>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConnectedPeersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MCPeerID>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConnectedPeersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>An instance of the MultipeerConnectivity.IMCSessionDelegate model class which acts as the class delegate.</summary><value>The instance of the MultipeerConnectivity.IMCSessionDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMCSessionDelegate Delegate {
			get {
				return (WeakDelegate as IMCSessionDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>What type, if any, encryption s preferred.</summary><value>The default value is <see cref="F:MultipeerConnectivity.MCEncryptionPreference.Optional" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MCEncryptionPreference EncryptionPreference {
			[Export ("encryptionPreference")]
			get {
				MCEncryptionPreference ret;
				if (IsDirectBinding) {
					ret = (MultipeerConnectivity.MCEncryptionPreference) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncryptionPreferenceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MultipeerConnectivity.MCEncryptionPreference) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEncryptionPreferenceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The peer ID associated with this device.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MCPeerID MyPeerID {
			[Export ("myPeerID")]
			get {
				MCPeerID? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MCPeerID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMyPeerIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MCPeerID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMyPeerIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The security identity of this peer.</summary><value>Location [0] holds a <c>SecIdentityRef</c> for the local peer. Additional values (if they exist) will be for connected peers.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray? SecurityIdentity {
			[Export ("securityIdentity")]
			get {
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSecurityIdentityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSecurityIdentityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		/// <summary>Represents the value associated with the constant kMCSessionMaximumNumberOfPeers</summary><value>The value is 8.</value><remarks>To be added.</remarks><altmember cref="P:MultipeerConnectivity.MCBrowserViewController.MaximumNumberOfPeers" />
		[Field ("kMCSessionMaximumNumberOfPeers",  "MultipeerConnectivity")]
		public static nint MaximumNumberOfPeers {
			get {
				return Dlfcn.GetIntPtr (Libraries.MultipeerConnectivity.Handle, "kMCSessionMaximumNumberOfPeers");
			}
		}
		/// <summary>Represents the value associated with the constant kMCSessionMinimumNumberOfPeers</summary><value>The value is 2.
		/// </value><remarks>To be added.</remarks><altmember cref="P:MultipeerConnectivity.MCBrowserViewController.MinimumNumberOfPeers" />
		[Field ("kMCSessionMinimumNumberOfPeers",  "MultipeerConnectivity")]
		public static nint MinimumNumberOfPeers {
			get {
				return Dlfcn.GetIntPtr (Libraries.MultipeerConnectivity.Handle, "kMCSessionMinimumNumberOfPeers");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MCSession */
}
