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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreVideo {
	/// <summary>An enumeration whose values can flag validity of a timestamp or field in a <see cref="T:CoreVideo.CVTimeStamp" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	public enum CVTimeStampFlags : ulong {
		/// <summary>To be added.</summary>
		VideoTimeValid = 1,
		/// <summary>To be added.</summary>
		HostTimeValid = 2,
		/// <summary>To be added.</summary>
		SMPTETimeValid = 4,
		/// <summary>To be added.</summary>
		VideoRefreshPeriodValid = 8,
		/// <summary>To be added.</summary>
		RateScalarValid = 16,
		/// <summary>To be added.</summary>
		TopField = 65536,
		/// <summary>To be added.</summary>
		BottomField = 131072,
		/// <summary>To be added.</summary>
		VideoHostTimeValid = 3,
		/// <summary>To be added.</summary>
		IsInterlaced = 196608,
	}
}
