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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum NSWindowCollectionBehavior : ulong {
		/// <summary>To be added.</summary>
		Default = 0,
		/// <summary>To be added.</summary>
		CanJoinAllSpaces = 1,
		/// <summary>To be added.</summary>
		MoveToActiveSpace = 2,
		/// <summary>To be added.</summary>
		Managed = 4,
		/// <summary>To be added.</summary>
		Transient = 8,
		/// <summary>To be added.</summary>
		Stationary = 16,
		/// <summary>To be added.</summary>
		ParticipatesInCycle = 32,
		/// <summary>To be added.</summary>
		IgnoresCycle = 64,
		/// <summary>To be added.</summary>
		FullScreenPrimary = 128,
		/// <summary>To be added.</summary>
		FullScreenAuxiliary = 256,
		/// <summary>To be added.</summary>
		FullScreenNone = 512,
		/// <summary>To be added.</summary>
		FullScreenAllowsTiling = 2048,
		/// <summary>To be added.</summary>
		FullScreenDisallowsTiling = 4096,
		Primary = 65536,
		Auxiliary = 131072,
		CanJoinAllApplications = 262144,
	}
}
