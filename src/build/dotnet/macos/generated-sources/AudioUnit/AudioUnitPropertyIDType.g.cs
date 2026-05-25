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
	/// <summary>An enumeration whose values specify a kind of <see cref="T:AudioUnit.AudioUnit" />.</summary>
	internal enum AudioUnitPropertyIDType : int {
		/// <summary>To be added.</summary>
		ClassInfo = 0,
		/// <summary>To be added.</summary>
		MakeConnection = 1,
		/// <summary>To be added.</summary>
		SampleRate = 2,
		/// <summary>To be added.</summary>
		ParameterList = 3,
		/// <summary>To be added.</summary>
		ParameterInfo = 4,
		/// <summary>To be added.</summary>
		CPULoad = 6,
		/// <summary>To be added.</summary>
		StreamFormat = 8,
		/// <summary>To be added.</summary>
		ElementCount = 11,
		/// <summary>To be added.</summary>
		Latency = 12,
		/// <summary>To be added.</summary>
		SupportedNumChannels = 13,
		/// <summary>To be added.</summary>
		MaximumFramesPerSlice = 14,
		/// <summary>To be added.</summary>
		ParameterValueStrings = 16,
		/// <summary>To be added.</summary>
		AudioChannelLayout = 19,
		/// <summary>To be added.</summary>
		TailTime = 20,
		/// <summary>To be added.</summary>
		BypassEffect = 21,
		/// <summary>To be added.</summary>
		LastRenderError = 22,
		/// <summary>To be added.</summary>
		SetRenderCallback = 23,
		/// <summary>To be added.</summary>
		FactoryPresets = 24,
		/// <summary>To be added.</summary>
		RenderQuality = 26,
		/// <summary>To be added.</summary>
		HostCallbacks = 27,
		/// <summary>To be added.</summary>
		InPlaceProcessing = 29,
		/// <summary>To be added.</summary>
		ElementName = 30,
		/// <summary>To be added.</summary>
		SupportedChannelLayoutTags = 32,
		/// <summary>To be added.</summary>
		PresentPreset = 36,
		/// <summary>To be added.</summary>
		DependentParameters = 45,
		/// <summary>To be added.</summary>
		InputSampleInOutput = 49,
		/// <summary>To be added.</summary>
		ShouldAllocateBuffer = 51,
		/// <summary>To be added.</summary>
		FrequencyResponse = 52,
		/// <summary>To be added.</summary>
		ParameterHistoryInfo = 53,
		/// <summary>To be added.</summary>
		Nickname = 54,
		/// <summary>To be added.</summary>
		OfflineRender = 37,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ParameterIDName = 34,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ParameterStringFromValue = 33,
		/// <summary>To be added.</summary>
		ParameterClumpName = 35,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ParameterValueFromString = 38,
		/// <summary>To be added.</summary>
		ContextName = 25,
		/// <summary>To be added.</summary>
		PresentationLatency = 40,
		/// <summary>To be added.</summary>
		ClassInfoFromDocument = 50,
		/// <summary>To be added.</summary>
		RequestViewController = 56,
		/// <summary>To be added.</summary>
		ParametersForOverview = 57,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SupportsMpe = 58,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		LastRenderSampleTime = 61,
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		LoadedOutOfProcess = 62,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		MIDIOutputEventListCallback = 63,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AudioUnitMIDIProtocol = 64,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		HostMIDIProtocol = 65,
		/// <summary>To be added.</summary>
		FastDispatch = 5,
		/// <summary>To be added.</summary>
		SetExternalBuffer = 15,
		/// <summary>To be added.</summary>
		GetUIComponentList = 18,
		/// <summary>To be added.</summary>
		CocoaUI = 31,
		/// <summary>To be added.</summary>
		IconLocation = 39,
		/// <summary>To be added.</summary>
		AUHostIdentifier = 46,
		/// <summary>To be added.</summary>
		MIDIOutputCallbackInfo = 47,
		/// <summary>To be added.</summary>
		MIDIOutputCallback = 48,
		/// <summary>To be added.</summary>
		IsRunning = 2001,
		/// <summary>To be added.</summary>
		AllParameterMIDIMappings = 41,
		/// <summary>To be added.</summary>
		AddParameterMIDIMapping = 42,
		/// <summary>To be added.</summary>
		RemoveParameterMIDIMapping = 43,
		/// <summary>To be added.</summary>
		HotMapParameterMIDIMapping = 44,
		/// <summary>To be added.</summary>
		MIDIXMLNames = 1006,
		/// <summary>To be added.</summary>
		PartGroup = 1010,
		/// <summary>To be added.</summary>
		DualSchedulingMode = 1013,
		/// <summary>To be added.</summary>
		SupportsStartStopNote = 1014,
		/// <summary>To be added.</summary>
		InputSize = 3020,
		/// <summary>To be added.</summary>
		OutputSize = 3021,
		/// <summary>To be added.</summary>
		StartOffset = 3022,
		/// <summary>To be added.</summary>
		PreflightRequirements = 3023,
		/// <summary>To be added.</summary>
		PreflightName = 3024,
		/// <summary>To be added.</summary>
		FromPlugin = 4000,
		/// <summary>To be added.</summary>
		OldAutomation = 4001,
		/// <summary>To be added.</summary>
		SampleRateConverterComplexity = 3014,
		/// <summary>To be added.</summary>
		CurrentDevice = 2000,
		/// <summary>To be added.</summary>
		ChannelMap = 2002,
		/// <summary>To be added.</summary>
		EnableIO = 2003,
		/// <summary>To be added.</summary>
		StartTime = 2004,
		/// <summary>To be added.</summary>
		SetInputCallback = 2005,
		/// <summary>To be added.</summary>
		HasIO = 2006,
		/// <summary>To be added.</summary>
		StartTimestampsAtZero = 2007,
		/// <summary>To be added.</summary>
		BypassVoiceProcessing = 2100,
		/// <summary>To be added.</summary>
		VoiceProcessingEnableAGC = 2101,
		/// <summary>To be added.</summary>
		MuteOutput = 2104,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		MutedSpeechActivityEventListener = 2106,
		/// <summary>To be added.</summary>
		NumberOfBands = 2200,
		/// <summary>To be added.</summary>
		MaxNumberOfBands = 2201,
		/// <summary>To be added.</summary>
		BiquadCoefficients = 2203,
		/// <summary>To be added.</summary>
		MeteringMode = 3007,
		/// <summary>To be added.</summary>
		MatrixLevels = 3006,
		/// <summary>To be added.</summary>
		MatrixDimensions = 3009,
		/// <summary>To be added.</summary>
		MeterClipping = 3011,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		InputAnchorTimeStamp = 3016,
		/// <summary>To be added.</summary>
		ReverbRoomType = 10,
		/// <summary>To be added.</summary>
		UsesInternalReverb = 1005,
		/// <summary>To be added.</summary>
		SpatializationAlgorithm = 3000,
		SpatialMixerRenderingFlags = 3003,
		SpatialMixerSourceMode = 3005,
		SpatialMixerDistanceParams = 3010,
		/// <summary>To be added.</summary>
		[Obsolete ("Use 'SpatialMixerDistanceParams' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		DistanceParams = 3010,
		/// <summary>Developers should not use this deprecated field. </summary>
		[Obsolete ("Use 'SpatialMixerAttenuationCurve' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		AttenuationCurve = 3013,
		/// <summary>To be added.</summary>
		[Obsolete ("Use 'SpatialMixerRenderingFlags' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		RenderingFlags = 3003,
		SpatialMixerAttenuationCurve = 3013,
		SpatialMixerOutputType = 3100,
		SpatialMixerPointSourceInHeadMode = 3103,
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		SpatialMixerEnableHeadTracking = 3111,
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		SpatialMixerPersonalizedHrtfMode = 3113,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		SpatialMixerAnyInputIsUsingPersonalizedHrtf = 3116,
		/// <summary>To be added.</summary>
		ScheduleAudioSlice = 3300,
		/// <summary>To be added.</summary>
		ScheduleStartTimeStamp = 3301,
		/// <summary>To be added.</summary>
		CurrentPlayTime = 3302,
		/// <summary>To be added.</summary>
		ScheduledFileIDs = 3310,
		/// <summary>To be added.</summary>
		ScheduledFileRegion = 3311,
		/// <summary>To be added.</summary>
		ScheduledFilePrime = 3312,
		/// <summary>To be added.</summary>
		ScheduledFileBufferSizeFrames = 3313,
		/// <summary>To be added.</summary>
		ScheduledFileNumberBuffers = 3314,
		/// <summary>To be added.</summary>
		SoundBankData = 1008,
		/// <summary>To be added.</summary>
		StreamFromDisk = 1011,
		/// <summary>To be added.</summary>
		SoundBankFSRef = 1012,
		/// <summary>To be added.</summary>
		InstrumentName = 1001,
		/// <summary>To be added.</summary>
		InstrumentNumber = 1004,
		/// <summary>To be added.</summary>
		InstrumentCount = 1000,
		/// <summary>To be added.</summary>
		BankName = 1007,
		/// <summary>To be added.</summary>
		SoundBankURL = 1100,
		/// <summary>To be added.</summary>
		MidiSynthEnablePreload = 4119,
		/// <summary>To be added.</summary>
		LoadInstrument = 4102,
		/// <summary>To be added.</summary>
		LoadAudioFiles = 4101,
		/// <summary>To be added.</summary>
		DeferredRendererPullSize = 3320,
		/// <summary>To be added.</summary>
		DeferredRendererExtraLatency = 3321,
		/// <summary>To be added.</summary>
		DeferredRendererWaitFrames = 3322,
		/// <summary>To be added.</summary>
		Hostname = 3511,
		/// <summary>To be added.</summary>
		NetReceivePassword = 3512,
		/// <summary>To be added.</summary>
		PortNum = 3513,
		/// <summary>To be added.</summary>
		TransmissionFormat = 3514,
		/// <summary>To be added.</summary>
		TransmissionFormatIndex = 3515,
		/// <summary>To be added.</summary>
		ServiceName = 3516,
		/// <summary>To be added.</summary>
		Disconnect = 3517,
		/// <summary>To be added.</summary>
		NetSendPassword = 3518,
	}
}
