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
namespace NotificationCenter {
	/// <summary>Enumerates values that describe what happened after the application developer attempted to change the state of a widget by using the <see cref="M:NotificationCenter.NCWidgetProviding.WidgetPerformUpdate(System.Action{NotificationCenter.NCUpdateResult})" /> method.</summary>
	[ObsoletedOSPlatform ("ios14.0")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum NCUpdateResult : ulong {
		/// <summary>The widget has new data and may need to update its displayed values, if any.</summary>
		NewData = 0,
		/// <summary>The update succeeded, but no new data resulted.</summary>
		NoData = 1,
		/// <summary>The update failed.</summary>
		Failed = 2,
	}
}
