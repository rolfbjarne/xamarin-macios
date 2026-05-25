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
	public unsafe static partial class NSAccessibilityNotificationUserInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnouncementKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAnnouncementKey",  "AppKit")]
		public static NSString AnnouncementKey {
			get {
				if (_AnnouncementKey is null)
					_AnnouncementKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnnouncementKey")!;
				return _AnnouncementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PriorityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPriorityKey",  "AppKit")]
		public static NSString PriorityKey {
			get {
				if (_PriorityKey is null)
					_PriorityKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPriorityKey")!;
				return _PriorityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIElementsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityUIElementsKey",  "AppKit")]
		public static NSString UIElementsKey {
			get {
				if (_UIElementsKey is null)
					_UIElementsKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUIElementsKey")!;
				return _UIElementsKey;
			}
		}
	} /* class NSAccessibilityNotificationUserInfoKeys */
}
