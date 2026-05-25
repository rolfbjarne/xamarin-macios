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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
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
