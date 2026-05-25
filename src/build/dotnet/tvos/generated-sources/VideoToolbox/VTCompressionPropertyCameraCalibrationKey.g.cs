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
namespace VideoToolbox {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe static partial class VTCompressionPropertyCameraCalibrationKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtrinsicOrientationQuaternion;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOrientationQuaternion'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOrientationQuaternion",  "VideoToolbox")]
		public static NSString ExtrinsicOrientationQuaternion {
			get {
				if (_ExtrinsicOrientationQuaternion is null)
					_ExtrinsicOrientationQuaternion = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOrientationQuaternion")!;
				return _ExtrinsicOrientationQuaternion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtrinsicOriginSource;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOriginSource'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOriginSource",  "VideoToolbox")]
		public static NSString ExtrinsicOriginSource {
			get {
				if (_ExtrinsicOriginSource is null)
					_ExtrinsicOriginSource = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOriginSource")!;
				return _ExtrinsicOriginSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IntrinsicMatrix;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrix'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrix",  "VideoToolbox")]
		public static NSString IntrinsicMatrix {
			get {
				if (_IntrinsicMatrix is null)
					_IntrinsicMatrix = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrix")!;
				return _IntrinsicMatrix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IntrinsicMatrixProjectionOffset;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixProjectionOffset'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixProjectionOffset",  "VideoToolbox")]
		public static NSString IntrinsicMatrixProjectionOffset {
			get {
				if (_IntrinsicMatrixProjectionOffset is null)
					_IntrinsicMatrixProjectionOffset = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixProjectionOffset")!;
				return _IntrinsicMatrixProjectionOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IntrinsicMatrixReferenceDimensions;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixReferenceDimensions'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixReferenceDimensions",  "VideoToolbox")]
		public static NSString IntrinsicMatrixReferenceDimensions {
			get {
				if (_IntrinsicMatrixReferenceDimensions is null)
					_IntrinsicMatrixReferenceDimensions = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixReferenceDimensions")!;
				return _IntrinsicMatrixReferenceDimensions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensAlgorithmKind;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensAlgorithmKind'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensAlgorithmKind",  "VideoToolbox")]
		public static NSString LensAlgorithmKind {
			get {
				if (_LensAlgorithmKind is null)
					_LensAlgorithmKind = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensAlgorithmKind")!;
				return _LensAlgorithmKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensDistortions;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensDistortions'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensDistortions",  "VideoToolbox")]
		public static NSString LensDistortions {
			get {
				if (_LensDistortions is null)
					_LensDistortions = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensDistortions")!;
				return _LensDistortions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensDomain;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensDomain'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensDomain",  "VideoToolbox")]
		public static NSString LensDomain {
			get {
				if (_LensDomain is null)
					_LensDomain = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensDomain")!;
				return _LensDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensFrameAdjustmentsPolynomialX;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialX'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialX",  "VideoToolbox")]
		public static NSString LensFrameAdjustmentsPolynomialX {
			get {
				if (_LensFrameAdjustmentsPolynomialX is null)
					_LensFrameAdjustmentsPolynomialX = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialX")!;
				return _LensFrameAdjustmentsPolynomialX;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensFrameAdjustmentsPolynomialY;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialY'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialY",  "VideoToolbox")]
		public static NSString LensFrameAdjustmentsPolynomialY {
			get {
				if (_LensFrameAdjustmentsPolynomialY is null)
					_LensFrameAdjustmentsPolynomialY = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialY")!;
				return _LensFrameAdjustmentsPolynomialY;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensIdentifier;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensIdentifier'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensIdentifier",  "VideoToolbox")]
		public static NSString LensIdentifier {
			get {
				if (_LensIdentifier is null)
					_LensIdentifier = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensIdentifier")!;
				return _LensIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensRole;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_LensRole'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensRole",  "VideoToolbox")]
		public static NSString LensRole {
			get {
				if (_LensRole is null)
					_LensRole = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_LensRole")!;
				return _LensRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RadialAngleLimit;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyCameraCalibrationKey_RadialAngleLimit'.</summary>
		[Field ("kVTCompressionPropertyCameraCalibrationKey_RadialAngleLimit",  "VideoToolbox")]
		public static NSString RadialAngleLimit {
			get {
				if (_RadialAngleLimit is null)
					_RadialAngleLimit = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyCameraCalibrationKey_RadialAngleLimit")!;
				return _RadialAngleLimit;
			}
		}
	} /* class VTCompressionPropertyCameraCalibrationKey */
}
