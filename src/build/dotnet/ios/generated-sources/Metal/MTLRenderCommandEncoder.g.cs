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
	/// <summary>System protocol for encoding render commands and state into a buffer.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLRenderCommandEncoder", WrapperType = typeof (MTLRenderCommandEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:", ParameterType = new Type [] { typeof (IMTLRenderPipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffer", Selector = "setVertexBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexTexture", Selector = "setVertexTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerState", Selector = "setVertexSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerState", Selector = "setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (float), typeof (float), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetViewport", Selector = "setViewport:", ParameterType = new Type [] { typeof (MTLViewport) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFrontFacingWinding", Selector = "setFrontFacingWinding:", ParameterType = new Type [] { typeof (MTLWinding) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCullMode", Selector = "setCullMode:", ParameterType = new Type [] { typeof (MTLCullMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthClipMode", Selector = "setDepthClipMode:", ParameterType = new Type [] { typeof (MTLDepthClipMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthBias", Selector = "setDepthBias:slopeScale:clamp:", ParameterType = new Type [] { typeof (float), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthTest", Selector = "setDepthTestMinBound:maxBound:", ParameterType = new Type [] { typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetScissorRect", Selector = "setScissorRect:", ParameterType = new Type [] { typeof (MTLScissorRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTriangleFillMode", Selector = "setTriangleFillMode:", ParameterType = new Type [] { typeof (MTLTriangleFillMode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBuffer", Selector = "setFragmentBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBufferOffset", Selector = "setFragmentBufferOffset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBytes", Selector = "setFragmentBytes:length:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentTexture", Selector = "setFragmentTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerState", Selector = "setFragmentSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerState", Selector = "setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (float), typeof (float), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBlendColor", Selector = "setBlendColorRed:green:blue:alpha:", ParameterType = new Type [] { typeof (float), typeof (float), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStencilState", Selector = "setDepthStencilState:", ParameterType = new Type [] { typeof (IMTLDepthStencilState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilReferenceValue", Selector = "setStencilReferenceValue:", ParameterType = new Type [] { typeof (uint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilFrontReferenceValue", Selector = "setStencilFrontReferenceValue:backReferenceValue:", ParameterType = new Type [] { typeof (uint), typeof (uint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibilityResultMode", Selector = "setVisibilityResultMode:offset:", ParameterType = new Type [] { typeof (MTLVisibilityResultMode), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorStoreAction", Selector = "setColorStoreAction:atIndex:", ParameterType = new Type [] { typeof (MTLStoreAction), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStoreAction", Selector = "setDepthStoreAction:", ParameterType = new Type [] { typeof (MTLStoreAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilStoreAction", Selector = "setStencilStoreAction:", ParameterType = new Type [] { typeof (MTLStoreAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (UIntPtr), typeof (MTLIndexType), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (MTLPrimitiveType), typeof (MTLIndexType), typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBuffers", Selector = "setFragmentBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerStates", Selector = "setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerStates", Selector = "setFragmentSamplerStates:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentTextures", Selector = "setFragmentTextures:withRange:", ParameterType = new Type [] { typeof (IMTLTexture[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffers", Selector = "setVertexBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IMTLBuffer[]), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBufferOffset", Selector = "setVertexBufferOffset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBytes", Selector = "setVertexBytes:length:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerStates", Selector = "setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerStates", Selector = "setVertexSamplerStates:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexTextures", Selector = "setVertexTextures:withRange:", ParameterType = new Type [] { typeof (IMTLTexture[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:afterStages:", ParameterType = new Type [] { typeof (IMTLFence), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:beforeStages:", ParameterType = new Type [] { typeof (IMTLFence), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTessellationFactorBuffer", Selector = "setTessellationFactorBuffer:offset:instanceStride:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTessellationFactorScale", Selector = "setTessellationFactorScale:", ParameterType = new Type [] { typeof (float) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPatches", Selector = "drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPatches", Selector = "drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPatches", Selector = "drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPatches", Selector = "drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetViewports", Selector = "setViewports:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetScissorRects", Selector = "setScissorRects:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorStoreActionOptions", Selector = "setColorStoreActionOptions:atIndex:", ParameterType = new Type [] { typeof (MTLStoreActionOptions), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStoreActionOptions", Selector = "setDepthStoreActionOptions:", ParameterType = new Type [] { typeof (MTLStoreActionOptions) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilStoreActionOptions", Selector = "setStencilStoreActionOptions:", ParameterType = new Type [] { typeof (MTLStoreActionOptions) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResource", Selector = "useResource:usage:", ParameterType = new Type [] { typeof (IMTLResource), typeof (MTLResourceUsage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResources", Selector = "useResources:count:usage:", ParameterType = new Type [] { typeof (IMTLResource[]), typeof (UIntPtr), typeof (MTLResourceUsage) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeap", Selector = "useHeap:", ParameterType = new Type [] { typeof (IMTLHeap) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeaps", Selector = "useHeaps:count:", ParameterType = new Type [] { typeof (IMTLHeap[]), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommands", Selector = "executeCommandsInBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommands", Selector = "executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithScope:afterStages:beforeStages:", ParameterType = new Type [] { typeof (MTLBarrierScope), typeof (MTLRenderStages), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithResources:count:afterStages:beforeStages:", ParameterType = new Type [] { typeof (IMTLResource[]), typeof (UIntPtr), typeof (MTLRenderStages), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileBytes", Selector = "setTileBytes:length:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileBuffer", Selector = "setTileBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileBufferOffset", Selector = "setTileBufferOffset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileBuffers", Selector = "setTileBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IMTLBuffer[]), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileTexture", Selector = "setTileTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileTextures", Selector = "setTileTextures:withRange:", ParameterType = new Type [] { typeof (IMTLTexture[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileSamplerState", Selector = "setTileSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileSamplerStates", Selector = "setTileSamplerStates:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileSamplerState", Selector = "setTileSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (float), typeof (float), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileSamplerStates", Selector = "setTileSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type [] { typeof (IMTLSamplerState[]), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadsPerTile", Selector = "dispatchThreadsPerTile:", ParameterType = new Type [] { typeof (MTLSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetThreadgroupMemoryLength", Selector = "setThreadgroupMemoryLength:offset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexAmplificationCount", Selector = "setVertexAmplificationCount:viewMappings:", ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLVertexAmplificationViewMapping) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResource", Selector = "useResource:usage:stages:", ParameterType = new Type [] { typeof (IMTLResource), typeof (MTLResourceUsage), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResources", Selector = "useResources:count:usage:stages:", ParameterType = new Type [] { typeof (IMTLResource[]), typeof (UIntPtr), typeof (MTLResourceUsage), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeap", Selector = "useHeap:stages:", ParameterType = new Type [] { typeof (IMTLHeap), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeaps", Selector = "useHeaps:count:stages:", ParameterType = new Type [] { typeof (IMTLHeap[]), typeof (UIntPtr), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SampleCounters", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type [] { typeof (IMTLCounterSampleBuffer), typeof (UIntPtr), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexVisibleFunctionTable", Selector = "setVertexVisibleFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexVisibleFunctionTables", Selector = "setVertexVisibleFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexIntersectionFunctionTable", Selector = "setVertexIntersectionFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexIntersectionFunctionTables", Selector = "setVertexIntersectionFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexAccelerationStructure", Selector = "setVertexAccelerationStructure:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentAccelerationStructure", Selector = "setFragmentAccelerationStructure:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentIntersectionFunctionTable", Selector = "setFragmentIntersectionFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentIntersectionFunctionTables", Selector = "setFragmentIntersectionFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentVisibleFunctionTable", Selector = "setFragmentVisibleFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentVisibleFunctionTables", Selector = "setFragmentVisibleFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileAccelerationStructure", Selector = "setTileAccelerationStructure:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileIntersectionFunctionTable", Selector = "setTileIntersectionFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileIntersectionFunctionTables", Selector = "setTileIntersectionFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLIntersectionFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileVisibleFunctionTable", Selector = "setTileVisibleFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTileVisibleFunctionTables", Selector = "setTileVisibleFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffer", Selector = "setVertexBuffer:offset:attributeStride:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffers", Selector = "setVertexBuffers:offsets:attributeStrides:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBufferOffset", Selector = "setVertexBufferOffset:attributeStride:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBytes", Selector = "setVertexBytes:length:attributeStride:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreadgroups", Selector = "drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreadgroups", Selector = "drawMeshThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawMeshThreads", Selector = "drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:", ParameterType = new Type [] { typeof (MTLSize), typeof (MTLSize), typeof (MTLSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshBufferOffset", Selector = "setMeshBufferOffset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshBuffers", Selector = "setMeshBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshTexture", Selector = "setMeshTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshTextures", Selector = "setMeshTextures:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshSamplerState", Selector = "setMeshSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshSamplerStates", Selector = "setMeshSamplerStates:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshSamplerState", Selector = "setMeshSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (float), typeof (float), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshSamplerStates", Selector = "setMeshSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectBuffer", Selector = "setObjectBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectBufferOffset", Selector = "setObjectBufferOffset:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectBuffers", Selector = "setObjectBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectBytes", Selector = "setObjectBytes:length:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshBuffer", Selector = "setMeshBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMeshBytes", Selector = "setMeshBytes:length:atIndex:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectSamplerState", Selector = "setObjectSamplerState:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectSamplerState", Selector = "setObjectSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type [] { typeof (IMTLSamplerState), typeof (float), typeof (float), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectSamplerStates", Selector = "setObjectSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectSamplerStates", Selector = "setObjectSamplerStates:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectTexture", Selector = "setObjectTexture:atIndex:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectTextures", Selector = "setObjectTextures:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObjectThreadgroupMemoryLength", Selector = "setObjectThreadgroupMemoryLength:atIndex:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorAttachmentMap", Selector = "setColorAttachmentMap:", ParameterType = new Type [] { typeof (MTLLogicalToPhysicalColorAttachmentMap) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TileWidth", Selector = "tileWidth", PropertyType = typeof (UIntPtr), GetterSelector = "tileWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TileHeight", Selector = "tileHeight", PropertyType = typeof (UIntPtr), GetterSelector = "tileHeight", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLRenderCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTLCommandEncoder
	{
		/// <param name="pipelineState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setRenderPipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRenderPipelineState (IMTLRenderPipelineState pipelineState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pipelineState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRenderPipelineState (IMTLRenderCommandEncoder This, IMTLRenderPipelineState pipelineState)
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
		internal static void _SetVertexBuffer (IMTLRenderCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexTexture (IMTLTexture texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexTexture (IMTLRenderCommandEncoder This, IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexSamplerState (IMTLSamplerState sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState sampler, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexSamplerState (IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="viewport">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setViewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewport (MTLViewport viewport)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewport">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetViewport (IMTLRenderCommandEncoder This, MTLViewport viewport)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLViewport (This.Handle, Selector.GetHandle ("setViewport:"), viewport);
			GC.KeepAlive (This);
		}
		/// <param name="frontFacingWinding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFrontFacingWinding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFrontFacingWinding (MTLWinding frontFacingWinding)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="frontFacingWinding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFrontFacingWinding (IMTLRenderCommandEncoder This, MTLWinding frontFacingWinding)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWinding);
			GC.KeepAlive (This);
		}
		/// <param name="cullMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setCullMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCullMode (MTLCullMode cullMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cullMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCullMode (IMTLRenderCommandEncoder This, MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
			GC.KeepAlive (This);
		}
		/// <summary>Sets a value that controls how clipped values are handled.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setDepthClipMode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthClipMode (MTLDepthClipMode depthClipMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets a value that controls how clipped values are handled.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthClipMode (IMTLRenderCommandEncoder This, MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
			GC.KeepAlive (This);
		}
		/// <param name="depthBias">To be added.</param><param name="slopeScale">To be added.</param><param name="clamp">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setDepthBias:slopeScale:clamp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthBias (float depthBias, float slopeScale, float clamp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="depthBias">To be added.</param><param name="slopeScale">To be added.</param><param name="clamp">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthBias (IMTLRenderCommandEncoder This, float depthBias, float slopeScale, float clamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (This.Handle, Selector.GetHandle ("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthTestMinBound:maxBound:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthTest (float minBound, float maxBound)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthTest (IMTLRenderCommandEncoder This, float minBound, float maxBound)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float (This.Handle, Selector.GetHandle ("setDepthTestMinBound:maxBound:"), minBound, maxBound);
			GC.KeepAlive (This);
		}
		/// <param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setScissorRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScissorRect (MTLScissorRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScissorRect (IMTLRenderCommandEncoder This, MTLScissorRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLScissorRect (This.Handle, Selector.GetHandle ("setScissorRect:"), rect);
			GC.KeepAlive (This);
		}
		/// <param name="fillMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setTriangleFillMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTriangleFillMode (MTLTriangleFillMode fillMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fillMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTriangleFillMode (IMTLRenderCommandEncoder This, MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
			GC.KeepAlive (This);
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
		internal static void _SetFragmentBuffer (IMTLRenderCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentBufferOffset:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentBufferOffset (nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentBufferOffset (IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFragmentBytes:length:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentBytes (nint bytes, nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentBytes (IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentTexture (IMTLTexture texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentTexture (IMTLRenderCommandEncoder This, IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentSamplerState (IMTLSamplerState sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState sampler, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentSamplerState (IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setBlendColorRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBlendColor (float red, float green, float blue, float alpha)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBlendColor (IMTLRenderCommandEncoder This, float red, float green, float blue, float alpha)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float_float (This.Handle, Selector.GetHandle ("setBlendColorRed:green:blue:alpha:"), red, green, blue, alpha);
			GC.KeepAlive (This);
		}
		/// <param name="depthStencilState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setDepthStencilState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStencilState (IMTLDepthStencilState depthStencilState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="depthStencilState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStencilState (IMTLRenderCommandEncoder This, IMTLDepthStencilState depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState!.GetNonNullHandle (nameof (depthStencilState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (depthStencilState);
		}
		/// <param name="referenceValue">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setStencilReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilReferenceValue (uint referenceValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="referenceValue">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilReferenceValue (IMTLRenderCommandEncoder This, uint referenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("setStencilReferenceValue:"), referenceValue);
			GC.KeepAlive (This);
		}
		/// <summary>Sets the front and back reference stencil values.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setStencilFrontReferenceValue:backReferenceValue:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilFrontReferenceValue (uint frontReferenceValue, uint backReferenceValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the front and back reference stencil values.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilFrontReferenceValue (IMTLRenderCommandEncoder This, uint frontReferenceValue, uint backReferenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (This.Handle, Selector.GetHandle ("setStencilFrontReferenceValue:backReferenceValue:"), frontReferenceValue, backReferenceValue);
			GC.KeepAlive (This);
		}
		/// <param name="mode">To be added.</param><param name="offset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVisibilityResultMode:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibilityResultMode (MTLVisibilityResultMode mode, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mode">To be added.</param><param name="offset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibilityResultMode (IMTLRenderCommandEncoder This, MTLVisibilityResultMode mode, nuint offset)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVisibilityResultMode:offset:"), (UIntPtr) (ulong) mode, offset);
			GC.KeepAlive (This);
		}
		/// <summary>Sets a value that controls how color results are handled after a rendering pass.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setColorStoreAction:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorStoreAction (MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets a value that controls how color results are handled after a rendering pass.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorStoreAction (IMTLRenderCommandEncoder This, MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setColorStoreAction:atIndex:"), (UIntPtr) (ulong) storeAction, colorAttachmentIndex);
			GC.KeepAlive (This);
		}
		/// <summary>Sets a value that controls how depth results are handled after a rendering pass.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setDepthStoreAction:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStoreAction (MTLStoreAction storeAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets a value that controls how depth results are handled after a rendering pass.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStoreAction (IMTLRenderCommandEncoder This, MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStoreAction:"), (UIntPtr) (ulong) storeAction);
			GC.KeepAlive (This);
		}
		/// <summary>Sets a value that controls how stencil results are handled after a rendering pass.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setStencilStoreAction:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilStoreAction (MTLStoreAction storeAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets a value that controls how stencil results are handled after a rendering pass.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilStoreAction (IMTLRenderCommandEncoder This, MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setStencilStoreAction:"), (UIntPtr) (ulong) storeAction);
			GC.KeepAlive (This);
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><param name="instanceCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><param name="instanceCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount);
			GC.KeepAlive (This);
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount);
			GC.KeepAlive (This);
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, instanceCount);
			GC.KeepAlive (This);
			GC.KeepAlive (indexBuffer);
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (indexBuffer);
		}
		/// <summary>Draws a range of primitives.</summary>
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Draws a range of primitives.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, instanceCount, baseVertex, baseInstance);
			GC.KeepAlive (This);
			GC.KeepAlive (indexBuffer);
		}
		/// <summary>Draws a range of primitives.</summary>
		[global::Foundation.RequiredMember]
		[Export ("drawPrimitives:indirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPrimitives (MTLPrimitiveType primitiveType, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Draws a range of primitives.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("drawPrimitives:indirectBuffer:indirectBufferOffset:"), (UIntPtr) (ulong) primitiveType, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPrimitives (IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:"), (UIntPtr) (ulong) primitiveType, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (indexBuffer);
			GC.KeepAlive (indirectBuffer);
		}
		/// <param name="buffers">To be added.</param><param name="IntPtrOffsets">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentBuffers (IMTLBuffer buffers, nint IntPtrOffsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffers">To be added.</param><param name="IntPtrOffsets">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentBuffers (IMTLRenderCommandEncoder This, IMTLBuffer buffers, nint IntPtrOffsets, NSRange range)
		{
			var buffers__handle__ = buffers!.GetNonNullHandle (nameof (buffers));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setFragmentBuffers:offsets:withRange:"), buffers__handle__, IntPtrOffsets, range);
			GC.KeepAlive (This);
			GC.KeepAlive (buffers);
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentSamplerStates (IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentSamplerStates (IMTLRenderCommandEncoder This, IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
			GC.KeepAlive (This);
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentSamplerStates (IMTLRenderCommandEncoder This, IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFragmentSamplerStates:withRange:"), nsa_samplers.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setFragmentTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentTextures (IMTLTexture[] textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentTextures (IMTLRenderCommandEncoder This, IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFragmentTextures:withRange:"), nsa_textures.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="buffers">To be added.</param><param name="uintArrayPtrOffsets">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBuffers (IMTLBuffer[] buffers, nint uintArrayPtrOffsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffers">To be added.</param><param name="uintArrayPtrOffsets">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBuffers (IMTLRenderCommandEncoder This, IMTLBuffer[] buffers, nint uintArrayPtrOffsets, NSRange range)
		{
			if (buffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (buffers));
			using var nsa_buffers = NSArray.FromNSObjects (buffers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setVertexBuffers:offsets:withRange:"), nsa_buffers.Handle, uintArrayPtrOffsets, range);
			GC.KeepAlive (This);
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexBufferOffset:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBufferOffset (nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBufferOffset (IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexBytes:length:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBytes (nint bytes, nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBytes (IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexSamplerStates (IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexSamplerStates (IMTLRenderCommandEncoder This, IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
			GC.KeepAlive (This);
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexSamplerStates (IMTLRenderCommandEncoder This, IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVertexSamplerStates:withRange:"), nsa_samplers.Handle, range);
			GC.KeepAlive (This);
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setVertexTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexTextures (IMTLTexture[] textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexTextures (IMTLRenderCommandEncoder This, IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVertexTextures:withRange:"), nsa_textures.Handle, range);
			GC.KeepAlive (This);
		}
		/// <summary>Captures all GPU work up to the current fence.</summary>
		[global::Foundation.RequiredMember]
		[Export ("updateFence:afterStages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (IMTLFence fence, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Captures all GPU work up to the current fence.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLRenderCommandEncoder This, IMTLFence fence, MTLRenderStages stages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("updateFence:afterStages:"), fence__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary>
		[global::Foundation.RequiredMember]
		[Export ("waitForFence:beforeStages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Wait (IMTLFence fence, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Wait (IMTLRenderCommandEncoder This, IMTLFence fence, MTLRenderStages stages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("waitForFence:beforeStages:"), fence__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		/// <summary>Sets the offset and stride value for a tessellation buffer.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setTessellationFactorBuffer:offset:instanceStride:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTessellationFactorBuffer (IMTLBuffer? buffer, nuint offset, nuint instanceStride)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the offset and stride value for a tessellation buffer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTessellationFactorBuffer (IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint instanceStride)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setTessellationFactorBuffer:offset:instanceStride:"), buffer__handle__, offset, instanceStride);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <summary>Sets the offset and stride value for a tessellation buffer.</summary>
		[global::Foundation.RequiredMember]
		[Export ("setTessellationFactorScale:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTessellationFactorScale (float scale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the offset and stride value for a tessellation buffer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTessellationFactorScale (IMTLRenderCommandEncoder This, float scale)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setTessellationFactorScale:"), scale);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPatches (IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, instanceCount, baseInstance);
			GC.KeepAlive (This);
			GC.KeepAlive (patchIndexBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPatches (nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawPatches (IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:"), numberOfPatchControlPoints, patchIndexBuffer__handle__, patchIndexBufferOffset, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (indirectBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPatches (IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var controlPointIndexBuffer__handle__ = controlPointIndexBuffer!.GetNonNullHandle (nameof (controlPointIndexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, controlPointIndexBuffer__handle__, controlPointIndexBufferOffset, instanceCount, baseInstance);
			GC.KeepAlive (This);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (controlPointIndexBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawIndexedPatches (nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawIndexedPatches (IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var controlPointIndexBuffer__handle__ = controlPointIndexBuffer!.GetNonNullHandle (nameof (controlPointIndexBuffer));
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:"), numberOfPatchControlPoints, patchIndexBuffer__handle__, patchIndexBufferOffset, controlPointIndexBuffer__handle__, controlPointIndexBufferOffset, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (controlPointIndexBuffer);
			GC.KeepAlive (indirectBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setViewports:count:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewports (nint viewports, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetViewports (IMTLRenderCommandEncoder This, nint viewports, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setViewports:count:"), viewports, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setScissorRects:count:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScissorRects (nint scissorRects, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScissorRects (IMTLRenderCommandEncoder This, nint scissorRects, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setScissorRects:count:"), scissorRects, count);
			GC.KeepAlive (This);
		}
		/// <summary>Sets the store action options on the color attachment at the specified index.</summary><param name="storeActionOptions">The action options to set.</param><param name="colorAttachmentIndex">The index of the color attachment.</param>
		[global::Foundation.RequiredMember]
		[Export ("setColorStoreActionOptions:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorStoreActionOptions (MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the store action options on the color attachment at the specified index.</summary><param name="storeActionOptions">The action options to set.</param><param name="colorAttachmentIndex">The index of the color attachment.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorStoreActionOptions (IMTLRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setColorStoreActionOptions:atIndex:"), (UIntPtr) (ulong) storeActionOptions, colorAttachmentIndex);
			GC.KeepAlive (This);
		}
		/// <summary>Sets the store action options on the depth attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[global::Foundation.RequiredMember]
		[Export ("setDepthStoreActionOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the store action options on the depth attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStoreActionOptions (IMTLRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
			GC.KeepAlive (This);
		}
		/// <summary>Sets the store action options on the stencil attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[global::Foundation.RequiredMember]
		[Export ("setStencilStoreActionOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the store action options on the stencil attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilStoreActionOptions (IMTLRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setStencilStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
			GC.KeepAlive (This);
		}
		/// <summary>Marks the specified resource as usable by a render pass.</summary><param name="resource">The resource to use.</param><param name="usage">Whether to read, write, or sample the resource.</param>
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
		/// <summary>Marks the specified resource as usable by a render pass.</summary><param name="resource">The resource to use.</param><param name="usage">Whether to read, write, or sample the resource.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResource (IMTLRenderCommandEncoder This, IMTLResource resource, MTLResourceUsage usage)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useResource:usage:"), resource__handle__, (UIntPtr) (ulong) usage);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
		}
		/// <summary>Marks the specified resources as usable by a render pass.</summary><param name="resources">The resources to use.</param><param name="count">The number of resources.</param><param name="usage">Whether to read, write, or sample the resource.</param>
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
		/// <summary>Marks the specified resources as usable by a render pass.</summary><param name="resources">The resources to use.</param><param name="count">The number of resources.</param><param name="usage">Whether to read, write, or sample the resource.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResources (IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResources:count:usage:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage);
			GC.KeepAlive (This);
		}
		/// <summary>Marks the specified heap as usable by a render pass.</summary><param name="heap">The heap from which to read resources that are wrapped in an argument buffer.</param>
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
		/// <summary>Marks the specified heap as usable by a render pass.</summary><param name="heap">The heap from which to read resources that are wrapped in an argument buffer.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeap (IMTLRenderCommandEncoder This, IMTLHeap heap)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useHeap:"), heap__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (heap);
		}
		/// <summary>Marks the specified heaps as usable by a render pass.</summary><param name="heaps">The heaps from which to read resources that are wrapped in an argument buffer.</param><param name="count">The number of heaps.</param>
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
		/// <summary>Marks the specified heaps as usable by a render pass.</summary><param name="heaps">The heaps from which to read resources that are wrapped in an argument buffer.</param><param name="count">The number of heaps.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeaps (IMTLRenderCommandEncoder This, IMTLHeap[] heaps, nuint count)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useHeaps:count:"), nsa_heaps.Handle, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:withRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommands (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommands (IMTLRenderCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:withRange:"), indirectCommandBuffer__handle__, executionRange);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteCommands (IMTLIndirectCommandBuffer indirectCommandbuffer, IMTLBuffer indirectRangeBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExecuteCommands (IMTLRenderCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandbuffer, IMTLBuffer indirectRangeBuffer, nuint indirectBufferOffset)
		{
			var indirectCommandbuffer__handle__ = indirectCommandbuffer!.GetNonNullHandle (nameof (indirectCommandbuffer));
			var indirectRangeBuffer__handle__ = indirectRangeBuffer!.GetNonNullHandle (nameof (indirectRangeBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:"), indirectCommandbuffer__handle__, indirectRangeBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandbuffer);
			GC.KeepAlive (indirectRangeBuffer);
		}
		/// <param name="scope">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("memoryBarrierWithScope:afterStages:beforeStages:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MemoryBarrier (MTLBarrierScope scope, MTLRenderStages after, MTLRenderStages before)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scope">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MemoryBarrier (IMTLRenderCommandEncoder This, MTLBarrierScope scope, MTLRenderStages after, MTLRenderStages before)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("memoryBarrierWithScope:afterStages:beforeStages:"), (UIntPtr) (ulong) scope, (UIntPtr) (ulong) after, (UIntPtr) (ulong) before);
			GC.KeepAlive (This);
		}
		/// <param name="resources">To be added.</param><param name="count">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("memoryBarrierWithResources:count:afterStages:beforeStages:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MemoryBarrier (IMTLResource[] resources, nuint count, MTLRenderStages after, MTLRenderStages before)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="resources">To be added.</param><param name="count">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MemoryBarrier (IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLRenderStages after, MTLRenderStages before)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("memoryBarrierWithResources:count:afterStages:beforeStages:"), nsa_resources.Handle, count, (UIntPtr) (ulong) after, (UIntPtr) (ulong) before);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileBytes:length:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileBytes (nint bytes, nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileBytes (IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setTileBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileBuffer:offset:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileBuffer (IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setTileBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileBufferOffset:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileBufferOffset (nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileBufferOffset (IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setTileBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileBuffers:offsets:withRange:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileBuffers (IMTLBuffer[] buffers, nint offsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileBuffers (IMTLRenderCommandEncoder This, IMTLBuffer[] buffers, nint offsets, NSRange range)
		{
			if (buffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (buffers));
			using var nsa_buffers = NSArray.FromNSObjects (buffers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setTileBuffers:offsets:withRange:"), nsa_buffers.Handle, offsets, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileTexture:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileTexture (IMTLTexture? texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileTexture (IMTLRenderCommandEncoder This, IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileTextures:withRange:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileTextures (IMTLTexture[] textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileTextures (IMTLRenderCommandEncoder This, IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTileTextures:withRange:"), nsa_textures.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileSamplerState:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileSamplerStates:withRange:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileSamplerStates (IMTLRenderCommandEncoder This, IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTileSamplerStates:withRange:"), nsa_samplers.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileSamplerState (IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setTileSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileSamplerStates (IMTLSamplerState[] samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileSamplerStates (IMTLRenderCommandEncoder This, IMTLSamplerState[] samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setTileSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, lodMinClamps, lodMaxClamps, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchThreadsPerTile:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchThreadsPerTile (MTLSize threadsPerTile)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchThreadsPerTile (IMTLRenderCommandEncoder This, MTLSize threadsPerTile)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize (This.Handle, Selector.GetHandle ("dispatchThreadsPerTile:"), threadsPerTile);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setThreadgroupMemoryLength:offset:atIndex:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetThreadgroupMemoryLength (nuint length, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetThreadgroupMemoryLength (IMTLRenderCommandEncoder This, nuint length, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setThreadgroupMemoryLength:offset:atIndex:"), length, offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexAmplificationCount:viewMappings:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexAmplificationCount (nuint count, MTLVertexAmplificationViewMapping viewMappings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexAmplificationCount (IMTLRenderCommandEncoder This, nuint count, MTLVertexAmplificationViewMapping viewMappings)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_MTLVertexAmplificationViewMapping (This.Handle, Selector.GetHandle ("setVertexAmplificationCount:viewMappings:"), count, viewMappings);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResource:usage:stages:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResource (IMTLResource resource, MTLResourceUsage usage, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResource (IMTLRenderCommandEncoder This, IMTLResource resource, MTLResourceUsage usage, MTLRenderStages stages)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResource:usage:stages:"), resource__handle__, (UIntPtr) (ulong) usage, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResources:count:usage:stages:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResources (IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage, MTLRenderStages stages)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResources:count:usage:stages:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("useHeap:stages:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseHeap (IMTLHeap heap, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeap (IMTLRenderCommandEncoder This, IMTLHeap heap, MTLRenderStages stages)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useHeap:stages:"), heap__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
			GC.KeepAlive (heap);
		}
		[global::Foundation.RequiredMember]
		[Export ("useHeaps:count:stages:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseHeaps (IMTLHeap[] heaps, nuint count, MTLRenderStages stages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeaps (IMTLRenderCommandEncoder This, IMTLHeap[] heaps, nuint count, MTLRenderStages stages)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useHeaps:count:stages:"), nsa_heaps.Handle, count, (UIntPtr) (ulong) stages);
			GC.KeepAlive (This);
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
		internal static void _SampleCounters (IMTLRenderCommandEncoder This, IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexVisibleFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexVisibleFunctionTable (IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexVisibleFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexVisibleFunctionTables (IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVertexVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexIntersectionFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexIntersectionFunctionTable (IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexIntersectionFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexIntersectionFunctionTables (IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVertexIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexAccelerationStructure:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexAccelerationStructure (IMTLRenderCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFragmentAccelerationStructure:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentAccelerationStructure (IMTLRenderCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFragmentIntersectionFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentIntersectionFunctionTable (IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFragmentIntersectionFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentIntersectionFunctionTables (IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFragmentIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFragmentVisibleFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentVisibleFunctionTable (IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFragmentVisibleFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFragmentVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFragmentVisibleFunctionTables (IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFragmentVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileAccelerationStructure:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileAccelerationStructure (IMTLRenderCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileIntersectionFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileIntersectionFunctionTable (IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileIntersectionFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileIntersectionFunctionTables (IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTileIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileVisibleFunctionTable:atBufferIndex:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileVisibleFunctionTable (IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTileVisibleFunctionTables:withBufferRange:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTileVisibleFunctionTables (IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTileVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexBuffer:offset:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBuffer (IMTLBuffer? buffer, nuint offset, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBuffer (IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexBuffers:offsets:attributeStrides:withRange:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBuffers (nint buffers, nint offsets, nint strides, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBuffers (IMTLRenderCommandEncoder This, nint buffers, nint offsets, nint strides, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setVertexBuffers:offsets:attributeStrides:withRange:"), buffers, offsets, strides, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexBufferOffset:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBufferOffset (nuint offset, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBufferOffset (IMTLRenderCommandEncoder This, nuint offset, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBufferOffset:attributeStride:atIndex:"), offset, stride, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVertexBytes:length:attributeStride:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVertexBytes (nint bytes, nuint length, nuint stride, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVertexBytes (IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBytes:length:attributeStride:atIndex:"), bytes, length, stride, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreadgroups (IMTLRenderCommandEncoder This, MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreadgroups (IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreadgroups (IMTLRenderCommandEncoder This, IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), indirectBuffer__handle__, indirectBufferOffset, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMeshThreads (MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawMeshThreads (IMTLRenderCommandEncoder This, MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshBufferOffset:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshBufferOffset (nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshBufferOffset (IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshBuffers:offsets:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshBuffers (nint buffers, nint offsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshBuffers (IMTLRenderCommandEncoder This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshTexture:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshTexture (IMTLTexture? texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshTexture (IMTLRenderCommandEncoder This, IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setMeshTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshTextures:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshTextures (nint textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshTextures (IMTLRenderCommandEncoder This, nint textures, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshTextures:withRange:"), textures, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshSamplerState:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setMeshSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshSamplerStates:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshSamplerStates (nint samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshSamplerStates (IMTLRenderCommandEncoder This, nint samplers, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshSamplerStates:withRange:"), samplers, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshSamplerState (IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setMeshSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshSamplerStates (nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshSamplerStates (IMTLRenderCommandEncoder This, nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), samplers, lodMinClamps, lodMaxClamps, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectBuffer:offset:atIndex:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectBuffer (IMTLRenderCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectBufferOffset:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectBufferOffset (nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectBufferOffset (IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectBuffers:offsets:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectBuffers (nint buffers, nint offsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectBuffers (IMTLRenderCommandEncoder This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectBytes:length:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectBytes (nint bytes, nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectBytes (IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshBuffer:offset:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshBuffer (IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMeshBytes:length:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMeshBytes (nint bytes, nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMeshBytes (IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectSamplerState:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setObjectSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectSamplerState (IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectSamplerState (IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setObjectSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectSamplerStates (nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectSamplerStates (IMTLRenderCommandEncoder This, nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), samplers, lodMinClamps, lodMaxClamps, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectSamplerStates:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectSamplerStates (nint samplers, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectSamplerStates (IMTLRenderCommandEncoder This, nint samplers, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectSamplerStates:withRange:"), samplers, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectTexture:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectTexture (IMTLTexture? texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectTexture (IMTLRenderCommandEncoder This, IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setObjectTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectTextures:withRange:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectTextures (nint textures, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectTextures (IMTLRenderCommandEncoder This, nint textures, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectTextures:withRange:"), textures, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setObjectThreadgroupMemoryLength:atIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectThreadgroupMemoryLength (nuint length, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectThreadgroupMemoryLength (IMTLRenderCommandEncoder This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setColorAttachmentMap:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorAttachmentMap (MTLLogicalToPhysicalColorAttachmentMap? mapping)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorAttachmentMap (IMTLRenderCommandEncoder This, MTLLogicalToPhysicalColorAttachmentMap? mapping)
		{
			var mapping__handle__ = mapping.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColorAttachmentMap:"), mapping__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapping);
		}
		[DynamicDependencyAttribute ("DispatchThreadsPerTile(Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawIndexedPatches(System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPatches(System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,Metal.MTLIndexType,Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawIndexedPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,Metal.MTLIndexType,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawMeshThreadgroups(Metal.IMTLBuffer,System.UIntPtr,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawMeshThreadgroups(Metal.MTLSize,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawMeshThreads(Metal.MTLSize,Metal.MTLSize,Metal.MTLSize)")]
		[DynamicDependencyAttribute ("DrawPatches(System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPatches(System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawPrimitives(Metal.MTLPrimitiveType,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ExecuteCommands(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ExecuteCommands(Metal.IMTLIndirectCommandBuffer,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("MemoryBarrier(Metal.IMTLResource[],System.UIntPtr,Metal.MTLRenderStages,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("MemoryBarrier(Metal.MTLBarrierScope,Metal.MTLRenderStages,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("SampleCounters(Metal.IMTLCounterSampleBuffer,System.UIntPtr,System.Boolean)")]
		[DynamicDependencyAttribute ("SetBlendColor(System.Single,System.Single,System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetColorAttachmentMap(Metal.MTLLogicalToPhysicalColorAttachmentMap)")]
		[DynamicDependencyAttribute ("SetColorStoreAction(Metal.MTLStoreAction,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetColorStoreActionOptions(Metal.MTLStoreActionOptions,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetCullMode(Metal.MTLCullMode)")]
		[DynamicDependencyAttribute ("SetDepthBias(System.Single,System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetDepthClipMode(Metal.MTLDepthClipMode)")]
		[DynamicDependencyAttribute ("SetDepthStencilState(Metal.IMTLDepthStencilState)")]
		[DynamicDependencyAttribute ("SetDepthStoreAction(Metal.MTLStoreAction)")]
		[DynamicDependencyAttribute ("SetDepthStoreActionOptions(Metal.MTLStoreActionOptions)")]
		[DynamicDependencyAttribute ("SetDepthTest(System.Single,System.Single)")]
		[DynamicDependencyAttribute ("SetFragmentAccelerationStructure(Metal.IMTLAccelerationStructure,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentBufferOffset(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentBuffers(Metal.IMTLBuffer,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFragmentBytes(System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentIntersectionFunctionTable(Metal.IMTLIntersectionFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentIntersectionFunctionTables(Metal.IMTLIntersectionFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFragmentSamplerState(Metal.IMTLSamplerState,System.Single,System.Single,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentSamplerStates(Metal.IMTLSamplerState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFragmentSamplerStates(Metal.IMTLSamplerState[],System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFragmentTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentTextures(Metal.IMTLTexture[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFragmentVisibleFunctionTable(Metal.IMTLVisibleFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFragmentVisibleFunctionTables(Metal.IMTLVisibleFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFrontFacingWinding(Metal.MTLWinding)")]
		[DynamicDependencyAttribute ("SetMeshBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetMeshBufferOffset(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetMeshBuffers(System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetMeshBytes(System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetMeshSamplerState(Metal.IMTLSamplerState,System.Single,System.Single,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetMeshSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetMeshSamplerStates(System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetMeshSamplerStates(System.IntPtr,System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetMeshTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetMeshTextures(System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetObjectBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectBufferOffset(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectBuffers(System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetObjectBytes(System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectSamplerState(Metal.IMTLSamplerState,System.Single,System.Single,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectSamplerStates(System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetObjectSamplerStates(System.IntPtr,System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetObjectTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetObjectTextures(System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetObjectThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetRenderPipelineState(Metal.IMTLRenderPipelineState)")]
		[DynamicDependencyAttribute ("SetScissorRect(Metal.MTLScissorRect)")]
		[DynamicDependencyAttribute ("SetScissorRects(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetStencilFrontReferenceValue(System.UInt32,System.UInt32)")]
		[DynamicDependencyAttribute ("SetStencilReferenceValue(System.UInt32)")]
		[DynamicDependencyAttribute ("SetStencilStoreAction(Metal.MTLStoreAction)")]
		[DynamicDependencyAttribute ("SetStencilStoreActionOptions(Metal.MTLStoreActionOptions)")]
		[DynamicDependencyAttribute ("SetTessellationFactorBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTessellationFactorScale(System.Single)")]
		[DynamicDependencyAttribute ("SetThreadgroupMemoryLength(System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileAccelerationStructure(Metal.IMTLAccelerationStructure,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileBufferOffset(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileBuffers(Metal.IMTLBuffer[],System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTileBytes(System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileIntersectionFunctionTable(Metal.IMTLIntersectionFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileIntersectionFunctionTables(Metal.IMTLIntersectionFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTileSamplerState(Metal.IMTLSamplerState,System.Single,System.Single,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileSamplerStates(Metal.IMTLSamplerState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTileSamplerStates(Metal.IMTLSamplerState[],System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTileTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileTextures(Metal.IMTLTexture[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTileVisibleFunctionTable(Metal.IMTLVisibleFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTileVisibleFunctionTables(Metal.IMTLVisibleFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetTriangleFillMode(Metal.MTLTriangleFillMode)")]
		[DynamicDependencyAttribute ("SetVertexAccelerationStructure(Metal.IMTLAccelerationStructure,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexAmplificationCount(System.UIntPtr,Metal.MTLVertexAmplificationViewMapping)")]
		[DynamicDependencyAttribute ("SetVertexBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexBufferOffset(System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexBufferOffset(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexBuffers(Metal.IMTLBuffer[],System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVertexBuffers(System.IntPtr,System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVertexBytes(System.IntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexBytes(System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexIntersectionFunctionTable(Metal.IMTLIntersectionFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexIntersectionFunctionTables(Metal.IMTLIntersectionFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVertexSamplerState(Metal.IMTLSamplerState,System.Single,System.Single,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexSamplerState(Metal.IMTLSamplerState,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexSamplerStates(Metal.IMTLSamplerState[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVertexSamplerStates(Metal.IMTLSamplerState[],System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVertexTexture(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexTextures(Metal.IMTLTexture[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetVertexVisibleFunctionTable(Metal.IMTLVisibleFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVertexVisibleFunctionTables(Metal.IMTLVisibleFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetViewport(Metal.MTLViewport)")]
		[DynamicDependencyAttribute ("SetViewports(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibilityResultMode(Metal.MTLVisibilityResultMode,System.UIntPtr)")]
		[DynamicDependencyAttribute ("TileHeight")]
		[DynamicDependencyAttribute ("TileWidth")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLFence,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("UseHeap(Metal.IMTLHeap,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("UseHeap(Metal.IMTLHeap)")]
		[DynamicDependencyAttribute ("UseHeaps(Metal.IMTLHeap[],System.UIntPtr,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("UseHeaps(Metal.IMTLHeap[],System.UIntPtr)")]
		[DynamicDependencyAttribute ("UseResource(Metal.IMTLResource,Metal.MTLResourceUsage,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("UseResource(Metal.IMTLResource,Metal.MTLResourceUsage)")]
		[DynamicDependencyAttribute ("UseResources(Metal.IMTLResource[],System.UIntPtr,Metal.MTLResourceUsage,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("UseResources(Metal.IMTLResource[],System.UIntPtr,Metal.MTLResourceUsage)")]
		[DynamicDependencyAttribute ("Wait(Metal.IMTLFence,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLRenderCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLRenderCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint TileWidth {
			[Export ("tileWidth")]
			get {
				return _GetTileWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetTileWidth (IMTLRenderCommandEncoder This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tileWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint TileHeight {
			[Export ("tileHeight")]
			get {
				return _GetTileHeight (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetTileHeight (IMTLRenderCommandEncoder This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tileHeight"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLRenderCommandEncoder" /> interface to support all the methods from the MTLRenderCommandEncoder protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLRenderCommandEncoder" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLRenderCommandEncoder protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLRenderCommandEncoder_Extensions {
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDepthTest (this IMTLRenderCommandEncoder This, float minBound, float maxBound)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float (This.Handle, Selector.GetHandle ("setDepthTestMinBound:maxBound:"), minBound, maxBound);
			GC.KeepAlive (This);
		}
		/// <param name="scope">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MemoryBarrier (this IMTLRenderCommandEncoder This, MTLBarrierScope scope, MTLRenderStages after, MTLRenderStages before)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("memoryBarrierWithScope:afterStages:beforeStages:"), (UIntPtr) (ulong) scope, (UIntPtr) (ulong) after, (UIntPtr) (ulong) before);
			GC.KeepAlive (This);
		}
		/// <param name="resources">To be added.</param><param name="count">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MemoryBarrier (this IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLRenderStages after, MTLRenderStages before)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("memoryBarrierWithResources:count:afterStages:beforeStages:"), nsa_resources.Handle, count, (UIntPtr) (ulong) after, (UIntPtr) (ulong) before);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexAmplificationCount (this IMTLRenderCommandEncoder This, nuint count, MTLVertexAmplificationViewMapping viewMappings)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_MTLVertexAmplificationViewMapping (This.Handle, Selector.GetHandle ("setVertexAmplificationCount:viewMappings:"), count, viewMappings);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexVisibleFunctionTable (this IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexVisibleFunctionTables (this IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVertexVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexIntersectionFunctionTable (this IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexIntersectionFunctionTables (this IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVertexIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexAccelerationStructure (this IMTLRenderCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVertexAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFragmentAccelerationStructure (this IMTLRenderCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFragmentIntersectionFunctionTable (this IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFragmentIntersectionFunctionTables (this IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFragmentIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFragmentVisibleFunctionTable (this IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFragmentVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFragmentVisibleFunctionTables (this IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFragmentVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTileAccelerationStructure (this IMTLRenderCommandEncoder This, IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTileIntersectionFunctionTable (this IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTileIntersectionFunctionTables (this IMTLRenderCommandEncoder This, IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTileIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTileVisibleFunctionTable (this IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTileVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTileVisibleFunctionTables (this IMTLRenderCommandEncoder This, IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setTileVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexBuffer (this IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexBuffers (this IMTLRenderCommandEncoder This, nint buffers, nint offsets, nint strides, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setVertexBuffers:offsets:attributeStrides:withRange:"), buffers, offsets, strides, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexBufferOffset (this IMTLRenderCommandEncoder This, nuint offset, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBufferOffset:attributeStride:atIndex:"), offset, stride, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetVertexBytes (this IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setVertexBytes:length:attributeStride:atIndex:"), bytes, length, stride, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawMeshThreadgroups (this IMTLRenderCommandEncoder This, MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawMeshThreadgroups (this IMTLRenderCommandEncoder This, IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), indirectBuffer__handle__, indirectBufferOffset, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectBuffer);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawMeshThreads (this IMTLRenderCommandEncoder This, MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (This.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshBufferOffset (this IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshBuffers (this IMTLRenderCommandEncoder This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshTexture (this IMTLRenderCommandEncoder This, IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setMeshTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshTextures (this IMTLRenderCommandEncoder This, nint textures, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshTextures:withRange:"), textures, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshSamplerState (this IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setMeshSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshSamplerStates (this IMTLRenderCommandEncoder This, nint samplers, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshSamplerStates:withRange:"), samplers, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshSamplerState (this IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setMeshSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshSamplerStates (this IMTLRenderCommandEncoder This, nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setMeshSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), samplers, lodMinClamps, lodMaxClamps, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectBuffer (this IMTLRenderCommandEncoder This, IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectBufferOffset (this IMTLRenderCommandEncoder This, nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBufferOffset:atIndex:"), offset, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectBuffers (this IMTLRenderCommandEncoder This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectBytes (this IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshBuffer (this IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMeshBytes (this IMTLRenderCommandEncoder This, nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setMeshBytes:length:atIndex:"), bytes, length, index);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectSamplerState (this IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setObjectSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectSamplerState (this IMTLRenderCommandEncoder This, IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (This.Handle, Selector.GetHandle ("setObjectSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (This);
			GC.KeepAlive (sampler);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectSamplerStates (this IMTLRenderCommandEncoder This, nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), samplers, lodMinClamps, lodMaxClamps, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectSamplerStates (this IMTLRenderCommandEncoder This, nint samplers, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectSamplerStates:withRange:"), samplers, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectTexture (this IMTLRenderCommandEncoder This, IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setObjectTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectTextures (this IMTLRenderCommandEncoder This, nint textures, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setObjectTextures:withRange:"), textures, range);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectThreadgroupMemoryLength (this IMTLRenderCommandEncoder This, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLRenderCommandEncoderWrapper : BaseWrapper, IMTLRenderCommandEncoder {
		public MTLRenderCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLRenderCommandEncoderWrapper))]
		static MTLRenderCommandEncoderWrapper ()
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
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexTexture (IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVertexTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexSamplerState (IMTLSamplerState sampler, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVertexSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexSamplerState (IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (this.Handle, Selector.GetHandle ("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="viewport">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setViewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetViewport (MTLViewport viewport)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLViewport (this.Handle, Selector.GetHandle ("setViewport:"), viewport);
		}
		/// <param name="frontFacingWinding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFrontFacingWinding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFrontFacingWinding (MTLWinding frontFacingWinding)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setFrontFacingWinding:"), (UIntPtr) (ulong) frontFacingWinding);
		}
		/// <param name="cullMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setCullMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetCullMode (MTLCullMode cullMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setCullMode:"), (UIntPtr) (ulong) cullMode);
		}
		/// <summary>Sets a value that controls how clipped values are handled.</summary>
		[Export ("setDepthClipMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthClipMode (MTLDepthClipMode depthClipMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthClipMode:"), (UIntPtr) (ulong) depthClipMode);
		}
		/// <param name="depthBias">To be added.</param><param name="slopeScale">To be added.</param><param name="clamp">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
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
		/// <param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setScissorRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetScissorRect (MTLScissorRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLScissorRect (this.Handle, Selector.GetHandle ("setScissorRect:"), rect);
		}
		/// <param name="fillMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setTriangleFillMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTriangleFillMode (MTLTriangleFillMode fillMode)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setTriangleFillMode:"), (UIntPtr) (ulong) fillMode);
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
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentBufferOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentBufferOffset (nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentBufferOffset:atIndex:"), offset, index);
		}
		[Export ("setFragmentBytes:length:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentBytes (nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentBytes:length:atIndex:"), bytes, length, index);
		}
		/// <param name="texture">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentTexture (IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		/// <param name="sampler">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentSamplerState (IMTLSamplerState sampler, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="sampler">To be added.</param><param name="lodMinClamp">To be added.</param><param name="lodMaxClamp">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentSamplerState (IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler!.GetNonNullHandle (nameof (sampler));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (sampler);
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setBlendColorRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBlendColor (float red, float green, float blue, float alpha)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float_float (this.Handle, Selector.GetHandle ("setBlendColorRed:green:blue:alpha:"), red, green, blue, alpha);
		}
		/// <param name="depthStencilState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setDepthStencilState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStencilState (IMTLDepthStencilState depthStencilState)
		{
			var depthStencilState__handle__ = depthStencilState!.GetNonNullHandle (nameof (depthStencilState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDepthStencilState:"), depthStencilState__handle__);
			GC.KeepAlive (depthStencilState);
		}
		/// <param name="referenceValue">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setStencilReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilReferenceValue (uint referenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setStencilReferenceValue:"), referenceValue);
		}
		/// <summary>Sets the front and back reference stencil values.</summary>
		[Export ("setStencilFrontReferenceValue:backReferenceValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilFrontReferenceValue (uint frontReferenceValue, uint backReferenceValue)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("setStencilFrontReferenceValue:backReferenceValue:"), frontReferenceValue, backReferenceValue);
		}
		/// <param name="mode">To be added.</param><param name="offset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVisibilityResultMode:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibilityResultMode (MTLVisibilityResultMode mode, nuint offset)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVisibilityResultMode:offset:"), (UIntPtr) (ulong) mode, offset);
		}
		/// <summary>Sets a value that controls how color results are handled after a rendering pass.</summary>
		[Export ("setColorStoreAction:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorStoreAction (MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setColorStoreAction:atIndex:"), (UIntPtr) (ulong) storeAction, colorAttachmentIndex);
		}
		/// <summary>Sets a value that controls how depth results are handled after a rendering pass.</summary>
		[Export ("setDepthStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStoreAction (MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthStoreAction:"), (UIntPtr) (ulong) storeAction);
		}
		/// <summary>Sets a value that controls how stencil results are handled after a rendering pass.</summary>
		[Export ("setStencilStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilStoreAction (MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setStencilStoreAction:"), (UIntPtr) (ulong) storeAction);
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><param name="instanceCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount);
		}
		/// <param name="primitiveType">To be added.</param><param name="vertexStart">To be added.</param><param name="vertexCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPrimitives:vertexStart:vertexCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount);
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><param name="instanceCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, instanceCount);
			GC.KeepAlive (indexBuffer);
		}
		/// <param name="primitiveType">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexBufferOffset">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset);
			GC.KeepAlive (indexBuffer);
		}
		/// <summary>Draws a range of primitives.</summary>
		[Export ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (UIntPtr) (ulong) primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
		}
		[Export ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:"), (UIntPtr) (ulong) primitiveType, indexCount, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, instanceCount, baseVertex, baseInstance);
			GC.KeepAlive (indexBuffer);
		}
		/// <summary>Draws a range of primitives.</summary>
		[Export ("drawPrimitives:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPrimitives (MTLPrimitiveType primitiveType, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("drawPrimitives:indirectBuffer:indirectBufferOffset:"), (UIntPtr) (ulong) primitiveType, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (indirectBuffer);
		}
		[Export ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPrimitives (MTLPrimitiveType primitiveType, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:"), (UIntPtr) (ulong) primitiveType, (UIntPtr) (ulong) indexType, indexBuffer__handle__, indexBufferOffset, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (indexBuffer);
			GC.KeepAlive (indirectBuffer);
		}
		/// <param name="buffers">To be added.</param><param name="IntPtrOffsets">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentBuffers (IMTLBuffer buffers, nint IntPtrOffsets, NSRange range)
		{
			var buffers__handle__ = buffers!.GetNonNullHandle (nameof (buffers));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setFragmentBuffers:offsets:withRange:"), buffers__handle__, IntPtrOffsets, range);
			GC.KeepAlive (buffers);
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentSamplerStates (IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setFragmentSamplerStates:withRange:"), nsa_samplers.Handle, range);
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setFragmentTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentTextures (IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setFragmentTextures:withRange:"), nsa_textures.Handle, range);
		}
		/// <param name="buffers">To be added.</param><param name="uintArrayPtrOffsets">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBuffers (IMTLBuffer[] buffers, nint uintArrayPtrOffsets, NSRange range)
		{
			if (buffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (buffers));
			using var nsa_buffers = NSArray.FromNSObjects (buffers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setVertexBuffers:offsets:withRange:"), nsa_buffers.Handle, uintArrayPtrOffsets, range);
		}
		/// <param name="offset">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexBufferOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBufferOffset (nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBufferOffset:atIndex:"), offset, index);
		}
		[Export ("setVertexBytes:length:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBytes (nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBytes:length:atIndex:"), bytes, length, index);
		}
		/// <param name="samplers">To be added.</param><param name="floatArrayPtrLodMinClamps">To be added.</param><param name="floatArrayPtrLodMaxClamps">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexSamplerStates (IMTLSamplerState[] samplers, nint floatArrayPtrLodMinClamps, nint floatArrayPtrLodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
		}
		/// <param name="samplers">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVertexSamplerStates:withRange:"), nsa_samplers.Handle, range);
		}
		/// <param name="textures">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVertexTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexTextures (IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVertexTextures:withRange:"), nsa_textures.Handle, range);
		}
		/// <summary>Captures all GPU work up to the current fence.</summary>
		[Export ("updateFence:afterStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLFence fence, MTLRenderStages stages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("updateFence:afterStages:"), fence__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (fence);
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary>
		[Export ("waitForFence:beforeStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Wait (IMTLFence fence, MTLRenderStages stages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("waitForFence:beforeStages:"), fence__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (fence);
		}
		/// <summary>Sets the offset and stride value for a tessellation buffer.</summary>
		[Export ("setTessellationFactorBuffer:offset:instanceStride:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTessellationFactorBuffer (IMTLBuffer? buffer, nuint offset, nuint instanceStride)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTessellationFactorBuffer:offset:instanceStride:"), buffer__handle__, offset, instanceStride);
			GC.KeepAlive (buffer);
		}
		/// <summary>Sets the offset and stride value for a tessellation buffer.</summary>
		[Export ("setTessellationFactorScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTessellationFactorScale (float scale)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setTessellationFactorScale:"), scale);
		}
		[Export ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, instanceCount, baseInstance);
			GC.KeepAlive (patchIndexBuffer);
		}
		[Export ("drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawPatches (nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:"), numberOfPatchControlPoints, patchIndexBuffer__handle__, patchIndexBufferOffset, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (indirectBuffer);
		}
		[Export ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPatches (nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var controlPointIndexBuffer__handle__ = controlPointIndexBuffer!.GetNonNullHandle (nameof (controlPointIndexBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer__handle__, patchIndexBufferOffset, controlPointIndexBuffer__handle__, controlPointIndexBufferOffset, instanceCount, baseInstance);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (controlPointIndexBuffer);
		}
		[Export ("drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawIndexedPatches (nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var patchIndexBuffer__handle__ = patchIndexBuffer.GetHandle ();
			var controlPointIndexBuffer__handle__ = controlPointIndexBuffer!.GetNonNullHandle (nameof (controlPointIndexBuffer));
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:"), numberOfPatchControlPoints, patchIndexBuffer__handle__, patchIndexBufferOffset, controlPointIndexBuffer__handle__, controlPointIndexBufferOffset, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (patchIndexBuffer);
			GC.KeepAlive (controlPointIndexBuffer);
			GC.KeepAlive (indirectBuffer);
		}
		[Export ("setViewports:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetViewports (nint viewports, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setViewports:count:"), viewports, count);
		}
		[Export ("setScissorRects:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetScissorRects (nint scissorRects, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setScissorRects:count:"), scissorRects, count);
		}
		/// <summary>Sets the store action options on the color attachment at the specified index.</summary><param name="storeActionOptions">The action options to set.</param><param name="colorAttachmentIndex">The index of the color attachment.</param>
		[Export ("setColorStoreActionOptions:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorStoreActionOptions (MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setColorStoreActionOptions:atIndex:"), (UIntPtr) (ulong) storeActionOptions, colorAttachmentIndex);
		}
		/// <summary>Sets the store action options on the depth attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[Export ("setDepthStoreActionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
		}
		/// <summary>Sets the store action options on the stencil attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[Export ("setStencilStoreActionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setStencilStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
		}
		/// <summary>Marks the specified resource as usable by a render pass.</summary><param name="resource">The resource to use.</param><param name="usage">Whether to read, write, or sample the resource.</param>
		[Export ("useResource:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResource (IMTLResource resource, MTLResourceUsage usage)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useResource:usage:"), resource__handle__, (UIntPtr) (ulong) usage);
			GC.KeepAlive (resource);
		}
		/// <summary>Marks the specified resources as usable by a render pass.</summary><param name="resources">The resources to use.</param><param name="count">The number of resources.</param><param name="usage">Whether to read, write, or sample the resource.</param>
		[Export ("useResources:count:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResources:count:usage:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage);
		}
		/// <summary>Marks the specified heap as usable by a render pass.</summary><param name="heap">The heap from which to read resources that are wrapped in an argument buffer.</param>
		[Export ("useHeap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeap (IMTLHeap heap)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("useHeap:"), heap__handle__);
			GC.KeepAlive (heap);
		}
		/// <summary>Marks the specified heaps as usable by a render pass.</summary><param name="heaps">The heaps from which to read resources that are wrapped in an argument buffer.</param><param name="count">The number of heaps.</param>
		[Export ("useHeaps:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeaps (IMTLHeap[] heaps, nuint count)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useHeaps:count:"), nsa_heaps.Handle, count);
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
		/// <param name="scope">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("memoryBarrierWithScope:afterStages:beforeStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MemoryBarrier (MTLBarrierScope scope, MTLRenderStages after, MTLRenderStages before)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("memoryBarrierWithScope:afterStages:beforeStages:"), (UIntPtr) (ulong) scope, (UIntPtr) (ulong) after, (UIntPtr) (ulong) before);
		}
		/// <param name="resources">To be added.</param><param name="count">To be added.</param><param name="after">To be added.</param><param name="before">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("memoryBarrierWithResources:count:afterStages:beforeStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MemoryBarrier (IMTLResource[] resources, nuint count, MTLRenderStages after, MTLRenderStages before)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("memoryBarrierWithResources:count:afterStages:beforeStages:"), nsa_resources.Handle, count, (UIntPtr) (ulong) after, (UIntPtr) (ulong) before);
		}
		[Export ("setTileBytes:length:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileBytes (nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTileBytes:length:atIndex:"), bytes, length, index);
		}
		[Export ("setTileBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTileBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setTileBufferOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileBufferOffset (nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTileBufferOffset:atIndex:"), offset, index);
		}
		[Export ("setTileBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileBuffers (IMTLBuffer[] buffers, nint offsets, NSRange range)
		{
			if (buffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (buffers));
			using var nsa_buffers = NSArray.FromNSObjects (buffers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setTileBuffers:offsets:withRange:"), nsa_buffers.Handle, offsets, range);
		}
		[Export ("setTileTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileTexture (IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTileTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		[Export ("setTileTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileTextures (IMTLTexture[] textures, NSRange range)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTileTextures:withRange:"), nsa_textures.Handle, range);
		}
		[Export ("setTileSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTileSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		[Export ("setTileSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileSamplerStates (IMTLSamplerState[] samplers, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTileSamplerStates:withRange:"), nsa_samplers.Handle, range);
		}
		[Export ("setTileSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileSamplerState (IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (this.Handle, Selector.GetHandle ("setTileSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (sampler);
		}
		[Export ("setTileSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileSamplerStates (IMTLSamplerState[] samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			if (samplers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samplers));
			using var nsa_samplers = NSArray.FromNSObjects (samplers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setTileSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nsa_samplers.Handle, lodMinClamps, lodMaxClamps, range);
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
		[Export ("setVertexAmplificationCount:viewMappings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexAmplificationCount (nuint count, MTLVertexAmplificationViewMapping viewMappings)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_MTLVertexAmplificationViewMapping (this.Handle, Selector.GetHandle ("setVertexAmplificationCount:viewMappings:"), count, viewMappings);
		}
		[Export ("useResource:usage:stages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResource (IMTLResource resource, MTLResourceUsage usage, MTLRenderStages stages)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResource:usage:stages:"), resource__handle__, (UIntPtr) (ulong) usage, (UIntPtr) (ulong) stages);
			GC.KeepAlive (resource);
		}
		[Export ("useResources:count:usage:stages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage, MTLRenderStages stages)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResources:count:usage:stages:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage, (UIntPtr) (ulong) stages);
		}
		[Export ("useHeap:stages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeap (IMTLHeap heap, MTLRenderStages stages)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useHeap:stages:"), heap__handle__, (UIntPtr) (ulong) stages);
			GC.KeepAlive (heap);
		}
		[Export ("useHeaps:count:stages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeaps (IMTLHeap[] heaps, nuint count, MTLRenderStages stages)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useHeaps:count:stages:"), nsa_heaps.Handle, count, (UIntPtr) (ulong) stages);
		}
		[Export ("sampleCountersInBuffer:atSampleIndex:withBarrier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SampleCounters (IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (sampleBuffer);
		}
		[Export ("setVertexVisibleFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVertexVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (functionTable);
		}
		[Export ("setVertexVisibleFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVertexVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
		}
		[Export ("setVertexIntersectionFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVertexIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[Export ("setVertexIntersectionFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVertexIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
		}
		[Export ("setVertexAccelerationStructure:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVertexAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (accelerationStructure);
		}
		[Export ("setFragmentAccelerationStructure:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (accelerationStructure);
		}
		[Export ("setFragmentIntersectionFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[Export ("setFragmentIntersectionFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setFragmentIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
		}
		[Export ("setFragmentVisibleFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setFragmentVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (functionTable);
		}
		[Export ("setFragmentVisibleFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFragmentVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setFragmentVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
		}
		[Export ("setTileAccelerationStructure:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileAccelerationStructure (IMTLAccelerationStructure? accelerationStructure, nuint bufferIndex)
		{
			var accelerationStructure__handle__ = accelerationStructure.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTileAccelerationStructure:atBufferIndex:"), accelerationStructure__handle__, bufferIndex);
			GC.KeepAlive (accelerationStructure);
		}
		[Export ("setTileIntersectionFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileIntersectionFunctionTable (IMTLIntersectionFunctionTable? intersectionFunctionTable, nuint bufferIndex)
		{
			var intersectionFunctionTable__handle__ = intersectionFunctionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTileIntersectionFunctionTable:atBufferIndex:"), intersectionFunctionTable__handle__, bufferIndex);
			GC.KeepAlive (intersectionFunctionTable);
		}
		[Export ("setTileIntersectionFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileIntersectionFunctionTables (IMTLIntersectionFunctionTable[] intersectionFunctionTable, NSRange range)
		{
			if (intersectionFunctionTable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intersectionFunctionTable));
			using var nsa_intersectionFunctionTable = NSArray.FromNSObjects (intersectionFunctionTable);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTileIntersectionFunctionTables:withBufferRange:"), nsa_intersectionFunctionTable.Handle, range);
		}
		[Export ("setTileVisibleFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTileVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (functionTable);
		}
		[Export ("setTileVisibleFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTileVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange range)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTileVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, range);
		}
		[Export ("setVertexBuffer:offset:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBuffer (IMTLBuffer? buffer, nuint offset, nuint stride, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBuffer:offset:attributeStride:atIndex:"), buffer__handle__, offset, stride, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setVertexBuffers:offsets:attributeStrides:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBuffers (nint buffers, nint offsets, nint strides, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setVertexBuffers:offsets:attributeStrides:withRange:"), buffers, offsets, strides, range);
		}
		[Export ("setVertexBufferOffset:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBufferOffset (nuint offset, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBufferOffset:attributeStride:atIndex:"), offset, stride, index);
		}
		[Export ("setVertexBytes:length:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVertexBytes (nint bytes, nuint length, nuint stride, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setVertexBytes:length:attributeStride:atIndex:"), bytes, length, stride, index);
		}
		[Export ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawMeshThreadgroups (MTLSize threadgroupsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
		}
		[Export ("drawMeshThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawMeshThreadgroups (IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("drawMeshThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), indirectBuffer__handle__, indirectBufferOffset, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
			GC.KeepAlive (indirectBuffer);
		}
		[Export ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawMeshThreads (MTLSize threadsPerGrid, MTLSize threadsPerObjectThreadgroup, MTLSize threadsPerMeshThreadgroup)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize_MTLSize_MTLSize (this.Handle, Selector.GetHandle ("drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:"), threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
		}
		[Export ("setMeshBufferOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshBufferOffset (nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setMeshBufferOffset:atIndex:"), offset, index);
		}
		[Export ("setMeshBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshBuffers (nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setMeshBuffers:offsets:withRange:"), buffers, offsets, range);
		}
		[Export ("setMeshTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshTexture (IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setMeshTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		[Export ("setMeshTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshTextures (nint textures, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setMeshTextures:withRange:"), textures, range);
		}
		[Export ("setMeshSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setMeshSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		[Export ("setMeshSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshSamplerStates (nint samplers, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setMeshSamplerStates:withRange:"), samplers, range);
		}
		[Export ("setMeshSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshSamplerState (IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (this.Handle, Selector.GetHandle ("setMeshSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (sampler);
		}
		[Export ("setMeshSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshSamplerStates (nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setMeshSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), samplers, lodMinClamps, lodMaxClamps, range);
		}
		[Export ("setObjectBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectBuffer (IMTLBuffer buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setObjectBufferOffset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectBufferOffset (nuint offset, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectBufferOffset:atIndex:"), offset, index);
		}
		[Export ("setObjectBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectBuffers (nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setObjectBuffers:offsets:withRange:"), buffers, offsets, range);
		}
		[Export ("setObjectBytes:length:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectBytes (nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectBytes:length:atIndex:"), bytes, length, index);
		}
		[Export ("setMeshBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setMeshBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setMeshBytes:length:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMeshBytes (nint bytes, nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setMeshBytes:length:atIndex:"), bytes, length, index);
		}
		[Export ("setObjectSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectSamplerState (IMTLSamplerState? sampler, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setObjectSamplerState:atIndex:"), sampler__handle__, index);
			GC.KeepAlive (sampler);
		}
		[Export ("setObjectSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectSamplerState (IMTLSamplerState? sampler, float lodMinClamp, float lodMaxClamp, nuint index)
		{
			var sampler__handle__ = sampler.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float_float_UIntPtr (this.Handle, Selector.GetHandle ("setObjectSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler__handle__, lodMinClamp, lodMaxClamp, index);
			GC.KeepAlive (sampler);
		}
		[Export ("setObjectSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectSamplerStates (nint samplers, nint lodMinClamps, nint lodMaxClamps, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setObjectSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), samplers, lodMinClamps, lodMaxClamps, range);
		}
		[Export ("setObjectSamplerStates:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectSamplerStates (nint samplers, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setObjectSamplerStates:withRange:"), samplers, range);
		}
		[Export ("setObjectTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectTexture (IMTLTexture? texture, nuint index)
		{
			var texture__handle__ = texture.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setObjectTexture:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
		}
		[Export ("setObjectTextures:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectTextures (nint textures, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setObjectTextures:withRange:"), textures, range);
		}
		[Export ("setObjectThreadgroupMemoryLength:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObjectThreadgroupMemoryLength (nuint length, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setObjectThreadgroupMemoryLength:atIndex:"), length, index);
		}
		[Export ("setColorAttachmentMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorAttachmentMap (MTLLogicalToPhysicalColorAttachmentMap? mapping)
		{
			var mapping__handle__ = mapping.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColorAttachmentMap:"), mapping__handle__);
			GC.KeepAlive (mapping);
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
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public nuint TileWidth {
			[Export ("tileWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tileWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public nuint TileHeight {
			[Export ("tileHeight")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tileHeight"));
				return ret;
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
