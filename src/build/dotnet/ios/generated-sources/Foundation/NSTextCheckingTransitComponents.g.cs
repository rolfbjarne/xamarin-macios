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
namespace Foundation {
	/// <summary>Contains the components of a recognized travel data.</summary><remarks>To be added.</remarks>
	public partial class NSTextCheckingTransitComponents : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSTextCheckingTransitComponents" /> with default (empty) values.</summary>
		public NSTextCheckingTransitComponents () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSTextCheckingTransitComponents" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSTextCheckingTransitComponents (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Airline {
			get {
				return GetStringValue (NSTextChecking.AirlineKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Flight {
			get {
				return GetStringValue (NSTextChecking.FlightKey!);
			}
		}
#endif
	}
}
