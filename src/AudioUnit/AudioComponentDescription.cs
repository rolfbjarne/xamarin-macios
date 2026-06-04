//
// AudioComponentDescription.cs: AudioComponentDescription wrapper class
//
// Author:
//   AKIHIRO Uehara (u-akihiro@reinforce-lab.com)
//   Miguel de Icaza (miguel@gnome.org)
//
// Copyright 2010 Reinforce Lab.
// Copyright 2010 Novell, Inc
// Copyright 2011, 2012 Xamarin Inc
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

#nullable enable

using System.Collections.Generic;
using AudioToolbox;

namespace AudioUnit {
	/// <summary>An enumeration whose values represent different types of audio components.</summary>
	///     <remarks>
	///       <para>Describes an audio unit component type.</para>
	///       <para />
	///     </remarks>
	public enum AudioComponentType : uint { // OSType in AudioComponentDescription
		/// <summary>An effect component, when set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypeOutput" /></summary>
		Output = 0x61756f75, //'auou',
		/// <summary>A music device component, when set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypeMusicDevice" /></summary>
		MusicDevice = 0x61756d75, // 'aumu'
		/// <summary>An effect component that can also work on MIDI control messages.</summary>
		MusicEffect = 0x61756d66, // 'aumf'
		/// <summary>An format converter component, when set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypeConverter" /></summary>
		FormatConverter = 0x61756663, // 'aufc'
		/// <summary>An effect component, when set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypeEffect" /></summary>
		Effect = 0x61756678, // 'aufx'
		/// <summary>A mixer component, when set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypeMixer" /></summary>
		Mixer = 0x61756d78, // 'aumx'
		/// <summary>A panner component that will pan a single audio input to a single output. When set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypePanner" /></summary>
		Panner = 0x6175706e, // 'aupn'
		/// <summary>An offline effect component, used to process data from files or to perform offline audio processing (not real time)</summary>
		OfflineEffect = 0x61756f6c, // 'auol'
		/// <summary>A generator component, when set, you want to set a component subtype in the <see cref="AudioComponentDescription.ComponentSubType" /> to one of the values from <see cref="AudioTypeGenerator" /></summary>
		Generator = 0x6175676e, // 'augn'
		/// <summary>A MIDI processor component, they can receive MIDI input and generate MIDI output, but they do not actually produce audio.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		MIDIProcessor = 0x61756d69, // 'aumi'
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		SpeechSynthesize = 0x61757370, // ausp

#if !MONOMAC
		/// <summary>A remote effect component</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		RemoteEffect = 0x61757278, // 'aurx',
		/// <summary>A remote generator.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		RemoteGenerator = 0x61757267, // 'aurg',
		/// <summary>A remote instrument</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		RemoteInstrument = 0x61757269, // 'auri',
		/// <summary>A remote music effect</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		RemoteMusicEffect = 0x6174726d, // 'aurm'
#endif
	}

	/// <summary>An enumeration whose values specify the type of audio output.</summary>
	public enum AudioTypeOutput { // OSType in AudioComponentDescription
		/// <summary>Indicates generic.</summary>
		Generic = 0x67656e72, // 'genr'
#if MONOMAC
		/// <summary>Indicates h a l.</summary>
		HAL = 0x6168616c, // 'ahal'
		/// <summary>Indicates default.</summary>
		Default = 0x64656620, // 'def'
		/// <summary>Indicates system.</summary>
		System = 0x73797320, // 'sys'
#endif
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		Remote = 0x72696f63, // 'rioc'
		/// <summary>Indicates voice processing i o.</summary>
		VoiceProcessingIO = 0x7670696f, // 'vpio'
	}

	/// <summary>An enumeration whose values specify whether an audio music device is a sampler or not.</summary>
	public enum AudioTypeMusicDevice { // OSType in AudioComponentDescription
#if MONOMAC
		/// <summary>Indicates dls synth.</summary>
		DlsSynth = 0x646c7320, // 'dls '
#endif
		/// <summary>Indicates sampler.</summary>
		Sampler = 0x73616d70, // 'samp'

		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		MidiSynth = 0x6d73796e, // 'msyn'
	}

