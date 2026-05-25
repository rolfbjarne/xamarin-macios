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
namespace CoreImage {
	#pragma warning disable CS1573
	/// <summary>The input to a <see cref="T:CoreImage.CIImageProcessorKernel" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "CIImageProcessorInput", WrapperType = typeof (CIImageProcessorInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Region", Selector = "region", PropertyType = typeof (CGRect), GetterSelector = "region", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BytesPerRow", Selector = "bytesPerRow", PropertyType = typeof (UIntPtr), GetterSelector = "bytesPerRow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Format", Selector = "format", PropertyType = typeof (CIFormat), GetterSelector = "format", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BaseAddress", Selector = "baseAddress", PropertyType = typeof (IntPtr), GetterSelector = "baseAddress", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PixelBuffer", Selector = "pixelBuffer", PropertyType = typeof (CVPixelBuffer), GetterSelector = "pixelBuffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MetalTexture", Selector = "metalTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "metalTexture", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Surface", Selector = "surface", PropertyType = typeof (global::IOSurface.IOSurface), GetterSelector = "surface", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Digest", Selector = "digest", PropertyType = typeof (ulong), GetterSelector = "digest", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RoiTileCount", Selector = "roiTileCount", PropertyType = typeof (UIntPtr), GetterSelector = "roiTileCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RoiTileIndex", Selector = "roiTileIndex", PropertyType = typeof (UIntPtr), GetterSelector = "roiTileIndex", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICIImageProcessorInput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("BaseAddress")]
		[DynamicDependencyAttribute ("BytesPerRow")]
		[DynamicDependencyAttribute ("Digest")]
		[DynamicDependencyAttribute ("Format")]
		[DynamicDependencyAttribute ("MetalTexture")]
		[DynamicDependencyAttribute ("PixelBuffer")]
		[DynamicDependencyAttribute ("Region")]
		[DynamicDependencyAttribute ("RoiTileCount")]
		[DynamicDependencyAttribute ("RoiTileIndex")]
		[DynamicDependencyAttribute ("Surface")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIImageProcessorInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIImageProcessorInput ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The region of interest in the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect Region {
			[Export ("region")]
			get {
				return _GetRegion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetRegion (ICIImageProcessorInput This)
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
		/// <summary>The number of bytes in a single row of the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint BytesPerRow {
			[Export ("bytesPerRow")]
			get {
				return _GetBytesPerRow (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBytesPerRow (ICIImageProcessorInput This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bytesPerRow"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The pixel format of the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIFormat Format {
			[Export ("format")]
			get {
				return _GetFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIFormat _GetFormat (ICIImageProcessorInput This)
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
		internal static nint _GetBaseAddress (ICIImageProcessorInput This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("baseAddress"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The input <see cref="T:CoreVideo.CVPixelBuffer" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreVideo.CVPixelBuffer? PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				return _GetPixelBuffer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreVideo.CVPixelBuffer _GetPixelBuffer (ICIImageProcessorInput This)
		{
			global::CoreVideo.CVPixelBuffer ret;
			ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pixelBuffer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The input <see cref="T:Metal.IMTLTexture" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? MetalTexture {
			[Export ("metalTexture")]
			get {
				return _GetMetalTexture (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetMetalTexture (ICIImageProcessorInput This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("metalTexture")), false)!;
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
		internal static global::IOSurface.IOSurface _GetSurface (ICIImageProcessorInput This)
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
		internal static ulong _GetDigest (ICIImageProcessorInput This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("digest"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.OptionalMember]
		public virtual nuint RoiTileCount {
			[Export ("roiTileCount")]
			get {
				return _GetRoiTileCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetRoiTileCount (ICIImageProcessorInput This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roiTileCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.OptionalMember]
		public virtual nuint RoiTileIndex {
			[Export ("roiTileIndex")]
			get {
				return _GetRoiTileIndex (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetRoiTileIndex (ICIImageProcessorInput This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roiTileIndex"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICIImageProcessorInput" /> interface to support all the methods from the CIImageProcessorInput protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICIImageProcessorInput" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CIImageProcessorInput protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CIImageProcessorInput_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ulong GetDigest (this ICIImageProcessorInput This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("digest"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetRoiTileCount (this ICIImageProcessorInput This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roiTileCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetRoiTileIndex (this ICIImageProcessorInput This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roiTileIndex"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIImageProcessorInputWrapper : BaseWrapper, ICIImageProcessorInput {
		public CIImageProcessorInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIImageProcessorInputWrapper))]
		static CIImageProcessorInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The region of interest in the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>The number of bytes in a single row of the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint BytesPerRow {
			[Export ("bytesPerRow")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bytesPerRow"));
				return ret;
			}
		}
		/// <summary>The pixel format of the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>The input <see cref="T:CoreVideo.CVPixelBuffer" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreVideo.CVPixelBuffer? PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				global::CoreVideo.CVPixelBuffer ret;
				ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pixelBuffer")), false)!;
				return ret;
			}
		}
		/// <summary>The input <see cref="T:Metal.IMTLTexture" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? MetalTexture {
			[Export ("metalTexture")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("metalTexture")), false)!;
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
