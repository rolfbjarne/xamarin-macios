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
	public unsafe static partial class MPSGraph_MPSGraphGatherAlongAxisOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("gatherAlongAxis:withUpdatesTensor:indicesTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GatherAlongAxis (this MPSGraph This, nint axis, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, string? name)
		{
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gatherAlongAxis:withUpdatesTensor:indicesTensor:name:"), axis, updatesTensor__handle__, indicesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("gatherAlongAxisTensor:withUpdatesTensor:indicesTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GatherAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gatherAlongAxisTensor:withUpdatesTensor:indicesTensor:name:"), axisTensor__handle__, updatesTensor__handle__, indicesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphGatherAlongAxisOps */
}
