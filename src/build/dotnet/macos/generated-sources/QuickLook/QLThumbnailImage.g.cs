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
namespace QuickLook {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class QLThumbnailImage  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionIconModeKey;
		/// <summary>Represents the value associated with the constant 'kQLThumbnailOptionIconModeKey'.</summary>
		[Field ("kQLThumbnailOptionIconModeKey",  "QuickLook")]
		internal static NSString OptionIconModeKey {
			get {
				if (_OptionIconModeKey is null)
					_OptionIconModeKey = Dlfcn.GetStringConstant (Libraries.QuickLook.Handle, "kQLThumbnailOptionIconModeKey")!;
				return _OptionIconModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionScaleFactorKey;
		/// <summary>Represents the value associated with the constant 'kQLThumbnailOptionScaleFactorKey'.</summary>
		[Field ("kQLThumbnailOptionScaleFactorKey",  "QuickLook")]
		internal static NSString OptionScaleFactorKey {
			get {
				if (_OptionScaleFactorKey is null)
					_OptionScaleFactorKey = Dlfcn.GetStringConstant (Libraries.QuickLook.Handle, "kQLThumbnailOptionScaleFactorKey")!;
				return _OptionScaleFactorKey;
			}
		}
	} /* class QLThumbnailImage */
}
