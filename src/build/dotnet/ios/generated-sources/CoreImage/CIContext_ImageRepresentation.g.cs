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
	/// <summary>Extension methods for <see cref="T:CoreImage.CIContext" /> that can generate common image formats.</summary>
	public unsafe static partial class CIContext_ImageRepresentation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIContext");
		[Export ("HEIF10RepresentationOfImage:colorSpace:options:error:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? GetHeif10Representation (this CIContext This, CIImage image, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("HEIF10RepresentationOfImage:colorSpace:options:error:"), image__handle__, colorSpace.Handle, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? GetHeif10Representation (this CIContext This, CIImage image, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
		{
			return GetHeif10Representation (This, image, colorSpace, options.GetDictionary ()!, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("HEIFRepresentationOfImage:format:colorSpace:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetHeifRepresentation (this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, NSDictionary options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("HEIFRepresentationOfImage:format:colorSpace:options:"), image__handle__, (int)format, colorSpace.Handle, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetHeifRepresentation (this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options)
		{
			return GetHeifRepresentation (This, image, format, colorSpace, options.GetDictionary ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">The image input to be processed.</param><param name="colorSpace">The color space to be used.</param><param name="options">Processing arguments.</param><summary>Applies the processing of this context to the <paramref name="image" /> and returns a JPEG image of the result.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("JPEGRepresentationOfImage:colorSpace:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetJpegRepresentation (this CIContext This, CIImage image, CGColorSpace colorSpace, NSDictionary options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("JPEGRepresentationOfImage:colorSpace:options:"), image__handle__, colorSpace.Handle, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetJpegRepresentation (this CIContext This, CIImage image, CGColorSpace colorSpace, CIImageRepresentationOptions options)
		{
			return GetJpegRepresentation (This, image, colorSpace, options.GetDictionary ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("PNGRepresentationOfImage:format:colorSpace:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetPngRepresentation (this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, NSDictionary options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PNGRepresentationOfImage:format:colorSpace:options:"), image__handle__, (int)format, colorSpace.Handle, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetPngRepresentation (this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options)
		{
			return GetPngRepresentation (This, image, format, colorSpace, options.GetDictionary ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">The image input to be processed.</param><param name="format">The desired pixel format.</param><param name="colorSpace">The color space to be used.</param><param name="options">Processing arguments.</param><summary>Applies the processing of this context to the <paramref name="image" /> and returns a TIFF image of the result.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("TIFFRepresentationOfImage:format:colorSpace:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetTiffRepresentation (this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, NSDictionary options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("TIFFRepresentationOfImage:format:colorSpace:options:"), image__handle__, (int)format, colorSpace.Handle, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetTiffRepresentation (this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options)
		{
			return GetTiffRepresentation (This, image, format, colorSpace, options.GetDictionary ()!);
		}
		[Export ("writeHEIF10RepresentationOfImage:toURL:colorSpace:options:error:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteHeif10Representation (this CIContext This, CIImage image, NSUrl url, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("writeHEIF10RepresentationOfImage:toURL:colorSpace:options:error:"), image__handle__, url__handle__, colorSpace.Handle, options__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (url);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteHeif10Representation (this CIContext This, CIImage image, NSUrl url, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
		{
			return WriteHeif10Representation (This, image, url, colorSpace, options.GetDictionary ()!, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="url">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeHEIFRepresentationOfImage:toURL:format:colorSpace:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteHeifRepresentation (this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("writeHEIFRepresentationOfImage:toURL:format:colorSpace:options:error:"), image__handle__, url__handle__, (int)format, colorSpace.Handle, options__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (url);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="url">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteHeifRepresentation (this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
		{
			return WriteHeifRepresentation (This, image, url, format, colorSpace, options.GetDictionary ()!, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">The image input to be processed.</param><param name="url">The file URL to which the image should be written.</param><param name="colorSpace">The color space to be used.</param><param name="options">Processing arguments.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Applies the processing of this context to the <paramref name="image" /> and writes a JPEG image of the result to <paramref name="url" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeJPEGRepresentationOfImage:toURL:colorSpace:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteJpegRepresentation (this CIContext This, CIImage image, NSUrl url, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("writeJPEGRepresentationOfImage:toURL:colorSpace:options:error:"), image__handle__, url__handle__, colorSpace.Handle, options__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (url);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="url">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteJpegRepresentation (this CIContext This, CIImage image, NSUrl url, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
		{
			return WriteJpegRepresentation (This, image, url, colorSpace, options.GetDictionary ()!, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="url">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writePNGRepresentationOfImage:toURL:format:colorSpace:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WritePngRepresentation (this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("writePNGRepresentationOfImage:toURL:format:colorSpace:options:error:"), image__handle__, url__handle__, (int)format, colorSpace.Handle, options__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (url);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="url">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WritePngRepresentation (this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
		{
			return WritePngRepresentation (This, image, url, format, colorSpace, options.GetDictionary ()!, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">The image input to be processed.</param><param name="url">To be added.</param><param name="format">The desired pixel format.</param><param name="colorSpace">The color space to be used.</param><param name="options">Processing arguments.</param><param name="error">If not <see langword="null" />, error that occurred during processing.</param><summary>Applies the processing of this context to the <paramref name="image" /> and writes a TIFF image of the result to <paramref name="url" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeTIFFRepresentationOfImage:toURL:format:colorSpace:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteTiffRepresentation (this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, NSDictionary options, out NSError error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("writeTIFFRepresentationOfImage:toURL:format:colorSpace:options:error:"), image__handle__, url__handle__, (int)format, colorSpace.Handle, options__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (url);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="url">To be added.</param><param name="format">To be added.</param><param name="colorSpace">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteTiffRepresentation (this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError error)
		{
			return WriteTiffRepresentation (This, image, url, format, colorSpace, options.GetDictionary ()!, out error);
		}
	} /* class CIContext_ImageRepresentation */
}
