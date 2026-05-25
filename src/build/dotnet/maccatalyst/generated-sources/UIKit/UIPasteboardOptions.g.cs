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
namespace UIKit {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> that holds options for describing pasteboard privacy.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public partial class UIPasteboardOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="UIPasteboardOptions" /> with default (empty) values.</summary>
		public UIPasteboardOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="UIPasteboardOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public UIPasteboardOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the date at which the system will remove the data from the pasteboard.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDate? ExpirationDate {
			get {
				return Dictionary [UIPasteboardOptionKeys.ExpirationDateKey!] as Foundation.NSDate;
			}
			set {
				SetNativeValue (UIPasteboardOptionKeys.ExpirationDateKey!, value);
			}
		}
		/// <summary>Gets or sets whether the pasteboard items should not be shareable via Handoff.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? LocalOnly {
			get {
				return  GetBoolValue (UIPasteboardOptionKeys.LocalOnlyKey!);
			}
			set {
				SetBooleanValue (UIPasteboardOptionKeys.LocalOnlyKey!, value);
			}
		}
#endif
	}
}
