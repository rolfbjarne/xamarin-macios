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
namespace UIKit {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	internal unsafe static partial class UITextAttributesConstants  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Font;
		/// <summary>Represents the value associated with the constant 'UITextAttributeFont'.</summary>
		[Field ("UITextAttributeFont",  "UIKit")]
		public static NSString Font {
			get {
				if (_Font is null)
					_Font = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextAttributeFont")!;
				return _Font;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextColor;
		/// <summary>Represents the value associated with the constant 'UITextAttributeTextColor'.</summary>
		[Field ("UITextAttributeTextColor",  "UIKit")]
		public static NSString TextColor {
			get {
				if (_TextColor is null)
					_TextColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextAttributeTextColor")!;
				return _TextColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextShadowColor;
		/// <summary>Represents the value associated with the constant 'UITextAttributeTextShadowColor'.</summary>
		[Field ("UITextAttributeTextShadowColor",  "UIKit")]
		public static NSString TextShadowColor {
			get {
				if (_TextShadowColor is null)
					_TextShadowColor = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextAttributeTextShadowColor")!;
				return _TextShadowColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextShadowOffset;
		/// <summary>Represents the value associated with the constant 'UITextAttributeTextShadowOffset'.</summary>
		[Field ("UITextAttributeTextShadowOffset",  "UIKit")]
		public static NSString TextShadowOffset {
			get {
				if (_TextShadowOffset is null)
					_TextShadowOffset = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextAttributeTextShadowOffset")!;
				return _TextShadowOffset;
			}
		}
	} /* class UITextAttributesConstants */
}
