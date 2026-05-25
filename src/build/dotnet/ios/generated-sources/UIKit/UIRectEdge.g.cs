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
	/// <summary>An enumeration whose values specify screen edges, for use with <see cref="P:UIKit.UIScreenEdgePanGestureRecognizer.Edges" /> and <see cref="P:UIKit.UIViewController.EdgesForExtendedLayout" />.</summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum UIRectEdge : ulong {
		/// <summary>No edges.</summary>
		None = 0,
		/// <summary>The top edge of the rectangle.</summary>
		Top = 1,
		/// <summary>The left edge of the rectangle.</summary>
		Left = 2,
		/// <summary>The bottom edge of the rectangle.</summary>
		Bottom = 4,
		/// <summary>The right edge of the rectangle.</summary>
		Right = 8,
		/// <summary>All edges of the rectangle.</summary>
		All = 15,
	}
}
