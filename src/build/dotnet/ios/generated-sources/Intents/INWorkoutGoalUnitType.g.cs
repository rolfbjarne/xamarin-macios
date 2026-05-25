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
namespace Intents {
	/// <summary>Enumerates the kind of goal the workout is striving for.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INWorkoutGoalUnitType : long {
		/// <summary>The workout goal's form is indeterminate.</summary>
		Unknown = 0,
		/// <summary>The workout goal is a distance in inches.</summary>
		Inch = 1,
		/// <summary>The workout goal is a distance measured in meters.</summary>
		Meter = 2,
		/// <summary>The workout goal is a distance in feet.</summary>
		Foot = 3,
		/// <summary>The workout goal is a distance measured in miles.</summary>
		Mile = 4,
		/// <summary>The workout goal is a distance measured in yards.</summary>
		Yard = 5,
		/// <summary>The workout goal is a time measured in seconds.</summary>
		Second = 6,
		/// <summary>The workout goal is a time measured in minutes.</summary>
		Minute = 7,
		/// <summary>The workout goal is a time in hours.</summary>
		Hour = 8,
		/// <summary>The workout goal is an energy measured in joules.</summary>
		Joule = 9,
		/// <summary>The workout goal is an energy measured in kilocalories.</summary>
		KiloCalorie = 10,
	}
}
