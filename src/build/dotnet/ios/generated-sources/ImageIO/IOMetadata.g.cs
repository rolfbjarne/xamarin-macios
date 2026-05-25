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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ImageIO {
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe static partial class IOMetadata  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraExtrinsicsKey;
		/// <summary>Represents the value associated with the constant 'kIIOMetadata_CameraExtrinsicsKey'.</summary>
		[Field ("kIIOMetadata_CameraExtrinsicsKey",  "ImageIO")]
		public static NSString CameraExtrinsicsKey {
			get {
				if (_CameraExtrinsicsKey is null)
					_CameraExtrinsicsKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOMetadata_CameraExtrinsicsKey")!;
				return _CameraExtrinsicsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraModelKey;
		/// <summary>Represents the value associated with the constant 'kIIOMetadata_CameraModelKey'.</summary>
		[Field ("kIIOMetadata_CameraModelKey",  "ImageIO")]
		public static NSString CameraModelKey {
			get {
				if (_CameraModelKey is null)
					_CameraModelKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOMetadata_CameraModelKey")!;
				return _CameraModelKey;
			}
		}
	} /* class IOMetadata */
}
