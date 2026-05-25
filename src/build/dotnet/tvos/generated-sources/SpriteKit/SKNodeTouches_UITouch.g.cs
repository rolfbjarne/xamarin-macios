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
namespace SpriteKit {
	/// <summary>Extension methods for <see cref="T:UIKit.UITouch" /> that aide with conversion to Sprite Kit coordinates.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SKNodeTouches_UITouch  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UITouch");
		/// <param name="This">The instance on which this method operates.</param><param name="node">To be added.</param><summary>The current position of <c>this</c> in the coordinate system of <paramref name="node" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("locationInNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint LocationInNode (this global::UIKit.UITouch This, SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationInNode:"), node__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (node);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="node">To be added.</param><summary>The previous location of <c>this</c> in the coordinate system of <paramref name="node" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previousLocationInNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint PreviousLocationInNode (this global::UIKit.UITouch This, SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previousLocationInNode:"), node__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (node);
			return ret!;
		}
	} /* class SKNodeTouches_UITouch */
}
