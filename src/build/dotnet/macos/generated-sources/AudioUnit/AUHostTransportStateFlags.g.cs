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
namespace AudioUnit {
	/// <summary>Enumerates flag values that describe the state of an audio transport.</summary>
	[Native]
	public enum AUHostTransportStateFlags : ulong {
		/// <summary>Indicates that a state change has occurred, such as a stop, start, seek, or other change since the host transport state block was last called.</summary>
		Changed = 1,
		/// <summary>Indicates that the transport is moving.</summary>
		Moving = 2,
		/// <summary>Indicates that the host is able to record, or is currently recording.</summary>
		Recording = 4,
		/// <summary>Indicates that the host is cycling.</summary>
		Cycling = 8,
	}
}
