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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UICollectionViewSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICollectionViewSource", WrapperType = typeof (UICollectionViewSourceWrapper), IsInformal = true)]
	public partial interface IUICollectionViewSource : INativeObject, IDisposable, 
		UIKit.IUICollectionViewDataSource
		, UIKit.IUICollectionViewDelegate
		, UIKit.IUIScrollViewDelegate
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewSourceWrapper : BaseWrapper, IUICollectionViewSource {
		public UICollectionViewSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewSourceWrapper))]
		static UICollectionViewSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:cellForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewCell? ret;
			ret =  Runtime.GetNSObject<UICollectionViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUICollectionViewSource" /> (for the protocol <c>UICollectionViewSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUICollectionViewSource" />.</para>
	/// </summary>
	[Protocol(IsInformal = true)]
	[Register("Microsoft_MacCatalyst__UIKit_UICollectionViewSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UICollectionViewSource : NSObject, IUICollectionViewSource, IUICollectionViewDataSource, IUICollectionViewDelegate, IUIScrollViewDelegate {
		/// <summary>Creates a new <see cref="UICollectionViewSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UICollectionViewSource () : base (NSObjectFlag.Empty)
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
		protected UICollectionViewSource (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("collectionView:canEditItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanEditItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The <see cref="T:UIKit.UICollectionView" /> is associated with <c>this</c>.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> of the item being checked.</param><summary>Whether the item at <paramref name="indexPath" /> can be focused.</summary><returns>Returns <see langword="true" /> if the item can be focused.</returns><remarks><para>If this method is not implemented, the item's <see cref="P:UIKit.UIView.CanBecomeFocused" /> property will be checked.</para></remarks>
		[Export ("collectionView:canFocusItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanFocusItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canMoveItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified <paramref name="indexPath" /> supports the specified action.</summary><returns>The default value is <see langword="false" />.</returns><remarks><para>This method is called after <see cref="UIKit.UICollectionViewDelegate_Extensions.ShouldShowMenu(UIKit.IUICollectionViewDelegate,UIKit.UICollectionView,Foundation.NSIndexPath)" /> and allows the developer to remove particular menu items from the displayed editing menu.</para></remarks>
		[Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:canPerformPrimaryActionForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformPrimaryActionForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDisplayingEnded (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDecelerating:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationEnded (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDecelerating:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationStarted (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:didBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginMultipleSelectionInteraction (UICollectionView collectionView, NSIndexPath indexPath)
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
		[Export ("collectionViewDidEndMultipleSelectionInteraction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndMultipleSelectionInteraction (UICollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UICollectionViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UICollectionViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="collectionView" />.</para></remarks>
		[Export ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UICollectionView collectionView, UICollectionViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidZoom:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoom (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (UIScrollView scrollView, bool willDecelerate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDragging:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingStarted (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:cellForItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:contextMenuConfigurationForItemAtIndexPath:point:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UICollectionView collectionView, NSIndexPath indexPath, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UICollectionView collectionView, NSIndexPath[] indexPaths, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetContextMenuConfigurationDismissalPreview (UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetContextMenuConfigurationHighlightPreview (UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="title">The title of the item.</param><param name="atIndex">The index into the index titles for which to retrieve the index path.</param><summary>Requests the index path for the item in the collection view at the specified index with the specified title.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:indexPathForIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (UICollectionView collectionView, string title, nint atIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>When overridden, allows the developer to specify the item that should initially receive focus.</summary><returns>To be added.</returns><remarks><para>The value returned by this method will be ignored on re-entry if the <paramref name="collectionView" /> object's <see cref="P:UIKit.UICollectionView.RemembersLastFocusedIndexPath" /> is <see langword="true" />. </para></remarks>
		[Export ("indexPathForPreferredFocusedViewInCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPathForPreferredFocusedView (UICollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>Requests the index titles for the items in the specified collection view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexTitlesForCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetIndexTitles (UICollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:previewForDismissingContextMenuWithConfiguration:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:previewForHighlightingContextMenuWithConfiguration:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:sceneActivationConfigurationForItemAtIndexPath:point:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIWindowSceneActivationConfiguration? GetSceneActivationConfigurationForItem (UICollectionView collectionView, NSIndexPath indexPath, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:selectionFollowsFocusForItemAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetSelectionFollowsFocusForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="proposedContentOffset">To be added.</param><summary>When overridden, allows the developer to modify the content offset for layout and animation changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:targetContentOffsetForProposedContentOffset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetTargetContentOffset (UICollectionView collectionView, CGPoint proposedContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="originalIndexPath">To be added.</param><param name="proposedIndexPath">To be added.</param><summary>When overridden, allows the developer to modify the final location of a moved item. (For instance, to disallow a move to a particular <paramref name="proposedIndexPath" />.)</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetTargetIndexPathForMove (UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath proposedIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetTargetIndexPathForMoveOfItemFromOriginalIndexPath (UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath currentIndexPath, NSIndexPath proposedIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The reusable view used for the supplementary element at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDeselected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemHighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemUnhighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="sourceIndexPath">To be added.</param><param name="destinationIndexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:moveItemAtIndexPath:toIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItem (UICollectionView collectionView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>The number of sections in this UICollectionViewDataSource.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInCollectionView:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UICollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified indexPath supports the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:performAction:forItemAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:performPrimaryActionForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPrimaryActionForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollAnimationEnded (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScroll:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Scrolled (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScrollToTop:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrolledToTop (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:shouldBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginMultipleSelectionInteraction (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDeselectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHighlightItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scrollViewShouldScrollToTop:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldScrollToTop (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath allows itself to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldSelectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should show an Action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowMenu (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">The index path to the item.</param><param name="context">The spring-loaded interaction context.</param><summary>Method that is called to indicate whether the identified item should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldSpringLoadItemAtIndexPath:withContext:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSpringLoadItem (UICollectionView collectionView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">To be added.</param><summary>When overridden, allows the developer to prevent the focus change specified in <paramref name="context" />.</summary><returns><see langword="true" /> if the focus specified in <paramref name="context" /> is allowed.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldUpdateFocusInContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UICollectionView collectionView, UICollectionViewFocusUpdateContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the supplementary view at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SupplementaryViewDisplayingEnded (UICollectionView collectionView, UICollectionReusableView view, NSString elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>The UICollectionViewTransitionLayout to be used when moving from the specified fromLayout to the toLayout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewTransitionLayout TransitionLayout (UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForZoomingInScrollView:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewForZoomingInScrollView (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>The <paramref name="cell" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplayCell:forItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:willDisplayContextMenuWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The supplementary <paramref name="view" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplaySupplementaryView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndContextMenuInteraction (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillEndDragging (UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingEnded (UIScrollView scrollView, UIView withView, nfloat atScale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginZooming:withView:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingStarted (UIScrollView scrollView, UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICollectionViewSource */
}
