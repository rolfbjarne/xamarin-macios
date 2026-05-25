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
namespace CoreAnimation {
	/// <summary>Flags used to determine what side of a layer should be antialiased.</summary>
	[Flags]
	public enum CAEdgeAntialiasingMask : uint {
		/// <summary>Left side of the layer is antialiased.</summary>
		LeftEdge = 1,
		/// <summary>Right side of the layer is antialiased.</summary>
		RightEdge = 2,
		/// <summary>Bottom side of the layer is antialiased.</summary>
		BottomEdge = 4,
		/// <summary>Top side of the layer is antialiased.</summary>
		TopEdge = 8,
		/// <summary>All sides of the layer are antialiased.</summary>
		All = 15,
		/// <summary>Left and right sides of the layer are antialiased.</summary>
		LeftRightEdges = 3,
		/// <summary>Top and bottom side of the layer are antialiased.</summary>
		TopBottomEdges = 12,
	}
}
