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
namespace AVKit {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UIWindow_AVAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIWindow");
		[Export ("avDisplayManager")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVDisplayManager GetAVDisplayManager (this global::UIKit.UIWindow This)
		{
			AVDisplayManager ret;
			ret =  Runtime.GetNSObject<AVDisplayManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("avDisplayManager")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class UIWindow_AVAdditions */
}
