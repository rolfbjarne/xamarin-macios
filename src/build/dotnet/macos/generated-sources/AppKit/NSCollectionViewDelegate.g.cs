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
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCollectionViewDelegate", WrapperType = typeof (NSCollectionViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanDragItems", Selector = "collectionView:canDragItemsAtIndexes:withEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSIndexSet), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteItems", Selector = "collectionView:writeItemsAtIndexes:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSIndexSet), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NamesOfPromisedFilesDroppedAtDestination", Selector = "collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSUrl), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "collectionView:validateDrop:proposedIndex:dropOperation:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (NSCollectionView), typeof (INSDraggingInfo), typeof (IntPtr), typeof (NSCollectionViewDropOperation) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "collectionView:acceptDrop:index:dropOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSCollectionView), typeof (INSDraggingInfo), typeof (IntPtr), typeof (NSCollectionViewDropOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanDragItems", Selector = "collectionView:canDragItemsAtIndexPaths:withEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteItems", Selector = "collectionView:writeItemsAtIndexPaths:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNamesOfPromisedFiles", Selector = "collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSUrl), typeof (NSSet) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDraggingImage", Selector = "collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:", ReturnType = typeof (NSImage), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet), typeof (NSEvent), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "collectionView:validateDrop:proposedIndexPath:dropOperation:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (NSCollectionView), typeof (INSDraggingInfo), typeof (NSIndexPath), typeof (NSCollectionViewDropOperation) }, ParameterByRef = new bool [] { false, false, true, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "collectionView:acceptDrop:indexPath:dropOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSCollectionView), typeof (INSDraggingInfo), typeof (NSIndexPath), typeof (NSCollectionViewDropOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPasteboardWriter", Selector = "collectionView:pasteboardWriterForItemAtIndexPath:", ReturnType = typeof (INSPasteboardWriting), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSSet) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeItems", Selector = "collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:", ReturnType = typeof (NSSet), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet), typeof (NSCollectionViewItemHighlightState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemsChanged", Selector = "collectionView:didChangeItemsAtIndexPaths:toHighlightState:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet), typeof (NSCollectionViewItemHighlightState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectItems", Selector = "collectionView:shouldSelectItemsAtIndexPaths:", ReturnType = typeof (NSSet), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDeselectItems", Selector = "collectionView:shouldDeselectItemsAtIndexPaths:", ReturnType = typeof (NSSet), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemsSelected", Selector = "collectionView:didSelectItemsAtIndexPaths:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemsDeselected", Selector = "collectionView:didDeselectItemsAtIndexPaths:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayItem", Selector = "collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewItem), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplaySupplementaryView", Selector = "collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSView), typeof (NSString), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayingItemEnded", Selector = "collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewItem), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayingSupplementaryViewEnded", Selector = "collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSView), typeof (string), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionLayout", Selector = "collectionView:transitionLayoutForOldLayout:newLayout:", ReturnType = typeof (NSCollectionViewTransitionLayout), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (NSCollectionViewLayout) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteboardWriterForItem", Selector = "collectionView:pasteboardWriterForItemAtIndex:", ReturnType = typeof (INSPasteboardWriting), ParameterType = new Type [] { typeof (NSCollectionView), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDraggingItemsForDrag", Selector = "collectionView:updateDraggingItemsForDrag:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionEnded", Selector = "collectionView:draggingSession:endedAtPoint:dragOperation:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSDraggingSession), typeof (CGPoint), typeof (NSDragOperation) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSCollectionViewDelegate : INativeObject, IDisposable
	{
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canDragItemsAtIndexes:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragItems (NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
		{
			return _CanDragItems (this, collectionView, indexes, evt);
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanDragItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var evt__handle__ = evt!.GetNonNullHandle (nameof (evt));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canDragItemsAtIndexes:withEvent:"), collectionView__handle__, indexes__handle__, evt__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexes);
			GC.KeepAlive (evt);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="toPasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:writeItemsAtIndexes:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteItems (NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
		{
			return _WriteItems (this, collectionView, indexes, toPasteboard);
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="toPasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var toPasteboard__handle__ = toPasteboard!.GetNonNullHandle (nameof (toPasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:writeItemsAtIndexes:toPasteboard:"), collectionView__handle__, indexes__handle__, toPasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexes);
			GC.KeepAlive (toPasteboard);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="dropUrl">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
		{
			return _NamesOfPromisedFilesDroppedAtDestination (this, collectionView, dropUrl, indexes);
		}
		/// <param name="collectionView">To be added.</param><param name="dropUrl">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _NamesOfPromisedFilesDroppedAtDestination (INSCollectionViewDelegate This, NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var dropUrl__handle__ = dropUrl!.GetNonNullHandle (nameof (dropUrl));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:"), collectionView__handle__, dropUrl__handle__, indexes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (dropUrl);
			GC.KeepAlive (indexes);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:validateDrop:proposedIndex:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
		{
			return _ValidateDrop (this, collectionView, draggingInfo, ref dropIndex, ref dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSDragOperation _ValidateDrop (INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			fixed (nint* dropIndex__pointer = &dropIndex) {
			fixed (NSCollectionViewDropOperation* dropOperation__pointer = &dropOperation) {
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_IntPtr_ref_NSCollectionViewDropOperation (This.Handle, Selector.GetHandle ("collectionView:validateDrop:proposedIndex:dropOperation:"), collectionView__handle__, draggingInfo__handle__, dropIndex__pointer, dropOperation__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			return ret!;
			}
			}
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:acceptDrop:index:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
		{
			return _AcceptDrop (this, collectionView, draggingInfo, index, dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AcceptDrop (INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("collectionView:acceptDrop:index:dropOperation:"), collectionView__handle__, draggingInfo__handle__, index, (IntPtr) (long) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canDragItemsAtIndexPaths:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragItems (NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
		{
			return _CanDragItems (this, collectionView, indexPaths, theEvent);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanDragItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canDragItemsAtIndexPaths:withEvent:"), collectionView__handle__, indexPaths__handle__, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:writeItemsAtIndexPaths:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteItems (NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
		{
			return _WriteItems (this, collectionView, indexPaths, pasteboard);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:writeItemsAtIndexPaths:toPasteboard:"), collectionView__handle__, indexPaths__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="dropURL">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetNamesOfPromisedFiles (NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
		{
			return _GetNamesOfPromisedFiles (this, collectionView, dropURL, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="dropURL">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetNamesOfPromisedFiles (INSCollectionViewDelegate This, NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var dropURL__handle__ = dropURL!.GetNonNullHandle (nameof (dropURL));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:"), collectionView__handle__, dropURL__handle__, indexPaths__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (dropURL);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><param name="dragImageOffset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSImage GetDraggingImage (NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
		{
			return _GetDraggingImage (this, collectionView, indexPaths, theEvent, ref dragImageOffset);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><param name="dragImageOffset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSImage _GetDraggingImage (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			fixed (CGPoint* dragImageOffset__pointer = &dragImageOffset) {
			NSImage? ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_CGPoint (This.Handle, Selector.GetHandle ("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:"), collectionView__handle__, indexPaths__handle__, theEvent__handle__, dragImageOffset__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (theEvent);
			return ret!;
			}
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:validateDrop:proposedIndexPath:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
		{
			return _ValidateDrop (this, collectionView, draggingInfo, ref proposedDropIndexPath, ref proposedDropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSDragOperation _ValidateDrop (INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			var proposedDropIndexPathValue = Runtime.RetainAndAutoreleaseNativeObject (proposedDropIndexPath);
			fixed (NSCollectionViewDropOperation* proposedDropOperation__pointer = &proposedDropOperation) {
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NSCollectionViewDropOperation (This.Handle, Selector.GetHandle ("collectionView:validateDrop:proposedIndexPath:dropOperation:"), collectionView__handle__, draggingInfo__handle__, &proposedDropIndexPathValue, proposedDropOperation__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			proposedDropIndexPath = Runtime.GetNSObject<NSIndexPath> (proposedDropIndexPathValue)!;
			return ret!;
			}
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:acceptDrop:indexPath:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
		{
			return _AcceptDrop (this, collectionView, draggingInfo, indexPath, dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AcceptDrop (INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:acceptDrop:indexPath:dropOperation:"), collectionView__handle__, draggingInfo__handle__, indexPath__handle__, (IntPtr) (long) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:pasteboardWriterForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting? GetPasteboardWriter (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			return _GetPasteboardWriter (this, collectionView, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSPasteboardWriting? _GetPasteboardWriter (INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:pasteboardWriterForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
		{
			_DraggingSessionWillBegin (this, collectionView, session, screenPoint, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionWillBegin (INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:"), collectionView__handle__, session__handle__, screenPoint, indexPaths__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldChangeItems (NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			return _ShouldChangeItems (this, collectionView, indexPaths, highlightState);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet _ShouldChangeItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:"), collectionView__handle__, indexPaths__handle__, (IntPtr) (long) highlightState), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didChangeItemsAtIndexPaths:toHighlightState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsChanged (NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			_ItemsChanged (this, collectionView, indexPaths, highlightState);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemsChanged (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:didChangeItemsAtIndexPaths:toHighlightState:"), collectionView__handle__, indexPaths__handle__, (IntPtr) (long) highlightState);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldSelectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldSelectItems (NSCollectionView collectionView, NSSet indexPaths)
		{
			return _ShouldSelectItems (this, collectionView, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet _ShouldSelectItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldSelectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:shouldDeselectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldDeselectItems (NSCollectionView collectionView, NSSet indexPaths)
		{
			return _ShouldDeselectItems (this, collectionView, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet _ShouldDeselectItems (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldDeselectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didSelectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsSelected (NSCollectionView collectionView, NSSet indexPaths)
		{
			_ItemsSelected (this, collectionView, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemsSelected (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didSelectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didDeselectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsDeselected (NSCollectionView collectionView, NSSet indexPaths)
		{
			_ItemsDeselected (this, collectionView, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemsDeselected (INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didDeselectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayItem (NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			_WillDisplayItem (this, collectionView, item, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayItem (INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:"), collectionView__handle__, item__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (item);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplaySupplementaryView (NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
		{
			_WillDisplaySupplementaryView (this, collectionView, view, elementKind, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplaySupplementaryView (INSCollectionViewDelegate This, NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView__handle__, view__handle__, elementKind__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayingItemEnded (NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			_DisplayingItemEnded (this, collectionView, item, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DisplayingItemEnded (INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:"), collectionView__handle__, item__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (item);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayingSupplementaryViewEnded (NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
		{
			_DisplayingSupplementaryViewEnded (this, collectionView, view, elementKind, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DisplayingSupplementaryViewEnded (INSCollectionViewDelegate This, NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nselementKind = CFString.CreateNative (elementKind);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView__handle__, view__handle__, nselementKind, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nselementKind);
		}
		/// <param name="collectionView">To be added.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewTransitionLayout TransitionLayout (NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
		{
			return _TransitionLayout (this, collectionView, fromLayout, toLayout);
		}
		/// <param name="collectionView">To be added.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCollectionViewTransitionLayout _TransitionLayout (INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var fromLayout__handle__ = fromLayout!.GetNonNullHandle (nameof (fromLayout));
			var toLayout__handle__ = toLayout!.GetNonNullHandle (nameof (toLayout));
			NSCollectionViewTransitionLayout? ret;
			ret =  Runtime.GetNSObject<NSCollectionViewTransitionLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView__handle__, fromLayout__handle__, toLayout__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (fromLayout);
			GC.KeepAlive (toLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:pasteboardWriterForItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting PasteboardWriterForItem (NSCollectionView collectionView, nuint index)
		{
			return _PasteboardWriterForItem (this, collectionView, index);
		}
		/// <param name="collectionView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSPasteboardWriting _PasteboardWriterForItem (INSCollectionViewDelegate This, NSCollectionView collectionView, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("collectionView:pasteboardWriterForItemAtIndex:"), collectionView__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionView:updateDraggingItemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItemsForDrag (NSCollectionView collectionView, INSDraggingInfo draggingInfo)
		{
			_UpdateDraggingItemsForDrag (this, collectionView, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateDraggingItemsForDrag (INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:updateDraggingItemsForDrag:"), collectionView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
		{
			_DraggingSessionWillBegin (this, collectionView, draggingSession, screenPoint, indexes);
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionWillBegin (INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:"), collectionView__handle__, draggingSession__handle__, screenPoint, indexes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingSession);
			GC.KeepAlive (indexes);
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="dragOperation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:draggingSession:endedAtPoint:dragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
		{
			_DraggingSessionEnded (this, collectionView, draggingSession, screenPoint, dragOperation);
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="dragOperation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingSessionEnded (INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("collectionView:draggingSession:endedAtPoint:dragOperation:"), collectionView__handle__, draggingSession__handle__, screenPoint, (UIntPtr) (ulong) dragOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingSession);
		}
		[DynamicDependencyAttribute ("AcceptDrop(AppKit.NSCollectionView,AppKit.INSDraggingInfo,Foundation.NSIndexPath,AppKit.NSCollectionViewDropOperation)")]
		[DynamicDependencyAttribute ("AcceptDrop(AppKit.NSCollectionView,AppKit.INSDraggingInfo,System.IntPtr,AppKit.NSCollectionViewDropOperation)")]
		[DynamicDependencyAttribute ("CanDragItems(AppKit.NSCollectionView,Foundation.NSIndexSet,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("CanDragItems(AppKit.NSCollectionView,Foundation.NSSet,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("DisplayingItemEnded(AppKit.NSCollectionView,AppKit.NSCollectionViewItem,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DisplayingSupplementaryViewEnded(AppKit.NSCollectionView,AppKit.NSView,System.String,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DraggingSessionEnded(AppKit.NSCollectionView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,AppKit.NSDragOperation)")]
		[DynamicDependencyAttribute ("DraggingSessionWillBegin(AppKit.NSCollectionView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("DraggingSessionWillBegin(AppKit.NSCollectionView,AppKit.NSDraggingSession,CoreGraphics.CGPoint,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("GetDraggingImage(AppKit.NSCollectionView,Foundation.NSSet,AppKit.NSEvent,CoreGraphics.CGPoint@)")]
		[DynamicDependencyAttribute ("GetNamesOfPromisedFiles(AppKit.NSCollectionView,Foundation.NSUrl,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("GetPasteboardWriter(AppKit.NSCollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("ItemsChanged(AppKit.NSCollectionView,Foundation.NSSet,AppKit.NSCollectionViewItemHighlightState)")]
		[DynamicDependencyAttribute ("ItemsDeselected(AppKit.NSCollectionView,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("ItemsSelected(AppKit.NSCollectionView,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("NamesOfPromisedFilesDroppedAtDestination(AppKit.NSCollectionView,Foundation.NSUrl,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("PasteboardWriterForItem(AppKit.NSCollectionView,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ShouldChangeItems(AppKit.NSCollectionView,Foundation.NSSet,AppKit.NSCollectionViewItemHighlightState)")]
		[DynamicDependencyAttribute ("ShouldDeselectItems(AppKit.NSCollectionView,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("ShouldSelectItems(AppKit.NSCollectionView,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("TransitionLayout(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,AppKit.NSCollectionViewLayout)")]
		[DynamicDependencyAttribute ("UpdateDraggingItemsForDrag(AppKit.NSCollectionView,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("ValidateDrop(AppKit.NSCollectionView,AppKit.INSDraggingInfo,Foundation.NSIndexPath@,AppKit.NSCollectionViewDropOperation@)")]
		[DynamicDependencyAttribute ("ValidateDrop(AppKit.NSCollectionView,AppKit.INSDraggingInfo,System.IntPtr@,AppKit.NSCollectionViewDropOperation@)")]
		[DynamicDependencyAttribute ("WillDisplayItem(AppKit.NSCollectionView,AppKit.NSCollectionViewItem,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WillDisplaySupplementaryView(AppKit.NSCollectionView,AppKit.NSView,Foundation.NSString,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("WriteItems(AppKit.NSCollectionView,Foundation.NSIndexSet,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("WriteItems(AppKit.NSCollectionView,Foundation.NSSet,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCollectionViewDelegate" /> interface to support all the methods from the NSCollectionViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCollectionViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCollectionViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCollectionViewDelegate_Extensions {
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanDragItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var evt__handle__ = evt!.GetNonNullHandle (nameof (evt));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canDragItemsAtIndexes:withEvent:"), collectionView__handle__, indexes__handle__, evt__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexes);
			GC.KeepAlive (evt);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="toPasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var toPasteboard__handle__ = toPasteboard!.GetNonNullHandle (nameof (toPasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:writeItemsAtIndexes:toPasteboard:"), collectionView__handle__, indexes__handle__, toPasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexes);
			GC.KeepAlive (toPasteboard);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="dropUrl">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] NamesOfPromisedFilesDroppedAtDestination (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var dropUrl__handle__ = dropUrl!.GetNonNullHandle (nameof (dropUrl));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:"), collectionView__handle__, dropUrl__handle__, indexes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (dropUrl);
			GC.KeepAlive (indexes);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDragOperation ValidateDrop (this INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			fixed (nint* dropIndex__pointer = &dropIndex) {
			fixed (NSCollectionViewDropOperation* dropOperation__pointer = &dropOperation) {
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_IntPtr_ref_NSCollectionViewDropOperation (This.Handle, Selector.GetHandle ("collectionView:validateDrop:proposedIndex:dropOperation:"), collectionView__handle__, draggingInfo__handle__, dropIndex__pointer, dropOperation__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			return ret!;
			}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptDrop (this INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("collectionView:acceptDrop:index:dropOperation:"), collectionView__handle__, draggingInfo__handle__, index, (IntPtr) (long) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanDragItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canDragItemsAtIndexPaths:withEvent:"), collectionView__handle__, indexPaths__handle__, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:writeItemsAtIndexPaths:toPasteboard:"), collectionView__handle__, indexPaths__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="dropURL">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetNamesOfPromisedFiles (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var dropURL__handle__ = dropURL!.GetNonNullHandle (nameof (dropURL));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:"), collectionView__handle__, dropURL__handle__, indexPaths__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (dropURL);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><param name="dragImageOffset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSImage GetDraggingImage (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			fixed (CGPoint* dragImageOffset__pointer = &dragImageOffset) {
			NSImage? ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_CGPoint (This.Handle, Selector.GetHandle ("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:"), collectionView__handle__, indexPaths__handle__, theEvent__handle__, dragImageOffset__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (theEvent);
			return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDragOperation ValidateDrop (this INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			var proposedDropIndexPathValue = Runtime.RetainAndAutoreleaseNativeObject (proposedDropIndexPath);
			fixed (NSCollectionViewDropOperation* proposedDropOperation__pointer = &proposedDropOperation) {
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NSCollectionViewDropOperation (This.Handle, Selector.GetHandle ("collectionView:validateDrop:proposedIndexPath:dropOperation:"), collectionView__handle__, draggingInfo__handle__, &proposedDropIndexPathValue, proposedDropOperation__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			proposedDropIndexPath = Runtime.GetNSObject<NSIndexPath> (proposedDropIndexPathValue)!;
			return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptDrop (this INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:acceptDrop:indexPath:dropOperation:"), collectionView__handle__, draggingInfo__handle__, indexPath__handle__, (IntPtr) (long) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSPasteboardWriting? GetPasteboardWriter (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:pasteboardWriterForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionWillBegin (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:"), collectionView__handle__, session__handle__, screenPoint, indexPaths__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet ShouldChangeItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:"), collectionView__handle__, indexPaths__handle__, (IntPtr) (long) highlightState), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemsChanged (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:didChangeItemsAtIndexPaths:toHighlightState:"), collectionView__handle__, indexPaths__handle__, (IntPtr) (long) highlightState);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet ShouldSelectItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldSelectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet ShouldDeselectItems (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:shouldDeselectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemsSelected (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didSelectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemsDeselected (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didDeselectItemsAtIndexPaths:"), collectionView__handle__, indexPaths__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayItem (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:"), collectionView__handle__, item__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (item);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplaySupplementaryView (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView__handle__, view__handle__, elementKind__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisplayingItemEnded (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:"), collectionView__handle__, item__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (item);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisplayingSupplementaryViewEnded (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nselementKind = CFString.CreateNative (elementKind);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView__handle__, view__handle__, nselementKind, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nselementKind);
		}
		/// <param name="collectionView">To be added.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionViewTransitionLayout TransitionLayout (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var fromLayout__handle__ = fromLayout!.GetNonNullHandle (nameof (fromLayout));
			var toLayout__handle__ = toLayout!.GetNonNullHandle (nameof (toLayout));
			NSCollectionViewTransitionLayout? ret;
			ret =  Runtime.GetNSObject<NSCollectionViewTransitionLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView__handle__, fromLayout__handle__, toLayout__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (fromLayout);
			GC.KeepAlive (toLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSPasteboardWriting PasteboardWriterForItem (this INSCollectionViewDelegate This, NSCollectionView collectionView, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			INSPasteboardWriting? ret;
			ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("collectionView:pasteboardWriterForItemAtIndex:"), collectionView__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateDraggingItemsForDrag (this INSCollectionViewDelegate This, NSCollectionView collectionView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:updateDraggingItemsForDrag:"), collectionView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingInfo);
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionWillBegin (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:"), collectionView__handle__, draggingSession__handle__, screenPoint, indexes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingSession);
			GC.KeepAlive (indexes);
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="dragOperation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingSessionEnded (this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("collectionView:draggingSession:endedAtPoint:dragOperation:"), collectionView__handle__, draggingSession__handle__, screenPoint, (UIntPtr) (ulong) dragOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (draggingSession);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionViewDelegateWrapper : BaseWrapper, INSCollectionViewDelegate {
		public NSCollectionViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewDelegateWrapper))]
		static NSCollectionViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSCollectionViewDelegate" /> (for the protocol <c>NSCollectionViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSCollectionViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSCollectionViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCollectionViewDelegate : NSObject, INSCollectionViewDelegate {
		/// <summary>Creates a new <see cref="NSCollectionViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCollectionViewDelegate () : base (NSObjectFlag.Empty)
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
		protected NSCollectionViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("collectionView:acceptDrop:index:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:acceptDrop:indexPath:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canDragItemsAtIndexes:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragItems (NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canDragItemsAtIndexPaths:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragItems (NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayingItemEnded (NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayingSupplementaryViewEnded (NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="dragOperation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:draggingSession:endedAtPoint:dragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><param name="dragImageOffset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSImage GetDraggingImage (NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="dropURL">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetNamesOfPromisedFiles (NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:pasteboardWriterForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting? GetPasteboardWriter (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didChangeItemsAtIndexPaths:toHighlightState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsChanged (NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didDeselectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsDeselected (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didSelectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsSelected (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="dropUrl">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:pasteboardWriterForItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting PasteboardWriterForItem (NSCollectionView collectionView, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldChangeItems (NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldDeselectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldDeselectItems (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldSelectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldSelectItems (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewTransitionLayout TransitionLayout (NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:updateDraggingItemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItemsForDrag (NSCollectionView collectionView, INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:validateDrop:proposedIndex:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:validateDrop:proposedIndexPath:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayItem (NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplaySupplementaryView (NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="toPasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:writeItemsAtIndexes:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteItems (NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:writeItemsAtIndexPaths:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteItems (NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSCollectionViewDelegate */
}
