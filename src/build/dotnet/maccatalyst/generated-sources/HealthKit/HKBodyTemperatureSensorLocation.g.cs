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
namespace HealthKit {
	/// <summary>Enumerates the positions at which a thermometer takes its reading.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKBodyTemperatureSensorLocation : long {
		/// <summary>The temperature reading location is unspecified.</summary>
		Other = 0,
		/// <summary>The temperature reading is taken at the user's armpit.</summary>
		Armpit = 1,
		/// <summary>The temperature reading is taken somewhere on the user's body.</summary>
		Body = 2,
		/// <summary>The temperature reading is taken at the user's ear.</summary>
		Ear = 3,
		/// <summary>The temperature reading is taken at the user's finger.</summary>
		Finger = 4,
		/// <summary>The temperature reading is taken in the user's gastrointestinal system.</summary>
		GastroIntestinal = 5,
		/// <summary>The temperature reading is taken in the user's mouth.</summary>
		Mouth = 6,
		/// <summary>The temperature reading is taken at the user's rectum.</summary>
		Rectum = 7,
		/// <summary>The temperature reading is taken at the user's toe.</summary>
		Toe = 8,
		/// <summary>The temperature reading is taken at the user's eardrum.</summary>
		EarDrum = 9,
		/// <summary>The temperature reading is taken at the user's temporal artery.</summary>
		TemporalArtery = 10,
		/// <summary>The temperature reading is taken at the user's forehead.</summary>
		Forehead = 11,
	}
}
