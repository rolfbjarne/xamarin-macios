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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class AVPlayerItemVideoOutputSettings : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVPlayerItemVideoOutputSettings" /> with default (empty) values.</summary>
		public AVPlayerItemVideoOutputSettings () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVPlayerItemVideoOutputSettings" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVPlayerItemVideoOutputSettings (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public AVColorProperties? ColorProperties {
			get {
				return GetStrongDictionary<AVColorProperties>(AVPlayerItemVideoOutputSettingsKeys.ColorPropertiesKey!, (dict) => new AVColorProperties (dict));
			}
			set {
				SetNativeValue (AVPlayerItemVideoOutputSettingsKeys.ColorPropertiesKey!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public AVCompressionProperties? CompressionProperties {
			get {
				return GetStrongDictionary<AVCompressionProperties>(AVPlayerItemVideoOutputSettingsKeys.CompressionPropertiesKey!, (dict) => new AVCompressionProperties (dict));
			}
			set {
				SetNativeValue (AVPlayerItemVideoOutputSettingsKeys.CompressionPropertiesKey!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? AllowWideColor {
			get {
				return  GetBoolValue (AVPlayerItemVideoOutputSettingsKeys.AllowWideColorKey!);
			}
			set {
				SetBooleanValue (AVPlayerItemVideoOutputSettingsKeys.AllowWideColorKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? Codec {
			get {
				return GetNSStringValue (AVPlayerItemVideoOutputSettingsKeys.CodecKey!);
			}
			set {
				SetStringValue (AVPlayerItemVideoOutputSettingsKeys.CodecKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? ScalingMode {
			get {
				return GetNSStringValue (AVPlayerItemVideoOutputSettingsKeys.ScalingModeKey!);
			}
			set {
				SetStringValue (AVPlayerItemVideoOutputSettingsKeys.ScalingModeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? Width {
			get {
				return Dictionary [AVPlayerItemVideoOutputSettingsKeys.WidthKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVPlayerItemVideoOutputSettingsKeys.WidthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? Height {
			get {
				return Dictionary [AVPlayerItemVideoOutputSettingsKeys.HeightKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVPlayerItemVideoOutputSettingsKeys.HeightKey!, value);
			}
		}
#endif
	}
}
