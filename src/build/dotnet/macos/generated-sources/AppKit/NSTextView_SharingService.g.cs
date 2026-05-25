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
	public unsafe static partial class NSTextView_SharingService  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontSharingServicePicker_X = "orderFrontSharingServicePicker:";
		static readonly NativeHandle selOrderFrontSharingServicePicker_XHandle = Selector.GetHandle ("orderFrontSharingServicePicker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextView");
		/// <param name="This">The instance on which this method operates.</param><param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("orderFrontSharingServicePicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OrderFrontSharingServicePicker (this NSTextView This, NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selOrderFrontSharingServicePicker_XHandle, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
	} /* class NSTextView_SharingService */
}
