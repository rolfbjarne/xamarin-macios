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
namespace CoreMedia {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public partial class CMCompressionPropertyCameraCalibration : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CMCompressionPropertyCameraCalibration" /> with default (empty) values.</summary>
		public CMCompressionPropertyCameraCalibration () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CMCompressionPropertyCameraCalibration" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CMCompressionPropertyCameraCalibration (NSDictionary? dictionary) : base (dictionary) {}
		public CMFormatDescriptionCameraCalibrationLensAlgorithmKind? LensAlgorithmKind {
			get {
				return TryGetNativeValue (CMCompressionPropertyCameraCalibrationKey.LensAlgorithmKind!, out var handle) ? global::CoreMedia.CMFormatDescriptionCameraCalibrationLensAlgorithmKindExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMCompressionPropertyCameraCalibrationKey.LensAlgorithmKind!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public CMFormatDescriptionCameraCalibrationLensDomain? LensDomain {
			get {
				return TryGetNativeValue (CMCompressionPropertyCameraCalibrationKey.LensDomain!, out var handle) ? global::CoreMedia.CMFormatDescriptionCameraCalibrationLensDomainExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMCompressionPropertyCameraCalibrationKey.LensDomain!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public int? LensIdentifier {
			get {
				return  GetInt32Value (CMCompressionPropertyCameraCalibrationKey.LensIdentifier!);
			}
			set {
				SetNumberValue (CMCompressionPropertyCameraCalibrationKey.LensIdentifier!, value);
			}
		}
		public CMFormatDescriptionCameraCalibrationLensRole? LensRole {
			get {
				return TryGetNativeValue (CMCompressionPropertyCameraCalibrationKey.LensRole!, out var handle) ? global::CoreMedia.CMFormatDescriptionCameraCalibrationLensRoleExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMCompressionPropertyCameraCalibrationKey.LensRole!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public float[]? LensDistortions {
			get {
				return GetArray<float> (CMCompressionPropertyCameraCalibrationKey.LensDistortions!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (CMCompressionPropertyCameraCalibrationKey.LensDistortions!, value);
			}
		}
		public float? RadialAngleLimit {
			get {
				return  GetFloatValue (CMCompressionPropertyCameraCalibrationKey.RadialAngleLimit!);
			}
			set {
				SetNumberValue (CMCompressionPropertyCameraCalibrationKey.RadialAngleLimit!, value);
			}
		}
		public float[]? LensFrameAdjustmentsPolynomialX {
			get {
				return GetArray<float> (CMCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialX!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (CMCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialX!, value);
			}
		}
		public float[]? LensFrameAdjustmentsPolynomialY {
			get {
				return GetArray<float> (CMCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialY!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (CMCompressionPropertyCameraCalibrationKey.LensFrameAdjustmentsPolynomialY!, value);
			}
		}
		public NMatrix3? IntrinsicMatrix {
			get {
				return  GetNSDataAsValueType<NMatrix3> (CMCompressionPropertyCameraCalibrationKey.IntrinsicMatrix!);
			}
			set {
				SetValueTypeAsNSData (CMCompressionPropertyCameraCalibrationKey.IntrinsicMatrix!, value);
			}
		}
		public float? IntrinsicMatrixProjectionOffset {
			get {
				return  GetFloatValue (CMCompressionPropertyCameraCalibrationKey.IntrinsicMatrixProjectionOffset!);
			}
			set {
				SetNumberValue (CMCompressionPropertyCameraCalibrationKey.IntrinsicMatrixProjectionOffset!, value);
			}
		}
		public CGSizeDictionary? IntrinsicMatrixReferenceDimensions {
			get {
				return GetStrongDictionary<CGSizeDictionary>(CMCompressionPropertyCameraCalibrationKey.IntrinsicMatrixReferenceDimensions!, (dict) => new CGSizeDictionary (dict));
			}
			set {
				SetNativeValue (CMCompressionPropertyCameraCalibrationKey.IntrinsicMatrixReferenceDimensions!, value?.Dictionary);
			}
		}
		public CMFormatDescriptionCameraCalibrationExtrinsicOriginSource? ExtrinsicOriginSource {
			get {
				return TryGetNativeValue (CMCompressionPropertyCameraCalibrationKey.ExtrinsicOriginSource!, out var handle) ? global::CoreMedia.CMFormatDescriptionCameraCalibrationExtrinsicOriginSourceExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMCompressionPropertyCameraCalibrationKey.ExtrinsicOriginSource!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public float[]? ExtrinsicOrientationQuaternion {
			get {
				return GetArray<float> (CMCompressionPropertyCameraCalibrationKey.ExtrinsicOrientationQuaternion!, (ptr) => (float?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.FloatValue ?? default (float));
			}
			set {
				SetArrayValue<float> (CMCompressionPropertyCameraCalibrationKey.ExtrinsicOrientationQuaternion!, value);
			}
		}
		public bool? ConvertedFromExternalSphericalTags {
			get {
				return  GetBoolValue (CMCompressionPropertyCameraCalibrationKey.ConvertedFromExternalSphericalTags!);
			}
			set {
				SetBooleanValue (CMCompressionPropertyCameraCalibrationKey.ConvertedFromExternalSphericalTags!, value);
			}
		}
#endif
	}
}
