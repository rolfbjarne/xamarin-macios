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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_GatherOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGatherWithUpdatesTensor_IndicesTensor_Axis_BatchDimensions_Name_X = "gatherWithUpdatesTensor:indicesTensor:axis:batchDimensions:name:";
		static readonly NativeHandle selGatherWithUpdatesTensor_IndicesTensor_Axis_BatchDimensions_Name_XHandle = Selector.GetHandle ("gatherWithUpdatesTensor:indicesTensor:axis:batchDimensions:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("gatherWithUpdatesTensor:indicesTensor:axis:batchDimensions:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Gather (this MPSGraph This, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, nuint axis, nuint batchDimensions, string? name)
		{
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, selGatherWithUpdatesTensor_IndicesTensor_Axis_BatchDimensions_Name_XHandle, updatesTensor__handle__, indicesTensor__handle__, axis, batchDimensions, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_GatherOps */
}
