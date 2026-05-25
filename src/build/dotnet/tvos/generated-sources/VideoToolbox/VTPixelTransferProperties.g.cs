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
	/// <summary>Strongly typed set of options used by <see cref="P:VideoToolbox.VTDecompressionProperties.PixelTransferSettings" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTPixelTransferProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTPixelTransferProperties" /> with default (empty) values.</summary>
		public VTPixelTransferProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTPixelTransferProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTPixelTransferProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::AVFoundation.AVVideoCleanApertureSettings? DestinationCleanAperture {
			get {
				return GetStrongDictionary<AVVideoCleanApertureSettings>(VTPixelTransferPropertyKeys.DestinationCleanAperture!, (dict) => new AVVideoCleanApertureSettings (dict));
			}
			set {
				SetNativeValue (VTPixelTransferPropertyKeys.DestinationCleanAperture!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::AVFoundation.AVVideoPixelAspectRatioSettings? DestinationPixelAspectRatio {
			get {
				return GetStrongDictionary<AVVideoPixelAspectRatioSettings>(VTPixelTransferPropertyKeys.DestinationPixelAspectRatio!, (dict) => new AVVideoPixelAspectRatioSettings (dict));
			}
			set {
				SetNativeValue (VTPixelTransferPropertyKeys.DestinationPixelAspectRatio!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSData? DestinationICCProfile {
			get {
				return Dictionary [VTPixelTransferPropertyKeys.DestinationICCProfile!] as Foundation.NSData;
			}
			set {
				SetNativeValue (VTPixelTransferPropertyKeys.DestinationICCProfile!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? RealTime {
			get {
				return  GetBoolValue (VTPixelTransferPropertyKeys.RealTime!);
			}
			set {
				SetBooleanValue (VTPixelTransferPropertyKeys.RealTime!, value);
			}
		}
#endif
	}
}
