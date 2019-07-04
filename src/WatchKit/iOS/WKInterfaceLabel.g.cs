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
	[Register("WKInterfaceLabel", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceLabel : WKInterfaceObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceLabel");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceLabel (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceLabel (IntPtr handle) : base (handle)
		{
		}

		[Export ("setText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetText (string text)
		{
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setText:"), nstext);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setText:"), nstext);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[Export ("setAttributedText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetText (NSAttributedString attributedText)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAttributedText:"), attributedText == null ? IntPtr.Zero : attributedText.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAttributedText:"), attributedText == null ? IntPtr.Zero : attributedText.Handle);
			}
		}
		
		[Export ("setTextColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextColor (global::UIKit.UIColor color)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextColor:"), color == null ? IntPtr.Zero : color.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTextColor:"), color == null ? IntPtr.Zero : color.Handle);
			}
		}
		
	} /* class WKInterfaceLabel */
}
