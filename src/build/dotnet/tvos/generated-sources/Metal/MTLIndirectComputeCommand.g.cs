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
	/// <summary>This interface represents the Objective-C protocol <c>MTLIndirectComputeCommand</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MTLIndirectComputeCommand", WrapperType = typeof (MTLIndirectComputeCommandWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetComputePipelineState", Selector = "setComputePipelineState:", ParameterType = new Type [] { typeof (IMTLComputePipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetKernelBuffer", Selector = "setKernelBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConcurrentDispatchThreadgroups", Selector = "concurrentDispatchThreadgroups:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConcurrentDispatchThreads", Selector = "concurrentDispatchThreads:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBarrier", Selector = "setBarrier")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ClearBarrier", Selector = "clearBarrier")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Reset", Selector = "reset")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetThreadgroupMemoryLength", Selector = "setThreadgroupMemoryLength:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStageInRegion", Selector = "setStageInRegion:", ParameterType = new Type [] { typeof (MTLRegion) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetImageblock", Selector = "setImageblockWidth:height:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetKernelBuffer", Selector = "setKernelBuffer:offset:attributeStride:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IMTLIndirectComputeCommand : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("setComputePipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComputePipelineState (IMTLComputePipelineState pipelineState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetComputePipelineState (IMTLIndirectComputeCommand This, IMTLComputePipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setComputePipelineState:"), pipelineState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pipelineState);
		}
		[global::Foundation.RequiredMember]
		[Export ("setKernelBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetKernelBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetKernelBuffer (IMTLIndirectComputeCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setKernelBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("concurrentDispatchThreadgroups:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConcurrentDispatchThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConcurrentDispatchThreadgroups (IMTLIndirectComputeCommand This, MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("concurrentDispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("concurrentDispatchThreads:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConcurrentDispatchThreads (MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConcurrentDispatchThreads (IMTLIndirectComputeCommand This, MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("concurrentDispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBarrier")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBarrier ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBarrier (IMTLIndirectComputeCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setBarrier"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("clearBarrier")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearBarrier ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ClearBarrier (IMTLIndirectComputeCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clearBarrier"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Reset (IMTLIndirectComputeCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("reset"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetThreadgroupMemoryLength (nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetThreadgroupMemoryLength (IMTLIndirectComputeCommand This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStageInRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStageInRegion (MTLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStageInRegion (IMTLIndirectComputeCommand This, MTLRegion region)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion (This.Handle, Selector.GetHandle ("setStageInRegion:"), region);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setImageblockWidth:height:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImageblock (nuint width, nuint height)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetImageblock (IMTLIndirectComputeCommand This, nuint width, nuint height)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setImageblockWidth:height:"), width, height);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setKernelBuffer:offset:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetKernelBuffer (IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetKernelBuffer (IMTLIndirectComputeCommand This, IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setKernelBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[DynamicDependencyAttribute ("ClearBarrier()")]
		[DynamicDependencyAttribute ("ConcurrentDispatchThreadgroups(Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("ConcurrentDispatchThreads(Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("Reset()")]
		[DynamicDependencyAttribute ("SetBarrier()")]
		[DynamicDependencyAttribute ("SetComputePipelineState(Metal.IMTLComputePipelineState)")]
		[DynamicDependencyAttribute ("SetImageblock(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetKernelBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetKernelBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetStageInRegion(Metal.MTLRegion)")]
		[DynamicDependencyAttribute ("SetThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIndirectComputeCommandWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLIndirectComputeCommand ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLIndirectComputeCommand" /> interface to support all the methods from the MTLIndirectComputeCommand protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLIndirectComputeCommand" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLIndirectComputeCommand protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLIndirectComputeCommand_Extensions {
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetKernelBuffer (this IMTLIndirectComputeCommand This, IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setKernelBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLIndirectComputeCommandWrapper : BaseWrapper, IMTLIndirectComputeCommand {
		public MTLIndirectComputeCommandWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIndirectComputeCommandWrapper))]
		static MTLIndirectComputeCommandWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setComputePipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComputePipelineState (IMTLComputePipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setComputePipelineState:"), pipelineState__handle__);
			GC.KeepAlive (pipelineState);
		}
		[Export ("setKernelBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetKernelBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setKernelBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("concurrentDispatchThreadgroups:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConcurrentDispatchThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("concurrentDispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
		}
		[Export ("concurrentDispatchThreads:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConcurrentDispatchThreads (MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("concurrentDispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
		}
		[Export ("setBarrier")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBarrier ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setBarrier"));
		}
		[Export ("clearBarrier")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ClearBarrier ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearBarrier"));
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Reset ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
		}
		[Export ("setThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetThreadgroupMemoryLength (nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:atIndex:"), length, index);
		}
		[Export ("setStageInRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStageInRegion (MTLRegion region)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion (this.Handle, Selector.GetHandle ("setStageInRegion:"), region);
		}
		[Export ("setImageblockWidth:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetImageblock (nuint width, nuint height)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setImageblockWidth:height:"), width, height);
		}
		[Export ("setKernelBuffer:offset:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetKernelBuffer (IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setKernelBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (buffer);
		}
	}
}
