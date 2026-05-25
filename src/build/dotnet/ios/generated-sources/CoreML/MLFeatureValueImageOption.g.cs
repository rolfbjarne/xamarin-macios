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
namespace CoreML {
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class MLFeatureValueImageOption : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="MLFeatureValueImageOption" /> with default (empty) values.</summary>
		public MLFeatureValueImageOption () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="MLFeatureValueImageOption" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public MLFeatureValueImageOption (NSDictionary? dictionary) : base (dictionary) {}
		public CGRect? CropRect {
			get {
				return  GetCGRectValue (MLFeatureValueImageOptionKeys.CropRectKey!);
			}
			set {
				SetCGRectValue (MLFeatureValueImageOptionKeys.CropRectKey!, value);
			}
		}
		public global::Vision.VNImageCropAndScaleOption? CropAndScale {
			get {
				return (global::Vision.VNImageCropAndScaleOption?) (ulong?) GetNUIntValue (MLFeatureValueImageOptionKeys.CropAndScaleKey!);
			}
			set {
				SetNumberValue (MLFeatureValueImageOptionKeys.CropAndScaleKey!, (System.UInt64?)value);
			}
		}
#endif
	}
}
