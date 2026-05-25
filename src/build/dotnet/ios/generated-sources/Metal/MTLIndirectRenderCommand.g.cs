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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLIndirectRenderCommand</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLIndirectRenderCommand", WrapperType = typeof (MTLIndirectRenderCommandWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:", ParameterType = new Type [] { typeof (IMTLRenderPipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffer", Selector = "setVertexBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBuffer", Selector = "setFragmentBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPatches", Selector = "drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPatches", Selector = "drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Reset", Selector = "reset")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffer", Selector = "setVertexBuffer:offset:attributeStride:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectThreadgroupMemoryLength", Selector = "setObjectThreadgroupMemoryLength:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectBuffer", Selector = "setObjectBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshBuffer", Selector = "setMeshBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreadgroups", Selector = "drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreads", Selector = "drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBarrier", Selector = "setBarrier")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ClearBarrier", Selector = "clearBarrier")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStencilState", Selector = "setDepthStencilState:", ParameterType = new Type [] { typeof (IMTLDepthStencilState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthBias", Selector = "setDepthBias:slopeScale:clamp:", ParameterType = new Type [] { typeof (float), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthClipMode", Selector = "setDepthClipMode:", ParameterType = new Type [] { typeof (MTLDepthClipMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCullMode", Selector = "setCullMode:", ParameterType = new Type [] { typeof (MTLCullMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFrontFacingWinding", Selector = "setFrontFacingWinding:", ParameterType = new Type [] { typeof (MTLWinding) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTriangleFillMode", Selector = "setTriangleFillMode:", ParameterType = new Type [] { typeof (MTLTriangleFillMode) }, ParameterByRef = new bool [] { false })]
	public partial interface IMTLIndirectRenderCommand : INativeObject, IDisposable
	{
		/// <param name="pipelineState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setRenderPipelineState:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRenderPipelineState (IMTLRenderPipelineState pipelineState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pipelineState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRenderPipelineState (IMTLIndirectRenderCommand This, IMTLRenderPipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRenderPipelineState:"), pipelineState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pipelineState);
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBuffer (IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentBuffer (IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <param name="numberOfPatchControlPoints">To be added.</param><param name="patchStart">To be added.</param><param name="patchCount">To be added.</param><param name="patchIndexBuffer">To be added.</param><param name="patchIndexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="instanceStride">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="numberOfPatchControlPoints">To be added.</param><param name="patchStart">To be added.</param><param name="patchCount">To be added.</param><param name="patchIndexBuffer">To be added.</param><param name="patchIndexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="instanceStride">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPatches (IMTLIndirectRenderCommand This, nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, instanceCount, baseInstance, buffer__handle__, offset, instanceStride);
			GC.KeepAlive (This);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (buffer);
		}
		/// <param name="numberOfPatchControlPoints">To be added.</param><param name="patchStart">To be added.</param><param name="patchCount">To be added.</param><param name="patchIndexBuffer">To be added.</param><param name="patchIndexBufferOffset">To be added.</param><param name="controlPointIndexBuffer">To be added.</param><param name="controlPointIndexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="instanceStride">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="numberOfPatchControlPoints">To be added.</param><param name="patchStart">To be added.</param><param name="patchCount">To be added.</param><param name="patchIndexBuffer">To be added.</param><param name="patchIndexBufferOffset">To be added.</param><param name="controlPointIndexBuffer">To be added.</param><param name="controlPointIndexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="instanceStride">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPatches (IMTLIndirectRenderCommand This, nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var controlPointIndexBuffer__handle__ = controlPointIndexBuffer!.GetNonNullHandle (nameof (controlPointIndexBuffer));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, controlPointIndexBuffer__handle__, controlPointIndexBufferOffset, instanceCount, baseInstance, buffer__handle__, offset, instanceStride);
			GC.KeepAlive (This);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (controlPointIndexBuffer);
			GC.KeepAlive (buffer);
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTLIndirectRenderCommand This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
			GC.KeepAlive (This);
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseVertex">To be added.</param><param name="baseInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseVertex">To be added.</param><param name="baseInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTLIndirectRenderCommand This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, instanceCount, baseVertex, baseInstance);
			GC.KeepAlive (This);
			GC.KeepAlive (indexBuffer);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Reset (IMTLIndirectRenderCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("reset"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexBuffer:offset:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBuffer (IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBuffer (IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectThreadgroupMemoryLength:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectThreadgroupMemoryLength (nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectThreadgroupMemoryLength (IMTLIndirectRenderCommand This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectBuffer:offset:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectBuffer (IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshBuffer:offset:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshBuffer (IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreadgroups (IMTLIndirectRenderCommand This, MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreads (MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreads (IMTLIndirectRenderCommand This, MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBarrier")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBarrier ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBarrier (IMTLIndirectRenderCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setBarrier"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("clearBarrier")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearBarrier ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ClearBarrier (IMTLIndirectRenderCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clearBarrier"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStencilState:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStencilState (IMTLDepthStencilState? depthStencilState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStencilState (IMTLIndirectRenderCommand This, IMTLDepthStencilState? depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (depthStencilState);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthBias:slopeScale:clamp:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthBias (float depthBias, float slopeScale, float clamp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthBias (IMTLIndirectRenderCommand This, float depthBias, float slopeScale, float clamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (This.Handle, Selector.GetHandle ("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthClipMode:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthClipMode (MTLDepthClipMode depthClipMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthClipMode (IMTLIndirectRenderCommand This, MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setCullMode:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCullMode (MTLCullMode cullMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCullMode (IMTLIndirectRenderCommand This, MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFrontFacingWinding:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFrontFacingWinding (MTLWinding frontFacingWindning)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFrontFacingWinding (IMTLIndirectRenderCommand This, MTLWinding frontFacingWindning)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWindning);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTriangleFillMode:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTriangleFillMode (MTLTriangleFillMode fillMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTriangleFillMode (IMTLIndirectRenderCommand This, MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ClearBarrier()")]
		[DynamicDependencyAttribute ("DrawIndexedPatches(System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawMeshThreadgroups(Metal.MTLSize,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawMeshThreads(Metal.MTLSize,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawPatches(System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Reset()")]
		[DynamicDependencyAttribute ("SetBarrier()")]
		[DynamicDependencyAttribute ("SetCullMode(Metal.MTLCullMode)")]
		[DynamicDependencyAttribute ("SetDepthBias(System.Single,System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetDepthClipMode(Metal.MTLDepthClipMode)")]
		[DynamicDependencyAttribute ("SetDepthStencilState(Metal.IMTLDepthStencilState)")]
		[DynamicDependencyAttribute ("SetFragmentBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFrontFacingWinding(Metal.MTLWinding)")]
		[DynamicDependencyAttribute ("SetMeshBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetRenderPipelineState(Metal.IMTLRenderPipelineState)")]
		[DynamicDependencyAttribute ("SetTriangleFillMode(Metal.MTLTriangleFillMode)")]
		[DynamicDependencyAttribute ("SetVertexBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIndirectRenderCommandWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLIndirectRenderCommand ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLIndirectRenderCommand" /> interface to support all the methods from the MTLIndirectRenderCommand protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLIndirectRenderCommand" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLIndirectRenderCommand protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLIndirectRenderCommand_Extensions {
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexBuffer (this IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectThreadgroupMemoryLength (this IMTLIndirectRenderCommand This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectBuffer (this IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshBuffer (this IMTLIndirectRenderCommand This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawMeshThreadgroups (this IMTLIndirectRenderCommand This, MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawMeshThreads (this IMTLIndirectRenderCommand This, MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBarrier (this IMTLIndirectRenderCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setBarrier"));
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClearBarrier (this IMTLIndirectRenderCommand This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clearBarrier"));
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDepthStencilState (this IMTLIndirectRenderCommand This, IMTLDepthStencilState? depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (depthStencilState);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDepthBias (this IMTLIndirectRenderCommand This, float depthBias, float slopeScale, float clamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (This.Handle, Selector.GetHandle ("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDepthClipMode (this IMTLIndirectRenderCommand This, MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCullMode (this IMTLIndirectRenderCommand This, MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFrontFacingWinding (this IMTLIndirectRenderCommand This, MTLWinding frontFacingWindning)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWindning);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTriangleFillMode (this IMTLIndirectRenderCommand This, MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLIndirectRenderCommandWrapper : BaseWrapper, IMTLIndirectRenderCommand {
		public MTLIndirectRenderCommandWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIndirectRenderCommandWrapper))]
		static MTLIndirectRenderCommandWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="pipelineState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setRenderPipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetRenderPipelineState (IMTLRenderPipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRenderPipelineState:"), pipelineState__handle__);
			GC.KeepAlive (pipelineState);
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		/// <param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		/// <param name="numberOfPatchControlPoints">To be added.</param><param name="patchStart">To be added.</param><param name="patchCount">To be added.</param><param name="patchIndexBuffer">To be added.</param><param name="patchIndexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="instanceStride">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, instanceCount, baseInstance, buffer__handle__, offset, instanceStride);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (buffer);
		}
		/// <param name="numberOfPatchControlPoints">To be added.</param><param name="patchStart">To be added.</param><param name="patchCount">To be added.</param><param name="patchIndexBuffer">To be added.</param><param name="patchIndexBufferOffset">To be added.</param><param name="controlPointIndexBuffer">To be added.</param><param name="controlPointIndexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><param name="buffer">To be added.</param><param name="offset">To be added.</param><param name="instanceStride">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var controlPointIndexBuffer__handle__ = controlPointIndexBuffer!.GetNonNullHandle (nameof (controlPointIndexBuffer));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, controlPointIndexBuffer__handle__, controlPointIndexBufferOffset, instanceCount, baseInstance, buffer__handle__, offset, instanceStride);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (controlPointIndexBuffer);
			GC.KeepAlive (buffer);
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><param name="instanceCount">To be added.</param><param name="baseInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><param name="baseVertex">To be added.</param><param name="baseInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, instanceCount, baseVertex, baseInstance);
			GC.KeepAlive (indexBuffer);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Reset ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
		}
		[Export ("setVertexBuffer:offset:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBuffer (IMTLBuffer buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setObjectThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectThreadgroupMemoryLength (nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
		}
		[Export ("setObjectBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setMeshBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setMeshBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawMeshThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
		}
		[Export ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawMeshThreads (MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
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
		[Export ("setDepthStencilState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStencilState (IMTLDepthStencilState? depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (depthStencilState);
		}
		[Export ("setDepthBias:slopeScale:clamp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthBias (float depthBias, float slopeScale, float clamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (this.Handle, Selector.GetHandle ("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
		}
		[Export ("setDepthClipMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthClipMode (MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
		}
		[Export ("setCullMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetCullMode (MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
		}
		[Export ("setFrontFacingWinding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFrontFacingWinding (MTLWinding frontFacingWindning)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWindning);
		}
		[Export ("setTriangleFillMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTriangleFillMode (MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
		}
	}
}
