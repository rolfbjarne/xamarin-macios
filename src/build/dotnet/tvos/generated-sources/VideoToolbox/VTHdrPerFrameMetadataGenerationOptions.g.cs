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
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public partial class VTHdrPerFrameMetadataGenerationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTHdrPerFrameMetadataGenerationOptions" /> with default (empty) values.</summary>
		public VTHdrPerFrameMetadataGenerationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTHdrPerFrameMetadataGenerationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTHdrPerFrameMetadataGenerationOptions (NSDictionary? dictionary) : base (dictionary) {}
		public VTHdrPerFrameMetadataGenerationHdrFormatType? HdrFormats {
			get {
				return TryGetNativeValue (VTHdrPerFrameMetadataGenerationOptionsKey.HdrFormats!, out var handle) ? global::VideoToolbox.VTHdrPerFrameMetadataGenerationHdrFormatTypeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (VTHdrPerFrameMetadataGenerationOptionsKey.HdrFormats!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
#endif
	}
}
