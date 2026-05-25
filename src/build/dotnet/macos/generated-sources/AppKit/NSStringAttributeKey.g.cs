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
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSStringAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdaptiveImageGlyph;
		/// <summary>Represents the value associated with the constant 'NSAdaptiveImageGlyphAttributeName'.</summary>
		[Field ("NSAdaptiveImageGlyphAttributeName",  "AppKit")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public static NSString AdaptiveImageGlyph {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				if (_AdaptiveImageGlyph is null)
					_AdaptiveImageGlyph = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAdaptiveImageGlyphAttributeName")!;
				return _AdaptiveImageGlyph;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Attachment;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAttachmentAttributeName",  "AppKit")]
		public static NSString Attachment {
			get {
				if (_Attachment is null)
					_Attachment = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAttachmentAttributeName")!;
				return _Attachment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSBackgroundColorAttributeName",  "AppKit")]
		public static NSString BackgroundColor {
			get {
				if (_BackgroundColor is null)
					_BackgroundColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSBackgroundColorAttributeName")!;
				return _BackgroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineOffset;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSBaselineOffsetAttributeName",  "AppKit")]
		public static NSString BaselineOffset {
			get {
				if (_BaselineOffset is null)
					_BaselineOffset = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSBaselineOffsetAttributeName")!;
				return _BaselineOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterShape;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCharacterShapeAttributeName",  "AppKit")]
		public static NSString CharacterShape {
			get {
				if (_CharacterShape is null)
					_CharacterShape = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCharacterShapeAttributeName")!;
				return _CharacterShape;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Cursor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCursorAttributeName",  "AppKit")]
		public static NSString Cursor {
			get {
				if (_Cursor is null)
					_Cursor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCursorAttributeName")!;
				return _Cursor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Expansion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSExpansionAttributeName",  "AppKit")]
		public static NSString Expansion {
			get {
				if (_Expansion is null)
					_Expansion = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSExpansionAttributeName")!;
				return _Expansion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Font;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontAttributeName",  "AppKit")]
		public static NSString Font {
			get {
				if (_Font is null)
					_Font = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontAttributeName")!;
				return _Font;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForegroundColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSForegroundColorAttributeName",  "AppKit")]
		public static NSString ForegroundColor {
			get {
				if (_ForegroundColor is null)
					_ForegroundColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSForegroundColorAttributeName")!;
				return _ForegroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GlyphInfo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSGlyphInfoAttributeName",  "AppKit")]
		public static NSString GlyphInfo {
			get {
				if (_GlyphInfo is null)
					_GlyphInfo = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSGlyphInfoAttributeName")!;
				return _GlyphInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KerningAdjustment;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSKernAttributeName",  "AppKit")]
		public static NSString KerningAdjustment {
			get {
				if (_KerningAdjustment is null)
					_KerningAdjustment = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSKernAttributeName")!;
				return _KerningAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ligature;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSLigatureAttributeName",  "AppKit")]
		public static NSString Ligature {
			get {
				if (_Ligature is null)
					_Ligature = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSLigatureAttributeName")!;
				return _Ligature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Link;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSLinkAttributeName",  "AppKit")]
		public static NSString Link {
			get {
				if (_Link is null)
					_Link = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSLinkAttributeName")!;
				return _Link;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkedClauseSegment;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMarkedClauseSegmentAttributeName",  "AppKit")]
		public static NSString MarkedClauseSegment {
			get {
				if (_MarkedClauseSegment is null)
					_MarkedClauseSegment = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSMarkedClauseSegmentAttributeName")!;
				return _MarkedClauseSegment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFileTypeDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSFileTypeDocumentOption'.</summary>
		[Field ("NSFileTypeDocumentOption",  "AppKit")]
		internal static NSString NSFileTypeDocumentOption {
			get {
				if (_NSFileTypeDocumentOption is null)
					_NSFileTypeDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFileTypeDocumentOption")!;
				return _NSFileTypeDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Obliqueness;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSObliquenessAttributeName",  "AppKit")]
		public static NSString Obliqueness {
			get {
				if (_Obliqueness is null)
					_Obliqueness = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSObliquenessAttributeName")!;
				return _Obliqueness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParagraphStyle;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSParagraphStyleAttributeName",  "AppKit")]
		public static NSString ParagraphStyle {
			get {
				if (_ParagraphStyle is null)
					_ParagraphStyle = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSParagraphStyleAttributeName")!;
				return _ParagraphStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Shadow;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSShadowAttributeName",  "AppKit")]
		public static NSString Shadow {
			get {
				if (_Shadow is null)
					_Shadow = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSShadowAttributeName")!;
				return _Shadow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentOption'.</summary>
		[Field ("NSSourceTextScalingDocumentOption",  "AppKit")]
		internal static NSString SourceTextScalingDocumentOption {
			get {
				if (_SourceTextScalingDocumentOption is null)
					_SourceTextScalingDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSourceTextScalingDocumentOption")!;
				return _SourceTextScalingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpellingState;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSpellingStateAttributeName",  "AppKit")]
		public static NSString SpellingState {
			get {
				if (_SpellingState is null)
					_SpellingState = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellingStateAttributeName")!;
				return _SpellingState;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrikethroughColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSStrikethroughColorAttributeName",  "AppKit")]
		public static NSString StrikethroughColor {
			get {
				if (_StrikethroughColor is null)
					_StrikethroughColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSStrikethroughColorAttributeName")!;
				return _StrikethroughColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrikethroughStyle;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSStrikethroughStyleAttributeName",  "AppKit")]
		public static NSString StrikethroughStyle {
			get {
				if (_StrikethroughStyle is null)
					_StrikethroughStyle = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSStrikethroughStyleAttributeName")!;
				return _StrikethroughStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrokeColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSStrokeColorAttributeName",  "AppKit")]
		public static NSString StrokeColor {
			get {
				if (_StrokeColor is null)
					_StrokeColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSStrokeColorAttributeName")!;
				return _StrokeColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrokeWidth;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSStrokeWidthAttributeName",  "AppKit")]
		public static NSString StrokeWidth {
			get {
				if (_StrokeWidth is null)
					_StrokeWidth = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSStrokeWidthAttributeName")!;
				return _StrokeWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Superscript;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSuperscriptAttributeName",  "AppKit")]
		public static NSString Superscript {
			get {
				if (_Superscript is null)
					_Superscript = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSuperscriptAttributeName")!;
				return _Superscript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TargetTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTargetTextScalingDocumentOption'.</summary>
		[Field ("NSTargetTextScalingDocumentOption",  "AppKit")]
		internal static NSString TargetTextScalingDocumentOption {
			get {
				if (_TargetTextScalingDocumentOption is null)
					_TargetTextScalingDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTargetTextScalingDocumentOption")!;
				return _TargetTextScalingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextAlternatives;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextAlternativesAttributeName",  "AppKit")]
		public static NSString TextAlternatives {
			get {
				if (_TextAlternatives is null)
					_TextAlternatives = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextAlternativesAttributeName")!;
				return _TextAlternatives;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextEffect;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextEffectAttributeName",  "AppKit")]
		public static NSString TextEffect {
			get {
				if (_TextEffect is null)
					_TextEffect = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextEffectAttributeName")!;
				return _TextEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextHighlightColorScheme;
		/// <summary>Represents the value associated with the constant 'NSTextHighlightColorSchemeAttributeName'.</summary>
		[Field ("NSTextHighlightColorSchemeAttributeName",  "AppKit")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public static NSString TextHighlightColorScheme {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				if (_TextHighlightColorScheme is null)
					_TextHighlightColorScheme = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextHighlightColorSchemeAttributeName")!;
				return _TextHighlightColorScheme;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextHighlightStyle;
		/// <summary>Represents the value associated with the constant 'NSTextHighlightStyleAttributeName'.</summary>
		[Field ("NSTextHighlightStyleAttributeName",  "AppKit")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public static NSString TextHighlightStyle {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				if (_TextHighlightStyle is null)
					_TextHighlightStyle = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextHighlightStyleAttributeName")!;
				return _TextHighlightStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToolTip;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolTipAttributeName",  "AppKit")]
		public static NSString ToolTip {
			get {
				if (_ToolTip is null)
					_ToolTip = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolTipAttributeName")!;
				return _ToolTip;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Tracking;
		/// <summary>Represents the value associated with the constant 'NSTrackingAttributeName'.</summary>
		[Field ("NSTrackingAttributeName",  "AppKit")]
		public static NSString Tracking {
			get {
				if (_Tracking is null)
					_Tracking = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTrackingAttributeName")!;
				return _Tracking;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSUnderlineColorAttributeName",  "AppKit")]
		public static NSString UnderlineColor {
			get {
				if (_UnderlineColor is null)
					_UnderlineColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSUnderlineColorAttributeName")!;
				return _UnderlineColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineStyle;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSUnderlineStyleAttributeName",  "AppKit")]
		public static NSString UnderlineStyle {
			get {
				if (_UnderlineStyle is null)
					_UnderlineStyle = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSUnderlineStyleAttributeName")!;
				return _UnderlineStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalGlyphForm;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSVerticalGlyphFormAttributeName",  "AppKit")]
		public static NSString VerticalGlyphForm {
			get {
				if (_VerticalGlyphForm is null)
					_VerticalGlyphForm = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSVerticalGlyphFormAttributeName")!;
				return _VerticalGlyphForm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WritingDirection;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWritingDirectionAttributeName",  "AppKit")]
		public static NSString WritingDirection {
			get {
				if (_WritingDirection is null)
					_WritingDirection = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWritingDirectionAttributeName")!;
				return _WritingDirection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WritingToolsExclusion;
		/// <summary>Represents the value associated with the constant 'NSWritingToolsExclusionAttributeName'.</summary>
		[Field ("NSWritingToolsExclusionAttributeName",  "AppKit")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public static NSString WritingToolsExclusion {
			[SupportedOSPlatform ("macos15.2")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				if (_WritingToolsExclusion is null)
					_WritingToolsExclusion = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWritingToolsExclusionAttributeName")!;
				return _WritingToolsExclusion;
			}
		}
	} /* class NSStringAttributeKey */
}
