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
namespace FileProvider {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public unsafe static partial class NSFileProviderManager_KnownFolders  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClaimKnownFolders_LocalizedReason_CompletionHandler_X = "claimKnownFolders:localizedReason:completionHandler:";
		static readonly NativeHandle selClaimKnownFolders_LocalizedReason_CompletionHandler_XHandle = Selector.GetHandle ("claimKnownFolders:localizedReason:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseKnownFolders_LocalizedReason_CompletionHandler_X = "releaseKnownFolders:localizedReason:completionHandler:";
		static readonly NativeHandle selReleaseKnownFolders_LocalizedReason_CompletionHandler_XHandle = Selector.GetHandle ("releaseKnownFolders:localizedReason:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileProviderManager");
		[Export ("claimKnownFolders:localizedReason:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ClaimKnownFolders (this NSFileProviderManager This, NSFileProviderKnownFolderLocations knownFolders, string localizedReason, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderManagerKnownFoldersCallback))]NSFileProviderManagerKnownFoldersCallback completionHandler)
		{
			var knownFolders__handle__ = knownFolders!.GetNonNullHandle (nameof (knownFolders));
			if (localizedReason is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedReason));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nslocalizedReason = CFString.CreateNative (localizedReason);
			using var block_completionHandler = Trampolines.SDNSFileProviderManagerKnownFoldersCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selClaimKnownFolders_LocalizedReason_CompletionHandler_XHandle, knownFolders__handle__, nslocalizedReason, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (knownFolders);
			CFString.ReleaseNative (nslocalizedReason);
		}
		[Export ("releaseKnownFolders:localizedReason:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ReleaseKnownFolders (this NSFileProviderManager This, NSFileProviderKnownFolderLocations knownFolders, string localizedReason, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderManagerKnownFoldersCallback))]NSFileProviderManagerKnownFoldersCallback completionHandler)
		{
			var knownFolders__handle__ = knownFolders!.GetNonNullHandle (nameof (knownFolders));
			if (localizedReason is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedReason));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nslocalizedReason = CFString.CreateNative (localizedReason);
			using var block_completionHandler = Trampolines.SDNSFileProviderManagerKnownFoldersCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReleaseKnownFolders_LocalizedReason_CompletionHandler_XHandle, knownFolders__handle__, nslocalizedReason, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (knownFolders);
			CFString.ReleaseNative (nslocalizedReason);
		}
	} /* class NSFileProviderManager_KnownFolders */
}
