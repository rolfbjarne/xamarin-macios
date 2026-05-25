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
namespace VideoToolbox {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	public unsafe static partial class VTPixelRotationPropertyKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlipHorizontalOrientation;
		/// <summary>Represents the value associated with the constant 'kVTPixelRotationPropertyKey_FlipHorizontalOrientation'.</summary>
		[Field ("kVTPixelRotationPropertyKey_FlipHorizontalOrientation",  "VideoToolbox")]
		public static NSString FlipHorizontalOrientation {
			get {
				if (_FlipHorizontalOrientation is null)
					_FlipHorizontalOrientation = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelRotationPropertyKey_FlipHorizontalOrientation")!;
				return _FlipHorizontalOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlipVerticalOrientation;
		/// <summary>Represents the value associated with the constant 'kVTPixelRotationPropertyKey_FlipVerticalOrientation'.</summary>
		[Field ("kVTPixelRotationPropertyKey_FlipVerticalOrientation",  "VideoToolbox")]
		public static NSString FlipVerticalOrientation {
			get {
				if (_FlipVerticalOrientation is null)
					_FlipVerticalOrientation = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelRotationPropertyKey_FlipVerticalOrientation")!;
				return _FlipVerticalOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Rotation;
		/// <summary>Represents the value associated with the constant 'kVTPixelRotationPropertyKey_Rotation'.</summary>
		[Field ("kVTPixelRotationPropertyKey_Rotation",  "VideoToolbox")]
		public static NSString Rotation {
			get {
				if (_Rotation is null)
					_Rotation = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelRotationPropertyKey_Rotation")!;
				return _Rotation;
			}
		}
	} /* class VTPixelRotationPropertyKeys */
}
