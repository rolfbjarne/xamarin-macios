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
namespace SpriteKit {
	/// <summary>Enumerates how neighboring tiles may be automatically placed.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SKTileAdjacencyMask : ulong {
		/// <summary>To be added.</summary>
		Up = 1,
		/// <summary>To be added.</summary>
		UpperRight = 2,
		/// <summary>To be added.</summary>
		Right = 4,
		/// <summary>To be added.</summary>
		LowerRight = 8,
		/// <summary>To be added.</summary>
		Down = 16,
		/// <summary>To be added.</summary>
		LowerLeft = 32,
		/// <summary>To be added.</summary>
		Left = 64,
		/// <summary>To be added.</summary>
		UpperLeft = 128,
		/// <summary>To be added.</summary>
		All = 255,
		/// <summary>To be added.</summary>
		HexFlatUp = 1,
		/// <summary>To be added.</summary>
		HexFlatUpperRight = 2,
		/// <summary>To be added.</summary>
		HexFlatLowerRight = 4,
		/// <summary>To be added.</summary>
		HexFlatDown = 8,
		/// <summary>To be added.</summary>
		HexFlatLowerLeft = 16,
		/// <summary>To be added.</summary>
		HexFlatUpperLeft = 32,
		/// <summary>To be added.</summary>
		HexFlatAll = 63,
		/// <summary>To be added.</summary>
		HexPointyUpperLeft = 1,
		/// <summary>To be added.</summary>
		HexPointyUpperRight = 2,
		/// <summary>To be added.</summary>
		HexPointyRight = 4,
		/// <summary>To be added.</summary>
		HexPointyLowerRight = 8,
		/// <summary>To be added.</summary>
		HexPointyLowerLeft = 16,
		/// <summary>To be added.</summary>
		HexPointyLeft = 32,
		/// <summary>To be added.</summary>
		HexPointyAll = 63,
		/// <summary>To be added.</summary>
		UpEdge = 124,
		/// <summary>To be added.</summary>
		UpperRightEdge = 112,
		/// <summary>To be added.</summary>
		RightEdge = 241,
		/// <summary>To be added.</summary>
		LowerRightEdge = 193,
		/// <summary>To be added.</summary>
		DownEdge = 199,
		/// <summary>To be added.</summary>
		LowerLeftEdge = 7,
		/// <summary>To be added.</summary>
		LeftEdge = 31,
		/// <summary>To be added.</summary>
		UpperLeftEdge = 28,
		/// <summary>To be added.</summary>
		UpperRightCorner = 223,
		/// <summary>To be added.</summary>
		LowerRightCorner = 127,
		/// <summary>To be added.</summary>
		LowerLeftCorner = 253,
		/// <summary>To be added.</summary>
		UpperLeftCorner = 247,
	}
}
