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
	/// <summary>The visual appearance of a <see cref="T:UIKit.UITableViewCell" /> when it is selected.</summary><remarks>Used to set the <see cref="P:UIKit.UITableViewCell.SelectionStyle" /> of a cell.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITableViewCellSelectionStyle : long {
		/// <summary>There is no change to the cell's appearance when it is selected.</summary>
		None = 0,
		/// <summary>The cell background turns blue when it is selected. This is the default behavior.</summary>
		Blue = 1,
		/// <summary>The cell background turns gray when it is selected.</summary>
		Gray = 2,
		/// <summary>The default selection style used by tables.</summary>
		Default = 3,
	}
}
