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
namespace GameKit {
	/// <summary>Enumerates responses to game play invitations.</summary><remarks>To be added.</remarks>
	[Native]
	public enum GKInviteRecipientResponse : long {
		/// <summary>The recipient accepted.</summary>
		Accepted = 0,
		/// <summary>The recipient declined.</summary>
		Declined = 1,
		/// <summary>The request failed.</summary>
		Failed = 2,
		/// <summary>The versions of the game that are owned by the host and recipient are incompatible.</summary>
		Incompatible = 3,
		/// <summary>To be added.</summary>
		UnableToConnect = 4,
		/// <summary>The recipient did not answer.</summary>
		NoAnswer = 5,
	}
}
