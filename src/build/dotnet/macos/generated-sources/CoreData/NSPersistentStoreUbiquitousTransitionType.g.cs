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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
namespace CoreData {
	/// <summary>Enumerates valid keys for the user information dictionary used in <see cref="P:CoreData.NSPersistentStoreCoordinator.StoresWillChangeNotification" /> and <see cref="P:CoreData.NSPersistentStoreCoordinator.StoresDidChangeNotification" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios10.0", "Please see the release notes and Core Data documentation.")]
	[ObsoletedOSPlatform ("macos10.12", "Please see the release notes and Core Data documentation.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Please see the release notes and Core Data documentation.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum NSPersistentStoreUbiquitousTransitionType : ulong {
		/// <summary>To be added.</summary>
		AccountAdded = 1,
		/// <summary>To be added.</summary>
		AccountRemoved = 2,
		/// <summary>To be added.</summary>
		ContentRemoved = 3,
		/// <summary>To be added.</summary>
		InitialImportCompleted = 4,
	}
}
