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
	[SupportedOSPlatform ("tvos14.5")]
	[SupportedOSPlatform ("ios14.5")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVPlayerItem_AVPlayerInterstitialSupport  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyHandlesInterstitialEventsX = "automaticallyHandlesInterstitialEvents";
		static readonly NativeHandle selAutomaticallyHandlesInterstitialEventsXHandle = Selector.GetHandle ("automaticallyHandlesInterstitialEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticallyHandlesInterstitialEvents_X = "setAutomaticallyHandlesInterstitialEvents:";
		static readonly NativeHandle selSetAutomaticallyHandlesInterstitialEvents_XHandle = Selector.GetHandle ("setAutomaticallyHandlesInterstitialEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemplatePlayerItemX = "templatePlayerItem";
		static readonly NativeHandle selTemplatePlayerItemXHandle = Selector.GetHandle ("templatePlayerItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayerItem");
		[Export ("automaticallyHandlesInterstitialEvents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAutomaticallyHandlesInterstitialEvents (this AVPlayerItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selAutomaticallyHandlesInterstitialEventsXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[Export ("templatePlayerItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPlayerItem? GetTemplatePlayerItem (this AVPlayerItem This)
		{
			AVPlayerItem ret;
			ret =  Runtime.GetNSObject<AVPlayerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selTemplatePlayerItemXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("setAutomaticallyHandlesInterstitialEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAutomaticallyHandlesInterstitialEvents (this AVPlayerItem This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, selSetAutomaticallyHandlesInterstitialEvents_XHandle, value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	} /* class AVPlayerItem_AVPlayerInterstitialSupport */
}
