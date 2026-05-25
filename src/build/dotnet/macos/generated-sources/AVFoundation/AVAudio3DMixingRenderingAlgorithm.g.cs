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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	/// <summary>Enumerates valid 3D audio-rendering algorithms.</summary><remarks>To be added.</remarks>
	[Native]
	public enum AVAudio3DMixingRenderingAlgorithm : long {
		/// <summary>Pans the mixer bus into a stereo field.</summary>
		EqualPowerPanning = 0,
		/// <summary>An algorithm best used for headphones; lower quality but lower processor-intensity than <see cref="F:AVFoundation.AVAudio3DMixingRenderingAlgorithm.HRTF" />.</summary>
		SphericalHead = 1,
		/// <summary>A processor-intensive Head-Related Transfer Function algorithm best used for emulating 3D space with headphones. (See also <see cref="F:AVFoundation.AVAudio3DMixingRenderingAlgorithm.SphericalHead" />)</summary>
		HRTF = 2,
		/// <summary>Renders on all output channels, but weights towards an origin. Best used for ambient sounds. </summary>
		SoundField = 3,
		/// <summary>No localization is performed on the input data.</summary>
		StereoPassThrough = 5,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HrtfHQ = 6,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Auto = 7,
	}
}
