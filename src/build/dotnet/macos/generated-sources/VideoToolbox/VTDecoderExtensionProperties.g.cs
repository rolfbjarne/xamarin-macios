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
namespace VideoToolbox {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public partial class VTDecoderExtensionProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTDecoderExtensionProperties" /> with default (empty) values.</summary>
		public VTDecoderExtensionProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTDecoderExtensionProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTDecoderExtensionProperties (NSDictionary? dictionary) : base (dictionary) {}
		public string? ExtensionIdentifier {
			get {
				return GetStringValue (VTExtensionPropertiesKey.ExtensionIdentifier!);
			}
			set {
				SetStringValue (VTExtensionPropertiesKey.ExtensionIdentifier!, value);
			}
		}
		public string? ExtensionName {
			get {
				return GetStringValue (VTExtensionPropertiesKey.ExtensionName!);
			}
			set {
				SetStringValue (VTExtensionPropertiesKey.ExtensionName!, value);
			}
		}
		public string? ContainingBundleName {
			get {
				return GetStringValue (VTExtensionPropertiesKey.ContainingBundleName!);
			}
			set {
				SetStringValue (VTExtensionPropertiesKey.ContainingBundleName!, value);
			}
		}
		public NSUrl? ExtensionUrl {
			get {
				return Dictionary [VTExtensionPropertiesKey.ExtensionUrl!] as Foundation.NSUrl;
			}
			set {
				SetNativeValue (VTExtensionPropertiesKey.ExtensionUrl!, value);
			}
		}
		public NSUrl? ContainingBundleUrl {
			get {
				return Dictionary [VTExtensionPropertiesKey.ContainingBundleUrl!] as Foundation.NSUrl;
			}
			set {
				SetNativeValue (VTExtensionPropertiesKey.ContainingBundleUrl!, value);
			}
		}
		public string? CodecName {
			get {
				return GetStringValue (VTExtensionPropertiesKey.CodecName!);
			}
			set {
				SetStringValue (VTExtensionPropertiesKey.CodecName!, value);
			}
		}
#endif
	}
}
