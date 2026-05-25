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
	internal unsafe static partial class NSAttributedStringDocumentReadingOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaseUrlDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSBaseURLDocumentOption'.</summary>
		[Field ("NSBaseURLDocumentOption",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BaseUrlDocumentOption {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BaseUrlDocumentOption is null)
					_BaseUrlDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSBaseURLDocumentOption")!;
				return _BaseUrlDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterEncodingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSCharacterEncodingDocumentOption'.</summary>
		[Field ("NSCharacterEncodingDocumentOption",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CharacterEncodingDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CharacterEncodingDocumentOption is null)
					_CharacterEncodingDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCharacterEncodingDocumentOption")!;
				return _CharacterEncodingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultAttributesDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSDefaultAttributesDocumentOption'.</summary>
		[Field ("NSDefaultAttributesDocumentOption",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DefaultAttributesDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DefaultAttributesDocumentOption is null)
					_DefaultAttributesDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDefaultAttributesDocumentOption")!;
				return _DefaultAttributesDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentTypeDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSDocumentTypeDocumentOption'.</summary>
		[Field ("NSDocumentTypeDocumentOption",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DocumentTypeDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DocumentTypeDocumentOption is null)
					_DocumentTypeDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDocumentTypeDocumentOption")!;
				return _DocumentTypeDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReadAccessUrlDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSReadAccessURLDocumentOption'.</summary>
		[Field ("NSReadAccessURLDocumentOption",  "WebKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		public static NSString ReadAccessUrlDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				if (_ReadAccessUrlDocumentOption is null)
					_ReadAccessUrlDocumentOption = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "NSReadAccessURLDocumentOption")!;
				return _ReadAccessUrlDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentOption'.</summary>
		[Field ("NSSourceTextScalingDocumentOption",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString SourceTextScalingDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_SourceTextScalingDocumentOption is null)
					_SourceTextScalingDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSourceTextScalingDocumentOption")!;
				return _SourceTextScalingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TargetTextScalingDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTargetTextScalingDocumentOption'.</summary>
		[Field ("NSTargetTextScalingDocumentOption",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString TargetTextScalingDocumentOption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_TargetTextScalingDocumentOption is null)
					_TargetTextScalingDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTargetTextScalingDocumentOption")!;
				return _TargetTextScalingDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextEncodingNameDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTextEncodingNameDocumentOption'.</summary>
		[Field ("NSTextEncodingNameDocumentOption",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TextEncodingNameDocumentOption {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TextEncodingNameDocumentOption is null)
					_TextEncodingNameDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextEncodingNameDocumentOption")!;
				return _TextEncodingNameDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextKit1ListMarkerFormatDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTextKit1ListMarkerFormatDocumentOption'.</summary>
		[Field ("NSTextKit1ListMarkerFormatDocumentOption",  "AppKit")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public static NSString TextKit1ListMarkerFormatDocumentOption {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				if (_TextKit1ListMarkerFormatDocumentOption is null)
					_TextKit1ListMarkerFormatDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextKit1ListMarkerFormatDocumentOption")!;
				return _TextKit1ListMarkerFormatDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextSizeMultiplierDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTextSizeMultiplierDocumentOption'.</summary>
		[Field ("NSTextSizeMultiplierDocumentOption",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TextSizeMultiplierDocumentOption {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TextSizeMultiplierDocumentOption is null)
					_TextSizeMultiplierDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextSizeMultiplierDocumentOption")!;
				return _TextSizeMultiplierDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeoutDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSTimeoutDocumentOption'.</summary>
		[Field ("NSTimeoutDocumentOption",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TimeoutDocumentOption {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TimeoutDocumentOption is null)
					_TimeoutDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTimeoutDocumentOption")!;
				return _TimeoutDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPreferencesDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSWebPreferencesDocumentOption'.</summary>
		[Field ("NSWebPreferencesDocumentOption",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPreferencesDocumentOption {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPreferencesDocumentOption is null)
					_WebPreferencesDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWebPreferencesDocumentOption")!;
				return _WebPreferencesDocumentOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebResourceLoadDelegateDocumentOption;
		/// <summary>Represents the value associated with the constant 'NSWebResourceLoadDelegateDocumentOption'.</summary>
		[Field ("NSWebResourceLoadDelegateDocumentOption",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebResourceLoadDelegateDocumentOption {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebResourceLoadDelegateDocumentOption is null)
					_WebResourceLoadDelegateDocumentOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWebResourceLoadDelegateDocumentOption")!;
				return _WebResourceLoadDelegateDocumentOption;
			}
		}
	} /* class NSAttributedStringDocumentReadingOptionKey */
}
