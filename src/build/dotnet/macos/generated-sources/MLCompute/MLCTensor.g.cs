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
	[Register("MLCTensor", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCTensor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBindAndWriteData_ToDevice_X = "bindAndWriteData:toDevice:";
		static readonly NativeHandle selBindAndWriteData_ToDevice_XHandle = Selector.GetHandle ("bindAndWriteData:toDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBindOptimizerData_DeviceData_X = "bindOptimizerData:deviceData:";
		static readonly NativeHandle selBindOptimizerData_DeviceData_XHandle = Selector.GetHandle ("bindOptimizerData:deviceData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyDataFromDeviceMemoryToBytes_Length_SynchronizeWithDevice_X = "copyDataFromDeviceMemoryToBytes:length:synchronizeWithDevice:";
		static readonly NativeHandle selCopyDataFromDeviceMemoryToBytes_Length_SynchronizeWithDevice_XHandle = Selector.GetHandle ("copyDataFromDeviceMemoryToBytes:length:synchronizeWithDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataX = "data";
		static readonly NativeHandle selDataXHandle = Selector.GetHandle ("data");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorX = "descriptor";
		static readonly NativeHandle selDescriptorXHandle = Selector.GetHandle ("descriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasValidNumericsX = "hasValidNumerics";
		static readonly NativeHandle selHasValidNumericsXHandle = Selector.GetHandle ("hasValidNumerics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptimizerDataX = "optimizerData";
		static readonly NativeHandle selOptimizerDataXHandle = Selector.GetHandle ("optimizerData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptimizerDeviceDataX = "optimizerDeviceData";
		static readonly NativeHandle selOptimizerDeviceDataXHandle = Selector.GetHandle ("optimizerDeviceData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_X = "setLabel:";
		static readonly NativeHandle selSetLabel_XHandle = Selector.GetHandle ("setLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeDataX = "synchronizeData";
		static readonly NativeHandle selSynchronizeDataXHandle = Selector.GetHandle ("synchronizeData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeOptimizerDataX = "synchronizeOptimizerData";
		static readonly NativeHandle selSynchronizeOptimizerDataXHandle = Selector.GetHandle ("synchronizeOptimizerData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorByDequantizingToType_Scale_Bias_X = "tensorByDequantizingToType:scale:bias:";
		static readonly NativeHandle selTensorByDequantizingToType_Scale_Bias_XHandle = Selector.GetHandle ("tensorByDequantizingToType:scale:bias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorByDequantizingToType_Scale_Bias_Axis_X = "tensorByDequantizingToType:scale:bias:axis:";
		static readonly NativeHandle selTensorByDequantizingToType_Scale_Bias_Axis_XHandle = Selector.GetHandle ("tensorByDequantizingToType:scale:bias:axis:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorByQuantizingToType_Scale_Bias_X = "tensorByQuantizingToType:scale:bias:";
		static readonly NativeHandle selTensorByQuantizingToType_Scale_Bias_XHandle = Selector.GetHandle ("tensorByQuantizingToType:scale:bias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorByQuantizingToType_Scale_Bias_Axis_X = "tensorByQuantizingToType:scale:bias:axis:";
		static readonly NativeHandle selTensorByQuantizingToType_Scale_Bias_Axis_XHandle = Selector.GetHandle ("tensorByQuantizingToType:scale:bias:axis:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorIDX = "tensorID";
		static readonly NativeHandle selTensorIDXHandle = Selector.GetHandle ("tensorID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithDescriptor_X = "tensorWithDescriptor:";
		static readonly NativeHandle selTensorWithDescriptor_XHandle = Selector.GetHandle ("tensorWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithDescriptor_Data_X = "tensorWithDescriptor:data:";
		static readonly NativeHandle selTensorWithDescriptor_Data_XHandle = Selector.GetHandle ("tensorWithDescriptor:data:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithDescriptor_FillWithData_X = "tensorWithDescriptor:fillWithData:";
		static readonly NativeHandle selTensorWithDescriptor_FillWithData_XHandle = Selector.GetHandle ("tensorWithDescriptor:fillWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithDescriptor_RandomInitializerType_X = "tensorWithDescriptor:randomInitializerType:";
		static readonly NativeHandle selTensorWithDescriptor_RandomInitializerType_XHandle = Selector.GetHandle ("tensorWithDescriptor:randomInitializerType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithSequenceLength_FeatureChannelCount_BatchSize_X = "tensorWithSequenceLength:featureChannelCount:batchSize:";
		static readonly NativeHandle selTensorWithSequenceLength_FeatureChannelCount_BatchSize_XHandle = Selector.GetHandle ("tensorWithSequenceLength:featureChannelCount:batchSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithSequenceLength_FeatureChannelCount_BatchSize_Data_X = "tensorWithSequenceLength:featureChannelCount:batchSize:data:";
		static readonly NativeHandle selTensorWithSequenceLength_FeatureChannelCount_BatchSize_Data_XHandle = Selector.GetHandle ("tensorWithSequenceLength:featureChannelCount:batchSize:data:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithSequenceLength_FeatureChannelCount_BatchSize_RandomInitializerType_X = "tensorWithSequenceLength:featureChannelCount:batchSize:randomInitializerType:";
		static readonly NativeHandle selTensorWithSequenceLength_FeatureChannelCount_BatchSize_RandomInitializerType_XHandle = Selector.GetHandle ("tensorWithSequenceLength:featureChannelCount:batchSize:randomInitializerType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithSequenceLengths_SortedSequences_FeatureChannelCount_BatchSize_Data_X = "tensorWithSequenceLengths:sortedSequences:featureChannelCount:batchSize:data:";
		static readonly NativeHandle selTensorWithSequenceLengths_SortedSequences_FeatureChannelCount_BatchSize_Data_XHandle = Selector.GetHandle ("tensorWithSequenceLengths:sortedSequences:featureChannelCount:batchSize:data:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithSequenceLengths_SortedSequences_FeatureChannelCount_BatchSize_RandomInitializerType_X = "tensorWithSequenceLengths:sortedSequences:featureChannelCount:batchSize:randomInitializerType:";
		static readonly NativeHandle selTensorWithSequenceLengths_SortedSequences_FeatureChannelCount_BatchSize_RandomInitializerType_XHandle = Selector.GetHandle ("tensorWithSequenceLengths:sortedSequences:featureChannelCount:batchSize:randomInitializerType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithShape_X = "tensorWithShape:";
		static readonly NativeHandle selTensorWithShape_XHandle = Selector.GetHandle ("tensorWithShape:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithShape_Data_DataType_X = "tensorWithShape:data:dataType:";
		static readonly NativeHandle selTensorWithShape_Data_DataType_XHandle = Selector.GetHandle ("tensorWithShape:data:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithShape_DataType_X = "tensorWithShape:dataType:";
		static readonly NativeHandle selTensorWithShape_DataType_XHandle = Selector.GetHandle ("tensorWithShape:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithShape_FillWithData_DataType_X = "tensorWithShape:fillWithData:dataType:";
		static readonly NativeHandle selTensorWithShape_FillWithData_DataType_XHandle = Selector.GetHandle ("tensorWithShape:fillWithData:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithShape_RandomInitializerType_X = "tensorWithShape:randomInitializerType:";
		static readonly NativeHandle selTensorWithShape_RandomInitializerType_XHandle = Selector.GetHandle ("tensorWithShape:randomInitializerType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithShape_RandomInitializerType_DataType_X = "tensorWithShape:randomInitializerType:dataType:";
		static readonly NativeHandle selTensorWithShape_RandomInitializerType_DataType_XHandle = Selector.GetHandle ("tensorWithShape:randomInitializerType:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithWidth_Height_FeatureChannelCount_BatchSize_X = "tensorWithWidth:height:featureChannelCount:batchSize:";
		static readonly NativeHandle selTensorWithWidth_Height_FeatureChannelCount_BatchSize_XHandle = Selector.GetHandle ("tensorWithWidth:height:featureChannelCount:batchSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithWidth_Height_FeatureChannelCount_BatchSize_Data_X = "tensorWithWidth:height:featureChannelCount:batchSize:data:";
		static readonly NativeHandle selTensorWithWidth_Height_FeatureChannelCount_BatchSize_Data_XHandle = Selector.GetHandle ("tensorWithWidth:height:featureChannelCount:batchSize:data:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithWidth_Height_FeatureChannelCount_BatchSize_Data_DataType_X = "tensorWithWidth:height:featureChannelCount:batchSize:data:dataType:";
		static readonly NativeHandle selTensorWithWidth_Height_FeatureChannelCount_BatchSize_Data_DataType_XHandle = Selector.GetHandle ("tensorWithWidth:height:featureChannelCount:batchSize:data:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithWidth_Height_FeatureChannelCount_BatchSize_FillWithData_DataType_X = "tensorWithWidth:height:featureChannelCount:batchSize:fillWithData:dataType:";
		static readonly NativeHandle selTensorWithWidth_Height_FeatureChannelCount_BatchSize_FillWithData_DataType_XHandle = Selector.GetHandle ("tensorWithWidth:height:featureChannelCount:batchSize:fillWithData:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTensorWithWidth_Height_FeatureChannelCount_BatchSize_RandomInitializerType_X = "tensorWithWidth:height:featureChannelCount:batchSize:randomInitializerType:";
		static readonly NativeHandle selTensorWithWidth_Height_FeatureChannelCount_BatchSize_RandomInitializerType_XHandle = Selector.GetHandle ("tensorWithWidth:height:featureChannelCount:batchSize:randomInitializerType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCTensor");
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
		protected MLCTensor (NSObjectFlag t) : base (t)
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
		protected internal MLCTensor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("bindAndWriteData:toDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindAndWrite (MLCTensorData data, MLCDevice device)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selBindAndWriteData_ToDevice_XHandle, data__handle__, device__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selBindAndWriteData_ToDevice_XHandle, data__handle__, device__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (device);
			return ret != 0;
		}
		[Export ("bindOptimizerData:deviceData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindOptimizer (MLCTensorData[] data, MLCTensorOptimizerDeviceData[]? deviceData)
		{
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			using var nsa_data = NSArray.FromNSObjects (data);
			using var nsa_deviceData = deviceData is null ? null : NSArray.FromNSObjects (deviceData);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selBindOptimizerData_DeviceData_XHandle, nsa_data.Handle, nsa_deviceData.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selBindOptimizerData_DeviceData_XHandle, nsa_data.Handle, nsa_deviceData.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
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
		[Export ("copyDataFromDeviceMemoryToBytes:length:synchronizeWithDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CopyDataFromDeviceMemory (nint bytes, nuint length, bool synchronizeWithDevice)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_UIntPtr_bool (this.Handle, selCopyDataFromDeviceMemoryToBytes_Length_SynchronizeWithDevice_XHandle, bytes, length, synchronizeWithDevice ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_UIntPtr_bool (&__objc_super__, selCopyDataFromDeviceMemoryToBytes_Length_SynchronizeWithDevice_XHandle, bytes, length, synchronizeWithDevice ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("tensorWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (MLCTensorDescriptor tensorDescriptor)
		{
			var tensorDescriptor__handle__ = tensorDescriptor!.GetNonNullHandle (nameof (tensorDescriptor));
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTensorWithDescriptor_XHandle, tensorDescriptor__handle__), false)!;
			GC.KeepAlive (tensorDescriptor);
			return ret!;
		}
		[Export ("tensorWithDescriptor:randomInitializerType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (MLCTensorDescriptor tensorDescriptor, MLCRandomInitializerType randomInitializerType)
		{
			var tensorDescriptor__handle__ = tensorDescriptor!.GetNonNullHandle (nameof (tensorDescriptor));
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (class_ptr, selTensorWithDescriptor_RandomInitializerType_XHandle, tensorDescriptor__handle__, (int)randomInitializerType), false)!;
			GC.KeepAlive (tensorDescriptor);
			return ret!;
		}
		[Export ("tensorWithDescriptor:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (MLCTensorDescriptor tensorDescriptor, MLCTensorData data)
		{
			var tensorDescriptor__handle__ = tensorDescriptor!.GetNonNullHandle (nameof (tensorDescriptor));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTensorWithDescriptor_Data_XHandle, tensorDescriptor__handle__, data__handle__), false)!;
			GC.KeepAlive (tensorDescriptor);
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("tensorWithShape:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTensorWithShape_XHandle, nsb_shape.GetHandle ()), false)!;
			return ret;
		}
		[Export ("tensorWithShape:randomInitializerType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, MLCRandomInitializerType randomInitializerType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (class_ptr, selTensorWithShape_RandomInitializerType_XHandle, nsb_shape.GetHandle (), (int)randomInitializerType), false)!;
			return ret;
		}
		[Export ("tensorWithShape:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, MLCDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (class_ptr, selTensorWithShape_DataType_XHandle, nsb_shape.GetHandle (), (int)dataType), false)!;
			return ret;
		}
		[Export ("tensorWithShape:data:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, MLCTensorData data, MLCDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_int (class_ptr, selTensorWithShape_Data_DataType_XHandle, nsb_shape.GetHandle (), data__handle__, (int)dataType), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("tensorWithWidth:height:featureChannelCount:batchSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint width, nuint height, nuint featureChannelCount, nuint batchSize)
		{
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selTensorWithWidth_Height_FeatureChannelCount_BatchSize_XHandle, width, height, featureChannelCount, batchSize), false)!;
			return ret;
		}
		[Export ("tensorWithWidth:height:featureChannelCount:batchSize:fillWithData:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint width, nuint height, nuint featureChannelCount, nuint batchSize, float fillWithData, MLCDataType dataType)
		{
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_float_int (class_ptr, selTensorWithWidth_Height_FeatureChannelCount_BatchSize_FillWithData_DataType_XHandle, width, height, featureChannelCount, batchSize, fillWithData, (int)dataType), false)!;
			return ret;
		}
		[Export ("tensorWithWidth:height:featureChannelCount:batchSize:randomInitializerType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint width, nuint height, nuint featureChannelCount, nuint batchSize, MLCRandomInitializerType randomInitializerType)
		{
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_int (class_ptr, selTensorWithWidth_Height_FeatureChannelCount_BatchSize_RandomInitializerType_XHandle, width, height, featureChannelCount, batchSize, (int)randomInitializerType), false)!;
			return ret;
		}
		[Export ("tensorWithWidth:height:featureChannelCount:batchSize:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint width, nuint height, nuint featureChannelCount, nuint batchSize, MLCTensorData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle (class_ptr, selTensorWithWidth_Height_FeatureChannelCount_BatchSize_Data_XHandle, width, height, featureChannelCount, batchSize, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("tensorWithWidth:height:featureChannelCount:batchSize:data:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint width, nuint height, nuint featureChannelCount, nuint batchSize, MLCTensorData data, MLCDataType dataType)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle_int (class_ptr, selTensorWithWidth_Height_FeatureChannelCount_BatchSize_Data_DataType_XHandle, width, height, featureChannelCount, batchSize, data__handle__, (int)dataType), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("tensorWithSequenceLength:featureChannelCount:batchSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint sequenceLength, nuint featureChannelCount, nuint batchSize)
		{
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (class_ptr, selTensorWithSequenceLength_FeatureChannelCount_BatchSize_XHandle, sequenceLength, featureChannelCount, batchSize), false)!;
			return ret;
		}
		[Export ("tensorWithSequenceLength:featureChannelCount:batchSize:randomInitializerType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint sequenceLength, nuint featureChannelCount, nuint batchSize, MLCRandomInitializerType randomInitializerType)
		{
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_int (class_ptr, selTensorWithSequenceLength_FeatureChannelCount_BatchSize_RandomInitializerType_XHandle, sequenceLength, featureChannelCount, batchSize, (int)randomInitializerType), false)!;
			return ret;
		}
		[Export ("tensorWithSequenceLength:featureChannelCount:batchSize:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (nuint sequenceLength, nuint featureChannelCount, nuint batchSize, MLCTensorData? data)
		{
			var data__handle__ = data.GetHandle ();
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle (class_ptr, selTensorWithSequenceLength_FeatureChannelCount_BatchSize_Data_XHandle, sequenceLength, featureChannelCount, batchSize, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("tensorWithSequenceLengths:sortedSequences:featureChannelCount:batchSize:randomInitializerType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor? Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] sequenceLengths, bool sortedSequences, nuint featureChannelCount, nuint batchSize, MLCRandomInitializerType randomInitializerType)
		{
			if (sequenceLengths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sequenceLengths));
			using var nsb_sequenceLengths = NSArray.FromNSObjects (o => new NSNumber (o), sequenceLengths);
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_UIntPtr_UIntPtr_int (class_ptr, selTensorWithSequenceLengths_SortedSequences_FeatureChannelCount_BatchSize_RandomInitializerType_XHandle, nsb_sequenceLengths.GetHandle (), sortedSequences ? (byte) 1 : (byte) 0, featureChannelCount, batchSize, (int)randomInitializerType), false)!;
			return ret;
		}
		[Export ("tensorWithShape:fillWithData:dataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, NSNumber fillData, MLCDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var fillData__handle__ = fillData!.GetNonNullHandle (nameof (fillData));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_int (class_ptr, selTensorWithShape_FillWithData_DataType_XHandle, nsb_shape.GetHandle (), fillData__handle__, (int)dataType), false)!;
			GC.KeepAlive (fillData);
			return ret!;
		}
		[Export ("tensorWithDescriptor:fillWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create (MLCTensorDescriptor tensorDescriptor, NSNumber fillData)
		{
			var tensorDescriptor__handle__ = tensorDescriptor!.GetNonNullHandle (nameof (tensorDescriptor));
			var fillData__handle__ = fillData!.GetNonNullHandle (nameof (fillData));
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTensorWithDescriptor_FillWithData_XHandle, tensorDescriptor__handle__, fillData__handle__), false)!;
			GC.KeepAlive (tensorDescriptor);
			GC.KeepAlive (fillData);
			return ret!;
		}
		[Export ("tensorWithSequenceLengths:sortedSequences:featureChannelCount:batchSize:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor? Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] sequenceLengths, bool sortedSequences, nuint featureChannelCount, nuint batchSize, MLCTensorData? data)
		{
			if (sequenceLengths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sequenceLengths));
			var data__handle__ = data.GetHandle ();
			using var nsb_sequenceLengths = NSArray.FromNSObjects (o => new NSNumber (o), sequenceLengths);
			MLCTensor? ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_UIntPtr_UIntPtr_NativeHandle (class_ptr, selTensorWithSequenceLengths_SortedSequences_FeatureChannelCount_BatchSize_Data_XHandle, nsb_sequenceLengths.GetHandle (), sortedSequences ? (byte) 1 : (byte) 0, featureChannelCount, batchSize, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("tensorWithShape:randomInitializerType:dataType:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTensor Create ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, MLCRandomInitializerType randomInitializerType, MLCDataType dataType)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor ret;
			ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_int (class_ptr, selTensorWithShape_RandomInitializerType_DataType_XHandle, nsb_shape.GetHandle (), (int)randomInitializerType, (int)dataType), false)!;
			return ret;
		}
		[Export ("tensorByDequantizingToType:scale:bias:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateByDequantizing (MLCDataType type, MLCTensor scale, MLCTensor bias)
		{
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var bias__handle__ = bias!.GetNonNullHandle (nameof (bias));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle_NativeHandle (this.Handle, selTensorByDequantizingToType_Scale_Bias_XHandle, (int)type, scale__handle__, bias__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_NativeHandle_NativeHandle (&__objc_super__, selTensorByDequantizingToType_Scale_Bias_XHandle, (int)type, scale__handle__, bias__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scale);
			GC.KeepAlive (bias);
			return ret!;
		}
		[Export ("tensorByDequantizingToType:scale:bias:axis:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateByDequantizing (MLCDataType type, MLCTensor scale, MLCTensor bias, nint axis)
		{
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var bias__handle__ = bias!.GetNonNullHandle (nameof (bias));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle_NativeHandle_IntPtr (this.Handle, selTensorByDequantizingToType_Scale_Bias_Axis_XHandle, (int)type, scale__handle__, bias__handle__, axis), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selTensorByDequantizingToType_Scale_Bias_Axis_XHandle, (int)type, scale__handle__, bias__handle__, axis), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scale);
			GC.KeepAlive (bias);
			return ret!;
		}
		[Export ("tensorByQuantizingToType:scale:bias:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateByQuantizing (MLCDataType type, float scale, nint bias)
		{
			MLCTensor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_IntPtr (this.Handle, selTensorByQuantizingToType_Scale_Bias_XHandle, (int)type, scale, bias), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_float_IntPtr (&__objc_super__, selTensorByQuantizingToType_Scale_Bias_XHandle, (int)type, scale, bias), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tensorByQuantizingToType:scale:bias:axis:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateByQuantizing (MLCDataType type, MLCTensor scale, MLCTensor bias, nint axis)
		{
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var bias__handle__ = bias!.GetNonNullHandle (nameof (bias));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle_NativeHandle_IntPtr (this.Handle, selTensorByQuantizingToType_Scale_Bias_Axis_XHandle, (int)type, scale__handle__, bias__handle__, axis), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selTensorByQuantizingToType_Scale_Bias_Axis_XHandle, (int)type, scale__handle__, bias__handle__, axis), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scale);
			GC.KeepAlive (bias);
			return ret!;
		}
		[Export ("synchronizeData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SynchronizeData ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSynchronizeDataXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSynchronizeDataXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("synchronizeOptimizerData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SynchronizeOptimizerData ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSynchronizeOptimizerDataXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSynchronizeOptimizerDataXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Data {
			[Export ("data", ArgumentSemantic.Retain)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensorDescriptor Descriptor {
			[Export ("descriptor", ArgumentSemantic.Copy)]
			get {
				MLCTensorDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLCTensorDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCDevice? Device {
			[Export ("device", ArgumentSemantic.Retain)]
			get {
				MLCDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasValidNumerics {
			[Export ("hasValidNumerics")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasValidNumericsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasValidNumericsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Label {
			[Export ("label")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLabel:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensorData[] OptimizerData {
			[Export ("optimizerData", ArgumentSemantic.Copy)]
			get {
				MLCTensorData[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MLCTensorData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOptimizerDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MLCTensorData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOptimizerDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensorOptimizerDeviceData[] OptimizerDeviceData {
			[Export ("optimizerDeviceData", ArgumentSemantic.Copy)]
			get {
				MLCTensorOptimizerDeviceData[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MLCTensorOptimizerDeviceData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOptimizerDeviceDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MLCTensorOptimizerDeviceData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOptimizerDeviceDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint TensorId {
			[Export ("tensorID")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTensorIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTensorIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MLCTensor */
}
