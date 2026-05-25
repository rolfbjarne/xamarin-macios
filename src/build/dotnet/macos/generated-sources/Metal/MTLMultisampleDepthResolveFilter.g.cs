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
	/// <summary>Enumerates MSAA dept resolve filter operations.</summary>
	[Native]
	public enum MTLMultisampleDepthResolveFilter : ulong {
		/// <summary>Indicates that no filter is applied. Default.</summary>
		Sample0 = 0,
		/// <summary>Indicates that a minimum filter is applied, selecting the minimum depth sample for each pixel.</summary>
		Min = 1,
		/// <summary>Indicates that a maximum filter is applied, selecting the largest depth sample for each pixel.</summary>
		Max = 2,
	}
}
