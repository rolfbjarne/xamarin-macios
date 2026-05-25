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
namespace VideoToolbox {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	public partial class VTPixelRotationProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTPixelRotationProperties" /> with default (empty) values.</summary>
		public VTPixelRotationProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTPixelRotationProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTPixelRotationProperties (NSDictionary? dictionary) : base (dictionary) {}
		public bool? FlipHorizontalOrientation {
			get {
				return  GetBoolValue (VTPixelRotationPropertyKeys.FlipHorizontalOrientation!);
			}
			set {
				SetBooleanValue (VTPixelRotationPropertyKeys.FlipHorizontalOrientation!, value);
			}
		}
		public bool? FlipVerticalOrientation {
			get {
				return  GetBoolValue (VTPixelRotationPropertyKeys.FlipVerticalOrientation!);
			}
			set {
				SetBooleanValue (VTPixelRotationPropertyKeys.FlipVerticalOrientation!, value);
			}
		}
#endif
	}
}
