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
	/// <summary>Strongly typed representation of a video encoder.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTVideoEncoderSpecification : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTVideoEncoderSpecification" /> with default (empty) values.</summary>
		public VTVideoEncoderSpecification () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTVideoEncoderSpecification" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTVideoEncoderSpecification (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("macos")]
		public bool? EnableHardwareAcceleratedVideoEncoder {
			get {
				return  GetBoolValue (VTVideoEncoderSpecificationKeys.EnableHardwareAcceleratedVideoEncoder!);
			}
			set {
				SetBooleanValue (VTVideoEncoderSpecificationKeys.EnableHardwareAcceleratedVideoEncoder!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("macos")]
		public bool? RequireHardwareAcceleratedVideoEncoder {
			get {
				return  GetBoolValue (VTVideoEncoderSpecificationKeys.RequireHardwareAcceleratedVideoEncoder!);
			}
			set {
				SetBooleanValue (VTVideoEncoderSpecificationKeys.RequireHardwareAcceleratedVideoEncoder!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? EncoderID {
			get {
				return GetStringValue (VTVideoEncoderSpecificationKeys.EncoderID!);
			}
			set {
				SetStringValue (VTVideoEncoderSpecificationKeys.EncoderID!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint? RequiredEncoderGpuRegistryId {
			get {
				return  GetUInt32Value (VTVideoEncoderSpecificationKeys.RequiredEncoderGpuRegistryId!);
			}
			set {
				SetNumberValue (VTVideoEncoderSpecificationKeys.RequiredEncoderGpuRegistryId!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public uint? PreferredEncoderGpuRegistryId {
			get {
				return  GetUInt32Value (VTVideoEncoderSpecificationKeys.PreferredEncoderGpuRegistryId!);
			}
			set {
				SetNumberValue (VTVideoEncoderSpecificationKeys.PreferredEncoderGpuRegistryId!, value);
			}
		}
#endif
	}
}
