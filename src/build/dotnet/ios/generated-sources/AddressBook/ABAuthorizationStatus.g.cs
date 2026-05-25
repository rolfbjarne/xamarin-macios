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
namespace AddressBook {
	/// <summary>An enumeration whose values specify the possible results of the <see cref="AddressBook.ABAddressBook.GetAuthorizationStatus" /> method.</summary>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst14.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum ABAuthorizationStatus : long {
		/// <summary>The user has not made a decision regarding access.</summary>
		NotDetermined = 0,
		/// <summary>Access is denied and the user is not allowed to change permission.</summary>
		Restricted = 1,
		/// <summary>The user has denied authorization to access address book data.</summary>
		Denied = 2,
		/// <summary>The app is authorized to access address book data.</summary>
		Authorized = 3,
	}
}
