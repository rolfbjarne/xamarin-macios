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
	public unsafe static partial class PdfBorderKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DashPatternKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFBorderKeyDashPattern",  "Quartz")]
		public static NSString DashPatternKey {
			get {
				if (_DashPatternKey is null)
					_DashPatternKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFBorderKeyDashPattern")!;
				return _DashPatternKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LineWidthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFBorderKeyLineWidth",  "Quartz")]
		public static NSString LineWidthKey {
			get {
				if (_LineWidthKey is null)
					_LineWidthKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFBorderKeyLineWidth")!;
				return _LineWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StyleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PDFBorderKeyStyle",  "Quartz")]
		public static NSString StyleKey {
			get {
				if (_StyleKey is null)
					_StyleKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFBorderKeyStyle")!;
				return _StyleKey;
			}
		}
	} /* class PdfBorderKeys */
}
