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
namespace CoreMedia {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe static partial class CMCompressionPropertyCameraCalibrationKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConvertedFromExternalSphericalTags;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ConvertedFromExternalSphericalTags'.</summary>
		[Field ("kCMFormatDescriptionExtension_ConvertedFromExternalSphericalTags",  "CoreMedia")]
		public static NSString ConvertedFromExternalSphericalTags {
			get {
				if (_ConvertedFromExternalSphericalTags is null)
					_ConvertedFromExternalSphericalTags = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ConvertedFromExternalSphericalTags")!;
				return _ConvertedFromExternalSphericalTags;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtrinsicOrientationQuaternion;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_ExtrinsicOrientationQuaternion'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_ExtrinsicOrientationQuaternion",  "CoreMedia")]
		public static NSString ExtrinsicOrientationQuaternion {
			get {
				if (_ExtrinsicOrientationQuaternion is null)
					_ExtrinsicOrientationQuaternion = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_ExtrinsicOrientationQuaternion")!;
				return _ExtrinsicOrientationQuaternion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtrinsicOriginSource;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_ExtrinsicOriginSource'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_ExtrinsicOriginSource",  "CoreMedia")]
		public static NSString ExtrinsicOriginSource {
			get {
				if (_ExtrinsicOriginSource is null)
					_ExtrinsicOriginSource = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_ExtrinsicOriginSource")!;
				return _ExtrinsicOriginSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IntrinsicMatrix;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_IntrinsicMatrix'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_IntrinsicMatrix",  "CoreMedia")]
		public static NSString IntrinsicMatrix {
			get {
				if (_IntrinsicMatrix is null)
					_IntrinsicMatrix = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_IntrinsicMatrix")!;
				return _IntrinsicMatrix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IntrinsicMatrixProjectionOffset;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_IntrinsicMatrixProjectionOffset'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_IntrinsicMatrixProjectionOffset",  "CoreMedia")]
		public static NSString IntrinsicMatrixProjectionOffset {
			get {
				if (_IntrinsicMatrixProjectionOffset is null)
					_IntrinsicMatrixProjectionOffset = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_IntrinsicMatrixProjectionOffset")!;
				return _IntrinsicMatrixProjectionOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IntrinsicMatrixReferenceDimensions;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_IntrinsicMatrixReferenceDimensions'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_IntrinsicMatrixReferenceDimensions",  "CoreMedia")]
		public static NSString IntrinsicMatrixReferenceDimensions {
			get {
				if (_IntrinsicMatrixReferenceDimensions is null)
					_IntrinsicMatrixReferenceDimensions = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_IntrinsicMatrixReferenceDimensions")!;
				return _IntrinsicMatrixReferenceDimensions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensAlgorithmKind;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensAlgorithmKind'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensAlgorithmKind",  "CoreMedia")]
		public static NSString LensAlgorithmKind {
			get {
				if (_LensAlgorithmKind is null)
					_LensAlgorithmKind = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensAlgorithmKind")!;
				return _LensAlgorithmKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensDistortions;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensDistortions'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensDistortions",  "CoreMedia")]
		public static NSString LensDistortions {
			get {
				if (_LensDistortions is null)
					_LensDistortions = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensDistortions")!;
				return _LensDistortions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensDomain;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensDomain'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensDomain",  "CoreMedia")]
		public static NSString LensDomain {
			get {
				if (_LensDomain is null)
					_LensDomain = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensDomain")!;
				return _LensDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensFrameAdjustmentsPolynomialX;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensFrameAdjustmentsPolynomialX'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensFrameAdjustmentsPolynomialX",  "CoreMedia")]
		public static NSString LensFrameAdjustmentsPolynomialX {
			get {
				if (_LensFrameAdjustmentsPolynomialX is null)
					_LensFrameAdjustmentsPolynomialX = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensFrameAdjustmentsPolynomialX")!;
				return _LensFrameAdjustmentsPolynomialX;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensFrameAdjustmentsPolynomialY;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensFrameAdjustmentsPolynomialY'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensFrameAdjustmentsPolynomialY",  "CoreMedia")]
		public static NSString LensFrameAdjustmentsPolynomialY {
			get {
				if (_LensFrameAdjustmentsPolynomialY is null)
					_LensFrameAdjustmentsPolynomialY = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensFrameAdjustmentsPolynomialY")!;
				return _LensFrameAdjustmentsPolynomialY;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensIdentifier;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensIdentifier'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensIdentifier",  "CoreMedia")]
		public static NSString LensIdentifier {
			get {
				if (_LensIdentifier is null)
					_LensIdentifier = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensIdentifier")!;
				return _LensIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensRole;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_LensRole'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_LensRole",  "CoreMedia")]
		public static NSString LensRole {
			get {
				if (_LensRole is null)
					_LensRole = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_LensRole")!;
				return _LensRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RadialAngleLimit;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionCameraCalibration_RadialAngleLimit'.</summary>
		[Field ("kCMFormatDescriptionCameraCalibration_RadialAngleLimit",  "CoreMedia")]
		public static NSString RadialAngleLimit {
			get {
				if (_RadialAngleLimit is null)
					_RadialAngleLimit = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibration_RadialAngleLimit")!;
				return _RadialAngleLimit;
			}
		}
	} /* class CMCompressionPropertyCameraCalibrationKey */
}
