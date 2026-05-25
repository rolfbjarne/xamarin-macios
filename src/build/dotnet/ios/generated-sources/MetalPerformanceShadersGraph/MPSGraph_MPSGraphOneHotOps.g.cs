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
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphOneHotOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("oneHotWithIndicesTensor:depth:axis:dataType:onValue:offValue:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor OneHot (this MPSGraph This, MPSGraphTensor indicesTensor, nuint depth, nuint axis, global::MetalPerformanceShaders.MPSDataType dataType, double onValue, double offValue, string? name)
		{
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UInt32_Double_Double_NativeHandle (This.Handle, Selector.GetHandle ("oneHotWithIndicesTensor:depth:axis:dataType:onValue:offValue:name:"), indicesTensor__handle__, depth, axis, (UInt32)dataType, onValue, offValue, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("oneHotWithIndicesTensor:depth:dataType:onValue:offValue:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor OneHot (this MPSGraph This, MPSGraphTensor indicesTensor, nuint depth, global::MetalPerformanceShaders.MPSDataType dataType, double onValue, double offValue, string? name)
		{
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UInt32_Double_Double_NativeHandle (This.Handle, Selector.GetHandle ("oneHotWithIndicesTensor:depth:dataType:onValue:offValue:name:"), indicesTensor__handle__, depth, (UInt32)dataType, onValue, offValue, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("oneHotWithIndicesTensor:depth:axis:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor OneHot (this MPSGraph This, MPSGraphTensor indicesTensor, nuint depth, nuint axis, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("oneHotWithIndicesTensor:depth:axis:dataType:name:"), indicesTensor__handle__, depth, axis, (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("oneHotWithIndicesTensor:depth:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor OneHot (this MPSGraph This, MPSGraphTensor indicesTensor, nuint depth, nuint axis, string? name)
		{
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("oneHotWithIndicesTensor:depth:axis:name:"), indicesTensor__handle__, depth, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("oneHotWithIndicesTensor:depth:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor OneHot (this MPSGraph This, MPSGraphTensor indicesTensor, nuint depth, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("oneHotWithIndicesTensor:depth:dataType:name:"), indicesTensor__handle__, depth, (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("oneHotWithIndicesTensor:depth:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor OneHot (this MPSGraph This, MPSGraphTensor indicesTensor, nuint depth, string? name)
		{
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("oneHotWithIndicesTensor:depth:name:"), indicesTensor__handle__, depth, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphOneHotOps */
}
