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
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.4")]
	public unsafe static partial class NSFileProviderManager_Diagnostics  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestDiagnosticCollectionForItemWithIdentifier_ErrorReason_CompletionHandler_X = "requestDiagnosticCollectionForItemWithIdentifier:errorReason:completionHandler:";
		static readonly NativeHandle selRequestDiagnosticCollectionForItemWithIdentifier_ErrorReason_CompletionHandler_XHandle = Selector.GetHandle ("requestDiagnosticCollectionForItemWithIdentifier:errorReason:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileProviderManager");
		[Export ("requestDiagnosticCollectionForItemWithIdentifier:errorReason:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestDiagnosticCollection (this NSFileProviderManager This, string itemIdentifier, NSError errorReason, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderManagerRequestDiagnosticCollectionCallback))]NSFileProviderManagerRequestDiagnosticCollectionCallback completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var errorReason__handle__ = errorReason!.GetNonNullHandle (nameof (errorReason));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderManagerRequestDiagnosticCollectionCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selRequestDiagnosticCollectionForItemWithIdentifier_ErrorReason_CompletionHandler_XHandle, nsitemIdentifier, errorReason__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (errorReason);
			CFString.ReleaseNative (nsitemIdentifier);
		}
	} /* class NSFileProviderManager_Diagnostics */
}
