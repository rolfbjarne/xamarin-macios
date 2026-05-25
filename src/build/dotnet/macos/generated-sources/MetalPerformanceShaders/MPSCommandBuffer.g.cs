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
	[Register("MPSCommandBuffer", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSCommandBuffer : NSObject, global::Metal.IMTLCommandBuffer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGPUEndTimeX = "GPUEndTime";
		static readonly NativeHandle selGPUEndTimeXHandle = Selector.GetHandle ("GPUEndTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGPUStartTimeX = "GPUStartTime";
		static readonly NativeHandle selGPUStartTimeXHandle = Selector.GetHandle ("GPUStartTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccelerationStructureCommandEncoderX = "accelerationStructureCommandEncoder";
		static readonly NativeHandle selAccelerationStructureCommandEncoderXHandle = Selector.GetHandle ("accelerationStructureCommandEncoder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccelerationStructureCommandEncoderWithDescriptor_X = "accelerationStructureCommandEncoderWithDescriptor:";
		static readonly NativeHandle selAccelerationStructureCommandEncoderWithDescriptor_XHandle = Selector.GetHandle ("accelerationStructureCommandEncoderWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddCompletedHandler_X = "addCompletedHandler:";
		static readonly NativeHandle selAddCompletedHandler_XHandle = Selector.GetHandle ("addCompletedHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddScheduledHandler_X = "addScheduledHandler:";
		static readonly NativeHandle selAddScheduledHandler_XHandle = Selector.GetHandle ("addScheduledHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlitCommandEncoderX = "blitCommandEncoder";
		static readonly NativeHandle selBlitCommandEncoderXHandle = Selector.GetHandle ("blitCommandEncoder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlitCommandEncoderWithDescriptor_X = "blitCommandEncoderWithDescriptor:";
		static readonly NativeHandle selBlitCommandEncoderWithDescriptor_XHandle = Selector.GetHandle ("blitCommandEncoderWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandBufferX = "commandBuffer";
		static readonly NativeHandle selCommandBufferXHandle = Selector.GetHandle ("commandBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandBufferFromCommandQueue_X = "commandBufferFromCommandQueue:";
		static readonly NativeHandle selCommandBufferFromCommandQueue_XHandle = Selector.GetHandle ("commandBufferFromCommandQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandBufferWithCommandBuffer_X = "commandBufferWithCommandBuffer:";
		static readonly NativeHandle selCommandBufferWithCommandBuffer_XHandle = Selector.GetHandle ("commandBufferWithCommandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandQueueX = "commandQueue";
		static readonly NativeHandle selCommandQueueXHandle = Selector.GetHandle ("commandQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommitX = "commit";
		static readonly NativeHandle selCommitXHandle = Selector.GetHandle ("commit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommitAndContinueX = "commitAndContinue";
		static readonly NativeHandle selCommitAndContinueXHandle = Selector.GetHandle ("commitAndContinue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComputeCommandEncoderX = "computeCommandEncoder";
		static readonly NativeHandle selComputeCommandEncoderXHandle = Selector.GetHandle ("computeCommandEncoder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComputeCommandEncoderWithDescriptor_X = "computeCommandEncoderWithDescriptor:";
		static readonly NativeHandle selComputeCommandEncoderWithDescriptor_XHandle = Selector.GetHandle ("computeCommandEncoderWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComputeCommandEncoderWithDispatchType_X = "computeCommandEncoderWithDispatchType:";
		static readonly NativeHandle selComputeCommandEncoderWithDispatchType_XHandle = Selector.GetHandle ("computeCommandEncoderWithDispatchType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeSignalEvent_Value_X = "encodeSignalEvent:value:";
		static readonly NativeHandle selEncodeSignalEvent_Value_XHandle = Selector.GetHandle ("encodeSignalEvent:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWaitForEvent_Value_X = "encodeWaitForEvent:value:";
		static readonly NativeHandle selEncodeWaitForEvent_Value_XHandle = Selector.GetHandle ("encodeWaitForEvent:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnqueueX = "enqueue";
		static readonly NativeHandle selEnqueueXHandle = Selector.GetHandle ("enqueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorX = "error";
		static readonly NativeHandle selErrorXHandle = Selector.GetHandle ("error");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorOptionsX = "errorOptions";
		static readonly NativeHandle selErrorOptionsXHandle = Selector.GetHandle ("errorOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeapProviderX = "heapProvider";
		static readonly NativeHandle selHeapProviderXHandle = Selector.GetHandle ("heapProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCommandBuffer_X = "initWithCommandBuffer:";
		static readonly NativeHandle selInitWithCommandBuffer_XHandle = Selector.GetHandle ("initWithCommandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelEndTimeX = "kernelEndTime";
		static readonly NativeHandle selKernelEndTimeXHandle = Selector.GetHandle ("kernelEndTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelStartTimeX = "kernelStartTime";
		static readonly NativeHandle selKernelStartTimeXHandle = Selector.GetHandle ("kernelStartTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogsX = "logs";
		static readonly NativeHandle selLogsXHandle = Selector.GetHandle ("logs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParallelRenderCommandEncoderWithDescriptor_X = "parallelRenderCommandEncoderWithDescriptor:";
		static readonly NativeHandle selParallelRenderCommandEncoderWithDescriptor_XHandle = Selector.GetHandle ("parallelRenderCommandEncoderWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopDebugGroupX = "popDebugGroup";
		static readonly NativeHandle selPopDebugGroupXHandle = Selector.GetHandle ("popDebugGroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateX = "predicate";
		static readonly NativeHandle selPredicateXHandle = Selector.GetHandle ("predicate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrefetchHeapForWorkloadSize_X = "prefetchHeapForWorkloadSize:";
		static readonly NativeHandle selPrefetchHeapForWorkloadSize_XHandle = Selector.GetHandle ("prefetchHeapForWorkloadSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentDrawable_X = "presentDrawable:";
		static readonly NativeHandle selPresentDrawable_XHandle = Selector.GetHandle ("presentDrawable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentDrawable_AfterMinimumDuration_X = "presentDrawable:afterMinimumDuration:";
		static readonly NativeHandle selPresentDrawable_AfterMinimumDuration_XHandle = Selector.GetHandle ("presentDrawable:afterMinimumDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentDrawable_AtTime_X = "presentDrawable:atTime:";
		static readonly NativeHandle selPresentDrawable_AtTime_XHandle = Selector.GetHandle ("presentDrawable:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPushDebugGroup_X = "pushDebugGroup:";
		static readonly NativeHandle selPushDebugGroup_XHandle = Selector.GetHandle ("pushDebugGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderCommandEncoderWithDescriptor_X = "renderCommandEncoderWithDescriptor:";
		static readonly NativeHandle selRenderCommandEncoderWithDescriptor_XHandle = Selector.GetHandle ("renderCommandEncoderWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceStateCommandEncoderX = "resourceStateCommandEncoder";
		static readonly NativeHandle selResourceStateCommandEncoderXHandle = Selector.GetHandle ("resourceStateCommandEncoder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceStateCommandEncoderWithDescriptor_X = "resourceStateCommandEncoderWithDescriptor:";
		static readonly NativeHandle selResourceStateCommandEncoderWithDescriptor_XHandle = Selector.GetHandle ("resourceStateCommandEncoderWithDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRetainedReferencesX = "retainedReferences";
		static readonly NativeHandle selRetainedReferencesXHandle = Selector.GetHandle ("retainedReferences");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRootCommandBufferX = "rootCommandBuffer";
		static readonly NativeHandle selRootCommandBufferXHandle = Selector.GetHandle ("rootCommandBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHeapProvider_X = "setHeapProvider:";
		static readonly NativeHandle selSetHeapProvider_XHandle = Selector.GetHandle ("setHeapProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_X = "setLabel:";
		static readonly NativeHandle selSetLabel_XHandle = Selector.GetHandle ("setLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPredicate_X = "setPredicate:";
		static readonly NativeHandle selSetPredicate_XHandle = Selector.GetHandle ("setPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseResidencySet_X = "useResidencySet:";
		static readonly NativeHandle selUseResidencySet_XHandle = Selector.GetHandle ("useResidencySet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseResidencySets_Count_X = "useResidencySets:count:";
		static readonly NativeHandle selUseResidencySets_Count_XHandle = Selector.GetHandle ("useResidencySets:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitUntilCompletedX = "waitUntilCompleted";
		static readonly NativeHandle selWaitUntilCompletedXHandle = Selector.GetHandle ("waitUntilCompleted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitUntilScheduledX = "waitUntilScheduled";
		static readonly NativeHandle selWaitUntilScheduledXHandle = Selector.GetHandle ("waitUntilScheduled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCommandBuffer");
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
		protected MPSCommandBuffer (NSObjectFlag t) : base (t)
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
		protected internal MPSCommandBuffer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCommandBuffer:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer)
			: base (NSObjectFlag.Empty)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCommandBuffer_XHandle, commandBuffer__handle__), "initWithCommandBuffer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCommandBuffer_XHandle, commandBuffer__handle__), "initWithCommandBuffer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addCompletedHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddCompletedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V83))]global::System.Action<global::Metal.IMTLCommandBuffer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V83.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddCompletedHandler_XHandle, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddCompletedHandler_XHandle, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addScheduledHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddScheduledHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V83))]global::System.Action<global::Metal.IMTLCommandBuffer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V83.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddScheduledHandler_XHandle, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddScheduledHandler_XHandle, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("commit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Commit ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCommitXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCommitXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("commitAndContinue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitAndContinue ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCommitAndContinueXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCommitAndContinueXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("computeCommandEncoderWithDispatchType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLComputeCommandEncoder? ComputeCommandEncoderDispatch (global::Metal.MTLDispatchType dispatchType)
		{
			global::Metal.IMTLComputeCommandEncoder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selComputeCommandEncoderWithDispatchType_XHandle, (UIntPtr) (ulong) dispatchType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selComputeCommandEncoderWithDispatchType_XHandle, (UIntPtr) (ulong) dispatchType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("commandBufferWithCommandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCommandBuffer Create (global::Metal.IMTLCommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			MPSCommandBuffer? ret;
			ret =  Runtime.GetNSObject<MPSCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCommandBufferWithCommandBuffer_XHandle, commandBuffer__handle__), false)!;
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		[Export ("commandBufferFromCommandQueue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCommandBuffer Create (global::Metal.IMTLCommandQueue commandQueue)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			MPSCommandBuffer? ret;
			ret =  Runtime.GetNSObject<MPSCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCommandBufferFromCommandQueue_XHandle, commandQueue__handle__), false)!;
			GC.KeepAlive (commandQueue);
			return ret!;
		}
		[Export ("accelerationStructureCommandEncoder")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder ()
		{
			global::Metal.IMTLAccelerationStructureCommandEncoder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccelerationStructureCommandEncoderXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccelerationStructureCommandEncoderXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accelerationStructureCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder (global::Metal.MTLAccelerationStructurePassDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			global::Metal.IMTLAccelerationStructureCommandEncoder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAccelerationStructureCommandEncoderWithDescriptor_XHandle, descriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccelerationStructureCommandEncoderWithDescriptor_XHandle, descriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("blitCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLBlitCommandEncoder CreateBlitCommandEncoder (global::Metal.MTLBlitPassDescriptor blitPassDescriptor)
		{
			var blitPassDescriptor__handle__ = blitPassDescriptor!.GetNonNullHandle (nameof (blitPassDescriptor));
			global::Metal.IMTLBlitCommandEncoder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selBlitCommandEncoderWithDescriptor_XHandle, blitPassDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selBlitCommandEncoderWithDescriptor_XHandle, blitPassDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (blitPassDescriptor);
			return ret!;
		}
		[Export ("computeCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLComputeCommandEncoder CreateComputeCommandEncoder (global::Metal.MTLComputePassDescriptor computePassDescriptor)
		{
			var computePassDescriptor__handle__ = computePassDescriptor!.GetNonNullHandle (nameof (computePassDescriptor));
			global::Metal.IMTLComputeCommandEncoder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComputeCommandEncoderWithDescriptor_XHandle, computePassDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComputeCommandEncoderWithDescriptor_XHandle, computePassDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (computePassDescriptor);
			return ret!;
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("parallelRenderCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLParallelRenderCommandEncoder? CreateParallelRenderCommandEncoder (global::Metal.MTLRenderPassDescriptor renderPassDescriptor)
		{
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			global::Metal.IMTLParallelRenderCommandEncoder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLParallelRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selParallelRenderCommandEncoderWithDescriptor_XHandle, renderPassDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLParallelRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selParallelRenderCommandEncoderWithDescriptor_XHandle, renderPassDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (renderPassDescriptor);
			return ret!;
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("renderCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLRenderCommandEncoder CreateRenderCommandEncoder (global::Metal.MTLRenderPassDescriptor renderPassDescriptor)
		{
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			global::Metal.IMTLRenderCommandEncoder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selRenderCommandEncoderWithDescriptor_XHandle, renderPassDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selRenderCommandEncoderWithDescriptor_XHandle, renderPassDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (renderPassDescriptor);
			return ret!;
		}
		[Export ("resourceStateCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLResourceStateCommandEncoder CreateResourceStateCommandEncoder (global::Metal.MTLResourceStatePassDescriptor resourceStatePassDescriptor)
		{
			var resourceStatePassDescriptor__handle__ = resourceStatePassDescriptor!.GetNonNullHandle (nameof (resourceStatePassDescriptor));
			global::Metal.IMTLResourceStateCommandEncoder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selResourceStateCommandEncoderWithDescriptor_XHandle, resourceStatePassDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selResourceStateCommandEncoderWithDescriptor_XHandle, resourceStatePassDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resourceStatePassDescriptor);
			return ret!;
		}
		[Export ("encodeSignalEvent:value:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeSignal (global::Metal.IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, selEncodeSignalEvent_Value_XHandle, @event__handle__, value);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt64 (&__objc_super__, selEncodeSignalEvent_Value_XHandle, @event__handle__, value);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@event);
		}
		[Export ("encodeWaitForEvent:value:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeWait (global::Metal.IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, selEncodeWaitForEvent_Value_XHandle, @event__handle__, value);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt64 (&__objc_super__, selEncodeWaitForEvent_Value_XHandle, @event__handle__, value);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@event);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("enqueue")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Enqueue ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEnqueueXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selEnqueueXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("popDebugGroup")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopDebugGroup ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPopDebugGroupXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPopDebugGroupXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prefetchHeapForWorkloadSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrefetchHeap (nuint size)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selPrefetchHeapForWorkloadSize_XHandle, size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selPrefetchHeapForWorkloadSize_XHandle, size);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="drawable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentDrawable:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentDrawable (global::Metal.IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentDrawable_XHandle, drawable__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentDrawable_XHandle, drawable__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (drawable);
		}
		/// <param name="drawable">To be added.</param><param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentDrawable:atTime:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentDrawable (global::Metal.IMTLDrawable drawable, double presentationTime)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, selPresentDrawable_AtTime_XHandle, drawable__handle__, presentationTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Double (&__objc_super__, selPresentDrawable_AtTime_XHandle, drawable__handle__, presentationTime);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (drawable);
		}
		/// <summary>Presents the specified <paramref name="drawable" /> after the previous drawable has been displayed for <paramref name="duration" /> seconds.</summary><param name="drawable">The drawable to present immediately after the command buffer is scheduled to run.</param><param name="duration">The minimum display time of the previous drawable.</param>
		[Export ("presentDrawable:afterMinimumDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentDrawableAfter (global::Metal.IMTLDrawable drawable, double duration)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, selPresentDrawable_AfterMinimumDuration_XHandle, drawable__handle__, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Double (&__objc_super__, selPresentDrawable_AfterMinimumDuration_XHandle, drawable__handle__, duration);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (drawable);
		}
		[Export ("pushDebugGroup:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushDebugGroup (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPushDebugGroup_XHandle, nsstring);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPushDebugGroup_XHandle, nsstring);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstring);
		}
		[Export ("useResidencySet:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResidencySet (global::Metal.IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUseResidencySet_XHandle, residencySet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUseResidencySet_XHandle, residencySet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (residencySet);
		}
		[Export ("useResidencySets:count:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResidencySets (nint residencySets, nuint count)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, selUseResidencySets_Count_XHandle, residencySets, count);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selUseResidencySets_Count_XHandle, residencySets, count);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("waitUntilCompleted")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitUntilCompleted ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWaitUntilCompletedXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selWaitUntilCompletedXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("waitUntilScheduled")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitUntilScheduled ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWaitUntilScheduledXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selWaitUntilScheduledXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Metal.IMTLBlitCommandEncoder BlitCommandEncoder {
			[Export ("blitCommandEncoder")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLBlitCommandEncoder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBlitCommandEncoderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBlitCommandEncoderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLCommandBuffer CommandBuffer {
			[Export ("commandBuffer", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLCommandBuffer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommandBufferXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommandBufferXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Metal.IMTLCommandQueue CommandQueue {
			[Export ("commandQueue")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLCommandQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommandQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommandQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Metal.IMTLComputeCommandEncoder ComputeCommandEncoder {
			[Export ("computeCommandEncoder")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLComputeCommandEncoder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selComputeCommandEncoderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selComputeCommandEncoderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Metal.IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSError Error {
			[Export ("error")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NSError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selErrorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selErrorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.MTLCommandBufferErrorOption ErrorOptions {
			[Export ("errorOptions")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.MTLCommandBufferErrorOption ret;
				if (IsDirectBinding) {
					ret = (MTLCommandBufferErrorOption) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selErrorOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLCommandBufferErrorOption) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selErrorOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU stopped running the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		public virtual double GpuEndTime {
			[Export ("GPUEndTime")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selGPUEndTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selGPUEndTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU started running the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		public virtual double GpuStartTime {
			[Export ("GPUStartTime")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selGPUStartTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selGPUStartTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSHeapProvider? HeapProvider {
			[Export ("heapProvider", ArgumentSemantic.Retain)]
			get {
				IMPSHeapProvider? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSHeapProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHeapProviderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSHeapProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHeapProviderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHeapProvider:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHeapProvider_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHeapProvider_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU finished scheduling the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		public virtual double KernelEndTime {
			[Export ("kernelEndTime")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selKernelEndTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selKernelEndTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU started scheduling the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		public virtual double KernelStartTime {
			[Export ("kernelStartTime")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selKernelStartTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selKernelStartTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.IMTLLogContainer Logs {
			[Export ("logs")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLLogContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLLogContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLogsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLLogContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLogsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSPredicate? Predicate {
			[Export ("predicate", ArgumentSemantic.Retain)]
			get {
				MPSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPredicateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPredicateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPredicate:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPredicate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPredicate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.IMTLResourceStateCommandEncoder? ResourceStateCommandEncoder {
			[Export ("resourceStateCommandEncoder")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLResourceStateCommandEncoder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourceStateCommandEncoderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourceStateCommandEncoderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool RetainedReferences {
			[Export ("retainedReferences")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRetainedReferencesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRetainedReferencesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLCommandBuffer RootCommandBuffer {
			[Export ("rootCommandBuffer", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLCommandBuffer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRootCommandBufferXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRootCommandBufferXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::Metal.MTLCommandBufferStatus Status {
			[Export ("status")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.MTLCommandBufferStatus ret;
				if (IsDirectBinding) {
					ret = (MTLCommandBufferStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLCommandBufferStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>Represents the value associated with the constant 'MTLCommandBufferErrorDomain'.</summary>
		[Field ("MTLCommandBufferErrorDomain",  "MetalPerformanceShaders")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.MetalPerformanceShaders.Handle, "MTLCommandBufferErrorDomain")!;
				return _ErrorDomain;
			}
		}
	} /* class MPSCommandBuffer */
}
