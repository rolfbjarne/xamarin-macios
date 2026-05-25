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
namespace NotificationCenter {
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("ios")]
	internal unsafe static partial class UIVibrancyEffect_NCWidgetAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIVibrancyEffect");
		[Export ("widgetEffectForVibrancyStyle:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIVibrancyEffect GetWidgetEffect (this global::UIKit.UIVibrancyEffect This, global::UIKit.UIVibrancyEffectStyle vibrancyStyle)
		{
			global::UIKit.UIVibrancyEffect ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIVibrancyEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("widgetEffectForVibrancyStyle:"), (IntPtr) (long) vibrancyStyle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("widgetPrimaryVibrancyEffect")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'UIVibrancyEffect.GetWidgetEffect' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIVibrancyEffect GetWidgetPrimaryVibrancyEffect (this global::UIKit.UIVibrancyEffect This)
		{
			global::UIKit.UIVibrancyEffect ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIVibrancyEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("widgetPrimaryVibrancyEffect")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("widgetSecondaryVibrancyEffect")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'UIVibrancyEffect.GetWidgetEffect' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIVibrancyEffect GetWidgetSecondaryVibrancyEffect (this global::UIKit.UIVibrancyEffect This)
		{
			global::UIKit.UIVibrancyEffect ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIVibrancyEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("widgetSecondaryVibrancyEffect")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class UIVibrancyEffect_NCWidgetAdditions */
}
