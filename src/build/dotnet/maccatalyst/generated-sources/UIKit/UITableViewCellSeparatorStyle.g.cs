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
namespace UIKit {
	/// <summary>The visual style of a <see cref="T:UIKit.UITableView" />'s cell separator.</summary><remarks>The cell separator style is set via a table view's <see cref="P:UIKit.UITableView.SeparatorStyle" /> property.</remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UITableViewCellSeparatorStyle : long {
		/// <summary>No separator is displayed between cells.</summary>
		None = 0,
		/// <summary>A single line is displayed between each cell. This is the default.</summary>
		SingleLine = 1,
		/// <summary>Developers should not use this deprecated field. Developers should use 'SingleLine' for a single line separator.</summary>
		[ObsoletedOSPlatform ("ios11.0", "Use 'SingleLine' for a single line separator.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SingleLine' for a single line separator.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SingleLineEtched = 2,
		/// <summary>A single etched line (made up of two different colored lines) is displayed between each cell (same as SingleLineEtched). This style can only be used in grouped-style table views.</summary>
		DoubleLineEtched = 2,
	}
}
