//
// AUEnums.cs: AudioUnit enumerations
//
// Authors:
//   AKIHIRO Uehara (u-akihiro@reinforce-lab.com)
//   Marek Safar (marek.safar@gmail.com)
//
// Copyright 2010 Reinforce Lab.
// Copyright 2011-2013 Xamarin Inc
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using AudioToolbox;
using CoreFoundation;

#nullable enable

namespace AudioUnit {
	/// <summary>An enumeration whose values specify the status of an <see cref="AudioUnit" />.</summary>
	public enum AudioUnitStatus { // Implictly cast to OSType
		/// <summary>No Error.</summary>
		NoError = 0,
		/// <summary>O K.</summary>
		OK = NoError,
		/// <summary>File Not Found.</summary>
		FileNotFound = -43,
		/// <summary>Parameter Error.</summary>
		ParameterError = -50,
		/// <summary>Invalid Property.</summary>
		InvalidProperty = -10879,
		/// <summary>Invalid Parameter.</summary>
		InvalidParameter = -10878,
		/// <summary>Invalid Element.</summary>
		InvalidElement = -10877,
		/// <summary>No Connection.</summary>
		NoConnection = -10876,
		/// <summary>Failed Initialization.</summary>
		FailedInitialization = -10875,
		/// <summary>Too Many Frames To Process.</summary>
		TooManyFramesToProcess = -10874,
		/// <summary>Invalid File.</summary>
		InvalidFile = -10871,
		/// <summary>Format Not Supported.</summary>
		FormatNotSupported = -10868,
		/// <summary>Uninitialized.</summary>
		Uninitialized = -10867,
		/// <summary>Invalid Scope.</summary>
		InvalidScope = -10866,
		/// <summary>Property Not Writable.</summary>
		PropertyNotWritable = -10865,
		/// <summary>Cannot Do In Current Context.</summary>
		CannotDoInCurrentContext = -10863,
		/// <summary>Invalid Property Value.</summary>
		InvalidPropertyValue = -10851,
		/// <summary>Property Not In Use.</summary>
		PropertyNotInUse = -10850,
		/// <summary>Initialized.</summary>
		Initialized = -10849,
		/// <summary>Invalid Offline Render.</summary>
		InvalidOfflineRender = -10848,
		/// <summary>Unauthorized.</summary>
		Unauthorized = -10847,
		/// <summary>Midi Output Buffer Full.</summary>
		MidiOutputBufferFull = -66753,
		RenderTimeout = -66745,
		/// <summary>Invalid Parameter Value.</summary>
		InvalidParameterValue = -66743,
		/// <summary>Extension Not Found.</summary>
		ExtensionNotFound = -66744,
		InvalidFilePath = -66742,
		MissingKey = -66741,
		ComponentManagerNotSupported = -66740,
		MultipleVoiceProcessors = -66635,
	}

#if !__MACOS__
	/// <summary>Enumerates status values returned by <see cref="AudioUnit.AudioOutputUnitPublish(AudioComponentDescription,System.String,System.UInt32)" />.</summary>
#endif
	public enum AudioComponentStatus { // Implictly cast to OSType
		/// <summary>O K.</summary>
		OK = 0,
		/// <summary>Duplicate Description.</summary>
		DuplicateDescription = -66752,
		/// <summary>Unsupported Type.</summary>
		UnsupportedType = -66751,
		/// <summary>Too Many Instances.</summary>
		TooManyInstances = -66750,
		InstanceTimedOut = -66754,
		/// <summary>Instance Invalidated.</summary>
		InstanceInvalidated = -66749,
		/// <summary>Not Permitted.</summary>
		NotPermitted = -66748,
		/// <summary>Initialization Timed Out.</summary>
		InitializationTimedOut = -66747,
		/// <summary>Invalid Format.</summary>
		InvalidFormat = -66746,
		/// <summary>Render Timeout.</summary>
		[MacCatalyst (13, 1)]
		RenderTimeout = -66745,
	}

	/// <summary>An enumeration whose values specify whether to use a hardware or software encoder.</summary>
	public enum AudioCodecManufacturer : uint  // Implictly cast to OSType in CoreAudio.framework - CoreAudioTypes.h
	{
		/// <summary>Apple Software.</summary>
		AppleSoftware = 0x6170706c, // 'appl'
		/// <summary>Apple Hardware.</summary>
		AppleHardware = 0x61706877, // 'aphw'
	}

	/// <summary>Enumerates instrument types.</summary>
	public enum InstrumentType : byte // UInt8 in AUSamplerInstrumentData
	{
		/// <summary>D L S Preset.</summary>
		DLSPreset = 1,
		/// <summary>S F2 Preset.</summary>
		SF2Preset = DLSPreset,
		/// <summary>A U Preset.</summary>
		AUPreset = 2,
		/// <summary>Audiofile.</summary>
		Audiofile = 3,
		/// <summary>E X S24.</summary>
		EXS24 = 4,
	}

	/// <summary>The unit of measure used by an audio unit parameter.</summary>
	public enum AudioUnitParameterUnit // UInt32 AudioUnitParameterUnit
	{
		/// <summary>Generic.</summary>
		Generic = 0,
		/// <summary>Indexed.</summary>
		Indexed = 1,
		/// <summary>Boolean.</summary>
		Boolean = 2,
		/// <summary>Percent.</summary>
		Percent = 3,
		/// <summary>Seconds.</summary>
		Seconds = 4,
		/// <summary>Sample Frames.</summary>
		SampleFrames = 5,
		/// <summary>Phase.</summary>
		Phase = 6,
		/// <summary>Rate.</summary>
		Rate = 7,
		/// <summary>Hertz.</summary>
		Hertz = 8,
		/// <summary>Cents.</summary>
		Cents = 9,
		/// <summary>Relative Semi Tones.</summary>
		RelativeSemiTones = 10,
		/// <summary>M I D I Note Number.</summary>
		MIDINoteNumber = 11,
		/// <summary>M I D I Controller.</summary>
		MIDIController = 12,
		/// <summary>Decibels.</summary>
		Decibels = 13,
		/// <summary>Linear Gain.</summary>
		LinearGain = 14,
		/// <summary>Degrees.</summary>
		Degrees = 15,
		/// <summary>Equal Power Crossfade.</summary>
		EqualPowerCrossfade = 16,
		/// <summary>Mixer Fader Curve1.</summary>
		MixerFaderCurve1 = 17,
		/// <summary>Pan.</summary>
		Pan = 18,
		/// <summary>Meters.</summary>
		Meters = 19,
		/// <summary>Absolute Cents.</summary>
		AbsoluteCents = 20,
		/// <summary>Octaves.</summary>
		Octaves = 21,
		/// <summary>B P M.</summary>
		BPM = 22,
		/// <summary>Beats.</summary>
		Beats = 23,
		/// <summary>Milliseconds.</summary>
		Milliseconds = 24,
		/// <summary>Ratio.</summary>
		Ratio = 25,
		/// <summary>Custom Unit.</summary>
		CustomUnit = 26,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		MIDI2Controller = 27,
	}

	/// <summary>Flagging enumeration used with <see cref="AudioUnitParameterInfo.Flags" />.</summary>
	[Flags]
	public enum AudioUnitParameterFlag : uint // UInt32 in AudioUnitParameterInfo
	{
		/// <summary>C F Name Release.</summary>
		CFNameRelease = (1 << 4),

		/// <summary>Omit From Presets.</summary>
		[MacCatalyst (13, 1)]
		OmitFromPresets = (1 << 13),
		/// <summary>Plot History.</summary>
		PlotHistory = (1 << 14),
		/// <summary>Meter Read Only.</summary>
		MeterReadOnly = (1 << 15),

