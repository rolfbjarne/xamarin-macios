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
namespace MetalPerformanceShaders {
	[Register("MPSRNNMatrixTrainingLayer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSRnnMatrixTrainingLayer : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccumulateWeightGradientsX = "accumulateWeightGradients";
		static readonly NativeHandle selAccumulateWeightGradientsXHandle = Selector.GetHandle ("accumulateWeightGradients");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_Device_X = "copyWithZone:device:";
		static readonly NativeHandle selCopyWithZone_Device_XHandle = Selector.GetHandle ("copyWithZone:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_X = "createTemporaryWeightGradientMatrices:dataType:commandBuffer:";
		static readonly NativeHandle selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_XHandle = Selector.GetHandle ("createTemporaryWeightGradientMatrices:dataType:commandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateWeightGradientMatrices_DataType_X = "createWeightGradientMatrices:dataType:";
		static readonly NativeHandle selCreateWeightGradientMatrices_DataType_XHandle = Selector.GetHandle ("createWeightGradientMatrices:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateWeightMatrices_X = "createWeightMatrices:";
		static readonly NativeHandle selCreateWeightMatrices_XHandle = Selector.GetHandle ("createWeightMatrices:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_X = "encodeCopyWeightsToCommandBuffer:weights:matrixId:matrix:copyFromWeightsToMatrix:matrixOffset:";
		static readonly NativeHandle selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_XHandle = Selector.GetHandle ("encodeCopyWeightsToCommandBuffer:weights:matrixId:matrix:copyFromWeightsToMatrix:matrixOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_X = "encodeForwardSequenceToCommandBuffer:sourceMatrices:destinationMatrices:trainingStates:weights:";
		static readonly NativeHandle selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_XHandle = Selector.GetHandle ("encodeForwardSequenceToCommandBuffer:sourceMatrices:destinationMatrices:trainingStates:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_X = "encodeForwardSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:trainingStates:recurrentInputState:recurrentOutputStates:weights:";
		static readonly NativeHandle selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_XHandle = Selector.GetHandle ("encodeForwardSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:trainingStates:recurrentInputState:recurrentOutputStates:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_X = "encodeGradientSequenceToCommandBuffer:forwardSources:forwardSourceOffsets:sourceGradients:sourceGradientOffsets:destinationGradients:destinationOffsets:weightGradients:trainingStates:recurrentInputState:recurrentOutputStates:weights:";
		static readonly NativeHandle selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_XHandle = Selector.GetHandle ("encodeGradientSequenceToCommandBuffer:forwardSources:forwardSourceOffsets:sourceGradients:sourceGradientOffsets:destinationGradients:destinationOffsets:weightGradients:trainingStates:recurrentInputState:recurrentOutputStates:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_X = "encodeGradientSequenceToCommandBuffer:forwardSources:sourceGradients:destinationGradients:weightGradients:trainingStates:weights:";
		static readonly NativeHandle selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_XHandle = Selector.GetHandle ("encodeGradientSequenceToCommandBuffer:forwardSources:sourceGradients:destinationGradients:weightGradients:trainingStates:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_RnnDescriptor_TrainableWeights_X = "initWithDevice:rnnDescriptor:trainableWeights:";
		static readonly NativeHandle selInitWithDevice_RnnDescriptor_TrainableWeights_XHandle = Selector.GetHandle ("initWithDevice:rnnDescriptor:trainableWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputFeatureChannelsX = "inputFeatureChannels";
		static readonly NativeHandle selInputFeatureChannelsXHandle = Selector.GetHandle ("inputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFeatureChannelsX = "outputFeatureChannels";
		static readonly NativeHandle selOutputFeatureChannelsXHandle = Selector.GetHandle ("outputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecurrentOutputIsTemporaryX = "recurrentOutputIsTemporary";
		static readonly NativeHandle selRecurrentOutputIsTemporaryXHandle = Selector.GetHandle ("recurrentOutputIsTemporary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccumulateWeightGradients_X = "setAccumulateWeightGradients:";
		static readonly NativeHandle selSetAccumulateWeightGradients_XHandle = Selector.GetHandle ("setAccumulateWeightGradients:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRecurrentOutputIsTemporary_X = "setRecurrentOutputIsTemporary:";
		static readonly NativeHandle selSetRecurrentOutputIsTemporary_XHandle = Selector.GetHandle ("setRecurrentOutputIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStoreAllIntermediateStates_X = "setStoreAllIntermediateStates:";
		static readonly NativeHandle selSetStoreAllIntermediateStates_XHandle = Selector.GetHandle ("setStoreAllIntermediateStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTrainingStateIsTemporary_X = "setTrainingStateIsTemporary:";
		static readonly NativeHandle selSetTrainingStateIsTemporary_XHandle = Selector.GetHandle ("setTrainingStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreAllIntermediateStatesX = "storeAllIntermediateStates";
		static readonly NativeHandle selStoreAllIntermediateStatesXHandle = Selector.GetHandle ("storeAllIntermediateStates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrainingStateIsTemporaryX = "trainingStateIsTemporary";
		static readonly NativeHandle selTrainingStateIsTemporaryXHandle = Selector.GetHandle ("trainingStateIsTemporary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSRNNMatrixTrainingLayer");
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
		public MPSRnnMatrixTrainingLayer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected MPSRnnMatrixTrainingLayer (NSObjectFlag t) : base (t)
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
		protected internal MPSRnnMatrixTrainingLayer (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="rnnDescriptor">To be added.</param><param name="trainableWeights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:rnnDescriptor:trainableWeights:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSRnnMatrixTrainingLayer (global::Metal.IMTLDevice device, MPSRnnDescriptor rnnDescriptor, NSMutableArray<MPSMatrix> trainableWeights)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var rnnDescriptor__handle__ = rnnDescriptor!.GetNonNullHandle (nameof (rnnDescriptor));
			var trainableWeights__handle__ = trainableWeights!.GetNonNullHandle (nameof (trainableWeights));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_RnnDescriptor_TrainableWeights_XHandle, device__handle__, rnnDescriptor__handle__, trainableWeights__handle__), "initWithDevice:rnnDescriptor:trainableWeights:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_RnnDescriptor_TrainableWeights_XHandle, device__handle__, rnnDescriptor__handle__, trainableWeights__handle__), "initWithDevice:rnnDescriptor:trainableWeights:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (rnnDescriptor);
			GC.KeepAlive (trainableWeights);
		}
		/// <param name="decoder">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSRnnMatrixTrainingLayer (NSCoder decoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var decoder__handle__ = decoder!.GetNonNullHandle (nameof (decoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithCoder_Device_XHandle, decoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithCoder_Device_XHandle, decoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (decoder);
			GC.KeepAlive (device);
		}
		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSRnnMatrixTrainingLayer Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			MPSRnnMatrixTrainingLayer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSRnnMatrixTrainingLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCopyWithZone_Device_XHandle, zone__handle__, device__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSRnnMatrixTrainingLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCopyWithZone_Device_XHandle, zone__handle__, device__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		/// <param name="matrices">To be added.</param><param name="dataType">To be added.</param><param name="commandBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("createTemporaryWeightGradientMatrices:dataType:commandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreateTemporaryWeightGradientMatrices (NSMutableArray<MPSMatrix> matrices, MPSDataType dataType, global::Metal.IMTLCommandBuffer commandBuffer)
		{
			var matrices__handle__ = matrices!.GetNonNullHandle (nameof (matrices));
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32_NativeHandle (this.Handle, selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_XHandle, matrices__handle__, (UInt32)dataType, commandBuffer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32_NativeHandle (&__objc_super__, selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_XHandle, matrices__handle__, (UInt32)dataType, commandBuffer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matrices);
			GC.KeepAlive (commandBuffer);
		}
		/// <param name="matrices">To be added.</param><param name="dataType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("createWeightGradientMatrices:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreateWeightGradientMatrices (NSMutableArray<MPSMatrix> matrices, MPSDataType dataType)
		{
			var matrices__handle__ = matrices!.GetNonNullHandle (nameof (matrices));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (this.Handle, selCreateWeightGradientMatrices_DataType_XHandle, matrices__handle__, (UInt32)dataType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32 (&__objc_super__, selCreateWeightGradientMatrices_DataType_XHandle, matrices__handle__, (UInt32)dataType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matrices);
		}
		/// <param name="matrices">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("createWeightMatrices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreateWeightMatrices (NSMutableArray<MPSMatrix> matrices)
		{
			var matrices__handle__ = matrices!.GetNonNullHandle (nameof (matrices));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCreateWeightMatrices_XHandle, matrices__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateWeightMatrices_XHandle, matrices__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matrices);
		}
		/// <param name="commandBuffer">To be added.</param><param name="weights">To be added.</param><param name="matrixId">To be added.</param><param name="matrix">To be added.</param><param name="copyFromWeightsToMatrix">To be added.</param><param name="matrixOffset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeCopyWeightsToCommandBuffer:weights:matrixId:matrix:copyFromWeightsToMatrix:matrixOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeCopyWeights (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] weights, MPSRnnMatrixId matrixId, MPSMatrix matrix, bool copyFromWeightsToMatrix, global::Metal.MTLOrigin matrixOffset)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			var matrix__handle__ = matrix!.GetNonNullHandle (nameof (matrix));
			using var nsa_weights = NSArray.FromNSObjects (weights);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_bool_MTLOrigin (this.Handle, selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_XHandle, commandBuffer__handle__, nsa_weights.Handle, (UIntPtr) (ulong) matrixId, matrix__handle__, copyFromWeightsToMatrix ? (byte) 1 : (byte) 0, matrixOffset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_bool_MTLOrigin (&__objc_super__, selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_XHandle, commandBuffer__handle__, nsa_weights.Handle, (UIntPtr) (ulong) matrixId, matrix__handle__, copyFromWeightsToMatrix ? (byte) 1 : (byte) 0, matrixOffset);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (matrix);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceMatrices">To be added.</param><param name="sourceOffsets">To be added.</param><param name="destinationMatrices">To be added.</param><param name="destinationOffsets">To be added.</param><param name="trainingStates">To be added.</param><param name="recurrentInputState">To be added.</param><param name="recurrentOutputStates">To be added.</param><param name="weights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeForwardSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:trainingStates:recurrentInputState:recurrentOutputStates:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeForwardSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceMatrices, nint sourceOffsets, MPSMatrix[] destinationMatrices, nint destinationOffsets, NSMutableArray<MPSRnnMatrixTrainingState> trainingStates, MPSRnnRecurrentMatrixState? recurrentInputState, NSMutableArray<MPSRnnRecurrentMatrixState>? recurrentOutputStates, MPSMatrix[] weights)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceMatrices));
			if (destinationMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationMatrices));
			var trainingStates__handle__ = trainingStates!.GetNonNullHandle (nameof (trainingStates));
			var recurrentInputState__handle__ = recurrentInputState.GetHandle ();
			var recurrentOutputStates__handle__ = recurrentOutputStates.GetHandle ();
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			using var nsa_sourceMatrices = NSArray.FromNSObjects (sourceMatrices);
			using var nsa_destinationMatrices = NSArray.FromNSObjects (destinationMatrices);
			using var nsa_weights = NSArray.FromNSObjects (weights);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, sourceOffsets, nsa_destinationMatrices.Handle, destinationOffsets, trainingStates__handle__, recurrentInputState__handle__, recurrentOutputStates__handle__, nsa_weights.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, sourceOffsets, nsa_destinationMatrices.Handle, destinationOffsets, trainingStates__handle__, recurrentInputState__handle__, recurrentOutputStates__handle__, nsa_weights.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (trainingStates);
			GC.KeepAlive (recurrentInputState);
			GC.KeepAlive (recurrentOutputStates);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceMatrices">To be added.</param><param name="destinationMatrices">To be added.</param><param name="trainingStates">To be added.</param><param name="weights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeForwardSequenceToCommandBuffer:sourceMatrices:destinationMatrices:trainingStates:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeForwardSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceMatrices, MPSMatrix[] destinationMatrices, NSMutableArray<MPSRnnMatrixTrainingState> trainingStates, MPSMatrix[] weights)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceMatrices));
			if (destinationMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationMatrices));
			var trainingStates__handle__ = trainingStates!.GetNonNullHandle (nameof (trainingStates));
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			using var nsa_sourceMatrices = NSArray.FromNSObjects (sourceMatrices);
			using var nsa_destinationMatrices = NSArray.FromNSObjects (destinationMatrices);
			using var nsa_weights = NSArray.FromNSObjects (weights);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, nsa_destinationMatrices.Handle, trainingStates__handle__, nsa_weights.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, nsa_destinationMatrices.Handle, trainingStates__handle__, nsa_weights.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (trainingStates);
		}
		/// <param name="commandBuffer">To be added.</param><param name="forwardSources">To be added.</param><param name="forwardSourceOffsets">To be added.</param><param name="sourceGradients">To be added.</param><param name="sourceGradientOffsets">To be added.</param><param name="destinationGradients">To be added.</param><param name="destinationOffsets">To be added.</param><param name="weightGradients">To be added.</param><param name="trainingStates">To be added.</param><param name="recurrentInputState">To be added.</param><param name="recurrentOutputStates">To be added.</param><param name="weights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeGradientSequenceToCommandBuffer:forwardSources:forwardSourceOffsets:sourceGradients:sourceGradientOffsets:destinationGradients:destinationOffsets:weightGradients:trainingStates:recurrentInputState:recurrentOutputStates:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeGradientSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] forwardSources, nint forwardSourceOffsets, MPSMatrix[] sourceGradients, nint sourceGradientOffsets, MPSMatrix[]? destinationGradients, nint destinationOffsets, MPSMatrix[]? weightGradients, MPSRnnMatrixTrainingState[] trainingStates, MPSRnnRecurrentMatrixState? recurrentInputState, NSMutableArray<MPSRnnRecurrentMatrixState>? recurrentOutputStates, MPSMatrix[] weights)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (forwardSources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forwardSources));
			if (sourceGradients is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceGradients));
			if (trainingStates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trainingStates));
			var recurrentInputState__handle__ = recurrentInputState.GetHandle ();
			var recurrentOutputStates__handle__ = recurrentOutputStates.GetHandle ();
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			using var nsa_forwardSources = NSArray.FromNSObjects (forwardSources);
			using var nsa_sourceGradients = NSArray.FromNSObjects (sourceGradients);
			using var nsa_destinationGradients = destinationGradients is null ? null : NSArray.FromNSObjects (destinationGradients);
			using var nsa_weightGradients = weightGradients is null ? null : NSArray.FromNSObjects (weightGradients);
			using var nsa_trainingStates = NSArray.FromNSObjects (trainingStates);
			using var nsa_weights = NSArray.FromNSObjects (weights);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_XHandle, commandBuffer__handle__, nsa_forwardSources.Handle, forwardSourceOffsets, nsa_sourceGradients.Handle, sourceGradientOffsets, nsa_destinationGradients.GetHandle (), destinationOffsets, nsa_weightGradients.GetHandle (), nsa_trainingStates.Handle, recurrentInputState__handle__, recurrentOutputStates__handle__, nsa_weights.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_XHandle, commandBuffer__handle__, nsa_forwardSources.Handle, forwardSourceOffsets, nsa_sourceGradients.Handle, sourceGradientOffsets, nsa_destinationGradients.GetHandle (), destinationOffsets, nsa_weightGradients.GetHandle (), nsa_trainingStates.Handle, recurrentInputState__handle__, recurrentOutputStates__handle__, nsa_weights.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (recurrentInputState);
			GC.KeepAlive (recurrentOutputStates);
		}
		/// <param name="commandBuffer">To be added.</param><param name="forwardSources">To be added.</param><param name="sourceGradients">To be added.</param><param name="destinationGradients">To be added.</param><param name="weightGradients">To be added.</param><param name="trainingStates">To be added.</param><param name="weights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeGradientSequenceToCommandBuffer:forwardSources:sourceGradients:destinationGradients:weightGradients:trainingStates:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeGradientSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] forwardSources, MPSMatrix[] sourceGradients, MPSMatrix[]? destinationGradients, MPSMatrix[]? weightGradients, MPSRnnMatrixTrainingState[] trainingStates, MPSMatrix[] weights)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (forwardSources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forwardSources));
			if (sourceGradients is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceGradients));
			if (trainingStates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trainingStates));
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			using var nsa_forwardSources = NSArray.FromNSObjects (forwardSources);
			using var nsa_sourceGradients = NSArray.FromNSObjects (sourceGradients);
			using var nsa_destinationGradients = destinationGradients is null ? null : NSArray.FromNSObjects (destinationGradients);
			using var nsa_weightGradients = weightGradients is null ? null : NSArray.FromNSObjects (weightGradients);
			using var nsa_trainingStates = NSArray.FromNSObjects (trainingStates);
			using var nsa_weights = NSArray.FromNSObjects (weights);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_XHandle, commandBuffer__handle__, nsa_forwardSources.Handle, nsa_sourceGradients.Handle, nsa_destinationGradients.GetHandle (), nsa_weightGradients.GetHandle (), nsa_trainingStates.Handle, nsa_weights.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_XHandle, commandBuffer__handle__, nsa_forwardSources.Handle, nsa_sourceGradients.Handle, nsa_destinationGradients.GetHandle (), nsa_weightGradients.GetHandle (), nsa_trainingStates.Handle, nsa_weights.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccumulateWeightGradients {
			[Export ("accumulateWeightGradients")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccumulateWeightGradientsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccumulateWeightGradientsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccumulateWeightGradients:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccumulateWeightGradients_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccumulateWeightGradients_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint InputFeatureChannels {
			[Export ("inputFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selInputFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selInputFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint OutputFeatureChannels {
			[Export ("outputFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOutputFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOutputFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RecurrentOutputIsTemporary {
			[Export ("recurrentOutputIsTemporary")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRecurrentOutputIsTemporaryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRecurrentOutputIsTemporaryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRecurrentOutputIsTemporary:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRecurrentOutputIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRecurrentOutputIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StoreAllIntermediateStates {
			[Export ("storeAllIntermediateStates")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStoreAllIntermediateStatesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStoreAllIntermediateStatesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setStoreAllIntermediateStates:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStoreAllIntermediateStates_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetStoreAllIntermediateStates_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrainingStateIsTemporary {
			[Export ("trainingStateIsTemporary")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTrainingStateIsTemporaryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTrainingStateIsTemporaryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTrainingStateIsTemporary:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTrainingStateIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTrainingStateIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSRnnMatrixTrainingLayer */
}
