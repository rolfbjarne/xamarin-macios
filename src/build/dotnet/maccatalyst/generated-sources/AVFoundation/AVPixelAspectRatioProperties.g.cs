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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class AVPixelAspectRatioProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVPixelAspectRatioProperties" /> with default (empty) values.</summary>
		public AVPixelAspectRatioProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVPixelAspectRatioProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVPixelAspectRatioProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? PixelAspectRatioHorizontalSpacing {
			get {
				return Dictionary [AVPixelAspectRatioPropertiesKeys.PixelAspectRatioHorizontalSpacingKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVPixelAspectRatioPropertiesKeys.PixelAspectRatioHorizontalSpacingKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? PixelAspectRatioVerticalSpacing {
			get {
				return Dictionary [AVPixelAspectRatioPropertiesKeys.PixelAspectRatioVerticalSpacingKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVPixelAspectRatioPropertiesKeys.PixelAspectRatioVerticalSpacingKey!, value);
			}
		}
#endif
	}
}
