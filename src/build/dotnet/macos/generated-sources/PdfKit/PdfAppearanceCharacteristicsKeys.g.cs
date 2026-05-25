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
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PdfAppearanceCharacteristicsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFAppearanceCharacteristicsKeyBackgroundColor",  "Quartz")]
		public static NSString BackgroundColorKey {
			get {
				if (_BackgroundColorKey is null)
					_BackgroundColorKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyBackgroundColor")!;
				return _BackgroundColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BorderColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFAppearanceCharacteristicsKeyBorderColor",  "Quartz")]
		public static NSString BorderColorKey {
			get {
				if (_BorderColorKey is null)
					_BorderColorKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyBorderColor")!;
				return _BorderColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CaptionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFAppearanceCharacteristicsKeyCaption",  "Quartz")]
		public static NSString CaptionKey {
			get {
				if (_CaptionKey is null)
					_CaptionKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyCaption")!;
				return _CaptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownCaptionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFAppearanceCharacteristicsKeyDownCaption",  "Quartz")]
		public static NSString DownCaptionKey {
			get {
				if (_DownCaptionKey is null)
					_DownCaptionKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyDownCaption")!;
				return _DownCaptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RolloverCaptionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFAppearanceCharacteristicsKeyRolloverCaption",  "Quartz")]
		public static NSString RolloverCaptionKey {
			get {
				if (_RolloverCaptionKey is null)
					_RolloverCaptionKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyRolloverCaption")!;
				return _RolloverCaptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RotationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFAppearanceCharacteristicsKeyRotation",  "Quartz")]
		public static NSString RotationKey {
			get {
				if (_RotationKey is null)
					_RotationKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyRotation")!;
				return _RotationKey;
			}
		}
	} /* class PdfAppearanceCharacteristicsKeys */
}
