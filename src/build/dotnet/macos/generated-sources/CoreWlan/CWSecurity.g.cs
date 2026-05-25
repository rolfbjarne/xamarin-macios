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
namespace CoreWlan {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CWSecurity : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		WEP = 1,
		/// <summary>To be added.</summary>
		WPAPersonal = 2,
		/// <summary>To be added.</summary>
		WPAPersonalMixed = 3,
		/// <summary>To be added.</summary>
		WPA2Personal = 4,
		/// <summary>To be added.</summary>
		Personal = 5,
		/// <summary>To be added.</summary>
		DynamicWEP = 6,
		/// <summary>To be added.</summary>
		WPAEnterprise = 7,
		/// <summary>To be added.</summary>
		WPAEnterpriseMixed = 8,
		/// <summary>To be added.</summary>
		WPA2Enterprise = 9,
		/// <summary>To be added.</summary>
		Enterprise = 10,
		Wpa3Personal = 11,
		Wpa3Enterprise = 12,
		Wpa3Transition = 13,
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Owe = 14,
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		OweTransition = 15,
		/// <summary>To be added.</summary>
		Unknown = 9223372036854775807,
	}
}
