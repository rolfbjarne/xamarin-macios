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
namespace UIKit {
	/// <summary>Provides the constants for <see cref="M:UIKit.UIViewControllerContextTransitioning.GetViewControllerForKey(Foundation.NSString)" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UITransitionContext  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FromViewControllerKey;
		/// <summary>Represents the value associated with the constant UITransitionContextFromViewControllerKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITransitionContextFromViewControllerKey",  "UIKit")]
		public static NSString FromViewControllerKey {
			get {
				if (_FromViewControllerKey is null)
					_FromViewControllerKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITransitionContextFromViewControllerKey")!;
				return _FromViewControllerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FromViewKey;
		/// <summary>Represents the value associated with the constant UITransitionContextFromViewKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITransitionContextFromViewKey",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FromViewKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FromViewKey is null)
					_FromViewKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITransitionContextFromViewKey")!;
				return _FromViewKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToViewControllerKey;
		/// <summary>Represents the value associated with the constant UITransitionContextToViewControllerKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITransitionContextToViewControllerKey",  "UIKit")]
		public static NSString ToViewControllerKey {
			get {
				if (_ToViewControllerKey is null)
					_ToViewControllerKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITransitionContextToViewControllerKey")!;
				return _ToViewControllerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToViewKey;
		/// <summary>Represents the value associated with the constant UITransitionContextToViewKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITransitionContextToViewKey",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ToViewKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ToViewKey is null)
					_ToViewKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITransitionContextToViewKey")!;
				return _ToViewKey;
			}
		}
	} /* class UITransitionContext */
}
