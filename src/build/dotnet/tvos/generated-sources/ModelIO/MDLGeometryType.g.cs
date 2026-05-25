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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ModelIO {
	/// <summary>Enumerates the geometric primitives to use for rendering.</summary>
	[Native]
	public enum MDLGeometryType : long {
		/// <summary>Indicates that each index describes a point.</summary>
		Points = 0,
		/// <summary>Indicates that consecutive index pairs describe lines.</summary>
		Lines = 1,
		/// <summary>Indicates that each 3-index stride in the buffer specifies a triangle.</summary>
		Triangles = 2,
		/// <summary>Indicates that the first 3-index stride in the buffer specifies a triangle, and that successive points specify another triangle with the preceding two indices </summary>
		TriangleStrips = 3,
		/// <summary>Indicates that each 4-index stride in the buffer specifies a quadrilateral.</summary>
		Quads = 4,
		/// <summary>Indicates that the geometry is not uniform, and is described by its <see cref="P:ModelIO.MDLSubmesh.Topology" /> property.</summary>
		VariableTopology = 5,
	}
}
