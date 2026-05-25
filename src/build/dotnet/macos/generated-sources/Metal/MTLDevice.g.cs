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
	/// <summary>System protocol for interacting with a single graphics device.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLDevice", WrapperType = typeof (MTLDeviceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetHeapTextureSizeAndAlign", Selector = "heapTextureSizeAndAlignWithDescriptor:", ReturnType = typeof (MTLSizeAndAlign), ParameterType = new Type [] { typeof (MTLTextureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetHeapBufferSizeAndAlignWithLength", Selector = "heapBufferSizeAndAlignWithLength:options:", ReturnType = typeof (MTLSizeAndAlign), ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLResourceOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateHeap", Selector = "newHeapWithDescriptor:", ReturnType = typeof (IMTLHeap), ParameterType = new Type [] { typeof (MTLHeapDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandQueue", Selector = "newCommandQueue", ReturnType = typeof (IMTLCommandQueue))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandQueue", Selector = "newCommandQueueWithMaxCommandBufferCount:", ReturnType = typeof (IMTLCommandQueue), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:", ReturnType = typeof (IMTLBuffer), ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLResourceOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithBytes:length:options:", ReturnType = typeof (IMTLBuffer), ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (MTLResourceOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBufferNoCopy", Selector = "newBufferWithBytesNoCopy:length:options:deallocator:", ReturnType = typeof (IMTLBuffer), ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (MTLResourceOptions), typeof (MTLDeallocator) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDMTLDeallocator) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDepthStencilState", Selector = "newDepthStencilStateWithDescriptor:", ReturnType = typeof (IMTLDepthStencilState), ParameterType = new Type [] { typeof (MTLDepthStencilDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:iosurface:plane:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureDescriptor), typeof (global::IOSurface.IOSurface), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedTexture", Selector = "newSharedTextureWithDescriptor:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedTexture", Selector = "newSharedTextureWithHandle:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLSharedTextureHandle) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSamplerState", Selector = "newSamplerStateWithDescriptor:", ReturnType = typeof (IMTLSamplerState), ParameterType = new Type [] { typeof (MTLSamplerDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDefaultLibrary", Selector = "newDefaultLibrary", ReturnType = typeof (IMTLLibrary))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithFile:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithData:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (DispatchData), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithSource:options:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (string), typeof (MTLCompileOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithSource:options:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (MTLCompileOptions), typeof (global::System.Action<global::Metal.IMTLLibrary, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V112) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDefaultLibrary", Selector = "newDefaultLibraryWithBundle:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (NSBundle), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTLRenderPipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:completionHandler:", ParameterType = new Type [] { typeof (MTLRenderPipelineDescriptor), typeof (global::System.Action<global::Metal.IMTLRenderPipelineState, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V113) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:options:reflection:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTLRenderPipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLRenderPipelineReflection), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:options:completionHandler:", ParameterType = new Type [] { typeof (MTLRenderPipelineDescriptor), typeof (MTLPipelineOption), typeof (global::System.Action<global::Metal.IMTLRenderPipelineState, global::Metal.MTLRenderPipelineReflection, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V15) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:options:reflection:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (IMTLFunction), typeof (MTLPipelineOption), typeof (MTLComputePipelineReflection), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:completionHandler:", ParameterType = new Type [] { typeof (IMTLFunction), typeof (global::System.Action<global::Metal.IMTLComputePipelineState, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V114) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (IMTLFunction), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:options:completionHandler:", ParameterType = new Type [] { typeof (IMTLFunction), typeof (MTLPipelineOption), typeof (global::System.Action<global::Metal.IMTLComputePipelineState, global::Metal.MTLComputePipelineReflection, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V16) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:options:reflection:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (MTLComputePipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLComputePipelineReflection), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:options:completionHandler:", ParameterType = new Type [] { typeof (MTLComputePipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLNewComputePipelineStateWithReflectionCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLNewComputePipelineStateWithReflectionCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFence", Selector = "newFence", ReturnType = typeof (IMTLFence))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsFeatureSet", Selector = "supportsFeatureSet:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLFeatureSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsTextureSampleCount", Selector = "supportsTextureSampleCount:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithURL:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMinimumLinearTextureAlignment", Selector = "minimumLinearTextureAlignmentForPixelFormat:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (MTLPixelFormat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMinimumTextureBufferAlignment", Selector = "minimumTextureBufferAlignmentForPixelFormat:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (MTLPixelFormat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetDefaultSamplePositions", Selector = "getDefaultSamplePositions:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithArguments:", ReturnType = typeof (IMTLArgumentEncoder), ParameterType = new Type [] { typeof (MTLArgumentDescriptor[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateIndirectCommandBuffer", Selector = "newIndirectCommandBufferWithDescriptor:maxCommandCount:options:", ReturnType = typeof (IMTLIndirectCommandBuffer), ParameterType = new Type [] { typeof (MTLIndirectCommandBufferDescriptor), typeof (UIntPtr), typeof (MTLResourceOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateEvent", Selector = "newEvent", ReturnType = typeof (IMTLEvent))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedEvent", Selector = "newSharedEvent", ReturnType = typeof (IMTLSharedEvent))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedEvent", Selector = "newSharedEventWithHandle:", ReturnType = typeof (IMTLSharedEvent), ParameterType = new Type [] { typeof (MTLSharedEventHandle) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithTileDescriptor:options:reflection:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTLTileRenderPipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLRenderPipelineReflection), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithTileDescriptor:options:completionHandler:", ParameterType = new Type [] { typeof (MTLTileRenderPipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLNewRenderPipelineStateWithReflectionCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsVertexAmplification", Selector = "supportsVertexAmplificationCount:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsRasterizationRateMap", Selector = "supportsRasterizationRateMapWithLayerCount:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSparseTileSize", Selector = "sparseTileSizeWithTextureType:pixelFormat:sampleCount:", ReturnType = typeof (MTLSize), ParameterType = new Type [] { typeof (MTLTextureType), typeof (MTLPixelFormat), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRasterizationRateMap", Selector = "newRasterizationRateMapWithDescriptor:", ReturnType = typeof (IMTLRasterizationRateMap), ParameterType = new Type [] { typeof (MTLRasterizationRateMapDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConvertSparseTileRegions", Selector = "convertSparseTileRegions:toPixelRegions:withTileSize:numRegions:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (MTLSize), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConvertSparsePixelRegions", Selector = "convertSparsePixelRegions:toTileRegions:withTileSize:alignmentMode:numRegions:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (MTLSize), typeof (MTLSparseTextureRegionAlignmentMode), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsFamily", Selector = "supportsFamily:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLGpuFamily) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCounterSampleBuffer", Selector = "newCounterSampleBufferWithDescriptor:error:", ReturnType = typeof (IMTLCounterSampleBuffer), ParameterType = new Type [] { typeof (MTLCounterSampleBufferDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSampleTimestamps", Selector = "sampleTimestamps:gpuTimestamp:", ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsCounterSampling", Selector = "supportsCounterSampling:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLCounterSamplingPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDynamicLibrary", Selector = "newDynamicLibrary:error:", ReturnType = typeof (IMTLDynamicLibrary), ParameterType = new Type [] { typeof (IMTLLibrary), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDynamicLibrary", Selector = "newDynamicLibraryWithURL:error:", ReturnType = typeof (IMTLDynamicLibrary), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBinaryArchive", Selector = "newBinaryArchiveWithDescriptor:error:", ReturnType = typeof (IMTLBinaryArchive), ParameterType = new Type [] { typeof (MTLBinaryArchiveDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructureSizes", Selector = "accelerationStructureSizesWithDescriptor:", ReturnType = typeof (MTLAccelerationStructureSizes), ParameterType = new Type [] { typeof (MTLAccelerationStructureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructure", Selector = "newAccelerationStructureWithSize:", ReturnType = typeof (IMTLAccelerationStructure), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructure", Selector = "newAccelerationStructureWithDescriptor:", ReturnType = typeof (IMTLAccelerationStructure), ParameterType = new Type [] { typeof (MTLAccelerationStructureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithStitchedDescriptor:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (MTLStitchedLibraryDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithStitchedDescriptor:completionHandler:", ParameterType = new Type [] { typeof (MTLStitchedLibraryDescriptor), typeof (global::System.Action<global::Metal.IMTLLibrary, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V112) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetHeapAccelerationStructureSizeAndAlign", Selector = "heapAccelerationStructureSizeAndAlignWithDescriptor:", ReturnType = typeof (MTLSizeAndAlign), ParameterType = new Type [] { typeof (MTLAccelerationStructureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetHeapAccelerationStructureSizeAndAlign", Selector = "heapAccelerationStructureSizeAndAlignWithSize:", ReturnType = typeof (MTLSizeAndAlign), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithBufferBinding:", ReturnType = typeof (IMTLArgumentEncoder), ParameterType = new Type [] { typeof (IMTLBufferBinding) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithMeshDescriptor:options:reflection:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTLMeshRenderPipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLRenderPipelineReflection), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithMeshDescriptor:options:completionHandler:", ParameterType = new Type [] { typeof (MTLMeshRenderPipelineDescriptor), typeof (MTLPipelineOption), typeof (MTLNewRenderPipelineStateWithReflectionCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSparseTileSizeInBytes", Selector = "sparseTileSizeInBytesForSparsePageSize:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (MTLSparsePageSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSparseTileSize", Selector = "sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:", ReturnType = typeof (MTLSize), ParameterType = new Type [] { typeof (MTLTextureType), typeof (MTLPixelFormat), typeof (UIntPtr), typeof (MTLSparsePageSize) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNewLogState", Selector = "newLogStateWithDescriptor:error:", ReturnType = typeof (IMTLLogState), ParameterType = new Type [] { typeof (MTLLogStateDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandQueue", Selector = "newCommandQueueWithDescriptor:", ReturnType = typeof (IMTLCommandQueue), ParameterType = new Type [] { typeof (MTLCommandQueueDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateResidencySet", Selector = "newResidencySetWithDescriptor:error:", ReturnType = typeof (IMTLResidencySet), ParameterType = new Type [] { typeof (MTLResidencySetDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTensorSizeAndAlign", Selector = "tensorSizeAndAlignWithDescriptor:", ReturnType = typeof (MTLSizeAndAlign), ParameterType = new Type [] { typeof (MTLTensorDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTensor", Selector = "newTensorWithDescriptor:error:", ReturnType = typeof (IMTLTensor), ParameterType = new Type [] { typeof (MTLTensorDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithFunction:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (IMTLFunction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandAllocator", Selector = "newCommandAllocator", ReturnType = typeof (IMTL4CommandAllocator))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandAllocator", Selector = "newCommandAllocatorWithDescriptor:error:", ReturnType = typeof (IMTL4CommandAllocator), ParameterType = new Type [] { typeof (MTL4CommandAllocatorDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateMTL4CommandQueue", Selector = "newMTL4CommandQueue", ReturnType = typeof (IMTL4CommandQueue))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateMTL4CommandQueue", Selector = "newMTL4CommandQueueWithDescriptor:error:", ReturnType = typeof (IMTL4CommandQueue), ParameterType = new Type [] { typeof (MTL4CommandQueueDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandBuffer", Selector = "newCommandBuffer", ReturnType = typeof (IMTL4CommandBuffer))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentTable", Selector = "newArgumentTableWithDescriptor:error:", ReturnType = typeof (IMTL4ArgumentTable), ParameterType = new Type [] { typeof (MTL4ArgumentTableDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTextureViewPool", Selector = "newTextureViewPoolWithDescriptor:error:", ReturnType = typeof (IMTLTextureViewPool), ParameterType = new Type [] { typeof (MTLResourceViewPoolDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCompiler", Selector = "newCompilerWithDescriptor:error:", ReturnType = typeof (IMTL4Compiler), ParameterType = new Type [] { typeof (MTL4CompilerDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArchive", Selector = "newArchiveWithURL:error:", ReturnType = typeof (IMTL4Archive), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreatePipelineDataSetSerializer", Selector = "newPipelineDataSetSerializerWithDescriptor:", ReturnType = typeof (IMTL4PipelineDataSetSerializer), ParameterType = new Type [] { typeof (MTL4PipelineDataSetSerializerDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:placementSparsePageSize:", ReturnType = typeof (IMTLBuffer), ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLResourceOptions), typeof (MTLSparsePageSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCounterHeap", Selector = "newCounterHeapWithDescriptor:error:", ReturnType = typeof (IMTL4CounterHeap), ParameterType = new Type [] { typeof (MTL4CounterHeapDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSizeOf", Selector = "sizeOfCounterHeapEntry:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (MTL4CounterHeapType) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithBinaryFunction:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (IMTL4BinaryFunction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof (string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxThreadsPerThreadgroup", Selector = "maxThreadsPerThreadgroup", PropertyType = typeof (MTLSize), GetterSelector = "maxThreadsPerThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LowPower", Selector = "lowPower", PropertyType = typeof (bool), GetterSelector = "isLowPower", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Headless", Selector = "headless", PropertyType = typeof (bool), GetterSelector = "isHeadless", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RecommendedMaxWorkingSetSize", Selector = "recommendedMaxWorkingSetSize", PropertyType = typeof (ulong), GetterSelector = "recommendedMaxWorkingSetSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Depth24Stencil8PixelFormatSupported", Selector = "depth24Stencil8PixelFormatSupported", PropertyType = typeof (bool), GetterSelector = "isDepth24Stencil8PixelFormatSupported", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Removable", Selector = "removable", PropertyType = typeof (bool), GetterSelector = "isRemovable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReadWriteTextureSupport", Selector = "readWriteTextureSupport", PropertyType = typeof (MTLReadWriteTextureTier), GetterSelector = "readWriteTextureSupport", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ArgumentBuffersSupport", Selector = "argumentBuffersSupport", PropertyType = typeof (MTLArgumentBuffersTier), GetterSelector = "argumentBuffersSupport", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RasterOrderGroupsSupported", Selector = "rasterOrderGroupsSupported", PropertyType = typeof (bool), GetterSelector = "areRasterOrderGroupsSupported", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxThreadgroupMemoryLength", Selector = "maxThreadgroupMemoryLength", PropertyType = typeof (UIntPtr), GetterSelector = "maxThreadgroupMemoryLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxArgumentBufferSamplerCount", Selector = "maxArgumentBufferSamplerCount", PropertyType = typeof (UIntPtr), GetterSelector = "maxArgumentBufferSamplerCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ProgrammableSamplePositionsSupported", Selector = "programmableSamplePositionsSupported", PropertyType = typeof (bool), GetterSelector = "areProgrammableSamplePositionsSupported", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxBufferLength", Selector = "maxBufferLength", PropertyType = typeof (UIntPtr), GetterSelector = "maxBufferLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RegistryId", Selector = "registryID", PropertyType = typeof (ulong), GetterSelector = "registryID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentAllocatedSize", Selector = "currentAllocatedSize", PropertyType = typeof (UIntPtr), GetterSelector = "currentAllocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SparseTileSizeInBytes", Selector = "sparseTileSizeInBytes", PropertyType = typeof (UIntPtr), GetterSelector = "sparseTileSizeInBytes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HasUnifiedMemory", Selector = "hasUnifiedMemory", PropertyType = typeof (bool), GetterSelector = "hasUnifiedMemory", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BarycentricCoordsSupported", Selector = "barycentricCoordsSupported", PropertyType = typeof (bool), GetterSelector = "areBarycentricCoordsSupported", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsShaderBarycentricCoordinates", Selector = "supportsShaderBarycentricCoordinates", PropertyType = typeof (bool), GetterSelector = "supportsShaderBarycentricCoordinates", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PeerIndex", Selector = "peerIndex", PropertyType = typeof (uint), GetterSelector = "peerIndex", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PeerCount", Selector = "peerCount", PropertyType = typeof (uint), GetterSelector = "peerCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CounterSets", Selector = "counterSets", PropertyType = typeof (IMTLCounterSet[]), GetterSelector = "counterSets", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PeerGroupId", Selector = "peerGroupID", PropertyType = typeof (ulong), GetterSelector = "peerGroupID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTransferRate", Selector = "maxTransferRate", PropertyType = typeof (ulong), GetterSelector = "maxTransferRate", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Location", Selector = "location", PropertyType = typeof (MTLDeviceLocation), GetterSelector = "location", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LocationNumber", Selector = "locationNumber", PropertyType = typeof (UIntPtr), GetterSelector = "locationNumber", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Supports32BitFloatFiltering", Selector = "supports32BitFloatFiltering", PropertyType = typeof (bool), GetterSelector = "supports32BitFloatFiltering", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Supports32BitMsaa", Selector = "supports32BitMSAA", PropertyType = typeof (bool), GetterSelector = "supports32BitMSAA", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsBCTextureCompression", Selector = "supportsBCTextureCompression", PropertyType = typeof (bool), GetterSelector = "supportsBCTextureCompression", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsPullModelInterpolation", Selector = "supportsPullModelInterpolation", PropertyType = typeof (bool), GetterSelector = "supportsPullModelInterpolation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsDynamicLibraries", Selector = "supportsDynamicLibraries", PropertyType = typeof (bool), GetterSelector = "supportsDynamicLibraries", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsRaytracing", Selector = "supportsRaytracing", PropertyType = typeof (bool), GetterSelector = "supportsRaytracing", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsFunctionPointers", Selector = "supportsFunctionPointers", PropertyType = typeof (bool), GetterSelector = "supportsFunctionPointers", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsQueryTextureLod", Selector = "supportsQueryTextureLOD", PropertyType = typeof (bool), GetterSelector = "supportsQueryTextureLOD", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsRenderDynamicLibraries", Selector = "supportsRenderDynamicLibraries", PropertyType = typeof (bool), GetterSelector = "supportsRenderDynamicLibraries", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsRaytracingFromRender", Selector = "supportsRaytracingFromRender", PropertyType = typeof (bool), GetterSelector = "supportsRaytracingFromRender", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsPrimitiveMotionBlur", Selector = "supportsPrimitiveMotionBlur", PropertyType = typeof (bool), GetterSelector = "supportsPrimitiveMotionBlur", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsFunctionPointersFromRender", Selector = "supportsFunctionPointersFromRender", PropertyType = typeof (bool), GetterSelector = "supportsFunctionPointersFromRender", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Architecture", Selector = "architecture", PropertyType = typeof (MTLArchitecture), GetterSelector = "architecture", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumConcurrentCompilationTaskCount", Selector = "maximumConcurrentCompilationTaskCount", PropertyType = typeof (UIntPtr), GetterSelector = "maximumConcurrentCompilationTaskCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShouldMaximizeConcurrentCompilation", Selector = "shouldMaximizeConcurrentCompilation", PropertyType = typeof (bool), GetterSelector = "shouldMaximizeConcurrentCompilation", SetterSelector = "setShouldMaximizeConcurrentCompilation:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "QueryTimestampFrequency", Selector = "queryTimestampFrequency", PropertyType = typeof (ulong), GetterSelector = "queryTimestampFrequency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsPlacementSparse", Selector = "supportsPlacementSparse", PropertyType = typeof (bool), GetterSelector = "supportsPlacementSparse", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLDevice : INativeObject, IDisposable
	{
		/// <summary>Gets the size and alignment of a texture with specified description, when allocated from a heap.</summary>
		[global::Foundation.RequiredMember]
		[Export ("heapTextureSizeAndAlignWithDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSizeAndAlign GetHeapTextureSizeAndAlign (MTLTextureDescriptor desc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the size and alignment of a texture with specified description, when allocated from a heap.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSizeAndAlign _GetHeapTextureSizeAndAlign (IMTLDevice This, MTLTextureDescriptor desc)
		{
			var desc__handle__ = desc!.GetNonNullHandle (nameof (desc));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("heapTextureSizeAndAlignWithDescriptor:"), desc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (desc);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("heapBufferSizeAndAlignWithLength:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSizeAndAlign GetHeapBufferSizeAndAlignWithLength (nuint length, MTLResourceOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSizeAndAlign _GetHeapBufferSizeAndAlignWithLength (IMTLDevice This, nuint length, MTLResourceOptions options)
		{
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("heapBufferSizeAndAlignWithLength:options:"), length, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Creates and returns a new heap.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newHeapWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLHeap? CreateHeap (MTLHeapDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates and returns a new heap.</summary>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLHeap? _CreateHeap (IMTLDevice This, MTLHeapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLHeap? ret;
			ret =  Runtime.GetINativeObject<IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newHeapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newCommandQueue")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCommandQueue? CreateCommandQueue ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandQueue? _CreateCommandQueue (IMTLDevice This)
		{
			IMTLCommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newCommandQueue")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="maxCommandBufferCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newCommandQueueWithMaxCommandBufferCount:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCommandQueue? CreateCommandQueue (nuint maxCommandBufferCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="maxCommandBufferCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandQueue? _CreateCommandQueue (IMTLDevice This, nuint maxCommandBufferCount)
		{
			IMTLCommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newCommandQueueWithMaxCommandBufferCount:"), maxCommandBufferCount), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="length">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithLength:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="length">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer? _CreateBuffer (IMTLDevice This, nuint length, MTLResourceOptions options)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newBufferWithLength:options:"), length, (UIntPtr) (ulong) options), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithBytes:length:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBuffer? CreateBuffer (nint pointer, nuint length, MTLResourceOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer? _CreateBuffer (IMTLDevice This, nint pointer, nuint length, MTLResourceOptions options)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newBufferWithBytes:length:options:"), pointer, length, (UIntPtr) (ulong) options), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Creates and returns a new buffer that is wrapped around the specified data, and runs an optional <paramref name="deallocator" /> when the memory is deallocated.</summary><param name="pointer">The data to wrap.</param><param name="length">The length of the data to wrap.</param><param name="options">Options for creating the buffer.</param><param name="deallocator">The deallocator to use when deleting the buffer.</param>
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithBytesNoCopy:length:options:deallocator:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLBuffer? CreateBufferNoCopy (nint pointer, nuint length, MTLResourceOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLDeallocator))]MTLDeallocator deallocator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates and returns a new buffer that is wrapped around the specified data, and runs an optional <paramref name="deallocator" /> when the memory is deallocated.</summary><param name="pointer">The data to wrap.</param><param name="length">The length of the data to wrap.</param><param name="options">Options for creating the buffer.</param><param name="deallocator">The deallocator to use when deleting the buffer.</param>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLBuffer? _CreateBufferNoCopy (IMTLDevice This, nint pointer, nuint length, MTLResourceOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLDeallocator))]MTLDeallocator deallocator)
		{
			if (deallocator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deallocator));
			using var block_deallocator = Trampolines.SDMTLDeallocator.CreateBlock (deallocator);
			BlockLiteral *block_ptr_deallocator = &block_deallocator;
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newBufferWithBytesNoCopy:length:options:deallocator:"), pointer, length, (UIntPtr) (ulong) options, (IntPtr) block_ptr_deallocator), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newDepthStencilStateWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLDepthStencilState? CreateDepthStencilState (MTLDepthStencilDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDepthStencilState? _CreateDepthStencilState (IMTLDevice This, MTLDepthStencilDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLDepthStencilState? ret;
			ret =  Runtime.GetINativeObject<IMTLDepthStencilState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newDepthStencilStateWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newTextureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTexture (IMTLDevice This, MTLTextureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newTextureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>Creates a Metal texture with the specified values.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newTextureWithDescriptor:iosurface:plane:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor, global::IOSurface.IOSurface iosurface, nuint plane)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates a Metal texture with the specified values.</summary>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTexture (IMTLDevice This, MTLTextureDescriptor descriptor, global::IOSurface.IOSurface iosurface, nuint plane)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var iosurface__handle__ = iosurface!.GetNonNullHandle (nameof (iosurface));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newTextureWithDescriptor:iosurface:plane:"), descriptor__handle__, iosurface__handle__, plane), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (iosurface);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newSharedTextureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateSharedTexture (MTLTextureDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateSharedTexture (IMTLDevice This, MTLTextureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newSharedTextureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newSharedTextureWithHandle:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateSharedTexture (MTLSharedTextureHandle sharedHandle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateSharedTexture (IMTLDevice This, MTLSharedTextureHandle sharedHandle)
		{
			var sharedHandle__handle__ = sharedHandle!.GetNonNullHandle (nameof (sharedHandle));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newSharedTextureWithHandle:"), sharedHandle__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharedHandle);
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newSamplerStateWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLSamplerState? CreateSamplerState (MTLSamplerDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLSamplerState? _CreateSamplerState (IMTLDevice This, MTLSamplerDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLSamplerState? ret;
			ret =  Runtime.GetINativeObject<IMTLSamplerState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newSamplerStateWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newDefaultLibrary")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLLibrary CreateDefaultLibrary ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLLibrary _CreateDefaultLibrary (IMTLDevice This)
		{
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newDefaultLibrary")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="filepath">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithFile:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary CreateLibrary (string filepath, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="filepath">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary _CreateLibrary (IMTLDevice This, string filepath, out NSError error)
		{
			if (filepath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filepath));
			NativeHandle errorValue = IntPtr.Zero;
			var nsfilepath = CFString.CreateNative (filepath);
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithFile:error:"), nsfilepath, &errorValue), true)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsfilepath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithData:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary CreateLibrary (global::CoreFoundation.DispatchData data, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary _CreateLibrary (IMTLDevice This, global::CoreFoundation.DispatchData data, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithData:error:"), data__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="source">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithSource:options:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary CreateLibrary (string source, MTLCompileOptions options, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="source">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary _CreateLibrary (IMTLDevice This, string source, MTLCompileOptions options, out NSError error)
		{
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			var nssource = CFString.CreateNative (source);
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithSource:options:error:"), nssource, options__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nssource);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="source">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithSource:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateLibrary (string source, MTLCompileOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V112))]global::System.Action<IMTLLibrary, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<IMTLLibrary> CreateLibraryAsync (string source, MTLCompileOptions options)
		{
			var tcs = new TaskCompletionSource<IMTLLibrary> ();
			CreateLibrary(source, options, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="source">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateLibrary (IMTLDevice This, string source, MTLCompileOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V112))]global::System.Action<IMTLLibrary, NSError> completionHandler)
		{
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssource = CFString.CreateNative (source);
			using var block_completionHandler = Trampolines.SDActionArity2V112.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithSource:options:completionHandler:"), nssource, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nssource);
		}
		/// <summary>Creates and returns a new library from the functions in the specified bundle.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newDefaultLibraryWithBundle:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary? CreateDefaultLibrary (NSBundle bundle, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates and returns a new library from the functions in the specified bundle.</summary>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary? _CreateDefaultLibrary (IMTLDevice This, NSBundle bundle, out NSError error)
		{
			var bundle__handle__ = bundle!.GetNonNullHandle (nameof (bundle));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newDefaultLibraryWithBundle:error:"), bundle__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (bundle);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState _CreateRenderPipelineState (IMTLDevice This, MTLRenderPipelineDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V113))]global::System.Action<IMTLRenderPipelineState, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateRenderPipelineState (IMTLDevice This, MTLRenderPipelineDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V113))]global::System.Action<IMTLRenderPipelineState, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V113.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		/// <param name="descriptor">To be added.</param><param name="options">To be added.</param><param name="reflection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection reflection, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><param name="options">To be added.</param><param name="reflection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState _CreateRenderPipelineState (IMTLDevice This, MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection reflection, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V15))]global::System.Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateRenderPipelineState (IMTLDevice This, MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V15))]global::System.Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity3V15.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		/// <param name="computeFunction">To be added.</param><param name="options">To be added.</param><param name="reflection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithFunction:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState CreateComputePipelineState (IMTLFunction computeFunction, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="computeFunction">To be added.</param><param name="options">To be added.</param><param name="reflection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState _CreateComputePipelineState (IMTLDevice This, IMTLFunction computeFunction, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:options:reflection:error:"), computeFunction__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (computeFunction);
			reflection = Runtime.GetNSObject<MTLComputePipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="computeFunction">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithFunction:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateComputePipelineState (IMTLFunction computeFunction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V114))]global::System.Action<IMTLComputePipelineState, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="computeFunction">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateComputePipelineState (IMTLDevice This, IMTLFunction computeFunction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V114))]global::System.Action<IMTLComputePipelineState, NSError> completionHandler)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V114.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:completionHandler:"), computeFunction__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (computeFunction);
		}
		/// <param name="computeFunction">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithFunction:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState CreateComputePipelineState (IMTLFunction computeFunction, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="computeFunction">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState _CreateComputePipelineState (IMTLDevice This, IMTLFunction computeFunction, out NSError error)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:error:"), computeFunction__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (computeFunction);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="computeFunction">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithFunction:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateComputePipelineState (IMTLFunction computeFunction, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V16))]global::System.Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="computeFunction">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateComputePipelineState (IMTLDevice This, IMTLFunction computeFunction, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V16))]global::System.Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError> completionHandler)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity3V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:options:completionHandler:"), computeFunction__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (computeFunction);
		}
		/// <summary>Creates a new pipeline state from the specified compute pipeline descriptor, options, and completion handler, and stores reflection information in the <paramref name="reflection" /><see langword="out" /> parameter.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState CreateComputePipelineState (MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates a new pipeline state from the specified compute pipeline descriptor, options, and completion handler, and stores reflection information in the <paramref name="reflection" /><see langword="out" /> parameter.</summary>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState _CreateComputePipelineState (IMTLDevice This, MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLComputePipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Creates a new pipeline state from the specified compute pipeline descriptor, options, and completion handler.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:options:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateComputePipelineState (MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewComputePipelineStateWithReflectionCompletionHandler))]MTLNewComputePipelineStateWithReflectionCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates a new pipeline state from the specified compute pipeline descriptor, options, and completion handler.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateComputePipelineState (IMTLDevice This, MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewComputePipelineStateWithReflectionCompletionHandler))]MTLNewComputePipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewComputePipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		/// <summary>Creates and returns a new fence for tracking and managing dependencies between command encoders.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newFence")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFence CreateFence ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates and returns a new fence for tracking and managing dependencies between command encoders.</summary>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFence _CreateFence (IMTLDevice This)
		{
			IMTLFence? ret;
			ret =  Runtime.GetINativeObject<IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newFence")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="featureSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("supportsFeatureSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsFeatureSet (MTLFeatureSet featureSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="featureSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsFeatureSet (IMTLDevice This, MTLFeatureSet featureSet)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsFeatureSet:"), (UIntPtr) (ulong) featureSet);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Returns a Boolean value that tells whether the device supports the specified texture count.</summary>
		[global::Foundation.RequiredMember]
		[Export ("supportsTextureSampleCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsTextureSampleCount (nuint sampleCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns a Boolean value that tells whether the device supports the specified texture count.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsTextureSampleCount (IMTLDevice This, nuint sampleCount)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsTextureSampleCount:"), sampleCount);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Creates and returns a new library from the functions at the specified URL.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithURL:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary? CreateLibrary (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates and returns a new library from the functions at the specified URL.</summary>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary? _CreateLibrary (IMTLDevice This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Gets the minimum alignment required for a linear texture in the given pixel format.</summary><param name="format">The pixel format. Depth, stencil, and compressed formats are not supported.</param>
		[global::Foundation.RequiredMember]
		[Export ("minimumLinearTextureAlignmentForPixelFormat:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetMinimumLinearTextureAlignment (MTLPixelFormat format)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the minimum alignment required for a linear texture in the given pixel format.</summary><param name="format">The pixel format. Depth, stencil, and compressed formats are not supported.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMinimumLinearTextureAlignment (IMTLDevice This, MTLPixelFormat format)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("minimumLinearTextureAlignmentForPixelFormat:"), (UIntPtr) (ulong) format);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("minimumTextureBufferAlignmentForPixelFormat:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetMinimumTextureBufferAlignment (MTLPixelFormat format)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMinimumTextureBufferAlignment (IMTLDevice This, MTLPixelFormat format)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("minimumTextureBufferAlignmentForPixelFormat:"), (UIntPtr) (ulong) format);
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Provides the default sample positions for the specified sample <paramref name="count" />.</summary><param name="positions">Array that will be filled with the default sample postions.</param><param name="count">The number of positions, which determines the set of default positions.</param>
		[global::Foundation.RequiredMember]
		[Export ("getDefaultSamplePositions:count:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetDefaultSamplePositions (nint positions, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Provides the default sample positions for the specified sample <paramref name="count" />.</summary><param name="positions">Array that will be filled with the default sample postions.</param><param name="count">The number of positions, which determines the set of default positions.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetDefaultSamplePositions (IMTLDevice This, nint positions, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("getDefaultSamplePositions:count:"), positions, count);
			GC.KeepAlive (This);
		}
		/// <summary>Creates an encoder for the specified array of arguments.</summary><param name="arguments">An array of arguments within a buffer.</param>
		[global::Foundation.RequiredMember]
		[Export ("newArgumentEncoderWithArguments:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLArgumentEncoder? CreateArgumentEncoder (MTLArgumentDescriptor[] arguments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates an encoder for the specified array of arguments.</summary><param name="arguments">An array of arguments within a buffer.</param>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLArgumentEncoder? _CreateArgumentEncoder (IMTLDevice This, MTLArgumentDescriptor[] arguments)
		{
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newArgumentEncoderWithArguments:"), nsa_arguments.Handle), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newIndirectCommandBufferWithDescriptor:maxCommandCount:options:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLIndirectCommandBuffer? CreateIndirectCommandBuffer (MTLIndirectCommandBufferDescriptor descriptor, nuint maxCount, MTLResourceOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLIndirectCommandBuffer? _CreateIndirectCommandBuffer (IMTLDevice This, MTLIndirectCommandBufferDescriptor descriptor, nuint maxCount, MTLResourceOptions options)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIndirectCommandBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLIndirectCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newIndirectCommandBufferWithDescriptor:maxCommandCount:options:"), descriptor__handle__, maxCount, (UIntPtr) (ulong) options), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newEvent")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLEvent? CreateEvent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLEvent? _CreateEvent (IMTLDevice This)
		{
			IMTLEvent? ret;
			ret =  Runtime.GetINativeObject<IMTLEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newEvent")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newSharedEvent")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLSharedEvent? CreateSharedEvent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLSharedEvent? _CreateSharedEvent (IMTLDevice This)
		{
			IMTLSharedEvent? ret;
			ret =  Runtime.GetINativeObject<IMTLSharedEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newSharedEvent")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newSharedEventWithHandle:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLSharedEvent? CreateSharedEvent (MTLSharedEventHandle sharedEventHandle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLSharedEvent? _CreateSharedEvent (IMTLDevice This, MTLSharedEventHandle sharedEventHandle)
		{
			var sharedEventHandle__handle__ = sharedEventHandle!.GetNonNullHandle (nameof (sharedEventHandle));
			IMTLSharedEvent? ret;
			ret =  Runtime.GetINativeObject<IMTLSharedEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newSharedEventWithHandle:"), sharedEventHandle__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharedEventHandle);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithTileDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTLTileRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTLDevice This, MTLTileRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithTileDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithTileDescriptor:options:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateRenderPipelineState (MTLTileRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateRenderPipelineState (IMTLDevice This, MTLTileRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewRenderPipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithTileDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[global::Foundation.RequiredMember]
		[Export ("supportsVertexAmplificationCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsVertexAmplification (nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsVertexAmplification (IMTLDevice This, nuint count)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsVertexAmplificationCount:"), count);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("supportsRasterizationRateMapWithLayerCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsRasterizationRateMap (nuint layerCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsRasterizationRateMap (IMTLDevice This, nuint layerCount)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsRasterizationRateMapWithLayerCount:"), layerCount);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSize GetSparseTileSize (MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetSparseTileSize (IMTLDevice This, MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRasterizationRateMapWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLRasterizationRateMap? CreateRasterizationRateMap (MTLRasterizationRateMapDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLRasterizationRateMap? _CreateRasterizationRateMap (IMTLDevice This, MTLRasterizationRateMapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLRasterizationRateMap? ret;
			ret =  Runtime.GetINativeObject<IMTLRasterizationRateMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newRasterizationRateMapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("convertSparseTileRegions:toPixelRegions:withTileSize:numRegions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConvertSparseTileRegions (nint tileRegions, nint pixelRegions, MTLSize tileSize, nuint numRegions)
		{
			_ConvertSparseTileRegions (this, tileRegions, pixelRegions, tileSize, numRegions);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConvertSparseTileRegions (IMTLDevice This, nint tileRegions, nint pixelRegions, MTLSize tileSize, nuint numRegions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_MTLSize_UIntPtr (This.Handle, Selector.GetHandle ("convertSparseTileRegions:toPixelRegions:withTileSize:numRegions:"), tileRegions, pixelRegions, tileSize, numRegions);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("convertSparsePixelRegions:toTileRegions:withTileSize:alignmentMode:numRegions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConvertSparsePixelRegions (nint pixelRegions, nint tileRegions, MTLSize tileSize, MTLSparseTextureRegionAlignmentMode mode, nuint numRegions)
		{
			_ConvertSparsePixelRegions (this, pixelRegions, tileRegions, tileSize, mode, numRegions);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConvertSparsePixelRegions (IMTLDevice This, nint pixelRegions, nint tileRegions, MTLSize tileSize, MTLSparseTextureRegionAlignmentMode mode, nuint numRegions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_MTLSize_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("convertSparsePixelRegions:toTileRegions:withTileSize:alignmentMode:numRegions:"), pixelRegions, tileRegions, tileSize, (UIntPtr) (ulong) mode, numRegions);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("supportsFamily:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsFamily (MTLGpuFamily gpuFamily)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsFamily (IMTLDevice This, MTLGpuFamily gpuFamily)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("supportsFamily:"), (IntPtr) (long) gpuFamily);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCounterSampleBufferWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLCounterSampleBuffer? CreateCounterSampleBuffer (MTLCounterSampleBufferDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLCounterSampleBuffer? _CreateCounterSampleBuffer (IMTLDevice This, MTLCounterSampleBufferDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLCounterSampleBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLCounterSampleBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newCounterSampleBufferWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("sampleTimestamps:gpuTimestamp:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetSampleTimestamps (nuint cpuTimestamp, nuint gpuTimestamp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetSampleTimestamps (IMTLDevice This, nuint cpuTimestamp, nuint gpuTimestamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("sampleTimestamps:gpuTimestamp:"), cpuTimestamp, gpuTimestamp);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("supportsCounterSampling:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsCounterSampling (MTLCounterSamplingPoint samplingPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsCounterSampling (IMTLDevice This, MTLCounterSamplingPoint samplingPoint)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsCounterSampling:"), (UIntPtr) (ulong) samplingPoint);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("newDynamicLibrary:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLDynamicLibrary? CreateDynamicLibrary (IMTLLibrary library, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLDynamicLibrary? _CreateDynamicLibrary (IMTLDevice This, IMTLLibrary library, out NSError? error)
		{
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newDynamicLibrary:error:"), library__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (library);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newDynamicLibraryWithURL:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLDynamicLibrary? CreateDynamicLibrary (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLDynamicLibrary? _CreateDynamicLibrary (IMTLDevice This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newDynamicLibraryWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBinaryArchiveWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLBinaryArchive? CreateBinaryArchive (MTLBinaryArchiveDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLBinaryArchive? _CreateBinaryArchive (IMTLDevice This, MTLBinaryArchiveDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLBinaryArchive? ret;
			ret =  Runtime.GetINativeObject<IMTLBinaryArchive> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newBinaryArchiveWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accelerationStructureSizesWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLAccelerationStructureSizes CreateAccelerationStructureSizes (MTLAccelerationStructureDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLAccelerationStructureSizes _CreateAccelerationStructureSizes (IMTLDevice This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLAccelerationStructureSizes ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLAccelerationStructureSizes_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accelerationStructureSizesWithDescriptor:"), descriptor__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLAccelerationStructureSizes_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("accelerationStructureSizesWithDescriptor:"), descriptor__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newAccelerationStructureWithSize:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructure? CreateAccelerationStructure (nuint size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructure? _CreateAccelerationStructure (IMTLDevice This, nuint size)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:"), size), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newAccelerationStructureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructure? CreateAccelerationStructure (MTLAccelerationStructureDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructure? _CreateAccelerationStructure (IMTLDevice This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithStitchedDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary? CreateLibrary (MTLStitchedLibraryDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary? _CreateLibrary (IMTLDevice This, MTLStitchedLibraryDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithStitchedDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithStitchedDescriptor:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateLibrary (MTLStitchedLibraryDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V112))]global::System.Action<IMTLLibrary, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<IMTLLibrary> CreateLibraryAsync (MTLStitchedLibraryDescriptor descriptor)
		{
			var tcs = new TaskCompletionSource<IMTLLibrary> ();
			CreateLibrary(descriptor, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateLibrary (IMTLDevice This, MTLStitchedLibraryDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V112))]global::System.Action<IMTLLibrary, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V112.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithStitchedDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[global::Foundation.RequiredMember]
		[Export ("heapAccelerationStructureSizeAndAlignWithDescriptor:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSizeAndAlign GetHeapAccelerationStructureSizeAndAlign (MTLAccelerationStructureDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSizeAndAlign _GetHeapAccelerationStructureSizeAndAlign (IMTLDevice This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("heapAccelerationStructureSizeAndAlignWithDescriptor:"), descriptor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("heapAccelerationStructureSizeAndAlignWithSize:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSizeAndAlign GetHeapAccelerationStructureSizeAndAlign (nuint size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSizeAndAlign _GetHeapAccelerationStructureSizeAndAlign (IMTLDevice This, nuint size)
		{
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("heapAccelerationStructureSizeAndAlignWithSize:"), size);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("newArgumentEncoderWithBufferBinding:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLArgumentEncoder CreateArgumentEncoder (IMTLBufferBinding bufferBinding)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLArgumentEncoder _CreateArgumentEncoder (IMTLDevice This, IMTLBufferBinding bufferBinding)
		{
			var bufferBinding__handle__ = bufferBinding!.GetNonNullHandle (nameof (bufferBinding));
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferBinding:"), bufferBinding__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (bufferBinding);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithMeshDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTLDevice This, MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithMeshDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithMeshDescriptor:options:completionHandler:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateRenderPipelineState (MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateRenderPipelineState (IMTLDevice This, MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewRenderPipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithMeshDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[global::Foundation.RequiredMember]
		[Export ("sparseTileSizeInBytesForSparsePageSize:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetSparseTileSizeInBytes (MTLSparsePageSize sparsePageSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetSparseTileSizeInBytes (IMTLDevice This, MTLSparsePageSize sparsePageSize)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeInBytesForSparsePageSize:"), (IntPtr) (long) sparsePageSize);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSize GetSparseTileSize (MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount, MTLSparsePageSize sparsePageSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetSparseTileSize (IMTLDevice This, MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount, MTLSparsePageSize sparsePageSize)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount, (IntPtr) (long) sparsePageSize);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr_UIntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount, (IntPtr) (long) sparsePageSize);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newLogStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLogState? GetNewLogState (MTLLogStateDescriptor descriptor, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLogState? _GetNewLogState (IMTLDevice This, MTLLogStateDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLogState? ret;
			ret =  Runtime.GetINativeObject<IMTLLogState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLogStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCommandQueueWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCommandQueue? CreateCommandQueue (MTLCommandQueueDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandQueue? _CreateCommandQueue (IMTLDevice This, MTLCommandQueueDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLCommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newCommandQueueWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newResidencySetWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLResidencySet? CreateResidencySet (MTLResidencySetDescriptor descriptor, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLResidencySet? _CreateResidencySet (IMTLDevice This, MTLResidencySetDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLResidencySet? ret;
			ret =  Runtime.GetINativeObject<IMTLResidencySet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newResidencySetWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("tensorSizeAndAlignWithDescriptor:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSizeAndAlign CreateTensorSizeAndAlign (MTLTensorDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSizeAndAlign _CreateTensorSizeAndAlign (IMTLDevice This, MTLTensorDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tensorSizeAndAlignWithDescriptor:"), descriptor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newTensorWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLTensor? CreateTensor (MTLTensorDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLTensor? _CreateTensor (IMTLDevice This, MTLTensorDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLTensor? ret;
			ret =  Runtime.GetINativeObject<IMTLTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newTensorWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithFunction:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? CreateFunctionHandle (IMTLFunction function)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _CreateFunctionHandle (IMTLDevice This, IMTLFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("functionHandleWithFunction:"), function__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCommandAllocator")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4CommandAllocator? CreateCommandAllocator ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4CommandAllocator? _CreateCommandAllocator (IMTLDevice This)
		{
			IMTL4CommandAllocator? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newCommandAllocator")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCommandAllocatorWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CommandAllocator? CreateCommandAllocator (MTL4CommandAllocatorDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CommandAllocator? _CreateCommandAllocator (IMTLDevice This, MTL4CommandAllocatorDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4CommandAllocator? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newCommandAllocatorWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newMTL4CommandQueue")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4CommandQueue? CreateMTL4CommandQueue ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4CommandQueue? _CreateMTL4CommandQueue (IMTLDevice This)
		{
			IMTL4CommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newMTL4CommandQueue")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newMTL4CommandQueueWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CommandQueue? CreateMTL4CommandQueue (MTL4CommandQueueDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CommandQueue? _CreateMTL4CommandQueue (IMTLDevice This, MTL4CommandQueueDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4CommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newMTL4CommandQueueWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCommandBuffer")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4CommandBuffer? CreateCommandBuffer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4CommandBuffer? _CreateCommandBuffer (IMTLDevice This)
		{
			IMTL4CommandBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newCommandBuffer")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newArgumentTableWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4ArgumentTable? CreateArgumentTable (MTL4ArgumentTableDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4ArgumentTable? _CreateArgumentTable (IMTLDevice This, MTL4ArgumentTableDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4ArgumentTable? ret;
			ret =  Runtime.GetINativeObject<IMTL4ArgumentTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newArgumentTableWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newTextureViewPoolWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLTextureViewPool? CreateTextureViewPool (MTLResourceViewPoolDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLTextureViewPool? _CreateTextureViewPool (IMTLDevice This, MTLResourceViewPoolDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLTextureViewPool? ret;
			ret =  Runtime.GetINativeObject<IMTLTextureViewPool> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newTextureViewPoolWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCompilerWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4Compiler? CreateCompiler (MTL4CompilerDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4Compiler? _CreateCompiler (IMTLDevice This, MTL4CompilerDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4Compiler? ret;
			ret =  Runtime.GetINativeObject<IMTL4Compiler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newCompilerWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newArchiveWithURL:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4Archive? CreateArchive (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4Archive? _CreateArchive (IMTLDevice This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4Archive? ret;
			ret =  Runtime.GetINativeObject<IMTL4Archive> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newArchiveWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newPipelineDataSetSerializerWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4PipelineDataSetSerializer CreatePipelineDataSetSerializer (MTL4PipelineDataSetSerializerDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4PipelineDataSetSerializer _CreatePipelineDataSetSerializer (IMTLDevice This, MTL4PipelineDataSetSerializerDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTL4PipelineDataSetSerializer? ret;
			ret =  Runtime.GetINativeObject<IMTL4PipelineDataSetSerializer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newPipelineDataSetSerializerWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithLength:options:placementSparsePageSize:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options, MTLSparsePageSize placementSparsePageSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer? _CreateBuffer (IMTLDevice This, nuint length, MTLResourceOptions options, MTLSparsePageSize placementSparsePageSize)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("newBufferWithLength:options:placementSparsePageSize:"), length, (UIntPtr) (ulong) options, (IntPtr) (long) placementSparsePageSize), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newCounterHeapWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CounterHeap? CreateCounterHeap (MTL4CounterHeapDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CounterHeap? _CreateCounterHeap (IMTLDevice This, MTL4CounterHeapDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4CounterHeap? ret;
			ret =  Runtime.GetINativeObject<IMTL4CounterHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newCounterHeapWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("sizeOfCounterHeapEntry:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetSizeOf (MTL4CounterHeapType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetSizeOf (IMTLDevice This, MTL4CounterHeapType type)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sizeOfCounterHeapEntry:"), (IntPtr) (long) type);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithBinaryFunction:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? CreateFunctionHandle (IMTL4BinaryFunction function)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _CreateFunctionHandle (IMTLDevice This, IMTL4BinaryFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("functionHandleWithBinaryFunction:"), function__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[DynamicDependencyAttribute ("Architecture")]
		[DynamicDependencyAttribute ("ArgumentBuffersSupport")]
		[DynamicDependencyAttribute ("BarycentricCoordsSupported")]
		[DynamicDependencyAttribute ("ConvertSparsePixelRegions(System.IntPtr,System.IntPtr,Metal.MTLSize,Metal.MTLSparseTextureRegionAlignmentMode,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ConvertSparseTileRegions(System.IntPtr,System.IntPtr,Metal.MTLSize,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CounterSets")]
		[DynamicDependencyAttribute ("CreateAccelerationStructure(Metal.MTLAccelerationStructureDescriptor)")]
		[DynamicDependencyAttribute ("CreateAccelerationStructure(System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateAccelerationStructureSizes(Metal.MTLAccelerationStructureDescriptor)")]
		[DynamicDependencyAttribute ("CreateArchive(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateArgumentEncoder(Metal.IMTLBufferBinding)")]
		[DynamicDependencyAttribute ("CreateArgumentEncoder(Metal.MTLArgumentDescriptor[])")]
		[DynamicDependencyAttribute ("CreateArgumentTable(Metal.MTL4ArgumentTableDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateBinaryArchive(Metal.MTLBinaryArchiveDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateBuffer(System.IntPtr,System.UIntPtr,Metal.MTLResourceOptions)")]
		[DynamicDependencyAttribute ("CreateBuffer(System.UIntPtr,Metal.MTLResourceOptions,Metal.MTLSparsePageSize)")]
		[DynamicDependencyAttribute ("CreateBuffer(System.UIntPtr,Metal.MTLResourceOptions)")]
		[DynamicDependencyAttribute ("CreateBufferNoCopy(System.IntPtr,System.UIntPtr,Metal.MTLResourceOptions,Metal.MTLDeallocator)")]
		[DynamicDependencyAttribute ("CreateCommandAllocator()")]
		[DynamicDependencyAttribute ("CreateCommandAllocator(Metal.MTL4CommandAllocatorDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateCommandBuffer()")]
		[DynamicDependencyAttribute ("CreateCommandQueue()")]
		[DynamicDependencyAttribute ("CreateCommandQueue(Metal.MTLCommandQueueDescriptor)")]
		[DynamicDependencyAttribute ("CreateCommandQueue(System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateCompiler(Metal.MTL4CompilerDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.IMTLFunction,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.IMTLFunction,Metal.MTLPipelineOption,Metal.MTLComputePipelineReflection@,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.IMTLFunction,Metal.MTLPipelineOption,System.Action{Metal.IMTLComputePipelineState,Metal.MTLComputePipelineReflection,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.IMTLFunction,System.Action{Metal.IMTLComputePipelineState,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTLComputePipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLComputePipelineReflection@,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTLComputePipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLNewComputePipelineStateWithReflectionCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateCounterHeap(Metal.MTL4CounterHeapDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateCounterSampleBuffer(Metal.MTLCounterSampleBufferDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateDefaultLibrary()")]
		[DynamicDependencyAttribute ("CreateDefaultLibrary(Foundation.NSBundle,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateDepthStencilState(Metal.MTLDepthStencilDescriptor)")]
		[DynamicDependencyAttribute ("CreateDynamicLibrary(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateDynamicLibrary(Metal.IMTLLibrary,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateEvent()")]
		[DynamicDependencyAttribute ("CreateFence()")]
		[DynamicDependencyAttribute ("CreateFunctionHandle(Metal.IMTL4BinaryFunction)")]
		[DynamicDependencyAttribute ("CreateFunctionHandle(Metal.IMTLFunction)")]
		[DynamicDependencyAttribute ("CreateHeap(Metal.MTLHeapDescriptor)")]
		[DynamicDependencyAttribute ("CreateIndirectCommandBuffer(Metal.MTLIndirectCommandBufferDescriptor,System.UIntPtr,Metal.MTLResourceOptions)")]
		[DynamicDependencyAttribute ("CreateLibrary(CoreFoundation.DispatchData,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateLibrary(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateLibrary(Metal.MTLStitchedLibraryDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateLibrary(Metal.MTLStitchedLibraryDescriptor,System.Action{Metal.IMTLLibrary,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateLibrary(System.String,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateLibrary(System.String,Metal.MTLCompileOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateLibrary(System.String,Metal.MTLCompileOptions,System.Action{Metal.IMTLLibrary,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateMTL4CommandQueue()")]
		[DynamicDependencyAttribute ("CreateMTL4CommandQueue(Metal.MTL4CommandQueueDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreatePipelineDataSetSerializer(Metal.MTL4PipelineDataSetSerializerDescriptor)")]
		[DynamicDependencyAttribute ("CreateRasterizationRateMap(Metal.MTLRasterizationRateMapDescriptor)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLMeshRenderPipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLNewRenderPipelineStateWithReflectionCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLMeshRenderPipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLRenderPipelineReflection@,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLRenderPipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLRenderPipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLRenderPipelineReflection@,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLRenderPipelineDescriptor,Metal.MTLPipelineOption,System.Action{Metal.IMTLRenderPipelineState,Metal.MTLRenderPipelineReflection,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLRenderPipelineDescriptor,System.Action{Metal.IMTLRenderPipelineState,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLTileRenderPipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLNewRenderPipelineStateWithReflectionCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTLTileRenderPipelineDescriptor,Metal.MTLPipelineOption,Metal.MTLRenderPipelineReflection@,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateResidencySet(Metal.MTLResidencySetDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateSamplerState(Metal.MTLSamplerDescriptor)")]
		[DynamicDependencyAttribute ("CreateSharedEvent()")]
		[DynamicDependencyAttribute ("CreateSharedEvent(Metal.MTLSharedEventHandle)")]
		[DynamicDependencyAttribute ("CreateSharedTexture(Metal.MTLSharedTextureHandle)")]
		[DynamicDependencyAttribute ("CreateSharedTexture(Metal.MTLTextureDescriptor)")]
		[DynamicDependencyAttribute ("CreateTensor(Metal.MTLTensorDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateTensorSizeAndAlign(Metal.MTLTensorDescriptor)")]
		[DynamicDependencyAttribute ("CreateTexture(Metal.MTLTextureDescriptor,IOSurface.IOSurface,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateTexture(Metal.MTLTextureDescriptor)")]
		[DynamicDependencyAttribute ("CreateTextureViewPool(Metal.MTLResourceViewPoolDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CurrentAllocatedSize")]
		[DynamicDependencyAttribute ("Depth24Stencil8PixelFormatSupported")]
		[DynamicDependencyAttribute ("GetDefaultSamplePositions(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetHeapAccelerationStructureSizeAndAlign(Metal.MTLAccelerationStructureDescriptor)")]
		[DynamicDependencyAttribute ("GetHeapAccelerationStructureSizeAndAlign(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetHeapBufferSizeAndAlignWithLength(System.UIntPtr,Metal.MTLResourceOptions)")]
		[DynamicDependencyAttribute ("GetHeapTextureSizeAndAlign(Metal.MTLTextureDescriptor)")]
		[DynamicDependencyAttribute ("GetMinimumLinearTextureAlignment(Metal.MTLPixelFormat)")]
		[DynamicDependencyAttribute ("GetMinimumTextureBufferAlignment(Metal.MTLPixelFormat)")]
		[DynamicDependencyAttribute ("GetNewLogState(Metal.MTLLogStateDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetSampleTimestamps(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetSizeOf(Metal.MTL4CounterHeapType)")]
		[DynamicDependencyAttribute ("GetSparseTileSize(Metal.MTLTextureType,Metal.MTLPixelFormat,System.UIntPtr,Metal.MTLSparsePageSize)")]
		[DynamicDependencyAttribute ("GetSparseTileSize(Metal.MTLTextureType,Metal.MTLPixelFormat,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetSparseTileSizeInBytes(Metal.MTLSparsePageSize)")]
		[DynamicDependencyAttribute ("HasUnifiedMemory")]
		[DynamicDependencyAttribute ("Headless")]
		[DynamicDependencyAttribute ("Location")]
		[DynamicDependencyAttribute ("LocationNumber")]
		[DynamicDependencyAttribute ("LowPower")]
		[DynamicDependencyAttribute ("MaxArgumentBufferSamplerCount")]
		[DynamicDependencyAttribute ("MaxBufferLength")]
		[DynamicDependencyAttribute ("MaximumConcurrentCompilationTaskCount")]
		[DynamicDependencyAttribute ("MaxThreadgroupMemoryLength")]
		[DynamicDependencyAttribute ("MaxThreadsPerThreadgroup")]
		[DynamicDependencyAttribute ("MaxTransferRate")]
		[DynamicDependencyAttribute ("Name")]
		[DynamicDependencyAttribute ("PeerCount")]
		[DynamicDependencyAttribute ("PeerGroupId")]
		[DynamicDependencyAttribute ("PeerIndex")]
		[DynamicDependencyAttribute ("ProgrammableSamplePositionsSupported")]
		[DynamicDependencyAttribute ("QueryTimestampFrequency")]
		[DynamicDependencyAttribute ("RasterOrderGroupsSupported")]
		[DynamicDependencyAttribute ("ReadWriteTextureSupport")]
		[DynamicDependencyAttribute ("RecommendedMaxWorkingSetSize")]
		[DynamicDependencyAttribute ("RegistryId")]
		[DynamicDependencyAttribute ("Removable")]
		[DynamicDependencyAttribute ("ShouldMaximizeConcurrentCompilation")]
		[DynamicDependencyAttribute ("SparseTileSizeInBytes")]
		[DynamicDependencyAttribute ("Supports32BitFloatFiltering")]
		[DynamicDependencyAttribute ("Supports32BitMsaa")]
		[DynamicDependencyAttribute ("SupportsBCTextureCompression")]
		[DynamicDependencyAttribute ("SupportsCounterSampling(Metal.MTLCounterSamplingPoint)")]
		[DynamicDependencyAttribute ("SupportsDynamicLibraries")]
		[DynamicDependencyAttribute ("SupportsFamily(Metal.MTLGpuFamily)")]
		[DynamicDependencyAttribute ("SupportsFeatureSet(Metal.MTLFeatureSet)")]
		[DynamicDependencyAttribute ("SupportsFunctionPointers")]
		[DynamicDependencyAttribute ("SupportsFunctionPointersFromRender")]
		[DynamicDependencyAttribute ("SupportsPlacementSparse")]
		[DynamicDependencyAttribute ("SupportsPrimitiveMotionBlur")]
		[DynamicDependencyAttribute ("SupportsPullModelInterpolation")]
		[DynamicDependencyAttribute ("SupportsQueryTextureLod")]
		[DynamicDependencyAttribute ("SupportsRasterizationRateMap(System.UIntPtr)")]
		[DynamicDependencyAttribute ("SupportsRaytracing")]
		[DynamicDependencyAttribute ("SupportsRaytracingFromRender")]
		[DynamicDependencyAttribute ("SupportsRenderDynamicLibraries")]
		[DynamicDependencyAttribute ("SupportsShaderBarycentricCoordinates")]
		[DynamicDependencyAttribute ("SupportsTextureSampleCount(System.UIntPtr)")]
		[DynamicDependencyAttribute ("SupportsVertexAmplification(System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLDeviceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLDevice ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Name {
			[Export ("name")]
			get {
				return _GetName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetName (IMTLDevice This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("name")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the number of threads per threadgroup on the device.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual MTLSize MaxThreadsPerThreadgroup {
			[Export ("maxThreadsPerThreadgroup")]
			get {
				return _GetMaxThreadsPerThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetMaxThreadsPerThreadgroup (IMTLDevice This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("maxThreadsPerThreadgroup"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("maxThreadsPerThreadgroup"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool LowPower {
			[Export ("isLowPower")]
			get {
				return _GetLowPower (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetLowPower (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isLowPower"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool Headless {
			[Export ("isHeadless")]
			get {
				return _GetHeadless (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHeadless (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isHeadless"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual ulong RecommendedMaxWorkingSetSize {
			[Export ("recommendedMaxWorkingSetSize")]
			get {
				return _GetRecommendedMaxWorkingSetSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetRecommendedMaxWorkingSetSize (IMTLDevice This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("recommendedMaxWorkingSetSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool Depth24Stencil8PixelFormatSupported {
			[Export ("isDepth24Stencil8PixelFormatSupported")]
			get {
				return _GetDepth24Stencil8PixelFormatSupported (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetDepth24Stencil8PixelFormatSupported (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDepth24Stencil8PixelFormatSupported"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool Removable {
			[Export ("isRemovable")]
			get {
				return _GetRemovable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRemovable (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRemovable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets the texture read-write support tier.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual MTLReadWriteTextureTier ReadWriteTextureSupport {
			[Export ("readWriteTextureSupport")]
			get {
				return _GetReadWriteTextureSupport (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLReadWriteTextureTier _GetReadWriteTextureSupport (IMTLDevice This)
		{
			MTLReadWriteTextureTier ret;
			ret = (MTLReadWriteTextureTier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("readWriteTextureSupport"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the argument buffer support tier.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual MTLArgumentBuffersTier ArgumentBuffersSupport {
			[Export ("argumentBuffersSupport")]
			get {
				return _GetArgumentBuffersSupport (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLArgumentBuffersTier _GetArgumentBuffersSupport (IMTLDevice This)
		{
			MTLArgumentBuffersTier ret;
			ret = (MTLArgumentBuffersTier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("argumentBuffersSupport"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns a Boolean value that tells whether raster order groups are supported.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool RasterOrderGroupsSupported {
			[Export ("areRasterOrderGroupsSupported")]
			get {
				return _GetRasterOrderGroupsSupported (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRasterOrderGroupsSupported (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("areRasterOrderGroupsSupported"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets the largest available length of memory for threadgroups.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxThreadgroupMemoryLength {
			[Export ("maxThreadgroupMemoryLength")]
			get {
				return _GetMaxThreadgroupMemoryLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxThreadgroupMemoryLength (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxThreadgroupMemoryLength"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxArgumentBufferSamplerCount {
			[Export ("maxArgumentBufferSamplerCount")]
			get {
				return _GetMaxArgumentBufferSamplerCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxArgumentBufferSamplerCount (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxArgumentBufferSamplerCount"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns a Boolean value that tells whether programmable sample positions are supported.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool ProgrammableSamplePositionsSupported {
			[Export ("areProgrammableSamplePositionsSupported")]
			get {
				return _GetProgrammableSamplePositionsSupported (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetProgrammableSamplePositionsSupported (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("areProgrammableSamplePositionsSupported"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxBufferLength {
			[Export ("maxBufferLength")]
			get {
				return _GetMaxBufferLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxBufferLength (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxBufferLength"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the registry ID.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual ulong RegistryId {
			[Export ("registryID")]
			get {
				return _GetRegistryId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetRegistryId (IMTLDevice This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("registryID"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the size, in bytes, of all the resources that the device has allocated.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint CurrentAllocatedSize {
			[Export ("currentAllocatedSize")]
			get {
				return _GetCurrentAllocatedSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetCurrentAllocatedSize (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("currentAllocatedSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint SparseTileSizeInBytes {
			[Export ("sparseTileSizeInBytes")]
			get {
				return _GetSparseTileSizeInBytes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetSparseTileSizeInBytes (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sparseTileSizeInBytes"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool HasUnifiedMemory {
			[Export ("hasUnifiedMemory")]
			get {
				return _GetHasUnifiedMemory (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHasUnifiedMemory (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasUnifiedMemory"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool BarycentricCoordsSupported {
			[Export ("areBarycentricCoordsSupported")]
			get {
				return _GetBarycentricCoordsSupported (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetBarycentricCoordsSupported (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("areBarycentricCoordsSupported"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsShaderBarycentricCoordinates {
			[Export ("supportsShaderBarycentricCoordinates")]
			get {
				return _GetSupportsShaderBarycentricCoordinates (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsShaderBarycentricCoordinates (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsShaderBarycentricCoordinates"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual uint PeerIndex {
			[Export ("peerIndex")]
			get {
				return _GetPeerIndex (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static uint _GetPeerIndex (IMTLDevice This)
		{
			uint ret;
			ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("peerIndex"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual uint PeerCount {
			[Export ("peerCount")]
			get {
				return _GetPeerCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static uint _GetPeerCount (IMTLDevice This)
		{
			uint ret;
			ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("peerCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual IMTLCounterSet[]? CounterSets {
			[Export ("counterSets")]
			get {
				return _GetCounterSets (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCounterSet[] _GetCounterSets (IMTLDevice This)
		{
			IMTLCounterSet[] ret;
			ret = CFArray.ArrayFromHandle<IMTLCounterSet>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("counterSets")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual ulong PeerGroupId {
			[Export ("peerGroupID")]
			get {
				return _GetPeerGroupId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetPeerGroupId (IMTLDevice This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("peerGroupID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual ulong MaxTransferRate {
			[Export ("maxTransferRate")]
			get {
				return _GetMaxTransferRate (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetMaxTransferRate (IMTLDevice This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("maxTransferRate"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLDeviceLocation Location {
			[Export ("location")]
			get {
				return _GetLocation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLDeviceLocation _GetLocation (IMTLDevice This)
		{
			MTLDeviceLocation ret;
			ret = (MTLDeviceLocation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("location"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint LocationNumber {
			[Export ("locationNumber")]
			get {
				return _GetLocationNumber (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetLocationNumber (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("locationNumber"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool Supports32BitFloatFiltering {
			[Export ("supports32BitFloatFiltering")]
			get {
				return _GetSupports32BitFloatFiltering (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupports32BitFloatFiltering (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supports32BitFloatFiltering"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool Supports32BitMsaa {
			[Export ("supports32BitMSAA")]
			get {
				return _GetSupports32BitMsaa (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupports32BitMsaa (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supports32BitMSAA"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsBCTextureCompression {
			[Export ("supportsBCTextureCompression")]
			get {
				return _GetSupportsBCTextureCompression (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsBCTextureCompression (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsBCTextureCompression"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsPullModelInterpolation {
			[Export ("supportsPullModelInterpolation")]
			get {
				return _GetSupportsPullModelInterpolation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsPullModelInterpolation (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsPullModelInterpolation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsDynamicLibraries {
			[Export ("supportsDynamicLibraries")]
			get {
				return _GetSupportsDynamicLibraries (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsDynamicLibraries (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsDynamicLibraries"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsRaytracing {
			[Export ("supportsRaytracing")]
			get {
				return _GetSupportsRaytracing (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsRaytracing (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsRaytracing"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsFunctionPointers {
			[Export ("supportsFunctionPointers")]
			get {
				return _GetSupportsFunctionPointers (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsFunctionPointers (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsFunctionPointers"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsQueryTextureLod {
			[Export ("supportsQueryTextureLOD")]
			get {
				return _GetSupportsQueryTextureLod (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsQueryTextureLod (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsQueryTextureLOD"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsRenderDynamicLibraries {
			[Export ("supportsRenderDynamicLibraries")]
			get {
				return _GetSupportsRenderDynamicLibraries (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsRenderDynamicLibraries (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsRenderDynamicLibraries"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsRaytracingFromRender {
			[Export ("supportsRaytracingFromRender")]
			get {
				return _GetSupportsRaytracingFromRender (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsRaytracingFromRender (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsRaytracingFromRender"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsPrimitiveMotionBlur {
			[Export ("supportsPrimitiveMotionBlur")]
			get {
				return _GetSupportsPrimitiveMotionBlur (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsPrimitiveMotionBlur (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsPrimitiveMotionBlur"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsFunctionPointersFromRender {
			[Export ("supportsFunctionPointersFromRender")]
			get {
				return _GetSupportsFunctionPointersFromRender (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsFunctionPointersFromRender (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsFunctionPointersFromRender"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLArchitecture Architecture {
			[Export ("architecture")]
			get {
				return _GetArchitecture (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLArchitecture _GetArchitecture (IMTLDevice This)
		{
			MTLArchitecture ret;
			ret =  Runtime.GetNSObject<MTLArchitecture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("architecture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.1")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("tvos26.1")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaximumConcurrentCompilationTaskCount {
			[Export ("maximumConcurrentCompilationTaskCount")]
			get {
				return _GetMaximumConcurrentCompilationTaskCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaximumConcurrentCompilationTaskCount (IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumConcurrentCompilationTaskCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.3")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual bool ShouldMaximizeConcurrentCompilation {
			[Export ("shouldMaximizeConcurrentCompilation")]
			get {
				return _GetShouldMaximizeConcurrentCompilation (this);
			}
			[Export ("setShouldMaximizeConcurrentCompilation:")]
			set {
				_SetShouldMaximizeConcurrentCompilation (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShouldMaximizeConcurrentCompilation (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldMaximizeConcurrentCompilation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetShouldMaximizeConcurrentCompilation (IMTLDevice This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShouldMaximizeConcurrentCompilation:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual ulong QueryTimestampFrequency {
			[Export ("queryTimestampFrequency")]
			get {
				return _GetQueryTimestampFrequency (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetQueryTimestampFrequency (IMTLDevice This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("queryTimestampFrequency"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsPlacementSparse {
			[Export ("supportsPlacementSparse")]
			get {
				return _GetSupportsPlacementSparse (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsPlacementSparse (IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsPlacementSparse"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLDevice" /> interface to support all the methods from the MTLDevice protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLDevice" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLDevice protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLDevice_Extensions {
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConvertSparseTileRegions (this IMTLDevice This, nint tileRegions, nint pixelRegions, MTLSize tileSize, nuint numRegions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_MTLSize_UIntPtr (This.Handle, Selector.GetHandle ("convertSparseTileRegions:toPixelRegions:withTileSize:numRegions:"), tileRegions, pixelRegions, tileSize, numRegions);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConvertSparsePixelRegions (this IMTLDevice This, nint pixelRegions, nint tileRegions, MTLSize tileSize, MTLSparseTextureRegionAlignmentMode mode, nuint numRegions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_MTLSize_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("convertSparsePixelRegions:toTileRegions:withTileSize:alignmentMode:numRegions:"), pixelRegions, tileRegions, tileSize, (UIntPtr) (ulong) mode, numRegions);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsVertexAmplification (this IMTLDevice This, nuint count)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsVertexAmplificationCount:"), count);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsRasterizationRateMap (this IMTLDevice This, nuint layerCount)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("supportsRasterizationRateMapWithLayerCount:"), layerCount);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLSize GetSparseTileSize (this IMTLDevice This, MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLRasterizationRateMap? CreateRasterizationRateMap (this IMTLDevice This, MTLRasterizationRateMapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLRasterizationRateMap? ret;
			ret =  Runtime.GetINativeObject<IMTLRasterizationRateMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newRasterizationRateMapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLAccelerationStructureSizes CreateAccelerationStructureSizes (this IMTLDevice This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLAccelerationStructureSizes ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLAccelerationStructureSizes_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accelerationStructureSizesWithDescriptor:"), descriptor__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLAccelerationStructureSizes_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("accelerationStructureSizesWithDescriptor:"), descriptor__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructure? CreateAccelerationStructure (this IMTLDevice This, nuint size)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:"), size), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructure? CreateAccelerationStructure (this IMTLDevice This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLSizeAndAlign GetHeapAccelerationStructureSizeAndAlign (this IMTLDevice This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("heapAccelerationStructureSizeAndAlignWithDescriptor:"), descriptor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLSizeAndAlign GetHeapAccelerationStructureSizeAndAlign (this IMTLDevice This, nuint size)
		{
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("heapAccelerationStructureSizeAndAlignWithSize:"), size);
			GC.KeepAlive (This);
			return ret;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLArgumentEncoder CreateArgumentEncoder (this IMTLDevice This, IMTLBufferBinding bufferBinding)
		{
			var bufferBinding__handle__ = bufferBinding!.GetNonNullHandle (nameof (bufferBinding));
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferBinding:"), bufferBinding__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (bufferBinding);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMTLRenderPipelineState? CreateRenderPipelineState (this IMTLDevice This, MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithMeshDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CreateRenderPipelineState (this IMTLDevice This, MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewRenderPipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithMeshDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetSparseTileSizeInBytes (this IMTLDevice This, MTLSparsePageSize sparsePageSize)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeInBytesForSparsePageSize:"), (IntPtr) (long) sparsePageSize);
			GC.KeepAlive (This);
			return ret;
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLSize GetSparseTileSize (this IMTLDevice This, MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount, MTLSparsePageSize sparsePageSize)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount, (IntPtr) (long) sparsePageSize);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr_UIntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount, (IntPtr) (long) sparsePageSize);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<IMTLLibrary> CreateLibraryAsync (this IMTLDevice This, string source, MTLCompileOptions options)
		{
			var tcs = new TaskCompletionSource<IMTLLibrary> ();
			This.CreateLibrary(source, options, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<IMTLLibrary> CreateLibraryAsync (this IMTLDevice This, MTLStitchedLibraryDescriptor descriptor)
		{
			var tcs = new TaskCompletionSource<IMTLLibrary> ();
			This.CreateLibrary(descriptor, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetSparseTileSizeInBytes (this IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sparseTileSizeInBytes"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsShaderBarycentricCoordinates (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsShaderBarycentricCoordinates"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupports32BitFloatFiltering (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supports32BitFloatFiltering"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupports32BitMsaa (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supports32BitMSAA"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsRaytracing (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsRaytracing"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsFunctionPointers (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsFunctionPointers"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsQueryTextureLod (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsQueryTextureLOD"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsRaytracingFromRender (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsRaytracingFromRender"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsPrimitiveMotionBlur (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsPrimitiveMotionBlur"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsFunctionPointersFromRender (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsFunctionPointersFromRender"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLArchitecture GetArchitecture (this IMTLDevice This)
		{
			MTLArchitecture ret;
			ret =  Runtime.GetNSObject<MTLArchitecture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("architecture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetMaximumConcurrentCompilationTaskCount (this IMTLDevice This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumConcurrentCompilationTaskCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetShouldMaximizeConcurrentCompilation (this IMTLDevice This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldMaximizeConcurrentCompilation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetShouldMaximizeConcurrentCompilation (this IMTLDevice This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShouldMaximizeConcurrentCompilation:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLDeviceWrapper : BaseWrapper, IMTLDevice {
		public MTLDeviceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLDeviceWrapper))]
		static MTLDeviceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the size and alignment of a texture with specified description, when allocated from a heap.</summary>
		[Export ("heapTextureSizeAndAlignWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSizeAndAlign GetHeapTextureSizeAndAlign (MTLTextureDescriptor desc)
		{
			var desc__handle__ = desc!.GetNonNullHandle (nameof (desc));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("heapTextureSizeAndAlignWithDescriptor:"), desc__handle__);
			GC.KeepAlive (desc);
			return ret!;
		}
		[Export ("heapBufferSizeAndAlignWithLength:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSizeAndAlign GetHeapBufferSizeAndAlignWithLength (nuint length, MTLResourceOptions options)
		{
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("heapBufferSizeAndAlignWithLength:options:"), length, (UIntPtr) (ulong) options);
			return ret;
		}
		/// <summary>Creates and returns a new heap.</summary>
		[Export ("newHeapWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLHeap? CreateHeap (MTLHeapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLHeap? ret;
			ret =  Runtime.GetINativeObject<IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newHeapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newCommandQueue")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandQueue? CreateCommandQueue ()
		{
			IMTLCommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newCommandQueue")), true)!;
			return ret!;
		}
		/// <param name="maxCommandBufferCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newCommandQueueWithMaxCommandBufferCount:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandQueue? CreateCommandQueue (nuint maxCommandBufferCount)
		{
			IMTLCommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newCommandQueueWithMaxCommandBufferCount:"), maxCommandBufferCount), true)!;
			return ret!;
		}
		/// <param name="length">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferWithLength:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newBufferWithLength:options:"), length, (UIntPtr) (ulong) options), true)!;
			return ret!;
		}
		[Export ("newBufferWithBytes:length:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBuffer? CreateBuffer (nint pointer, nuint length, MTLResourceOptions options)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newBufferWithBytes:length:options:"), pointer, length, (UIntPtr) (ulong) options), true)!;
			return ret!;
		}
		/// <summary>Creates and returns a new buffer that is wrapped around the specified data, and runs an optional <paramref name="deallocator" /> when the memory is deallocated.</summary><param name="pointer">The data to wrap.</param><param name="length">The length of the data to wrap.</param><param name="options">Options for creating the buffer.</param><param name="deallocator">The deallocator to use when deleting the buffer.</param>
		[Export ("newBufferWithBytesNoCopy:length:options:deallocator:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLBuffer? CreateBufferNoCopy (nint pointer, nuint length, MTLResourceOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLDeallocator))]MTLDeallocator deallocator)
		{
			if (deallocator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deallocator));
			using var block_deallocator = Trampolines.SDMTLDeallocator.CreateBlock (deallocator);
			BlockLiteral *block_ptr_deallocator = &block_deallocator;
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_UIntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("newBufferWithBytesNoCopy:length:options:deallocator:"), pointer, length, (UIntPtr) (ulong) options, (IntPtr) block_ptr_deallocator), true)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newDepthStencilStateWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDepthStencilState? CreateDepthStencilState (MTLDepthStencilDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLDepthStencilState? ret;
			ret =  Runtime.GetINativeObject<IMTLDepthStencilState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newDepthStencilStateWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newTextureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newTextureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>Creates a Metal texture with the specified values.</summary>
		[Export ("newTextureWithDescriptor:iosurface:plane:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor, global::IOSurface.IOSurface iosurface, nuint plane)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var iosurface__handle__ = iosurface!.GetNonNullHandle (nameof (iosurface));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newTextureWithDescriptor:iosurface:plane:"), descriptor__handle__, iosurface__handle__, plane), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (iosurface);
			return ret!;
		}
		[Export ("newSharedTextureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateSharedTexture (MTLTextureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newSharedTextureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newSharedTextureWithHandle:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateSharedTexture (MTLSharedTextureHandle sharedHandle)
		{
			var sharedHandle__handle__ = sharedHandle!.GetNonNullHandle (nameof (sharedHandle));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newSharedTextureWithHandle:"), sharedHandle__handle__), true)!;
			GC.KeepAlive (sharedHandle);
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newSamplerStateWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLSamplerState? CreateSamplerState (MTLSamplerDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLSamplerState? ret;
			ret =  Runtime.GetINativeObject<IMTLSamplerState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newSamplerStateWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newDefaultLibrary")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLLibrary CreateDefaultLibrary ()
		{
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newDefaultLibrary")), true)!;
			return ret!;
		}
		/// <param name="filepath">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newLibraryWithFile:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary CreateLibrary (string filepath, out NSError error)
		{
			if (filepath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filepath));
			NativeHandle errorValue = IntPtr.Zero;
			var nsfilepath = CFString.CreateNative (filepath);
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithFile:error:"), nsfilepath, &errorValue), true)!;
			CFString.ReleaseNative (nsfilepath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newLibraryWithData:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary CreateLibrary (global::CoreFoundation.DispatchData data, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithData:error:"), data__handle__, &errorValue), true)!;
			GC.KeepAlive (data);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="source">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newLibraryWithSource:options:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary CreateLibrary (string source, MTLCompileOptions options, out NSError error)
		{
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			var nssource = CFString.CreateNative (source);
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithSource:options:error:"), nssource, options__handle__, &errorValue), true)!;
			GC.KeepAlive (options);
			CFString.ReleaseNative (nssource);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="source">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newLibraryWithSource:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateLibrary (string source, MTLCompileOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V112))]global::System.Action<IMTLLibrary, NSError> completionHandler)
		{
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssource = CFString.CreateNative (source);
			using var block_completionHandler = Trampolines.SDActionArity2V112.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithSource:options:completionHandler:"), nssource, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nssource);
		}
		/// <summary>Creates and returns a new library from the functions in the specified bundle.</summary>
		[Export ("newDefaultLibraryWithBundle:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary? CreateDefaultLibrary (NSBundle bundle, out NSError error)
		{
			var bundle__handle__ = bundle!.GetNonNullHandle (nameof (bundle));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newDefaultLibraryWithBundle:error:"), bundle__handle__, &errorValue), true)!;
			GC.KeepAlive (bundle);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newRenderPipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newRenderPipelineStateWithDescriptor:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V113))]global::System.Action<IMTLRenderPipelineState, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V113.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		/// <param name="descriptor">To be added.</param><param name="options">To be added.</param><param name="reflection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newRenderPipelineStateWithDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection reflection, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="descriptor">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newRenderPipelineStateWithDescriptor:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateRenderPipelineState (MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V15))]global::System.Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity3V15.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		/// <param name="computeFunction">To be added.</param><param name="options">To be added.</param><param name="reflection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newComputePipelineStateWithFunction:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState CreateComputePipelineState (IMTLFunction computeFunction, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:options:reflection:error:"), computeFunction__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (computeFunction);
			reflection = Runtime.GetNSObject<MTLComputePipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="computeFunction">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newComputePipelineStateWithFunction:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateComputePipelineState (IMTLFunction computeFunction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V114))]global::System.Action<IMTLComputePipelineState, NSError> completionHandler)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V114.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:completionHandler:"), computeFunction__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (computeFunction);
		}
		/// <param name="computeFunction">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newComputePipelineStateWithFunction:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState CreateComputePipelineState (IMTLFunction computeFunction, out NSError error)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:error:"), computeFunction__handle__, &errorValue), true)!;
			GC.KeepAlive (computeFunction);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="computeFunction">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newComputePipelineStateWithFunction:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateComputePipelineState (IMTLFunction computeFunction, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V16))]global::System.Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError> completionHandler)
		{
			var computeFunction__handle__ = computeFunction!.GetNonNullHandle (nameof (computeFunction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity3V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithFunction:options:completionHandler:"), computeFunction__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (computeFunction);
		}
		/// <summary>Creates a new pipeline state from the specified compute pipeline descriptor, options, and completion handler, and stores reflection information in the <paramref name="reflection" /><see langword="out" /> parameter.</summary>
		[Export ("newComputePipelineStateWithDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState CreateComputePipelineState (MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLComputePipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Creates a new pipeline state from the specified compute pipeline descriptor, options, and completion handler.</summary>
		[Export ("newComputePipelineStateWithDescriptor:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateComputePipelineState (MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewComputePipelineStateWithReflectionCompletionHandler))]MTLNewComputePipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewComputePipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		/// <summary>Creates and returns a new fence for tracking and managing dependencies between command encoders.</summary>
		[Export ("newFence")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFence CreateFence ()
		{
			IMTLFence? ret;
			ret =  Runtime.GetINativeObject<IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newFence")), true)!;
			return ret!;
		}
		/// <param name="featureSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("supportsFeatureSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsFeatureSet (MTLFeatureSet featureSet)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("supportsFeatureSet:"), (UIntPtr) (ulong) featureSet);
			return ret != 0;
		}
		/// <summary>Returns a Boolean value that tells whether the device supports the specified texture count.</summary>
		[Export ("supportsTextureSampleCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsTextureSampleCount (nuint sampleCount)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("supportsTextureSampleCount:"), sampleCount);
			return ret != 0;
		}
		/// <summary>Creates and returns a new library from the functions at the specified URL.</summary>
		[Export ("newLibraryWithURL:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary? CreateLibrary (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Gets the minimum alignment required for a linear texture in the given pixel format.</summary><param name="format">The pixel format. Depth, stencil, and compressed formats are not supported.</param>
		[Export ("minimumLinearTextureAlignmentForPixelFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetMinimumLinearTextureAlignment (MTLPixelFormat format)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("minimumLinearTextureAlignmentForPixelFormat:"), (UIntPtr) (ulong) format);
			return ret;
		}
		[Export ("minimumTextureBufferAlignmentForPixelFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetMinimumTextureBufferAlignment (MTLPixelFormat format)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("minimumTextureBufferAlignmentForPixelFormat:"), (UIntPtr) (ulong) format);
			return ret;
		}
		/// <summary>Provides the default sample positions for the specified sample <paramref name="count" />.</summary><param name="positions">Array that will be filled with the default sample postions.</param><param name="count">The number of positions, which determines the set of default positions.</param>
		[Export ("getDefaultSamplePositions:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetDefaultSamplePositions (nint positions, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("getDefaultSamplePositions:count:"), positions, count);
		}
		/// <summary>Creates an encoder for the specified array of arguments.</summary><param name="arguments">An array of arguments within a buffer.</param>
		[Export ("newArgumentEncoderWithArguments:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLArgumentEncoder? CreateArgumentEncoder (MTLArgumentDescriptor[] arguments)
		{
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newArgumentEncoderWithArguments:"), nsa_arguments.Handle), true)!;
			return ret!;
		}
		[Export ("newIndirectCommandBufferWithDescriptor:maxCommandCount:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLIndirectCommandBuffer? CreateIndirectCommandBuffer (MTLIndirectCommandBufferDescriptor descriptor, nuint maxCount, MTLResourceOptions options)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIndirectCommandBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLIndirectCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newIndirectCommandBufferWithDescriptor:maxCommandCount:options:"), descriptor__handle__, maxCount, (UIntPtr) (ulong) options), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newEvent")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLEvent? CreateEvent ()
		{
			IMTLEvent? ret;
			ret =  Runtime.GetINativeObject<IMTLEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newEvent")), true)!;
			return ret!;
		}
		[Export ("newSharedEvent")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLSharedEvent? CreateSharedEvent ()
		{
			IMTLSharedEvent? ret;
			ret =  Runtime.GetINativeObject<IMTLSharedEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newSharedEvent")), true)!;
			return ret!;
		}
		[Export ("newSharedEventWithHandle:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLSharedEvent? CreateSharedEvent (MTLSharedEventHandle sharedEventHandle)
		{
			var sharedEventHandle__handle__ = sharedEventHandle!.GetNonNullHandle (nameof (sharedEventHandle));
			IMTLSharedEvent? ret;
			ret =  Runtime.GetINativeObject<IMTLSharedEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newSharedEventWithHandle:"), sharedEventHandle__handle__), true)!;
			GC.KeepAlive (sharedEventHandle);
			return ret!;
		}
		[Export ("newRenderPipelineStateWithTileDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTLTileRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithTileDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateWithTileDescriptor:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateRenderPipelineState (MTLTileRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewRenderPipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithTileDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		[Export ("supportsVertexAmplificationCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsVertexAmplification (nuint count)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("supportsVertexAmplificationCount:"), count);
			return ret != 0;
		}
		[Export ("supportsRasterizationRateMapWithLayerCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsRasterizationRateMap (nuint layerCount)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("supportsRasterizationRateMapWithLayerCount:"), layerCount);
			return ret != 0;
		}
		[Export ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSize GetSparseTileSize (MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount);
			}
			return ret!;
		}
		[Export ("newRasterizationRateMapWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLRasterizationRateMap? CreateRasterizationRateMap (MTLRasterizationRateMapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLRasterizationRateMap? ret;
			ret =  Runtime.GetINativeObject<IMTLRasterizationRateMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newRasterizationRateMapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("supportsFamily:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsFamily (MTLGpuFamily gpuFamily)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("supportsFamily:"), (IntPtr) (long) gpuFamily);
			return ret != 0;
		}
		[Export ("newCounterSampleBufferWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLCounterSampleBuffer? CreateCounterSampleBuffer (MTLCounterSampleBufferDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLCounterSampleBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLCounterSampleBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newCounterSampleBufferWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("sampleTimestamps:gpuTimestamp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetSampleTimestamps (nuint cpuTimestamp, nuint gpuTimestamp)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("sampleTimestamps:gpuTimestamp:"), cpuTimestamp, gpuTimestamp);
		}
		[Export ("supportsCounterSampling:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsCounterSampling (MTLCounterSamplingPoint samplingPoint)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("supportsCounterSampling:"), (UIntPtr) (ulong) samplingPoint);
			return ret != 0;
		}
		[Export ("newDynamicLibrary:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLDynamicLibrary? CreateDynamicLibrary (IMTLLibrary library, out NSError? error)
		{
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newDynamicLibrary:error:"), library__handle__, &errorValue), true)!;
			GC.KeepAlive (library);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newDynamicLibraryWithURL:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLDynamicLibrary? CreateDynamicLibrary (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newDynamicLibraryWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newBinaryArchiveWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLBinaryArchive? CreateBinaryArchive (MTLBinaryArchiveDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLBinaryArchive? ret;
			ret =  Runtime.GetINativeObject<IMTLBinaryArchive> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newBinaryArchiveWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("accelerationStructureSizesWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLAccelerationStructureSizes CreateAccelerationStructureSizes (MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLAccelerationStructureSizes ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLAccelerationStructureSizes_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accelerationStructureSizesWithDescriptor:"), descriptor__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLAccelerationStructureSizes_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("accelerationStructureSizesWithDescriptor:"), descriptor__handle__);
			}
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newAccelerationStructureWithSize:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructure? CreateAccelerationStructure (nuint size)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:"), size), true)!;
			return ret!;
		}
		[Export ("newAccelerationStructureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructure? CreateAccelerationStructure (MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newLibraryWithStitchedDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary? CreateLibrary (MTLStitchedLibraryDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithStitchedDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newLibraryWithStitchedDescriptor:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateLibrary (MTLStitchedLibraryDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V112))]global::System.Action<IMTLLibrary, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V112.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithStitchedDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		[Export ("heapAccelerationStructureSizeAndAlignWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSizeAndAlign GetHeapAccelerationStructureSizeAndAlign (MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("heapAccelerationStructureSizeAndAlignWithDescriptor:"), descriptor__handle__);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("heapAccelerationStructureSizeAndAlignWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSizeAndAlign GetHeapAccelerationStructureSizeAndAlign (nuint size)
		{
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("heapAccelerationStructureSizeAndAlignWithSize:"), size);
			return ret;
		}
		[Export ("newArgumentEncoderWithBufferBinding:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLArgumentEncoder CreateArgumentEncoder (IMTLBufferBinding bufferBinding)
		{
			var bufferBinding__handle__ = bufferBinding!.GetNonNullHandle (nameof (bufferBinding));
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferBinding:"), bufferBinding__handle__), true)!;
			GC.KeepAlive (bufferBinding);
			return ret!;
		}
		[Export ("newRenderPipelineStateWithMeshDescriptor:options:reflection:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection? reflection, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle reflectionValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithMeshDescriptor:options:reflection:error:"), descriptor__handle__, (UIntPtr) (ulong) options, &reflectionValue, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			reflection = Runtime.GetNSObject<MTLRenderPipelineReflection> (reflectionValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateWithMeshDescriptor:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateRenderPipelineState (MTLMeshRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLNewRenderPipelineStateWithReflectionCompletionHandler))]MTLNewRenderPipelineStateWithReflectionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLNewRenderPipelineStateWithReflectionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithMeshDescriptor:options:completionHandler:"), descriptor__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		[Export ("sparseTileSizeInBytesForSparsePageSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetSparseTileSizeInBytes (MTLSparsePageSize sparsePageSize)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sparseTileSizeInBytesForSparsePageSize:"), (IntPtr) (long) sparsePageSize);
			return ret;
		}
		[Export ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSize GetSparseTileSize (MTLTextureType textureType, MTLPixelFormat pixelFormat, nuint sampleCount, MTLSparsePageSize sparsePageSize)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount, (IntPtr) (long) sparsePageSize);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("sparseTileSizeWithTextureType:pixelFormat:sampleCount:sparsePageSize:"), (UIntPtr) (ulong) textureType, (UIntPtr) (ulong) pixelFormat, sampleCount, (IntPtr) (long) sparsePageSize);
			}
			return ret!;
		}
		[Export ("newLogStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLogState? GetNewLogState (MTLLogStateDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLogState? ret;
			ret =  Runtime.GetINativeObject<IMTLLogState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLogStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newCommandQueueWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandQueue? CreateCommandQueue (MTLCommandQueueDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLCommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newCommandQueueWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newResidencySetWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLResidencySet? CreateResidencySet (MTLResidencySetDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLResidencySet? ret;
			ret =  Runtime.GetINativeObject<IMTLResidencySet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newResidencySetWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("tensorSizeAndAlignWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSizeAndAlign CreateTensorSizeAndAlign (MTLTensorDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("tensorSizeAndAlignWithDescriptor:"), descriptor__handle__);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newTensorWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLTensor? CreateTensor (MTLTensorDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLTensor? ret;
			ret =  Runtime.GetINativeObject<IMTLTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newTensorWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("functionHandleWithFunction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? CreateFunctionHandle (IMTLFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("functionHandleWithFunction:"), function__handle__), false)!;
			GC.KeepAlive (function);
			return ret!;
		}
		[Export ("newCommandAllocator")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4CommandAllocator? CreateCommandAllocator ()
		{
			IMTL4CommandAllocator? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newCommandAllocator")), true)!;
			return ret!;
		}
		[Export ("newCommandAllocatorWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CommandAllocator? CreateCommandAllocator (MTL4CommandAllocatorDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4CommandAllocator? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newCommandAllocatorWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newMTL4CommandQueue")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4CommandQueue? CreateMTL4CommandQueue ()
		{
			IMTL4CommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newMTL4CommandQueue")), true)!;
			return ret!;
		}
		[Export ("newMTL4CommandQueueWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CommandQueue? CreateMTL4CommandQueue (MTL4CommandQueueDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4CommandQueue? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newMTL4CommandQueueWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newCommandBuffer")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4CommandBuffer? CreateCommandBuffer ()
		{
			IMTL4CommandBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newCommandBuffer")), true)!;
			return ret!;
		}
		[Export ("newArgumentTableWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4ArgumentTable? CreateArgumentTable (MTL4ArgumentTableDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4ArgumentTable? ret;
			ret =  Runtime.GetINativeObject<IMTL4ArgumentTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newArgumentTableWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newTextureViewPoolWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLTextureViewPool? CreateTextureViewPool (MTLResourceViewPoolDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLTextureViewPool? ret;
			ret =  Runtime.GetINativeObject<IMTLTextureViewPool> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newTextureViewPoolWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newCompilerWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4Compiler? CreateCompiler (MTL4CompilerDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4Compiler? ret;
			ret =  Runtime.GetINativeObject<IMTL4Compiler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newCompilerWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newArchiveWithURL:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4Archive? CreateArchive (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4Archive? ret;
			ret =  Runtime.GetINativeObject<IMTL4Archive> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newArchiveWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newPipelineDataSetSerializerWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4PipelineDataSetSerializer CreatePipelineDataSetSerializer (MTL4PipelineDataSetSerializerDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTL4PipelineDataSetSerializer? ret;
			ret =  Runtime.GetINativeObject<IMTL4PipelineDataSetSerializer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newPipelineDataSetSerializerWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newBufferWithLength:options:placementSparsePageSize:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options, MTLSparsePageSize placementSparsePageSize)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("newBufferWithLength:options:placementSparsePageSize:"), length, (UIntPtr) (ulong) options, (IntPtr) (long) placementSparsePageSize), true)!;
			return ret!;
		}
		[Export ("newCounterHeapWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CounterHeap? CreateCounterHeap (MTL4CounterHeapDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4CounterHeap? ret;
			ret =  Runtime.GetINativeObject<IMTL4CounterHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newCounterHeapWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("sizeOfCounterHeapEntry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetSizeOf (MTL4CounterHeapType type)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sizeOfCounterHeapEntry:"), (IntPtr) (long) type);
			return ret;
		}
		[Export ("functionHandleWithBinaryFunction:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? CreateFunctionHandle (IMTL4BinaryFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("functionHandleWithBinaryFunction:"), function__handle__), true)!;
			GC.KeepAlive (function);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Name {
			[Export ("name")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the number of threads per threadgroup on the device.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLSize MaxThreadsPerThreadgroup {
			[Export ("maxThreadsPerThreadgroup")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("maxThreadsPerThreadgroup"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("maxThreadsPerThreadgroup"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public bool LowPower {
			[Export ("isLowPower")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLowPower"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public bool Headless {
			[Export ("isHeadless")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHeadless"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public ulong RecommendedMaxWorkingSetSize {
			[Export ("recommendedMaxWorkingSetSize")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("recommendedMaxWorkingSetSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public bool Depth24Stencil8PixelFormatSupported {
			[Export ("isDepth24Stencil8PixelFormatSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDepth24Stencil8PixelFormatSupported"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool Removable {
			[Export ("isRemovable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRemovable"));
				return ret != 0;
			}
		}
		/// <summary>Gets the texture read-write support tier.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLReadWriteTextureTier ReadWriteTextureSupport {
			[Export ("readWriteTextureSupport")]
			get {
				MTLReadWriteTextureTier ret;
				ret = (MTLReadWriteTextureTier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("readWriteTextureSupport"));
				return ret!;
			}
		}
		/// <summary>Returns the argument buffer support tier.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLArgumentBuffersTier ArgumentBuffersSupport {
			[Export ("argumentBuffersSupport")]
			get {
				MTLArgumentBuffersTier ret;
				ret = (MTLArgumentBuffersTier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("argumentBuffersSupport"));
				return ret!;
			}
		}
		/// <summary>Returns a Boolean value that tells whether raster order groups are supported.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool RasterOrderGroupsSupported {
			[Export ("areRasterOrderGroupsSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("areRasterOrderGroupsSupported"));
				return ret != 0;
			}
		}
		/// <summary>Gets the largest available length of memory for threadgroups.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint MaxThreadgroupMemoryLength {
			[Export ("maxThreadgroupMemoryLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxThreadgroupMemoryLength"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint MaxArgumentBufferSamplerCount {
			[Export ("maxArgumentBufferSamplerCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxArgumentBufferSamplerCount"));
				return ret;
			}
		}
		/// <summary>Returns a Boolean value that tells whether programmable sample positions are supported.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool ProgrammableSamplePositionsSupported {
			[Export ("areProgrammableSamplePositionsSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("areProgrammableSamplePositionsSupported"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint MaxBufferLength {
			[Export ("maxBufferLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxBufferLength"));
				return ret;
			}
		}
		/// <summary>Gets the registry ID.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public ulong RegistryId {
			[Export ("registryID")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("registryID"));
				return ret;
			}
		}
		/// <summary>Gets the size, in bytes, of all the resources that the device has allocated.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint CurrentAllocatedSize {
			[Export ("currentAllocatedSize")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentAllocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		public nuint SparseTileSizeInBytes {
			[Export ("sparseTileSizeInBytes")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sparseTileSizeInBytes"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool HasUnifiedMemory {
			[Export ("hasUnifiedMemory")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasUnifiedMemory"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool BarycentricCoordsSupported {
			[Export ("areBarycentricCoordsSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("areBarycentricCoordsSupported"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsShaderBarycentricCoordinates {
			[Export ("supportsShaderBarycentricCoordinates")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsShaderBarycentricCoordinates"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint PeerIndex {
			[Export ("peerIndex")]
			get {
				uint ret;
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("peerIndex"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint PeerCount {
			[Export ("peerCount")]
			get {
				uint ret;
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("peerCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public IMTLCounterSet[]? CounterSets {
			[Export ("counterSets")]
			get {
				IMTLCounterSet[] ret;
				ret = CFArray.ArrayFromHandle<IMTLCounterSet>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("counterSets")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public ulong PeerGroupId {
			[Export ("peerGroupID")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("peerGroupID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public ulong MaxTransferRate {
			[Export ("maxTransferRate")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("maxTransferRate"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLDeviceLocation Location {
			[Export ("location")]
			get {
				MTLDeviceLocation ret;
				ret = (MTLDeviceLocation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("location"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint LocationNumber {
			[Export ("locationNumber")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("locationNumber"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool Supports32BitFloatFiltering {
			[Export ("supports32BitFloatFiltering")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supports32BitFloatFiltering"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool Supports32BitMsaa {
			[Export ("supports32BitMSAA")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supports32BitMSAA"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsBCTextureCompression {
			[Export ("supportsBCTextureCompression")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsBCTextureCompression"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsPullModelInterpolation {
			[Export ("supportsPullModelInterpolation")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsPullModelInterpolation"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsDynamicLibraries {
			[Export ("supportsDynamicLibraries")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsDynamicLibraries"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsRaytracing {
			[Export ("supportsRaytracing")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsRaytracing"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsFunctionPointers {
			[Export ("supportsFunctionPointers")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsFunctionPointers"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsQueryTextureLod {
			[Export ("supportsQueryTextureLOD")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsQueryTextureLOD"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsRenderDynamicLibraries {
			[Export ("supportsRenderDynamicLibraries")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsRenderDynamicLibraries"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsRaytracingFromRender {
			[Export ("supportsRaytracingFromRender")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsRaytracingFromRender"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsPrimitiveMotionBlur {
			[Export ("supportsPrimitiveMotionBlur")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsPrimitiveMotionBlur"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		public bool SupportsFunctionPointersFromRender {
			[Export ("supportsFunctionPointersFromRender")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsFunctionPointersFromRender"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public MTLArchitecture Architecture {
			[Export ("architecture")]
			get {
				MTLArchitecture ret;
				ret =  Runtime.GetNSObject<MTLArchitecture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("architecture")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.1")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("tvos26.1")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint MaximumConcurrentCompilationTaskCount {
			[Export ("maximumConcurrentCompilationTaskCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maximumConcurrentCompilationTaskCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.3")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public bool ShouldMaximizeConcurrentCompilation {
			[Export ("shouldMaximizeConcurrentCompilation")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldMaximizeConcurrentCompilation"));
				return ret != 0;
			}
			[Export ("setShouldMaximizeConcurrentCompilation:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldMaximizeConcurrentCompilation:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public ulong QueryTimestampFrequency {
			[Export ("queryTimestampFrequency")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("queryTimestampFrequency"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public bool SupportsPlacementSparse {
			[Export ("supportsPlacementSparse")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsPlacementSparse"));
				return ret != 0;
			}
		}
	}
}
