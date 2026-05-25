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
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphRandomOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("dropoutTensor:rate:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dropout (this MPSGraph This, MPSGraphTensor tensor, double rate, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_NativeHandle (This.Handle, Selector.GetHandle ("dropoutTensor:rate:name:"), tensor__handle__, rate, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dropoutTensor:rateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dropout (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor rate, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var rate__handle__ = rate!.GetNonNullHandle (nameof (rate));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropoutTensor:rateTensor:name:"), tensor__handle__, rate__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (rate);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomTensorWithShape:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Random (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, MPSGraphRandomOpDescriptor descriptor, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomTensorWithShape:descriptor:name:"), nsb_shape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomTensorWithShapeTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Random (this MPSGraph This, MPSGraphTensor shapeTensor, MPSGraphRandomOpDescriptor descriptor, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomTensorWithShapeTensor:descriptor:name:"), shapeTensor__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomTensorWithShape:descriptor:seed:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Random (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, MPSGraphRandomOpDescriptor descriptor, nuint seed, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("randomTensorWithShape:descriptor:seed:name:"), nsb_shape.GetHandle (), descriptor__handle__, seed, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomTensorWithShapeTensor:descriptor:seed:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Random (this MPSGraph This, MPSGraphTensor shapeTensor, MPSGraphRandomOpDescriptor descriptor, nuint seed, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("randomTensorWithShapeTensor:descriptor:seed:name:"), shapeTensor__handle__, descriptor__handle__, seed, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomTensorWithShape:descriptor:stateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Random (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, MPSGraphRandomOpDescriptor descriptor, MPSGraphTensor state, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomTensorWithShape:descriptor:stateTensor:name:"), nsb_shape.GetHandle (), descriptor__handle__, state__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (state);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomTensorWithShapeTensor:descriptor:stateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Random (this MPSGraph This, MPSGraphTensor shapeTensor, MPSGraphRandomOpDescriptor descriptor, MPSGraphTensor state, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomTensorWithShapeTensor:descriptor:stateTensor:name:"), shapeTensor__handle__, descriptor__handle__, state__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (state);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomPhiloxStateTensorWithSeed:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RandomPhiloxState (this MPSGraph This, nuint seed, string? name)
		{
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("randomPhiloxStateTensorWithSeed:name:"), seed, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomPhiloxStateTensorWithCounterLow:counterHigh:key:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RandomPhiloxState (this MPSGraph This, nuint counterLow, nuint counterHigh, nuint key, string? name)
		{
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("randomPhiloxStateTensorWithCounterLow:counterHigh:key:name:"), counterLow, counterHigh, key, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomUniformTensorWithShape:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RandomUniform (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomUniformTensorWithShape:name:"), nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomUniformTensorWithShapeTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RandomUniform (this MPSGraph This, MPSGraphTensor shapeTensor, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomUniformTensorWithShapeTensor:name:"), shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomUniformTensorWithShape:seed:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RandomUniform (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, nuint seed, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("randomUniformTensorWithShape:seed:name:"), nsb_shape.GetHandle (), seed, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomUniformTensorWithShapeTensor:seed:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RandomUniform (this MPSGraph This, MPSGraphTensor shapeTensor, nuint seed, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("randomUniformTensorWithShapeTensor:seed:name:"), shapeTensor__handle__, seed, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomUniformTensorWithShape:stateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] RandomUniform (this MPSGraph This, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, MPSGraphTensor state, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomUniformTensorWithShape:stateTensor:name:"), nsb_shape.GetHandle (), state__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (state);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("randomUniformTensorWithShapeTensor:stateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] RandomUniform (this MPSGraph This, MPSGraphTensor shapeTensor, MPSGraphTensor state, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("randomUniformTensorWithShapeTensor:stateTensor:name:"), shapeTensor__handle__, state__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			GC.KeepAlive (state);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphRandomOps */
}
