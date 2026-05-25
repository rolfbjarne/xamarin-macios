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
	/// <summary>Strongly typed set of options for decompression sessions.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTDecompressionProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTDecompressionProperties" /> with default (empty) values.</summary>
		public VTDecompressionProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTDecompressionProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTDecompressionProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? PixelBufferPoolIsShared {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.PixelBufferPoolIsShared!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public uint? OutputPoolRequestedMinimumBufferCount {
			get {
				return  GetUInt32Value (VTDecompressionPropertyKey.OutputPoolRequestedMinimumBufferCount!);
			}
			set {
				SetNumberValue (VTDecompressionPropertyKey.OutputPoolRequestedMinimumBufferCount!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public uint? NumberOfFramesBeingDecoded {
			get {
				return  GetUInt32Value (VTDecompressionPropertyKey.NumberOfFramesBeingDecoded!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? MinOutputPresentationTimeStampOfFramesBeingDecoded {
			get {
				return GetNSDictionary (VTDecompressionPropertyKey.MinOutputPresentationTimeStampOfFramesBeingDecoded!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? MaxOutputPresentationTimeStampOfFramesBeingDecoded {
			get {
				return GetNSDictionary (VTDecompressionPropertyKey.MaxOutputPresentationTimeStampOfFramesBeingDecoded!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ContentHasInterframeDependencies {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.ContentHasInterframeDependencies!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? UsingHardwareAcceleratedVideoDecoder {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.UsingHardwareAcceleratedVideoDecoder!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? RealTime {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.RealTime!);
			}
			set {
				SetBooleanValue (VTDecompressionPropertyKey.RealTime!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? MaximizePowerEfficiency {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.MaximizePowerEfficiency!);
			}
			set {
				SetBooleanValue (VTDecompressionPropertyKey.MaximizePowerEfficiency!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public uint? ThreadCount {
			get {
				return  GetUInt32Value (VTDecompressionPropertyKey.ThreadCount!);
			}
			set {
				SetNumberValue (VTDecompressionPropertyKey.ThreadCount!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public VTDecompressionResolutionOptions? ReducedResolutionDecode {
			get {
				return GetStrongDictionary<VTDecompressionResolutionOptions>(VTDecompressionPropertyKey.ReducedResolutionDecode!, (dict) => new VTDecompressionResolutionOptions (dict));
			}
			set {
				SetNativeValue (VTDecompressionPropertyKey.ReducedResolutionDecode!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public uint? ReducedCoefficientDecode {
			get {
				return  GetUInt32Value (VTDecompressionPropertyKey.ReducedCoefficientDecode!);
			}
			set {
				SetNumberValue (VTDecompressionPropertyKey.ReducedCoefficientDecode!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? ReducedFrameDelivery {
			get {
				return  GetFloatValue (VTDecompressionPropertyKey.ReducedFrameDelivery!);
			}
			set {
				SetNumberValue (VTDecompressionPropertyKey.ReducedFrameDelivery!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public int? TemporalLevelLimit {
			get {
				return  GetInt32Value (VTDecompressionPropertyKey.TemporalLevelLimit!);
			}
			set {
				SetNumberValue (VTDecompressionPropertyKey.TemporalLevelLimit!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary[]? SuggestedQualityOfServiceTiers {
			get {
				return GetArray<NSDictionary> (VTDecompressionPropertyKey.SuggestedQualityOfServiceTiers!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::CoreMedia.CMPixelFormat[]? SupportedPixelFormatsOrderedByQuality {
			get {
				return GetArray<global::CoreMedia.CMPixelFormat> (VTDecompressionPropertyKey.SupportedPixelFormatsOrderedByQuality!, (ptr) => (global::CoreMedia.CMPixelFormat?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt32Value ?? default (global::CoreMedia.CMPixelFormat));
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::CoreMedia.CMPixelFormat[]? SupportedPixelFormatsOrderedByPerformance {
			get {
				return GetArray<global::CoreMedia.CMPixelFormat> (VTDecompressionPropertyKey.SupportedPixelFormatsOrderedByPerformance!, (ptr) => (global::CoreMedia.CMPixelFormat?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt32Value ?? default (global::CoreMedia.CMPixelFormat));
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::CoreMedia.CMPixelFormat[]? PixelFormatsWithReducedResolutionSupport {
			get {
				return GetArray<global::CoreMedia.CMPixelFormat> (VTDecompressionPropertyKey.PixelFormatsWithReducedResolutionSupport!, (ptr) => (global::CoreMedia.CMPixelFormat?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt32Value ?? default (global::CoreMedia.CMPixelFormat));
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? PixelTransferProperties {
			get {
				return GetNSDictionary (VTDecompressionPropertyKey.PixelTransferProperties!);
			}
			set {
				SetNativeValue (VTDecompressionPropertyKey.PixelTransferProperties!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public VTPixelTransferProperties? PixelTransferSettings {
			get {
				return GetStrongDictionary<VTPixelTransferProperties>(VTDecompressionPropertyKey.PixelTransferProperties!, (dict) => new VTPixelTransferProperties (dict));
			}
			set {
				SetNativeValue (VTDecompressionPropertyKey.PixelTransferProperties!, value?.Dictionary);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint? UsingGpuRegistryId {
			get {
				return  GetUInt32Value (VTDecompressionPropertyKey.UsingGpuRegistryId!);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? PropagatePerFrameHhrDisplayMetadata {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.PropagatePerFrameHdrDisplayMetadata!);
			}
			set {
				SetBooleanValue (VTDecompressionPropertyKey.PropagatePerFrameHdrDisplayMetadata!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public bool? GeneratePerFrameHdrDisplayMetadata {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.GeneratePerFrameHdrDisplayMetadata!);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		public bool? AllowBitstreamToChangeFrameDimensions {
			get {
				return  GetBoolValue (VTDecompressionPropertyKey.AllowBitstreamToChangeFrameDimensions!);
			}
		}
#endif
	}
}
