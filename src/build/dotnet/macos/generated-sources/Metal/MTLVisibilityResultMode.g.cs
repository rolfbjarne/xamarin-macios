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
namespace Metal {
	/// <summary>Enumerates values that control how and whether to monitor samples that pass depth and stencil tests.</summary>
	[Native]
	public enum MTLVisibilityResultMode : ulong {
		/// <summary>Indicates that monitoring is turned off.</summary>
		Disabled = 0,
		/// <summary>Indicates that only whether the samples pass the depth and stencil tests should be tracked.</summary>
		Boolean = 1,
		/// <summary>Indicates that the samples that pass should be monitored.</summary>
		Counting = 2,
	}
}
