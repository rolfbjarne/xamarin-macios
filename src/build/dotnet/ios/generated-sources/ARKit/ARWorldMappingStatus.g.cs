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
namespace ARKit {
	/// <summary>Enumerates the states of a world-mapping session.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum ARWorldMappingStatus : long {
		/// <summary>No real-world map is available.</summary>
		NotAvailable = 0,
		/// <summary>Not enough data has been gathered to accurately fix the device in space.</summary>
		Limited = 1,
		/// <summary>Some areas have been mapped, but further mapping is still required.</summary>
		Extending = 2,
		/// <summary>There is enough data to accurately track the device in the real world.</summary>
		Mapped = 3,
	}
}
