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
namespace AudioUnit {
	public enum AudioUnitSubType : uint {
		/// <summary>To be added.</summary>
		AUConverter = 1668247158,
		/// <summary>To be added.</summary>
		Varispeed = 1986097769,
		/// <summary>To be added.</summary>
		DeferredRenderer = 1684366962,
		/// <summary>To be added.</summary>
		Splitter = 1936747636,
		/// <summary>To be added.</summary>
		MultiSplitter = 1836281964,
		/// <summary>To be added.</summary>
		Merger = 1835364967,
		/// <summary>To be added.</summary>
		NewTimePitch = 1853191280,
		/// <summary>To be added.</summary>
		AUiPodTimeOther = 1768977519,
		/// <summary>To be added.</summary>
		RoundTripAac = 1918984547,
		/// <summary>To be added.</summary>
		GenericOutput = 1734700658,
		/// <summary>To be added.</summary>
		VoiceProcessingIO = 1987078511,
		/// <summary>To be added.</summary>
		Sampler = 1935764848,
		/// <summary>To be added.</summary>
		MidiSynth = 1836284270,
		/// <summary>To be added.</summary>
		PeakLimiter = 1819112562,
		/// <summary>To be added.</summary>
		DynamicsProcessor = 1684237680,
		/// <summary>To be added.</summary>
		LowPassFilter = 1819304307,
		/// <summary>To be added.</summary>
		HighPassFilter = 1752195443,
		/// <summary>To be added.</summary>
		BandPassFilter = 1651532147,
		/// <summary>To be added.</summary>
		HighShelfFilter = 1752393830,
		/// <summary>To be added.</summary>
		LowShelfFilter = 1819502694,
		/// <summary>To be added.</summary>
		ParametricEQ = 1886217585,
		/// <summary>To be added.</summary>
		Distortion = 1684632436,
		/// <summary>To be added.</summary>
		Delay = 1684368505,
		/// <summary>To be added.</summary>
		SampleDelay = 1935961209,
		/// <summary>To be added.</summary>
		NBandEQ = 1851942257,
		/// <summary>To be added.</summary>
		MultiChannelMixer = 1835232632,
		/// <summary>To be added.</summary>
		MatrixMixer = 1836608888,
		/// <summary>To be added.</summary>
		SpatialMixer = 862217581,
		/// <summary>To be added.</summary>
		ScheduledSoundPlayer = 1936945260,
		/// <summary>To be added.</summary>
		AudioFilePlayer = 1634103404,
		/// <summary>A light reverb.</summary>
		Reverb2 = 1920361010,
		/// <summary>An audio unit that can be used to isolate a sound type.</summary>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		AUSoundIsolation = 1987012979,
		/// <summary>An audio unit that supports AudioMix separate-and-remix.</summary>
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		AUAudioMix = 1634560376,
	}
}
