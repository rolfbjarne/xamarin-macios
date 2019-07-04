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
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe static partial class WKAccessibility  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceObject");
		
		[Export ("setAccessibilityHint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityHint (this WKInterfaceObject This, string accessibilityHint)
		{
			var nsaccessibilityHint = NSString.CreateNative (accessibilityHint);
			
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityHint:"), nsaccessibilityHint);
			NSString.ReleaseNative (nsaccessibilityHint);
			
		}
		
		[Export ("setAccessibilityIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityIdentifier (this WKInterfaceObject This, string accessibilityIdentifier)
		{
			var nsaccessibilityIdentifier = NSString.CreateNative (accessibilityIdentifier);
			
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityIdentifier:"), nsaccessibilityIdentifier);
			NSString.ReleaseNative (nsaccessibilityIdentifier);
			
		}
		
		[Export ("setAccessibilityImageRegions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityImageRegions (this WKInterfaceObject This, WKAccessibilityImageRegion[] accessibilityImageRegions)
		{
			if (accessibilityImageRegions == null)
				throw new ArgumentNullException ("accessibilityImageRegions");
			var nsa_accessibilityImageRegions = NSArray.FromNSObjects (accessibilityImageRegions);
			
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityImageRegions:"), nsa_accessibilityImageRegions.Handle);
			nsa_accessibilityImageRegions.Dispose ();
			
		}
		
		[Export ("setAccessibilityLabel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityLabel (this WKInterfaceObject This, string accessibilityLabel)
		{
			var nsaccessibilityLabel = NSString.CreateNative (accessibilityLabel);
			
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityLabel:"), nsaccessibilityLabel);
			NSString.ReleaseNative (nsaccessibilityLabel);
			
		}
		
		[Export ("setAccessibilityTraits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityTraits (this WKInterfaceObject This, global::UIKit.UIAccessibilityTrait accessibilityTraits)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setAccessibilityTraits:"), (Int64)accessibilityTraits);
		}
		
		[Export ("setAccessibilityValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityValue (this WKInterfaceObject This, string accessibilityValue)
		{
			var nsaccessibilityValue = NSString.CreateNative (accessibilityValue);
			
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityValue:"), nsaccessibilityValue);
			NSString.ReleaseNative (nsaccessibilityValue);
			
		}
		
		[Export ("setIsAccessibilityElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIsAccessibilityElement (this WKInterfaceObject This, bool isAccessibilityElement)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsAccessibilityElement:"), isAccessibilityElement);
		}
		
	} /* class WKAccessibility */
}
