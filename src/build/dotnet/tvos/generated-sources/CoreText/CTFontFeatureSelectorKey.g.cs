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
namespace CoreText {
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontFeatureSelectors" />.</summary>
	public unsafe static partial class CTFontFeatureSelectorKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Default;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureSelectorDefaultKey",  "CoreText")]
		public static NSString Default {
			get {
				if (_Default is null)
					_Default = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureSelectorDefaultKey")!;
				return _Default;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureSelectorIdentifierKey",  "CoreText")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureSelectorIdentifierKey")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureSelectorNameKey",  "CoreText")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureSelectorNameKey")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SampleText;
		/// <summary>Represents the value associated with the constant 'kCTFontFeatureSampleTextKey'.</summary>
		[Field ("kCTFontFeatureSampleTextKey",  "CoreText")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SampleText {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SampleText is null)
					_SampleText = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureSampleTextKey")!;
				return _SampleText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Setting;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureSelectorSettingKey",  "CoreText")]
		public static NSString Setting {
			get {
				if (_Setting is null)
					_Setting = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureSelectorSettingKey")!;
				return _Setting;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TooltipText;
		/// <summary>Represents the value associated with the constant 'kCTFontFeatureTooltipTextKey'.</summary>
		[Field ("kCTFontFeatureTooltipTextKey",  "CoreText")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TooltipText {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TooltipText is null)
					_TooltipText = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureTooltipTextKey")!;
				return _TooltipText;
			}
		}
	} /* class CTFontFeatureSelectorKey */
}
