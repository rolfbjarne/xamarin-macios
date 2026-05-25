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
	/// <summary>An enumeration of standard accessory controls that can be used by a <see cref="T:UIKit.UITableViewCell" />.</summary><remarks>Set the type of accessory to display in a <see cref="T:UIKit.UITableViewCell" /> using the <see cref="P:UIKit.UITableViewCell.Accessory" /> property.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native ("UITableViewCellAccessoryType")]
	public enum UITableViewCellAccessory : long {
		/// <summary>No accessory is displayed. This is the default. Use this value to remove a previously-assigned accessory.</summary>
		None = 0,
		/// <summary>A chevron (right-pointing arrow) is displayed on the right side of the cell. This accessory does not track touches.</summary>
		DisclosureIndicator = 1,
		/// <summary>A blue circular button containing a chevron (right-pointing arrow) is displayed on the right side of the cell. This accessory tracks touches separately from the rest of the cell.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		DetailDisclosureButton = 2,
		/// <summary>A tick is displayed on the right side of the cell. This accessory does not track touches. The table view's <see cref="T:UIKit.UITableViewSource" /> can manage check marks (possibly limiting the check mark to a single row) in the <see cref="M:UIKit.UITableViewSource.RowSelected(UIKit.UITableView,Foundation.NSIndexPath)" /> method.</summary>
		Checkmark = 3,
		/// <summary>A standard button indicating additional detail.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		DetailButton = 4,
	}
}
