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
namespace Foundation {
	/// <summary>A flagging enumeration whose values can be used with <see cref="M:Foundation.NSProcessInfo.BeginActivity(Foundation.NSActivityOptions,System.String)" />.</summary><remarks>To be added.</remarks>
	[Flags]
	public enum NSActivityOptions : ulong {
		/// <summary>To be added.</summary>
		IdleDisplaySleepDisabled = 1099511627776,
		/// <summary>To be added.</summary>
		IdleSystemSleepDisabled = 1048576,
		/// <summary>To be added.</summary>
		SuddenTerminationDisabled = 16384,
		/// <summary>To be added.</summary>
		AutomaticTerminationDisabled = 32768,
		AnimationTrackingEnabled = 35184372088832,
		TrackingEnabled = 70368744177664,
		UserInteractive = 1095233437695,
		/// <summary>To be added.</summary>
		UserInitiated = 16777215,
		/// <summary>To be added.</summary>
		Background = 255,
		/// <summary>To be added.</summary>
		LatencyCritical = 1095216660480,
		InitiatedAllowingIdleSystemSleep = 15728639,
	}
}
