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
	/// <summary>Enumerates the phases of the button-press life-cycle.</summary><remarks><para><see cref="T:UIKit.UIPress" /> objects model not just digital presses but, for instance, trackpads, so a <see cref="T:UIKit.UIPress" /> may have both location and force data. Additionally, the system may cancel tracking of a button press at any time. This leads to the following state-machine:</para><para><img href="~/xml/UIKit/_images/UIKit.UIPressPhase_States.png" alt="Statechart showing states and transitions occurring during a press" /></para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIPressPhase : long {
		/// <summary>The initial state of a button. Indicates that a press has begun.</summary>
		Began = 0,
		/// <summary>Indicates that either the location of the button press or it's <see cref="P:UIKit.UIPress.Force" /> has changed.</summary>
		Changed = 1,
		/// <summary>Indicates that the button is still down, with the same location and force as previously.</summary>
		Stationary = 2,
		/// <summary>Indicates that the button has been released.</summary>
		Ended = 3,
		/// <summary>Indicates that the system has canceled tracking of this button-press sequence.</summary>
		Cancelled = 4,
	}
}
