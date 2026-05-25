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
	/// <summary>Enumerates the user's cervical mucus quality.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKCategoryValueCervicalMucusQuality : long {
		/// <summary>Either not recorded or permissions not given.</summary>
		NotApplicable = 0,
		/// <summary>Little or no mucus.</summary>
		Dry = 1,
		/// <summary>Sticky mucus.</summary>
		Sticky = 2,
		/// <summary>Creamy mucus.</summary>
		Creamy = 3,
		/// <summary>Watery mucus.</summary>
		Watery = 4,
		/// <summary>Mucus the color and consistency of egg whites.</summary>
		EggWhite = 5,
	}
}
