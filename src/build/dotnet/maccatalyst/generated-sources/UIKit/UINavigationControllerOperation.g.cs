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
	/// <summary>An enumeration whose values specify operations on <see cref="T:UIKit.UINavigationController" />.</summary><remarks>This enumeration is used in calls to <see cref="M:UIKit.UINavigationControllerDelegate.GetAnimationControllerForOperation(UIKit.UINavigationController,UIKit.UINavigationControllerOperation,UIKit.UIViewController,UIKit.UIViewController)" />.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UINavigationControllerOperation : long {
		/// <summary>No navigation operation is happening.</summary>
		None = 0,
		/// <summary>A UIViewController is being pushed onto the navigation stack.</summary>
		Push = 1,
		/// <summary>The top UIViewController is being removed from the navigation stack.</summary>
		Pop = 2,
	}
}
