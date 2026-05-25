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
namespace CoreImage {
	/// <summary>Options that can be used when initializing a new <see cref="T:CoreImage.CIImage" />.</summary>
	public partial class CIImageInitializationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CIImageInitializationOptions" /> with default (empty) values.</summary>
		public CIImageInitializationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CIImageInitializationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CIImageInitializationOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImageProperties? Properties {
			get {
				return GetStrongDictionary<CGImageProperties>(CIImageInitializationOptionsKeys.PropertiesKey!, (dict) => new CGImageProperties (dict));
			}
			set {
				SetNativeValue (CIImageInitializationOptionsKeys.PropertiesKey!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? ApplyOrientationProperty {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.ApplyOrientationPropertyKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.ApplyOrientationPropertyKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? NearestSampling {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.NearestSamplingKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.NearestSamplingKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? AuxiliaryDepth {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliaryDepthKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliaryDepthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? AuxiliaryDisparity {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliaryDisparityKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliaryDisparityKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? AuxiliaryPortraitEffectsMatte {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliaryPortraitEffectsMatteKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliaryPortraitEffectsMatteKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? AuxiliarySemanticSegmentationSkinMatte {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationSkinMatteKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationSkinMatteKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? AuxiliarySemanticSegmentationHairMatte {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationHairMatteKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationHairMatteKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? AuxiliarySemanticSegmentationTeethMatte {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationTeethMatteKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationTeethMatteKey!, value);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? AuxiliarySemanticSegmentationGlassesMatte {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationGlassesMatteKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationGlassesMatteKey!, value);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.1")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? AuxiliaryHdrGainMap {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.AuxiliaryHdrGainMapKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.AuxiliaryHdrGainMapKey!, value);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? ToneMapHdrToSdr {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.ToneMapHdrToSdrKey!);
			}
			set {
				SetBooleanValue (CIImageInitializationOptionsKeys.ToneMapHdrToSdrKey!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? CacheImmediately {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.CacheImmediatelyKey!);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? ExpandToHdr {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.ExpandToHdrKey!);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public float? ContentHeadroom {
			get {
				return  GetFloatValue (CIImageInitializationOptionsKeys.ContentHeadroomKey!);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float? ContentAverageLightLevel {
			get {
				return  GetFloatValue (CIImageInitializationOptionsKeys.ContentAverageLightLevelKey!);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public bool? ApplyCleanAperture {
			get {
				return  GetBoolValue (CIImageInitializationOptionsKeys.ApplyCleanApertureKey!);
			}
		}
#endif
	}
}
