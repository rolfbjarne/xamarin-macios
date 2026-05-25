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
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum NSAppleEventSendOptions : ulong {
		/// <summary>To be added.</summary>
		NoReply = 1,
		/// <summary>To be added.</summary>
		QueueReply = 2,
		/// <summary>To be added.</summary>
		WaitForReply = 3,
		/// <summary>To be added.</summary>
		NeverInteract = 16,
		/// <summary>To be added.</summary>
		CanInteract = 32,
		/// <summary>To be added.</summary>
		AlwaysInteract = 48,
		/// <summary>To be added.</summary>
		CanSwitchLayer = 64,
		/// <summary>To be added.</summary>
		DontRecord = 4096,
		/// <summary>To be added.</summary>
		DontExecute = 8192,
		/// <summary>To be added.</summary>
		DontAnnotate = 65536,
		/// <summary>To be added.</summary>
		DefaultOptions = 35,
	}
}
