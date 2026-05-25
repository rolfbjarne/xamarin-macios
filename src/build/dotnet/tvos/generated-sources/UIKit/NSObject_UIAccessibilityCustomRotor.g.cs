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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>Extension method for <see cref="T:Foundation.NSObject" /> that provides access to the <see cref="T:UIKit.UIAccessibilityCustomRotor" /> array.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NSObject_UIAccessibilityCustomRotor  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		/// <summary>Gets the array of <see cref="T:UIKit.UIAccessibilityCustomRotor" /> objects appropriate for <see langword="this" /> object.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("accessibilityCustomRotors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIAccessibilityCustomRotor[]? GetAccessibilityCustomRotors (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIAccessibilityCustomRotor[] ret;
			ret = CFArray.ArrayFromHandle<UIAccessibilityCustomRotor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCustomRotors")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="customRotors"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Sets the array of <see cref="T:UIKit.UIAccessibilityCustomRotor" /> objects appropriate for <see langword="this" /> object.</summary><remarks>To be added.</remarks>
		[Export ("setAccessibilityCustomRotors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityCustomRotors (this NSObject This, UIAccessibilityCustomRotor[]? customRotors)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsa_customRotors = customRotors is null ? null : NSArray.FromNSObjects (customRotors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCustomRotors:"), nsa_customRotors.GetHandle ());
			GC.KeepAlive (This);
		}
	} /* class NSObject_UIAccessibilityCustomRotor */
}
