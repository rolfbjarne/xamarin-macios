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
namespace UIKit {
	/// <summary>An enumeration indicating in which direction the arrow of the <see cref="T:UIKit.UIMenuController" /> points.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIMenuControllerArrowDirection : long {
		/// <summary>The system decides the arrow location based on the menu size.</summary>
		Default = 0,
		/// <summary>The arrow will be at the top of the menu.</summary>
		Up = 1,
		/// <summary>The arrow will be at the bottom of the menu.</summary>
		Down = 2,
		/// <summary>The arrow will be at the left of the menu.</summary>
		Left = 3,
		/// <summary>The arrow will be at the right of the menu.</summary>
		Right = 4,
	}
}
