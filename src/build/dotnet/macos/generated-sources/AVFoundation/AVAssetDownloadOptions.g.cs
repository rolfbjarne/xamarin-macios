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
namespace AVFoundation {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public partial class AVAssetDownloadOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVAssetDownloadOptions" /> with default (empty) values.</summary>
		public AVAssetDownloadOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVAssetDownloadOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVAssetDownloadOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? MinimumRequiredMediaBitrate {
			get {
				return Dictionary [AVAssetDownloadTaskKeys.MinimumRequiredMediaBitrateKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVAssetDownloadTaskKeys.MinimumRequiredMediaBitrateKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public AVMediaSelection? MediaSelection {
			get {
				return Dictionary [AVAssetDownloadTaskKeys.MediaSelectionKey!] as AVFoundation.AVMediaSelection;
			}
			set {
				SetNativeValue (AVAssetDownloadTaskKeys.MediaSelectionKey!, value);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? MediaSelectionPrefersMultichannel {
			get {
				return  GetBoolValue (AVAssetDownloadTaskKeys.MediaSelectionPrefersMultichannelKey!);
			}
			set {
				SetBooleanValue (AVAssetDownloadTaskKeys.MediaSelectionPrefersMultichannelKey!, value);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? PrefersHdr {
			get {
				return  GetBoolValue (AVAssetDownloadTaskKeys.PrefersHdrKey!);
			}
			set {
				SetBooleanValue (AVAssetDownloadTaskKeys.PrefersHdrKey!, value);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CGSize? MinimumRequiredPresentationSize {
			get {
				return  GetCGSizeValue (AVAssetDownloadTaskKeys.MinimumRequiredPresentationSizeKey!);
			}
			set {
				SetCGSizeValue (AVAssetDownloadTaskKeys.MinimumRequiredPresentationSizeKey!, value);
			}
		}
#endif
	}
}
