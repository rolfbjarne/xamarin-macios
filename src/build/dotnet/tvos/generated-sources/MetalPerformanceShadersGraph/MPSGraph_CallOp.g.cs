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
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class MPSGraph_CallOp  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("callSymbolName:inputTensors:outputTypes:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Call (this MPSGraph This, string symbolName, MPSGraphTensor[] inputTensors, MPSGraphType[] outputTypes, string? name)
		{
			if (symbolName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbolName));
			if (inputTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputTensors));
			if (outputTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputTypes));
			var nssymbolName = CFString.CreateNative (symbolName);
			using var nsa_inputTensors = NSArray.FromNSObjects (inputTensors);
			using var nsa_outputTypes = NSArray.FromNSObjects (outputTypes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("callSymbolName:inputTensors:outputTypes:name:"), nssymbolName, nsa_inputTensors.Handle, nsa_outputTypes.Handle, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssymbolName);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_CallOp */
}
