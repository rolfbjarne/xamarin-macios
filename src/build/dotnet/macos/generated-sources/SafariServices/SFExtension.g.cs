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
namespace SafariServices {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class SFExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MessageKey;
		/// <summary>Represents the value associated with the constant 'SFExtensionMessageKey'.</summary>
		[Field ("SFExtensionMessageKey",  "SafariServices")]
		public static NSString MessageKey {
			get {
				if (_MessageKey is null)
					_MessageKey = Dlfcn.GetStringConstant (Libraries.SafariServices.Handle, "SFExtensionMessageKey")!;
				return _MessageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileKey;
		/// <summary>Represents the value associated with the constant 'SFExtensionProfileKey'.</summary>
		[Field ("SFExtensionProfileKey",  "SafariServices")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.1")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString ProfileKey {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.1")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_ProfileKey is null)
					_ProfileKey = Dlfcn.GetStringConstant (Libraries.SafariServices.Handle, "SFExtensionProfileKey")!;
				return _ProfileKey;
			}
		}
	} /* class SFExtension */
}
