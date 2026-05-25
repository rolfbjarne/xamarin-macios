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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVContentKeySession_AVContentKeyRecipients  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddContentKeyRecipient_X = "addContentKeyRecipient:";
		static readonly NativeHandle selAddContentKeyRecipient_XHandle = Selector.GetHandle ("addContentKeyRecipient:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentKeyRecipientsX = "contentKeyRecipients";
		static readonly NativeHandle selContentKeyRecipientsXHandle = Selector.GetHandle ("contentKeyRecipients");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveContentKeyRecipient_X = "removeContentKeyRecipient:";
		static readonly NativeHandle selRemoveContentKeyRecipient_XHandle = Selector.GetHandle ("removeContentKeyRecipient:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVContentKeySession");
		/// <param name="This">The instance on which this method operates.</param><param name="recipient">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addContentKeyRecipient:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Add (this AVContentKeySession This, IAVContentKeyRecipient recipient)
		{
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selAddContentKeyRecipient_XHandle, recipient__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recipient);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("contentKeyRecipients")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IAVContentKeyRecipient[] GetContentKeyRecipients (this AVContentKeySession This)
		{
			IAVContentKeyRecipient[] ret;
			ret = CFArray.ArrayFromHandle<IAVContentKeyRecipient>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selContentKeyRecipientsXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="recipient">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeContentKeyRecipient:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Remove (this AVContentKeySession This, IAVContentKeyRecipient recipient)
		{
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selRemoveContentKeyRecipient_XHandle, recipient__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recipient);
		}
	} /* class AVContentKeySession_AVContentKeyRecipients */
}
