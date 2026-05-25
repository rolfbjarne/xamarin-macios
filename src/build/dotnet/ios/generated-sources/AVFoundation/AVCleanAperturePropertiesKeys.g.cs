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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class AVCleanAperturePropertiesKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeightKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCleanApertureHeightKey'.</summary>
		[Field ("AVVideoCleanApertureHeightKey",  "AVFoundation")]
		public static NSString HeightKey {
			get {
				if (_HeightKey is null)
					_HeightKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureHeightKey")!;
				return _HeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalOffsetKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCleanApertureHorizontalOffsetKey'.</summary>
		[Field ("AVVideoCleanApertureHorizontalOffsetKey",  "AVFoundation")]
		public static NSString HorizontalOffsetKey {
			get {
				if (_HorizontalOffsetKey is null)
					_HorizontalOffsetKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureHorizontalOffsetKey")!;
				return _HorizontalOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalOffsetKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCleanApertureVerticalOffsetKey'.</summary>
		[Field ("AVVideoCleanApertureVerticalOffsetKey",  "AVFoundation")]
		public static NSString VerticalOffsetKey {
			get {
				if (_VerticalOffsetKey is null)
					_VerticalOffsetKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureVerticalOffsetKey")!;
				return _VerticalOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCleanApertureWidthKey'.</summary>
		[Field ("AVVideoCleanApertureWidthKey",  "AVFoundation")]
		public static NSString WidthKey {
			get {
				if (_WidthKey is null)
					_WidthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureWidthKey")!;
				return _WidthKey;
			}
		}
	} /* class AVCleanAperturePropertiesKeys */
}
