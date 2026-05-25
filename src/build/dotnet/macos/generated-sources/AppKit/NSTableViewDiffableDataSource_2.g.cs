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
	[Register("NSTableViewDiffableDataSource", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTableViewDiffableDataSource<SectionIdentifierType, ItemIdentifierType> : NSObject, INSTableViewDataSource 
			where SectionIdentifierType : NSObject
			where ItemIdentifierType : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplySnapshot_AnimatingDifferences_X = "applySnapshot:animatingDifferences:";
		static readonly NativeHandle selApplySnapshot_AnimatingDifferences_XHandle = Selector.GetHandle ("applySnapshot:animatingDifferences:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplySnapshot_AnimatingDifferences_Completion_X = "applySnapshot:animatingDifferences:completion:";
		static readonly NativeHandle selApplySnapshot_AnimatingDifferences_Completion_XHandle = Selector.GetHandle ("applySnapshot:animatingDifferences:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRowAnimationX = "defaultRowAnimation";
		static readonly NativeHandle selDefaultRowAnimationXHandle = Selector.GetHandle ("defaultRowAnimation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTableView_CellProvider_X = "initWithTableView:cellProvider:";
		static readonly NativeHandle selInitWithTableView_CellProvider_XHandle = Selector.GetHandle ("initWithTableView:cellProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemIdentifierForRow_X = "itemIdentifierForRow:";
		static readonly NativeHandle selItemIdentifierForRow_XHandle = Selector.GetHandle ("itemIdentifierForRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRowsInTableView_X = "numberOfRowsInTableView:";
		static readonly NativeHandle selNumberOfRowsInTableView_XHandle = Selector.GetHandle ("numberOfRowsInTableView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowForItemIdentifier_X = "rowForItemIdentifier:";
		static readonly NativeHandle selRowForItemIdentifier_XHandle = Selector.GetHandle ("rowForItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowForSectionIdentifier_X = "rowForSectionIdentifier:";
		static readonly NativeHandle selRowForSectionIdentifier_XHandle = Selector.GetHandle ("rowForSectionIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowViewProviderX = "rowViewProvider";
		static readonly NativeHandle selRowViewProviderXHandle = Selector.GetHandle ("rowViewProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSectionHeaderViewProviderX = "sectionHeaderViewProvider";
		static readonly NativeHandle selSectionHeaderViewProviderXHandle = Selector.GetHandle ("sectionHeaderViewProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSectionIdentifierForRow_X = "sectionIdentifierForRow:";
		static readonly NativeHandle selSectionIdentifierForRow_XHandle = Selector.GetHandle ("sectionIdentifierForRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultRowAnimation_X = "setDefaultRowAnimation:";
		static readonly NativeHandle selSetDefaultRowAnimation_XHandle = Selector.GetHandle ("setDefaultRowAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowViewProvider_X = "setRowViewProvider:";
		static readonly NativeHandle selSetRowViewProvider_XHandle = Selector.GetHandle ("setRowViewProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSectionHeaderViewProvider_X = "setSectionHeaderViewProvider:";
		static readonly NativeHandle selSetSectionHeaderViewProvider_XHandle = Selector.GetHandle ("setSectionHeaderViewProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSnapshotX = "snapshot";
		static readonly NativeHandle selSnapshotXHandle = Selector.GetHandle ("snapshot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_AcceptDrop_Row_DropOperation_X = "tableView:acceptDrop:row:dropOperation:";
		static readonly NativeHandle selTableView_AcceptDrop_Row_DropOperation_XHandle = Selector.GetHandle ("tableView:acceptDrop:row:dropOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_DraggingSession_EndedAtPoint_Operation_X = "tableView:draggingSession:endedAtPoint:operation:";
		static readonly NativeHandle selTableView_DraggingSession_EndedAtPoint_Operation_XHandle = Selector.GetHandle ("tableView:draggingSession:endedAtPoint:operation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_DraggingSession_WillBeginAtPoint_ForRowIndexes_X = "tableView:draggingSession:willBeginAtPoint:forRowIndexes:";
		static readonly NativeHandle selTableView_DraggingSession_WillBeginAtPoint_ForRowIndexes_XHandle = Selector.GetHandle ("tableView:draggingSession:willBeginAtPoint:forRowIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_NamesOfPromisedFilesDroppedAtDestination_ForDraggedRowsWithIndexes_X = "tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:";
		static readonly NativeHandle selTableView_NamesOfPromisedFilesDroppedAtDestination_ForDraggedRowsWithIndexes_XHandle = Selector.GetHandle ("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_ObjectValueForTableColumn_Row_X = "tableView:objectValueForTableColumn:row:";
		static readonly NativeHandle selTableView_ObjectValueForTableColumn_Row_XHandle = Selector.GetHandle ("tableView:objectValueForTableColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_PasteboardWriterForRow_X = "tableView:pasteboardWriterForRow:";
		static readonly NativeHandle selTableView_PasteboardWriterForRow_XHandle = Selector.GetHandle ("tableView:pasteboardWriterForRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_SetObjectValue_ForTableColumn_Row_X = "tableView:setObjectValue:forTableColumn:row:";
		static readonly NativeHandle selTableView_SetObjectValue_ForTableColumn_Row_XHandle = Selector.GetHandle ("tableView:setObjectValue:forTableColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_SortDescriptorsDidChange_X = "tableView:sortDescriptorsDidChange:";
		static readonly NativeHandle selTableView_SortDescriptorsDidChange_XHandle = Selector.GetHandle ("tableView:sortDescriptorsDidChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_UpdateDraggingItemsForDrag_X = "tableView:updateDraggingItemsForDrag:";
		static readonly NativeHandle selTableView_UpdateDraggingItemsForDrag_XHandle = Selector.GetHandle ("tableView:updateDraggingItemsForDrag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_ValidateDrop_ProposedRow_ProposedDropOperation_X = "tableView:validateDrop:proposedRow:proposedDropOperation:";
		static readonly NativeHandle selTableView_ValidateDrop_ProposedRow_ProposedDropOperation_XHandle = Selector.GetHandle ("tableView:validateDrop:proposedRow:proposedDropOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableView_WriteRowsWithIndexes_ToPasteboard_X = "tableView:writeRowsWithIndexes:toPasteboard:";
		static readonly NativeHandle selTableView_WriteRowsWithIndexes_ToPasteboard_XHandle = Selector.GetHandle ("tableView:writeRowsWithIndexes:toPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTableViewDiffableDataSource");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NSTableViewDiffableDataSource (NSObjectFlag t) : base (t)
		{
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
		protected internal NSTableViewDiffableDataSource (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTableView:cellProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTableViewDiffableDataSource (NSTableView tableView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTableViewDiffableDataSourceCellProvider))]NSTableViewDiffableDataSourceCellProvider cellProvider)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (cellProvider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cellProvider));
			using var block_cellProvider = Trampolines.SDNSTableViewDiffableDataSourceCellProvider.CreateBlock (cellProvider);
			BlockLiteral *block_ptr_cellProvider = &block_cellProvider;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTableView_CellProvider_XHandle, tableView__handle__, (IntPtr) block_ptr_cellProvider), "initWithTableView:cellProvider:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTableView_CellProvider_XHandle, tableView__handle__, (IntPtr) block_ptr_cellProvider), "initWithTableView:cellProvider:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
		}
		[Export ("tableView:acceptDrop:row:dropOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (this.Handle, selTableView_AcceptDrop_Row_DropOperation_XHandle, tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_UIntPtr (&__objc_super__, selTableView_AcceptDrop_Row_DropOperation_XHandle, tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (info);
			return ret != 0;
		}
		[Export ("applySnapshot:animatingDifferences:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplySnapshot (NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> snapshot, bool animatingDifferences)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var snapshot__handle__ = snapshot!.GetNonNullHandle (nameof (snapshot));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selApplySnapshot_AnimatingDifferences_XHandle, snapshot__handle__, animatingDifferences ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selApplySnapshot_AnimatingDifferences_XHandle, snapshot__handle__, animatingDifferences ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (snapshot);
		}
		[Export ("applySnapshot:animatingDifferences:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ApplySnapshot (NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> snapshot, bool animatingDifferences, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var snapshot__handle__ = snapshot!.GetNonNullHandle (nameof (snapshot));
			using var block_completion = Trampolines.SDAction.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selApplySnapshot_AnimatingDifferences_Completion_XHandle, snapshot__handle__, animatingDifferences ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selApplySnapshot_AnimatingDifferences_Completion_XHandle, snapshot__handle__, animatingDifferences ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (snapshot);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ApplySnapshotAsync (NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> snapshot, bool animatingDifferences)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ApplySnapshot(snapshot, animatingDifferences, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="endedAtScreenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:draggingSession:endedAtPoint:operation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_UIntPtr (this.Handle, selTableView_DraggingSession_EndedAtPoint_Operation_XHandle, tableView__handle__, draggingSession__handle__, endedAtScreenPoint, (UIntPtr) (ulong) operation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint_UIntPtr (&__objc_super__, selTableView_DraggingSession_EndedAtPoint_Operation_XHandle, tableView__handle__, draggingSession__handle__, endedAtScreenPoint, (UIntPtr) (ulong) operation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingSession);
		}
		/// <param name="tableView">To be added.</param><param name="draggingSession">To be added.</param><param name="willBeginAtScreenPoint">To be added.</param><param name="rowIndexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:draggingSession:willBeginAtPoint:forRowIndexes:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingSession__handle__ = draggingSession!.GetNonNullHandle (nameof (draggingSession));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (this.Handle, selTableView_DraggingSession_WillBeginAtPoint_ForRowIndexes_XHandle, tableView__handle__, draggingSession__handle__, willBeginAtScreenPoint, rowIndexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint_NativeHandle (&__objc_super__, selTableView_DraggingSession_WillBeginAtPoint_ForRowIndexes_XHandle, tableView__handle__, draggingSession__handle__, willBeginAtScreenPoint, rowIndexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingSession);
			GC.KeepAlive (rowIndexes);
		}
		/// <param name="tableView">To be added.</param><param name="dropDestination">To be added.</param><param name="indexSet">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] FilesDropped (NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTableView_NamesOfPromisedFilesDroppedAtDestination_ForDraggedRowsWithIndexes_XHandle, tableView__handle__, dropDestination__handle__, indexSet__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTableView_NamesOfPromisedFilesDroppedAtDestination_ForDraggedRowsWithIndexes_XHandle, tableView__handle__, dropDestination__handle__, indexSet__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (dropDestination);
			GC.KeepAlive (indexSet);
			return ret!;
		}
		[Export ("itemIdentifierForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ItemIdentifierType? GetItemIdentifier (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			ItemIdentifierType ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ItemIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selItemIdentifierForRow_XHandle, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<ItemIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selItemIdentifierForRow_XHandle, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="tableView">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:objectValueForTableColumn:row:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetObjectValue (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selTableView_ObjectValueForTableColumn_Row_XHandle, tableView__handle__, tableColumn__handle__, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selTableView_ObjectValueForTableColumn_Row_XHandle, tableView__handle__, tableColumn__handle__, row), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:pasteboardWriterForRow:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting GetPasteboardWriterForRow (NSTableView tableView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			INSPasteboardWriting? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selTableView_PasteboardWriterForRow_XHandle, tableView__handle__, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSPasteboardWriting> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selTableView_PasteboardWriterForRow_XHandle, tableView__handle__, row), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfRowsInTableView:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowCount (NSTableView tableView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selNumberOfRowsInTableView_XHandle, tableView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNumberOfRowsInTableView_XHandle, tableView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		[Export ("rowForItemIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowForItemIdentifier (ItemIdentifierType itemIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selRowForItemIdentifier_XHandle, itemIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRowForItemIdentifier_XHandle, itemIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
			return ret!;
		}
		[Export ("rowForSectionIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowForSectionIdentifier (SectionIdentifierType sectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sectionIdentifier__handle__ = sectionIdentifier!.GetNonNullHandle (nameof (sectionIdentifier));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selRowForSectionIdentifier_XHandle, sectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRowForSectionIdentifier_XHandle, sectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sectionIdentifier);
			return ret!;
		}
		[Export ("sectionIdentifierForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SectionIdentifierType? GetSectionIdentifier (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			SectionIdentifierType ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SectionIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selSectionIdentifierForRow_XHandle, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SectionIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selSectionIdentifierForRow_XHandle, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="tableView">To be added.</param><param name="theObject">To be added.</param><param name="tableColumn">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:setObjectValue:forTableColumn:row:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjectValue (NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var theObject__handle__ = theObject!.GetNonNullHandle (nameof (theObject));
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selTableView_SetObjectValue_ForTableColumn_Row_XHandle, tableView__handle__, theObject__handle__, tableColumn__handle__, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selTableView_SetObjectValue_ForTableColumn_Row_XHandle, tableView__handle__, theObject__handle__, tableColumn__handle__, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (theObject);
			GC.KeepAlive (tableColumn);
		}
		[Export ("snapshot")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> Snapshot ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSnapshotXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSnapshotXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="tableView">To be added.</param><param name="oldDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:sortDescriptorsDidChange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SortDescriptorsChanged (NSTableView tableView, NSSortDescriptor[] oldDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (oldDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldDescriptors));
			using var nsa_oldDescriptors = NSArray.FromNSObjects (oldDescriptors);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTableView_SortDescriptorsDidChange_XHandle, tableView__handle__, nsa_oldDescriptors.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTableView_SortDescriptorsDidChange_XHandle, tableView__handle__, nsa_oldDescriptors.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
		}
		[Export ("tableView:updateDraggingItemsForDrag:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItems (NSTableView tableView, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTableView_UpdateDraggingItemsForDrag_XHandle, tableView__handle__, draggingInfo__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTableView_UpdateDraggingItemsForDrag_XHandle, tableView__handle__, draggingInfo__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (draggingInfo);
		}
		[Export ("tableView:validateDrop:proposedRow:proposedDropOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSTableView tableView, INSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (this.Handle, selTableView_ValidateDrop_ProposedRow_ProposedDropOperation_XHandle, tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_UIntPtr (&__objc_super__, selTableView_ValidateDrop_ProposedRow_ProposedDropOperation_XHandle, tableView__handle__, info__handle__, row, (UIntPtr) (ulong) dropOperation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (info);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="rowIndexes">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:writeRowsWithIndexes:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriterForRow' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRows (NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTableView_WriteRowsWithIndexes_ToPasteboard_XHandle, tableView__handle__, rowIndexes__handle__, pboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTableView_WriteRowsWithIndexes_ToPasteboard_XHandle, tableView__handle__, rowIndexes__handle__, pboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewAnimationOptions DefaultRowAnimation {
			[Export ("defaultRowAnimation", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewAnimationOptions ret;
				if (IsDirectBinding) {
					ret = (NSTableViewAnimationOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDefaultRowAnimationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewAnimationOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDefaultRowAnimationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultRowAnimation:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDefaultRowAnimation_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDefaultRowAnimation_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSTableViewDiffableDataSourceRowProvider? RowViewProvider {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDNSTableViewDiffableDataSourceRowProvider))]
			[Export ("rowViewProvider", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRowViewProviderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRowViewProviderXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDNSTableViewDiffableDataSourceRowProvider.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTableViewDiffableDataSourceRowProvider))]
			[Export ("setRowViewProvider:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var block_value = Trampolines.SDNSTableViewDiffableDataSourceRowProvider.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRowViewProvider_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRowViewProvider_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSTableViewDiffableDataSourceSectionHeaderViewProvider? SectionHeaderViewProvider {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDNSTableViewDiffableDataSourceSectionHeaderViewProvider))]
			[Export ("sectionHeaderViewProvider", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSectionHeaderViewProviderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSectionHeaderViewProviderXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDNSTableViewDiffableDataSourceSectionHeaderViewProvider.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTableViewDiffableDataSourceSectionHeaderViewProvider))]
			[Export ("setSectionHeaderViewProvider:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var block_value = Trampolines.SDNSTableViewDiffableDataSourceSectionHeaderViewProvider.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSectionHeaderViewProvider_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSectionHeaderViewProvider_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSTableViewDiffableDataSource */
}
