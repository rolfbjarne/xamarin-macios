//
// WatchConnectivity bindings
//
// Authors:
//	Alex Soto  <alex.soto@xamarin.com>
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

using System.ComponentModel;

namespace WatchConnectivity {

	/// <summary>The reply handler for use with <see cref="WatchConnectivity.WCSessionDelegate_Extensions.DidReceiveMessageData(WatchConnectivity.IWCSessionDelegate,WatchConnectivity.WCSession,Foundation.NSData,WatchConnectivity.WCSessionReplyDataHandler)" />.</summary>
	delegate void WCSessionReplyHandler (NSDictionary<NSString, NSObject> replyMessage);
	/// <summary>The reply handler for use with <see cref="WatchConnectivity.WCSessionDelegate.DidReceiveMessageData" />.</summary>
	delegate void WCSessionReplyDataHandler (NSData replyMessage);

	/// <summary>Mediates the transfer of information between a WatchKit extension app and the container app on the device.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSession_class/index.html">Apple documentation for <c>WCSession</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface WCSession {

		/// <summary>Whether the current device supports <see cref="WatchConnectivity.WCSession" /> objects.</summary>
		[Static]
		[Export ("isSupported")]
		bool IsSupported { get; }

		/// <summary>Produces the shared view of the app's <see cref="WatchConnectivity.WCSession" /> on the current device.</summary>
		[Static]
		[Export ("defaultSession")]
		WCSession DefaultSession { get; }

		/// <summary>An instance of the WatchConnectivity.IWCSessionDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the WatchConnectivity.IWCSessionDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		IWCSessionDelegate Delegate { get; set; }

		/// <summary>
		///           <see cref="WatchConnectivity.WCSession" /> objects must be activated on both devices prior to data transfer.</summary>
		[Export ("activateSession")]
		void ActivateSession ();

		/// <summary>Whether the current iPhone is paired to an Apple Watch.</summary>
		[Export ("paired")]
		bool Paired { [Bind ("isPaired")] get; }

		/// <summary>Whether the watch app is installed on the paired Apple Watch.</summary>
		[Export ("watchAppInstalled")]
		bool WatchAppInstalled { [Bind ("isWatchAppInstalled")] get; }

		/// <summary>Whether this application's complication is in use on the watch face.</summary>
		[Export ("complicationEnabled")]
		bool ComplicationEnabled { [Bind ("isComplicationEnabled")] get; }

		/// <summary>The directory in which information about the paired Apple Watch is stored.</summary>
		[Export ("watchDirectoryURL")]
		[NullAllowed]
		NSUrl WatchDirectoryUrl { get; }

		/// <summary>Whether the paired device is reachable.</summary>
		[Export ("reachable")]
		bool Reachable { [Bind ("isReachable")] get; }

		[NoiOS]
		[Export ("iOSDeviceNeedsUnlockAfterRebootForReachability")]
		bool iOSDeviceNeedsUnlockAfterRebootForReachability { get; }

		/// <param name="message">The message dictionary to send.</param>
		///         <param name="replyHandler">
		///   <para>The reply handler, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="errorHandler">
		///   <para>The error handler, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Sends the message to the active paired device.</summary>
		[Export ("sendMessage:replyHandler:errorHandler:")]
		void SendMessage (NSDictionary<NSString, NSObject> message, [NullAllowed] WCSessionReplyHandler replyHandler, [NullAllowed] Action<NSError> errorHandler);

		/// <param name="data">The data to send.</param>
		///         <param name="replyHandler">
		///   <para>The reply handler, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="errorHandler">
		///   <para>The error handler, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Sends <paramref name="data" /> to the companion app.</summary>
		[Export ("sendMessageData:replyHandler:errorHandler:")]
		void SendMessage (NSData data, [NullAllowed] WCSessionReplyDataHandler replyHandler, [NullAllowed] Action<NSError> errorHandler);

