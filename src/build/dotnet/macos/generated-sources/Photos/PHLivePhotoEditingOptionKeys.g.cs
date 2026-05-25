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
namespace Photos {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class PHLivePhotoEditingOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldRenderAtPlaybackTimeKey;
		/// <summary>Represents the value associated with the constant 'PHLivePhotoShouldRenderAtPlaybackTime'.</summary>
		[Field ("PHLivePhotoShouldRenderAtPlaybackTime",  "Photos")]
		public static NSString ShouldRenderAtPlaybackTimeKey {
			get {
				if (_ShouldRenderAtPlaybackTimeKey is null)
					_ShouldRenderAtPlaybackTimeKey = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHLivePhotoShouldRenderAtPlaybackTime")!;
				return _ShouldRenderAtPlaybackTimeKey;
			}
		}
	} /* class PHLivePhotoEditingOptionKeys */
}
