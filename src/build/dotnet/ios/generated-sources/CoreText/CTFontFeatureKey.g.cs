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
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontFeatures" />.</summary>
	public unsafe static partial class CTFontFeatureKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Exclusive;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureTypeExclusiveKey",  "CoreText")]
		public static NSString Exclusive {
			get {
				if (_Exclusive is null)
					_Exclusive = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureTypeExclusiveKey")!;
				return _Exclusive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureTypeIdentifierKey",  "CoreText")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureTypeIdentifierKey")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureTypeNameKey",  "CoreText")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureTypeNameKey")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Selectors;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTFontFeatureTypeSelectorsKey",  "CoreText")]
		public static NSString Selectors {
			get {
				if (_Selectors is null)
					_Selectors = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFeatureTypeSelectorsKey")!;
				return _Selectors;
			}
		}
	} /* class CTFontFeatureKey */
}
