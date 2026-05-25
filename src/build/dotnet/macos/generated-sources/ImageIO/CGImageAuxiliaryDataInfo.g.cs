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
namespace ImageIO {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CGImageAuxiliaryDataInfo : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGImageAuxiliaryDataInfo" /> with default (empty) values.</summary>
		public CGImageAuxiliaryDataInfo () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGImageAuxiliaryDataInfo" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGImageAuxiliaryDataInfo (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? Data {
			get {
				return Dictionary [CGImageAuxiliaryDataInfoKeys.DataKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CGImageAuxiliaryDataInfoKeys.DataKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? DataDescription {
			get {
				return GetNSDictionary (CGImageAuxiliaryDataInfoKeys.DataDescriptionKey!);
			}
			set {
				SetNativeValue (CGImageAuxiliaryDataInfoKeys.DataDescriptionKey!, value);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public CGColorSpace? ColorSpace {
			get {
				return GetNativeValue<CoreGraphics.CGColorSpace> (CGImageAuxiliaryDataInfoKeys.ColorSpaceKey!);
			}
			set {
				SetNativeValue (CGImageAuxiliaryDataInfoKeys.ColorSpaceKey!, value);
			}
		}
#endif
	}
}
