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
namespace CoreGraphics {
	/// <summary>Text drawing mode used by Quartz.</summary><remarks>These drawing modes are used with the <see cref="CGContext.SetTextDrawingMode" /> method and they specify how the glyphs that make up the text should be drawn.</remarks>
	public enum CGTextDrawingMode : uint {
		/// <summary>Perform a Fill operation on the text glyphs.</summary>
		Fill = 0,
		/// <summary>Perform a Stroke operation on the text glyphs.</summary>
		Stroke = 1,
		/// <summary>Perform a Fill operation followed by a Stroke operation on the text glyphs.</summary>
		FillStroke = 2,
		/// <summary>Does not draw the text, merely updates the text position</summary>
		Invisible = 3,
		/// <summary>Perform a Fill operation on the text glyphs followed by a clip operation using the current clip path.</summary>
		FillClip = 4,
		/// <summary>To be added.</summary>
		StrokeClip = 5,
		/// <summary>Perform a Stroke operation on the text glyphs followed by a clip operation using the current clip path.</summary>
		FillStrokeClip = 6,
		/// <summary>Performs a clip operation using the current clip path without drawing the text.</summary>
		Clip = 7,
	}
}
