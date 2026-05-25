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
namespace UIKit {
	/// <summary>Enumerates the types of file transfer operations used by the document picker.</summary>
	[ObsoletedOSPlatform ("ios14.0", "Use the designated constructors instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst14.0", "Use the designated constructors instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIDocumentPickerMode : ulong {
		/// <summary>Imports a file from a specified destination outside the sandbox for the app.</summary>
		Import = 0,
		/// <summary>Opens an external file that is located outside the sandobox for the app.</summary>
		Open = 1,
		/// <summary>Exports a local file to a specified destination outside the sandbox for the app.</summary>
		ExportToService = 2,
		/// <summary>Moves a local file outside of the sandbox for the app, providing access to it as an external file.</summary>
		MoveToService = 3,
	}
}