		// bit positions 18,17,16 are set aside for display scales. bit 19 is reserved.
		/// <summary>Display Mask.</summary>
		DisplayMask = (7 << 16) | (1 << 22),
		/// <summary>Display Square Root.</summary>
		DisplaySquareRoot = (1 << 16),
		/// <summary>Display Squared.</summary>
		DisplaySquared = (2 << 16),
		/// <summary>Display Cubed.</summary>
		DisplayCubed = (3 << 16),
		/// <summary>Display Cube Root.</summary>
		DisplayCubeRoot = (4 << 16),
		/// <summary>Display Exponential.</summary>
		DisplayExponential = (5 << 16),

		/// <summary>Has Clump.</summary>
		HasClump = (1 << 20),
		/// <summary>Values Have Strings.</summary>
		ValuesHaveStrings = (1 << 21),

		/// <summary>Display Logarithmic.</summary>
		DisplayLogarithmic = (1 << 22),

		/// <summary>Is High Resolution.</summary>
		IsHighResolution = (1 << 23),
		/// <summary>Non Real Time.</summary>
		NonRealTime = (1 << 24),
		/// <summary>Can Ramp.</summary>
		CanRamp = (1 << 25),
		/// <summary>Expert Mode.</summary>
		ExpertMode = (1 << 26),
		/// <summary>Has C F Name String.</summary>
		HasCFNameString = (1 << 27),
		/// <summary>Is Global Meta.</summary>
		IsGlobalMeta = (1 << 28),
		/// <summary>Is Element Meta.</summary>
		IsElementMeta = (1 << 29),
		/// <summary>Is Readable.</summary>
		IsReadable = (1 << 30),
		/// <summary>Is Writable.</summary>
		IsWritable = ((uint) 1 << 31),
	}

	/// <summary>Enumerates values used by <see cref="AudioUnitParameterInfo" />. Currenty reserved for system use.</summary>
	public enum AudioUnitClumpID // UInt32 in AudioUnitParameterInfo
	{
		/// <summary>System.</summary>
		System = 0,
	}

	[MacCatalyst (13, 1)]
	[NoTV]
	[NoiOS]
	public enum AudioObjectPropertySelector : uint {
		/// <summary>Property Devices.</summary>
		PropertyDevices = 1684370979, // 'dev#'
		/// <summary>Devices.</summary>
		Devices = 1684370979, // 'dev#'
		/// <summary>Default Input Device.</summary>
		DefaultInputDevice = 1682533920, // 'dIn '
		/// <summary>Default Output Device.</summary>
		DefaultOutputDevice = 1682929012, // 'dOut'
		/// <summary>Default System Output Device.</summary>
		DefaultSystemOutputDevice = 1934587252, // 'sOut'
		/// <summary>Translate U I D To Device.</summary>
		TranslateUIDToDevice = 1969841252, // 'uidd'
		/// <summary>Mix Stereo To Mono.</summary>
		MixStereoToMono = 1937010031, // 'stmo'
		/// <summary>Plug In List.</summary>
		PlugInList = 1886152483, // 'plg#'
		/// <summary>Translate Bundle I D To Plug In.</summary>
		TranslateBundleIDToPlugIn = 1651074160, // 'bidp'
		/// <summary>Transport Manager List.</summary>
		TransportManagerList = 1953326883, // 'tmg#'
		/// <summary>Translate Bundle I D To Transport Manager.</summary>
		TranslateBundleIDToTransportManager = 1953325673, // 'tmbi'
		/// <summary>Box List.</summary>
		BoxList = 1651472419, // 'box#'
		/// <summary>Translate U I D To Box.</summary>
		TranslateUIDToBox = 1969841250, // 'uidb'
		ClockDeviceList = 1668049699, //'clk#'
		TranslateUidToClockDevice = 1969841251, // 'uidc',
#if !XAMCORE_5_0
		/// <summary>Process Is Master.</summary>
		[MacCatalyst (13, 1)] // This is required for .NET, because otherwise the generator thinks it's not available because it's not available on iOS.
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use the 'ProcessIsMain' element instead.")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use the 'ProcessIsMain' element instead.")]
		[Deprecated (PlatformName.MacCatalyst, 15, 0, message: "Use the 'ProcessIsMain' element instead.")]
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use the 'ProcessIsMain' element instead.")]
		[Obsolete ("Use the 'ProcessIsMain' element instead.")]
		ProcessIsMaster = 1835103092, // 'mast'
