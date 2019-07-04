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
	[Register("WKInterfaceButton", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceButton : WKInterfaceObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceButton (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceButton (IntPtr handle) : base (handle)
		{
		}

		[Export ("setBackgroundColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundColor (global::UIKit.UIColor color)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundColor:"), color == null ? IntPtr.Zero : color.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundColor:"), color == null ? IntPtr.Zero : color.Handle);
			}
		}
		
		[Export ("setBackgroundImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (global::UIKit.UIImage image)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:"), image == null ? IntPtr.Zero : image.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundImage:"), image == null ? IntPtr.Zero : image.Handle);
			}
		}
		
		[Export ("setBackgroundImageData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (NSData imageData)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImageData:"), imageData == null ? IntPtr.Zero : imageData.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundImageData:"), imageData == null ? IntPtr.Zero : imageData.Handle);
			}
		}
		
		[Export ("setBackgroundImageNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (string imageName)
		{
			var nsimageName = NSString.CreateNative (imageName);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImageNamed:"), nsimageName);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundImageNamed:"), nsimageName);
			}
			NSString.ReleaseNative (nsimageName);
			
		}
		
		[Export ("setEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), enabled);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnabled:"), enabled);
			}
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
		
		[Export ("setAttributedTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitle (NSAttributedString attributedTitle)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAttributedTitle:"), attributedTitle == null ? IntPtr.Zero : attributedTitle.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAttributedTitle:"), attributedTitle == null ? IntPtr.Zero : attributedTitle.Handle);
			}
		}
		
	} /* class WKInterfaceButton */
}
