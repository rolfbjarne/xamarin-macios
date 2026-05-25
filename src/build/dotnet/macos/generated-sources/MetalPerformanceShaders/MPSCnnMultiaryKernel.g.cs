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
	[Register("MPSCNNMultiaryKernel", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSCnnMultiaryKernel : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBatchBarrierX = "appendBatchBarrier";
		static readonly NativeHandle selAppendBatchBarrierXHandle = Selector.GetHandle ("appendBatchBarrier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClipRectX = "clipRect";
		static readonly NativeHandle selClipRectXHandle = Selector.GetHandle ("clipRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationFeatureChannelOffsetX = "destinationFeatureChannelOffset";
		static readonly NativeHandle selDestinationFeatureChannelOffsetXHandle = Selector.GetHandle ("destinationFeatureChannelOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationImageAllocatorX = "destinationImageAllocator";
		static readonly NativeHandle selDestinationImageAllocatorXHandle = Selector.GetHandle ("destinationImageAllocator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationImageDescriptorForSourceImages_SourceStates_X = "destinationImageDescriptorForSourceImages:sourceStates:";
		static readonly NativeHandle selDestinationImageDescriptorForSourceImages_SourceStates_XHandle = Selector.GetHandle ("destinationImageDescriptorForSourceImages:sourceStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateXatIndex_X = "dilationRateXatIndex:";
		static readonly NativeHandle selDilationRateXatIndex_XHandle = Selector.GetHandle ("dilationRateXatIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateYatIndex_X = "dilationRateYatIndex:";
		static readonly NativeHandle selDilationRateYatIndex_XHandle = Selector.GetHandle ("dilationRateYatIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEdgeModeAtIndex_X = "edgeModeAtIndex:";
		static readonly NativeHandle selEdgeModeAtIndex_XHandle = Selector.GetHandle ("edgeModeAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_X = "encodeBatchToCommandBuffer:sourceImages:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_X = "encodeBatchToCommandBuffer:sourceImages:destinationImages:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:destinationImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_X = "encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationStateIsTemporary:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImages_X = "encodeToCommandBuffer:sourceImages:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImages_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImages_DestinationImage_X = "encodeToCommandBuffer:sourceImages:destinationImage:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImages_DestinationImage_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImages:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImages_DestinationState_DestinationStateIsTemporary_X = "encodeToCommandBuffer:sourceImages:destinationState:destinationStateIsTemporary:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImages_DestinationState_DestinationStateIsTemporary_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImages:destinationState:destinationStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_SourceCount_X = "initWithDevice:sourceCount:";
		static readonly NativeHandle selInitWithDevice_SourceCount_XHandle = Selector.GetHandle ("initWithDevice:sourceCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBackwardsX = "isBackwards";
		static readonly NativeHandle selIsBackwardsXHandle = Selector.GetHandle ("isBackwards");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsResultStateReusedAcrossBatchX = "isResultStateReusedAcrossBatch";
		static readonly NativeHandle selIsResultStateReusedAcrossBatchXHandle = Selector.GetHandle ("isResultStateReusedAcrossBatch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStateModifiedX = "isStateModified";
		static readonly NativeHandle selIsStateModifiedXHandle = Selector.GetHandle ("isStateModified");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelHeightAtIndex_X = "kernelHeightAtIndex:";
		static readonly NativeHandle selKernelHeightAtIndex_XHandle = Selector.GetHandle ("kernelHeightAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelWidthAtIndex_X = "kernelWidthAtIndex:";
		static readonly NativeHandle selKernelWidthAtIndex_XHandle = Selector.GetHandle ("kernelWidthAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetAtIndex_X = "offsetAtIndex:";
		static readonly NativeHandle selOffsetAtIndex_XHandle = Selector.GetHandle ("offsetAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingX = "padding";
		static readonly NativeHandle selPaddingXHandle = Selector.GetHandle ("padding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateBatchForSourceImages_SourceStates_DestinationImage_X = "resultStateBatchForSourceImages:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateBatchForSourceImages_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateBatchForSourceImages:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateForSourceImages_SourceStates_DestinationImage_X = "resultStateForSourceImages:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateForSourceImages_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateForSourceImages:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClipRect_X = "setClipRect:";
		static readonly NativeHandle selSetClipRect_XHandle = Selector.GetHandle ("setClipRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDestinationFeatureChannelOffset_X = "setDestinationFeatureChannelOffset:";
		static readonly NativeHandle selSetDestinationFeatureChannelOffset_XHandle = Selector.GetHandle ("setDestinationFeatureChannelOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDestinationImageAllocator_X = "setDestinationImageAllocator:";
		static readonly NativeHandle selSetDestinationImageAllocator_XHandle = Selector.GetHandle ("setDestinationImageAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDilationRateX_AtIndex_X = "setDilationRateX:atIndex:";
		static readonly NativeHandle selSetDilationRateX_AtIndex_XHandle = Selector.GetHandle ("setDilationRateX:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDilationRateY_AtIndex_X = "setDilationRateY:atIndex:";
		static readonly NativeHandle selSetDilationRateY_AtIndex_XHandle = Selector.GetHandle ("setDilationRateY:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEdgeMode_AtIndex_X = "setEdgeMode:atIndex:";
		static readonly NativeHandle selSetEdgeMode_AtIndex_XHandle = Selector.GetHandle ("setEdgeMode:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKernelHeight_AtIndex_X = "setKernelHeight:atIndex:";
		static readonly NativeHandle selSetKernelHeight_AtIndex_XHandle = Selector.GetHandle ("setKernelHeight:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKernelWidth_AtIndex_X = "setKernelWidth:atIndex:";
		static readonly NativeHandle selSetKernelWidth_AtIndex_XHandle = Selector.GetHandle ("setKernelWidth:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOffset_AtIndex_X = "setOffset:atIndex:";
		static readonly NativeHandle selSetOffset_AtIndex_XHandle = Selector.GetHandle ("setOffset:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPadding_X = "setPadding:";
		static readonly NativeHandle selSetPadding_XHandle = Selector.GetHandle ("setPadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceFeatureChannelMaxCount_AtIndex_X = "setSourceFeatureChannelMaxCount:atIndex:";
		static readonly NativeHandle selSetSourceFeatureChannelMaxCount_AtIndex_XHandle = Selector.GetHandle ("setSourceFeatureChannelMaxCount:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceFeatureChannelOffset_AtIndex_X = "setSourceFeatureChannelOffset:atIndex:";
		static readonly NativeHandle selSetSourceFeatureChannelOffset_AtIndex_XHandle = Selector.GetHandle ("setSourceFeatureChannelOffset:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrideInPixelsX_AtIndex_X = "setStrideInPixelsX:atIndex:";
		static readonly NativeHandle selSetStrideInPixelsX_AtIndex_XHandle = Selector.GetHandle ("setStrideInPixelsX:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrideInPixelsY_AtIndex_X = "setStrideInPixelsY:atIndex:";
		static readonly NativeHandle selSetStrideInPixelsY_AtIndex_XHandle = Selector.GetHandle ("setStrideInPixelsY:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceCountX = "sourceCount";
		static readonly NativeHandle selSourceCountXHandle = Selector.GetHandle ("sourceCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceFeatureChannelMaxCountAtIndex_X = "sourceFeatureChannelMaxCountAtIndex:";
		static readonly NativeHandle selSourceFeatureChannelMaxCountAtIndex_XHandle = Selector.GetHandle ("sourceFeatureChannelMaxCountAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceFeatureChannelOffsetAtIndex_X = "sourceFeatureChannelOffsetAtIndex:";
		static readonly NativeHandle selSourceFeatureChannelOffsetAtIndex_XHandle = Selector.GetHandle ("sourceFeatureChannelOffsetAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInPixelsXatIndex_X = "strideInPixelsXatIndex:";
		static readonly NativeHandle selStrideInPixelsXatIndex_XHandle = Selector.GetHandle ("strideInPixelsXatIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInPixelsYatIndex_X = "strideInPixelsYatIndex:";
		static readonly NativeHandle selStrideInPixelsYatIndex_XHandle = Selector.GetHandle ("strideInPixelsYatIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateBatchForCommandBuffer_SourceImages_SourceStates_DestinationImage_X = "temporaryResultStateBatchForCommandBuffer:sourceImages:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateBatchForCommandBuffer_SourceImages_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateBatchForCommandBuffer:sourceImages:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateForCommandBuffer_SourceImages_SourceStates_DestinationImage_X = "temporaryResultStateForCommandBuffer:sourceImages:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateForCommandBuffer_SourceImages_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateForCommandBuffer:sourceImages:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNMultiaryKernel");
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
		public MPSCnnMultiaryKernel (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSCnnMultiaryKernel (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnMultiaryKernel (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDevice:sourceCount:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnMultiaryKernel (global::Metal.IMTLDevice device, nuint sourceCount)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInitWithDevice_SourceCount_XHandle, device__handle__, sourceCount), "initWithDevice:sourceCount:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInitWithDevice_SourceCount_XHandle, device__handle__, sourceCount), "initWithDevice:sourceCount:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnMultiaryKernel (NSCoder aDecoder, global::Metal.IMTLDevice device)
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
		[Export ("encodeToCommandBuffer:sourceImages:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImages_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImages_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (destinationImage);
		}
		[Export ("encodeToCommandBuffer:sourceImages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImages_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImages_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		[Export ("encodeToCommandBuffer:sourceImages:destinationState:destinationStateIsTemporary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages, out MPSState? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			NativeHandle outStateValue = IntPtr.Zero;
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, selEncodeToCommandBuffer_SourceImages_DestinationState_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, selEncodeToCommandBuffer_SourceImages_DestinationState_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			outState = Runtime.GetNSObject<MetalPerformanceShaders.MPSState> (outStateValue)!;
			return ret!;
		}
		[Export ("encodeBatchToCommandBuffer:sourceImages:destinationImages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImages, MPSImage[] destinationImages)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			if (destinationImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationImages));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_destinationImages = NSArray.FromNSObjects (destinationImages);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_destinationImages.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_DestinationImages_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_destinationImages.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		[Export ("encodeBatchToCommandBuffer:sourceImages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage[] EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImageBatches)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImageBatches is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImageBatches));
			using var nsa_sourceImageBatches = NSArray.FromNSObjects (sourceImageBatches);
			MPSImage[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSImage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_XHandle, commandBuffer__handle__, nsa_sourceImageBatches.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSImage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_XHandle, commandBuffer__handle__, nsa_sourceImageBatches.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		[Export ("encodeBatchToCommandBuffer:sourceImages:destinationStates:destinationStateIsTemporary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage[] EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImageBatches, out MPSState[]? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImageBatches is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImageBatches));
			NativeHandle outStateValue = IntPtr.Zero;
			using var nsa_sourceImageBatches = NSArray.FromNSObjects (sourceImageBatches);
			MPSImage[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSImage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, nsa_sourceImageBatches.Handle, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSImage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_DestinationStates_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, nsa_sourceImageBatches.Handle, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			outState = CFArray.ArrayFromHandle<MetalPerformanceShaders.MPSState> (outStateValue)!;
			return ret!;
		}
		[Export ("destinationImageDescriptorForSourceImages:sourceStates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageDescriptor GetDestinationImageDescriptor (MPSImage[] sourceImages, MPSState[]? sourceStates)
		{
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSImageDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDestinationImageDescriptorForSourceImages_SourceStates_XHandle, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDestinationImageDescriptorForSourceImages_SourceStates_XHandle, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("dilationRateXatIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetDilationRateX (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selDilationRateXatIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selDilationRateXatIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("dilationRateYatIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetDilationRateY (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selDilationRateYatIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selDilationRateYatIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("edgeModeAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageEdgeMode GetEdgeMode (nuint index)
		{
			MPSImageEdgeMode ret;
			if (IsDirectBinding) {
				ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selEdgeModeAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selEdgeModeAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("kernelHeightAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetKernelHeight (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selKernelHeightAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selKernelHeightAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("kernelWidthAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetKernelWidth (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selKernelWidthAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selKernelWidthAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("offsetAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSOffset GetOffset (nuint index)
		{
			MPSOffset ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend_UIntPtr (this.Handle, selOffsetAtIndex_XHandle, index);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend_stret_UIntPtr (this.Handle, selOffsetAtIndex_XHandle, index);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper_UIntPtr (&__objc_super__, selOffsetAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, selOffsetAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("resultStateForSourceImages:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetResultState (MPSImage[] sourceImages, MPSState[]? sourceStates, MPSImage destinationImage)
		{
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateForSourceImages_SourceStates_DestinationImage_XHandle, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateForSourceImages_SourceStates_DestinationImage_XHandle, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		[Export ("resultStateBatchForSourceImages:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState[]? GetResultStateBatch (NSArray<MPSImage>[] sourceImages, NSArray<MPSState>[]? sourceStates, MPSImage[] destinationImage)
		{
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			if (destinationImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationImage));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			using var nsa_destinationImage = NSArray.FromNSObjects (destinationImage);
			MPSState[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateBatchForSourceImages_SourceStates_DestinationImage_XHandle, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateBatchForSourceImages_SourceStates_DestinationImage_XHandle, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sourceFeatureChannelMaxCountAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetSourceFeatureChannelMaxCount (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selSourceFeatureChannelMaxCountAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selSourceFeatureChannelMaxCountAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sourceFeatureChannelOffsetAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetSourceFeatureChannelOffset (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selSourceFeatureChannelOffsetAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selSourceFeatureChannelOffsetAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("strideInPixelsXatIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetStrideInPixelsX (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selStrideInPixelsXatIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selStrideInPixelsXatIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("strideInPixelsYatIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetStrideInPixelsY (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selStrideInPixelsYatIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selStrideInPixelsYatIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("temporaryResultStateForCommandBuffer:sourceImages:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetTemporaryResultState (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImage, MPSState[]? sourceStates, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceImage = NSArray.FromNSObjects (sourceImage);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateForCommandBuffer_SourceImages_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateForCommandBuffer_SourceImages_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		[Export ("temporaryResultStateBatchForCommandBuffer:sourceImages:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState[]? GetTemporaryResultStateBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImage, NSArray<MPSState>[]? sourceStates, MPSImage[] destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImage));
			if (destinationImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationImage));
			using var nsa_sourceImage = NSArray.FromNSObjects (sourceImage);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			using var nsa_destinationImage = NSArray.FromNSObjects (destinationImage);
			MPSState[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateBatchForCommandBuffer_SourceImages_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateBatchForCommandBuffer_SourceImages_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, nsa_sourceImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		[Export ("setDilationRateX:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDilationRateX (nuint dilationRate, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetDilationRateX_AtIndex_XHandle, dilationRate, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetDilationRateX_AtIndex_XHandle, dilationRate, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setDilationRateY:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDilationRateY (nuint dilationRate, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetDilationRateY_AtIndex_XHandle, dilationRate, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetDilationRateY_AtIndex_XHandle, dilationRate, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setEdgeMode:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEdgeMode (MPSImageEdgeMode edgeMode, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetEdgeMode_AtIndex_XHandle, (UIntPtr) (ulong) edgeMode, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetEdgeMode_AtIndex_XHandle, (UIntPtr) (ulong) edgeMode, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setKernelHeight:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetKernelHeight (nuint height, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetKernelHeight_AtIndex_XHandle, height, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetKernelHeight_AtIndex_XHandle, height, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setKernelWidth:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetKernelWidth (nuint width, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetKernelWidth_AtIndex_XHandle, width, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetKernelWidth_AtIndex_XHandle, width, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOffset (MPSOffset offset, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MPSOffset_UIntPtr (this.Handle, selSetOffset_AtIndex_XHandle, offset, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MPSOffset_UIntPtr (&__objc_super__, selSetOffset_AtIndex_XHandle, offset, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSourceFeatureChannelMaxCount:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSourceFeatureChannelMaxCount (nuint count, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetSourceFeatureChannelMaxCount_AtIndex_XHandle, count, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetSourceFeatureChannelMaxCount_AtIndex_XHandle, count, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSourceFeatureChannelOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSourceFeatureChannelOffset (nuint offset, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetSourceFeatureChannelOffset_AtIndex_XHandle, offset, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetSourceFeatureChannelOffset_AtIndex_XHandle, offset, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setStrideInPixelsX:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStrideInPixelsX (nuint stride, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetStrideInPixelsX_AtIndex_XHandle, stride, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetStrideInPixelsX_AtIndex_XHandle, stride, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setStrideInPixelsY:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStrideInPixelsY (nuint stride, nuint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selSetStrideInPixelsY_AtIndex_XHandle, stride, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selSetStrideInPixelsY_AtIndex_XHandle, stride, index);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AppendBatchBarrier {
			[Export ("appendBatchBarrier")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAppendBatchBarrierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAppendBatchBarrierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLRegion ClipRect {
			[Export ("clipRect", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLRegion ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSend (this.Handle, selClipRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSend_stret (this.Handle, selClipRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSendSuper (&__objc_super__, selClipRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSendSuper_stret (&__objc_super__, selClipRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setClipRect:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion (this.Handle, selSetClipRect_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTLRegion (&__objc_super__, selSetClipRect_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DestinationFeatureChannelOffset {
			[Export ("destinationFeatureChannelOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDestinationFeatureChannelOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDestinationFeatureChannelOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDestinationFeatureChannelOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDestinationFeatureChannelOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDestinationFeatureChannelOffset_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSImageAllocator DestinationImageAllocator {
			[Export ("destinationImageAllocator", ArgumentSemantic.Retain)]
			get {
				IMPSImageAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationImageAllocatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationImageAllocatorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDestinationImageAllocator:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDestinationImageAllocator_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDestinationImageAllocator_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBackwards {
			[Export ("isBackwards")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBackwardsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBackwardsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsResultStateReusedAcrossBatch {
			[Export ("isResultStateReusedAcrossBatch")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsResultStateReusedAcrossBatchXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsResultStateReusedAcrossBatchXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsStateModified {
			[Export ("isStateModified")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStateModifiedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsStateModifiedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSNNPadding Padding {
			[Export ("padding", ArgumentSemantic.Retain)]
			get {
				IMPSNNPadding? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPaddingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPaddingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPadding:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPadding_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPadding_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SourceCount {
			[Export ("sourceCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSourceCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSourceCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSCnnMultiaryKernel */
}
