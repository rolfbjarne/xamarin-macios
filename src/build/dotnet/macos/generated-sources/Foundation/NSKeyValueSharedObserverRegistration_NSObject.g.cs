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
namespace Foundation {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class NSKeyValueSharedObserverRegistration_NSObject  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSharedObservers_X = "setSharedObservers:";
		static readonly NativeHandle selSetSharedObservers_XHandle = Selector.GetHandle ("setSharedObservers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		[Export ("setSharedObservers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSharedObservers (this NSObject This, NSKeyValueSharedObserversSnapshot? sharedObservers)
		{
			var sharedObservers__handle__ = sharedObservers.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSetSharedObservers_XHandle, sharedObservers__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharedObservers);
		}
	} /* class NSKeyValueSharedObserverRegistration_NSObject */
}
