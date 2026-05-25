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
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public partial class VTCompressionPreset : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTCompressionPreset" /> with default (empty) values.</summary>
		public VTCompressionPreset () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTCompressionPreset" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTCompressionPreset (NSDictionary? dictionary) : base (dictionary) {}
		public NSDictionary? HighQuality {
			get {
				return GetNSDictionary (VTCompressionPresetKey.HighQuality!);
			}
		}
		public NSDictionary? Balanced {
			get {
				return GetNSDictionary (VTCompressionPresetKey.Balanced!);
			}
		}
		public NSDictionary? HighSpeed {
			get {
				return GetNSDictionary (VTCompressionPresetKey.HighSpeed!);
			}
		}
		public NSDictionary? VideoConferencing {
			get {
				return GetNSDictionary (VTCompressionPresetKey.VideoConferencing!);
			}
		}
#endif
	}
}
