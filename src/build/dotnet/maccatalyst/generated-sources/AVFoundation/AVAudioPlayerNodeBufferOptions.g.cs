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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	/// <summary>Flagging enumeration whose values are valid options in calls to <see cref="AVFoundation.AVAudioPlayerNode.ScheduleBufferAsync(AVFoundation.AVAudioPcmBuffer,AVFoundation.AVAudioTime,AVFoundation.AVAudioPlayerNodeBufferOptions,AVFoundation.AVAudioPlayerNodeCompletionCallbackType)" /></summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum AVAudioPlayerNodeBufferOptions : ulong {
		/// <summary>The buffer should loop indefinitely.</summary>
		Loops = 1,
		/// <summary>The buffer should interrupt any other buffer that is already playing.</summary>
		Interrupts = 2,
		/// <summary>The buffer should interrupt any other buffer at its loop point.</summary>
		InterruptsAtLoop = 4,
	}
}
