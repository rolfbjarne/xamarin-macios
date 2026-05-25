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
	/// <summary>An enumeration of values that specify how a <see cref="T:UIKit.UIImage" /> ought to be resized.</summary><remarks>To be added.</remarks><altmember cref="T:UIKit.UIImage" />
	[Native (ConvertToManaged = "UIImageResizingModeExtensions.ToManaged", ConvertToNative = "UIImageResizingModeExtensions.ToNative")]
	public enum UIImageResizingMode : long {
		/// <summary>The contents of the original image are repeated as necessary to fill the interior of the new image.</summary>
		Tile = 0,
		/// <summary>The contents of the original image are scaled to fill the interior of the new image.</summary>
		Stretch = 1,
	}
}
