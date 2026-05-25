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
namespace ReplayKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NSExtensionContext_RPBroadcastExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSExtensionContext");
		/// <param name="This">The instance on which this method operates.</param><param name="broadcastURL">To be added.</param><param name="broadcastConfiguration">To be added.</param><param name="setupInfo"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. Developers should use 'CompleteRequest(NSUrl,NSDictionary&lt;NSString,INSCoding&gt;)' instead.</summary><remarks>To be added.</remarks>
		[Export ("completeRequestWithBroadcastURL:broadcastConfiguration:setupInfo:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CompleteRequest(NSUrl,NSDictionary<NSString,INSCoding>)' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CompleteRequest(NSUrl,NSDictionary<NSString,INSCoding>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CompleteRequest(NSUrl,NSDictionary<NSString,INSCoding>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CompleteRequest (this NSExtensionContext This, NSUrl broadcastURL, RPBroadcastConfiguration broadcastConfiguration, NSDictionary<NSString, INSCoding>? setupInfo)
		{
			var broadcastURL__handle__ = broadcastURL!.GetNonNullHandle (nameof (broadcastURL));
			var broadcastConfiguration__handle__ = broadcastConfiguration!.GetNonNullHandle (nameof (broadcastConfiguration));
			var setupInfo__handle__ = setupInfo.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("completeRequestWithBroadcastURL:broadcastConfiguration:setupInfo:"), broadcastURL__handle__, broadcastConfiguration__handle__, setupInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastURL);
			GC.KeepAlive (broadcastConfiguration);
			GC.KeepAlive (setupInfo);
		}
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("completeRequestWithBroadcastURL:setupInfo:"), broadcastURL__handle__, setupInfo__handle__);
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadBroadcastingApplicationInfoWithCompletion:"), (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
	} /* class NSExtensionContext_RPBroadcastExtension */
}
