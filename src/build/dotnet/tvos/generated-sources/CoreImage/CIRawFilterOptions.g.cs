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
namespace CoreImage {
	/// <summary>Settings for use with <see cref="M:CoreImage.CIFilter.CreateRawFilter(CoreVideo.CVPixelBuffer,Foundation.NSDictionary,Foundation.NSDictionary)" />.</summary>
	[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
	[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
	[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CIRawFilterOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CIRawFilterOptions" /> with default (empty) values.</summary>
		public CIRawFilterOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CIRawFilterOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CIRawFilterOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary><see langword="true" /> if draft mode should be allowed. (Switching this key is an expensive operation.)</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? AllowDraftMode {
			get {
				return  GetBoolValue (CIRawFilterKeys.AllowDraftModeKey!);
			}
			set {
				SetBooleanValue (CIRawFilterKeys.AllowDraftModeKey!, value);
			}
		}
		/// <summary>The key of the current decoder (see <see cref="P:CoreImage.CIRawFilterOptions.SupportedDecoderVersions" />).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public string? Version {
			get {
				return GetStringValue (CIRawFilterKeys.VersionKey!);
			}
			set {
				SetStringValue (CIRawFilterKeys.VersionKey!, value);
			}
		}
		/// <summary>A dictionary whose keys are version identifiers of valid decoders.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSDictionary[]? SupportedDecoderVersions {
			get {
				return GetArray<NSDictionary> (CIRawFilterKeys.SupportedDecoderVersionsKey!);
			}
			set {
				SetArrayValue (CIRawFilterKeys.SupportedDecoderVersionsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? BaselineExposure {
			get {
				return  GetFloatValue (CIRawFilterKeys.BaselineExposureKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.BaselineExposureKey!, value);
			}
		}
		/// <summary>Amount of boost (contrast enhancement), ranging from 0.0 (no boost) to 1.0 (full boost).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? Boost {
			get {
				return  GetFloatValue (CIRawFilterKeys.BoostKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.BoostKey!, value);
			}
		}
		/// <summary>Amount of boost (contrast enhancement), ranging from 0.0 (no boost) to 1.0 (full boost) to be applied in shadow regions.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? BoostShadowAmount {
			get {
				return  GetFloatValue (CIRawFilterKeys.BoostShadowAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.BoostShadowAmountKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? DisableGamutMap {
			get {
				return  GetBoolValue (CIRawFilterKeys.DisableGamutMapKey!);
			}
			set {
				SetBooleanValue (CIRawFilterKeys.DisableGamutMapKey!, value);
			}
		}
		/// <summary>Current neutral X value of the chromaticity.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? NeutralChromaticityX {
			get {
				return  GetFloatValue (CIRawFilterKeys.NeutralChromaticityXKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NeutralChromaticityXKey!, value);
			}
		}
		/// <summary>Current neutral Y value of the chromaticity.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? NeutralChromaticityY {
			get {
				return  GetFloatValue (CIRawFilterKeys.NeutralChromaticityYKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NeutralChromaticityYKey!, value);
			}
		}
		/// <summary>The neutral color temperature. (Set using <see cref="P:CoreImage.CIRawFilterOptions.NeutralTint" />.)</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? NeutralTemperature {
			get {
				return  GetFloatValue (CIRawFilterKeys.NeutralTemperatureKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NeutralTemperatureKey!, value);
			}
		}
		/// <summary>The neutral tint. Setting this value also modifies <see cref="P:CoreImage.CIRawFilterOptions.NeutralTemperature" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? NeutralTint {
			get {
				return  GetFloatValue (CIRawFilterKeys.NeutralTintKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NeutralTintKey!, value);
			}
		}
		/// <summary>Used to set the neutral (X,Y) position in the unrotated output image.</summary><value>To be added.</value><remarks><para>Developers should not rely on reading this value: it is specified as "undefined" for reading.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CIVector? NeutralLocation {
			get {
				return Dictionary [CIRawFilterKeys.NeutralLocationKey!] as CoreImage.CIVector;
			}
			set {
				SetNativeValue (CIRawFilterKeys.NeutralLocationKey!, value);
			}
		}
		/// <summary>The desired scale factor for drawing the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public float? ScaleFactor {
			get {
				return  GetFloatValue (CIRawFilterKeys.ScaleFactorKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.ScaleFactorKey!, value);
			}
		}
		/// <summary>If <see langword="true" />, the image's embedded orientation data will be ignored.</summary><value>The default value is <see langword="false" />.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? IgnoreImageOrientation {
			get {
				return  GetBoolValue (CIRawFilterKeys.IgnoreImageOrientationKey!);
			}
			set {
				SetBooleanValue (CIRawFilterKeys.IgnoreImageOrientationKey!, value);
			}
		}
		/// <summary>The EXIF image orientation value (in the range 1..8).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public int? ImageOrientation {
			get {
				return  GetInt32Value (CIRawFilterKeys.ImageOrientationKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.ImageOrientationKey!, value);
			}
		}
		/// <summary><see langword="true" /> if sharpening should be applied.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? EnableSharpening {
			get {
				return  GetBoolValue (CIRawFilterKeys.EnableSharpeningKey!);
			}
			set {
				SetBooleanValue (CIRawFilterKeys.EnableSharpeningKey!, value);
			}
		}
		/// <summary>If <see langword="true" />, chromatic noise tracking using ISO and exposure is active.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? EnableChromaticNoiseTracking {
			get {
				return  GetBoolValue (CIRawFilterKeys.EnableChromaticNoiseTrackingKey!);
			}
			set {
				SetBooleanValue (CIRawFilterKeys.EnableChromaticNoiseTrackingKey!, value);
			}
		}
		/// <summary>Amount of noise reduction to apply, ranging from 0.0 (no reduction) to 1.0 (maximum).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? NoiseReductionAmount {
			get {
				return  GetDoubleValue (CIRawFilterKeys.NoiseReductionAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NoiseReductionAmountKey!, value);
			}
		}
		/// <summary>If <see langword="true" />, correction will be applied for known lenses.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? EnableVendorLensCorrection {
			get {
				return  GetBoolValue (CIRawFilterKeys.EnableVendorLensCorrectionKey!);
			}
			set {
				SetBooleanValue (CIRawFilterKeys.EnableVendorLensCorrectionKey!, value);
			}
		}
		/// <summary>Amount of noise reduction to apply to luminance data, ranging from 0.0 (no reduction) to 1.0 (maximum).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? LuminanceNoiseReductionAmount {
			get {
				return  GetDoubleValue (CIRawFilterKeys.LuminanceNoiseReductionAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.LuminanceNoiseReductionAmountKey!, value);
			}
		}
		/// <summary>Amount of noise reduction to apply to color data, ranging from 0.0 (no reduction) to 1.0 (maximum).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? ColorNoiseReductionAmount {
			get {
				return  GetDoubleValue (CIRawFilterKeys.ColorNoiseReductionAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.ColorNoiseReductionAmountKey!, value);
			}
		}
		/// <summary>Amount of sharpening to apply during noise reduction, in the range 0.0 (no sharpening) to 1.0 (maximum).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? NoiseReductionSharpnessAmount {
			get {
				return  GetDoubleValue (CIRawFilterKeys.NoiseReductionSharpnessAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NoiseReductionSharpnessAmountKey!, value);
			}
		}
		/// <summary>Amount of contrast enhancement to apply during noise reduction, in the range 0.0 (no contrast enhancement) to 1.0 (maximum).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? NoiseReductionContrastAmount {
			get {
				return  GetDoubleValue (CIRawFilterKeys.NoiseReductionContrastAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NoiseReductionContrastAmountKey!, value);
			}
		}
		/// <summary>Amount of detail enhancement to apply during noise reduction, in the range 0.0 (no detail enhancement) to 1.0 (maximum).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? NoiseReductionDetailAmount {
			get {
				return  GetDoubleValue (CIRawFilterKeys.NoiseReductionDetailAmountKey!);
			}
			set {
				SetNumberValue (CIRawFilterKeys.NoiseReductionDetailAmountKey!, value);
			}
		}
		/// <summary>The <see cref="T:CoreImage.CIFilter" /> applied to the image when, during RAW processing, it is in the linear color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CIFilter? LinearSpaceFilter {
			get {
				return Dictionary [CIRawFilterKeys.LinearSpaceFilterKey!] as CoreImage.CIFilter;
			}
			set {
				SetNativeValue (CIRawFilterKeys.LinearSpaceFilterKey!, value);
			}
		}
		/// <summary>The full native size of the original image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CIVector? OutputNativeSize {
			get {
				return Dictionary [CIRawFilterKeys.OutputNativeSizeKey!] as CoreImage.CIVector;
			}
			set {
				SetNativeValue (CIRawFilterKeys.OutputNativeSizeKey!, value);
			}
		}
		/// <summary>The set of input keys that are available for use on the input image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSSet? ActiveKeys {
			get {
				return Dictionary [CIRawFilterKeys.ActiveKeysKey!] as Foundation.NSSet;
			}
		}
#endif
	}
}
