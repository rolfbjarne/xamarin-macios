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
namespace AudioUnit {
	public enum AUSpatializationAlgorithm : uint {
		/// <summary>To be added.</summary>
		EqualPowerPanning = 0,
		/// <summary>To be added.</summary>
		SphericalHead = 1,
		/// <summary>To be added.</summary>
		Hrtf = 2,
		/// <summary>To be added.</summary>
		SoundField = 3,
		/// <summary>To be added.</summary>
		VectorBasedPanning = 4,
		/// <summary>To be added.</summary>
		StereoPassThrough = 5,
		/// <summary>To be added.</summary>
		HrtfHQ = 6,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		UseOutputType = 7,
	}
}
