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
	public partial class VTCompressionPropertyCameraCalibration : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTCompressionPropertyCameraCalibration" /> with default (empty) values.</summary>
		public VTCompressionPropertyCameraCalibration () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTCompressionPropertyCameraCalibration" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTCompressionPropertyCameraCalibration (NSDictionary? dictionary) : base (dictionary) {}
		public VTCameraCalibrationLensAlgorithmKind? LensAlgorithmKind {
			get {
				return TryGetNativeValue (VTCompressionPropertyCameraCalibrationKey.LensAlgorithmKind!, out var handle) ? global::VideoToolbox.VTCameraCalibrationLensAlgorithmKindExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (VTCompressionPropertyCameraCalibrationKey.LensAlgorithmKind!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public VTCameraCalibrationLensDomain? LensDomain {
			get {
				return TryGetNativeValue (VTCompressionPropertyCameraCalibrationKey.LensDomain!, out var handle) ? global::VideoToolbox.VTCameraCalibrationLensDomainExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (VTCompressionPropertyCameraCalibrationKey.LensDomain!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public int? LensIdentifier {
			get {
				return  GetInt32Value (VTCompressionPropertyCameraCalibrationKey.LensIdentifier!);
			}
			set {
				SetNumberValue (VTCompressionPropertyCameraCalibrationKey.LensIdentifier!, value);
			}
		}
		public VTCameraCalibrationLensRole? LensRole {
			get {
				return TryGetNativeValue (VTCompressionPropertyCameraCalibrationKey.LensRole!, out var handle) ? global::VideoToolbox.VTCameraCalibrationLensRoleExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (VTCompressionPropertyCameraCalibrationKey.LensRole!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public float[]? LensDistortions {
			get {
				return GetArray<float> (VTCompressionPropertyCameraCalibrationKey.LensDistortions!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (VTCompressionPropertyCameraCalibrationKey.LensDistortions!, value);
			}
		}
		public float? RadialAngleLimit {
			get {
				return  GetFloatValue (VTCompressionPropertyCameraCalibrationKey.RadialAngleLimit!);
			}
			set {
				SetNumberValue (VTCompressionPropertyCameraCalibrationKey.RadialAngleLimit!, value);
			}
		}
		public float[]? LensFrameAdjustmentsPolynomialX {
			get {
				return GetArray<float> (VTCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialX!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (VTCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialX!, value);
			}
		}
		public float[]? LensFrameAdjustmentsPolynomialY {
			get {
				return GetArray<float> (VTCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialY!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (VTCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialY!, value);
			}
		}
		public NMatrix3? IntrinsicMatrix {
			get {
				return  GetNSDataAsValueType<NMatrix3> (VTCompressionPropertyCameraCalibrationKey.IntrinsicMatrix!);
			}
			set {
				SetValueTypeAsNSData (VTCompressionPropertyCameraCalibrationKey.IntrinsicMatrix!, value);
			}
		}
		public float? IntrinsicMatrixProjectionOffset {
			get {
				return  GetFloatValue (VTCompressionPropertyCameraCalibrationKey.IntrinsicMatrixProjectionOffset!);
			}
			set {
				SetNumberValue (VTCompressionPropertyCameraCalibrationKey.IntrinsicMatrixProjectionOffset!, value);
			}
		}
		public CGSizeDictionary? IntrinsicMatrixReferenceDimensions {
			get {
				return GetStrongDictionary<CGSizeDictionary>(VTCompressionPropertyCameraCalibrationKey.IntrinsicMatrixReferenceDimensions!, (dict) => new CGSizeDictionary (dict));
			}
			set {
				SetNativeValue (VTCompressionPropertyCameraCalibrationKey.IntrinsicMatrixReferenceDimensions!, value?.Dictionary);
			}
		}
		public VTCameraCalibrationExtrinsicOriginSource? ExtrinsicOriginSource {
			get {
				return TryGetNativeValue (VTCompressionPropertyCameraCalibrationKey.ExtrinsicOriginSource!, out var handle) ? global::VideoToolbox.VTCameraCalibrationExtrinsicOriginSourceExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (VTCompressionPropertyCameraCalibrationKey.ExtrinsicOriginSource!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public float[]? ExtrinsicOrientationQuaternion {
			get {
				return GetArray<float> (VTCompressionPropertyCameraCalibrationKey.ExtrinsicOrientationQuaternion!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (VTCompressionPropertyCameraCalibrationKey.ExtrinsicOrientationQuaternion!, value);
			}
		}
#endif
	}
}
