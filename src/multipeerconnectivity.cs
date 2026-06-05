//
// multipeerconnectivity.cs: binding for iOS (7+) MultipeerConnectivity framework
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013 Xamarin, Inc.

using Security;
#if MONOMAC
using AppKit;
using UIViewController = AppKit.NSViewController;
#else
using UIKit;
#endif

namespace MultipeerConnectivity {

	/// <summary>Identifies a device in a multipeer connectivity network.</summary>
	///     <remarks>
	///       <para>
	///         <see cref="MultipeerConnectivity.MCPeerID.DisplayName" /> must be unique among peers.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCPeerID_class/index.html">Apple documentation for <c>MCPeerID</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSInvalidArgumentException Reason: -[MCPeerID init]: unrecognized selector sent to instance 0x7d721090
	partial interface MCPeerID : NSCopying, NSSecureCoding {

		/// <param name="myDisplayName">The name for the peer.</param>
		/// <summary>Constructor that assigns to the <see cref="MultipeerConnectivity.MCPeerID.DisplayName" /> property.</summary>
		
		[DesignatedInitializer]
		[Export ("initWithDisplayName:")]
		NativeHandle Constructor (string myDisplayName);

		/// <summary>The displayable name for the peer.</summary>
		[Export ("displayName")]
		string DisplayName { get; }
	}

	/// <summary>A delegate that serves as the completion handler for <see cref="MultipeerConnectivity.MCSession.NearbyConnectionDataForPeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler)" />.</summary>
	delegate void MCSessionNearbyConnectionDataForPeerCompletionHandler ([NullAllowed] NSData connectionData, [NullAllowed] NSError error);

	/// <include file="../docs/api/MultipeerConnectivity/MCSession.xml" path="/Documentation/Docs[@DocId='T:MultipeerConnectivity.MCSession']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // crash when calling `description` selector
	partial interface MCSession {

		/// <param name="myPeerID">The identity of the local peer.</param>
		/// <summary>Constructs a session with the specified identity for the local peer.</summary>
		
		[Export ("initWithPeer:")]
		NativeHandle Constructor (MCPeerID myPeerID);

		// Note: it should be a constructor but it's use of an NSArray of different types makes it hard to provide a 
		// nice binding, i.e. the first item of NSArray must be an SecIdentity followed by (0...) SecCertificate
		[Internal]
		[Export ("initWithPeer:securityIdentity:encryptionPreference:")]
		IntPtr _Init (MCPeerID myPeerID, [NullAllowed] NSArray identity, MCEncryptionPreference encryptionPreference);

		/// <param name="data">The data to send.</param>
		/// <param name="peerIDs">The peer IDs to send the data to.</param>
		/// <param name="mode">The delivery mode.</param>
		/// <param name="error">Set to the error if sending fails.</param>
		///         <summary>Enqueues for delivery the <paramref name="data" /> to the peers in <paramref name="peerIDs" />.</summary>
		///         <returns>
		///           <see langword="true" /> if the message was enqueued for delivery.</returns>
		///         <remarks>
		///           <para>Note that the return value only indicates successful enqueueing of the data for transmission, not a confirmation of delivery.</para>
		///         </remarks>
		[Export ("sendData:toPeers:withMode:error:")]
		bool SendData (NSData data, MCPeerID [] peerIDs, MCSessionSendDataMode mode, out NSError error);

		/// <summary>Disconnects this peer from the session.</summary>
		[Export ("disconnect")]
		void Disconnect ();

		/// <summary>An array of the currently connected devices.</summary>
		///         <value>The array will be non-null, but of length 0, if no peers are connected.</value>
		[Export ("connectedPeers")]
		MCPeerID [] ConnectedPeers { get; }

