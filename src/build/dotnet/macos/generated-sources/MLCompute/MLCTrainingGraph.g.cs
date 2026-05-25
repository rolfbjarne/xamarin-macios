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
	[Register("MLCTrainingGraph", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCTrainingGraph : MLCGraph {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddInputs_LossLabels_X = "addInputs:lossLabels:";
		static readonly NativeHandle selAddInputs_LossLabels_XHandle = Selector.GetHandle ("addInputs:lossLabels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddInputs_LossLabels_LossLabelWeights_X = "addInputs:lossLabels:lossLabelWeights:";
		static readonly NativeHandle selAddInputs_LossLabels_LossLabelWeights_XHandle = Selector.GetHandle ("addInputs:lossLabels:lossLabelWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOutputs_X = "addOutputs:";
		static readonly NativeHandle selAddOutputs_XHandle = Selector.GetHandle ("addOutputs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllocateUserGradientForTensor_X = "allocateUserGradientForTensor:";
		static readonly NativeHandle selAllocateUserGradientForTensor_XHandle = Selector.GetHandle ("allocateUserGradientForTensor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBindOptimizerData_DeviceData_WithTensor_X = "bindOptimizerData:deviceData:withTensor:";
		static readonly NativeHandle selBindOptimizerData_DeviceData_WithTensor_XHandle = Selector.GetHandle ("bindOptimizerData:deviceData:withTensor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompileOptimizer_X = "compileOptimizer:";
		static readonly NativeHandle selCompileOptimizer_XHandle = Selector.GetHandle ("compileOptimizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompileWithOptions_Device_X = "compileWithOptions:device:";
		static readonly NativeHandle selCompileWithOptions_Device_XHandle = Selector.GetHandle ("compileWithOptions:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompileWithOptions_Device_InputTensors_InputTensorsData_X = "compileWithOptions:device:inputTensors:inputTensorsData:";
		static readonly NativeHandle selCompileWithOptions_Device_InputTensors_InputTensorsData_XHandle = Selector.GetHandle ("compileWithOptions:device:inputTensors:inputTensorsData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceMemorySizeX = "deviceMemorySize";
		static readonly NativeHandle selDeviceMemorySizeXHandle = Selector.GetHandle ("deviceMemorySize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteForwardWithBatchSize_Options_CompletionHandler_X = "executeForwardWithBatchSize:options:completionHandler:";
		static readonly NativeHandle selExecuteForwardWithBatchSize_Options_CompletionHandler_XHandle = Selector.GetHandle ("executeForwardWithBatchSize:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteForwardWithBatchSize_Options_OutputsData_CompletionHandler_X = "executeForwardWithBatchSize:options:outputsData:completionHandler:";
		static readonly NativeHandle selExecuteForwardWithBatchSize_Options_OutputsData_CompletionHandler_XHandle = Selector.GetHandle ("executeForwardWithBatchSize:options:outputsData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteGradientWithBatchSize_Options_CompletionHandler_X = "executeGradientWithBatchSize:options:completionHandler:";
		static readonly NativeHandle selExecuteGradientWithBatchSize_Options_CompletionHandler_XHandle = Selector.GetHandle ("executeGradientWithBatchSize:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteGradientWithBatchSize_Options_OutputsData_CompletionHandler_X = "executeGradientWithBatchSize:options:outputsData:completionHandler:";
		static readonly NativeHandle selExecuteGradientWithBatchSize_Options_OutputsData_CompletionHandler_XHandle = Selector.GetHandle ("executeGradientWithBatchSize:options:outputsData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteOptimizerUpdateWithOptions_CompletionHandler_X = "executeOptimizerUpdateWithOptions:completionHandler:";
		static readonly NativeHandle selExecuteOptimizerUpdateWithOptions_CompletionHandler_XHandle = Selector.GetHandle ("executeOptimizerUpdateWithOptions:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_BatchSize_Options_CompletionHandler_X = "executeWithInputsData:lossLabelsData:lossLabelWeightsData:batchSize:options:completionHandler:";
		static readonly NativeHandle selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_BatchSize_Options_CompletionHandler_XHandle = Selector.GetHandle ("executeWithInputsData:lossLabelsData:lossLabelWeightsData:batchSize:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_OutputsData_BatchSize_Options_CompletionHandler_X = "executeWithInputsData:lossLabelsData:lossLabelWeightsData:outputsData:batchSize:options:completionHandler:";
		static readonly NativeHandle selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_OutputsData_BatchSize_Options_CompletionHandler_XHandle = Selector.GetHandle ("executeWithInputsData:lossLabelsData:lossLabelWeightsData:outputsData:batchSize:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientDataForParameter_Layer_X = "gradientDataForParameter:layer:";
		static readonly NativeHandle selGradientDataForParameter_Layer_XHandle = Selector.GetHandle ("gradientDataForParameter:layer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientTensorForInput_X = "gradientTensorForInput:";
		static readonly NativeHandle selGradientTensorForInput_XHandle = Selector.GetHandle ("gradientTensorForInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphWithGraphObjects_LossLayer_Optimizer_X = "graphWithGraphObjects:lossLayer:optimizer:";
		static readonly NativeHandle selGraphWithGraphObjects_LossLayer_Optimizer_XHandle = Selector.GetHandle ("graphWithGraphObjects:lossLayer:optimizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkWithGraphs_X = "linkWithGraphs:";
		static readonly NativeHandle selLinkWithGraphs_XHandle = Selector.GetHandle ("linkWithGraphs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptimizerX = "optimizer";
		static readonly NativeHandle selOptimizerXHandle = Selector.GetHandle ("optimizer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultGradientTensorsForLayer_X = "resultGradientTensorsForLayer:";
		static readonly NativeHandle selResultGradientTensorsForLayer_XHandle = Selector.GetHandle ("resultGradientTensorsForLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTrainingTensorParameters_X = "setTrainingTensorParameters:";
		static readonly NativeHandle selSetTrainingTensorParameters_XHandle = Selector.GetHandle ("setTrainingTensorParameters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceGradientTensorsForLayer_X = "sourceGradientTensorsForLayer:";
		static readonly NativeHandle selSourceGradientTensorsForLayer_XHandle = Selector.GetHandle ("sourceGradientTensorsForLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopGradientForTensors_X = "stopGradientForTensors:";
		static readonly NativeHandle selStopGradientForTensors_XHandle = Selector.GetHandle ("stopGradientForTensors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeUpdatesX = "synchronizeUpdates";
		static readonly NativeHandle selSynchronizeUpdatesXHandle = Selector.GetHandle ("synchronizeUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCTrainingGraph");
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
		protected MLCTrainingGraph (NSObjectFlag t) : base (t)
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
		protected internal MLCTrainingGraph (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addInputs:lossLabels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddInputs (NSDictionary<NSString, MLCTensor> inputs, NSDictionary<NSString, MLCTensor>? lossLabels)
		{
			var inputs__handle__ = inputs!.GetNonNullHandle (nameof (inputs));
			var lossLabels__handle__ = lossLabels.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddInputs_LossLabels_XHandle, inputs__handle__, lossLabels__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddInputs_LossLabels_XHandle, inputs__handle__, lossLabels__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputs);
			GC.KeepAlive (lossLabels);
			return ret != 0;
		}
		[Export ("addInputs:lossLabels:lossLabelWeights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddInputs (NSDictionary<NSString, MLCTensor> inputs, NSDictionary<NSString, MLCTensor>? lossLabels, NSDictionary<NSString, MLCTensor>? lossLabelWeights)
		{
			var inputs__handle__ = inputs!.GetNonNullHandle (nameof (inputs));
			var lossLabels__handle__ = lossLabels.GetHandle ();
			var lossLabelWeights__handle__ = lossLabelWeights.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddInputs_LossLabels_LossLabelWeights_XHandle, inputs__handle__, lossLabels__handle__, lossLabelWeights__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddInputs_LossLabels_LossLabelWeights_XHandle, inputs__handle__, lossLabels__handle__, lossLabelWeights__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputs);
			GC.KeepAlive (lossLabels);
			GC.KeepAlive (lossLabelWeights);
			return ret != 0;
		}
		[Export ("addOutputs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddOutputs (NSDictionary<NSString, MLCTensor> outputs)
		{
			var outputs__handle__ = outputs!.GetNonNullHandle (nameof (outputs));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAddOutputs_XHandle, outputs__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOutputs_XHandle, outputs__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputs);
			return ret != 0;
		}
		[Export ("allocateUserGradientForTensor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? AllocateUserGradient (MLCTensor tensor)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAllocateUserGradientForTensor_XHandle, tensor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAllocateUserGradientForTensor_XHandle, tensor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tensor);
			return ret!;
		}
		[Export ("bindOptimizerData:deviceData:withTensor:")]
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindOptimizer (MLCTensorData[] data, MLCTensorOptimizerDeviceData[]? deviceData, MLCTensor tensor)
		{
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsa_data = NSArray.FromNSObjects (data);
			using var nsa_deviceData = deviceData is null ? null : NSArray.FromNSObjects (deviceData);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selBindOptimizerData_DeviceData_WithTensor_XHandle, nsa_data.Handle, nsa_deviceData.GetHandle (), tensor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selBindOptimizerData_DeviceData_WithTensor_XHandle, nsa_data.Handle, nsa_deviceData.GetHandle (), tensor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tensor);
			return ret != 0;
		}
		[Export ("compileWithOptions:device:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Compile (MLCGraphCompilationOptions options, MLCDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt64_NativeHandle (this.Handle, selCompileWithOptions_Device_XHandle, (UInt64)options, device__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt64_NativeHandle (&__objc_super__, selCompileWithOptions_Device_XHandle, (UInt64)options, device__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			return ret != 0;
		}
		[Export ("compileWithOptions:device:inputTensors:inputTensorsData:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Compile (MLCGraphCompilationOptions options, MLCDevice device, NSDictionary<NSString, MLCTensor>? inputTensors, NSDictionary<NSString, MLCTensorData>? inputTensorsData)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var inputTensors__handle__ = inputTensors.GetHandle ();
			var inputTensorsData__handle__ = inputTensorsData.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt64_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCompileWithOptions_Device_InputTensors_InputTensorsData_XHandle, (UInt64)options, device__handle__, inputTensors__handle__, inputTensorsData__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt64_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCompileWithOptions_Device_InputTensors_InputTensorsData_XHandle, (UInt64)options, device__handle__, inputTensors__handle__, inputTensorsData__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (inputTensors);
			GC.KeepAlive (inputTensorsData);
			return ret != 0;
		}
		[Export ("compileOptimizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Compile (MLCOptimizer optimizer)
		{
			var optimizer__handle__ = optimizer!.GetNonNullHandle (nameof (optimizer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCompileOptimizer_XHandle, optimizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompileOptimizer_XHandle, optimizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (optimizer);
			return ret != 0;
		}
		[Export ("graphWithGraphObjects:lossLayer:optimizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCTrainingGraph Create (MLCGraph[] graphObjects, MLCLayer? lossLayer, MLCOptimizer? optimizer)
		{
			if (graphObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (graphObjects));
			var lossLayer__handle__ = lossLayer.GetHandle ();
			var optimizer__handle__ = optimizer.GetHandle ();
			using var nsa_graphObjects = NSArray.FromNSObjects (graphObjects);
			MLCTrainingGraph? ret;
			ret =  Runtime.GetNSObject<MLCTrainingGraph> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selGraphWithGraphObjects_LossLayer_Optimizer_XHandle, nsa_graphObjects.Handle, lossLayer__handle__, optimizer__handle__), false)!;
			GC.KeepAlive (lossLayer);
			GC.KeepAlive (optimizer);
			return ret!;
		}
		[Export ("executeWithInputsData:lossLabelsData:lossLabelWeightsData:batchSize:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Execute (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensorData>? lossLabelsData, NSDictionary<NSString, MLCTensorData>? lossLabelWeightsData, nuint batchSize, MLCExecutionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			var inputsData__handle__ = inputsData!.GetNonNullHandle (nameof (inputsData));
			var lossLabelsData__handle__ = lossLabelsData.GetHandle ();
			var lossLabelWeightsData__handle__ = lossLabelWeightsData.GetHandle ();
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UInt64_NativeHandle (this.Handle, selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_BatchSize_Options_CompletionHandler_XHandle, inputsData__handle__, lossLabelsData__handle__, lossLabelWeightsData__handle__, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UInt64_NativeHandle (&__objc_super__, selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_BatchSize_Options_CompletionHandler_XHandle, inputsData__handle__, lossLabelsData__handle__, lossLabelWeightsData__handle__, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputsData);
			GC.KeepAlive (lossLabelsData);
			GC.KeepAlive (lossLabelWeightsData);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteAsync (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensorData>? lossLabelsData, NSDictionary<NSString, MLCTensorData>? lossLabelWeightsData, nuint batchSize, MLCExecutionOptions options)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			Execute(inputsData, lossLabelsData, lossLabelWeightsData, batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteAsync (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensorData>? lossLabelsData, NSDictionary<NSString, MLCTensorData>? lossLabelWeightsData, nuint batchSize, MLCExecutionOptions options, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = Execute(inputsData, lossLabelsData, lossLabelWeightsData, batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("executeWithInputsData:lossLabelsData:lossLabelWeightsData:outputsData:batchSize:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Execute (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensorData>? lossLabelsData, NSDictionary<NSString, MLCTensorData>? lossLabelWeightsData, NSDictionary<NSString, MLCTensorData>? outputsData, nuint batchSize, MLCExecutionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			var inputsData__handle__ = inputsData!.GetNonNullHandle (nameof (inputsData));
			var lossLabelsData__handle__ = lossLabelsData.GetHandle ();
			var lossLabelWeightsData__handle__ = lossLabelWeightsData.GetHandle ();
			var outputsData__handle__ = outputsData.GetHandle ();
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UInt64_NativeHandle (this.Handle, selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_OutputsData_BatchSize_Options_CompletionHandler_XHandle, inputsData__handle__, lossLabelsData__handle__, lossLabelWeightsData__handle__, outputsData__handle__, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UInt64_NativeHandle (&__objc_super__, selExecuteWithInputsData_LossLabelsData_LossLabelWeightsData_OutputsData_BatchSize_Options_CompletionHandler_XHandle, inputsData__handle__, lossLabelsData__handle__, lossLabelWeightsData__handle__, outputsData__handle__, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputsData);
			GC.KeepAlive (lossLabelsData);
			GC.KeepAlive (lossLabelWeightsData);
			GC.KeepAlive (outputsData);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteAsync (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensorData>? lossLabelsData, NSDictionary<NSString, MLCTensorData>? lossLabelWeightsData, NSDictionary<NSString, MLCTensorData>? outputsData, nuint batchSize, MLCExecutionOptions options)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			Execute(inputsData, lossLabelsData, lossLabelWeightsData, outputsData, batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteAsync (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensorData>? lossLabelsData, NSDictionary<NSString, MLCTensorData>? lossLabelWeightsData, NSDictionary<NSString, MLCTensorData>? outputsData, nuint batchSize, MLCExecutionOptions options, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = Execute(inputsData, lossLabelsData, lossLabelWeightsData, outputsData, batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("executeForwardWithBatchSize:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteForward (nuint batchSize, MLCExecutionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr_UInt64_NativeHandle (this.Handle, selExecuteForwardWithBatchSize_Options_CompletionHandler_XHandle, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr_UInt64_NativeHandle (&__objc_super__, selExecuteForwardWithBatchSize_Options_CompletionHandler_XHandle, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteForwardAsync (nuint batchSize, MLCExecutionOptions options)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			ExecuteForward(batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteForwardAsync (nuint batchSize, MLCExecutionOptions options, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = ExecuteForward(batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("executeForwardWithBatchSize:options:outputsData:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteForward (nuint batchSize, MLCExecutionOptions options, NSDictionary<NSString, MLCTensorData>? outputsData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			var outputsData__handle__ = outputsData.GetHandle ();
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr_UInt64_NativeHandle_NativeHandle (this.Handle, selExecuteForwardWithBatchSize_Options_OutputsData_CompletionHandler_XHandle, batchSize, (UInt64)options, outputsData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr_UInt64_NativeHandle_NativeHandle (&__objc_super__, selExecuteForwardWithBatchSize_Options_OutputsData_CompletionHandler_XHandle, batchSize, (UInt64)options, outputsData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputsData);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteForwardAsync (nuint batchSize, MLCExecutionOptions options, NSDictionary<NSString, MLCTensorData>? outputsData)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			ExecuteForward(batchSize, options, outputsData, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteForwardAsync (nuint batchSize, MLCExecutionOptions options, NSDictionary<NSString, MLCTensorData>? outputsData, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = ExecuteForward(batchSize, options, outputsData, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("executeGradientWithBatchSize:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteGradient (nuint batchSize, MLCExecutionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr_UInt64_NativeHandle (this.Handle, selExecuteGradientWithBatchSize_Options_CompletionHandler_XHandle, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr_UInt64_NativeHandle (&__objc_super__, selExecuteGradientWithBatchSize_Options_CompletionHandler_XHandle, batchSize, (UInt64)options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteGradientAsync (nuint batchSize, MLCExecutionOptions options)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			ExecuteGradient(batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteGradientAsync (nuint batchSize, MLCExecutionOptions options, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = ExecuteGradient(batchSize, options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("executeGradientWithBatchSize:options:outputsData:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteGradient (nuint batchSize, MLCExecutionOptions options, NSDictionary<NSString, MLCTensorData>? outputsData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			var outputsData__handle__ = outputsData.GetHandle ();
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr_UInt64_NativeHandle_NativeHandle (this.Handle, selExecuteGradientWithBatchSize_Options_OutputsData_CompletionHandler_XHandle, batchSize, (UInt64)options, outputsData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr_UInt64_NativeHandle_NativeHandle (&__objc_super__, selExecuteGradientWithBatchSize_Options_OutputsData_CompletionHandler_XHandle, batchSize, (UInt64)options, outputsData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputsData);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteGradientAsync (nuint batchSize, MLCExecutionOptions options, NSDictionary<NSString, MLCTensorData>? outputsData)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			ExecuteGradient(batchSize, options, outputsData, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteGradientAsync (nuint batchSize, MLCExecutionOptions options, NSDictionary<NSString, MLCTensorData>? outputsData, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = ExecuteGradient(batchSize, options, outputsData, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("executeOptimizerUpdateWithOptions:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteOptimizerUpdate (MLCExecutionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMLCGraphCompletionHandler))]MLCGraphCompletionHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDMLCGraphCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt64_NativeHandle (this.Handle, selExecuteOptimizerUpdateWithOptions_CompletionHandler_XHandle, (UInt64)options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt64_NativeHandle (&__objc_super__, selExecuteOptimizerUpdateWithOptions_CompletionHandler_XHandle, (UInt64)options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteOptimizerUpdateAsync (MLCExecutionOptions options)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			ExecuteOptimizerUpdate(options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLCGraphCompletionResult> ExecuteOptimizerUpdateAsync (MLCExecutionOptions options, out bool result)
		{
			var tcs = new TaskCompletionSource<MLCGraphCompletionResult> ();
			result = ExecuteOptimizerUpdate(options, (resultTensor_, error_, executionTime_) => {
				tcs.SetResult (new MLCGraphCompletionResult (resultTensor_!, error_!, executionTime_!));
			})!;
			return tcs.Task;
		}
		[Export ("gradientDataForParameter:layer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetGradientData (MLCTensor parameter, MLCLayer layer)
		{
			var parameter__handle__ = parameter!.GetNonNullHandle (nameof (parameter));
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGradientDataForParameter_Layer_XHandle, parameter__handle__, layer__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGradientDataForParameter_Layer_XHandle, parameter__handle__, layer__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parameter);
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("gradientTensorForInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? GetGradientTensor (MLCTensor input)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientTensorForInput_XHandle, input__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientTensorForInput_XHandle, input__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
			return ret!;
		}
		[Export ("resultGradientTensorsForLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor[] GetResultGradientTensors (MLCLayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			MLCTensor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selResultGradientTensorsForLayer_XHandle, layer__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selResultGradientTensorsForLayer_XHandle, layer__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("sourceGradientTensorsForLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor[] GetSourceGradientTensors (MLCLayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			MLCTensor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSourceGradientTensorsForLayer_XHandle, layer__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSourceGradientTensorsForLayer_XHandle, layer__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("linkWithGraphs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Link (MLCTrainingGraph[] graphs)
		{
			if (graphs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (graphs));
			using var nsa_graphs = NSArray.FromNSObjects (graphs);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selLinkWithGraphs_XHandle, nsa_graphs.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selLinkWithGraphs_XHandle, nsa_graphs.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("setTrainingTensorParameters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetTrainingTensorParameters (MLCTensorParameter[] parameters)
		{
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSetTrainingTensorParameters_XHandle, nsa_parameters.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTrainingTensorParameters_XHandle, nsa_parameters.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("stopGradientForTensors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StopGradient (MLCTensor[] tensors)
		{
			if (tensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tensors));
			using var nsa_tensors = NSArray.FromNSObjects (tensors);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selStopGradientForTensors_XHandle, nsa_tensors.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopGradientForTensors_XHandle, nsa_tensors.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("synchronizeUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SynchronizeUpdates ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSynchronizeUpdatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSynchronizeUpdatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DeviceMemorySize {
			[Export ("deviceMemorySize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDeviceMemorySizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDeviceMemorySizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCOptimizer? Optimizer {
			[Export ("optimizer", ArgumentSemantic.Retain)]
			get {
				MLCOptimizer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLCOptimizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOptimizerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLCOptimizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOptimizerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MLCTrainingGraph */
	//
	// Async result classes
	//
}
