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
	[Register("WKInterfaceController", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe abstract partial class WKInterfaceController : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceController (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceController (IntPtr handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKInterfaceController ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("init")), "init");
			}
		}
		
		[Export ("addMenuItemWithImage:title:action:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMenuItem (global::UIKit.UIImage image, string title, Selector action)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (title == null)
				throw new ArgumentNullException ("title");
			if (action == null)
				throw new ArgumentNullException ("action");
			var nstitle = NSString.CreateNative (title);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addMenuItemWithImage:title:action:"), image.Handle, nstitle, action.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addMenuItemWithImage:title:action:"), image.Handle, nstitle, action.Handle);
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("addMenuItemWithImageNamed:title:action:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMenuItem (string imageName, string title, Selector action)
		{
			if (imageName == null)
				throw new ArgumentNullException ("imageName");
			if (title == null)
				throw new ArgumentNullException ("title");
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsimageName = NSString.CreateNative (imageName);
			var nstitle = NSString.CreateNative (title);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addMenuItemWithImageNamed:title:action:"), nsimageName, nstitle, action.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addMenuItemWithImageNamed:title:action:"), nsimageName, nstitle, action.Handle);
			}
			NSString.ReleaseNative (nsimageName);
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("addMenuItemWithItemIcon:title:action:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMenuItem (WKMenuItemIcon itemIcon, string title, Selector action)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (action == null)
				throw new ArgumentNullException ("action");
			var nstitle = NSString.CreateNative (title);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addMenuItemWithItemIcon:title:action:"), (Int64)itemIcon, nstitle, action.Handle);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addMenuItemWithItemIcon:title:action:"), (int)itemIcon, nstitle, action.Handle);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addMenuItemWithItemIcon:title:action:"), (Int64)itemIcon, nstitle, action.Handle);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addMenuItemWithItemIcon:title:action:"), (int)itemIcon, nstitle, action.Handle);
				}
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("awakeWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Awake (NSObject context)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("awakeWithContext:"), context == null ? IntPtr.Zero : context.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("awakeWithContext:"), context == null ? IntPtr.Zero : context.Handle);
			}
		}
		
		[Export ("becomeCurrentPage")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BecomeCurrentPage ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("becomeCurrentPage"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("becomeCurrentPage"));
			}
		}
		
		[Export ("clearAllMenuItems")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearAllMenuItems ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearAllMenuItems"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearAllMenuItems"));
			}
		}
		
		[Export ("didDeactivate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didDeactivate"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didDeactivate"));
			}
		}
		
		[Export ("table:didSelectRowAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectRow (WKInterfaceTable table, nint rowIndex)
		{
			if (table == null)
				throw new ArgumentNullException ("table");
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("table:didSelectRowAtIndex:"), table.Handle, rowIndex);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("table:didSelectRowAtIndex:"), table.Handle, rowIndex);
			}
		}
		
		[Export ("dismissController")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissController ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dismissController"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dismissController"));
			}
		}
		
		[Export ("dismissTextInputController")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissTextInputController ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dismissTextInputController"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dismissTextInputController"));
			}
		}
		
		[Export ("contextForSegueWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetContextForSegue (string segueIdentifier)
		{
			if (segueIdentifier == null)
				throw new ArgumentNullException ("segueIdentifier");
			var nssegueIdentifier = NSString.CreateNative (segueIdentifier);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("contextForSegueWithIdentifier:"), nssegueIdentifier));
			} else {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("contextForSegueWithIdentifier:"), nssegueIdentifier));
			}
			NSString.ReleaseNative (nssegueIdentifier);
			
			return ret;
		}
		
		[Export ("contextForSegueWithIdentifier:inTable:rowIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetContextForSegue (string segueIdentifier, WKInterfaceTable table, nint rowIndex)
		{
			if (segueIdentifier == null)
				throw new ArgumentNullException ("segueIdentifier");
			if (table == null)
				throw new ArgumentNullException ("table");
			var nssegueIdentifier = NSString.CreateNative (segueIdentifier);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint (this.Handle, Selector.GetHandle ("contextForSegueWithIdentifier:inTable:rowIndex:"), nssegueIdentifier, table.Handle, rowIndex));
			} else {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("contextForSegueWithIdentifier:inTable:rowIndex:"), nssegueIdentifier, table.Handle, rowIndex));
			}
			NSString.ReleaseNative (nssegueIdentifier);
			
			return ret;
		}
		
		[Export ("contextsForSegueWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GetContextsForSegue (string segueIdentifier)
		{
			if (segueIdentifier == null)
				throw new ArgumentNullException ("segueIdentifier");
			var nssegueIdentifier = NSString.CreateNative (segueIdentifier);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("contextsForSegueWithIdentifier:"), nssegueIdentifier));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("contextsForSegueWithIdentifier:"), nssegueIdentifier));
			}
			NSString.ReleaseNative (nssegueIdentifier);
			
			return ret;
		}
		
		[Export ("contextsForSegueWithIdentifier:inTable:rowIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GetContextsForSegue (string segueIdentifier, WKInterfaceTable table, nint rowIndex)
		{
			if (segueIdentifier == null)
				throw new ArgumentNullException ("segueIdentifier");
			if (table == null)
				throw new ArgumentNullException ("table");
			var nssegueIdentifier = NSString.CreateNative (segueIdentifier);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint (this.Handle, Selector.GetHandle ("contextsForSegueWithIdentifier:inTable:rowIndex:"), nssegueIdentifier, table.Handle, rowIndex));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("contextsForSegueWithIdentifier:inTable:rowIndex:"), nssegueIdentifier, table.Handle, rowIndex));
			}
			NSString.ReleaseNative (nssegueIdentifier);
			
			return ret;
		}
		
		[Export ("handleActionWithIdentifier:forNotification:")]
		[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleAction (string identifier, global::UserNotifications.UNNotification notification)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			var nsidentifier = NSString.CreateNative (identifier);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleActionWithIdentifier:forNotification:"), nsidentifier, notification.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleActionWithIdentifier:forNotification:"), nsidentifier, notification.Handle);
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("handleActionWithIdentifier:forLocalNotification:")]
		[Deprecated (PlatformName.iOS, 10,0, message: "Use 'UNUserNotificationCenterDelegate' instead.")]
		[Deprecated (PlatformName.WatchOS, 3,0, message: "Use 'UNUserNotificationCenterDelegate' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleLocalNotificationAction (string identifier, global::UIKit.UILocalNotification localNotification)
		{
			if (localNotification == null)
				throw new ArgumentNullException ("localNotification");
			var nsidentifier = NSString.CreateNative (identifier);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleActionWithIdentifier:forLocalNotification:"), nsidentifier, localNotification.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleActionWithIdentifier:forLocalNotification:"), nsidentifier, localNotification.Handle);
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("handleActionWithIdentifier:forRemoteNotification:")]
		[Deprecated (PlatformName.iOS, 10,0, message: "Use 'UNUserNotificationCenterDelegate' instead.")]
		[Deprecated (PlatformName.WatchOS, 3,0, message: "Use 'UNUserNotificationCenterDelegate' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleRemoteNotificationAction (string identifier, NSDictionary remoteNotification)
		{
			if (remoteNotification == null)
				throw new ArgumentNullException ("remoteNotification");
			var nsidentifier = NSString.CreateNative (identifier);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleActionWithIdentifier:forRemoteNotification:"), nsidentifier, remoteNotification.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleActionWithIdentifier:forRemoteNotification:"), nsidentifier, remoteNotification.Handle);
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("handleUserActivity:")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'WKExtensionDelegate.HandleUserActivity' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleUserActivity (NSDictionary userActivity)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handleUserActivity:"), userActivity == null ? IntPtr.Zero : userActivity.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handleUserActivity:"), userActivity == null ? IntPtr.Zero : userActivity.Handle);
			}
		}
		
		[Export ("invalidateUserActivity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateUserActivity ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidateUserActivity"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("invalidateUserActivity"));
			}
		}
		
		[Export ("openParentApplication:reply:")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool OpenParentApplication (NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V69))]global::System.Action<NSDictionary, NSError> reply)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			BlockLiteral *block_ptr_reply;
			BlockLiteral block_reply;
			if (reply == null){
				block_ptr_reply = null;
			} else {
				block_reply = new BlockLiteral ();
				block_ptr_reply = &block_reply;
				block_reply.SetupBlockUnsafe (Trampolines.SDActionArity2V69.Handler, reply);
			}
			
			bool ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("openParentApplication:reply:"), userInfo.Handle, (IntPtr) block_ptr_reply);
			if (block_ptr_reply != null)
				block_ptr_reply->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("popController")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopController ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popController"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popController"));
			}
		}
		
		[Export ("popToRootController")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopToRootController ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popToRootController"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popToRootController"));
			}
		}
		
		[Export ("presentControllerWithName:context:")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentController (string name, NSObject context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentControllerWithName:context:"), nsname, context == null ? IntPtr.Zero : context.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentControllerWithName:context:"), nsname, context == null ? IntPtr.Zero : context.Handle);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("presentControllerWithNames:contexts:")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentController (string[] names, NSObject[] contexts)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (names == null)
				throw new ArgumentNullException ("names");
			var nsa_names = NSArray.FromStrings (names);
			var nsa_contexts = contexts == null ? null : NSArray.FromNSObjects (contexts);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentControllerWithNames:contexts:"), nsa_names.Handle, nsa_contexts == null ? IntPtr.Zero : nsa_contexts.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentControllerWithNames:contexts:"), nsa_names.Handle, nsa_contexts == null ? IntPtr.Zero : nsa_contexts.Handle);
			}
			nsa_names.Dispose ();
			if (nsa_contexts != null)
				nsa_contexts.Dispose ();
			
		}
		
		[Export ("presentTextInputControllerWithSuggestions:allowedInputMode:completion:")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentTextInputController (string[] suggestions, WKTextInputMode inputMode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V208))]global::System.Action<NSArray> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsa_suggestions = suggestions == null ? null : NSArray.FromStrings (suggestions);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V208.Handler, completion);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr (this.Handle, Selector.GetHandle ("presentTextInputControllerWithSuggestions:allowedInputMode:completion:"), nsa_suggestions == null ? IntPtr.Zero : nsa_suggestions.Handle, (Int64)inputMode, (IntPtr) block_ptr_completion);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (this.Handle, Selector.GetHandle ("presentTextInputControllerWithSuggestions:allowedInputMode:completion:"), nsa_suggestions == null ? IntPtr.Zero : nsa_suggestions.Handle, (int)inputMode, (IntPtr) block_ptr_completion);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr (this.SuperHandle, Selector.GetHandle ("presentTextInputControllerWithSuggestions:allowedInputMode:completion:"), nsa_suggestions == null ? IntPtr.Zero : nsa_suggestions.Handle, (Int64)inputMode, (IntPtr) block_ptr_completion);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, Selector.GetHandle ("presentTextInputControllerWithSuggestions:allowedInputMode:completion:"), nsa_suggestions == null ? IntPtr.Zero : nsa_suggestions.Handle, (int)inputMode, (IntPtr) block_ptr_completion);
				}
			}
			if (nsa_suggestions != null)
				nsa_suggestions.Dispose ();
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray> PresentTextInputControllerAsync (string[] suggestions, WKTextInputMode inputMode)
		{
			var tcs = new TaskCompletionSource<NSArray> ();
			PresentTextInputController(suggestions, inputMode, (obj_) => {
				tcs.SetResult (obj_);
			});
			return tcs.Task;
		}
		
		[Export ("presentTextInputControllerWithSuggestionsForLanguage:allowedInputMode:completion:")]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentTextInputController ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V8))]global::System.Func<NSString, NSArray> suggestionsHandler, WKTextInputMode inputMode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V208))]global::System.Action<NSArray> completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_suggestionsHandler;
			BlockLiteral block_suggestionsHandler;
			if (suggestionsHandler == null){
				block_ptr_suggestionsHandler = null;
			} else {
				block_suggestionsHandler = new BlockLiteral ();
				block_ptr_suggestionsHandler = &block_suggestionsHandler;
				block_suggestionsHandler.SetupBlockUnsafe (Trampolines.SDFuncArity2V8.Handler, suggestionsHandler);
			}
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V208.Handler, completion);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr (this.Handle, Selector.GetHandle ("presentTextInputControllerWithSuggestionsForLanguage:allowedInputMode:completion:"), (IntPtr) block_ptr_suggestionsHandler, (Int64)inputMode, (IntPtr) block_ptr_completion);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (this.Handle, Selector.GetHandle ("presentTextInputControllerWithSuggestionsForLanguage:allowedInputMode:completion:"), (IntPtr) block_ptr_suggestionsHandler, (int)inputMode, (IntPtr) block_ptr_completion);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr (this.SuperHandle, Selector.GetHandle ("presentTextInputControllerWithSuggestionsForLanguage:allowedInputMode:completion:"), (IntPtr) block_ptr_suggestionsHandler, (Int64)inputMode, (IntPtr) block_ptr_completion);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, Selector.GetHandle ("presentTextInputControllerWithSuggestionsForLanguage:allowedInputMode:completion:"), (IntPtr) block_ptr_suggestionsHandler, (int)inputMode, (IntPtr) block_ptr_completion);
				}
			}
			if (block_ptr_suggestionsHandler != null)
				block_ptr_suggestionsHandler->CleanupBlock ();
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray> PresentTextInputControllerAsync ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V8))]global::System.Func<NSString, NSArray> suggestionsHandler, WKTextInputMode inputMode)
		{
			var tcs = new TaskCompletionSource<NSArray> ();
			PresentTextInputController(suggestionsHandler, inputMode, (obj_) => {
				tcs.SetResult (obj_);
			});
			return tcs.Task;
		}
		
		[Export ("pushControllerWithName:context:")]
		[ThreadSafe (false)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushController (string name, NSObject context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("pushControllerWithName:context:"), nsname, context == null ? IntPtr.Zero : context.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("pushControllerWithName:context:"), nsname, context == null ? IntPtr.Zero : context.Handle);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("reloadRootControllersWithNames:contexts:")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'ReloadRootPageControllers' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReloadRootControllers (string[] names, NSObject[] contexts)
		{
			if (names == null)
				throw new ArgumentNullException ("names");
			var nsa_names = NSArray.FromStrings (names);
			var nsa_contexts = contexts == null ? null : NSArray.FromNSObjects (contexts);
			
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("reloadRootControllersWithNames:contexts:"), nsa_names.Handle, nsa_contexts == null ? IntPtr.Zero : nsa_contexts.Handle);
			nsa_names.Dispose ();
			if (nsa_contexts != null)
				nsa_contexts.Dispose ();
			
		}
		
		[Export ("setTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitle (string title)
		{
			var nstitle = NSString.CreateNative (title);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitle:"), nstitle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitle:"), nstitle);
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("updateUserActivity:userInfo:webpageURL:")]
		[Deprecated (PlatformName.WatchOS, 5,0, message: "Use 'UpdateUserActivity(NSUserActivity)' instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateUserActivity (string type, NSDictionary userInfo, NSUrl webpageURL)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			var nstype = NSString.CreateNative (type);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateUserActivity:userInfo:webpageURL:"), nstype, userInfo == null ? IntPtr.Zero : userInfo.Handle, webpageURL == null ? IntPtr.Zero : webpageURL.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateUserActivity:userInfo:webpageURL:"), nstype, userInfo == null ? IntPtr.Zero : userInfo.Handle, webpageURL == null ? IntPtr.Zero : webpageURL.Handle);
			}
			NSString.ReleaseNative (nstype);
			
		}
		
		[Export ("willActivate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillActivate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willActivate"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willActivate"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ContentFrame {
			[Export ("contentFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("contentFrame"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentFrame"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentFrame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentFrame"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentFrame"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentFrame"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ErrorDomain;
		[Field ("WatchKitErrorDomain",  "WatchKit")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain == null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "WatchKitErrorDomain");
				return _ErrorDomain;
			}
		}
	} /* class WKInterfaceController */
}