#endif // !XAMCORE_5_0
		[NoiOS]
		[MacCatalyst (15, 0), NoTV]
		ProcessIsMain = 1835100526, // 'main'
		/// <summary>Is Initing Or Exiting.</summary>
		IsInitingOrExiting = 1768845172, // 'inot'
		/// <summary>User I D Changed.</summary>
		UserIDChanged = 1702193508, // 'euid'
		/// <summary>Process Is Audible.</summary>
		ProcessIsAudible = 1886221684, // 'pmut'
		/// <summary>Sleeping Is Allowed.</summary>
		SleepingIsAllowed = 1936483696, // 'slep'
		/// <summary>Unloading Is Allowed.</summary>
		UnloadingIsAllowed = 1970170980, // 'unld'
		/// <summary>Hog Mode Is Allowed.</summary>
		HogModeIsAllowed = 1752131442, // 'hogr'
		/// <summary>User Session Is Active Or Headless.</summary>
		UserSessionIsActiveOrHeadless = 1970496882, // 'user'
		/// <summary>Service Restarted.</summary>
		ServiceRestarted = 1936880500, // 'srst'
		/// <summary>Power Hint.</summary>
		PowerHint = 1886353256, // 'powh'
		ActualSampleRate = 1634955892,// 'asrt',
		ClockDevice = 1634755428, // 'apcd',
		IOThreadOSWorkgroup = 1869838183, // 'oswg'
		[NoiOS]
		[MacCatalyst (15, 0), NoTV]
		ProcessMute = 1634758765, // 'appm'
		[MacCatalyst (17, 0), Mac (14, 0), NoTV]
		InputMute = 1852403056, //pmin
	}

	[MacCatalyst (13, 1)]
	[NoTV]
	[NoiOS]
	public enum AudioObjectPropertyScope : uint {
		/// <summary>Global.</summary>
		Global = 1735159650, // 'glob'
		/// <summary>Input.</summary>
		Input = 1768845428, // 'inpt'
		/// <summary>Output.</summary>
		Output = 1869968496, // 'outp'
		/// <summary>Play Through.</summary>
		PlayThrough = 1886679669, // 'ptru'
	}

	[MacCatalyst (13, 1)]
	[NoTV]
	[NoiOS]
	public enum AudioObjectPropertyElement : uint {
		/// <summary>Main.</summary>
		Main = 0, // 0
	}

	/// <summary>An enumeration whose values specify a kind of <see cref="AudioUnit" />.</summary>
	[Internal]
	enum AudioUnitPropertyIDType { // UInt32 AudioUnitPropertyID
								   // Audio Unit Properties
		/// <summary>Class Info.</summary>
		ClassInfo = 0,
		/// <summary>Make Connection.</summary>
		MakeConnection = 1,
		/// <summary>Sample Rate.</summary>
		SampleRate = 2,
		/// <summary>Parameter List.</summary>
		ParameterList = 3,
		/// <summary>Parameter Info.</summary>
		ParameterInfo = 4,
		/// <summary>C P U Load.</summary>
		CPULoad = 6,
		/// <summary>Stream Format.</summary>
		StreamFormat = 8,
		/// <summary>Element Count.</summary>
		ElementCount = 11,
		/// <summary>Latency.</summary>
		Latency = 12,
		/// <summary>Supported Num Channels.</summary>
		SupportedNumChannels = 13,
		/// <summary>Maximum Frames Per Slice.</summary>
		MaximumFramesPerSlice = 14,
		/// <summary>Parameter Value Strings.</summary>
		ParameterValueStrings = 16,
		/// <summary>Audio Channel Layout.</summary>
		AudioChannelLayout = 19,
		/// <summary>Tail Time.</summary>
		TailTime = 20,
		/// <summary>Bypass Effect.</summary>
		BypassEffect = 21,
		/// <summary>Last Render Error.</summary>
		LastRenderError = 22,
		/// <summary>Set Render Callback.</summary>
		SetRenderCallback = 23,
		/// <summary>Factory Presets.</summary>
		FactoryPresets = 24,
		/// <summary>Render Quality.</summary>
		RenderQuality = 26,
		/// <summary>Host Callbacks.</summary>
		HostCallbacks = 27,
		/// <summary>In Place Processing.</summary>
		InPlaceProcessing = 29,
		/// <summary>Element Name.</summary>
		ElementName = 30,
		/// <summary>Supported Channel Layout Tags.</summary>
		SupportedChannelLayoutTags = 32,
		/// <summary>Present Preset.</summary>
		PresentPreset = 36,
		/// <summary>Dependent Parameters.</summary>
		DependentParameters = 45,
		/// <summary>Input Sample In Output.</summary>
		InputSampleInOutput = 49,
		/// <summary>Should Allocate Buffer.</summary>
		ShouldAllocateBuffer = 51,
		/// <summary>Frequency Response.</summary>
		FrequencyResponse = 52,
		/// <summary>Parameter History Info.</summary>
		ParameterHistoryInfo = 53,
		/// <summary>Nickname.</summary>
		Nickname = 54,
		/// <summary>Offline Render.</summary>
		OfflineRender = 37,
		/// <summary>Parameter I D Name.</summary>
		[MacCatalyst (13, 1)]
		ParameterIDName = 34,
		/// <summary>Parameter String From Value.</summary>
		[MacCatalyst (13, 1)]
		ParameterStringFromValue = 33,
		/// <summary>Parameter Clump Name.</summary>
		ParameterClumpName = 35,
		/// <summary>Parameter Value From String.</summary>
		[MacCatalyst (13, 1)]
		ParameterValueFromString = 38,
		/// <summary>Context Name.</summary>
		ContextName = 25,
		/// <summary>Presentation Latency.</summary>
		PresentationLatency = 40,
		/// <summary>Class Info From Document.</summary>
		ClassInfoFromDocument = 50,
		/// <summary>Request View Controller.</summary>
		RequestViewController = 56,
		/// <summary>Parameters For Overview.</summary>
		ParametersForOverview = 57,
		/// <summary>Supports Mpe.</summary>
		[MacCatalyst (13, 1)]
		SupportsMpe = 58,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		LastRenderSampleTime = 61,
		[iOS (14, 5), TV (14, 5)]
		[MacCatalyst (14, 5)]
		LoadedOutOfProcess = 62,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		MIDIOutputEventListCallback = 63,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		AudioUnitMIDIProtocol = 64,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		HostMIDIProtocol = 65,

#if MONOMAC
		/// <summary>Fast Dispatch.</summary>
		FastDispatch = 5,
		/// <summary>Set External Buffer.</summary>
		SetExternalBuffer = 15,
		/// <summary>Get U I Component List.</summary>
		GetUIComponentList = 18,
		/// <summary>Cocoa U I.</summary>
		CocoaUI = 31,
		/// <summary>Icon Location.</summary>
		IconLocation = 39,
		/// <summary>A U Host Identifier.</summary>
		AUHostIdentifier = 46,
		/// <summary>M I D I Output Callback Info.</summary>
		MIDIOutputCallbackInfo = 47,
		/// <summary>M I D I Output Callback.</summary>
		MIDIOutputCallback = 48,
#else
		/// <summary>Remote Control Event Listener.</summary>
		RemoteControlEventListener = 100,
		/// <summary>Is Inter App Connected.</summary>
		IsInterAppConnected = 101,
		/// <summary>Peer U R L.</summary>
		PeerURL = 102,
#endif // MONOMAC

		// Output Unit
		/// <summary>Is Running.</summary>
		IsRunning = 2001,

		// OS X Availability
#if MONOMAC

		// Music Effects and Instruments
		/// <summary>All Parameter M I D I Mappings.</summary>
		AllParameterMIDIMappings = 41,
		/// <summary>Add Parameter M I D I Mapping.</summary>
		AddParameterMIDIMapping = 42,
		/// <summary>Remove Parameter M I D I Mapping.</summary>
		RemoveParameterMIDIMapping = 43,
		/// <summary>Hot Map Parameter M I D I Mapping.</summary>
		HotMapParameterMIDIMapping = 44,

		// Music Device
		/// <summary>M I D I X M L Names.</summary>
		MIDIXMLNames = 1006,
		/// <summary>Part Group.</summary>
		PartGroup = 1010,
		/// <summary>Dual Scheduling Mode.</summary>
		DualSchedulingMode = 1013,
		/// <summary>Supports Start Stop Note.</summary>
		SupportsStartStopNote = 1014,

		// Offline Unit
		/// <summary>Input Size.</summary>
		InputSize = 3020,
		/// <summary>Output Size.</summary>
		OutputSize = 3021,
		/// <summary>Start Offset.</summary>
		StartOffset = 3022,
		/// <summary>Preflight Requirements.</summary>
		PreflightRequirements = 3023,
		/// <summary>Preflight Name.</summary>
		PreflightName = 3024,

		// Translation Service
		/// <summary>From Plugin.</summary>
		FromPlugin = 4000,
		/// <summary>Old Automation.</summary>
		OldAutomation = 4001,

#endif // MONOMAC

		// Apple Specific Properties
		// AUConverter
		/// <summary>Sample Rate Converter Complexity.</summary>
		SampleRateConverterComplexity = 3014,

		// AUHAL and device units
		/// <summary>Current Device.</summary>
		CurrentDevice = 2000,
		/// <summary>Channel Map.</summary>
		ChannelMap = 2002, // this will also work with AUConverter
		/// <summary>Enable I O.</summary>
		EnableIO = 2003,
		/// <summary>Start Time.</summary>
		StartTime = 2004,
		/// <summary>Set Input Callback.</summary>
		SetInputCallback = 2005,
		/// <summary>Has I O.</summary>
		HasIO = 2006,
		/// <summary>Start Timestamps At Zero.</summary>
		StartTimestampsAtZero = 2007, // this will also work with AUConverter

#if !MONOMAC
		/// <summary>M I D I Callbacks.</summary>
		MIDICallbacks = 2010,
		/// <summary>Host Receives Remote Control Events.</summary>
		HostReceivesRemoteControlEvents = 2011,
		/// <summary>Remote Control To Host.</summary>
		RemoteControlToHost = 2012,
		/// <summary>Host Transport State.</summary>
		HostTransportState = 2013,
		/// <summary>Node Component Description.</summary>
		NodeComponentDescription = 2014,
#endif // !MONOMAC

		// AUVoiceProcessing unit
		/// <summary>Bypass Voice Processing.</summary>
		BypassVoiceProcessing = 2100,
		/// <summary>Voice Processing Enable A G C.</summary>
		VoiceProcessingEnableAGC = 2101,
		/// <summary>Mute Output.</summary>
		MuteOutput = 2104,
		[iOS (15, 0), MacCatalyst (15, 0), NoMac, NoTV]
		MutedSpeechActivityEventListener = 2106,

		// AUNBandEQ unit
		/// <summary>Number Of Bands.</summary>
		NumberOfBands = 2200,
		/// <summary>Max Number Of Bands.</summary>
		MaxNumberOfBands = 2201,
		/// <summary>Biquad Coefficients.</summary>
		BiquadCoefficients = 2203,

		// Mixers
		// General mixers
		/// <summary>Metering Mode.</summary>
		MeteringMode = 3007,

		// Matrix Mixer
		/// <summary>Matrix Levels.</summary>
		MatrixLevels = 3006,
		/// <summary>Matrix Dimensions.</summary>
		MatrixDimensions = 3009,
		/// <summary>Meter Clipping.</summary>
		MeterClipping = 3011,
		/// <summary>Input Anchor Time Stamp.</summary>
		[MacCatalyst (13, 1)]
		InputAnchorTimeStamp = 3016,

		// SpatialMixer
		/// <summary>Reverb Room Type.</summary>
		ReverbRoomType = 10,
		/// <summary>Uses Internal Reverb.</summary>
		UsesInternalReverb = 1005,
		/// <summary>Spatialization Algorithm.</summary>
		SpatializationAlgorithm = 3000,
		SpatialMixerRenderingFlags = 3003,
		SpatialMixerSourceMode = 3005,
		SpatialMixerDistanceParams = 3010,
#if !XAMCORE_5_0
		/// <summary>Distance Params.</summary>
		[Obsolete ("Use 'SpatialMixerDistanceParams' instead.")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		DistanceParams = SpatialMixerDistanceParams,
		/// <summary>Developers should not use this deprecated field. </summary>
		[Obsolete ("Use 'SpatialMixerAttenuationCurve' instead.")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		AttenuationCurve = SpatialMixerAttenuationCurve,
		/// <summary>Rendering Flags.</summary>
		[Obsolete ("Use 'SpatialMixerRenderingFlags' instead.")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		RenderingFlags = SpatialMixerRenderingFlags,
#endif
		SpatialMixerAttenuationCurve = 3013,
		SpatialMixerOutputType = 3100,
		SpatialMixerPointSourceInHeadMode = 3103,
		[Mac (12, 3), iOS (18, 0), TV (18, 0), MacCatalyst (18, 0)]
		SpatialMixerEnableHeadTracking = 3111,
		[Mac (13, 0), iOS (18, 0), TV (18, 0), MacCatalyst (18, 0)]
		SpatialMixerPersonalizedHrtfMode = 3113,
		[Mac (14, 0), iOS (18, 0), TV (18, 0), MacCatalyst (18, 0)]
		SpatialMixerAnyInputIsUsingPersonalizedHrtf = 3116,

		// AUScheduledSoundPlayer
		/// <summary>Schedule Audio Slice.</summary>
		ScheduleAudioSlice = 3300,
		/// <summary>Schedule Start Time Stamp.</summary>
		ScheduleStartTimeStamp = 3301,
		/// <summary>Current Play Time.</summary>
		CurrentPlayTime = 3302,

		// AUAudioFilePlayer
		/// <summary>Scheduled File I Ds.</summary>
		ScheduledFileIDs = 3310,
		/// <summary>Scheduled File Region.</summary>
		ScheduledFileRegion = 3311,
		/// <summary>Scheduled File Prime.</summary>
		ScheduledFilePrime = 3312,
		/// <summary>Scheduled File Buffer Size Frames.</summary>
		ScheduledFileBufferSizeFrames = 3313,
		/// <summary>Scheduled File Number Buffers.</summary>
		ScheduledFileNumberBuffers = 3314,

#if MONOMAC
		// OS X-specific Music Device Properties
		/// <summary>Sound Bank Data.</summary>
		SoundBankData = 1008,
		/// <summary>Stream From Disk.</summary>
		StreamFromDisk = 1011,
		/// <summary>Sound Bank F S Ref.</summary>
		SoundBankFSRef = 1012,

#endif // !MONOMAC

		// Music Device Properties
		/// <summary>Instrument Name.</summary>
		InstrumentName = 1001,
		/// <summary>Instrument Number.</summary>
		InstrumentNumber = 1004,

		// Music Device Properties used by DLSMusicDevice and AUMIDISynth
		/// <summary>Instrument Count.</summary>
		InstrumentCount = 1000,
		/// <summary>Bank Name.</summary>
		BankName = 1007,
		/// <summary>Sound Bank U R L.</summary>
		SoundBankURL = 1100,

		// AUMIDISynth
		/// <summary>Midi Synth Enable Preload.</summary>
		MidiSynthEnablePreload = 4119,

		// AUSampler
		/// <summary>Load Instrument.</summary>
		LoadInstrument = 4102,
		/// <summary>Load Audio Files.</summary>
		LoadAudioFiles = 4101,

		// AUDeferredRenderer
		/// <summary>Deferred Renderer Pull Size.</summary>
		DeferredRendererPullSize = 3320,
		/// <summary>Deferred Renderer Extra Latency.</summary>
		DeferredRendererExtraLatency = 3321,
		/// <summary>Deferred Renderer Wait Frames.</summary>
		DeferredRendererWaitFrames = 3322,

#if MONOMAC
		// AUNetReceive
		/// <summary>Hostname.</summary>
		Hostname = 3511,
		/// <summary>Net Receive Password.</summary>
		NetReceivePassword = 3512,

		// AUNetSend
		/// <summary>Port Num.</summary>
		PortNum = 3513,
		/// <summary>Transmission Format.</summary>
		TransmissionFormat = 3514,
		/// <summary>Transmission Format Index.</summary>
		TransmissionFormatIndex = 3515,
		/// <summary>Service Name.</summary>
		ServiceName = 3516,
		/// <summary>Disconnect.</summary>
		Disconnect = 3517,
		/// <summary>Net Send Password.</summary>
		NetSendPassword = 3518,
#endif // MONOMAC
	}

	/// <summary>An enumeration whose values represent adjustable attributes such as pitch or volume.</summary>
	public enum AudioUnitParameterType // UInt32 in AudioUnitParameterInfo
	{
		// AUMixer3D unit
		/// <summary>Mixer3 D Azimuth.</summary>
		Mixer3DAzimuth = 0,
		/// <summary>Mixer3 D Elevation.</summary>
		Mixer3DElevation = 1,
		/// <summary>Mixer3 D Distance.</summary>
		Mixer3DDistance = 2,
		/// <summary>Mixer3 D Gain.</summary>
		Mixer3DGain = 3,
		/// <summary>Mixer3 D Playback Rate.</summary>
		Mixer3DPlaybackRate = 4,
#if MONOMAC
		Mixer3DReverbBlend = 5,
		Mixer3DGlobalReverbGain = 6,
		Mixer3DOcclusionAttenuation = 7,
		Mixer3DObstructionAttenuation = 8,
		Mixer3DMinGain = 9,
		Mixer3DMaxGain = 10,
		/// <summary>Mixer3 D Pre Average Power.</summary>
		Mixer3DPreAveragePower = 1000,
		/// <summary>Mixer3 D Pre Peak Hold Level.</summary>
		Mixer3DPrePeakHoldLevel = 2000,
		/// <summary>Mixer3 D Post Average Power.</summary>
		Mixer3DPostAveragePower = 3000,
		/// <summary>Mixer3 D Post Peak Hold Level.</summary>
		Mixer3DPostPeakHoldLevel = 4000,
#else
		/// <summary>Mixer3 D Enable.</summary>
		Mixer3DEnable = 5,
		/// <summary>Mixer3 D Min Gain.</summary>
		Mixer3DMinGain = 6,
		/// <summary>Mixer3 D Max Gain.</summary>
		Mixer3DMaxGain = 7,
		/// <summary>Mixer3 D Reverb Blend.</summary>
		Mixer3DReverbBlend = 8,
		/// <summary>Mixer3 D Global Reverb Gain.</summary>
		Mixer3DGlobalReverbGain = 9,
		/// <summary>Mixer3 D Occlusion Attenuation.</summary>
		Mixer3DOcclusionAttenuation = 10,
		/// <summary>Mixer3 D Obstruction Attenuation.</summary>
		Mixer3DObstructionAttenuation = 11,
#endif

		// AUSpatialMixer unit
		/// <summary>Spatial Azimuth.</summary>
		SpatialAzimuth = 0,
		/// <summary>Spatial Elevation.</summary>
		SpatialElevation = 1,
		/// <summary>Spatial Distance.</summary>
		SpatialDistance = 2,
		/// <summary>Spatial Gain.</summary>
		SpatialGain = 3,
		/// <summary>Spatial Playback Rate.</summary>
		SpatialPlaybackRate = 4,
		/// <summary>Spatial Enable.</summary>
		SpatialEnable = 5,
		/// <summary>Spatial Min Gain.</summary>
		SpatialMinGain = 6,
		/// <summary>Spatial Max Gain.</summary>
		SpatialMaxGain = 7,
		/// <summary>Spatial Reverb Blend.</summary>
		SpatialReverbBlend = 8,
		/// <summary>Spatial Global Reverb Gain.</summary>
		SpatialGlobalReverbGain = 9,
		/// <summary>Spatial Occlusion Attenuation.</summary>
		SpatialOcclusionAttenuation = 10,
		/// <summary>Spatial Obstruction Attenuation.</summary>
		SpatialObstructionAttenuation = 11,

		// Reverb applicable to the 3DMixer or AUSpatialMixer
		/// <summary>Reverb Filter Frequency.</summary>
		ReverbFilterFrequency = 14,
		/// <summary>Reverb Filter Bandwidth.</summary>
		ReverbFilterBandwidth = 15,
		/// <summary>Reverb Filter Gain.</summary>
		ReverbFilterGain = 16,
		/// <summary>Reverb Filter Type.</summary>
		[MacCatalyst (13, 1)]
		ReverbFilterType = 17,
		/// <summary>Reverb Filter Enable.</summary>
		[MacCatalyst (13, 1)]
		ReverbFilterEnable = 18,

		// AUMultiChannelMixer
		/// <summary>Multi Channel Mixer Volume.</summary>
		MultiChannelMixerVolume = 0,
		/// <summary>Multi Channel Mixer Enable.</summary>
		MultiChannelMixerEnable = 1,
		/// <summary>Multi Channel Mixer Pan.</summary>
		MultiChannelMixerPan = 2,

		// AUMatrixMixer unit
		/// <summary>Matrix Mixer Volume.</summary>
		MatrixMixerVolume = 0,
		/// <summary>Matrix Mixer Enable.</summary>
		MatrixMixerEnable = 1,

		// AudioDeviceOutput, DefaultOutputUnit, and SystemOutputUnit units
		/// <summary>H A L Output Volume.</summary>
		HALOutputVolume = 14,

		// AUTimePitch, AUTimePitch (offline), AUPitch units
		/// <summary>Time Pitch Rate.</summary>
		TimePitchRate = 0,
#if MONOMAC
		/// <summary>Time Pitch Pitch.</summary>
		TimePitchPitch = 1,
		/// <summary>Time Pitch Effect Blend.</summary>
		TimePitchEffectBlend = 2,
#endif

		// AUNewTimePitch
		/// <summary>New Time Pitch Rate.</summary>
		NewTimePitchRate = 0,
		/// <summary>New Time Pitch Pitch.</summary>
		NewTimePitchPitch = 1,
		/// <summary>New Time Pitch Overlap.</summary>
		NewTimePitchOverlap = 4,
		/// <summary>New Time Pitch Enable Peak Locking.</summary>
		NewTimePitchEnablePeakLocking = 6,

		// AUSampler unit
		/// <summary>A U Sampler Gain.</summary>
		AUSamplerGain = 900,
		/// <summary>A U Sampler Coarse Tuning.</summary>
		AUSamplerCoarseTuning = 901,
		/// <summary>A U Sampler Fine Tuning.</summary>
		AUSamplerFineTuning = 902,
		/// <summary>A U Sampler Pan.</summary>
		AUSamplerPan = 903,

		// AUBandpass
		/// <summary>Bandpass Center Frequency.</summary>
		BandpassCenterFrequency = 0,
		/// <summary>Bandpass Bandwidth.</summary>
		BandpassBandwidth = 1,

		// AUHipass
		/// <summary>Hipass Cutoff Frequency.</summary>
		HipassCutoffFrequency = 0,
		/// <summary>Hipass Resonance.</summary>
		HipassResonance = 1,

		// AULowpass
		/// <summary>Low Pass Cutoff Frequency.</summary>
		LowPassCutoffFrequency = 0,
		/// <summary>Low Pass Resonance.</summary>
		LowPassResonance = 1,

		// AUHighShelfFilter
		/// <summary>High Shelf Cut Off Frequency.</summary>
		HighShelfCutOffFrequency = 0,
		/// <summary>High Shelf Gain.</summary>
		HighShelfGain = 1,

		// AULowShelfFilter
		/// <summary>A U Low Shelf Cutoff Frequency.</summary>
		AULowShelfCutoffFrequency = 0,
		/// <summary>A U Low Shelf Gain.</summary>
		AULowShelfGain = 1,

#if !XAMCORE_5_0 // I can't find this value in the headers anymore
		/// <summary>A U D C Filter Decay Time.</summary>
		[Obsoleted (PlatformName.iOS, 7, 0)]
		[Obsoleted (PlatformName.MacCatalyst, 13, 1)]
		AUDCFilterDecayTime = 0,
#endif

		// AUParametricEQ
		/// <summary>Parametric E Q Center Freq.</summary>
		ParametricEQCenterFreq = 0,
		/// <summary>Parametric E Q Q.</summary>
		ParametricEQQ = 1,
		/// <summary>Parametric E Q Gain.</summary>
		ParametricEQGain = 2,

		// AUPeakLimiter
		/// <summary>Limiter Attack Time.</summary>
		LimiterAttackTime = 0,
		/// <summary>Limiter Decay Time.</summary>
		LimiterDecayTime = 1,
		/// <summary>Limiter Pre Gain.</summary>
		LimiterPreGain = 2,

		// AUDynamicsProcessor
		/// <summary>Dynamics Processor Threshold.</summary>
		DynamicsProcessorThreshold = 0,
		/// <summary>Dynamics Processor Head Room.</summary>
		DynamicsProcessorHeadRoom = 1,
		/// <summary>Dynamics Processor Expansion Ratio.</summary>
		DynamicsProcessorExpansionRatio = 2,
		/// <summary>Dynamics Processor Expansion Threshold.</summary>
		DynamicsProcessorExpansionThreshold = 3,
		/// <summary>Dynamics Processor Attack Time.</summary>
		DynamicsProcessorAttackTime = 4,
		/// <summary>Dynamics Processor Release Time.</summary>
		DynamicsProcessorReleaseTime = 5,
		/// <summary>Dynamics Processor Master Gain.</summary>
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use 'DynamicsProcessorOverallGain' instead.")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use 'DynamicsProcessorOverallGain' instead.")]
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use 'DynamicsProcessorOverallGain' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 15, 0, message: "Use 'DynamicsProcessorOverallGain' instead.")]
		DynamicsProcessorMasterGain = 6,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		DynamicsProcessorOverallGain = 6,
		/// <summary>Dynamics Processor Compression Amount.</summary>
		DynamicsProcessorCompressionAmount = 1000,
		/// <summary>Dynamics Processor Input Amplitude.</summary>
		DynamicsProcessorInputAmplitude = 2000,
		/// <summary>Dynamics Processor Output Amplitude.</summary>
		DynamicsProcessorOutputAmplitude = 3000,

		// AUVarispeed
		/// <summary>Varispeed Playback Rate.</summary>
		VarispeedPlaybackRate = 0,
		/// <summary>Varispeed Playback Cents.</summary>
		VarispeedPlaybackCents = 1,

		// Distortion unit 
		/// <summary>Distortion Delay.</summary>
		DistortionDelay = 0,
		/// <summary>Distortion Decay.</summary>
		DistortionDecay = 1,
		/// <summary>Distortion Delay Mix.</summary>
		DistortionDelayMix = 2,
		/// <summary>Distortion Decimation.</summary>
		DistortionDecimation = 3,
		/// <summary>Distortion Rounding.</summary>
		DistortionRounding = 4,
		/// <summary>Distortion Decimation Mix.</summary>
		DistortionDecimationMix = 5,
		/// <summary>Distortion Linear Term.</summary>
		DistortionLinearTerm = 6,
		/// <summary>Distortion Squared Term.</summary>
		DistortionSquaredTerm = 7,
		/// <summary>Distortion Cubic Term.</summary>
		DistortionCubicTerm = 8,
		/// <summary>Distortion Polynomial Mix.</summary>
		DistortionPolynomialMix = 9,
		/// <summary>Distortion Ring Mod Freq1.</summary>
		DistortionRingModFreq1 = 10,
		/// <summary>Distortion Ring Mod Freq2.</summary>
		DistortionRingModFreq2 = 11,
		/// <summary>Distortion Ring Mod Balance.</summary>
		DistortionRingModBalance = 12,
		/// <summary>Distortion Ring Mod Mix.</summary>
		DistortionRingModMix = 13,
		/// <summary>Distortion Soft Clip Gain.</summary>
		DistortionSoftClipGain = 14,
		/// <summary>Distortion Final Mix.</summary>
		DistortionFinalMix = 15,

		// AUDelay
		/// <summary>Delay Wet Dry Mix.</summary>
		DelayWetDryMix = 0,
		/// <summary>Delay Time.</summary>
		DelayTime = 1,
		/// <summary>Delay Feedback.</summary>
		DelayFeedback = 2,
		/// <summary>Delay Lopass Cutoff.</summary>
		DelayLopassCutoff = 3,

		// AUNBandEQ
		/// <summary>A U N Band E Q Global Gain.</summary>
		AUNBandEQGlobalGain = 0,
		/// <summary>A U N Band E Q Bypass Band.</summary>
		AUNBandEQBypassBand = 1000,
		/// <summary>A U N Band E Q Filter Type.</summary>
		AUNBandEQFilterType = 2000,
		/// <summary>A U N Band E Q Frequency.</summary>
		AUNBandEQFrequency = 3000,
		/// <summary>A U N Band E Q Gain.</summary>
		AUNBandEQGain = 4000,
		/// <summary>A U N Band E Q Bandwidth.</summary>
		AUNBandEQBandwidth = 5000,

		// AURandomUnit
		/// <summary>Random Bound A.</summary>
		RandomBoundA = 0,
		/// <summary>Random Bound B.</summary>
		RandomBoundB = 1,
		/// <summary>Random Curve.</summary>
		RandomCurve = 2,

