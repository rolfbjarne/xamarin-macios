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
	public unsafe static partial class NSApplication_NSServicesMenu  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterServicesMenuSendTypes_ReturnTypes_X = "registerServicesMenuSendTypes:returnTypes:";
		static readonly NativeHandle selRegisterServicesMenuSendTypes_ReturnTypes_XHandle = Selector.GetHandle ("registerServicesMenuSendTypes:returnTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSApplication");
		[Export ("registerServicesMenuSendTypes:returnTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterServicesMenu (this NSApplication This, string[] sendTypes, string[] returnTypes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (sendTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sendTypes));
			if (returnTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (returnTypes));
			using var nsa_sendTypes = NSArray.FromStrings (sendTypes);
			using var nsa_returnTypes = NSArray.FromStrings (returnTypes);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selRegisterServicesMenuSendTypes_ReturnTypes_XHandle, nsa_sendTypes.Handle, nsa_returnTypes.Handle);
			GC.KeepAlive (This);
		}
	} /* class NSApplication_NSServicesMenu */
}
