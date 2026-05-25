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
	/// <summary>Protocol for encoding and running parallel commands on a GPU.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLComputeCommandEncoder", WrapperType = typeof (MTLComputeCommandEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetComputePipelineState", Selector = "setComputePipelineState:", ParameterType = new Type [] { typeof (IMTLComputePipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffer", Selector = "setBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTexture", Selector = "setTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (float), typeof (float), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetThreadgroupMemoryLength", Selector = "setThreadgroupMemoryLength:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadgroups", Selector = "dispatchThreadgroups:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadgroups", Selector = "dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffers", Selector = "setBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerStates", Selector = "setSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerStates", Selector = "setSamplerStates:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextures", Selector = "setTextures:withRange:", ParameterType = new Type [] { typeof (IMTLTexture[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBufferOffset", Selector = "setBufferOffset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBytes", Selector = "setBytes:length:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStage", Selector = "setStageInRegion:", ParameterType = new Type [] { typeof (MTLRegion) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStageInRegion", Selector = "setStageInRegionWithIndirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreads", Selector = "dispatchThreads:threadsPerThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResource", Selector = "useResource:usage:", ParameterType = new Type [] { typeof (IMTLResource), typeof (MTLResourceUsage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResources", Selector = "useResources:count:usage:", ParameterType = new Type [] { typeof (IMTLResource[]), typeof (UIntPtr), typeof (MTLResourceUsage) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeap", Selector = "useHeap:", ParameterType = new Type [] { typeof (IMTLHeap) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeaps", Selector = "useHeaps:count:", ParameterType = new Type [] { typeof (IMTLHeap[]), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetImageblock", Selector = "setImageblockWidth:height:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithScope:", ParameterType = new Type [] { typeof (MTLBarrierScope) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithResources:count:", ParameterType = new Type [] { typeof (IMTLResource[]), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommands", Selector = "executeCommandsInBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommands", Selector = "executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SampleCounters", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type [] { typeof (IMTLCounterSampleBuffer), typeof (UIntPtr), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibleFunctionTable", Selector = "setVisibleFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibleFunctionTables", Selector = "setVisibleFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIntersectionFunctionTable", Selector = "setIntersectionFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIntersectionFunctionTables", Selector = "setIntersectionFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAccelerationStructure", Selector = "setAccelerationStructure:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffer", Selector = "setBuffer:offset:attributeStride:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffers", Selector = "setBuffers:offsets:attributeStrides:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBufferOffset", Selector = "setBufferOffset:attributeStride:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBytes", Selector = "setBytes:length:attributeStride:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DispatchType", Selector = "dispatchType", PropertyType = typeof (MTLDispatchType), GetterSelector = "dispatchType", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLComputeCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTLCommandEncoder
	{
		/// <param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setComputePipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComputePipelineState (IMTLComputePipelineState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetComputePipelineState (IMTLComputeCommandEncoder This, IMTLComputePipelineState state)
		{
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setComputePipelineState:"), state__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (state);
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffer (IMTLComputeCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTexture (IMTLTexture texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTexture (IMTLComputeCommandEncoder This, IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerState (IMTLSamplerState sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerState (IMTLComputeCommandEncoder This, IMTLSamplerState sampler, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerState (IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerState (IMTLComputeCommandEncoder This, IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="length">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetThreadgroupMemoryLength (nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="length">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetThreadgroupMemoryLength (IMTLComputeCommandEncoder This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		/// <param name="threadgroupsPerGrid">To be added.</param><param name="threadsPerThreadgroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadgroups:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="threadgroupsPerGrid">To be added.</param><param name="threadsPerThreadgroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreadgroups (IMTLComputeCommandEncoder This, MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreadgroups (IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreadgroups (IMTLComputeCommandEncoder This, IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerThreadgroup)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:"), indirectBuffer__handle__, indirectBufferOffset, threadsPerThreadgroup);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectBuffer);
		}
		/// <summary>Encodes <paramref name="buffers" /> to the argument buffer.</summary><param name="buffers">An array of buffers in an argument buffer.</param><param name="offsets">The byte offsets of <paramref name="buffers" /> in the containing buffer.</param><param name="range">Indices into the target buffer of the buffers in <paramref name="buffers" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param>
		[global::Foundation.RequiredMember]
		[Export ("setBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffers (nint buffers, nint offsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Encodes <paramref name="buffers" /> to the argument buffer.</summary><param name="buffers">An array of buffers in an argument buffer.</param><param name="offsets">The byte offsets of <paramref name="buffers" /> in the containing buffer.</param><param name="range">Indices into the target buffer of the buffers in <paramref name="buffers" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffers (IMTLComputeCommandEncoder This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerStates (IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerStates (IMTLComputeCommandEncoder This, IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
			GC.KeepAlive (This);
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerStates (IMTLComputeCommandEncoder This, IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setSamplerStates:withRange:"), nsa_samplers.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextures (IMTLTexture[] textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextures (IMTLComputeCommandEncoder This, IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTextures:withRange:"), nsa_textures.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setBufferOffset:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBufferOffset (nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBufferOffset (IMTLComputeCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBytes:length:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBytes (nint bytes, nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBytes (IMTLComputeCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStageInRegion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStage (MTLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStage (IMTLComputeCommandEncoder This, MTLRegion region)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion (This.Handle, Selector.GetHandle ("setStageInRegion:"), region);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStageInRegionWithIndirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStageInRegion (IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStageInRegion (IMTLComputeCommandEncoder This, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setStageInRegionWithIndirectBuffer:indirectBufferOffset:"), indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectBuffer);
		}
		/// <summary>Captures all GPU work up to the current fence.</summary>
		[global::Foundation.RequiredMember]
		[Export ("updateFence:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (IMTLFence fence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Captures all GPU work up to the current fence.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLComputeCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary><param name="fence">The fence to wait for.</param>
		[global::Foundation.RequiredMember]
		[Export ("waitForFence:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Wait (IMTLFence fence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary><param name="fence">The fence to wait for.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Wait (IMTLComputeCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreads:threadsPerThreadgroup:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreads (MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreads (IMTLComputeCommandEncoder This, MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResource:usage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResource (IMTLResource resource, MTLResourceUsage usage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResource (IMTLComputeCommandEncoder This, IMTLResource resource, MTLResourceUsage usage)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useResource:usage:"), resource__handle__, (UIntPtr) (ulong) usage);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResources:count:usage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResources (IMTLComputeCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResources:count:usage:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("useHeap:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseHeap (IMTLHeap heap)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeap (IMTLComputeCommandEncoder This, IMTLHeap heap)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useHeap:"), heap__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (heap);
		}
		[global::Foundation.RequiredMember]
		[Export ("useHeaps:count:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseHeaps (IMTLHeap[] heaps, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeaps (IMTLComputeCommandEncoder This, IMTLHeap[] heaps, nuint count)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useHeaps:count:"), nsa_heaps.Handle, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setImageblockWidth:height:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImageblock (nuint width, nuint height)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetImageblock (IMTLComputeCommandEncoder This, nuint width, nuint height)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setImageblockWidth:height:"), width, height);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("memoryBarrierWithScope:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MemoryBarrier (MTLBarrierScope scope)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MemoryBarrier (IMTLComputeCommandEncoder This, MTLBarrierScope scope)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("memoryBarrierWithScope:"), (UIntPtr) (ulong) scope);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("memoryBarrierWithResources:count:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MemoryBarrier (IMTLResource[] resources, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MemoryBarrier (IMTLComputeCommandEncoder This, IMTLResource[] resources, nuint count)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("memoryBarrierWithResources:count:"), nsa_resources.Handle, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:withRange:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommands (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommands (IMTLComputeCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:withRange:"), indirectCommandBuffer__handle__, executionRange);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommands (IMTLIndirectCommandBuffer indirectCommandbuffer, IMTLBuffer indirectRangeBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommands (IMTLComputeCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandbuffer, IMTLBuffer indirectRangeBuffer, nuint indirectBufferOffset)
		{
			var indirectCommandbuffer__handle__ = indirectCommandbuffer!.GetNonNullHandle (nameof (indirectCommandbuffer));
			var indirectRangeBuffer__handle__ = indirectRangeBuffer!.GetNonNullHandle (nameof (indirectRangeBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:"), indirectCommandbuffer__handle__, indirectRangeBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandbuffer);
			GC.KeepAlive (indirectRangeBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("sampleCountersInBuffer:atSampleIndex:withBarrier:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SampleCounters (IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SampleCounters (IMTLComputeCommandEncoder This, IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibleFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleFunctionTable (IMTLVisibleFunctionTable? visibleFunctionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibleFunctionTable (IMTLComputeCommandEncoder This, IMTLVisibleFunctionTable? visibleFunctionTable, nuint bufferIndex)
		{
			var visibleFunctionTable__handle__ = visibleFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVisibleFunctionTable:atBufferIndex:"), visibleFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (visibleFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibleFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleFunctionTables (IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibleFunctionTables (IMTLComputeCommandEncoder This, IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			if (visibleFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleFunctionTables));
			using var nsa_visibleFunctionTables = NSArray.FromNSObjects (visibleFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVisibleFunctionTables:withBufferRange:"), nsa_visibleFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setIntersectionFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIntersectionFunctionTable (IMTLComputeCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setIntersectionFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIntersectionFunctionTables (IMTLComputeCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			if (intersectionFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTables));
			using var nsa_intersectionFunctionTables = NSArray.FromNSObjects (intersectionFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setAccelerationStructure:atBufferIndex:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccelerationStructure (IMTLComputeCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBuffer:offset:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffer (IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffer (IMTLComputeCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBuffers:offsets:attributeStrides:withRange:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffers (nint buffers, nint offsets, nint strides, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffers (IMTLComputeCommandEncoder This, nint buffers, nint offsets, nint strides, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setBuffers:offsets:attributeStrides:withRange:"), buffers, offsets, strides, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBufferOffset:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBufferOffset (nuint offset, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBufferOffset (IMTLComputeCommandEncoder This, nuint offset, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBufferOffset:attributeStride:atIndex:"), offset, stride, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBytes:length:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBytes (nint bytes, nuint length, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBytes (IMTLComputeCommandEncoder This, nint bytes, nuint length, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBytes:length:attributeStride:atIndex:"), bytes, length, stride, index);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DispatchThreadgroups(Metal.IMTLBuffer,System.UIntPtr,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DispatchThreadgroups(Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DispatchThreads(Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DispatchType")]
		[DynamicDependencyAttribute ("ExecuteCommands(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ExecuteCommands(Metal.IMTLIndirectCommandBuffer,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("MemoryBarrier(Metal.IMTLResource[],System.UIntPtr)")]
		[DynamicDependencyAttribute ("MemoryBarrier(Metal.MTLBarrierScope)")]
		[DynamicDependencyAttribute ("SampleCounters(Metal.IMTLCounterSampleBuffer,System.UIntPtr,System.Boolean)")]
		[DynamicDependencyAttribute ("SetAccelerationStructure(Metal.IMTLAccelerationStructure,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBufferOffset(System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBufferOffset(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBuffers(System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetBuffers(System.IntPtr,System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetBytes(System.IntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBytes(System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetComputePipelineState(Metal.IMTLComputePipelineState)")]
		[DynamicDependencyAttribute ("SetImageblock(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetIntersectionFunctionTable(Metal.IMTLIntersectionFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetIntersectionFunctionTables(Metal.IMTLIntersectionFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetSamplerState(Metal.IMTLSamplerState,System.Single,System.Single,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetSamplerStates(Metal.IMTLSamplerState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetSamplerStates(Metal.IMTLSamplerState[],System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetStage(Metal.MTLRegion)")]
		[DynamicDependencyAttribute ("SetStageInRegion(Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTextures(Metal.IMTLTexture[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibleFunctionTable(Metal.IMTLVisibleFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibleFunctionTables(Metal.IMTLVisibleFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLFence)")]
		[DynamicDependencyAttribute ("UseHeap(Metal.IMTLHeap)")]
		[DynamicDependencyAttribute ("UseHeaps(Metal.IMTLHeap[],System.UIntPtr)")]
		[DynamicDependencyAttribute ("UseResource(Metal.IMTLResource,Metal.MTLResourceUsage)")]
		[DynamicDependencyAttribute ("UseResources(Metal.IMTLResource[],System.UIntPtr,Metal.MTLResourceUsage)")]
		[DynamicDependencyAttribute ("Wait(Metal.IMTLFence)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLComputeCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLComputeCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual MTLDispatchType DispatchType {
			[Export ("dispatchType")]
			get {
				return _GetDispatchType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLDispatchType _GetDispatchType (IMTLComputeCommandEncoder This)
		{
			MTLDispatchType ret;
			ret = (MTLDispatchType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dispatchType"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLComputeCommandEncoder" /> interface to support all the methods from the MTLComputeCommandEncoder protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLComputeCommandEncoder" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLComputeCommandEncoder protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLComputeCommandEncoder_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVisibleFunctionTable (this IMTLComputeCommandEncoder This, IMTLVisibleFunctionTable? visibleFunctionTable, nuint bufferIndex)
		{
			var visibleFunctionTable__handle__ = visibleFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVisibleFunctionTable:atBufferIndex:"), visibleFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (visibleFunctionTable);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVisibleFunctionTables (this IMTLComputeCommandEncoder This, IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			if (visibleFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleFunctionTables));
			using var nsa_visibleFunctionTables = NSArray.FromNSObjects (visibleFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVisibleFunctionTables:withBufferRange:"), nsa_visibleFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIntersectionFunctionTable (this IMTLComputeCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIntersectionFunctionTables (this IMTLComputeCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			if (intersectionFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTables));
			using var nsa_intersectionFunctionTables = NSArray.FromNSObjects (intersectionFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccelerationStructure (this IMTLComputeCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBuffer (this IMTLComputeCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBuffers (this IMTLComputeCommandEncoder This, nint buffers, nint offsets, nint strides, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setBuffers:offsets:attributeStrides:withRange:"), buffers, offsets, strides, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBufferOffset (this IMTLComputeCommandEncoder This, nuint offset, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBufferOffset:attributeStride:atIndex:"), offset, stride, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBytes (this IMTLComputeCommandEncoder This, nint bytes, nuint length, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBytes:length:attributeStride:atIndex:"), bytes, length, stride, index);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLComputeCommandEncoderWrapper : BaseWrapper, IMTLComputeCommandEncoder {
		public MTLComputeCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLComputeCommandEncoderWrapper))]
		static MTLComputeCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setComputePipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComputePipelineState (IMTLComputePipelineState state)
		{
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setComputePipelineState:"), state__handle__);
			GC.KeepAlive (state);
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTexture (IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerState (IMTLSamplerState sampler, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerState (IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (this.Handle, Selector.GetHandle ("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="length">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetThreadgroupMemoryLength (nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:atIndex:"), length, index);
		}
		/// <param name="threadgroupsPerGrid">To be added.</param><param name="threadsPerThreadgroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("dispatchThreadgroups:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
		}
		[Export ("dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreadgroups (IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerThreadgroup)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:"), indirectBuffer__handle__, indirectBufferOffset, threadsPerThreadgroup);
			GC.KeepAlive (indirectBuffer);
		}
		/// <summary>Encodes <paramref name="buffers" /> to the argument buffer.</summary><param name="buffers">An array of buffers in an argument buffer.</param><param name="offsets">The byte offsets of <paramref name="buffers" /> in the containing buffer.</param><param name="range">Indices into the target buffer of the buffers in <paramref name="buffers" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param>
		[Export ("setBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffers (nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setBuffers:offsets:withRange:"), buffers, offsets, range);
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerStates (IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setSamplerStates:withRange:"), nsa_samplers.Handle, range);
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTextures (IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTextures:withRange:"), nsa_textures.Handle, range);
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setBufferOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBufferOffset (nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBufferOffset:atIndex:"), offset, index);
		}
		[Export ("setBytes:length:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBytes (nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBytes:length:atIndex:"), bytes, length, index);
		}
		[Export ("setStageInRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStage (MTLRegion region)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion (this.Handle, Selector.GetHandle ("setStageInRegion:"), region);
		}
		[Export ("setStageInRegionWithIndirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStageInRegion (IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setStageInRegionWithIndirectBuffer:indirectBufferOffset:"), indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (indirectBuffer);
		}
		/// <summary>Captures all GPU work up to the current fence.</summary>
		[Export ("updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary><param name="fence">The fence to wait for.</param>
		[Export ("waitForFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Wait (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		[Export ("dispatchThreads:threadsPerThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreads (MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
		}
		[Export ("useResource:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResource (IMTLResource resource, MTLResourceUsage usage)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useResource:usage:"), resource__handle__, (UIntPtr) (ulong) usage);
			GC.KeepAlive (resource);
		}
		[Export ("useResources:count:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResources:count:usage:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage);
		}
		[Export ("useHeap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeap (IMTLHeap heap)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("useHeap:"), heap__handle__);
			GC.KeepAlive (heap);
		}
		[Export ("useHeaps:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeaps (IMTLHeap[] heaps, nuint count)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useHeaps:count:"), nsa_heaps.Handle, count);
		}
		[Export ("setImageblockWidth:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetImageblock (nuint width, nuint height)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setImageblockWidth:height:"), width, height);
		}
		[Export ("memoryBarrierWithScope:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MemoryBarrier (MTLBarrierScope scope)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("memoryBarrierWithScope:"), (UIntPtr) (ulong) scope);
		}
		[Export ("memoryBarrierWithResources:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MemoryBarrier (IMTLResource[] resources, nuint count)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("memoryBarrierWithResources:count:"), nsa_resources.Handle, count);
		}
		[Export ("executeCommandsInBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExecuteCommands (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("executeCommandsInBuffer:withRange:"), indirectCommandBuffer__handle__, executionRange);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[Export ("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExecuteCommands (IMTLIndirectCommandBuffer indirectCommandbuffer, IMTLBuffer indirectRangeBuffer, nuint indirectBufferOffset)
		{
			var indirectCommandbuffer__handle__ = indirectCommandbuffer!.GetNonNullHandle (nameof (indirectCommandbuffer));
			var indirectRangeBuffer__handle__ = indirectRangeBuffer!.GetNonNullHandle (nameof (indirectRangeBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:"), indirectCommandbuffer__handle__, indirectRangeBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (indirectCommandbuffer);
			GC.KeepAlive (indirectRangeBuffer);
		}
		[Export ("sampleCountersInBuffer:atSampleIndex:withBarrier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SampleCounters (IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (sampleBuffer);
		}
		[Export ("setVisibleFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibleFunctionTable (IMTLVisibleFunctionTable? visibleFunctionTable, nuint bufferIndex)
		{
			var visibleFunctionTable__handle__ = visibleFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVisibleFunctionTable:atBufferIndex:"), visibleFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (visibleFunctionTable);
		}
		[Export ("setVisibleFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibleFunctionTables (IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			if (visibleFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleFunctionTables));
			using var nsa_visibleFunctionTables = NSArray.FromNSObjects (visibleFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVisibleFunctionTables:withBufferRange:"), nsa_visibleFunctionTables.Handle, range);
		}
		[Export ("setIntersectionFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[Export ("setIntersectionFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			if (intersectionFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTables));
			using var nsa_intersectionFunctionTables = NSArray.FromNSObjects (intersectionFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTables.Handle, range);
		}
		[Export ("setAccelerationStructure:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (accelerationStructure);
		}
		[Export ("setBuffer:offset:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffer (IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setBuffers:offsets:attributeStrides:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffers (nint buffers, nint offsets, nint strides, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setBuffers:offsets:attributeStrides:withRange:"), buffers, offsets, strides, range);
		}
		[Export ("setBufferOffset:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBufferOffset (nuint offset, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBufferOffset:attributeStride:atIndex:"), offset, stride, index);
		}
		[Export ("setBytes:length:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBytes (nint bytes, nuint length, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBytes:length:attributeStride:atIndex:"), bytes, length, stride, index);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("endEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndEncoding ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endEncoding"));
		}
		/// <param name="signpost">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertDebugSignpost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertDebugSignpost (string signpost)
		{
			if (signpost is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (signpost));
			var nssignpost = CFString.CreateNative (signpost);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDebugSignpost:"), nssignpost);
			CFString.ReleaseNative (nssignpost);
		}
		/// <param name="debugGroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PushDebugGroup (string debugGroup)
		{
			if (debugGroup is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (debugGroup));
			var nsdebugGroup = CFString.CreateNative (debugGroup);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pushDebugGroup:"), nsdebugGroup);
			CFString.ReleaseNative (nsdebugGroup);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popDebugGroup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PopDebugGroup ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popDebugGroup"));
		}
		[Export ("barrierAfterQueueStages:beforeStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterQueueStages (MTLStages afterQueueStages, MTLStages beforeStages)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterQueueStages:beforeStages:"), (UIntPtr) (ulong) afterQueueStages, (UIntPtr) (ulong) beforeStages);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLDispatchType DispatchType {
			[Export ("dispatchType")]
			get {
				MTLDispatchType ret;
				ret = (MTLDispatchType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dispatchType"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
