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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class UIApplicationOpenUrlOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationKey;
		/// <summary>Represents the value associated with the constant 'UIApplicationOpenURLOptionsAnnotationKey'.</summary>
		[Field ("UIApplicationOpenURLOptionsAnnotationKey",  "UIKit")]
		public static NSString AnnotationKey {
			get {
				if (_AnnotationKey is null)
					_AnnotationKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIApplicationOpenURLOptionsAnnotationKey")!;
				return _AnnotationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenInPlaceKey;
		/// <summary>Represents the value associated with the constant 'UIApplicationOpenURLOptionsOpenInPlaceKey'.</summary>
		[Field ("UIApplicationOpenURLOptionsOpenInPlaceKey",  "UIKit")]
		public static NSString OpenInPlaceKey {
			get {
				if (_OpenInPlaceKey is null)
					_OpenInPlaceKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIApplicationOpenURLOptionsOpenInPlaceKey")!;
				return _OpenInPlaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceApplicationKey;
		/// <summary>Represents the value associated with the constant 'UIApplicationOpenURLOptionsSourceApplicationKey'.</summary>
		[Field ("UIApplicationOpenURLOptionsSourceApplicationKey",  "UIKit")]
		public static NSString SourceApplicationKey {
			get {
				if (_SourceApplicationKey is null)
					_SourceApplicationKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIApplicationOpenURLOptionsSourceApplicationKey")!;
				return _SourceApplicationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UniversalLinksOnlyKey;
		/// <summary>Represents the value associated with the constant 'UIApplicationOpenURLOptionUniversalLinksOnly'.</summary>
		[Field ("UIApplicationOpenURLOptionUniversalLinksOnly",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UniversalLinksOnlyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UniversalLinksOnlyKey is null)
					_UniversalLinksOnlyKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIApplicationOpenURLOptionUniversalLinksOnly")!;
				return _UniversalLinksOnlyKey;
			}
		}
	} /* class UIApplicationOpenUrlOptionKeys */
}
