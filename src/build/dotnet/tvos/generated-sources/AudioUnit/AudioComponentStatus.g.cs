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
namespace AudioUnit {
	/// <summary>Enumerates status values returned by <see cref="AudioUnit.AudioOutputUnitPublish(AudioComponentDescription,System.String,System.UInt32)" />.</summary>
	public enum AudioComponentStatus : int {
		/// <summary>To be added.</summary>
		OK = 0,
		/// <summary>To be added.</summary>
		DuplicateDescription = -66752,
		/// <summary>To be added.</summary>
		UnsupportedType = -66751,
		/// <summary>To be added.</summary>
		TooManyInstances = -66750,
		InstanceTimedOut = -66754,
		/// <summary>To be added.</summary>
		InstanceInvalidated = -66749,
		/// <summary>To be added.</summary>
		NotPermitted = -66748,
		/// <summary>To be added.</summary>
		InitializationTimedOut = -66747,
		/// <summary>To be added.</summary>
		InvalidFormat = -66746,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RenderTimeout = -66745,
	}
}
