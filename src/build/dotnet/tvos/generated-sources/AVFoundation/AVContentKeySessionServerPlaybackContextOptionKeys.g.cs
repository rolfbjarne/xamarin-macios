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
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class AVContentKeySessionServerPlaybackContextOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtocolVersionsKey;
		/// <summary>Represents the value associated with the constant 'AVContentKeySessionServerPlaybackContextOptionProtocolVersions'.</summary>
		[Field ("AVContentKeySessionServerPlaybackContextOptionProtocolVersions",  "AVFoundation")]
		public static NSString ProtocolVersionsKey {
			get {
				if (_ProtocolVersionsKey is null)
					_ProtocolVersionsKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVContentKeySessionServerPlaybackContextOptionProtocolVersions")!;
				return _ProtocolVersionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServerChallengeKey;
		/// <summary>Represents the value associated with the constant 'AVContentKeySessionServerPlaybackContextOptionServerChallenge'.</summary>
		[Field ("AVContentKeySessionServerPlaybackContextOptionServerChallenge",  "AVFoundation")]
		public static NSString ServerChallengeKey {
			get {
				if (_ServerChallengeKey is null)
					_ServerChallengeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVContentKeySessionServerPlaybackContextOptionServerChallenge")!;
				return _ServerChallengeKey;
			}
		}
	} /* class AVContentKeySessionServerPlaybackContextOptionKeys */
}
