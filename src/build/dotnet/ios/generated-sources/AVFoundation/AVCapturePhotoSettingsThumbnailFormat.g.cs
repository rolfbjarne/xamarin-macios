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
	/// <summary>A raw format for an embedded thumbnail image.</summary>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public partial class AVCapturePhotoSettingsThumbnailFormat : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVCapturePhotoSettingsThumbnailFormat" /> with default (empty) values.</summary>
		public AVCapturePhotoSettingsThumbnailFormat () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVCapturePhotoSettingsThumbnailFormat" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVCapturePhotoSettingsThumbnailFormat (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the thumbnail codec.</summary><value>The thumbnail codec.</value><remarks>To be added.</remarks>
		public NSString? Codec {
			get {
				return GetNSStringValue (AVCapturePhotoSettingsThumbnailFormatKeys.CodecKey!);
			}
			set {
				SetStringValue (AVCapturePhotoSettingsThumbnailFormatKeys.CodecKey!, value);
			}
		}
		/// <summary>Gets or sets the thumbnail width.</summary><value>The thumbnail width.</value><remarks>To be added.</remarks>
		public NSNumber? Width {
			get {
				return Dictionary [AVCapturePhotoSettingsThumbnailFormatKeys.WidthKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVCapturePhotoSettingsThumbnailFormatKeys.WidthKey!, value);
			}
		}
		/// <summary>Gets or sets the thumbnail height.</summary><value>The thumbnail height.</value><remarks>To be added.</remarks>
		public NSNumber? Height {
			get {
				return Dictionary [AVCapturePhotoSettingsThumbnailFormatKeys.HeightKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVCapturePhotoSettingsThumbnailFormatKeys.HeightKey!, value);
			}
		}
#endif
	}
}
