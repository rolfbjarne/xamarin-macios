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
namespace ReplayKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NSExtensionContext_RPBroadcastExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompleteRequestWithBroadcastURL_SetupInfo_X = "completeRequestWithBroadcastURL:setupInfo:";
		static readonly NativeHandle selCompleteRequestWithBroadcastURL_SetupInfo_XHandle = Selector.GetHandle ("completeRequestWithBroadcastURL:setupInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadBroadcastingApplicationInfoWithCompletion_X = "loadBroadcastingApplicationInfoWithCompletion:";
		static readonly NativeHandle selLoadBroadcastingApplicationInfoWithCompletion_XHandle = Selector.GetHandle ("loadBroadcastingApplicationInfoWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSExtensionContext");
		/// <param name="This">The instance on which this method operates.</param><param name="broadcastURL">To be added.</param><param name="setupInfo"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("completeRequestWithBroadcastURL:setupInfo:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CompleteRequest (this NSExtensionContext This, NSUrl broadcastURL, NSDictionary<NSString, INSCoding>? setupInfo)
		{
			var broadcastURL__handle__ = broadcastURL!.GetNonNullHandle (nameof (broadcastURL));
			var setupInfo__handle__ = setupInfo.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selCompleteRequestWithBroadcastURL_SetupInfo_XHandle, broadcastURL__handle__, setupInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastURL);
			GC.KeepAlive (setupInfo);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("loadBroadcastingApplicationInfoWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadBroadcastingApplicationInfo (this NSExtensionContext This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLoadBroadcastingHandler))]LoadBroadcastingHandler handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDLoadBroadcastingHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selLoadBroadcastingApplicationInfoWithCompletion_XHandle, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
	} /* class NSExtensionContext_RPBroadcastExtension */
}
