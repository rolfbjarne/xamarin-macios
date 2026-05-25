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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace WatchConnectivity {
	#pragma warning disable CS1573
	/// <summary>Delegate object whose methods, when overridden, allow the app developer to respond to messages sent between a WatchKit extension app and it's container app.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSessionDelegate_protocol/index.html">Apple documentation for <c>WCSessionDelegate</c></related>
	[Protocol (Name = "WCSessionDelegate", WrapperType = typeof (WCSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionWatchStateDidChange", Selector = "sessionWatchStateDidChange:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionReachabilityDidChange", Selector = "sessionReachabilityDidChange:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessage", Selector = "session:didReceiveMessage:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessage", Selector = "session:didReceiveMessage:replyHandler:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (WatchConnectivity.WCSessionReplyHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessageData", Selector = "session:didReceiveMessageData:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessageData", Selector = "session:didReceiveMessageData:replyHandler:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (NSData), typeof (WatchConnectivity.WCSessionReplyDataHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyDataHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveApplicationContext", Selector = "session:didReceiveApplicationContext:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishUserInfoTransfer", Selector = "session:didFinishUserInfoTransfer:error:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (WatchConnectivity.WCSessionUserInfoTransfer), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveUserInfo", Selector = "session:didReceiveUserInfo:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishFileTransfer", Selector = "session:didFinishFileTransfer:error:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (WatchConnectivity.WCSessionFileTransfer), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveFile", Selector = "session:didReceiveFile:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (WatchConnectivity.WCSessionFile) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ActivationDidComplete", Selector = "session:activationDidCompleteWithState:error:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession), typeof (WatchConnectivity.WCSessionActivationState), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidBecomeInactive", Selector = "sessionDidBecomeInactive:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDeactivate", Selector = "sessionDidDeactivate:", ParameterType = new Type [] { typeof (WatchConnectivity.WCSession) }, ParameterByRef = new bool [] { false })]
	public partial interface IWCSessionDelegate : INativeObject, IDisposable
	{
		/// <param name="session">To be added.</param><summary>A feature has been enabled or disabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sessionWatchStateDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWatchStateDidChange (WCSession session)
		{
			_SessionWatchStateDidChange (this, session);
		}
		/// <param name="session">To be added.</param><summary>A feature has been enabled or disabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionWatchStateDidChange (IWCSessionDelegate This, WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionWatchStateDidChange:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">To be added.</param><summary>The reachability of the companion device has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sessionReachabilityDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionReachabilityDidChange (WCSession session)
		{
			_SessionReachabilityDidChange (this, session);
		}
		/// <param name="session">To be added.</param><summary>The reachability of the companion device has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionReachabilityDidChange (IWCSessionDelegate This, WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionReachabilityDidChange:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMessage (WCSession session, NSDictionary<NSString, NSObject> message)
		{
			_DidReceiveMessage (this, session, message);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveMessage (IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> message)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessage:"), session__handle__, message__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (message);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="replyHandler">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveMessage:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveMessage (WCSession session, NSDictionary<NSString, NSObject> message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyHandler))]WCSessionReplyHandler replyHandler)
		{
			_DidReceiveMessage (this, session, message, replyHandler);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="replyHandler">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveMessage (IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyHandler))]WCSessionReplyHandler replyHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDWCSessionReplyHandler.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessage:replyHandler:"), session__handle__, message__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (message);
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><summary>An immediate data message was received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveMessageData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMessageData (WCSession session, NSData messageData)
		{
			_DidReceiveMessageData (this, session, messageData);
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><summary>An immediate data message was received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveMessageData (IWCSessionDelegate This, WCSession session, NSData messageData)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var messageData__handle__ = messageData!.GetNonNullHandle (nameof (messageData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessageData:"), session__handle__, messageData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (messageData);
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><param name="replyHandler">To be added.</param><summary>An immediate data message was received and requires a response.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveMessageData:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveMessageData (WCSession session, NSData messageData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyDataHandler))]WCSessionReplyDataHandler replyHandler)
		{
			_DidReceiveMessageData (this, session, messageData, replyHandler);
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><param name="replyHandler">To be added.</param><summary>An immediate data message was received and requires a response.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveMessageData (IWCSessionDelegate This, WCSession session, NSData messageData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyDataHandler))]WCSessionReplyDataHandler replyHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var messageData__handle__ = messageData!.GetNonNullHandle (nameof (messageData));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDWCSessionReplyDataHandler.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessageData:replyHandler:"), session__handle__, messageData__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (messageData);
		}
		/// <param name="session">To be added.</param><param name="applicationContext">To be added.</param><summary>Method that is called after an application context is received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveApplicationContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveApplicationContext (WCSession session, NSDictionary<NSString, NSObject> applicationContext)
		{
			_DidReceiveApplicationContext (this, session, applicationContext);
		}
		/// <param name="session">To be added.</param><param name="applicationContext">To be added.</param><summary>Method that is called after an application context is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveApplicationContext (IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> applicationContext)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var applicationContext__handle__ = applicationContext!.GetNonNullHandle (nameof (applicationContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveApplicationContext:"), session__handle__, applicationContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (applicationContext);
		}
		/// <param name="session">To be added.</param><param name="userInfoTransfer">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>A data transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didFinishUserInfoTransfer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishUserInfoTransfer (WCSession session, WCSessionUserInfoTransfer userInfoTransfer, NSError? error)
		{
			_DidFinishUserInfoTransfer (this, session, userInfoTransfer, error);
		}
		/// <param name="session">To be added.</param><param name="userInfoTransfer">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>A data transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishUserInfoTransfer (IWCSessionDelegate This, WCSession session, WCSessionUserInfoTransfer userInfoTransfer, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var userInfoTransfer__handle__ = userInfoTransfer!.GetNonNullHandle (nameof (userInfoTransfer));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFinishUserInfoTransfer:error:"), session__handle__, userInfoTransfer__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (userInfoTransfer);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><param name="userInfo">To be added.</param><summary>Method that is called when a user info dictionary is received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveUserInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveUserInfo (WCSession session, NSDictionary<NSString, NSObject> userInfo)
		{
			_DidReceiveUserInfo (this, session, userInfo);
		}
		/// <param name="session">To be added.</param><param name="userInfo">To be added.</param><summary>Method that is called when a user info dictionary is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveUserInfo (IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> userInfo)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveUserInfo:"), session__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (userInfo);
		}
		/// <param name="session">To be added.</param><param name="fileTransfer">To be added.</param><param name="error">To be added.</param><summary>A file transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didFinishFileTransfer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishFileTransfer (WCSession session, WCSessionFileTransfer fileTransfer, NSError? error)
		{
			_DidFinishFileTransfer (this, session, fileTransfer, error);
		}
		/// <param name="session">To be added.</param><param name="fileTransfer">To be added.</param><param name="error">To be added.</param><summary>A file transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishFileTransfer (IWCSessionDelegate This, WCSession session, WCSessionFileTransfer fileTransfer, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var fileTransfer__handle__ = fileTransfer!.GetNonNullHandle (nameof (fileTransfer));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFinishFileTransfer:error:"), session__handle__, fileTransfer__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (fileTransfer);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><param name="file">To be added.</param><summary>A file was received successfully.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveFile (WCSession session, WCSessionFile file)
		{
			_DidReceiveFile (this, session, file);
		}
		/// <param name="session">To be added.</param><param name="file">To be added.</param><summary>A file was received successfully.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveFile (IWCSessionDelegate This, WCSession session, WCSessionFile file)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveFile:"), session__handle__, file__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (file);
		}
		/// <param name="session">To be added.</param><param name="activationState">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when session activation completes.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("session:activationDidCompleteWithState:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ActivationDidComplete (WCSession session, WCSessionActivationState activationState, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="activationState">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when session activation completes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ActivationDidComplete (IWCSessionDelegate This, WCSession session, WCSessionActivationState activationState, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("session:activationDidCompleteWithState:error:"), session__handle__, (IntPtr) (long) activationState, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><summary>Method that is called when the session becomes inactive.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("sessionDidBecomeInactive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeInactive (WCSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>Method that is called when the session becomes inactive.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeInactive (IWCSessionDelegate This, WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionDidBecomeInactive:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">To be added.</param><summary>Method that is called after the session deactivates.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("sessionDidDeactivate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivate (WCSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>Method that is called after the session deactivates.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDeactivate (IWCSessionDelegate This, WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionDidDeactivate:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[DynamicDependencyAttribute ("ActivationDidComplete(WatchConnectivity.WCSession,WatchConnectivity.WCSessionActivationState,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidBecomeInactive(WatchConnectivity.WCSession)")]
		[DynamicDependencyAttribute ("DidDeactivate(WatchConnectivity.WCSession)")]
		[DynamicDependencyAttribute ("DidFinishFileTransfer(WatchConnectivity.WCSession,WatchConnectivity.WCSessionFileTransfer,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishUserInfoTransfer(WatchConnectivity.WCSession,WatchConnectivity.WCSessionUserInfoTransfer,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveApplicationContext(WatchConnectivity.WCSession,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("DidReceiveFile(WatchConnectivity.WCSession,WatchConnectivity.WCSessionFile)")]
		[DynamicDependencyAttribute ("DidReceiveMessage(WatchConnectivity.WCSession,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},WatchConnectivity.WCSessionReplyHandler)")]
		[DynamicDependencyAttribute ("DidReceiveMessage(WatchConnectivity.WCSession,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("DidReceiveMessageData(WatchConnectivity.WCSession,Foundation.NSData,WatchConnectivity.WCSessionReplyDataHandler)")]
		[DynamicDependencyAttribute ("DidReceiveMessageData(WatchConnectivity.WCSession,Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidReceiveUserInfo(WatchConnectivity.WCSession,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("SessionReachabilityDidChange(WatchConnectivity.WCSession)")]
		[DynamicDependencyAttribute ("SessionWatchStateDidChange(WatchConnectivity.WCSession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WCSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWCSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWCSessionDelegate" /> interface to support all the methods from the WCSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWCSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WCSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WCSessionDelegate_Extensions {
		/// <param name="session">To be added.</param><summary>A feature has been enabled or disabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionWatchStateDidChange (this IWCSessionDelegate This, WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionWatchStateDidChange:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">To be added.</param><summary>The reachability of the companion device has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionReachabilityDidChange (this IWCSessionDelegate This, WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionReachabilityDidChange:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveMessage (this IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> message)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessage:"), session__handle__, message__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (message);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="replyHandler">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveMessage (this IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyHandler))]WCSessionReplyHandler replyHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDWCSessionReplyHandler.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessage:replyHandler:"), session__handle__, message__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (message);
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><summary>An immediate data message was received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveMessageData (this IWCSessionDelegate This, WCSession session, NSData messageData)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var messageData__handle__ = messageData!.GetNonNullHandle (nameof (messageData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessageData:"), session__handle__, messageData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (messageData);
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><param name="replyHandler">To be added.</param><summary>An immediate data message was received and requires a response.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveMessageData (this IWCSessionDelegate This, WCSession session, NSData messageData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyDataHandler))]WCSessionReplyDataHandler replyHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var messageData__handle__ = messageData!.GetNonNullHandle (nameof (messageData));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDWCSessionReplyDataHandler.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessageData:replyHandler:"), session__handle__, messageData__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (messageData);
		}
		/// <param name="session">To be added.</param><param name="applicationContext">To be added.</param><summary>Method that is called after an application context is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveApplicationContext (this IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> applicationContext)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var applicationContext__handle__ = applicationContext!.GetNonNullHandle (nameof (applicationContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveApplicationContext:"), session__handle__, applicationContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (applicationContext);
		}
		/// <param name="session">To be added.</param><param name="userInfoTransfer">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>A data transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishUserInfoTransfer (this IWCSessionDelegate This, WCSession session, WCSessionUserInfoTransfer userInfoTransfer, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var userInfoTransfer__handle__ = userInfoTransfer!.GetNonNullHandle (nameof (userInfoTransfer));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFinishUserInfoTransfer:error:"), session__handle__, userInfoTransfer__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (userInfoTransfer);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><param name="userInfo">To be added.</param><summary>Method that is called when a user info dictionary is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveUserInfo (this IWCSessionDelegate This, WCSession session, NSDictionary<NSString, NSObject> userInfo)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveUserInfo:"), session__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (userInfo);
		}
		/// <param name="session">To be added.</param><param name="fileTransfer">To be added.</param><param name="error">To be added.</param><summary>A file transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishFileTransfer (this IWCSessionDelegate This, WCSession session, WCSessionFileTransfer fileTransfer, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var fileTransfer__handle__ = fileTransfer!.GetNonNullHandle (nameof (fileTransfer));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFinishFileTransfer:error:"), session__handle__, fileTransfer__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (fileTransfer);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><param name="file">To be added.</param><summary>A file was received successfully.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveFile (this IWCSessionDelegate This, WCSession session, WCSessionFile file)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveFile:"), session__handle__, file__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (file);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WCSessionDelegateWrapper : BaseWrapper, IWCSessionDelegate {
		public WCSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WCSessionDelegateWrapper))]
		static WCSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="session">To be added.</param><param name="activationState">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when session activation completes.</summary><remarks>To be added.</remarks>
		[Export ("session:activationDidCompleteWithState:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ActivationDidComplete (WCSession session, WCSessionActivationState activationState, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("session:activationDidCompleteWithState:error:"), session__handle__, (IntPtr) (long) activationState, error__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><summary>Method that is called when the session becomes inactive.</summary><remarks>To be added.</remarks>
		[Export ("sessionDidBecomeInactive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidBecomeInactive (WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("sessionDidBecomeInactive:"), session__handle__);
			GC.KeepAlive (session);
		}
		/// <param name="session">To be added.</param><summary>Method that is called after the session deactivates.</summary><remarks>To be added.</remarks>
		[Export ("sessionDidDeactivate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDeactivate (WCSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("sessionDidDeactivate:"), session__handle__);
			GC.KeepAlive (session);
		}
	}
}
namespace WatchConnectivity {
	/// <summary>Delegate object whose methods, when overridden, allow the app developer to respond to messages sent between a WatchKit extension app and it's container app.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WatchConnectivity/Reference/WCSessionDelegate_protocol/index.html">Apple documentation for <c>WCSessionDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__WatchConnectivity_WCSessionDelegate", false)]
	[Model]
	public unsafe abstract partial class WCSessionDelegate : NSObject, IWCSessionDelegate {
		/// <summary>Creates a new <see cref="WCSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WCSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected WCSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal WCSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="activationState">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when session activation completes.</summary><remarks>To be added.</remarks>
		[Export ("session:activationDidCompleteWithState:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ActivationDidComplete (WCSession session, WCSessionActivationState activationState, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>Method that is called when the session becomes inactive.</summary><remarks>To be added.</remarks>
		[Export ("sessionDidBecomeInactive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeInactive (WCSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>Method that is called after the session deactivates.</summary><remarks>To be added.</remarks>
		[Export ("sessionDidDeactivate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivate (WCSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="fileTransfer">To be added.</param><param name="error">To be added.</param><summary>A file transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[Export ("session:didFinishFileTransfer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishFileTransfer (WCSession session, WCSessionFileTransfer fileTransfer, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="userInfoTransfer">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>A data transfer finished, either successfully or with an error.</summary><remarks>To be added.</remarks>
		[Export ("session:didFinishUserInfoTransfer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishUserInfoTransfer (WCSession session, WCSessionUserInfoTransfer userInfoTransfer, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="applicationContext">To be added.</param><summary>Method that is called after an application context is received.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveApplicationContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveApplicationContext (WCSession session, NSDictionary<NSString, NSObject> applicationContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="file">To be added.</param><summary>A file was received successfully.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveFile (WCSession session, WCSessionFile file)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMessage (WCSession session, NSDictionary<NSString, NSObject> message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="replyHandler">To be added.</param><summary>Method that is called after a message is received.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveMessage:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveMessage (WCSession session, NSDictionary<NSString, NSObject> message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyHandler))]WCSessionReplyHandler replyHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><summary>An immediate data message was received.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveMessageData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMessageData (WCSession session, NSData messageData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="messageData">To be added.</param><param name="replyHandler">To be added.</param><summary>An immediate data message was received and requires a response.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveMessageData:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveMessageData (WCSession session, NSData messageData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWCSessionReplyDataHandler))]WCSessionReplyDataHandler replyHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="userInfo">To be added.</param><summary>Method that is called when a user info dictionary is received.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveUserInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveUserInfo (WCSession session, NSDictionary<NSString, NSObject> userInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>The reachability of the companion device has changed.</summary><remarks>To be added.</remarks>
		[Export ("sessionReachabilityDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionReachabilityDidChange (WCSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>A feature has been enabled or disabled.</summary><remarks>To be added.</remarks>
		[Export ("sessionWatchStateDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWatchStateDidChange (WCSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WCSessionDelegate */
}
