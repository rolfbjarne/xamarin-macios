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
namespace AVFoundation {
	/// <summary>Enumerates possible values of the <see cref="P:AVFoundation.AVSampleBufferAudioRenderer.Status" />, <see cref="P:AVFoundation.AVSampleBufferDisplayLayer.Status" /> and <see cref="P:AVFoundation.AVSampleBufferVideoRenderer.Status" /> fields.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum AVQueuedSampleBufferRenderingStatus : long {
		/// <summary>No sample buffers have been enqueued yet.</summary>
		Unknown = 0,
		/// <summary>At least one sample buffer is queued for rendering.</summary>
		Rendering = 1,
		/// <summary>The player failed during or preparing for rendering.</summary>
		Failed = 2,
	}
}
