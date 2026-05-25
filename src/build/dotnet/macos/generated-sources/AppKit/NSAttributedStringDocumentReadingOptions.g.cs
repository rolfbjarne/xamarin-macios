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
namespace AppKit {
	public partial class NSAttributedStringDocumentReadingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSAttributedStringDocumentReadingOptions" /> with default (empty) values.</summary>
		public NSAttributedStringDocumentReadingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSAttributedStringDocumentReadingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSAttributedStringDocumentReadingOptions (NSDictionary? dictionary) : base (dictionary) {}
		public NSAttributedStringDocumentType? DocumentType {
			get {
				return TryGetNativeValue (NSAttributedStringDocumentReadingOptionKey.DocumentTypeDocumentOption!, out var handle) ? global::AppKit.NSAttributedStringDocumentTypeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentReadingOptionKey.DocumentTypeDocumentOption!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public NSDictionary? DefaultAttributes {
			get {
				return GetNSDictionary (NSAttributedStringDocumentReadingOptionKey.DefaultAttributesDocumentOption!);
			}
			set {
				SetNativeValue (NSAttributedStringDocumentReadingOptionKey.DefaultAttributesDocumentOption!, value);
			}
		}
		public NSStringEncoding? CharacterEncoding {
			get {
				return (NSStringEncoding?) (ulong?) GetNUIntValue (NSAttributedStringDocumentReadingOptionKey.CharacterEncodingDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.CharacterEncodingDocumentOption!, (System.UInt64?)value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public global::WebKit.WebPreferences? WebPreferences {
			get {
				return Dictionary [NSAttributedStringDocumentReadingOptionKey.WebPreferencesDocumentOption!] as WebKit.WebPreferences;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentReadingOptionKey.WebPreferencesDocumentOption!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSObject? WebResourceLoadDelegate {
			get {
				return GetNativeValue<Foundation.NSObject> (NSAttributedStringDocumentReadingOptionKey.WebResourceLoadDelegateDocumentOption!);
			}
			set {
				SetNativeValue (NSAttributedStringDocumentReadingOptionKey.WebResourceLoadDelegateDocumentOption!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSUrl? BaseUrl {
			get {
				return Dictionary [NSAttributedStringDocumentReadingOptionKey.BaseUrlDocumentOption!] as Foundation.NSUrl;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentReadingOptionKey.BaseUrlDocumentOption!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? TextEncodingName {
			get {
				return GetStringValue (NSAttributedStringDocumentReadingOptionKey.TextEncodingNameDocumentOption!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentReadingOptionKey.TextEncodingNameDocumentOption!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? TextSizeMultiplier {
			get {
				return  GetFloatValue (NSAttributedStringDocumentReadingOptionKey.TextSizeMultiplierDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.TextSizeMultiplierDocumentOption!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? Timeout {
			get {
				return  GetFloatValue (NSAttributedStringDocumentReadingOptionKey.TimeoutDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.TimeoutDocumentOption!, value);
			}
		}
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public NSTextScalingType? TargetTextScaling {
			get {
				return (NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentReadingOptionKey.TargetTextScalingDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.TargetTextScalingDocumentOption!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public NSTextScalingType? SourceTextScaling {
			get {
				return (NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentReadingOptionKey.SourceTextScalingDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.SourceTextScalingDocumentOption!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? TextKit1ListMarkerFormat {
			get {
				return  GetBoolValue (NSAttributedStringDocumentReadingOptionKey.TextKit1ListMarkerFormatDocumentOption!);
			}
			set {
				SetBooleanValue (NSAttributedStringDocumentReadingOptionKey.TextKit1ListMarkerFormatDocumentOption!, value);
			}
		}
#endif
	}
}
