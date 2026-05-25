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
	public unsafe static partial class MPSGraph_GatherNDOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGatherNDWithUpdatesTensor_IndicesTensor_BatchDimensions_Name_X = "gatherNDWithUpdatesTensor:indicesTensor:batchDimensions:name:";
		static readonly NativeHandle selGatherNDWithUpdatesTensor_IndicesTensor_BatchDimensions_Name_XHandle = Selector.GetHandle ("gatherNDWithUpdatesTensor:indicesTensor:batchDimensions:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("gatherNDWithUpdatesTensor:indicesTensor:batchDimensions:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GatherND (this MPSGraph This, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, nuint batchDimensions, string? name)
		{
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selGatherNDWithUpdatesTensor_IndicesTensor_BatchDimensions_Name_XHandle, updatesTensor__handle__, indicesTensor__handle__, batchDimensions, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_GatherNDOps */
}
