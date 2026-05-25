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
namespace MapKit {
	/// <summary>An enumeration whose values specify the routing type for directions requests.</summary><remarks><para>The <see cref="T:MapKit.MKDirectionsTransportType" /> used as the <see cref="P:MapKit.MKDirectionsRequest.TransportType" /> property of a <see cref="T:MapKit.MKDirectionsRequest" /> must match the values specified in the application's <c>info.plist</c> (see <see cref="T:MapKit.MKDirections" />).</para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MKDirectionsTransportType : ulong {
		/// <summary>Routing for automobiles.</summary>
		Automobile = 1,
		/// <summary>Routing for walking.</summary>
		Walking = 2,
		/// <summary>Routing for public transport.</summary>
		Transit = 4,
		/// <summary>Routing for cycling.</summary>
		Cycling = 8,
		/// <summary>The routing type is not specified.</summary>
		Any = 268435455,
	}
}
