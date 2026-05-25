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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UILayoutGuide_UIConstraintBasedLayoutDebugging  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UILayoutGuide");
		/// <param name="This">The instance on which this method operates.</param><param name="axis">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("constraintsAffectingLayoutForAxis:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLayoutConstraint[] GetConstraintsAffectingLayout (this UILayoutGuide This, UILayoutConstraintAxis axis)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSLayoutConstraint[] ret;
			ret = CFArray.ArrayFromHandle<NSLayoutConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("constraintsAffectingLayoutForAxis:"), (IntPtr) (long) axis), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("hasAmbiguousLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHasAmbiguousLayout (this UILayoutGuide This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasAmbiguousLayout"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	} /* class UILayoutGuide_UIConstraintBasedLayoutDebugging */
}
