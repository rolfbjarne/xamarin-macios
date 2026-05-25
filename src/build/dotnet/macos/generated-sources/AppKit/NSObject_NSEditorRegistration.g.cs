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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSObject_NSEditorRegistration  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectDidBeginEditing_X = "objectDidBeginEditing:";
		static readonly NativeHandle selObjectDidBeginEditing_XHandle = Selector.GetHandle ("objectDidBeginEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectDidEndEditing_X = "objectDidEndEditing:";
		static readonly NativeHandle selObjectDidEndEditing_XHandle = Selector.GetHandle ("objectDidEndEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		/// <param name="This">The instance on which this method operates.</param><param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("objectDidBeginEditing:")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSEditorRegistration' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ObjectDidBeginEditing (this NSObject This, INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selObjectDidBeginEditing_XHandle, editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("objectDidEndEditing:")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSEditorRegistration' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ObjectDidEndEditing (this NSObject This, INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selObjectDidEndEditing_XHandle, editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
	} /* class NSObject_NSEditorRegistration */
}
