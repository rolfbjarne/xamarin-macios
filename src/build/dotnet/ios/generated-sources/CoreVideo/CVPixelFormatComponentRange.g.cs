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
namespace CoreVideo {
	public partial class CVPixelFormatComponentRange : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CVPixelFormatComponentRange" /> with default (empty) values.</summary>
		public CVPixelFormatComponentRange () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CVPixelFormatComponentRange" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CVPixelFormatComponentRange (NSDictionary? dictionary) : base (dictionary) {}
		public NSObject? VideoRange {
			get {
				return GetNativeValue<Foundation.NSObject> (CVPixelFormatComponentRangeKeys.VideoRange!);
			}
			set {
				SetNativeValue (CVPixelFormatComponentRangeKeys.VideoRange!, value);
			}
		}
		public NSObject? FullRange {
			get {
				return GetNativeValue<Foundation.NSObject> (CVPixelFormatComponentRangeKeys.FullRange!);
			}
			set {
				SetNativeValue (CVPixelFormatComponentRangeKeys.FullRange!, value);
			}
		}
		public NSObject? WideRange {
			get {
				return GetNativeValue<Foundation.NSObject> (CVPixelFormatComponentRangeKeys.WideRange!);
			}
			set {
				SetNativeValue (CVPixelFormatComponentRangeKeys.WideRange!, value);
			}
		}
#endif
	}
}
