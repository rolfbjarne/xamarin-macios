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
	/// <summary>An enumeration of predefined scroll positions.</summary><remarks>This is used by the <see cref="M:UIKit.UITableView.ScrollToRow(Foundation.NSIndexPath,UIKit.UITableViewScrollPosition,System.Boolean)" /> method</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITableViewScrollPosition : long {
		/// <summary>Minimal scrolling to make the requested cell visible.</summary>
		None = 0,
		/// <summary>Scrolls the row of interest to the top of the view.</summary>
		Top = 1,
		/// <summary>Scrolls the row of interest to the middle of the view.</summary>
		Middle = 2,
		/// <summary>Scrolls the cell to the bottom of the view.</summary>
		Bottom = 3,
	}
}
