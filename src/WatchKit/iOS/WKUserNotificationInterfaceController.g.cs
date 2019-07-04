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
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
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

namespace WatchKit {
	[Register("WKUserNotificationInterfaceController", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKUserNotificationInterfaceController : WKInterfaceController {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKUserNotificationInterfaceController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKUserNotificationInterfaceController (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKUserNotificationInterfaceController (IntPtr handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKUserNotificationInterfaceController ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("init")), "init");
			}
		}
		
		[Export ("didReceiveLocalNotification:withCompletion:")]
		[Deprecated (PlatformName.iOS, 10,0, message: "Use 'DidReceiveNotification' instead.")]
		[Deprecated (PlatformName.WatchOS, 3,0, message: "Use 'DidReceiveNotification' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveLocalNotification (global::UIKit.UILocalNotification localNotification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V209))]global::System.Action<WKUserNotificationInterfaceType> completionHandler)
		{
			if (localNotification == null)
				throw new ArgumentNullException ("localNotification");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V209.Handler, completionHandler);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didReceiveLocalNotification:withCompletion:"), localNotification.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceiveLocalNotification:withCompletion:"), localNotification.Handle, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("didReceiveNotification:withCompletion:")]
		[Deprecated (PlatformName.WatchOS, 5,0, message: "Use 'DidReceiveNotification(UNNotification)' instead.")]
		[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveNotification (global::UserNotifications.UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V209))]global::System.Action<WKUserNotificationInterfaceType> completionHandler)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V209.Handler, completionHandler);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didReceiveNotification:withCompletion:"), notification.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceiveNotification:withCompletion:"), notification.Handle, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("didReceiveRemoteNotification:withCompletion:")]
		[Deprecated (PlatformName.iOS, 10,0, message: "Use 'DidReceiveNotification' instead.")]
		[Deprecated (PlatformName.WatchOS, 3,0, message: "Use 'DidReceiveNotification' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveRemoteNotification (NSDictionary remoteNotification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V209))]global::System.Action<WKUserNotificationInterfaceType> completionHandler)
		{
			if (remoteNotification == null)
				throw new ArgumentNullException ("remoteNotification");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V209.Handler, completionHandler);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didReceiveRemoteNotification:withCompletion:"), remoteNotification.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceiveRemoteNotification:withCompletion:"), remoteNotification.Handle, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("dismissController")]
		[Deprecated (PlatformName.WatchOS, 5,0, message: "Use 'PerformDismissAction' instead.")]
		[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissController ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dismissController"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dismissController"));
			}
		}
		
	} /* class WKUserNotificationInterfaceController */
}
