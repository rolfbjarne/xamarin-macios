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
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontVariationAxes" />.</summary>
	public unsafe static partial class CTFontVariationAxisKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultValue;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAxisDefaultValueKey",  "CoreText")]
		public static NSString DefaultValue {
			get {
				if (_DefaultValue is null)
					_DefaultValue = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAxisDefaultValueKey")!;
				return _DefaultValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hidden;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAxisHiddenKey",  "CoreText")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Hidden {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Hidden is null)
					_Hidden = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAxisHiddenKey")!;
				return _Hidden;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAxisIdentifierKey",  "CoreText")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAxisIdentifierKey")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumValue;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAxisMaximumValueKey",  "CoreText")]
		public static NSString MaximumValue {
			get {
				if (_MaximumValue is null)
					_MaximumValue = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAxisMaximumValueKey")!;
				return _MaximumValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimumValue;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAxisMinimumValueKey",  "CoreText")]
		public static NSString MinimumValue {
			get {
				if (_MinimumValue is null)
					_MinimumValue = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAxisMinimumValueKey")!;
				return _MinimumValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontVariationAxisNameKey",  "CoreText")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVariationAxisNameKey")!;
				return _Name;
			}
		}
	} /* class CTFontVariationAxisKey */
}
