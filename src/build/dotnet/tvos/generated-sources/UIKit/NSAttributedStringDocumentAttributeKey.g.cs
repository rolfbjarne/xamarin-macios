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
	internal unsafe static partial class NSAttributedStringDocumentAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColorDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSBackgroundColorDocumentAttribute'.</summary>
		[Field ("NSBackgroundColorDocumentAttribute",  "UIKit")]
		public static NSString BackgroundColorDocumentAttribute {
			get {
				if (_BackgroundColorDocumentAttribute is null)
					_BackgroundColorDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSBackgroundColorDocumentAttribute")!;
				return _BackgroundColorDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterEncodingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSCharacterEncodingDocumentAttribute'.</summary>
		[Field ("NSCharacterEncodingDocumentAttribute",  "UIKit")]
		public static NSString CharacterEncodingDocumentAttribute {
			get {
				if (_CharacterEncodingDocumentAttribute is null)
					_CharacterEncodingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSCharacterEncodingDocumentAttribute")!;
				return _CharacterEncodingDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CocoaVersionDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSCocoaVersionDocumentAttribute'.</summary>
		[Field ("NSCocoaVersionDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString CocoaVersionDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_CocoaVersionDocumentAttribute is null)
					_CocoaVersionDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSCocoaVersionDocumentAttribute")!;
				return _CocoaVersionDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultAttributesDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSDefaultAttributesDocumentAttribute'.</summary>
		[Field ("NSDefaultAttributesDocumentAttribute",  "UIKit")]
		public static NSString DefaultAttributesDocumentAttribute {
			get {
				if (_DefaultAttributesDocumentAttribute is null)
					_DefaultAttributesDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSDefaultAttributesDocumentAttribute")!;
				return _DefaultAttributesDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultFontExcludedDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSDefaultFontExcludedDocumentAttribute'.</summary>
		[Field ("NSDefaultFontExcludedDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString DefaultFontExcludedDocumentAttribute {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_DefaultFontExcludedDocumentAttribute is null)
					_DefaultFontExcludedDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSDefaultFontExcludedDocumentAttribute")!;
				return _DefaultFontExcludedDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultTabIntervalDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSDefaultTabIntervalDocumentAttribute'.</summary>
		[Field ("NSDefaultTabIntervalDocumentAttribute",  "UIKit")]
		public static NSString DefaultTabIntervalDocumentAttribute {
			get {
				if (_DefaultTabIntervalDocumentAttribute is null)
					_DefaultTabIntervalDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSDefaultTabIntervalDocumentAttribute")!;
				return _DefaultTabIntervalDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentTypeDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSDocumentTypeDocumentAttribute'.</summary>
		[Field ("NSDocumentTypeDocumentAttribute",  "UIKit")]
		public static NSString DocumentTypeDocumentAttribute {
			get {
				if (_DocumentTypeDocumentAttribute is null)
					_DocumentTypeDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSDocumentTypeDocumentAttribute")!;
				return _DocumentTypeDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HyphenationFactorDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSHyphenationFactorDocumentAttribute'.</summary>
		[Field ("NSHyphenationFactorDocumentAttribute",  "UIKit")]
		public static NSString HyphenationFactorDocumentAttribute {
			get {
				if (_HyphenationFactorDocumentAttribute is null)
					_HyphenationFactorDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSHyphenationFactorDocumentAttribute")!;
				return _HyphenationFactorDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PaperMarginDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSPaperMarginDocumentAttribute'.</summary>
		[Field ("NSPaperMarginDocumentAttribute",  "UIKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PaperMarginDocumentAttribute {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PaperMarginDocumentAttribute is null)
					_PaperMarginDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSPaperMarginDocumentAttribute")!;
				return _PaperMarginDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PaperSizeDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSPaperSizeDocumentAttribute'.</summary>
		[Field ("NSPaperSizeDocumentAttribute",  "UIKit")]
		public static NSString PaperSizeDocumentAttribute {
			get {
				if (_PaperSizeDocumentAttribute is null)
					_PaperSizeDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSPaperSizeDocumentAttribute")!;
				return _PaperSizeDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReadOnlyDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSReadOnlyDocumentAttribute'.</summary>
		[Field ("NSReadOnlyDocumentAttribute",  "UIKit")]
		public static NSString ReadOnlyDocumentAttribute {
			get {
				if (_ReadOnlyDocumentAttribute is null)
					_ReadOnlyDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSReadOnlyDocumentAttribute")!;
				return _ReadOnlyDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentAttribute'.</summary>
		[Field ("NSSourceTextScalingDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString SourceTextScalingDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_SourceTextScalingDocumentAttribute is null)
					_SourceTextScalingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSSourceTextScalingDocumentAttribute")!;
				return _SourceTextScalingDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionsAttribute;
		/// <summary>Represents the value associated with the constant 'NSTextLayoutSectionsAttribute'.</summary>
		[Field ("NSTextLayoutSectionsAttribute",  "UIKit")]
		public static NSString TextLayoutSectionsAttribute {
			get {
				if (_TextLayoutSectionsAttribute is null)
					_TextLayoutSectionsAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextLayoutSectionsAttribute")!;
				return _TextLayoutSectionsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextScalingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSTextScalingDocumentAttribute'.</summary>
		[Field ("NSTextScalingDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString TextScalingDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_TextScalingDocumentAttribute is null)
					_TextScalingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextScalingDocumentAttribute")!;
				return _TextScalingDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewModeDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSViewModeDocumentAttribute'.</summary>
		[Field ("NSViewModeDocumentAttribute",  "UIKit")]
		public static NSString ViewModeDocumentAttribute {
			get {
				if (_ViewModeDocumentAttribute is null)
					_ViewModeDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSViewModeDocumentAttribute")!;
				return _ViewModeDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewSizeDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSViewSizeDocumentAttribute'.</summary>
		[Field ("NSViewSizeDocumentAttribute",  "UIKit")]
		public static NSString ViewSizeDocumentAttribute {
			get {
				if (_ViewSizeDocumentAttribute is null)
					_ViewSizeDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSViewSizeDocumentAttribute")!;
				return _ViewSizeDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewZoomDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSViewZoomDocumentAttribute'.</summary>
		[Field ("NSViewZoomDocumentAttribute",  "UIKit")]
		public static NSString ViewZoomDocumentAttribute {
			get {
				if (_ViewZoomDocumentAttribute is null)
					_ViewZoomDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSViewZoomDocumentAttribute")!;
				return _ViewZoomDocumentAttribute;
			}
		}
	} /* class NSAttributedStringDocumentAttributeKey */
}
