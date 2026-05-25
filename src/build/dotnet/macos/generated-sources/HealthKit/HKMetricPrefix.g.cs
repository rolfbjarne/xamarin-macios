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
	/// <summary>Enumerates metric prefixes, e.g., Centi-, Deca-, Deci-. Used with factory methods of <see cref="T:HealthKit.HKUnit" />.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKMetricPrefix : long {
		/// <summary>No prefix</summary>
		None = 0,
		/// <summary>The "pico-" prefix.</summary>
		Pico = 1,
		/// <summary>The "nano-" prefix.</summary>
		Nano = 2,
		/// <summary>The "micro-" prefix.</summary>
		Micro = 3,
		/// <summary>The "milli-" prefix.</summary>
		Milli = 4,
		/// <summary>The "centi-" prefix.</summary>
		Centi = 5,
		/// <summary>The "deci-" prefix.</summary>
		Deci = 6,
		/// <summary>The "deca-" prefix.</summary>
		Deca = 7,
		/// <summary>The "hecto-" prefix.</summary>
		Hecto = 8,
		/// <summary>The "kilo-" prefix.</summary>
		Kilo = 9,
		/// <summary>The "mega-" prefix.</summary>
		Mega = 10,
		/// <summary>The "giga-" prefix.</summary>
		Giga = 11,
		/// <summary>The "tera-" prefix.</summary>
		Tera = 12,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Femto = 13,
	}
}
