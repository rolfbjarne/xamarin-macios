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
	[Register("MLCLossLayer", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCLossLayer : MLCLayer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategoricalCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weight_X = "categoricalCrossEntropyLossWithReductionType:labelSmoothing:classCount:weight:";
		static readonly NativeHandle selCategoricalCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weight_XHandle = Selector.GetHandle ("categoricalCrossEntropyLossWithReductionType:labelSmoothing:classCount:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategoricalCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weights_X = "categoricalCrossEntropyLossWithReductionType:labelSmoothing:classCount:weights:";
		static readonly NativeHandle selCategoricalCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weights_XHandle = Selector.GetHandle ("categoricalCrossEntropyLossWithReductionType:labelSmoothing:classCount:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCosineDistanceLossWithReductionType_Weight_X = "cosineDistanceLossWithReductionType:weight:";
		static readonly NativeHandle selCosineDistanceLossWithReductionType_Weight_XHandle = Selector.GetHandle ("cosineDistanceLossWithReductionType:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCosineDistanceLossWithReductionType_Weights_X = "cosineDistanceLossWithReductionType:weights:";
		static readonly NativeHandle selCosineDistanceLossWithReductionType_Weights_XHandle = Selector.GetHandle ("cosineDistanceLossWithReductionType:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorX = "descriptor";
		static readonly NativeHandle selDescriptorXHandle = Selector.GetHandle ("descriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHingeLossWithReductionType_Weight_X = "hingeLossWithReductionType:weight:";
		static readonly NativeHandle selHingeLossWithReductionType_Weight_XHandle = Selector.GetHandle ("hingeLossWithReductionType:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHingeLossWithReductionType_Weights_X = "hingeLossWithReductionType:weights:";
		static readonly NativeHandle selHingeLossWithReductionType_Weights_XHandle = Selector.GetHandle ("hingeLossWithReductionType:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHuberLossWithReductionType_Delta_Weight_X = "huberLossWithReductionType:delta:weight:";
		static readonly NativeHandle selHuberLossWithReductionType_Delta_Weight_XHandle = Selector.GetHandle ("huberLossWithReductionType:delta:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHuberLossWithReductionType_Delta_Weights_X = "huberLossWithReductionType:delta:weights:";
		static readonly NativeHandle selHuberLossWithReductionType_Delta_Weights_XHandle = Selector.GetHandle ("huberLossWithReductionType:delta:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerWithDescriptor_X = "layerWithDescriptor:";
		static readonly NativeHandle selLayerWithDescriptor_XHandle = Selector.GetHandle ("layerWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerWithDescriptor_Weights_X = "layerWithDescriptor:weights:";
		static readonly NativeHandle selLayerWithDescriptor_Weights_XHandle = Selector.GetHandle ("layerWithDescriptor:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogLossWithReductionType_Epsilon_Weight_X = "logLossWithReductionType:epsilon:weight:";
		static readonly NativeHandle selLogLossWithReductionType_Epsilon_Weight_XHandle = Selector.GetHandle ("logLossWithReductionType:epsilon:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogLossWithReductionType_Epsilon_Weights_X = "logLossWithReductionType:epsilon:weights:";
		static readonly NativeHandle selLogLossWithReductionType_Epsilon_Weights_XHandle = Selector.GetHandle ("logLossWithReductionType:epsilon:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeanAbsoluteErrorLossWithReductionType_Weight_X = "meanAbsoluteErrorLossWithReductionType:weight:";
		static readonly NativeHandle selMeanAbsoluteErrorLossWithReductionType_Weight_XHandle = Selector.GetHandle ("meanAbsoluteErrorLossWithReductionType:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeanAbsoluteErrorLossWithReductionType_Weights_X = "meanAbsoluteErrorLossWithReductionType:weights:";
		static readonly NativeHandle selMeanAbsoluteErrorLossWithReductionType_Weights_XHandle = Selector.GetHandle ("meanAbsoluteErrorLossWithReductionType:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeanSquaredErrorLossWithReductionType_Weight_X = "meanSquaredErrorLossWithReductionType:weight:";
		static readonly NativeHandle selMeanSquaredErrorLossWithReductionType_Weight_XHandle = Selector.GetHandle ("meanSquaredErrorLossWithReductionType:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeanSquaredErrorLossWithReductionType_Weights_X = "meanSquaredErrorLossWithReductionType:weights:";
		static readonly NativeHandle selMeanSquaredErrorLossWithReductionType_Weights_XHandle = Selector.GetHandle ("meanSquaredErrorLossWithReductionType:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSigmoidCrossEntropyLossWithReductionType_LabelSmoothing_Weight_X = "sigmoidCrossEntropyLossWithReductionType:labelSmoothing:weight:";
		static readonly NativeHandle selSigmoidCrossEntropyLossWithReductionType_LabelSmoothing_Weight_XHandle = Selector.GetHandle ("sigmoidCrossEntropyLossWithReductionType:labelSmoothing:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSigmoidCrossEntropyLossWithReductionType_LabelSmoothing_Weights_X = "sigmoidCrossEntropyLossWithReductionType:labelSmoothing:weights:";
		static readonly NativeHandle selSigmoidCrossEntropyLossWithReductionType_LabelSmoothing_Weights_XHandle = Selector.GetHandle ("sigmoidCrossEntropyLossWithReductionType:labelSmoothing:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftmaxCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weight_X = "softmaxCrossEntropyLossWithReductionType:labelSmoothing:classCount:weight:";
		static readonly NativeHandle selSoftmaxCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weight_XHandle = Selector.GetHandle ("softmaxCrossEntropyLossWithReductionType:labelSmoothing:classCount:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftmaxCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weights_X = "softmaxCrossEntropyLossWithReductionType:labelSmoothing:classCount:weights:";
		static readonly NativeHandle selSoftmaxCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weights_XHandle = Selector.GetHandle ("softmaxCrossEntropyLossWithReductionType:labelSmoothing:classCount:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWeightsX = "weights";
		static readonly NativeHandle selWeightsXHandle = Selector.GetHandle ("weights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCLossLayer");
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
		protected MLCLossLayer (NSObjectFlag t) : base (t)
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
		protected internal MLCLossLayer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("layerWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer Create (MLCLossDescriptor lossDescriptor)
		{
			var lossDescriptor__handle__ = lossDescriptor!.GetNonNullHandle (nameof (lossDescriptor));
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLayerWithDescriptor_XHandle, lossDescriptor__handle__), false)!;
			GC.KeepAlive (lossDescriptor);
			return ret!;
		}
		[Export ("layerWithDescriptor:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer Create (MLCLossDescriptor lossDescriptor, MLCTensor weights)
		{
			var lossDescriptor__handle__ = lossDescriptor!.GetNonNullHandle (nameof (lossDescriptor));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selLayerWithDescriptor_Weights_XHandle, lossDescriptor__handle__, weights__handle__), false)!;
			GC.KeepAlive (lossDescriptor);
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("categoricalCrossEntropyLossWithReductionType:labelSmoothing:classCount:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateCategoricalCrossEntropyLoss (MLCReductionType reductionType, float labelSmoothing, nuint classCount, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_UIntPtr_float (class_ptr, selCategoricalCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weight_XHandle, (int)reductionType, labelSmoothing, classCount, weight), false)!;
			return ret;
		}
		[Export ("categoricalCrossEntropyLossWithReductionType:labelSmoothing:classCount:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateCategoricalCrossEntropyLoss (MLCReductionType reductionType, float labelSmoothing, nuint classCount, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_UIntPtr_NativeHandle (class_ptr, selCategoricalCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weights_XHandle, (int)reductionType, labelSmoothing, classCount, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("cosineDistanceLossWithReductionType:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateCosineDistanceLoss (MLCReductionType reductionType, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float (class_ptr, selCosineDistanceLossWithReductionType_Weight_XHandle, (int)reductionType, weight), false)!;
			return ret;
		}
		[Export ("cosineDistanceLossWithReductionType:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateCosineDistanceLoss (MLCReductionType reductionType, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle (class_ptr, selCosineDistanceLossWithReductionType_Weights_XHandle, (int)reductionType, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("hingeLossWithReductionType:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateHingeLoss (MLCReductionType reductionType, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float (class_ptr, selHingeLossWithReductionType_Weight_XHandle, (int)reductionType, weight), false)!;
			return ret;
		}
		[Export ("hingeLossWithReductionType:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateHingeLoss (MLCReductionType reductionType, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle (class_ptr, selHingeLossWithReductionType_Weights_XHandle, (int)reductionType, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("huberLossWithReductionType:delta:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateHuberLoss (MLCReductionType reductionType, float delta, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_float (class_ptr, selHuberLossWithReductionType_Delta_Weight_XHandle, (int)reductionType, delta, weight), false)!;
			return ret;
		}
		[Export ("huberLossWithReductionType:delta:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateHuberLoss (MLCReductionType reductionType, float delta, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_NativeHandle (class_ptr, selHuberLossWithReductionType_Delta_Weights_XHandle, (int)reductionType, delta, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("logLossWithReductionType:epsilon:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateLogLoss (MLCReductionType reductionType, float epsilon, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_float (class_ptr, selLogLossWithReductionType_Epsilon_Weight_XHandle, (int)reductionType, epsilon, weight), false)!;
			return ret;
		}
		[Export ("logLossWithReductionType:epsilon:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateLogLoss (MLCReductionType reductionType, float epsilon, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_NativeHandle (class_ptr, selLogLossWithReductionType_Epsilon_Weights_XHandle, (int)reductionType, epsilon, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("meanAbsoluteErrorLossWithReductionType:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateMeanAbsoluteErrorLoss (MLCReductionType reductionType, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float (class_ptr, selMeanAbsoluteErrorLossWithReductionType_Weight_XHandle, (int)reductionType, weight), false)!;
			return ret;
		}
		[Export ("meanAbsoluteErrorLossWithReductionType:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateMeanAbsoluteErrorLoss (MLCReductionType reductionType, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle (class_ptr, selMeanAbsoluteErrorLossWithReductionType_Weights_XHandle, (int)reductionType, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("meanSquaredErrorLossWithReductionType:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateMeanSquaredErrorLoss (MLCReductionType reductionType, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float (class_ptr, selMeanSquaredErrorLossWithReductionType_Weight_XHandle, (int)reductionType, weight), false)!;
			return ret;
		}
		[Export ("meanSquaredErrorLossWithReductionType:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateMeanSquaredErrorLoss (MLCReductionType reductionType, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle (class_ptr, selMeanSquaredErrorLossWithReductionType_Weights_XHandle, (int)reductionType, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("sigmoidCrossEntropyLossWithReductionType:labelSmoothing:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateSigmoidCrossEntropyLoss (MLCReductionType reductionType, float labelSmoothing, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_float (class_ptr, selSigmoidCrossEntropyLossWithReductionType_LabelSmoothing_Weight_XHandle, (int)reductionType, labelSmoothing, weight), false)!;
			return ret;
		}
		[Export ("sigmoidCrossEntropyLossWithReductionType:labelSmoothing:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateSigmoidCrossEntropyLoss (MLCReductionType reductionType, float labelSmoothing, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_NativeHandle (class_ptr, selSigmoidCrossEntropyLossWithReductionType_LabelSmoothing_Weights_XHandle, (int)reductionType, labelSmoothing, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[Export ("softmaxCrossEntropyLossWithReductionType:labelSmoothing:classCount:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateSoftmaxCrossEntropyLoss (MLCReductionType reductionType, float labelSmoothing, nuint classCount, float weight)
		{
			MLCLossLayer ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_UIntPtr_float (class_ptr, selSoftmaxCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weight_XHandle, (int)reductionType, labelSmoothing, classCount, weight), false)!;
			return ret;
		}
		[Export ("softmaxCrossEntropyLossWithReductionType:labelSmoothing:classCount:weights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossLayer CreateSoftmaxCrossEntropyLoss (MLCReductionType reductionType, float labelSmoothing, nuint classCount, MLCTensor? weights)
		{
			var weights__handle__ = weights.GetHandle ();
			MLCLossLayer? ret;
			ret =  Runtime.GetNSObject<MLCLossLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_float_UIntPtr_NativeHandle (class_ptr, selSoftmaxCrossEntropyLossWithReductionType_LabelSmoothing_ClassCount_Weights_XHandle, (int)reductionType, labelSmoothing, classCount, weights__handle__), false)!;
			GC.KeepAlive (weights);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCLossDescriptor Descriptor {
			[Export ("descriptor", ArgumentSemantic.Copy)]
			get {
				MLCLossDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLCLossDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLCLossDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCTensor? Weights {
			[Export ("weights", ArgumentSemantic.Retain)]
			get {
				MLCTensor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLCTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MLCLossLayer */
}
