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
	/// <summary>A flagging enumeration of the properties of a <see cref="T:UIKit.UITouch" /> that may change.</summary><remarks><para>Different hardware devices have different capabilities that can vary over the duration of a touch. For instance, all current hardware allows the <see cref="F:UIKit.UITouchProperties.Location" /> property to vary, but only the Apple Pencil currently supports the <see cref="F:UIKit.UITouchProperties.Altitude" /> and <see cref="F:UIKit.UITouchProperties.Azimuth" /> values to change over the course of a touch.</para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UITouchProperties : long {
		/// <summary>The device allows for the possibility that the <see cref="P:UIKit.UITouch.Force" /> will vary over the course of a touch.</summary>
		Force = 1,
		/// <summary>The device allows for the possibility that the <see cref="M:UIKit.UITouch.GetAzimuthAngle(UIKit.UIView)" /> and <see cref="M:UIKit.UITouch.GetAzimuthUnitVector(UIKit.UIView)" /> will vary over the course of a touch.</summary>
		Azimuth = 2,
		/// <summary>The device allows for the possibility that the <see cref="P:UIKit.UITouch.AltitudeAngle" /> will vary over the course of a touch.</summary>
		Altitude = 4,
		/// <summary>The device allows for the possibility that the <see cref="M:UIKit.UITouch.LocationInView(UIKit.UIView)" /> will vary over the course of a touch.</summary>
		Location = 8,
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		Roll = 16,
	}
}
