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
namespace ClassKit {
	/// <summary>Enumerates curriculum units.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CLSContextType : long {
		/// <summary>Indicates no context type.</summary>
		None = 0,
		/// <summary>Indicates an app context.</summary>
		App = 1,
		/// <summary>Indicates a context for chapter.</summary>
		Chapter = 2,
		/// <summary>Indicates a context for a section.</summary>
		Section = 3,
		/// <summary>Indicates a context for level.</summary>
		Level = 4,
		/// <summary>Indicates a context for a page.</summary>
		Page = 5,
		/// <summary>Indicates a context for a task.</summary>
		Task = 6,
		/// <summary>Indicates a context for a challenge.</summary>
		Challenge = 7,
		/// <summary>Indicates a context for a quiz.</summary>
		Quiz = 8,
		/// <summary>Indicates a context for an exercise</summary>
		Exercise = 9,
		/// <summary>Indicates a context for a lesson.</summary>
		Lesson = 10,
		/// <summary>Indicates a context for a book.</summary>
		Book = 11,
		/// <summary>Indicates a context for a game.</summary>
		Game = 12,
		/// <summary>Indicates a context for a document.</summary>
		Document = 13,
		/// <summary>Indicates a context for audio material.</summary>
		Audio = 14,
		/// <summary>Indicates a context for a video.</summary>
		Video = 15,
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		Course = 16,
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		Custom = 17,
	}
}
