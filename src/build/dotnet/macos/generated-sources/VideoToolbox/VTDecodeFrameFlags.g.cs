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
namespace VideoToolbox {
	/// <summary>Flags to control encoder in a decompression session</summary>
	[Flags]
	public enum VTDecodeFrameFlags : uint {
		None = 0,
		/// <summary>To be added.</summary>
		EnableAsynchronousDecompression = 1,
		/// <summary>To be added.</summary>
		DoNotOutputFrame = 2,
		/// <summary>To be added.</summary>
		OneTimeRealTimePlayback = 4,
		/// <summary>To be added.</summary>
		EnableTemporalProcessing = 8,
	}
}
