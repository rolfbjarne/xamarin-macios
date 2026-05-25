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
namespace UserNotificationsUI {
	/// <summary>Content extension for presenting notification UI, including UI for playable content.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSExtensionContext_UNNotificationContentExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDismissNotificationContentExtensionX = "dismissNotificationContentExtension";
		static readonly NativeHandle selDismissNotificationContentExtensionXHandle = Selector.GetHandle ("dismissNotificationContentExtension");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaPlayingPausedX = "mediaPlayingPaused";
		static readonly NativeHandle selMediaPlayingPausedXHandle = Selector.GetHandle ("mediaPlayingPaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaPlayingStartedX = "mediaPlayingStarted";
		static readonly NativeHandle selMediaPlayingStartedXHandle = Selector.GetHandle ("mediaPlayingStarted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotificationActionsX = "notificationActions";
		static readonly NativeHandle selNotificationActionsXHandle = Selector.GetHandle ("notificationActions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformNotificationDefaultActionX = "performNotificationDefaultAction";
		static readonly NativeHandle selPerformNotificationDefaultActionXHandle = Selector.GetHandle ("performNotificationDefaultAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNotificationActions_X = "setNotificationActions:";
		static readonly NativeHandle selSetNotificationActions_XHandle = Selector.GetHandle ("setNotificationActions:");
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
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selDismissNotificationContentExtensionXHandle);
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
			ret = CFArray.ArrayFromHandle<global::UserNotifications.UNNotificationAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selNotificationActionsXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Method that is called when the user pauses playable notification content.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("mediaPlayingPaused")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MediaPlayingPaused (this NSExtensionContext This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selMediaPlayingPausedXHandle);
			GC.KeepAlive (This);
		}
		/// <summary>Method that is called when the user starts playable notification content.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("mediaPlayingStarted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MediaPlayingStarted (this NSExtensionContext This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selMediaPlayingStartedXHandle);
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
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selPerformNotificationDefaultActionXHandle);
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSetNotificationActions_XHandle, nsa_actions.Handle);
			GC.KeepAlive (This);
		}
	} /* class NSExtensionContext_UNNotificationContentExtension */
}
