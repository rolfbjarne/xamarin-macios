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
	/// <summary>Enumerates various types of printing tasks. Used with <see cref="P:UIKit.UIPrinter.SupportedJobTypes" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIPrinterJobTypes : long {
		/// <summary>Printer support is unknown.</summary>
		Unknown = 0,
		/// <summary>Supports standard printing of documents.</summary>
		Document = 1,
		/// <summary>Supports printing upon envelopes.</summary>
		Envelope = 2,
		/// <summary>Supports printing upon cut labels.</summary>
		Label = 4,
		/// <summary>Supports photographic print quality printing.</summary>
		Photo = 8,
		/// <summary>Supports printing of receipts.</summary>
		Receipt = 16,
		/// <summary>Supports the printing of documents or photos on a continuous paper roll.</summary>
		Roll = 32,
		/// <summary>Supports printing in formats larger than the ISO A3 size.</summary>
		LargeFormat = 64,
		/// <summary>Supports postcard printing.</summary>
		Postcard = 128,
	}
}
