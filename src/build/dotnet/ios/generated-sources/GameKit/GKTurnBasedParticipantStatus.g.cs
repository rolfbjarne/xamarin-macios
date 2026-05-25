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
namespace GameKit {
	/// <summary>An enumeration whose values specify the status of turn-based participants. (See <see cref="P:GameKit.GKTurnBasedParticipant.Status" />.)</summary><remarks>To be added.</remarks>
	[Native]
	public enum GKTurnBasedParticipantStatus : long {
		/// <summary>To be added.</summary>
		Unknown = 0,
		/// <summary>To be added.</summary>
		Invited = 1,
		/// <summary>To be added.</summary>
		Declined = 2,
		/// <summary>To be added.</summary>
		Matching = 3,
		/// <summary>To be added.</summary>
		Active = 4,
		/// <summary>To be added.</summary>
		Done = 5,
	}
}
