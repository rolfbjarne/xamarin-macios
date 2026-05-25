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
namespace Vision {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> holding options to be used in Vision queries.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VNImageOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VNImageOptions" /> with default (empty) values.</summary>
		public VNImageOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VNImageOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VNImageOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? WeakProperties {
			get {
				return GetNSDictionary (VNImageOptionKeys.PropertiesKey!);
			}
			set {
				SetNativeValue (VNImageOptionKeys.PropertiesKey!, value);
			}
		}
		/// <summary>Gets or sets the <see cref="T:CoreGraphics.CGImageProperties" /> used with the <see cref="T:Vision.VNImageRequestHandler" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImageProperties? Properties {
			get {
				return GetStrongDictionary<CGImageProperties>(VNImageOptionKeys.PropertiesKey!, (dict) => new CGImageProperties (dict));
			}
			set {
				SetNativeValue (VNImageOptionKeys.PropertiesKey!, value?.Dictionary);
			}
		}
		/// <summary>Gets or sets the camera intrinsic data, used in camera calibration.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? CameraIntrinsics {
			get {
				return Dictionary [VNImageOptionKeys.CameraIntrinsicsKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (VNImageOptionKeys.CameraIntrinsicsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::CoreImage.CIContext? CIContext {
			get {
				return Dictionary [VNImageOptionKeys.CIContextKey!] as CoreImage.CIContext;
			}
			set {
				SetNativeValue (VNImageOptionKeys.CIContextKey!, value);
			}
		}
#endif
	}
}
