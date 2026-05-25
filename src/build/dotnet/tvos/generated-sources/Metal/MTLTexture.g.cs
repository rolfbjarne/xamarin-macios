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
	/// <summary>System protocol for image data that is used by vertex shaders, fragment shaders, and compute kernels.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLTexture", WrapperType = typeof (MTLTextureWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTextureView", Selector = "newTextureViewWithPixelFormat:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLPixelFormat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTextureView", Selector = "newTextureViewWithPixelFormat:textureType:levels:slices:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLPixelFormat), typeof (MTLTextureType), typeof (NSRange), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBytes", Selector = "getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLRegion), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBytes", Selector = "getBytes:bytesPerRow:fromRegion:mipmapLevel:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (MTLRegion), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceRegion", Selector = "replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:", ParameterType = new Type [] { typeof (MTLRegion), typeof (UIntPtr), typeof (UIntPtr), typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceRegion", Selector = "replaceRegion:mipmapLevel:withBytes:bytesPerRow:", ParameterType = new Type [] { typeof (MTLRegion), typeof (UIntPtr), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedTextureHandle", Selector = "newSharedTextureHandle", ReturnType = typeof (MTLSharedTextureHandle))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Create", Selector = "newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLPixelFormat), typeof (MTLTextureType), typeof (NSRange), typeof (NSRange), typeof (MTLTextureSwizzleChannels) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTextureView", Selector = "newTextureViewWithDescriptor:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureViewDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RootResource", Selector = "rootResource", PropertyType = typeof (IMTLResource), GetterSelector = "rootResource", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParentTexture", Selector = "parentTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "parentTexture", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParentRelativeLevel", Selector = "parentRelativeLevel", PropertyType = typeof (UIntPtr), GetterSelector = "parentRelativeLevel", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParentRelativeSlice", Selector = "parentRelativeSlice", PropertyType = typeof (UIntPtr), GetterSelector = "parentRelativeSlice", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Buffer", Selector = "buffer", PropertyType = typeof (IMTLBuffer), GetterSelector = "buffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferOffset", Selector = "bufferOffset", PropertyType = typeof (UIntPtr), GetterSelector = "bufferOffset", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferBytesPerRow", Selector = "bufferBytesPerRow", PropertyType = typeof (UIntPtr), GetterSelector = "bufferBytesPerRow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextureType", Selector = "textureType", PropertyType = typeof (MTLTextureType), GetterSelector = "textureType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PixelFormat", Selector = "pixelFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "pixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof (UIntPtr), GetterSelector = "width", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Height", Selector = "height", PropertyType = typeof (UIntPtr), GetterSelector = "height", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Depth", Selector = "depth", PropertyType = typeof (UIntPtr), GetterSelector = "depth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MipmapLevelCount", Selector = "mipmapLevelCount", PropertyType = typeof (UIntPtr), GetterSelector = "mipmapLevelCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SampleCount", Selector = "sampleCount", PropertyType = typeof (UIntPtr), GetterSelector = "sampleCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ArrayLength", Selector = "arrayLength", PropertyType = typeof (UIntPtr), GetterSelector = "arrayLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FramebufferOnly", Selector = "framebufferOnly", PropertyType = typeof (bool), GetterSelector = "isFramebufferOnly", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllowGpuOptimizedContents", Selector = "allowGPUOptimizedContents", PropertyType = typeof (bool), GetterSelector = "allowGPUOptimizedContents", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CompressionType", Selector = "compressionType", PropertyType = typeof (MTLTextureCompressionType), GetterSelector = "compressionType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Usage", Selector = "usage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "usage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IOSurface", Selector = "iosurface", PropertyType = typeof (global::IOSurface.IOSurface), GetterSelector = "iosurface", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IOSurfacePlane", Selector = "iosurfacePlane", PropertyType = typeof (UIntPtr), GetterSelector = "iosurfacePlane", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Shareable", Selector = "shareable", PropertyType = typeof (bool), GetterSelector = "isShareable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FirstMipmapInTail", Selector = "firstMipmapInTail", PropertyType = typeof (UIntPtr), GetterSelector = "firstMipmapInTail", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TailSizeInBytes", Selector = "tailSizeInBytes", PropertyType = typeof (UIntPtr), GetterSelector = "tailSizeInBytes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsSparse", Selector = "isSparse", PropertyType = typeof (bool), GetterSelector = "isSparse", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Swizzle", Selector = "swizzle", PropertyType = typeof (MTLTextureSwizzleChannels), GetterSelector = "swizzle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuResourceId", Selector = "gpuResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "gpuResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SparseTextureTier", Selector = "sparseTextureTier", PropertyType = typeof (MTLTextureSparseTier), GetterSelector = "sparseTextureTier", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLTexture : INativeObject, IDisposable, 
		Metal.IMTLAllocation
		, Metal.IMTLResource
	{
		/// <param name="pixelFormat">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newTextureViewWithPixelFormat:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTextureView (MTLPixelFormat pixelFormat)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pixelFormat">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTextureView (IMTLTexture This, MTLPixelFormat pixelFormat)
		{
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newTextureViewWithPixelFormat:"), (UIntPtr) (ulong) pixelFormat), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Creates and returns a Metal texture that shares the same memory as the source object, but that is interpreted with the new pixel format.</summary>
		[global::Foundation.RequiredMember]
		[Export ("newTextureViewWithPixelFormat:textureType:levels:slices:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTextureView (MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates and returns a Metal texture that shares the same memory as the source object, but that is interpreted with the new pixel format.</summary>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTextureView (IMTLTexture This, MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange)
		{
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NSRange_NSRange (This.Handle, Selector.GetHandle ("newTextureViewWithPixelFormat:textureType:levels:slices:"), (UIntPtr) (ulong) pixelFormat, (UIntPtr) (ulong) textureType, levelRange, sliceRange), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetBytes (nint pixelBytes, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, nuint level, nuint slice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetBytes (IMTLTexture This, nint pixelBytes, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, nuint level, nuint slice)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_MTLRegion_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:"), pixelBytes, bytesPerRow, bytesPerImage, region, level, slice);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("getBytes:bytesPerRow:fromRegion:mipmapLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetBytes (nint pixelBytes, nuint bytesPerRow, MTLRegion region, nuint level)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetBytes (IMTLTexture This, nint pixelBytes, nuint bytesPerRow, MTLRegion region, nuint level)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_MTLRegion_UIntPtr (This.Handle, Selector.GetHandle ("getBytes:bytesPerRow:fromRegion:mipmapLevel:"), pixelBytes, bytesPerRow, region, level);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceRegion (MTLRegion region, nuint level, nuint slice, nint pixelBytes, nuint bytesPerRow, nuint bytesPerImage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceRegion (IMTLTexture This, MTLRegion region, nuint level, nuint slice, nint pixelBytes, nuint bytesPerRow, nuint bytesPerImage)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion_UIntPtr_UIntPtr_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:"), region, level, slice, pixelBytes, bytesPerRow, bytesPerImage);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceRegion:mipmapLevel:withBytes:bytesPerRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceRegion (MTLRegion region, nuint level, nint pixelBytes, nuint bytesPerRow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceRegion (IMTLTexture This, MTLRegion region, nuint level, nint pixelBytes, nuint bytesPerRow)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion_UIntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("replaceRegion:mipmapLevel:withBytes:bytesPerRow:"), region, level, pixelBytes, bytesPerRow);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("newSharedTextureHandle")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSharedTextureHandle? CreateSharedTextureHandle ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSharedTextureHandle? _CreateSharedTextureHandle (IMTLTexture This)
		{
			MTLSharedTextureHandle? ret;
			ret =  Runtime.GetNSObject<MTLSharedTextureHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newSharedTextureHandle")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? Create (MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange, MTLTextureSwizzleChannels swizzle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _Create (IMTLTexture This, MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange, MTLTextureSwizzleChannels swizzle)
		{
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NSRange_NSRange_MTLTextureSwizzleChannels (This.Handle, Selector.GetHandle ("newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:"), (UIntPtr) (ulong) pixelFormat, (UIntPtr) (ulong) textureType, levelRange, sliceRange, swizzle), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newTextureViewWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTextureView (MTLTextureViewDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTextureView (IMTLTexture This, MTLTextureViewDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newTextureViewWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[DynamicDependencyAttribute ("AllowGpuOptimizedContents")]
		[DynamicDependencyAttribute ("ArrayLength")]
		[DynamicDependencyAttribute ("Buffer")]
		[DynamicDependencyAttribute ("BufferBytesPerRow")]
		[DynamicDependencyAttribute ("BufferOffset")]
		[DynamicDependencyAttribute ("CompressionType")]
		[DynamicDependencyAttribute ("Create(Metal.MTLPixelFormat,Metal.MTLTextureType,Foundation.NSRange,Foundation.NSRange,Metal.MTLTextureSwizzleChannels)")]
		[DynamicDependencyAttribute ("CreateSharedTextureHandle()")]
		[DynamicDependencyAttribute ("CreateTextureView(Metal.MTLPixelFormat,Metal.MTLTextureType,Foundation.NSRange,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("CreateTextureView(Metal.MTLPixelFormat)")]
		[DynamicDependencyAttribute ("CreateTextureView(Metal.MTLTextureViewDescriptor)")]
		[DynamicDependencyAttribute ("Depth")]
		[DynamicDependencyAttribute ("FirstMipmapInTail")]
		[DynamicDependencyAttribute ("FramebufferOnly")]
		[DynamicDependencyAttribute ("GetBytes(System.IntPtr,System.UIntPtr,Metal.MTLRegion,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetBytes(System.IntPtr,System.UIntPtr,System.UIntPtr,Metal.MTLRegion,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GpuResourceId")]
		[DynamicDependencyAttribute ("Height")]
		[DynamicDependencyAttribute ("IOSurface")]
		[DynamicDependencyAttribute ("IOSurfacePlane")]
		[DynamicDependencyAttribute ("IsSparse")]
		[DynamicDependencyAttribute ("MipmapLevelCount")]
		[DynamicDependencyAttribute ("ParentRelativeLevel")]
		[DynamicDependencyAttribute ("ParentRelativeSlice")]
		[DynamicDependencyAttribute ("ParentTexture")]
		[DynamicDependencyAttribute ("PixelFormat")]
		[DynamicDependencyAttribute ("ReplaceRegion(Metal.MTLRegion,System.UIntPtr,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ReplaceRegion(Metal.MTLRegion,System.UIntPtr,System.UIntPtr,System.IntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("RootResource")]
		[DynamicDependencyAttribute ("SampleCount")]
		[DynamicDependencyAttribute ("Shareable")]
		[DynamicDependencyAttribute ("SparseTextureTier")]
		[DynamicDependencyAttribute ("Swizzle")]
		[DynamicDependencyAttribute ("TailSizeInBytes")]
		[DynamicDependencyAttribute ("TextureType")]
		[DynamicDependencyAttribute ("Usage")]
		[DynamicDependencyAttribute ("Width")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTextureWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLTexture ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos10.12")]
		[ObsoletedOSPlatform ("tvos10.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual IMTLResource RootResource {
			[Export ("rootResource")]
			get {
				return _GetRootResource (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLResource _GetRootResource (IMTLTexture This)
		{
			IMTLResource ret;
			ret =  Runtime.GetINativeObject<IMTLResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("rootResource")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the parent texture.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual IMTLTexture? ParentTexture {
			[Export ("parentTexture")]
			get {
				return _GetParentTexture (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture _GetParentTexture (IMTLTexture This)
		{
			IMTLTexture ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("parentTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the base level of the parent texture from which the target texture was created.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint ParentRelativeLevel {
			[Export ("parentRelativeLevel")]
			get {
				return _GetParentRelativeLevel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetParentRelativeLevel (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("parentRelativeLevel"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the base slice of the parent texture from which the target texture was created.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint ParentRelativeSlice {
			[Export ("parentRelativeSlice")]
			get {
				return _GetParentRelativeSlice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetParentRelativeSlice (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("parentRelativeSlice"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the buffer for the target texture.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual IMTLBuffer? Buffer {
			[Export ("buffer")]
			get {
				return _GetBuffer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer _GetBuffer (IMTLTexture This)
		{
			IMTLBuffer ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("buffer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the offset into the parent texture where the the target texture data begins.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint BufferOffset {
			[Export ("bufferOffset")]
			get {
				return _GetBufferOffset (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBufferOffset (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bufferOffset"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the bytes per row in the buffer for the target texture.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint BufferBytesPerRow {
			[Export ("bufferBytesPerRow")]
			get {
				return _GetBufferBytesPerRow (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBufferBytesPerRow (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bufferBytesPerRow"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTextureType TextureType {
			[Export ("textureType")]
			get {
				return _GetTextureType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTextureType _GetTextureType (IMTLTexture This)
		{
			MTLTextureType ret;
			ret = (MTLTextureType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textureType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLPixelFormat PixelFormat {
			[Export ("pixelFormat")]
			get {
				return _GetPixelFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLPixelFormat _GetPixelFormat (IMTLTexture This)
		{
			MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("pixelFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Width {
			[Export ("width")]
			get {
				return _GetWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetWidth (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("width"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Height {
			[Export ("height")]
			get {
				return _GetHeight (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetHeight (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("height"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Depth {
			[Export ("depth")]
			get {
				return _GetDepth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetDepth (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("depth"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint MipmapLevelCount {
			[Export ("mipmapLevelCount")]
			get {
				return _GetMipmapLevelCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMipmapLevelCount (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mipmapLevelCount"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual nuint SampleCount {
			[Export ("sampleCount")]
			get {
				return _GetSampleCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetSampleCount (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sampleCount"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint ArrayLength {
			[Export ("arrayLength")]
			get {
				return _GetArrayLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetArrayLength (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("arrayLength"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool FramebufferOnly {
			[Export ("isFramebufferOnly")]
			get {
				return _GetFramebufferOnly (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetFramebufferOnly (IMTLTexture This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isFramebufferOnly"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool AllowGpuOptimizedContents {
			[Export ("allowGPUOptimizedContents")]
			get {
				return _GetAllowGpuOptimizedContents (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAllowGpuOptimizedContents (IMTLTexture This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowGPUOptimizedContents"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos12.5")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLTextureCompressionType CompressionType {
			[Export ("compressionType")]
			get {
				return _GetCompressionType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTextureCompressionType _GetCompressionType (IMTLTexture This)
		{
			MTLTextureCompressionType ret;
			ret = (MTLTextureCompressionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("compressionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets a description of how the texture can be used. (For example, as a write target for compute shaders.)</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTextureUsage Usage {
			[Export ("usage")]
			get {
				return _GetUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTextureUsage _GetUsage (IMTLTexture This)
		{
			MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("usage"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets the IOSurface that was used to create this texture, if one was used.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::IOSurface.IOSurface? IOSurface {
			[Export ("iosurface")]
			get {
				return _GetIOSurface (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::IOSurface.IOSurface _GetIOSurface (IMTLTexture This)
		{
			global::IOSurface.IOSurface ret;
			ret =  Runtime.GetNSObject<global::IOSurface.IOSurface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("iosurface")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the IOSurface plane used by the surface that is returned from <see cref="IMTLTexture.IOSurface" />.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint IOSurfacePlane {
			[Export ("iosurfacePlane")]
			get {
				return _GetIOSurfacePlane (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetIOSurfacePlane (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("iosurfacePlane"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool Shareable {
			[Export ("isShareable")]
			get {
				return _GetShareable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShareable (IMTLTexture This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isShareable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint FirstMipmapInTail {
			[Export ("firstMipmapInTail")]
			get {
				return _GetFirstMipmapInTail (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetFirstMipmapInTail (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("firstMipmapInTail"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint TailSizeInBytes {
			[Export ("tailSizeInBytes")]
			get {
				return _GetTailSizeInBytes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetTailSizeInBytes (IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tailSizeInBytes"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool IsSparse {
			[Export ("isSparse")]
			get {
				return _GetIsSparse (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsSparse (IMTLTexture This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSparse"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLTextureSwizzleChannels Swizzle {
			[Export ("swizzle")]
			get {
				return _GetSwizzle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTextureSwizzleChannels _GetSwizzle (IMTLTexture This)
		{
			MTLTextureSwizzleChannels ret;
			ret = global::ObjCRuntime.Messaging.MTLTextureSwizzleChannels_objc_msgSend (This.Handle, Selector.GetHandle ("swizzle"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				return _GetGpuResourceId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetGpuResourceId (IMTLTexture This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLTextureSparseTier SparseTextureTier {
			[Export ("sparseTextureTier")]
			get {
				return _GetSparseTextureTier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTextureSparseTier _GetSparseTextureTier (IMTLTexture This)
		{
			MTLTextureSparseTier ret;
			ret = (MTLTextureSparseTier) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sparseTextureTier"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLTexture" /> interface to support all the methods from the MTLTexture protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLTexture" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLTexture protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLTexture_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLTextureCompressionType GetCompressionType (this IMTLTexture This)
		{
			MTLTextureCompressionType ret;
			ret = (MTLTextureCompressionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("compressionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetFirstMipmapInTail (this IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("firstMipmapInTail"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetTailSizeInBytes (this IMTLTexture This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tailSizeInBytes"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsSparse (this IMTLTexture This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSparse"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLResourceId GetGpuResourceId (this IMTLTexture This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLTextureWrapper : BaseWrapper, IMTLTexture {
		public MTLTextureWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTextureWrapper))]
		static MTLTextureWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="pixelFormat">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newTextureViewWithPixelFormat:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTextureView (MTLPixelFormat pixelFormat)
		{
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newTextureViewWithPixelFormat:"), (UIntPtr) (ulong) pixelFormat), true)!;
			return ret!;
		}
		/// <summary>Creates and returns a Metal texture that shares the same memory as the source object, but that is interpreted with the new pixel format.</summary>
		[Export ("newTextureViewWithPixelFormat:textureType:levels:slices:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTextureView (MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange)
		{
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NSRange_NSRange (this.Handle, Selector.GetHandle ("newTextureViewWithPixelFormat:textureType:levels:slices:"), (UIntPtr) (ulong) pixelFormat, (UIntPtr) (ulong) textureType, levelRange, sliceRange), true)!;
			return ret!;
		}
		[Export ("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetBytes (nint pixelBytes, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, nuint level, nuint slice)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_MTLRegion_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:"), pixelBytes, bytesPerRow, bytesPerImage, region, level, slice);
		}
		[Export ("getBytes:bytesPerRow:fromRegion:mipmapLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetBytes (nint pixelBytes, nuint bytesPerRow, MTLRegion region, nuint level)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_MTLRegion_UIntPtr (this.Handle, Selector.GetHandle ("getBytes:bytesPerRow:fromRegion:mipmapLevel:"), pixelBytes, bytesPerRow, region, level);
		}
		[Export ("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceRegion (MTLRegion region, nuint level, nuint slice, nint pixelBytes, nuint bytesPerRow, nuint bytesPerImage)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion_UIntPtr_UIntPtr_IntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:"), region, level, slice, pixelBytes, bytesPerRow, bytesPerImage);
		}
		[Export ("replaceRegion:mipmapLevel:withBytes:bytesPerRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceRegion (MTLRegion region, nuint level, nint pixelBytes, nuint bytesPerRow)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion_UIntPtr_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("replaceRegion:mipmapLevel:withBytes:bytesPerRow:"), region, level, pixelBytes, bytesPerRow);
		}
		[Export ("newSharedTextureHandle")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSharedTextureHandle? CreateSharedTextureHandle ()
		{
			MTLSharedTextureHandle? ret;
			ret =  Runtime.GetNSObject<MTLSharedTextureHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newSharedTextureHandle")), true)!;
			return ret!;
		}
		[Export ("newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? Create (MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange, MTLTextureSwizzleChannels swizzle)
		{
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NSRange_NSRange_MTLTextureSwizzleChannels (this.Handle, Selector.GetHandle ("newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:"), (UIntPtr) (ulong) pixelFormat, (UIntPtr) (ulong) textureType, levelRange, sliceRange, swizzle), true)!;
			return ret!;
		}
		[Export ("newTextureViewWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTextureView (MTLTextureViewDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newTextureViewWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setPurgeableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLPurgeableState SetPurgeableState (MTLPurgeableState state)
		{
			MTLPurgeableState ret;
			ret = (MTLPurgeableState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPurgeableState:"), (UIntPtr) (ulong) state);
			return ret!;
		}
		/// <summary>Makes the resource aliasable.</summary>
		[Export ("makeAliasable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MakeAliasable ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("makeAliasable"));
		}
		[Export ("setOwnerWithIdentity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public int SetOwnerWithIdentity (uint taskIdToken)
		{
			int ret;
			ret = global::ObjCRuntime.Messaging.int_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setOwnerWithIdentity:"), taskIdToken);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos10.12")]
		[ObsoletedOSPlatform ("tvos10.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public IMTLResource RootResource {
			[Export ("rootResource")]
			get {
				IMTLResource ret;
				ret =  Runtime.GetINativeObject<IMTLResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rootResource")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the parent texture.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public IMTLTexture? ParentTexture {
			[Export ("parentTexture")]
			get {
				IMTLTexture ret;
				ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentTexture")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the base level of the parent texture from which the target texture was created.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint ParentRelativeLevel {
			[Export ("parentRelativeLevel")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentRelativeLevel"));
				return ret;
			}
		}
		/// <summary>Returns the base slice of the parent texture from which the target texture was created.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint ParentRelativeSlice {
			[Export ("parentRelativeSlice")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentRelativeSlice"));
				return ret;
			}
		}
		/// <summary>Returns the buffer for the target texture.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public IMTLBuffer? Buffer {
			[Export ("buffer")]
			get {
				IMTLBuffer ret;
				ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("buffer")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the offset into the parent texture where the the target texture data begins.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint BufferOffset {
			[Export ("bufferOffset")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bufferOffset"));
				return ret;
			}
		}
		/// <summary>Gets the bytes per row in the buffer for the target texture.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint BufferBytesPerRow {
			[Export ("bufferBytesPerRow")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bufferBytesPerRow"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTextureType TextureType {
			[Export ("textureType")]
			get {
				MTLTextureType ret;
				ret = (MTLTextureType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textureType"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLPixelFormat PixelFormat {
			[Export ("pixelFormat")]
			get {
				MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pixelFormat"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Width {
			[Export ("width")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("width"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Height {
			[Export ("height")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("height"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Depth {
			[Export ("depth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("depth"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint MipmapLevelCount {
			[Export ("mipmapLevelCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mipmapLevelCount"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public nuint SampleCount {
			[Export ("sampleCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sampleCount"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint ArrayLength {
			[Export ("arrayLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("arrayLength"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool FramebufferOnly {
			[Export ("isFramebufferOnly")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFramebufferOnly"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool AllowGpuOptimizedContents {
			[Export ("allowGPUOptimizedContents")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowGPUOptimizedContents"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos12.5")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		public MTLTextureCompressionType CompressionType {
			[Export ("compressionType")]
			get {
				MTLTextureCompressionType ret;
				ret = (MTLTextureCompressionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("compressionType"));
				return ret!;
			}
		}
		/// <summary>Gets a description of how the texture can be used. (For example, as a write target for compute shaders.)</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTextureUsage Usage {
			[Export ("usage")]
			get {
				MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("usage"));
				return ret!;
			}
		}
		/// <summary>Gets the IOSurface that was used to create this texture, if one was used.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::IOSurface.IOSurface? IOSurface {
			[Export ("iosurface")]
			get {
				global::IOSurface.IOSurface ret;
				ret =  Runtime.GetNSObject<global::IOSurface.IOSurface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("iosurface")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the IOSurface plane used by the surface that is returned from <see cref="IMTLTexture.IOSurface" />.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint IOSurfacePlane {
			[Export ("iosurfacePlane")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("iosurfacePlane"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool Shareable {
			[Export ("isShareable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isShareable"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint FirstMipmapInTail {
			[Export ("firstMipmapInTail")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstMipmapInTail"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint TailSizeInBytes {
			[Export ("tailSizeInBytes")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tailSizeInBytes"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool IsSparse {
			[Export ("isSparse")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSparse"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLTextureSwizzleChannels Swizzle {
			[Export ("swizzle")]
			get {
				MTLTextureSwizzleChannels ret;
				ret = global::ObjCRuntime.Messaging.MTLTextureSwizzleChannels_objc_msgSend (this.Handle, Selector.GetHandle ("swizzle"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("gpuResourceID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLTextureSparseTier SparseTextureTier {
			[Export ("sparseTextureTier")]
			get {
				MTLTextureSparseTier ret;
				ret = (MTLTextureSparseTier) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sparseTextureTier"));
				return ret!;
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
		public MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLCpuCacheMode ret;
				ret = (MTLCpuCacheMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cpuCacheMode"));
				return ret!;
			}
		}
		/// <summary>Returns a description of the location and permissions of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLStorageMode StorageMode {
			[Export ("storageMode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLStorageMode ret;
				ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storageMode"));
				return ret!;
			}
		}
		/// <summary>Returns the heap that sub-allocated the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public IMTLHeap? Heap {
			[Export ("heap")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLHeap ret;
				ret =  Runtime.GetINativeObject<IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("heap")), false)!;
				return ret;
			}
		}
		/// <summary>Returns a Boolean value that tells whether future sub-allocations can alias the resource's memory.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool IsAliasable {
			[Export ("isAliasable")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAliasable"));
				return ret != 0;
			}
		}
		/// <summary>Returns the allocated size of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLResourceOptions ret;
				ret = (MTLResourceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceOptions"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint HeapOffset {
			[Export ("heapOffset")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heapOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLHazardTrackingMode HazardTrackingMode {
			[Export ("hazardTrackingMode")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLHazardTrackingMode ret;
				ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hazardTrackingMode"));
				return ret!;
			}
		}
	}
}
