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
namespace AVFoundation {
	/// <summary>Enumerates the types of audio processing plug-ins.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVAudioUnitType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Effect;
		/// <summary>Indicates that the underlying audio unit is an effect.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeEffect",  "AVFoundation")]
		public static NSString Effect {
			get {
				if (_Effect is null)
					_Effect = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeEffect")!;
				return _Effect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FormatConverter;
		/// <summary>Indicates that the underlying audio unit is a format converter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeFormatConverter",  "AVFoundation")]
		public static NSString FormatConverter {
			get {
				if (_FormatConverter is null)
					_FormatConverter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeFormatConverter")!;
				return _FormatConverter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Generator;
		/// <summary>Indicates that the underlying audio unit is a generator.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeGenerator",  "AVFoundation")]
		public static NSString Generator {
			get {
				if (_Generator is null)
					_Generator = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeGenerator")!;
				return _Generator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MidiProcessor;
		/// <summary>Indicates that the underlying audio unit is a MIDI processor.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeMIDIProcessor",  "AVFoundation")]
		public static NSString MidiProcessor {
			get {
				if (_MidiProcessor is null)
					_MidiProcessor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeMIDIProcessor")!;
				return _MidiProcessor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mixer;
		/// <summary>Indicates that the underlying audio unit is a mixer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeMixer",  "AVFoundation")]
		public static NSString Mixer {
			get {
				if (_Mixer is null)
					_Mixer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeMixer")!;
				return _Mixer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MusicDevice;
		/// <summary>Indicates that the underlying audio unit is a music device.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeMusicDevice",  "AVFoundation")]
		public static NSString MusicDevice {
			get {
				if (_MusicDevice is null)
					_MusicDevice = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeMusicDevice")!;
				return _MusicDevice;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MusicEffect;
		/// <summary>Indicates that the underlying audio unit is a music effect.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeMusicEffect",  "AVFoundation")]
		public static NSString MusicEffect {
			get {
				if (_MusicEffect is null)
					_MusicEffect = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeMusicEffect")!;
				return _MusicEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OfflineEffect;
		/// <summary>Indicates that the underlying audio unit is an offline effect.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeOfflineEffect",  "AVFoundation")]
		public static NSString OfflineEffect {
			get {
				if (_OfflineEffect is null)
					_OfflineEffect = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeOfflineEffect")!;
				return _OfflineEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Output;
		/// <summary>Indicates that the underlying audio unit is an output unit.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypeOutput",  "AVFoundation")]
		public static NSString Output {
			get {
				if (_Output is null)
					_Output = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypeOutput")!;
				return _Output;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Panner;
		/// <summary>Indicates that the underlying audio unit is a panner.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioUnitTypePanner",  "AVFoundation")]
		public static NSString Panner {
			get {
				if (_Panner is null)
					_Panner = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitTypePanner")!;
				return _Panner;
			}
		}
	} /* class AVAudioUnitType */
}
