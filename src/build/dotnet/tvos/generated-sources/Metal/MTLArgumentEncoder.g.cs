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
	/// <summary>Encodes data into argument buffers.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLArgumentEncoder", WrapperType = typeof (MTLArgumentEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentBuffer", Selector = "setArgumentBuffer:offset:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentBuffer", Selector = "setArgumentBuffer:startOffset:arrayElement:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffer", Selector = "setBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffers", Selector = "setBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTexture", Selector = "setTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextures", Selector = "setTextures:withRange:", ParameterType = new Type [] { typeof (IMTLTexture[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerStates", Selector = "setSamplerStates:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetConstantData", Selector = "constantDataAtIndex:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:atIndex:", ParameterType = new Type [] { typeof (IMTLRenderPipelineState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineStates", Selector = "setRenderPipelineStates:withRange:", ParameterType = new Type [] { typeof (IMTLRenderPipelineState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIndirectCommandBuffer", Selector = "setIndirectCommandBuffer:atIndex:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIndirectCommandBuffers", Selector = "setIndirectCommandBuffers:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderForBufferAtIndex:", ReturnType = typeof (IMTLArgumentEncoder), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetComputePipelineState", Selector = "setComputePipelineState:atIndex:", ParameterType = new Type [] { typeof (IMTLComputePipelineState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetComputePipelineStates", Selector = "setComputePipelineStates:withRange:", ParameterType = new Type [] { typeof (IMTLComputePipelineState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAccelerationStructure", Selector = "setAccelerationStructure:atIndex:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibleFunctionTable", Selector = "setVisibleFunctionTable:atIndex:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibleFunctionTables", Selector = "setVisibleFunctionTables:withRange:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIntersectionFunctionTable", Selector = "setIntersectionFunctionTable:atIndex:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIntersectionFunctionTables", Selector = "setIntersectionFunctionTables:withRange:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStencilState", Selector = "setDepthStencilState:atIndex:", ParameterType = new Type [] { typeof (IMTLDepthStencilState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStencilStates", Selector = "setDepthStencilStates:withRange:", ParameterType = new Type [] { typeof (IMTLDepthStencilState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "EncodedLength", Selector = "encodedLength", PropertyType = typeof (UIntPtr), GetterSelector = "encodedLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Alignment", Selector = "alignment", PropertyType = typeof (UIntPtr), GetterSelector = "alignment", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLArgumentEncoder : INativeObject, IDisposable
	{
		/// <param name="argumentBuffer">The destination buffer.</param><param name="offset">The offset of the buffer, in bytes.</param><summary>Sets the target buffer to which arguments will be encoded.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setArgumentBuffer:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetArgumentBuffer (IMTLBuffer? argumentBuffer, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="argumentBuffer">The destination buffer.</param><param name="offset">The offset of the buffer, in bytes.</param><summary>Sets the target buffer to which arguments will be encoded.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetArgumentBuffer (IMTLArgumentEncoder This, IMTLBuffer? argumentBuffer, nuint offset)
		{
			var argumentBuffer__handle__ = argumentBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setArgumentBuffer:offset:"), argumentBuffer__handle__, offset);
			GC.KeepAlive (This);
			GC.KeepAlive (argumentBuffer);
		}
		/// <param name="argumentBuffer">The destination buffer.</param><param name="startOffset">The offset of the buffer, in bytes.</param><param name="arrayElement">The index, into the targeted buffer, of the argument.</param><summary>Sets the target buffer to which arguments will be encoded.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setArgumentBuffer:startOffset:arrayElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetArgumentBuffer (IMTLBuffer? argumentBuffer, nuint startOffset, nuint arrayElement)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="argumentBuffer">The destination buffer.</param><param name="startOffset">The offset of the buffer, in bytes.</param><param name="arrayElement">The index, into the targeted buffer, of the argument.</param><summary>Sets the target buffer to which arguments will be encoded.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetArgumentBuffer (IMTLArgumentEncoder This, IMTLBuffer? argumentBuffer, nuint startOffset, nuint arrayElement)
		{
			var argumentBuffer__handle__ = argumentBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setArgumentBuffer:startOffset:arrayElement:"), argumentBuffer__handle__, startOffset, arrayElement);
			GC.KeepAlive (This);
			GC.KeepAlive (argumentBuffer);
		}
		/// <param name="buffer">A buffer in an argument buffer.</param><param name="offset">The byte offset of <paramref name="buffer" />.</param><param name="index">The index of the nested buffer. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes <paramref name="buffer" /> to the argument buffer.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffer">A buffer in an argument buffer.</param><param name="offset">The byte offset of <paramref name="buffer" />.</param><param name="index">The index of the nested buffer. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes <paramref name="buffer" /> to the argument buffer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffer (IMTLArgumentEncoder This, IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffers (nint buffers, nint offsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffers (IMTLArgumentEncoder This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		/// <param name="texture">A texture within an argument buffer.</param><param name="index">The index of the texture. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes the provided <paramref name="texture" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTexture (IMTLTexture? texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="texture">A texture within an argument buffer.</param><param name="index">The index of the texture. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes the provided <paramref name="texture" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTexture (IMTLArgumentEncoder This, IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		/// <param name="textures">An array of textures from which to select the textures to encode.</param><param name="range">Indices into <paramref name="textures" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param><summary>Encodes the provided <paramref name="textures" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextures (IMTLTexture[] textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textures">An array of textures from which to select the textures to encode.</param><param name="range">Indices into <paramref name="textures" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param><summary>Encodes the provided <paramref name="textures" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextures (IMTLArgumentEncoder This, IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTextures:withRange:"), nsa_textures.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="sampler">A sampler within an argument buffer.</param><param name="index">The sampler index. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes <paramref name="sampler" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">A sampler within an argument buffer.</param><param name="index">The sampler index. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes <paramref name="sampler" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerState (IMTLArgumentEncoder This, IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="samplers">An array of samplers from which to select the samplers to encode.</param><param name="range">Indices into <paramref name="samplers" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param><summary>Encodes the provided <paramref name="samplers" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">An array of samplers from which to select the samplers to encode.</param><param name="range">Indices into <paramref name="samplers" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param><summary>Encodes the provided <paramref name="samplers" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerStates (IMTLArgumentEncoder This, IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setSamplerStates:withRange:"), nsa_samplers.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="index">The index for the constant. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Returns a pointer to the constant at the specified <paramref name="index" /> into the buffer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("constantDataAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetConstantData (nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="index">The index for the constant. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Returns a pointer to the constant at the specified <paramref name="index" /> into the buffer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetConstantData (IMTLArgumentEncoder This, nuint index)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("constantDataAtIndex:"), index);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("setRenderPipelineState:atIndex:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRenderPipelineState (IMTLRenderPipelineState? pipeline, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRenderPipelineState (IMTLArgumentEncoder This, IMTLRenderPipelineState? pipeline, nuint index)
		{
			var pipeline__handle__ = pipeline.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setRenderPipelineState:atIndex:"), pipeline__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (pipeline);
		}
		[global::Foundation.RequiredMember]
		[Export ("setRenderPipelineStates:withRange:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRenderPipelineStates (IMTLRenderPipelineState[] pipelines, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRenderPipelineStates (IMTLArgumentEncoder This, IMTLRenderPipelineState[] pipelines, NSRange range)
		{
			if (pipelines is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pipelines));
			using var nsa_pipelines = NSArray.FromNSObjects (pipelines);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setRenderPipelineStates:withRange:"), nsa_pipelines.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setIndirectCommandBuffer:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIndirectCommandBuffer (IMTLIndirectCommandBuffer? indirectCommandBuffer, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIndirectCommandBuffer (IMTLArgumentEncoder This, IMTLIndirectCommandBuffer? indirectCommandBuffer, nuint index)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setIndirectCommandBuffer:atIndex:"), indirectCommandBuffer__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setIndirectCommandBuffers:withRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIndirectCommandBuffers (IMTLIndirectCommandBuffer[] buffers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIndirectCommandBuffers (IMTLArgumentEncoder This, IMTLIndirectCommandBuffer[] buffers, NSRange range)
		{
			if (buffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (buffers));
			using var nsa_buffers = NSArray.FromNSObjects (buffers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setIndirectCommandBuffers:withRange:"), nsa_buffers.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newArgumentEncoderForBufferAtIndex:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLArgumentEncoder? CreateArgumentEncoder (nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLArgumentEncoder? _CreateArgumentEncoder (IMTLArgumentEncoder This, nuint index)
		{
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newArgumentEncoderForBufferAtIndex:"), index), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setComputePipelineState:atIndex:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComputePipelineState (IMTLComputePipelineState? pipeline, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetComputePipelineState (IMTLArgumentEncoder This, IMTLComputePipelineState? pipeline, nuint index)
		{
			var pipeline__handle__ = pipeline.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setComputePipelineState:atIndex:"), pipeline__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (pipeline);
		}
		[global::Foundation.RequiredMember]
		[Export ("setComputePipelineStates:withRange:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComputePipelineStates (IMTLComputePipelineState[] pipelines, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetComputePipelineStates (IMTLArgumentEncoder This, IMTLComputePipelineState[] pipelines, NSRange range)
		{
			if (pipelines is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pipelines));
			using var nsa_pipelines = NSArray.FromNSObjects (pipelines);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setComputePipelineStates:withRange:"), nsa_pipelines.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setAccelerationStructure:atIndex:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccelerationStructure (IMTLArgumentEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint index)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setAccelerationStructure:atIndex:"), accelerationStructure__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibleFunctionTable:atIndex:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleFunctionTable (IMTLVisibleFunctionTable? visibleFunctionTable, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibleFunctionTable (IMTLArgumentEncoder This, IMTLVisibleFunctionTable? visibleFunctionTable, nuint index)
		{
			var visibleFunctionTable__handle__ = visibleFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVisibleFunctionTable:atIndex:"), visibleFunctionTable__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (visibleFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibleFunctionTables:withRange:")]
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
		internal static void _SetVisibleFunctionTables (IMTLArgumentEncoder This, IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			if (visibleFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleFunctionTables));
			using var nsa_visibleFunctionTables = NSArray.FromNSObjects (visibleFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVisibleFunctionTables:withRange:"), nsa_visibleFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setIntersectionFunctionTable:atIndex:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIntersectionFunctionTable (IMTLArgumentEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint index)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setIntersectionFunctionTable:atIndex:"), intersectionFunctionTable__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setIntersectionFunctionTables:withRange:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIntersectionFunctionTables (IMTLArgumentEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			if (intersectionFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTables));
			using var nsa_intersectionFunctionTables = NSArray.FromNSObjects (intersectionFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setIntersectionFunctionTables:withRange:"), nsa_intersectionFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStencilState:atIndex:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStencilState (IMTLDepthStencilState? depthStencilState, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStencilState (IMTLArgumentEncoder This, IMTLDepthStencilState? depthStencilState, nuint index)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStencilState:atIndex:"), depthStencilState__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (depthStencilState);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStencilStates:withRange:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStencilStates (IMTLDepthStencilState[] depthStencilStates, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStencilStates (IMTLArgumentEncoder This, IMTLDepthStencilState[] depthStencilStates, NSRange range)
		{
			if (depthStencilStates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (depthStencilStates));
			using var nsa_depthStencilStates = NSArray.FromNSObjects (depthStencilStates);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setDepthStencilStates:withRange:"), nsa_depthStencilStates.Handle, range);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Alignment")]
		[DynamicDependencyAttribute ("CreateArgumentEncoder(System.UIntPtr)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("EncodedLength")]
		[DynamicDependencyAttribute ("GetConstantData(System.UIntPtr)")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("SetAccelerationStructure(Metal.IMTLAccelerationStructure,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetArgumentBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetArgumentBuffer(Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBuffers(System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetComputePipelineState(Metal.IMTLComputePipelineState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetComputePipelineStates(Metal.IMTLComputePipelineState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetDepthStencilState(Metal.IMTLDepthStencilState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetDepthStencilStates(Metal.IMTLDepthStencilState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetIndirectCommandBuffer(Metal.IMTLIndirectCommandBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetIndirectCommandBuffers(Metal.IMTLIndirectCommandBuffer[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetIntersectionFunctionTable(Metal.IMTLIntersectionFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetIntersectionFunctionTables(Metal.IMTLIntersectionFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetRenderPipelineState(Metal.IMTLRenderPipelineState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetRenderPipelineStates(Metal.IMTLRenderPipelineState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetSamplerStates(Metal.IMTLSamplerState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTextures(Metal.IMTLTexture[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVisibleFunctionTable(Metal.IMTLVisibleFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibleFunctionTables(Metal.IMTLVisibleFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLArgumentEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLArgumentEncoder ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the device for the encoder.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLArgumentEncoder This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets or sets a descriptive label for the encoder.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
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
		internal static string _GetLabel (IMTLArgumentEncoder This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLArgumentEncoder This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		/// <summary>Gets the number of bytes that are required to store the encoded resources in the buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint EncodedLength {
			[Export ("encodedLength")]
			get {
				return _GetEncodedLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetEncodedLength (IMTLArgumentEncoder This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("encodedLength"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the byte alignment for the encoded data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Alignment {
			[Export ("alignment")]
			get {
				return _GetAlignment (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetAlignment (IMTLArgumentEncoder This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("alignment"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLArgumentEncoder" /> interface to support all the methods from the MTLArgumentEncoder protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLArgumentEncoder" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLArgumentEncoder protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLArgumentEncoder_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccelerationStructure (this IMTLArgumentEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint index)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setAccelerationStructure:atIndex:"), accelerationStructure__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVisibleFunctionTable (this IMTLArgumentEncoder This, IMTLVisibleFunctionTable? visibleFunctionTable, nuint index)
		{
			var visibleFunctionTable__handle__ = visibleFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVisibleFunctionTable:atIndex:"), visibleFunctionTable__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (visibleFunctionTable);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVisibleFunctionTables (this IMTLArgumentEncoder This, IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			if (visibleFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleFunctionTables));
			using var nsa_visibleFunctionTables = NSArray.FromNSObjects (visibleFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVisibleFunctionTables:withRange:"), nsa_visibleFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIntersectionFunctionTable (this IMTLArgumentEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint index)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setIntersectionFunctionTable:atIndex:"), intersectionFunctionTable__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIntersectionFunctionTables (this IMTLArgumentEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			if (intersectionFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTables));
			using var nsa_intersectionFunctionTables = NSArray.FromNSObjects (intersectionFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setIntersectionFunctionTables:withRange:"), nsa_intersectionFunctionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDepthStencilState (this IMTLArgumentEncoder This, IMTLDepthStencilState? depthStencilState, nuint index)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStencilState:atIndex:"), depthStencilState__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (depthStencilState);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDepthStencilStates (this IMTLArgumentEncoder This, IMTLDepthStencilState[] depthStencilStates, NSRange range)
		{
			if (depthStencilStates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (depthStencilStates));
			using var nsa_depthStencilStates = NSArray.FromNSObjects (depthStencilStates);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setDepthStencilStates:withRange:"), nsa_depthStencilStates.Handle, range);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLArgumentEncoderWrapper : BaseWrapper, IMTLArgumentEncoder {
		public MTLArgumentEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLArgumentEncoderWrapper))]
		static MTLArgumentEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="argumentBuffer">The destination buffer.</param><param name="offset">The offset of the buffer, in bytes.</param><summary>Sets the target buffer to which arguments will be encoded.</summary><remarks>To be added.</remarks>
		[Export ("setArgumentBuffer:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetArgumentBuffer (IMTLBuffer? argumentBuffer, nuint offset)
		{
			var argumentBuffer__handle__ = argumentBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setArgumentBuffer:offset:"), argumentBuffer__handle__, offset);
			GC.KeepAlive (argumentBuffer);
		}
		/// <param name="argumentBuffer">The destination buffer.</param><param name="startOffset">The offset of the buffer, in bytes.</param><param name="arrayElement">The index, into the targeted buffer, of the argument.</param><summary>Sets the target buffer to which arguments will be encoded.</summary><remarks>To be added.</remarks>
		[Export ("setArgumentBuffer:startOffset:arrayElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetArgumentBuffer (IMTLBuffer? argumentBuffer, nuint startOffset, nuint arrayElement)
		{
			var argumentBuffer__handle__ = argumentBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setArgumentBuffer:startOffset:arrayElement:"), argumentBuffer__handle__, startOffset, arrayElement);
			GC.KeepAlive (argumentBuffer);
		}
		/// <param name="buffer">A buffer in an argument buffer.</param><param name="offset">The byte offset of <paramref name="buffer" />.</param><param name="index">The index of the nested buffer. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes <paramref name="buffer" /> to the argument buffer.</summary><remarks>To be added.</remarks>
		[Export ("setBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffers (nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setBuffers:offsets:withRange:"), buffers, offsets, range);
		}
		/// <param name="texture">A texture within an argument buffer.</param><param name="index">The index of the texture. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes the provided <paramref name="texture" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[Export ("setTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTexture (IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		/// <param name="textures">An array of textures from which to select the textures to encode.</param><param name="range">Indices into <paramref name="textures" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param><summary>Encodes the provided <paramref name="textures" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[Export ("setTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTextures (IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTextures:withRange:"), nsa_textures.Handle, range);
		}
		/// <param name="sampler">A sampler within an argument buffer.</param><param name="index">The sampler index. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Encodes <paramref name="sampler" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[Export ("setSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="samplers">An array of samplers from which to select the samplers to encode.</param><param name="range">Indices into <paramref name="samplers" />. Either Metal index IDs or the index members of <see cref="T:Metal.MTLArgumentDescriptor" />s.</param><summary>Encodes the provided <paramref name="samplers" /> into the argument buffer.</summary><remarks>To be added.</remarks>
		[Export ("setSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setSamplerStates:withRange:"), nsa_samplers.Handle, range);
		}
		/// <param name="index">The index for the constant. Either a Metal index ID or the index member of a <see cref="T:Metal.MTLArgumentDescriptor" />.</param><summary>Returns a pointer to the constant at the specified <paramref name="index" /> into the buffer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("constantDataAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetConstantData (nuint index)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("constantDataAtIndex:"), index);
			return ret;
		}
		[Export ("setRenderPipelineState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetRenderPipelineState (IMTLRenderPipelineState? pipeline, nuint index)
		{
			var pipeline__handle__ = pipeline.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setRenderPipelineState:atIndex:"), pipeline__handle__, index);
			GC.KeepAlive (pipeline);
		}
		[Export ("setRenderPipelineStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetRenderPipelineStates (IMTLRenderPipelineState[] pipelines, NSRange range)
		{
			if (pipelines is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pipelines));
			using var nsa_pipelines = NSArray.FromNSObjects (pipelines);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setRenderPipelineStates:withRange:"), nsa_pipelines.Handle, range);
		}
		[Export ("setIndirectCommandBuffer:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIndirectCommandBuffer (IMTLIndirectCommandBuffer? indirectCommandBuffer, nuint index)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setIndirectCommandBuffer:atIndex:"), indirectCommandBuffer__handle__, index);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[Export ("setIndirectCommandBuffers:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIndirectCommandBuffers (IMTLIndirectCommandBuffer[] buffers, NSRange range)
		{
			if (buffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (buffers));
			using var nsa_buffers = NSArray.FromNSObjects (buffers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setIndirectCommandBuffers:withRange:"), nsa_buffers.Handle, range);
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newArgumentEncoderForBufferAtIndex:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLArgumentEncoder? CreateArgumentEncoder (nuint index)
		{
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newArgumentEncoderForBufferAtIndex:"), index), true)!;
			return ret!;
		}
		[Export ("setComputePipelineState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComputePipelineState (IMTLComputePipelineState? pipeline, nuint index)
		{
			var pipeline__handle__ = pipeline.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setComputePipelineState:atIndex:"), pipeline__handle__, index);
			GC.KeepAlive (pipeline);
		}
		[Export ("setComputePipelineStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComputePipelineStates (IMTLComputePipelineState[] pipelines, NSRange range)
		{
			if (pipelines is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pipelines));
			using var nsa_pipelines = NSArray.FromNSObjects (pipelines);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setComputePipelineStates:withRange:"), nsa_pipelines.Handle, range);
		}
		[Export ("setAccelerationStructure:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint index)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setAccelerationStructure:atIndex:"), accelerationStructure__handle__, index);
			GC.KeepAlive (accelerationStructure);
		}
		[Export ("setVisibleFunctionTable:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibleFunctionTable (IMTLVisibleFunctionTable? visibleFunctionTable, nuint index)
		{
			var visibleFunctionTable__handle__ = visibleFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVisibleFunctionTable:atIndex:"), visibleFunctionTable__handle__, index);
			GC.KeepAlive (visibleFunctionTable);
		}
		[Export ("setVisibleFunctionTables:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibleFunctionTables (IMTLVisibleFunctionTable[] visibleFunctionTables, NSRange range)
		{
			if (visibleFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleFunctionTables));
			using var nsa_visibleFunctionTables = NSArray.FromNSObjects (visibleFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVisibleFunctionTables:withRange:"), nsa_visibleFunctionTables.Handle, range);
		}
		[Export ("setIntersectionFunctionTable:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint index)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setIntersectionFunctionTable:atIndex:"), intersectionFunctionTable__handle__, index);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[Export ("setIntersectionFunctionTables:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
		{
			if (intersectionFunctionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTables));
			using var nsa_intersectionFunctionTables = NSArray.FromNSObjects (intersectionFunctionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setIntersectionFunctionTables:withRange:"), nsa_intersectionFunctionTables.Handle, range);
		}
		[Export ("setDepthStencilState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStencilState (IMTLDepthStencilState? depthStencilState, nuint index)
		{
			var depthStencilState__handle__ = depthStencilState.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setDepthStencilState:atIndex:"), depthStencilState__handle__, index);
			GC.KeepAlive (depthStencilState);
		}
		[Export ("setDepthStencilStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStencilStates (IMTLDepthStencilState[] depthStencilStates, NSRange range)
		{
			if (depthStencilStates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (depthStencilStates));
			using var nsa_depthStencilStates = NSArray.FromNSObjects (depthStencilStates);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setDepthStencilStates:withRange:"), nsa_depthStencilStates.Handle, range);
		}
		/// <summary>Gets the device for the encoder.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>Gets or sets a descriptive label for the encoder.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the number of bytes that are required to store the encoded resources in the buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint EncodedLength {
			[Export ("encodedLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("encodedLength"));
				return ret;
			}
		}
		/// <summary>Gets the byte alignment for the encoded data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Alignment {
			[Export ("alignment")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alignment"));
				return ret;
			}
		}
	}
}
