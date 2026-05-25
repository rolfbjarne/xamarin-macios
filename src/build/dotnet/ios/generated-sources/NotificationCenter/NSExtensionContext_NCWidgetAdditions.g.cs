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
	/// <summary>Extension context methods and properties for an NDWidget.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class NSExtensionContext_NCWidgetAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSExtensionContext");
		/// <summary>Returns the current display mode for the widget.</summary><returns>The current display mode for the widget.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("widgetActiveDisplayMode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NCWidgetDisplayMode GetWidgetActiveDisplayMode (this NSExtensionContext This)
		{
			NCWidgetDisplayMode ret;
			ret = (NotificationCenter.NCWidgetDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("widgetActiveDisplayMode"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the largest available display mode for the widget.</summary><returns>The largest available display mode for the widget.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("widgetLargestAvailableDisplayMode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NCWidgetDisplayMode GetWidgetLargestAvailableDisplayMode (this NSExtensionContext This)
		{
			NCWidgetDisplayMode ret;
			ret = (NotificationCenter.NCWidgetDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("widgetLargestAvailableDisplayMode"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="displayMode">The display mode to query.</param><summary>Returns the maximum size of the widget for the specified display mode.</summary><returns>The maximum size of the widget for the specified display mode.</returns><remarks>To be added.</remarks>
		[Export ("widgetMaximumSizeForDisplayMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetWidgetMaximumSize (this NSExtensionContext This, NCWidgetDisplayMode displayMode)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("widgetMaximumSizeForDisplayMode:"), (IntPtr) (long) displayMode);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mode">The display mode to set.</param><summary>Sets the largest available display mode for the widget.</summary><remarks>To be added.</remarks>
		[Export ("setWidgetLargestAvailableDisplayMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWidgetLargestAvailableDisplayMode (this NSExtensionContext This, NCWidgetDisplayMode mode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setWidgetLargestAvailableDisplayMode:"), (IntPtr) (long) mode);
			GC.KeepAlive (This);
		}
	} /* class NSExtensionContext_NCWidgetAdditions */
}
