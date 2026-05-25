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
	/// <summary>A <see cref="T:MetalPerformanceShaders.MPSCnnKernel" /> that transposes its input.</summary>
	[Register("MPSCNNConvolutionTranspose", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSCnnConvolutionTranspose : MPSCnnKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccumulatorPrecisionOptionX = "accumulatorPrecisionOption";
		static readonly NativeHandle selAccumulatorPrecisionOptionXHandle = Selector.GetHandle ("accumulatorPrecisionOption");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_X = "encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_X = "encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationImages:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationStates_DestinationStateIsTemporary_X = "encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationStates:destinationStateIsTemporary:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationStates_DestinationStateIsTemporary_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationStates:destinationStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_X = "encodeToCommandBuffer:sourceImage:convolutionGradientState:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImage:convolutionGradientState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_X = "encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationImage:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationState_DestinationStateIsTemporary_X = "encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationState:destinationStateIsTemporary:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationState_DestinationStateIsTemporary_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationState:destinationStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_X = "exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:";
		static readonly NativeHandle selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_XHandle = Selector.GetHandle ("exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupsX = "groups";
		static readonly NativeHandle selGroupsXHandle = Selector.GetHandle ("groups");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_Weights_X = "initWithDevice:weights:";
		static readonly NativeHandle selInitWithDevice_Weights_XHandle = Selector.GetHandle ("initWithDevice:weights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputFeatureChannelsX = "inputFeatureChannels";
		static readonly NativeHandle selInputFeatureChannelsXHandle = Selector.GetHandle ("inputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelOffsetXX = "kernelOffsetX";
		static readonly NativeHandle selKernelOffsetXXHandle = Selector.GetHandle ("kernelOffsetX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelOffsetYX = "kernelOffsetY";
		static readonly NativeHandle selKernelOffsetYXHandle = Selector.GetHandle ("kernelOffsetY");
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
		const string selResultStateBatchForSourceImage_SourceStates_DestinationImage_X = "resultStateBatchForSourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateBatchForSourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateBatchForSourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateForSourceImage_SourceStates_DestinationImage_X = "resultStateForSourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateForSourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateForSourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccumulatorPrecisionOption_X = "setAccumulatorPrecisionOption:";
		static readonly NativeHandle selSetAccumulatorPrecisionOption_XHandle = Selector.GetHandle ("setAccumulatorPrecisionOption:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKernelOffsetX_X = "setKernelOffsetX:";
		static readonly NativeHandle selSetKernelOffsetX_XHandle = Selector.GetHandle ("setKernelOffsetX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKernelOffsetY_X = "setKernelOffsetY:";
		static readonly NativeHandle selSetKernelOffsetY_XHandle = Selector.GetHandle ("setKernelOffsetY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_X = "temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_X = "temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNConvolutionTranspose");
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
		public MPSCnnConvolutionTranspose (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSCnnConvolutionTranspose (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnConvolutionTranspose (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="weights">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:weights:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnConvolutionTranspose (global::Metal.IMTLDevice device, IMPSCnnConvolutionDataSource weights)
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
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnConvolutionTranspose (NSCoder aDecoder, global::Metal.IMTLDevice device)
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
		[Export ("encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationState:destinationStateIsTemporary:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionGradientState? convolutionGradientState, out MPSCnnConvolutionTransposeGradientState? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var convolutionGradientState__handle__ = convolutionGradientState.GetHandle ();
			NativeHandle outStateValue = IntPtr.Zero;
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationState_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, sourceImage__handle__, convolutionGradientState__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationState_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, sourceImage__handle__, convolutionGradientState__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (convolutionGradientState);
			outState = Runtime.GetNSObject<MetalPerformanceShaders.MPSCnnConvolutionTransposeGradientState> (outStateValue)!;
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="convolutionGradientState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage> EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, MPSCnnConvolutionGradientState[]? convolutionGradientState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			using var nsa_convolutionGradientState = convolutionGradientState is null ? null : NSArray.FromNSObjects (convolutionGradientState);
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_convolutionGradientState.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_convolutionGradientState.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="convolutionGradientState">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationImages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, MPSCnnConvolutionGradientState[]? convolutionGradientState, NSArray<MPSImage> destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_convolutionGradientState = convolutionGradientState is null ? null : NSArray.FromNSObjects (convolutionGradientState);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_convolutionGradientState.GetHandle (), destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationImages_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_convolutionGradientState.GetHandle (), destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (destinationImage);
		}
		[Export ("encodeBatchToCommandBuffer:sourceImages:convolutionGradientStates:destinationStates:destinationStateIsTemporary:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage[] EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages, MPSCnnConvolutionGradientState[]? convolutionGradientStates, out MPSCnnConvolutionTransposeGradientState[]? outStates, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			NativeHandle outStatesValue = IntPtr.Zero;
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_convolutionGradientStates = convolutionGradientStates is null ? null : NSArray.FromNSObjects (convolutionGradientStates);
			MPSImage[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSImage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationStates_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_convolutionGradientStates.GetHandle (), &outStatesValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSImage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_ConvolutionGradientStates_DestinationStates_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_convolutionGradientStates.GetHandle (), &outStatesValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			outStates = CFArray.ArrayFromHandle<MetalPerformanceShaders.MPSCnnConvolutionTransposeGradientState> (outStatesValue)!;
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="convolutionGradientState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImage:convolutionGradientState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionGradientState? convolutionGradientState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var convolutionGradientState__handle__ = convolutionGradientState.GetHandle ();
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_XHandle, commandBuffer__handle__, sourceImage__handle__, convolutionGradientState__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_XHandle, commandBuffer__handle__, sourceImage__handle__, convolutionGradientState__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (convolutionGradientState);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="convolutionGradientState">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImage:convolutionGradientState:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionGradientState? convolutionGradientState, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var convolutionGradientState__handle__ = convolutionGradientState.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, convolutionGradientState__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImage_ConvolutionGradientState_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, convolutionGradientState__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (convolutionGradientState);
			GC.KeepAlive (destinationImage);
		}
		[Export ("exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
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
		[Export ("resultStateForSourceImage:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionTransposeGradientState? GetResultState (MPSImage sourceImage, MPSCnnConvolutionGradientState[]? sourceStates, MPSImage destinationImage)
		{
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSCnnConvolutionTransposeGradientState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnConvolutionTransposeGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateForSourceImage_SourceStates_DestinationImage_XHandle, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnConvolutionTransposeGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateForSourceImage_SourceStates_DestinationImage_XHandle, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		[Export ("resultStateBatchForSourceImage:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionTransposeGradientState[]? GetResultStateBatch (MPSImage[] sourceImage, NSArray<MPSCnnConvolutionGradientState>[]? sourceStates, MPSImage[] destinationImage)
		{
			if (sourceImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImage));
			if (destinationImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationImage));
			using var nsa_sourceImage = NSArray.FromNSObjects (sourceImage);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			using var nsa_destinationImage = NSArray.FromNSObjects (destinationImage);
			MPSCnnConvolutionTransposeGradientState[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSCnnConvolutionTransposeGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateBatchForSourceImage_SourceStates_DestinationImage_XHandle, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSCnnConvolutionTransposeGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateBatchForSourceImage_SourceStates_DestinationImage_XHandle, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionTransposeGradientState? GetTemporaryResultState (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionGradientState[]? sourceStates, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSCnnConvolutionTransposeGradientState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnConvolutionTransposeGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnConvolutionTransposeGradientState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		[Export ("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionTransposeGradientState[]? GetTemporaryResultStateBatch (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImage, NSArray<MPSCnnConvolutionGradientState>[]? sourceStates, MPSImage[] destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImage));
			if (destinationImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationImage));
			using var nsa_sourceImage = NSArray.FromNSObjects (sourceImage);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			using var nsa_destinationImage = NSArray.FromNSObjects (destinationImage);
			MPSCnnConvolutionTransposeGradientState[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSCnnConvolutionTransposeGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSCnnConvolutionTransposeGradientState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		[Export ("reloadWeightsAndBiasesWithCommandBuffer:state:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
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
		[Export ("reloadWeightsAndBiasesFromDataSource")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMPSCnnConvolutionDataSource DataSource {
			get {
				return (WeakDataSource as IMPSCnnConvolutionDataSource)!;
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
		public virtual nint KernelOffsetX {
			[Export ("kernelOffsetX")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKernelOffsetXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selKernelOffsetXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setKernelOffsetX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKernelOffsetX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetKernelOffsetX_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint KernelOffsetY {
			[Export ("kernelOffsetY")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKernelOffsetYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selKernelOffsetYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setKernelOffsetY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKernelOffsetY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetKernelOffsetY_XHandle, value);
						GC.KeepAlive (this);
					}
				}
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Retain)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MPSCnnConvolutionTranspose */
}
