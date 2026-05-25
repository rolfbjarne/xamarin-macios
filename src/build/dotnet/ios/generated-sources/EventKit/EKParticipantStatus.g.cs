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
namespace EventKit {
	/// <summary>The status of a participant.</summary>
	[Native]
	public enum EKParticipantStatus : long {
		/// <summary>We do not know what the participant's intentions are at this point.</summary>
		Unknown = 0,
		/// <summary>The participant has not yet responded to this event.   Probably trying to find someone he can EKParticipantStatus.Delegate this too.   If you know what I mean.</summary>
		Pending = 1,
		/// <summary>The participant has expressed his commitment to this meeting by accepting your invitation.</summary>
		Accepted = 2,
		/// <summary>The participant has declined to participate in this event.</summary>
		Declined = 3,
		/// <summary>The participant will tentatively will join this event.</summary>
		Tentative = 4,
		/// <summary>The participant delegate this event to someone else.</summary>
		Delegated = 5,
		/// <summary>The event has completed.</summary>
		Completed = 6,
		/// <summary>In process.   </summary>
		InProcess = 7,
	}
}
