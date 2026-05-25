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
namespace ImageCaptureCore {
	public unsafe static partial class ICStatusNotificationKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodeKey;
		/// <summary>Represents the value associated with the constant 'ICStatusCodeKey'.</summary>
		[Field ("ICStatusCodeKey",  "ImageCaptureCore")]
		public static NSString CodeKey {
			get {
				if (_CodeKey is null)
					_CodeKey = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICStatusCodeKey")!;
				return _CodeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedNotificationKey;
		/// <summary>Represents the value associated with the constant 'ICLocalizedStatusNotificationKey'.</summary>
		[Field ("ICLocalizedStatusNotificationKey",  "ImageCaptureCore")]
		public static NSString LocalizedNotificationKey {
			get {
				if (_LocalizedNotificationKey is null)
					_LocalizedNotificationKey = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICLocalizedStatusNotificationKey")!;
				return _LocalizedNotificationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotificationKey;
		/// <summary>Represents the value associated with the constant 'ICStatusNotificationKey'.</summary>
		[Field ("ICStatusNotificationKey",  "ImageCaptureCore")]
		public static NSString NotificationKey {
			get {
				if (_NotificationKey is null)
					_NotificationKey = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICStatusNotificationKey")!;
				return _NotificationKey;
			}
		}
	} /* class ICStatusNotificationKeys */
}
