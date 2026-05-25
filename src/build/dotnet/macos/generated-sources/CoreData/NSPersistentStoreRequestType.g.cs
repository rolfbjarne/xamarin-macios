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
	/// <summary>Constants defining the types of a fetch request.</summary>
	[Native]
	public enum NSPersistentStoreRequestType : ulong {
		/// <summary>Indicates that the fetch request was for retrieving objects.</summary>
		Fetch = 1,
		/// <summary>Indicates that the fetch request was to save managed objects.</summary>
		Save = 2,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BatchInsert = 5,
		/// <summary>Indicates that the fetch request was for a batch update.</summary>
		BatchUpdate = 6,
		/// <summary>Indicates that the fetch request was for a batch delete.</summary>
		BatchDelete = 7,
	}
}
