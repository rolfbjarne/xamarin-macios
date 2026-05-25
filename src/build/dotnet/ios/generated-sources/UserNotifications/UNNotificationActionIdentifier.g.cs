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
	internal unsafe static partial class UNNotificationActionIdentifier  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Default;
		/// <summary>Represents the value associated with the constant 'UNNotificationDefaultActionIdentifier'.</summary>
		[Field ("UNNotificationDefaultActionIdentifier",  "UserNotifications")]
		public static NSString Default {
			get {
				if (_Default is null)
					_Default = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNNotificationDefaultActionIdentifier")!;
				return _Default;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dismiss;
		/// <summary>Represents the value associated with the constant 'UNNotificationDismissActionIdentifier'.</summary>
		[Field ("UNNotificationDismissActionIdentifier",  "UserNotifications")]
		public static NSString Dismiss {
			get {
				if (_Dismiss is null)
					_Dismiss = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNNotificationDismissActionIdentifier")!;
				return _Dismiss;
			}
		}
	} /* class UNNotificationActionIdentifier */
}
