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
namespace AudioToolbox {
	/// <summary>The available audio input sources on the device.</summary>
	public enum AudioSessionInputRouteKind : int {
		/// <summary>No input device.</summary>
		None = 0,
		/// <summary>Line input</summary>
		LineIn = 1,
		/// <summary>The built-in microphone (this device is not available on iPod touch devices for example).</summary>
		BuiltInMic = 2,
		/// <summary>Headset based microphone</summary>
		HeadsetMic = 3,
		/// <summary>Bluetooth based microphone</summary>
		BluetoothHFP = 4,
		/// <summary>Microphone connected through USB (connected either through the Lightning or 30-pin ports).</summary>
		USBAudio = 5,
	}
}
