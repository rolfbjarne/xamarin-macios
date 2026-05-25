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
namespace Foundation {
	public partial class NSAttributedStringDocumentAttributes : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSAttributedStringDocumentAttributes" /> with default (empty) values.</summary>
		public NSAttributedStringDocumentAttributes () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSAttributedStringDocumentAttributes" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSAttributedStringDocumentAttributes (NSDictionary? dictionary) : base (dictionary) {}
		public NSStringEncoding? CharacterEncoding {
			get {
				return (NSStringEncoding?) (ulong?) GetNUIntValue (NSAttributedStringDocumentAttributeKey.CharacterEncodingDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.CharacterEncodingDocumentAttribute!, (System.UInt64?)value);
			}
		}
		public NSAttributedStringDocumentAttributes? DefaultAttributes {
			get {
				return GetStrongDictionary<NSAttributedStringDocumentAttributes>(NSAttributedStringDocumentAttributeKey.DefaultAttributesDocumentAttribute!, (dict) => new NSAttributedStringDocumentAttributes (dict));
			}
			set {
				SetNativeValue (NSAttributedStringDocumentAttributeKey.DefaultAttributesDocumentAttribute!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGSize? PaperSize {
			get {
				return  GetCGSizeValue (NSAttributedStringDocumentAttributeKey.PaperSizeDocumentAttribute!);
			}
			set {
				SetCGSizeValue (NSAttributedStringDocumentAttributeKey.PaperSizeDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public global::UIKit.UIEdgeInsets? PaperMargin {
			get {
				return  GetUIEdgeInsets (NSAttributedStringDocumentAttributeKey.PaperMarginDocumentAttribute!);
			}
			set {
				SetUIEdgeInsets (NSAttributedStringDocumentAttributeKey.PaperMarginDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGSize? ViewSize {
			get {
				return  GetCGSizeValue (NSAttributedStringDocumentAttributeKey.ViewSizeDocumentAttribute!);
			}
			set {
				SetCGSizeValue (NSAttributedStringDocumentAttributeKey.ViewSizeDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? ViewZoom {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.ViewZoomDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.ViewZoomDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDocumentViewMode? ViewMode {
			get {
				return (NSDocumentViewMode?) GetInt32Value (NSAttributedStringDocumentAttributeKey.ViewModeDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.ViewModeDocumentAttribute!, (System.Int32?)value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::UIKit.UIColor? BackgroundColor {
			get {
				return Dictionary [NSAttributedStringDocumentAttributeKey.BackgroundColorDocumentAttribute!] as UIKit.UIColor;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentAttributeKey.BackgroundColorDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? HyphenationFactor {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.HyphenationFactorDocumentAttribute!);
			}
			set {
				if (value < 0 || value > 1.0f) throw new ArgumentOutOfRangeException (nameof (value), value, "Value must be between 0 and 1");
				SetNumberValue (NSAttributedStringDocumentAttributeKey.HyphenationFactorDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? DefaultTabInterval {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.DefaultTabIntervalDocumentAttribute!);
			}
			set {
				if (value < 0 || value > 1.0f) throw new ArgumentOutOfRangeException (nameof (value), value, "Value must be between 0 and 1");
				SetNumberValue (NSAttributedStringDocumentAttributeKey.DefaultTabIntervalDocumentAttribute!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public global::UIKit.NSTextScalingType? TextScaling {
			get {
				return (global::UIKit.NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentAttributeKey.TextScalingDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.TextScalingDocumentAttribute!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public global::UIKit.NSTextScalingType? SourceTextScaling {
			get {
				return (global::UIKit.NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentAttributeKey.SourceTextScalingDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.SourceTextScalingDocumentAttribute!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public float? CocoaVersion {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.CocoaVersionDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.CocoaVersionDocumentAttribute!, value);
			}
		}
#endif
	}
}
