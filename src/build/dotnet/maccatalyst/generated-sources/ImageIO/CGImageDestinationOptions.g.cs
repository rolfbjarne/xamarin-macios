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
namespace ImageIO {
	/// <summary>Use an instance of this class to configure how an image is added to a <see cref="ImageIO.CGImageDestination" />.</summary><remarks><para>Use this class to configure the parameters when you add an image to CGImageDestination.</para></remarks>
	public partial class CGImageDestinationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGImageDestinationOptions" /> with default (empty) values.</summary>
		public CGImageDestinationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGImageDestinationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGImageDestinationOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>The quality used to encode the image.</summary><value>Values between 0.0 (maximum compression) and 1.0 (no compression, use lossless).</value><remarks>To be added.</remarks>
		public float? LossyCompressionQuality {
			get {
				return  GetFloatValue (CGImageDestinationOptionsKeys.LossyCompressionQuality!);
			}
			set {
				SetNumberValue (CGImageDestinationOptionsKeys.LossyCompressionQuality!, value);
			}
		}
		/// <summary /><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public int? ImageMaxPixelSize {
			get {
				return  GetInt32Value (CGImageDestinationOptionsKeys.ImageMaxPixelSize!);
			}
			set {
				SetNumberValue (CGImageDestinationOptionsKeys.ImageMaxPixelSize!, value);
			}
		}
		/// <summary>Controls whether to embed a JPEG image thumbnail in the destination file.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? EmbedThumbnail {
			get {
				return  GetBoolValue (CGImageDestinationOptionsKeys.EmbedThumbnail!);
			}
			set {
				SetBooleanValue (CGImageDestinationOptionsKeys.EmbedThumbnail!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? OptimizeColorForSharing {
			get {
				return  GetBoolValue (CGImageDestinationOptionsKeys.OptimizeColorForSharing!);
			}
			set {
				SetBooleanValue (CGImageDestinationOptionsKeys.OptimizeColorForSharing!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImagePropertiesTiff? TiffDictionary {
			get {
				return GetStrongDictionary<CGImagePropertiesTiff>(CGImageDestinationOptionsKeys.TIFFDictionary!, (dict) => new CGImagePropertiesTiff (dict));
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.TIFFDictionary!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? GifDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.GIFDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.GIFDictionary!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImagePropertiesJfif? JfifDictionary {
			get {
				return GetStrongDictionary<CGImagePropertiesJfif>(CGImageDestinationOptionsKeys.JFIFDictionary!, (dict) => new CGImagePropertiesJfif (dict));
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.JFIFDictionary!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImagePropertiesExif? ExifDictionary {
			get {
				return GetStrongDictionary<CGImagePropertiesExif>(CGImageDestinationOptionsKeys.ExifDictionary!, (dict) => new CGImagePropertiesExif (dict));
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.ExifDictionary!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImagePropertiesPng? PngDictionary {
			get {
				return GetStrongDictionary<CGImagePropertiesPng>(CGImageDestinationOptionsKeys.PNGDictionary!, (dict) => new CGImagePropertiesPng (dict));
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.PNGDictionary!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImagePropertiesIptc? IptcDictionary {
			get {
				return GetStrongDictionary<CGImagePropertiesIptc>(CGImageDestinationOptionsKeys.IPTCDictionary!, (dict) => new CGImagePropertiesIptc (dict));
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.IPTCDictionary!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CGImagePropertiesGps? GpsDictionary {
			get {
				return GetStrongDictionary<CGImagePropertiesGps>(CGImageDestinationOptionsKeys.GPSDictionary!, (dict) => new CGImagePropertiesGps (dict));
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.GPSDictionary!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? RawDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.RawDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.RawDictionary!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? CiffDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.CIFFDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.CIFFDictionary!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? EightBimDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.EightBIMDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.EightBIMDictionary!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? DngDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.DNGDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.DNGDictionary!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? ExifAuxDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.ExifAuxDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.ExifAuxDictionary!, value);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSDictionary? WebPDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.WebPDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.WebPDictionary!, value);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSDictionary? TgaDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.TgaDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.TgaDictionary!, value);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public NSDictionary? AvisDictionary {
			get {
				return GetNSDictionary (CGImageDestinationOptionsKeys.AvisDictionary!);
			}
			set {
				SetNativeValue (CGImageDestinationOptionsKeys.AvisDictionary!, value);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? PreserveGainMap {
			get {
				return  GetBoolValue (CGImageDestinationOptionsKeys.PreserveGainMapKey!);
			}
			set {
				SetBooleanValue (CGImageDestinationOptionsKeys.PreserveGainMapKey!, value);
			}
		}
#endif
	}
}
