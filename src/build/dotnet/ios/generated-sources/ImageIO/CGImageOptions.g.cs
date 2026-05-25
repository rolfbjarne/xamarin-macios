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
	/// <summary>Use an instance of this class to configure the CGImageSource.</summary>
	public unsafe partial class CGImageOptions  {
		/// <summary>Represents the value associated with the constant 'kCGImageSourceShouldAllowFloat'.</summary>
		[Field ("kCGImageSourceShouldAllowFloat",  "ImageIO")]
		internal static nint kShouldAllowFloat {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceShouldAllowFloat");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceShouldCache'.</summary>
		[Field ("kCGImageSourceShouldCache",  "ImageIO")]
		internal static nint kShouldCache {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceShouldCache");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceShouldCacheImmediately'.</summary>
		[Field ("kCGImageSourceShouldCacheImmediately",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static nint kShouldCacheImmediately {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceShouldCacheImmediately");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceTypeIdentifierHint'.</summary>
		[Field ("kCGImageSourceTypeIdentifierHint",  "ImageIO")]
		internal static nint kTypeIdentifierHint {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceTypeIdentifierHint");
			}
		}
	} /* class CGImageOptions */
}
