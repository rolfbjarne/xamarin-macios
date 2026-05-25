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
namespace EventKit {
	/// <summary>Specifies the types of availability information the calendar is capable of providing for its associated events.</summary>
	[Flags]
	[Native ("EKCalendarEventAvailabilityMask")]
	public enum EKCalendarEventAvailability : ulong {
		/// <summary>The calendar cannot provide availability status for its associated events.</summary>
		None = 0,
		/// <summary>The calendar can provide busy status for its associated events.</summary>
		Busy = 1,
		/// <summary>The calendar can provide free status for its associated events.</summary>
		Free = 2,
		/// <summary>The calendar can provide tentative status for its associated events.</summary>
		Tentative = 4,
		/// <summary>The calendar can provide unavailable status for its associated events.</summary>
		Unavailable = 8,
	}
}
