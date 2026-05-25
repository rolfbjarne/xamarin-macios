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
namespace CoreBluetooth {
	/// <summary>Contains options for initializing a Bluetooth central manager.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CBCentralInitOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CBCentralInitOptions" /> with default (empty) values.</summary>
		public CBCentralInitOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CBCentralInitOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CBCentralInitOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ShowPowerAlert {
			get {
				return  GetBoolValue (CBCentralManager.OptionShowPowerAlertKey!);
			}
			set {
				SetBooleanValue (CBCentralManager.OptionShowPowerAlertKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public string? RestoreIdentifier {
			get {
				return GetStringValue (CBCentralManager.OptionRestoreIdentifierKey!);
			}
			set {
				SetStringValue (CBCentralManager.OptionRestoreIdentifierKey!, value);
			}
		}
#endif
	}
}
