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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AudioUnit {
	/// <summary>An enumeration whose values represent adjustable attributes such as pitch or volume.</summary>
	public enum AudioUnitParameterType : int {
		/// <summary>To be added.</summary>
		Mixer3DAzimuth = 0,
		/// <summary>To be added.</summary>
		Mixer3DElevation = 1,
		/// <summary>To be added.</summary>
		Mixer3DDistance = 2,
		/// <summary>To be added.</summary>
		Mixer3DGain = 3,
		/// <summary>To be added.</summary>
		Mixer3DPlaybackRate = 4,
		/// <summary>To be added.</summary>
		Mixer3DEnable = 5,
		/// <summary>To be added.</summary>
		Mixer3DMinGain = 6,
		/// <summary>To be added.</summary>
		Mixer3DMaxGain = 7,
		/// <summary>To be added.</summary>
		Mixer3DReverbBlend = 8,
		/// <summary>To be added.</summary>
		Mixer3DGlobalReverbGain = 9,
		/// <summary>To be added.</summary>
		Mixer3DOcclusionAttenuation = 10,
		/// <summary>To be added.</summary>
		Mixer3DObstructionAttenuation = 11,
		/// <summary>To be added.</summary>
		SpatialAzimuth = 0,
		/// <summary>To be added.</summary>
		SpatialElevation = 1,
		/// <summary>To be added.</summary>
		SpatialDistance = 2,
		/// <summary>To be added.</summary>
		SpatialGain = 3,
		/// <summary>To be added.</summary>
		SpatialPlaybackRate = 4,
		/// <summary>To be added.</summary>
		SpatialEnable = 5,
		/// <summary>To be added.</summary>
		SpatialMinGain = 6,
		/// <summary>To be added.</summary>
		SpatialMaxGain = 7,
		/// <summary>To be added.</summary>
		SpatialReverbBlend = 8,
		/// <summary>To be added.</summary>
		SpatialGlobalReverbGain = 9,
		/// <summary>To be added.</summary>
		SpatialOcclusionAttenuation = 10,
		/// <summary>To be added.</summary>
		SpatialObstructionAttenuation = 11,
		/// <summary>To be added.</summary>
		ReverbFilterFrequency = 14,
		/// <summary>To be added.</summary>
		ReverbFilterBandwidth = 15,
		/// <summary>To be added.</summary>
		ReverbFilterGain = 16,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ReverbFilterType = 17,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ReverbFilterEnable = 18,
		/// <summary>To be added.</summary>
		MultiChannelMixerVolume = 0,
		/// <summary>To be added.</summary>
		MultiChannelMixerEnable = 1,
		/// <summary>To be added.</summary>
		MultiChannelMixerPan = 2,
		/// <summary>To be added.</summary>
		MatrixMixerVolume = 0,
		/// <summary>To be added.</summary>
		MatrixMixerEnable = 1,
		/// <summary>To be added.</summary>
		HALOutputVolume = 14,
		/// <summary>To be added.</summary>
		TimePitchRate = 0,
		/// <summary>To be added.</summary>
		NewTimePitchRate = 0,
		/// <summary>To be added.</summary>
		NewTimePitchPitch = 1,
		/// <summary>To be added.</summary>
		NewTimePitchOverlap = 4,
		/// <summary>To be added.</summary>
		NewTimePitchEnablePeakLocking = 6,
		/// <summary>To be added.</summary>
		AUSamplerGain = 900,
		/// <summary>To be added.</summary>
		AUSamplerCoarseTuning = 901,
		/// <summary>To be added.</summary>
		AUSamplerFineTuning = 902,
		/// <summary>To be added.</summary>
		AUSamplerPan = 903,
		/// <summary>To be added.</summary>
		BandpassCenterFrequency = 0,
		/// <summary>To be added.</summary>
		BandpassBandwidth = 1,
		/// <summary>To be added.</summary>
		HipassCutoffFrequency = 0,
		/// <summary>To be added.</summary>
		HipassResonance = 1,
		/// <summary>To be added.</summary>
		LowPassCutoffFrequency = 0,
		/// <summary>To be added.</summary>
		LowPassResonance = 1,
		/// <summary>To be added.</summary>
		HighShelfCutOffFrequency = 0,
		/// <summary>To be added.</summary>
		HighShelfGain = 1,
		/// <summary>To be added.</summary>
		AULowShelfCutoffFrequency = 0,
		/// <summary>To be added.</summary>
		AULowShelfGain = 1,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("ios7.0")]
		[UnsupportedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		AUDCFilterDecayTime = 0,
		/// <summary>To be added.</summary>
		ParametricEQCenterFreq = 0,
		/// <summary>To be added.</summary>
		ParametricEQQ = 1,
		/// <summary>To be added.</summary>
		ParametricEQGain = 2,
		/// <summary>To be added.</summary>
		LimiterAttackTime = 0,
		/// <summary>To be added.</summary>
		LimiterDecayTime = 1,
		/// <summary>To be added.</summary>
		LimiterPreGain = 2,
		/// <summary>To be added.</summary>
		DynamicsProcessorThreshold = 0,
		/// <summary>To be added.</summary>
		DynamicsProcessorHeadRoom = 1,
		/// <summary>To be added.</summary>
		DynamicsProcessorExpansionRatio = 2,
		/// <summary>To be added.</summary>
		DynamicsProcessorExpansionThreshold = 3,
		/// <summary>To be added.</summary>
		DynamicsProcessorAttackTime = 4,
		/// <summary>To be added.</summary>
		DynamicsProcessorReleaseTime = 5,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios15.0", "Use 'DynamicsProcessorOverallGain' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'DynamicsProcessorOverallGain' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'DynamicsProcessorOverallGain' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'DynamicsProcessorOverallGain' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		DynamicsProcessorMasterGain = 6,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		DynamicsProcessorOverallGain = 6,
		/// <summary>To be added.</summary>
		DynamicsProcessorCompressionAmount = 1000,
		/// <summary>To be added.</summary>
		DynamicsProcessorInputAmplitude = 2000,
		/// <summary>To be added.</summary>
		DynamicsProcessorOutputAmplitude = 3000,
		/// <summary>To be added.</summary>
		VarispeedPlaybackRate = 0,
		/// <summary>To be added.</summary>
		VarispeedPlaybackCents = 1,
		/// <summary>To be added.</summary>
		DistortionDelay = 0,
		/// <summary>To be added.</summary>
		DistortionDecay = 1,
		/// <summary>To be added.</summary>
		DistortionDelayMix = 2,
		/// <summary>To be added.</summary>
		DistortionDecimation = 3,
		/// <summary>To be added.</summary>
		DistortionRounding = 4,
		/// <summary>To be added.</summary>
		DistortionDecimationMix = 5,
		/// <summary>To be added.</summary>
		DistortionLinearTerm = 6,
		/// <summary>To be added.</summary>
		DistortionSquaredTerm = 7,
		/// <summary>To be added.</summary>
		DistortionCubicTerm = 8,
		/// <summary>To be added.</summary>
		DistortionPolynomialMix = 9,
		/// <summary>To be added.</summary>
		DistortionRingModFreq1 = 10,
		/// <summary>To be added.</summary>
		DistortionRingModFreq2 = 11,
		/// <summary>To be added.</summary>
		DistortionRingModBalance = 12,
		/// <summary>To be added.</summary>
		DistortionRingModMix = 13,
		/// <summary>To be added.</summary>
		DistortionSoftClipGain = 14,
		/// <summary>To be added.</summary>
		DistortionFinalMix = 15,
		/// <summary>To be added.</summary>
		DelayWetDryMix = 0,
		/// <summary>To be added.</summary>
		DelayTime = 1,
		/// <summary>To be added.</summary>
		DelayFeedback = 2,
		/// <summary>To be added.</summary>
		DelayLopassCutoff = 3,
		/// <summary>To be added.</summary>
		AUNBandEQGlobalGain = 0,
		/// <summary>To be added.</summary>
		AUNBandEQBypassBand = 1000,
		/// <summary>To be added.</summary>
		AUNBandEQFilterType = 2000,
		/// <summary>To be added.</summary>
		AUNBandEQFrequency = 3000,
		/// <summary>To be added.</summary>
		AUNBandEQGain = 4000,
		/// <summary>To be added.</summary>
		AUNBandEQBandwidth = 5000,
		/// <summary>To be added.</summary>
		RandomBoundA = 0,
		/// <summary>To be added.</summary>
		RandomBoundB = 1,
		/// <summary>To be added.</summary>
		RandomCurve = 2,
		/// <summary>To be added.</summary>
		Reverb2DryWetMix = 0,
		/// <summary>To be added.</summary>
		Reverb2Gain = 1,
		/// <summary>To be added.</summary>
		Reverb2MinDelayTime = 2,
		/// <summary>To be added.</summary>
		Reverb2MaxDelayTime = 3,
		/// <summary>To be added.</summary>
		Reverb2DecayTimeAt0Hz = 4,
		/// <summary>To be added.</summary>
		Reverb2DecayTimeAtNyquist = 5,
		/// <summary>To be added.</summary>
		Reverb2RandomizeReflections = 6,
		/// <summary>To be added.</summary>
		RoundTripAacFormat = 0,
		/// <summary>To be added.</summary>
		RoundTripAacEncodingStrategy = 1,
		/// <summary>To be added.</summary>
		RoundTripAacRateOrQuality = 2,
		/// <summary>To be added.</summary>
		SpacialMixerAzimuth = 0,
		/// <summary>To be added.</summary>
		Elevation = 1,
		/// <summary>To be added.</summary>
		Distance = 2,
		/// <summary>To be added.</summary>
		Gain = 3,
		/// <summary>To be added.</summary>
		PlaybackRate = 4,
		/// <summary>To be added.</summary>
		Enable = 5,
		/// <summary>To be added.</summary>
		MinGain = 6,
		/// <summary>To be added.</summary>
		MaxGain = 7,
		/// <summary>To be added.</summary>
		ReverbBlend = 8,
		/// <summary>To be added.</summary>
		GlobalReverbGain = 9,
		/// <summary>To be added.</summary>
		OcclussionAttenuation = 10,
		/// <summary>To be added.</summary>
		ObstructionAttenuation = 11,
	}
}
