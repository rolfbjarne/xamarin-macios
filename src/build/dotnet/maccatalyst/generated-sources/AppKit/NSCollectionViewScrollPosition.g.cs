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
namespace AppKit {
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "This enum doesn't exist on this platform.")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	[Flags]
	[Native]
	public enum NSCollectionViewScrollPosition : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Top = 1,
		/// <summary>To be added.</summary>
		CenteredVertically = 2,
		/// <summary>To be added.</summary>
		Bottom = 4,
		/// <summary>To be added.</summary>
		NearestHorizontalEdge = 512,
		/// <summary>To be added.</summary>
		Left = 8,
		/// <summary>To be added.</summary>
		CenteredHorizontally = 16,
		/// <summary>To be added.</summary>
		Right = 32,
		/// <summary>To be added.</summary>
		LeadingEdge = 64,
		/// <summary>To be added.</summary>
		TrailingEdge = 128,
		/// <summary>To be added.</summary>
		NearestVerticalEdge = 256,
	}
}
