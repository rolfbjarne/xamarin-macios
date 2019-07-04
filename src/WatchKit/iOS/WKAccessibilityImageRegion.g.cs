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
	[Register("WKAccessibilityImageRegion", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKAccessibilityImageRegion : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKAccessibilityImageRegion");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WKAccessibilityImageRegion () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKAccessibilityImageRegion (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKAccessibilityImageRegion (IntPtr handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Frame {
			[Export ("frame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("frame"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frame"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frame"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frame"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frame"));
					}
				}
				return ret;
			}
			
			[Export ("setFrame:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setFrame:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("setFrame:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Label {
			[Export ("label")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("label")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("label")));
				}
			}
			
			[Export ("setLabel:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabel:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class WKAccessibilityImageRegion */
}
