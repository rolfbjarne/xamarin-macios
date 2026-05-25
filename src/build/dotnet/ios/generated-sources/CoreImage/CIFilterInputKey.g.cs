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
namespace CoreImage {
	/// <summary>Keys that can be used to configure the CIFilter input values.</summary>
	public unsafe static partial class CIFilterInputKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Amount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Amount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Amount is null)
					_Amount = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputAmountKey")!;
				return _Amount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Angle;
		/// <summary>Represents the value associated with the constant kCIInputAngleKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputAngleKey",  "CoreImage")]
		public static NSString Angle {
			get {
				if (_Angle is null)
					_Angle = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputAngleKey")!;
				return _Angle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AspectRatio;
		/// <summary>Represents the value associated with the constant kCIInputAspectRatioKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputAspectRatioKey",  "CoreImage")]
		public static NSString AspectRatio {
			get {
				if (_AspectRatio is null)
					_AspectRatio = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputAspectRatioKey")!;
				return _AspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundImage;
		/// <summary>Represents the value associated with the constant kCIInputBackgroundImageKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputBackgroundImageKey",  "CoreImage")]
		public static NSString BackgroundImage {
			get {
				if (_BackgroundImage is null)
					_BackgroundImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBackgroundImageKey")!;
				return _BackgroundImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BacksideImage;
		/// <summary>Represents the value associated with the constant 'kCIInputBacksideImageKey'.</summary>
		[Field ("kCIInputBacksideImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString BacksideImage {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_BacksideImage is null)
					_BacksideImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBacksideImageKey")!;
				return _BacksideImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BiasKey;
		/// <summary>Represents the value associated with the constant kCIInputBiasKey.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputBiasKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BiasKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BiasKey is null)
					_BiasKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBiasKey")!;
				return _BiasKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BiasVector;
		/// <summary>Represents the value associated with the constant 'kCIInputBiasVectorKey'.</summary>
		[Field ("kCIInputBiasVectorKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString BiasVector {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_BiasVector is null)
					_BiasVector = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBiasVectorKey")!;
				return _BiasVector;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Brightness;
		/// <summary>Represents the value associated with the constant kCIInputBrightnessKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputBrightnessKey",  "CoreImage")]
		public static NSString Brightness {
			get {
				if (_Brightness is null)
					_Brightness = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBrightnessKey")!;
				return _Brightness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Center;
		/// <summary>Represents the value associated with the constant kCIInputCenterKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputCenterKey",  "CoreImage")]
		public static NSString Center {
			get {
				if (_Center is null)
					_Center = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputCenterKey")!;
				return _Center;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Color;
		/// <summary>Represents the value associated with the constant kCIInputColorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputColorKey",  "CoreImage")]
		public static NSString Color {
			get {
				if (_Color is null)
					_Color = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputColorKey")!;
				return _Color;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Color0;
		/// <summary>Represents the value associated with the constant 'kCIInputColor0Key'.</summary>
		[Field ("kCIInputColor0Key",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Color0 {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Color0 is null)
					_Color0 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputColor0Key")!;
				return _Color0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Color1;
		/// <summary>Represents the value associated with the constant 'kCIInputColor1Key'.</summary>
		[Field ("kCIInputColor1Key",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Color1 {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Color1 is null)
					_Color1 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputColor1Key")!;
				return _Color1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorSpace;
		/// <summary>Represents the value associated with the constant 'kCIInputColorSpaceKey'.</summary>
		[Field ("kCIInputColorSpaceKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString ColorSpace {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_ColorSpace is null)
					_ColorSpace = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputColorSpaceKey")!;
				return _ColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Contrast;
		/// <summary>Represents the value associated with the constant kCIInputContrastKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputContrastKey",  "CoreImage")]
		public static NSString Contrast {
			get {
				if (_Contrast is null)
					_Contrast = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputContrastKey")!;
				return _Contrast;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Count;
		/// <summary>Represents the value associated with the constant 'kCIInputCountKey'.</summary>
		[Field ("kCIInputCountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Count {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Count is null)
					_Count = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputCountKey")!;
				return _Count;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DepthImage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputDepthImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DepthImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DepthImage is null)
					_DepthImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputDepthImageKey")!;
				return _DepthImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisparityImage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputDisparityImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DisparityImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DisparityImage is null)
					_DisparityImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputDisparityImageKey")!;
				return _DisparityImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EV;
		/// <summary>Represents the value associated with the constant kCIInputEVKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputEVKey",  "CoreImage")]
		public static NSString EV {
			get {
				if (_EV is null)
					_EV = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputEVKey")!;
				return _EV;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Extent;
		/// <summary>Represents the value associated with the constant kCIInputExtentKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputExtentKey",  "CoreImage")]
		public static NSString Extent {
			get {
				if (_Extent is null)
					_Extent = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputExtentKey")!;
				return _Extent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Extrapolate;
		/// <summary>Represents the value associated with the constant 'kCIInputExtrapolateKey'.</summary>
		[Field ("kCIInputExtrapolateKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Extrapolate {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Extrapolate is null)
					_Extrapolate = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputExtrapolateKey")!;
				return _Extrapolate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GradientImage;
		/// <summary>Represents the value associated with the constant kCIInputGradientImageKey.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputGradientImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GradientImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GradientImage is null)
					_GradientImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputGradientImageKey")!;
				return _GradientImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Image;
		/// <summary>Represents the value associated with the constant kCIInputImageKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputImageKey",  "CoreImage")]
		public static NSString Image {
			get {
				if (_Image is null)
					_Image = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputImageKey")!;
				return _Image;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Intensity;
		/// <summary>Represents the value associated with the constant kCIInputIntensityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputIntensityKey",  "CoreImage")]
		public static NSString Intensity {
			get {
				if (_Intensity is null)
					_Intensity = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputIntensityKey")!;
				return _Intensity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaskImage;
		/// <summary>Represents the value associated with the constant kCIInputMaskImageKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputMaskImageKey",  "CoreImage")]
		public static NSString MaskImage {
			get {
				if (_MaskImage is null)
					_MaskImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputMaskImageKey")!;
				return _MaskImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatteImage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputMatteImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MatteImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MatteImage is null)
					_MatteImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputMatteImageKey")!;
				return _MatteImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PaletteImage;
		/// <summary>Represents the value associated with the constant 'kCIInputPaletteImageKey'.</summary>
		[Field ("kCIInputPaletteImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString PaletteImage {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_PaletteImage is null)
					_PaletteImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputPaletteImageKey")!;
				return _PaletteImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Perceptual;
		/// <summary>Represents the value associated with the constant 'kCIInputPerceptualKey'.</summary>
		[Field ("kCIInputPerceptualKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Perceptual {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Perceptual is null)
					_Perceptual = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputPerceptualKey")!;
				return _Perceptual;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Point0;
		/// <summary>Represents the value associated with the constant 'kCIInputPoint0Key'.</summary>
		[Field ("kCIInputPoint0Key",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Point0 {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Point0 is null)
					_Point0 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputPoint0Key")!;
				return _Point0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Point1;
		/// <summary>Represents the value associated with the constant 'kCIInputPoint1Key'.</summary>
		[Field ("kCIInputPoint1Key",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Point1 {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Point1 is null)
					_Point1 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputPoint1Key")!;
				return _Point1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Radius;
		/// <summary>Represents the value associated with the constant kCIInputRadiusKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputRadiusKey",  "CoreImage")]
		public static NSString Radius {
			get {
				if (_Radius is null)
					_Radius = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputRadiusKey")!;
				return _Radius;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Radius0;
		/// <summary>Represents the value associated with the constant 'kCIInputRadius0Key'.</summary>
		[Field ("kCIInputRadius0Key",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Radius0 {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Radius0 is null)
					_Radius0 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputRadius0Key")!;
				return _Radius0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Radius1;
		/// <summary>Represents the value associated with the constant 'kCIInputRadius1Key'.</summary>
		[Field ("kCIInputRadius1Key",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Radius1 {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Radius1 is null)
					_Radius1 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputRadius1Key")!;
				return _Radius1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Refraction;
		/// <summary>Represents the value associated with the constant kCIInputRefractionKey.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputRefractionKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Refraction {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Refraction is null)
					_Refraction = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputRefractionKey")!;
				return _Refraction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Saturation;
		/// <summary>Represents the value associated with the constant kCIInputSaturationKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputSaturationKey",  "CoreImage")]
		public static NSString Saturation {
			get {
				if (_Saturation is null)
					_Saturation = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputSaturationKey")!;
				return _Saturation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Scale;
		/// <summary>Represents the value associated with the constant kCIInputScaleKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputScaleKey",  "CoreImage")]
		public static NSString Scale {
			get {
				if (_Scale is null)
					_Scale = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputScaleKey")!;
				return _Scale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadingImage;
		/// <summary>Represents the value associated with the constant kCIInputShadingImageKey.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputShadingImageKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ShadingImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ShadingImage is null)
					_ShadingImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputShadingImageKey")!;
				return _ShadingImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sharpness;
		/// <summary>Represents the value associated with the constant kCIInputSharpnessKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputSharpnessKey",  "CoreImage")]
		public static NSString Sharpness {
			get {
				if (_Sharpness is null)
					_Sharpness = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputSharpnessKey")!;
				return _Sharpness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TargetImage;
		/// <summary>Represents the value associated with the constant kCIInputTargetImageKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputTargetImageKey",  "CoreImage")]
		public static NSString TargetImage {
			get {
				if (_TargetImage is null)
					_TargetImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputTargetImageKey")!;
				return _TargetImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Threshold;
		/// <summary>Represents the value associated with the constant 'kCIInputThresholdKey'.</summary>
		[Field ("kCIInputThresholdKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString Threshold {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_Threshold is null)
					_Threshold = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputThresholdKey")!;
				return _Threshold;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Time;
		/// <summary>Represents the value associated with the constant kCIInputTimeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputTimeKey",  "CoreImage")]
		public static NSString Time {
			get {
				if (_Time is null)
					_Time = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputTimeKey")!;
				return _Time;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Transform;
		/// <summary>Represents the value associated with the constant kCIInputTransformKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputTransformKey",  "CoreImage")]
		public static NSString Transform {
			get {
				if (_Transform is null)
					_Transform = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputTransformKey")!;
				return _Transform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Version;
		/// <summary>Represents the value associated with the constant kCIInputVersionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputVersionKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Version {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Version is null)
					_Version = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputVersionKey")!;
				return _Version;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WeightsKey;
		/// <summary>A key indicating a value that is a weight matrix for a convolution filter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIInputWeightsKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString WeightsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_WeightsKey is null)
					_WeightsKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputWeightsKey")!;
				return _WeightsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Width;
		/// <summary>Represents the value associated with the constant kCIInputWidthKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIInputWidthKey",  "CoreImage")]
		public static NSString Width {
			get {
				if (_Width is null)
					_Width = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputWidthKey")!;
				return _Width;
			}
		}
	} /* class CIFilterInputKey */
}
