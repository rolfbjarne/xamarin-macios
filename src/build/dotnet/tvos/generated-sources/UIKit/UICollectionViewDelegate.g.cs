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
	/// <summary>This interface represents the Objective-C protocol <c>UICollectionViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICollectionViewDelegate", WrapperType = typeof (UICollectionViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldHighlightItem", Selector = "collectionView:shouldHighlightItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemHighlighted", Selector = "collectionView:didHighlightItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemUnhighlighted", Selector = "collectionView:didUnhighlightItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectItem", Selector = "collectionView:shouldSelectItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDeselectItem", Selector = "collectionView:shouldDeselectItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemSelected", Selector = "collectionView:didSelectItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemDeselected", Selector = "collectionView:didDeselectItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "collectionView:willDisplayCell:forItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewCell), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplaySupplementaryView", Selector = "collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionReusableView), typeof (string), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellDisplayingEnded", Selector = "collectionView:didEndDisplayingCell:forItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewCell), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupplementaryViewDisplayingEnded", Selector = "collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionReusableView), typeof (NSString), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowMenu", Selector = "collectionView:shouldShowMenuForItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanPerformAction", Selector = "collectionView:canPerformAction:forItemAtIndexPath:withSender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (Selector), typeof (NSIndexPath), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAction", Selector = "collectionView:performAction:forItemAtIndexPath:withSender:", ParameterType = new Type [] { typeof (UICollectionView), typeof (Selector), typeof (NSIndexPath), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionLayout", Selector = "collectionView:transitionLayoutForOldLayout:newLayout:", ReturnType = typeof (UICollectionViewTransitionLayout), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (UICollectionViewLayout) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTargetIndexPathForMove", Selector = "collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTargetContentOffset", Selector = "collectionView:targetContentOffsetForProposedContentOffset:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (UICollectionView), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanEditItem", Selector = "collectionView:canEditItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanFocusItem", Selector = "collectionView:canFocusItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUpdateFocus", Selector = "collectionView:shouldUpdateFocusInContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewFocusUpdateContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateFocus", Selector = "collectionView:didUpdateFocusInContext:withAnimationCoordinator:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewFocusUpdateContext), typeof (UIFocusAnimationCoordinator) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIndexPathForPreferredFocusedView", Selector = "indexPathForPreferredFocusedViewInCollectionView:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UICollectionView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTargetIndexPathForMoveOfItemFromOriginalIndexPath", Selector = "collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath), typeof (NSIndexPath), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayContextMenu", Selector = "collectionView:willDisplayContextMenuWithConfiguration:animator:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndContextMenuInteraction", Selector = "collectionView:willEndContextMenuInteractionWithConfiguration:animator:", ParameterType = new Type [] { typeof (UICollectionView), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanPerformPrimaryActionForItem", Selector = "collectionView:canPerformPrimaryActionForItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformPrimaryActionForItem", Selector = "collectionView:performPrimaryActionForItemAtIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContextMenuConfiguration", Selector = "collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:", ReturnType = typeof (UIContextMenuConfiguration), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath[]), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContextMenuConfigurationHighlightPreview", Selector = "collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UICollectionView), typeof (UIContextMenuConfiguration), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContextMenuConfigurationDismissalPreview", Selector = "collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UICollectionView), typeof (UIContextMenuConfiguration), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUICollectionViewDelegate : INativeObject, IDisposable, 
		UIKit.IUIScrollViewDelegate
	{
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHighlightItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _ShouldHighlightItem (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldHighlightItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemHighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			_ItemHighlighted (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemHighlighted (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemUnhighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			_ItemUnhighlighted (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemUnhighlighted (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didUnhighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath allows itself to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldSelectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _ShouldSelectItem (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath allows itself to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDeselectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _ShouldDeselectItem (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDeselectItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			_ItemSelected (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemSelected (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDeselected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			_ItemDeselected (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemDeselected (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>The <paramref name="cell" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:willDisplayCell:forItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			_WillDisplayCell (this, collectionView, cell, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>The <paramref name="cell" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayCell (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplayCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The supplementary <paramref name="view" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplaySupplementaryView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath)
		{
			_WillDisplaySupplementaryView (this, collectionView, view, elementKind, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The supplementary <paramref name="view" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplaySupplementaryView (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nselementKind = CFString.CreateNative (elementKind);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView__handle__, view__handle__, nselementKind, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nselementKind);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDisplayingEnded (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			_CellDisplayingEnded (this, collectionView, cell, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CellDisplayingEnded (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the supplementary view at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SupplementaryViewDisplayingEnded (UICollectionView collectionView, UICollectionReusableView view, NSString elementKind, NSIndexPath indexPath)
		{
			_SupplementaryViewDisplayingEnded (this, collectionView, view, elementKind, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the supplementary view at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SupplementaryViewDisplayingEnded (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionReusableView view, NSString elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView__handle__, view__handle__, elementKind__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should show an Action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
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
			return _ShouldShowMenu (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should show an Action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowMenu (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldShowMenuForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified <paramref name="indexPath" /> supports the specified action.</summary><returns>The default value is <see langword="false" />.</returns><remarks><para>This method is called after <see cref="UIKit.UICollectionViewDelegate_Extensions.ShouldShowMenu(UIKit.IUICollectionViewDelegate,UIKit.UICollectionView,Foundation.NSIndexPath)" /> and allows the developer to remove particular menu items from the displayed editing menu.</para></remarks>
		[global::Foundation.OptionalMember]
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
			return _CanPerformAction (this, collectionView, action, indexPath, sender);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified <paramref name="indexPath" /> supports the specified action.</summary><returns>The default value is <see langword="false" />.</returns><remarks><para>This method is called after <see cref="UIKit.UICollectionViewDelegate_Extensions.ShouldShowMenu(UIKit.IUICollectionViewDelegate,UIKit.UICollectionView,Foundation.NSIndexPath)" /> and allows the developer to remove particular menu items from the displayed editing menu.</para></remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPerformAction (IUICollectionViewDelegate This, UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canPerformAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified indexPath supports the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
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
			_PerformAction (this, collectionView, action, indexPath, sender);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified indexPath supports the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformAction (IUICollectionViewDelegate This, UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:performAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>The UICollectionViewTransitionLayout to be used when moving from the specified fromLayout to the toLayout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewTransitionLayout TransitionLayout (UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout)
		{
			return _TransitionLayout (this, collectionView, fromLayout, toLayout);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>The UICollectionViewTransitionLayout to be used when moving from the specified fromLayout to the toLayout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICollectionViewTransitionLayout _TransitionLayout (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var fromLayout__handle__ = fromLayout!.GetNonNullHandle (nameof (fromLayout));
			var toLayout__handle__ = toLayout!.GetNonNullHandle (nameof (toLayout));
			UICollectionViewTransitionLayout? ret;
			ret =  Runtime.GetNSObject<UICollectionViewTransitionLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView__handle__, fromLayout__handle__, toLayout__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (fromLayout);
			GC.KeepAlive (toLayout);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="originalIndexPath">To be added.</param><param name="proposedIndexPath">To be added.</param><summary>When overridden, allows the developer to modify the final location of a moved item. (For instance, to disallow a move to a particular <paramref name="proposedIndexPath" />.)</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
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
			return _GetTargetIndexPathForMove (this, collectionView, originalIndexPath, proposedIndexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="originalIndexPath">To be added.</param><param name="proposedIndexPath">To be added.</param><summary>When overridden, allows the developer to modify the final location of a moved item. (For instance, to disallow a move to a particular <paramref name="proposedIndexPath" />.)</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _GetTargetIndexPathForMove (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var originalIndexPath__handle__ = originalIndexPath!.GetNonNullHandle (nameof (originalIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, proposedIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (originalIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="proposedContentOffset">To be added.</param><summary>When overridden, allows the developer to modify the content offset for layout and animation changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:targetContentOffsetForProposedContentOffset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetTargetContentOffset (UICollectionView collectionView, CGPoint proposedContentOffset)
		{
			return _GetTargetContentOffset (this, collectionView, proposedContentOffset);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="proposedContentOffset">To be added.</param><summary>When overridden, allows the developer to modify the content offset for layout and animation changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetTargetContentOffset (IUICollectionViewDelegate This, UICollectionView collectionView, CGPoint proposedContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collectionView:targetContentOffsetForProposedContentOffset:"), collectionView__handle__, proposedContentOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canEditItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanEditItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _CanEditItem (this, collectionView, indexPath);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanEditItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canEditItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The <see cref="T:UIKit.UICollectionView" /> is associated with <c>this</c>.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> of the item being checked.</param><summary>Whether the item at <paramref name="indexPath" /> can be focused.</summary><returns>Returns <see langword="true" /> if the item can be focused.</returns><remarks><para>If this method is not implemented, the item's <see cref="P:UIKit.UIView.CanBecomeFocused" /> property will be checked.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canFocusItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanFocusItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _CanFocusItem (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The <see cref="T:UIKit.UICollectionView" /> is associated with <c>this</c>.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> of the item being checked.</param><summary>Whether the item at <paramref name="indexPath" /> can be focused.</summary><returns>Returns <see langword="true" /> if the item can be focused.</returns><remarks><para>If this method is not implemented, the item's <see cref="P:UIKit.UIView.CanBecomeFocused" /> property will be checked.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanFocusItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canFocusItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">To be added.</param><summary>When overridden, allows the developer to prevent the focus change specified in <paramref name="context" />.</summary><returns><see langword="true" /> if the focus specified in <paramref name="context" /> is allowed.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldUpdateFocusInContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UICollectionView collectionView, UICollectionViewFocusUpdateContext context)
		{
			return _ShouldUpdateFocus (this, collectionView, context);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">To be added.</param><summary>When overridden, allows the developer to prevent the focus change specified in <paramref name="context" />.</summary><returns><see langword="true" /> if the focus specified in <paramref name="context" /> is allowed.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldUpdateFocus (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldUpdateFocusInContext:"), collectionView__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UICollectionViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UICollectionViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="collectionView" />.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UICollectionView collectionView, UICollectionViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			_DidUpdateFocus (this, collectionView, context, coordinator);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UICollectionViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UICollectionViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="collectionView" />.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateFocus (IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:"), collectionView__handle__, context__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>When overridden, allows the developer to specify the item that should initially receive focus.</summary><returns>To be added.</returns><remarks><para>The value returned by this method will be ignored on re-entry if the <paramref name="collectionView" /> object's <see cref="P:UIKit.UICollectionView.RemembersLastFocusedIndexPath" /> is <see langword="true" />. </para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("indexPathForPreferredFocusedViewInCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPathForPreferredFocusedView (UICollectionView collectionView)
		{
			return _GetIndexPathForPreferredFocusedView (this, collectionView);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>When overridden, allows the developer to specify the item that should initially receive focus.</summary><returns>To be added.</returns><remarks><para>The value returned by this method will be ignored on re-entry if the <paramref name="collectionView" /> object's <see cref="P:UIKit.UICollectionView.RemembersLastFocusedIndexPath" /> is <see langword="true" />. </para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _GetIndexPathForPreferredFocusedView (IUICollectionViewDelegate This, UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexPathForPreferredFocusedViewInCollectionView:"), collectionView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetTargetIndexPathForMoveOfItemFromOriginalIndexPath (UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath currentIndexPath, NSIndexPath proposedIndexPath)
		{
			return _GetTargetIndexPathForMoveOfItemFromOriginalIndexPath (this, collectionView, originalIndexPath, currentIndexPath, proposedIndexPath);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _GetTargetIndexPathForMoveOfItemFromOriginalIndexPath (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath currentIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var originalIndexPath__handle__ = originalIndexPath!.GetNonNullHandle (nameof (originalIndexPath));
			var currentIndexPath__handle__ = currentIndexPath!.GetNonNullHandle (nameof (currentIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, currentIndexPath__handle__, proposedIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (originalIndexPath);
			GC.KeepAlive (currentIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:willDisplayContextMenuWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			_WillDisplayContextMenu (this, collectionView, configuration, animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayContextMenu (IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplayContextMenuWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndContextMenuInteraction (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			_WillEndContextMenuInteraction (this, collectionView, configuration, animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEndContextMenuInteraction (IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canPerformPrimaryActionForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformPrimaryActionForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _CanPerformPrimaryActionForItem (this, collectionView, indexPath);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPerformPrimaryActionForItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canPerformPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:performPrimaryActionForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPrimaryActionForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			_PerformPrimaryActionForItem (this, collectionView, indexPath);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformPrimaryActionForItem (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:performPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UICollectionView collectionView, NSIndexPath[] indexPaths, CGPoint point)
		{
			return _GetContextMenuConfiguration (this, collectionView, indexPaths, point);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIContextMenuConfiguration? _GetContextMenuConfiguration (IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath[] indexPaths, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:"), collectionView__handle__, nsa_indexPaths.Handle, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetContextMenuConfigurationHighlightPreview (UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			return _GetContextMenuConfigurationHighlightPreview (this, collectionView, configuration, indexPath);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetContextMenuConfigurationHighlightPreview (IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetContextMenuConfigurationDismissalPreview (UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			return _GetContextMenuConfigurationDismissalPreview (this, collectionView, configuration, indexPath);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetContextMenuConfigurationDismissalPreview (IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[DynamicDependencyAttribute ("CanEditItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CanFocusItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CanPerformAction(UIKit.UICollectionView,ObjCRuntime.Selector,Foundation.NSIndexPath,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("CanPerformPrimaryActionForItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CellDisplayingEnded(UIKit.UICollectionView,UIKit.UICollectionViewCell,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DidUpdateFocus(UIKit.UICollectionView,UIKit.UICollectionViewFocusUpdateContext,UIKit.UIFocusAnimationCoordinator)")]
		[DynamicDependencyAttribute ("GetContextMenuConfiguration(UIKit.UICollectionView,Foundation.NSIndexPath[],CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetContextMenuConfigurationDismissalPreview(UIKit.UICollectionView,UIKit.UIContextMenuConfiguration,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetContextMenuConfigurationHighlightPreview(UIKit.UICollectionView,UIKit.UIContextMenuConfiguration,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetIndexPathForPreferredFocusedView(UIKit.UICollectionView)")]
		[DynamicDependencyAttribute ("GetTargetContentOffset(UIKit.UICollectionView,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetTargetIndexPathForMove(UIKit.UICollectionView,Foundation.NSIndexPath,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetTargetIndexPathForMoveOfItemFromOriginalIndexPath(UIKit.UICollectionView,Foundation.NSIndexPath,Foundation.NSIndexPath,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ItemDeselected(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ItemHighlighted(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ItemSelected(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ItemUnhighlighted(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("PerformAction(UIKit.UICollectionView,ObjCRuntime.Selector,Foundation.NSIndexPath,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PerformPrimaryActionForItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldDeselectItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldHighlightItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldSelectItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldShowMenu(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldUpdateFocus(UIKit.UICollectionView,UIKit.UICollectionViewFocusUpdateContext)")]
		[DynamicDependencyAttribute ("SupplementaryViewDisplayingEnded(UIKit.UICollectionView,UIKit.UICollectionReusableView,Foundation.NSString,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("TransitionLayout(UIKit.UICollectionView,UIKit.UICollectionViewLayout,UIKit.UICollectionViewLayout)")]
		[DynamicDependencyAttribute ("WillDisplayCell(UIKit.UICollectionView,UIKit.UICollectionViewCell,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillDisplayContextMenu(UIKit.UICollectionView,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillDisplaySupplementaryView(UIKit.UICollectionView,UIKit.UICollectionReusableView,System.String,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillEndContextMenuInteraction(UIKit.UICollectionView,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionAnimating)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollectionViewDelegate" /> interface to support all the methods from the UICollectionViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollectionViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollectionViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollectionViewDelegate_Extensions {
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldHighlightItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemHighlighted (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemUnhighlighted (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didUnhighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath allows itself to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDeselectItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemSelected (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemDeselected (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>The <paramref name="cell" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayCell (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplayCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The supplementary <paramref name="view" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplaySupplementaryView (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nselementKind = CFString.CreateNative (elementKind);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView__handle__, view__handle__, nselementKind, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nselementKind);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CellDisplayingEnded (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the supplementary view at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SupplementaryViewDisplayingEnded (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionReusableView view, NSString elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView__handle__, view__handle__, elementKind__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should show an Action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowMenu (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldShowMenuForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified <paramref name="indexPath" /> supports the specified action.</summary><returns>The default value is <see langword="false" />.</returns><remarks><para>This method is called after <see cref="UIKit.UICollectionViewDelegate_Extensions.ShouldShowMenu(UIKit.IUICollectionViewDelegate,UIKit.UICollectionView,Foundation.NSIndexPath)" /> and allows the developer to remove particular menu items from the displayed editing menu.</para></remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformAction (this IUICollectionViewDelegate This, UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canPerformAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified indexPath supports the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformAction (this IUICollectionViewDelegate This, UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:performAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>The UICollectionViewTransitionLayout to be used when moving from the specified fromLayout to the toLayout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UICollectionViewTransitionLayout TransitionLayout (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var fromLayout__handle__ = fromLayout!.GetNonNullHandle (nameof (fromLayout));
			var toLayout__handle__ = toLayout!.GetNonNullHandle (nameof (toLayout));
			UICollectionViewTransitionLayout? ret;
			ret =  Runtime.GetNSObject<UICollectionViewTransitionLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView__handle__, fromLayout__handle__, toLayout__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (fromLayout);
			GC.KeepAlive (toLayout);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="originalIndexPath">To be added.</param><param name="proposedIndexPath">To be added.</param><summary>When overridden, allows the developer to modify the final location of a moved item. (For instance, to disallow a move to a particular <paramref name="proposedIndexPath" />.)</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath GetTargetIndexPathForMove (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var originalIndexPath__handle__ = originalIndexPath!.GetNonNullHandle (nameof (originalIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, proposedIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (originalIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="proposedContentOffset">To be added.</param><summary>When overridden, allows the developer to modify the content offset for layout and animation changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint GetTargetContentOffset (this IUICollectionViewDelegate This, UICollectionView collectionView, CGPoint proposedContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collectionView:targetContentOffsetForProposedContentOffset:"), collectionView__handle__, proposedContentOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanEditItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canEditItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The <see cref="T:UIKit.UICollectionView" /> is associated with <c>this</c>.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> of the item being checked.</param><summary>Whether the item at <paramref name="indexPath" /> can be focused.</summary><returns>Returns <see langword="true" /> if the item can be focused.</returns><remarks><para>If this method is not implemented, the item's <see cref="P:UIKit.UIView.CanBecomeFocused" /> property will be checked.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanFocusItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canFocusItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">To be added.</param><summary>When overridden, allows the developer to prevent the focus change specified in <paramref name="context" />.</summary><returns><see langword="true" /> if the focus specified in <paramref name="context" /> is allowed.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldUpdateFocus (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldUpdateFocusInContext:"), collectionView__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UICollectionViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UICollectionViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="collectionView" />.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateFocus (this IUICollectionViewDelegate This, UICollectionView collectionView, UICollectionViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:"), collectionView__handle__, context__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>When overridden, allows the developer to specify the item that should initially receive focus.</summary><returns>To be added.</returns><remarks><para>The value returned by this method will be ignored on re-entry if the <paramref name="collectionView" /> object's <see cref="P:UIKit.UICollectionView.RemembersLastFocusedIndexPath" /> is <see langword="true" />. </para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath? GetIndexPathForPreferredFocusedView (this IUICollectionViewDelegate This, UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexPathForPreferredFocusedViewInCollectionView:"), collectionView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath GetTargetIndexPathForMoveOfItemFromOriginalIndexPath (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath currentIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var originalIndexPath__handle__ = originalIndexPath!.GetNonNullHandle (nameof (originalIndexPath));
			var currentIndexPath__handle__ = currentIndexPath!.GetNonNullHandle (nameof (currentIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, currentIndexPath__handle__, proposedIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (originalIndexPath);
			GC.KeepAlive (currentIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayContextMenu (this IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplayContextMenuWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEndContextMenuInteraction (this IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformPrimaryActionForItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canPerformPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformPrimaryActionForItem (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:performPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIContextMenuConfiguration? GetContextMenuConfiguration (this IUICollectionViewDelegate This, UICollectionView collectionView, NSIndexPath[] indexPaths, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:"), collectionView__handle__, nsa_indexPaths.Handle, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetContextMenuConfigurationHighlightPreview (this IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetContextMenuConfigurationDismissalPreview (this IUICollectionViewDelegate This, UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDelegateWrapper : BaseWrapper, IUICollectionViewDelegate {
		public UICollectionViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDelegateWrapper))]
		static UICollectionViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUICollectionViewDelegate" /> (for the protocol <c>UICollectionViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUICollectionViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UICollectionViewDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UICollectionViewDelegate : NSObject, IUICollectionViewDelegate, IUIScrollViewDelegate {
		/// <summary>Creates a new <see cref="UICollectionViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UICollectionViewDelegate () : base (NSObjectFlag.Empty)
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
		protected UICollectionViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewDelegate (NativeHandle handle) : base (handle)
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
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDeselected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemHighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemUnhighlighted (UICollectionView collectionView, NSIndexPath indexPath)
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
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDeselectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SupplementaryViewDisplayingEnded (UICollectionView collectionView, UICollectionReusableView view, NSString elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>The UICollectionViewTransitionLayout to be used when moving from the specified fromLayout to the toLayout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
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
	} /* class UICollectionViewDelegate */
}
