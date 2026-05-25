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
namespace CoreText {
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTStringAttributes" />.</summary>
	public unsafe partial class CTStringAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdaptiveImageProvider;
		/// <summary>Represents the value associated with the constant 'kCTAdaptiveImageProviderAttributeName'.</summary>
		[Field ("kCTAdaptiveImageProviderAttributeName",  "CoreText")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString AdaptiveImageProvider {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_AdaptiveImageProvider is null)
					_AdaptiveImageProvider = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTAdaptiveImageProviderAttributeName")!;
				return _AdaptiveImageProvider;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColor;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTBackgroundColorAttributeName",  "CoreText")]
		public static NSString BackgroundColor {
			get {
				if (_BackgroundColor is null)
					_BackgroundColor = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBackgroundColorAttributeName")!;
				return _BackgroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineClass;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassAttributeName'.</summary>
		[Field ("kCTBaselineClassAttributeName",  "CoreText")]
		public static NSString BaselineClass {
			get {
				if (_BaselineClass is null)
					_BaselineClass = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassAttributeName")!;
				return _BaselineClass;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineInfo;
		/// <summary>Represents the value associated with the constant 'kCTBaselineInfoAttributeName'.</summary>
		[Field ("kCTBaselineInfoAttributeName",  "CoreText")]
		public static NSString BaselineInfo {
			get {
				if (_BaselineInfo is null)
					_BaselineInfo = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineInfoAttributeName")!;
				return _BaselineInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineOffset;
		/// <summary>Represents the value associated with the constant 'kCTBaselineOffsetAttributeName'.</summary>
		[Field ("kCTBaselineOffsetAttributeName",  "CoreText")]
		public static NSString BaselineOffset {
			get {
				if (_BaselineOffset is null)
					_BaselineOffset = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineOffsetAttributeName")!;
				return _BaselineOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineReferenceInfo;
		/// <summary>Represents the value associated with the constant 'kCTBaselineReferenceInfoAttributeName'.</summary>
		[Field ("kCTBaselineReferenceInfoAttributeName",  "CoreText")]
		public static NSString BaselineReferenceInfo {
			get {
				if (_BaselineReferenceInfo is null)
					_BaselineReferenceInfo = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineReferenceInfoAttributeName")!;
				return _BaselineReferenceInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterShape;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTCharacterShapeAttributeName",  "CoreText")]
		public static NSString CharacterShape {
			get {
				if (_CharacterShape is null)
					_CharacterShape = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTCharacterShapeAttributeName")!;
				return _CharacterShape;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Font;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontAttributeName",  "CoreText")]
		public static NSString Font {
			get {
				if (_Font is null)
					_Font = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontAttributeName")!;
				return _Font;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForegroundColor;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTForegroundColorAttributeName",  "CoreText")]
		public static NSString ForegroundColor {
			get {
				if (_ForegroundColor is null)
					_ForegroundColor = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTForegroundColorAttributeName")!;
				return _ForegroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForegroundColorFromContext;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTForegroundColorFromContextAttributeName",  "CoreText")]
		public static NSString ForegroundColorFromContext {
			get {
				if (_ForegroundColorFromContext is null)
					_ForegroundColorFromContext = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTForegroundColorFromContextAttributeName")!;
				return _ForegroundColorFromContext;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GlyphInfo;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTGlyphInfoAttributeName",  "CoreText")]
		public static NSString GlyphInfo {
			get {
				if (_GlyphInfo is null)
					_GlyphInfo = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTGlyphInfoAttributeName")!;
				return _GlyphInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalInVerticalForms;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTHorizontalInVerticalFormsAttributeName",  "CoreText")]
		public static NSString HorizontalInVerticalForms {
			get {
				if (_HorizontalInVerticalForms is null)
					_HorizontalInVerticalForms = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTHorizontalInVerticalFormsAttributeName")!;
				return _HorizontalInVerticalForms;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KerningAdjustment;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTKernAttributeName",  "CoreText")]
		public static NSString KerningAdjustment {
			get {
				if (_KerningAdjustment is null)
					_KerningAdjustment = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTKernAttributeName")!;
				return _KerningAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LigatureFormation;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTLigatureAttributeName",  "CoreText")]
		public static NSString LigatureFormation {
			get {
				if (_LigatureFormation is null)
					_LigatureFormation = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTLigatureAttributeName")!;
				return _LigatureFormation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParagraphStyle;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTParagraphStyleAttributeName",  "CoreText")]
		public static NSString ParagraphStyle {
			get {
				if (_ParagraphStyle is null)
					_ParagraphStyle = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTParagraphStyleAttributeName")!;
				return _ParagraphStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RubyAnnotation;
		/// <summary>Represents the value associated with the constant 'kCTRubyAnnotationAttributeName'.</summary>
		[Field ("kCTRubyAnnotationAttributeName",  "CoreText")]
		public static NSString RubyAnnotation {
			get {
				if (_RubyAnnotation is null)
					_RubyAnnotation = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTRubyAnnotationAttributeName")!;
				return _RubyAnnotation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RunDelegate;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTRunDelegateAttributeName",  "CoreText")]
		public static NSString RunDelegate {
			get {
				if (_RunDelegate is null)
					_RunDelegate = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTRunDelegateAttributeName")!;
				return _RunDelegate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrokeColor;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTStrokeColorAttributeName",  "CoreText")]
		public static NSString StrokeColor {
			get {
				if (_StrokeColor is null)
					_StrokeColor = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTStrokeColorAttributeName")!;
				return _StrokeColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrokeWidth;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTStrokeWidthAttributeName",  "CoreText")]
		public static NSString StrokeWidth {
			get {
				if (_StrokeWidth is null)
					_StrokeWidth = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTStrokeWidthAttributeName")!;
				return _StrokeWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Superscript;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTSuperscriptAttributeName",  "CoreText")]
		public static NSString Superscript {
			get {
				if (_Superscript is null)
					_Superscript = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTSuperscriptAttributeName")!;
				return _Superscript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TrackingAttributeName;
		/// <summary>Represents the value associated with the constant 'kCTTrackingAttributeName'.</summary>
		[Field ("kCTTrackingAttributeName",  "CoreText")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TrackingAttributeName {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TrackingAttributeName is null)
					_TrackingAttributeName = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTTrackingAttributeName")!;
				return _TrackingAttributeName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineColor;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTUnderlineColorAttributeName",  "CoreText")]
		public static NSString UnderlineColor {
			get {
				if (_UnderlineColor is null)
					_UnderlineColor = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTUnderlineColorAttributeName")!;
				return _UnderlineColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineStyle;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTUnderlineStyleAttributeName",  "CoreText")]
		public static NSString UnderlineStyle {
			get {
				if (_UnderlineStyle is null)
					_UnderlineStyle = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTUnderlineStyleAttributeName")!;
				return _UnderlineStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalForms;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTVerticalFormsAttributeName",  "CoreText")]
		public static NSString VerticalForms {
			get {
				if (_VerticalForms is null)
					_VerticalForms = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTVerticalFormsAttributeName")!;
				return _VerticalForms;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WritingDirection;
		/// <summary>Represents the value associated with the constant 'kCTWritingDirectionAttributeName'.</summary>
		[Field ("kCTWritingDirectionAttributeName",  "CoreText")]
		public static NSString WritingDirection {
			get {
				if (_WritingDirection is null)
					_WritingDirection = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTWritingDirectionAttributeName")!;
				return _WritingDirection;
			}
		}
	} /* class CTStringAttributeKey */
}
