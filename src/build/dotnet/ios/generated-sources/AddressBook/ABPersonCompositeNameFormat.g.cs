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
	/// <summary>
	/// The format to use for a person's composite name.
	/// </summary><remarks><para>
	/// The composite name controls the output of
	/// <see cref="AddressBook.ABRecord.ToString" />.
	/// </para></remarks>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum ABPersonCompositeNameFormat : uint {
		/// <summary>First name first.</summary>
		FirstNameFirst = 0,
		/// <summary>Last name first.</summary>
		LastNameFirst = 1,
	}
}
