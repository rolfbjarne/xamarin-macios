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
namespace CoreML {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class MLModel_MLState  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewStateX = "newState";
		static readonly NativeHandle selNewStateXHandle = Selector.GetHandle ("newState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredictionFromFeatures_UsingState_Error_X = "predictionFromFeatures:usingState:error:";
		static readonly NativeHandle selPredictionFromFeatures_UsingState_Error_XHandle = Selector.GetHandle ("predictionFromFeatures:usingState:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredictionFromFeatures_UsingState_Options_CompletionHandler_X = "predictionFromFeatures:usingState:options:completionHandler:";
		static readonly NativeHandle selPredictionFromFeatures_UsingState_Options_CompletionHandler_XHandle = Selector.GetHandle ("predictionFromFeatures:usingState:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredictionFromFeatures_UsingState_Options_Error_X = "predictionFromFeatures:usingState:options:error:";
		static readonly NativeHandle selPredictionFromFeatures_UsingState_Options_Error_XHandle = Selector.GetHandle ("predictionFromFeatures:usingState:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLModel");
		[Export ("newState")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLState CreateNewState (this MLModel This)
		{
			MLState? ret;
			ret =  Runtime.GetNSObject<MLState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selNewStateXHandle), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[Export ("predictionFromFeatures:usingState:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMLFeatureProvider? GetPrediction (this MLModel This, IMLFeatureProvider inputFeatures, MLState state, out NSError error)
		{
			var inputFeatures__handle__ = inputFeatures!.GetNonNullHandle (nameof (inputFeatures));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			NativeHandle errorValue = IntPtr.Zero;
			IMLFeatureProvider? ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, selPredictionFromFeatures_UsingState_Error_XHandle, inputFeatures__handle__, state__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputFeatures);
			GC.KeepAlive (state);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("predictionFromFeatures:usingState:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMLFeatureProvider? GetPrediction (this MLModel This, IMLFeatureProvider inputFeatures, MLState state, MLPredictionOptions options, out NSError error)
		{
			var inputFeatures__handle__ = inputFeatures!.GetNonNullHandle (nameof (inputFeatures));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			IMLFeatureProvider? ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, selPredictionFromFeatures_UsingState_Options_Error_XHandle, inputFeatures__handle__, state__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputFeatures);
			GC.KeepAlive (state);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("predictionFromFeatures:usingState:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMLFeatureProvider? GetPrediction (this MLModel This, IMLFeatureProvider inputFeatures, MLState state, MLPredictionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLStateGetPredictionCompletionHandler))]MLStateGetPredictionCompletionHandler completionHandler)
		{
			var inputFeatures__handle__ = inputFeatures!.GetNonNullHandle (nameof (inputFeatures));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMLStateGetPredictionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMLFeatureProvider? ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selPredictionFromFeatures_UsingState_Options_CompletionHandler_XHandle, inputFeatures__handle__, state__handle__, options__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputFeatures);
			GC.KeepAlive (state);
			GC.KeepAlive (options);
			return ret!;
		}
	} /* class MLModel_MLState */
}
