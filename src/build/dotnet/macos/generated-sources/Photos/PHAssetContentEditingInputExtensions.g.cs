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
namespace Photos {
	/// <summary>Extension methods for <see cref="T:Photos.PHAsset" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class PHAssetContentEditingInputExtensions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelContentEditingInputRequest_X = "cancelContentEditingInputRequest:";
		static readonly NativeHandle selCancelContentEditingInputRequest_XHandle = Selector.GetHandle ("cancelContentEditingInputRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestContentEditingInputWithOptions_CompletionHandler_X = "requestContentEditingInputWithOptions:completionHandler:";
		static readonly NativeHandle selRequestContentEditingInputWithOptions_CompletionHandler_XHandle = Selector.GetHandle ("requestContentEditingInputWithOptions:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHAsset");
		/// <param name="This">The instance on which this method operates.</param><param name="requestID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cancelContentEditingInputRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelContentEditingInputRequest (this PHAsset This, nuint requestID)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, selCancelContentEditingInputRequest_XHandle, requestID);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("requestContentEditingInputWithOptions:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static nuint RequestContentEditingInput (this PHAsset This, PHContentEditingInputRequestOptions? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPHContentEditingHandler))]PHContentEditingHandler completionHandler)
		{
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDPHContentEditingHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selRequestContentEditingInputWithOptions_CompletionHandler_XHandle, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			return ret!;
		}
	} /* class PHAssetContentEditingInputExtensions */
}
