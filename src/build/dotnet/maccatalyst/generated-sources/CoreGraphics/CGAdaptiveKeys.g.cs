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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
