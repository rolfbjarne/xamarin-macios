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
	/// <summary>Provides the <c>GetTransitionCoordinator</c> extension method for <see cref="T:UIKit.UIViewController" />s.</summary><remarks>To be added.</remarks><altmember cref="T:UIKit.UIViewController" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class TransitionCoordinator_UIViewController  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIViewController");
		/// <summary>The IUIViewControllerTransitionCoordinator coordinating the transition of the specified UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("transitionCoordinator")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerTransitionCoordinator? GetTransitionCoordinator (this UIViewController This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIViewControllerTransitionCoordinator ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerTransitionCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("transitionCoordinator")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class TransitionCoordinator_UIViewController */
}
