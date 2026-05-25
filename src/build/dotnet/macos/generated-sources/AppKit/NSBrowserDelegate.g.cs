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
	/// <summary>This interface represents the Objective-C protocol <c>NSBrowserDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSBrowserDelegate", WrapperType = typeof (NSBrowserDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowsInColumn", Selector = "browser:numberOfRowsInColumn:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateRowsForColumn", Selector = "browser:createRowsForColumn:inMatrix:", ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (NSMatrix) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CountChildren", Selector = "browser:numberOfChildrenOfItem:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChild", Selector = "browser:child:ofItem:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsLeafItem", Selector = "browser:isLeafItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectValueForItem", Selector = "browser:objectValueForItem:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowHeight", Selector = "browser:heightOfRow:inColumn:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RootItemForBrowser", Selector = "rootItemForBrowser:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSBrowser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetObjectValue", Selector = "browser:setObjectValue:forItem:", ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEditItem", Selector = "browser:shouldEditItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "browser:willDisplayCell:atRow:column:", ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnTitle", Selector = "browser:titleOfColumn:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectCellWithString", Selector = "browser:selectCellWithString:inColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (string), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectRowInColumn", Selector = "browser:selectRow:inColumn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsColumnValid", Selector = "browser:isColumnValid:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillScroll", Selector = "browserWillScroll:", ParameterType = new Type [] { typeof (NSBrowser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScroll", Selector = "browserDidScroll:", ParameterType = new Type [] { typeof (NSBrowser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSizeColumn", Selector = "browser:shouldSizeColumn:forUserResize:toWidth:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (bool), typeof (NFloat) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SizeToFitWidth", Selector = "browser:sizeToFitWidthOfColumn:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnConfigurationDidChange", Selector = "browserColumnConfigurationDidChange:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowCellExpansion", Selector = "browser:shouldShowCellExpansionForRow:column:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRowsWithIndexesToPasteboard", Selector = "browser:writeRowsWithIndexes:inColumn:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSIndexSet), typeof (IntPtr), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PromisedFilesDroppedAtDestination", Selector = "browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSUrl), typeof (NSIndexSet), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanDragRowsWithIndexes", Selector = "browser:canDragRowsWithIndexes:inColumn:withEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSIndexSet), typeof (IntPtr), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "browser:validateDrop:proposedRow:column:dropOperation:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (NSBrowser), typeof (INSDraggingInfo), typeof (IntPtr), typeof (IntPtr), typeof (NSBrowserDropOperation) }, ParameterByRef = new bool [] { false, false, true, true, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "browser:acceptDrop:atRow:column:dropOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (INSDraggingInfo), typeof (IntPtr), typeof (IntPtr), typeof (NSBrowserDropOperation) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TypeSelectString", Selector = "browser:typeSelectStringForRow:inColumn:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTypeSelectForEvent", Selector = "browser:shouldTypeSelectForEvent:withCurrentSearchString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSEvent), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NextTypeSelectMatch", Selector = "browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreviewViewControllerForLeafItem", Selector = "browser:previewViewControllerForLeafItem:", ReturnType = typeof (NSViewController), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HeaderViewControllerForItem", Selector = "browser:headerViewControllerForItem:", ReturnType = typeof (NSViewController), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeLastColumn", Selector = "browser:didChangeLastColumn:toColumn:", ParameterType = new Type [] { typeof (NSBrowser), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIndexesForProposedSelection", Selector = "browser:selectionIndexesForProposedSelection:inColumn:", ReturnType = typeof (NSIndexSet), ParameterType = new Type [] { typeof (NSBrowser), typeof (NSIndexSet), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSBrowserDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:numberOfRowsInColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowsInColumn (NSBrowser sender, nint column)
		{
			return _RowsInColumn (this, sender, column);
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _RowsInColumn (INSBrowserDelegate This, NSBrowser sender, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:numberOfRowsInColumn:"), sender__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><param name="matrix">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:createRowsForColumn:inMatrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreateRowsForColumn (NSBrowser sender, nint column, NSMatrix matrix)
		{
			_CreateRowsForColumn (this, sender, column, matrix);
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><param name="matrix">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CreateRowsForColumn (INSBrowserDelegate This, NSBrowser sender, nint column, NSMatrix matrix)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var matrix__handle__ = matrix!.GetNonNullHandle (nameof (matrix));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:createRowsForColumn:inMatrix:"), sender__handle__, column, matrix__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (matrix);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:numberOfChildrenOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CountChildren (NSBrowser browser, NSObject item)
		{
			return _CountChildren (this, browser, item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _CountChildren (INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:numberOfChildrenOfItem:"), browser__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:child:ofItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetChild (NSBrowser browser, nint index, NSObject item)
		{
			return _GetChild (this, browser, index, item);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetChild (INSBrowserDelegate This, NSBrowser browser, nint index, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:child:ofItem:"), browser__handle__, index, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:isLeafItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLeafItem (NSBrowser browser, NSObject item)
		{
			return _IsLeafItem (this, browser, item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsLeafItem (INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:isLeafItem:"), browser__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:objectValueForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ObjectValueForItem (NSBrowser browser, NSObject item)
		{
			return _ObjectValueForItem (this, browser, item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _ObjectValueForItem (INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:objectValueForItem:"), browser__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:heightOfRow:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RowHeight (NSBrowser browser, nint row, nint columnIndex)
		{
			return _RowHeight (this, browser, row, columnIndex);
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _RowHeight (INSBrowserDelegate This, NSBrowser browser, nint row, nint columnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:heightOfRow:inColumn:"), browser__handle__, row, columnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("rootItemForBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject RootItemForBrowser (NSBrowser browser)
		{
			return _RootItemForBrowser (this, browser);
		}
		/// <param name="browser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _RootItemForBrowser (INSBrowserDelegate This, NSBrowser browser)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("rootItemForBrowser:"), browser__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="obj">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:setObjectValue:forItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSBrowser browser, NSObject obj, NSObject item)
		{
			_SetObjectValue (this, browser, obj, item);
		}
		/// <param name="browser">To be added.</param><param name="obj">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObjectValue (INSBrowserDelegate This, NSBrowser browser, NSObject obj, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:setObjectValue:forItem:"), browser__handle__, obj__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (obj);
			GC.KeepAlive (item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:shouldEditItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEditItem (NSBrowser browser, NSObject item)
		{
			return _ShouldEditItem (this, browser, item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEditItem (INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:shouldEditItem:"), browser__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="cell">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:willDisplayCell:atRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (NSBrowser sender, NSObject cell, nint row, nint column)
		{
			_WillDisplayCell (this, sender, cell, row, column);
		}
		/// <param name="sender">To be added.</param><param name="cell">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayCell (INSBrowserDelegate This, NSBrowser sender, NSObject cell, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:willDisplayCell:atRow:column:"), sender__handle__, cell__handle__, row, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (cell);
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:titleOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ColumnTitle (NSBrowser sender, nint column)
		{
			return _ColumnTitle (this, sender, column);
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _ColumnTitle (INSBrowserDelegate This, NSBrowser sender, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:titleOfColumn:"), sender__handle__, column), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:selectCellWithString:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectCellWithString (NSBrowser sender, string title, nint column)
		{
			return _SelectCellWithString (this, sender, title, column);
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SelectCellWithString (INSBrowserDelegate This, NSBrowser sender, string title, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:selectCellWithString:inColumn:"), sender__handle__, nstitle, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstitle);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:selectRow:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectRowInColumn (NSBrowser sender, nint row, nint column)
		{
			return _SelectRowInColumn (this, sender, row, column);
		}
		/// <param name="sender">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SelectRowInColumn (INSBrowserDelegate This, NSBrowser sender, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:selectRow:inColumn:"), sender__handle__, row, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:isColumnValid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsColumnValid (NSBrowser sender, nint column)
		{
			return _IsColumnValid (this, sender, column);
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsColumnValid (INSBrowserDelegate This, NSBrowser sender, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:isColumnValid:"), sender__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browserWillScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillScroll (NSBrowser sender)
		{
			_WillScroll (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillScroll (INSBrowserDelegate This, NSBrowser sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserWillScroll:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browserDidScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScroll (NSBrowser sender)
		{
			_DidScroll (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidScroll (INSBrowserDelegate This, NSBrowser sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserDidScroll:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><param name="userResize">To be added.</param><param name="suggestedWidth">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:shouldSizeColumn:forUserResize:toWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ShouldSizeColumn (NSBrowser browser, nint columnIndex, bool userResize, nfloat suggestedWidth)
		{
			return _ShouldSizeColumn (this, browser, columnIndex, userResize, suggestedWidth);
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><param name="userResize">To be added.</param><param name="suggestedWidth">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _ShouldSizeColumn (INSBrowserDelegate This, NSBrowser browser, nint columnIndex, bool userResize, nfloat suggestedWidth)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr_bool_nfloat (This.Handle, Selector.GetHandle ("browser:shouldSizeColumn:forUserResize:toWidth:"), browser__handle__, columnIndex, userResize ? (byte) 1 : (byte) 0, suggestedWidth);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:sizeToFitWidthOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SizeToFitWidth (NSBrowser browser, nint columnIndex)
		{
			return _SizeToFitWidth (this, browser, columnIndex);
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _SizeToFitWidth (INSBrowserDelegate This, NSBrowser browser, nint columnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:sizeToFitWidthOfColumn:"), browser__handle__, columnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browserColumnConfigurationDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnConfigurationDidChange (NSNotification notification)
		{
			_ColumnConfigurationDidChange (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ColumnConfigurationDidChange (INSBrowserDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserColumnConfigurationDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:shouldShowCellExpansionForRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowCellExpansion (NSBrowser browser, nint row, nint column)
		{
			return _ShouldShowCellExpansion (this, browser, row, column);
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowCellExpansion (INSBrowserDelegate This, NSBrowser browser, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:shouldShowCellExpansionForRow:column:"), browser__handle__, row, column);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:writeRowsWithIndexes:inColumn:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRowsWithIndexesToPasteboard (NSBrowser browser, NSIndexSet rowIndexes, nint column, NSPasteboard pasteboard)
		{
			return _WriteRowsWithIndexesToPasteboard (this, browser, rowIndexes, column, pasteboard);
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteRowsWithIndexesToPasteboard (INSBrowserDelegate This, NSBrowser browser, NSIndexSet rowIndexes, nint column, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:writeRowsWithIndexes:inColumn:toPasteboard:"), browser__handle__, rowIndexes__handle__, column, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="dropDestination">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PromisedFilesDroppedAtDestination (NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, nint column)
		{
			return _PromisedFilesDroppedAtDestination (this, browser, dropDestination, rowIndexes, column);
		}
		/// <param name="browser">To be added.</param><param name="dropDestination">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _PromisedFilesDroppedAtDestination (INSBrowserDelegate This, NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:"), browser__handle__, dropDestination__handle__, rowIndexes__handle__, column), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (rowIndexes);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:canDragRowsWithIndexes:inColumn:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragRowsWithIndexes (NSBrowser browser, NSIndexSet rowIndexes, nint column, NSEvent theEvent)
		{
			return _CanDragRowsWithIndexes (this, browser, rowIndexes, column, theEvent);
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanDragRowsWithIndexes (INSBrowserDelegate This, NSBrowser browser, NSIndexSet rowIndexes, nint column, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:canDragRowsWithIndexes:inColumn:withEvent:"), browser__handle__, rowIndexes__handle__, column, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("browser:validateDrop:proposedRow:column:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSBrowser browser, INSDraggingInfo info, ref nint row, ref nint column, ref NSBrowserDropOperation dropOperation)
		{
			return _ValidateDrop (this, browser, info, ref row, ref column, ref dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSDragOperation _ValidateDrop (INSBrowserDelegate This, NSBrowser browser, INSDraggingInfo info, ref nint row, ref nint column, ref NSBrowserDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			fixed (nint* row__pointer = &row) {
			fixed (nint* column__pointer = &column) {
			fixed (NSBrowserDropOperation* dropOperation__pointer = &dropOperation) {
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_IntPtr_ref_IntPtr_ref_NSBrowserDropOperation (This.Handle, Selector.GetHandle ("browser:validateDrop:proposedRow:column:dropOperation:"), browser__handle__, info__handle__, row__pointer, column__pointer, dropOperation__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (info);
			return ret!;
			}
			}
			}
		}
		[global::Foundation.OptionalMember]
		[Export ("browser:acceptDrop:atRow:column:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSBrowser browser, INSDraggingInfo info, nint row, nint column, NSBrowserDropOperation dropOperation)
		{
			return _AcceptDrop (this, browser, info, row, column, dropOperation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AcceptDrop (INSBrowserDelegate This, NSBrowser browser, INSDraggingInfo info, nint row, nint column, NSBrowserDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("browser:acceptDrop:atRow:column:dropOperation:"), browser__handle__, info__handle__, row, column, (UIntPtr) (ulong) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (info);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:typeSelectStringForRow:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TypeSelectString (NSBrowser browser, nint row, nint column)
		{
			return _TypeSelectString (this, browser, row, column);
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _TypeSelectString (INSBrowserDelegate This, NSBrowser browser, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:typeSelectStringForRow:inColumn:"), browser__handle__, row, column), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="theEvent">To be added.</param><param name="currentSearchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:shouldTypeSelectForEvent:withCurrentSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTypeSelectForEvent (NSBrowser browser, NSEvent theEvent, string currentSearchString)
		{
			return _ShouldTypeSelectForEvent (this, browser, theEvent, currentSearchString);
		}
		/// <param name="browser">To be added.</param><param name="theEvent">To be added.</param><param name="currentSearchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldTypeSelectForEvent (INSBrowserDelegate This, NSBrowser browser, NSEvent theEvent, string currentSearchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (currentSearchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currentSearchString));
			var nscurrentSearchString = CFString.CreateNative (currentSearchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:shouldTypeSelectForEvent:withCurrentSearchString:"), browser__handle__, theEvent__handle__, nscurrentSearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (theEvent);
			CFString.ReleaseNative (nscurrentSearchString);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="column">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NextTypeSelectMatch (NSBrowser browser, nint startRow, nint endRow, nint column, string searchString)
		{
			return _NextTypeSelectMatch (this, browser, startRow, endRow, column, searchString);
		}
		/// <param name="browser">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="column">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _NextTypeSelectMatch (INSBrowserDelegate This, NSBrowser browser, nint startRow, nint endRow, nint column, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:"), browser__handle__, startRow, endRow, column, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			CFString.ReleaseNative (nssearchString);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:previewViewControllerForLeafItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController PreviewViewControllerForLeafItem (NSBrowser browser, NSObject item)
		{
			return _PreviewViewControllerForLeafItem (this, browser, item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSViewController _PreviewViewControllerForLeafItem (INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSViewController? ret;
			ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:previewViewControllerForLeafItem:"), browser__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:headerViewControllerForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController HeaderViewControllerForItem (NSBrowser browser, NSObject item)
		{
			return _HeaderViewControllerForItem (this, browser, item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSViewController _HeaderViewControllerForItem (INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSViewController? ret;
			ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:headerViewControllerForItem:"), browser__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="oldLastColumn">To be added.</param><param name="toColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:didChangeLastColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeLastColumn (NSBrowser browser, nint oldLastColumn, nint toColumn)
		{
			_DidChangeLastColumn (this, browser, oldLastColumn, toColumn);
		}
		/// <param name="browser">To be added.</param><param name="oldLastColumn">To be added.</param><param name="toColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeLastColumn (INSBrowserDelegate This, NSBrowser browser, nint oldLastColumn, nint toColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:didChangeLastColumn:toColumn:"), browser__handle__, oldLastColumn, toColumn);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><param name="inColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("browser:selectionIndexesForProposedSelection:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet SelectionIndexesForProposedSelection (NSBrowser browser, NSIndexSet proposedSelectionIndexes, nint inColumn)
		{
			return _SelectionIndexesForProposedSelection (this, browser, proposedSelectionIndexes, inColumn);
		}
		/// <param name="browser">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><param name="inColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexSet _SelectionIndexesForProposedSelection (INSBrowserDelegate This, NSBrowser browser, NSIndexSet proposedSelectionIndexes, nint inColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var proposedSelectionIndexes__handle__ = proposedSelectionIndexes!.GetNonNullHandle (nameof (proposedSelectionIndexes));
			NSIndexSet? ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:selectionIndexesForProposedSelection:inColumn:"), browser__handle__, proposedSelectionIndexes__handle__, inColumn), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (proposedSelectionIndexes);
			return ret!;
		}
		[DynamicDependencyAttribute ("AcceptDrop(AppKit.NSBrowser,AppKit.INSDraggingInfo,System.IntPtr,System.IntPtr,AppKit.NSBrowserDropOperation)")]
		[DynamicDependencyAttribute ("CanDragRowsWithIndexes(AppKit.NSBrowser,Foundation.NSIndexSet,System.IntPtr,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("ColumnConfigurationDidChange(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ColumnTitle(AppKit.NSBrowser,System.IntPtr)")]
		[DynamicDependencyAttribute ("CountChildren(AppKit.NSBrowser,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("CreateRowsForColumn(AppKit.NSBrowser,System.IntPtr,AppKit.NSMatrix)")]
		[DynamicDependencyAttribute ("DidChangeLastColumn(AppKit.NSBrowser,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidScroll(AppKit.NSBrowser)")]
		[DynamicDependencyAttribute ("GetChild(AppKit.NSBrowser,System.IntPtr,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("HeaderViewControllerForItem(AppKit.NSBrowser,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("IsColumnValid(AppKit.NSBrowser,System.IntPtr)")]
		[DynamicDependencyAttribute ("IsLeafItem(AppKit.NSBrowser,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("NextTypeSelectMatch(AppKit.NSBrowser,System.IntPtr,System.IntPtr,System.IntPtr,System.String)")]
		[DynamicDependencyAttribute ("ObjectValueForItem(AppKit.NSBrowser,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PreviewViewControllerForLeafItem(AppKit.NSBrowser,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PromisedFilesDroppedAtDestination(AppKit.NSBrowser,Foundation.NSUrl,Foundation.NSIndexSet,System.IntPtr)")]
		[DynamicDependencyAttribute ("RootItemForBrowser(AppKit.NSBrowser)")]
		[DynamicDependencyAttribute ("RowHeight(AppKit.NSBrowser,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("RowsInColumn(AppKit.NSBrowser,System.IntPtr)")]
		[DynamicDependencyAttribute ("SelectCellWithString(AppKit.NSBrowser,System.String,System.IntPtr)")]
		[DynamicDependencyAttribute ("SelectionIndexesForProposedSelection(AppKit.NSBrowser,Foundation.NSIndexSet,System.IntPtr)")]
		[DynamicDependencyAttribute ("SelectRowInColumn(AppKit.NSBrowser,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("SetObjectValue(AppKit.NSBrowser,Foundation.NSObject,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldEditItem(AppKit.NSBrowser,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ShouldShowCellExpansion(AppKit.NSBrowser,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldSizeColumn(AppKit.NSBrowser,System.IntPtr,System.Boolean,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("ShouldTypeSelectForEvent(AppKit.NSBrowser,AppKit.NSEvent,System.String)")]
		[DynamicDependencyAttribute ("SizeToFitWidth(AppKit.NSBrowser,System.IntPtr)")]
		[DynamicDependencyAttribute ("TypeSelectString(AppKit.NSBrowser,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("ValidateDrop(AppKit.NSBrowser,AppKit.INSDraggingInfo,System.IntPtr@,System.IntPtr@,AppKit.NSBrowserDropOperation@)")]
		[DynamicDependencyAttribute ("WillDisplayCell(AppKit.NSBrowser,Foundation.NSObject,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("WillScroll(AppKit.NSBrowser)")]
		[DynamicDependencyAttribute ("WriteRowsWithIndexesToPasteboard(AppKit.NSBrowser,Foundation.NSIndexSet,System.IntPtr,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSBrowserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSBrowserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSBrowserDelegate" /> interface to support all the methods from the NSBrowserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSBrowserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSBrowserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSBrowserDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint RowsInColumn (this INSBrowserDelegate This, NSBrowser sender, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:numberOfRowsInColumn:"), sender__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><param name="matrix">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CreateRowsForColumn (this INSBrowserDelegate This, NSBrowser sender, nint column, NSMatrix matrix)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var matrix__handle__ = matrix!.GetNonNullHandle (nameof (matrix));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:createRowsForColumn:inMatrix:"), sender__handle__, column, matrix__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (matrix);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint CountChildren (this INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:numberOfChildrenOfItem:"), browser__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetChild (this INSBrowserDelegate This, NSBrowser browser, nint index, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:child:ofItem:"), browser__handle__, index, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsLeafItem (this INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:isLeafItem:"), browser__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ObjectValueForItem (this INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:objectValueForItem:"), browser__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat RowHeight (this INSBrowserDelegate This, NSBrowser browser, nint row, nint columnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:heightOfRow:inColumn:"), browser__handle__, row, columnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject RootItemForBrowser (this INSBrowserDelegate This, NSBrowser browser)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("rootItemForBrowser:"), browser__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="obj">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetObjectValue (this INSBrowserDelegate This, NSBrowser browser, NSObject obj, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:setObjectValue:forItem:"), browser__handle__, obj__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (obj);
			GC.KeepAlive (item);
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEditItem (this INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:shouldEditItem:"), browser__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="cell">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayCell (this INSBrowserDelegate This, NSBrowser sender, NSObject cell, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:willDisplayCell:atRow:column:"), sender__handle__, cell__handle__, row, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (cell);
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ColumnTitle (this INSBrowserDelegate This, NSBrowser sender, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:titleOfColumn:"), sender__handle__, column), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SelectCellWithString (this INSBrowserDelegate This, NSBrowser sender, string title, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:selectCellWithString:inColumn:"), sender__handle__, nstitle, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstitle);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SelectRowInColumn (this INSBrowserDelegate This, NSBrowser sender, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:selectRow:inColumn:"), sender__handle__, row, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsColumnValid (this INSBrowserDelegate This, NSBrowser sender, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:isColumnValid:"), sender__handle__, column);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillScroll (this INSBrowserDelegate This, NSBrowser sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserWillScroll:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidScroll (this INSBrowserDelegate This, NSBrowser sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserDidScroll:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><param name="userResize">To be added.</param><param name="suggestedWidth">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat ShouldSizeColumn (this INSBrowserDelegate This, NSBrowser browser, nint columnIndex, bool userResize, nfloat suggestedWidth)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr_bool_nfloat (This.Handle, Selector.GetHandle ("browser:shouldSizeColumn:forUserResize:toWidth:"), browser__handle__, columnIndex, userResize ? (byte) 1 : (byte) 0, suggestedWidth);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat SizeToFitWidth (this INSBrowserDelegate This, NSBrowser browser, nint columnIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:sizeToFitWidthOfColumn:"), browser__handle__, columnIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ColumnConfigurationDidChange (this INSBrowserDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserColumnConfigurationDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowCellExpansion (this INSBrowserDelegate This, NSBrowser browser, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:shouldShowCellExpansionForRow:column:"), browser__handle__, row, column);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteRowsWithIndexesToPasteboard (this INSBrowserDelegate This, NSBrowser browser, NSIndexSet rowIndexes, nint column, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:writeRowsWithIndexes:inColumn:toPasteboard:"), browser__handle__, rowIndexes__handle__, column, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="dropDestination">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] PromisedFilesDroppedAtDestination (this INSBrowserDelegate This, NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:"), browser__handle__, dropDestination__handle__, rowIndexes__handle__, column), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (rowIndexes);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanDragRowsWithIndexes (this INSBrowserDelegate This, NSBrowser browser, NSIndexSet rowIndexes, nint column, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:canDragRowsWithIndexes:inColumn:withEvent:"), browser__handle__, rowIndexes__handle__, column, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDragOperation ValidateDrop (this INSBrowserDelegate This, NSBrowser browser, INSDraggingInfo info, ref nint row, ref nint column, ref NSBrowserDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			fixed (nint* row__pointer = &row) {
			fixed (nint* column__pointer = &column) {
			fixed (NSBrowserDropOperation* dropOperation__pointer = &dropOperation) {
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_IntPtr_ref_IntPtr_ref_NSBrowserDropOperation (This.Handle, Selector.GetHandle ("browser:validateDrop:proposedRow:column:dropOperation:"), browser__handle__, info__handle__, row__pointer, column__pointer, dropOperation__pointer);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (info);
			return ret!;
			}
			}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptDrop (this INSBrowserDelegate This, NSBrowser browser, INSDraggingInfo info, nint row, nint column, NSBrowserDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("browser:acceptDrop:atRow:column:dropOperation:"), browser__handle__, info__handle__, row, column, (UIntPtr) (ulong) dropOperation);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (info);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? TypeSelectString (this INSBrowserDelegate This, NSBrowser browser, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:typeSelectStringForRow:inColumn:"), browser__handle__, row, column), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="theEvent">To be added.</param><param name="currentSearchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldTypeSelectForEvent (this INSBrowserDelegate This, NSBrowser browser, NSEvent theEvent, string currentSearchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (currentSearchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currentSearchString));
			var nscurrentSearchString = CFString.CreateNative (currentSearchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:shouldTypeSelectForEvent:withCurrentSearchString:"), browser__handle__, theEvent__handle__, nscurrentSearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (theEvent);
			CFString.ReleaseNative (nscurrentSearchString);
			return ret != 0;
		}
		/// <param name="browser">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="column">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint NextTypeSelectMatch (this INSBrowserDelegate This, NSBrowser browser, nint startRow, nint endRow, nint column, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:"), browser__handle__, startRow, endRow, column, nssearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			CFString.ReleaseNative (nssearchString);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSViewController PreviewViewControllerForLeafItem (this INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSViewController? ret;
			ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:previewViewControllerForLeafItem:"), browser__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSViewController HeaderViewControllerForItem (this INSBrowserDelegate This, NSBrowser browser, NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSViewController? ret;
			ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("browser:headerViewControllerForItem:"), browser__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="browser">To be added.</param><param name="oldLastColumn">To be added.</param><param name="toColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeLastColumn (this INSBrowserDelegate This, NSBrowser browser, nint oldLastColumn, nint toColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("browser:didChangeLastColumn:toColumn:"), browser__handle__, oldLastColumn, toColumn);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><param name="inColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet SelectionIndexesForProposedSelection (this INSBrowserDelegate This, NSBrowser browser, NSIndexSet proposedSelectionIndexes, nint inColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var proposedSelectionIndexes__handle__ = proposedSelectionIndexes!.GetNonNullHandle (nameof (proposedSelectionIndexes));
			NSIndexSet? ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("browser:selectionIndexesForProposedSelection:inColumn:"), browser__handle__, proposedSelectionIndexes__handle__, inColumn), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (proposedSelectionIndexes);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSBrowserDelegateWrapper : BaseWrapper, INSBrowserDelegate {
		public NSBrowserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSBrowserDelegateWrapper))]
		static NSBrowserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSBrowserDelegate" /> (for the protocol <c>NSBrowserDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSBrowserDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSBrowserDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSBrowserDelegate : NSObject, INSBrowserDelegate {
		/// <summary>Creates a new <see cref="NSBrowserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSBrowserDelegate () : base (NSObjectFlag.Empty)
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
		protected NSBrowserDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSBrowserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("browser:acceptDrop:atRow:column:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSBrowser browser, INSDraggingInfo info, nint row, nint column, NSBrowserDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:canDragRowsWithIndexes:inColumn:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragRowsWithIndexes (NSBrowser browser, NSIndexSet rowIndexes, nint column, NSEvent theEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browserColumnConfigurationDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ColumnConfigurationDidChange (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:titleOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ColumnTitle (NSBrowser sender, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:numberOfChildrenOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CountChildren (NSBrowser browser, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><param name="matrix">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browser:createRowsForColumn:inMatrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreateRowsForColumn (NSBrowser sender, nint column, NSMatrix matrix)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="oldLastColumn">To be added.</param><param name="toColumn">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browser:didChangeLastColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeLastColumn (NSBrowser browser, nint oldLastColumn, nint toColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browserDidScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScroll (NSBrowser sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:child:ofItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetChild (NSBrowser browser, nint index, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:headerViewControllerForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController HeaderViewControllerForItem (NSBrowser browser, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:isColumnValid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsColumnValid (NSBrowser sender, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:isLeafItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLeafItem (NSBrowser browser, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="startRow">To be added.</param><param name="endRow">To be added.</param><param name="column">To be added.</param><param name="searchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NextTypeSelectMatch (NSBrowser browser, nint startRow, nint endRow, nint column, string searchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:objectValueForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ObjectValueForItem (NSBrowser browser, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:previewViewControllerForLeafItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController PreviewViewControllerForLeafItem (NSBrowser browser, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="dropDestination">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PromisedFilesDroppedAtDestination (NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rootItemForBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject RootItemForBrowser (NSBrowser browser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:heightOfRow:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RowHeight (NSBrowser browser, nint row, nint columnIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:numberOfRowsInColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowsInColumn (NSBrowser sender, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:selectCellWithString:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectCellWithString (NSBrowser sender, string title, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:selectRow:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectRowInColumn (NSBrowser sender, nint row, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="proposedSelectionIndexes">To be added.</param><param name="inColumn">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:selectionIndexesForProposedSelection:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet SelectionIndexesForProposedSelection (NSBrowser browser, NSIndexSet proposedSelectionIndexes, nint inColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="obj">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browser:setObjectValue:forItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSBrowser browser, NSObject obj, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:shouldEditItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEditItem (NSBrowser browser, NSObject item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:shouldShowCellExpansionForRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowCellExpansion (NSBrowser browser, nint row, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><param name="userResize">To be added.</param><param name="suggestedWidth">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:shouldSizeColumn:forUserResize:toWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ShouldSizeColumn (NSBrowser browser, nint columnIndex, bool userResize, nfloat suggestedWidth)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="theEvent">To be added.</param><param name="currentSearchString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:shouldTypeSelectForEvent:withCurrentSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTypeSelectForEvent (NSBrowser browser, NSEvent theEvent, string currentSearchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:sizeToFitWidthOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SizeToFitWidth (NSBrowser browser, nint columnIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:typeSelectStringForRow:inColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TypeSelectString (NSBrowser browser, nint row, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("browser:validateDrop:proposedRow:column:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSBrowser browser, INSDraggingInfo info, ref nint row, ref nint column, ref NSBrowserDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="cell">To be added.</param><param name="row">To be added.</param><param name="column">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browser:willDisplayCell:atRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (NSBrowser sender, NSObject cell, nint row, nint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("browserWillScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillScroll (NSBrowser sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="rowIndexes">To be added.</param><param name="column">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("browser:writeRowsWithIndexes:inColumn:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRowsWithIndexesToPasteboard (NSBrowser browser, NSIndexSet rowIndexes, nint column, NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSBrowserDelegate */
}
