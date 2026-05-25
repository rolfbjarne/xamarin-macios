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
namespace UIKit {
	public partial class NSAttributedStringDocumentReadingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSAttributedStringDocumentReadingOptions" /> with default (empty) values.</summary>
		public NSAttributedStringDocumentReadingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSAttributedStringDocumentReadingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSAttributedStringDocumentReadingOptions (NSDictionary? dictionary) : base (dictionary) {}
		public NSAttributedStringDocumentType? DocumentType {
			get {
				return TryGetNativeValue (NSAttributedStringDocumentReadingOptionKey.DocumentTypeDocumentOption!, out var handle) ? global::UIKit.NSAttributedStringDocumentTypeExtensions.GetNullableValue (handle) : null;
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
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSTextScalingType? TargetTextScaling {
			get {
				return (NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentReadingOptionKey.TargetTextScalingDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.TargetTextScalingDocumentOption!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSTextScalingType? SourceTextScaling {
			get {
				return (NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentReadingOptionKey.SourceTextScalingDocumentOption!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentReadingOptionKey.SourceTextScalingDocumentOption!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
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
