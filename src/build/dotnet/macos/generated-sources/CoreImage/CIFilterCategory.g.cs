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
namespace CoreImage {
	/// <summary>Constants used for CIFilter filtering facilities to find filters by category.</summary>
	public unsafe static partial class CIFilterCategory  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Blur;
		/// <summary>Represents the value associated with the constant kCICategoryBlur</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryBlur",  "Quartz")]
		public static NSString Blur {
			get {
				if (_Blur is null)
					_Blur = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryBlur")!;
				return _Blur;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BuiltIn;
		/// <summary>Represents the value associated with the constant kCICategoryBuiltIn</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryBuiltIn",  "Quartz")]
		public static NSString BuiltIn {
			get {
				if (_BuiltIn is null)
					_BuiltIn = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryBuiltIn")!;
				return _BuiltIn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorAdjustment;
		/// <summary>Represents the value associated with the constant kCICategoryColorAdjustment</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryColorAdjustment",  "Quartz")]
		public static NSString ColorAdjustment {
			get {
				if (_ColorAdjustment is null)
					_ColorAdjustment = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryColorAdjustment")!;
				return _ColorAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorEffect;
		/// <summary>Represents the value associated with the constant kCICategoryColorEffect</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryColorEffect",  "Quartz")]
		public static NSString ColorEffect {
			get {
				if (_ColorEffect is null)
					_ColorEffect = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryColorEffect")!;
				return _ColorEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompositeOperation;
		/// <summary>Represents the value associated with the constant kCICategoryCompositeOperation</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryCompositeOperation",  "Quartz")]
		public static NSString CompositeOperation {
			get {
				if (_CompositeOperation is null)
					_CompositeOperation = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryCompositeOperation")!;
				return _CompositeOperation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DistortionEffect;
		/// <summary>Represents the value associated with the constant kCICategoryDistortionEffect</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryDistortionEffect",  "Quartz")]
		public static NSString DistortionEffect {
			get {
				if (_DistortionEffect is null)
					_DistortionEffect = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryDistortionEffect")!;
				return _DistortionEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterGenerator;
		/// <summary>Represents the value associated with the constant kCICategoryFilterGenerator</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCICategoryFilterGenerator",  "Quartz")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FilterGenerator {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FilterGenerator is null)
					_FilterGenerator = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryFilterGenerator")!;
				return _FilterGenerator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Generator;
		/// <summary>Represents the value associated with the constant kCICategoryGenerator</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryGenerator",  "Quartz")]
		public static NSString Generator {
			get {
				if (_Generator is null)
					_Generator = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryGenerator")!;
				return _Generator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GeometryAdjustment;
		/// <summary>Represents the value associated with the constant kCICategoryGeometryAdjustment</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryGeometryAdjustment",  "Quartz")]
		public static NSString GeometryAdjustment {
			get {
				if (_GeometryAdjustment is null)
					_GeometryAdjustment = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryGeometryAdjustment")!;
				return _GeometryAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Gradient;
		/// <summary>Represents the value associated with the constant kCICategoryGradient</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryGradient",  "Quartz")]
		public static NSString Gradient {
			get {
				if (_Gradient is null)
					_Gradient = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryGradient")!;
				return _Gradient;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HalftoneEffect;
		/// <summary>Represents the value associated with the constant kCICategoryHalftoneEffect</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryHalftoneEffect",  "Quartz")]
		public static NSString HalftoneEffect {
			get {
				if (_HalftoneEffect is null)
					_HalftoneEffect = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryHalftoneEffect")!;
				return _HalftoneEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HighDynamicRange;
		/// <summary>Represents the value associated with the constant kCICategoryHighDynamicRange</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryHighDynamicRange",  "Quartz")]
		public static NSString HighDynamicRange {
			get {
				if (_HighDynamicRange is null)
					_HighDynamicRange = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryHighDynamicRange")!;
				return _HighDynamicRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Interlaced;
		/// <summary>Represents the value associated with the constant kCICategoryInterlaced</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryInterlaced",  "Quartz")]
		public static NSString Interlaced {
			get {
				if (_Interlaced is null)
					_Interlaced = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryInterlaced")!;
				return _Interlaced;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NonSquarePixels;
		/// <summary>Represents the value associated with the constant kCICategoryNonSquarePixels</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryNonSquarePixels",  "Quartz")]
		public static NSString NonSquarePixels {
			get {
				if (_NonSquarePixels is null)
					_NonSquarePixels = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryNonSquarePixels")!;
				return _NonSquarePixels;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Reduction;
		/// <summary>Represents the value associated with the constant kCICategoryReduction</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryReduction",  "Quartz")]
		public static NSString Reduction {
			get {
				if (_Reduction is null)
					_Reduction = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryReduction")!;
				return _Reduction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sharpen;
		/// <summary>Represents the value associated with the constant kCICategorySharpen</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategorySharpen",  "Quartz")]
		public static NSString Sharpen {
			get {
				if (_Sharpen is null)
					_Sharpen = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategorySharpen")!;
				return _Sharpen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StillImage;
		/// <summary>Represents the value associated with the constant kCICategoryStillImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryStillImage",  "Quartz")]
		public static NSString StillImage {
			get {
				if (_StillImage is null)
					_StillImage = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryStillImage")!;
				return _StillImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stylize;
		/// <summary>Represents the value associated with the constant kCICategoryStylize</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryStylize",  "Quartz")]
		public static NSString Stylize {
			get {
				if (_Stylize is null)
					_Stylize = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryStylize")!;
				return _Stylize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TileEffect;
		/// <summary>Represents the value associated with the constant kCICategoryTileEffect</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryTileEffect",  "Quartz")]
		public static NSString TileEffect {
			get {
				if (_TileEffect is null)
					_TileEffect = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryTileEffect")!;
				return _TileEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Transition;
		/// <summary>Represents the value associated with the constant kCICategoryTransition</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryTransition",  "Quartz")]
		public static NSString Transition {
			get {
				if (_Transition is null)
					_Transition = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryTransition")!;
				return _Transition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Video;
		/// <summary>Represents the value associated with the constant kCICategoryVideo</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCICategoryVideo",  "Quartz")]
		public static NSString Video {
			get {
				if (_Video is null)
					_Video = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCICategoryVideo")!;
				return _Video;
			}
		}
	} /* class CIFilterCategory */
}
