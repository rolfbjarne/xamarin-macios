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
namespace CoreImage {
	#pragma warning disable CS1573
	/// <summary>The output of a <see cref="T:CoreImage.CIImageProcessorKernel" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "CIImageProcessorOutput", WrapperType = typeof (CIImageProcessorOutputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Region", Selector = "region", PropertyType = typeof (CGRect), GetterSelector = "region", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BytesPerRow", Selector = "bytesPerRow", PropertyType = typeof (UIntPtr), GetterSelector = "bytesPerRow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Format", Selector = "format", PropertyType = typeof (CIFormat), GetterSelector = "format", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BaseAddress", Selector = "baseAddress", PropertyType = typeof (IntPtr), GetterSelector = "baseAddress", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PixelBuffer", Selector = "pixelBuffer", PropertyType = typeof (CVPixelBuffer), GetterSelector = "pixelBuffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MetalTexture", Selector = "metalTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "metalTexture", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MetalCommandBuffer", Selector = "metalCommandBuffer", PropertyType = typeof (IMTLCommandBuffer), GetterSelector = "metalCommandBuffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Surface", Selector = "surface", PropertyType = typeof (global::IOSurface.IOSurface), GetterSelector = "surface", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Digest", Selector = "digest", PropertyType = typeof (ulong), GetterSelector = "digest", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICIImageProcessorOutput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("BaseAddress")]
		[DynamicDependencyAttribute ("BytesPerRow")]
		[DynamicDependencyAttribute ("Digest")]
		[DynamicDependencyAttribute ("Format")]
		[DynamicDependencyAttribute ("MetalCommandBuffer")]
		[DynamicDependencyAttribute ("MetalTexture")]
		[DynamicDependencyAttribute ("PixelBuffer")]
		[DynamicDependencyAttribute ("Region")]
		[DynamicDependencyAttribute ("Surface")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIImageProcessorOutputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIImageProcessorOutput ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The <see cref="T:CoreGraphics.CGRect" /> to which the processing was applied.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect Region {
			[Export ("region")]
			get {
				return _GetRegion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetRegion (ICIImageProcessorOutput This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("region"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("region"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>The number of bytes in a single row of the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint BytesPerRow {
			[Export ("bytesPerRow")]
			get {
				return _GetBytesPerRow (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBytesPerRow (ICIImageProcessorOutput This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bytesPerRow"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The colorspace of the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIFormat Format {
			[Export ("format")]
			get {
				return _GetFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIFormat _GetFormat (ICIImageProcessorOutput This)
		{
			CIFormat ret;
			ret = (CIFormat) global::ObjCRuntime.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("format"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The memory address of the data buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint BaseAddress {
			[Export ("baseAddress")]
			get {
				return _GetBaseAddress (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetBaseAddress (ICIImageProcessorOutput This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("baseAddress"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The output image, as a <see cref="T:CoreVideo.CVPixelBuffer" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreVideo.CVPixelBuffer? PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				return _GetPixelBuffer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreVideo.CVPixelBuffer _GetPixelBuffer (ICIImageProcessorOutput This)
		{
			global::CoreVideo.CVPixelBuffer ret;
			ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pixelBuffer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The Metal <see cref="T:Metal.IMTLTexture" /> of the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? MetalTexture {
			[Export ("metalTexture")]
			get {
				return _GetMetalTexture (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetMetalTexture (ICIImageProcessorOutput This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("metalTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The Metal command buffer for the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLCommandBuffer? MetalCommandBuffer {
			[Export ("metalCommandBuffer")]
			get {
				return _GetMetalCommandBuffer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLCommandBuffer _GetMetalCommandBuffer (ICIImageProcessorOutput This)
		{
			global::Metal.IMTLCommandBuffer ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("metalCommandBuffer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::IOSurface.IOSurface Surface {
			[Export ("surface")]
			get {
				return _GetSurface (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::IOSurface.IOSurface _GetSurface (ICIImageProcessorOutput This)
		{
			global::IOSurface.IOSurface ret;
			ret =  Runtime.GetNSObject<global::IOSurface.IOSurface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("surface")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.OptionalMember]
		public virtual ulong Digest {
			[Export ("digest")]
			get {
				return _GetDigest (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetDigest (ICIImageProcessorOutput This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("digest"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICIImageProcessorOutput" /> interface to support all the methods from the CIImageProcessorOutput protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICIImageProcessorOutput" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CIImageProcessorOutput protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CIImageProcessorOutput_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ulong GetDigest (this ICIImageProcessorOutput This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("digest"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIImageProcessorOutputWrapper : BaseWrapper, ICIImageProcessorOutput {
		public CIImageProcessorOutputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIImageProcessorOutputWrapper))]
		static CIImageProcessorOutputWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The <see cref="T:CoreGraphics.CGRect" /> to which the processing was applied.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect Region {
			[Export ("region")]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("region"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("region"));
				}
				return ret!;
			}
		}
		/// <summary>The number of bytes in a single row of the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint BytesPerRow {
			[Export ("bytesPerRow")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bytesPerRow"));
				return ret;
			}
		}
		/// <summary>The colorspace of the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIFormat Format {
			[Export ("format")]
			get {
				CIFormat ret;
				ret = (CIFormat) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("format"));
				return ret;
			}
		}
		/// <summary>The memory address of the data buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint BaseAddress {
			[Export ("baseAddress")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("baseAddress"));
				return ret;
			}
		}
		/// <summary>The output image, as a <see cref="T:CoreVideo.CVPixelBuffer" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreVideo.CVPixelBuffer? PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				global::CoreVideo.CVPixelBuffer ret;
				ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pixelBuffer")), false)!;
				return ret;
			}
		}
		/// <summary>The Metal <see cref="T:Metal.IMTLTexture" /> of the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? MetalTexture {
			[Export ("metalTexture")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("metalTexture")), false)!;
				return ret;
			}
		}
		/// <summary>The Metal command buffer for the output image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLCommandBuffer? MetalCommandBuffer {
			[Export ("metalCommandBuffer")]
			get {
				global::Metal.IMTLCommandBuffer ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("metalCommandBuffer")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::IOSurface.IOSurface Surface {
			[Export ("surface")]
			get {
				global::IOSurface.IOSurface ret;
				ret =  Runtime.GetNSObject<global::IOSurface.IOSurface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("surface")), false)!;
				return ret;
			}
		}
	}
}
