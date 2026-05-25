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
namespace VideoToolbox {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public partial class VTDecodeFrameOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTDecodeFrameOptions" /> with default (empty) values.</summary>
		public VTDecodeFrameOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTDecodeFrameOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTDecodeFrameOptions (NSDictionary? dictionary) : base (dictionary) {}
		public nint? ContentAnalyzerRotation {
			get {
				return  GetNIntValue (VTDecodeFrameOptionKey.ContentAnalyzerRotation!);
			}
			set {
				SetNumberValue (VTDecodeFrameOptionKey.ContentAnalyzerRotation!, value);
			}
		}
		public CGRectDictionary? ContentAnalyzerCropRectangle {
			get {
				return GetStrongDictionary<CGRectDictionary>(VTDecodeFrameOptionKey.ContentAnalyzerCropRectangle!, (dict) => new CGRectDictionary (dict));
			}
			set {
				SetNativeValue (VTDecodeFrameOptionKey.ContentAnalyzerCropRectangle!, value?.Dictionary);
			}
		}
#endif
	}
}
