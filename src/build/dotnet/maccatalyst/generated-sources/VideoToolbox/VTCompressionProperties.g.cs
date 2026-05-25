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
namespace VideoToolbox {
	/// <summary>Strongly typed set of options for compression sessions</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTCompressionProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTCompressionProperties" /> with default (empty) values.</summary>
		public VTCompressionProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTCompressionProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTCompressionProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? NumberOfPendingFrames {
			get {
				return  GetInt32Value (VTCompressionPropertyKey.NumberOfPendingFrames!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? PixelBufferPoolIsShared {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.PixelBufferPoolIsShared!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? VideoEncoderPixelBufferAttributes {
			get {
				return GetNSDictionary (VTCompressionPropertyKey.VideoEncoderPixelBufferAttributes!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? MaxKeyFrameInterval {
			get {
				return  GetInt32Value (VTCompressionPropertyKey.MaxKeyFrameInterval!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.MaxKeyFrameInterval!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public double? MaxKeyFrameIntervalDuration {
			get {
				return  GetDoubleValue (VTCompressionPropertyKey.MaxKeyFrameIntervalDuration!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.MaxKeyFrameIntervalDuration!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? AllowTemporalCompression {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.AllowTemporalCompression!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.AllowTemporalCompression!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? AllowFrameReordering {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.AllowFrameReordering!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.AllowFrameReordering!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? AllowOpenGop {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.AllowOpenGop!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.AllowOpenGop!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? AverageBitRate {
			get {
				return  GetInt32Value (VTCompressionPropertyKey.AverageBitRate!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.AverageBitRate!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? Quality {
			get {
				return  GetFloatValue (VTCompressionPropertyKey.Quality!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.Quality!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? MoreFramesBeforeStart {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.MoreFramesBeforeStart!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.MoreFramesBeforeStart!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? MoreFramesAfterEnd {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.MoreFramesAfterEnd!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.MoreFramesAfterEnd!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::CoreMedia.CMPixelFormat? Depth {
			get {
				return (global::CoreMedia.CMPixelFormat?) GetUInt32Value (VTCompressionPropertyKey.Depth!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.Depth!, (System.UInt32?)value);
			}
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public bool? PreserveAlphaChannel {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.PreserveAlphaChannel!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.PreserveAlphaChannel!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? MaxFrameDelayCount {
			get {
				return  GetInt32Value (VTCompressionPropertyKey.MaxFrameDelayCount!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.MaxFrameDelayCount!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? MaxH264SliceBytes {
			get {
				return  GetInt32Value (VTCompressionPropertyKey.MaxH264SliceBytes!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.MaxH264SliceBytes!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? RealTime {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.RealTime!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.RealTime!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? MaximizePowerEfficiency {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.MaximizePowerEfficiency!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.MaximizePowerEfficiency!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public uint? SourceFrameCount {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.SourceFrameCount!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.SourceFrameCount!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public double? ExpectedFrameRate {
			get {
				return  GetDoubleValue (VTCompressionPropertyKey.ExpectedFrameRate!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.ExpectedFrameRate!, value);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public double? MaximumRealTimeFrameRate {
			get {
				return  GetDoubleValue (VTCompressionPropertyKey.MaximumRealTimeFrameRate!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public double? ExpectedDuration {
			get {
				return  GetDoubleValue (VTCompressionPropertyKey.ExpectedDuration!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.ExpectedDuration!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double? BaseLayerFrameRate {
			get {
				return  GetDoubleValue (VTCompressionPropertyKey.BaseLayerFrameRate!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.BaseLayerFrameRate!, value);
			}
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public long? ReferenceBufferCount {
			get {
				return  GetLongValue (VTCompressionPropertyKey.ReferenceBufferCount!);
			}
		}
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public bool? CalculateMeanSquaredError {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.CalculateMeanSquaredError!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? UsingHardwareAcceleratedVideoEncoder {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.UsingHardwareAcceleratedVideoEncoder!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? CleanAperture {
			get {
				return GetNSDictionary (VTCompressionPropertyKey.CleanAperture!);
			}
			set {
				SetNativeValue (VTCompressionPropertyKey.CleanAperture!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? PixelAspectRatio {
			get {
				return GetNSDictionary (VTCompressionPropertyKey.PixelAspectRatio!);
			}
			set {
				SetNativeValue (VTCompressionPropertyKey.PixelAspectRatio!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public VTFieldCount? FieldCount {
			get {
				return (VTFieldCount?) GetInt32Value (VTCompressionPropertyKey.FieldCount!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.FieldCount!, (System.Int32?)value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? AspectRatio16x9 {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.AspectRatio16x9!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.AspectRatio16x9!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ProgressiveScan {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.ProgressiveScan!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.ProgressiveScan!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? ICCProfile {
			get {
				return Dictionary [VTCompressionPropertyKey.ICCProfile!] as Foundation.NSData;
			}
			set {
				SetNativeValue (VTCompressionPropertyKey.ICCProfile!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSData? MasteringDisplayColorVolume {
			get {
				return Dictionary [VTCompressionPropertyKey.MasteringDisplayColorVolume!] as Foundation.NSData;
			}
			set {
				SetNativeValue (VTCompressionPropertyKey.MasteringDisplayColorVolume!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSData? ContentLightLevelInfo {
			get {
				return Dictionary [VTCompressionPropertyKey.ContentLightLevelInfo!] as Foundation.NSData;
			}
			set {
				SetNativeValue (VTCompressionPropertyKey.ContentLightLevelInfo!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? PixelTransferProperties {
			get {
				return GetNSDictionary (VTCompressionPropertyKey.PixelTransferProperties!);
			}
			set {
				SetNativeValue (VTCompressionPropertyKey.PixelTransferProperties!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public string? EncoderId {
			get {
				return GetStringValue (VTCompressionPropertyKey.EncoderId!);
			}
			set {
				SetStringValue (VTCompressionPropertyKey.EncoderId!, value);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos14.0")]
		public ulong? RecommendedParallelizedSubdivisionMinimumFrameCount {
			get {
				return  GetULongValue (VTCompressionPropertyKey.RecommendedParallelizedSubdivisionMinimumFrameCount!);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos14.0")]
		public NSDictionary? RecommendedParallelizedSubdivisionMinimumDuration {
			get {
				return GetNSDictionary (VTCompressionPropertyKey.RecommendedParallelizedSubdivisionMinimumDuration!);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? TargetQualityForAlpha {
			get {
				return  GetFloatValue (VTCompressionPropertyKey.TargetQualityForAlpha!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.TargetQualityForAlpha!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public double? GammaLevel {
			get {
				return  GetDoubleValue (VTCompressionPropertyKey.GammaLevel!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.GammaLevel!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint? UsingGpuRegistryId {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.UsingGpuRegistryId!);
			}
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public long? ConstantBitRate {
			get {
				return  GetLongValue (VTCompressionPropertyKey.ConstantBitRate!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.ConstantBitRate!, value);
			}
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public long? EstimatedAverageBytesPerFrame {
			get {
				return  GetLongValue (VTCompressionPropertyKey.EstimatedAverageBytesPerFrame!);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? PreserveDynamicHdrMetadata {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.PreserveDynamicHdrMetadata!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.PreserveDynamicHdrMetadata!, value);
			}
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? EnableLowLatencyRateControl {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.EnableLowLatencyRateControl!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.EnableLowLatencyRateControl!, value);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public float? BaseLayerBitRateFraction {
			get {
				return  GetFloatValue (VTCompressionPropertyKey.BaseLayerBitRateFraction!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.BaseLayerBitRateFraction!, value);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? EnableLtr {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.EnableLtr!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.EnableLtr!, value);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint? MaxAllowedFrameQP {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.MaxAllowedFrameQP!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.MaxAllowedFrameQP!, value);
			}
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public uint? MinAllowedFrameQP {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.MinAllowedFrameQP!);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? SupportsBaseFrameQP {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.SupportsBaseFrameQP!);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public bool? OutputBitDepth {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.OutputBitDepth!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.OutputBitDepth!, value);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public global::CoreMedia.CMFormatDescriptionProjectionKind? ProjectionKind {
			get {
				return TryGetNativeValue (VTCompressionPropertyKey.ProjectionKind!, out var handle) ? global::CoreMedia.CMFormatDescriptionProjectionKindExtensions.GetNullableValue (handle) : null;
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public global::CoreMedia.CMFormatDescriptionViewPackingKind? ViewPackingKind {
			get {
				return TryGetNativeValue (VTCompressionPropertyKey.ViewPackingKind!, out var handle) ? global::CoreMedia.CMFormatDescriptionViewPackingKindExtensions.GetNullableValue (handle) : null;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public NSNumber[]? MvHevcVideoLayerIds {
			get {
				return GetArray<NSNumber> (VTCompressionPropertyKey.MvHevcVideoLayerIds!);
			}
			set {
				SetArrayValue (VTCompressionPropertyKey.MvHevcVideoLayerIds!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public NSNumber[]? MvHevcViewIds {
			get {
				return GetArray<NSNumber> (VTCompressionPropertyKey.MvHevcViewIds!);
			}
			set {
				SetArrayValue (VTCompressionPropertyKey.MvHevcViewIds!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public NSNumber[]? MvHevcLeftAndRightViewIds {
			get {
				return GetArray<NSNumber> (VTCompressionPropertyKey.MvHevcLeftAndRightViewIds!);
			}
			set {
				SetArrayValue (VTCompressionPropertyKey.MvHevcLeftAndRightViewIds!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public string? HeroEye {
			get {
				return GetStringValue (VTCompressionPropertyKey.HeroEye!);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public VTHeroEye? VTHeroEye {
			get {
				return TryGetNativeValue (VTCompressionPropertyKey.HeroEye!, out var handle) ? global::VideoToolbox.VTHeroEyeExtensions.GetNullableValue (handle) : null;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public uint? StereoCameraBaseline {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.StereoCameraBaseline!);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public int? HorizontalDisparityAdjustment {
			get {
				return  GetInt32Value (VTCompressionPropertyKey.HorizontalDisparityAdjustment!);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public bool? HasLeftStereoEyeView {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.HasLeftStereoEyeView!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.HasLeftStereoEyeView!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public bool? HasRightStereoEyeView {
			get {
				return  GetBoolValue (VTCompressionPropertyKey.HasRightStereoEyeView!);
			}
			set {
				SetBooleanValue (VTCompressionPropertyKey.HasRightStereoEyeView!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public uint? HorizontalFieldOfView {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.HorizontalFieldOfView!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.HorizontalFieldOfView!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public uint? VariableBitRate {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.VariableBitRate!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.VariableBitRate!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public uint? VbvMaxBitRate {
			get {
				return  GetUInt32Value (VTCompressionPropertyKey.VbvMaxBitRate!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.VbvMaxBitRate!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public float? VbvBufferDuration {
			get {
				return  GetFloatValue (VTCompressionPropertyKey.VbvBufferDuration!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.VbvBufferDuration!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public float? VbvInitialDelayPercentage {
			get {
				return  GetFloatValue (VTCompressionPropertyKey.VbvInitialDelayPercentage!);
			}
			set {
				SetNumberValue (VTCompressionPropertyKey.VbvInitialDelayPercentage!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public VTCompressionPropertyCameraCalibration[]? CameraCalibrationDataLensCollection {
			get {
				return GetArrayOfDictionariesValue<VTCompressionPropertyCameraCalibration> (VTCompressionPropertyKey.CameraCalibrationDataLensCollection!);
			}
			set {
				SetArrayOfDictionariesValue (VTCompressionPropertyKey.CameraCalibrationDataLensCollection!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public VTCompressionPreset? SupportedPresetDictionaries {
			get {
				return GetStrongDictionary<VTCompressionPreset>(VTCompressionPropertyKey.SupportedPresetDictionaries!, (dict) => new VTCompressionPreset (dict));
			}
		}
#endif
	}
}
