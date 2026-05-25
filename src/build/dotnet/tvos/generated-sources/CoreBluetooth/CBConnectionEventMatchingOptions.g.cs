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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreBluetooth {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public partial class CBConnectionEventMatchingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CBConnectionEventMatchingOptions" /> with default (empty) values.</summary>
		public CBConnectionEventMatchingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CBConnectionEventMatchingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CBConnectionEventMatchingOptions (NSDictionary? dictionary) : base (dictionary) {}
		public NSUuid[]? PeripheralUuids {
			get {
				return GetArray<NSUuid> (CBConnectionEventMatchingOptionsKeys.PeripheralUuidsKey!);
			}
			set {
				SetArrayValue (CBConnectionEventMatchingOptionsKeys.PeripheralUuidsKey!, value);
			}
		}
		public CBUUID[]? ServiceUuids {
			get {
				return GetArray<CBUUID> (CBConnectionEventMatchingOptionsKeys.ServiceUuidsKey!);
			}
			set {
				SetArrayValue (CBConnectionEventMatchingOptionsKeys.ServiceUuidsKey!, value);
			}
		}
#endif
	}
}
