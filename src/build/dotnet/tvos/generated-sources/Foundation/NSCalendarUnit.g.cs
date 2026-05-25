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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>An enumeration whose values specify calendrical units (e.g., seconds, months, eras).</summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum NSCalendarUnit : ulong {
		/// <summary>To be added.</summary>
		Era = 2,
		/// <summary>To be added.</summary>
		Year = 4,
		/// <summary>To be added.</summary>
		Month = 8,
		/// <summary>To be added.</summary>
		Day = 16,
		/// <summary>To be added.</summary>
		Hour = 32,
		/// <summary>To be added.</summary>
		Minute = 64,
		/// <summary>To be added.</summary>
		Second = 128,
		/// <summary>Developers should not use this deprecated field. </summary>
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Week = 256,
		/// <summary>To be added.</summary>
		Weekday = 512,
		/// <summary>To be added.</summary>
		WeekdayOrdinal = 1024,
		/// <summary>To be added.</summary>
		Quarter = 2048,
		/// <summary>To be added.</summary>
		WeekOfMonth = 4096,
		/// <summary>To be added.</summary>
		WeekOfYear = 8192,
		/// <summary>To be added.</summary>
		YearForWeakOfYear = 16384,
		/// <summary>To be added.</summary>
		Nanosecond = 32768,
		DayOfYear = 65536,
		/// <summary>To be added.</summary>
		Calendar = 1048576,
		/// <summary>To be added.</summary>
		TimeZone = 2097152,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		IsLeapMonth = 1073741824,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		IsRepeatedDay = 2147483648,
	}
}
