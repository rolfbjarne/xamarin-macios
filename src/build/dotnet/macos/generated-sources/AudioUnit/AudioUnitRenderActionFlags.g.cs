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
	/// <summary>An enumeration whose values specify configuration flags for audio-unit rendering.</summary>
	[Flags]
	public enum AudioUnitRenderActionFlags : int {
		/// <summary>To be added.</summary>
		PreRender = 4,
		/// <summary>To be added.</summary>
		PostRender = 8,
		/// <summary>To be added.</summary>
		OutputIsSilence = 16,
		/// <summary>To be added.</summary>
		OfflinePreflight = 32,
		/// <summary>To be added.</summary>
		OfflineRender = 64,
		/// <summary>To be added.</summary>
		OfflineComplete = 128,
		/// <summary>To be added.</summary>
		PostRenderError = 256,
		/// <summary>To be added.</summary>
		DoNotCheckRenderArgs = 512,
	}
}
