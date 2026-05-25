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
	/// <summary>Enumerates characteristics of the button displayed in a table row. Used with the <see cref="M:UIKit.UITableViewRowAction.Create(UIKit.UITableViewRowActionStyle,System.String,System.Action{UIKit.UITableViewRowAction,Foundation.NSIndexPath})" /> factory method.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'UIContextualActionStyle' and corresponding APIs instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIContextualActionStyle' and corresponding APIs instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UITableViewRowActionStyle : long {
		/// <summary>The default button appearance.</summary>
		Default = 0,
		/// <summary>The appearance for a button that may delete data.</summary>
		Destructive = 0,
		/// <summary>The appearance for a nondestructive button.</summary>
		Normal = 1,
	}
}
