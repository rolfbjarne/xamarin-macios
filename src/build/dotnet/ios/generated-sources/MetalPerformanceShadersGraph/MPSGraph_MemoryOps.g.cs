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
	public unsafe static partial class MPSGraph_MemoryOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("assignVariable:withValueOfTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphOperation Assign (this MPSGraph This, MPSGraphTensor variable, MPSGraphTensor tensor, string? name)
		{
			var variable__handle__ = variable!.GetNonNullHandle (nameof (variable));
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphOperation? ret;
			ret =  Runtime.GetNSObject<MPSGraphOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assignVariable:withValueOfTensor:name:"), variable__handle__, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (variable);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("constantWithData:shape:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Constant (this MPSGraph This, NSData data, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, global::MetalPerformanceShaders.MPSDataType dataType)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UInt32 (This.Handle, Selector.GetHandle ("constantWithData:shape:dataType:"), data__handle__, nsb_shape.GetHandle (), (UInt32)dataType), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("constantWithScalar:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Constant (this MPSGraph This, double scalar, global::MetalPerformanceShaders.MPSDataType dataType)
		{
			MPSGraphTensor ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_UInt32 (This.Handle, Selector.GetHandle ("constantWithScalar:dataType:"), scalar, (UInt32)dataType), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("constantWithScalar:shape:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Constant (this MPSGraph This, double scalar, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, global::MetalPerformanceShaders.MPSDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MPSGraphTensor ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle_UInt32 (This.Handle, Selector.GetHandle ("constantWithScalar:shape:dataType:"), scalar, nsb_shape.GetHandle (), (UInt32)dataType), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("constantWithRealPart:imaginaryPart:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Constant (this MPSGraph This, double realPart, double imaginaryPart)
		{
			MPSGraphTensor ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_Double (This.Handle, Selector.GetHandle ("constantWithRealPart:imaginaryPart:"), realPart, imaginaryPart), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("constantWithRealPart:imaginaryPart:dataType:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Constant (this MPSGraph This, double realPart, double imaginaryPart, global::MetalPerformanceShaders.MPSDataType dataType)
		{
			MPSGraphTensor ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_Double_UInt32 (This.Handle, Selector.GetHandle ("constantWithRealPart:imaginaryPart:dataType:"), realPart, imaginaryPart, (UInt32)dataType), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("constantWithRealPart:imaginaryPart:shape:dataType:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Constant (this MPSGraph This, double realPart, double imaginaryPart, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, global::MetalPerformanceShaders.MPSDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MPSGraphTensor ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_Double_NativeHandle_UInt32 (This.Handle, Selector.GetHandle ("constantWithRealPart:imaginaryPart:shape:dataType:"), realPart, imaginaryPart, nsb_shape.GetHandle (), (UInt32)dataType), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("placeholderWithShape:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Placeholder (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? shape, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("placeholderWithShape:dataType:name:"), nsb_shape.GetHandle (), (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("placeholderWithShape:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Placeholder (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? shape, string? name)
		{
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("placeholderWithShape:name:"), nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("readVariable:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Read (this MPSGraph This, MPSGraphTensor variable, string? name)
		{
			var variable__handle__ = variable!.GetNonNullHandle (nameof (variable));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readVariable:name:"), variable__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (variable);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("variableWithData:shape:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Variable (this MPSGraph This, NSData data, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("variableWithData:shape:dataType:name:"), data__handle__, nsb_shape.GetHandle (), (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("variableFromTensorWithTensor:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Variable (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("variableFromTensorWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MemoryOps */
}
