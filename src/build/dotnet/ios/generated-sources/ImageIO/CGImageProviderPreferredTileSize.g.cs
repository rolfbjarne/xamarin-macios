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
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe static partial class CGImageProviderPreferredTileSize  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Height;
		/// <summary>Represents the value associated with the constant 'kCGImageProviderPreferredTileHeight'.</summary>
		[Field ("kCGImageProviderPreferredTileHeight",  "ImageIO")]
		public static NSString Height {
			get {
				if (_Height is null)
					_Height = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageProviderPreferredTileHeight")!;
				return _Height;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Width;
		/// <summary>Represents the value associated with the constant 'kCGImageProviderPreferredTileWidth'.</summary>
		[Field ("kCGImageProviderPreferredTileWidth",  "ImageIO")]
		public static NSString Width {
			get {
				if (_Width is null)
					_Width = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageProviderPreferredTileWidth")!;
				return _Width;
			}
		}
	} /* class CGImageProviderPreferredTileSize */
}
