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
namespace Foundation {
	/// <summary>Contains the components of a recognized address.</summary><remarks>To be added.</remarks>
	public partial class NSTextCheckingAddressComponents : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSTextCheckingAddressComponents" /> with default (empty) values.</summary>
		public NSTextCheckingAddressComponents () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSTextCheckingAddressComponents" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSTextCheckingAddressComponents (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Name {
			get {
				return GetStringValue (NSTextChecking.NameKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? JobTitle {
			get {
				return GetStringValue (NSTextChecking.JobTitleKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Organization {
			get {
				return GetStringValue (NSTextChecking.OrganizationKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Street {
			get {
				return GetStringValue (NSTextChecking.StreetKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? City {
			get {
				return GetStringValue (NSTextChecking.CityKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? State {
			get {
				return GetStringValue (NSTextChecking.StateKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? ZIP {
			get {
				return GetStringValue (NSTextChecking.ZipKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Country {
			get {
				return GetStringValue (NSTextChecking.CountryKey!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Phone {
			get {
				return GetStringValue (NSTextChecking.PhoneKey!);
			}
		}
#endif
	}
}
