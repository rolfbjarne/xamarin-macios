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
namespace CloudKit {
	/// <summary>Enumerates share participant types.</summary>
	[ObsoletedOSPlatform ("tvos12.0", "Use 'CKShareParticipantRole' instead.")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'CKShareParticipantRole' instead.")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'CKShareParticipantRole' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CKShareParticipantRole' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum CKShareParticipantType : long {
		/// <summary>Indicates that the participant type is unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates that a participant is the share owner.</summary>
		Owner = 1,
		/// <summary>Indicates that a participant is a credentialed user.</summary>
		PrivateUser = 3,
		/// <summary>Indicates that a participant is an anonymous user.</summary>
		PublicUser = 4,
	}
}
