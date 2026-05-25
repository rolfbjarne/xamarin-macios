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
namespace MapKit {
	/// <summary>Class that contains address data for a place mark.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public partial class MKPlacemarkAddress : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="MKPlacemarkAddress" /> with default (empty) values.</summary>
		public MKPlacemarkAddress () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="MKPlacemarkAddress" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public MKPlacemarkAddress (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? City {
			get {
				return GetStringValue (global::AddressBook.ABPersonAddressKey.City!);
			}
			set {
				SetStringValue (global::AddressBook.ABPersonAddressKey.City!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Country {
			get {
				return GetStringValue (global::AddressBook.ABPersonAddressKey.Country!);
			}
			set {
				SetStringValue (global::AddressBook.ABPersonAddressKey.Country!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? CountryCode {
			get {
				return GetStringValue (global::AddressBook.ABPersonAddressKey.CountryCode!);
			}
			set {
				SetStringValue (global::AddressBook.ABPersonAddressKey.CountryCode!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? State {
			get {
				return GetStringValue (global::AddressBook.ABPersonAddressKey.State!);
			}
			set {
				SetStringValue (global::AddressBook.ABPersonAddressKey.State!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Street {
			get {
				return GetStringValue (global::AddressBook.ABPersonAddressKey.Street!);
			}
			set {
				SetStringValue (global::AddressBook.ABPersonAddressKey.Street!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Zip {
			get {
				return GetStringValue (global::AddressBook.ABPersonAddressKey.Zip!);
			}
			set {
				SetStringValue (global::AddressBook.ABPersonAddressKey.Zip!, value);
			}
		}
#endif
	}
}
