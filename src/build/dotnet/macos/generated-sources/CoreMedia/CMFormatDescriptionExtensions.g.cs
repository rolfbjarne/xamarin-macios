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
	public partial class CMFormatDescriptionExtensions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CMFormatDescriptionExtensions" /> with default (empty) values.</summary>
		public CMFormatDescriptionExtensions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CMFormatDescriptionExtensions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CMFormatDescriptionExtensions (NSDictionary? dictionary) : base (dictionary) {}
		public NSDictionary<NSString, NSObject>? OriginalCompressionSettings {
			get {
				return GetNSDictionary <NSString, NSObject> (CMFormatDescriptionExtensionKeys.OriginalCompressionSettings!);
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.OriginalCompressionSettings!, value);
			}
		}
		public NSDictionary<NSString, NSObject>? SampleDescriptionExtensionAtoms {
			get {
				return GetNSDictionary <NSString, NSObject> (CMFormatDescriptionExtensionKeys.SampleDescriptionExtensionAtoms!);
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.SampleDescriptionExtensionAtoms!, value);
			}
		}
		public NSData? VerbatimSampleDescription {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.VerbatimSampleDescription!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.VerbatimSampleDescription!, value);
			}
		}
		public NSData? VerbatimISOSampleEntry {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.VerbatimISOSampleEntry!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.VerbatimISOSampleEntry!, value);
			}
		}
		public string? FormatName {
			get {
				return GetStringValue (CMFormatDescriptionExtensionKeys.FormatName!);
			}
			set {
				SetStringValue (CMFormatDescriptionExtensionKeys.FormatName!, value);
			}
		}
		/// <seealso>http://developer.apple.com/qa/qa2001/qa1183.html </seealso>
		public int? Depth {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.Depth!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.Depth!, value);
			}
		}
		public CMFormatDescriptionCleanAperture? CleanAperture {
			get {
				return GetStrongDictionary<CMFormatDescriptionCleanAperture>(CMFormatDescriptionExtensionKeys.CleanAperture!, (dict) => new CMFormatDescriptionCleanAperture (dict));
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.CleanAperture!, value?.Dictionary);
			}
		}
		public int? FieldCount {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.FieldCount!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.FieldCount!, value);
			}
		}
		public CMFormatDescriptionFieldDetail? FieldDetail {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.FieldDetail!, out var handle) ? global::CoreMedia.CMFormatDescriptionFieldDetailExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.FieldDetail!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public CMFormatDescriptionPixelAspectRatio? PixelAspectRatio {
			get {
				return GetStrongDictionary<CMFormatDescriptionPixelAspectRatio>(CMFormatDescriptionExtensionKeys.PixelAspectRatio!, (dict) => new CMFormatDescriptionPixelAspectRatio (dict));
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.PixelAspectRatio!, value?.Dictionary);
			}
		}
		public CMFormatDescriptionColorPrimaries? ColorPrimaries {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.ColorPrimaries!, out var handle) ? global::CoreMedia.CMFormatDescriptionColorPrimariesExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ColorPrimaries!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public CMFormatDescriptionTransferFunction? TransferFunction {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.TransferFunction!, out var handle) ? global::CoreMedia.CMFormatDescriptionTransferFunctionExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.TransferFunction!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public nint? GammaLevel {
			get {
				return  GetNIntValue (CMFormatDescriptionExtensionKeys.GammaLevel!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.GammaLevel!, value);
			}
		}
		public CMFormatDescriptionYCbCrMatrix? YCbCrMatrix {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.YCbCrMatrix!, out var handle) ? global::CoreMedia.CMFormatDescriptionYCbCrMatrixExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.YCbCrMatrix!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public bool? FullRangeVideo {
			get {
				return  GetBoolValue (CMFormatDescriptionExtensionKeys.FullRangeVideo!);
			}
			set {
				SetBooleanValue (CMFormatDescriptionExtensionKeys.FullRangeVideo!, value);
			}
		}
		public NSData? ICCProfile {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.ICCProfile!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ICCProfile!, value);
			}
		}
		public int? BytesPerRow {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.BytesPerRow!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.BytesPerRow!, value);
			}
		}
		public CMFormatDescriptionChromaLocation? ChromaLocationTopField {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.ChromaLocationTopField!, out var handle) ? global::CoreMedia.CMFormatDescriptionChromaLocationExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ChromaLocationTopField!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public CMFormatDescriptionChromaLocation? ChromaLocationBottomField {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.ChromaLocationBottomField!, out var handle) ? global::CoreMedia.CMFormatDescriptionChromaLocationExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ChromaLocationBottomField!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public CMMPEG2VideoProfile? ConformsToMPEG2VideoProfile {
			get {
				return (CMMPEG2VideoProfile?) GetInt32Value (CMFormatDescriptionExtensionKeys.ConformsToMPEG2VideoProfile!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.ConformsToMPEG2VideoProfile!, (System.Int32?)value);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public int? ProtectedContentOriginalFormat {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.ProtectedContentOriginalFormat!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.ProtectedContentOriginalFormat!, value);
			}
		}
		public NSNumber? TemporalQuality {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.TemporalQuality!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.TemporalQuality!, value);
			}
		}
		public NSNumber? SpatialQuality {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.SpatialQuality!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.SpatialQuality!, value);
			}
		}
		public string? VerbatimImageDescription {
			get {
				return GetStringValue (CMFormatDescriptionExtensionKeys.VerbatimImageDescription!);
			}
			set {
				SetStringValue (CMFormatDescriptionExtensionKeys.VerbatimImageDescription!, value);
			}
		}
		public int? Version {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.Version!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.Version!, value);
			}
		}
		public int? RevisionLevel {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.RevisionLevel!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.RevisionLevel!, value);
			}
		}
		public NSString? Vendor {
			get {
				return GetNSStringValue (CMFormatDescriptionExtensionKeys.Vendor!);
			}
			set {
				SetStringValue (CMFormatDescriptionExtensionKeys.Vendor!, value);
			}
		}
		public NSData? MasteringDisplayColorVolume {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.MasteringDisplayColorVolume!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.MasteringDisplayColorVolume!, value);
			}
		}
		public NSData? ContentLightLevelInfo {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.ContentLightLevelInfo!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ContentLightLevelInfo!, value);
			}
		}
		public CMMetadataFormatDescription? MetadataKeyTable {
			get {
				return GetStrongDictionary<CMMetadataFormatDescription>(CMFormatDescriptionExtensionKeys.MetadataKeyTable!, (dict) => new CMMetadataFormatDescription (dict));
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public NSData? ContentColorVolume {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.ContentColorVolume!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ContentColorVolume!, value);
			}
		}
		public NSString? AlternativeTransferCharacteristics {
			get {
				return GetNSStringValue (CMFormatDescriptionExtensionKeys.AlternativeTransferCharacteristics!);
			}
			set {
				SetStringValue (CMFormatDescriptionExtensionKeys.AlternativeTransferCharacteristics!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public string? AuxiliaryTypeInfo {
			get {
				return GetStringValue (CMFormatDescriptionExtensionKeys.AuxiliaryTypeInfo!);
			}
			set {
				SetStringValue (CMFormatDescriptionExtensionKeys.AuxiliaryTypeInfo!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public CMFormatDescriptionAlphaChannelMode? AlphaChannelMode {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.AlphaChannelMode!, out var handle) ? global::CoreMedia.CMFormatDescriptionAlphaChannelModeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.AlphaChannelMode!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool? ContainsAlphaChannel {
			get {
				return  GetBoolValue (CMFormatDescriptionExtensionKeys.ContainsAlphaChannel!);
			}
			set {
				SetBooleanValue (CMFormatDescriptionExtensionKeys.ContainsAlphaChannel!, value);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public int? BitsPerComponent {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.BitsPerComponent!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.BitsPerComponent!, value);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public nint? HorizontalFieldOfView {
			get {
				return  GetNIntValue (CMFormatDescriptionExtensionKeys.HorizontalFieldOfView!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.HorizontalFieldOfView!, value);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSData? AmbientViewingEnvironment {
			get {
				return Dictionary [CMFormatDescriptionExtensionKeys.AmbientViewingEnvironment!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.AmbientViewingEnvironment!, value);
			}
		}
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		public NSString? LogTransferFunction {
			get {
				return GetNSStringValue (CMFormatDescriptionExtensionKeys.LogTransferFunction!);
			}
			set {
				SetStringValue (CMFormatDescriptionExtensionKeys.LogTransferFunction!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public CMFormatDescriptionHeroEye? HeroEye {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.HeroEye!, out var handle) ? global::CoreMedia.CMFormatDescriptionHeroEyeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.HeroEye!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public uint? StereoCameraBaseline {
			get {
				return  GetUInt32Value (CMFormatDescriptionExtensionKeys.StereoCameraBaseline!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.StereoCameraBaseline!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public int? HorizontalDisparityAdjustment {
			get {
				return  GetInt32Value (CMFormatDescriptionExtensionKeys.HorizontalDisparityAdjustment!);
			}
			set {
				SetNumberValue (CMFormatDescriptionExtensionKeys.HorizontalDisparityAdjustment!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? HasLeftStereoEyeView {
			get {
				return  GetBoolValue (CMFormatDescriptionExtensionKeys.HasLeftStereoEyeView!);
			}
			set {
				SetBooleanValue (CMFormatDescriptionExtensionKeys.HasLeftStereoEyeView!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? HasRightStereoEyeView {
			get {
				return  GetBoolValue (CMFormatDescriptionExtensionKeys.HasRightStereoEyeView!);
			}
			set {
				SetBooleanValue (CMFormatDescriptionExtensionKeys.HasRightStereoEyeView!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? HasAdditionalViews {
			get {
				return  GetBoolValue (CMFormatDescriptionExtensionKeys.HasAdditionalViews!);
			}
			set {
				SetBooleanValue (CMFormatDescriptionExtensionKeys.HasAdditionalViews!, value);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public CMFormatDescriptionProjectionKind? ProjectionKind {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.ProjectionKind!, out var handle) ? global::CoreMedia.CMFormatDescriptionProjectionKindExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ProjectionKind!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public CMFormatDescriptionViewPackingKind? ViewPackingKind {
			get {
				return TryGetNativeValue (CMFormatDescriptionExtensionKeys.ViewPackingKind!, out var handle) ? global::CoreMedia.CMFormatDescriptionViewPackingKindExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CMFormatDescriptionExtensionKeys.ViewPackingKind!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public CMCompressionPropertyCameraCalibration[]? CameraCalibrationDataLensCollection {
			get {
				return GetArrayOfDictionariesValue<CMCompressionPropertyCameraCalibration> (CMFormatDescriptionExtensionKeys.CameraCalibrationDataLensCollection!);
			}
		}
#endif
	}
}
