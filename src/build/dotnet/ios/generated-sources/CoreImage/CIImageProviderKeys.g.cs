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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CIImageProviderKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TileSizeKey;
		/// <summary>Represents the value associated with the constant 'kCIImageProviderTileSize'.</summary>
		[Field ("kCIImageProviderTileSize",  "CoreImage")]
		public static NSString TileSizeKey {
			get {
				if (_TileSizeKey is null)
					_TileSizeKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageProviderTileSize")!;
				return _TileSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserInfoKey;
		/// <summary>Represents the value associated with the constant 'kCIImageProviderUserInfo'.</summary>
		[Field ("kCIImageProviderUserInfo",  "CoreImage")]
		public static NSString UserInfoKey {
			get {
				if (_UserInfoKey is null)
					_UserInfoKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageProviderUserInfo")!;
				return _UserInfoKey;
			}
		}
	} /* class CIImageProviderKeys */
}
