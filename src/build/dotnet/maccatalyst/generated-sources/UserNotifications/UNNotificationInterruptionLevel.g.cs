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
namespace UserNotifications {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum UNNotificationInterruptionLevel : long {
		[Obsolete ("Use 'Active2'.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		Active = 0,
		[Obsolete ("Use 'Critical2'.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		Critical = 1,
		[Obsolete ("Use 'Passive2'.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		Passive = 2,
		[Obsolete ("Use 'TimeSensitive2'.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		TimeSensitive = 3,
		Active2 = 1,
		Critical2 = 3,
		Passive2 = 0,
		TimeSensitive2 = 2,
	}
}
