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
namespace CoreVideo {
	public unsafe partial class CVPixelFormatComponentRangeKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FullRange;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatComponentRange_FullRange'.</summary>
		[Field ("kCVPixelFormatComponentRange_FullRange",  "CoreVideo")]
		public static NSString FullRange {
			get {
				if (_FullRange is null)
					_FullRange = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange_FullRange")!;
				return _FullRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VideoRange;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatComponentRange_VideoRange'.</summary>
		[Field ("kCVPixelFormatComponentRange_VideoRange",  "CoreVideo")]
		public static NSString VideoRange {
			get {
				if (_VideoRange is null)
					_VideoRange = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange_VideoRange")!;
				return _VideoRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WideRange;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatComponentRange_WideRange'.</summary>
		[Field ("kCVPixelFormatComponentRange_WideRange",  "CoreVideo")]
		public static NSString WideRange {
			get {
				if (_WideRange is null)
					_WideRange = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange_WideRange")!;
				return _WideRange;
			}
		}
	} /* class CVPixelFormatComponentRangeKeys */
}
