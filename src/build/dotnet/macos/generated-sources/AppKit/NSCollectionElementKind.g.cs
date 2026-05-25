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
	public unsafe static partial class NSCollectionElementKind  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InterItemGapIndicator;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCollectionElementKindInterItemGapIndicator",  "AppKit")]
		public static NSString InterItemGapIndicator {
			get {
				if (_InterItemGapIndicator is null)
					_InterItemGapIndicator = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCollectionElementKindInterItemGapIndicator")!;
				return _InterItemGapIndicator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SectionFooter;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCollectionElementKindSectionFooter",  "AppKit")]
		public static NSString SectionFooter {
			get {
				if (_SectionFooter is null)
					_SectionFooter = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCollectionElementKindSectionFooter")!;
				return _SectionFooter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SectionHeader;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCollectionElementKindSectionHeader",  "AppKit")]
		public static NSString SectionHeader {
			get {
				if (_SectionHeader is null)
					_SectionHeader = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCollectionElementKindSectionHeader")!;
				return _SectionHeader;
			}
		}
	} /* class NSCollectionElementKind */
}
