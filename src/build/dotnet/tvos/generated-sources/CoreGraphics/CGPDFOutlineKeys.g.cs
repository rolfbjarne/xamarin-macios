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
namespace CoreGraphics {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CGPDFOutlineKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AccessPermissionsKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFContextAccessPermissions'.</summary>
		[Field ("kCGPDFContextAccessPermissions",  "CoreGraphics")]
		internal static NSString AccessPermissionsKey {
			get {
				if (_AccessPermissionsKey is null)
					_AccessPermissionsKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFContextAccessPermissions")!;
				return _AccessPermissionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationRectKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFOutlineDestinationRect'.</summary>
		[Field ("kCGPDFOutlineDestinationRect",  "CoreGraphics")]
		internal static NSString DestinationRectKey {
			get {
				if (_DestinationRectKey is null)
					_DestinationRectKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFOutlineDestinationRect")!;
				return _DestinationRectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutlineChildrenKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFOutlineChildren'.</summary>
		[Field ("kCGPDFOutlineChildren",  "CoreGraphics")]
		internal static NSString OutlineChildrenKey {
			get {
				if (_OutlineChildrenKey is null)
					_OutlineChildrenKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFOutlineChildren")!;
				return _OutlineChildrenKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutlineDestinationKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFOutlineDestination'.</summary>
		[Field ("kCGPDFOutlineDestination",  "CoreGraphics")]
		internal static NSString OutlineDestinationKey {
			get {
				if (_OutlineDestinationKey is null)
					_OutlineDestinationKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFOutlineDestination")!;
				return _OutlineDestinationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutlineTitleKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFOutlineTitle'.</summary>
		[Field ("kCGPDFOutlineTitle",  "CoreGraphics")]
		internal static NSString OutlineTitleKey {
			get {
				if (_OutlineTitleKey is null)
					_OutlineTitleKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFOutlineTitle")!;
				return _OutlineTitleKey;
			}
		}
	} /* class CGPDFOutlineKeys */
}