	/// <summary>An enumeration whose values specify different audio unit format converters.</summary>
	public enum AudioTypeConverter { // OSType in AudioComponentDescription
		/// <summary>Indicates a converter that does linear PCM conversions.</summary>
		AU = 0x636f6e76, // 'conv'
		/// <summary>Indicates an audio unit that controls speed.</summary>
		Varispeed = 0x76617269, // 'vari'
		/// <summary>Indicates a cross-thread audio unit with a delay that is controlled by its buffer size.</summary>
		DeferredRenderer = 0x64656672, // 'defr'
		/// <summary>Indicates an audio unit that splits its input to two outputs.</summary>
		Splitter = 0x73706c74, // 'splt'
		/// <summary>Indicates an audio unit that merges two inputs.</summary>
		Merger = 0x6d657267, // 'merg'
		/// <summary>Indicates an audio unit that provides independent control of pitch and speed. (iOS 6.0 and later.)</summary>
		NewTimePitch = 0x6e757470, // 'nutp'
		/// <summary>Indicates a basic iPhone audio unit. (iOS 5.0 or later.)</summary>
		AUiPodTimeOther = 0x6970746f, // 'ipto
		/// <summary>Indicates an audio unit that handles round trip AAC data.</summary>
		RoundTripAAC = 0x72616163, // 'raac'
		/// <summary>Indicates an audio unit that splits its input to more than two outputs.</summary>
		MultiSplitter = 0x6d73706c, // 'mspl'
#if MONOMAC
		/// <summary>Indicates time pitch.</summary>
		TimePitch = 0x746d7074, // 'tmpt'
#else
		/// <summary>Indicates an iPhone audio unit that provides basic control over playback.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AudioTypeConverter.NewTimePitch' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AudioTypeConverter.NewTimePitch' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AudioTypeConverter.NewTimePitch' instead.")]
		AUiPodTime = 0x6970746d, // 'iptm'
#endif
	}

