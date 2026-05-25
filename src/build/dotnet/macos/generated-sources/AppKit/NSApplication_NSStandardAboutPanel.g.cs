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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSApplication_NSStandardAboutPanel  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontStandardAboutPanel_X = "orderFrontStandardAboutPanel:";
		static readonly NativeHandle selOrderFrontStandardAboutPanel_XHandle = Selector.GetHandle ("orderFrontStandardAboutPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontStandardAboutPanelWithOptions_X = "orderFrontStandardAboutPanelWithOptions:";
		static readonly NativeHandle selOrderFrontStandardAboutPanelWithOptions_XHandle = Selector.GetHandle ("orderFrontStandardAboutPanelWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSApplication");
		[Export ("orderFrontStandardAboutPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OrderFrontStandardAboutPanel (this NSApplication This, NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selOrderFrontStandardAboutPanel_XHandle, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontStandardAboutPanelWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OrderFrontStandardAboutPanelWithOptions (this NSApplication This, NSDictionary optionsDictionary)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var optionsDictionary__handle__ = optionsDictionary!.GetNonNullHandle (nameof (optionsDictionary));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selOrderFrontStandardAboutPanelWithOptions_XHandle, optionsDictionary__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (optionsDictionary);
		}
	} /* class NSApplication_NSStandardAboutPanel */
}
