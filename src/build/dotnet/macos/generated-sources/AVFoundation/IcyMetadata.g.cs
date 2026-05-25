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
namespace AVFoundation {
	/// <summary>Constants identifying Icy streaming metadata properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class IcyMetadata  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _StreamTitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierIcyMetadataStreamTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierIcyMetadataStreamTitle",  "AVFoundation")]
			public static NSString StreamTitle {
				get {
					if (_StreamTitle is null)
						_StreamTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierIcyMetadataStreamTitle")!;
					return _StreamTitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _StreamUrl;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierIcyMetadataStreamURL</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierIcyMetadataStreamURL",  "AVFoundation")]
			public static NSString StreamUrl {
				get {
					if (_StreamUrl is null)
						_StreamUrl = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierIcyMetadataStreamURL")!;
					return _StreamUrl;
				}
			}
		} /* class IcyMetadata */
	}
}
