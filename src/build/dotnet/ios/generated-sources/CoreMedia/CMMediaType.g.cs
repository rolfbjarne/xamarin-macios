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
namespace CoreMedia {
	/// <summary>An enumeration whose values specify valid types of media.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMMediaType : uint {
		/// <summary>To be added.</summary>
		Video = 1986618469,
		/// <summary>To be added.</summary>
		Audio = 1936684398,
		/// <summary>To be added.</summary>
		Muxed = 1836415096,
		/// <summary>To be added.</summary>
		Text = 1952807028,
		/// <summary>To be added.</summary>
		ClosedCaption = 1668047728,
		/// <summary>To be added.</summary>
		Subtitle = 1935832172,
		/// <summary>To be added.</summary>
		TimeCode = 1953325924,
		/// <summary>To be added.</summary>
		Metadata = 1835365473,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		TaggedBufferGroup = 1952606066,
	}
}
