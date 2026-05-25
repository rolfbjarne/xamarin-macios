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
namespace CoreText {
	/// <summary>A valid key for use with <see cref="T:CoreText.CTFontDescriptor" /> attribute properties.</summary>
	public unsafe static partial class CTFontDescriptorAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineAdjust;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontBaselineAdjustAttribute",  "CoreText")]
		public static NSString BaselineAdjust {
			get {
				if (_BaselineAdjust is null)
					_BaselineAdjust = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontBaselineAdjustAttribute")!;
				return _BaselineAdjust;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CascadeList;
		/// <summary>Augment the list of cascading fonts to try out when a font is needed.</summary><remarks><para>
		/// 	    Since fonts do not cover the entire Unicode space, you can
		/// 	    provide a list of fallback fonts that will be tried for
		/// 	    glyphs that are not available for a certain codepoint in
		/// 	    the main selected font.
		/// 
		/// 	  </para><para>
		/// 	    By default the system has a built-in cascade list that the
		/// 	    system uses to satisfy the font.  By setting this property
		/// 	    is to set a list that is consulted before the system
		/// 	    cascade list is looked up.
		/// 
		/// 	  </para><para>
		/// 	    If you want to prevent the system cascade list from being
		/// 	    consulted, you can use the special font name "LastResort",
		/// 	    this is a special font that contains glyphs for every
		/// 	    unicode code point.  You can learn more about it at the
		/// 	    Unicode web site:
		/// 	    https://unicode.org/policies/lastresortfont_eula.html
		/// 
		/// 	  </para></remarks>
		[Field ("kCTFontCascadeListAttribute",  "CoreText")]
		public static NSString CascadeList {
			get {
				if (_CascadeList is null)
					_CascadeList = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontCascadeListAttribute")!;
				return _CascadeList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterSet;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontCharacterSetAttribute",  "CoreText")]
		public static NSString CharacterSet {
			get {
				if (_CharacterSet is null)
					_CharacterSet = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontCharacterSetAttribute")!;
				return _CharacterSet;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayName;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontDisplayNameAttribute",  "CoreText")]
		public static NSString DisplayName {
			get {
				if (_DisplayName is null)
					_DisplayName = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontDisplayNameAttribute")!;
				return _DisplayName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Enabled;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontEnabledAttribute",  "CoreText")]
		public static NSString Enabled {
			get {
				if (_Enabled is null)
					_Enabled = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontEnabledAttribute")!;
				return _Enabled;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyName;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontFamilyNameAttribute",  "CoreText")]
		public static NSString FamilyName {
			get {
				if (_FamilyName is null)
					_FamilyName = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFamilyNameAttribute")!;
				return _FamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FeatureSettings;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureSettingsAttribute",  "CoreText")]
		public static NSString FeatureSettings {
			get {
				if (_FeatureSettings is null)
					_FeatureSettings = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureSettingsAttribute")!;
				return _FeatureSettings;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Features;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontFeaturesAttribute",  "CoreText")]
		public static NSString Features {
			get {
				if (_Features is null)
					_Features = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeaturesAttribute")!;
				return _Features;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FixedAdvance;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontFixedAdvanceAttribute",  "CoreText")]
		public static NSString FixedAdvance {
			get {
				if (_FixedAdvance is null)
					_FixedAdvance = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFixedAdvanceAttribute")!;
				return _FixedAdvance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontFormat;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontFormatAttribute",  "CoreText")]
		public static NSString FontFormat {
			get {
				if (_FontFormat is null)
					_FontFormat = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFormatAttribute")!;
				return _FontFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontOrientation;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontOrientationAttribute",  "CoreText")]
		public static NSString FontOrientation {
			get {
				if (_FontOrientation is null)
					_FontOrientation = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontOrientationAttribute")!;
				return _FontOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Language;
		/// <summary>Represents the value associated with the constant 'kCTFontDescriptorLanguageAttribute'.</summary>
		[Field ("kCTFontDescriptorLanguageAttribute",  "CoreText")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public static NSString Language {
			[SupportedOSPlatform ("ios26.4")]
			[SupportedOSPlatform ("tvos26.4")]
			[SupportedOSPlatform ("macos26.4")]
			[SupportedOSPlatform ("maccatalyst26.4")]
			get {
				if (_Language is null)
					_Language = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontDescriptorLanguageAttribute")!;
				return _Language;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Languages;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontLanguagesAttribute",  "CoreText")]
		public static NSString Languages {
			get {
				if (_Languages is null)
					_Languages = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontLanguagesAttribute")!;
				return _Languages;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MacintoshEncodings;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontMacintoshEncodingsAttribute",  "CoreText")]
		public static NSString MacintoshEncodings {
			get {
				if (_MacintoshEncodings is null)
					_MacintoshEncodings = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontMacintoshEncodingsAttribute")!;
				return _MacintoshEncodings;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Matrix;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontMatrixAttribute",  "CoreText")]
		public static NSString Matrix {
			get {
				if (_Matrix is null)
					_Matrix = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontMatrixAttribute")!;
				return _Matrix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontNameAttribute",  "CoreText")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontNameAttribute")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Priority;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontPriorityAttribute",  "CoreText")]
		public static NSString Priority {
			get {
				if (_Priority is null)
					_Priority = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontPriorityAttribute")!;
				return _Priority;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RegistrationScope;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontRegistrationScopeAttribute",  "CoreText")]
		public static NSString RegistrationScope {
			get {
				if (_RegistrationScope is null)
					_RegistrationScope = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontRegistrationScopeAttribute")!;
				return _RegistrationScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RegistrationUserInfo;
		/// <summary>Represents the value associated with the constant 'kCTFontRegistrationUserInfoAttribute'.</summary>
		[Field ("kCTFontRegistrationUserInfoAttribute",  "CoreText")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString RegistrationUserInfo {
			[SupportedOSPlatform ("ios13.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_RegistrationUserInfo is null)
					_RegistrationUserInfo = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontRegistrationUserInfoAttribute")!;
				return _RegistrationUserInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Size;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontSizeAttribute",  "CoreText")]
		public static NSString Size {
			get {
				if (_Size is null)
					_Size = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontSizeAttribute")!;
				return _Size;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StyleName;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontStyleNameAttribute",  "CoreText")]
		public static NSString StyleName {
			get {
				if (_StyleName is null)
					_StyleName = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontStyleNameAttribute")!;
				return _StyleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Traits;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontTraitsAttribute",  "CoreText")]
		public static NSString Traits {
			get {
				if (_Traits is null)
					_Traits = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontTraitsAttribute")!;
				return _Traits;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Url;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontURLAttribute",  "CoreText")]
		public static NSString Url {
			get {
				if (_Url is null)
					_Url = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontURLAttribute")!;
				return _Url;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Variation;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAttribute",  "CoreText")]
		public static NSString Variation {
			get {
				if (_Variation is null)
					_Variation = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAttribute")!;
				return _Variation;
			}
		}
	} /* class CTFontDescriptorAttributeKey */
}
