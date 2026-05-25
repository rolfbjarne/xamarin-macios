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
namespace AudioUnit {
	/// <summary>The unit of measure used by an audio unit parameter.</summary>
	public enum AudioUnitParameterUnit : int {
		/// <summary>To be added.</summary>
		Generic = 0,
		/// <summary>To be added.</summary>
		Indexed = 1,
		/// <summary>To be added.</summary>
		Boolean = 2,
		/// <summary>To be added.</summary>
		Percent = 3,
		/// <summary>To be added.</summary>
		Seconds = 4,
		/// <summary>To be added.</summary>
		SampleFrames = 5,
		/// <summary>To be added.</summary>
		Phase = 6,
		/// <summary>To be added.</summary>
		Rate = 7,
		/// <summary>To be added.</summary>
		Hertz = 8,
		/// <summary>To be added.</summary>
		Cents = 9,
		/// <summary>To be added.</summary>
		RelativeSemiTones = 10,
		/// <summary>To be added.</summary>
		MIDINoteNumber = 11,
		/// <summary>To be added.</summary>
		MIDIController = 12,
		/// <summary>To be added.</summary>
		Decibels = 13,
		/// <summary>To be added.</summary>
		LinearGain = 14,
		/// <summary>To be added.</summary>
		Degrees = 15,
		/// <summary>To be added.</summary>
		EqualPowerCrossfade = 16,
		/// <summary>To be added.</summary>
		MixerFaderCurve1 = 17,
		/// <summary>To be added.</summary>
		Pan = 18,
		/// <summary>To be added.</summary>
		Meters = 19,
		/// <summary>To be added.</summary>
		AbsoluteCents = 20,
		/// <summary>To be added.</summary>
		Octaves = 21,
		/// <summary>To be added.</summary>
		BPM = 22,
		/// <summary>To be added.</summary>
		Beats = 23,
		/// <summary>To be added.</summary>
		Milliseconds = 24,
		/// <summary>To be added.</summary>
		Ratio = 25,
		/// <summary>To be added.</summary>
		CustomUnit = 26,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		MIDI2Controller = 27,
	}
}
