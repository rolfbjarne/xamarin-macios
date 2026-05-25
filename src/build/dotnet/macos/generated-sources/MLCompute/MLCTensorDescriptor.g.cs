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
namespace MLCompute {
	[Register("MLCTensorDescriptor", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCTensorDescriptor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchSizePerSequenceStepX = "batchSizePerSequenceStep";
		static readonly NativeHandle selBatchSizePerSequenceStepXHandle = Selector.GetHandle ("batchSizePerSequenceStep");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionBiasesDescriptorWithFeatureChannelCount_DataType_X = "convolutionBiasesDescriptorWithFeatureChannelCount:dataType:";
		static readonly NativeHandle selConvolutionBiasesDescriptorWithFeatureChannelCount_DataType_XHandle = Selector.GetHandle ("convolutionBiasesDescriptorWithFeatureChannelCount:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionWeightsDescriptorWithInputFeatureChannelCount_OutputFeatureChannelCount_DataType_X = "convolutionWeightsDescriptorWithInputFeatureChannelCount:outputFeatureChannelCount:dataType:";
		static readonly NativeHandle selConvolutionWeightsDescriptorWithInputFeatureChannelCount_OutputFeatureChannelCount_DataType_XHandle = Selector.GetHandle ("convolutionWeightsDescriptorWithInputFeatureChannelCount:outputFeatureChannelCount:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionWeightsDescriptorWithWidth_Height_InputFeatureChannelCount_OutputFeatureChannelCount_DataType_X = "convolutionWeightsDescriptorWithWidth:height:inputFeatureChannelCount:outputFeatureChannelCount:dataType:";
		static readonly NativeHandle selConvolutionWeightsDescriptorWithWidth_Height_InputFeatureChannelCount_OutputFeatureChannelCount_DataType_XHandle = Selector.GetHandle ("convolutionWeightsDescriptorWithWidth:height:inputFeatureChannelCount:outputFeatureChannelCount:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataTypeX = "dataType";
		static readonly NativeHandle selDataTypeXHandle = Selector.GetHandle ("dataType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithShape_DataType_X = "descriptorWithShape:dataType:";
		static readonly NativeHandle selDescriptorWithShape_DataType_XHandle = Selector.GetHandle ("descriptorWithShape:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithShape_SequenceLengths_SortedSequences_DataType_X = "descriptorWithShape:sequenceLengths:sortedSequences:dataType:";
		static readonly NativeHandle selDescriptorWithShape_SequenceLengths_SortedSequences_DataType_XHandle = Selector.GetHandle ("descriptorWithShape:sequenceLengths:sortedSequences:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithWidth_Height_FeatureChannelCount_BatchSize_X = "descriptorWithWidth:height:featureChannelCount:batchSize:";
		static readonly NativeHandle selDescriptorWithWidth_Height_FeatureChannelCount_BatchSize_XHandle = Selector.GetHandle ("descriptorWithWidth:height:featureChannelCount:batchSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithWidth_Height_FeatureChannelCount_BatchSize_DataType_X = "descriptorWithWidth:height:featureChannelCount:batchSize:dataType:";
		static readonly NativeHandle selDescriptorWithWidth_Height_FeatureChannelCount_BatchSize_DataType_XHandle = Selector.GetHandle ("descriptorWithWidth:height:featureChannelCount:batchSize:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDimensionCountX = "dimensionCount";
		static readonly NativeHandle selDimensionCountXHandle = Selector.GetHandle ("dimensionCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxTensorDimensionsX = "maxTensorDimensions";
		static readonly NativeHandle selMaxTensorDimensionsXHandle = Selector.GetHandle ("maxTensorDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSequenceLengthsX = "sequenceLengths";
		static readonly NativeHandle selSequenceLengthsXHandle = Selector.GetHandle ("sequenceLengths");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeX = "shape";
		static readonly NativeHandle selShapeXHandle = Selector.GetHandle ("shape");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortedSequencesX = "sortedSequences";
		static readonly NativeHandle selSortedSequencesXHandle = Selector.GetHandle ("sortedSequences");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideX = "stride";
		static readonly NativeHandle selStrideXHandle = Selector.GetHandle ("stride");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorAllocationSizeInBytesX = "tensorAllocationSizeInBytes";
		static readonly NativeHandle selTensorAllocationSizeInBytesXHandle = Selector.GetHandle ("tensorAllocationSizeInBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCTensorDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected MLCTensorDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MLCTensorDescriptor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("descriptorWithShape:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, MLCDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (class_ptr, selDescriptorWithShape_DataType_XHandle, nsb_shape.GetHandle (), (int)dataType), false)!;
			return ret;
		}
		[Export ("descriptorWithShape:sequenceLengths:sortedSequences:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, [BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] sequenceLengths, bool sortedSequences, MLCDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			if (sequenceLengths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sequenceLengths));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			using var nsb_sequenceLengths = NSArray.FromNSObjects (o => new NSNumber (o), sequenceLengths);
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_int (class_ptr, selDescriptorWithShape_SequenceLengths_SortedSequences_DataType_XHandle, nsb_shape.GetHandle (), nsb_sequenceLengths.GetHandle (), sortedSequences ? (byte) 1 : (byte) 0, (int)dataType), false)!;
			return ret;
		}
		[Export ("descriptorWithWidth:height:featureChannelCount:batchSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? Create (nuint width, nuint height, nuint featureChannels, nuint batchSize)
		{
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selDescriptorWithWidth_Height_FeatureChannelCount_BatchSize_XHandle, width, height, featureChannels, batchSize), false)!;
			return ret;
		}
		[Export ("descriptorWithWidth:height:featureChannelCount:batchSize:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? Create (nuint width, nuint height, nuint featureChannelCount, nuint batchSize, MLCDataType dataType)
		{
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_int (class_ptr, selDescriptorWithWidth_Height_FeatureChannelCount_BatchSize_DataType_XHandle, width, height, featureChannelCount, batchSize, (int)dataType), false)!;
			return ret;
		}
		[Export ("convolutionBiasesDescriptorWithFeatureChannelCount:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? CreateConvolutionBiases (nuint featureChannelCount, MLCDataType dataType)
		{
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_int (class_ptr, selConvolutionBiasesDescriptorWithFeatureChannelCount_DataType_XHandle, featureChannelCount, (int)dataType), false)!;
			return ret;
		}
		[Export ("convolutionWeightsDescriptorWithWidth:height:inputFeatureChannelCount:outputFeatureChannelCount:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? CreateConvolutionWeights (nuint width, nuint height, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, MLCDataType dataType)
		{
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_int (class_ptr, selConvolutionWeightsDescriptorWithWidth_Height_InputFeatureChannelCount_OutputFeatureChannelCount_DataType_XHandle, width, height, inputFeatureChannelCount, outputFeatureChannelCount, (int)dataType), false)!;
			return ret;
		}
		[Export ("convolutionWeightsDescriptorWithInputFeatureChannelCount:outputFeatureChannelCount:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensorDescriptor? CreateConvolutionWeights (nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, MLCDataType dataType)
		{
			MLCTensorDescriptor ret;
			ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_int (class_ptr, selConvolutionWeightsDescriptorWithInputFeatureChannelCount_OutputFeatureChannelCount_DataType_XHandle, inputFeatureChannelCount, outputFeatureChannelCount, (int)dataType), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))]
		public virtual nint[]? BatchSizePerSequenceStep {
			[Export ("batchSizePerSequenceStep", ArgumentSemantic.Copy)]
			get {
				nint[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBatchSizePerSequenceStepXHandle), NSNumber.ToNInt, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBatchSizePerSequenceStepXHandle), NSNumber.ToNInt, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCDataType DataType {
			[Export ("dataType")]
			get {
				MLCDataType ret;
				if (IsDirectBinding) {
					ret = (MLCDataType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDataTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLCDataType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selDataTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DimensionCount {
			[Export ("dimensionCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDimensionCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDimensionCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint MaxTensorDimensions {
			[Export ("maxTensorDimensions")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selMaxTensorDimensionsXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))]
		public virtual nint[]? SequenceLengths {
			[Export ("sequenceLengths", ArgumentSemantic.Copy)]
			get {
				nint[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSequenceLengthsXHandle), NSNumber.ToNInt, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSequenceLengthsXHandle), NSNumber.ToNInt, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))]
		public virtual nint[] Shape {
			[Export ("shape", ArgumentSemantic.Copy)]
			get {
				nint[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShapeXHandle), NSNumber.ToNInt, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShapeXHandle), NSNumber.ToNInt, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SortedSequences {
			[Export ("sortedSequences")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSortedSequencesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSortedSequencesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))]
		public virtual nint[] Stride {
			[Export ("stride", ArgumentSemantic.Copy)]
			get {
				nint[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStrideXHandle), NSNumber.ToNInt, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <nint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStrideXHandle), NSNumber.ToNInt, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint TensorAllocationSizeInBytes {
			[Export ("tensorAllocationSizeInBytes")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTensorAllocationSizeInBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTensorAllocationSizeInBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MLCTensorDescriptor */
}
