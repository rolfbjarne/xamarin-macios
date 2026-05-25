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
namespace SceneKit {
	/// <summary>Enumeration of lifecycle events for particles emitted by a <see cref="T:SceneKit.SCNParticleSystem" />. Used with <see cref="M:SceneKit.SCNParticleSystem.HandleEvent(SceneKit.SCNParticleEvent,Foundation.NSString[],SceneKit.SCNParticleEventHandler)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SCNParticleEvent : long {
		/// <summary>
		/// 	    This event is raised when a new particle is created.
		/// 	  </summary>
		Birth = 0,
		/// <summary>
		/// 	    This event is raised when a new particle will be destroyed.
		/// 	  </summary>
		Death = 1,
		/// <summary>
		/// 	    This event is raised when two particles collide with the scene geometry.
		/// 	  </summary>
		Collision = 2,
	}
}
