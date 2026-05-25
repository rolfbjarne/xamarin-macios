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
namespace MediaPlayer {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MPLanguageOptionCharacteristics  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsOnlyForcedSubtitles;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicContainsOnlyForcedSubtitles",  "MediaPlayer")]
		public static NSString ContainsOnlyForcedSubtitles {
			get {
				if (_ContainsOnlyForcedSubtitles is null)
					_ContainsOnlyForcedSubtitles = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicContainsOnlyForcedSubtitles")!;
				return _ContainsOnlyForcedSubtitles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescribesMusicAndSound;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicDescribesMusicAndSound",  "MediaPlayer")]
		public static NSString DescribesMusicAndSound {
			get {
				if (_DescribesMusicAndSound is null)
					_DescribesMusicAndSound = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicDescribesMusicAndSound")!;
				return _DescribesMusicAndSound;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescribesVideo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicDescribesVideo",  "MediaPlayer")]
		public static NSString DescribesVideo {
			get {
				if (_DescribesVideo is null)
					_DescribesVideo = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicDescribesVideo")!;
				return _DescribesVideo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DubbedTranslation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicDubbedTranslation",  "MediaPlayer")]
		public static NSString DubbedTranslation {
			get {
				if (_DubbedTranslation is null)
					_DubbedTranslation = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicDubbedTranslation")!;
				return _DubbedTranslation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EasyToRead;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicEasyToRead",  "MediaPlayer")]
		public static NSString EasyToRead {
			get {
				if (_EasyToRead is null)
					_EasyToRead = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicEasyToRead")!;
				return _EasyToRead;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsAuxiliaryContent;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicIsAuxiliaryContent",  "MediaPlayer")]
		public static NSString IsAuxiliaryContent {
			get {
				if (_IsAuxiliaryContent is null)
					_IsAuxiliaryContent = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicIsAuxiliaryContent")!;
				return _IsAuxiliaryContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsMainProgramContent;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicIsMainProgramContent",  "MediaPlayer")]
		public static NSString IsMainProgramContent {
			get {
				if (_IsMainProgramContent is null)
					_IsMainProgramContent = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicIsMainProgramContent")!;
				return _IsMainProgramContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LanguageTranslation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicLanguageTranslation",  "MediaPlayer")]
		public static NSString LanguageTranslation {
			get {
				if (_LanguageTranslation is null)
					_LanguageTranslation = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicLanguageTranslation")!;
				return _LanguageTranslation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TranscribesSpokenDialog;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicTranscribesSpokenDialog",  "MediaPlayer")]
		public static NSString TranscribesSpokenDialog {
			get {
				if (_TranscribesSpokenDialog is null)
					_TranscribesSpokenDialog = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicTranscribesSpokenDialog")!;
				return _TranscribesSpokenDialog;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VoiceOverTranslation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPLanguageOptionCharacteristicVoiceOverTranslation",  "MediaPlayer")]
		public static NSString VoiceOverTranslation {
			get {
				if (_VoiceOverTranslation is null)
					_VoiceOverTranslation = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicVoiceOverTranslation")!;
				return _VoiceOverTranslation;
			}
		}
	} /* class MPLanguageOptionCharacteristics */
}
