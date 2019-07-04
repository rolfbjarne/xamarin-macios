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
	[Register("WKInterfaceTimer", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceTimer : WKInterfaceObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceTimer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceTimer (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceTimer (IntPtr handle) : base (handle)
		{
		}

		[Export ("setDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDate (NSDate date)
		{
			if (date == null)
				throw new ArgumentNullException ("date");
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDate:"), date.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDate:"), date.Handle);
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
		
		[Export ("start")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Start ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("start"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("start"));
			}
		}
		
		[Export ("stop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
			}
		}
		
	} /* class WKInterfaceTimer */
}
