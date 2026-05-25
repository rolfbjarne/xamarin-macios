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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PencilKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PKCanvasViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "PKCanvasViewDelegate", WrapperType = typeof (PKCanvasViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawingDidChange", Selector = "canvasViewDrawingDidChange:", ParameterType = new Type [] { typeof (PencilKit.PKCanvasView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRendering", Selector = "canvasViewDidFinishRendering:", ParameterType = new Type [] { typeof (PencilKit.PKCanvasView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginUsingTool", Selector = "canvasViewDidBeginUsingTool:", ParameterType = new Type [] { typeof (PencilKit.PKCanvasView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndUsingTool", Selector = "canvasViewDidEndUsingTool:", ParameterType = new Type [] { typeof (PencilKit.PKCanvasView) }, ParameterByRef = new bool [] { false })]
	public partial interface IPKCanvasViewDelegate : INativeObject, IDisposable, 
		UIKit.IUIScrollViewDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("canvasViewDrawingDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawingDidChange (PKCanvasView canvasView)
		{
			_DrawingDidChange (this, canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawingDidChange (IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDrawingDidChange:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[global::Foundation.OptionalMember]
		[Export ("canvasViewDidFinishRendering:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRendering (PKCanvasView canvasView)
		{
			_DidFinishRendering (this, canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishRendering (IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDidFinishRendering:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[global::Foundation.OptionalMember]
		[Export ("canvasViewDidBeginUsingTool:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginUsingTool (PKCanvasView canvasView)
		{
			_DidBeginUsingTool (this, canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginUsingTool (IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDidBeginUsingTool:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[global::Foundation.OptionalMember]
		[Export ("canvasViewDidEndUsingTool:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndUsingTool (PKCanvasView canvasView)
		{
			_EndUsingTool (this, canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndUsingTool (IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDidEndUsingTool:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[DynamicDependencyAttribute ("DidBeginUsingTool(PencilKit.PKCanvasView)")]
		[DynamicDependencyAttribute ("DidFinishRendering(PencilKit.PKCanvasView)")]
		[DynamicDependencyAttribute ("DrawingDidChange(PencilKit.PKCanvasView)")]
		[DynamicDependencyAttribute ("EndUsingTool(PencilKit.PKCanvasView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKCanvasViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKCanvasViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPKCanvasViewDelegate" /> interface to support all the methods from the PKCanvasViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPKCanvasViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PKCanvasViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PKCanvasViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawingDidChange (this IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDrawingDidChange:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishRendering (this IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDidFinishRendering:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginUsingTool (this IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDidBeginUsingTool:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndUsingTool (this IPKCanvasViewDelegate This, PKCanvasView canvasView)
		{
			var canvasView__handle__ = canvasView!.GetNonNullHandle (nameof (canvasView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canvasViewDidEndUsingTool:"), canvasView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (canvasView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKCanvasViewDelegateWrapper : BaseWrapper, IPKCanvasViewDelegate {
		public PKCanvasViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKCanvasViewDelegateWrapper))]
		static PKCanvasViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace PencilKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IPKCanvasViewDelegate" /> (for the protocol <c>PKCanvasViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IPKCanvasViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__PencilKit_PKCanvasViewDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class PKCanvasViewDelegate : NSObject, IPKCanvasViewDelegate, global::UIKit.IUIScrollViewDelegate {
		/// <summary>Creates a new <see cref="PKCanvasViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PKCanvasViewDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected PKCanvasViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal PKCanvasViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDecelerating:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationEnded (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDecelerating:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationStarted (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("canvasViewDidBeginUsingTool:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginUsingTool (PKCanvasView canvasView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">The scroll view whose insets changed.</param><summary>Method that is called when the inset values change.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidChangeAdjustedContentInset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAdjustedContentInset (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("canvasViewDidFinishRendering:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRendering (PKCanvasView canvasView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidZoom:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoom (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (global::UIKit.UIScrollView scrollView, bool willDecelerate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDragging:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingStarted (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("canvasViewDrawingDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawingDidChange (PKCanvasView canvasView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("canvasViewDidEndUsingTool:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndUsingTool (PKCanvasView canvasView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollAnimationEnded (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScroll:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Scrolled (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScrollToTop:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrolledToTop (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scrollViewShouldScrollToTop:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldScrollToTop (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForZoomingInScrollView:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView ViewForZoomingInScrollView (global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillEndDragging (global::UIKit.UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingEnded (global::UIKit.UIScrollView scrollView, global::UIKit.UIView withView, nfloat atScale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginZooming:withView:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingStarted (global::UIKit.UIScrollView scrollView, global::UIKit.UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PKCanvasViewDelegate */
}