		/// <summary>The most recent contextual data sent to the companion app.</summary>
		[Export ("applicationContext", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ApplicationContext { get; }

		/// <param name="applicationContext">The context dictionary to update.</param>
		/// <param name="error">Set to the error if the update fails.</param>
		///         <summary>Sends the application context data to the device.</summary>
		/// <returns><see langword="true" /> if the context was updated; otherwise, <see langword="false" />.</returns>
		[Export ("updateApplicationContext:error:")]
		bool UpdateApplicationContext (NSDictionary<NSString, NSObject> applicationContext, out NSError error);

		/// <summary>The most recent data sent from the companion app.</summary>
		[Export ("receivedApplicationContext", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ReceivedApplicationContext { get; }

		/// <param name="userInfo">The user info dictionary to transfer.</param>
		///         <summary>Sends the provided user info to the peer.</summary>
		/// <returns>The user info transfer object.</returns>
		[Export ("transferUserInfo:")]
		WCSessionUserInfoTransfer TransferUserInfo (NSDictionary<NSString, NSObject> userInfo);

		/// <param name="userInfo">The user info dictionary for the complication.</param>
		///         <summary>Sends the complication user info data to the extension.</summary>
		/// <returns>The user info transfer object.</returns>
		[Export ("transferCurrentComplicationUserInfo:")]
		WCSessionUserInfoTransfer TransferCurrentComplicationUserInfo (NSDictionary<NSString, NSObject> userInfo);

		/// <summary>The currently in-progress data transfers.</summary>
		[Export ("outstandingUserInfoTransfers", ArgumentSemantic.Copy)]
		WCSessionUserInfoTransfer [] OutstandingUserInfoTransfers { get; }

		/// <param name="file">The file URL to transfer.</param>
		///         <param name="metadata">
		///   <para>Metadata dictionary, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Sends the file and metadata to the device.</summary>
		/// <returns>The file transfer object.</returns>
		[Export ("transferFile:metadata:")]
		WCSessionFileTransfer TransferFile (NSUrl file, [NullAllowed] NSDictionary<NSString, NSObject> metadata);

		/// <summary>The currently in-progress file transfers.</summary>
		[Export ("outstandingFileTransfers", ArgumentSemantic.Copy)]
		WCSessionFileTransfer [] OutstandingFileTransfers { get; }

		/// <summary>Gets the error domain in which errors are reported.</summary>
		[Field ("WCErrorDomain")]
		NSString ErrorDomain { get; }

		/// <summary>Get the activation state of the session.</summary>
		[Export ("activationState")]
		WCSessionActivationState ActivationState { get; }

		/// <summary>Gets a Boolean value that tells whether there is more content to transfer.</summary>
		[Export ("hasContentPending")]
		bool HasContentPending { get; }

		/// <summary>Gets the number of remaining times that complication data can be sent to the extension.</summary>
		[Export ("remainingComplicationUserInfoTransfers")]
		nuint RemainingComplicationUserInfoTransfers { get; }

		[NoiOS]
		[Export ("companionAppInstalled")]
		bool CompanionAppInstalled { [Bind ("isCompanionAppInstalled")] get; }
	}

	interface IWCSessionDelegate { }

	/// <summary>Delegate object whose methods, when overridden, allow the app developer to respond to messages sent between a WatchKit extension app and it's container app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSessionDelegate_protocol/index.html">Apple documentation for <c>WCSessionDelegate</c></related>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface WCSessionDelegate {
		/// <param name="session">The WCSession.</param>
		///         <summary>A feature has been enabled or disabled.</summary>
		[Export ("sessionWatchStateDidChange:")]
		void SessionWatchStateDidChange (WCSession session);

		/// <param name="session">The WCSession.</param>
		///         <summary>The reachability of the companion device has changed.</summary>
		[Export ("sessionReachabilityDidChange:")]
		void SessionReachabilityDidChange (WCSession session);

		/// <param name="session">The WCSession.</param>
		/// <param name="message">The received message dictionary.</param>
		///         <summary>Method that is called after a message is received.</summary>
		[Export ("session:didReceiveMessage:")]
		void DidReceiveMessage (WCSession session, NSDictionary<NSString, NSObject> message);

		/// <param name="session">The WCSession.</param>
		/// <param name="message">The received message dictionary.</param>
		/// <param name="replyHandler">The handler to call with the reply.</param>
		///         <summary>Method that is called after a message is received.</summary>
		[Export ("session:didReceiveMessage:replyHandler:")]
		void DidReceiveMessage (WCSession session, NSDictionary<NSString, NSObject> message, WCSessionReplyHandler replyHandler);

		/// <param name="session">The WCSession.</param>
		/// <param name="messageData">The received message data.</param>
		///         <summary>An immediate data message was received.</summary>
		[Export ("session:didReceiveMessageData:")]
		void DidReceiveMessageData (WCSession session, NSData messageData);

		/// <param name="session">The WCSession.</param>
		/// <param name="messageData">The received message data.</param>
		/// <param name="replyHandler">The handler to call with the reply data.</param>
		///         <summary>An immediate data message was received and requires a response.</summary>
		[Export ("session:didReceiveMessageData:replyHandler:")]
		void DidReceiveMessageData (WCSession session, NSData messageData, WCSessionReplyDataHandler replyHandler);

		/// <param name="session">The WCSession.</param>
		/// <param name="applicationContext">The received application context.</param>
		///         <summary>Method that is called after an application context is received.</summary>
		[Export ("session:didReceiveApplicationContext:")]
		void DidReceiveApplicationContext (WCSession session, NSDictionary<NSString, NSObject> applicationContext);

		/// <param name="session">The WCSession.</param>
		/// <param name="userInfoTransfer">The transfer that finished.</param>
		///         <param name="error">
		///   <para>The error, or <see langword="null" /> if the transfer succeeded.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>A data transfer finished, either successfully or with an error.</summary>
		[Export ("session:didFinishUserInfoTransfer:error:")]
		void DidFinishUserInfoTransfer (WCSession session, WCSessionUserInfoTransfer userInfoTransfer, [NullAllowed] NSError error);

		/// <param name="session">The WCSession.</param>
		/// <param name="userInfo">The received user info dictionaries.</param>
		///         <summary>Method that is called when a user info dictionary is received.</summary>
		[Export ("session:didReceiveUserInfo:")]
		void DidReceiveUserInfo (WCSession session, NSDictionary<NSString, NSObject> userInfo);

		/// <param name="session">The WCSession.</param>
		/// <param name="fileTransfer">The file transfer that finished.</param>
		/// <param name="error">The error, or <see langword="null" /> if the transfer succeeded.</param>
		///         <summary>A file transfer finished, either successfully or with an error.</summary>
		[Export ("session:didFinishFileTransfer:error:")]
		void DidFinishFileTransfer (WCSession session, WCSessionFileTransfer fileTransfer, [NullAllowed] NSError error);

		/// <param name="session">The WCSession.</param>
		/// <param name="file">The received file.</param>
		///         <summary>A file was received successfully.</summary>
		[Export ("session:didReceiveFile:")]
		void DidReceiveFile (WCSession session, WCSessionFile file);

		/// <param name="session">The WCSession.</param>
		/// <param name="activationState">The activation state.</param>
		///         <param name="error">
		///   <para>The error, or <see langword="null" /> if activation succeeded.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Method that is called when session activation completes.</summary>
		[Abstract] // OS 10 beta 1 SDK made this required
		[Export ("session:activationDidCompleteWithState:error:")]
		void ActivationDidComplete (WCSession session, WCSessionActivationState activationState, [NullAllowed] NSError error);

		/// <param name="session">The WCSession.</param>
		///         <summary>Method that is called when the session becomes inactive.</summary>
		[Abstract] // OS 10 beta 1 SDK made this required
		[Export ("sessionDidBecomeInactive:")]
		void DidBecomeInactive (WCSession session);

		/// <param name="session">The WCSession.</param>
		///         <summary>Method that is called after the session deactivates.</summary>
		[Abstract] // OS 10 beta 1 SDK made this required
		[Export ("sessionDidDeactivate:")]
		void DidDeactivate (WCSession session);

		[NoiOS]
		[Export ("sessionCompanionAppInstalledDidChange:")]
		void CompanionAppInstalledDidChange (WCSession session);
	}

	/// <summary>Holds data relating to a file being transferred between a WatchKit extension app and it's container app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSessionFile_class/index.html">Apple documentation for <c>WCSessionFile</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // no handle, doc: You do not create instances of this class directly.
	interface WCSessionFile {

		/// <summary>The URL to a received file.</summary>
		[Export ("fileURL")]
		NSUrl FileUrl { get; }

		/// <summary>Additional data sent with a received file.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Metadata { get; }
	}

	/// <summary>Represents an ongoing file transfer between a WatchKit extension app and it's container app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSessionFileTransfer_class/index.html">Apple documentation for <c>WCSessionFileTransfer</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // no handle, doc: You do not create instances of this class yourself.
	interface WCSessionFileTransfer {

		/// <summary>The file being transferred.</summary>
		[Export ("file")]
		WCSessionFile File { get; }

		/// <summary>Gets a Boolean value the tells whether the transfer is currently happening.</summary>
		///         <value>A Boolean value the tells whether the transfer is currently happening.</value>
		[Export ("transferring")]
		bool Transferring { [Bind ("isTransferring")] get; }

		/// <summary>Cancels the file transfer.</summary>
		[Export ("cancel")]
		void Cancel ();

		/// <summary>Gets the progress indicator for the file transfer.</summary>
		///         <value>The progress indicator for the file transfer.</value>
		[Export ("progress")]
		NSProgress Progress { get; }
	}

	/// <summary>Represents an ongoing data transfer between a WatchKit extension app and it's container app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSessionUserInfoTransfer_class/index.html">Apple documentation for <c>WCSessionUserInfoTransfer</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // no handle, doc: You do not create instances of this class yourself.
	interface WCSessionUserInfoTransfer : NSSecureCoding {

		/// <summary>Whether the data being transferred relates to a complication.</summary>
		[Export ("currentComplicationInfo")]
		bool CurrentComplicationInfo { [Bind ("isCurrentComplicationInfo")] get; }

		/// <summary>The data being transferred.</summary>
		[Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		/// <summary>Whether the transfer is currently happening.</summary>
		[Export ("transferring")]
		bool Transferring { [Bind ("isTransferring")] get; }

		/// <summary>Cancels the data transfer.</summary>
		[Export ("cancel")]
		void Cancel ();
	}

}
