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
namespace CoreText {
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTTypesetterOptions" />.</summary>
	public unsafe static partial class CTTypesetterOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowUnboundedLayout;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCTTypesetterOptionAllowUnboundedLayout",  "CoreText")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AllowUnboundedLayout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AllowUnboundedLayout is null)
					_AllowUnboundedLayout = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTTypesetterOptionAllowUnboundedLayout")!;
				return _AllowUnboundedLayout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisableBidiProcessing;
		/// <summary>Developers should not use this deprecated field. </summary><remarks>To be added.</remarks>
		[Field ("kCTTypesetterOptionDisableBidiProcessing",  "CoreText")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[ObsoletedOSPlatform ("macos10.8")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString DisableBidiProcessing {
			[ObsoletedOSPlatform ("ios6.0")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[ObsoletedOSPlatform ("macos10.8")]
			[ObsoletedOSPlatform ("tvos9.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_DisableBidiProcessing is null)
					_DisableBidiProcessing = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTTypesetterOptionDisableBidiProcessing")!;
				return _DisableBidiProcessing;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForceEmbeddingLevel;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTTypesetterOptionForcedEmbeddingLevel",  "CoreText")]
		public static NSString ForceEmbeddingLevel {
			get {
				if (_ForceEmbeddingLevel is null)
					_ForceEmbeddingLevel = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTTypesetterOptionForcedEmbeddingLevel")!;
				return _ForceEmbeddingLevel;
			}
		}
	} /* class CTTypesetterOptionKey */
}
