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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>An enumeration of animations used when rows are inserted or deleted from a table view.</summary><remarks></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITableViewRowAnimation : long {
		/// <summary>Affected rows fade in/out of view.</summary>
		Fade = 0,
		/// <summary>Inserted row/s slide in from the right, deleted row/s slide out to the right.</summary>
		Right = 1,
		/// <summary>Inserted row/s slide in from the left, deleted row/s slide out to the left.</summary>
		Left = 2,
		/// <summary>Inserted row/s slide down from the top, deleted row/s slide up.</summary>
		Top = 3,
		/// <summary>Inserted row/s slide up from the bottom, deleted row/s slide down.</summary>
		Bottom = 4,
		/// <summary>There is no animation when cells are added or removed. The cell appears immediately, as if the table view had been reloaded.</summary>
		None = 5,
		/// <summary>The table view tries to keep the location of affected cells centered in the table view.</summary>
		Middle = 6,
		/// <summary>Allows the table view to choose an appropriate animation.</summary>
		Automatic = 100,
	}
}
