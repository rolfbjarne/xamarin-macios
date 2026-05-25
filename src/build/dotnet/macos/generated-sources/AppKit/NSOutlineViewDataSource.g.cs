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
	/// <summary>This interface represents the Objective-C protocol <c>NSOutlineViewDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSOutlineViewDataSource", WrapperType = typeof (NSOutlineViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChild", Selector = "outlineView:child:ofItem:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSOutlineView), typeof (IntPtr), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemExpandable", Selector = "outlineView:isItemExpandable:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChildrenCount", Selector = "outlineView:numberOfChildrenOfItem:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetObjectValue", Selector = "outlineView:objectValueForTableColumn:byItem:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetObjectValue", Selector = "outlineView:setObjectValue:forTableColumn:byItem:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject), typeof (NSTableColumn), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemForPersistentObject", Selector = "outlineView:itemForPersistentObject:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PersistentObjectForItem", Selector = "outlineView:persistentObjectForItem:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SortDescriptorsChanged", Selector = "outlineView:sortDescriptorsDidChange:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSSortDescriptor[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OutlineViewwriteItemstoPasteboard", Selector = "outlineView:writeItems:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSArray), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "outlineView:validateDrop:proposedItem:proposedChildIndex:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (NSOutlineView), typeof (INSDraggingInfo), typeof (NSObject), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "outlineView:acceptDrop:item:childIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSOutlineView), typeof (INSDraggingInfo), typeof (NSObject), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FilesDropped", Selector = "outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSUrl), typeof (NSArray) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteboardWriterForItem", Selector = "outlineView:pasteboardWriterForItem:", ReturnType = typeof (INSPasteboardWriting), ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "outlineView:draggingSession:willBeginAtPoint:forItems:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSArray) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionEnded", Selector = "outlineView:draggingSession:endedAtPoint:operation:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSDragOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDraggingItemsForDrag", Selector = "outlineView:updateDraggingItemsForDrag:", ParameterType = new Type [] { typeof (NSOutlineView), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSOutlineViewDataSource : INativeObject, IDisposable
	{
		/// <param name="outlineView">To be added.</param><param name="childIndex">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:child:ofItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetChild (NSOutlineView outlineView, nint childIndex, NSObject? item)
		{
			return _GetChild (this, outlineView, childIndex, item);
		}
		/// <param name="outlineView">To be added.</param><param name="childIndex">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetChild (INSOutlineViewDataSource This, NSOutlineView outlineView, nint childIndex, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:child:ofItem:"), outlineView__handle__, childIndex, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:isItemExpandable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ItemExpandable (NSOutlineView outlineView, NSObject item)
		{
			return _ItemExpandable (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ItemExpandable (INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:isItemExpandable:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:numberOfChildrenOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetChildrenCount (NSOutlineView outlineView, NSObject? item)
		{
			return _GetChildrenCount (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetChildrenCount (INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item.GetHandle ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:numberOfChildrenOfItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:objectValueForTableColumn:byItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetObjectValue (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject? item)
		{
			return _GetObjectValue (this, outlineView, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetObjectValue (INSOutlineViewDataSource This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:objectValueForTableColumn:byItem:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:setObjectValue:forTableColumn:byItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSOutlineView outlineView, NSObject? theObject, NSTableColumn? tableColumn, NSObject? item)
		{
			_SetObjectValue (this, outlineView, theObject, tableColumn, item);
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectValue (INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? theObject, NSTableColumn? tableColumn, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var theObject__handle__ = theObject.GetHandle ();
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:setObjectValue:forTableColumn:byItem:"), outlineView__handle__, theObject__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (theObject);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:itemForPersistentObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ItemForPersistentObject (NSOutlineView outlineView, NSObject theObject)
		{
			return _ItemForPersistentObject (this, outlineView, theObject);
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _ItemForPersistentObject (INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject theObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var theObject__handle__ = theObject!.GetNonNullHandle (nameof (theObject));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:itemForPersistentObject:"), outlineView__handle__, theObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (theObject);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:persistentObjectForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PersistentObjectForItem (NSOutlineView outlineView, NSObject? item)
		{
			return _PersistentObjectForItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _PersistentObjectForItem (INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:persistentObjectForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:sortDescriptorsDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SortDescriptorsChanged (NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
		{
			_SortDescriptorsChanged (this, outlineView, oldDescriptors);
		}
		/// <param name="outlineView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SortDescriptorsChanged (INSOutlineViewDataSource This, NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			if (oldDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldDescriptors));
			using var nsa_oldDescriptors = NSArray.FromNSObjects (oldDescriptors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:sortDescriptorsDidChange:"), outlineView__handle__, nsa_oldDescriptors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
		}
		/// <param name="outlineView">To be added.</param><param name="items">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:writeItems:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OutlineViewwriteItemstoPasteboard (NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
		{
			return _OutlineViewwriteItemstoPasteboard (this, outlineView, items, pboard);
		}
		/// <param name="outlineView">To be added.</param><param name="items">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _OutlineViewwriteItemstoPasteboard (INSOutlineViewDataSource This, NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var items__handle__ = items!.GetNonNullHandle (nameof (items));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:writeItems:toPasteboard:"), outlineView__handle__, items__handle__, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (items);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("outlineView:validateDrop:proposedItem:proposedChildIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			return _ValidateDrop (this, outlineView, info, item, index);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _ValidateDrop (INSOutlineViewDataSource This, NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			var item__handle__ = item.GetHandle ();
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:validateDrop:proposedItem:proposedChildIndex:"), outlineView__handle__, info__handle__, item__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (info);
			GC.KeepAlive (item);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("outlineView:acceptDrop:item:childIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			return _AcceptDrop (this, outlineView, info, item, index);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AcceptDrop (INSOutlineViewDataSource This, NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			var item__handle__ = item.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:acceptDrop:item:childIndex:"), outlineView__handle__, info__handle__, item__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (info);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="dropDestination">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] FilesDropped (NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
		{
			return _FilesDropped (this, outlineView, dropDestination, items);
		}
		/// <param name="outlineView">To be added.</param><param name="dropDestination">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _FilesDropped (INSOutlineViewDataSource This, NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var items__handle__ = items!.GetNonNullHandle (nameof (items));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:"), outlineView__handle__, dropDestination__handle__, items__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (items);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:pasteboardWriterForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting PasteboardWriterForItem (NSOutlineView outlineView, NSObject item)
		{
			return _PasteboardWriterForItem (this, outlineView, item);
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSPasteboardWriting _PasteboardWriterForItem (INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:pasteboardWriterForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="draggedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:draggingSession:willBeginAtPoint:forItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSArray draggedItems)
		{
			_DraggingSessionWillBegin (this, outlineView, session, screenPoint, draggedItems);
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="draggedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionWillBegin (INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSArray draggedItems)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var draggedItems__handle__ = draggedItems!.GetNonNullHandle (nameof (draggedItems));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:draggingSession:willBeginAtPoint:forItems:"), outlineView__handle__, session__handle__, screenPoint, draggedItems__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (session);
			GC.KeepAlive (draggedItems);
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("outlineView:draggingSession:endedAtPoint:operation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSDragOperation operation)
		{
			_DraggingSessionEnded (this, outlineView, session, screenPoint, operation);
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionEnded (INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("outlineView:draggingSession:endedAtPoint:operation:"), outlineView__handle__, session__handle__, screenPoint, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("outlineView:updateDraggingItemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItemsForDrag (NSOutlineView outlineView, INSDraggingInfo draggingInfo)
		{
			_UpdateDraggingItemsForDrag (this, outlineView, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateDraggingItemsForDrag (INSOutlineViewDataSource This, NSOutlineView outlineView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:updateDraggingItemsForDrag:"), outlineView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (draggingInfo);
		}
		[DynamicDependencyAttribute ("AcceptDrop(AppKit.NSOutlineView,AppKit.INSDraggingInfo,Foundation.NSObject,System.IntPtr)")]
		[DynamicDependencyAttribute ("DraggingSessionEnded(AppKit.NSOutlineView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,AppKit.NSDragOperation)")]
		[DynamicDependencyAttribute ("DraggingSessionWillBegin(AppKit.NSOutlineView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,Foundation.NSArray)")]
		[DynamicDependencyAttribute ("FilesDropped(AppKit.NSOutlineView,Foundation.NSUrl,Foundation.NSArray)")]
		[DynamicDependencyAttribute ("GetChild(AppKit.NSOutlineView,System.IntPtr,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetChildrenCount(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetObjectValue(AppKit.NSOutlineView,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ItemExpandable(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ItemForPersistentObject(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("OutlineViewwriteItemstoPasteboard(AppKit.NSOutlineView,Foundation.NSArray,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("PasteboardWriterForItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PersistentObjectForItem(AppKit.NSOutlineView,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SetObjectValue(AppKit.NSOutlineView,Foundation.NSObject,AppKit.NSTableColumn,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SortDescriptorsChanged(AppKit.NSOutlineView,Foundation.NSSortDescriptor[])")]
		[DynamicDependencyAttribute ("UpdateDraggingItemsForDrag(AppKit.NSOutlineView,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("ValidateDrop(AppKit.NSOutlineView,AppKit.INSDraggingInfo,Foundation.NSObject,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSOutlineViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSOutlineViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSOutlineViewDataSource" /> interface to support all the methods from the NSOutlineViewDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSOutlineViewDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSOutlineViewDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSOutlineViewDataSource_Extensions {
		/// <param name="outlineView">To be added.</param><param name="childIndex">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetChild (this INSOutlineViewDataSource This, NSOutlineView outlineView, nint childIndex, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:child:ofItem:"), outlineView__handle__, childIndex, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ItemExpandable (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:isItemExpandable:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetChildrenCount (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item.GetHandle ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:numberOfChildrenOfItem:"), outlineView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetObjectValue (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:objectValueForTableColumn:byItem:"), outlineView__handle__, tableColumn__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectValue (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? theObject, NSTableColumn? tableColumn, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var theObject__handle__ = theObject.GetHandle ();
			var tableColumn__handle__ = tableColumn.GetHandle ();
			var item__handle__ = item.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:setObjectValue:forTableColumn:byItem:"), outlineView__handle__, theObject__handle__, tableColumn__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (theObject);
			GC.KeepAlive (tableColumn);
			GC.KeepAlive (item);
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ItemForPersistentObject (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject theObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var theObject__handle__ = theObject!.GetNonNullHandle (nameof (theObject));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:itemForPersistentObject:"), outlineView__handle__, theObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (theObject);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject PersistentObjectForItem (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:persistentObjectForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SortDescriptorsChanged (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			if (oldDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldDescriptors));
			using var nsa_oldDescriptors = NSArray.FromNSObjects (oldDescriptors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:sortDescriptorsDidChange:"), outlineView__handle__, nsa_oldDescriptors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
		}
		/// <param name="outlineView">To be added.</param><param name="items">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OutlineViewwriteItemstoPasteboard (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var items__handle__ = items!.GetNonNullHandle (nameof (items));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:writeItems:toPasteboard:"), outlineView__handle__, items__handle__, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (items);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDragOperation ValidateDrop (this INSOutlineViewDataSource This, NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			var item__handle__ = item.GetHandle ();
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:validateDrop:proposedItem:proposedChildIndex:"), outlineView__handle__, info__handle__, item__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (info);
			GC.KeepAlive (item);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptDrop (this INSOutlineViewDataSource This, NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			var item__handle__ = item.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("outlineView:acceptDrop:item:childIndex:"), outlineView__handle__, info__handle__, item__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (info);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="outlineView">To be added.</param><param name="dropDestination">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] FilesDropped (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var items__handle__ = items!.GetNonNullHandle (nameof (items));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:"), outlineView__handle__, dropDestination__handle__, items__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (items);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSPasteboardWriting PasteboardWriterForItem (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:pasteboardWriterForItem:"), outlineView__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="draggedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionWillBegin (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSArray draggedItems)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var draggedItems__handle__ = draggedItems!.GetNonNullHandle (nameof (draggedItems));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:draggingSession:willBeginAtPoint:forItems:"), outlineView__handle__, session__handle__, screenPoint, draggedItems__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (session);
			GC.KeepAlive (draggedItems);
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionEnded (this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("outlineView:draggingSession:endedAtPoint:operation:"), outlineView__handle__, session__handle__, screenPoint, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateDraggingItemsForDrag (this INSOutlineViewDataSource This, NSOutlineView outlineView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var outlineView__handle__ = outlineView!.GetNonNullHandle (nameof (outlineView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("outlineView:updateDraggingItemsForDrag:"), outlineView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (outlineView);
			GC.KeepAlive (draggingInfo);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSOutlineViewDataSourceWrapper : BaseWrapper, INSOutlineViewDataSource {
		public NSOutlineViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSOutlineViewDataSourceWrapper))]
		static NSOutlineViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSOutlineViewDataSource" /> (for the protocol <c>NSOutlineViewDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSOutlineViewDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSOutlineViewDataSource", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSOutlineViewDataSource : NSObject, INSOutlineViewDataSource {
		/// <summary>Creates a new <see cref="NSOutlineViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSOutlineViewDataSource () : base (NSObjectFlag.Empty)
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
		protected NSOutlineViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal NSOutlineViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("outlineView:acceptDrop:item:childIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:draggingSession:endedAtPoint:operation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSDragOperation operation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="draggedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:draggingSession:willBeginAtPoint:forItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSArray draggedItems)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="dropDestination">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] FilesDropped (NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="childIndex">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:child:ofItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetChild (NSOutlineView outlineView, nint childIndex, NSObject? item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:numberOfChildrenOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetChildrenCount (NSOutlineView outlineView, NSObject? item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:objectValueForTableColumn:byItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetObjectValue (NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject? item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:isItemExpandable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ItemExpandable (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:itemForPersistentObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ItemForPersistentObject (NSOutlineView outlineView, NSObject theObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="items">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:writeItems:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OutlineViewwriteItemstoPasteboard (NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:pasteboardWriterForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting PasteboardWriterForItem (NSOutlineView outlineView, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineView:persistentObjectForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PersistentObjectForItem (NSOutlineView outlineView, NSObject? item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:setObjectValue:forTableColumn:byItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSOutlineView outlineView, NSObject? theObject, NSTableColumn? tableColumn, NSObject? item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="outlineView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("outlineView:sortDescriptorsDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SortDescriptorsChanged (NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("outlineView:updateDraggingItemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItemsForDrag (NSOutlineView outlineView, INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("outlineView:validateDrop:proposedItem:proposedChildIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSOutlineView outlineView, INSDraggingInfo info, NSObject? item, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSOutlineViewDataSource */
}
