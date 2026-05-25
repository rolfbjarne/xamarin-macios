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
namespace Metal {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class NSProcessInfo_NSDeviceCertification  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSProcessInfo");
		[Export ("hasPerformanceProfile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasPerformanceProfile (this NSProcessInfo This, NSProcessPerformanceProfile performanceProfile)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_int (This.Handle, Selector.GetHandle ("hasPerformanceProfile:"), (int)performanceProfile);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[Export ("isDeviceCertifiedFor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDeviceCertifiedFor (this NSProcessInfo This, NSDeviceCertification performanceTier)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_int (This.Handle, Selector.GetHandle ("isDeviceCertifiedFor:"), (int)performanceTier);
			GC.KeepAlive (This);
			return ret != 0;
		}
	} /* class NSProcessInfo_NSDeviceCertification */
}
