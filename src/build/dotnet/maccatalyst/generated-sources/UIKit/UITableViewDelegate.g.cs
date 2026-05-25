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
	/// <summary>A class that receives notifications from a UITableView. MonoTouch developers should generally use <see cref="T:UIKit.UITableViewSource" /> instead of this class.</summary><remarks><para>Implementing <see cref="T:UIKit.UITableView" /> often requires subclasses of both <see cref="T:UIKit.UITableViewDataSource" /> and <see cref="T:UIKit.UITableViewDelegate" /> to provide data and behavior for the table view. MonoTouch provides a single class - <see cref="T:UIKit.UITableViewSource" /> - so that only one class needs to be implemented.</para><para>The UITableViewDelegate class methods provide a table view with the ability to manage selection, configure section headers and footers, delete and reorder cells and control the editing menu.</para></remarks><related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/MonoCatalog-MonoDevelop/">monocatalog</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UITableViewDelegate_Protocol/index.html">Apple documentation for <c>UITableViewDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITableViewDelegate", WrapperType = typeof (UITableViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplay", Selector = "tableView:willDisplayCell:forRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (UITableViewCell), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHeightForRow", Selector = "tableView:heightForRowAtIndexPath:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHeightForHeader", Selector = "tableView:heightForHeaderInSection:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHeightForFooter", Selector = "tableView:heightForFooterInSection:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForHeader", Selector = "tableView:viewForHeaderInSection:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForFooter", Selector = "tableView:viewForFooterInSection:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccessoryButtonTapped", Selector = "tableView:accessoryButtonTappedForRowWithIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSelectRow", Selector = "tableView:willSelectRowAtIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDeselectRow", Selector = "tableView:willDeselectRowAtIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowSelected", Selector = "tableView:didSelectRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowDeselected", Selector = "tableView:didDeselectRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingStyleForRow", Selector = "tableView:editingStyleForRowAtIndexPath:", ReturnType = typeof (UITableViewCellEditingStyle), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TitleForDeleteConfirmation", Selector = "tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldIndentWhileEditing", Selector = "tableView:shouldIndentWhileEditingRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginEditing", Selector = "tableView:willBeginEditingRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndEditing", Selector = "tableView:didEndEditingRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomizeMoveTarget", Selector = "tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IndentationLevel", Selector = "tableView:indentationLevelForRowAtIndexPath:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowMenu", Selector = "tableView:shouldShowMenuForRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanPerformAction", Selector = "tableView:canPerformAction:forRowAtIndexPath:withSender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (Selector), typeof (NSIndexPath), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAction", Selector = "tableView:performAction:forRowAtIndexPath:withSender:", ParameterType = new Type [] { typeof (UITableView), typeof (Selector), typeof (NSIndexPath), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayHeaderView", Selector = "tableView:willDisplayHeaderView:forSection:", ParameterType = new Type [] { typeof (UITableView), typeof (UIView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayFooterView", Selector = "tableView:willDisplayFooterView:forSection:", ParameterType = new Type [] { typeof (UITableView), typeof (UIView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellDisplayingEnded", Selector = "tableView:didEndDisplayingCell:forRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (UITableViewCell), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HeaderViewDisplayingEnded", Selector = "tableView:didEndDisplayingHeaderView:forSection:", ParameterType = new Type [] { typeof (UITableView), typeof (UIView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FooterViewDisplayingEnded", Selector = "tableView:didEndDisplayingFooterView:forSection:", ParameterType = new Type [] { typeof (UITableView), typeof (UIView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldHighlightRow", Selector = "tableView:shouldHighlightRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowHighlighted", Selector = "tableView:didHighlightRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowUnhighlighted", Selector = "tableView:didUnhighlightRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EstimatedHeight", Selector = "tableView:estimatedHeightForRowAtIndexPath:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EstimatedHeightForHeader", Selector = "tableView:estimatedHeightForHeaderInSection:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EstimatedHeightForFooter", Selector = "tableView:estimatedHeightForFooterInSection:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditActionsForRow", Selector = "tableView:editActionsForRowAtIndexPath:", ReturnType = typeof (UITableViewRowAction[]), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanFocusRow", Selector = "tableView:canFocusRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUpdateFocus", Selector = "tableView:shouldUpdateFocusInContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (UITableViewFocusUpdateContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateFocus", Selector = "tableView:didUpdateFocusInContext:withAnimationCoordinator:", ParameterType = new Type [] { typeof (UITableView), typeof (UITableViewFocusUpdateContext), typeof (UIFocusAnimationCoordinator) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIndexPathForPreferredFocusedView", Selector = "indexPathForPreferredFocusedViewInTableView:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UITableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectionFollowsFocusForRow", Selector = "tableView:selectionFollowsFocusForRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLeadingSwipeActionsConfiguration", Selector = "tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:", ReturnType = typeof (UISwipeActionsConfiguration), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTrailingSwipeActionsConfiguration", Selector = "tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:", ReturnType = typeof (UISwipeActionsConfiguration), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSpringLoadRow", Selector = "tableView:shouldSpringLoadRowAtIndexPath:withContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath), typeof (IUISpringLoadedInteractionContext) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeginMultipleSelectionInteraction", Selector = "tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginMultipleSelectionInteraction", Selector = "tableView:didBeginMultipleSelectionInteractionAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndMultipleSelectionInteraction", Selector = "tableViewDidEndMultipleSelectionInteraction:", ParameterType = new Type [] { typeof (UITableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContextMenuConfiguration", Selector = "tableView:contextMenuConfigurationForRowAtIndexPath:point:", ReturnType = typeof (UIContextMenuConfiguration), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForHighlightingContextMenu", Selector = "tableView:previewForHighlightingContextMenuWithConfiguration:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UITableView), typeof (UIContextMenuConfiguration) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForDismissingContextMenu", Selector = "tableView:previewForDismissingContextMenuWithConfiguration:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UITableView), typeof (UIContextMenuConfiguration) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformPreviewAction", Selector = "tableView:willPerformPreviewActionForMenuWithConfiguration:animator:", ParameterType = new Type [] { typeof (UITableView), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionCommitAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayContextMenu", Selector = "tableView:willDisplayContextMenuWithConfiguration:animator:", ParameterType = new Type [] { typeof (UITableView), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndContextMenuInteraction", Selector = "tableView:willEndContextMenuInteractionWithConfiguration:animator:", ParameterType = new Type [] { typeof (UITableView), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanPerformPrimaryAction", Selector = "tableView:canPerformPrimaryActionForRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformPrimaryAction", Selector = "tableView:performPrimaryActionForRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUITableViewDelegate : INativeObject, IDisposable, 
		UIKit.IUIScrollViewDelegate
	{
		/// <param name="tableView">Table view containing the row.</param><param name="cell">Cell view that is going to be used to draw the row.</param><param name="indexPath">Location of the row.</param><summary>Indicates that the cell at the specified indexPath is about to be shown.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willDisplayCell:forRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			_WillDisplay (this, tableView, cell, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="cell">Cell view that is going to be used to draw the row.</param><param name="indexPath">Location of the row.</param><summary>Indicates that the cell at the specified indexPath is about to be shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplay (IUITableViewDelegate This, UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willDisplayCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view.</param><param name="indexPath">Location of the row.</param><summary>The height of the cell at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:heightForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _GetHeightForRow (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view.</param><param name="indexPath">Location of the row.</param><summary>The height of the cell at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetHeightForRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:heightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a header display.</param><summary>The height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:heightForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			return _GetHeightForHeader (this, tableView, section);
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a header display.</param><summary>The height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetHeightForHeader (IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:heightForHeaderInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a footer display.</param><summary>Called to determine the height of the footer for the section specified by <paramref name="section" />.</summary><returns>The height of the footer (in points) as a <see langword="float" />.</returns><remarks><para>This method allows section footers to have different heights. This method is not called if the table is <see cref="F:UIKit.UITableViewStyle.Plain" /> style.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:heightForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForFooter (UITableView tableView, nint section)
		{
			return _GetHeightForFooter (this, tableView, section);
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a footer display.</param><summary>Called to determine the height of the footer for the section specified by <paramref name="section" />.</summary><returns>The height of the footer (in points) as a <see langword="float" />.</returns><remarks><para>This method allows section footers to have different heights. This method is not called if the table is <see cref="F:UIKit.UITableViewStyle.Plain" /> style.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetHeightForFooter (IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:heightForFooterInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the header will be added.</param><summary>Returns a view object to display at the start of the given section.</summary><returns>A view to be displayed at the start of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForHeader(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:viewForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewForHeader (UITableView tableView, nint section)
		{
			return _GetViewForHeader (this, tableView, section);
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the header will be added.</param><summary>Returns a view object to display at the start of the given section.</summary><returns>A view to be displayed at the start of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForHeader(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetViewForHeader (IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:viewForHeaderInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the footer will be added.</param><summary>Returns a view object to display at the end of the given section.</summary><returns>A view to be displayed at the end of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForFooter(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para><para>[UITableViewDelegate]</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:viewForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewForFooter (UITableView tableView, nint section)
		{
			return _GetViewForFooter (this, tableView, section);
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the footer will be added.</param><summary>Returns a view object to display at the end of the given section.</summary><returns>A view to be displayed at the end of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForFooter(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para><para>[UITableViewDelegate]</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetViewForFooter (IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:viewForFooterInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">The table view containing the row/cell accessory that has been tapped.</param><param name="indexPath">The location of the row in the table view.</param><summary>Indicates that the user has tapped the accessory/disclosure button at the specified indexPath.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:accessoryButtonTappedForRowWithIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AccessoryButtonTapped (UITableView tableView, NSIndexPath indexPath)
		{
			_AccessoryButtonTapped (this, tableView, indexPath);
		}
		/// <param name="tableView">The table view containing the row/cell accessory that has been tapped.</param><param name="indexPath">The location of the row in the table view.</param><summary>Indicates that the user has tapped the accessory/disclosure button at the specified indexPath.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AccessoryButtonTapped (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:accessoryButtonTappedForRowWithIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row about to be selected.</param><summary>Indicates the the cell at the specified indexPath is about to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willSelectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? WillSelectRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _WillSelectRow (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row about to be selected.</param><summary>Indicates the the cell at the specified indexPath is about to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _WillSelectRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table involved.</param><param name="indexPath">The index path of the row about to be de-selected.</param><summary>Indicates that the cell at the specified indexPath is about to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willDeselectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? WillDeselectRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _WillDeselectRow (this, tableView, indexPath);
		}
		/// <param name="tableView">The table involved.</param><param name="indexPath">The index path of the row about to be de-selected.</param><summary>Indicates that the cell at the specified indexPath is about to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _WillDeselectRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become selected.</param><summary>Indicates that the call at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didSelectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			_RowSelected (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become selected.</param><summary>Indicates that the call at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RowSelected (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become de-selected.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didDeselectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowDeselected (UITableView tableView, NSIndexPath indexPath)
		{
			_RowDeselected (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become de-selected.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RowDeselected (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view that is going to be editable.</param><param name="indexPath">Location of the row.</param><summary>The UITableViewCellEditingStyle for the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:editingStyleForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewCellEditingStyle EditingStyleForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _EditingStyleForRow (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view that is going to be editable.</param><param name="indexPath">Location of the row.</param><summary>The UITableViewCellEditingStyle for the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITableViewCellEditingStyle _EditingStyleForRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewCellEditingStyle ret;
			ret = (UITableViewCellEditingStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:editingStyleForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row that may be deleted.</param><summary>When overridden, changes the default title of the delete confirmation button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForDeleteConfirmation (UITableView tableView, NSIndexPath indexPath)
		{
			return _TitleForDeleteConfirmation (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row that may be deleted.</param><summary>When overridden, changes the default title of the delete confirmation button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _TitleForDeleteConfirmation (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view that contains the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the cell at the specified indexPath should be indented while it is being edited.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldIndentWhileEditingRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldIndentWhileEditing (UITableView tableView, NSIndexPath indexPath)
		{
			return _ShouldIndentWhileEditing (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view that contains the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the cell at the specified indexPath should be indented while it is being edited.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldIndentWhileEditing (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldIndentWhileEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view about to be edited.</param><param name="indexPath">Location of the row that has been swiped.</param><summary>Indicates that the cell at the specified indexPath is about to be edited.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willBeginEditingRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginEditing (UITableView tableView, NSIndexPath indexPath)
		{
			_WillBeginEditing (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view about to be edited.</param><param name="indexPath">Location of the row that has been swiped.</param><summary>Indicates that the cell at the specified indexPath is about to be edited.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginEditing (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willBeginEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row.</param><summary>Indicates that editing of the cell at the specified indexPath has finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didEndEditingRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndEditing (UITableView tableView, NSIndexPath indexPath)
		{
			_DidEndEditing (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row.</param><summary>Indicates that editing of the cell at the specified indexPath has finished.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndEditing (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didEndEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row to be moved.</param><param name="sourceIndexPath">The original location of the row being moved.</param><param name="proposedIndexPath">The location in the table view where the row has been dropped. The location can be altered by this method.</param><summary>Used to change a cell move destination, for example, to prevent dropping a cell in a certain position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath CustomizeMoveTarget (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedIndexPath)
		{
			return _CustomizeMoveTarget (this, tableView, sourceIndexPath, proposedIndexPath);
		}
		/// <param name="tableView">Table view containing the row to be moved.</param><param name="sourceIndexPath">The original location of the row being moved.</param><param name="proposedIndexPath">The location in the table view where the row has been dropped. The location can be altered by this method.</param><summary>Used to change a cell move destination, for example, to prevent dropping a cell in a certain position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _CustomizeMoveTarget (IUITableViewDelegate This, UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:"), tableView__handle__, sourceIndexPath__handle__, proposedIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>The indentation level for the cell at the specified indexPath.</summary><returns></returns><remarks><para>Note that custom <see cref="T:UIKit.UITableViewCell" />'s do not respect IndentationLevel automatically. Application developers must override <see cref="M:UIKit.UIView.LayoutSubviews" />.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:indentationLevelForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndentationLevel (UITableView tableView, NSIndexPath indexPath)
		{
			return _IndentationLevel (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>The indentation level for the cell at the specified indexPath.</summary><returns></returns><remarks><para>Note that custom <see cref="T:UIKit.UITableViewCell" />'s do not respect IndentationLevel automatically. Application developers must override <see cref="M:UIKit.UIView.LayoutSubviews" />.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _IndentationLevel (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:indentationLevelForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="rowAtindexPath">Location of the row that the user is selecting.</param><summary>Whether the cell at the specified rowAtIndexPath should show an action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldShowMenuForRowAtIndexPath:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowMenu (UITableView tableView, NSIndexPath rowAtindexPath)
		{
			return _ShouldShowMenu (this, tableView, rowAtindexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="rowAtindexPath">Location of the row that the user is selecting.</param><summary>Whether the cell at the specified rowAtIndexPath should show an action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowMenu (IUITableViewDelegate This, UITableView tableView, NSIndexPath rowAtindexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowAtindexPath__handle__ = rowAtindexPath!.GetNonNullHandle (nameof (rowAtindexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldShowMenuForRowAtIndexPath:"), tableView__handle__, rowAtindexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowAtindexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row.</param><param name="sender">Object that initially triggere the Copy or Paste.</param><summary>Whether the cell at the specified indexPath can perform the specified Copy or Paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:canPerformAction:forRowAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			return _CanPerformAction (this, tableView, action, indexPath, sender);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row.</param><param name="sender">Object that initially triggere the Copy or Paste.</param><summary>Whether the cell at the specified indexPath can perform the specified Copy or Paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPerformAction (IUITableViewDelegate This, UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canPerformAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row where the copy or paste operation was selected.</param><param name="sender">Object that triggered the copy or paste operation.</param><summary>Performs the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:performAction:forRowAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			_PerformAction (this, tableView, action, indexPath, sender);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row where the copy or paste operation was selected.</param><param name="sender">Object that triggered the copy or paste operation.</param><summary>Performs the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformAction (IUITableViewDelegate This, UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:performAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> that will be used as the header view.</param><param name="section">The table section to which the header view belongs.</param><summary>Called prior to the display of a header view for a section.</summary><remarks></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willDisplayHeaderView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayHeaderView (UITableView tableView, UIView? headerView, nint section)
		{
			_WillDisplayHeaderView (this, tableView, headerView, section);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> that will be used as the header view.</param><param name="section">The table section to which the header view belongs.</param><summary>Called prior to the display of a header view for a section.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayHeaderView (IUITableViewDelegate This, UITableView tableView, UIView? headerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var headerView__handle__ = headerView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:willDisplayHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (headerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> that will be used as the footer view.</param><param name="section">The table section to which the footer view belongs.</param><summary>Called prior to the display of a footer view for a section.</summary><remarks></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willDisplayFooterView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayFooterView (UITableView tableView, UIView? footerView, nint section)
		{
			_WillDisplayFooterView (this, tableView, footerView, section);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> that will be used as the footer view.</param><param name="section">The table section to which the footer view belongs.</param><summary>Called prior to the display of a footer view for a section.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayFooterView (IUITableViewDelegate This, UITableView tableView, UIView? footerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var footerView__handle__ = footerView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:willDisplayFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (footerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> being displayed.</param><param name="cell">The <see cref="T:UIKit.UITableViewCell" /> that has just been removed.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> specifying the <paramref name="cell" />.</param><summary>Indicates that the cell has just been removed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didEndDisplayingCell:forRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDisplayingEnded (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			_CellDisplayingEnded (this, tableView, cell, indexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> being displayed.</param><param name="cell">The <see cref="T:UIKit.UITableViewCell" /> that has just been removed.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> specifying the <paramref name="cell" />.</param><summary>Indicates that the cell has just been removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CellDisplayingEnded (IUITableViewDelegate This, UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didEndDisplayingCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> to which the <paramref name="headerView" /> belongs.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">An index indicating the section to which the <paramref name="headerView" /> belongs.</param><summary>Called when a section header is removed from a table (for instance, due to scrolling).</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didEndDisplayingHeaderView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HeaderViewDisplayingEnded (UITableView tableView, UIView headerView, nint section)
		{
			_HeaderViewDisplayingEnded (this, tableView, headerView, section);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> to which the <paramref name="headerView" /> belongs.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">An index indicating the section to which the <paramref name="headerView" /> belongs.</param><summary>Called when a section header is removed from a table (for instance, due to scrolling).</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HeaderViewDisplayingEnded (IUITableViewDelegate This, UITableView tableView, UIView headerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var headerView__handle__ = headerView!.GetNonNullHandle (nameof (headerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didEndDisplayingHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (headerView);
		}
		/// <param name="tableView">Table to which the footer view belongs.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">The index of the section to which the <paramref name="footerView" /> belonged.</param><summary>Called when a section footer view is removed from the table (for instance, due to scrolling).</summary><remarks>Application developers should use this method rather than trying to monitor the <paramref name="footerView" />'s visibility directly.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didEndDisplayingFooterView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FooterViewDisplayingEnded (UITableView tableView, UIView footerView, nint section)
		{
			_FooterViewDisplayingEnded (this, tableView, footerView, section);
		}
		/// <param name="tableView">Table to which the footer view belongs.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">The index of the section to which the <paramref name="footerView" /> belonged.</param><summary>Called when a section footer view is removed from the table (for instance, due to scrolling).</summary><remarks>Application developers should use this method rather than trying to monitor the <paramref name="footerView" />'s visibility directly.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FooterViewDisplayingEnded (IUITableViewDelegate This, UITableView tableView, UIView footerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var footerView__handle__ = footerView!.GetNonNullHandle (nameof (footerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didEndDisplayingFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (footerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> in which the row is located.</param><param name="rowIndexPath">The location of the row being highlighted.</param><summary>Whether the cell at the specified indexPath should be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldHighlightRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHighlightRow (UITableView tableView, NSIndexPath rowIndexPath)
		{
			return _ShouldHighlightRow (this, tableView, rowIndexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> in which the row is located.</param><param name="rowIndexPath">The location of the row being highlighted.</param><summary>Whether the cell at the specified indexPath should be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldHighlightRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
			return ret != 0;
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">Location of the row being highlighted.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didHighlightRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowHighlighted (UITableView tableView, NSIndexPath rowIndexPath)
		{
			_RowHighlighted (this, tableView, rowIndexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">Location of the row being highlighted.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RowHighlighted (IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">The row being unhighlighted.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didUnhighlightRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowUnhighlighted (UITableView tableView, NSIndexPath rowIndexPath)
		{
			_RowUnhighlighted (this, tableView, rowIndexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">The row being unhighlighted.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RowUnhighlighted (IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didUnhighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>An estimate of the height for the specified indexPath. Implementations should perform minimal calculation, as it is called repeatedly.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:estimatedHeightForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeight (UITableView tableView, NSIndexPath indexPath)
		{
			return _EstimatedHeight (this, tableView, indexPath);
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>An estimate of the height for the specified indexPath. Implementations should perform minimal calculation, as it is called repeatedly.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _EstimatedHeight (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:estimatedHeightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:estimatedHeightForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeightForHeader (UITableView tableView, nint section)
		{
			return _EstimatedHeightForHeader (this, tableView, section);
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _EstimatedHeightForHeader (IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:estimatedHeightForHeaderInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:estimatedHeightForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeightForFooter (UITableView tableView, nint section)
		{
			return _EstimatedHeightForFooter (this, tableView, section);
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _EstimatedHeightForFooter (IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:estimatedHeightForFooterInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Returns an array of row actions to display after the user swipes the row in the <paramref name="tableView" /> table view that is identified by <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:editActionsForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewRowAction[] EditActionsForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _EditActionsForRow (this, tableView, indexPath);
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Returns an array of row actions to display after the user swipes the row in the <paramref name="tableView" /> table view that is identified by <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITableViewRowAction[] _EditActionsForRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewRowAction[]? ret;
			ret = CFArray.ArrayFromHandle<UITableViewRowAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:editActionsForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Whether the row at the specified <paramref name="indexPath" /> may receive focus.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:canFocusRowAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanFocusRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _CanFocusRow (this, tableView, indexPath);
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Whether the row at the specified <paramref name="indexPath" /> may receive focus.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanFocusRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canFocusRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="context">To be added.</param><summary>TCalled prior to the <paramref name="tableView" /> either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldUpdateFocusInContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UITableView tableView, UITableViewFocusUpdateContext context)
		{
			return _ShouldUpdateFocus (this, tableView, context);
		}
		/// <param name="tableView">To be added.</param><param name="context">To be added.</param><summary>TCalled prior to the <paramref name="tableView" /> either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldUpdateFocus (IUITableViewDelegate This, UITableView tableView, UITableViewFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldUpdateFocusInContext:"), tableView__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="context">A <see cref="T:UIKit.UITableViewFocusUpdateContext" /> object containing metadata.</param><param name="coordinator">A <see cref="T:UIKit.UIFocusAnimationCoordinator" /> object containing metadata.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UITableViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UITableViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="tableView" />.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didUpdateFocusInContext:withAnimationCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UITableView tableView, UITableViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			_DidUpdateFocus (this, tableView, context, coordinator);
		}
		/// <param name="tableView">To be added.</param><param name="context">A <see cref="T:UIKit.UITableViewFocusUpdateContext" /> object containing metadata.</param><param name="coordinator">A <see cref="T:UIKit.UIFocusAnimationCoordinator" /> object containing metadata.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UITableViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UITableViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="tableView" />.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateFocus (IUITableViewDelegate This, UITableView tableView, UITableViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didUpdateFocusInContext:withAnimationCoordinator:"), tableView__handle__, context__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="tableView">To be added.</param><summary>The index path of the table's preferred focus view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("indexPathForPreferredFocusedViewInTableView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPathForPreferredFocusedView (UITableView tableView)
		{
			return _GetIndexPathForPreferredFocusedView (this, tableView);
		}
		/// <param name="tableView">To be added.</param><summary>The index path of the table's preferred focus view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _GetIndexPathForPreferredFocusedView (IUITableViewDelegate This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexPathForPreferredFocusedViewInTableView:"), tableView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:selectionFollowsFocusForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetSelectionFollowsFocusForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _GetSelectionFollowsFocusForRow (this, tableView, indexPath);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSelectionFollowsFocusForRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:selectionFollowsFocusForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the leading edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetLeadingSwipeActionsConfiguration (UITableView tableView, NSIndexPath indexPath)
		{
			return _GetLeadingSwipeActionsConfiguration (this, tableView, indexPath);
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the leading edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISwipeActionsConfiguration? _GetLeadingSwipeActionsConfiguration (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UISwipeActionsConfiguration? ret;
			ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the trailing edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetTrailingSwipeActionsConfiguration (UITableView tableView, NSIndexPath indexPath)
		{
			return _GetTrailingSwipeActionsConfiguration (this, tableView, indexPath);
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the trailing edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISwipeActionsConfiguration? _GetTrailingSwipeActionsConfiguration (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UISwipeActionsConfiguration? ret;
			ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table view to query.</param><param name="indexPath">The index path to the row to query.</param><param name="context">The spring loading context to query.</param><summary>Method that is called to indicate whether the identified row should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldSpringLoadRowAtIndexPath:withContext:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSpringLoadRow (UITableView tableView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			return _ShouldSpringLoadRow (this, tableView, indexPath, context);
		}
		/// <param name="tableView">The table view to query.</param><param name="indexPath">The index path to the row to query.</param><param name="context">The spring loading context to query.</param><summary>Method that is called to indicate whether the identified row should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSpringLoadRow (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldSpringLoadRowAtIndexPath:withContext:"), tableView__handle__, indexPath__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginMultipleSelectionInteraction (UITableView tableView, NSIndexPath indexPath)
		{
			return _ShouldBeginMultipleSelectionInteraction (this, tableView, indexPath);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeginMultipleSelectionInteraction (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginMultipleSelectionInteraction (UITableView tableView, NSIndexPath indexPath)
		{
			_DidBeginMultipleSelectionInteraction (this, tableView, indexPath);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginMultipleSelectionInteraction (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		[global::Foundation.OptionalMember]
		[Export ("tableViewDidEndMultipleSelectionInteraction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndMultipleSelectionInteraction (UITableView tableView)
		{
			_DidEndMultipleSelectionInteraction (this, tableView);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndMultipleSelectionInteraction (IUITableViewDelegate This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewDidEndMultipleSelectionInteraction:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:contextMenuConfigurationForRowAtIndexPath:point:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UITableView tableView, NSIndexPath indexPath, CGPoint point)
		{
			return _GetContextMenuConfiguration (this, tableView, indexPath, point);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIContextMenuConfiguration? _GetContextMenuConfiguration (IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("tableView:contextMenuConfigurationForRowAtIndexPath:point:"), tableView__handle__, indexPath__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:previewForHighlightingContextMenuWithConfiguration:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingContextMenu (UITableView tableView, UIContextMenuConfiguration configuration)
		{
			return _GetPreviewForHighlightingContextMenu (this, tableView, configuration);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetPreviewForHighlightingContextMenu (IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:previewForHighlightingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:previewForDismissingContextMenuWithConfiguration:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingContextMenu (UITableView tableView, UIContextMenuConfiguration configuration)
		{
			return _GetPreviewForDismissingContextMenu (this, tableView, configuration);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetPreviewForDismissingContextMenu (IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:previewForDismissingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			_WillPerformPreviewAction (this, tableView, configuration, animator);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPerformPreviewAction (IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:willDisplayContextMenuWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayContextMenu (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			_WillDisplayContextMenu (this, tableView, configuration, animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayContextMenu (IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willDisplayContextMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:willEndContextMenuInteractionWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndContextMenuInteraction (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			_WillEndContextMenuInteraction (this, tableView, configuration, animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEndContextMenuInteraction (IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willEndContextMenuInteractionWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:canPerformPrimaryActionForRowAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformPrimaryAction (UITableView tableView, NSIndexPath rowIndexPath)
		{
			return _CanPerformPrimaryAction (this, tableView, rowIndexPath);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPerformPrimaryAction (IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canPerformPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:performPrimaryActionForRowAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPrimaryAction (UITableView tableView, NSIndexPath rowIndexPath)
		{
			_PerformPrimaryAction (this, tableView, rowIndexPath);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformPrimaryAction (IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:performPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		[DynamicDependencyAttribute ("AccessoryButtonTapped(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CanFocusRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CanPerformAction(UIKit.UITableView,ObjCRuntime.Selector,Foundation.NSIndexPath,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("CanPerformPrimaryAction(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CellDisplayingEnded(UIKit.UITableView,UIKit.UITableViewCell,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CustomizeMoveTarget(UIKit.UITableView,Foundation.NSIndexPath,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DidBeginMultipleSelectionInteraction(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DidEndEditing(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DidEndMultipleSelectionInteraction(UIKit.UITableView)")]
		[DynamicDependencyAttribute ("DidUpdateFocus(UIKit.UITableView,UIKit.UITableViewFocusUpdateContext,UIKit.UIFocusAnimationCoordinator)")]
		[DynamicDependencyAttribute ("EditActionsForRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("EditingStyleForRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("EstimatedHeight(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("EstimatedHeightForFooter(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("EstimatedHeightForHeader(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("FooterViewDisplayingEnded(UIKit.UITableView,UIKit.UIView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetContextMenuConfiguration(UIKit.UITableView,Foundation.NSIndexPath,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetHeightForFooter(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetHeightForHeader(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetHeightForRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetIndexPathForPreferredFocusedView(UIKit.UITableView)")]
		[DynamicDependencyAttribute ("GetLeadingSwipeActionsConfiguration(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetPreviewForDismissingContextMenu(UIKit.UITableView,UIKit.UIContextMenuConfiguration)")]
		[DynamicDependencyAttribute ("GetPreviewForHighlightingContextMenu(UIKit.UITableView,UIKit.UIContextMenuConfiguration)")]
		[DynamicDependencyAttribute ("GetSelectionFollowsFocusForRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetTrailingSwipeActionsConfiguration(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetViewForFooter(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetViewForHeader(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("HeaderViewDisplayingEnded(UIKit.UITableView,UIKit.UIView,System.IntPtr)")]
		[DynamicDependencyAttribute ("IndentationLevel(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("PerformAction(UIKit.UITableView,ObjCRuntime.Selector,Foundation.NSIndexPath,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PerformPrimaryAction(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("RowDeselected(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("RowHighlighted(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("RowSelected(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("RowUnhighlighted(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldBeginMultipleSelectionInteraction(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldHighlightRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldIndentWhileEditing(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldShowMenu(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ShouldSpringLoadRow(UIKit.UITableView,Foundation.NSIndexPath,UIKit.IUISpringLoadedInteractionContext)")]
		[DynamicDependencyAttribute ("ShouldUpdateFocus(UIKit.UITableView,UIKit.UITableViewFocusUpdateContext)")]
		[DynamicDependencyAttribute ("TitleForDeleteConfirmation(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillBeginEditing(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillDeselectRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillDisplay(UIKit.UITableView,UIKit.UITableViewCell,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillDisplayContextMenu(UIKit.UITableView,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillDisplayFooterView(UIKit.UITableView,UIKit.UIView,System.IntPtr)")]
		[DynamicDependencyAttribute ("WillDisplayHeaderView(UIKit.UITableView,UIKit.UIView,System.IntPtr)")]
		[DynamicDependencyAttribute ("WillEndContextMenuInteraction(UIKit.UITableView,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillPerformPreviewAction(UIKit.UITableView,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionCommitAnimating)")]
		[DynamicDependencyAttribute ("WillSelectRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITableViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITableViewDelegate" /> interface to support all the methods from the UITableViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITableViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITableViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITableViewDelegate_Extensions {
		/// <param name="tableView">Table view containing the row.</param><param name="cell">Cell view that is going to be used to draw the row.</param><param name="indexPath">Location of the row.</param><summary>Indicates that the cell at the specified indexPath is about to be shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplay (this IUITableViewDelegate This, UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willDisplayCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view.</param><param name="indexPath">Location of the row.</param><summary>The height of the cell at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetHeightForRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:heightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a header display.</param><summary>The height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetHeightForHeader (this IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:heightForHeaderInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a footer display.</param><summary>Called to determine the height of the footer for the section specified by <paramref name="section" />.</summary><returns>The height of the footer (in points) as a <see langword="float" />.</returns><remarks><para>This method allows section footers to have different heights. This method is not called if the table is <see cref="F:UIKit.UITableViewStyle.Plain" /> style.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetHeightForFooter (this IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:heightForFooterInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the header will be added.</param><summary>Returns a view object to display at the start of the given section.</summary><returns>A view to be displayed at the start of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForHeader(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView GetViewForHeader (this IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:viewForHeaderInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the footer will be added.</param><summary>Returns a view object to display at the end of the given section.</summary><returns>A view to be displayed at the end of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForFooter(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para><para>[UITableViewDelegate]</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView GetViewForFooter (this IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:viewForFooterInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">The table view containing the row/cell accessory that has been tapped.</param><param name="indexPath">The location of the row in the table view.</param><summary>Indicates that the user has tapped the accessory/disclosure button at the specified indexPath.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AccessoryButtonTapped (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:accessoryButtonTappedForRowWithIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row about to be selected.</param><summary>Indicates the the cell at the specified indexPath is about to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath? WillSelectRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table involved.</param><param name="indexPath">The index path of the row about to be de-selected.</param><summary>Indicates that the cell at the specified indexPath is about to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath? WillDeselectRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become selected.</param><summary>Indicates that the call at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RowSelected (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become de-selected.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RowDeselected (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view that is going to be editable.</param><param name="indexPath">Location of the row.</param><summary>The UITableViewCellEditingStyle for the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITableViewCellEditingStyle EditingStyleForRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewCellEditingStyle ret;
			ret = (UITableViewCellEditingStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:editingStyleForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row that may be deleted.</param><summary>When overridden, changes the default title of the delete confirmation button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? TitleForDeleteConfirmation (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view that contains the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the cell at the specified indexPath should be indented while it is being edited.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldIndentWhileEditing (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldIndentWhileEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view about to be edited.</param><param name="indexPath">Location of the row that has been swiped.</param><summary>Indicates that the cell at the specified indexPath is about to be edited.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginEditing (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willBeginEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row.</param><summary>Indicates that editing of the cell at the specified indexPath has finished.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndEditing (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didEndEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row to be moved.</param><param name="sourceIndexPath">The original location of the row being moved.</param><param name="proposedIndexPath">The location in the table view where the row has been dropped. The location can be altered by this method.</param><summary>Used to change a cell move destination, for example, to prevent dropping a cell in a certain position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath CustomizeMoveTarget (this IUITableViewDelegate This, UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:"), tableView__handle__, sourceIndexPath__handle__, proposedIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>The indentation level for the cell at the specified indexPath.</summary><returns></returns><remarks><para>Note that custom <see cref="T:UIKit.UITableViewCell" />'s do not respect IndentationLevel automatically. Application developers must override <see cref="M:UIKit.UIView.LayoutSubviews" />.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint IndentationLevel (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:indentationLevelForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="rowAtindexPath">Location of the row that the user is selecting.</param><summary>Whether the cell at the specified rowAtIndexPath should show an action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowMenu (this IUITableViewDelegate This, UITableView tableView, NSIndexPath rowAtindexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowAtindexPath__handle__ = rowAtindexPath!.GetNonNullHandle (nameof (rowAtindexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldShowMenuForRowAtIndexPath:"), tableView__handle__, rowAtindexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowAtindexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row.</param><param name="sender">Object that initially triggere the Copy or Paste.</param><summary>Whether the cell at the specified indexPath can perform the specified Copy or Paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformAction (this IUITableViewDelegate This, UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canPerformAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row where the copy or paste operation was selected.</param><param name="sender">Object that triggered the copy or paste operation.</param><summary>Performs the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformAction (this IUITableViewDelegate This, UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:performAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> that will be used as the header view.</param><param name="section">The table section to which the header view belongs.</param><summary>Called prior to the display of a header view for a section.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayHeaderView (this IUITableViewDelegate This, UITableView tableView, UIView? headerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var headerView__handle__ = headerView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:willDisplayHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (headerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> that will be used as the footer view.</param><param name="section">The table section to which the footer view belongs.</param><summary>Called prior to the display of a footer view for a section.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayFooterView (this IUITableViewDelegate This, UITableView tableView, UIView? footerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var footerView__handle__ = footerView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:willDisplayFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (footerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> being displayed.</param><param name="cell">The <see cref="T:UIKit.UITableViewCell" /> that has just been removed.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> specifying the <paramref name="cell" />.</param><summary>Indicates that the cell has just been removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CellDisplayingEnded (this IUITableViewDelegate This, UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didEndDisplayingCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> to which the <paramref name="headerView" /> belongs.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">An index indicating the section to which the <paramref name="headerView" /> belongs.</param><summary>Called when a section header is removed from a table (for instance, due to scrolling).</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HeaderViewDisplayingEnded (this IUITableViewDelegate This, UITableView tableView, UIView headerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var headerView__handle__ = headerView!.GetNonNullHandle (nameof (headerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didEndDisplayingHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (headerView);
		}
		/// <param name="tableView">Table to which the footer view belongs.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">The index of the section to which the <paramref name="footerView" /> belonged.</param><summary>Called when a section footer view is removed from the table (for instance, due to scrolling).</summary><remarks>Application developers should use this method rather than trying to monitor the <paramref name="footerView" />'s visibility directly.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FooterViewDisplayingEnded (this IUITableViewDelegate This, UITableView tableView, UIView footerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var footerView__handle__ = footerView!.GetNonNullHandle (nameof (footerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didEndDisplayingFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (footerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> in which the row is located.</param><param name="rowIndexPath">The location of the row being highlighted.</param><summary>Whether the cell at the specified indexPath should be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldHighlightRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
			return ret != 0;
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">Location of the row being highlighted.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RowHighlighted (this IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">The row being unhighlighted.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RowUnhighlighted (this IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didUnhighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>An estimate of the height for the specified indexPath. Implementations should perform minimal calculation, as it is called repeatedly.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat EstimatedHeight (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:estimatedHeightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat EstimatedHeightForHeader (this IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:estimatedHeightForHeaderInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat EstimatedHeightForFooter (this IUITableViewDelegate This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:estimatedHeightForFooterInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Returns an array of row actions to display after the user swipes the row in the <paramref name="tableView" /> table view that is identified by <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITableViewRowAction[] EditActionsForRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewRowAction[]? ret;
			ret = CFArray.ArrayFromHandle<UITableViewRowAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:editActionsForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Whether the row at the specified <paramref name="indexPath" /> may receive focus.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanFocusRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canFocusRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="context">To be added.</param><summary>TCalled prior to the <paramref name="tableView" /> either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldUpdateFocus (this IUITableViewDelegate This, UITableView tableView, UITableViewFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldUpdateFocusInContext:"), tableView__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="context">A <see cref="T:UIKit.UITableViewFocusUpdateContext" /> object containing metadata.</param><param name="coordinator">A <see cref="T:UIKit.UIFocusAnimationCoordinator" /> object containing metadata.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UITableViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UITableViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="tableView" />.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateFocus (this IUITableViewDelegate This, UITableView tableView, UITableViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didUpdateFocusInContext:withAnimationCoordinator:"), tableView__handle__, context__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="tableView">To be added.</param><summary>The index path of the table's preferred focus view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath? GetIndexPathForPreferredFocusedView (this IUITableViewDelegate This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexPathForPreferredFocusedViewInTableView:"), tableView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSelectionFollowsFocusForRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:selectionFollowsFocusForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the leading edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISwipeActionsConfiguration? GetLeadingSwipeActionsConfiguration (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UISwipeActionsConfiguration? ret;
			ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the trailing edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISwipeActionsConfiguration? GetTrailingSwipeActionsConfiguration (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UISwipeActionsConfiguration? ret;
			ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table view to query.</param><param name="indexPath">The index path to the row to query.</param><param name="context">The spring loading context to query.</param><summary>Method that is called to indicate whether the identified row should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSpringLoadRow (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldSpringLoadRowAtIndexPath:withContext:"), tableView__handle__, indexPath__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeginMultipleSelectionInteraction (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginMultipleSelectionInteraction (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndMultipleSelectionInteraction (this IUITableViewDelegate This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewDidEndMultipleSelectionInteraction:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIContextMenuConfiguration? GetContextMenuConfiguration (this IUITableViewDelegate This, UITableView tableView, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("tableView:contextMenuConfigurationForRowAtIndexPath:point:"), tableView__handle__, indexPath__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetPreviewForHighlightingContextMenu (this IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:previewForHighlightingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetPreviewForDismissingContextMenu (this IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:previewForDismissingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPerformPreviewAction (this IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayContextMenu (this IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willDisplayContextMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEndContextMenuInteraction (this IUITableViewDelegate This, UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:willEndContextMenuInteractionWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformPrimaryAction (this IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canPerformPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
			return ret != 0;
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformPrimaryAction (this IUITableViewDelegate This, UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:performPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITableViewDelegateWrapper : BaseWrapper, IUITableViewDelegate {
		public UITableViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDelegateWrapper))]
		static UITableViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class that receives notifications from a UITableView. MonoTouch developers should generally use <see cref="T:UIKit.UITableViewSource" /> instead of this class.</summary><remarks><para>Implementing <see cref="T:UIKit.UITableView" /> often requires subclasses of both <see cref="T:UIKit.UITableViewDataSource" /> and <see cref="T:UIKit.UITableViewDelegate" /> to provide data and behavior for the table view. MonoTouch provides a single class - <see cref="T:UIKit.UITableViewSource" /> - so that only one class needs to be implemented.</para><para>The UITableViewDelegate class methods provide a table view with the ability to manage selection, configure section headers and footers, delete and reorder cells and control the editing menu.</para></remarks><related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/MonoCatalog-MonoDevelop/">monocatalog</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UITableViewDelegate_Protocol/index.html">Apple documentation for <c>UITableViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITableViewDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITableViewDelegate : UIScrollViewDelegate, IUITableViewDelegate {
		/// <summary>Creates a new <see cref="UITableViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITableViewDelegate () : base (NSObjectFlag.Empty)
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
		protected UITableViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITableViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tableView">The table view containing the row/cell accessory that has been tapped.</param><param name="indexPath">The location of the row in the table view.</param><summary>Indicates that the user has tapped the accessory/disclosure button at the specified indexPath.</summary><remarks>To be added.</remarks>
		[Export ("tableView:accessoryButtonTappedForRowWithIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AccessoryButtonTapped (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Whether the row at the specified <paramref name="indexPath" /> may receive focus.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canFocusRowAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanFocusRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row.</param><param name="sender">Object that initially triggere the Copy or Paste.</param><summary>Whether the cell at the specified indexPath can perform the specified Copy or Paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canPerformAction:forRowAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:canPerformPrimaryActionForRowAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformPrimaryAction (UITableView tableView, NSIndexPath rowIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> being displayed.</param><param name="cell">The <see cref="T:UIKit.UITableViewCell" /> that has just been removed.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> specifying the <paramref name="cell" />.</param><summary>Indicates that the cell has just been removed.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didEndDisplayingCell:forRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDisplayingEnded (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row to be moved.</param><param name="sourceIndexPath">The original location of the row being moved.</param><param name="proposedIndexPath">The location in the table view where the row has been dropped. The location can be altered by this method.</param><summary>Used to change a cell move destination, for example, to prevent dropping a cell in a certain position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath CustomizeMoveTarget (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginMultipleSelectionInteraction (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row.</param><summary>Indicates that editing of the cell at the specified indexPath has finished.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didEndEditingRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndEditing (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableViewDidEndMultipleSelectionInteraction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndMultipleSelectionInteraction (UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="context">A <see cref="T:UIKit.UITableViewFocusUpdateContext" /> object containing metadata.</param><param name="coordinator">A <see cref="T:UIKit.UIFocusAnimationCoordinator" /> object containing metadata.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UITableViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UITableViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="tableView" />.</para></remarks>
		[Export ("tableView:didUpdateFocusInContext:withAnimationCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UITableView tableView, UITableViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Returns an array of row actions to display after the user swipes the row in the <paramref name="tableView" /> table view that is identified by <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:editActionsForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewRowAction[] EditActionsForRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view that is going to be editable.</param><param name="indexPath">Location of the row.</param><summary>The UITableViewCellEditingStyle for the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:editingStyleForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewCellEditingStyle EditingStyleForRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>An estimate of the height for the specified indexPath. Implementations should perform minimal calculation, as it is called repeatedly.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:estimatedHeightForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeight (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:estimatedHeightForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeightForFooter (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:estimatedHeightForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeightForHeader (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table to which the footer view belongs.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">The index of the section to which the <paramref name="footerView" /> belonged.</param><summary>Called when a section footer view is removed from the table (for instance, due to scrolling).</summary><remarks>Application developers should use this method rather than trying to monitor the <paramref name="footerView" />'s visibility directly.</remarks>
		[Export ("tableView:didEndDisplayingFooterView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FooterViewDisplayingEnded (UITableView tableView, UIView footerView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:contextMenuConfigurationForRowAtIndexPath:point:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UITableView tableView, NSIndexPath indexPath, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a footer display.</param><summary>Called to determine the height of the footer for the section specified by <paramref name="section" />.</summary><returns>The height of the footer (in points) as a <see langword="float" />.</returns><remarks><para>This method allows section footers to have different heights. This method is not called if the table is <see cref="F:UIKit.UITableViewStyle.Plain" /> style.</para></remarks>
		[Export ("tableView:heightForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForFooter (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a header display.</param><summary>The height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:heightForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view.</param><param name="indexPath">Location of the row.</param><summary>The height of the cell at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:heightForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><summary>The index path of the table's preferred focus view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexPathForPreferredFocusedViewInTableView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPathForPreferredFocusedView (UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the leading edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetLeadingSwipeActionsConfiguration (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:previewForDismissingContextMenuWithConfiguration:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingContextMenu (UITableView tableView, UIContextMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:previewForHighlightingContextMenuWithConfiguration:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingContextMenu (UITableView tableView, UIContextMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:selectionFollowsFocusForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetSelectionFollowsFocusForRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the trailing edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetTrailingSwipeActionsConfiguration (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the footer will be added.</param><summary>Returns a view object to display at the end of the given section.</summary><returns>A view to be displayed at the end of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForFooter(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para><para>[UITableViewDelegate]</para></remarks>
		[Export ("tableView:viewForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewForFooter (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the header will be added.</param><summary>Returns a view object to display at the start of the given section.</summary><returns>A view to be displayed at the start of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForHeader(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para></remarks>
		[Export ("tableView:viewForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewForHeader (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> to which the <paramref name="headerView" /> belongs.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">An index indicating the section to which the <paramref name="headerView" /> belongs.</param><summary>Called when a section header is removed from a table (for instance, due to scrolling).</summary><remarks>To be added.</remarks>
		[Export ("tableView:didEndDisplayingHeaderView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HeaderViewDisplayingEnded (UITableView tableView, UIView headerView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>The indentation level for the cell at the specified indexPath.</summary><returns></returns><remarks><para>Note that custom <see cref="T:UIKit.UITableViewCell" />'s do not respect IndentationLevel automatically. Application developers must override <see cref="M:UIKit.UIView.LayoutSubviews" />.</para></remarks>
		[Export ("tableView:indentationLevelForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndentationLevel (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row where the copy or paste operation was selected.</param><param name="sender">Object that triggered the copy or paste operation.</param><summary>Performs the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[Export ("tableView:performAction:forRowAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:performPrimaryActionForRowAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPrimaryAction (UITableView tableView, NSIndexPath rowIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become de-selected.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didDeselectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowDeselected (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">Location of the row being highlighted.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didHighlightRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowHighlighted (UITableView tableView, NSIndexPath rowIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become selected.</param><summary>Indicates that the call at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didSelectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">The row being unhighlighted.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didUnhighlightRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowUnhighlighted (UITableView tableView, NSIndexPath rowIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginMultipleSelectionInteraction (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> in which the row is located.</param><param name="rowIndexPath">The location of the row being highlighted.</param><summary>Whether the cell at the specified indexPath should be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldHighlightRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHighlightRow (UITableView tableView, NSIndexPath rowIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view that contains the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the cell at the specified indexPath should be indented while it is being edited.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldIndentWhileEditingRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldIndentWhileEditing (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="rowAtindexPath">Location of the row that the user is selecting.</param><summary>Whether the cell at the specified rowAtIndexPath should show an action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldShowMenuForRowAtIndexPath:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowMenu (UITableView tableView, NSIndexPath rowAtindexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The table view to query.</param><param name="indexPath">The index path to the row to query.</param><param name="context">The spring loading context to query.</param><summary>Method that is called to indicate whether the identified row should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldSpringLoadRowAtIndexPath:withContext:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSpringLoadRow (UITableView tableView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="context">To be added.</param><summary>TCalled prior to the <paramref name="tableView" /> either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldUpdateFocusInContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UITableView tableView, UITableViewFocusUpdateContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row that may be deleted.</param><summary>When overridden, changes the default title of the delete confirmation button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForDeleteConfirmation (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view about to be edited.</param><param name="indexPath">Location of the row that has been swiped.</param><summary>Indicates that the cell at the specified indexPath is about to be edited.</summary><remarks>To be added.</remarks>
		[Export ("tableView:willBeginEditingRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginEditing (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The table involved.</param><param name="indexPath">The index path of the row about to be de-selected.</param><summary>Indicates that the cell at the specified indexPath is about to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:willDeselectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? WillDeselectRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="cell">Cell view that is going to be used to draw the row.</param><param name="indexPath">Location of the row.</param><summary>Indicates that the cell at the specified indexPath is about to be shown.</summary><remarks>To be added.</remarks>
		[Export ("tableView:willDisplayCell:forRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:willDisplayContextMenuWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayContextMenu (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> that will be used as the footer view.</param><param name="section">The table section to which the footer view belongs.</param><summary>Called prior to the display of a footer view for a section.</summary><remarks></remarks>
		[Export ("tableView:willDisplayFooterView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayFooterView (UITableView tableView, UIView? footerView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> that will be used as the header view.</param><param name="section">The table section to which the header view belongs.</param><summary>Called prior to the display of a header view for a section.</summary><remarks></remarks>
		[Export ("tableView:willDisplayHeaderView:forSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayHeaderView (UITableView tableView, UIView? headerView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:willEndContextMenuInteractionWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndContextMenuInteraction (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row about to be selected.</param><summary>Indicates the the cell at the specified indexPath is about to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:willSelectRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? WillSelectRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITableViewDelegate */
}
