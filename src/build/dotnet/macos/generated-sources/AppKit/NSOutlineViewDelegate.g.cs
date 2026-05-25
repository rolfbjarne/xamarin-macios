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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSOutlineViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSOutlineViewDelegate", WrapperType = typeof (NSOutlineViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "outlineView:willDisplayCell:forTableColumn:item:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEditTableColumn", Selector = "outlineView:shouldEditTableColumn:item:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionShouldChange", Selector = "selectionShouldChangeInOutlineView:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectItem", Selector = "outlineView:shouldSelectItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectionIndexes", Selector = "outlineView:selectionIndexesForProposedSelection:", ReturnType = typeof (NSIndexSet), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectTableColumn", Selector = "outlineView:shouldSelectTableColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MouseDown", Selector = "outlineView:mouseDownInHeaderOfTableColumn:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClickTableColumn", Selector = "outlineView:didClickTableColumn:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDragTableColumn", Selector = "outlineView:didDragTableColumn:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToolTipForCell", Selector = "outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSCell), typeof (CGRect), typeof (NSTableColumn), typeof (NSObject), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, true, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowHeight", Selector = "outlineView:heightOfRowByItem:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectString", Selector = "outlineView:typeSelectStringForTableColumn:item:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNextTypeSelectMatch", Selector = "outlineView:nextTypeSelectMatchFromItem:toItem:forString:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject), typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTypeSelect", Selector = "outlineView:shouldTypeSelectForEvent:withCurrentSearchString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSEvent), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowCellExpansion", Selector = "outlineView:shouldShowCellExpansionForTableColumn:item:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTrackCell", Selector = "outlineView:shouldTrackCell:forTableColumn:item:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSCell), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCell", Selector = "outlineView:dataCellForTableColumn:item:", ReturnType = typeof (NSCell), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "outlineView:viewForTableColumn:item:", ReturnType = typeof (NSView), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsGroupItem", Selector = "outlineView:isGroupItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldExpandItem", Selector = "outlineView:shouldExpandItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCollapseItem", Selector = "outlineView:shouldCollapseItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayOutlineCell", Selector = "outlineView:willDisplayOutlineCell:forTableColumn:item:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSizeToFitColumnWidth", Selector = "outlineView:sizeToFitWidthOfColumn:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSOutlineView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReorder", Selector = "outlineView:shouldReorderColumn:toColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowOutlineCell", Selector = "outlineView:shouldShowOutlineCellForItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidMove", Selector = "outlineViewColumnDidMove:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidResize", Selector = "outlineViewColumnDidResize:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIsChanging", Selector = "outlineViewSelectionIsChanging:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemWillExpand", Selector = "outlineViewItemWillExpand:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemDidExpand", Selector = "outlineViewItemDidExpand:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemWillCollapse", Selector = "outlineViewItemWillCollapse:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemDidCollapse", Selector = "outlineViewItemDidCollapse:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "outlineViewSelectionDidChange:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowViewForItem", Selector = "outlineView:rowViewForItem:", ReturnType = typeof (NSTableRowView), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddRowView", Selector = "outlineView:didAddRowView:forRow:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableRowView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRowView", Selector = "outlineView:didRemoveRowView:forRow:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableRowView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTintConfiguration", Selector = "outlineView:tintConfigurationForItem:", ReturnType = typeof (NSTintConfiguration), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserCanChangeVisibility", Selector = "outlineView:userCanChangeVisibilityOfTableColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserDidChangeVisibility", Selector = "outlineView:userDidChangeVisibilityOfTableColumns:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSOutlineViewDelegate : INativeObject, IDisposable
	{
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:willDisplayCell:forTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			_WillDisplayCell (this, outlineView, cell, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayCell (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:willDisplayCell:forTableColumn:item:"), outlineView__handle__, cell__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldEditTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEditTableColumn (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			return _ShouldEditTableColumn (this, outlineView, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEditTableColumn (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldEditTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("selectionShouldChangeInOutlineView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectionShouldChange (NSOutlineView outlineView)
		{
			return _SelectionShouldChange (this, outlineView);
		}
		/// <param name="outlineView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SelectionShouldChange (INSOutlineViewDelegate This, NSOutlineView outlineView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionShouldChangeInOutlineView:"), outlineView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldSelectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectItem (NSOutlineView outlineView, NSObject item)
		{
			return _ShouldSelectItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectItem (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldSelectItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:selectionIndexesForProposedSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetSelectionIndexes (NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
		{
			return _GetSelectionIndexes (this, outlineView, proposedSelectionIndexes);
		}
		/// <param name="outlineView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexSet _GetSelectionIndexes (INSOutlineViewDelegate This, NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var proposedSelectionIndexes__handle__ = proposedSelectionIndexes!.GetNonNullHandle (nameof (proposedSelectionIndexes));
			NSIndexSet? ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:selectionIndexesForProposedSelection:"), outlineView__handle__, proposedSelectionIndexes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (proposedSelectionIndexes);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldSelectTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectTableColumn (NSOutlineView outlineView, NSTableColumn? tableColumn)
		{
			return _ShouldSelectTableColumn (this, outlineView, tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectTableColumn (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldSelectTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:mouseDownInHeaderOfTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDown (NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			_MouseDown (this, outlineView, tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MouseDown (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:mouseDownInHeaderOfTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:didClickTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickTableColumn (NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			_DidClickTableColumn (this, outlineView, tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidClickTableColumn (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:didClickTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:didDragTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDragTableColumn (NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			_DidDragTableColumn (this, outlineView, tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDragTableColumn (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:didDragTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string ToolTipForCell (NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, NSObject item, CGPoint mouseLocation)
		{
			return _ToolTipForCell (this, outlineView, cell, ref rect, tableColumn, item, mouseLocation);
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static string _ToolTipForCell (INSOutlineViewDelegate This, NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, NSObject item, CGPoint mouseLocation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			fixed (CGRect* rect__pointer = &rect) {
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_CGRect_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:"), outlineView__handle__, cell__handle__, rect__pointer, tableColumn__handle__, item__handle__, mouseLocation), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
			}
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:heightOfRowByItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetRowHeight (NSOutlineView outlineView, NSObject item)
		{
			return _GetRowHeight (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetRowHeight (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:heightOfRowByItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:typeSelectStringForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetSelectString (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			return _GetSelectString (this, outlineView, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSelectString (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:typeSelectStringForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="startItem">To be added.</param><param name="endItem">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:nextTypeSelectMatchFromItem:toItem:forString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetNextTypeSelectMatch (NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
		{
			return _GetNextTypeSelectMatch (this, outlineView, startItem, endItem, searchString);
		}
		/// <param name="outlineView">To be added.</param><param name="startItem">To be added.</param><param name="endItem">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetNextTypeSelectMatch (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var startItem__handle__ = startItem!.GetNonNullHandle (nameof (startItem));
			var endItem__handle__ = endItem!.GetNonNullHandle (nameof (endItem));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:nextTypeSelectMatchFromItem:toItem:forString:"), outlineView__handle__, startItem__handle__, endItem__handle__, nssearchString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (startItem);
			GC.KeepAlive (endItem);
			CFString.ReleaseNative (nssearchString);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTypeSelect (NSOutlineView outlineView, NSEvent theEvent, string? searchString)
		{
			return _ShouldTypeSelect (this, outlineView, theEvent, searchString);
		}
		/// <param name="outlineView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldTypeSelect (INSOutlineViewDelegate This, NSOutlineView outlineView, NSEvent theEvent, string? searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var nssearchString = CFString.CreateNative (searchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:"), outlineView__handle__, theEvent__handle__, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (theEvent);
			CFString.ReleaseNative (nssearchString);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldShowCellExpansionForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowCellExpansion (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			return _ShouldShowCellExpansion (this, outlineView, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowCellExpansion (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldShowCellExpansionForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldTrackCell:forTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTrackCell (NSOutlineView outlineView, NSCell cell, NSTableColumn? tableColumn, NSObject item)
		{
			return _ShouldTrackCell (this, outlineView, cell, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldTrackCell (INSOutlineViewDelegate This, NSOutlineView outlineView, NSCell cell, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldTrackCell:forTableColumn:item:"), outlineView__handle__, cell__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:dataCellForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell GetCell (NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			return _GetCell (this, outlineView, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCell _GetCell (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSCell? ret;
			ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:dataCellForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:viewForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetView (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			return _GetView (this, outlineView, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSView _GetView (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:viewForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:isGroupItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsGroupItem (NSOutlineView outlineView, NSObject item)
		{
			return _IsGroupItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsGroupItem (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:isGroupItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldExpandItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldExpandItem (NSOutlineView outlineView, NSObject item)
		{
			return _ShouldExpandItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldExpandItem (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldExpandItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldCollapseItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCollapseItem (NSOutlineView outlineView, NSObject item)
		{
			return _ShouldCollapseItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldCollapseItem (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldCollapseItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:willDisplayOutlineCell:forTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayOutlineCell (NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			_WillDisplayOutlineCell (this, outlineView, cell, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayOutlineCell (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:willDisplayOutlineCell:forTableColumn:item:"), outlineView__handle__, cell__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
		}
		/// <param name="outlineView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:sizeToFitWidthOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetSizeToFitColumnWidth (NSOutlineView outlineView, nint column)
		{
			return _GetSizeToFitColumnWidth (this, outlineView, column);
		}
		/// <param name="outlineView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetSizeToFitColumnWidth (INSOutlineViewDelegate This, NSOutlineView outlineView, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:sizeToFitWidthOfColumn:"), outlineView__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldReorderColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReorder (NSOutlineView outlineView, nint columnIndex, nint newColumnIndex)
		{
			return _ShouldReorder (this, outlineView, columnIndex, newColumnIndex);
		}
		/// <param name="outlineView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReorder (INSOutlineViewDelegate This, NSOutlineView outlineView, nint columnIndex, nint newColumnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("outlineView:shouldReorderColumn:toColumn:"), outlineView__handle__, columnIndex, newColumnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:shouldShowOutlineCellForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowOutlineCell (NSOutlineView outlineView, NSObject item)
		{
			return _ShouldShowOutlineCell (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowOutlineCell (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldShowOutlineCellForItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewColumnDidMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidMove (NSNotification notification)
		{
			_ColumnDidMove (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ColumnDidMove (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewColumnDidMove:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewColumnDidResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidResize (NSNotification notification)
		{
			_ColumnDidResize (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ColumnDidResize (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewColumnDidResize:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewSelectionIsChanging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionIsChanging (NSNotification notification)
		{
			_SelectionIsChanging (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionIsChanging (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewSelectionIsChanging:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewItemWillExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemWillExpand (NSNotification notification)
		{
			_ItemWillExpand (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemWillExpand (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemWillExpand:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewItemDidExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDidExpand (NSNotification notification)
		{
			_ItemDidExpand (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemDidExpand (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemDidExpand:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewItemWillCollapse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemWillCollapse (NSNotification notification)
		{
			_ItemWillCollapse (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemWillCollapse (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemWillCollapse:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewItemDidCollapse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDidCollapse (NSNotification notification)
		{
			_ItemDidCollapse (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemDidCollapse (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemDidCollapse:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineViewSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (NSNotification notification)
		{
			_SelectionDidChange (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewSelectionDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:rowViewForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableRowView RowViewForItem (NSOutlineView outlineView, NSObject item)
		{
			return _RowViewForItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTableRowView _RowViewForItem (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSTableRowView? ret;
			ret =  Runtime.GetNSObject<NSTableRowView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:rowViewForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:didAddRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRowView (NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			_DidAddRowView (this, outlineView, rowView, row);
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddRowView (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:didAddRowView:forRow:"), outlineView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (rowView);
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:didRemoveRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRowView (NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			_DidRemoveRowView (this, outlineView, rowView, row);
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveRowView (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:didRemoveRowView:forRow:"), outlineView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (rowView);
		}
		[global::Foundation.OptionalMember]
		[Export ("outlineView:tintConfigurationForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTintConfiguration? GetTintConfiguration (NSOutlineView outlineView, NSObject item)
		{
			return _GetTintConfiguration (this, outlineView, item);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTintConfiguration? _GetTintConfiguration (INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSTintConfiguration? ret;
			ret =  Runtime.GetNSObject<NSTintConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:tintConfigurationForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("outlineView:userCanChangeVisibilityOfTableColumn:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserCanChangeVisibility (NSOutlineView outlineView, NSTableColumn column)
		{
			return _UserCanChangeVisibility (this, outlineView, column);
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UserCanChangeVisibility (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var column__handle__ = column!.GetNonNullHandle (nameof (column));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:userCanChangeVisibilityOfTableColumn:"), outlineView__handle__, column__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (column);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("outlineView:userDidChangeVisibilityOfTableColumns:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidChangeVisibility (NSOutlineView outlineView, NSTableColumn[] columns)
		{
			_UserDidChangeVisibility (this, outlineView, columns);
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserDidChangeVisibility (INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn[] columns)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			if (columns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (columns));
			using var nsa_columns = NSArray.FromNSObjects (columns);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:userDidChangeVisibilityOfTableColumns:"), outlineView__handle__, nsa_columns.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
		}
		[DynamicDependencyAttribute ("ColumnDidMove(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ColumnDidResize(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidAddRowView(AppKit.NSOutlineView,AppKit.NSTableRowView,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidClickTableColumn(AppKit.NSOutlineView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("DidDragTableColumn(AppKit.NSOutlineView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("DidRemoveRowView(AppKit.NSOutlineView,AppKit.NSTableRowView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetCell(AppKit.NSOutlineView,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetNextTypeSelectMatch(AppKit.NSOutlineView,Foundation.NSObject,Foundation.NSObject,System.String)")]
		[DynamicDependencyAttribute ("GetRowHeight(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetSelectionIndexes(AppKit.NSOutlineView,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("GetSelectString(AppKit.NSOutlineView,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetSizeToFitColumnWidth(AppKit.NSOutlineView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetTintConfiguration(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetView(AppKit.NSOutlineView,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("IsGroupItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ItemDidCollapse(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ItemDidExpand(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ItemWillCollapse(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ItemWillExpand(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("MouseDown(AppKit.NSOutlineView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("RowViewForItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SelectionDidChange(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("SelectionIsChanging(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("SelectionShouldChange(AppKit.NSOutlineView)")]
		[DynamicDependencyAttribute ("ShouldCollapseItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldEditTableColumn(AppKit.NSOutlineView,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldExpandItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldReorder(AppKit.NSOutlineView,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldSelectItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldSelectTableColumn(AppKit.NSOutlineView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("ShouldShowCellExpansion(AppKit.NSOutlineView,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldShowOutlineCell(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldTrackCell(AppKit.NSOutlineView,AppKit.NSCell,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldTypeSelect(AppKit.NSOutlineView,AppKit.NSEvent,System.String)")]
		[DynamicDependencyAttribute ("ToolTipForCell(AppKit.NSOutlineView,AppKit.NSCell,CoreGraphics.CGRect@,AppKit.NSTableColumn,Foundation.NSObject,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("UserCanChangeVisibility(AppKit.NSOutlineView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("UserDidChangeVisibility(AppKit.NSOutlineView,AppKit.NSTableColumn[])")]
		[DynamicDependencyAttribute ("WillDisplayCell(AppKit.NSOutlineView,Foundation.NSObject,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("WillDisplayOutlineCell(AppKit.NSOutlineView,Foundation.NSObject,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSOutlineViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSOutlineViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSOutlineViewDelegate" /> interface to support all the methods from the NSOutlineViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSOutlineViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSOutlineViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSOutlineViewDelegate_Extensions {
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayCell (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:willDisplayCell:forTableColumn:item:"), outlineView__handle__, cell__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEditTableColumn (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldEditTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SelectionShouldChange (this INSOutlineViewDelegate This, NSOutlineView outlineView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionShouldChangeInOutlineView:"), outlineView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectItem (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldSelectItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet GetSelectionIndexes (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var proposedSelectionIndexes__handle__ = proposedSelectionIndexes!.GetNonNullHandle (nameof (proposedSelectionIndexes));
			NSIndexSet? ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:selectionIndexesForProposedSelection:"), outlineView__handle__, proposedSelectionIndexes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (proposedSelectionIndexes);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectTableColumn (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldSelectTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MouseDown (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:mouseDownInHeaderOfTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClickTableColumn (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:didClickTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDragTableColumn (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:didDragTableColumn:"), outlineView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static string ToolTipForCell (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, NSObject item, CGPoint mouseLocation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			fixed (CGRect* rect__pointer = &rect) {
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_CGRect_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:"), outlineView__handle__, cell__handle__, rect__pointer, tableColumn__handle__, item__handle__, mouseLocation), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
			}
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetRowHeight (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:heightOfRowByItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSelectString (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:typeSelectStringForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="startItem">To be added.</param><param name="endItem">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetNextTypeSelectMatch (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var startItem__handle__ = startItem!.GetNonNullHandle (nameof (startItem));
			var endItem__handle__ = endItem!.GetNonNullHandle (nameof (endItem));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:nextTypeSelectMatchFromItem:toItem:forString:"), outlineView__handle__, startItem__handle__, endItem__handle__, nssearchString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (startItem);
			GC.KeepAlive (endItem);
			CFString.ReleaseNative (nssearchString);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldTypeSelect (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSEvent theEvent, string? searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var nssearchString = CFString.CreateNative (searchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:"), outlineView__handle__, theEvent__handle__, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (theEvent);
			CFString.ReleaseNative (nssearchString);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowCellExpansion (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldShowCellExpansionForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldTrackCell (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSCell cell, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldTrackCell:forTableColumn:item:"), outlineView__handle__, cell__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCell GetCell (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSCell? ret;
			ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:dataCellForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSView GetView (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:viewForTableColumn:item:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsGroupItem (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:isGroupItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldExpandItem (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldExpandItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldCollapseItem (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldCollapseItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayOutlineCell (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:willDisplayOutlineCell:forTableColumn:item:"), outlineView__handle__, cell__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
		}
		/// <param name="outlineView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetSizeToFitColumnWidth (this INSOutlineViewDelegate This, NSOutlineView outlineView, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:sizeToFitWidthOfColumn:"), outlineView__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReorder (this INSOutlineViewDelegate This, NSOutlineView outlineView, nint columnIndex, nint newColumnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("outlineView:shouldReorderColumn:toColumn:"), outlineView__handle__, columnIndex, newColumnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowOutlineCell (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:shouldShowOutlineCellForItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ColumnDidMove (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewColumnDidMove:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ColumnDidResize (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewColumnDidResize:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionIsChanging (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewSelectionIsChanging:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemWillExpand (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemWillExpand:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemDidExpand (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemDidExpand:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemWillCollapse (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemWillCollapse:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemDidCollapse (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewItemDidCollapse:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionDidChange (this INSOutlineViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("outlineViewSelectionDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTableRowView RowViewForItem (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSTableRowView? ret;
			ret =  Runtime.GetNSObject<NSTableRowView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:rowViewForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddRowView (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:didAddRowView:forRow:"), outlineView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (rowView);
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveRowView (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:didRemoveRowView:forRow:"), outlineView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (rowView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTintConfiguration? GetTintConfiguration (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSTintConfiguration? ret;
			ret =  Runtime.GetNSObject<NSTintConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:tintConfigurationForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UserCanChangeVisibility (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var column__handle__ = column!.GetNonNullHandle (nameof (column));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:userCanChangeVisibilityOfTableColumn:"), outlineView__handle__, column__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (column);
			return ret != 0;
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserDidChangeVisibility (this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn[] columns)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			if (columns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (columns));
			using var nsa_columns = NSArray.FromNSObjects (columns);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:userDidChangeVisibilityOfTableColumns:"), outlineView__handle__, nsa_columns.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSOutlineViewDelegateWrapper : BaseWrapper, INSOutlineViewDelegate {
		public NSOutlineViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSOutlineViewDelegateWrapper))]
		static NSOutlineViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSOutlineViewDelegate" /> (for the protocol <c>NSOutlineViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSOutlineViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSOutlineViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSOutlineViewDelegate : NSObject, INSOutlineViewDelegate {
		/// <summary>Creates a new <see cref="NSOutlineViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSOutlineViewDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSOutlineViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSOutlineViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewColumnDidMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidMove (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewColumnDidResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidResize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:didAddRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRowView (NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:didClickTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickTableColumn (NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:didDragTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDragTableColumn (NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:didRemoveRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRowView (NSOutlineView outlineView, NSTableRowView rowView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:dataCellForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell GetCell (NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="startItem">To be added.</param><param name="endItem">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:nextTypeSelectMatchFromItem:toItem:forString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetNextTypeSelectMatch (NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:heightOfRowByItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetRowHeight (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:typeSelectStringForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetSelectString (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:selectionIndexesForProposedSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetSelectionIndexes (NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:sizeToFitWidthOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetSizeToFitColumnWidth (NSOutlineView outlineView, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("outlineView:tintConfigurationForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTintConfiguration? GetTintConfiguration (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:viewForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetView (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:isGroupItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsGroupItem (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewItemDidCollapse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDidCollapse (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewItemDidExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDidExpand (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewItemWillCollapse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemWillCollapse (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewItemWillExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemWillExpand (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:mouseDownInHeaderOfTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDown (NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:rowViewForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableRowView RowViewForItem (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineViewSelectionIsChanging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionIsChanging (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionShouldChangeInOutlineView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectionShouldChange (NSOutlineView outlineView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldCollapseItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCollapseItem (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldEditTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEditTableColumn (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldExpandItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldExpandItem (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldReorderColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReorder (NSOutlineView outlineView, nint columnIndex, nint newColumnIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldSelectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectItem (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldSelectTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectTableColumn (NSOutlineView outlineView, NSTableColumn? tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldShowCellExpansionForTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowCellExpansion (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldShowOutlineCellForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowOutlineCell (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldTrackCell:forTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTrackCell (NSOutlineView outlineView, NSCell cell, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTypeSelect (NSOutlineView outlineView, NSEvent theEvent, string? searchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string ToolTipForCell (NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, NSObject item, CGPoint mouseLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("outlineView:userCanChangeVisibilityOfTableColumn:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserCanChangeVisibility (NSOutlineView outlineView, NSTableColumn column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("outlineView:userDidChangeVisibilityOfTableColumns:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidChangeVisibility (NSOutlineView outlineView, NSTableColumn[] columns)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:willDisplayCell:forTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:willDisplayOutlineCell:forTableColumn:item:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayOutlineCell (NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSOutlineViewDelegate */
}
