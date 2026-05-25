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
	/// <summary>An enumeration of values that may be sent to <see cref="M:Foundation.NSStreamDelegate.HandleEvent(Foundation.NSStream,Foundation.NSStreamEvent)" />.</summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum NSStreamEvent : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		OpenCompleted = 1,
		/// <summary>To be added.</summary>
		HasBytesAvailable = 2,
		/// <summary>To be added.</summary>
		HasSpaceAvailable = 4,
		/// <summary>To be added.</summary>
		ErrorOccurred = 8,
		/// <summary>To be added.</summary>
		EndEncountered = 16,
	}
}
