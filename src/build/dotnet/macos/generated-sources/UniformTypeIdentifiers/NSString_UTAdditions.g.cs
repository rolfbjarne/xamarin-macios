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
namespace UniformTypeIdentifiers {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSString_UTAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAppendingPathComponent_ConformingToType_X = "stringByAppendingPathComponent:conformingToType:";
		static readonly NativeHandle selStringByAppendingPathComponent_ConformingToType_XHandle = Selector.GetHandle ("stringByAppendingPathComponent:conformingToType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAppendingPathExtensionForType_X = "stringByAppendingPathExtensionForType:";
		static readonly NativeHandle selStringByAppendingPathExtensionForType_XHandle = Selector.GetHandle ("stringByAppendingPathExtensionForType:");
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
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selStringByAppendingPathComponent_ConformingToType_XHandle, nspartialName, contentType__handle__), false)!;
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
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selStringByAppendingPathExtensionForType_XHandle, contentType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (contentType);
			return ret!;
		}
	} /* class NSString_UTAdditions */
}
