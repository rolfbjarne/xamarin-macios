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
	[Register("MLCConvolutionDescriptor", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCConvolutionDescriptor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTransposeDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_X = "convolutionTransposeDescriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selConvolutionTransposeDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("convolutionTransposeDescriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTransposeDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_Strides_PaddingPolicy_PaddingSizes_X = "convolutionTransposeDescriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:strides:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selConvolutionTransposeDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_Strides_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("convolutionTransposeDescriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:strides:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTransposeDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_OutputFeatureChannelCount_X = "convolutionTransposeDescriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:outputFeatureChannelCount:";
		static readonly NativeHandle selConvolutionTransposeDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_OutputFeatureChannelCount_XHandle = Selector.GetHandle ("convolutionTransposeDescriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:outputFeatureChannelCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTypeX = "convolutionType";
		static readonly NativeHandle selConvolutionTypeXHandle = Selector.GetHandle ("convolutionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthwiseConvolutionDescriptorWithKernelSizes_InputFeatureChannelCount_ChannelMultiplier_Strides_DilationRates_PaddingPolicy_PaddingSizes_X = "depthwiseConvolutionDescriptorWithKernelSizes:inputFeatureChannelCount:channelMultiplier:strides:dilationRates:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selDepthwiseConvolutionDescriptorWithKernelSizes_InputFeatureChannelCount_ChannelMultiplier_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("depthwiseConvolutionDescriptorWithKernelSizes:inputFeatureChannelCount:channelMultiplier:strides:dilationRates:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthwiseConvolutionDescriptorWithKernelSizes_InputFeatureChannelCount_ChannelMultiplier_Strides_PaddingPolicy_PaddingSizes_X = "depthwiseConvolutionDescriptorWithKernelSizes:inputFeatureChannelCount:channelMultiplier:strides:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selDepthwiseConvolutionDescriptorWithKernelSizes_InputFeatureChannelCount_ChannelMultiplier_Strides_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("depthwiseConvolutionDescriptorWithKernelSizes:inputFeatureChannelCount:channelMultiplier:strides:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthwiseConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_ChannelMultiplier_X = "depthwiseConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:channelMultiplier:";
		static readonly NativeHandle selDepthwiseConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_ChannelMultiplier_XHandle = Selector.GetHandle ("depthwiseConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:channelMultiplier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_X = "descriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("descriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_Strides_PaddingPolicy_PaddingSizes_X = "descriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:strides:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_Strides_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("descriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:strides:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_OutputFeatureChannelCount_X = "descriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:outputFeatureChannelCount:";
		static readonly NativeHandle selDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_OutputFeatureChannelCount_XHandle = Selector.GetHandle ("descriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:outputFeatureChannelCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithType_KernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_X = "descriptorWithType:kernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:";
		static readonly NativeHandle selDescriptorWithType_KernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle = Selector.GetHandle ("descriptorWithType:kernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateInXX = "dilationRateInX";
		static readonly NativeHandle selDilationRateInXXHandle = Selector.GetHandle ("dilationRateInX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateInYX = "dilationRateInY";
		static readonly NativeHandle selDilationRateInYXHandle = Selector.GetHandle ("dilationRateInY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupCountX = "groupCount";
		static readonly NativeHandle selGroupCountXHandle = Selector.GetHandle ("groupCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputFeatureChannelCountX = "inputFeatureChannelCount";
		static readonly NativeHandle selInputFeatureChannelCountXHandle = Selector.GetHandle ("inputFeatureChannelCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConvolutionTransposeX = "isConvolutionTranspose";
		static readonly NativeHandle selIsConvolutionTransposeXHandle = Selector.GetHandle ("isConvolutionTranspose");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelHeightX = "kernelHeight";
		static readonly NativeHandle selKernelHeightXHandle = Selector.GetHandle ("kernelHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelWidthX = "kernelWidth";
		static readonly NativeHandle selKernelWidthXHandle = Selector.GetHandle ("kernelWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFeatureChannelCountX = "outputFeatureChannelCount";
		static readonly NativeHandle selOutputFeatureChannelCountXHandle = Selector.GetHandle ("outputFeatureChannelCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingPolicyX = "paddingPolicy";
		static readonly NativeHandle selPaddingPolicyXHandle = Selector.GetHandle ("paddingPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingSizeInXX = "paddingSizeInX";
		static readonly NativeHandle selPaddingSizeInXXHandle = Selector.GetHandle ("paddingSizeInX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingSizeInYX = "paddingSizeInY";
		static readonly NativeHandle selPaddingSizeInYXHandle = Selector.GetHandle ("paddingSizeInY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInXX = "strideInX";
		static readonly NativeHandle selStrideInXXHandle = Selector.GetHandle ("strideInX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInYX = "strideInY";
		static readonly NativeHandle selStrideInYXHandle = Selector.GetHandle ("strideInY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesDepthwiseConvolutionX = "usesDepthwiseConvolution";
		static readonly NativeHandle selUsesDepthwiseConvolutionXHandle = Selector.GetHandle ("usesDepthwiseConvolution");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCConvolutionDescriptor");
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
		protected MLCConvolutionDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MLCConvolutionDescriptor (NativeHandle handle) : base (handle)
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
		[Export ("descriptorWithType:kernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor Create (MLCConvolutionType convolutionType, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, nuint groupCount, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] dilationRates, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			if (dilationRates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dilationRates));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_dilationRates = NSArray.FromNSObjects (o => new NSNumber (o), dilationRates);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle_int_NativeHandle (class_ptr, selDescriptorWithType_KernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle, (int)convolutionType, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, outputFeatureChannelCount, groupCount, nsb_strides.GetHandle (), nsb_dilationRates.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[Export ("descriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:outputFeatureChannelCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor Create (nuint kernelWidth, nuint kernelHeight, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount)
		{
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_OutputFeatureChannelCount_XHandle, kernelWidth, kernelHeight, inputFeatureChannelCount, outputFeatureChannelCount), false)!;
			return ret;
		}
		[Export ("descriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:strides:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor Create ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_int_NativeHandle (class_ptr, selDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_Strides_PaddingPolicy_PaddingSizes_XHandle, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, outputFeatureChannelCount, nsb_strides.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[Export ("descriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor Create ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, nuint groupCount, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] dilationRates, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			if (dilationRates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dilationRates));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_dilationRates = NSArray.FromNSObjects (o => new NSNumber (o), dilationRates);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle_int_NativeHandle (class_ptr, selDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, outputFeatureChannelCount, groupCount, nsb_strides.GetHandle (), nsb_dilationRates.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[Export ("convolutionTransposeDescriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:outputFeatureChannelCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor CreateConvolutionTranspose (nuint kernelWidth, nuint kernelHeight, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount)
		{
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selConvolutionTransposeDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_OutputFeatureChannelCount_XHandle, kernelWidth, kernelHeight, inputFeatureChannelCount, outputFeatureChannelCount), false)!;
			return ret;
		}
		[Export ("convolutionTransposeDescriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:strides:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor CreateConvolutionTranspose ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_int_NativeHandle (class_ptr, selConvolutionTransposeDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_Strides_PaddingPolicy_PaddingSizes_XHandle, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, outputFeatureChannelCount, nsb_strides.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[Export ("convolutionTransposeDescriptorWithKernelSizes:inputFeatureChannelCount:outputFeatureChannelCount:groupCount:strides:dilationRates:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor CreateConvolutionTranspose ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint outputFeatureChannelCount, nuint groupCount, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] dilationRates, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			if (dilationRates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dilationRates));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_dilationRates = NSArray.FromNSObjects (o => new NSNumber (o), dilationRates);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle_int_NativeHandle (class_ptr, selConvolutionTransposeDescriptorWithKernelSizes_InputFeatureChannelCount_OutputFeatureChannelCount_GroupCount_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, outputFeatureChannelCount, groupCount, nsb_strides.GetHandle (), nsb_dilationRates.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[Export ("depthwiseConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannelCount:channelMultiplier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor CreateDepthwiseConvolution (nuint kernelWidth, nuint kernelHeight, nuint inputFeatureChannelCount, nuint channelMultiplier)
		{
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selDepthwiseConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannelCount_ChannelMultiplier_XHandle, kernelWidth, kernelHeight, inputFeatureChannelCount, channelMultiplier), false)!;
			return ret;
		}
		[Export ("depthwiseConvolutionDescriptorWithKernelSizes:inputFeatureChannelCount:channelMultiplier:strides:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor CreateDepthwiseConvolution ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint channelMultiplier, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_int_NativeHandle (class_ptr, selDepthwiseConvolutionDescriptorWithKernelSizes_InputFeatureChannelCount_ChannelMultiplier_Strides_PaddingPolicy_PaddingSizes_XHandle, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, channelMultiplier, nsb_strides.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[Export ("depthwiseConvolutionDescriptorWithKernelSizes:inputFeatureChannelCount:channelMultiplier:strides:dilationRates:paddingPolicy:paddingSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCConvolutionDescriptor CreateDepthwiseConvolution ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] kernelSizes, nuint inputFeatureChannelCount, nuint channelMultiplier, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] strides, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] dilationRates, MLCPaddingPolicy paddingPolicy, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[]? paddingSizes)
		{
			if (kernelSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kernelSizes));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			if (dilationRates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dilationRates));
			using var nsb_kernelSizes = NSArray.FromNSObjects (o => new NSNumber (o), kernelSizes);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_dilationRates = NSArray.FromNSObjects (o => new NSNumber (o), dilationRates);
			using var nsb_paddingSizes = NSArray.FromNSObjects (o => new NSNumber (o), paddingSizes);
			MLCConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MLCConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_NativeHandle_int_NativeHandle (class_ptr, selDepthwiseConvolutionDescriptorWithKernelSizes_InputFeatureChannelCount_ChannelMultiplier_Strides_DilationRates_PaddingPolicy_PaddingSizes_XHandle, nsb_kernelSizes.GetHandle (), inputFeatureChannelCount, channelMultiplier, nsb_strides.GetHandle (), nsb_dilationRates.GetHandle (), (int)paddingPolicy, nsb_paddingSizes.GetHandle ()), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCConvolutionType ConvolutionType {
			[Export ("convolutionType")]
			get {
				MLCConvolutionType ret;
				if (IsDirectBinding) {
					ret = (MLCConvolutionType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selConvolutionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLCConvolutionType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selConvolutionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DilationRateInX {
			[Export ("dilationRateInX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDilationRateInXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDilationRateInXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DilationRateInY {
			[Export ("dilationRateInY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDilationRateInYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDilationRateInYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GroupCount {
			[Export ("groupCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selGroupCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selGroupCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint InputFeatureChannelCount {
			[Export ("inputFeatureChannelCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selInputFeatureChannelCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selInputFeatureChannelCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsConvolutionTranspose {
			[Export ("isConvolutionTranspose")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConvolutionTransposeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConvolutionTransposeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint KernelHeight {
			[Export ("kernelHeight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selKernelHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selKernelHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint KernelWidth {
			[Export ("kernelWidth")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selKernelWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selKernelWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint OutputFeatureChannelCount {
			[Export ("outputFeatureChannelCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOutputFeatureChannelCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOutputFeatureChannelCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCPaddingPolicy PaddingPolicy {
			[Export ("paddingPolicy")]
			get {
				MLCPaddingPolicy ret;
				if (IsDirectBinding) {
					ret = (MLCPaddingPolicy) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPaddingPolicyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLCPaddingPolicy) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selPaddingPolicyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PaddingSizeInX {
			[Export ("paddingSizeInX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingSizeInXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingSizeInXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PaddingSizeInY {
			[Export ("paddingSizeInY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingSizeInYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingSizeInYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint StrideInX {
			[Export ("strideInX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStrideInXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStrideInXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint StrideInY {
			[Export ("strideInY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStrideInYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStrideInYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesDepthwiseConvolution {
			[Export ("usesDepthwiseConvolution")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesDepthwiseConvolutionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesDepthwiseConvolutionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class MLCConvolutionDescriptor */
}
