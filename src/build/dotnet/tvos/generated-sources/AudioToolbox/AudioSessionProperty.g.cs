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
namespace AudioToolbox {
	/// <summary>An enumeration whose values specify properties for audio sessions.</summary>
	public enum AudioSessionProperty : int {
		/// <summary>To be added.</summary>
		PreferredHardwareSampleRate = 1752658802,
		/// <summary>To be added.</summary>
		PreferredHardwareIOBufferDuration = 1768907364,
		/// <summary>To be added.</summary>
		AudioCategory = 1633902964,
		/// <summary>Developers should not use this deprecated field. </summary>
		[ObsoletedOSPlatform ("ios5.0")]
		[ObsoletedOSPlatform ("macos10.7")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		AudioRoute = 1919907188,
		/// <summary>To be added.</summary>
		AudioRouteChange = 1919902568,
		/// <summary>To be added.</summary>
		CurrentHardwareSampleRate = 1667789682,
		/// <summary>To be added.</summary>
		CurrentHardwareInputNumberChannels = 1667787107,
		/// <summary>To be added.</summary>
		CurrentHardwareOutputNumberChannels = 1667788643,
		/// <summary>To be added.</summary>
		CurrentHardwareOutputVolume = 1667788662,
		/// <summary>To be added.</summary>
		CurrentHardwareInputLatency = 1667853428,
		/// <summary>To be added.</summary>
		CurrentHardwareOutputLatency = 1668246644,
		/// <summary>To be added.</summary>
		CurrentHardwareIOBufferDuration = 1667785316,
		/// <summary>To be added.</summary>
		OtherAudioIsPlaying = 1869899890,
		/// <summary>To be added.</summary>
		OverrideAudioRoute = 1870033508,
		/// <summary>To be added.</summary>
		AudioInputAvailable = 1634296182,
		/// <summary>To be added.</summary>
		ServerDied = 1684628836,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.9")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		OtherMixableAudioShouldDuck = 1685414763,
		/// <summary>To be added.</summary>
		OverrideCategoryMixWithOthers = 1668114808,
		/// <summary>To be added.</summary>
		OverrideCategoryDefaultToSpeaker = 1668509803,
		/// <summary>To be added.</summary>
		OverrideCategoryEnableBluetoothInput = 1667394677,
		/// <summary>To be added.</summary>
		InterruptionType = 1954115685,
		/// <summary>To be added.</summary>
		Mode = 1836016741,
		/// <summary>To be added.</summary>
		InputSources = 1936876403,
		/// <summary>To be added.</summary>
		OutputDestinations = 1685288051,
		/// <summary>To be added.</summary>
		InputSource = 1769173603,
		/// <summary>To be added.</summary>
		OutputDestination = 1868854132,
		/// <summary>To be added.</summary>
		InputGainAvailable = 1768382838,
		/// <summary>To be added.</summary>
		InputGainScalar = 1768387427,
		/// <summary>To be added.</summary>
		AudioRouteDescription = 1668440434,
	}
}
