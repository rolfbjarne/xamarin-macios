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
	/// <summary>An enumeration of editing styles for a <see cref="T:UIKit.UITableView" /> cell.</summary><remarks>The editing style of a cell is set on the <see cref="P:UIKit.UITableViewCell.EditingStyle" /> property.  The editing control is displayed on the left hand side of the cell when it is in editing mode.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITableViewCellEditingStyle : long {
		/// <summary>No editing control is displayed in the cell (this is the default).</summary>
		None = 0,
		/// <summary>A red circle with a white minus sign is displayed, to indicate the cell can be deleted.</summary>
		Delete = 1,
		/// <summary>A gree circle with a white plus sign is displayed, indicating a new row can be inserted.</summary>
		Insert = 2,
	}
}
