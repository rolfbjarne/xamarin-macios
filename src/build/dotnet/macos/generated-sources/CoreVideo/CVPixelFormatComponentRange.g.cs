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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
