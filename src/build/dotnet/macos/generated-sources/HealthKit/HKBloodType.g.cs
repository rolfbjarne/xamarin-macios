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
namespace HealthKit {
	/// <summary>Enumerates known blood types.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKBloodType : long {
		/// <summary>The user's blood type is not recorded.</summary>
		NotSet = 0,
		/// <summary>The A+ blood type.</summary>
		APositive = 1,
		/// <summary>The A- blood type.</summary>
		ANegative = 2,
		/// <summary>The B+ blood type.</summary>
		BPositive = 3,
		/// <summary>The B- blood type.</summary>
		BNegative = 4,
		/// <summary>The AB+ blood type</summary>
		ABPositive = 5,
		/// <summary>The AB- blood type.</summary>
		ABNegative = 6,
		/// <summary>The O+ blood type.</summary>
		OPositive = 7,
		/// <summary>The O- blood type.</summary>
		ONegative = 8,
	}
}
