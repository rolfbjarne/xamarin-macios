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
	[Register("MLCActivationLayer", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCActivationLayer : MLCLayer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteLayerX = "absoluteLayer";
		static readonly NativeHandle selAbsoluteLayerXHandle = Selector.GetHandle ("absoluteLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCeluLayerX = "celuLayer";
		static readonly NativeHandle selCeluLayerXHandle = Selector.GetHandle ("celuLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCeluLayerWithA_X = "celuLayerWithA:";
		static readonly NativeHandle selCeluLayerWithA_XHandle = Selector.GetHandle ("celuLayerWithA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClampLayerWithMinValue_MaxValue_X = "clampLayerWithMinValue:maxValue:";
		static readonly NativeHandle selClampLayerWithMinValue_MaxValue_XHandle = Selector.GetHandle ("clampLayerWithMinValue:maxValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorX = "descriptor";
		static readonly NativeHandle selDescriptorXHandle = Selector.GetHandle ("descriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEluLayerX = "eluLayer";
		static readonly NativeHandle selEluLayerXHandle = Selector.GetHandle ("eluLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEluLayerWithA_X = "eluLayerWithA:";
		static readonly NativeHandle selEluLayerWithA_XHandle = Selector.GetHandle ("eluLayerWithA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGeluLayerX = "geluLayer";
		static readonly NativeHandle selGeluLayerXHandle = Selector.GetHandle ("geluLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHardShrinkLayerX = "hardShrinkLayer";
		static readonly NativeHandle selHardShrinkLayerXHandle = Selector.GetHandle ("hardShrinkLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHardShrinkLayerWithA_X = "hardShrinkLayerWithA:";
		static readonly NativeHandle selHardShrinkLayerWithA_XHandle = Selector.GetHandle ("hardShrinkLayerWithA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHardSigmoidLayerX = "hardSigmoidLayer";
		static readonly NativeHandle selHardSigmoidLayerXHandle = Selector.GetHandle ("hardSigmoidLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHardSwishLayerX = "hardSwishLayer";
		static readonly NativeHandle selHardSwishLayerXHandle = Selector.GetHandle ("hardSwishLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerWithDescriptor_X = "layerWithDescriptor:";
		static readonly NativeHandle selLayerWithDescriptor_XHandle = Selector.GetHandle ("layerWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeakyReLULayerX = "leakyReLULayer";
		static readonly NativeHandle selLeakyReLULayerXHandle = Selector.GetHandle ("leakyReLULayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeakyReLULayerWithNegativeSlope_X = "leakyReLULayerWithNegativeSlope:";
		static readonly NativeHandle selLeakyReLULayerWithNegativeSlope_XHandle = Selector.GetHandle ("leakyReLULayerWithNegativeSlope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearLayerWithScale_Bias_X = "linearLayerWithScale:bias:";
		static readonly NativeHandle selLinearLayerWithScale_Bias_XHandle = Selector.GetHandle ("linearLayerWithScale:bias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogSigmoidLayerX = "logSigmoidLayer";
		static readonly NativeHandle selLogSigmoidLayerXHandle = Selector.GetHandle ("logSigmoidLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelu6LayerX = "relu6Layer";
		static readonly NativeHandle selRelu6LayerXHandle = Selector.GetHandle ("relu6Layer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReluLayerX = "reluLayer";
		static readonly NativeHandle selReluLayerXHandle = Selector.GetHandle ("reluLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelunLayerWithA_B_X = "relunLayerWithA:b:";
		static readonly NativeHandle selRelunLayerWithA_B_XHandle = Selector.GetHandle ("relunLayerWithA:b:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeluLayerX = "seluLayer";
		static readonly NativeHandle selSeluLayerXHandle = Selector.GetHandle ("seluLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSigmoidLayerX = "sigmoidLayer";
		static readonly NativeHandle selSigmoidLayerXHandle = Selector.GetHandle ("sigmoidLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftPlusLayerX = "softPlusLayer";
		static readonly NativeHandle selSoftPlusLayerXHandle = Selector.GetHandle ("softPlusLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftPlusLayerWithBeta_X = "softPlusLayerWithBeta:";
		static readonly NativeHandle selSoftPlusLayerWithBeta_XHandle = Selector.GetHandle ("softPlusLayerWithBeta:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftShrinkLayerX = "softShrinkLayer";
		static readonly NativeHandle selSoftShrinkLayerXHandle = Selector.GetHandle ("softShrinkLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftShrinkLayerWithA_X = "softShrinkLayerWithA:";
		static readonly NativeHandle selSoftShrinkLayerWithA_XHandle = Selector.GetHandle ("softShrinkLayerWithA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftSignLayerX = "softSignLayer";
		static readonly NativeHandle selSoftSignLayerXHandle = Selector.GetHandle ("softSignLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTanhLayerX = "tanhLayer";
		static readonly NativeHandle selTanhLayerXHandle = Selector.GetHandle ("tanhLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTanhShrinkLayerX = "tanhShrinkLayer";
		static readonly NativeHandle selTanhShrinkLayerXHandle = Selector.GetHandle ("tanhShrinkLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThresholdLayerWithThreshold_Replacement_X = "thresholdLayerWithThreshold:replacement:";
		static readonly NativeHandle selThresholdLayerWithThreshold_Replacement_XHandle = Selector.GetHandle ("thresholdLayerWithThreshold:replacement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCActivationLayer");
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
		protected MLCActivationLayer (NSObjectFlag t) : base (t)
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
		protected internal MLCActivationLayer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("layerWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer Create (MLCActivationDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MLCActivationLayer? ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLayerWithDescriptor_XHandle, descriptor__handle__), false)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("celuLayerWithA:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateCeluLayer (float a)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selCeluLayerWithA_XHandle, a), false)!;
			return ret;
		}
		[Export ("clampLayerWithMinValue:maxValue:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateClampLayer (float minValue, float maxValue)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float (class_ptr, selClampLayerWithMinValue_MaxValue_XHandle, minValue, maxValue), false)!;
			return ret;
		}
		[Export ("eluLayerWithA:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateEluLayer (float a)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selEluLayerWithA_XHandle, a), false)!;
			return ret;
		}
		[Export ("hardShrinkLayerWithA:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateHardShrinkLayer (float a)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selHardShrinkLayerWithA_XHandle, a), false)!;
			return ret;
		}
		[Export ("hardSwishLayer")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateHardSwishLayer ()
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHardSwishLayerXHandle), false)!;
			return ret;
		}
		[Export ("leakyReLULayerWithNegativeSlope:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateLeakyReLULayer (float negativeSlope)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selLeakyReLULayerWithNegativeSlope_XHandle, negativeSlope), false)!;
			return ret;
		}
		[Export ("linearLayerWithScale:bias:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateLinearLayer (float scale, float bias)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float (class_ptr, selLinearLayerWithScale_Bias_XHandle, scale, bias), false)!;
			return ret;
		}
		[Export ("relunLayerWithA:b:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateRelunLayer (float a, float b)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float (class_ptr, selRelunLayerWithA_B_XHandle, a, b), false)!;
			return ret;
		}
		[Export ("softPlusLayerWithBeta:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateSoftPlusLayer (float beta)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selSoftPlusLayerWithBeta_XHandle, beta), false)!;
			return ret;
		}
		[Export ("softShrinkLayerWithA:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateSoftShrinkLayer (float a)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selSoftShrinkLayerWithA_XHandle, a), false)!;
			return ret;
		}
		[Export ("thresholdLayerWithThreshold:replacement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CreateThresholdLayer (float threshold, float replacement)
		{
			MLCActivationLayer ret;
			ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float (class_ptr, selThresholdLayerWithThreshold_Replacement_XHandle, threshold, replacement), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer AbsoluteLayer {
			[Export ("absoluteLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAbsoluteLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer CeluLayer {
			[Export ("celuLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCeluLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCActivationDescriptor Descriptor {
			[Export ("descriptor", ArgumentSemantic.Copy)]
			get {
				MLCActivationDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLCActivationDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLCActivationDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer EluLayer {
			[Export ("eluLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selEluLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer GeluLayer {
			[Export ("geluLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGeluLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer HardShrinkLayer {
			[Export ("hardShrinkLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHardShrinkLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer HardSigmoidLayer {
			[Export ("hardSigmoidLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHardSigmoidLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer LeakyReLULayer {
			[Export ("leakyReLULayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLeakyReLULayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer LogSigmoidLayer {
			[Export ("logSigmoidLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLogSigmoidLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer Relu6Layer {
			[Export ("relu6Layer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRelu6LayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer ReluLayer {
			[Export ("reluLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selReluLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer SeluLayer {
			[Export ("seluLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSeluLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer SigmoidLayer {
			[Export ("sigmoidLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSigmoidLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer SoftPlusLayer {
			[Export ("softPlusLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSoftPlusLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer SoftShrinkLayer {
			[Export ("softShrinkLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSoftShrinkLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer SoftSignLayer {
			[Export ("softSignLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSoftSignLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer TanhLayer {
			[Export ("tanhLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTanhLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCActivationLayer TanhShrinkLayer {
			[Export ("tanhShrinkLayer")]
			get {
				MLCActivationLayer? ret;
				ret =  Runtime.GetNSObject<MLCActivationLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTanhShrinkLayerXHandle), false)!;
				return ret!;
			}
		}
	} /* class MLCActivationLayer */
}
