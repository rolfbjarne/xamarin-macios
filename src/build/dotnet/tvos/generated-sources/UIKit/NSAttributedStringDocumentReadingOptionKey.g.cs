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
	internal unsafe static partial class NSAttributedStringDocumentReadingOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterEncodingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSCharacterEncodingDocumentOption'.</summary>
		[Field ("NSCharacterEncodingDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CharacterEncodingDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CharacterEncodingDocumentOption is null)
					_CharacterEncodingDocumentOption = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSCharacterEncodingDocumentOption")!;
				return _CharacterEncodingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultAttributesDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSDefaultAttributesDocumentOption'.</summary>
		[Field ("NSDefaultAttributesDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DefaultAttributesDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DefaultAttributesDocumentOption is null)
					_DefaultAttributesDocumentOption = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSDefaultAttributesDocumentOption")!;
				return _DefaultAttributesDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentTypeDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSDocumentTypeDocumentOption'.</summary>
		[Field ("NSDocumentTypeDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DocumentTypeDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DocumentTypeDocumentOption is null)
					_DocumentTypeDocumentOption = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSDocumentTypeDocumentOption")!;
				return _DocumentTypeDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentOption'.</summary>
		[Field ("NSSourceTextScalingDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString SourceTextScalingDocumentOption {
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
		static NSString? _TargetTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTargetTextScalingDocumentOption'.</summary>
		[Field ("NSTargetTextScalingDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString TargetTextScalingDocumentOption {
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
		static NSString? _TextKit1ListMarkerFormatDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTextKit1ListMarkerFormatDocumentOption'.</summary>
		[Field ("NSTextKit1ListMarkerFormatDocumentOption",  "UIKit")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString TextKit1ListMarkerFormatDocumentOption {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_TextKit1ListMarkerFormatDocumentOption is null)
					_TextKit1ListMarkerFormatDocumentOption = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextKit1ListMarkerFormatDocumentOption")!;
				return _TextKit1ListMarkerFormatDocumentOption;
			}
		}
	} /* class NSAttributedStringDocumentReadingOptionKey */
}
