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
namespace CoreGraphics {
	/// <summary>Quality of interpolation for drawing images.</summary>
	public enum CGInterpolationQuality : int {
		/// <summary>Let the context pick the best interpolation mode.</summary>
		Default = 0,
		/// <summary>Do not interpolate.</summary>
		None = 1,
		/// <summary>Low interpolation quality, fast processing.</summary>
		Low = 2,
		/// <summary>High quality, at the cost of speed.</summary>
		High = 3,
		/// <summary>To be added.</summary>
		Medium = 4,
	}
}
