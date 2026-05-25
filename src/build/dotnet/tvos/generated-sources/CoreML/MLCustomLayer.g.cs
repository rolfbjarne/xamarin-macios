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
namespace CoreML {
	#pragma warning disable CS1573
	/// <summary>Interface defining methods necessary for a custom model layer.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MLCustomLayer", WrapperType = typeof (MLCustomLayerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetWeightData", Selector = "setWeightData:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSData[]), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetOutputShapes", Selector = "outputShapesForInputShapes:error:", ReturnType = typeof (NSArray[]), ParameterType = new Type [] { typeof (NSArray[]), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EvaluateOnCpu", Selector = "evaluateOnCPUWithInputs:outputs:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MLMultiArray[]), typeof (MLMultiArray[]), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeToCommandBuffer:inputs:outputs:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (IMTLTexture[]), typeof (IMTLTexture[]), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	public partial interface IMLCustomLayer : INativeObject, IDisposable
	{
		/// <param name="weights">To be added.</param><param name="error">To be added.</param><summary>Sets the internal weights of the layer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setWeightData:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetWeightData (NSData[] weights, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="weights">To be added.</param><param name="error">To be added.</param><summary>Sets the internal weights of the layer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _SetWeightData (IMLCustomLayer This, NSData[] weights, out NSError? error)
		{
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_weights = NSArray.FromNSObjects (weights);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("setWeightData:error:"), nsa_weights.Handle, &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="inputShapes">To be added.</param><param name="error">To be added.</param><summary>Retrieves the output data shape, as an array of numbers describing the dimensions of the output tensor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("outputShapesForInputShapes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSArray[]? GetOutputShapes (NSArray[] inputShapes, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="inputShapes">To be added.</param><param name="error">To be added.</param><summary>Retrieves the output data shape, as an array of numbers describing the dimensions of the output tensor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSArray[]? _GetOutputShapes (IMLCustomLayer This, NSArray[] inputShapes, out NSError? error)
		{
			if (inputShapes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputShapes));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_inputShapes = NSArray.FromNSObjects (inputShapes);
			NSArray[]? ret;
			ret = CFArray.ArrayFromHandle<NSArray>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("outputShapesForInputShapes:error:"), nsa_inputShapes.Handle, &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="inputs">To be added.</param><param name="outputs">To be added.</param><param name="error">To be added.</param><summary>Sets <paramref name="outputs" /> based on <paramref name="inputs" /> using the CPU to do the calculations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("evaluateOnCPUWithInputs:outputs:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool EvaluateOnCpu (MLMultiArray[] inputs, MLMultiArray[] outputs, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="inputs">To be added.</param><param name="outputs">To be added.</param><param name="error">To be added.</param><summary>Sets <paramref name="outputs" /> based on <paramref name="inputs" /> using the CPU to do the calculations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _EvaluateOnCpu (IMLCustomLayer This, MLMultiArray[] inputs, MLMultiArray[] outputs, out NSError? error)
		{
			if (inputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputs));
			if (outputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputs));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_inputs = NSArray.FromNSObjects (inputs);
			using var nsa_outputs = NSArray.FromNSObjects (outputs);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("evaluateOnCPUWithInputs:outputs:error:"), nsa_inputs.Handle, nsa_outputs.Handle, &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="commandBuffer">To be added.</param><param name="inputs">To be added.</param><param name="outputs">To be added.</param><param name="error">To be added.</param><summary>Sets <paramref name="outputs" /> by applying <paramref name="inputs" /> to the function described by <paramref name="commandBuffer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("encodeToCommandBuffer:inputs:outputs:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Encode (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture[] inputs, global::Metal.IMTLTexture[] outputs, out NSError? error)
		{
			return _Encode (this, commandBuffer, inputs, outputs, out error);
		}
		/// <param name="commandBuffer">To be added.</param><param name="inputs">To be added.</param><param name="outputs">To be added.</param><param name="error">To be added.</param><summary>Sets <paramref name="outputs" /> by applying <paramref name="inputs" /> to the function described by <paramref name="commandBuffer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Encode (IMLCustomLayer This, global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture[] inputs, global::Metal.IMTLTexture[] outputs, out NSError? error)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (inputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputs));
			if (outputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputs));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_inputs = NSArray.FromNSObjects (inputs);
			using var nsa_outputs = NSArray.FromNSObjects (outputs);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("encodeToCommandBuffer:inputs:outputs:error:"), commandBuffer__handle__, nsa_inputs.Handle, nsa_outputs.Handle, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("Encode(Metal.IMTLCommandBuffer,Metal.IMTLTexture[],Metal.IMTLTexture[],Foundation.NSError@)")]
		[DynamicDependencyAttribute ("EvaluateOnCpu(CoreML.MLMultiArray[],CoreML.MLMultiArray[],Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetOutputShapes(Foundation.NSArray[],Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SetWeightData(Foundation.NSData[],Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLCustomLayerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMLCustomLayer ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMLCustomLayer" /> interface to support all the methods from the MLCustomLayer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMLCustomLayer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MLCustomLayer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MLCustomLayer_Extensions {
		/// <param name="commandBuffer">To be added.</param><param name="inputs">To be added.</param><param name="outputs">To be added.</param><param name="error">To be added.</param><summary>Sets <paramref name="outputs" /> by applying <paramref name="inputs" /> to the function described by <paramref name="commandBuffer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool Encode (this IMLCustomLayer This, global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture[] inputs, global::Metal.IMTLTexture[] outputs, out NSError? error)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (inputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputs));
			if (outputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputs));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_inputs = NSArray.FromNSObjects (inputs);
			using var nsa_outputs = NSArray.FromNSObjects (outputs);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("encodeToCommandBuffer:inputs:outputs:error:"), commandBuffer__handle__, nsa_inputs.Handle, nsa_outputs.Handle, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MLCustomLayerWrapper : BaseWrapper, IMLCustomLayer {
		public MLCustomLayerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLCustomLayerWrapper))]
		static MLCustomLayerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="weights">To be added.</param><param name="error">To be added.</param><summary>Sets the internal weights of the layer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setWeightData:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool SetWeightData (NSData[] weights, out NSError? error)
		{
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_weights = NSArray.FromNSObjects (weights);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("setWeightData:error:"), nsa_weights.Handle, &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="inputShapes">To be added.</param><param name="error">To be added.</param><summary>Retrieves the output data shape, as an array of numbers describing the dimensions of the output tensor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outputShapesForInputShapes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSArray[]? GetOutputShapes (NSArray[] inputShapes, out NSError? error)
		{
			if (inputShapes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputShapes));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_inputShapes = NSArray.FromNSObjects (inputShapes);
			NSArray[]? ret;
			ret = CFArray.ArrayFromHandle<NSArray>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("outputShapesForInputShapes:error:"), nsa_inputShapes.Handle, &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="inputs">To be added.</param><param name="outputs">To be added.</param><param name="error">To be added.</param><summary>Sets <paramref name="outputs" /> based on <paramref name="inputs" /> using the CPU to do the calculations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("evaluateOnCPUWithInputs:outputs:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool EvaluateOnCpu (MLMultiArray[] inputs, MLMultiArray[] outputs, out NSError? error)
		{
			if (inputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputs));
			if (outputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputs));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_inputs = NSArray.FromNSObjects (inputs);
			using var nsa_outputs = NSArray.FromNSObjects (outputs);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("evaluateOnCPUWithInputs:outputs:error:"), nsa_inputs.Handle, nsa_outputs.Handle, &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
	}
}
