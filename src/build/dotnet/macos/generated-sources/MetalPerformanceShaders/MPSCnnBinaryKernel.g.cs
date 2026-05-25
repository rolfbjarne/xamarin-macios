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
	/// <summary>A <see cref="T:MetalPerformanceShaders.MPSKernel" /> that has binary weights.</summary>
	[Register("MPSCNNBinaryKernel", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSCnnBinaryKernel : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBatchBarrierX = "appendBatchBarrier";
		static readonly NativeHandle selAppendBatchBarrierXHandle = Selector.GetHandle ("appendBatchBarrier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_X = "batchEncodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:";
		static readonly NativeHandle selBatchEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("batchEncodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:");
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
		const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_X = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_X = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_X = "encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_X = "encodeToCommandBuffer:primaryImage:secondaryImage:";
		static readonly NativeHandle selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_XHandle = Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_X = "encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:";
		static readonly NativeHandle selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_XHandle = Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_X = "encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:";
		static readonly NativeHandle selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_XHandle = Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_X = "encodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:";
		static readonly NativeHandle selEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("encodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_X = "initWithDevice:";
		static readonly NativeHandle selInitWithDevice_XHandle = Selector.GetHandle ("initWithDevice:");
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
		const string selPaddingX = "padding";
		static readonly NativeHandle selPaddingXHandle = Selector.GetHandle ("padding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryDilationRateXX = "primaryDilationRateX";
		static readonly NativeHandle selPrimaryDilationRateXXHandle = Selector.GetHandle ("primaryDilationRateX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryDilationRateYX = "primaryDilationRateY";
		static readonly NativeHandle selPrimaryDilationRateYXHandle = Selector.GetHandle ("primaryDilationRateY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryEdgeModeX = "primaryEdgeMode";
		static readonly NativeHandle selPrimaryEdgeModeXHandle = Selector.GetHandle ("primaryEdgeMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryKernelHeightX = "primaryKernelHeight";
		static readonly NativeHandle selPrimaryKernelHeightXHandle = Selector.GetHandle ("primaryKernelHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryKernelWidthX = "primaryKernelWidth";
		static readonly NativeHandle selPrimaryKernelWidthXHandle = Selector.GetHandle ("primaryKernelWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryOffsetX = "primaryOffset";
		static readonly NativeHandle selPrimaryOffsetXHandle = Selector.GetHandle ("primaryOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimarySourceFeatureChannelMaxCountX = "primarySourceFeatureChannelMaxCount";
		static readonly NativeHandle selPrimarySourceFeatureChannelMaxCountXHandle = Selector.GetHandle ("primarySourceFeatureChannelMaxCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimarySourceFeatureChannelOffsetX = "primarySourceFeatureChannelOffset";
		static readonly NativeHandle selPrimarySourceFeatureChannelOffsetXHandle = Selector.GetHandle ("primarySourceFeatureChannelOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryStrideInPixelsXX = "primaryStrideInPixelsX";
		static readonly NativeHandle selPrimaryStrideInPixelsXXHandle = Selector.GetHandle ("primaryStrideInPixelsX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryStrideInPixelsYX = "primaryStrideInPixelsY";
		static readonly NativeHandle selPrimaryStrideInPixelsYXHandle = Selector.GetHandle ("primaryStrideInPixelsY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_X = "resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_X = "resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:";
		static readonly NativeHandle selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryDilationRateXX = "secondaryDilationRateX";
		static readonly NativeHandle selSecondaryDilationRateXXHandle = Selector.GetHandle ("secondaryDilationRateX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryDilationRateYX = "secondaryDilationRateY";
		static readonly NativeHandle selSecondaryDilationRateYXHandle = Selector.GetHandle ("secondaryDilationRateY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryEdgeModeX = "secondaryEdgeMode";
		static readonly NativeHandle selSecondaryEdgeModeXHandle = Selector.GetHandle ("secondaryEdgeMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryKernelHeightX = "secondaryKernelHeight";
		static readonly NativeHandle selSecondaryKernelHeightXHandle = Selector.GetHandle ("secondaryKernelHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryKernelWidthX = "secondaryKernelWidth";
		static readonly NativeHandle selSecondaryKernelWidthXHandle = Selector.GetHandle ("secondaryKernelWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryOffsetX = "secondaryOffset";
		static readonly NativeHandle selSecondaryOffsetXHandle = Selector.GetHandle ("secondaryOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondarySourceFeatureChannelMaxCountX = "secondarySourceFeatureChannelMaxCount";
		static readonly NativeHandle selSecondarySourceFeatureChannelMaxCountXHandle = Selector.GetHandle ("secondarySourceFeatureChannelMaxCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondarySourceFeatureChannelOffsetX = "secondarySourceFeatureChannelOffset";
		static readonly NativeHandle selSecondarySourceFeatureChannelOffsetXHandle = Selector.GetHandle ("secondarySourceFeatureChannelOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryStrideInPixelsXX = "secondaryStrideInPixelsX";
		static readonly NativeHandle selSecondaryStrideInPixelsXXHandle = Selector.GetHandle ("secondaryStrideInPixelsX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryStrideInPixelsYX = "secondaryStrideInPixelsY";
		static readonly NativeHandle selSecondaryStrideInPixelsYXHandle = Selector.GetHandle ("secondaryStrideInPixelsY");
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
		const string selSetPadding_X = "setPadding:";
		static readonly NativeHandle selSetPadding_XHandle = Selector.GetHandle ("setPadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryEdgeMode_X = "setPrimaryEdgeMode:";
		static readonly NativeHandle selSetPrimaryEdgeMode_XHandle = Selector.GetHandle ("setPrimaryEdgeMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryOffset_X = "setPrimaryOffset:";
		static readonly NativeHandle selSetPrimaryOffset_XHandle = Selector.GetHandle ("setPrimaryOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimarySourceFeatureChannelMaxCount_X = "setPrimarySourceFeatureChannelMaxCount:";
		static readonly NativeHandle selSetPrimarySourceFeatureChannelMaxCount_XHandle = Selector.GetHandle ("setPrimarySourceFeatureChannelMaxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimarySourceFeatureChannelOffset_X = "setPrimarySourceFeatureChannelOffset:";
		static readonly NativeHandle selSetPrimarySourceFeatureChannelOffset_XHandle = Selector.GetHandle ("setPrimarySourceFeatureChannelOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryStrideInPixelsX_X = "setPrimaryStrideInPixelsX:";
		static readonly NativeHandle selSetPrimaryStrideInPixelsX_XHandle = Selector.GetHandle ("setPrimaryStrideInPixelsX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryStrideInPixelsY_X = "setPrimaryStrideInPixelsY:";
		static readonly NativeHandle selSetPrimaryStrideInPixelsY_XHandle = Selector.GetHandle ("setPrimaryStrideInPixelsY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryEdgeMode_X = "setSecondaryEdgeMode:";
		static readonly NativeHandle selSetSecondaryEdgeMode_XHandle = Selector.GetHandle ("setSecondaryEdgeMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryOffset_X = "setSecondaryOffset:";
		static readonly NativeHandle selSetSecondaryOffset_XHandle = Selector.GetHandle ("setSecondaryOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondarySourceFeatureChannelMaxCount_X = "setSecondarySourceFeatureChannelMaxCount:";
		static readonly NativeHandle selSetSecondarySourceFeatureChannelMaxCount_XHandle = Selector.GetHandle ("setSecondarySourceFeatureChannelMaxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondarySourceFeatureChannelOffset_X = "setSecondarySourceFeatureChannelOffset:";
		static readonly NativeHandle selSetSecondarySourceFeatureChannelOffset_XHandle = Selector.GetHandle ("setSecondarySourceFeatureChannelOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryStrideInPixelsX_X = "setSecondaryStrideInPixelsX:";
		static readonly NativeHandle selSetSecondaryStrideInPixelsX_XHandle = Selector.GetHandle ("setSecondaryStrideInPixelsX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryStrideInPixelsY_X = "setSecondaryStrideInPixelsY:";
		static readonly NativeHandle selSetSecondaryStrideInPixelsY_XHandle = Selector.GetHandle ("setSecondaryStrideInPixelsY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_X = "temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_X = "temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:";
		static readonly NativeHandle selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle = Selector.GetHandle ("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNBinaryKernel");
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
		public MPSCnnBinaryKernel (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSCnnBinaryKernel (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnBinaryKernel (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBinaryKernel (global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDevice_XHandle, device__handle__), "initWithDevice:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDevice_XHandle, device__handle__), "initWithDevice:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		/// <param name="aDecoder">The unarchiver object.</param><param name="device">To be added.</param><summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary><remarks><para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization).   This is part of the <see cref="T:Foundation.NSCoding" />  protocol.</para><para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="T:Foundation.NSCoder" /> and decorate it with the [Export("initWithCoder:"] attribute declaration.</para><para>The state of this object can also be serialized by using the companion method, EncodeTo.</para></remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBinaryKernel (NSCoder aDecoder, global::Metal.IMTLDevice device)
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
		/// <param name="commandBuffer">To be added.</param><param name="primaryImages">To be added.</param><param name="secondaryImages">To be added.</param><param name="destinationImages">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, NSArray<MPSImage> destinationImages)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImages__handle__ = primaryImages!.GetNonNullHandle (nameof (primaryImages));
			var secondaryImages__handle__ = secondaryImages!.GetNonNullHandle (nameof (secondaryImages));
			var destinationImages__handle__ = destinationImages!.GetNonNullHandle (nameof (destinationImages));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_XHandle, commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, destinationImages__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationImages_XHandle, commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, destinationImages__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImages);
			GC.KeepAlive (secondaryImages);
			GC.KeepAlive (destinationImages);
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage> EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImages">To be added.</param><param name="secondaryImages">To be added.</param><param name="outState">To be added.</param><param name="isTemporary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSArray<MPSImage> EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, out MPSState[]? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImages__handle__ = primaryImages!.GetNonNullHandle (nameof (primaryImages));
			var secondaryImages__handle__ = secondaryImages!.GetNonNullHandle (nameof (secondaryImages));
			NativeHandle outStateValue = IntPtr.Zero;
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, selEncodeBatchToCommandBuffer_PrimaryImages_SecondaryImages_DestinationStates_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImages);
			GC.KeepAlive (secondaryImages);
			outState = CFArray.ArrayFromHandle<MetalPerformanceShaders.MPSState> (outStateValue)!;
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="outState">To be added.</param><param name="isTemporary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, out MPSState? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			NativeHandle outStateValue = IntPtr.Zero;
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationState_DestinationStateIsTemporary_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			outState = Runtime.GetNSObject<MetalPerformanceShaders.MPSState> (outStateValue)!;
			return ret!;
		}
		[Export ("batchEncodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetBatchEncodingStorageSize (MPSImage[] primaryImage, MPSImage[] secondaryImage, NSArray<MPSState>[]? sourceStates, MPSImage[]? destinationImage)
		{
			if (primaryImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (primaryImage));
			if (secondaryImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (secondaryImage));
			using var nsa_primaryImage = NSArray.FromNSObjects (primaryImage);
			using var nsa_secondaryImage = NSArray.FromNSObjects (secondaryImage);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			using var nsa_destinationImage = destinationImage is null ? null : NSArray.FromNSObjects (destinationImage);
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selBatchEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, nsa_primaryImage.Handle, nsa_secondaryImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selBatchEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, nsa_primaryImage.Handle, nsa_secondaryImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("destinationImageDescriptorForSourceImages:sourceStates:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageDescriptor GetDestinationImageDescriptor (NSArray<MPSImage> sourceImages, NSArray<MPSState>? sourceStates)
		{
			var sourceImages__handle__ = sourceImages!.GetNonNullHandle (nameof (sourceImages));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			MPSImageDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDestinationImageDescriptorForSourceImages_SourceStates_XHandle, sourceImages__handle__, sourceStates__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDestinationImageDescriptorForSourceImages_SourceStates_XHandle, sourceImages__handle__, sourceStates__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImages);
			GC.KeepAlive (sourceStates);
			return ret!;
		}
		[Export ("encodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetEncodingStorageSize (MPSImage primaryImage, MPSImage secondaryImage, MPSState[]? sourceStates, MPSImage? destinationImage)
		{
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage.GetHandle ();
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodingStorageSizeForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetResultState (MPSImage primaryImage, MPSImage secondaryImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSState>? GetResultStateBatch (NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
		{
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			NSArray<MPSState>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResultStateBatchForPrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetTemporaryResultState (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSState>? GetTemporaryResultStateBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			NSArray<MPSState>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTemporaryResultStateBatchForCommandBuffer_PrimaryImage_SecondaryImage_SourceStates_DestinationImage_XHandle, commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryDilationRateX {
			[Export ("primaryDilationRateX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryDilationRateXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryDilationRateXXHandle);
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
		public virtual nuint PrimaryDilationRateY {
			[Export ("primaryDilationRateY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryDilationRateYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryDilationRateYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageEdgeMode PrimaryEdgeMode {
			[Export ("primaryEdgeMode", ArgumentSemantic.Assign)]
			get {
				MPSImageEdgeMode ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryEdgeModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryEdgeModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrimaryEdgeMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimaryEdgeMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimaryEdgeMode_XHandle, (UIntPtr) (ulong) value);
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
		public virtual nuint PrimaryKernelHeight {
			[Export ("primaryKernelHeight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryKernelHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryKernelHeightXHandle);
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
		public virtual nuint PrimaryKernelWidth {
			[Export ("primaryKernelWidth")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryKernelWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryKernelWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSOffset PrimaryOffset {
			[Export ("primaryOffset", ArgumentSemantic.Assign)]
			get {
				MPSOffset ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend (this.Handle, selPrimaryOffsetXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend_stret (this.Handle, selPrimaryOffsetXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper (&__objc_super__, selPrimaryOffsetXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper_stret (&__objc_super__, selPrimaryOffsetXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setPrimaryOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MPSOffset (this.Handle, selSetPrimaryOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MPSOffset (&__objc_super__, selSetPrimaryOffset_XHandle, value);
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
		public virtual nuint PrimarySourceFeatureChannelMaxCount {
			[Export ("primarySourceFeatureChannelMaxCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimarySourceFeatureChannelMaxCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimarySourceFeatureChannelMaxCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimarySourceFeatureChannelMaxCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimarySourceFeatureChannelMaxCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimarySourceFeatureChannelMaxCount_XHandle, value);
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
		public virtual nuint PrimarySourceFeatureChannelOffset {
			[Export ("primarySourceFeatureChannelOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimarySourceFeatureChannelOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimarySourceFeatureChannelOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimarySourceFeatureChannelOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimarySourceFeatureChannelOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimarySourceFeatureChannelOffset_XHandle, value);
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
		public virtual nuint PrimaryStrideInPixelsX {
			[Export ("primaryStrideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryStrideInPixelsXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryStrideInPixelsXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInPixelsX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimaryStrideInPixelsX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimaryStrideInPixelsX_XHandle, value);
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
		public virtual nuint PrimaryStrideInPixelsY {
			[Export ("primaryStrideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryStrideInPixelsYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryStrideInPixelsYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInPixelsY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimaryStrideInPixelsY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimaryStrideInPixelsY_XHandle, value);
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
		public virtual nuint SecondaryDilationRateX {
			[Export ("secondaryDilationRateX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryDilationRateXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryDilationRateXXHandle);
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
		public virtual nuint SecondaryDilationRateY {
			[Export ("secondaryDilationRateY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryDilationRateYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryDilationRateYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageEdgeMode SecondaryEdgeMode {
			[Export ("secondaryEdgeMode", ArgumentSemantic.Assign)]
			get {
				MPSImageEdgeMode ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryEdgeModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryEdgeModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSecondaryEdgeMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondaryEdgeMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondaryEdgeMode_XHandle, (UIntPtr) (ulong) value);
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
		public virtual nuint SecondaryKernelHeight {
			[Export ("secondaryKernelHeight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryKernelHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryKernelHeightXHandle);
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
		public virtual nuint SecondaryKernelWidth {
			[Export ("secondaryKernelWidth")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryKernelWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryKernelWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSOffset SecondaryOffset {
			[Export ("secondaryOffset", ArgumentSemantic.Assign)]
			get {
				MPSOffset ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend (this.Handle, selSecondaryOffsetXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend_stret (this.Handle, selSecondaryOffsetXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper (&__objc_super__, selSecondaryOffsetXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper_stret (&__objc_super__, selSecondaryOffsetXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setSecondaryOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MPSOffset (this.Handle, selSetSecondaryOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MPSOffset (&__objc_super__, selSetSecondaryOffset_XHandle, value);
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
		public virtual nuint SecondarySourceFeatureChannelMaxCount {
			[Export ("secondarySourceFeatureChannelMaxCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondarySourceFeatureChannelMaxCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondarySourceFeatureChannelMaxCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondarySourceFeatureChannelMaxCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondarySourceFeatureChannelMaxCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondarySourceFeatureChannelMaxCount_XHandle, value);
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
		public virtual nuint SecondarySourceFeatureChannelOffset {
			[Export ("secondarySourceFeatureChannelOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondarySourceFeatureChannelOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondarySourceFeatureChannelOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondarySourceFeatureChannelOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondarySourceFeatureChannelOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondarySourceFeatureChannelOffset_XHandle, value);
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
		public virtual nuint SecondaryStrideInPixelsX {
			[Export ("secondaryStrideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryStrideInPixelsXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryStrideInPixelsXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInPixelsX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondaryStrideInPixelsX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondaryStrideInPixelsX_XHandle, value);
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
		public virtual nuint SecondaryStrideInPixelsY {
			[Export ("secondaryStrideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryStrideInPixelsYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryStrideInPixelsYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInPixelsY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondaryStrideInPixelsY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondaryStrideInPixelsY_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSCnnBinaryKernel */
}
