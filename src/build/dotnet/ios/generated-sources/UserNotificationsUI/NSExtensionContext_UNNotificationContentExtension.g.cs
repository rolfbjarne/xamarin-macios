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
namespace UserNotificationsUI {
	/// <summary>Content extension for presenting notification UI, including UI for playable content.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSExtensionContext_UNNotificationContentExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSExtensionContext");
		/// <summary>To be added.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("dismissNotificationContentExtension")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DismissNotificationContentExtension (this NSExtensionContext This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dismissNotificationContentExtension"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("notificationActions")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UserNotifications.UNNotificationAction[] GetNotificationActions (this NSExtensionContext This)
		{
			global::UserNotifications.UNNotificationAction[] ret;
			ret = CFArray.ArrayFromHandle<global::UserNotifications.UNNotificationAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("notificationActions")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Method that is called when the user pauses playable notification content.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("mediaPlayingPaused")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MediaPlayingPaused (this NSExtensionContext This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayingPaused"));
			GC.KeepAlive (This);
		}
		/// <summary>Method that is called when the user starts playable notification content.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("mediaPlayingStarted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MediaPlayingStarted (this NSExtensionContext This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayingStarted"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("performNotificationDefaultAction")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformNotificationDefaultAction (this NSExtensionContext This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("performNotificationDefaultAction"));
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="actions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setNotificationActions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNotificationActions (this NSExtensionContext This, global::UserNotifications.UNNotificationAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setNotificationActions:"), nsa_actions.Handle);
			GC.KeepAlive (This);
		}
	} /* class NSExtensionContext_UNNotificationContentExtension */
}
