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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>Protocol for commands that are run on a GPU</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLCommandBuffer", WrapperType = typeof (MTLCommandBufferWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Enqueue", Selector = "enqueue")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Commit", Selector = "commit")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddScheduledHandler", Selector = "addScheduledHandler:", ParameterType = new Type [] { typeof (global::System.Action<global::Metal.IMTLCommandBuffer>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V62) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitUntilScheduled", Selector = "waitUntilScheduled")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddCompletedHandler", Selector = "addCompletedHandler:", ParameterType = new Type [] { typeof (global::System.Action<global::Metal.IMTLCommandBuffer>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V62) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitUntilCompleted", Selector = "waitUntilCompleted")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ComputeCommandEncoderDispatch", Selector = "computeCommandEncoderWithDispatchType:", ReturnType = typeof (IMTLComputeCommandEncoder), ParameterType = new Type [] { typeof (MTLDispatchType) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EncodeWait", Selector = "encodeWaitForEvent:value:", ParameterType = new Type [] { typeof (IMTLEvent), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EncodeSignal", Selector = "encodeSignalEvent:value:", ParameterType = new Type [] { typeof (IMTLEvent), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateParallelRenderCommandEncoder", Selector = "parallelRenderCommandEncoderWithDescriptor:", ReturnType = typeof (IMTLParallelRenderCommandEncoder), ParameterType = new Type [] { typeof (MTLRenderPassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentDrawable", Selector = "presentDrawable:", ParameterType = new Type [] { typeof (IMTLDrawable) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentDrawable", Selector = "presentDrawable:atTime:", ParameterType = new Type [] { typeof (IMTLDrawable), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentDrawableAfter", Selector = "presentDrawable:afterMinimumDuration:", ParameterType = new Type [] { typeof (IMTLDrawable), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderCommandEncoder", Selector = "renderCommandEncoderWithDescriptor:", ReturnType = typeof (IMTLRenderCommandEncoder), ParameterType = new Type [] { typeof (MTLRenderPassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PushDebugGroup", Selector = "pushDebugGroup:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PopDebugGroup", Selector = "popDebugGroup")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputeCommandEncoder", Selector = "computeCommandEncoderWithDescriptor:", ReturnType = typeof (IMTLComputeCommandEncoder), ParameterType = new Type [] { typeof (MTLComputePassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBlitCommandEncoder", Selector = "blitCommandEncoderWithDescriptor:", ReturnType = typeof (IMTLBlitCommandEncoder), ParameterType = new Type [] { typeof (MTLBlitPassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateResourceStateCommandEncoder", Selector = "resourceStateCommandEncoderWithDescriptor:", ReturnType = typeof (IMTLResourceStateCommandEncoder), ParameterType = new Type [] { typeof (MTLResourceStatePassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructureCommandEncoder", Selector = "accelerationStructureCommandEncoder", ReturnType = typeof (IMTLAccelerationStructureCommandEncoder))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructureCommandEncoder", Selector = "accelerationStructureCommandEncoderWithDescriptor:", ReturnType = typeof (IMTLAccelerationStructureCommandEncoder), ParameterType = new Type [] { typeof (MTLAccelerationStructurePassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResidencySet", Selector = "useResidencySet:", ParameterType = new Type [] { typeof (IMTLResidencySet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResidencySets", Selector = "useResidencySets:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CommandQueue", Selector = "commandQueue", PropertyType = typeof (IMTLCommandQueue), GetterSelector = "commandQueue", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RetainedReferences", Selector = "retainedReferences", PropertyType = typeof (bool), GetterSelector = "retainedReferences", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Status", Selector = "status", PropertyType = typeof (MTLCommandBufferStatus), GetterSelector = "status", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Error", Selector = "error", PropertyType = typeof (NSError), GetterSelector = "error", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BlitCommandEncoder", Selector = "blitCommandEncoder", PropertyType = typeof (IMTLBlitCommandEncoder), GetterSelector = "blitCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ComputeCommandEncoder", Selector = "computeCommandEncoder", PropertyType = typeof (IMTLComputeCommandEncoder), GetterSelector = "computeCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "KernelStartTime", Selector = "kernelStartTime", PropertyType = typeof (double), GetterSelector = "kernelStartTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "KernelEndTime", Selector = "kernelEndTime", PropertyType = typeof (double), GetterSelector = "kernelEndTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuStartTime", Selector = "GPUStartTime", PropertyType = typeof (double), GetterSelector = "GPUStartTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuEndTime", Selector = "GPUEndTime", PropertyType = typeof (double), GetterSelector = "GPUEndTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ResourceStateCommandEncoder", Selector = "resourceStateCommandEncoder", PropertyType = typeof (IMTLResourceStateCommandEncoder), GetterSelector = "resourceStateCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ErrorOptions", Selector = "errorOptions", PropertyType = typeof (MTLCommandBufferErrorOption), GetterSelector = "errorOptions", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Logs", Selector = "logs", PropertyType = typeof (IMTLLogContainer), GetterSelector = "logs", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLCommandBuffer : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("enqueue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Enqueue ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Enqueue (IMTLCommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("enqueue"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Commit ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Commit (IMTLCommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("commit"));
			GC.KeepAlive (This);
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addScheduledHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddScheduledHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V62))]global::System.Action<IMTLCommandBuffer> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddScheduledHandler (IMTLCommandBuffer This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V62))]global::System.Action<IMTLCommandBuffer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V62.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addScheduledHandler:"), (IntPtr) block_ptr_block);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("waitUntilScheduled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitUntilScheduled ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitUntilScheduled (IMTLCommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("waitUntilScheduled"));
			GC.KeepAlive (This);
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addCompletedHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddCompletedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V62))]global::System.Action<IMTLCommandBuffer> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddCompletedHandler (IMTLCommandBuffer This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V62))]global::System.Action<IMTLCommandBuffer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V62.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addCompletedHandler:"), (IntPtr) block_ptr_block);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("waitUntilCompleted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitUntilCompleted ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitUntilCompleted (IMTLCommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("waitUntilCompleted"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("computeCommandEncoderWithDispatchType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLComputeCommandEncoder? ComputeCommandEncoderDispatch (MTLDispatchType dispatchType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLComputeCommandEncoder? _ComputeCommandEncoderDispatch (IMTLCommandBuffer This, MTLDispatchType dispatchType)
		{
			IMTLComputeCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("computeCommandEncoderWithDispatchType:"), (UIntPtr) (ulong) dispatchType), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("encodeWaitForEvent:value:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeWait (IMTLEvent @event, ulong value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EncodeWait (IMTLCommandBuffer This, IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("encodeWaitForEvent:value:"), @event__handle__, value);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("encodeSignalEvent:value:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeSignal (IMTLEvent @event, ulong value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EncodeSignal (IMTLCommandBuffer This, IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("encodeSignalEvent:value:"), @event__handle__, value);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("parallelRenderCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLParallelRenderCommandEncoder? CreateParallelRenderCommandEncoder (MTLRenderPassDescriptor renderPassDescriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLParallelRenderCommandEncoder? _CreateParallelRenderCommandEncoder (IMTLCommandBuffer This, MTLRenderPassDescriptor renderPassDescriptor)
		{
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			IMTLParallelRenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLParallelRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("parallelRenderCommandEncoderWithDescriptor:"), renderPassDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (renderPassDescriptor);
			return ret!;
		}
		/// <param name="drawable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("presentDrawable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentDrawable (IMTLDrawable drawable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="drawable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentDrawable (IMTLCommandBuffer This, IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentDrawable:"), drawable__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (drawable);
		}
		/// <param name="drawable">To be added.</param><param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("presentDrawable:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentDrawable (IMTLDrawable drawable, double presentationTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="drawable">To be added.</param><param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentDrawable (IMTLCommandBuffer This, IMTLDrawable drawable, double presentationTime)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("presentDrawable:atTime:"), drawable__handle__, presentationTime);
			GC.KeepAlive (This);
			GC.KeepAlive (drawable);
		}
		/// <summary>Presents the specified <paramref name="drawable" /> after the previous drawable has been displayed for <paramref name="duration" /> seconds.</summary><param name="drawable">The drawable to present immediately after the command buffer is scheduled to run.</param><param name="duration">The minimum display time of the previous drawable.</param>
		[global::Foundation.RequiredMember]
		[Export ("presentDrawable:afterMinimumDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentDrawableAfter (IMTLDrawable drawable, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Presents the specified <paramref name="drawable" /> after the previous drawable has been displayed for <paramref name="duration" /> seconds.</summary><param name="drawable">The drawable to present immediately after the command buffer is scheduled to run.</param><param name="duration">The minimum display time of the previous drawable.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentDrawableAfter (IMTLCommandBuffer This, IMTLDrawable drawable, double duration)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("presentDrawable:afterMinimumDuration:"), drawable__handle__, duration);
			GC.KeepAlive (This);
			GC.KeepAlive (drawable);
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("renderCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLRenderCommandEncoder CreateRenderCommandEncoder (MTLRenderPassDescriptor renderPassDescriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLRenderCommandEncoder _CreateRenderCommandEncoder (IMTLCommandBuffer This, MTLRenderPassDescriptor renderPassDescriptor)
		{
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			IMTLRenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("renderCommandEncoderWithDescriptor:"), renderPassDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (renderPassDescriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("pushDebugGroup:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushDebugGroup (string @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PushDebugGroup (IMTLCommandBuffer This, string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pushDebugGroup:"), nsstring);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsstring);
		}
		[global::Foundation.RequiredMember]
		[Export ("popDebugGroup")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopDebugGroup ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PopDebugGroup (IMTLCommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("popDebugGroup"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("computeCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLComputeCommandEncoder CreateComputeCommandEncoder (MTLComputePassDescriptor computePassDescriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLComputeCommandEncoder _CreateComputeCommandEncoder (IMTLCommandBuffer This, MTLComputePassDescriptor computePassDescriptor)
		{
			var computePassDescriptor__handle__ = computePassDescriptor!.GetNonNullHandle (nameof (computePassDescriptor));
			IMTLComputeCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("computeCommandEncoderWithDescriptor:"), computePassDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (computePassDescriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("blitCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBlitCommandEncoder CreateBlitCommandEncoder (MTLBlitPassDescriptor blitPassDescriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBlitCommandEncoder _CreateBlitCommandEncoder (IMTLCommandBuffer This, MTLBlitPassDescriptor blitPassDescriptor)
		{
			var blitPassDescriptor__handle__ = blitPassDescriptor!.GetNonNullHandle (nameof (blitPassDescriptor));
			IMTLBlitCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("blitCommandEncoderWithDescriptor:"), blitPassDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (blitPassDescriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("resourceStateCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLResourceStateCommandEncoder CreateResourceStateCommandEncoder (MTLResourceStatePassDescriptor resourceStatePassDescriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLResourceStateCommandEncoder _CreateResourceStateCommandEncoder (IMTLCommandBuffer This, MTLResourceStatePassDescriptor resourceStatePassDescriptor)
		{
			var resourceStatePassDescriptor__handle__ = resourceStatePassDescriptor!.GetNonNullHandle (nameof (resourceStatePassDescriptor));
			IMTLResourceStateCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("resourceStateCommandEncoderWithDescriptor:"), resourceStatePassDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (resourceStatePassDescriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accelerationStructureCommandEncoder")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructureCommandEncoder _CreateAccelerationStructureCommandEncoder (IMTLCommandBuffer This)
		{
			IMTLAccelerationStructureCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accelerationStructureCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accelerationStructureCommandEncoderWithDescriptor:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder (MTLAccelerationStructurePassDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructureCommandEncoder _CreateAccelerationStructureCommandEncoder (IMTLCommandBuffer This, MTLAccelerationStructurePassDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructureCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accelerationStructureCommandEncoderWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("useResidencySet:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResidencySet (IMTLResidencySet residencySet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResidencySet (IMTLCommandBuffer This, IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useResidencySet:"), residencySet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (residencySet);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResidencySets:count:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResidencySets (nint residencySets, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResidencySets (IMTLCommandBuffer This, nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResidencySets:count:"), residencySets, count);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddCompletedHandler(System.Action{Metal.IMTLCommandBuffer})")]
		[DynamicDependencyAttribute ("AddScheduledHandler(System.Action{Metal.IMTLCommandBuffer})")]
		[DynamicDependencyAttribute ("BlitCommandEncoder")]
		[DynamicDependencyAttribute ("CommandQueue")]
		[DynamicDependencyAttribute ("Commit()")]
		[DynamicDependencyAttribute ("ComputeCommandEncoder")]
		[DynamicDependencyAttribute ("ComputeCommandEncoderDispatch(Metal.MTLDispatchType)")]
		[DynamicDependencyAttribute ("CreateAccelerationStructureCommandEncoder()")]
		[DynamicDependencyAttribute ("CreateAccelerationStructureCommandEncoder(Metal.MTLAccelerationStructurePassDescriptor)")]
		[DynamicDependencyAttribute ("CreateBlitCommandEncoder(Metal.MTLBlitPassDescriptor)")]
		[DynamicDependencyAttribute ("CreateComputeCommandEncoder(Metal.MTLComputePassDescriptor)")]
		[DynamicDependencyAttribute ("CreateParallelRenderCommandEncoder(Metal.MTLRenderPassDescriptor)")]
		[DynamicDependencyAttribute ("CreateRenderCommandEncoder(Metal.MTLRenderPassDescriptor)")]
		[DynamicDependencyAttribute ("CreateResourceStateCommandEncoder(Metal.MTLResourceStatePassDescriptor)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("EncodeSignal(Metal.IMTLEvent,System.UInt64)")]
		[DynamicDependencyAttribute ("EncodeWait(Metal.IMTLEvent,System.UInt64)")]
		[DynamicDependencyAttribute ("Enqueue()")]
		[DynamicDependencyAttribute ("Error")]
		[DynamicDependencyAttribute ("ErrorOptions")]
		[DynamicDependencyAttribute ("GpuEndTime")]
		[DynamicDependencyAttribute ("GpuStartTime")]
		[DynamicDependencyAttribute ("KernelEndTime")]
		[DynamicDependencyAttribute ("KernelStartTime")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Logs")]
		[DynamicDependencyAttribute ("PopDebugGroup()")]
		[DynamicDependencyAttribute ("PresentDrawable(Metal.IMTLDrawable,System.Double)")]
		[DynamicDependencyAttribute ("PresentDrawable(Metal.IMTLDrawable)")]
		[DynamicDependencyAttribute ("PresentDrawableAfter(Metal.IMTLDrawable,System.Double)")]
		[DynamicDependencyAttribute ("PushDebugGroup(System.String)")]
		[DynamicDependencyAttribute ("ResourceStateCommandEncoder")]
		[DynamicDependencyAttribute ("RetainedReferences")]
		[DynamicDependencyAttribute ("Status")]
		[DynamicDependencyAttribute ("UseResidencySet(Metal.IMTLResidencySet)")]
		[DynamicDependencyAttribute ("UseResidencySets(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("WaitUntilCompleted()")]
		[DynamicDependencyAttribute ("WaitUntilScheduled()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLCommandBufferWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLCommandBuffer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLCommandBuffer This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLCommandQueue CommandQueue {
			[Export ("commandQueue")]
			get {
				return _GetCommandQueue (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandQueue _GetCommandQueue (IMTLCommandBuffer This)
		{
			IMTLCommandQueue ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("commandQueue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool RetainedReferences {
			[Export ("retainedReferences")]
			get {
				return _GetRetainedReferences (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRetainedReferences (IMTLCommandBuffer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("retainedReferences"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
			[Export ("setLabel:")]
			set {
				_SetLabel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTLCommandBuffer This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLCommandBuffer This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLCommandBufferStatus Status {
			[Export ("status")]
			get {
				return _GetStatus (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLCommandBufferStatus _GetStatus (IMTLCommandBuffer This)
		{
			MTLCommandBufferStatus ret;
			ret = (MTLCommandBufferStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("status"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSError Error {
			[Export ("error")]
			get {
				return _GetError (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSError _GetError (IMTLCommandBuffer This)
		{
			NSError ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("error")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLBlitCommandEncoder BlitCommandEncoder {
			[Export ("blitCommandEncoder")]
			get {
				return _GetBlitCommandEncoder (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBlitCommandEncoder _GetBlitCommandEncoder (IMTLCommandBuffer This)
		{
			IMTLBlitCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("blitCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLComputeCommandEncoder ComputeCommandEncoder {
			[Export ("computeCommandEncoder")]
			get {
				return _GetComputeCommandEncoder (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLComputeCommandEncoder _GetComputeCommandEncoder (IMTLCommandBuffer This)
		{
			IMTLComputeCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("computeCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the time, in seconds, when the GPU started scheduling the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual double KernelStartTime {
			[Export ("kernelStartTime")]
			get {
				return _GetKernelStartTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetKernelStartTime (IMTLCommandBuffer This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("kernelStartTime"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the time, in seconds, when the GPU finished scheduling the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual double KernelEndTime {
			[Export ("kernelEndTime")]
			get {
				return _GetKernelEndTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetKernelEndTime (IMTLCommandBuffer This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("kernelEndTime"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the time, in seconds, when the GPU started running the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual double GpuStartTime {
			[Export ("GPUStartTime")]
			get {
				return _GetGpuStartTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetGpuStartTime (IMTLCommandBuffer This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("GPUStartTime"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the time, in seconds, when the GPU stopped running the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual double GpuEndTime {
			[Export ("GPUEndTime")]
			get {
				return _GetGpuEndTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetGpuEndTime (IMTLCommandBuffer This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("GPUEndTime"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual IMTLResourceStateCommandEncoder? ResourceStateCommandEncoder {
			[Export ("resourceStateCommandEncoder")]
			get {
				return _GetResourceStateCommandEncoder (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLResourceStateCommandEncoder _GetResourceStateCommandEncoder (IMTLCommandBuffer This)
		{
			IMTLResourceStateCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("resourceStateCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLCommandBufferErrorOption ErrorOptions {
			[Export ("errorOptions")]
			get {
				return _GetErrorOptions (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLCommandBufferErrorOption _GetErrorOptions (IMTLCommandBuffer This)
		{
			MTLCommandBufferErrorOption ret;
			ret = (MTLCommandBufferErrorOption) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("errorOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual IMTLLogContainer Logs {
			[Export ("logs")]
			get {
				return _GetLogs (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLLogContainer _GetLogs (IMTLCommandBuffer This)
		{
			IMTLLogContainer ret;
			ret =  Runtime.GetINativeObject<IMTLLogContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("logs")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLCommandBuffer" /> interface to support all the methods from the MTLCommandBuffer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLCommandBuffer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLCommandBuffer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLCommandBuffer_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLResourceStateCommandEncoder CreateResourceStateCommandEncoder (this IMTLCommandBuffer This, MTLResourceStatePassDescriptor resourceStatePassDescriptor)
		{
			var resourceStatePassDescriptor__handle__ = resourceStatePassDescriptor!.GetNonNullHandle (nameof (resourceStatePassDescriptor));
			IMTLResourceStateCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("resourceStateCommandEncoderWithDescriptor:"), resourceStatePassDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (resourceStatePassDescriptor);
			return ret!;
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder (this IMTLCommandBuffer This)
		{
			IMTLAccelerationStructureCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accelerationStructureCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder (this IMTLCommandBuffer This, MTLAccelerationStructurePassDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructureCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accelerationStructureCommandEncoderWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLResourceStateCommandEncoder GetResourceStateCommandEncoder (this IMTLCommandBuffer This)
		{
			IMTLResourceStateCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("resourceStateCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLCommandBufferWrapper : BaseWrapper, IMTLCommandBuffer {
		public MTLCommandBufferWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLCommandBufferWrapper))]
		static MTLCommandBufferWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("enqueue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Enqueue ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("enqueue"));
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("commit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Commit ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("commit"));
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addScheduledHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddScheduledHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V62))]global::System.Action<IMTLCommandBuffer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V62.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addScheduledHandler:"), (IntPtr) block_ptr_block);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("waitUntilScheduled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitUntilScheduled ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("waitUntilScheduled"));
		}
		/// <param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addCompletedHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddCompletedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V62))]global::System.Action<IMTLCommandBuffer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V62.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addCompletedHandler:"), (IntPtr) block_ptr_block);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("waitUntilCompleted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitUntilCompleted ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("waitUntilCompleted"));
		}
		[Export ("computeCommandEncoderWithDispatchType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLComputeCommandEncoder? ComputeCommandEncoderDispatch (MTLDispatchType dispatchType)
		{
			IMTLComputeCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("computeCommandEncoderWithDispatchType:"), (UIntPtr) (ulong) dispatchType), false)!;
			return ret;
		}
		[Export ("encodeWaitForEvent:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EncodeWait (IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, Selector.GetHandle ("encodeWaitForEvent:value:"), @event__handle__, value);
			GC.KeepAlive (@event);
		}
		[Export ("encodeSignalEvent:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EncodeSignal (IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, Selector.GetHandle ("encodeSignalEvent:value:"), @event__handle__, value);
			GC.KeepAlive (@event);
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("parallelRenderCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLParallelRenderCommandEncoder? CreateParallelRenderCommandEncoder (MTLRenderPassDescriptor renderPassDescriptor)
		{
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			IMTLParallelRenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLParallelRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("parallelRenderCommandEncoderWithDescriptor:"), renderPassDescriptor__handle__), false)!;
			GC.KeepAlive (renderPassDescriptor);
			return ret!;
		}
		/// <param name="drawable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentDrawable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PresentDrawable (IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("presentDrawable:"), drawable__handle__);
			GC.KeepAlive (drawable);
		}
		/// <param name="drawable">To be added.</param><param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentDrawable:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PresentDrawable (IMTLDrawable drawable, double presentationTime)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, Selector.GetHandle ("presentDrawable:atTime:"), drawable__handle__, presentationTime);
			GC.KeepAlive (drawable);
		}
		/// <summary>Presents the specified <paramref name="drawable" /> after the previous drawable has been displayed for <paramref name="duration" /> seconds.</summary><param name="drawable">The drawable to present immediately after the command buffer is scheduled to run.</param><param name="duration">The minimum display time of the previous drawable.</param>
		[Export ("presentDrawable:afterMinimumDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PresentDrawableAfter (IMTLDrawable drawable, double duration)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, Selector.GetHandle ("presentDrawable:afterMinimumDuration:"), drawable__handle__, duration);
			GC.KeepAlive (drawable);
		}
		/// <param name="renderPassDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("renderCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLRenderCommandEncoder CreateRenderCommandEncoder (MTLRenderPassDescriptor renderPassDescriptor)
		{
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			IMTLRenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("renderCommandEncoderWithDescriptor:"), renderPassDescriptor__handle__), false)!;
			GC.KeepAlive (renderPassDescriptor);
			return ret!;
		}
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PushDebugGroup (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pushDebugGroup:"), nsstring);
			CFString.ReleaseNative (nsstring);
		}
		[Export ("popDebugGroup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PopDebugGroup ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popDebugGroup"));
		}
		[Export ("computeCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLComputeCommandEncoder CreateComputeCommandEncoder (MTLComputePassDescriptor computePassDescriptor)
		{
			var computePassDescriptor__handle__ = computePassDescriptor!.GetNonNullHandle (nameof (computePassDescriptor));
			IMTLComputeCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("computeCommandEncoderWithDescriptor:"), computePassDescriptor__handle__), false)!;
			GC.KeepAlive (computePassDescriptor);
			return ret!;
		}
		[Export ("blitCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBlitCommandEncoder CreateBlitCommandEncoder (MTLBlitPassDescriptor blitPassDescriptor)
		{
			var blitPassDescriptor__handle__ = blitPassDescriptor!.GetNonNullHandle (nameof (blitPassDescriptor));
			IMTLBlitCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("blitCommandEncoderWithDescriptor:"), blitPassDescriptor__handle__), false)!;
			GC.KeepAlive (blitPassDescriptor);
			return ret!;
		}
		[Export ("resourceStateCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLResourceStateCommandEncoder CreateResourceStateCommandEncoder (MTLResourceStatePassDescriptor resourceStatePassDescriptor)
		{
			var resourceStatePassDescriptor__handle__ = resourceStatePassDescriptor!.GetNonNullHandle (nameof (resourceStatePassDescriptor));
			IMTLResourceStateCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("resourceStateCommandEncoderWithDescriptor:"), resourceStatePassDescriptor__handle__), false)!;
			GC.KeepAlive (resourceStatePassDescriptor);
			return ret!;
		}
		[Export ("accelerationStructureCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder ()
		{
			IMTLAccelerationStructureCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accelerationStructureCommandEncoder")), false)!;
			return ret;
		}
		[Export ("accelerationStructureCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructureCommandEncoder CreateAccelerationStructureCommandEncoder (MTLAccelerationStructurePassDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructureCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructureCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accelerationStructureCommandEncoderWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("useResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResidencySet (IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("useResidencySet:"), residencySet__handle__);
			GC.KeepAlive (residencySet);
		}
		[Export ("useResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResidencySets (nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResidencySets:count:"), residencySets, count);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandQueue CommandQueue {
			[Export ("commandQueue")]
			get {
				IMTLCommandQueue ret;
				ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandQueue")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool RetainedReferences {
			[Export ("retainedReferences")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("retainedReferences"));
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLCommandBufferStatus Status {
			[Export ("status")]
			get {
				MTLCommandBufferStatus ret;
				ret = (MTLCommandBufferStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSError Error {
			[Export ("error")]
			get {
				NSError ret;
				ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("error")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBlitCommandEncoder BlitCommandEncoder {
			[Export ("blitCommandEncoder")]
			get {
				IMTLBlitCommandEncoder ret;
				ret =  Runtime.GetINativeObject<IMTLBlitCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("blitCommandEncoder")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLComputeCommandEncoder ComputeCommandEncoder {
			[Export ("computeCommandEncoder")]
			get {
				IMTLComputeCommandEncoder ret;
				ret =  Runtime.GetINativeObject<IMTLComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("computeCommandEncoder")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU started scheduling the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double KernelStartTime {
			[Export ("kernelStartTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("kernelStartTime"));
				return ret;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU finished scheduling the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double KernelEndTime {
			[Export ("kernelEndTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("kernelEndTime"));
				return ret;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU started running the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double GpuStartTime {
			[Export ("GPUStartTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("GPUStartTime"));
				return ret;
			}
		}
		/// <summary>Returns the time, in seconds, when the GPU stopped running the command buffer.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double GpuEndTime {
			[Export ("GPUEndTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("GPUEndTime"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		public IMTLResourceStateCommandEncoder? ResourceStateCommandEncoder {
			[Export ("resourceStateCommandEncoder")]
			get {
				IMTLResourceStateCommandEncoder ret;
				ret =  Runtime.GetINativeObject<IMTLResourceStateCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("resourceStateCommandEncoder")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLCommandBufferErrorOption ErrorOptions {
			[Export ("errorOptions")]
			get {
				MTLCommandBufferErrorOption ret;
				ret = (MTLCommandBufferErrorOption) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("errorOptions"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public IMTLLogContainer Logs {
			[Export ("logs")]
			get {
				IMTLLogContainer ret;
				ret =  Runtime.GetINativeObject<IMTLLogContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("logs")), false)!;
				return ret;
			}
		}
	}
}
