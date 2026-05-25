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
	/// <summary>A flagging enumeration of formatting options for use with <see cref="T:Foundation.NSIso8601DateFormatter" />.</summary><remarks><para>It is often easier to code a format by removing flags from <see cref="F:Foundation.NSIso8601DateFormatOptions.InternetDateTime" /> such as:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// fmt.FormatOptions = fmt.FormatOptions & ~NSIso8601DateFormatOptions.Day
	/// var s = fmt.StringFor(d); //"2016-08T23:15:36Z"          
	/// ]]></code></example></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum NSIso8601DateFormatOptions : ulong {
		/// <summary>Includes the year in the string.</summary>
		Year = 1,
		/// <summary>Includes the month in the string.</summary>
		Month = 2,
		/// <summary>Includes the week of the year in the string (e.g., "W33").</summary>
		WeekOfYear = 4,
		/// <summary>Includes the day in the string.</summary>
		Day = 16,
		/// <summary>Includes the time in the string.</summary>
		Time = 32,
		/// <summary>Includes the timezone in the string.</summary>
		TimeZone = 64,
		/// <summary>Puts a space between the date and the time.</summary>
		SpaceBetweenDateAndTime = 128,
		/// <summary>Separates date components with a dash.</summary>
		DashSeparatorInDate = 256,
		/// <summary>Puts a colon between time components</summary>
		ColonSeparatorInTime = 512,
		/// <summary>Puts a colon in the time.</summary>
		ColonSeparatorInTimeZone = 1024,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		FractionalSeconds = 2048,
		/// <summary>Includes the date in the string.</summary>
		FullDate = 275,
		/// <summary>Includes the time in the string.</summary>
		FullTime = 1632,
		/// <summary>The standard ISO-8601 format (<c>yyyy-MM-ddTHH:mm:ssZ</c>).</summary>
		InternetDateTime = 1907,
	}
}
