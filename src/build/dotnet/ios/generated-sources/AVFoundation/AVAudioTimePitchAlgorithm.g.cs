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
	/// <summary>Defines constants for use with <see cref="P:AVFoundation.AVMutableAudioMixInputParameters.AudioTimePitchAlgorithm" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVAudioTimePitchAlgorithm  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LowQualityZeroLatency;
		/// <summary>Represents the value associated with the constant AVAudioTimePitchAlgorithmLowQualityZeroLatency</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVAudioTimePitchAlgorithmLowQualityZeroLatency",  "AVFoundation")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString LowQualityZeroLatency {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_LowQualityZeroLatency is null)
					_LowQualityZeroLatency = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmLowQualityZeroLatency")!;
				return _LowQualityZeroLatency;
			}
		}
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
