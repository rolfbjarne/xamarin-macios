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
	public unsafe static partial class MPSGraph_MPSGraphNormalizationOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeanOfTensor_Axes_Name_X = "meanOfTensor:axes:name:";
		static readonly NativeHandle selMeanOfTensor_Axes_Name_XHandle = Selector.GetHandle ("meanOfTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalizationBetaGradientWithIncomingGradientTensor_SourceTensor_ReductionAxes_Name_X = "normalizationBetaGradientWithIncomingGradientTensor:sourceTensor:reductionAxes:name:";
		static readonly NativeHandle selNormalizationBetaGradientWithIncomingGradientTensor_SourceTensor_ReductionAxes_Name_XHandle = Selector.GetHandle ("normalizationBetaGradientWithIncomingGradientTensor:sourceTensor:reductionAxes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalizationGammaGradientWithIncomingGradientTensor_SourceTensor_MeanTensor_VarianceTensor_ReductionAxes_Epsilon_Name_X = "normalizationGammaGradientWithIncomingGradientTensor:sourceTensor:meanTensor:varianceTensor:reductionAxes:epsilon:name:";
		static readonly NativeHandle selNormalizationGammaGradientWithIncomingGradientTensor_SourceTensor_MeanTensor_VarianceTensor_ReductionAxes_Epsilon_Name_XHandle = Selector.GetHandle ("normalizationGammaGradientWithIncomingGradientTensor:sourceTensor:meanTensor:varianceTensor:reductionAxes:epsilon:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalizationGradientWithIncomingGradientTensor_SourceTensor_MeanTensor_VarianceTensor_GammaTensor_GammaGradientTensor_BetaGradientTensor_ReductionAxes_Epsilon_Name_X = "normalizationGradientWithIncomingGradientTensor:sourceTensor:meanTensor:varianceTensor:gammaTensor:gammaGradientTensor:betaGradientTensor:reductionAxes:epsilon:name:";
		static readonly NativeHandle selNormalizationGradientWithIncomingGradientTensor_SourceTensor_MeanTensor_VarianceTensor_GammaTensor_GammaGradientTensor_BetaGradientTensor_ReductionAxes_Epsilon_Name_XHandle = Selector.GetHandle ("normalizationGradientWithIncomingGradientTensor:sourceTensor:meanTensor:varianceTensor:gammaTensor:gammaGradientTensor:betaGradientTensor:reductionAxes:epsilon:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalizationWithTensor_MeanTensor_VarianceTensor_GammaTensor_BetaTensor_Epsilon_Name_X = "normalizationWithTensor:meanTensor:varianceTensor:gammaTensor:betaTensor:epsilon:name:";
		static readonly NativeHandle selNormalizationWithTensor_MeanTensor_VarianceTensor_GammaTensor_BetaTensor_Epsilon_Name_XHandle = Selector.GetHandle ("normalizationWithTensor:meanTensor:varianceTensor:gammaTensor:betaTensor:epsilon:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVarianceOfTensor_Axes_Name_X = "varianceOfTensor:axes:name:";
		static readonly NativeHandle selVarianceOfTensor_Axes_Name_XHandle = Selector.GetHandle ("varianceOfTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVarianceOfTensor_MeanTensor_Axes_Name_X = "varianceOfTensor:meanTensor:axes:name:";
		static readonly NativeHandle selVarianceOfTensor_MeanTensor_Axes_Name_XHandle = Selector.GetHandle ("varianceOfTensor:meanTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("meanOfTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Mean (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMeanOfTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("normalizationWithTensor:meanTensor:varianceTensor:gammaTensor:betaTensor:epsilon:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Normalization (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor mean, MPSGraphTensor variance, MPSGraphTensor? gamma, MPSGraphTensor? beta, float epsilon, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var mean__handle__ = mean!.GetNonNullHandle (nameof (mean));
			var variance__handle__ = variance!.GetNonNullHandle (nameof (variance));
			var gamma__handle__ = gamma.GetHandle ();
			var beta__handle__ = beta.GetHandle ();
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_float_NativeHandle (This.Handle, selNormalizationWithTensor_MeanTensor_VarianceTensor_GammaTensor_BetaTensor_Epsilon_Name_XHandle, tensor__handle__, mean__handle__, variance__handle__, gamma__handle__, beta__handle__, epsilon, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (mean);
			GC.KeepAlive (variance);
			GC.KeepAlive (gamma);
			GC.KeepAlive (beta);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("normalizationBetaGradientWithIncomingGradientTensor:sourceTensor:reductionAxes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NormalizationBetaGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selNormalizationBetaGradientWithIncomingGradientTensor_SourceTensor_ReductionAxes_Name_XHandle, incomingGradientTensor__handle__, sourceTensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("normalizationGammaGradientWithIncomingGradientTensor:sourceTensor:meanTensor:varianceTensor:reductionAxes:epsilon:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NormalizationGammaGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, MPSGraphTensor meanTensor, MPSGraphTensor varianceTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, float epsilon, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			var meanTensor__handle__ = meanTensor!.GetNonNullHandle (nameof (meanTensor));
			var varianceTensor__handle__ = varianceTensor!.GetNonNullHandle (nameof (varianceTensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_float_NativeHandle (This.Handle, selNormalizationGammaGradientWithIncomingGradientTensor_SourceTensor_MeanTensor_VarianceTensor_ReductionAxes_Epsilon_Name_XHandle, incomingGradientTensor__handle__, sourceTensor__handle__, meanTensor__handle__, varianceTensor__handle__, nsb_axes.GetHandle (), epsilon, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			GC.KeepAlive (meanTensor);
			GC.KeepAlive (varianceTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("normalizationGradientWithIncomingGradientTensor:sourceTensor:meanTensor:varianceTensor:gammaTensor:gammaGradientTensor:betaGradientTensor:reductionAxes:epsilon:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NormalizationGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, MPSGraphTensor meanTensor, MPSGraphTensor varianceTensor, MPSGraphTensor? gamma, MPSGraphTensor? gammaGradient, MPSGraphTensor? betaGradient, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, float epsilon, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			var meanTensor__handle__ = meanTensor!.GetNonNullHandle (nameof (meanTensor));
			var varianceTensor__handle__ = varianceTensor!.GetNonNullHandle (nameof (varianceTensor));
			var gamma__handle__ = gamma.GetHandle ();
			var gammaGradient__handle__ = gammaGradient.GetHandle ();
			var betaGradient__handle__ = betaGradient.GetHandle ();
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_float_NativeHandle (This.Handle, selNormalizationGradientWithIncomingGradientTensor_SourceTensor_MeanTensor_VarianceTensor_GammaTensor_GammaGradientTensor_BetaGradientTensor_ReductionAxes_Epsilon_Name_XHandle, incomingGradientTensor__handle__, sourceTensor__handle__, meanTensor__handle__, varianceTensor__handle__, gamma__handle__, gammaGradient__handle__, betaGradient__handle__, nsb_axes.GetHandle (), epsilon, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			GC.KeepAlive (meanTensor);
			GC.KeepAlive (varianceTensor);
			GC.KeepAlive (gamma);
			GC.KeepAlive (gammaGradient);
			GC.KeepAlive (betaGradient);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("varianceOfTensor:meanTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Variance (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor meanTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var meanTensor__handle__ = meanTensor!.GetNonNullHandle (nameof (meanTensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selVarianceOfTensor_MeanTensor_Axes_Name_XHandle, tensor__handle__, meanTensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (meanTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("varianceOfTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Variance (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selVarianceOfTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphNormalizationOps */
}
