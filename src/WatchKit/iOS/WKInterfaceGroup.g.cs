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
	[Register("WKInterfaceGroup", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceGroup : WKInterfaceObject, IWKImageAnimatable {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceGroup");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceGroup (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceGroup (IntPtr handle) : base (handle)
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
		
		[Export ("setCornerRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCornerRadius (nfloat cornerRadius)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setCornerRadius:"), cornerRadius);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setCornerRadius:"), cornerRadius);
			}
		}
		
		[Export ("startAnimating")]
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartAnimating ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startAnimating"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startAnimating"));
			}
		}
		
		[Export ("startAnimatingWithImagesInRange:duration:repeatCount:")]
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartAnimating (NSRange imageRange, double duration, nint repeatCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_Double_nint (this.Handle, Selector.GetHandle ("startAnimatingWithImagesInRange:duration:repeatCount:"), imageRange, duration, repeatCount);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_Double_nint (this.SuperHandle, Selector.GetHandle ("startAnimatingWithImagesInRange:duration:repeatCount:"), imageRange, duration, repeatCount);
			}
		}
		
		[Export ("stopAnimating")]
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopAnimating ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopAnimating"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAnimating"));
			}
		}
		
	} /* class WKInterfaceGroup */
}
