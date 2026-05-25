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
namespace PdfKit {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos18.2")]
	public partial class PdfPageImageInitializationOption : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="PdfPageImageInitializationOption" /> with default (empty) values.</summary>
		public PdfPageImageInitializationOption () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="PdfPageImageInitializationOption" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public PdfPageImageInitializationOption (NSDictionary? dictionary) : base (dictionary) {}
		public CGRect? MediaBox {
			get {
				return  GetCGRectValue (PdfPageImageInitializationOptionKeys.MediaBoxKey!);
			}
			set {
				SetCGRectValue (PdfPageImageInitializationOptionKeys.MediaBoxKey!, value);
			}
		}
		public int? Rotation {
			get {
				return  GetInt32Value (PdfPageImageInitializationOptionKeys.RotationKey!);
			}
			set {
				SetNumberValue (PdfPageImageInitializationOptionKeys.RotationKey!, value);
			}
		}
		public bool? UpscaleIfSmaller {
			get {
				return  GetBoolValue (PdfPageImageInitializationOptionKeys.UpscaleIfSmallerKey!);
			}
			set {
				SetBooleanValue (PdfPageImageInitializationOptionKeys.UpscaleIfSmallerKey!, value);
			}
		}
		public double? CompressionQuality {
			get {
				return  GetDoubleValue (PdfPageImageInitializationOptionKeys.CompressionQualityKey!);
			}
			set {
				SetNumberValue (PdfPageImageInitializationOptionKeys.CompressionQualityKey!, value);
			}
		}
#endif
	}
}
