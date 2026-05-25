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
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTEncodeFrameOptions" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTDecompressionResolutionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Height;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionResolutionKey_Height",  "VideoToolbox")]
		public static NSString Height {
			get {
				if (_Height is null)
					_Height = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionResolutionKey_Height")!;
				return _Height;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Width;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionResolutionKey_Width",  "VideoToolbox")]
		public static NSString Width {
			get {
				if (_Width is null)
					_Width = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionResolutionKey_Width")!;
				return _Width;
			}
		}
	} /* class VTDecompressionResolutionKeys */
}
