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
namespace SceneKit {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> that defines <c>options</c> when instantiating a <see cref="T:SceneKit.SCNView" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SCNRenderingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SCNRenderingOptions" /> with default (empty) values.</summary>
		public SCNRenderingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SCNRenderingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SCNRenderingOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public global::Metal.IMTLDevice? Device {
			get {
				return Dictionary [SCNRenderingOptionsKeys.DeviceKey!] as Metal.IMTLDevice;
			}
			set {
				SetNativeValue (SCNRenderingOptionsKeys.DeviceKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? LowPowerDevice {
			get {
				return  GetBoolValue (SCNRenderingOptionsKeys.LowPowerDeviceKey!);
			}
			set {
				SetBooleanValue (SCNRenderingOptionsKeys.LowPowerDeviceKey!, value);
			}
		}
#endif
	}
}