	/// <summary>An enumeration whose values specify different types of audio effects.</summary>
	public enum AudioTypeEffect { // OSType in AudioComponentDescription
		/// <summary>Indicates peak limiter.</summary>
		PeakLimiter = 0x6c6d7472, // 'lmtr'
		/// <summary>Indicates dynamics processor.</summary>
		DynamicsProcessor = 0x64636d70, // 'dcmp'
		/// <summary>Indicates low pass filter.</summary>
		LowPassFilter = 0x6c706173, // 'lpas'
		/// <summary>Indicates high pass filter.</summary>
		HighPassFilter = 0x68706173, // 'hpas'
		/// <summary>Indicates high shelf filter.</summary>
		HighShelfFilter = 0x68736866, // 'hshf'
		/// <summary>Indicates low shelf filter.</summary>
		LowShelfFilter = 0x6c736866, // 'lshf'
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("macos10.9")]
		DCFilter = 0x6463666c, // 'dcfl'
		/// <summary>To be added.</summary>
		ParametricEQ = 0x706d6571, // 'pmeq'
		/// <summary>Indicates delay.</summary>
		Delay = 0x64656c79, // 'dely'

		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SampleDelay = 0x73646c79, // 'sdly'
		/// <summary>Indicates distortion.</summary>
		Distortion = 0x64697374, // 'dist'
		/// <summary>Indicates band pass filter.</summary>
		BandPassFilter = 0x62706173, // 'bpas'
#if MONOMAC
		/// <summary>Indicates graphic e q.</summary>
		GraphicEQ = 0x67726571, // 'greq'
		/// <summary>Indicates multi band compressor.</summary>
		MultiBandCompressor = 0x6d636d70, // 'mcmp'
		/// <summary>Indicates matrix reverb.</summary>
		MatrixReverb = 0x6d726576, // 'mrev'
		/// <summary>Indicates pitch.</summary>
		Pitch = 0x70697463, // 'pitc'
		/// <summary>Indicates a u filter.</summary>
		AUFilter = 0x66696c74, // 'filt'
		/// <summary>Indicates net send.</summary>
		NetSend = 0x6e736e64, // 'nsnd'
		/// <summary>Indicates roger beep.</summary>
		RogerBeep = 0x726f6772, // 'rogr'
#else
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AudioTypeEffect.GraphicEQ' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AudioTypeEffect.GraphicEQ' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		AUiPodEQ = 0x69706571, // 'ipeq'
#endif
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Reverb2 = 0x72766232, // 'rvb2'
		/// <summary>Indicates n band eq.</summary>
		NBandEq = 0x6e626571, // 'nbeq'
	}

	/// <summary>An enumeration whose values specify whether the type of an audio mixer.</summary>
	public enum AudioTypeMixer { // OSType in AudioComponentDescription
		/// <summary>Indicates multi channel.</summary>
		MultiChannel = 0x6d636d78, // 'mcmx'
		/// <summary>Indicates matrix.</summary>
		Matrix = 0x6d786d78, // 'mxmx'
		/// <summary>Indicates spacial.</summary>
		Spacial = 0x3364656d, // Same as Embedded3D
#if MONOMAC
		/// <summary>Indicates stereo.</summary>
		Stereo = 0x736d7872, // 'smxr'
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'Spacial' instead.")]
		ThreeD = 0x33646d78, // '3dmx'
#else
		/// <summary>Developers should not use this deprecated field. Developers should use 'Spacial' instead.</summary>
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'Spacial' instead.")]
		Embedded3D = 0x3364656d, // '3dem'
#endif
	}

	/// <summary>An unimplemented enumeration.</summary>
	public enum AudioTypePanner { // OSType in AudioComponentDescription
#if MONOMAC
		/// <summary>Indicates spherical head.</summary>
		SphericalHead = 0x73706872, // 'sphr'
		/// <summary>Indicates vector.</summary>
		Vector = 0x76626173, // 'vbas'
		/// <summary>Indicates sound field.</summary>
		SoundField = 0x616d6269, // 'ambi'
		/// <summary>Indicates r h r t f.</summary>
		rHRTF = 0x68727466, // 'hrtf'
#endif
	}

	/// <summary>An enumeration whose values specify whether an audio generator is a file player or a scheduled sound player.</summary>
	public enum AudioTypeGenerator { // OSType in AudioComponentDescription
#if MONOMAC
		/// <summary>Indicates net receive.</summary>
		NetReceive = 0x6e726376, // 'nrcv'
#endif
		/// <summary>Indicates scheduled sound player.</summary>
		ScheduledSoundPlayer = 0x7373706c, // 'sspl'
		/// <summary>Indicates audio file player.</summary>
		AudioFilePlayer = 0x6166706c, // 'afpl'
	}

	/// <summary>An enumeration that specifies that an audio component was manufactured by Apple.</summary>
	public enum AudioComponentManufacturerType : uint // OSType in AudioComponentDescription
	{
		/// <summary>Indicates apple.</summary>
		Apple = 0x6170706c, // little endian 0x6c707061 //'appl'
	}

	/// <summary>A flagging enumeration whose value specifies whether an audio component is searchable. Used with <see cref="AudioComponentDescription.ComponentFlags" /></summary>
	[Flags]
	public enum AudioComponentFlag // UInt32 in AudioComponentDescription
	{
		/// <summary>Indicates unsearchable.</summary>
		Unsearchable = 1,
		/// <summary>Indicates sandbox safe.</summary>
		SandboxSafe = 2,
		/// <summary>Indicates is v3 audio unit.</summary>
		IsV3AudioUnit = 4,
		/// <summary>Indicates requires async instantiation.</summary>
		RequiresAsyncInstantiation = 8,
		/// <summary>Indicates can load in process.</summary>
		CanLoadInProcess = 0x10,
	}

	/// <include file="../../docs/api/AudioUnit/AudioComponentDescription.xml" path="/Documentation/Docs[@DocId='T:AudioUnit.AudioComponentDescription']/*" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct AudioComponentDescription {
		/// <summary>Describes the component type, some of the component types have subtypes, in those cases, you should also set the <see cref="AudioComponentDescription.ComponentSubType" /> property.</summary>
		///         <remarks>
		///           <para />
		///         </remarks>
		public AudioComponentType ComponentType;

#if !COREBUILD
		/// <include file="../../docs/api/AudioUnit/AudioComponentDescription.xml" path="/Documentation/Docs[@DocId='F:AudioUnit.AudioComponentDescription.ComponentSubType']/*" />
		public AudioUnitSubType ComponentSubType;
#else
		public int ComponentSubType;
