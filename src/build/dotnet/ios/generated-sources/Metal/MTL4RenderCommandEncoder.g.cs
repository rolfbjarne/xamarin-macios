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
	/// <summary>This interface represents the Objective-C protocol <c>MTL4RenderCommandEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[UnsupportedSimulator ("ios")]
	[Protocol (Name = "MTL4RenderCommandEncoder", WrapperType = typeof (MTL4RenderCommandEncoderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorAttachmentMap", Selector = "setColorAttachmentMap:", ParameterType = new Type [] { typeof (MTLLogicalToPhysicalColorAttachmentMap) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:", ParameterType = new Type [] { typeof (IMTLRenderPipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetViewport", Selector = "setViewport:", ParameterType = new Type [] { typeof (MTLViewport) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetViewports", Selector = "setViewports:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexAmplificationCount", Selector = "setVertexAmplificationCount:viewMappings:", ParameterType = new Type [] { typeof (UIntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCullMode", Selector = "setCullMode:", ParameterType = new Type [] { typeof (MTLCullMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthClipMode", Selector = "setDepthClipMode:", ParameterType = new Type [] { typeof (MTLDepthClipMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthBias", Selector = "setDepthBias:slopeScale:clamp:", ParameterType = new Type [] { typeof (float), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthTest", Selector = "setDepthTestMinBound:maxBound:", ParameterType = new Type [] { typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetScissorRect", Selector = "setScissorRect:", ParameterType = new Type [] { typeof (MTLScissorRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetScissorRects", Selector = "setScissorRects:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTriangleFillMode", Selector = "setTriangleFillMode:", ParameterType = new Type [] { typeof (MTLTriangleFillMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBlendColorRed", Selector = "setBlendColorRed:green:blue:alpha:", ParameterType = new Type [] { typeof (float), typeof (float), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStencilState", Selector = "setDepthStencilState:", ParameterType = new Type [] { typeof (IMTLDepthStencilState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilReferenceValue", Selector = "setStencilReferenceValue:", ParameterType = new Type [] { typeof (uint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilFrontReferenceValue", Selector = "setStencilFrontReferenceValue:backReferenceValue:", ParameterType = new Type [] { typeof (uint), typeof (uint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibilityResultMode", Selector = "setVisibilityResultMode:offset:", ParameterType = new Type [] { typeof (MTLVisibilityResultMode), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorStoreAction", Selector = "setColorStoreAction:atIndex:", ParameterType = new Type [] { typeof (MTLStoreAction), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStoreAction", Selector = "setDepthStoreAction:", ParameterType = new Type [] { typeof (MTLStoreAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilStoreAction", Selector = "setStencilStoreAction:", ParameterType = new Type [] { typeof (MTLStoreAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (ulong), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (ulong), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:baseVertex:baseInstance:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (ulong), typeof (UIntPtr), typeof (UIntPtr), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:indirectBuffer:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexType:indexBuffer:indexBufferLength:indirectBuffer:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (MTLIndexType), typeof (ulong), typeof (UIntPtr), typeof (ulong) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommandsInBuffer", Selector = "executeCommandsInBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommandsInBuffer", Selector = "executeCommandsInBuffer:indirectBuffer:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectThreadgroupMemoryLength", Selector = "setObjectThreadgroupMemoryLength:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreadgroups", Selector = "drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreads", Selector = "drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreadgroups", Selector = "drawMeshThreadgroupsWithIndirectBuffer:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (ulong), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadsPerTile", Selector = "dispatchThreadsPerTile:", ParameterType = new Type [] { typeof (MTLSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetThreadgroupMemoryLength", Selector = "setThreadgroupMemoryLength:offset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentTable", Selector = "setArgumentTable:atStages:", ParameterType = new Type [] { typeof (IMTL4ArgumentTable), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFrontFacingWinding", Selector = "setFrontFacingWinding:", ParameterType = new Type [] { typeof (MTLWinding) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteTimestamp", Selector = "writeTimestampWithGranularity:afterStage:intoHeap:atIndex:", ParameterType = new Type [] { typeof (MTL4TimestampGranularity), typeof (MTLRenderStages), typeof (IMTL4CounterHeap), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TileWidth", Selector = "tileWidth", PropertyType = typeof (UIntPtr), GetterSelector = "tileWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TileHeight", Selector = "tileHeight", PropertyType = typeof (UIntPtr), GetterSelector = "tileHeight", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4RenderCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTL4CommandEncoder
	{
		[global::Foundation.RequiredMember]
		[Export ("setColorAttachmentMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorAttachmentMap (MTLLogicalToPhysicalColorAttachmentMap? mapping)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorAttachmentMap (IMTL4RenderCommandEncoder This, MTLLogicalToPhysicalColorAttachmentMap? mapping)
		{
			var mapping__handle__ = mapping.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColorAttachmentMap:"), mapping__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapping);
		}
		[global::Foundation.RequiredMember]
		[Export ("setRenderPipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRenderPipelineState (IMTLRenderPipelineState pipelineState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRenderPipelineState (IMTL4RenderCommandEncoder This, IMTLRenderPipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRenderPipelineState:"), pipelineState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pipelineState);
		}
		[global::Foundation.RequiredMember]
		[Export ("setViewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewport (MTLViewport viewport)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetViewport (IMTL4RenderCommandEncoder This, MTLViewport viewport)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLViewport (This.Handle, Selector.GetHandle ("setViewport:"), viewport);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setViewports:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewports (nint viewports, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetViewports (IMTL4RenderCommandEncoder This, nint viewports, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setViewports:count:"), viewports, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexAmplificationCount:viewMappings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexAmplificationCount (nuint count, nint viewMappings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexAmplificationCount (IMTL4RenderCommandEncoder This, nuint count, nint viewMappings)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("setVertexAmplificationCount:viewMappings:"), count, viewMappings);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setCullMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCullMode (MTLCullMode cullMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCullMode (IMTL4RenderCommandEncoder This, MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthClipMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthClipMode (MTLDepthClipMode depthClipMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthClipMode (IMTL4RenderCommandEncoder This, MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthBias:slopeScale:clamp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthBias (float depthBias, float slopeScale, float clamp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthBias (IMTL4RenderCommandEncoder This, float depthBias, float slopeScale, float clamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (This.Handle, Selector.GetHandle ("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthTestMinBound:maxBound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthTest (float minBound, float maxBound)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthTest (IMTL4RenderCommandEncoder This, float minBound, float maxBound)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float (This.Handle, Selector.GetHandle ("setDepthTestMinBound:maxBound:"), minBound, maxBound);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setScissorRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScissorRect (MTLScissorRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScissorRect (IMTL4RenderCommandEncoder This, MTLScissorRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLScissorRect (This.Handle, Selector.GetHandle ("setScissorRect:"), rect);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setScissorRects:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScissorRects (nint scissorRects, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScissorRects (IMTL4RenderCommandEncoder This, nint scissorRects, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setScissorRects:count:"), scissorRects, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTriangleFillMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTriangleFillMode (MTLTriangleFillMode fillMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTriangleFillMode (IMTL4RenderCommandEncoder This, MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBlendColorRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBlendColorRed (float red, float green, float blue, float alpha)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBlendColorRed (IMTL4RenderCommandEncoder This, float red, float green, float blue, float alpha)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float_float (This.Handle, Selector.GetHandle ("setBlendColorRed:green:blue:alpha:"), red, green, blue, alpha);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStencilState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStencilState (IMTLDepthStencilState? depthStencilState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStencilState (IMTL4RenderCommandEncoder This, IMTLDepthStencilState? depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (depthStencilState);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStencilReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilReferenceValue (uint referenceValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilReferenceValue (IMTL4RenderCommandEncoder This, uint referenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("setStencilReferenceValue:"), referenceValue);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStencilFrontReferenceValue:backReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilFrontReferenceValue (uint frontReferenceValue, uint backReferenceValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilFrontReferenceValue (IMTL4RenderCommandEncoder This, uint frontReferenceValue, uint backReferenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (This.Handle, Selector.GetHandle ("setStencilFrontReferenceValue:backReferenceValue:"), frontReferenceValue, backReferenceValue);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibilityResultMode:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibilityResultMode (MTLVisibilityResultMode mode, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibilityResultMode (IMTL4RenderCommandEncoder This, MTLVisibilityResultMode mode, nuint offset)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVisibilityResultMode:offset:"), (UIntPtr) (ulong) mode, offset);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setColorStoreAction:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorStoreAction (MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorStoreAction (IMTL4RenderCommandEncoder This, MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setColorStoreAction:atIndex:"), (UIntPtr) (ulong) storeAction, colorAttachmentIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStoreAction (MTLStoreAction storeAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStoreAction (IMTL4RenderCommandEncoder This, MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStoreAction:"), (UIntPtr) (ulong) storeAction);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStencilStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilStoreAction (MTLStoreAction storeAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilStoreAction (IMTL4RenderCommandEncoder This, MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setStencilStoreAction:"), (UIntPtr) (ulong) storeAction);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt64_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, nuint instanceCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, nuint instanceCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt64_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength, instanceCount);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:baseVertex:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt64_UIntPtr_UIntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:baseVertex:baseInstance:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength, instanceCount, baseVertex, baseInstance);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, ulong indirectBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, ulong indirectBuffer)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UInt64 (This.Handle, Selector.GetHandle ("drawPrimitives:indirectBuffer:"), (UIntPtr) (ulong) primitiveType, indirectBuffer);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferLength:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, ulong indirectBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTL4RenderCommandEncoder This, MTLPrimitiveType primitiveType, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, ulong indirectBuffer)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UInt64_UIntPtr_UInt64 (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferLength:indirectBuffer:"), (UIntPtr) (ulong) primitiveType, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength, indirectBuffer);
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
		internal static void _ExecuteCommandsInBuffer (IMTL4RenderCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:withRange:"), indirectCommandBuffer__handle__, executionRange);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommandsInBuffer (IMTLIndirectCommandBuffer indirectCommandBuffer, ulong indirectRangeBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommandsInBuffer (IMTL4RenderCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, ulong indirectRangeBuffer)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:"), indirectCommandBuffer__handle__, indirectRangeBuffer);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectThreadgroupMemoryLength (nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectThreadgroupMemoryLength (IMTL4RenderCommandEncoder This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreadgroups (IMTL4RenderCommandEncoder This, MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreads (MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreads (IMTL4RenderCommandEncoder This, MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreadgroupsWithIndirectBuffer:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreadgroups (ulong indirectBuffer, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreadgroups (IMTL4RenderCommandEncoder This, ulong indirectBuffer, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroupsWithIndirectBuffer:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), indirectBuffer, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadsPerTile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreadsPerTile (MTLSize threadsPerTile)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreadsPerTile (IMTL4RenderCommandEncoder This, MTLSize threadsPerTile)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreadsPerTile:"), threadsPerTile);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setThreadgroupMemoryLength:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetThreadgroupMemoryLength (nuint length, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetThreadgroupMemoryLength (IMTL4RenderCommandEncoder This, nuint length, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:offset:atIndex:"), length, offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setArgumentTable:atStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetArgumentTable (IMTL4ArgumentTable argumentTable, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetArgumentTable (IMTL4RenderCommandEncoder This, IMTL4ArgumentTable argumentTable, MTLRenderStages stages)
		{
			var argumentTable__handle__ = argumentTable!.GetNonNullHandle (nameof (argumentTable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setArgumentTable:atStages:"), argumentTable__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
			GC.KeepAlive (argumentTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFrontFacingWinding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFrontFacingWinding (MTLWinding frontFacingWinding)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFrontFacingWinding (IMTL4RenderCommandEncoder This, MTLWinding frontFacingWinding)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWinding);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeTimestampWithGranularity:afterStage:intoHeap:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteTimestamp (MTL4TimestampGranularity granularity, MTLRenderStages stage, IMTL4CounterHeap counterHeap, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteTimestamp (IMTL4RenderCommandEncoder This, MTL4TimestampGranularity granularity, MTLRenderStages stage, IMTL4CounterHeap counterHeap, nuint index)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("writeTimestampWithGranularity:afterStage:intoHeap:atIndex:"), (IntPtr) (long) granularity, (UIntPtr) (ulong) stage, counterHeap__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (counterHeap);
		}
		[DynamicDependencyAttribute ("DispatchThreadsPerTile(Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,Metal.MTLIndexType,System.UInt64,System.UIntPtr,System.UInt64)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,System.UInt64,System.UIntPtr,System.UIntPtr,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,System.UInt64,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,System.UInt64,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawMeshThreadgroups(Metal.MTLSize,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawMeshThreadgroups(System.UInt64,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawMeshThreads(Metal.MTLSize,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UInt64)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ExecuteCommandsInBuffer(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ExecuteCommandsInBuffer(Metal.IMTLIndirectCommandBuffer,System.UInt64)")]
		[DynamicDependencyAttribute ("SetArgumentTable(Metal.IMTL4ArgumentTable,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("SetBlendColorRed(System.Single,System.Single,System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetColorAttachmentMap(Metal.MTLLogicalToPhysicalColorAttachmentMap)")]
		[DynamicDependencyAttribute ("SetColorStoreAction(Metal.MTLStoreAction,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetCullMode(Metal.MTLCullMode)")]
		[DynamicDependencyAttribute ("SetDepthBias(System.Single,System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetDepthClipMode(Metal.MTLDepthClipMode)")]
		[DynamicDependencyAttribute ("SetDepthStencilState(Metal.IMTLDepthStencilState)")]
		[DynamicDependencyAttribute ("SetDepthStoreAction(Metal.MTLStoreAction)")]
		[DynamicDependencyAttribute ("SetDepthTest(System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetFrontFacingWinding(Metal.MTLWinding)")]
		[DynamicDependencyAttribute ("SetObjectThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetRenderPipelineState(Metal.IMTLRenderPipelineState)")]
		[DynamicDependencyAttribute ("SetScissorRect(Metal.MTLScissorRect)")]
		[DynamicDependencyAttribute ("SetScissorRects(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetStencilFrontReferenceValue(System.UInt32,System.UInt32)")]
		[DynamicDependencyAttribute ("SetStencilReferenceValue(System.UInt32)")]
		[DynamicDependencyAttribute ("SetStencilStoreAction(Metal.MTLStoreAction)")]
		[DynamicDependencyAttribute ("SetThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTriangleFillMode(Metal.MTLTriangleFillMode)")]
		[DynamicDependencyAttribute ("SetVertexAmplificationCount(System.UIntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("SetViewport(Metal.MTLViewport)")]
		[DynamicDependencyAttribute ("SetViewports(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibilityResultMode(Metal.MTLVisibilityResultMode,System.UIntPtr)")]
		[DynamicDependencyAttribute ("TileHeight")]
		[DynamicDependencyAttribute ("TileWidth")]
		[DynamicDependencyAttribute ("WriteTimestamp(Metal.MTL4TimestampGranularity,Metal.MTLRenderStages,Metal.IMTL4CounterHeap,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4RenderCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4RenderCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint TileWidth {
			[Export ("tileWidth")]
			get {
				return _GetTileWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetTileWidth (IMTL4RenderCommandEncoder This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tileWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint TileHeight {
			[Export ("tileHeight")]
			get {
				return _GetTileHeight (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetTileHeight (IMTL4RenderCommandEncoder This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tileHeight"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4RenderCommandEncoderWrapper : BaseWrapper, IMTL4RenderCommandEncoder {
		public MTL4RenderCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4RenderCommandEncoderWrapper))]
		static MTL4RenderCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setColorAttachmentMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorAttachmentMap (MTLLogicalToPhysicalColorAttachmentMap? mapping)
		{
			var mapping__handle__ = mapping.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColorAttachmentMap:"), mapping__handle__);
			GC.KeepAlive (mapping);
		}
		[Export ("setRenderPipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetRenderPipelineState (IMTLRenderPipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRenderPipelineState:"), pipelineState__handle__);
			GC.KeepAlive (pipelineState);
		}
		[Export ("setViewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetViewport (MTLViewport viewport)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLViewport (this.Handle, Selector.GetHandle ("setViewport:"), viewport);
		}
		[Export ("setViewports:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetViewports (nint viewports, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setViewports:count:"), viewports, count);
		}
		[Export ("setVertexAmplificationCount:viewMappings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexAmplificationCount (nuint count, nint viewMappings)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setVertexAmplificationCount:viewMappings:"), count, viewMappings);
		}
		[Export ("setCullMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetCullMode (MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
		}
		[Export ("setDepthClipMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthClipMode (MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
		}
		[Export ("setDepthBias:slopeScale:clamp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthBias (float depthBias, float slopeScale, float clamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (this.Handle, Selector.GetHandle ("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
		}
		[Export ("setDepthTestMinBound:maxBound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthTest (float minBound, float maxBound)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float (this.Handle, Selector.GetHandle ("setDepthTestMinBound:maxBound:"), minBound, maxBound);
		}
		[Export ("setScissorRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetScissorRect (MTLScissorRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLScissorRect (this.Handle, Selector.GetHandle ("setScissorRect:"), rect);
		}
		[Export ("setScissorRects:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetScissorRects (nint scissorRects, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setScissorRects:count:"), scissorRects, count);
		}
		[Export ("setTriangleFillMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTriangleFillMode (MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
		}
		[Export ("setBlendColorRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBlendColorRed (float red, float green, float blue, float alpha)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float_float (this.Handle, Selector.GetHandle ("setBlendColorRed:green:blue:alpha:"), red, green, blue, alpha);
		}
		[Export ("setDepthStencilState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStencilState (IMTLDepthStencilState? depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (depthStencilState);
		}
		[Export ("setStencilReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilReferenceValue (uint referenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setStencilReferenceValue:"), referenceValue);
		}
		[Export ("setStencilFrontReferenceValue:backReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilFrontReferenceValue (uint frontReferenceValue, uint backReferenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("setStencilFrontReferenceValue:backReferenceValue:"), frontReferenceValue, backReferenceValue);
		}
		[Export ("setVisibilityResultMode:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibilityResultMode (MTLVisibilityResultMode mode, nuint offset)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVisibilityResultMode:offset:"), (UIntPtr) (ulong) mode, offset);
		}
		[Export ("setColorStoreAction:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorStoreAction (MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setColorStoreAction:atIndex:"), (UIntPtr) (ulong) storeAction, colorAttachmentIndex);
		}
		[Export ("setDepthStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStoreAction (MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthStoreAction:"), (UIntPtr) (ulong) storeAction);
		}
		[Export ("setStencilStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilStoreAction (MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setStencilStoreAction:"), (UIntPtr) (ulong) storeAction);
		}
		[Export ("drawPrimitives:vertexStart:vertexCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount);
		}
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount);
		}
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
		}
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt64_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength);
		}
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, nuint instanceCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt64_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength, instanceCount);
		}
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:baseVertex:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt64_UIntPtr_UIntPtr_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:baseVertex:baseInstance:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength, instanceCount, baseVertex, baseInstance);
		}
		[Export ("drawPrimitives:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, ulong indirectBuffer)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UInt64 (this.Handle, Selector.GetHandle ("drawPrimitives:indirectBuffer:"), (UIntPtr) (ulong) primitiveType, indirectBuffer);
		}
		[Export ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferLength:indirectBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, MTLIndexType indexType, ulong indexBuffer, nuint indexBufferLength, ulong indirectBuffer)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UInt64_UIntPtr_UInt64 (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferLength:indirectBuffer:"), (UIntPtr) (ulong) primitiveType, (UIntPtr) (ulong) indexType, indexBuffer, indexBufferLength, indirectBuffer);
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
		public void ExecuteCommandsInBuffer (IMTLIndirectCommandBuffer indirectCommandBuffer, ulong indirectRangeBuffer)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:"), indirectCommandBuffer__handle__, indirectRangeBuffer);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[Export ("setObjectThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectThreadgroupMemoryLength (nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
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
		[Export ("drawMeshThreadgroupsWithIndirectBuffer:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawMeshThreadgroups (ulong indirectBuffer, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("drawMeshThreadgroupsWithIndirectBuffer:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), indirectBuffer, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
		}
		[Export ("dispatchThreadsPerTile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchThreadsPerTile (MTLSize threadsPerTile)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize (this.Handle, Selector.GetHandle ("dispatchThreadsPerTile:"), threadsPerTile);
		}
		[Export ("setThreadgroupMemoryLength:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetThreadgroupMemoryLength (nuint length, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:offset:atIndex:"), length, offset, index);
		}
		[Export ("setArgumentTable:atStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetArgumentTable (IMTL4ArgumentTable argumentTable, MTLRenderStages stages)
		{
			var argumentTable__handle__ = argumentTable!.GetNonNullHandle (nameof (argumentTable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setArgumentTable:atStages:"), argumentTable__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (argumentTable);
		}
		[Export ("setFrontFacingWinding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFrontFacingWinding (MTLWinding frontFacingWinding)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWinding);
		}
		[Export ("writeTimestampWithGranularity:afterStage:intoHeap:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WriteTimestamp (MTL4TimestampGranularity granularity, MTLRenderStages stage, IMTL4CounterHeap counterHeap, nuint index)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("writeTimestampWithGranularity:afterStage:intoHeap:atIndex:"), (IntPtr) (long) granularity, (UIntPtr) (ulong) stage, counterHeap__handle__, index);
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
		public nuint TileWidth {
			[Export ("tileWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tileWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint TileHeight {
			[Export ("tileHeight")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tileHeight"));
				return ret;
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
