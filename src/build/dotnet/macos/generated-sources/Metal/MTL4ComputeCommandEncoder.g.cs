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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4ComputeCommandEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4ComputeCommandEncoder", WrapperType = typeof (MTL4ComputeCommandEncoderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetComputePipelineState", Selector = "setComputePipelineState:", ParameterType = new Type [] { typeof (IMTLComputePipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetThreadgroupMemoryLength", Selector = "setThreadgroupMemoryLength:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetImageblock", Selector = "setImageblockWidth:height:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreads", Selector = "dispatchThreads:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadgroups", Selector = "dispatchThreadgroups:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadgroups", Selector = "dispatchThreadgroupsWithIndirectBuffer:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (ulong), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreads", Selector = "dispatchThreadsWithIndirectBuffer:", ParameterType = new Type [] { typeof (ulong) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommandsInBuffer", Selector = "executeCommandsInBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommandsInBuffer", Selector = "executeCommandsInBuffer:indirectBuffer:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:toTexture:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (IMTLTexture) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLBlitOption) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLBlitOption) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTensor", Selector = "copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:", ParameterType = new Type [] { typeof (IMTLTensor), typeof (MTLTensorExtents), typeof (MTLTensorExtents), typeof (IMTLTensor), typeof (MTLTensorExtents), typeof (MTLTensorExtents) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateMipmaps", Selector = "generateMipmapsForTexture:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FillBuffer", Selector = "fillBuffer:range:value:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (NSRange), typeof (byte) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForGpuAccess", Selector = "optimizeContentsForGPUAccess:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForGpuAccess", Selector = "optimizeContentsForGPUAccess:slice:level:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForCpuAccess", Selector = "optimizeContentsForCPUAccess:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForCpuAccess", Selector = "optimizeContentsForCPUAccess:slice:level:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResetCommandsInBuffer", Selector = "resetCommandsInBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyIndirectCommandBuffer", Selector = "copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange), typeof (IMTLIndirectCommandBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeIndirectCommandBuffer", Selector = "optimizeIndirectCommandBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentTable", Selector = "setArgumentTable:", ParameterType = new Type [] { typeof (IMTL4ArgumentTable) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BuildAccelerationStructure", Selector = "buildAccelerationStructure:descriptor:scratchBuffer:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTL4AccelerationStructureDescriptor), typeof (MTL4BufferRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RefitAccelerationStructure", Selector = "refitAccelerationStructure:descriptor:destination:scratchBuffer:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTL4AccelerationStructureDescriptor), typeof (IMTLAccelerationStructure), typeof (MTL4BufferRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RefitAccelerationStructure", Selector = "refitAccelerationStructure:descriptor:destination:scratchBuffer:options:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTL4AccelerationStructureDescriptor), typeof (IMTLAccelerationStructure), typeof (MTL4BufferRange), typeof (MTLAccelerationStructureRefitOptions) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyAccelerationStructure", Selector = "copyAccelerationStructure:toAccelerationStructure:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (IMTLAccelerationStructure) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteCompactedAccelerationStructureSize", Selector = "writeCompactedAccelerationStructureSize:toBuffer:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTL4BufferRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyAndCompactAccelerationStructure", Selector = "copyAndCompactAccelerationStructure:toAccelerationStructure:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (IMTLAccelerationStructure) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteTimestamp", Selector = "writeTimestampWithGranularity:intoHeap:atIndex:", ParameterType = new Type [] { typeof (MTL4TimestampGranularity), typeof (IMTL4CounterHeap), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Stages", Selector = "stages", PropertyType = typeof (MTLStages), GetterSelector = "stages", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4ComputeCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTL4CommandEncoder
	{
		[global::Foundation.RequiredMember]
		[Export ("setComputePipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComputePipelineState (IMTLComputePipelineState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetComputePipelineState (IMTL4ComputeCommandEncoder This, IMTLComputePipelineState state)
		{
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setComputePipelineState:"), state__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (state);
		}
		[global::Foundation.RequiredMember]
		[Export ("setThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetThreadgroupMemoryLength (nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetThreadgroupMemoryLength (IMTL4ComputeCommandEncoder This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setImageblockWidth:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImageblock (nuint width, nuint height)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetImageblock (IMTL4ComputeCommandEncoder This, nuint width, nuint height)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setImageblockWidth:height:"), width, height);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreads:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreads (MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreads (IMTL4ComputeCommandEncoder This, MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadgroups:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreadgroups (IMTL4ComputeCommandEncoder This, MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadgroupsWithIndirectBuffer:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreadgroups (ulong indirectBuffer, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreadgroups (IMTL4ComputeCommandEncoder This, ulong indirectBuffer, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreadgroupsWithIndirectBuffer:threadsPerThreadgroup:"), indirectBuffer, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadsWithIndirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreads (ulong indirectBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreads (IMTL4ComputeCommandEncoder This, ulong indirectBuffer)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (This.Handle, Selector.GetHandle ("dispatchThreadsWithIndirectBuffer:"), indirectBuffer);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommandsInBuffer (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommandsInBuffer (IMTL4ComputeCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:withRange:"), indirectCommandBuffer__handle__, executionRange);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommandsInBuffer (IMTLIndirectCommandBuffer indirectCommandbuffer, ulong indirectRangeBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommandsInBuffer (IMTL4ComputeCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandbuffer, ulong indirectRangeBuffer)
		{
			var indirectCommandbuffer__handle__ = indirectCommandbuffer!.GetNonNullHandle (nameof (indirectCommandbuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:"), indirectCommandbuffer__handle__, indirectRangeBuffer);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandbuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:toTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, IMTLTexture destinationTexture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTL4ComputeCommandEncoder This, IMTLTexture sourceTexture, IMTLTexture destinationTexture)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyFromTexture:toTexture:"), sourceTexture__handle__, destinationTexture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTL4ComputeCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:"), sourceTexture__handle__, sourceSlice, sourceLevel, destinationTexture__handle__, destinationSlice, destinationLevel, sliceCount, levelCount);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTL4ComputeCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinationBytesPerRow, nuint destinationBytesPerImage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTL4ComputeCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinationBytesPerRow, nuint destinationBytesPerImage)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinationBytesPerRow, destinationBytesPerImage);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinationBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTL4ComputeCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinationBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinationBytesPerRow, destinationBytesPerImage, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromBuffer (IMTL4ComputeCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:"), sourceBuffer__handle__, sourceOffset, destinationBuffer__handle__, destinationOffset, size);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromBuffer (IMTL4ComputeCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (This.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceBuffer__handle__, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin, MTLBlitOption options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromBuffer (IMTL4ComputeCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin, MTLBlitOption options)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_UIntPtr (This.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:"), sourceBuffer__handle__, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTensor (IMTLTensor sourceTensor, MTLTensorExtents sourceOrigin, MTLTensorExtents sourceDimensions, IMTLTensor destinationTensor, MTLTensorExtents destinationOrigin, MTLTensorExtents destinationDimensions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTensor (IMTL4ComputeCommandEncoder This, IMTLTensor sourceTensor, MTLTensorExtents sourceOrigin, MTLTensorExtents sourceDimensions, IMTLTensor destinationTensor, MTLTensorExtents destinationOrigin, MTLTensorExtents destinationDimensions)
		{
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			var sourceOrigin__handle__ = sourceOrigin!.GetNonNullHandle (nameof (sourceOrigin));
			var sourceDimensions__handle__ = sourceDimensions!.GetNonNullHandle (nameof (sourceDimensions));
			var destinationTensor__handle__ = destinationTensor!.GetNonNullHandle (nameof (destinationTensor));
			var destinationOrigin__handle__ = destinationOrigin!.GetNonNullHandle (nameof (destinationOrigin));
			var destinationDimensions__handle__ = destinationDimensions!.GetNonNullHandle (nameof (destinationDimensions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:"), sourceTensor__handle__, sourceOrigin__handle__, sourceDimensions__handle__, destinationTensor__handle__, destinationOrigin__handle__, destinationDimensions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTensor);
			GC.KeepAlive (sourceOrigin);
			GC.KeepAlive (sourceDimensions);
			GC.KeepAlive (destinationTensor);
			GC.KeepAlive (destinationOrigin);
			GC.KeepAlive (destinationDimensions);
		}
		[global::Foundation.RequiredMember]
		[Export ("generateMipmapsForTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GenerateMipmaps (IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GenerateMipmaps (IMTL4ComputeCommandEncoder This, IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("generateMipmapsForTexture:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("fillBuffer:range:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FillBuffer (IMTLBuffer buffer, NSRange range, byte value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FillBuffer (IMTL4ComputeCommandEncoder This, IMTLBuffer buffer, NSRange range, byte value)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_byte (This.Handle, Selector.GetHandle ("fillBuffer:range:value:"), buffer__handle__, range, value);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForGPUAccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForGpuAccess (IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForGpuAccess (IMTL4ComputeCommandEncoder This, IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("optimizeContentsForGPUAccess:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForGPUAccess:slice:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForGpuAccess (IMTLTexture texture, nuint slice, nuint level)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForGpuAccess (IMTL4ComputeCommandEncoder This, IMTLTexture texture, nuint slice, nuint level)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("optimizeContentsForGPUAccess:slice:level:"), texture__handle__, slice, level);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForCPUAccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForCpuAccess (IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForCpuAccess (IMTL4ComputeCommandEncoder This, IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("optimizeContentsForCPUAccess:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForCPUAccess:slice:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForCpuAccess (IMTLTexture texture, nuint slice, nuint level)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForCpuAccess (IMTL4ComputeCommandEncoder This, IMTLTexture texture, nuint slice, nuint level)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("optimizeContentsForCPUAccess:slice:level:"), texture__handle__, slice, level);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("resetCommandsInBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetCommandsInBuffer (IMTLIndirectCommandBuffer buffer, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResetCommandsInBuffer (IMTL4ComputeCommandEncoder This, IMTLIndirectCommandBuffer buffer, NSRange range)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("resetCommandsInBuffer:withRange:"), buffer__handle__, range);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyIndirectCommandBuffer (IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyIndirectCommandBuffer (IMTL4ComputeCommandEncoder This, IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:"), source__handle__, sourceRange, destination__handle__, destinationIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (destination);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeIndirectCommandBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeIndirectCommandBuffer (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeIndirectCommandBuffer (IMTL4ComputeCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("optimizeIndirectCommandBuffer:withRange:"), indirectCommandBuffer__handle__, range);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setArgumentTable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetArgumentTable (IMTL4ArgumentTable? argumentTable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetArgumentTable (IMTL4ComputeCommandEncoder This, IMTL4ArgumentTable? argumentTable)
		{
			var argumentTable__handle__ = argumentTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setArgumentTable:"), argumentTable__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (argumentTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("buildAccelerationStructure:descriptor:scratchBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BuildAccelerationStructure (IMTLAccelerationStructure accelerationStructure, MTL4AccelerationStructureDescriptor descriptor, MTL4BufferRange scratchBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BuildAccelerationStructure (IMTL4ComputeCommandEncoder This, IMTLAccelerationStructure accelerationStructure, MTL4AccelerationStructureDescriptor descriptor, MTL4BufferRange scratchBuffer)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_MTL4BufferRange (This.Handle, Selector.GetHandle ("buildAccelerationStructure:descriptor:scratchBuffer:"), accelerationStructure__handle__, descriptor__handle__, scratchBuffer);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (descriptor);
		}
		[global::Foundation.RequiredMember]
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTL4AccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, MTL4BufferRange scratchBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RefitAccelerationStructure (IMTL4ComputeCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, MTL4AccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, MTL4BufferRange scratchBuffer)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_MTL4BufferRange (This.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTL4AccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, MTL4BufferRange scratchBuffer, MTLAccelerationStructureRefitOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RefitAccelerationStructure (IMTL4ComputeCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, MTL4AccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, MTL4BufferRange scratchBuffer, MTLAccelerationStructureRefitOptions options)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_MTL4BufferRange_UIntPtr (This.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:options:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyAccelerationStructure (IMTL4ComputeCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeCompactedAccelerationStructureSize:toBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteCompactedAccelerationStructureSize (IMTLAccelerationStructure accelerationStructure, MTL4BufferRange buffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteCompactedAccelerationStructureSize (IMTL4ComputeCommandEncoder This, IMTLAccelerationStructure accelerationStructure, MTL4BufferRange buffer)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTL4BufferRange (This.Handle, Selector.GetHandle ("writeCompactedAccelerationStructureSize:toBuffer:"), accelerationStructure__handle__, buffer);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyAndCompactAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyAndCompactAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyAndCompactAccelerationStructure (IMTL4ComputeCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyAndCompactAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeTimestampWithGranularity:intoHeap:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteTimestamp (MTL4TimestampGranularity granularity, IMTL4CounterHeap counterHeap, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteTimestamp (IMTL4ComputeCommandEncoder This, MTL4TimestampGranularity granularity, IMTL4CounterHeap counterHeap, nuint index)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("writeTimestampWithGranularity:intoHeap:atIndex:"), (IntPtr) (long) granularity, counterHeap__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (counterHeap);
		}
		[DynamicDependencyAttribute ("BuildAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.MTL4AccelerationStructureDescriptor,Metal.MTL4BufferRange)")]
		[DynamicDependencyAttribute ("CopyAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.IMTLAccelerationStructure)")]
		[DynamicDependencyAttribute ("CopyAndCompactAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.IMTLAccelerationStructure)")]
		[DynamicDependencyAttribute ("CopyFromBuffer(Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyFromBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLBlitOption)")]
		[DynamicDependencyAttribute ("CopyFromBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin)")]
		[DynamicDependencyAttribute ("CopyFromTensor(Metal.IMTLTensor,Metal.MTLTensorExtents,Metal.MTLTensorExtents,Metal.IMTLTensor,Metal.MTLTensorExtents,Metal.MTLTensorExtents)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLBlitOption)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin)")]
		[DynamicDependencyAttribute ("CopyIndirectCommandBuffer(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange,Metal.IMTLIndirectCommandBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DispatchThreadgroups(Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DispatchThreadgroups(System.UInt64,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DispatchThreads(Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DispatchThreads(System.UInt64)")]
		[DynamicDependencyAttribute ("ExecuteCommandsInBuffer(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ExecuteCommandsInBuffer(Metal.IMTLIndirectCommandBuffer,System.UInt64)")]
		[DynamicDependencyAttribute ("FillBuffer(Metal.IMTLBuffer,Foundation.NSRange,System.Byte)")]
		[DynamicDependencyAttribute ("GenerateMipmaps(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("OptimizeContentsForCpuAccess(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("OptimizeContentsForCpuAccess(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("OptimizeContentsForGpuAccess(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("OptimizeContentsForGpuAccess(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("OptimizeIndirectCommandBuffer(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("RefitAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.MTL4AccelerationStructureDescriptor,Metal.IMTLAccelerationStructure,Metal.MTL4BufferRange,Metal.MTLAccelerationStructureRefitOptions)")]
		[DynamicDependencyAttribute ("RefitAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.MTL4AccelerationStructureDescriptor,Metal.IMTLAccelerationStructure,Metal.MTL4BufferRange)")]
		[DynamicDependencyAttribute ("ResetCommandsInBuffer(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetArgumentTable(Metal.IMTL4ArgumentTable)")]
		[DynamicDependencyAttribute ("SetComputePipelineState(Metal.IMTLComputePipelineState)")]
		[DynamicDependencyAttribute ("SetImageblock(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Stages")]
		[DynamicDependencyAttribute ("WriteCompactedAccelerationStructureSize(Metal.IMTLAccelerationStructure,Metal.MTL4BufferRange)")]
		[DynamicDependencyAttribute ("WriteTimestamp(Metal.MTL4TimestampGranularity,Metal.IMTL4CounterHeap,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4ComputeCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4ComputeCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLStages Stages {
			[Export ("stages")]
			get {
				return _GetStages (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLStages _GetStages (IMTL4ComputeCommandEncoder This)
		{
			MTLStages ret;
			ret = (MTLStages) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("stages"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4ComputeCommandEncoderWrapper : BaseWrapper, IMTL4ComputeCommandEncoder {
		public MTL4ComputeCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4ComputeCommandEncoderWrapper))]
		static MTL4ComputeCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setComputePipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComputePipelineState (IMTLComputePipelineState state)
		{
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setComputePipelineState:"), state__handle__);
			GC.KeepAlive (state);
		}
		[Export ("setThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetThreadgroupMemoryLength (nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:atIndex:"), length, index);
		}
		[Export ("setImageblockWidth:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetImageblock (nuint width, nuint height)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setImageblockWidth:height:"), width, height);
		}
		[Export ("dispatchThreads:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreads (MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
		}
		[Export ("dispatchThreadgroups:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
		}
		[Export ("dispatchThreadgroupsWithIndirectBuffer:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreadgroups (ulong indirectBuffer, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreadgroupsWithIndirectBuffer:threadsPerThreadgroup:"), indirectBuffer, threadsPerThreadgroup);
		}
		[Export ("dispatchThreadsWithIndirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreads (ulong indirectBuffer)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("dispatchThreadsWithIndirectBuffer:"), indirectBuffer);
		}
		[Export ("executeCommandsInBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExecuteCommandsInBuffer (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("executeCommandsInBuffer:withRange:"), indirectCommandBuffer__handle__, executionRange);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[Export ("executeCommandsInBuffer:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExecuteCommandsInBuffer (IMTLIndirectCommandBuffer indirectCommandbuffer, ulong indirectRangeBuffer)
		{
			var indirectCommandbuffer__handle__ = indirectCommandbuffer!.GetNonNullHandle (nameof (indirectCommandbuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:"), indirectCommandbuffer__handle__, indirectRangeBuffer);
			GC.KeepAlive (indirectCommandbuffer);
		}
		[Export ("copyFromTexture:toTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, IMTLTexture destinationTexture)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyFromTexture:toTexture:"), sourceTexture__handle__, destinationTexture__handle__);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:"), sourceTexture__handle__, sourceSlice, sourceLevel, destinationTexture__handle__, destinationSlice, destinationLevel, sliceCount, levelCount);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinationBytesPerRow, nuint destinationBytesPerImage)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinationBytesPerRow, destinationBytesPerImage);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinationBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinationBytesPerRow, destinationBytesPerImage, (UIntPtr) (ulong) options);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		[Export ("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:"), sourceBuffer__handle__, sourceOffset, destinationBuffer__handle__, destinationOffset, size);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationBuffer);
		}
		[Export ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (this.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceBuffer__handle__, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin, MTLBlitOption options)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_UIntPtr (this.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:"), sourceBuffer__handle__, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin, (UIntPtr) (ulong) options);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTensor (IMTLTensor sourceTensor, MTLTensorExtents sourceOrigin, MTLTensorExtents sourceDimensions, IMTLTensor destinationTensor, MTLTensorExtents destinationOrigin, MTLTensorExtents destinationDimensions)
		{
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			var sourceOrigin__handle__ = sourceOrigin!.GetNonNullHandle (nameof (sourceOrigin));
			var sourceDimensions__handle__ = sourceDimensions!.GetNonNullHandle (nameof (sourceDimensions));
			var destinationTensor__handle__ = destinationTensor!.GetNonNullHandle (nameof (destinationTensor));
			var destinationOrigin__handle__ = destinationOrigin!.GetNonNullHandle (nameof (destinationOrigin));
			var destinationDimensions__handle__ = destinationDimensions!.GetNonNullHandle (nameof (destinationDimensions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:"), sourceTensor__handle__, sourceOrigin__handle__, sourceDimensions__handle__, destinationTensor__handle__, destinationOrigin__handle__, destinationDimensions__handle__);
			GC.KeepAlive (sourceTensor);
			GC.KeepAlive (sourceOrigin);
			GC.KeepAlive (sourceDimensions);
			GC.KeepAlive (destinationTensor);
			GC.KeepAlive (destinationOrigin);
			GC.KeepAlive (destinationDimensions);
		}
		[Export ("generateMipmapsForTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GenerateMipmaps (IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("generateMipmapsForTexture:"), texture__handle__);
			GC.KeepAlive (texture);
		}
		[Export ("fillBuffer:range:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FillBuffer (IMTLBuffer buffer, NSRange range, byte value)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_byte (this.Handle, Selector.GetHandle ("fillBuffer:range:value:"), buffer__handle__, range, value);
			GC.KeepAlive (buffer);
		}
		[Export ("optimizeContentsForGPUAccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OptimizeContentsForGpuAccess (IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("optimizeContentsForGPUAccess:"), texture__handle__);
			GC.KeepAlive (texture);
		}
		[Export ("optimizeContentsForGPUAccess:slice:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OptimizeContentsForGpuAccess (IMTLTexture texture, nuint slice, nuint level)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("optimizeContentsForGPUAccess:slice:level:"), texture__handle__, slice, level);
			GC.KeepAlive (texture);
		}
		[Export ("optimizeContentsForCPUAccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OptimizeContentsForCpuAccess (IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("optimizeContentsForCPUAccess:"), texture__handle__);
			GC.KeepAlive (texture);
		}
		[Export ("optimizeContentsForCPUAccess:slice:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OptimizeContentsForCpuAccess (IMTLTexture texture, nuint slice, nuint level)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("optimizeContentsForCPUAccess:slice:level:"), texture__handle__, slice, level);
			GC.KeepAlive (texture);
		}
		[Export ("resetCommandsInBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ResetCommandsInBuffer (IMTLIndirectCommandBuffer buffer, NSRange range)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("resetCommandsInBuffer:withRange:"), buffer__handle__, range);
			GC.KeepAlive (buffer);
		}
		[Export ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyIndirectCommandBuffer (IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:"), source__handle__, sourceRange, destination__handle__, destinationIndex);
			GC.KeepAlive (source);
			GC.KeepAlive (destination);
		}
		[Export ("optimizeIndirectCommandBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OptimizeIndirectCommandBuffer (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("optimizeIndirectCommandBuffer:withRange:"), indirectCommandBuffer__handle__, range);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[Export ("setArgumentTable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetArgumentTable (IMTL4ArgumentTable? argumentTable)
		{
			var argumentTable__handle__ = argumentTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setArgumentTable:"), argumentTable__handle__);
			GC.KeepAlive (argumentTable);
		}
		[Export ("buildAccelerationStructure:descriptor:scratchBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BuildAccelerationStructure (IMTLAccelerationStructure accelerationStructure, MTL4AccelerationStructureDescriptor descriptor, MTL4BufferRange scratchBuffer)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_MTL4BufferRange (this.Handle, Selector.GetHandle ("buildAccelerationStructure:descriptor:scratchBuffer:"), accelerationStructure__handle__, descriptor__handle__, scratchBuffer);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (descriptor);
		}
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTL4AccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, MTL4BufferRange scratchBuffer)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_MTL4BufferRange (this.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTL4AccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, MTL4BufferRange scratchBuffer, MTLAccelerationStructureRefitOptions options)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_MTL4BufferRange_UIntPtr (this.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:options:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer, (UIntPtr) (ulong) options);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[Export ("copyAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[Export ("writeCompactedAccelerationStructureSize:toBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WriteCompactedAccelerationStructureSize (IMTLAccelerationStructure accelerationStructure, MTL4BufferRange buffer)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTL4BufferRange (this.Handle, Selector.GetHandle ("writeCompactedAccelerationStructureSize:toBuffer:"), accelerationStructure__handle__, buffer);
			GC.KeepAlive (accelerationStructure);
		}
		[Export ("copyAndCompactAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyAndCompactAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyAndCompactAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[Export ("writeTimestampWithGranularity:intoHeap:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WriteTimestamp (MTL4TimestampGranularity granularity, IMTL4CounterHeap counterHeap, nuint index)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("writeTimestampWithGranularity:intoHeap:atIndex:"), (IntPtr) (long) granularity, counterHeap__handle__, index);
			GC.KeepAlive (counterHeap);
		}
		[Export ("barrierAfterQueueStages:beforeStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterQueueStages (MTLStages afterQueueStages, MTLStages beforeStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterQueueStages:beforeStages:visibilityOptions:"), (UIntPtr) (ulong) afterQueueStages, (UIntPtr) (ulong) beforeStages, (UIntPtr) (ulong) visibilityOptions);
		}
		[Export ("barrierAfterStages:beforeQueueStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterStages (MTLStages afterStages, MTLStages beforeQueueStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterStages:beforeQueueStages:visibilityOptions:"), (UIntPtr) (ulong) afterStages, (UIntPtr) (ulong) beforeQueueStages, (UIntPtr) (ulong) visibilityOptions);
		}
		[Export ("barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterEncoderStages (MTLStages afterEncoderStages, MTLStages beforeEncoderStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:"), (UIntPtr) (ulong) afterEncoderStages, (UIntPtr) (ulong) beforeEncoderStages, (UIntPtr) (ulong) visibilityOptions);
		}
		[Export ("updateFence:afterEncoderStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateFence (IMTLFence fence, MTLStages afterEncoderStages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("updateFence:afterEncoderStages:"), fence__handle__, (UIntPtr) (ulong) afterEncoderStages);
			GC.KeepAlive (fence);
		}
		[Export ("waitForFence:beforeEncoderStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitForFence (IMTLFence fence, MTLStages beforeEncoderStages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("waitForFence:beforeEncoderStages:"), fence__handle__, (UIntPtr) (ulong) beforeEncoderStages);
			GC.KeepAlive (fence);
		}
		[Export ("insertDebugSignpost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertDebugSignpost (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDebugSignpost:"), nsstring);
			CFString.ReleaseNative (nsstring);
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
		[Export ("endEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndEncoding ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endEncoding"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLStages Stages {
			[Export ("stages")]
			get {
				MTLStages ret;
				ret = (MTLStages) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stages"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public string? Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public IMTL4CommandBuffer? CommandBuffer {
			[Export ("commandBuffer")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				IMTL4CommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTL4CommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandBuffer")), false)!;
				return ret;
			}
		}
	}
}
