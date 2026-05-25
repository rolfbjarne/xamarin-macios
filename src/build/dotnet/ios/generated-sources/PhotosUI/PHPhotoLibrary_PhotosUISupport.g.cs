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
namespace PhotosUI {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class PHPhotoLibrary_PhotosUISupport  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHPhotoLibrary");
		[Export ("presentLimitedLibraryPickerFromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentLimitedLibraryPicker (this global::Photos.PHPhotoLibrary This, global::UIKit.UIViewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentLimitedLibraryPickerFromViewController:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[Export ("presentLimitedLibraryPickerFromViewController:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PresentLimitedLibraryPicker (this global::Photos.PHPhotoLibrary This, global::UIKit.UIViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<string[]> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V5.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentLimitedLibraryPickerFromViewController:completionHandler:"), controller__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<string[]> PresentLimitedLibraryPickerAsync (this global::Photos.PHPhotoLibrary This, global::UIKit.UIViewController controller)
		{
			var tcs = new TaskCompletionSource<string[]> ();
			This.PresentLimitedLibraryPicker(controller, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
	} /* class PHPhotoLibrary_PhotosUISupport */
}
