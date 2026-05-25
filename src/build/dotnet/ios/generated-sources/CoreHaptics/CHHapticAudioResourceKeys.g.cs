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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class CHHapticAudioResourceKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LoopEnabledKey;
		/// <summary>Represents the value associated with the constant 'CHHapticAudioResourceKeyLoopEnabled'.</summary>
		[Field ("CHHapticAudioResourceKeyLoopEnabled",  "CoreHaptics")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString LoopEnabledKey {
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_LoopEnabledKey is null)
					_LoopEnabledKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticAudioResourceKeyLoopEnabled")!;
				return _LoopEnabledKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseVolumeEnvelopeKey;
		/// <summary>Represents the value associated with the constant 'CHHapticAudioResourceKeyUseVolumeEnvelope'.</summary>
		[Field ("CHHapticAudioResourceKeyUseVolumeEnvelope",  "CoreHaptics")]
		public static NSString UseVolumeEnvelopeKey {
			get {
				if (_UseVolumeEnvelopeKey is null)
					_UseVolumeEnvelopeKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticAudioResourceKeyUseVolumeEnvelope")!;
				return _UseVolumeEnvelopeKey;
			}
		}
	} /* class CHHapticAudioResourceKeys */
}
