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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreGraphics {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public partial class CGToneMappingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGToneMappingOptions" /> with default (empty) values.</summary>
		public CGToneMappingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGToneMappingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGToneMappingOptions (NSDictionary? dictionary) : base (dictionary) {}
		public bool? Use100nitsHlgOotf {
			get {
				return  GetBoolValue (CGToneMappingOptionKeys.Use100nitsHlgOotfKey!);
			}
			set {
				SetBooleanValue (CGToneMappingOptionKeys.Use100nitsHlgOotfKey!, value);
			}
		}
		public bool? UseBT1886ForCoreVideoGamma {
			get {
				return  GetBoolValue (CGToneMappingOptionKeys.UseBT1886ForCoreVideoGammaKey!);
			}
			set {
				SetBooleanValue (CGToneMappingOptionKeys.UseBT1886ForCoreVideoGammaKey!, value);
			}
		}
		public bool? SkipBoostToHdr {
			get {
				return  GetBoolValue (CGToneMappingOptionKeys.SkipBoostToHdrKey!);
			}
			set {
				SetBooleanValue (CGToneMappingOptionKeys.SkipBoostToHdrKey!, value);
			}
		}
		public float? ExrToneMappingGammaDefog {
			get {
				return  GetFloatValue (CGToneMappingOptionKeys.ExrToneMappingGammaDefogKey!);
			}
			set {
				SetNumberValue (CGToneMappingOptionKeys.ExrToneMappingGammaDefogKey!, value);
			}
		}
		public float? ExrToneMappingGammaExposure {
			get {
				return  GetFloatValue (CGToneMappingOptionKeys.ExrToneMappingGammaExposureKey!);
			}
			set {
				SetNumberValue (CGToneMappingOptionKeys.ExrToneMappingGammaExposureKey!, value);
			}
		}
		public float? ExrToneMappingGammaKneeLow {
			get {
				return  GetFloatValue (CGToneMappingOptionKeys.ExrToneMappingGammaKneeLowKey!);
			}
			set {
				SetNumberValue (CGToneMappingOptionKeys.ExrToneMappingGammaKneeLowKey!, value);
			}
		}
		public float? ExrToneMappingGammaKneeHigh {
			get {
				return  GetFloatValue (CGToneMappingOptionKeys.ExrToneMappingGammaKneeHighKey!);
			}
			set {
				SetNumberValue (CGToneMappingOptionKeys.ExrToneMappingGammaKneeHighKey!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public CGDynamicRange? PreferredDynamicRange {
			get {
				return TryGetNativeValue (CGToneMappingOptionKeys.PreferredDynamicRangeKey!, out var handle) ? CGDynamicRangeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CGToneMappingOptionKeys.PreferredDynamicRangeKey!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public float? ContentAverageLightLevel {
			get {
				return  GetFloatValue (CGToneMappingOptionKeys.ContentAverageLightLevelKey!);
			}
			set {
				SetNumberValue (CGToneMappingOptionKeys.ContentAverageLightLevelKey!, value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public nint? ContentAverageLightLevelNits {
			get {
				return  GetNIntValue (CGToneMappingOptionKeys.ContentAverageLightLevelNitsKey!);
			}
		}
#endif
	}
}
