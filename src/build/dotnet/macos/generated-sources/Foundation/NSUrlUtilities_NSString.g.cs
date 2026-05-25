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
	/// <summary>Defines static methods for URL encoding and escaping.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSUrlUtilities_NSString  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAddingPercentEncodingWithAllowedCharacters_X = "stringByAddingPercentEncodingWithAllowedCharacters:";
		static readonly NativeHandle selStringByAddingPercentEncodingWithAllowedCharacters_XHandle = Selector.GetHandle ("stringByAddingPercentEncodingWithAllowedCharacters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAddingPercentEscapesUsingEncoding_X = "stringByAddingPercentEscapesUsingEncoding:";
		static readonly NativeHandle selStringByAddingPercentEscapesUsingEncoding_XHandle = Selector.GetHandle ("stringByAddingPercentEscapesUsingEncoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByRemovingPercentEncodingX = "stringByRemovingPercentEncoding";
		static readonly NativeHandle selStringByRemovingPercentEncodingXHandle = Selector.GetHandle ("stringByRemovingPercentEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByReplacingPercentEscapesUsingEncoding_X = "stringByReplacingPercentEscapesUsingEncoding:";
		static readonly NativeHandle selStringByReplacingPercentEscapesUsingEncoding_XHandle = Selector.GetHandle ("stringByReplacingPercentEscapesUsingEncoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <param name="This">The instance on which this method operates.</param><param name="allowedCharacters">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stringByAddingPercentEncodingWithAllowedCharacters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString CreateStringByAddingPercentEncoding (this NSString This, NSCharacterSet allowedCharacters)
		{
			var allowedCharacters__handle__ = allowedCharacters!.GetNonNullHandle (nameof (allowedCharacters));
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selStringByAddingPercentEncodingWithAllowedCharacters_XHandle, allowedCharacters__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (allowedCharacters);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stringByAddingPercentEscapesUsingEncoding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString CreateStringByAddingPercentEscapes (this NSString This, NSStringEncoding enc)
		{
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, selStringByAddingPercentEscapesUsingEncoding_XHandle, (UIntPtr) (ulong) enc), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("stringByRemovingPercentEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString CreateStringByRemovingPercentEncoding (this NSString This)
		{
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selStringByRemovingPercentEncodingXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stringByReplacingPercentEscapesUsingEncoding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString CreateStringByReplacingPercentEscapes (this NSString This, NSStringEncoding enc)
		{
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, selStringByReplacingPercentEscapesUsingEncoding_XHandle, (UIntPtr) (ulong) enc), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class NSUrlUtilities_NSString */
}
