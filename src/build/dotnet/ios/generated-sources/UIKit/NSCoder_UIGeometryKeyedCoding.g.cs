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
	/// <summary>A set of <see cref="T:Foundation.NSCoder" /> extension methods that add encoding of geometry-based data for use in UIKit.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSCoder_UIGeometryKeyedCoding  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCoder");
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key identified with the affine transform.</param><summary>Decodes and then returns the affine transform structure that is associated with the designated key.</summary><returns>The affine transform structure that is associated with the designated key.</returns><remarks>To be added.</remarks>
		[Export ("decodeCGAffineTransformForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGAffineTransform DecodeCGAffineTransform (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGAffineTransformForKey:"), nskey);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGAffineTransformForKey:"), nskey);
				GC.KeepAlive (This);
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key that is identified with the point.</param><summary>Decodes and then returns the point structure that is associated with the designated key.</summary><returns>The point structure that is associated with the designated key.</returns><remarks>To be added.</remarks>
		[Export ("decodeCGPointForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint DecodeCGPoint (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGPointForKey:"), nskey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key that is identified with the affine transform.</param><summary>Decodes and then returns the rectangle structure that is associated with the designated key.</summary><returns>The rectangle structure that is associated with the designated key.</returns><remarks>To be added.</remarks>
		[Export ("decodeCGRectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect DecodeCGRect (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGRectForKey:"), nskey);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGRectForKey:"), nskey);
				GC.KeepAlive (This);
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key that is identified with the rect.</param><summary>Decodes and then returns the size structure that is associated with the designated key.</summary><returns>The size structure that is associated with the designated key.</returns><remarks>To be added.</remarks>
		[Export ("decodeCGSizeForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize DecodeCGSize (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGSizeForKey:"), nskey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key that is identified with the vector.</param><summary>Decodes and then returns the vector structure that is associated with the designated key.</summary><returns>The vector structure that is associated with the designated key.</returns><remarks>To be added.</remarks>
		[Export ("decodeCGVectorForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGVector DecodeCGVector (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			CGVector ret;
			ret = global::ObjCRuntime.Messaging.CGVector_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeCGVectorForKey:"), nskey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("decodeDirectionalEdgeInsetsForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDirectionalEdgeInsets DecodeDirectionalEdgeInsets (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSDirectionalEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeDirectionalEdgeInsetsForKey:"), nskey);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("decodeDirectionalEdgeInsetsForKey:"), nskey);
				GC.KeepAlive (This);
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key that is identified with the edge insets.</param><summary>Decodes and then returns the edge insets that are associated with the designated key.</summary><returns>The edge insets that are associated with the designated key.</returns><remarks>To be added.</remarks>
		[Export ("decodeUIEdgeInsetsForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIEdgeInsets DecodeUIEdgeInsets (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			UIEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeUIEdgeInsetsForKey:"), nskey);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("decodeUIEdgeInsetsForKey:"), nskey);
				GC.KeepAlive (This);
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="key">Key that is identified with the offset.</param><summary>Decodes and then returns the offset that is associated with the designated key.</summary><returns>The offset that is associated with the designated key</returns><remarks>To be added.</remarks>
		[Export ("decodeUIOffsetForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIOffset DecodeUIOffsetForKey (this NSCoder This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			UIOffset ret;
			ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeUIOffsetForKey:"), nskey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="forKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeCGPoint:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, CGPoint point, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("encodeCGPoint:forKey:"), point, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="vector">The specified vector.</param><param name="forKey">Designated key in the receiver archive.</param><summary>Encodes the vector and also associates it with the designated key.</summary><remarks>To be added.</remarks>
		[Export ("encodeCGVector:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, CGVector vector, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector_NativeHandle (This.Handle, Selector.GetHandle ("encodeCGVector:forKey:"), vector, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="size">To be added.</param><param name="forKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeCGSize:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, CGSize size, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NativeHandle (This.Handle, Selector.GetHandle ("encodeCGSize:forKey:"), size, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="forKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeCGRect:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, CGRect rect, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("encodeCGRect:forKey:"), rect, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="transform">The specified affine transform.</param><param name="forKey">Designated key in the receiver archive.</param><summary>Encodes the affine transform and also associates it with the designated key.</summary><remarks>To be added.</remarks>
		[Export ("encodeCGAffineTransform:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, CGAffineTransform transform, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform_NativeHandle (This.Handle, Selector.GetHandle ("encodeCGAffineTransform:forKey:"), transform, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="edgeInsets">The specified edge insets.</param><param name="forKey">Designated key in the receiver archive.</param><summary>Encodes the edge insets and also associates them with the designated key.</summary><remarks>To be added.</remarks>
		[Export ("encodeUIEdgeInsets:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, UIEdgeInsets edgeInsets, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets_NativeHandle (This.Handle, Selector.GetHandle ("encodeUIEdgeInsets:forKey:"), edgeInsets, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="directionalEdgeInsets">To be added.</param><param name="forKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeDirectionalEdgeInsets:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, NSDirectionalEdgeInsets directionalEdgeInsets, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSDirectionalEdgeInsets_NativeHandle (This.Handle, Selector.GetHandle ("encodeDirectionalEdgeInsets:forKey:"), directionalEdgeInsets, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="uiOffset">The specified offset.</param><param name="forKey">Designated key in the receiver archive.</param><summary>Encodes the offset and also associates it with the designated key.</summary><remarks>To be added.</remarks>
		[Export ("encodeUIOffset:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this NSCoder This, UIOffset uiOffset, string forKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_NativeHandle (This.Handle, Selector.GetHandle ("encodeUIOffset:forKey:"), uiOffset, nsforKey);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
		}
	} /* class NSCoder_UIGeometryKeyedCoding */
}
