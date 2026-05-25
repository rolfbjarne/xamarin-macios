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
namespace CoreImage {
	/// <summary>Options used in various calls to <see cref="T:CoreImage.CIImage" /> involving <see cref="T:CoreImage.ICIImageProvider" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CIImageProviderOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CIImageProviderOptions" /> with default (empty) values.</summary>
		public CIImageProviderOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CIImageProviderOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CIImageProviderOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>A <see cref="T:Foundation.NSNumber" /> that holds an int that is the length of a tile square.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSObject? TileSize {
			get {
				return GetNativeValue<Foundation.NSObject> (CIImageProviderKeys.TileSizeKey!);
			}
			set {
				SetNativeValue (CIImageProviderKeys.TileSizeKey!, value);
			}
		}
		/// <summary>User-supplied data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSObject? UserInfo {
			get {
				return GetNativeValue<Foundation.NSObject> (CIImageProviderKeys.UserInfoKey!);
			}
			set {
				SetNativeValue (CIImageProviderKeys.UserInfoKey!, value);
			}
		}
#endif
	}
}
