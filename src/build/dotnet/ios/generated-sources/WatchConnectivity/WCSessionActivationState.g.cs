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
namespace WatchConnectivity {
	/// <summary>Enumerates session states.</summary>
	[Native]
	public enum WCSessionActivationState : long {
		/// <summary>Indicates that the session is inactive and the watch and the phone are not connected.</summary>
		NotActivated = 0,
		/// <summary>Indicates that the session is deactivating. Data can be received by the app, but not sent to the phone.</summary>
		Inactive = 1,
		/// <summary>Indicates that the seesion is activated and the watch app and iOS can communicate.</summary>
		Activated = 2,
	}
}