		/// <param name="resourceUrl">The URL to the resource.</param>
		///         <param name="resourceName">The name of the resource.</param>
		///         <param name="peerID">The ID of the receiving peer.</param>
		///         <param name="completionHandler">
		///           <para>A handler that is run after delivery or failure.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Enqueues for delivery to <paramref name="peerID" /> the resource at <paramref name="resourceUrl" />.</summary>
		///         <returns>
		///           <see langword="true" /> if the resource was enqueued for delivery.</returns>
		///         <remarks>
		///           <para>Note that the return value only indicates successful enqueueing of the resource for transmission, not a confirmation of delivery. Delivery success or failure is passed in to the <paramref name="completionHandler" />.</para>
		///         </remarks>
		[Async (XmlDocs = """
			<param name="resourceUrl">The URL to the resource.</param>
			<param name="resourceName">The name of the resource.</param>
			<param name="peerID">The ID of the receiving peer.</param>
			<summary>Enqueues for delivery to <paramref name="peerID" /> the resource at <paramref name="resourceUrl" />.</summary>
			<returns>A task that represents the asynchronous SendResource operation</returns>
			
			""",
			XmlDocsWithOutParameter = """
			<param name="resourceUrl">The URL to the resource.</param>
			<param name="resourceName">The name of the resource.</param>
			<param name="peerID">The ID of the receiving peer.</param>
			<param name="result">A progress result.</param>
			<summary>Asynchronously enqueues for delivery to <paramref name="resourceName" /> the resource at <paramref name="resourceUrl" />, returning a task that represents the operation.</summary>
			<returns>A task representing the asynchronous operation.</returns>
			
			""")]
		[return: NullAllowed]
		[Export ("sendResourceAtURL:withName:toPeer:withCompletionHandler:")]
		NSProgress SendResource (NSUrl resourceUrl, string resourceName, MCPeerID peerID, [NullAllowed] Action<NSError> completionHandler);

		/// <param name="streamName">The name of the stream.</param>
		/// <param name="peerID">The peer ID to stream to.</param>
		/// <param name="error">Set to the error if the stream cannot be started.</param>
		///         <summary>Creates a named stream to <paramref name="peerID" />.</summary>
		///         <returns>A byte stream or <see langword="null" /> if the stream could not be created.</returns>
		[return: NullAllowed]
		[Export ("startStreamWithName:toPeer:error:")]
		NSOutputStream StartStream (string streamName, MCPeerID peerID, out NSError error);

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MultipeerConnectivity.IMCSessionDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MultipeerConnectivity.IMCSessionDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMCSessionDelegate Delegate { get; set; }

		/// <summary>The peer ID associated with this device.</summary>
		[Export ("myPeerID")]
		MCPeerID MyPeerID { get; }

		// we use NSArray because, when non-null, it contains a SecIdentity followed by 0..n SecCertificate - none are NSObject
		/// <summary>The security identity of this peer.</summary>
		///         <value>Location [0] holds a <c>SecIdentityRef</c> for the local peer. Additional values (if they exist) will be for connected peers.</value>
		[NullAllowed]
		[Export ("securityIdentity")]
		NSArray SecurityIdentity { get; }

		/// <summary>What type, if any, encryption s preferred.</summary>
		///         <value>The default value is <see cref="MultipeerConnectivity.MCEncryptionPreference.Optional" />.</value>
		[Export ("encryptionPreference")]
		MCEncryptionPreference EncryptionPreference { get; }

		/// <summary>Represents the value associated with the constant kMCSessionMaximumNumberOfPeers</summary>
		///         <value>The value is 8.</value>
		///         <altmember cref="MultipeerConnectivity.MCBrowserViewController.MaximumNumberOfPeers" />
		[Field ("kMCSessionMaximumNumberOfPeers")]
		nint MaximumNumberOfPeers { get; }

		/// <summary>Represents the value associated with the constant kMCSessionMinimumNumberOfPeers</summary>
		///         <value>The value is 2.
		///         </value>
		///         <altmember cref="MultipeerConnectivity.MCBrowserViewController.MinimumNumberOfPeers" />
		[Field ("kMCSessionMinimumNumberOfPeers")]
		nint MinimumNumberOfPeers { get; }

		#region Custom Discovery Category

