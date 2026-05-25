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
namespace MediaAccessibility {
	public unsafe static partial class MAMediaCharacteristic  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescribesMusicAndSoundForAccessibility;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MAMediaCharacteristicDescribesMusicAndSoundForAccessibility",  "MediaAccessibility")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DescribesMusicAndSoundForAccessibility {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DescribesMusicAndSoundForAccessibility is null)
					_DescribesMusicAndSoundForAccessibility = Dlfcn.GetStringConstant (Libraries.MediaAccessibility.Handle, "MAMediaCharacteristicDescribesMusicAndSoundForAccessibility")!;
				return _DescribesMusicAndSoundForAccessibility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescribesVideoForAccessibility;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MAMediaCharacteristicDescribesVideoForAccessibility",  "MediaAccessibility")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DescribesVideoForAccessibility {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DescribesVideoForAccessibility is null)
					_DescribesVideoForAccessibility = Dlfcn.GetStringConstant (Libraries.MediaAccessibility.Handle, "MAMediaCharacteristicDescribesVideoForAccessibility")!;
				return _DescribesVideoForAccessibility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TranscribesSpokenDialogForAccessibility;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MAMediaCharacteristicTranscribesSpokenDialogForAccessibility",  "MediaAccessibility")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TranscribesSpokenDialogForAccessibility {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TranscribesSpokenDialogForAccessibility is null)
					_TranscribesSpokenDialogForAccessibility = Dlfcn.GetStringConstant (Libraries.MediaAccessibility.Handle, "MAMediaCharacteristicTranscribesSpokenDialogForAccessibility")!;
				return _TranscribesSpokenDialogForAccessibility;
			}
		}
	} /* class MAMediaCharacteristic */
}
