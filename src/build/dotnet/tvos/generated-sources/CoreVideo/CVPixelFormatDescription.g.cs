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
namespace CoreVideo {
	public partial class CVPixelFormatDescription : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CVPixelFormatDescription" /> with default (empty) values.</summary>
		public CVPixelFormatDescription () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CVPixelFormatDescription" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CVPixelFormatDescription (NSDictionary? dictionary) : base (dictionary) {}
		public string? Name {
			get {
				return GetStringValue (CVPixelFormatKeys.Name!);
			}
			set {
				SetStringValue (CVPixelFormatKeys.Name!, value);
			}
		}
		public CVPixelFormatType? Constant {
			get {
				return (CVPixelFormatType?) GetUInt32Value (CVPixelFormatKeys.Constant!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.Constant!, (System.UInt32?)value);
			}
		}
		public NSObject? CodecType {
			get {
				return GetNativeValue<Foundation.NSObject> (CVPixelFormatKeys.CodecType!);
			}
			set {
				SetNativeValue (CVPixelFormatKeys.CodecType!, value);
			}
		}
		public int? FourCC {
			get {
				return  GetInt32Value (CVPixelFormatKeys.FourCC!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.FourCC!, value);
			}
		}
		public bool? ContainsAlpha {
			get {
				return  GetBoolValue (CVPixelFormatKeys.ContainsAlpha!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.ContainsAlpha!, value);
			}
		}
		public bool? FormatContainsYCbCr {
			get {
				return  GetBoolValue (CVPixelFormatKeys.ContainsYCbCr!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.ContainsYCbCr!, value);
			}
		}
		public bool? FormatContainsRgb {
			get {
				return  GetBoolValue (CVPixelFormatKeys.ContainsRgb!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.ContainsRgb!, value);
			}
		}
		public bool? ContainsGrayscale {
			get {
				return  GetBoolValue (CVPixelFormatKeys.ContainsGrayscale!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.ContainsGrayscale!, value);
			}
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public bool? FormatContainsSenselArray {
			get {
				return  GetBoolValue (CVPixelFormatKeys.ContainsSenselArray!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.ContainsSenselArray!, value);
			}
		}
		public CVPixelFormatComponentRangeValues? ComponentRangeValue {
			get {
				return TryGetNativeValue (CVPixelFormatKeys.ComponentRange!, out var handle) ? global::CoreVideo.CVPixelFormatComponentRangeValuesExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CVPixelFormatKeys.ComponentRange!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public NSObject? Planes {
			get {
				return GetNativeValue<Foundation.NSObject> (CVPixelFormatKeys.Planes!);
			}
			set {
				SetNativeValue (CVPixelFormatKeys.Planes!, value);
			}
		}
		public int? BlockWidth {
			get {
				return  GetInt32Value (CVPixelFormatKeys.BlockWidth!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.BlockWidth!, value);
			}
		}
		public int? BlockHeight {
			get {
				return  GetInt32Value (CVPixelFormatKeys.BlockHeight!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.BlockHeight!, value);
			}
		}
		public int? BitsPerBlock {
			get {
				return  GetInt32Value (CVPixelFormatKeys.BitsPerBlock!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.BitsPerBlock!, value);
			}
		}
		public int? BlockHorizontalAlignment {
			get {
				return  GetInt32Value (CVPixelFormatKeys.BlockHorizontalAlignment!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.BlockHorizontalAlignment!, value);
			}
		}
		public int? BlockVerticalAlignment {
			get {
				return  GetInt32Value (CVPixelFormatKeys.BlockVerticalAlignment!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.BlockVerticalAlignment!, value);
			}
		}
		public NSData? BlackBlock {
			get {
				return Dictionary [CVPixelFormatKeys.BlackBlock!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CVPixelFormatKeys.BlackBlock!, value);
			}
		}
		public int? HorizontalSubsampling {
			get {
				return  GetInt32Value (CVPixelFormatKeys.HorizontalSubsampling!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.HorizontalSubsampling!, value);
			}
		}
		public int? VerticalSubsampling {
			get {
				return  GetInt32Value (CVPixelFormatKeys.VerticalSubsampling!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.VerticalSubsampling!, value);
			}
		}
		public int? OpenGLFormat {
			get {
				return  GetInt32Value (CVPixelFormatKeys.OpenGLFormat!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.OpenGLFormat!, value);
			}
		}
		public int? OpenGLType {
			get {
				return  GetInt32Value (CVPixelFormatKeys.OpenGLType!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.OpenGLType!, value);
			}
		}
		public int? OpenGLInternalFormat {
			get {
				return  GetInt32Value (CVPixelFormatKeys.OpenGLInternalFormat!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.OpenGLInternalFormat!, value);
			}
		}
		public CGBitmapFlags? CGBitmapInfo {
			get {
				return (CGBitmapFlags?) GetUInt32Value (CVPixelFormatKeys.CGBitmapInfo!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.CGBitmapInfo!, (System.UInt32?)value);
			}
		}
		public bool? QDCompatibility {
			get {
				return  GetBoolValue (CVPixelFormatKeys.QDCompatibility!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.QDCompatibility!, value);
			}
		}
		public bool? CGBitmapContextCompatibility {
			get {
				return  GetBoolValue (CVPixelFormatKeys.CGBitmapContextCompatibility!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.CGBitmapContextCompatibility!, value);
			}
		}
		public bool? CGImageCompatibility {
			get {
				return  GetBoolValue (CVPixelFormatKeys.CGImageCompatibility!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.CGImageCompatibility!, value);
			}
		}
		public bool? OpenGLCompatibility {
			get {
				return  GetBoolValue (CVPixelFormatKeys.OpenGLCompatibility!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.OpenGLCompatibility!, value);
			}
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public bool? OpenGlesCompatibility {
			get {
				return  GetBoolValue (CVPixelFormatKeys.OpenGlesCompatibility!);
			}
			set {
				SetBooleanValue (CVPixelFormatKeys.OpenGlesCompatibility!, value);
			}
		}
		public NSData? FillExtendedPixelsCallback {
			get {
				return Dictionary [CVPixelFormatKeys.FillExtendedPixelsCallback!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CVPixelFormatKeys.FillExtendedPixelsCallback!, value);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		public int? BitsPerComponent {
			get {
				return  GetInt32Value (CVPixelFormatKeys.BitsPerComponent!);
			}
			set {
				SetNumberValue (CVPixelFormatKeys.BitsPerComponent!, value);
			}
		}
#endif
	}
}
