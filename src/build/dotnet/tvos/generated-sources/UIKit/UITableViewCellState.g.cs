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
	/// <summary>An enumeration of states for a <see cref="T:UIKit.UITableViewCell" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native ("UITableViewCellStateMask")]
	public enum UITableViewCellState : ulong {
		/// <summary>The normal state of a UITableViewCell.</summary>
		DefaultMask = 0,
		/// <summary>The state of a UITableViewCell when the table is in editing mode.</summary>
		ShowingEditControlMask = 1,
		/// <summary>The state of a UITableViewCell that shows a button requesting confirmation of a delete gesture.</summary>
		ShowingDeleteConfirmationMask = 2,
	}
}
