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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	[SupportedOSPlatform ("ios18.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class AVCaptionSettings : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVCaptionSettings" /> with default (empty) values.</summary>
		public AVCaptionSettings () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVCaptionSettings" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVCaptionSettings (NSDictionary? dictionary) : base (dictionary) {}
		public AVMediaTypes? MediaSubType {
			get {
				return TryGetNativeValue (AVCaptionSettingsKeys.MediaSubTypeKey!, out var handle) ? global::AVFoundation.AVMediaTypesExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (AVCaptionSettingsKeys.MediaSubTypeKey!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public AVMediaTypes? MediaType {
			get {
				return TryGetNativeValue (AVCaptionSettingsKeys.MediaTypeKey!, out var handle) ? global::AVFoundation.AVMediaTypesExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (AVCaptionSettingsKeys.MediaTypeKey!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public bool? UseTimeCodeFrameDuration {
			get {
				return  GetBoolValue (AVCaptionSettingsKeys.UseTimeCodeFrameDurationKey!);
			}
			set {
				SetBooleanValue (AVCaptionSettingsKeys.UseTimeCodeFrameDurationKey!, value);
			}
		}
		public bool? UseDropFrameTimeCode {
			get {
				return  GetBoolValue (AVCaptionSettingsKeys.UseDropFrameTimeCodeKey!);
			}
			set {
				SetBooleanValue (AVCaptionSettingsKeys.UseDropFrameTimeCodeKey!, value);
			}
		}
#endif
	}
}
