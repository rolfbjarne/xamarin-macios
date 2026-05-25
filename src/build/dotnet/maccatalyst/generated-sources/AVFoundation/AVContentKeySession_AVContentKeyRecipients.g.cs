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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVContentKeySession_AVContentKeyRecipients  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVContentKeySession");
		/// <param name="This">The instance on which this method operates.</param><param name="recipient">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addContentKeyRecipient:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Add (this AVContentKeySession This, IAVContentKeyRecipient recipient)
		{
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addContentKeyRecipient:"), recipient__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recipient);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("contentKeyRecipients")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IAVContentKeyRecipient[] GetContentKeyRecipients (this AVContentKeySession This)
		{
			IAVContentKeyRecipient[] ret;
			ret = CFArray.ArrayFromHandle<IAVContentKeyRecipient>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentKeyRecipients")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="recipient">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeContentKeyRecipient:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Remove (this AVContentKeySession This, IAVContentKeyRecipient recipient)
		{
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeContentKeyRecipient:"), recipient__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recipient);
		}
	} /* class AVContentKeySession_AVContentKeyRecipients */
}
