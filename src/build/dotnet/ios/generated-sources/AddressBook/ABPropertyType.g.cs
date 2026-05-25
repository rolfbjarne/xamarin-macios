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
namespace AddressBook {
	/// <summary>Record property types.</summary>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum ABPropertyType : uint {
		/// <summary>Invalid property type.</summary>
		Invalid = 0,
		/// <summary>
		/// The property holds a <see cref="T:System.String" /> value.
		/// </summary>
		String = 1,
		/// <summary>
		/// The property holds a <see cref="T:Foundation.NSNumber" /> value.
		/// </summary>
		Integer = 2,
		/// <summary>
		/// The property holds a <see cref="T:Foundation.NSNumber" /> value.
		/// </summary>
		Real = 3,
		/// <summary>
		/// The property holds a <see cref="T:Foundation.NSDate" /> value.
		/// </summary>
		DateTime = 4,
		/// <summary>
		/// The property holds a <see cref="T:Foundation.NSDictionary" /> value.
		/// </summary>
		Dictionary = 5,
		/// <summary>
		/// The property holds a
		/// <see cref="AddressBook.ABMultiValue&lt;T&gt;" />
		/// value.
		/// </summary>
		MultiString = 257,
		/// <summary>
		/// The property holds a
		/// <see cref="AddressBook.ABMultiValue&lt;T&gt;" /> of <see cref="T:Foundation.NSNumber" />
		/// value.
		/// </summary>
		MultiInteger = 258,
		/// <summary>
		/// The property holds a
		/// <see cref="AddressBook.ABMultiValue&lt;T&gt;" /> of <see cref="T:Foundation.NSNumber" />
		/// value.
		/// </summary>
		MultiReal = 259,
		/// <summary>
		/// The property holds a
		/// <see cref="AddressBook.ABMultiValue&lt;T&gt;" /> of <see cref="T:Foundation.NSDate" />
		/// value.
		/// </summary>
		MultiDateTime = 260,
		/// <summary>
		/// The property holds a
		/// <see cref="AddressBook.ABMultiValue&lt;T&gt;" /> of <see cref="T:Foundation.NSDictionary" />
		/// value.
		/// </summary>
		MultiDictionary = 261,
		MultiMask = 256,
	}
}
