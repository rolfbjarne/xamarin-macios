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
	[Register("MLCGraph", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCGraph : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBindAndWriteData_ForInputs_ToDevice_BatchSize_Synchronous_X = "bindAndWriteData:forInputs:toDevice:batchSize:synchronous:";
		static readonly NativeHandle selBindAndWriteData_ForInputs_ToDevice_BatchSize_Synchronous_XHandle = Selector.GetHandle ("bindAndWriteData:forInputs:toDevice:batchSize:synchronous:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBindAndWriteData_ForInputs_ToDevice_Synchronous_X = "bindAndWriteData:forInputs:toDevice:synchronous:";
		static readonly NativeHandle selBindAndWriteData_ForInputs_ToDevice_Synchronous_XHandle = Selector.GetHandle ("bindAndWriteData:forInputs:toDevice:synchronous:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConcatenateWithSources_Dimension_X = "concatenateWithSources:dimension:";
		static readonly NativeHandle selConcatenateWithSources_Dimension_XHandle = Selector.GetHandle ("concatenateWithSources:dimension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGatherWithDimension_Source_Indices_X = "gatherWithDimension:source:indices:";
		static readonly NativeHandle selGatherWithDimension_Source_Indices_XHandle = Selector.GetHandle ("gatherWithDimension:source:indices:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphX = "graph";
		static readonly NativeHandle selGraphXHandle = Selector.GetHandle ("graph");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayersX = "layers";
		static readonly NativeHandle selLayersXHandle = Selector.GetHandle ("layers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithLayer_Source_X = "nodeWithLayer:source:";
		static readonly NativeHandle selNodeWithLayer_Source_XHandle = Selector.GetHandle ("nodeWithLayer:source:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithLayer_Sources_X = "nodeWithLayer:sources:";
		static readonly NativeHandle selNodeWithLayer_Sources_XHandle = Selector.GetHandle ("nodeWithLayer:sources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithLayer_Sources_DisableUpdate_X = "nodeWithLayer:sources:disableUpdate:";
		static readonly NativeHandle selNodeWithLayer_Sources_DisableUpdate_XHandle = Selector.GetHandle ("nodeWithLayer:sources:disableUpdate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithLayer_Sources_LossLabels_X = "nodeWithLayer:sources:lossLabels:";
		static readonly NativeHandle selNodeWithLayer_Sources_LossLabels_XHandle = Selector.GetHandle ("nodeWithLayer:sources:lossLabels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReshapeWithShape_Source_X = "reshapeWithShape:source:";
		static readonly NativeHandle selReshapeWithShape_Source_XHandle = Selector.GetHandle ("reshapeWithShape:source:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultTensorsForLayer_X = "resultTensorsForLayer:";
		static readonly NativeHandle selResultTensorsForLayer_XHandle = Selector.GetHandle ("resultTensorsForLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScatterWithDimension_Source_Indices_CopyFrom_ReductionType_X = "scatterWithDimension:source:indices:copyFrom:reductionType:";
		static readonly NativeHandle selScatterWithDimension_Source_Indices_CopyFrom_ReductionType_XHandle = Selector.GetHandle ("scatterWithDimension:source:indices:copyFrom:reductionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectWithSources_Condition_X = "selectWithSources:condition:";
		static readonly NativeHandle selSelectWithSources_Condition_XHandle = Selector.GetHandle ("selectWithSources:condition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceTensorsForLayer_X = "sourceTensorsForLayer:";
		static readonly NativeHandle selSourceTensorsForLayer_XHandle = Selector.GetHandle ("sourceTensorsForLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitWithSource_SplitCount_Dimension_X = "splitWithSource:splitCount:dimension:";
		static readonly NativeHandle selSplitWithSource_SplitCount_Dimension_XHandle = Selector.GetHandle ("splitWithSource:splitCount:dimension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitWithSource_SplitSectionLengths_Dimension_X = "splitWithSource:splitSectionLengths:dimension:";
		static readonly NativeHandle selSplitWithSource_SplitSectionLengths_Dimension_XHandle = Selector.GetHandle ("splitWithSource:splitSectionLengths:dimension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSummarizedDOTDescriptionX = "summarizedDOTDescription";
		static readonly NativeHandle selSummarizedDOTDescriptionXHandle = Selector.GetHandle ("summarizedDOTDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransposeWithDimensions_Source_X = "transposeWithDimensions:source:";
		static readonly NativeHandle selTransposeWithDimensions_Source_XHandle = Selector.GetHandle ("transposeWithDimensions:source:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCGraph");
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
		protected MLCGraph (NSObjectFlag t) : base (t)
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
		protected internal MLCGraph (NativeHandle handle) : base (handle)
		{
		}

		[Export ("bindAndWriteData:forInputs:toDevice:batchSize:synchronous:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindAndWrite (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensor> inputTensors, MLCDevice device, nuint batchSize, bool synchronous)
		{
			var inputsData__handle__ = inputsData!.GetNonNullHandle (nameof (inputsData));
			var inputTensors__handle__ = inputTensors!.GetNonNullHandle (nameof (inputTensors));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_bool (this.Handle, selBindAndWriteData_ForInputs_ToDevice_BatchSize_Synchronous_XHandle, inputsData__handle__, inputTensors__handle__, device__handle__, batchSize, synchronous ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_bool (&__objc_super__, selBindAndWriteData_ForInputs_ToDevice_BatchSize_Synchronous_XHandle, inputsData__handle__, inputTensors__handle__, device__handle__, batchSize, synchronous ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputsData);
			GC.KeepAlive (inputTensors);
			GC.KeepAlive (device);
			return ret != 0;
		}
		[Export ("bindAndWriteData:forInputs:toDevice:synchronous:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindAndWrite (NSDictionary<NSString, MLCTensorData> inputsData, NSDictionary<NSString, MLCTensor> inputTensors, MLCDevice device, bool synchronous)
		{
			var inputsData__handle__ = inputsData!.GetNonNullHandle (nameof (inputsData));
			var inputTensors__handle__ = inputTensors!.GetNonNullHandle (nameof (inputTensors));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, selBindAndWriteData_ForInputs_ToDevice_Synchronous_XHandle, inputsData__handle__, inputTensors__handle__, device__handle__, synchronous ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, selBindAndWriteData_ForInputs_ToDevice_Synchronous_XHandle, inputsData__handle__, inputTensors__handle__, device__handle__, synchronous ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputsData);
			GC.KeepAlive (inputTensors);
			GC.KeepAlive (device);
			return ret != 0;
		}
		[Export ("concatenateWithSources:dimension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Concatenate (MLCTensor[] sources, nuint dimension)
		{
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			using var nsa_sources = NSArray.FromNSObjects (sources);
			MLCTensor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selConcatenateWithSources_Dimension_XHandle, nsa_sources.Handle, dimension), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selConcatenateWithSources_Dimension_XHandle, nsa_sources.Handle, dimension), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("graph")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCGraph Create ()
		{
			MLCGraph ret;
			ret =  Runtime.GetNSObject<MLCGraph> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGraphXHandle), false)!;
			return ret;
		}
		[Export ("nodeWithLayer:source:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateNode (MLCLayer layer, MLCTensor source)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selNodeWithLayer_Source_XHandle, layer__handle__, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selNodeWithLayer_Source_XHandle, layer__handle__, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("nodeWithLayer:sources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateNode (MLCLayer layer, MLCTensor[] sources)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			using var nsa_sources = NSArray.FromNSObjects (sources);
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selNodeWithLayer_Sources_XHandle, layer__handle__, nsa_sources.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selNodeWithLayer_Sources_XHandle, layer__handle__, nsa_sources.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("nodeWithLayer:sources:disableUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateNode (MLCLayer layer, MLCTensor[] sources, bool disableUpdate)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			using var nsa_sources = NSArray.FromNSObjects (sources);
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selNodeWithLayer_Sources_DisableUpdate_XHandle, layer__handle__, nsa_sources.Handle, disableUpdate ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selNodeWithLayer_Sources_DisableUpdate_XHandle, layer__handle__, nsa_sources.Handle, disableUpdate ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("nodeWithLayer:sources:lossLabels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? CreateNode (MLCLayer layer, MLCTensor[] sources, MLCTensor[] lossLabels)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			if (lossLabels is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (lossLabels));
			using var nsa_sources = NSArray.FromNSObjects (sources);
			using var nsa_lossLabels = NSArray.FromNSObjects (lossLabels);
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNodeWithLayer_Sources_LossLabels_XHandle, layer__handle__, nsa_sources.Handle, nsa_lossLabels.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNodeWithLayer_Sources_LossLabels_XHandle, layer__handle__, nsa_sources.Handle, nsa_lossLabels.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("gatherWithDimension:source:indices:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Gather (nuint dimension, MLCTensor source, MLCTensor indices)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var indices__handle__ = indices!.GetNonNullHandle (nameof (indices));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (this.Handle, selGatherWithDimension_Source_Indices_XHandle, dimension, source__handle__, indices__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selGatherWithDimension_Source_Indices_XHandle, dimension, source__handle__, indices__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			GC.KeepAlive (indices);
			return ret!;
		}
		[Export ("resultTensorsForLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor[] GetResultTensors (MLCLayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			MLCTensor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selResultTensorsForLayer_XHandle, layer__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selResultTensorsForLayer_XHandle, layer__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("sourceTensorsForLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor[] GetSourceTensors (MLCLayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			MLCTensor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSourceTensorsForLayer_XHandle, layer__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSourceTensorsForLayer_XHandle, layer__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("reshapeWithShape:source:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Reshape ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] shape, MLCTensor source)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReshapeWithShape_Source_XHandle, nsb_shape.GetHandle (), source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReshapeWithShape_Source_XHandle, nsb_shape.GetHandle (), source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("scatterWithDimension:source:indices:copyFrom:reductionType:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Scatter (nuint dimension, MLCTensor source, MLCTensor indices, MLCTensor copyFrom, MLCReductionType reductionType)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var indices__handle__ = indices!.GetNonNullHandle (nameof (indices));
			var copyFrom__handle__ = copyFrom!.GetNonNullHandle (nameof (copyFrom));
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_NativeHandle_int (this.Handle, selScatterWithDimension_Source_Indices_CopyFrom_ReductionType_XHandle, dimension, source__handle__, indices__handle__, copyFrom__handle__, (int)reductionType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_NativeHandle_int (&__objc_super__, selScatterWithDimension_Source_Indices_CopyFrom_ReductionType_XHandle, dimension, source__handle__, indices__handle__, copyFrom__handle__, (int)reductionType), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			GC.KeepAlive (indices);
			GC.KeepAlive (copyFrom);
			return ret!;
		}
		[Export ("selectWithSources:condition:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Select (MLCTensor[] sources, MLCTensor condition)
		{
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			var condition__handle__ = condition!.GetNonNullHandle (nameof (condition));
			using var nsa_sources = NSArray.FromNSObjects (sources);
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSelectWithSources_Condition_XHandle, nsa_sources.Handle, condition__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSelectWithSources_Condition_XHandle, nsa_sources.Handle, condition__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (condition);
			return ret!;
		}
		[Export ("splitWithSource:splitCount:dimension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor[]? Split (MLCTensor source, nuint splitCount, nuint dimension)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			MLCTensor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, selSplitWithSource_SplitCount_Dimension_XHandle, source__handle__, splitCount, dimension), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, selSplitWithSource_SplitCount_Dimension_XHandle, source__handle__, splitCount, dimension), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("splitWithSource:splitSectionLengths:dimension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor[]? Split (MLCTensor source, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] splitSectionLengths, nuint dimension)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (splitSectionLengths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (splitSectionLengths));
			using var nsb_splitSectionLengths = NSArray.FromNSObjects (o => new NSNumber (o), splitSectionLengths);
			MLCTensor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selSplitWithSource_SplitSectionLengths_Dimension_XHandle, source__handle__, nsb_splitSectionLengths.GetHandle (), dimension), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MLCTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selSplitWithSource_SplitSectionLengths_Dimension_XHandle, source__handle__, nsb_splitSectionLengths.GetHandle (), dimension), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("transposeWithDimensions:source:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Transpose ([BindAs (typeof (nint[]), OriginalType = typeof (NSNumber[]))] nint[] dimensions, MLCTensor source)
		{
			if (dimensions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dimensions));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			using var nsb_dimensions = NSArray.FromNSObjects (o => new NSNumber (o), dimensions);
			MLCTensor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTransposeWithDimensions_Source_XHandle, nsb_dimensions.GetHandle (), source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTransposeWithDimensions_Source_XHandle, nsb_dimensions.GetHandle (), source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
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
		public virtual MLCLayer[] Layers {
			[Export ("layers")]
			get {
				MLCLayer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MLCLayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLayersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MLCLayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLayersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SummarizedDotDescription {
			[Export ("summarizedDOTDescription")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSummarizedDOTDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSummarizedDOTDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MLCGraph */
}
