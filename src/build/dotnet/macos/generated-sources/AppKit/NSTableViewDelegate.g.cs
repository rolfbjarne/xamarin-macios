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
	/// <summary>This interface represents the Objective-C protocol <c>NSTableViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTableViewDelegate", WrapperType = typeof (NSTableViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "tableView:willDisplayCell:forTableColumn:row:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSObject), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEditTableColumn", Selector = "tableView:shouldEditTableColumn:row:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionShouldChange", Selector = "selectionShouldChangeInTableView:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectRow", Selector = "tableView:shouldSelectRow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectionIndexes", Selector = "tableView:selectionIndexesForProposedSelection:", ReturnType = typeof (NSIndexSet), ParameterType = new Type [] { typeof (NSTableView), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectTableColumn", Selector = "tableView:shouldSelectTableColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MouseDownInHeaderOfTableColumn", Selector = "tableView:mouseDownInHeaderOfTableColumn:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClickTableColumn", Selector = "tableView:didClickTableColumn:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDragTableColumn", Selector = "tableView:didDragTableColumn:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowHeight", Selector = "tableView:heightOfRow:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectString", Selector = "tableView:typeSelectStringForTableColumn:row:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNextTypeSelectMatch", Selector = "tableView:nextTypeSelectMatchFromRow:toRow:forString:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr), typeof (IntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTypeSelect", Selector = "tableView:shouldTypeSelectForEvent:withCurrentSearchString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSEvent), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowCellExpansion", Selector = "tableView:shouldShowCellExpansionForTableColumn:row:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTrackCell", Selector = "tableView:shouldTrackCell:forTableColumn:row:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSCell), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDataCell", Selector = "tableView:dataCellForTableColumn:row:", ReturnType = typeof (NSCell), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsGroupRow", Selector = "tableView:isGroupRow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSizeToFitColumnWidth", Selector = "tableView:sizeToFitWidthOfColumn:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReorder", Selector = "tableView:shouldReorderColumn:toColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "tableViewSelectionDidChange:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidMove", Selector = "tableViewColumnDidMove:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidResize", Selector = "tableViewColumnDidResize:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIsChanging", Selector = "tableViewSelectionIsChanging:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForItem", Selector = "tableView:viewForTableColumn:row:", ReturnType = typeof (NSView), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CoreGetRowView", Selector = "tableView:rowViewForRow:", ReturnType = typeof (NSTableRowView), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddRowView", Selector = "tableView:didAddRowView:forRow:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableRowView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRowView", Selector = "tableView:didRemoveRowView:forRow:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableRowView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowActions", Selector = "tableView:rowActionsForRow:edge:", ReturnType = typeof (NSTableViewRowAction[]), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr), typeof (NSTableRowActionEdge) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetToolTip", Selector = "tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:", ReturnType = typeof (NSString), ParameterType = new Type [] { typeof (NSTableView), typeof (NSCell), typeof (CGRect), typeof (NSTableColumn), typeof (IntPtr), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, true, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserCanChangeVisibility", Selector = "tableView:userCanChangeVisibilityOfTableColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserDidChangeVisibility", Selector = "tableView:userDidChangeVisibilityOfTableColumns:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSTableViewDelegate : INativeObject, IDisposable
	{
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:willDisplayCell:forTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
		{
			_WillDisplayCell (this, tableView, cell, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayCell (INSTableViewDelegate This, NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:willDisplayCell:forTableColumn:row:"), tableView__handle__, cell__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldEditTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEditTableColumn (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return _ShouldEditTableColumn (this, tableView, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEditTableColumn (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldEditTableColumn:row:"), tableView__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("selectionShouldChangeInTableView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectionShouldChange (NSTableView tableView)
		{
			return _SelectionShouldChange (this, tableView);
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SelectionShouldChange (INSTableViewDelegate This, NSTableView tableView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionShouldChangeInTableView:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldSelectRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectRow (NSTableView tableView, nint row)
		{
			return _ShouldSelectRow (this, tableView, row);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectRow (INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldSelectRow:"), tableView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:selectionIndexesForProposedSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetSelectionIndexes (NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			return _GetSelectionIndexes (this, tableView, proposedSelectionIndexes);
		}
		/// <param name="tableView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexSet _GetSelectionIndexes (INSTableViewDelegate This, NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var proposedSelectionIndexes__handle__ = proposedSelectionIndexes!.GetNonNullHandle (nameof (proposedSelectionIndexes));
			NSIndexSet? ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:selectionIndexesForProposedSelection:"), tableView__handle__, proposedSelectionIndexes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (proposedSelectionIndexes);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldSelectTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			return _ShouldSelectTableColumn (this, tableView, tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectTableColumn (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldSelectTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:mouseDownInHeaderOfTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDownInHeaderOfTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			_MouseDownInHeaderOfTableColumn (this, tableView, tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MouseDownInHeaderOfTableColumn (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:mouseDownInHeaderOfTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didClickTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			_DidClickTableColumn (this, tableView, tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidClickTableColumn (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didClickTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didDragTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDragTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			_DidDragTableColumn (this, tableView, tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDragTableColumn (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didDragTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:heightOfRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetRowHeight (NSTableView tableView, nint row)
		{
			return _GetRowHeight (this, tableView, row);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetRowHeight (INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:heightOfRow:"), tableView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:typeSelectStringForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetSelectString (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return _GetSelectString (this, tableView, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSelectString (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:typeSelectStringForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNextTypeSelectMatch (NSTableView tableView, nint startRow, nint endRow, string searchString)
		{
			return _GetNextTypeSelectMatch (this, tableView, startRow, endRow, searchString);
		}
		/// <param name="tableView">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNextTypeSelectMatch (INSTableViewDelegate This, NSTableView tableView, nint startRow, nint endRow, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("tableView:nextTypeSelectMatchFromRow:toRow:forString:"), tableView__handle__, startRow, endRow, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			CFString.ReleaseNative (nssearchString);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldTypeSelectForEvent:withCurrentSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTypeSelect (NSTableView tableView, NSEvent theEvent, string searchString)
		{
			return _ShouldTypeSelect (this, tableView, theEvent, searchString);
		}
		/// <param name="tableView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldTypeSelect (INSTableViewDelegate This, NSTableView tableView, NSEvent theEvent, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldTypeSelectForEvent:withCurrentSearchString:"), tableView__handle__, theEvent__handle__, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (theEvent);
			CFString.ReleaseNative (nssearchString);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldShowCellExpansionForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowCellExpansion (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return _ShouldShowCellExpansion (this, tableView, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowCellExpansion (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldShowCellExpansionForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldTrackCell:forTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTrackCell (NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
		{
			return _ShouldTrackCell (this, tableView, cell, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldTrackCell (INSTableViewDelegate This, NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldTrackCell:forTableColumn:row:"), tableView__handle__, cell__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dataCellForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell GetDataCell (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return _GetDataCell (this, tableView, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCell _GetDataCell (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSCell? ret;
			ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:dataCellForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:isGroupRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsGroupRow (NSTableView tableView, nint row)
		{
			return _IsGroupRow (this, tableView, row);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsGroupRow (INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:isGroupRow:"), tableView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:sizeToFitWidthOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetSizeToFitColumnWidth (NSTableView tableView, nint column)
		{
			return _GetSizeToFitColumnWidth (this, tableView, column);
		}
		/// <param name="tableView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetSizeToFitColumnWidth (INSTableViewDelegate This, NSTableView tableView, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:sizeToFitWidthOfColumn:"), tableView__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:shouldReorderColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReorder (NSTableView tableView, nint columnIndex, nint newColumnIndex)
		{
			return _ShouldReorder (this, tableView, columnIndex, newColumnIndex);
		}
		/// <param name="tableView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReorder (INSTableViewDelegate This, NSTableView tableView, nint columnIndex, nint newColumnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldReorderColumn:toColumn:"), tableView__handle__, columnIndex, newColumnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableViewSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (NSNotification notification)
		{
			_SelectionDidChange (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewSelectionDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableViewColumnDidMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidMove (NSNotification notification)
		{
			_ColumnDidMove (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ColumnDidMove (INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewColumnDidMove:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableViewColumnDidResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidResize (NSNotification notification)
		{
			_ColumnDidResize (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ColumnDidResize (INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewColumnDidResize:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableViewSelectionIsChanging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionIsChanging (NSNotification notification)
		{
			_SelectionIsChanging (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionIsChanging (INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewSelectionIsChanging:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:viewForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetViewForItem (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return _GetViewForItem (this, tableView, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSView _GetViewForItem (INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:viewForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:rowViewForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableRowView CoreGetRowView (NSTableView tableView, nint row)
		{
			return _CoreGetRowView (this, tableView, row);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTableRowView _CoreGetRowView (INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSTableRowView? ret;
			ret =  Runtime.GetNSObject<NSTableRowView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:rowViewForRow:"), tableView__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didAddRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRowView (NSTableView tableView, NSTableRowView rowView, nint row)
		{
			_DidAddRowView (this, tableView, rowView, row);
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddRowView (INSTableViewDelegate This, NSTableView tableView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didAddRowView:forRow:"), tableView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowView);
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:didRemoveRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRowView (NSTableView tableView, NSTableRowView rowView, nint row)
		{
			_DidRemoveRowView (this, tableView, rowView, row);
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveRowView (INSTableViewDelegate This, NSTableView tableView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didRemoveRowView:forRow:"), tableView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowView);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><param name="edge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:rowActionsForRow:edge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewRowAction[] RowActions (NSTableView tableView, nint row, NSTableRowActionEdge edge)
		{
			return _RowActions (this, tableView, row, edge);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><param name="edge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTableViewRowAction[] _RowActions (INSTableViewDelegate This, NSTableView tableView, nint row, NSTableRowActionEdge edge)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSTableViewRowAction[]? ret;
			ret = CFArray.ArrayFromHandle<NSTableViewRowAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tableView:rowActionsForRow:edge:"), tableView__handle__, row, (IntPtr) (long) edge), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSString GetToolTip (NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
		{
			return _GetToolTip (this, tableView, cell, ref rect, tableColumn, row, mouseLocation);
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSString _GetToolTip (INSTableViewDelegate This, NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			fixed (CGRect* rect__pointer = &rect) {
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_CGRect_NativeHandle_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:"), tableView__handle__, cell__handle__, rect__pointer, tableColumn__handle__, row, mouseLocation), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			return ret!;
			}
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:userCanChangeVisibilityOfTableColumn:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserCanChangeVisibility (NSTableView tableView, NSTableColumn column)
		{
			return _UserCanChangeVisibility (this, tableView, column);
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UserCanChangeVisibility (INSTableViewDelegate This, NSTableView tableView, NSTableColumn column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var column__handle__ = column!.GetNonNullHandle (nameof (column));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:userCanChangeVisibilityOfTableColumn:"), tableView__handle__, column__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (column);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:userDidChangeVisibilityOfTableColumns:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidChangeVisibility (NSTableView tableView, NSTableColumn[] columns)
		{
			_UserDidChangeVisibility (this, tableView, columns);
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserDidChangeVisibility (INSTableViewDelegate This, NSTableView tableView, NSTableColumn[] columns)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (columns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (columns));
			using var nsa_columns = NSArray.FromNSObjects (columns);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:userDidChangeVisibilityOfTableColumns:"), tableView__handle__, nsa_columns.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		[DynamicDependencyAttribute ("ColumnDidMove(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ColumnDidResize(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("CoreGetRowView(AppKit.NSTableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidAddRowView(AppKit.NSTableView,AppKit.NSTableRowView,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidClickTableColumn(AppKit.NSTableView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("DidDragTableColumn(AppKit.NSTableView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("DidRemoveRowView(AppKit.NSTableView,AppKit.NSTableRowView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetDataCell(AppKit.NSTableView,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetNextTypeSelectMatch(AppKit.NSTableView,System.IntPtr,System.IntPtr,System.String)")]
		[DynamicDependencyAttribute ("GetRowHeight(AppKit.NSTableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetSelectionIndexes(AppKit.NSTableView,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("GetSelectString(AppKit.NSTableView,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetSizeToFitColumnWidth(AppKit.NSTableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetToolTip(AppKit.NSTableView,AppKit.NSCell,CoreGraphics.CGRect@,AppKit.NSTableColumn,System.IntPtr,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetViewForItem(AppKit.NSTableView,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("IsGroupRow(AppKit.NSTableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("MouseDownInHeaderOfTableColumn(AppKit.NSTableView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("RowActions(AppKit.NSTableView,System.IntPtr,AppKit.NSTableRowActionEdge)")]
		[DynamicDependencyAttribute ("SelectionDidChange(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("SelectionIsChanging(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("SelectionShouldChange(AppKit.NSTableView)")]
		[DynamicDependencyAttribute ("ShouldEditTableColumn(AppKit.NSTableView,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldReorder(AppKit.NSTableView,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldSelectRow(AppKit.NSTableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldSelectTableColumn(AppKit.NSTableView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("ShouldShowCellExpansion(AppKit.NSTableView,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldTrackCell(AppKit.NSTableView,AppKit.NSCell,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldTypeSelect(AppKit.NSTableView,AppKit.NSEvent,System.String)")]
		[DynamicDependencyAttribute ("UserCanChangeVisibility(AppKit.NSTableView,AppKit.NSTableColumn)")]
		[DynamicDependencyAttribute ("UserDidChangeVisibility(AppKit.NSTableView,AppKit.NSTableColumn[])")]
		[DynamicDependencyAttribute ("WillDisplayCell(AppKit.NSTableView,Foundation.NSObject,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTableViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTableViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTableViewDelegate" /> interface to support all the methods from the NSTableViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTableViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTableViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTableViewDelegate_Extensions {
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayCell (this INSTableViewDelegate This, NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:willDisplayCell:forTableColumn:row:"), tableView__handle__, cell__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEditTableColumn (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldEditTableColumn:row:"), tableView__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SelectionShouldChange (this INSTableViewDelegate This, NSTableView tableView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionShouldChangeInTableView:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectRow (this INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldSelectRow:"), tableView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet GetSelectionIndexes (this INSTableViewDelegate This, NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var proposedSelectionIndexes__handle__ = proposedSelectionIndexes!.GetNonNullHandle (nameof (proposedSelectionIndexes));
			NSIndexSet? ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:selectionIndexesForProposedSelection:"), tableView__handle__, proposedSelectionIndexes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (proposedSelectionIndexes);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectTableColumn (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldSelectTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MouseDownInHeaderOfTableColumn (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:mouseDownInHeaderOfTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClickTableColumn (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didClickTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDragTableColumn (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:didDragTableColumn:"), tableView__handle__, tableColumn__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetRowHeight (this INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:heightOfRow:"), tableView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSelectString (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:typeSelectStringForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetNextTypeSelectMatch (this INSTableViewDelegate This, NSTableView tableView, nint startRow, nint endRow, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("tableView:nextTypeSelectMatchFromRow:toRow:forString:"), tableView__handle__, startRow, endRow, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			CFString.ReleaseNative (nssearchString);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldTypeSelect (this INSTableViewDelegate This, NSTableView tableView, NSEvent theEvent, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:shouldTypeSelectForEvent:withCurrentSearchString:"), tableView__handle__, theEvent__handle__, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (theEvent);
			CFString.ReleaseNative (nssearchString);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowCellExpansion (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldShowCellExpansionForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldTrackCell (this INSTableViewDelegate This, NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldTrackCell:forTableColumn:row:"), tableView__handle__, cell__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCell GetDataCell (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSCell? ret;
			ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:dataCellForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsGroupRow (this INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:isGroupRow:"), tableView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetSizeToFitColumnWidth (this INSTableViewDelegate This, NSTableView tableView, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:sizeToFitWidthOfColumn:"), tableView__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReorder (this INSTableViewDelegate This, NSTableView tableView, nint columnIndex, nint newColumnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tableView:shouldReorderColumn:toColumn:"), tableView__handle__, columnIndex, newColumnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret != 0;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionDidChange (this INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewSelectionDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ColumnDidMove (this INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewColumnDidMove:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ColumnDidResize (this INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewColumnDidResize:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionIsChanging (this INSTableViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tableViewSelectionIsChanging:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSView GetViewForItem (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:viewForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTableRowView CoreGetRowView (this INSTableViewDelegate This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSTableRowView? ret;
			ret =  Runtime.GetNSObject<NSTableRowView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:rowViewForRow:"), tableView__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddRowView (this INSTableViewDelegate This, NSTableView tableView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didAddRowView:forRow:"), tableView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowView);
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveRowView (this INSTableViewDelegate This, NSTableView tableView, NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:didRemoveRowView:forRow:"), tableView__handle__, rowView__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowView);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><param name="edge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTableViewRowAction[] RowActions (this INSTableViewDelegate This, NSTableView tableView, nint row, NSTableRowActionEdge edge)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSTableViewRowAction[]? ret;
			ret = CFArray.ArrayFromHandle<NSTableViewRowAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tableView:rowActionsForRow:edge:"), tableView__handle__, row, (IntPtr) (long) edge), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSString GetToolTip (this INSTableViewDelegate This, NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			fixed (CGRect* rect__pointer = &rect) {
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_CGRect_NativeHandle_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:"), tableView__handle__, cell__handle__, rect__pointer, tableColumn__handle__, row, mouseLocation), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (tableColumn);
			return ret!;
			}
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UserCanChangeVisibility (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var column__handle__ = column!.GetNonNullHandle (nameof (column));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:userCanChangeVisibilityOfTableColumn:"), tableView__handle__, column__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (column);
			return ret != 0;
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserDidChangeVisibility (this INSTableViewDelegate This, NSTableView tableView, NSTableColumn[] columns)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (columns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (columns));
			using var nsa_columns = NSArray.FromNSObjects (columns);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:userDidChangeVisibilityOfTableColumns:"), tableView__handle__, nsa_columns.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTableViewDelegateWrapper : BaseWrapper, INSTableViewDelegate {
		public NSTableViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTableViewDelegateWrapper))]
		static NSTableViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTableViewDelegate" /> (for the protocol <c>NSTableViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTableViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTableViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTableViewDelegate : NSObject, INSTableViewDelegate {
		/// <summary>Creates a new <see cref="NSTableViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTableViewDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTableViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTableViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableViewColumnDidMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidMove (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableViewColumnDidResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnDidResize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:rowViewForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableRowView CoreGetRowView (NSTableView tableView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didAddRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRowView (NSTableView tableView, NSTableRowView rowView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didClickTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didDragTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDragTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="rowView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didRemoveRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRowView (NSTableView tableView, NSTableRowView rowView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:dataCellForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell GetDataCell (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNextTypeSelectMatch (NSTableView tableView, nint startRow, nint endRow, string searchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:heightOfRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetRowHeight (NSTableView tableView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:typeSelectStringForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetSelectString (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:selectionIndexesForProposedSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetSelectionIndexes (NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:sizeToFitWidthOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetSizeToFitColumnWidth (NSTableView tableView, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="rect">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><param name="mouseLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSString GetToolTip (NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:viewForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetViewForItem (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:isGroupRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsGroupRow (NSTableView tableView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:mouseDownInHeaderOfTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDownInHeaderOfTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><param name="edge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:rowActionsForRow:edge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewRowAction[] RowActions (NSTableView tableView, nint row, NSTableRowActionEdge edge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableViewSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableViewSelectionIsChanging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionIsChanging (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionShouldChangeInTableView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectionShouldChange (NSTableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldEditTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEditTableColumn (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="columnIndex">To be added.</param><param name="newColumnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldReorderColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReorder (NSTableView tableView, nint columnIndex, nint newColumnIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldSelectRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectRow (NSTableView tableView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldSelectTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldShowCellExpansionForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowCellExpansion (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldTrackCell:forTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTrackCell (NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="theEvent">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldTypeSelectForEvent:withCurrentSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTypeSelect (NSTableView tableView, NSEvent theEvent, string searchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:userCanChangeVisibilityOfTableColumn:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserCanChangeVisibility (NSTableView tableView, NSTableColumn column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:userDidChangeVisibilityOfTableColumns:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidChangeVisibility (NSTableView tableView, NSTableColumn[] columns)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="cell">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:willDisplayCell:forTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTableViewDelegate */
}
