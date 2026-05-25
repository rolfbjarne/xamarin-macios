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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphSparseOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSparseTensorWithDescriptor_Tensors_Shape_Name_X = "sparseTensorWithDescriptor:tensors:shape:name:";
		static readonly NativeHandle selSparseTensorWithDescriptor_Tensors_Shape_Name_XHandle = Selector.GetHandle ("sparseTensorWithDescriptor:tensors:shape:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSparseTensorWithType_Tensors_Shape_DataType_Name_X = "sparseTensorWithType:tensors:shape:dataType:name:";
		static readonly NativeHandle selSparseTensorWithType_Tensors_Shape_DataType_Name_XHandle = Selector.GetHandle ("sparseTensorWithType:tensors:shape:dataType:name:");
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, selSparseTensorWithType_Tensors_Shape_DataType_Name_XHandle, (UInt64)sparseStorageType, nsa_inputTensorArray.Handle, nsb_shape.GetHandle (), (UInt32)dataType, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSparseTensorWithDescriptor_Tensors_Shape_Name_XHandle, sparseDescriptor__handle__, nsa_inputTensorArray.Handle, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sparseDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphSparseOps */
}
