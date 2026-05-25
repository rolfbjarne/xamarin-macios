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
namespace CoreSpotlight {
	/// <summary>Extension methods for <see cref="T:CoreSpotlight.CSSearchableIndex" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class CSSearchableIndex_CSOptionalBatchingExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginIndexBatchX = "beginIndexBatch";
		static readonly NativeHandle selBeginIndexBatchXHandle = Selector.GetHandle ("beginIndexBatch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndIndexBatchWithClientState_CompletionHandler_X = "endIndexBatchWithClientState:completionHandler:";
		static readonly NativeHandle selEndIndexBatchWithClientState_CompletionHandler_XHandle = Selector.GetHandle ("endIndexBatchWithClientState:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndIndexBatchWithExpectedClientState_NewClientState_CompletionHandler_X = "endIndexBatchWithExpectedClientState:newClientState:completionHandler:";
		static readonly NativeHandle selEndIndexBatchWithExpectedClientState_NewClientState_CompletionHandler_XHandle = Selector.GetHandle ("endIndexBatchWithExpectedClientState:newClientState:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchLastClientStateWithCompletionHandler_X = "fetchLastClientStateWithCompletionHandler:";
		static readonly NativeHandle selFetchLastClientStateWithCompletionHandler_XHandle = Selector.GetHandle ("fetchLastClientStateWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CSSearchableIndex");
		/// <summary>Begins an index update batch.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("beginIndexBatch")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginIndexBatch (this CSSearchableIndex This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selBeginIndexBatchXHandle);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="clientState">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Ends an index update batch, relying on the 250 bytes of information for crash recovery, and calls <paramref name="completionHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("endIndexBatchWithClientState:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EndIndexBatch (this CSSearchableIndex This, NSData clientState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var clientState__handle__ = clientState!.GetNonNullHandle (nameof (clientState));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selEndIndexBatchWithClientState_CompletionHandler_XHandle, clientState__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (clientState);
		}
		[Export ("endIndexBatchWithExpectedClientState:newClientState:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EndIndexBatch (this CSSearchableIndex This, NSData? expectedClientState, NSData newClientState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexEndIndexHandler))]CSSearchableIndexEndIndexHandler? completionHandler)
		{
			var expectedClientState__handle__ = expectedClientState.GetHandle ();
			var newClientState__handle__ = newClientState!.GetNonNullHandle (nameof (newClientState));
			using var block_completionHandler = Trampolines.SDCSSearchableIndexEndIndexHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selEndIndexBatchWithExpectedClientState_NewClientState_CompletionHandler_XHandle, expectedClientState__handle__, newClientState__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (expectedClientState);
			GC.KeepAlive (newClientState);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="completionHandler">To be added.</param><summary>Fetches the client state and runs <paramref name="completionHandler" /> when finished..</summary><remarks>To be added.</remarks>
		[Export ("fetchLastClientStateWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void FetchLastClientState (this CSSearchableIndex This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexFetchHandler))]CSSearchableIndexFetchHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCSSearchableIndexFetchHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selFetchLastClientStateWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
	} /* class CSSearchableIndex_CSOptionalBatchingExtension */
}
