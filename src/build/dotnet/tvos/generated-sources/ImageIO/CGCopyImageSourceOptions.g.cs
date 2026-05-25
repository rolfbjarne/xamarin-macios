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
namespace ImageIO {
	public partial class CGCopyImageSourceOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGCopyImageSourceOptions" /> with default (empty) values.</summary>
		public CGCopyImageSourceOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGCopyImageSourceOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGCopyImageSourceOptions (NSDictionary? dictionary) : base (dictionary) {}
		public CGImageMetadata? Metadata {
			get {
				return GetNativeValue<ImageIO.CGImageMetadata> (CGCopyImageSourceOptionsKeys.MetadataKey!);
			}
			set {
				SetNativeValue (CGCopyImageSourceOptionsKeys.MetadataKey!, value);
			}
		}
		public bool? NullableMergeMetadata {
			get {
				return  GetBoolValue (CGCopyImageSourceOptionsKeys.MergeMetadataKey!);
			}
			set {
				SetBooleanValue (CGCopyImageSourceOptionsKeys.MergeMetadataKey!, value);
			}
		}
		public bool? NullableShouldExcludeXmp {
			get {
				return  GetBoolValue (CGCopyImageSourceOptionsKeys.ShouldExcludeXmpKey!);
			}
			set {
				SetBooleanValue (CGCopyImageSourceOptionsKeys.ShouldExcludeXmpKey!, value);
			}
		}
		public bool? NullableShouldExcludeGps {
			get {
				return  GetBoolValue (CGCopyImageSourceOptionsKeys.ShouldExcludeGpsKey!);
			}
			set {
				SetBooleanValue (CGCopyImageSourceOptionsKeys.ShouldExcludeGpsKey!, value);
			}
		}
		public global::System.DateTime? DateTime {
			get {
				return GetDateTimeValue (CGCopyImageSourceOptionsKeys.DateTimeKey!);
			}
			set {
				SetNativeValue (CGCopyImageSourceOptionsKeys.DateTimeKey!, (NSDate?) value);
			}
		}
		public int? Orientation {
			get {
				return  GetInt32Value (CGCopyImageSourceOptionsKeys.OrientationKey!);
			}
			set {
				SetNumberValue (CGCopyImageSourceOptionsKeys.OrientationKey!, value);
			}
		}
		public CGImagePropertyEncoder? Encoder {
			get {
				return TryGetNativeValue (CGCopyImageSourceOptionsKeys.EncoderKey!, out var handle) ? global::ImageIO.CGImagePropertyEncoderExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CGCopyImageSourceOptionsKeys.EncoderKey!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public int? BCFormat {
			get {
				return  GetInt32Value (CGCopyImageSourceOptionsKeys.BCFormatKey!);
			}
			set {
				SetNumberValue (CGCopyImageSourceOptionsKeys.BCFormatKey!, value);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public CGImagePropertyAstcBlockSize? AstcBlockSize {
			get {
				return TryGetNativeValue (CGCopyImageSourceOptionsKeys.AstcBlockSizeKey!, out var handle) ? global::ImageIO.CGImagePropertyAstcBlockSizeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CGCopyImageSourceOptionsKeys.AstcBlockSizeKey!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
#endif
	}
}
