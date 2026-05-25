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
namespace UIKit {
	/// <summary>Enumerates desired page cutting behavior for roll-feed printers.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIPrinterCutterBehavior : long {
		/// <summary>Indicates that the printer should not cut pages.</summary>
		NoCut = 0,
		/// <summary>Indicates that the printer's default behavior should be used.</summary>
		PrinterDefault = 1,
		/// <summary>Indicates that the paper is cut after each page is printed.</summary>
		CutAfterEachPage = 2,
		/// <summary>Indicates that the paper is cut after each copy of the document is printed.</summary>
		CutAfterEachCopy = 3,
		/// <summary>Indicates that the paper is cut after each print job is completed.</summary>
		CutAfterEachJob = 4,
	}
}