#if !MONOMAC
		// iOS reverb
		/// <summary>Reverb2 Dry Wet Mix.</summary>
		Reverb2DryWetMix = 0,
		/// <summary>Reverb2 Gain.</summary>
		Reverb2Gain = 1,
		/// <summary>Reverb2 Min Delay Time.</summary>
		Reverb2MinDelayTime = 2,
		/// <summary>Reverb2 Max Delay Time.</summary>
		Reverb2MaxDelayTime = 3,
		/// <summary>Reverb2 Decay Time At0 Hz.</summary>
		Reverb2DecayTimeAt0Hz = 4,
		/// <summary>Reverb2 Decay Time At Nyquist.</summary>
		Reverb2DecayTimeAtNyquist = 5,
		/// <summary>Reverb2 Randomize Reflections.</summary>
		Reverb2RandomizeReflections = 6,
#endif

		// RoundTripAAC
		/// <summary>Round Trip Aac Format.</summary>
		RoundTripAacFormat = 0,
		/// <summary>Round Trip Aac Encoding Strategy.</summary>
		RoundTripAacEncodingStrategy = 1,
		/// <summary>Round Trip Aac Rate Or Quality.</summary>
		RoundTripAacRateOrQuality = 2,

		// Spacial Mixer
		/// <summary>Spacial Mixer Azimuth.</summary>
		SpacialMixerAzimuth = 0,
		/// <summary>Elevation.</summary>
		Elevation = 1,
		/// <summary>Distance.</summary>
		Distance = 2,
		/// <summary>Gain.</summary>
		Gain = 3,
		/// <summary>Playback Rate.</summary>
		PlaybackRate = 4,
		/// <summary>Enable.</summary>
		Enable = 5,
		/// <summary>Min Gain.</summary>
		MinGain = 6,
		/// <summary>Max Gain.</summary>
		MaxGain = 7,
		/// <summary>Reverb Blend.</summary>
		ReverbBlend = 8,
		/// <summary>Global Reverb Gain.</summary>
		GlobalReverbGain = 9,
		/// <summary>Occlussion Attenuation.</summary>
		OcclussionAttenuation = 10,
		/// <summary>Obstruction Attenuation.</summary>
		ObstructionAttenuation = 11,
	}

	/// <summary>Enumerates attenuation modes.</summary>
	[MacCatalyst (13, 1)]
	public enum SpatialMixerAttenuation {
		/// <summary>Power.</summary>
		Power = 0,
		/// <summary>Exponential.</summary>
		Exponential = 1,
		/// <summary>Inverse.</summary>
		Inverse = 2,
		/// <summary>Linear.</summary>
		Linear = 3,
	}

	/// <summary>Flagging enumeration used to control spatial mixing.</summary>
	[Flags]
	[MacCatalyst (13, 1)]
	public enum SpatialMixerRenderingFlags {
		/// <summary>Inter Aural Delay.</summary>
		InterAuralDelay = (1 << 0),
		/// <summary>Developers should not use this deprecated field. </summary>
		[Deprecated (PlatformName.iOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Deprecated (PlatformName.MacOSX, 10, 11)]
		DistanceAttenuation = (1 << 2),
	}

	/// <summary>Enumerates timing flags for rendering audio slices.</summary>
	[Flags]
	public enum ScheduledAudioSliceFlag {
		/// <summary>Complete.</summary>
		Complete = 0x01,
		/// <summary>Began To Render.</summary>
		BeganToRender = 0x02,
		/// <summary>Began To Render Late.</summary>
		BeganToRenderLate = 0x04,

		/// <summary>Loop.</summary>
		[MacCatalyst (13, 1)]
		Loop = 0x08,
		/// <summary>Interrupt.</summary>
		[MacCatalyst (13, 1)]
		Interrupt = 0x10,
		/// <summary>Interrupt At Loop.</summary>
		[MacCatalyst (13, 1)]
		InterruptAtLoop = 0x20,
	}

	/// <summary>An enumeration whose values specify roles and contexts for audio unit properties.</summary>
	public enum AudioUnitScopeType { // UInt32 AudioUnitScope
		/// <summary>Global.</summary>
		Global = 0,
		/// <summary>Input.</summary>
		Input = 1,
		/// <summary>Output.</summary>
		Output = 2,
		/// <summary>Group.</summary>
		Group = 3,
		/// <summary>Part.</summary>
		Part = 4,
		/// <summary>Note.</summary>
		Note = 5,
		/// <summary>Layer.</summary>
		Layer = 6,
		/// <summary>Layer Item.</summary>
		LayerItem = 7,
	}

	/// <summary>An enumeration whose values specify configuration flags for audio-unit rendering.</summary>
	[Flags]
	public enum AudioUnitRenderActionFlags { // UInt32 AudioUnitRenderActionFlags
		/// <summary>Pre Render.</summary>
		PreRender = (1 << 2),
		/// <summary>Post Render.</summary>
		PostRender = (1 << 3),
		/// <summary>Output Is Silence.</summary>
		OutputIsSilence = (1 << 4),
		/// <summary>Offline Preflight.</summary>
		OfflinePreflight = (1 << 5),
		/// <summary>Offline Render.</summary>
		OfflineRender = (1 << 6),
		/// <summary>Offline Complete.</summary>
		OfflineComplete = (1 << 7),
		/// <summary>Post Render Error.</summary>
		PostRenderError = (1 << 8),
		/// <summary>Do Not Check Render Args.</summary>
		DoNotCheckRenderArgs = (1 << 9),
	}

	/// <summary>Enumerates events relating to remote control commands.</summary>
	public enum AudioUnitRemoteControlEvent // Unused?
	{
		/// <summary>Toggle Play Pause.</summary>
		TogglePlayPause = 1,
		/// <summary>Toggle Record.</summary>
		ToggleRecord = 2,
		/// <summary>Rewind.</summary>
		Rewind = 3,
	}

	[Native]
	public enum AudioUnitBusType : long {
		/// <summary>Input.</summary>
		Input = 1,
		/// <summary>Output.</summary>
		Output = 2,
	}

	/// <summary>Enumerates flag values that describe the state of an audio transport.</summary>
	[Native]
	public enum AUHostTransportStateFlags : ulong {
		/// <summary>Indicates that a state change has occurred, such as a stop, start, seek, or other change since the host transport state block was last called.</summary>
		Changed = 1,
		/// <summary>Indicates that the transport is moving.</summary>
		Moving = 2,
		/// <summary>Indicates that the host is able to record, or is currently recording.</summary>
		Recording = 4,
		/// <summary>Indicates that the host is cycling.</summary>
		Cycling = 8,
	}

	public enum AUEventSampleTime : long {
		/// <summary>Immediate.</summary>
		Immediate = unchecked((long) 0xffffffff00000000),
	}

	/// <summary>Enumerates options that can be used while instantiating a <see cref="AUAudioUnit" />.</summary>
	[MacCatalyst (13, 1)]
	public enum AudioComponentInstantiationOptions : uint {
		/// <summary>Out Of Process.</summary>
		OutOfProcess = 1,
		/// <summary>In Process.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		InProcess = 2,
		[iOS (14, 5), TV (14, 5), NoMac]
		[MacCatalyst (14, 5)]
		LoadedRemotely = 1u << 31,
	}

	/// <summary>Enumerates audio unit bus input-output capabilities.</summary>
	[Native]
	public enum AUAudioUnitBusType : long {
		/// <summary>Indicates an input bus.</summary>
		Input = 1,
		/// <summary>Indicates an output bus.</summary>
		Output = 2,
	}

	public enum AudioUnitParameterOptions : uint {
		/// <summary>C F Name Release.</summary>
		CFNameRelease = (1 << 4),
		/// <summary>Omit From Presets.</summary>
		OmitFromPresets = (1 << 13),
		/// <summary>Plot History.</summary>
		PlotHistory = (1 << 14),
		/// <summary>Meter Read Only.</summary>
		MeterReadOnly = (1 << 15),
		/// <summary>Display Mask.</summary>
		DisplayMask = (7 << 16) | (1 << 22),
		/// <summary>Display Square Root.</summary>
		DisplaySquareRoot = (1 << 16),
		/// <summary>Display Squared.</summary>
		DisplaySquared = (2 << 16),
		/// <summary>Display Cubed.</summary>
		DisplayCubed = (3 << 16),
		/// <summary>Display Cube Root.</summary>
		DisplayCubeRoot = (4 << 16),
		/// <summary>Display Exponential.</summary>
		DisplayExponential = (5 << 16),
		/// <summary>Has Clump.</summary>
		HasClump = (1 << 20),
		/// <summary>Values Have Strings.</summary>
		ValuesHaveStrings = (1 << 21),
		/// <summary>Display Logarithmic.</summary>
		DisplayLogarithmic = (1 << 22),
		/// <summary>Is High Resolution.</summary>
		IsHighResolution = (1 << 23),
		/// <summary>Non Real Time.</summary>
		NonRealTime = (1 << 24),
		/// <summary>Can Ramp.</summary>
		CanRamp = (1 << 25),
		/// <summary>Expert Mode.</summary>
		ExpertMode = (1 << 26),
		/// <summary>Has C F Name String.</summary>
		HasCFNameString = (1 << 27),
		/// <summary>Is Global Meta.</summary>
		IsGlobalMeta = (1 << 28),
		/// <summary>Is Element Meta.</summary>
		IsElementMeta = (1 << 29),
		/// <summary>Is Readable.</summary>
		IsReadable = (1 << 30),
		/// <summary>Is Writable.</summary>
		IsWritable = unchecked((uint) 1 << 31),
	}

	public enum AudioComponentValidationResult : uint {
		/// <summary>Unknown.</summary>
		Unknown = 0,
		/// <summary>Passed.</summary>
		Passed,
		/// <summary>Failed.</summary>
		Failed,
		/// <summary>Timed Out.</summary>
		TimedOut,
		/// <summary>Unauthorized Error Open.</summary>
		UnauthorizedErrorOpen,
		/// <summary>Unauthorized Error Init.</summary>
		UnauthorizedErrorInit,
	}

	public enum AUSpatialMixerAttenuationCurve : uint {
		/// <summary>Power.</summary>
		Power = 0,
		/// <summary>Exponential.</summary>
		Exponential = 1,
		/// <summary>Inverse.</summary>
		Inverse = 2,
		/// <summary>Linear.</summary>
		Linear = 3,
	}

	public enum AU3DMixerRenderingFlags : uint {
		/// <summary>Inter Aural Delay.</summary>
		InterAuralDelay = (1 << 0),
		/// <summary>Doppler Shift.</summary>
		DopplerShift = (1 << 1),
		/// <summary>Distance Attenuation.</summary>
		DistanceAttenuation = (1 << 2),
		/// <summary>Distance Filter.</summary>
		DistanceFilter = (1 << 3),
		/// <summary>Distance Diffusion.</summary>
		DistanceDiffusion = (1 << 4),
		/// <summary>Linear Distance Attenuation.</summary>
		LinearDistanceAttenuation = (1 << 5),
		/// <summary>Constant Reverb Blend.</summary>
		ConstantReverbBlend = (1 << 6),
	}

	public enum AUReverbRoomType : uint {
		/// <summary>Small Room.</summary>
		SmallRoom = 0,
		/// <summary>Medium Room.</summary>
		MediumRoom = 1,
		/// <summary>Large Room.</summary>
		LargeRoom = 2,
		/// <summary>Medium Hall.</summary>
		MediumHall = 3,
		/// <summary>Large Hall.</summary>
		LargeHall = 4,
		/// <summary>Plate.</summary>
		Plate = 5,
		/// <summary>Medium Chamber.</summary>
		MediumChamber = 6,
		/// <summary>Large Chamber.</summary>
		LargeChamber = 7,
		/// <summary>Cathedral.</summary>
		Cathedral = 8,
		/// <summary>Large Room2.</summary>
		LargeRoom2 = 9,
		/// <summary>Medium Hall2.</summary>
		MediumHall2 = 10,
		/// <summary>Medium Hall3.</summary>
		MediumHall3 = 11,
		/// <summary>Large Hall2.</summary>
		LargeHall2 = 12,
	}

	public enum AUScheduledAudioSliceFlags : uint {
		/// <summary>Complete.</summary>
		Complete = 1,
		/// <summary>Began To Render.</summary>
		BeganToRender = 2,
		/// <summary>Began To Render Late.</summary>
		BeganToRenderLate = 4,
		/// <summary>Loop.</summary>
		Loop = 8,
		/// <summary>Interrupt.</summary>
		Interrupt = 16,
		/// <summary>Interrupt At Loop.</summary>
		InterruptAtLoop = 32,
	}

	public enum AUSpatializationAlgorithm : uint {
		/// <summary>Equal Power Panning.</summary>
		EqualPowerPanning = 0,
		/// <summary>Spherical Head.</summary>
		SphericalHead = 1,
		/// <summary>Hrtf.</summary>
		Hrtf = 2,
		/// <summary>Sound Field.</summary>
		SoundField = 3,
		/// <summary>Vector Based Panning.</summary>
		VectorBasedPanning = 4,
		/// <summary>Stereo Pass Through.</summary>
		StereoPassThrough = 5,
		/// <summary>Hrtf H Q.</summary>
		HrtfHQ = 6,
		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		UseOutputType = 7,
	}

	/// <summary>Enumerates attentuation curve types.</summary>
	public enum AU3DMixerAttenuationCurve : uint {
		/// <summary>Indicates an equal-power attenuation curve.</summary>
		Power = 0,
		/// <summary>Indicates an exponential attenuation curve.</summary>
		Exponential = 1,
		/// <summary>Indicates an inverse attenuation curve.</summary>
		Inverse = 2,
		/// <summary>Indicates a linear attenuation curve.</summary>
		Linear = 3,
	}

	public enum AUSpatialMixerRenderingFlags : uint {
		/// <summary>Inter Aural Delay.</summary>
		InterAuralDelay = (1 << 0),
		/// <summary>Distance Attenuation.</summary>
		DistanceAttenuation = (1 << 2),
	}

	[MacCatalyst (13, 1)]
	public enum AUParameterAutomationEventType : uint {
		/// <summary>Value.</summary>
		Value = 0,
		/// <summary>Touch.</summary>
		Touch = 1,
		/// <summary>Release.</summary>
		Release = 2,
	}

	[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
	public enum AUVoiceIOSpeechActivityEvent : uint {
		Started = 0,
		Ended = 1,
	}

	[iOS (16, 0), TV (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
	public enum AudioUnitEventType : uint {
		ParameterValueChange = 0,
		BeginParameterChangeGesture = 1,
		EndParameterChangeGesture = 2,
		PropertyChange = 3,
	}


	public enum AudioUnitSubType : uint {
		/// <summary>A U Converter.</summary>
		AUConverter = 0x636F6E76, // 'conv'
		/// <summary>Varispeed.</summary>
		Varispeed = 0x76617269, // 'vari'
		/// <summary>Deferred Renderer.</summary>
		DeferredRenderer = 0x64656672, // 'defr'
		/// <summary>Splitter.</summary>
		Splitter = 0x73706C74, // 'splt'
		/// <summary>Multi Splitter.</summary>
		MultiSplitter = 0x6D73706C, // 'mspl'
		/// <summary>Merger.</summary>
		Merger = 0x6D657267, // 'merg'
		/// <summary>New Time Pitch.</summary>
		NewTimePitch = 0x6E757470, // 'nutp'
		/// <summary>A Ui Pod Time Other.</summary>
		AUiPodTimeOther = 0x6970746F, // 'ipto'
		/// <summary>Round Trip Aac.</summary>
		RoundTripAac = 0x72616163, // 'raac'
		/// <summary>Generic Output.</summary>
		GenericOutput = 0x67656E72, // 'genr'
		/// <summary>Voice Processing I O.</summary>
		VoiceProcessingIO = 0x7670696F, // 'vpio'
		/// <summary>Sampler.</summary>
		Sampler = 0x73616D70, // 'samp'
		/// <summary>Midi Synth.</summary>
		MidiSynth = 0x6D73796E, // 'msyn'
		/// <summary>Peak Limiter.</summary>
		PeakLimiter = 0x6C6D7472, // 'lmtr'
		/// <summary>Dynamics Processor.</summary>
		DynamicsProcessor = 0x64636D70, // 'dcmp'
		/// <summary>Low Pass Filter.</summary>
		LowPassFilter = 0x6C706173, // 'lpas'
		/// <summary>High Pass Filter.</summary>
		HighPassFilter = 0x68706173, // 'hpas'
		/// <summary>Band Pass Filter.</summary>
		BandPassFilter = 0x62706173, // 'bpas'
		/// <summary>High Shelf Filter.</summary>
		HighShelfFilter = 0x68736866, // 'hshf'
		/// <summary>Low Shelf Filter.</summary>
		LowShelfFilter = 0x6C736866, // 'lshf'
		/// <summary>Parametric E Q.</summary>
		ParametricEQ = 0x706D6571, // 'pmeq'
		/// <summary>Distortion.</summary>
		Distortion = 0x64697374, // 'dist'
		/// <summary>Delay.</summary>
		Delay = 0x64656C79, // 'dely'
		/// <summary>Sample Delay.</summary>
		SampleDelay = 0x73646C79, // 'sdly'
		/// <summary>N Band E Q.</summary>
		NBandEQ = 0x6E626571, // 'nbeq'
		/// <summary>Multi Channel Mixer.</summary>
		MultiChannelMixer = 0x6D636D78, // 'mcmx'
		/// <summary>Matrix Mixer.</summary>
		MatrixMixer = 0x6D786D78, // 'mxmx'
		/// <summary>Spatial Mixer.</summary>
		SpatialMixer = 0x3364656D, // '3dem'
		/// <summary>Scheduled Sound Player.</summary>
		ScheduledSoundPlayer = 0x7373706C, // 'sspl'
		/// <summary>Audio File Player.</summary>
		AudioFilePlayer = 0x6166706C, // 'afpl'
		/// <summary>A light reverb.</summary>
		Reverb2 = 0x72766232, // 'rvb2'
		/// <summary>An audio unit that can be used to isolate a sound type.</summary>
		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0), NoTV]
		AUSoundIsolation = 0x766f6973, // 'vois'
		/// <summary>An audio unit that supports AudioMix separate-and-remix.</summary>
		[iOS (26, 0), Mac (26, 0), MacCatalyst (26, 0), NoTV]
		AUAudioMix = 0x616d6978, // 'amix'
#if MONOMAC
		/// <summary>H A L Output.</summary>
		HALOutput = 0x6168616C, // 'ahal'
		/// <summary>Default Output.</summary>
		DefaultOutput = 0x64656620, // 'def '
		/// <summary>System Output.</summary>
		SystemOutput = 0x73797320, // 'sys '
		/// <summary>D L S Synth.</summary>
		DLSSynth = 0x646C7320, // 'dls '
		/// <summary>Time Pitch.</summary>
		TimePitch = 0x746D7074, // 'tmpt'
		/// <summary>Graphic E Q.</summary>
		GraphicEQ = 0x67726571, // 'greq'
		/// <summary>Multi Band Compressor.</summary>
		MultiBandCompressor = 0x6D636D70, // 'mcmp'
		/// <summary>Matrix Reverb.</summary>
		MatrixReverb = 0x6D726576, // 'mrev'
		/// <summary>Pitch.</summary>
		Pitch = 0x746D7074, // 'tmpt'
		/// <summary>A U Filter.</summary>
		AUFilter = 0x66696C74, // 'filt
		/// <summary>Net Send.</summary>
		NetSend = 0x6E736E64, // 'nsnd'
		/// <summary>Roger Beep.</summary>
		RogerBeep = 0x726F6772, // 'rogr'
		/// <summary>Stereo Mixer.</summary>
		StereoMixer = 0x736D7872, // 'smxr'
		/// <summary>Spherical Head Panner.</summary>
		SphericalHeadPanner = 0x73706872, // 'sphr'
		/// <summary>Vector Panner.</summary>
		VectorPanner = 0x76626173, // 'vbas'
		/// <summary>Sound Field Panner.</summary>
		SoundFieldPanner = 0x616D6269, // 'ambi'
		/// <summary>H R T F Panner.</summary>
		HRTFPanner = 0x68727466, // 'hrtf'
		/// <summary>Net Receive.</summary>
		NetReceive = 0x6E726376, // 'nrcv'
#endif
	}

	[MacCatalyst (17, 0), Mac (14, 0), NoTV, NoiOS]
	public enum AudioAggregateDriftCompensation : uint {
		MinQuality = 0,
		LowQuality = 0x20,
		MediumQuality = 0x40,
		HighQuality = 0x60,
		MaxQuality = 0x7F,
	}
}