		/// <include file="../docs/api/MultipeerConnectivity/MCSession.xml" path="/Documentation/Docs[@DocId='M:MultipeerConnectivity.MCSession.NearbyConnectionDataForPeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler)']/*" />
		[Async (XmlDocs = """
			<param name="peerID">Created from data serialized on a remote peer.</param>
			<summary>Creates the necessary data for a  manually-managed peer connection.</summary>
			<returns>
			          <para>A task that represents the asynchronous NearbyConnectionDataForPeer operation.   The value of the TResult parameter is a <see cref="MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler" />.</para>
			        </returns>
			<remarks>
			          <para copied="true">The NearbyConnectionDataForPeerAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para copied="true">Application developers may use a non-Multipeer Connectivity discovery technique, such as Bonjour / <see cref="Foundation.NSNetService" />, and manually manage peer connection. However, the <paramref name="peerID" /> used here and in <see cref="MultipeerConnectivity.MCSession.ConnectPeer(MultipeerConnectivity.MCPeerID,Foundation.NSData)" /> must originate from a <see cref="Foundation.NSKeyedArchiver" /> serializing an <see cref="MultipeerConnectivity.MCPeerID" /> on the remote peer. (This raises the question: if discovery and enough message-passing code to transmit the <paramref name="peerID" /> is done by Bonjour, what's the advantage of using MPC for further communication? One answer might be the evolution of a legacy system, another answer might lie in the simpler message- and resource-passing of MPC.)</para>
			          <para copied="true">Once the application developer has the <paramref name="peerID" />, the rest of the code to connect a peer would be:</para>
			          <example copied="true">
			            <code lang="csharp lang-csharp"><![CDATA[
			//User code: Perhaps using Bonjour or other discovery and messaging service
			var peerID = DeserializedPeerID();
			//Request connection data, with completionHandler lambda as continuation
			session.NearbyConnectionDataForPeer(peerID, (connectionData, error) => { 
			    if(error is not null){
			        //Note: peerID is serialized version, connectionData is passed in to continuation
			        session.ConnectPeer(peerID, connectionData);
			    }else{
			         throw new Exception(error);
			    }
			});              
			              ]]></code>
			          </example>
			        </remarks>
			""")]
		[Export ("nearbyConnectionDataForPeer:withCompletionHandler:")]
		void NearbyConnectionDataForPeer (MCPeerID peerID, MCSessionNearbyConnectionDataForPeerCompletionHandler completionHandler);

		/// <include file="../docs/api/MultipeerConnectivity/MCSession.xml" path="/Documentation/Docs[@DocId='M:MultipeerConnectivity.MCSession.ConnectPeer(MultipeerConnectivity.MCPeerID,Foundation.NSData)']/*" />
		[Export ("connectPeer:withNearbyConnectionData:")]
		void ConnectPeer (MCPeerID peerID, NSData data);

		/// <param name="peerID">The ID of the peer whose connection should be cancelled.</param>
		///         <summary>Cancel's APending connection to the <paramref name="peerID" />.</summary>
		[Export ("cancelConnectPeer:")]
		void CancelConnectPeer (MCPeerID peerID);

		#endregion
	}

	interface IMCSessionDelegate { }

	/// <summary>A delegate object whose functions relate to events in the <see cref="MultipeerConnectivity.MCSession" /> life-cycle, such as connection status changes and data reception.</summary>
	///     <remarks>
	///       <para>Callbacks to the <see cref="MultipeerConnectivity.MCSessionDelegate" /> object are likely to be made on background threads. Application developers who wish to update the display must use, for instance, <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCSessionDelegateRef/index.html">Apple documentation for <c>MCSessionDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	partial interface MCSessionDelegate {
		/// <param name="session">The session.</param>
		/// <param name="peerID">The peer ID whose state changed.</param>
		/// <param name="state">The new session state.</param>
		///         <summary>Indicates that the <paramref name="session" /> has transitioned to the new <paramref name="state" />.</summary>
		[Abstract]
		[Export ("session:peer:didChangeState:")]
		void DidChangeState (MCSession session, MCPeerID peerID, MCSessionState state);

		/// <param name="session">The session.</param>
		/// <param name="data">The received data.</param>
		/// <param name="peerID">The peer ID that sent the data.</param>
		///         <summary>Indicates the arrival of <paramref name="data" />.</summary>
		[Abstract]
		[Export ("session:didReceiveData:fromPeer:")]
		void DidReceiveData (MCSession session, NSData data, MCPeerID peerID);

