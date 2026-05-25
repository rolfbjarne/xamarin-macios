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
namespace ImageIO {
	/// <summary>Configuration options used when loading thumbnails using CGImageSource.</summary>
	public unsafe partial class CGImageThumbnailOptions  {
		/// <summary>Represents the value associated with the constant 'kCGImageSourceSubsampleFactor'.</summary>
		[Field ("kCGImageSourceSubsampleFactor",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static nint kCGImageSourceSubsampleFactor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceSubsampleFactor");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceCreateThumbnailFromImageAlways'.</summary>
		[Field ("kCGImageSourceCreateThumbnailFromImageAlways",  "ImageIO")]
		internal static nint kCreateThumbnailFromImageAlways {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceCreateThumbnailFromImageAlways");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceCreateThumbnailFromImageIfAbsent'.</summary>
		[Field ("kCGImageSourceCreateThumbnailFromImageIfAbsent",  "ImageIO")]
		internal static nint kCreateThumbnailFromImageIfAbsent {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceCreateThumbnailFromImageIfAbsent");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceCreateThumbnailWithTransform'.</summary>
		[Field ("kCGImageSourceCreateThumbnailWithTransform",  "ImageIO")]
		internal static nint kCreateThumbnailWithTransform {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceCreateThumbnailWithTransform");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceThumbnailMaxPixelSize'.</summary>
		[Field ("kCGImageSourceThumbnailMaxPixelSize",  "ImageIO")]
		internal static nint kThumbnailMaxPixelSize {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceThumbnailMaxPixelSize");
			}
		}
	} /* class CGImageThumbnailOptions */
}
