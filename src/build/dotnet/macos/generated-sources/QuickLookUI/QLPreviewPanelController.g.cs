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
namespace QuickLookUI {
	public unsafe static partial class QLPreviewPanelController  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptsPreviewPanelControl_X = "acceptsPreviewPanelControl:";
		static readonly NativeHandle selAcceptsPreviewPanelControl_XHandle = Selector.GetHandle ("acceptsPreviewPanelControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginPreviewPanelControl_X = "beginPreviewPanelControl:";
		static readonly NativeHandle selBeginPreviewPanelControl_XHandle = Selector.GetHandle ("beginPreviewPanelControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndPreviewPanelControl_X = "endPreviewPanelControl:";
		static readonly NativeHandle selEndPreviewPanelControl_XHandle = Selector.GetHandle ("endPreviewPanelControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		/// <param name="This">The instance on which this method operates.</param><param name="panel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("acceptsPreviewPanelControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptsPreviewPanelControl (this NSObject This, QLPreviewPanel panel)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, selAcceptsPreviewPanelControl_XHandle, panel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="panel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginPreviewPanelControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginPreviewPanelControl (this NSObject This, QLPreviewPanel panel)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selBeginPreviewPanelControl_XHandle, panel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="panel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("endPreviewPanelControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndPreviewPanelControl (this NSObject This, QLPreviewPanel panel)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selEndPreviewPanelControl_XHandle, panel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
		}
	} /* class QLPreviewPanelController */
}
