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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITextSelectionHighlightView</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UITextSelectionHighlightView", WrapperType = typeof (UITextSelectionHighlightViewWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectionRects", Selector = "selectionRects", PropertyType = typeof (UITextSelectionRect[]), GetterSelector = "selectionRects", SetterSelector = "setSelectionRects:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUITextSelectionHighlightView : INativeObject, IDisposable, 
		UIKit.IUICoordinateSpace
	{
		[DynamicDependencyAttribute ("SelectionRects")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSelectionHighlightViewWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextSelectionHighlightView ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextSelectionRect[] SelectionRects {
			[Export ("selectionRects", ArgumentSemantic.Retain)]
			get {
				return _GetSelectionRects (this);
			}
			[Export ("setSelectionRects:", ArgumentSemantic.Retain)]
			set {
				_SetSelectionRects (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextSelectionRect[] _GetSelectionRects (IUITextSelectionHighlightView This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSelectionRect[] ret;
			ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectionRects")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelectionRects (IUITextSelectionHighlightView This, UITextSelectionRect[] value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectionRects:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextSelectionHighlightViewWrapper : BaseWrapper, IUITextSelectionHighlightView {
		public UITextSelectionHighlightViewWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSelectionHighlightViewWrapper))]
		static UITextSelectionHighlightViewWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ConvertPointToCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ConvertPointFromCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect ConvertRectToCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect ConvertRectFromCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextSelectionRect[] SelectionRects {
			[Export ("selectionRects", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSelectionRect[] ret;
				ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectionRects")), false)!;
				return ret;
			}
			[Export ("setSelectionRects:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectionRects:"), nsa_value.Handle);
			}
		}
		/// <summary>Gets the bounding rectangle of the object in its own coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public CGRect Bounds {
			[Export ("bounds")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
				}
				return ret!;
			}
		}
	}
}
