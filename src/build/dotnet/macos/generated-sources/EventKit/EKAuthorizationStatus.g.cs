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
namespace EventKit {
	/// <summary>An enumeration whose values specify the restrictions on access to the <see cref="T:EventKit.EKEventStore" />. Retrieved by calling the <see cref="M:EventKit.EKEventStore.GetAuthorizationStatus(EventKit.EKEntityType)" /> method.</summary>
	[Native]
	public enum EKAuthorizationStatus : long {
		/// <summary>The user has not interacted with the permissions dialog.</summary>
		NotDetermined = 0,
		/// <summary>Access is denied and the user cannot change permission.</summary>
		Restricted = 1,
		/// <summary>The user has denied access.</summary>
		Denied = 2,
		/// <summary>The user has granted access.</summary>
		Authorized = 3,
		WriteOnly = 4,
	}
}
