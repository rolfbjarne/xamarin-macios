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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphSparseOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("sparseTensorWithType:tensors:shape:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sparse (this MPSGraph This, MPSGraphSparseStorageType sparseStorageType, MPSGraphTensor[] inputTensorArray, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			if (inputTensorArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputTensorArray));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsa_inputTensorArray = NSArray.FromNSObjects (inputTensorArray);
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sparseTensorWithType:tensors:shape:dataType:name:"), (UInt64)sparseStorageType, nsa_inputTensorArray.Handle, nsb_shape.GetHandle (), (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sparseTensorWithDescriptor:tensors:shape:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sparse (this MPSGraph This, MPSGraphCreateSparseOpDescriptor sparseDescriptor, MPSGraphTensor[] inputTensorArray, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var sparseDescriptor__handle__ = sparseDescriptor!.GetNonNullHandle (nameof (sparseDescriptor));
			if (inputTensorArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputTensorArray));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsa_inputTensorArray = NSArray.FromNSObjects (inputTensorArray);
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sparseTensorWithDescriptor:tensors:shape:name:"), sparseDescriptor__handle__, nsa_inputTensorArray.Handle, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sparseDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphSparseOps */
}
