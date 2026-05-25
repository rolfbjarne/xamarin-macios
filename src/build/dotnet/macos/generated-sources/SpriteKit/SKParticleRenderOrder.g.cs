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
	/// <summary>Enumerates values used with <see cref="P:SpriteKit.SKEmitterNode.ParticleRenderOrder" />.</summary>
	[Native]
	public enum SKParticleRenderOrder : ulong {
		/// <summary>The oldest particles are rendered last.</summary>
		OldestLast = 0,
		/// <summary>The oldest particles are rendered first.</summary>
		OldestFirst = 1,
		/// <summary>Sprite Kit may render the particles in whichever order is best for performance.</summary>
		DontCare = 2,
	}
}
