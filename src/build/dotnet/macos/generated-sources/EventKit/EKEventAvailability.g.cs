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
	/// <summary>Types of availability </summary>
	[Native]
	public enum EKEventAvailability : long {
		/// <summary>Calendar does not provide availability information for events.</summary>
		NotSupported = -1,
		/// <summary>Duration of event is reported as busy.</summary>
		Busy = 0,
		/// <summary>Duration of event is reported as free.</summary>
		Free = 1,
		/// <summary>Duration of event is reported as tentative.</summary>
		Tentative = 2,
		/// <summary>Duration of event is reported as unavailable.</summary>
		Unavailable = 3,
	}
}
