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
	internal unsafe partial class CTBaselineClassID  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hanging;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassHanging'.</summary>
		[Field ("kCTBaselineClassHanging",  "CoreText")]
		public static NSString Hanging {
			get {
				if (_Hanging is null)
					_Hanging = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassHanging")!;
				return _Hanging;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IdeographicCentered;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassIdeographicCentered'.</summary>
		[Field ("kCTBaselineClassIdeographicCentered",  "CoreText")]
		public static NSString IdeographicCentered {
			get {
				if (_IdeographicCentered is null)
					_IdeographicCentered = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassIdeographicCentered")!;
				return _IdeographicCentered;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IdeographicHigh;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassIdeographicHigh'.</summary>
		[Field ("kCTBaselineClassIdeographicHigh",  "CoreText")]
		public static NSString IdeographicHigh {
			get {
				if (_IdeographicHigh is null)
					_IdeographicHigh = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassIdeographicHigh")!;
				return _IdeographicHigh;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IdeographicLow;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassIdeographicLow'.</summary>
		[Field ("kCTBaselineClassIdeographicLow",  "CoreText")]
		public static NSString IdeographicLow {
			get {
				if (_IdeographicLow is null)
					_IdeographicLow = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassIdeographicLow")!;
				return _IdeographicLow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Math;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassMath'.</summary>
		[Field ("kCTBaselineClassMath",  "CoreText")]
		public static NSString Math {
			get {
				if (_Math is null)
					_Math = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassMath")!;
				return _Math;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Roman;
		/// <summary>Represents the value associated with the constant 'kCTBaselineClassRoman'.</summary>
		[Field ("kCTBaselineClassRoman",  "CoreText")]
		public static NSString Roman {
			get {
				if (_Roman is null)
					_Roman = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineClassRoman")!;
				return _Roman;
			}
		}
	} /* class CTBaselineClassID */
}
