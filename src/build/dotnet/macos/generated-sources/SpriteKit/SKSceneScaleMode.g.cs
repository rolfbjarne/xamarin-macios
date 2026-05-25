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
namespace SpriteKit {
	/// <summary>An enumeration whose values specify the way in which a <see cref="T:SpriteKit.SKScene" /> scales to the view in which it is being displayed.</summary>
	[Native]
	public enum SKSceneScaleMode : long {
		/// <summary>Stretch the scene to fill the view.</summary>
		Fill = 0,
		/// <summary>Scale the scene to fill the view, even if the scene must be cropped.</summary>
		AspectFill = 1,
		/// <summary>Scale the scene to fit the view, possibly letterboxing the scene.</summary>
		AspectFit = 2,
		/// <summary>Resize the scene so that it is the same size and shape as the view.</summary>
		ResizeFill = 3,
	}
}
