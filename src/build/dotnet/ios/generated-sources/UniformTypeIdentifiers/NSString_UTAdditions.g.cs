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
namespace UniformTypeIdentifiers {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSString_UTAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		[Export ("stringByAppendingPathComponent:conformingToType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString AppendPathComponent (this NSString This, string partialName, UTType contentType)
		{
			if (partialName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (partialName));
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			var nspartialName = CFString.CreateNative (partialName);
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("stringByAppendingPathComponent:conformingToType:"), nspartialName, contentType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (contentType);
			CFString.ReleaseNative (nspartialName);
			return ret!;
		}
		[Export ("stringByAppendingPathExtensionForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString AppendPathExtension (this NSString This, UTType contentType)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stringByAppendingPathExtensionForType:"), contentType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (contentType);
			return ret!;
		}
	} /* class NSString_UTAdditions */
}