		/// <param name="session">The session.</param>
		/// <param name="resourceName">The name of the resource.</param>
		/// <param name="fromPeer">The peer ID that is sending the resource.</param>
		/// <param name="progress">The progress of the transfer.</param>
		///         <summary>Indicates that <paramref name="resourceName" /> has begun to arrive.</summary>
		[Abstract]
		[Export ("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
		void DidStartReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress);

		/// <param name="session">The session.</param>
		/// <param name="resourceName">The name of the resource.</param>
		/// <param name="fromPeer">The peer ID that sent the resource.</param>
		///         <param name="localUrl">
		///   <para>The error, or <see langword="null" /> if the transfer succeeded.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">
		///           <para>The error (if any) that occurred during transfer.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Indicates that the transfer of <paramref name="resourceName" /> has completed.</summary>
		[Abstract]
		[Export ("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
		void DidFinishReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, [NullAllowed] NSUrl localUrl, [NullAllowed] NSError error);

		/// <param name="session">The session.</param>
		/// <param name="stream">The input stream.</param>
		/// <param name="streamName">The name of the stream.</param>
		/// <param name="peerID">The peer ID that opened the stream.</param>
		///         <summary>Indicates the arrival of <paramref name="stream" />.</summary>
		[Abstract]
		[Export ("session:didReceiveStream:withName:fromPeer:")]
		void DidReceiveStream (MCSession session, NSInputStream stream, string streamName, MCPeerID peerID);

		/// <param name="session">The session.</param>
		///         <param name="certificate">
		///   <para>The certificate chain, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="peerID">The peer ID that is connecting.</param>
		/// <param name="certificateHandler">The handler to call with the certificate decision.</param>
		///         <summary>Indicates <paramref name="peerID" /> wishes to join the <paramref name="session" />. <paramref name="certificateHandler" /> must be called.</summary>
		/// <returns><see langword="true" /> to handle certificate verification; otherwise, <see langword="false" />.</returns>
		///         <remarks>
		///           <para>When overriding this method, the application developer must invoke the <paramref name="certificateHandler" />, passing in <see langword="true" /> if the peer should be accepted to the <paramref name="session" />.</para>
		///           <para>The Multipeer Connectivity framework makes no attempt to validate passed certificates. It is the application developer's responsibility to ensure their validity.</para>
		///         </remarks>
		[Export ("session:didReceiveCertificate:fromPeer:certificateHandler:")]
		bool DidReceiveCertificate (MCSession session, [NullAllowed] SecCertificate [] certificate, MCPeerID peerID, Action<bool> certificateHandler);
	}

	/// <summary>Provides programmatic control for advertising the device for multipeer connectivity.</summary>
	///     <remarks>
	///       <para>Multipeer connectivity's discovery phase involves two roles: browsing and advertising. When an application makes itself available for connection, it is advertising. Advertising may be controlled by either a <see cref="MultipeerConnectivity.MCAdvertiserAssistant" /> or can be fully customized with a <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser" />. For a discussion of the discovery process, see the remarks for <see cref="MultipeerConnectivity.MCSession" />.</para>
	///     </remarks>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceAdvertiserClassRef/index.html">Apple documentation for <c>MCNearbyServiceAdvertiser</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSInvalidArgumentException -[MCNearbyServiceAdvertiser init]: unrecognized selector sent to instance 0x19195e50
	partial interface MCNearbyServiceAdvertiser {

		/// <param name="myPeerID">The local peer ID.</param>
		/// <param name="info">A small dictionary to aide discovery (see <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser.DiscoveryInfo" />).<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param>
		/// <param name="serviceType">A string between 1 and 15 characters long, identifying the protocol being used.</param>
		/// <summary>Creates an object identified as <paramref name="myPeerID" /> for the specific <paramref name="serviceType" />.</summary>
		/// <remarks>
		///           <para>The <paramref name="serviceType" /> must be a string, between 1 and 15 characters long, identifying the network protocol being advertised. A common pattern is "{company_name}-{apptype}", e.g., <c>xamarin-txtchat</c>.</para>
		///           <para>The <paramref name="info" /> dictionary has size and content limitations (see <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser.DiscoveryInfo" />). </para>
		///         </remarks>
		[DesignatedInitializer]
		[Export ("initWithPeer:discoveryInfo:serviceType:")]
		NativeHandle Constructor (MCPeerID myPeerID, [NullAllowed] NSDictionary info, string serviceType);

		/// <summary>Begins advertising this peer device for connection.</summary>
		[Export ("startAdvertisingPeer")]
		void StartAdvertisingPeer ();

		/// <summary>Stops advertising this peer device for connection.</summary>
		[Export ("stopAdvertisingPeer")]
		void StopAdvertisingPeer ();

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MultipeerConnectivity.IMCNearbyServiceAdvertiserDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MultipeerConnectivity.IMCNearbyServiceAdvertiserDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMCNearbyServiceAdvertiserDelegate Delegate { get; set; }

		/// <summary>The identity by which this device will be known on the peer network.</summary>
		///         <value>This will contain the datAPassed in to the <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser(MultipeerConnectivity.MCPeerID,Foundation.NSDictionary,string)" /> constructor.</value>
		[Export ("myPeerID")]
		MCPeerID MyPeerID { get; }

		/// <include file="../docs/api/MultipeerConnectivity/MCNearbyServiceAdvertiser.xml" path="/Documentation/Docs[@DocId='P:MultipeerConnectivity.MCNearbyServiceAdvertiser.DiscoveryInfo']/*" />
		[NullAllowed]
		[Export ("discoveryInfo")]
		NSDictionary DiscoveryInfo { get; }

		/// <summary>The network protocol this peer supports.</summary>
		///         <value>This will contain the datAPassed in to the <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser(MultipeerConnectivity.MCPeerID,Foundation.NSDictionary,string)" /> constructor.</value>
		[Export ("serviceType")]
		string ServiceType { get; }
	}

	/// <param name="accept">
	///       <see langword="true" /> if the invitation should be accepted.</param>
	///     <param name="session">The session to which the peer shouldbe connected.</param>
	///     <summary>The delegate that serves as the invitation handler in calls to <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiserDelegate.DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,MultipeerConnectivity.MCPeerID,Foundation.NSData,MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler)" />.</summary>
	delegate void MCNearbyServiceAdvertiserInvitationHandler (bool accept, [NullAllowed] MCSession session);

	interface IMCNearbyServiceAdvertiserDelegate { }

	/// <summary>A delegate object that exposes events relating to advertising and invitations for multipeer connectivity for a <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser" /> object.</summary>
	///     <remarks>
	///       <para>For a discussion of the discovery process, see the remarks for <see cref="MultipeerConnectivity.MCSession" />.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceAdvertiserDelegateProtocolRef/index.html">Apple documentation for <c>MCNearbyServiceAdvertiserDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	partial interface MCNearbyServiceAdvertiserDelegate {

		/// <include file="../docs/api/MultipeerConnectivity/MCNearbyServiceAdvertiserDelegate.xml" path="/Documentation/Docs[@DocId='M:MultipeerConnectivity.MCNearbyServiceAdvertiserDelegate.DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,MultipeerConnectivity.MCPeerID,Foundation.NSData,MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler)']/*" />
		[Abstract]
		[Export ("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
		void DidReceiveInvitationFromPeer (MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, [NullAllowed] NSData context, MCNearbyServiceAdvertiserInvitationHandler invitationHandler);

		/// <param name="advertiser">The nearby service advertiser.</param>
		/// <param name="error">The error that occurred.</param>
		///         <summary>Indicates that advertising peer availability failed.</summary>
		[Export ("advertiser:didNotStartAdvertisingPeer:")]
		void DidNotStartAdvertisingPeer (MCNearbyServiceAdvertiser advertiser, NSError error);
	}

	/// <summary>Allows programmatic browsing for devices advertising for multipeer connetivity.</summary>
	///     <remarks>
	///       <para>Multipeer connectivity's discovery phase involves two roles: browsing and advertising. When an application searches for peers with which to connect, it is browsing. Browsing may be controlled by either a <see cref="MultipeerConnectivity.MCBrowserViewController" /> or can be fully customized with a <see cref="MultipeerConnectivity.MCNearbyServiceBrowser" />. For a discussion of the discovery process, see the remarks for <see cref="MultipeerConnectivity.MCSession" />.</para>
	///     </remarks>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceBrowserClassRef/index.html">Apple documentation for <c>MCNearbyServiceBrowser</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSInvalidArgumentException -[MCNearbyServiceBrowser init]: unrecognized selector sent to instance 0x15519a70
	partial interface MCNearbyServiceBrowser {

		/// <param name="myPeerID">The ID of the local peer.</param>
		/// <param name="serviceType">The network protocol.</param>
		/// <summary>Constructs a browser for the specified <paramref name="serviceType" /> protocol, identifying the local peer as <paramref name="myPeerID" />.</summary>
		/// <remarks>
		///           <para>The <paramref name="serviceType" /> must be a string, between 1 and 15 characters long, identifying the network protocol being advertised. A common pattern is "{company_name}-{apptype}", e.g., <c>xamarin-txtchat</c>.</para>
		///         </remarks>
		[DesignatedInitializer]
		[Export ("initWithPeer:serviceType:")]
		NativeHandle Constructor (MCPeerID myPeerID, string serviceType);

		/// <summary>Starts browsing for local peers advertising for the <see cref="MultipeerConnectivity.MCNearbyServiceBrowser.ServiceType" />.</summary>
		[Export ("startBrowsingForPeers")]
		void StartBrowsingForPeers ();

		/// <summary>Stops browsing for peers.</summary>
		[Export ("stopBrowsingForPeers")]
		void StopBrowsingForPeers ();

		/// <param name="peerID">The remote peer being invited.</param>
		///         <param name="session">The session to which the peer is being invited.</param>
		///         <param name="context">
		///           <para>Arbitrary data that can aide the peer in analyzing the invitation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="timeout">The maximum time, in seconds, to wait for the peer (default value is 30).</param>
		///         <summary>Invites a remote peer to join the <paramref name="session" />.</summary>
		[Export ("invitePeer:toSession:withContext:timeout:")]
		void InvitePeer (MCPeerID peerID, MCSession session, [NullAllowed] NSData context, double timeout);

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MultipeerConnectivity.IMCNearbyServiceBrowserDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MultipeerConnectivity.IMCNearbyServiceBrowserDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMCNearbyServiceBrowserDelegate Delegate { get; set; }

		/// <summary>The identity of the local peer.</summary>
		[Export ("myPeerID")]
		MCPeerID MyPeerID { get; }

		/// <summary>The network protocol being browsed for.</summary>
		[Export ("serviceType")]
		string ServiceType { get; }
	}

	/// <summary>A delegate object that exposes peer-discovery events for a <see cref="MultipeerConnectivity.MCNearbyServiceBrowser" /> object.</summary>
	///     <remarks>
	///       <para>For a discussion of peer discovery and connection, see <see cref="MultipeerConnectivity.MCSession" /> remarks.</para>
	///       <para>Methods of <see cref="MultipeerConnectivity.MCNearbyServiceBrowserDelegate" /> are typically called by the system on a background thread. Application developers who wish to modify the user interface must use, for instance, <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCNearbyServiceBrowserDelegateRef/index.html">Apple documentation for <c>MCNearbyServiceBrowserDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	partial interface MCNearbyServiceBrowserDelegate {

		/// <param name="browser">The nearby service browser.</param>
		/// <param name="peerID">The discovered peer ID.</param>
		///         <param name="info">
		///   <para>The discovery info, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Indicates that APeer has been found.</summary>
		[Abstract]
		[Export ("browser:foundPeer:withDiscoveryInfo:")]
		void FoundPeer (MCNearbyServiceBrowser browser, MCPeerID peerID, [NullAllowed] NSDictionary info);

		/// <param name="browser">The nearby service browser.</param>
		/// <param name="peerID">The lost peer ID.</param>
		///         <summary>Indicates that APeer has been lost.</summary>
		[Abstract]
		[Export ("browser:lostPeer:")]
		void LostPeer (MCNearbyServiceBrowser browser, MCPeerID peerID);

		/// <param name="browser">The nearby service browser.</param>
		/// <param name="error">The error that occurred.</param>
		///         <summary>Indicates that browsing for peers failed.</summary>
		[Export ("browser:didNotStartBrowsingForPeers:")]
		void DidNotStartBrowsingForPeers (MCNearbyServiceBrowser browser, NSError error);
	}

	interface IMCNearbyServiceBrowserDelegate { }

	/// <include file="../docs/api/MultipeerConnectivity/MCBrowserViewController.xml" path="/Documentation/Docs[@DocId='T:MultipeerConnectivity.MCBrowserViewController']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (UIViewController))]
	[DisableDefaultCtor] // NSInvalidArgumentException -[MCPeerPickerViewController initWithNibName:bundle:]: unrecognized selector sent to instance 0x15517b90
	partial interface MCBrowserViewController : MCNearbyServiceBrowserDelegate {
		/// <param name="nibName">
		///   <para>The name of the nib file, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bundle">
		///   <para>The bundle containing the nib, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new multipeer browser view controller from the named NIB in the specified bundle.</summary>
		
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <param name="browser">The nearby service browser to use.</param>
		/// <param name="session">The session to connect peers to.</param>
		/// <summary>Constructor where the service type and options are defined in <paramref name="browser" />.</summary>
		
		[DesignatedInitializer]
		[Export ("initWithBrowser:session:")]
		NativeHandle Constructor (MCNearbyServiceBrowser browser, MCSession session);

		/// <param name="serviceType">The Bonjour service type to browse for.</param>
		/// <param name="session">The session to connect peers to.</param>
		/// <summary>Constructor that advertises the <paramref name="serviceType" /> network protocol.</summary>
		/// <remarks>
		///           <para>The <paramref name="serviceType" /> must be a string, between 1 and 15 characters long, identifying the network protocol being advertised. A common pattern is "{company_name}-{apptype}", e.g., <c>xamarin-txtchat</c>.</para>
		///         </remarks>
		[Export ("initWithServiceType:session:")]
		NativeHandle Constructor (string serviceType, MCSession session);

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MultipeerConnectivity.IMCBrowserViewControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MultipeerConnectivity.IMCBrowserViewControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMCBrowserViewControllerDelegate Delegate { get; set; }

		/// <summary>Allows the application developer to specify a minimum amount of peers.</summary>
		///         <value>Must be greater than or equal to <see cref="MultipeerConnectivity.MCSession.MinimumNumberOfPeers" />.</value>
		[Export ("minimumNumberOfPeers", ArgumentSemantic.Assign)]
		nuint MinimumNumberOfPeers { get; set; }

		/// <summary>Allows the application developer to limit the number of peers.</summary>
		///         <value>Must be less than or equal to <see cref="MultipeerConnectivity.MCSession.MaximumNumberOfPeers" />.</value>
		[Export ("maximumNumberOfPeers", ArgumentSemantic.Assign)]
		nuint MaximumNumberOfPeers { get; set; }

#if !MONOMAC
		/// <summary>The <see cref="MultipeerConnectivity.MCNearbyServiceBrowser" /> used for discovering peers.</summary>
		[NullAllowed]
#endif
		[Export ("browser")]
		MCNearbyServiceBrowser Browser { get; }

		/// <summary>The <see cref="MultipeerConnectivity.MCSession" /> being managed.</summary>
		[Export ("session")]
		MCSession Session { get; }
	}

	interface IMCBrowserViewControllerDelegate { }

	/// <summary>A delegate object that provides events relating to the presentation of discovered peers and the application user's selection or cancellation of them.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCBrowserViewControllerDelegate/index.html">Apple documentation for <c>MCBrowserViewControllerDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	partial interface MCBrowserViewControllerDelegate {

		/// <param name="browserViewController">The browser view controller.</param>
		///         <summary>Indicates that the <paramref name="browserViewController" /> was dismissed when the user cancelled the presentation.</summary>
		[Abstract]
		[Export ("browserViewControllerWasCancelled:")]
		void WasCancelled (MCBrowserViewController browserViewController);

		/// <param name="browserViewController">The browser view controller.</param>
		///         <summary>Indicates that the <see cref="MultipeerConnectivity.MCBrowserViewController" /> was dismissed with peers connected.
		///         </summary>
		[Abstract]
		[Export ("browserViewControllerDidFinish:")]
		void DidFinish (MCBrowserViewController browserViewController);

		// optional

		/// <param name="browserViewController">The browser view controller.</param>
		/// <param name="peerID">The peer ID to validate.</param>
		///         <param name="info">
		///   <para>The discovery info, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Indicates a new peer has been discovered. Can be used to avoid showing the invitation UI.</summary>
		///         <returns>
		///           <see langword="true" /> if the <paramref name="browserViewController" /> should be displayed to the app user.</returns>
		[Export ("browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:")]
		bool ShouldPresentNearbyPeer (MCBrowserViewController browserViewController, MCPeerID peerID, [NullAllowed] NSDictionary info);
	}

