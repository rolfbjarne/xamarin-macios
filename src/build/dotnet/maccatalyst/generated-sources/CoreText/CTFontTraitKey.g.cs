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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreText {
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontTraits" />.</summary>
	public unsafe static partial class CTFontTraitKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Slant;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontSlantTrait",  "CoreText")]
		public static NSString Slant {
			get {
				if (_Slant is null)
					_Slant = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontSlantTrait")!;
				return _Slant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Symbolic;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontSymbolicTrait",  "CoreText")]
		public static NSString Symbolic {
			get {
				if (_Symbolic is null)
					_Symbolic = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontSymbolicTrait")!;
				return _Symbolic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Weight;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontWeightTrait",  "CoreText")]
		public static NSString Weight {
			get {
				if (_Weight is null)
					_Weight = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontWeightTrait")!;
				return _Weight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Width;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontWidthTrait",  "CoreText")]
		public static NSString Width {
			get {
				if (_Width is null)
					_Width = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontWidthTrait")!;
				return _Width;
			}
		}
	} /* class CTFontTraitKey */
}
