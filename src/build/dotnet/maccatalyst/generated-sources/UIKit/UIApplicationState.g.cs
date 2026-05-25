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
namespace UIKit {
	/// <summary>An enumeration indicating the current application state.</summary><remarks><para> 
	/// 	When the user taps on the app icon, the app briefly
	/// 	goes through a transitional state of
	/// 	UIApplicationState.Inactive on its way to becoming
	/// 	UIApplicationState.Active. This is where the app gets
	/// 	itself ready to display to the user.
	/// </para><para>
	/// 	When the app is open, the application state is UIApplicationState.Active.
	/// </para><para>
	/// 	If the user presses the home button, and is returned to
	/// 	the springboard (home screen), or the application is
	/// 	interrupted by something, such as a phone call, the
	/// 	application state transitions back to
	/// 	UIApplicationState.Inactive.
	/// </para><para> 
	/// 	For the application state of your app to become
	/// 	UIApplicationState.Background, your application would have
	/// 	to register for a background process. 
	/// </para><para>
	/// 	Reference: https://stackoverflow.com/questions/7937400/need-clarification-about-uiapplicationstate
	/// </para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIApplicationState : long {
		/// <summary>The application is currently active and on the foreground</summary>
		Active = 0,
		/// <summary>The application is in the foreground but not receiving events.   The application is placed in this state when moving in and out of the foreground state and also when the application is interrupted by a system notification.</summary>
		Inactive = 1,
		/// <summary>The application is executing in the background.   It does not receive events.</summary>
		Background = 2,
	}
}
