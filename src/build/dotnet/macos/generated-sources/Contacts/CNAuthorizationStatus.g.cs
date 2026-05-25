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
namespace Contacts {
	/// <summary>Enumerates the application's current authorization to access the <see cref="T:Contacts.CNContactStore" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CNAuthorizationStatus : long {
		/// <summary>The user has not yet chosen whether the app may access the Contacts database.</summary>
		NotDetermined = 0,
		/// <summary>The app may not access the Contacts database, although the reason may not be the user's choice, but rather something such as parental controls.</summary>
		Restricted = 1,
		/// <summary>The app has been denied access to the Contacts database.</summary>
		Denied = 2,
		/// <summary>The app is authorized to access the Contacts database.</summary>
		Authorized = 3,
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		Limited = 4,
	}
}
