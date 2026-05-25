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
namespace CoreText {
	public unsafe static partial class CTFontManagerErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontAssetNameKey;
		/// <summary>Represents the value associated with the constant 'kCTFontManagerErrorFontAssetNameKey'.</summary>
		[Field ("kCTFontManagerErrorFontAssetNameKey",  "CoreText")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString FontAssetNameKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_FontAssetNameKey is null)
					_FontAssetNameKey = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontManagerErrorFontAssetNameKey")!;
				return _FontAssetNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontDescriptorsKey;
		/// <summary>Represents the value associated with the constant 'kCTFontManagerErrorFontDescriptorsKey'.</summary>
		[Field ("kCTFontManagerErrorFontDescriptorsKey",  "CoreText")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString FontDescriptorsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_FontDescriptorsKey is null)
					_FontDescriptorsKey = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontManagerErrorFontDescriptorsKey")!;
				return _FontDescriptorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontUrlsKey;
		/// <summary>Represents the value associated with the constant 'kCTFontManagerErrorFontURLsKey'.</summary>
		[Field ("kCTFontManagerErrorFontURLsKey",  "CoreText")]
		public static NSString FontUrlsKey {
			get {
				if (_FontUrlsKey is null)
					_FontUrlsKey = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontManagerErrorFontURLsKey")!;
				return _FontUrlsKey;
			}
		}
	} /* class CTFontManagerErrorKeys */
}
