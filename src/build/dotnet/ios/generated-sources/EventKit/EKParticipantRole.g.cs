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
	/// <summary>The role of an <see cref="T:EventKit.EKParticipant" /></summary>
	[Native]
	public enum EKParticipantRole : long {
		/// <summary>Uknonwn role.   The participant might want to consider his role in the group.</summary>
		Unknown = 0,
		/// <summary>Attendance is required.</summary>
		Required = 1,
		/// <summary>Attendance is optional.   This means that you can get away by not showing up at the meeting.   Or you can use this to politely invite someone, hoping they wont show up.</summary>
		Optional = 2,
		/// <summary>Chairing the meeting.</summary>
		Chair = 3,
		/// <summary>Not a participant.</summary>
		NonParticipant = 4,
	}
}
