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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CIImageRepresentationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CIImageRepresentationOptions" /> with default (empty) values.</summary>
		public CIImageRepresentationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CIImageRepresentationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CIImageRepresentationOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? LossyCompressionQuality {
			get {
				return  GetFloatValue (CIImageRepresentationKeys.LossyCompressionQualityKey!);
			}
			set {
				SetNumberValue (CIImageRepresentationKeys.LossyCompressionQualityKey!, value);
			}
		}
		public global::AVFoundation.AVDepthData? AVDepthData {
			get {
				return Dictionary [CIImageRepresentationKeys.AVDepthDataKey!] as AVFoundation.AVDepthData;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.AVDepthDataKey!, value);
			}
		}
		public CIImage? DepthImage {
			get {
				return Dictionary [CIImageRepresentationKeys.DepthImageKey!] as CoreImage.CIImage;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.DepthImageKey!, value);
			}
		}
		public CIImage? DisparityImage {
			get {
				return Dictionary [CIImageRepresentationKeys.DisparityImageKey!] as CoreImage.CIImage;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.DisparityImageKey!, value);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CIImage? PortraitEffectsMatteImage {
			get {
				return Dictionary [CIImageRepresentationKeys.PortraitEffectsMatteImageKey!] as CoreImage.CIImage;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.PortraitEffectsMatteImageKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::AVFoundation.AVPortraitEffectsMatte? AVPortraitEffectsMatte {
			get {
				return Dictionary [CIImageRepresentationKeys.AVPortraitEffectsMatteKey!] as AVFoundation.AVPortraitEffectsMatte;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.AVPortraitEffectsMatteKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public global::AVFoundation.AVSemanticSegmentationMatte[]? SemanticSegmentationMattes {
			get {
				return GetArray<global::AVFoundation.AVSemanticSegmentationMatte> (CIImageRepresentationKeys.SemanticSegmentationMattesKey!);
			}
			set {
				SetArrayValue (CIImageRepresentationKeys.SemanticSegmentationMattesKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CIImage? SemanticSegmentationSkinMatteImage {
			get {
				return Dictionary [CIImageRepresentationKeys.SemanticSegmentationSkinMatteImageKey!] as CoreImage.CIImage;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.SemanticSegmentationSkinMatteImageKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CIImage? SemanticSegmentationHairMatteImage {
			get {
				return Dictionary [CIImageRepresentationKeys.SemanticSegmentationHairMatteImageKey!] as CoreImage.CIImage;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.SemanticSegmentationHairMatteImageKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CIImage? SemanticSegmentationTeethMatteImage {
			get {
				return Dictionary [CIImageRepresentationKeys.SemanticSegmentationTeethMatteImageKey!] as CoreImage.CIImage;
			}
			set {
				SetNativeValue (CIImageRepresentationKeys.SemanticSegmentationTeethMatteImageKey!, value);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CIImage? SemanticSegmentationGlassesMatteImage {
			get {
				return Dictionary [CIImageRepresentationKeys.SemanticSegmentationGlassesMatteImageKey!] as CoreImage.CIImage;
			}
		}
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CIImage? SemanticSegmentationSkyMatteImage {
			get {
				return Dictionary [CIImageRepresentationKeys.SemanticSegmentationSkyMatteImageKey!] as CoreImage.CIImage;
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public CIImage? HdrImage {
			get {
				return Dictionary [CIImageRepresentationKeys.HdrImageKey!] as CoreImage.CIImage;
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public CIImage? HdrGainMapImage {
			get {
				return Dictionary [CIImageRepresentationKeys.HdrGainMapImageKey!] as CoreImage.CIImage;
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public bool? RepresentationHdrGainMapAsRgb {
			get {
				return  GetBoolValue (CIImageRepresentationKeys.RepresentationHdrGainMapAsRgbKey!);
			}
		}
#endif
	}
}
