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
	/// <summary>This interface represents the Objective-C protocol <c>NSTableViewDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTableViewDataSource", WrapperType = typeof (NSTableViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowCount", Selector = "numberOfRowsInTableView:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSTableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetObjectValue", Selector = "tableView:objectValueForTableColumn:row:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSTableView), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetObjectValue", Selector = "tableView:setObjectValue:forTableColumn:row:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSObject), typeof (NSTableColumn), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SortDescriptorsChanged", Selector = "tableView:sortDescriptorsDidChange:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSSortDescriptor[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRows", Selector = "tableView:writeRowsWithIndexes:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (NSIndexSet), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "tableView:validateDrop:proposedRow:proposedDropOperation:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (NSTableView), typeof (INSDraggingInfo), typeof (IntPtr), typeof (NSTableViewDropOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "tableView:acceptDrop:row:dropOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTableView), typeof (INSDraggingInfo), typeof (IntPtr), typeof (NSTableViewDropOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FilesDropped", Selector = "tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSTableView), typeof (NSUrl), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPasteboardWriterForRow", Selector = "tableView:pasteboardWriterForRow:", ReturnType = typeof (INSPasteboardWriting), ParameterType = new Type [] { typeof (NSTableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "tableView:draggingSession:willBeginAtPoint:forRowIndexes:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionEnded", Selector = "tableView:draggingSession:endedAtPoint:operation:", ParameterType = new Type [] { typeof (NSTableView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSDragOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDraggingItems", Selector = "tableView:updateDraggingItemsForDrag:", ParameterType = new Type [] { typeof (NSTableView), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSTableViewDataSource : INativeObject, IDisposable
	{
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfRowsInTableView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowCount (NSTableView tableView)
		{
			return _GetRowCount (this, tableView);
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetRowCount (INSTableViewDataSource This, NSTableView tableView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfRowsInTableView:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:objectValueForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetObjectValue (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return _GetObjectValue (this, tableView, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetObjectValue (INSTableViewDataSource This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:objectValueForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:setObjectValue:forTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
		{
			_SetObjectValue (this, tableView, theObject, tableColumn, row);
		}
		/// <param name="tableView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectValue (INSTableViewDataSource This, NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var theObject__handle__ = theObject!.GetNonNullHandle (nameof (theObject));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:setObjectValue:forTableColumn:row:"), tableView__handle__, theObject__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (theObject);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:sortDescriptorsDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SortDescriptorsChanged (NSTableView tableView, NSSortDescriptor[] oldDescriptors)
		{
			_SortDescriptorsChanged (this, tableView, oldDescriptors);
		}
		/// <param name="tableView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SortDescriptorsChanged (INSTableViewDataSource This, NSTableView tableView, NSSortDescriptor[] oldDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (oldDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldDescriptors));
			using var nsa_oldDescriptors = NSArray.FromNSObjects (oldDescriptors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:sortDescriptorsDidChange:"), tableView__handle__, nsa_oldDescriptors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		/// <param name="tableView">To be added.</param><param name="rowIndexes">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:writeRowsWithIndexes:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriterForRow' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRows (NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
		{
			return _WriteRows (this, tableView, rowIndexes, pboard);
		}
		/// <param name="tableView">To be added.</param><param name="rowIndexes">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriterForRow' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteRows (INSTableViewDataSource This, NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:writeRowsWithIndexes:toPasteboard:"), tableView__handle__, rowIndexes__handle__, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:validateDrop:proposedRow:proposedDropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			return _ValidateDrop (this, tableView, info, row, dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _ValidateDrop (INSTableViewDataSource This, NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("tableView:validateDrop:proposedRow:proposedDropOperation:"), tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (info);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:acceptDrop:row:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			return _AcceptDrop (this, tableView, info, row, dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AcceptDrop (INSTableViewDataSource This, NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("tableView:acceptDrop:row:dropOperation:"), tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (info);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="dropDestination">To be added.</param><param name="indexSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] FilesDropped (NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
		{
			return _FilesDropped (this, tableView, dropDestination, indexSet);
		}
		/// <param name="tableView">To be added.</param><param name="dropDestination">To be added.</param><param name="indexSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _FilesDropped (INSTableViewDataSource This, NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:"), tableView__handle__, dropDestination__handle__, indexSet__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (indexSet);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:pasteboardWriterForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting GetPasteboardWriterForRow (NSTableView tableView, nint row)
		{
			return _GetPasteboardWriterForRow (this, tableView, row);
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSPasteboardWriting _GetPasteboardWriterForRow (INSTableViewDataSource This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:pasteboardWriterForRow:"), tableView__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="willBeginAtScreenPoint">To be added.</param><param name="rowIndexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:draggingSession:willBeginAtPoint:forRowIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
		{
			_DraggingSessionWillBegin (this, tableView, draggingSession, willBeginAtScreenPoint, rowIndexes);
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="willBeginAtScreenPoint">To be added.</param><param name="rowIndexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionWillBegin (INSTableViewDataSource This, NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("tableView:draggingSession:willBeginAtPoint:forRowIndexes:"), tableView__handle__, draggingSession__handle__, willBeginAtScreenPoint, rowIndexes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingSession);
			GC.KeepAlive (rowIndexes);
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="endedAtScreenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:draggingSession:endedAtPoint:operation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
		{
			_DraggingSessionEnded (this, tableView, draggingSession, endedAtScreenPoint, operation);
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="endedAtScreenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionEnded (INSTableViewDataSource This, NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("tableView:draggingSession:endedAtPoint:operation:"), tableView__handle__, draggingSession__handle__, endedAtScreenPoint, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingSession);
		}
		[global::Foundation.OptionalMember]
		[Export ("tableView:updateDraggingItemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItems (NSTableView tableView, INSDraggingInfo draggingInfo)
		{
			_UpdateDraggingItems (this, tableView, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateDraggingItems (INSTableViewDataSource This, NSTableView tableView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:updateDraggingItemsForDrag:"), tableView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingInfo);
		}
		[DynamicDependencyAttribute ("AcceptDrop(AppKit.NSTableView,AppKit.INSDraggingInfo,System.IntPtr,AppKit.NSTableViewDropOperation)")]
		[DynamicDependencyAttribute ("DraggingSessionEnded(AppKit.NSTableView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,AppKit.NSDragOperation)")]
		[DynamicDependencyAttribute ("DraggingSessionWillBegin(AppKit.NSTableView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("FilesDropped(AppKit.NSTableView,Foundation.NSUrl,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("GetObjectValue(AppKit.NSTableView,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetPasteboardWriterForRow(AppKit.NSTableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetRowCount(AppKit.NSTableView)")]
		[DynamicDependencyAttribute ("SetObjectValue(AppKit.NSTableView,Foundation.NSObject,AppKit.NSTableColumn,System.IntPtr)")]
		[DynamicDependencyAttribute ("SortDescriptorsChanged(AppKit.NSTableView,Foundation.NSSortDescriptor[])")]
		[DynamicDependencyAttribute ("UpdateDraggingItems(AppKit.NSTableView,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("ValidateDrop(AppKit.NSTableView,AppKit.INSDraggingInfo,System.IntPtr,AppKit.NSTableViewDropOperation)")]
		[DynamicDependencyAttribute ("WriteRows(AppKit.NSTableView,Foundation.NSIndexSet,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTableViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTableViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTableViewDataSource" /> interface to support all the methods from the NSTableViewDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTableViewDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTableViewDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTableViewDataSource_Extensions {
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetRowCount (this INSTableViewDataSource This, NSTableView tableView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfRowsInTableView:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetObjectValue (this INSTableViewDataSource This, NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:objectValueForTableColumn:row:"), tableView__handle__, tableColumn__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectValue (this INSTableViewDataSource This, NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var theObject__handle__ = theObject!.GetNonNullHandle (nameof (theObject));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:setObjectValue:forTableColumn:row:"), tableView__handle__, theObject__handle__, tableColumn__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (theObject);
			GC.KeepAlive (tableColumn);
		}
		/// <param name="tableView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SortDescriptorsChanged (this INSTableViewDataSource This, NSTableView tableView, NSSortDescriptor[] oldDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (oldDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldDescriptors));
			using var nsa_oldDescriptors = NSArray.FromNSObjects (oldDescriptors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:sortDescriptorsDidChange:"), tableView__handle__, nsa_oldDescriptors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		/// <param name="tableView">To be added.</param><param name="rowIndexes">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriterForRow' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteRows (this INSTableViewDataSource This, NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:writeRowsWithIndexes:toPasteboard:"), tableView__handle__, rowIndexes__handle__, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDragOperation ValidateDrop (this INSTableViewDataSource This, NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("tableView:validateDrop:proposedRow:proposedDropOperation:"), tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (info);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptDrop (this INSTableViewDataSource This, NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("tableView:acceptDrop:row:dropOperation:"), tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (info);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="dropDestination">To be added.</param><param name="indexSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] FilesDropped (this INSTableViewDataSource This, NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:"), tableView__handle__, dropDestination__handle__, indexSet__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (indexSet);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSPasteboardWriting GetPasteboardWriterForRow (this INSTableViewDataSource This, NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:pasteboardWriterForRow:"), tableView__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="willBeginAtScreenPoint">To be added.</param><param name="rowIndexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionWillBegin (this INSTableViewDataSource This, NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("tableView:draggingSession:willBeginAtPoint:forRowIndexes:"), tableView__handle__, draggingSession__handle__, willBeginAtScreenPoint, rowIndexes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingSession);
			GC.KeepAlive (rowIndexes);
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="endedAtScreenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionEnded (this INSTableViewDataSource This, NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("tableView:draggingSession:endedAtPoint:operation:"), tableView__handle__, draggingSession__handle__, endedAtScreenPoint, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingSession);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateDraggingItems (this INSTableViewDataSource This, NSTableView tableView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:updateDraggingItemsForDrag:"), tableView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingInfo);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTableViewDataSourceWrapper : BaseWrapper, INSTableViewDataSource {
		public NSTableViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTableViewDataSourceWrapper))]
		static NSTableViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTableViewDataSource" /> (for the protocol <c>NSTableViewDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTableViewDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTableViewDataSource", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTableViewDataSource : NSObject, INSTableViewDataSource {
		/// <summary>Creates a new <see cref="NSTableViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTableViewDataSource () : base (NSObjectFlag.Empty)
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
		protected NSTableViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal NSTableViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("tableView:acceptDrop:row:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="endedAtScreenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:draggingSession:endedAtPoint:operation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="willBeginAtScreenPoint">To be added.</param><param name="rowIndexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:draggingSession:willBeginAtPoint:forRowIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="dropDestination">To be added.</param><param name="indexSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] FilesDropped (NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:objectValueForTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetObjectValue (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:pasteboardWriterForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting GetPasteboardWriterForRow (NSTableView tableView, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfRowsInTableView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowCount (NSTableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:setObjectValue:forTableColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:sortDescriptorsDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SortDescriptorsChanged (NSTableView tableView, NSSortDescriptor[] oldDescriptors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:updateDraggingItemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItems (NSTableView tableView, INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tableView:validateDrop:proposedRow:proposedDropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="rowIndexes">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:writeRowsWithIndexes:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriterForRow' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRows (NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTableViewDataSource */
}
