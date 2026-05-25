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
namespace AccessorySetupKit {
	[SupportedOSPlatform ("ios18.0")]
	[Native]
	public enum ASAccessoryEventType : long {
		Unknown = 0,
		Activated = 10,
		Invalidated = 11,
		MigrationComplete = 20,
		AccessoryAdded = 30,
		AccessoryRemoved = 31,
		AccessoryChanged = 32,
		Discovered = 33,
		PickerDidPresent = 40,
		PickerDidDismiss = 50,
		PickerSetupBridging = 60,
		PickerSetupFailed = 70,
		PickerSetupPairing = 80,
		PickerSetupRename = 90,
	}
}
