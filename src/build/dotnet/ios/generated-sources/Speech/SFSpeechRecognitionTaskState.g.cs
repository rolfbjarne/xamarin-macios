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
namespace Speech {
	/// <summary>Enumerates the states of a <see cref="T:Speech.SFSpeechRecognitionTask" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[Native]
	public enum SFSpeechRecognitionTaskState : long {
		/// <summary>The recognition task is beginning.</summary>
		Starting = 0,
		/// <summary>The task is attempting to recognize speech.</summary>
		Running = 1,
		/// <summary>The task is ending.</summary>
		Finishing = 2,
		/// <summary>Speech recognition is in the process of being canceled.</summary>
		Canceling = 3,
		/// <summary>Speech recognition has completed.</summary>
		Completed = 4,
	}
}
