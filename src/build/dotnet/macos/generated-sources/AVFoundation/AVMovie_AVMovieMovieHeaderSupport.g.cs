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
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVMovie_AVMovieMovieHeaderSupport  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCompatibleWithFileType_X = "isCompatibleWithFileType:";
		static readonly NativeHandle selIsCompatibleWithFileType_XHandle = Selector.GetHandle ("isCompatibleWithFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMovieHeaderWithFileType_Error_X = "movieHeaderWithFileType:error:";
		static readonly NativeHandle selMovieHeaderWithFileType_Error_XHandle = Selector.GetHandle ("movieHeaderWithFileType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteMovieHeaderToURL_FileType_Options_Error_X = "writeMovieHeaderToURL:fileType:options:error:";
		static readonly NativeHandle selWriteMovieHeaderToURL_FileType_Options_Error_XHandle = Selector.GetHandle ("writeMovieHeaderToURL:fileType:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMovie");
		/// <param name="This">The instance on which this method operates.</param><param name="fileType">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("movieHeaderWithFileType:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? GetMovieHeader (this AVMovie This, string fileType, out NSError? outError)
		{
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsfileType = CFString.CreateNative (fileType);
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, selMovieHeaderWithFileType_Error_XHandle, nsfileType, &outErrorValue), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsfileType);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="fileType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isCompatibleWithFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCompatibleWithFileType (this AVMovie This, string fileType)
		{
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			var nsfileType = CFString.CreateNative (fileType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, selIsCompatibleWithFileType_XHandle, nsfileType);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsfileType);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="URL">To be added.</param><param name="fileType">To be added.</param><param name="options">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeMovieHeaderToURL:fileType:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteMovieHeader (this AVMovie This, NSUrl URL, string fileType, AVMovieWritingOptions options, out NSError? outError)
		{
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsfileType = CFString.CreateNative (fileType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (This.Handle, selWriteMovieHeaderToURL_FileType_Options_Error_XHandle, URL__handle__, nsfileType, (UIntPtr) (ulong) options, &outErrorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (URL);
			CFString.ReleaseNative (nsfileType);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
	} /* class AVMovie_AVMovieMovieHeaderSupport */
}
