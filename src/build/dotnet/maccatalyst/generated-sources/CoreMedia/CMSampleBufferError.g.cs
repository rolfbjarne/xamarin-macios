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
namespace CoreMedia {
	/// <summary>An enumeration whose values specify errors relating to <see cref="T:CoreMedia.CMSampleBuffer" />s.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMSampleBufferError : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		AllocationFailed = -12730,
		/// <summary>To be added.</summary>
		RequiredParameterMissing = -12731,
		/// <summary>To be added.</summary>
		AlreadyHasDataBuffer = -12732,
		/// <summary>To be added.</summary>
		BufferNotReady = -12733,
		/// <summary>To be added.</summary>
		SampleIndexOutOfRange = -12734,
		/// <summary>To be added.</summary>
		BufferHasNoSampleSizes = -12735,
		/// <summary>To be added.</summary>
		BufferHasNoSampleTimingInfo = -12736,
		/// <summary>To be added.</summary>
		ArrayTooSmall = -12737,
		/// <summary>To be added.</summary>
		InvalidEntryCount = -12738,
		/// <summary>To be added.</summary>
		CannotSubdivide = -12739,
		/// <summary>To be added.</summary>
		SampleTimingInfoInvalid = -12740,
		/// <summary>To be added.</summary>
		InvalidMediaTypeForOperation = -12741,
		/// <summary>To be added.</summary>
		InvalidSampleData = -12742,
		/// <summary>To be added.</summary>
		InvalidMediaFormat = -12743,
		/// <summary>To be added.</summary>
		Invalidated = -12744,
	}
}
