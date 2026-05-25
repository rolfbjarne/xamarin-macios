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
	public unsafe static partial class NSFileManager_NSUserInformation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHomeDirectoryForCurrentUserX = "homeDirectoryForCurrentUser";
		static readonly NativeHandle selHomeDirectoryForCurrentUserXHandle = Selector.GetHandle ("homeDirectoryForCurrentUser");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHomeDirectoryForUser_X = "homeDirectoryForUser:";
		static readonly NativeHandle selHomeDirectoryForUser_XHandle = Selector.GetHandle ("homeDirectoryForUser:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryDirectoryX = "temporaryDirectory";
		static readonly NativeHandle selTemporaryDirectoryXHandle = Selector.GetHandle ("temporaryDirectory");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileManager");
		/// <param name="This">The instance on which this method operates.</param><param name="userName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("homeDirectoryForUser:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? GetHomeDirectory (this NSFileManager This, string userName)
		{
			if (userName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userName));
			var nsuserName = CFString.CreateNative (userName);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selHomeDirectoryForUser_XHandle, nsuserName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsuserName);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("homeDirectoryForCurrentUser")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl GetHomeDirectoryForCurrentUser (this NSFileManager This)
		{
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selHomeDirectoryForCurrentUserXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("temporaryDirectory")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl GetTemporaryDirectory (this NSFileManager This)
		{
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selTemporaryDirectoryXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class NSFileManager_NSUserInformation */
}
