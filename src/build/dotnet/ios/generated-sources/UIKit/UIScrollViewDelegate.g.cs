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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIScrollViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIScrollViewDelegate", WrapperType = typeof (UIScrollViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Scrolled", Selector = "scrollViewDidScroll:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingStarted", Selector = "scrollViewWillBeginDragging:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEnded", Selector = "scrollViewDidEndDragging:willDecelerate:", ParameterType = new Type [] { typeof (UIScrollView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecelerationStarted", Selector = "scrollViewWillBeginDecelerating:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecelerationEnded", Selector = "scrollViewDidEndDecelerating:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollAnimationEnded", Selector = "scrollViewDidEndScrollingAnimation:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ViewForZoomingInScrollView", Selector = "viewForZoomingInScrollView:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldScrollToTop", Selector = "scrollViewShouldScrollToTop:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrolledToTop", Selector = "scrollViewDidScrollToTop:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ZoomingEnded", Selector = "scrollViewDidEndZooming:withView:atScale:", ParameterType = new Type [] { typeof (UIScrollView), typeof (UIView), typeof (NFloat) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidZoom", Selector = "scrollViewDidZoom:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ZoomingStarted", Selector = "scrollViewWillBeginZooming:withView:", ParameterType = new Type [] { typeof (UIScrollView), typeof (UIView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndDragging", Selector = "scrollViewWillEndDragging:withVelocity:targetContentOffset:", ParameterType = new Type [] { typeof (UIScrollView), typeof (CGPoint), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAdjustedContentInset", Selector = "scrollViewDidChangeAdjustedContentInset:", ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIScrollViewDelegate : INativeObject, IDisposable
	{
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Scrolled (UIScrollView scrollView)
		{
			_Scrolled (this, scrollView);
		}
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Scrolled (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidScroll:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewWillBeginDragging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingStarted (UIScrollView scrollView)
		{
			_DraggingStarted (this, scrollView);
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingStarted (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewWillBeginDragging:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (UIScrollView scrollView, bool willDecelerate)
		{
			_DraggingEnded (this, scrollView, willDecelerate);
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingEnded (IUIScrollViewDelegate This, UIScrollView scrollView, bool willDecelerate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:"), scrollView__handle__, willDecelerate ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewWillBeginDecelerating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationStarted (UIScrollView scrollView)
		{
			_DecelerationStarted (this, scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecelerationStarted (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewWillBeginDecelerating:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidEndDecelerating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationEnded (UIScrollView scrollView)
		{
			_DecelerationEnded (this, scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecelerationEnded (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidEndDecelerating:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollAnimationEnded (UIScrollView scrollView)
		{
			_ScrollAnimationEnded (this, scrollView);
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ScrollAnimationEnded (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidEndScrollingAnimation:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("viewForZoomingInScrollView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewForZoomingInScrollView (UIScrollView scrollView)
		{
			return _ViewForZoomingInScrollView (this, scrollView);
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _ViewForZoomingInScrollView (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewForZoomingInScrollView:"), scrollView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret!;
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewShouldScrollToTop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldScrollToTop (UIScrollView scrollView)
		{
			return _ShouldScrollToTop (this, scrollView);
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldScrollToTop (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewShouldScrollToTop:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret != 0;
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidScrollToTop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrolledToTop (UIScrollView scrollView)
		{
			_ScrolledToTop (this, scrollView);
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ScrolledToTop (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidScrollToTop:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingEnded (UIScrollView scrollView, UIView withView, nfloat atScale)
		{
			_ZoomingEnded (this, scrollView, withView, atScale);
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ZoomingEnded (IUIScrollViewDelegate This, UIScrollView scrollView, UIView withView, nfloat atScale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			var withView__handle__ = withView!.GetNonNullHandle (nameof (withView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:"), scrollView__handle__, withView__handle__, atScale);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			GC.KeepAlive (withView);
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidZoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoom (UIScrollView scrollView)
		{
			_DidZoom (this, scrollView);
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidZoom (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidZoom:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewWillBeginZooming:withView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingStarted (UIScrollView scrollView, UIView view)
		{
			_ZoomingStarted (this, scrollView, view);
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ZoomingStarted (IUIScrollViewDelegate This, UIScrollView scrollView, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewWillBeginZooming:withView:"), scrollView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			GC.KeepAlive (view);
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillEndDragging (UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			_WillEndDragging (this, scrollView, velocity, ref targetContentOffset);
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillEndDragging (IUIScrollViewDelegate This, UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			fixed (CGPoint* targetContentOffset__pointer = &targetContentOffset) {
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_ref_CGPoint (This.Handle, Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:"), scrollView__handle__, velocity, targetContentOffset__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			}
		}
		/// <param name="scrollView">The scroll view whose insets changed.</param><summary>Method that is called when the inset values change.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollViewDidChangeAdjustedContentInset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAdjustedContentInset (UIScrollView scrollView)
		{
			_DidChangeAdjustedContentInset (this, scrollView);
		}
		/// <param name="scrollView">The scroll view whose insets changed.</param><summary>Method that is called when the inset values change.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeAdjustedContentInset (IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidChangeAdjustedContentInset:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		[DynamicDependencyAttribute ("DecelerationEnded(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("DecelerationStarted(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("DidChangeAdjustedContentInset(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("DidZoom(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("DraggingEnded(UIKit.UIScrollView,System.Boolean)")]
		[DynamicDependencyAttribute ("DraggingStarted(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("ScrollAnimationEnded(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("Scrolled(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("ScrolledToTop(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("ShouldScrollToTop(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("ViewForZoomingInScrollView(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("WillEndDragging(UIKit.UIScrollView,CoreGraphics.CGPoint,CoreGraphics.CGPoint@)")]
		[DynamicDependencyAttribute ("ZoomingEnded(UIKit.UIScrollView,UIKit.UIView,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("ZoomingStarted(UIKit.UIScrollView,UIKit.UIView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIScrollViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIScrollViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIScrollViewDelegate" /> interface to support all the methods from the UIScrollViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIScrollViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIScrollViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIScrollViewDelegate_Extensions {
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Scrolled (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidScroll:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingStarted (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewWillBeginDragging:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingEnded (this IUIScrollViewDelegate This, UIScrollView scrollView, bool willDecelerate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:"), scrollView__handle__, willDecelerate ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecelerationStarted (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewWillBeginDecelerating:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecelerationEnded (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidEndDecelerating:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScrollAnimationEnded (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidEndScrollingAnimation:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView ViewForZoomingInScrollView (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewForZoomingInScrollView:"), scrollView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret!;
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldScrollToTop (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewShouldScrollToTop:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret != 0;
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScrolledToTop (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidScrollToTop:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ZoomingEnded (this IUIScrollViewDelegate This, UIScrollView scrollView, UIView withView, nfloat atScale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			var withView__handle__ = withView!.GetNonNullHandle (nameof (withView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:"), scrollView__handle__, withView__handle__, atScale);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			GC.KeepAlive (withView);
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidZoom (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidZoom:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ZoomingStarted (this IUIScrollViewDelegate This, UIScrollView scrollView, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewWillBeginZooming:withView:"), scrollView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			GC.KeepAlive (view);
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillEndDragging (this IUIScrollViewDelegate This, UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			fixed (CGPoint* targetContentOffset__pointer = &targetContentOffset) {
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_ref_CGPoint (This.Handle, Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:"), scrollView__handle__, velocity, targetContentOffset__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			}
		}
		/// <param name="scrollView">The scroll view whose insets changed.</param><summary>Method that is called when the inset values change.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeAdjustedContentInset (this IUIScrollViewDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scrollViewDidChangeAdjustedContentInset:"), scrollView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIScrollViewDelegateWrapper : BaseWrapper, IUIScrollViewDelegate {
		public UIScrollViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIScrollViewDelegateWrapper))]
		static UIScrollViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIScrollViewDelegate" /> (for the protocol <c>UIScrollViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIScrollViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIScrollViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIScrollViewDelegate : NSObject, IUIScrollViewDelegate {
		/// <summary>Creates a new <see cref="UIScrollViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIScrollViewDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UIScrollViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UIScrollViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDecelerating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationEnded (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDecelerating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationStarted (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">The scroll view whose insets changed.</param><summary>Method that is called when the inset values change.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidChangeAdjustedContentInset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAdjustedContentInset (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidZoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoom (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (UIScrollView scrollView, bool willDecelerate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDragging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingStarted (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollAnimationEnded (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Scrolled (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScrollToTop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrolledToTop (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scrollViewShouldScrollToTop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldScrollToTop (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForZoomingInScrollView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewForZoomingInScrollView (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillEndDragging (UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingEnded (UIScrollView scrollView, UIView withView, nfloat atScale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginZooming:withView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingStarted (UIScrollView scrollView, UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIScrollViewDelegate */
}
