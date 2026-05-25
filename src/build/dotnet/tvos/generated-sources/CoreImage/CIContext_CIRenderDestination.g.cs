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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreImage {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CIContext_CIRenderDestination  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIContext");
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="fromRect">To be added.</param><param name="destination">To be added.</param><param name="atPoint">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("prepareRender:fromRect:toDestination:atPoint:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool PrepareRender (this CIContext This, CIImage image, CGRect fromRect, CIRenderDestination destination, CGPoint atPoint, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_CGPoint_ref_NativeHandle (This.Handle, Selector.GetHandle ("prepareRender:fromRect:toDestination:atPoint:error:"), image__handle__, fromRect, destination__handle__, atPoint, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (destination);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="destination">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startTaskToClear:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CIRenderTask? StartTaskToClear (this CIContext This, CIRenderDestination destination, out NSError? error)
		{
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			NativeHandle errorValue = IntPtr.Zero;
			CIRenderTask? ret;
			ret =  Runtime.GetNSObject<CIRenderTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("startTaskToClear:error:"), destination__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (destination);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="fromRect">To be added.</param><param name="destination">To be added.</param><param name="atPoint">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startTaskToRender:fromRect:toDestination:atPoint:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CIRenderTask? StartTaskToRender (this CIContext This, CIImage image, CGRect fromRect, CIRenderDestination destination, CGPoint atPoint, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			NativeHandle errorValue = IntPtr.Zero;
			CIRenderTask? ret;
			ret =  Runtime.GetNSObject<CIRenderTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle_CGPoint_ref_NativeHandle (This.Handle, Selector.GetHandle ("startTaskToRender:fromRect:toDestination:atPoint:error:"), image__handle__, fromRect, destination__handle__, atPoint, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (destination);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="destination">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startTaskToRender:toDestination:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CIRenderTask? StartTaskToRender (this CIContext This, CIImage image, CIRenderDestination destination, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			NativeHandle errorValue = IntPtr.Zero;
			CIRenderTask? ret;
			ret =  Runtime.GetNSObject<CIRenderTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("startTaskToRender:toDestination:error:"), image__handle__, destination__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (destination);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	} /* class CIContext_CIRenderDestination */
}