	/// <summary>A convenience class that manages the process of advertising for multipeer connectivity and interacting with the application user.</summary>
	///     <remarks>
	///       <para>Multipeer connectivity's discovery phase involves two roles: browsing and advertising. When an application makes itself available for connection, it is advertising. Advertising may be controlled by either a <see cref="MultipeerConnectivity.MCAdvertiserAssistant" /> or can be fully customized with a <see cref="MultipeerConnectivity.MCNearbyServiceAdvertiser" />. For a discussion of the discovery process, see the remarks for <see cref="MultipeerConnectivity.MCSession" />.</para>
	///     </remarks>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCAdvertiserAssistant_class/index.html">Apple documentation for <c>MCAdvertiserAssistant</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSInvalidArgumentException Reason: -[MCAdvertiserAssistant init]: unrecognized selector sent to instance 0x7ea7fa40
	interface MCAdvertiserAssistant {

		/// <param name="serviceType">A string between 1 and 15 characters long, identifying the protocol being used.</param>
		/// <param name="info">A small dictionary to aide discovery (see <see cref="MultipeerConnectivity.MCAdvertiserAssistant.DiscoveryInfo" />).<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param>
		/// <param name="session">The session to advertise for.</param>
		/// <summary>Creates an object for the specific <paramref name="serviceType" /> and <paramref name="session" />.</summary>
		/// <remarks>
		///           <para>The <paramref name="serviceType" /> must be a string, between 1 and 15 characters long, identifying the network protocol being advertised. A common pattern is "{company_name}-{apptype}", e.g., <c>xamarin-txtchat</c>.</para>
		///           <para>The <paramref name="info" /> dictionary has size and content limitations (see <see cref="MultipeerConnectivity.MCAdvertiserAssistant.DiscoveryInfo" />). </para>
		///         </remarks>
		[DesignatedInitializer]
		[Export ("initWithServiceType:discoveryInfo:session:")]
		NativeHandle Constructor (string serviceType, [NullAllowed] NSDictionary info, MCSession session);

