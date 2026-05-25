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
	/// <summary>A <see cref="T:MetalPerformanceShaders.MPSCnnKernel" /> that convolves its inputs, producing a feature map for each of its constituent filters.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/MetalPerformanceShaders/MPSCNNConvolution">Apple documentation for <c>MPSCNNConvolution</c></related>
	[Register("MPSCNNConvolution", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSCnnConvolution : MPSCnnKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccumulatorPrecisionOptionX = "accumulatorPrecisionOption";
		static readonly NativeHandle selAccumulatorPrecisionOptionXHandle = Selector.GetHandle ("accumulatorPrecisionOption");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChannelMultiplierX = "channelMultiplier";
		static readonly NativeHandle selChannelMultiplierXHandle = Selector.GetHandle ("channelMultiplier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateXX = "dilationRateX";
		static readonly NativeHandle selDilationRateXXHandle = Selector.GetHandle ("dilationRateX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateYX = "dilationRateY";
		static readonly NativeHandle selDilationRateYXHandle = Selector.GetHandle ("dilationRateY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_X = "exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:";
		static readonly NativeHandle selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_XHandle = Selector.GetHandle ("exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFusedNeuronDescriptorX = "fusedNeuronDescriptor";
		static readonly NativeHandle selFusedNeuronDescriptorXHandle = Selector.GetHandle ("fusedNeuronDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupsX = "groups";
		static readonly NativeHandle selGroupsXHandle = Selector.GetHandle ("groups");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_X = "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:";
		static readonly NativeHandle selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_XHandle = Selector.GetHandle ("initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_Weights_X = "initWithDevice:weights:";
		static readonly NativeHandle selInitWithDevice_Weights_XHandle = Selector.GetHandle ("initWithDevice:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputFeatureChannelsX = "inputFeatureChannels";
		static readonly NativeHandle selInputFeatureChannelsXHandle = Selector.GetHandle ("inputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelHeightX = "kernelHeight";
		static readonly NativeHandle selKernelHeightXHandle = Selector.GetHandle ("kernelHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelWidthX = "kernelWidth";
		static readonly NativeHandle selKernelWidthXHandle = Selector.GetHandle ("kernelWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeuronX = "neuron";
		static readonly NativeHandle selNeuronXHandle = Selector.GetHandle ("neuron");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeuronParameterAX = "neuronParameterA";
		static readonly NativeHandle selNeuronParameterAXHandle = Selector.GetHandle ("neuronParameterA");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeuronParameterBX = "neuronParameterB";
		static readonly NativeHandle selNeuronParameterBXHandle = Selector.GetHandle ("neuronParameterB");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeuronParameterCX = "neuronParameterC";
		static readonly NativeHandle selNeuronParameterCXHandle = Selector.GetHandle ("neuronParameterC");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeuronTypeX = "neuronType";
		static readonly NativeHandle selNeuronTypeXHandle = Selector.GetHandle ("neuronType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFeatureChannelsX = "outputFeatureChannels";
		static readonly NativeHandle selOutputFeatureChannelsXHandle = Selector.GetHandle ("outputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadWeightsAndBiasesFromDataSourceX = "reloadWeightsAndBiasesFromDataSource";
		static readonly NativeHandle selReloadWeightsAndBiasesFromDataSourceXHandle = Selector.GetHandle ("reloadWeightsAndBiasesFromDataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadWeightsAndBiasesWithCommandBuffer_State_X = "reloadWeightsAndBiasesWithCommandBuffer:state:";
		static readonly NativeHandle selReloadWeightsAndBiasesWithCommandBuffer_State_XHandle = Selector.GetHandle ("reloadWeightsAndBiasesWithCommandBuffer:state:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadWeightsAndBiasesWithDataSource_X = "reloadWeightsAndBiasesWithDataSource:";
		static readonly NativeHandle selReloadWeightsAndBiasesWithDataSource_XHandle = Selector.GetHandle ("reloadWeightsAndBiasesWithDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateBatchForSourceImage_SourceStates_DestinationImage_X = "resultStateBatchForSourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateBatchForSourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateBatchForSourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateForSourceImage_SourceStates_DestinationImage_X = "resultStateForSourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateForSourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateForSourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccumulatorPrecisionOption_X = "setAccumulatorPrecisionOption:";
		static readonly NativeHandle selSetAccumulatorPrecisionOption_XHandle = Selector.GetHandle ("setAccumulatorPrecisionOption:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInPixelsXX = "strideInPixelsX";
		static readonly NativeHandle selStrideInPixelsXXHandle = Selector.GetHandle ("strideInPixelsX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInPixelsYX = "strideInPixelsY";
		static readonly NativeHandle selStrideInPixelsYXHandle = Selector.GetHandle ("strideInPixelsY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubPixelScaleFactorX = "subPixelScaleFactor";
		static readonly NativeHandle selSubPixelScaleFactorXHandle = Selector.GetHandle ("subPixelScaleFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_X = "temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_X = "temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNConvolution");
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
		public MPSCnnConvolution (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSCnnConvolution (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnConvolution (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="weights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:weights:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnConvolution (global::Metal.IMTLDevice device, IMPSCnnConvolutionDataSource weights)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_Weights_XHandle, device__handle__, weights__handle__), "initWithDevice:weights:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_Weights_XHandle, device__handle__, weights__handle__), "initWithDevice:weights:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (weights);
		}
		/// <param name="aDecoder">The unarchiver object.</param><param name="device">To be added.</param><summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary><remarks><para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization).   This is part of the <see cref="T:Foundation.NSCoding" />  protocol.</para><para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="T:Foundation.NSCoder" /> and decorate it with the [Export("initWithCoder:"] attribute declaration.</para><para>The state of this object can also be serialized by using the companion method, EncodeTo.</para></remarks>
		[Export ("initWithCoder:device:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnConvolution (NSCoder aDecoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithCoder_Device_XHandle, aDecoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithCoder_Device_XHandle, aDecoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aDecoder);
			GC.KeepAlive (device);
		}
		/// <param name="commandBuffer">To be added.</param><param name="resultStateCanBeTemporary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionWeightsAndBiasesState ExportWeightsAndBiases (global::Metal.IMTLCommandBuffer commandBuffer, bool resultStateCanBeTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			MPSCnnConvolutionWeightsAndBiasesState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_XHandle, commandBuffer__handle__, resultStateCanBeTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_XHandle, commandBuffer__handle__, resultStateCanBeTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <param name="sourceImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateForSourceImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionGradientState? GetResultState (MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSCnnConvolutionGradientState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnConvolutionGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateForSourceImage_SourceStates_DestinationImage_XHandle, sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnConvolutionGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateForSourceImage_SourceStates_DestinationImage_XHandle, sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="sourceImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateBatchForSourceImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionGradientState[]? GetResultStateBatch (NSArray<MPSImage> sourceImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
		{
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSCnnConvolutionGradientState[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateBatchForSourceImage_SourceStates_DestinationImage_XHandle, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateBatchForSourceImage_SourceStates_DestinationImage_XHandle, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionGradientState? GetTemporaryResultState (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSCnnConvolutionGradientState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnConvolutionGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnConvolutionGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionGradientState[]? GetTemporaryResultStateBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSCnnConvolutionGradientState[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		[Export ("initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitWithDevice (global::Metal.IMTLDevice device, MPSCnnConvolutionDescriptor convolutionDescriptor, nint kernelWeights, nint biasTerms, MPSCnnConvolutionFlags flags)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var convolutionDescriptor__handle__ = convolutionDescriptor!.GetNonNullHandle (nameof (convolutionDescriptor));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr_UIntPtr (this.Handle, selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_XHandle, device__handle__, convolutionDescriptor__handle__, kernelWeights, biasTerms, (UIntPtr) (ulong) flags);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_IntPtr_UIntPtr (&__objc_super__, selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_XHandle, device__handle__, convolutionDescriptor__handle__, kernelWeights, biasTerms, (UIntPtr) (ulong) flags);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (convolutionDescriptor);
			return ret!;
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadWeightsAndBiasesWithDataSource:")]
		[ObsoletedOSPlatform ("tvos12.0", "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadWeightsAndBiases (IMPSCnnConvolutionDataSource dataSource)
		{
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadWeightsAndBiasesWithDataSource_XHandle, dataSource__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadWeightsAndBiasesWithDataSource_XHandle, dataSource__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataSource);
		}
		/// <param name="commandBuffer">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadWeightsAndBiasesWithCommandBuffer:state:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadWeightsAndBiases (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnConvolutionWeightsAndBiasesState state)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReloadWeightsAndBiasesWithCommandBuffer_State_XHandle, commandBuffer__handle__, state__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReloadWeightsAndBiasesWithCommandBuffer_State_XHandle, commandBuffer__handle__, state__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (state);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadWeightsAndBiasesFromDataSource")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadWeightsAndBiasesFromDataSource ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadWeightsAndBiasesFromDataSourceXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReloadWeightsAndBiasesFromDataSourceXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPSNNConvolutionAccumulatorPrecisionOption AccumulatorPrecisionOption {
			[Export ("accumulatorPrecisionOption", ArgumentSemantic.Assign)]
			get {
				MPSNNConvolutionAccumulatorPrecisionOption ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSNNConvolutionAccumulatorPrecisionOption) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAccumulatorPrecisionOptionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSNNConvolutionAccumulatorPrecisionOption) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAccumulatorPrecisionOptionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccumulatorPrecisionOption:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAccumulatorPrecisionOption_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAccumulatorPrecisionOption_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint ChannelMultiplier {
			[Export ("channelMultiplier")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selChannelMultiplierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selChannelMultiplierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IMPSCnnConvolutionDataSource DataSource {
			[Export ("dataSource", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint DilationRateX {
			[Export ("dilationRateX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDilationRateXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDilationRateXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint DilationRateY {
			[Export ("dilationRateY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDilationRateYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDilationRateYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPSNNNeuronDescriptor? FusedNeuronDescriptor {
			[Export ("fusedNeuronDescriptor")]
			get {
				MPSNNNeuronDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSNNNeuronDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFusedNeuronDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSNNNeuronDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFusedNeuronDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Groups {
			[Export ("groups")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selGroupsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selGroupsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
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
		public override nuint KernelHeight {
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nuint KernelWidth {
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
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos11.0", "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("ios11.0", "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSCnnNeuron? Neuron {
			[Export ("neuron")]
			get {
				MPSCnnNeuron? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSCnnNeuron> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNeuronXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSCnnNeuron> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNeuronXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual float NeuronParameterA {
			[Export ("neuronParameterA")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNeuronParameterAXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNeuronParameterAXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual float NeuronParameterB {
			[Export ("neuronParameterB")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNeuronParameterBXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNeuronParameterBXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual float NeuronParameterC {
			[Export ("neuronParameterC")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNeuronParameterCXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNeuronParameterCXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPSCnnNeuronType NeuronType {
			[Export ("neuronType")]
			get {
				MPSCnnNeuronType ret;
				if (IsDirectBinding) {
					ret = (MPSCnnNeuronType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNeuronTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSCnnNeuronType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selNeuronTypeXHandle);
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
		public override nuint StrideInPixelsX {
			[Export ("strideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStrideInPixelsXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStrideInPixelsXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nuint StrideInPixelsY {
			[Export ("strideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStrideInPixelsYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStrideInPixelsYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SubPixelScaleFactor {
			[Export ("subPixelScaleFactor")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSubPixelScaleFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSubPixelScaleFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSCnnConvolution */
}
