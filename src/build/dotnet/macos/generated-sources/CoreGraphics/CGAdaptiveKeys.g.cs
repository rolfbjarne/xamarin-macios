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
namespace CoreGraphics {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe partial class CGAdaptiveKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumBitDepthKey;
		/// <summary>Represents the value associated with the constant 'kCGAdaptiveMaximumBitDepth'.</summary>
		[Field ("kCGAdaptiveMaximumBitDepth",  "CoreGraphics")]
		public static NSString MaximumBitDepthKey {
			get {
				if (_MaximumBitDepthKey is null)
					_MaximumBitDepthKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGAdaptiveMaximumBitDepth")!;
				return _MaximumBitDepthKey;
			}
		}
	} /* class CGAdaptiveKeys */
}
