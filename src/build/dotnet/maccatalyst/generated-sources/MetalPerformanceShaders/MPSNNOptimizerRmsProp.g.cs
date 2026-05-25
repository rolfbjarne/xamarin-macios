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
namespace MetalPerformanceShaders {
	[Register("MPSNNOptimizerRMSProp", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSNNOptimizerRmsProp : MPSNNOptimizer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNNOptimizerRMSProp");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MPSNNOptimizerRmsProp (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MPSNNOptimizerRmsProp (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPSNNOptimizerRmsProp (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="learningRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:learningRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNOptimizerRmsProp (global::Metal.IMTLDevice device, float learningRate)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (this.Handle, Selector.GetHandle ("initWithDevice:learningRate:"), device__handle__, learningRate), "initWithDevice:learningRate:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_float (&__objc_super__, Selector.GetHandle ("initWithDevice:learningRate:"), device__handle__, learningRate), "initWithDevice:learningRate:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		/// <param name="device">To be added.</param><param name="decay">To be added.</param><param name="epsilon">To be added.</param><param name="optimizerDescriptor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:decay:epsilon:optimizerDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNOptimizerRmsProp (global::Metal.IMTLDevice device, double decay, float epsilon, MPSNNOptimizerDescriptor optimizerDescriptor)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var optimizerDescriptor__handle__ = optimizerDescriptor!.GetNonNullHandle (nameof (optimizerDescriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_float_NativeHandle (this.Handle, Selector.GetHandle ("initWithDevice:decay:epsilon:optimizerDescriptor:"), device__handle__, decay, epsilon, optimizerDescriptor__handle__), "initWithDevice:decay:epsilon:optimizerDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_Double_float_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDevice:decay:epsilon:optimizerDescriptor:"), device__handle__, decay, epsilon, optimizerDescriptor__handle__), "initWithDevice:decay:epsilon:optimizerDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (optimizerDescriptor);
		}
		/// <param name="commandBuffer">To be added.</param><param name="inputGradientVector">To be added.</param><param name="inputValuesVector">To be added.</param><param name="inputSumOfSquaresVector">To be added.</param><param name="resultValuesVector">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputSumOfSquaresVector:resultValuesVector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSVector inputGradientVector, MPSVector inputValuesVector, MPSVector inputSumOfSquaresVector, MPSVector resultValuesVector)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var inputGradientVector__handle__ = inputGradientVector!.GetNonNullHandle (nameof (inputGradientVector));
			var inputValuesVector__handle__ = inputValuesVector!.GetNonNullHandle (nameof (inputValuesVector));
			var inputSumOfSquaresVector__handle__ = inputSumOfSquaresVector!.GetNonNullHandle (nameof (inputSumOfSquaresVector));
			var resultValuesVector__handle__ = resultValuesVector!.GetNonNullHandle (nameof (resultValuesVector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputSumOfSquaresVector:resultValuesVector:"), commandBuffer__handle__, inputGradientVector__handle__, inputValuesVector__handle__, inputSumOfSquaresVector__handle__, resultValuesVector__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputSumOfSquaresVector:resultValuesVector:"), commandBuffer__handle__, inputGradientVector__handle__, inputValuesVector__handle__, inputSumOfSquaresVector__handle__, resultValuesVector__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (inputGradientVector);
			GC.KeepAlive (inputValuesVector);
			GC.KeepAlive (inputSumOfSquaresVector);
			GC.KeepAlive (resultValuesVector);
		}
		/// <param name="commandBuffer">To be added.</param><param name="convolutionGradientState">To be added.</param><param name="convolutionSourceState">To be added.</param><param name="inputSumOfSquaresVectors">To be added.</param><param name="resultState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputSumOfSquaresVectors:resultState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState convolutionGradientState, MPSCnnConvolutionWeightsAndBiasesState convolutionSourceState, NSArray<MPSVector>? inputSumOfSquaresVectors, MPSCnnConvolutionWeightsAndBiasesState resultState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var convolutionGradientState__handle__ = convolutionGradientState!.GetNonNullHandle (nameof (convolutionGradientState));
			var convolutionSourceState__handle__ = convolutionSourceState!.GetNonNullHandle (nameof (convolutionSourceState));
			var inputSumOfSquaresVectors__handle__ = inputSumOfSquaresVectors.GetHandle ();
			var resultState__handle__ = resultState!.GetNonNullHandle (nameof (resultState));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputSumOfSquaresVectors:resultState:"), commandBuffer__handle__, convolutionGradientState__handle__, convolutionSourceState__handle__, inputSumOfSquaresVectors__handle__, resultState__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputSumOfSquaresVectors:resultState:"), commandBuffer__handle__, convolutionGradientState__handle__, convolutionSourceState__handle__, inputSumOfSquaresVectors__handle__, resultState__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (convolutionGradientState);
			GC.KeepAlive (convolutionSourceState);
			GC.KeepAlive (inputSumOfSquaresVectors);
			GC.KeepAlive (resultState);
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><param name="inputSumOfSquaresVectors">To be added.</param><param name="resultState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:batchNormalizationState:inputSumOfSquaresVectors:resultState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSVector>? inputSumOfSquaresVectors, MPSCnnNormalizationGammaAndBetaState resultState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			var inputSumOfSquaresVectors__handle__ = inputSumOfSquaresVectors.GetHandle ();
			var resultState__handle__ = resultState!.GetNonNullHandle (nameof (resultState));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:batchNormalizationState:inputSumOfSquaresVectors:resultState:"), commandBuffer__handle__, batchNormalizationState__handle__, inputSumOfSquaresVectors__handle__, resultState__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:batchNormalizationState:inputSumOfSquaresVectors:resultState:"), commandBuffer__handle__, batchNormalizationState__handle__, inputSumOfSquaresVectors__handle__, resultState__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (batchNormalizationState);
			GC.KeepAlive (inputSumOfSquaresVectors);
			GC.KeepAlive (resultState);
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationGradientState">To be added.</param><param name="batchNormalizationSourceState">To be added.</param><param name="inputSumOfSquaresVectors">To be added.</param><param name="resultState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputSumOfSquaresVectors:resultState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationGradientState, MPSCnnBatchNormalizationState batchNormalizationSourceState, NSArray<MPSVector>? inputSumOfSquaresVectors, MPSCnnNormalizationGammaAndBetaState resultState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var batchNormalizationGradientState__handle__ = batchNormalizationGradientState!.GetNonNullHandle (nameof (batchNormalizationGradientState));
			var batchNormalizationSourceState__handle__ = batchNormalizationSourceState!.GetNonNullHandle (nameof (batchNormalizationSourceState));
			var inputSumOfSquaresVectors__handle__ = inputSumOfSquaresVectors.GetHandle ();
			var resultState__handle__ = resultState!.GetNonNullHandle (nameof (resultState));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputSumOfSquaresVectors:resultState:"), commandBuffer__handle__, batchNormalizationGradientState__handle__, batchNormalizationSourceState__handle__, inputSumOfSquaresVectors__handle__, resultState__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputSumOfSquaresVectors:resultState:"), commandBuffer__handle__, batchNormalizationGradientState__handle__, batchNormalizationSourceState__handle__, inputSumOfSquaresVectors__handle__, resultState__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (batchNormalizationGradientState);
			GC.KeepAlive (batchNormalizationSourceState);
			GC.KeepAlive (inputSumOfSquaresVectors);
			GC.KeepAlive (resultState);
		}
		[Export ("encodeToCommandBuffer:inputGradientMatrix:inputValuesMatrix:inputSumOfSquaresMatrix:resultValuesMatrix:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix inputGradientMatrix, MPSMatrix inputValuesMatrix, MPSMatrix inputSumOfSquaresMatrix, MPSMatrix resultValuesMatrix)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var inputGradientMatrix__handle__ = inputGradientMatrix!.GetNonNullHandle (nameof (inputGradientMatrix));
			var inputValuesMatrix__handle__ = inputValuesMatrix!.GetNonNullHandle (nameof (inputValuesMatrix));
			var inputSumOfSquaresMatrix__handle__ = inputSumOfSquaresMatrix!.GetNonNullHandle (nameof (inputSumOfSquaresMatrix));
			var resultValuesMatrix__handle__ = resultValuesMatrix!.GetNonNullHandle (nameof (resultValuesMatrix));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:inputGradientMatrix:inputValuesMatrix:inputSumOfSquaresMatrix:resultValuesMatrix:"), commandBuffer__handle__, inputGradientMatrix__handle__, inputValuesMatrix__handle__, inputSumOfSquaresMatrix__handle__, resultValuesMatrix__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:inputGradientMatrix:inputValuesMatrix:inputSumOfSquaresMatrix:resultValuesMatrix:"), commandBuffer__handle__, inputGradientMatrix__handle__, inputValuesMatrix__handle__, inputSumOfSquaresMatrix__handle__, resultValuesMatrix__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (inputGradientMatrix);
			GC.KeepAlive (inputValuesMatrix);
			GC.KeepAlive (inputSumOfSquaresMatrix);
			GC.KeepAlive (resultValuesMatrix);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Decay {
			[Export ("decay")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("decay"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("decay"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Epsilon {
			[Export ("epsilon")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("epsilon"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("epsilon"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSNNOptimizerRmsProp */
}