#endif

		/// <summary>To be added.</summary>
		public AudioComponentManufacturerType ComponentManufacturer;

		/// <summary>To be added.</summary>
		public AudioComponentFlag ComponentFlags;
		/// <summary>To be added.</summary>
		public int ComponentFlagsMask;

		internal AudioComponentDescription (AudioComponentType type, int subType)
		{
			ComponentType = type;
#if !COREBUILD
			ComponentSubType = (AudioUnitSubType) subType;
#else
			ComponentSubType = subType;
#endif
			ComponentManufacturer = AudioComponentManufacturerType.Apple;
			ComponentFlags = (AudioComponentFlag) 0;
			ComponentFlagsMask = 0;
		}

		/// <param name="type">The type.</param>
		///         <param name="subType">The sub type.</param>
		///         <summary>Initializes an <see cref="AudioComponentDescription" /> with the given type and given subtype.   This method is here for cases where you might want to create a component description that is not covered by the built-in enumerations for component subtypes.</summary>
		///         <returns>To be added.</returns>
		public static AudioComponentDescription CreateGeneric (AudioComponentType type, int subType)
		{
			return new AudioComponentDescription (type, subType);
		}

		/// <param name="outputType">The output type.</param>
		///         <summary>Creates an output component description.</summary>
		///         <returns>An initialized AudioComponentDescription with the <see cref="AudioComponentDescription.ComponentType" /> set to <see cref="AudioComponentType.Output" /> and the specified output type.</returns>
		public static AudioComponentDescription CreateOutput (AudioTypeOutput outputType)
		{
			return new AudioComponentDescription (AudioComponentType.Output, (int) outputType);
		}

		/// <param name="musicDevice">The music device.</param>
		///         <summary>Creates a music effect component description.</summary>
		///         <returns>An initialized AudioComponentDescription with the <see cref="AudioComponentDescription.ComponentType" /> set to <see cref="AudioComponentType.MusicDevice" /> and the specified device.</returns>
		public static AudioComponentDescription CreateMusicDevice (AudioTypeMusicDevice musicDevice)
		{
			return new AudioComponentDescription (AudioComponentType.MusicDevice, (int) musicDevice);
		}

		/// <param name="converter">The converter.</param>
		///         <summary>Creates an audio converter component description.</summary>
		///         <returns>To be added.</returns>
		public static AudioComponentDescription CreateConverter (AudioTypeConverter converter)
		{
			return new AudioComponentDescription (AudioComponentType.FormatConverter, (int) converter);
		}

		/// <param name="effect">The effect.</param>
		///         <summary>Creates an audio effect component description.</summary>
		///         <returns>An initialized AudioComponentDescription with the <see cref="AudioComponentDescription.ComponentType" /> set to <see cref="AudioComponentType.Effect" /> and the specified effect.</returns>
		public static AudioComponentDescription CreateEffect (AudioTypeEffect effect)
		{
			return new AudioComponentDescription (AudioComponentType.Effect, (int) effect);
		}

		/// <param name="mixer">The mixer.</param>
		///         <summary>Creates an audio mixer component description.</summary>
		///         <returns>An initialized AudioComponentDescription with the <see cref="AudioComponentDescription.ComponentType" /> set to <see cref="AudioComponentType.Mixer" /> and the specified mixer.</returns>
		public static AudioComponentDescription CreateMixer (AudioTypeMixer mixer)
		{
			return new AudioComponentDescription (AudioComponentType.Mixer, (int) mixer);
		}

		/// <param name="panner">The panner.</param>
		///         <summary>Creates a panner component description.</summary>
		///         <returns>An initialized AudioComponentDescription with the <see cref="AudioComponentDescription.ComponentType" /> set to <see cref="AudioComponentType.Panner" /> and the specified panner.</returns>
		public static AudioComponentDescription CreatePanner (AudioTypePanner panner)
		{
			return new AudioComponentDescription (AudioComponentType.Panner, (int) panner);
		}

		/// <param name="generator">The generator.</param>
		///         <summary>Creates an audio generator component description.</summary>
		///         <returns>An initialized AudioComponentDescription with the <see cref="AudioComponentDescription.ComponentType" /> set to <see cref="AudioComponentType.Generator" /> and the specified generator.</returns>
		public static AudioComponentDescription CreateGenerator (AudioTypeGenerator generator)
		{
			return new AudioComponentDescription (AudioComponentType.Generator, (int) generator);
		}

		/// <summary>Returns a debugging message showing the component type and subtype for this description.</summary>
		///         <returns>To be added.</returns>
		public override string ToString ()
		{
			const string fmt = "[componentType={0}, subType={1}]";

			switch (ComponentType) {
			case AudioComponentType.Output:
				return String.Format (fmt, ComponentType, (AudioTypeOutput) ComponentSubType);
			case AudioComponentType.MusicDevice:
				return String.Format (fmt, ComponentType, (AudioTypeMusicDevice) ComponentSubType);
			case AudioComponentType.FormatConverter:
				return String.Format (fmt, ComponentType, (AudioTypeConverter) ComponentSubType);
			case AudioComponentType.Effect:
				return String.Format (fmt, ComponentType, (AudioTypeEffect) ComponentSubType);
			case AudioComponentType.Mixer:
				return String.Format (fmt, ComponentType, (AudioTypeMixer) ComponentSubType);
			case AudioComponentType.Panner:
				return String.Format (fmt, ComponentType, (AudioTypePanner) ComponentSubType);
			case AudioComponentType.Generator:
				return String.Format (fmt, ComponentType, (AudioTypeGenerator) ComponentSubType);
			default:
				return String.Format (fmt, ComponentType, ComponentSubType);
			}
		}
	}
}
