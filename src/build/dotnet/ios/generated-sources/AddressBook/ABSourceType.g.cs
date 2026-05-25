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
	/// <summary>An enumeration whose values specify various kinds of <see cref="T:AddressBook.ABSourceType" />.</summary>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum ABSourceType : int {
		/// <summary>To be added.</summary>
		Local = 0,
		/// <summary>To be added.</summary>
		Exchange = 1,
		/// <summary>To be added.</summary>
		ExchangeGAL = 16777217,
		/// <summary>To be added.</summary>
		MobileMe = 2,
		/// <summary>To be added.</summary>
		LDAP = 16777219,
		/// <summary>To be added.</summary>
		CardDAV = 4,
		/// <summary>To be added.</summary>
		DAVSearch = 16777220,
		/// <summary>To be added.</summary>
		SearchableMask = 16777216,
	}
}
