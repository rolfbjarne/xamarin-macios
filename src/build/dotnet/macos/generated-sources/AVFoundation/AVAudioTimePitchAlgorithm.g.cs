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
	/// <summary>Defines constants for use with <see cref="P:AVFoundation.AVMutableAudioMixInputParameters.AudioTimePitchAlgorithm" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVAudioTimePitchAlgorithm  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Spectral;
		/// <summary>Represents the value associated with the constant AVAudioTimePitchAlgorithmSpectral</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVAudioTimePitchAlgorithmSpectral",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Spectral {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Spectral is null)
					_Spectral = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmSpectral")!;
				return _Spectral;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeDomain;
		/// <summary>Represents the value associated with the constant AVAudioTimePitchAlgorithmTimeDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVAudioTimePitchAlgorithmTimeDomain",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TimeDomain {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TimeDomain is null)
					_TimeDomain = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmTimeDomain")!;
				return _TimeDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Varispeed;
		/// <summary>Represents the value associated with the constant AVAudioTimePitchAlgorithmVarispeed</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVAudioTimePitchAlgorithmVarispeed",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Varispeed {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Varispeed is null)
					_Varispeed = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmVarispeed")!;
				return _Varispeed;
			}
		}
	} /* class AVAudioTimePitchAlgorithm */
}
