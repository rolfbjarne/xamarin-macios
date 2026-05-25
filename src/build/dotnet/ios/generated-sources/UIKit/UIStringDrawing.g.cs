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
namespace UIKit {
	/// <summary>Extension class for drawing strings to the screen.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class UIStringDrawing  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="font">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'NSString.DrawString (CGPoint, UIStringAttributes)' instead.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawAtPoint:withFont:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGPoint, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGPoint, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DrawString (this NSString This, CGPoint point, UIFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("drawAtPoint:withFont:"), point, font__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="width">To be added.</param><param name="font">To be added.</param><param name="breakMode">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method..</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawAtPoint:forWidth:withFont:lineBreakMode:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DrawString (this NSString This, CGPoint point, nfloat width, UIFont font, UILineBreakMode breakMode)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGPoint_nfloat_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("drawAtPoint:forWidth:withFont:lineBreakMode:"), point, width, font__handle__, (IntPtr) (long) breakMode);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="width">To be added.</param><param name="font">To be added.</param><param name="fontSize">To be added.</param><param name="breakMode">To be added.</param><param name="adjustment">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawAtPoint:forWidth:withFont:fontSize:lineBreakMode:baselineAdjustment:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DrawString (this NSString This, CGPoint point, nfloat width, UIFont font, nfloat fontSize, UILineBreakMode breakMode, UIBaselineAdjustment adjustment)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGPoint_nfloat_NativeHandle_nfloat_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("drawAtPoint:forWidth:withFont:fontSize:lineBreakMode:baselineAdjustment:"), point, width, font__handle__, fontSize, (IntPtr) (long) breakMode, (IntPtr) (long) adjustment);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="width">To be added.</param><param name="font">To be added.</param><param name="minFontSize">To be added.</param><param name="actualFontSize">To be added.</param><param name="breakMode">To be added.</param><param name="adjustment">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawAtPoint:forWidth:withFont:minFontSize:actualFontSize:lineBreakMode:baselineAdjustment:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CGSize DrawString (this NSString This, CGPoint point, nfloat width, UIFont font, nfloat minFontSize, ref nfloat actualFontSize, UILineBreakMode breakMode, UIBaselineAdjustment adjustment)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			fixed (nfloat* actualFontSize__pointer = &actualFontSize) {
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGPoint_nfloat_NativeHandle_nfloat_ref_NFloat_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("drawAtPoint:forWidth:withFont:minFontSize:actualFontSize:lineBreakMode:baselineAdjustment:"), point, width, font__handle__, minFontSize, actualFontSize__pointer, (IntPtr) (long) breakMode, (IntPtr) (long) adjustment);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
			}
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="font">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawInRect:withFont:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DrawString (this NSString This, CGRect rect, UIFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("drawInRect:withFont:"), rect, font__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="font">To be added.</param><param name="mode">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawInRect:withFont:lineBreakMode:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DrawString (this NSString This, CGRect rect, UIFont font, UILineBreakMode mode)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGRect_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("drawInRect:withFont:lineBreakMode:"), rect, font__handle__, (IntPtr) (long) mode);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="font">To be added.</param><param name="mode">To be added.</param><param name="alignment">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawInRect:withFont:lineBreakMode:alignment:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.DrawString (CGRect, UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DrawString (this NSString This, CGRect rect, UIFont font, UILineBreakMode mode, UITextAlignment alignment)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGRect_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("drawInRect:withFont:lineBreakMode:alignment:"), rect, font__handle__, (IntPtr) (long) mode, (IntPtr) (long) alignment);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="font">To be added.</param><summary>Developers should use <see cref="NSStringDrawing.GetSizeUsingAttributes(Foundation.NSString,UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("sizeWithFont:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.GetSizeUsingAttributes (UIStringAttributes)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.GetSizeUsingAttributes (UIStringAttributes)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize StringSize (this NSString This, UIFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sizeWithFont:"), font__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="font">To be added.</param><param name="forWidth">To be added.</param><param name="breakMode">To be added.</param><summary>Gets the <see cref="T:CoreGraphics.CGSize" /> necessary to display this <see cref="T:Foundation.NSString" />.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("sizeWithFont:forWidth:lineBreakMode:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize StringSize (this NSString This, UIFont font, nfloat forWidth, UILineBreakMode breakMode)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("sizeWithFont:forWidth:lineBreakMode:"), font__handle__, forWidth, (IntPtr) (long) breakMode);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="font">To be added.</param><param name="constrainedToSize">To be added.</param><summary>The calculated size of the string if rendered with the <paramref name="font" /> or <paramref name="constrainedToSize" />, whichever is smaller.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("sizeWithFont:constrainedToSize:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize StringSize (this NSString This, UIFont font, CGSize constrainedToSize)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("sizeWithFont:constrainedToSize:"), font__handle__, constrainedToSize);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="font">To be added.</param><param name="constrainedToSize">To be added.</param><param name="lineBreakMode">To be added.</param><summary>Gets the <see cref="T:CoreGraphics.CGSize" /> necessary to display this <see cref="T:Foundation.NSString" />.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("sizeWithFont:constrainedToSize:lineBreakMode:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize StringSize (this NSString This, UIFont font, CGSize constrainedToSize, UILineBreakMode lineBreakMode)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_CGSize_IntPtr (This.Handle, Selector.GetHandle ("sizeWithFont:constrainedToSize:lineBreakMode:"), font__handle__, constrainedToSize, (IntPtr) (long) lineBreakMode);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="font">To be added.</param><param name="minFontSize">To be added.</param><param name="actualFontSize">To be added.</param><param name="forWidth">To be added.</param><param name="lineBreakMode">To be added.</param><summary>Gets the <see cref="T:CoreGraphics.CGSize" /> necessary to display this <see cref="T:Foundation.NSString" />.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("sizeWithFont:minFontSize:actualFontSize:forWidth:lineBreakMode:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CGSize StringSize (this NSString This, UIFont font, nfloat minFontSize, ref nfloat actualFontSize, nfloat forWidth, UILineBreakMode lineBreakMode)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			fixed (nfloat* actualFontSize__pointer = &actualFontSize) {
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_nfloat_ref_NFloat_nfloat_IntPtr (This.Handle, Selector.GetHandle ("sizeWithFont:minFontSize:actualFontSize:forWidth:lineBreakMode:"), font__handle__, minFontSize, actualFontSize__pointer, forWidth, (IntPtr) (long) lineBreakMode);
			GC.KeepAlive (This);
			GC.KeepAlive (font);
			return ret!;
			}
		}
	} /* class UIStringDrawing */
}
