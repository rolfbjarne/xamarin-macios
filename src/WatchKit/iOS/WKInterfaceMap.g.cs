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
	[Register("WKInterfaceMap", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceMap : WKInterfaceObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceMap");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceMap (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceMap (IntPtr handle) : base (handle)
		{
		}

		[Export ("addAnnotation:withImage:centerOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (global::CoreLocation.CLLocationCoordinate2D location, global::UIKit.UIImage image, CGPoint offset)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D_IntPtr_CGPoint (this.Handle, Selector.GetHandle ("addAnnotation:withImage:centerOffset:"), location, image == null ? IntPtr.Zero : image.Handle, offset);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr_CGPoint (this.SuperHandle, Selector.GetHandle ("addAnnotation:withImage:centerOffset:"), location, image == null ? IntPtr.Zero : image.Handle, offset);
			}
		}
		
		[Export ("addAnnotation:withImageNamed:centerOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (global::CoreLocation.CLLocationCoordinate2D location, string name, CGPoint offset)
		{
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D_IntPtr_CGPoint (this.Handle, Selector.GetHandle ("addAnnotation:withImageNamed:centerOffset:"), location, nsname, offset);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr_CGPoint (this.SuperHandle, Selector.GetHandle ("addAnnotation:withImageNamed:centerOffset:"), location, nsname, offset);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("addAnnotation:withPinColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (global::CoreLocation.CLLocationCoordinate2D location, WKInterfaceMapPinColor pinColor)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D_Int64 (this.Handle, Selector.GetHandle ("addAnnotation:withPinColor:"), location, (Int64)pinColor);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D_int (this.Handle, Selector.GetHandle ("addAnnotation:withPinColor:"), location, (int)pinColor);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_Int64 (this.SuperHandle, Selector.GetHandle ("addAnnotation:withPinColor:"), location, (Int64)pinColor);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_int (this.SuperHandle, Selector.GetHandle ("addAnnotation:withPinColor:"), location, (int)pinColor);
				}
			}
		}
		
		[Export ("removeAllAnnotations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnnotations ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllAnnotations"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllAnnotations"));
			}
		}
		
		[Export ("setRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRegion (global::MapKit.MKCoordinateRegion coordinateRegion)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKCoordinateRegion (this.Handle, Selector.GetHandle ("setRegion:"), coordinateRegion);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKCoordinateRegion (this.SuperHandle, Selector.GetHandle ("setRegion:"), coordinateRegion);
			}
		}
		
		[Export ("setVisibleMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisible (global::MapKit.MKMapRect mapRect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect (this.Handle, Selector.GetHandle ("setVisibleMapRect:"), mapRect);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect (this.SuperHandle, Selector.GetHandle ("setVisibleMapRect:"), mapRect);
			}
		}
		
	} /* class WKInterfaceMap */
}
