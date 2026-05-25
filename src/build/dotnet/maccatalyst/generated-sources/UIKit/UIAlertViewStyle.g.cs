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
	/// <summary>The visual style for a <see cref="T:UIKit.UIAlertView" />.</summary><remarks><para>
	/// The values other than <see cref="F:UIKit.UIAlertViewStyle.Default" /> allow the user to enter text, including the option to obscure the text as it is being entered.
	/// </para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIAlertViewStyle : long {
		/// <summary>A standard alert.</summary>
		Default = 0,
		/// <summary>Allows the user to enter text, but the text field is obscured.</summary>
		SecureTextInput = 1,
		/// <summary>Allows the user to enter text.</summary>
		PlainTextInput = 2,
		/// <summary>Allows the user to enter a login id and a password.</summary>
		LoginAndPasswordInput = 3,
	}
}
