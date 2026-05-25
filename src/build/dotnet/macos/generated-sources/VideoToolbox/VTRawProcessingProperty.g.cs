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
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public partial class VTRawProcessingProperty : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTRawProcessingProperty" /> with default (empty) values.</summary>
		public VTRawProcessingProperty () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTRawProcessingProperty" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTRawProcessingProperty (NSDictionary? dictionary) : base (dictionary) {}
		public ulong? MetalDeviceRegistryId {
			get {
				return  GetULongValue (VTRawProcessingPropertyKey.MetalDeviceRegistryId!);
			}
			set {
				SetNumberValue (VTRawProcessingPropertyKey.MetalDeviceRegistryId!, value);
			}
		}
		public NSDictionary? OutputColorAttachments {
			get {
				return GetNSDictionary (VTRawProcessingPropertyKey.OutputColorAttachments!);
			}
		}
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public NSData? MetadataForSidecarFile {
			get {
				return Dictionary [VTRawProcessingPropertyKey.MetadataForSidecarFile!] as Foundation.NSData;
			}
		}
#endif
	}
}