		/// <include file="../docs/api/MultipeerConnectivity/MCAdvertiserAssistant.xml" path="/Documentation/Docs[@DocId='P:MultipeerConnectivity.MCAdvertiserAssistant.DiscoveryInfo']/*" />
		[NullAllowed]
		[Export ("discoveryInfo")]
		NSDictionary DiscoveryInfo { get; }

		/// <summary>The <see cref="MultipeerConnectivity.MCSession" /> into which peers will be placed.</summary>
		///         <value>Passed in to the <see cref="MultipeerConnectivity.MCAdvertiserAssistant(string,Foundation.NSDictionary, MultipeerConnectivity.MCSession)" /> constructor.</value>
		[Export ("session")]
		MCSession Session { get; }

		/// <summary>A string, between 1 and 15 characters long, identifying the network protocol being advertised.</summary>
		///         <value>Passed in to the <see cref="MultipeerConnectivity.MCAdvertiserAssistant(string,Foundation.NSDictionary, MultipeerConnectivity.MCSession)" /> constructor.</value>
		[Export ("serviceType")]
		string ServiceType { get; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MultipeerConnectivity.IMCAdvertiserAssistantDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MultipeerConnectivity.IMCAdvertiserAssistantDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMCAdvertiserAssistantDelegate Delegate { get; set; }

		/// <summary>Begins advertising the local peer for connections.</summary>
		[Export ("start")]
		void Start ();

		/// <summary>Stops advertising the local peer.</summary>
		[Export ("stop")]
		void Stop ();
	}

	interface IMCAdvertiserAssistantDelegate { }

	/// <summary>A delegate object that provides events for the presentation or dismissal of an invitation by a <see cref="MultipeerConnectivity.MCAdvertiserAssistant" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCAdvertiserAssistantDelegate_class/index.html">Apple documentation for <c>MCAdvertiserAssistantDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MCAdvertiserAssistantDelegate {

		/// <param name="advertiserAssistant">The advertiser assistant.</param>
		///         <summary>Indicates that the peer-connection invitation is no longer being displayed to the user.</summary>
		[Export ("advertiserAssistantDidDismissInvitation:")]
		void DidDismissInvitation (MCAdvertiserAssistant advertiserAssistant);

		/// <param name="advertiserAssistant">The advertiser assistant.</param>
		///         <summary>Indicates that the peer-connection invitation is about to be presented.</summary>
		[Export ("advertiserAssistantWillPresentInvitation:")]
		void WillPresentInvitation (MCAdvertiserAssistant advertiserAssistant);
	}
}
