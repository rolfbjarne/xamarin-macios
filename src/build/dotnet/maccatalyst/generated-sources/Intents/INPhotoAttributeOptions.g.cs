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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	/// <summary>Enumerates various photo options.</summary>
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum INPhotoAttributeOptions : ulong {
		/// <summary>The media is a photograph.</summary>
		Photo = 1,
		/// <summary>The media is a video.</summary>
		Video = 2,
		/// <summary>The photo is stored in the GIF format.</summary>
		Gif = 4,
		/// <summary>The photo was taken with an artificial flash.</summary>
		Flash = 8,
		/// <summary>The photo's longer edge should be along the X axis.</summary>
		LandscapeOrientation = 16,
		/// <summary>The photo's longer edge should be along the Y axis.</summary>
		PortraitOrientation = 32,
		/// <summary>The user has indicated the photo is a favorite.</summary>
		Favorite = 64,
		/// <summary>The photo is of the photographer.</summary>
		Selfie = 128,
		/// <summary>The photo was taken with the front-facing camera.</summary>
		FrontFacingCamera = 256,
		/// <summary>The image is a screenshot. </summary>
		Screenshot = 512,
		/// <summary>Indicates a photo taken in a burst.</summary>
		BurstPhoto = 1024,
		/// <summary>The photo was constructed via the High-Dynamic Range process.</summary>
		HdrPhoto = 2048,
		/// <summary>The photo has a square aspect ratio.</summary>
		SquarePhoto = 4096,
		/// <summary>The photo was taken with the panoramic process.</summary>
		PanoramaPhoto = 8192,
		/// <summary>The media is a video recorded in the timelapse mode.</summary>
		TimeLapseVideo = 16384,
		/// <summary>The media is a video recorded in slow motion.</summary>
		SlowMotionVideo = 32768,
		/// <summary>The Noir image effect.</summary>
		NoirFilter = 65536,
		/// <summary>The Chrome image effect.</summary>
		ChromeFilter = 131072,
		/// <summary>The Instant image effect.</summary>
		InstantFilter = 262144,
		/// <summary>The Tonal image effect.</summary>
		TonalFilter = 524288,
		/// <summary>The Transfer image effect.</summary>
		TransferFilter = 1048576,
		/// <summary>The Monochrome image effect.</summary>
		MonoFilter = 2097152,
		/// <summary>The Fade image effect.</summary>
		FadeFilter = 4194304,
		/// <summary>The Process image effect.</summary>
		ProcessFilter = 8388608,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		PortraitPhoto = 16777216,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		LivePhoto = 33554432,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		LoopPhoto = 67108864,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		BouncePhoto = 134217728,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		LongExposurePhoto = 268435456,
	}
}
