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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace EventKit {
	/// <summary>Specifies the type of a calendar.</summary>
	[Native]
	public enum EKCalendarType : long {
		/// <summary>The calendar is stored locally.</summary>
		Local = 0,
		/// <summary>The calendar is being accessed via the CalDAV protocol.</summary>
		CalDav = 1,
		/// <summary>The calendar is being accessed via Microsoft Exchange Server protocols.</summary>
		Exchange = 2,
		/// <summary>The calendar is being accessed via subscription (iCal).</summary>
		Subscription = 3,
		/// <summary>The calendar is a birthday calendar.</summary>
		Birthday = 4,
	}
}
