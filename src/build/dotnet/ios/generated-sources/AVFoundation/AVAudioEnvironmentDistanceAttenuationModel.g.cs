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
	/// <summary>Enumerates attenuation models used by <see cref="T:AVFoundation.AVAudioEnvironmentDistanceAttenuationParameters" />.</summary><remarks><para>Graph of <c>Gain</c> as Distance ranges from 0 to 10 with: <c>ReferenceDistance = 5</c>, <c>RolloffFactor = 0.5</c>, and <c>MaximumDistance = 20</c></para><para><see cref="F:AVFoundation.AVAudioEnvironmentDistanceAttenuationModel.Exponential" /></para><para><img href="~/xml/AVFoundation/_images/AVFoundation.AVAudioEnvironmentDistanceAttenuationModel.Exponential.png" alt="Graph of exponential attenuation"></img></para><para><see cref="F:AVFoundation.AVAudioEnvironmentDistanceAttenuationModel.Inverse" /></para><para><img href="~/xml/AVFoundation/_images/AVFoundation.AVAudioEnvironmentDistanceAttenuationModel.Inverse.png" alt="Graph of inverse attenuation"></img></para><para><see cref="F:AVFoundation.AVAudioEnvironmentDistanceAttenuationModel.Linear" /></para><para><img href="~/xml/AVFoundation/_images/AVFoundation.AVAudioEnvironmentDistanceAttenuationModel.Linear.png" alt="Graph of linear attenuation"></img></para></remarks>
	[Native]
	public enum AVAudioEnvironmentDistanceAttenuationModel : long {
		/// <summary>Gain = (Distance / ReferenceDistance)^(-RolloffFactor)</summary>
		Exponential = 1,
		/// <summary>Gain = ReferenceDistance / (ReferenceDistance + RolloffFactor * (Distance - ReferenceDistance))</summary>
		Inverse = 2,
		/// <summary>Gain = (1 - RolloffFactor * (Distance - ReferenceDistance) / (MaximumDistance - ReferenceDistance))</summary>
		Linear = 3,
	}
}
