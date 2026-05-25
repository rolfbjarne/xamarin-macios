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
		public global::AppKit.NSColor? BackgroundColor {
			get {
				return Dictionary [NSAttributedStringDocumentAttributeKey.BackgroundColorDocumentAttribute!] as AppKit.NSColor;
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
		public global::AppKit.NSTextScalingType? TextScaling {
			get {
				return (global::AppKit.NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentAttributeKey.TextScalingDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.TextScalingDocumentAttribute!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public global::AppKit.NSTextScalingType? SourceTextScaling {
			get {
				return (global::AppKit.NSTextScalingType?) (long?) GetNIntValue (NSAttributedStringDocumentAttributeKey.SourceTextScalingDocumentAttribute!);
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
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public int? Converted {
			get {
				return  GetInt32Value (NSAttributedStringDocumentAttributeKey.ConvertedDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.ConvertedDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? FileType {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.FileTypeDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.FileTypeDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Title {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.TitleDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.TitleDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Company {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.CompanyDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.CompanyDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Copyright {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.CopyrightDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.CopyrightDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Subject {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.SubjectDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.SubjectDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Author {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.AuthorDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.AuthorDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string[]? Keywords {
			get {
				return GetArray<string> (NSAttributedStringDocumentAttributeKey.KeywordsDocumentAttribute!, (ptr) => CFString.FromHandle (ptr)!);
			}
			set {
				SetArrayValue (NSAttributedStringDocumentAttributeKey.KeywordsDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Comment {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.CommentDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.CommentDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Editor {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.EditorDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.EditorDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSDate? CreationTime {
			get {
				return Dictionary [NSAttributedStringDocumentAttributeKey.CreationTimeDocumentAttribute!] as Foundation.NSDate;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentAttributeKey.CreationTimeDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSDate? ModificationTime {
			get {
				return Dictionary [NSAttributedStringDocumentAttributeKey.ModificationTimeDocumentAttribute!] as Foundation.NSDate;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentAttributeKey.ModificationTimeDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Manager {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.ManagerDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.ManagerDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Category {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.CategoryDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.CategoryDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public global::AppKit.NSAppearance? Appearance {
			get {
				return Dictionary [NSAttributedStringDocumentAttributeKey.AppearanceDocumentAttribute!] as AppKit.NSAppearance;
			}
			set {
				SetNativeValue (NSAttributedStringDocumentAttributeKey.AppearanceDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? LeftMargin {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.LeftMarginDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.LeftMarginDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? RightMargin {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.RightMarginDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.RightMarginDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? TopMargin {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.TopMarginDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.TopMarginDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? BottomMargin {
			get {
				return  GetFloatValue (NSAttributedStringDocumentAttributeKey.BottomMarginDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.BottomMarginDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string[]? ExcludedElements {
			get {
				return GetArray<string> (NSAttributedStringDocumentAttributeKey.ExcludedElementsDocumentAttribute!, (ptr) => CFString.FromHandle (ptr)!);
			}
			set {
				SetArrayValue (NSAttributedStringDocumentAttributeKey.ExcludedElementsDocumentAttribute!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? TextEncodingName {
			get {
				return GetStringValue (NSAttributedStringDocumentAttributeKey.TextEncodingNameDocumentAttribute!);
			}
			set {
				SetStringValue (NSAttributedStringDocumentAttributeKey.TextEncodingNameDocumentAttribute!, value);
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public int? PrefixSpaces {
			get {
				return  GetInt32Value (NSAttributedStringDocumentAttributeKey.PrefixSpacesDocumentAttribute!);
			}
			set {
				SetNumberValue (NSAttributedStringDocumentAttributeKey.PrefixSpacesDocumentAttribute!, value);
			}
		}
#endif
	}
}
