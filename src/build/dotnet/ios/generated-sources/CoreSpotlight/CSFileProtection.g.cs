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
namespace CoreSpotlight {
	/// <summary>Enumerates file protection options in calls to <see cref="CSSearchableIndex.CSSearchableIndex(string,CSFileProtection)" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum CSFileProtection : int {
		/// <summary>The file is not protected.</summary>
		None = 0,
		/// <summary>The file is encrypted and cannot be read until after booting and unlocking are completed.</summary>
		Complete = 1,
		/// <summary>The file is encrypted. If it was  created when the device was locked, it cannot be accessed after it is closed until after the user unlocks the device.</summary>
		CompleteUnlessOpen = 2,
		/// <summary>The file is encrypted and cannot be opened until the user unlocks the device.</summary>
		CompleteUntilFirstUserAuthentication = 3,
	}
}
