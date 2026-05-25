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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTSampleAttachments : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTSampleAttachments" /> with default (empty) values.</summary>
		public VTSampleAttachments () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTSampleAttachments" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTSampleAttachments (NSDictionary? dictionary) : base (dictionary) {}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSNumber? RequireLtrAcknowledgementToken {
			get {
				return Dictionary [VTSampleAttachmentKey.RequireLtrAcknowledgementToken!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (VTSampleAttachmentKey.RequireLtrAcknowledgementToken!, value);
			}
		}
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public VTSampleAttachmentQualityMetrics? QualityMetrics {
			get {
				return GetStrongDictionary<VTSampleAttachmentQualityMetrics>(VTSampleAttachmentKey.QualityMetrics!, (dict) => new VTSampleAttachmentQualityMetrics (dict));
			}
		}
#endif
	}
}
