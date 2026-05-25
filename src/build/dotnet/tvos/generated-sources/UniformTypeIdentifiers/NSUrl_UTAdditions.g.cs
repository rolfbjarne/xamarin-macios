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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UniformTypeIdentifiers {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSUrl_UTAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSURL");
		[Export ("URLByAppendingPathComponent:conformingToType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl AppendPathComponent (this NSUrl This, string partialName, UTType contentType)
		{
			if (partialName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (partialName));
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			var nspartialName = CFString.CreateNative (partialName);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLByAppendingPathComponent:conformingToType:"), nspartialName, contentType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (contentType);
			CFString.ReleaseNative (nspartialName);
			return ret!;
		}
		[Export ("URLByAppendingPathExtensionForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl AppendPathExtension (this NSUrl This, UTType contentType)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("URLByAppendingPathExtensionForType:"), contentType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (contentType);
			return ret!;
		}
	} /* class NSUrl_UTAdditions */
}
