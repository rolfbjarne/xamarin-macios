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
namespace CoreNFC {
	/// <summary>Enumerates the kinds of content-type available to <see cref="T:CoreNFC.NFCNdefPayload" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum NFCTypeNameFormat : byte {
		/// <summary>The payload contains no data.</summary>
		Empty = 0,
		/// <summary>The data follows the NFC record-type definition specification.</summary>
		NFCWellKnown = 1,
		/// <summary>The data is a media type, as defined in RFC-2046.</summary>
		Media = 2,
		/// <summary>The data is a URI.</summary>
		AbsoluteUri = 3,
		/// <summary>The data is defined using the NFC record-type definition for external types.</summary>
		NFCExternal = 4,
		/// <summary>The data format is unknown.</summary>
		Unknown = 5,
		/// <summary>The data is part of a chunked-data record series and is not the initial record (which defines the overall format).</summary>
		Unchanged = 6,
	}
}
