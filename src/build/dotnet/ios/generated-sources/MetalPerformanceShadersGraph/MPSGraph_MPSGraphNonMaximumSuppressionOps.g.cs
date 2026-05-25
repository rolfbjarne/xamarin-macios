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
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe static partial class MPSGraph_MPSGraphNonMaximumSuppressionOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("nonMaximumSuppressionWithBoxesTensor:scoresTensor:IOUThreshold:scoreThreshold:perClassSuppression:coordinateMode:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NonMaximumSuppression (this MPSGraph This, MPSGraphTensor boxesTensor, MPSGraphTensor scoresTensor, float iouThreshold, float scoreThreshold, bool perClassSuppression, MPSGraphNonMaximumSuppressionCoordinateMode coordinateMode, string? name)
		{
			var boxesTensor__handle__ = boxesTensor!.GetNonNullHandle (nameof (boxesTensor));
			var scoresTensor__handle__ = scoresTensor!.GetNonNullHandle (nameof (scoresTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_float_float_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("nonMaximumSuppressionWithBoxesTensor:scoresTensor:IOUThreshold:scoreThreshold:perClassSuppression:coordinateMode:name:"), boxesTensor__handle__, scoresTensor__handle__, iouThreshold, scoreThreshold, perClassSuppression ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) coordinateMode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (boxesTensor);
			GC.KeepAlive (scoresTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("nonMaximumSuppressionWithBoxesTensor:scoresTensor:classIndicesTensor:IOUThreshold:scoreThreshold:perClassSuppression:coordinateMode:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NonMaximumSuppression (this MPSGraph This, MPSGraphTensor boxesTensor, MPSGraphTensor scoresTensor, MPSGraphTensor classIndicesTensor, float iouThreshold, float scoreThreshold, bool perClassSuppression, MPSGraphNonMaximumSuppressionCoordinateMode coordinateMode, string? name)
		{
			var boxesTensor__handle__ = boxesTensor!.GetNonNullHandle (nameof (boxesTensor));
			var scoresTensor__handle__ = scoresTensor!.GetNonNullHandle (nameof (scoresTensor));
			var classIndicesTensor__handle__ = classIndicesTensor!.GetNonNullHandle (nameof (classIndicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_float_float_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("nonMaximumSuppressionWithBoxesTensor:scoresTensor:classIndicesTensor:IOUThreshold:scoreThreshold:perClassSuppression:coordinateMode:name:"), boxesTensor__handle__, scoresTensor__handle__, classIndicesTensor__handle__, iouThreshold, scoreThreshold, perClassSuppression ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) coordinateMode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (boxesTensor);
			GC.KeepAlive (scoresTensor);
			GC.KeepAlive (classIndicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphNonMaximumSuppressionOps */
}
