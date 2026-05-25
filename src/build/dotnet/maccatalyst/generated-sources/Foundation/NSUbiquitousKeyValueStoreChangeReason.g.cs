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
namespace Foundation {
	/// <summary>An enumeration of valid reasons for modifying the iCloud ubiquitous key store.</summary><remarks>To be added.</remarks>
	[Native]
	public enum NSUbiquitousKeyValueStoreChangeReason : long {
		/// <summary>To be added.</summary>
		ServerChange = 0,
		/// <summary>To be added.</summary>
		InitialSyncChange = 1,
		/// <summary>To be added.</summary>
		QuotaViolationChange = 2,
		/// <summary>To be added.</summary>
		AccountChange = 3,
	}
}
