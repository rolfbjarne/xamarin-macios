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
namespace Security {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SecKeyKeyExchangeParameter : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SecKeyKeyExchangeParameter" /> with default (empty) values.</summary>
		public SecKeyKeyExchangeParameter () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SecKeyKeyExchangeParameter" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SecKeyKeyExchangeParameter (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? RequestedSize {
			get {
				return  GetInt32Value (SecKeyKeyExchangeParameterKey.RequestedSizeKey!);
			}
			set {
				SetNumberValue (SecKeyKeyExchangeParameterKey.RequestedSizeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? SharedInfo {
			get {
				return Dictionary [SecKeyKeyExchangeParameterKey.SharedInfoKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (SecKeyKeyExchangeParameterKey.SharedInfoKey!, value);
			}
		}
#endif
	}
}
