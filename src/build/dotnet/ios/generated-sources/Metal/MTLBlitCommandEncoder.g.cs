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
	/// <summary>Protocol for writing data into frame buffers.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLBlitCommandEncoder", WrapperType = typeof (MTLBlitCommandEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLBlitOption) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLBlitOption) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateMipmapsForTexture", Selector = "generateMipmapsForTexture:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FillBuffer", Selector = "fillBuffer:range:value:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (NSRange), typeof (byte) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForGpuAccess", Selector = "optimizeContentsForGPUAccess:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForGpuAccess", Selector = "optimizeContentsForGPUAccess:slice:level:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForCpuAccess", Selector = "optimizeContentsForCPUAccess:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForCpuAccess", Selector = "optimizeContentsForCPUAccess:slice:level:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResetCommands", Selector = "resetCommandsInBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange), typeof (IMTLIndirectCommandBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Optimize", Selector = "optimizeIndirectCommandBuffer:withRange:", ParameterType = new Type [] { typeof (IMTLIndirectCommandBuffer), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTextureAccessCounters", Selector = "getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (MTLRegion), typeof (UIntPtr), typeof (UIntPtr), typeof (bool), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResetTextureAccessCounters", Selector = "resetTextureAccessCounters:region:mipLevel:slice:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (MTLRegion), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyFromTexture:toTexture:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (IMTLTexture) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SampleCounters", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type [] { typeof (IMTLCounterSampleBuffer), typeof (UIntPtr), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResolveCounters", Selector = "resolveCounters:inRange:destinationBuffer:destinationOffset:", ParameterType = new Type [] { typeof (IMTLCounterSampleBuffer), typeof (NSRange), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTensor", Selector = "copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:", ParameterType = new Type [] { typeof (IMTLTensor), typeof (MTLTensorExtents), typeof (MTLTensorExtents), typeof (IMTLTensor), typeof (MTLTensorExtents), typeof (MTLTensorExtents) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	public partial interface IMTLBlitCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTLCommandEncoder
	{
		/// <param name="sourceTexture">To be added.</param><param name="sourceSlice">To be added.</param><param name="sourceLevel">To be added.</param><param name="sourceOrigin">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationTexture">To be added.</param><param name="destinationSlice">To be added.</param><param name="destinationLevel">To be added.</param><param name="destinationOrigin">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sourceTexture">To be added.</param><param name="sourceSlice">To be added.</param><param name="sourceLevel">To be added.</param><param name="sourceOrigin">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationTexture">To be added.</param><param name="destinationSlice">To be added.</param><param name="destinationLevel">To be added.</param><param name="destinationOrigin">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		/// <param name="sourceBuffer">To be added.</param><param name="sourceOffset">To be added.</param><param name="sourceBytesPerRow">To be added.</param><param name="sourceBytesPerImage">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationTexture">To be added.</param><param name="destinationSlice">To be added.</param><param name="destinationLevel">To be added.</param><param name="destinationOrigin">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sourceBuffer">To be added.</param><param name="sourceOffset">To be added.</param><param name="sourceBytesPerRow">To be added.</param><param name="sourceBytesPerImage">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationTexture">To be added.</param><param name="destinationSlice">To be added.</param><param name="destinationLevel">To be added.</param><param name="destinationOrigin">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromBuffer (IMTLBlitCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin, MTLBlitOption options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromBuffer (IMTLBlitCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin, MTLBlitOption options)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_UIntPtr (This.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:"), sourceBuffer__handle__, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationTexture);
		}
		/// <param name="sourceTexture">To be added.</param><param name="sourceSlice">To be added.</param><param name="sourceLevel">To be added.</param><param name="sourceOrigin">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationBuffer">To be added.</param><param name="destinationOffset">To be added.</param><param name="destinatinBytesPerRow">To be added.</param><param name="destinationBytesPerImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sourceTexture">To be added.</param><param name="sourceSlice">To be added.</param><param name="sourceLevel">To be added.</param><param name="sourceOrigin">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationBuffer">To be added.</param><param name="destinationOffset">To be added.</param><param name="destinatinBytesPerRow">To be added.</param><param name="destinationBytesPerImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinatinBytesPerRow, destinationBytesPerImage);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTexture (IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinatinBytesPerRow, destinationBytesPerImage, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		/// <param name="texture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("generateMipmapsForTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GenerateMipmapsForTexture (IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="texture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GenerateMipmapsForTexture (IMTLBlitCommandEncoder This, IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("generateMipmapsForTexture:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		/// <param name="buffer">To be added.</param><param name="range">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("fillBuffer:range:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FillBuffer (IMTLBuffer buffer, NSRange range, byte value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="buffer">To be added.</param><param name="range">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FillBuffer (IMTLBlitCommandEncoder This, IMTLBuffer buffer, NSRange range, byte value)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_byte (This.Handle, Selector.GetHandle ("fillBuffer:range:value:"), buffer__handle__, range, value);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		/// <param name="sourceBuffer">To be added.</param><param name="sourceOffset">To be added.</param><param name="destinationBuffer">To be added.</param><param name="destinationOffset">To be added.</param><param name="size">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromBuffer (IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sourceBuffer">To be added.</param><param name="sourceOffset">To be added.</param><param name="destinationBuffer">To be added.</param><param name="destinationOffset">To be added.</param><param name="size">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromBuffer (IMTLBlitCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:"), sourceBuffer__handle__, sourceOffset, destinationBuffer__handle__, destinationOffset, size);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationBuffer);
		}
		/// <summary>Captures GPU work that was enqueued by the encoder for the specified <paramref name="fence" />.</summary><param name="fence">The fence to update.</param>
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
		/// <summary>Captures GPU work that was enqueued by the encoder for the specified <paramref name="fence" />.</summary><param name="fence">The fence to update.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLBlitCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary><param name="fence">The fence to wait to be updated.</param>
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
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary><param name="fence">The fence to wait to be updated.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Wait (IMTLBlitCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForGPUAccess:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForGpuAccess (IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForGpuAccess (IMTLBlitCommandEncoder This, IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("optimizeContentsForGPUAccess:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForGPUAccess:slice:level:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForGpuAccess (IMTLTexture texture, nuint slice, nuint level)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForGpuAccess (IMTLBlitCommandEncoder This, IMTLTexture texture, nuint slice, nuint level)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("optimizeContentsForGPUAccess:slice:level:"), texture__handle__, slice, level);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForCPUAccess:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForCpuAccess (IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForCpuAccess (IMTLBlitCommandEncoder This, IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("optimizeContentsForCPUAccess:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("optimizeContentsForCPUAccess:slice:level:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OptimizeContentsForCpuAccess (IMTLTexture texture, nuint slice, nuint level)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OptimizeContentsForCpuAccess (IMTLBlitCommandEncoder This, IMTLTexture texture, nuint slice, nuint level)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("optimizeContentsForCPUAccess:slice:level:"), texture__handle__, slice, level);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("resetCommandsInBuffer:withRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetCommands (IMTLIndirectCommandBuffer buffer, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResetCommands (IMTLBlitCommandEncoder This, IMTLIndirectCommandBuffer buffer, NSRange range)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("resetCommandsInBuffer:withRange:"), buffer__handle__, range);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Copy (IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Copy (IMTLBlitCommandEncoder This, IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Optimize (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Optimize (IMTLBlitCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("optimizeIndirectCommandBuffer:withRange:"), indirectCommandBuffer__handle__, range);
			GC.KeepAlive (This);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetTextureAccessCounters (IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice, bool resetCounters, IMTLBuffer countersBuffer, nuint countersBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetTextureAccessCounters (IMTLBlitCommandEncoder This, IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice, bool resetCounters, IMTLBuffer countersBuffer, nuint countersBufferOffset)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var countersBuffer__handle__ = countersBuffer!.GetNonNullHandle (nameof (countersBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTLRegion_UIntPtr_UIntPtr_bool_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:"), texture__handle__, region, mipLevel, slice, resetCounters ? (byte) 1 : (byte) 0, countersBuffer__handle__, countersBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (countersBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("resetTextureAccessCounters:region:mipLevel:slice:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetTextureAccessCounters (IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResetTextureAccessCounters (IMTLBlitCommandEncoder This, IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTLRegion_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("resetTextureAccessCounters:region:mipLevel:slice:"), texture__handle__, region, mipLevel, slice);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Copy (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Copy (IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:"), sourceTexture__handle__, sourceSlice, sourceLevel, destinationTexture__handle__, destinationSlice, destinationLevel, sliceCount, levelCount);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTexture:toTexture:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Copy (IMTLTexture sourceTexture, IMTLTexture destinationTexture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Copy (IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, IMTLTexture destinationTexture)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyFromTexture:toTexture:"), sourceTexture__handle__, destinationTexture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
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
		internal static void _SampleCounters (IMTLBlitCommandEncoder This, IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("resolveCounters:inRange:destinationBuffer:destinationOffset:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResolveCounters (IMTLCounterSampleBuffer sampleBuffer, NSRange range, IMTLBuffer destinationBuffer, nuint destinationOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResolveCounters (IMTLBlitCommandEncoder This, IMTLCounterSampleBuffer sampleBuffer, NSRange range, IMTLBuffer destinationBuffer, nuint destinationOffset)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("resolveCounters:inRange:destinationBuffer:destinationOffset:"), sampleBuffer__handle__, range, destinationBuffer__handle__, destinationOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (destinationBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFromTensor (IMTLTensor sourceTensor, MTLTensorExtents sourceOrigin, MTLTensorExtents sourceDimensions, IMTLTensor destinationTensor, MTLTensorExtents destinationOrigin, MTLTensorExtents destinationDimensions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyFromTensor (IMTLBlitCommandEncoder This, IMTLTensor sourceTensor, MTLTensorExtents sourceOrigin, MTLTensorExtents sourceDimensions, IMTLTensor destinationTensor, MTLTensorExtents destinationOrigin, MTLTensorExtents destinationDimensions)
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
		[DynamicDependencyAttribute ("Copy(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange,Metal.IMTLIndirectCommandBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Copy(Metal.IMTLTexture,Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("Copy(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyFromBuffer(Metal.IMTLBuffer,System.UIntPtr,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyFromBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLBlitOption)")]
		[DynamicDependencyAttribute ("CopyFromBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin)")]
		[DynamicDependencyAttribute ("CopyFromTensor(Metal.IMTLTensor,Metal.MTLTensorExtents,Metal.MTLTensorExtents,Metal.IMTLTensor,Metal.MTLTensorExtents,Metal.MTLTensorExtents)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLBlitOption)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyFromTexture(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin)")]
		[DynamicDependencyAttribute ("FillBuffer(Metal.IMTLBuffer,Foundation.NSRange,System.Byte)")]
		[DynamicDependencyAttribute ("GenerateMipmapsForTexture(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("GetTextureAccessCounters(Metal.IMTLTexture,Metal.MTLRegion,System.UIntPtr,System.UIntPtr,System.Boolean,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Optimize(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("OptimizeContentsForCpuAccess(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("OptimizeContentsForCpuAccess(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("OptimizeContentsForGpuAccess(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("OptimizeContentsForGpuAccess(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute ("ResetCommands(Metal.IMTLIndirectCommandBuffer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ResetTextureAccessCounters(Metal.IMTLTexture,Metal.MTLRegion,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ResolveCounters(Metal.IMTLCounterSampleBuffer,Foundation.NSRange,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SampleCounters(Metal.IMTLCounterSampleBuffer,System.UIntPtr,System.Boolean)")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLFence)")]
		[DynamicDependencyAttribute ("Wait(Metal.IMTLFence)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBlitCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLBlitCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLBlitCommandEncoder" /> interface to support all the methods from the MTLBlitCommandEncoder protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLBlitCommandEncoder" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLBlitCommandEncoder protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLBlitCommandEncoder_Extensions {
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void GetTextureAccessCounters (this IMTLBlitCommandEncoder This, IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice, bool resetCounters, IMTLBuffer countersBuffer, nuint countersBufferOffset)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var countersBuffer__handle__ = countersBuffer!.GetNonNullHandle (nameof (countersBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTLRegion_UIntPtr_UIntPtr_bool_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:"), texture__handle__, region, mipLevel, slice, resetCounters ? (byte) 1 : (byte) 0, countersBuffer__handle__, countersBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (countersBuffer);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetTextureAccessCounters (this IMTLBlitCommandEncoder This, IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTLRegion_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("resetTextureAccessCounters:region:mipLevel:slice:"), texture__handle__, region, mipLevel, slice);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLBlitCommandEncoderWrapper : BaseWrapper, IMTLBlitCommandEncoder {
		public MTLBlitCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBlitCommandEncoderWrapper))]
		static MTLBlitCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="sourceTexture">To be added.</param><param name="sourceSlice">To be added.</param><param name="sourceLevel">To be added.</param><param name="sourceOrigin">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationTexture">To be added.</param><param name="destinationSlice">To be added.</param><param name="destinationLevel">To be added.</param><param name="destinationOrigin">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
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
		/// <param name="sourceBuffer">To be added.</param><param name="sourceOffset">To be added.</param><param name="sourceBytesPerRow">To be added.</param><param name="sourceBytesPerImage">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationTexture">To be added.</param><param name="destinationSlice">To be added.</param><param name="destinationLevel">To be added.</param><param name="destinationOrigin">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
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
		/// <param name="sourceTexture">To be added.</param><param name="sourceSlice">To be added.</param><param name="sourceLevel">To be added.</param><param name="sourceOrigin">To be added.</param><param name="sourceSize">To be added.</param><param name="destinationBuffer">To be added.</param><param name="destinationOffset">To be added.</param><param name="destinatinBytesPerRow">To be added.</param><param name="destinationBytesPerImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinatinBytesPerRow, destinationBytesPerImage);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		[Export ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyFromTexture (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer__handle__, destinationOffset, destinatinBytesPerRow, destinationBytesPerImage, (UIntPtr) (ulong) options);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationBuffer);
		}
		/// <param name="texture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("generateMipmapsForTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GenerateMipmapsForTexture (IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("generateMipmapsForTexture:"), texture__handle__);
			GC.KeepAlive (texture);
		}
		/// <param name="buffer">To be added.</param><param name="range">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("fillBuffer:range:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FillBuffer (IMTLBuffer buffer, NSRange range, byte value)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_byte (this.Handle, Selector.GetHandle ("fillBuffer:range:value:"), buffer__handle__, range, value);
			GC.KeepAlive (buffer);
		}
		/// <param name="sourceBuffer">To be added.</param><param name="sourceOffset">To be added.</param><param name="destinationBuffer">To be added.</param><param name="destinationOffset">To be added.</param><param name="size">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
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
		/// <summary>Captures GPU work that was enqueued by the encoder for the specified <paramref name="fence" />.</summary><param name="fence">The fence to update.</param>
		[Export ("updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		/// <summary>Prevents additional GPU work by the encoder until the <paramref name="fence" /> is reached.</summary><param name="fence">The fence to wait to be updated.</param>
		[Export ("waitForFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Wait (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (fence);
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
		public void ResetCommands (IMTLIndirectCommandBuffer buffer, NSRange range)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("resetCommandsInBuffer:withRange:"), buffer__handle__, range);
			GC.KeepAlive (buffer);
		}
		[Export ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Copy (IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:"), source__handle__, sourceRange, destination__handle__, destinationIndex);
			GC.KeepAlive (source);
			GC.KeepAlive (destination);
		}
		[Export ("optimizeIndirectCommandBuffer:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Optimize (IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
		{
			var indirectCommandBuffer__handle__ = indirectCommandBuffer!.GetNonNullHandle (nameof (indirectCommandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("optimizeIndirectCommandBuffer:withRange:"), indirectCommandBuffer__handle__, range);
			GC.KeepAlive (indirectCommandBuffer);
		}
		[Export ("getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetTextureAccessCounters (IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice, bool resetCounters, IMTLBuffer countersBuffer, nuint countersBufferOffset)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var countersBuffer__handle__ = countersBuffer!.GetNonNullHandle (nameof (countersBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTLRegion_UIntPtr_UIntPtr_bool_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:"), texture__handle__, region, mipLevel, slice, resetCounters ? (byte) 1 : (byte) 0, countersBuffer__handle__, countersBufferOffset);
			GC.KeepAlive (texture);
			GC.KeepAlive (countersBuffer);
		}
		[Export ("resetTextureAccessCounters:region:mipLevel:slice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ResetTextureAccessCounters (IMTLTexture texture, MTLRegion region, nuint mipLevel, nuint slice)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_MTLRegion_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("resetTextureAccessCounters:region:mipLevel:slice:"), texture__handle__, region, mipLevel, slice);
			GC.KeepAlive (texture);
		}
		[Export ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Copy (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:"), sourceTexture__handle__, sourceSlice, sourceLevel, destinationTexture__handle__, destinationSlice, destinationLevel, sliceCount, levelCount);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("copyFromTexture:toTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Copy (IMTLTexture sourceTexture, IMTLTexture destinationTexture)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyFromTexture:toTexture:"), sourceTexture__handle__, destinationTexture__handle__);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("sampleCountersInBuffer:atSampleIndex:withBarrier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SampleCounters (IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (sampleBuffer);
		}
		[Export ("resolveCounters:inRange:destinationBuffer:destinationOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ResolveCounters (IMTLCounterSampleBuffer sampleBuffer, NSRange range, IMTLBuffer destinationBuffer, nuint destinationOffset)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("resolveCounters:inRange:destinationBuffer:destinationOffset:"), sampleBuffer__handle__, range, destinationBuffer__handle__, destinationOffset);
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (destinationBuffer);
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
