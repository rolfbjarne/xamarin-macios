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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>Represents the key to be used in the <see cref="T:Foundation.NSMutableDictionary" /> that define the attributes of a <see cref="T:Foundation.NSAttributedString" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class UIStringAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdaptiveImageGlyph;
		/// <summary>Represents the value associated with the constant 'NSAdaptiveImageGlyphAttributeName'.</summary>
		[Field ("NSAdaptiveImageGlyphAttributeName",  "UIKit")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString AdaptiveImageGlyph {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_AdaptiveImageGlyph is null)
					_AdaptiveImageGlyph = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSAdaptiveImageGlyphAttributeName")!;
				return _AdaptiveImageGlyph;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Attachment;
		/// <summary>Represents the value associated with the constant NSAttachmentAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSAttachmentAttributeName",  "UIKit")]
		public static NSString Attachment {
			get {
				if (_Attachment is null)
					_Attachment = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSAttachmentAttributeName")!;
				return _Attachment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColor;
		/// <summary>Represents the value associated with the constant NSBackgroundColorAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSBackgroundColorAttributeName",  "UIKit")]
		public static NSString BackgroundColor {
			get {
				if (_BackgroundColor is null)
					_BackgroundColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSBackgroundColorAttributeName")!;
				return _BackgroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineOffset;
		/// <summary>Represents the value associated with the constant NSBaselineOffsetAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSBaselineOffsetAttributeName",  "UIKit")]
		public static NSString BaselineOffset {
			get {
				if (_BaselineOffset is null)
					_BaselineOffset = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSBaselineOffsetAttributeName")!;
				return _BaselineOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Expansion;
		/// <summary>Represents the value associated with the constant NSExpansionAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSExpansionAttributeName",  "UIKit")]
		public static NSString Expansion {
			get {
				if (_Expansion is null)
					_Expansion = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSExpansionAttributeName")!;
				return _Expansion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Font;
		/// <summary>Represents the value associated with the constant NSFontAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFontAttributeName",  "UIKit")]
		public static NSString Font {
			get {
				if (_Font is null)
					_Font = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSFontAttributeName")!;
				return _Font;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForegroundColor;
		/// <summary>Represents the value associated with the constant NSForegroundColorAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSForegroundColorAttributeName",  "UIKit")]
		public static NSString ForegroundColor {
			get {
				if (_ForegroundColor is null)
					_ForegroundColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSForegroundColorAttributeName")!;
				return _ForegroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KerningAdjustment;
		/// <summary>Represents the value associated with the constant NSKernAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSKernAttributeName",  "UIKit")]
		public static NSString KerningAdjustment {
			get {
				if (_KerningAdjustment is null)
					_KerningAdjustment = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSKernAttributeName")!;
				return _KerningAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ligature;
		/// <summary>Represents the value associated with the constant NSLigatureAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSLigatureAttributeName",  "UIKit")]
		public static NSString Ligature {
			get {
				if (_Ligature is null)
					_Ligature = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSLigatureAttributeName")!;
				return _Ligature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Link;
		/// <summary>Represents the value associated with the constant NSLinkAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSLinkAttributeName",  "UIKit")]
		public static NSString Link {
			get {
				if (_Link is null)
					_Link = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSLinkAttributeName")!;
				return _Link;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSTextEffectLetterpressStyle;
		/// <summary>Represents the value associated with the constant 'NSTextEffectLetterpressStyle'.</summary>
		[Field ("NSTextEffectLetterpressStyle",  "UIKit")]
		internal static NSString NSTextEffectLetterpressStyle {
			get {
				if (_NSTextEffectLetterpressStyle is null)
					_NSTextEffectLetterpressStyle = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextEffectLetterpressStyle")!;
				return _NSTextEffectLetterpressStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Obliqueness;
		/// <summary>Represents the value associated with the constant NSObliquenessAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSObliquenessAttributeName",  "UIKit")]
		public static NSString Obliqueness {
			get {
				if (_Obliqueness is null)
					_Obliqueness = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSObliquenessAttributeName")!;
				return _Obliqueness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParagraphStyle;
		/// <summary>Represents the value associated with the constant NSParagraphStyleAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSParagraphStyleAttributeName",  "UIKit")]
		public static NSString ParagraphStyle {
			get {
				if (_ParagraphStyle is null)
					_ParagraphStyle = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSParagraphStyleAttributeName")!;
				return _ParagraphStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Shadow;
		/// <summary>Represents the value associated with the constant NSShadowAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSShadowAttributeName",  "UIKit")]
		public static NSString Shadow {
			get {
				if (_Shadow is null)
					_Shadow = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSShadowAttributeName")!;
				return _Shadow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentOption'.</summary>
		[Field ("NSSourceTextScalingDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString SourceTextScalingDocumentOption {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_SourceTextScalingDocumentOption is null)
					_SourceTextScalingDocumentOption = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSSourceTextScalingDocumentOption")!;
				return _SourceTextScalingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrikethroughColor;
		/// <summary>Represents the value associated with the constant NSStrikethroughColorAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStrikethroughColorAttributeName",  "UIKit")]
		public static NSString StrikethroughColor {
			get {
				if (_StrikethroughColor is null)
					_StrikethroughColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSStrikethroughColorAttributeName")!;
				return _StrikethroughColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrikethroughStyle;
		/// <summary>Represents the value associated with the constant NSStrikethroughStyleAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStrikethroughStyleAttributeName",  "UIKit")]
		public static NSString StrikethroughStyle {
			get {
				if (_StrikethroughStyle is null)
					_StrikethroughStyle = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSStrikethroughStyleAttributeName")!;
				return _StrikethroughStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrokeColor;
		/// <summary>Represents the value associated with the constant NSStrokeColorAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStrokeColorAttributeName",  "UIKit")]
		public static NSString StrokeColor {
			get {
				if (_StrokeColor is null)
					_StrokeColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSStrokeColorAttributeName")!;
				return _StrokeColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrokeWidth;
		/// <summary>Represents the value associated with the constant NSStrokeWidthAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStrokeWidthAttributeName",  "UIKit")]
		public static NSString StrokeWidth {
			get {
				if (_StrokeWidth is null)
					_StrokeWidth = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSStrokeWidthAttributeName")!;
				return _StrokeWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TargetTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTargetTextScalingDocumentOption'.</summary>
		[Field ("NSTargetTextScalingDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString TargetTextScalingDocumentOption {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_TargetTextScalingDocumentOption is null)
					_TargetTextScalingDocumentOption = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTargetTextScalingDocumentOption")!;
				return _TargetTextScalingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextEffect;
		/// <summary>Represents the value associated with the constant NSTextEffectAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSTextEffectAttributeName",  "UIKit")]
		public static NSString TextEffect {
			get {
				if (_TextEffect is null)
					_TextEffect = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextEffectAttributeName")!;
				return _TextEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextHighlightColorScheme;
		/// <summary>Represents the value associated with the constant 'NSTextHighlightColorSchemeAttributeName'.</summary>
		[Field ("NSTextHighlightColorSchemeAttributeName",  "UIKit")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString TextHighlightColorScheme {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_TextHighlightColorScheme is null)
					_TextHighlightColorScheme = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextHighlightColorSchemeAttributeName")!;
				return _TextHighlightColorScheme;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextHighlightStyle;
		/// <summary>Represents the value associated with the constant 'NSTextHighlightStyleAttributeName'.</summary>
		[Field ("NSTextHighlightStyleAttributeName",  "UIKit")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString TextHighlightStyle {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_TextHighlightStyle is null)
					_TextHighlightStyle = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextHighlightStyleAttributeName")!;
				return _TextHighlightStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Tracking;
		/// <summary>Represents the value associated with the constant 'NSTrackingAttributeName'.</summary>
		[Field ("NSTrackingAttributeName",  "UIKit")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString Tracking {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_Tracking is null)
					_Tracking = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTrackingAttributeName")!;
				return _Tracking;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineColor;
		/// <summary>Represents the value associated with the constant NSUnderlineColorAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSUnderlineColorAttributeName",  "UIKit")]
		public static NSString UnderlineColor {
			get {
				if (_UnderlineColor is null)
					_UnderlineColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSUnderlineColorAttributeName")!;
				return _UnderlineColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineStyle;
		/// <summary>Represents the value associated with the constant NSUnderlineStyleAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSUnderlineStyleAttributeName",  "UIKit")]
		public static NSString UnderlineStyle {
			get {
				if (_UnderlineStyle is null)
					_UnderlineStyle = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSUnderlineStyleAttributeName")!;
				return _UnderlineStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalGlyphForm;
		/// <summary>Represents the value associated with the constant NSVerticalGlyphFormAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSVerticalGlyphFormAttributeName",  "UIKit")]
		public static NSString VerticalGlyphForm {
			get {
				if (_VerticalGlyphForm is null)
					_VerticalGlyphForm = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSVerticalGlyphFormAttributeName")!;
				return _VerticalGlyphForm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WritingDirection;
		/// <summary>Represents the value associated with the constant NSWritingDirectionAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSWritingDirectionAttributeName",  "UIKit")]
		public static NSString WritingDirection {
			get {
				if (_WritingDirection is null)
					_WritingDirection = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSWritingDirectionAttributeName")!;
				return _WritingDirection;
			}
		}
	} /* class UIStringAttributeKey */
}
