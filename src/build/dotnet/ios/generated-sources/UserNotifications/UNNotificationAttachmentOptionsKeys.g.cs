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
namespace UserNotifications {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class UNNotificationAttachmentOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailClippingRect;
		/// <summary>Represents the value associated with the constant 'UNNotificationAttachmentOptionsThumbnailClippingRectKey'.</summary>
		[Field ("UNNotificationAttachmentOptionsThumbnailClippingRectKey",  "UserNotifications")]
		public static NSString ThumbnailClippingRect {
			get {
				if (_ThumbnailClippingRect is null)
					_ThumbnailClippingRect = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsThumbnailClippingRectKey")!;
				return _ThumbnailClippingRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailHidden;
		/// <summary>Represents the value associated with the constant 'UNNotificationAttachmentOptionsThumbnailHiddenKey'.</summary>
		[Field ("UNNotificationAttachmentOptionsThumbnailHiddenKey",  "UserNotifications")]
		public static NSString ThumbnailHidden {
			get {
				if (_ThumbnailHidden is null)
					_ThumbnailHidden = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsThumbnailHiddenKey")!;
				return _ThumbnailHidden;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailTime;
		/// <summary>Represents the value associated with the constant 'UNNotificationAttachmentOptionsThumbnailTimeKey'.</summary>
		[Field ("UNNotificationAttachmentOptionsThumbnailTimeKey",  "UserNotifications")]
		public static NSString ThumbnailTime {
			get {
				if (_ThumbnailTime is null)
					_ThumbnailTime = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsThumbnailTimeKey")!;
				return _ThumbnailTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeHint;
		/// <summary>Represents the value associated with the constant 'UNNotificationAttachmentOptionsTypeHintKey'.</summary>
		[Field ("UNNotificationAttachmentOptionsTypeHintKey",  "UserNotifications")]
		public static NSString TypeHint {
			get {
				if (_TypeHint is null)
					_TypeHint = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsTypeHintKey")!;
				return _TypeHint;
			}
		}
	} /* class UNNotificationAttachmentOptionsKeys */
}
