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
	/// <summary>Contains the key values used to configure the AVAudioRecorder using its Settings dictionary.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVAudioSettings  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVChannelLayoutKey;
		/// <summary>Represents the value associated with the constant AVChannelLayoutKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVChannelLayoutKey",  "AVFoundation")]
		public static NSString AVChannelLayoutKey {
			get {
				if (_AVChannelLayoutKey is null)
					_AVChannelLayoutKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVChannelLayoutKey")!;
				return _AVChannelLayoutKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderAspFrequencyKey;
		/// <summary>Represents the value associated with the constant 'AVEncoderASPFrequencyKey'.</summary>
		[Field ("AVEncoderASPFrequencyKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static NSString AVEncoderAspFrequencyKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_AVEncoderAspFrequencyKey is null)
					_AVEncoderAspFrequencyKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderASPFrequencyKey")!;
				return _AVEncoderAspFrequencyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderAudioQualityForVBRKey;
		/// <summary>Represents the value associated with the constant 'AVEncoderAudioQualityForVBRKey'.</summary>
		[Field ("AVEncoderAudioQualityForVBRKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString AVEncoderAudioQualityForVBRKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVEncoderAudioQualityForVBRKey is null)
					_AVEncoderAudioQualityForVBRKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderAudioQualityForVBRKey")!;
				return _AVEncoderAudioQualityForVBRKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderAudioQualityKey;
		/// <summary>Represents the value associated with the constant AVEncoderAudioQualityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVEncoderAudioQualityKey",  "AVFoundation")]
		public static NSString AVEncoderAudioQualityKey {
			get {
				if (_AVEncoderAudioQualityKey is null)
					_AVEncoderAudioQualityKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderAudioQualityKey")!;
				return _AVEncoderAudioQualityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderBitDepthHintKey;
		/// <summary>Represents the value associated with the constant AVEncoderBitDepthHintKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVEncoderBitDepthHintKey",  "AVFoundation")]
		public static NSString AVEncoderBitDepthHintKey {
			get {
				if (_AVEncoderBitDepthHintKey is null)
					_AVEncoderBitDepthHintKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderBitDepthHintKey")!;
				return _AVEncoderBitDepthHintKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderBitRateKey;
		/// <summary>Represents the value associated with the constant AVEncoderBitRateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVEncoderBitRateKey",  "AVFoundation")]
		public static NSString AVEncoderBitRateKey {
			get {
				if (_AVEncoderBitRateKey is null)
					_AVEncoderBitRateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderBitRateKey")!;
				return _AVEncoderBitRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderBitRatePerChannelKey;
		/// <summary>Represents the value associated with the constant AVEncoderBitRatePerChannelKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVEncoderBitRatePerChannelKey",  "AVFoundation")]
		public static NSString AVEncoderBitRatePerChannelKey {
			get {
				if (_AVEncoderBitRatePerChannelKey is null)
					_AVEncoderBitRatePerChannelKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderBitRatePerChannelKey")!;
				return _AVEncoderBitRatePerChannelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderBitRateStrategyKey;
		/// <summary>Represents the value associated with the constant 'AVEncoderBitRateStrategyKey'.</summary>
		[Field ("AVEncoderBitRateStrategyKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString AVEncoderBitRateStrategyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVEncoderBitRateStrategyKey is null)
					_AVEncoderBitRateStrategyKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderBitRateStrategyKey")!;
				return _AVEncoderBitRateStrategyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderContentSourceKey;
		/// <summary>Represents the value associated with the constant 'AVEncoderContentSourceKey'.</summary>
		[Field ("AVEncoderContentSourceKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static NSString AVEncoderContentSourceKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_AVEncoderContentSourceKey is null)
					_AVEncoderContentSourceKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderContentSourceKey")!;
				return _AVEncoderContentSourceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVEncoderDynamicRangeControlConfigurationKey;
		/// <summary>Represents the value associated with the constant 'AVEncoderDynamicRangeControlConfigurationKey'.</summary>
		[Field ("AVEncoderDynamicRangeControlConfigurationKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static NSString AVEncoderDynamicRangeControlConfigurationKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_AVEncoderDynamicRangeControlConfigurationKey is null)
					_AVEncoderDynamicRangeControlConfigurationKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVEncoderDynamicRangeControlConfigurationKey")!;
				return _AVEncoderDynamicRangeControlConfigurationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVFormatIDKey;
		/// <summary>Represents the value associated with the constant AVFormatIDKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVFormatIDKey",  "AVFoundation")]
		public static NSString AVFormatIDKey {
			get {
				if (_AVFormatIDKey is null)
					_AVFormatIDKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVFormatIDKey")!;
				return _AVFormatIDKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVLinearPCMBitDepthKey;
		/// <summary>Represents the value associated with the constant AVLinearPCMBitDepthKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVLinearPCMBitDepthKey",  "AVFoundation")]
		public static NSString AVLinearPCMBitDepthKey {
			get {
				if (_AVLinearPCMBitDepthKey is null)
					_AVLinearPCMBitDepthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVLinearPCMBitDepthKey")!;
				return _AVLinearPCMBitDepthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVLinearPCMIsBigEndianKey;
		/// <summary>Represents the value associated with the constant AVLinearPCMIsBigEndianKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVLinearPCMIsBigEndianKey",  "AVFoundation")]
		public static NSString AVLinearPCMIsBigEndianKey {
			get {
				if (_AVLinearPCMIsBigEndianKey is null)
					_AVLinearPCMIsBigEndianKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVLinearPCMIsBigEndianKey")!;
				return _AVLinearPCMIsBigEndianKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVLinearPCMIsFloatKey;
		/// <summary>Represents the value associated with the constant AVLinearPCMIsFloatKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVLinearPCMIsFloatKey",  "AVFoundation")]
		public static NSString AVLinearPCMIsFloatKey {
			get {
				if (_AVLinearPCMIsFloatKey is null)
					_AVLinearPCMIsFloatKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVLinearPCMIsFloatKey")!;
				return _AVLinearPCMIsFloatKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVLinearPCMIsNonInterleaved;
		/// <summary>Represents the value associated with the constant AVLinearPCMIsNonInterleaved</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVLinearPCMIsNonInterleaved",  "AVFoundation")]
		public static NSString AVLinearPCMIsNonInterleaved {
			get {
				if (_AVLinearPCMIsNonInterleaved is null)
					_AVLinearPCMIsNonInterleaved = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVLinearPCMIsNonInterleaved")!;
				return _AVLinearPCMIsNonInterleaved;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVNumberOfChannelsKey;
		/// <summary>Represents the value associated with the constant AVNumberOfChannelsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVNumberOfChannelsKey",  "AVFoundation")]
		public static NSString AVNumberOfChannelsKey {
			get {
				if (_AVNumberOfChannelsKey is null)
					_AVNumberOfChannelsKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVNumberOfChannelsKey")!;
				return _AVNumberOfChannelsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVSampleRateConverterAlgorithmKey;
		/// <summary>Represents the value associated with the constant 'AVSampleRateConverterAlgorithmKey'.</summary>
		[Field ("AVSampleRateConverterAlgorithmKey",  "AVFoundation")]
		internal static NSString AVSampleRateConverterAlgorithmKey {
			get {
				if (_AVSampleRateConverterAlgorithmKey is null)
					_AVSampleRateConverterAlgorithmKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithmKey")!;
				return _AVSampleRateConverterAlgorithmKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVSampleRateConverterAlgorithm_Mastering;
		/// <summary>Represents the value associated with the constant 'AVSampleRateConverterAlgorithm_Mastering'.</summary>
		[Field ("AVSampleRateConverterAlgorithm_Mastering",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString AVSampleRateConverterAlgorithm_Mastering {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVSampleRateConverterAlgorithm_Mastering is null)
					_AVSampleRateConverterAlgorithm_Mastering = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithm_Mastering")!;
				return _AVSampleRateConverterAlgorithm_Mastering;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVSampleRateConverterAlgorithm_MinimumPhase;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVSampleRateConverterAlgorithm_MinimumPhase",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AVSampleRateConverterAlgorithm_MinimumPhase {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVSampleRateConverterAlgorithm_MinimumPhase is null)
					_AVSampleRateConverterAlgorithm_MinimumPhase = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithm_MinimumPhase")!;
				return _AVSampleRateConverterAlgorithm_MinimumPhase;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVSampleRateConverterAlgorithm_Normal;
		/// <summary>Represents the value associated with the constant 'AVSampleRateConverterAlgorithm_Normal'.</summary>
		[Field ("AVSampleRateConverterAlgorithm_Normal",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString AVSampleRateConverterAlgorithm_Normal {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVSampleRateConverterAlgorithm_Normal is null)
					_AVSampleRateConverterAlgorithm_Normal = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithm_Normal")!;
				return _AVSampleRateConverterAlgorithm_Normal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVSampleRateConverterAudioQualityKey;
		/// <summary>Represents the value associated with the constant AVSampleRateConverterAudioQualityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVSampleRateConverterAudioQualityKey",  "AVFoundation")]
		public static NSString AVSampleRateConverterAudioQualityKey {
			get {
				if (_AVSampleRateConverterAudioQualityKey is null)
					_AVSampleRateConverterAudioQualityKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVSampleRateConverterAudioQualityKey")!;
				return _AVSampleRateConverterAudioQualityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVSampleRateKey;
		/// <summary>Represents the value associated with the constant AVSampleRateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVSampleRateKey",  "AVFoundation")]
		public static NSString AVSampleRateKey {
			get {
				if (_AVSampleRateKey is null)
					_AVSampleRateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVSampleRateKey")!;
				return _AVSampleRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileTypeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAudioFileTypeKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileTypeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileTypeKey is null)
					_FileTypeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioFileTypeKey")!;
				return _FileTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Constant;
		/// <summary>Represents the value associated with the constant 'AVAudioBitRateStrategy_Constant'.</summary>
		[Field ("AVAudioBitRateStrategy_Constant",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _Constant {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__Constant is null)
					__Constant = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_Constant")!;
				return __Constant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __LongTermAverage;
		/// <summary>Represents the value associated with the constant 'AVAudioBitRateStrategy_LongTermAverage'.</summary>
		[Field ("AVAudioBitRateStrategy_LongTermAverage",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _LongTermAverage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__LongTermAverage is null)
					__LongTermAverage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_LongTermAverage")!;
				return __LongTermAverage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Variable;
		/// <summary>Represents the value associated with the constant 'AVAudioBitRateStrategy_Variable'.</summary>
		[Field ("AVAudioBitRateStrategy_Variable",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _Variable {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__Variable is null)
					__Variable = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_Variable")!;
				return __Variable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __VariableConstrained;
		/// <summary>Represents the value associated with the constant 'AVAudioBitRateStrategy_VariableConstrained'.</summary>
		[Field ("AVAudioBitRateStrategy_VariableConstrained",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _VariableConstrained {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__VariableConstrained is null)
					__VariableConstrained = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_VariableConstrained")!;
				return __VariableConstrained;
			}
		}
	} /* class AVAudioSettings */
}
