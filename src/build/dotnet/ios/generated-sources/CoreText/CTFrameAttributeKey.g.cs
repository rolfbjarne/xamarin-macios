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
namespace CoreText {
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTFrameAttributes" />.</summary>
	public unsafe static partial class CTFrameAttributeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClippingPaths;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFrameClippingPathsAttributeName",  "CoreText")]
		public static NSString ClippingPaths {
			get {
				if (_ClippingPaths is null)
					_ClippingPaths = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFrameClippingPathsAttributeName")!;
				return _ClippingPaths;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathClippingPath;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFramePathClippingPathAttributeName",  "CoreText")]
		public static NSString PathClippingPath {
			get {
				if (_PathClippingPath is null)
					_PathClippingPath = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFramePathClippingPathAttributeName")!;
				return _PathClippingPath;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathFillRule;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFramePathFillRuleAttributeName",  "CoreText")]
		public static NSString PathFillRule {
			get {
				if (_PathFillRule is null)
					_PathFillRule = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFramePathFillRuleAttributeName")!;
				return _PathFillRule;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathWidth;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFramePathWidthAttributeName",  "CoreText")]
		public static NSString PathWidth {
			get {
				if (_PathWidth is null)
					_PathWidth = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFramePathWidthAttributeName")!;
				return _PathWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Progression;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFrameProgressionAttributeName",  "CoreText")]
		public static NSString Progression {
			get {
				if (_Progression is null)
					_Progression = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFrameProgressionAttributeName")!;
				return _Progression;
			}
		}
	} /* class CTFrameAttributeKey */
}
