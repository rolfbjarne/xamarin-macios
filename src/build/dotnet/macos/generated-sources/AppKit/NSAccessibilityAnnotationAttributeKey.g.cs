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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSAccessibilityAnnotationAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationElement;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAnnotationElement",  "AppKit")]
		public static NSString AnnotationElement {
			get {
				if (_AnnotationElement is null)
					_AnnotationElement = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnnotationElement")!;
				return _AnnotationElement;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationLabel;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAnnotationLabel",  "AppKit")]
		public static NSString AnnotationLabel {
			get {
				if (_AnnotationLabel is null)
					_AnnotationLabel = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnnotationLabel")!;
				return _AnnotationLabel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationLocation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAnnotationLocation",  "AppKit")]
		public static NSString AnnotationLocation {
			get {
				if (_AnnotationLocation is null)
					_AnnotationLocation = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnnotationLocation")!;
				return _AnnotationLocation;
			}
		}
	} /* class NSAccessibilityAnnotationAttributeKey */
}
