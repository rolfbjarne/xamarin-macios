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
namespace AVFoundation {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class AVAssetDownloadTaskKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSelectionKey;
		/// <summary>Represents the value associated with the constant 'AVAssetDownloadTaskMediaSelectionKey'.</summary>
		[Field ("AVAssetDownloadTaskMediaSelectionKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString MediaSelectionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MediaSelectionKey is null)
					_MediaSelectionKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDownloadTaskMediaSelectionKey")!;
				return _MediaSelectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSelectionPrefersMultichannelKey;
		/// <summary>Represents the value associated with the constant 'AVAssetDownloadTaskMediaSelectionPrefersMultichannelKey'.</summary>
		[Field ("AVAssetDownloadTaskMediaSelectionPrefersMultichannelKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MediaSelectionPrefersMultichannelKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MediaSelectionPrefersMultichannelKey is null)
					_MediaSelectionPrefersMultichannelKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDownloadTaskMediaSelectionPrefersMultichannelKey")!;
				return _MediaSelectionPrefersMultichannelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimumRequiredMediaBitrateKey;
		/// <summary>Represents the value associated with the constant 'AVAssetDownloadTaskMinimumRequiredMediaBitrateKey'.</summary>
		[Field ("AVAssetDownloadTaskMinimumRequiredMediaBitrateKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString MinimumRequiredMediaBitrateKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MinimumRequiredMediaBitrateKey is null)
					_MinimumRequiredMediaBitrateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDownloadTaskMinimumRequiredMediaBitrateKey")!;
				return _MinimumRequiredMediaBitrateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimumRequiredPresentationSizeKey;
		/// <summary>Represents the value associated with the constant 'AVAssetDownloadTaskMinimumRequiredPresentationSizeKey'.</summary>
		[Field ("AVAssetDownloadTaskMinimumRequiredPresentationSizeKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MinimumRequiredPresentationSizeKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MinimumRequiredPresentationSizeKey is null)
					_MinimumRequiredPresentationSizeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDownloadTaskMinimumRequiredPresentationSizeKey")!;
				return _MinimumRequiredPresentationSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrefersHdrKey;
		/// <summary>Represents the value associated with the constant 'AVAssetDownloadTaskPrefersHDRKey'.</summary>
		[Field ("AVAssetDownloadTaskPrefersHDRKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PrefersHdrKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PrefersHdrKey is null)
					_PrefersHdrKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDownloadTaskPrefersHDRKey")!;
				return _PrefersHdrKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrefersLosslessAudioKey;
		/// <summary>Represents the value associated with the constant 'AVAssetDownloadTaskPrefersLosslessAudioKey'.</summary>
		[Field ("AVAssetDownloadTaskPrefersLosslessAudioKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PrefersLosslessAudioKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PrefersLosslessAudioKey is null)
					_PrefersLosslessAudioKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDownloadTaskPrefersLosslessAudioKey")!;
				return _PrefersLosslessAudioKey;
			}
		}
	} /* class AVAssetDownloadTaskKeys */
}
