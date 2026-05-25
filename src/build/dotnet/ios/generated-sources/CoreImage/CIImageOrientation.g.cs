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
namespace CoreImage {
	/// <summary>An enumeration whose values specify the origin of the <see cref="T:CoreImage.CIImage" />.</summary><remarks><para>The enumeration values are equal to those of the EXIF and TIFF specifications.</para></remarks>
	public enum CIImageOrientation : int {
		/// <summary>Standard position.</summary>
		TopLeft = 1,
		/// <summary>Mirror image of standard position.</summary>
		TopRight = 2,
		/// <summary>Rotated 180 degrees from standard position.</summary>
		BottomRight = 3,
		/// <summary>Mirror image taken after the standard position image has been rotated 180 degrees.</summary>
		BottomLeft = 4,
		/// <summary>Mirror image taken after the standard position image has been rotated 90 degrees clockwise.</summary>
		LeftTop = 5,
		/// <summary>Rotated 90 degrees counterclockwise from standard position.</summary>
		RightTop = 6,
		/// <summary>Mirror image taken after the standard position image has been rotated 90 degrees counterclockwise.</summary>
		RightBottom = 7,
		/// <summary>Rotated 90 degrees clockwise from standard position.</summary>
		LeftBottom = 8,
	}
}
