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
namespace CoreData {
	/// <summary>An enumeration whose values define the valid types for <see cref="T:CoreData.NSAttributeType" /> objects.</summary>
	[Native]
	public enum NSAttributeType : ulong {
		/// <summary>Indicates an undefined type.</summary>
		Undefined = 0,
		/// <summary>Indicates a signed 16-bit integer.</summary>
		Integer16 = 100,
		/// <summary>Indicates a signed 32-bit integer..</summary>
		Integer32 = 200,
		/// <summary>Indicates a signed 64-bit integer.</summary>
		Integer64 = 300,
		/// <summary>Indicates an NSDecimalNumber.</summary>
		Decimal = 400,
		/// <summary>Indicates a double.</summary>
		Double = 500,
		/// <summary>Indicates a float.</summary>
		Float = 600,
		/// <summary>Indicates an NSString.</summary>
		String = 700,
		/// <summary>Indicates a Boolean value</summary>
		Boolean = 800,
		/// <summary>Indicates an NSDate.</summary>
		Date = 900,
		/// <summary>Indicates NSData.</summary>
		Binary = 1000,
		/// <summary>Indicates a UUID.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Uuid = 1100,
		/// <summary>Indicates a URI.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Uri = 1200,
		/// <summary>Indicates a type with an available transformer.</summary>
		Transformable = 1800,
		/// <summary>Indicates an Object ID.</summary>
		ObjectID = 2000,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		CompositeAttributeType = 2100,
	}
}
