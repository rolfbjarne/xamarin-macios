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
namespace AVFoundation {
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Native]
	[NativeName ("AVMIDIControlChangeMessageType")]
	public enum AVMidiControlChangeMessageType : long {
		BankSelect = 0,
		ModWheel = 1,
		Breath = 2,
		Foot = 4,
		PortamentoTime = 5,
		DataEntry = 6,
		Volume = 7,
		Balance = 8,
		Pan = 10,
		Expression = 11,
		Sustain = 64,
		Portamento = 65,
		Sostenuto = 66,
		Soft = 67,
		LegatoPedal = 68,
		Hold2Pedal = 69,
		FilterResonance = 71,
		ReleaseTime = 72,
		AttackTime = 73,
		Brightness = 74,
		DecayTime = 75,
		VibratoRate = 76,
		VibratoDepth = 77,
		VibratoDelay = 78,
		ReverbLevel = 91,
		ChorusLevel = 93,
		RpnLsb = 100,
		RpnMsb = 101,
		AllSoundOff = 120,
		ResetAllControllers = 121,
		AllNotesOff = 123,
		OmniModeOff = 124,
		OmniModeOn = 125,
		MonoModeOn = 126,
		MonoModeOff = 127,
	}
}
