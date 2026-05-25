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
	/// <summary>Enumerates whether a <see cref="T:UIKit.UIAlertController" /> is displaying an action sheet or an alert.</summary><remarks><para>This is how an action sheet is displayed:</para><para><img href="~/xml/UIKit/_images/actioncontroller-action-sheet.png" alt="Screenshot of the action sheet." /></para><para></para><para>This is how an alert is displayed:</para><para><img href="~/xml/UIKit/_images/actioncontroller-alert.png" alt="Image of the alert dialog" /></para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIAlertControllerStyle : long {
		/// <summary>Displays the alert controller as an action sheet.</summary>
		ActionSheet = 0,
		/// <summary>Displays the alert controller as an alert.</summary>
		Alert = 1,
	}
}
