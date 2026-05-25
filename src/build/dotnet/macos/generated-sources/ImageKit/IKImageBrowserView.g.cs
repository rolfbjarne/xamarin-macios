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
namespace ImageKit {
	[Register("IKImageBrowserView", true)]
	[ObsoletedOSPlatform ("macos10.14", "Use 'NSCollectionView' instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class IKImageBrowserView : global::AppKit.NSView, global::AppKit.INSDraggingSource {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDroppingOnItemsX = "allowsDroppingOnItems";
		static readonly NativeHandle selAllowsDroppingOnItemsXHandle = Selector.GetHandle ("allowsDroppingOnItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsEmptySelectionX = "allowsEmptySelection";
		static readonly NativeHandle selAllowsEmptySelectionXHandle = Selector.GetHandle ("allowsEmptySelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsMultipleSelectionX = "allowsMultipleSelection";
		static readonly NativeHandle selAllowsMultipleSelectionXHandle = Selector.GetHandle ("allowsMultipleSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsReorderingX = "allowsReordering";
		static readonly NativeHandle selAllowsReorderingXHandle = Selector.GetHandle ("allowsReordering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimatesX = "animates";
		static readonly NativeHandle selAnimatesXHandle = Selector.GetHandle ("animates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundLayerX = "backgroundLayer";
		static readonly NativeHandle selBackgroundLayerXHandle = Selector.GetHandle ("backgroundLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanControlQuickLookPanelX = "canControlQuickLookPanel";
		static readonly NativeHandle selCanControlQuickLookPanelXHandle = Selector.GetHandle ("canControlQuickLookPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellForItemAtIndex_X = "cellForItemAtIndex:";
		static readonly NativeHandle selCellForItemAtIndex_XHandle = Selector.GetHandle ("cellForItemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellSizeX = "cellSize";
		static readonly NativeHandle selCellSizeXHandle = Selector.GetHandle ("cellSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellsStyleMaskX = "cellsStyleMask";
		static readonly NativeHandle selCellsStyleMaskXHandle = Selector.GetHandle ("cellsStyleMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollapseGroupAtIndex_X = "collapseGroupAtIndex:";
		static readonly NativeHandle selCollapseGroupAtIndex_XHandle = Selector.GetHandle ("collapseGroupAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnIndexesInRect_X = "columnIndexesInRect:";
		static readonly NativeHandle selColumnIndexesInRect_XHandle = Selector.GetHandle ("columnIndexesInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConstrainsToOriginalSizeX = "constrainsToOriginalSize";
		static readonly NativeHandle selConstrainsToOriginalSizeXHandle = Selector.GetHandle ("constrainsToOriginalSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentResizingMaskX = "contentResizingMask";
		static readonly NativeHandle selContentResizingMaskXHandle = Selector.GetHandle ("contentResizingMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_BeganAt_X = "draggedImage:beganAt:";
		static readonly NativeHandle selDraggedImage_BeganAt_XHandle = Selector.GetHandle ("draggedImage:beganAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_EndedAt_Deposited_X = "draggedImage:endedAt:deposited:";
		static readonly NativeHandle selDraggedImage_EndedAt_Deposited_XHandle = Selector.GetHandle ("draggedImage:endedAt:deposited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_EndedAt_Operation_X = "draggedImage:endedAt:operation:";
		static readonly NativeHandle selDraggedImage_EndedAt_Operation_XHandle = Selector.GetHandle ("draggedImage:endedAt:operation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_MovedTo_X = "draggedImage:movedTo:";
		static readonly NativeHandle selDraggedImage_MovedTo_XHandle = Selector.GetHandle ("draggedImage:movedTo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingDestinationDelegateX = "draggingDestinationDelegate";
		static readonly NativeHandle selDraggingDestinationDelegateXHandle = Selector.GetHandle ("draggingDestinationDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingSourceOperationMaskForLocal_X = "draggingSourceOperationMaskForLocal:";
		static readonly NativeHandle selDraggingSourceOperationMaskForLocal_XHandle = Selector.GetHandle ("draggingSourceOperationMaskForLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDropOperationX = "dropOperation";
		static readonly NativeHandle selDropOperationXHandle = Selector.GetHandle ("dropOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpandGroupAtIndex_X = "expandGroupAtIndex:";
		static readonly NativeHandle selExpandGroupAtIndex_XHandle = Selector.GetHandle ("expandGroupAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForegroundLayerX = "foregroundLayer";
		static readonly NativeHandle selForegroundLayerXHandle = Selector.GetHandle ("foregroundLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoreModifierKeysWhileDraggingX = "ignoreModifierKeysWhileDragging";
		static readonly NativeHandle selIgnoreModifierKeysWhileDraggingXHandle = Selector.GetHandle ("ignoreModifierKeysWhileDragging");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexAtLocationOfDroppedItemX = "indexAtLocationOfDroppedItem";
		static readonly NativeHandle selIndexAtLocationOfDroppedItemXHandle = Selector.GetHandle ("indexAtLocationOfDroppedItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItemAtPoint_X = "indexOfItemAtPoint:";
		static readonly NativeHandle selIndexOfItemAtPoint_XHandle = Selector.GetHandle ("indexOfItemAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntercellSpacingX = "intercellSpacing";
		static readonly NativeHandle selIntercellSpacingXHandle = Selector.GetHandle ("intercellSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsGroupExpandedAtIndex_X = "isGroupExpandedAtIndex:";
		static readonly NativeHandle selIsGroupExpandedAtIndex_XHandle = Selector.GetHandle ("isGroupExpandedAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemFrameAtIndex_X = "itemFrameAtIndex:";
		static readonly NativeHandle selItemFrameAtIndex_XHandle = Selector.GetHandle ("itemFrameAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNamesOfPromisedFilesDroppedAtDestination_X = "namesOfPromisedFilesDroppedAtDestination:";
		static readonly NativeHandle selNamesOfPromisedFilesDroppedAtDestination_XHandle = Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewCellForRepresentedItem_X = "newCellForRepresentedItem:";
		static readonly NativeHandle selNewCellForRepresentedItem_XHandle = Selector.GetHandle ("newCellForRepresentedItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColumnsX = "numberOfColumns";
		static readonly NativeHandle selNumberOfColumnsXHandle = Selector.GetHandle ("numberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRowsX = "numberOfRows";
		static readonly NativeHandle selNumberOfRowsXHandle = Selector.GetHandle ("numberOfRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectOfColumn_X = "rectOfColumn:";
		static readonly NativeHandle selRectOfColumn_XHandle = Selector.GetHandle ("rectOfColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectOfRow_X = "rectOfRow:";
		static readonly NativeHandle selRectOfRow_XHandle = Selector.GetHandle ("rectOfRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadDataX = "reloadData";
		static readonly NativeHandle selReloadDataXHandle = Selector.GetHandle ("reloadData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowIndexesInRect_X = "rowIndexesInRect:";
		static readonly NativeHandle selRowIndexesInRect_XHandle = Selector.GetHandle ("rowIndexesInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollIndexToVisible_X = "scrollIndexToVisible:";
		static readonly NativeHandle selScrollIndexToVisible_XHandle = Selector.GetHandle ("scrollIndexToVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionIndexesX = "selectionIndexes";
		static readonly NativeHandle selSelectionIndexesXHandle = Selector.GetHandle ("selectionIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsDroppingOnItems_X = "setAllowsDroppingOnItems:";
		static readonly NativeHandle selSetAllowsDroppingOnItems_XHandle = Selector.GetHandle ("setAllowsDroppingOnItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsEmptySelection_X = "setAllowsEmptySelection:";
		static readonly NativeHandle selSetAllowsEmptySelection_XHandle = Selector.GetHandle ("setAllowsEmptySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsMultipleSelection_X = "setAllowsMultipleSelection:";
		static readonly NativeHandle selSetAllowsMultipleSelection_XHandle = Selector.GetHandle ("setAllowsMultipleSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsReordering_X = "setAllowsReordering:";
		static readonly NativeHandle selSetAllowsReordering_XHandle = Selector.GetHandle ("setAllowsReordering:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimates_X = "setAnimates:";
		static readonly NativeHandle selSetAnimates_XHandle = Selector.GetHandle ("setAnimates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundLayer_X = "setBackgroundLayer:";
		static readonly NativeHandle selSetBackgroundLayer_XHandle = Selector.GetHandle ("setBackgroundLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanControlQuickLookPanel_X = "setCanControlQuickLookPanel:";
		static readonly NativeHandle selSetCanControlQuickLookPanel_XHandle = Selector.GetHandle ("setCanControlQuickLookPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellSize_X = "setCellSize:";
		static readonly NativeHandle selSetCellSize_XHandle = Selector.GetHandle ("setCellSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellsStyleMask_X = "setCellsStyleMask:";
		static readonly NativeHandle selSetCellsStyleMask_XHandle = Selector.GetHandle ("setCellsStyleMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstrainsToOriginalSize_X = "setConstrainsToOriginalSize:";
		static readonly NativeHandle selSetConstrainsToOriginalSize_XHandle = Selector.GetHandle ("setConstrainsToOriginalSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentResizingMask_X = "setContentResizingMask:";
		static readonly NativeHandle selSetContentResizingMask_XHandle = Selector.GetHandle ("setContentResizingMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataSource_X = "setDataSource:";
		static readonly NativeHandle selSetDataSource_XHandle = Selector.GetHandle ("setDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDraggingDestinationDelegate_X = "setDraggingDestinationDelegate:";
		static readonly NativeHandle selSetDraggingDestinationDelegate_XHandle = Selector.GetHandle ("setDraggingDestinationDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDropIndex_DropOperation_X = "setDropIndex:dropOperation:";
		static readonly NativeHandle selSetDropIndex_DropOperation_XHandle = Selector.GetHandle ("setDropIndex:dropOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetForegroundLayer_X = "setForegroundLayer:";
		static readonly NativeHandle selSetForegroundLayer_XHandle = Selector.GetHandle ("setForegroundLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIntercellSpacing_X = "setIntercellSpacing:";
		static readonly NativeHandle selSetIntercellSpacing_XHandle = Selector.GetHandle ("setIntercellSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionIndexes_ByExtendingSelection_X = "setSelectionIndexes:byExtendingSelection:";
		static readonly NativeHandle selSetSelectionIndexes_ByExtendingSelection_XHandle = Selector.GetHandle ("setSelectionIndexes:byExtendingSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZoomValue_X = "setZoomValue:";
		static readonly NativeHandle selSetZoomValue_XHandle = Selector.GetHandle ("setZoomValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibleItemIndexesX = "visibleItemIndexes";
		static readonly NativeHandle selVisibleItemIndexesXHandle = Selector.GetHandle ("visibleItemIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoomValueX = "zoomValue";
		static readonly NativeHandle selZoomValueXHandle = Selector.GetHandle ("zoomValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("IKImageBrowserView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="IKImageBrowserView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IKImageBrowserView () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public IKImageBrowserView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected IKImageBrowserView (NSObjectFlag t) : base (t)
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
		protected internal IKImageBrowserView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IKImageBrowserView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collapseGroupAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollapseGroup (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCollapseGroupAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selCollapseGroupAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:beganAt:")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSCollectionView' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageBeganAt (global::AppKit.NSImage image, CGPoint screenPoint)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDraggedImage_BeganAt_XHandle, image__handle__, screenPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDraggedImage_BeganAt_XHandle, image__handle__, screenPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:deposited:")]
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtDeposited (global::AppKit.NSImage image, CGPoint screenPoint, bool deposited)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_bool (this.Handle, selDraggedImage_EndedAt_Deposited_XHandle, image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_bool (&__objc_super__, selDraggedImage_EndedAt_Deposited_XHandle, image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:operation:")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSCollectionView' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtOperation (global::AppKit.NSImage image, CGPoint screenPoint, global::AppKit.NSDragOperation operation)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_UIntPtr (this.Handle, selDraggedImage_EndedAt_Operation_XHandle, image__handle__, screenPoint, (UIntPtr) (ulong) operation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_UIntPtr (&__objc_super__, selDraggedImage_EndedAt_Operation_XHandle, image__handle__, screenPoint, (UIntPtr) (ulong) operation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:movedTo:")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSCollectionView' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageMovedTo (global::AppKit.NSImage image, CGPoint screenPoint)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDraggedImage_MovedTo_XHandle, image__handle__, screenPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDraggedImage_MovedTo_XHandle, image__handle__, screenPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("draggingSourceOperationMaskForLocal:")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSCollectionView' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSDragOperation DraggingSourceOperationMaskForLocal (bool flag)
		{
			global::AppKit.NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_bool (this.Handle, selDraggingSourceOperationMaskForLocal_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_bool (&__objc_super__, selDraggingSourceOperationMaskForLocal_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropOperation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKImageBrowserDropOperation DropOperation ()
		{
			IKImageBrowserDropOperation ret;
			if (IsDirectBinding) {
				ret = (IKImageBrowserDropOperation) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDropOperationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (IKImageBrowserDropOperation) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selDropOperationXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("expandGroupAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExpandGroup (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selExpandGroupAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selExpandGroupAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="itemIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("cellForItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKImageBrowserCell GetCellAt (nint itemIndex)
		{
			IKImageBrowserCell ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<IKImageBrowserCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selCellForItemAtIndex_XHandle, itemIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<IKImageBrowserCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selCellForItemAtIndex_XHandle, itemIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("columnIndexesInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetColumnIndexes (CGRect rect)
		{
			NSIndexSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selColumnIndexesInRect_XHandle, rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selColumnIndexesInRect_XHandle, rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexAtLocationOfDroppedItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndexAtLocationOfDroppedItem ()
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexAtLocationOfDroppedItemXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIndexAtLocationOfDroppedItemXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexOfItemAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndexOfItem (CGPoint point)
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, selIndexOfItemAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selIndexOfItemAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemFrameAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetItemFrame (nint index)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selItemFrameAtIndex_XHandle, index);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selItemFrameAtIndex_XHandle, index);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selItemFrameAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selItemFrameAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="columnIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rectOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetRectOfColumn (nint columnIndex)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selRectOfColumn_XHandle, columnIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selRectOfColumn_XHandle, columnIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selRectOfColumn_XHandle, columnIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selRectOfColumn_XHandle, columnIndex);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="rowIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rectOfRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetRectOfRow (nint rowIndex)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selRectOfRow_XHandle, rowIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selRectOfRow_XHandle, rowIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selRectOfRow_XHandle, rowIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selRectOfRow_XHandle, rowIndex);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rowIndexesInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetRowIndexes (CGRect rect)
		{
			NSIndexSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selRowIndexesInRect_XHandle, rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selRowIndexesInRect_XHandle, rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("visibleItemIndexes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetVisibleItemIndexes ()
		{
			NSIndexSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVisibleItemIndexesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVisibleItemIndexesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isGroupExpandedAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsGroupExpanded (nint index)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsGroupExpandedAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsGroupExpandedAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNamesOfPromisedFilesDroppedAtDestination_XHandle, dropDestination__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNamesOfPromisedFilesDroppedAtDestination_XHandle, dropDestination__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		/// <param name="representedItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newCellForRepresentedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKImageBrowserCell NewCell (IIKImageBrowserItem representedItem)
		{
			var representedItem__handle__ = representedItem!.GetNonNullHandle (nameof (representedItem));
			IKImageBrowserCell? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<IKImageBrowserCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNewCellForRepresentedItem_XHandle, representedItem__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<IKImageBrowserCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNewCellForRepresentedItem_XHandle, representedItem__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (representedItem);
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadDataXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReloadDataXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scrollIndexToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollIndexToVisible (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollIndexToVisible_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selScrollIndexToVisible_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="indexes">To be added.</param><param name="extendSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setSelectionIndexes:byExtendingSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectItemsAt (NSIndexSet indexes, bool extendSelection)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetSelectionIndexes_ByExtendingSelection_XHandle, indexes__handle__, extendSelection ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetSelectionIndexes_ByExtendingSelection_XHandle, indexes__handle__, extendSelection ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		/// <param name="index">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setDropIndex:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDropIndex (nint index, IKImageBrowserDropOperation operation)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, selSetDropIndex_DropOperation_XHandle, index, (int)operation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int (&__objc_super__, selSetDropIndex_DropOperation_XHandle, index, (int)operation);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsDroppingOnItems {
			[Export ("allowsDroppingOnItems")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDroppingOnItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDroppingOnItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsDroppingOnItems:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsDroppingOnItems_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsDroppingOnItems_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsEmptySelection {
			[Export ("allowsEmptySelection")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsEmptySelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsEmptySelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEmptySelection:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsEmptySelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsEmptySelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsMultipleSelection {
			[Export ("allowsMultipleSelection")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsMultipleSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsMultipleSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsMultipleSelection:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsMultipleSelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsMultipleSelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsReordering {
			[Export ("allowsReordering")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsReorderingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsReorderingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsReordering:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsReordering_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsReordering_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Animates {
			[Export ("animates")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAnimatesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAnimatesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAnimates:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAnimates_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAnimates_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CALayer BackgroundLayer {
			[Export ("backgroundLayer")]
			get {
				global::CoreAnimation.CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundLayerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundLayerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundLayer:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundLayer_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundLayer_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanControlQuickLookPanel {
			[Export ("canControlQuickLookPanel")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanControlQuickLookPanelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanControlQuickLookPanelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanControlQuickLookPanel:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanControlQuickLookPanel_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanControlQuickLookPanel_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize CellSize {
			[Export ("cellSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selCellSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selCellSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetCellSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetCellSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKCellsStyle CellsStyleMask {
			[Export ("cellsStyleMask")]
			get {
				IKCellsStyle ret;
				if (IsDirectBinding) {
					ret = (ImageKit.IKCellsStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCellsStyleMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ImageKit.IKCellsStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCellsStyleMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCellsStyleMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetCellsStyleMask_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetCellsStyleMask_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColumnCount {
			[Export ("numberOfColumns")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ConstrainsToOriginalSize {
			[Export ("constrainsToOriginalSize")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selConstrainsToOriginalSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selConstrainsToOriginalSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setConstrainsToOriginalSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetConstrainsToOriginalSize_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetConstrainsToOriginalSize_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSViewResizingMask ContentResizingMask {
			[Export ("contentResizingMask")]
			get {
				global::AppKit.NSViewResizingMask ret;
				if (IsDirectBinding) {
					ret = (NSViewResizingMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selContentResizingMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSViewResizingMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selContentResizingMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentResizingMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetContentResizingMask_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetContentResizingMask_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IIKImageBrowserDataSource DataSource {
			get {
				return (WeakDataSource as IIKImageBrowserDataSource)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDataSource = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IIKImageBrowserDelegate Delegate {
			get {
				return (WeakDelegate as IIKImageBrowserDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_DraggingDestinationDelegate_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.INSDraggingDestination DraggingDestinationDelegate {
			[Export ("draggingDestinationDelegate", ArgumentSemantic.Weak)]
			get {
				global::AppKit.INSDraggingDestination? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::AppKit.INSDraggingDestination> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDraggingDestinationDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::AppKit.INSDraggingDestination> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDraggingDestinationDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_DraggingDestinationDelegate_var = ret;
				return ret!;
			}
			[Export ("setDraggingDestinationDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDraggingDestinationDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDraggingDestinationDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_DraggingDestinationDelegate_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CALayer ForegroundLayer {
			[Export ("foregroundLayer")]
			get {
				global::CoreAnimation.CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selForegroundLayerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selForegroundLayerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setForegroundLayer:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetForegroundLayer_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetForegroundLayer_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSCollectionView' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IgnoreModifierKeysWhileDragging {
			[Export ("ignoreModifierKeysWhileDragging")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'NSCollectionView' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIgnoreModifierKeysWhileDraggingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIgnoreModifierKeysWhileDraggingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize IntercellSpacing {
			[Export ("intercellSpacing")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selIntercellSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selIntercellSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIntercellSpacing:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetIntercellSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetIntercellSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowCount {
			[Export ("numberOfRows")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet SelectionIndexes {
			[Export ("selectionIndexes")]
			get {
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDataSource_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret!;
			}
			[Export ("setDataSource:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDataSource_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDataSource_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDataSource_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ZoomValue {
			[Export ("zoomValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selZoomValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selZoomValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZoomValue:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetZoomValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetZoomValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserBackgroundColorKey",  "ImageKit")]
		public static NSString BackgroundColorKey {
			get {
				if (_BackgroundColorKey is null)
					_BackgroundColorKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserBackgroundColorKey")!;
				return _BackgroundColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellsHighlightedTitleAttributesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserCellsHighlightedTitleAttributesKey",  "ImageKit")]
		public static NSString CellsHighlightedTitleAttributesKey {
			get {
				if (_CellsHighlightedTitleAttributesKey is null)
					_CellsHighlightedTitleAttributesKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserCellsHighlightedTitleAttributesKey")!;
				return _CellsHighlightedTitleAttributesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellsOutlineColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserCellsOutlineColorKey",  "ImageKit")]
		public static NSString CellsOutlineColorKey {
			get {
				if (_CellsOutlineColorKey is null)
					_CellsOutlineColorKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserCellsOutlineColorKey")!;
				return _CellsOutlineColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellsSubtitleAttributesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserCellsSubtitleAttributesKey",  "ImageKit")]
		public static NSString CellsSubtitleAttributesKey {
			get {
				if (_CellsSubtitleAttributesKey is null)
					_CellsSubtitleAttributesKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserCellsSubtitleAttributesKey")!;
				return _CellsSubtitleAttributesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellsTitleAttributesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserCellsTitleAttributesKey",  "ImageKit")]
		public static NSString CellsTitleAttributesKey {
			get {
				if (_CellsTitleAttributesKey is null)
					_CellsTitleAttributesKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserCellsTitleAttributesKey")!;
				return _CellsTitleAttributesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserSelectionColorKey",  "ImageKit")]
		public static NSString SelectionColorKey {
			get {
				if (_SelectionColorKey is null)
					_SelectionColorKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserSelectionColorKey")!;
				return _SelectionColorKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_IKImageBrowserDelegate); }
		}
		internal virtual _IKImageBrowserDelegate CreateInternalEventDelegateType ()
		{
			return (_IKImageBrowserDelegate)(new _IKImageBrowserDelegate());
		}
		internal _IKImageBrowserDelegate EnsureIKImageBrowserDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _IKImageBrowserDelegate;
			if (del is null){
				del = (_IKImageBrowserDelegate)CreateInternalEventDelegateType ();
				Delegate = (IIKImageBrowserDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _IKImageBrowserDelegate : NSObject, IIKImageBrowserDelegate { 
			public _IKImageBrowserDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_IKImageBrowserDelegate))]
			static _IKImageBrowserDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<IKImageBrowserViewEventEventArgs>? backgroundWasRightClicked;
			[Export ("imageBrowser:backgroundWasRightClickedWithEvent:")]
			public void BackgroundWasRightClicked (ImageKit.IKImageBrowserView browser, NSEvent nsevent)
			{
				var handler = backgroundWasRightClicked;
				if (handler is not null){
					var args = new IKImageBrowserViewEventEventArgs (nsevent);
					handler (browser, args);
				}
			}
			internal EventHandler<IKImageBrowserViewIndexEventArgs>? cellWasDoubleClicked;
			[Export ("imageBrowser:cellWasDoubleClickedAtIndex:")]
			public void CellWasDoubleClicked (ImageKit.IKImageBrowserView browser, IntPtr index)
			{
				var handler = cellWasDoubleClicked;
				if (handler is not null){
					var args = new IKImageBrowserViewIndexEventArgs (index);
					handler (browser, args);
				}
			}
			internal EventHandler<IKImageBrowserViewIndexEventEventArgs>? cellWasRightClicked;
			[Export ("imageBrowser:cellWasRightClickedAtIndex:withEvent:")]
			public void CellWasRightClicked (ImageKit.IKImageBrowserView browser, IntPtr index, NSEvent nsevent)
			{
				var handler = cellWasRightClicked;
				if (handler is not null){
					var args = new IKImageBrowserViewIndexEventEventArgs (index, nsevent);
					handler (browser, args);
				}
			}
			internal EventHandler? selectionDidChange;
			[Export ("imageBrowserSelectionDidChange:")]
			public void SelectionDidChange (ImageKit.IKImageBrowserView browser)
			{
				var handler = selectionDidChange;
				if (handler is not null){
					handler (browser, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<IKImageBrowserViewEventEventArgs> BackgroundWasRightClicked {
			add { EnsureIKImageBrowserDelegate ()!.backgroundWasRightClicked += value; }
			remove { EnsureIKImageBrowserDelegate ()!.backgroundWasRightClicked -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<IKImageBrowserViewIndexEventArgs> CellWasDoubleClicked {
			add { EnsureIKImageBrowserDelegate ()!.cellWasDoubleClicked += value; }
			remove { EnsureIKImageBrowserDelegate ()!.cellWasDoubleClicked -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<IKImageBrowserViewIndexEventEventArgs> CellWasRightClicked {
			add { EnsureIKImageBrowserDelegate ()!.cellWasRightClicked += value; }
			remove { EnsureIKImageBrowserDelegate ()!.cellWasRightClicked -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler SelectionDidChange {
			add { EnsureIKImageBrowserDelegate ()!.selectionDidChange += value; }
			remove { EnsureIKImageBrowserDelegate ()!.selectionDidChange -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DraggingDestinationDelegate_var = null;
				__mt_WeakDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class IKImageBrowserView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKImageBrowserViewEventEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKImageBrowserViewEventEventArgs" /> with the specified event data.</summary>
		/// <param name="nsevent">The value for the <see cref="Nsevent" /> property.</param>
		public IKImageBrowserViewEventEventArgs (NSEvent nsevent)
		{
			this.Nsevent = nsevent;
		}
		public NSEvent Nsevent { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKImageBrowserViewIndexEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKImageBrowserViewIndexEventArgs" /> with the specified event data.</summary>
		/// <param name="index">The value for the <see cref="Index" /> property.</param>
		public IKImageBrowserViewIndexEventArgs (IntPtr index)
		{
			this.Index = index;
		}
		public IntPtr Index { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKImageBrowserViewIndexEventEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKImageBrowserViewIndexEventEventArgs" /> with the specified event data.</summary>
		/// <param name="index">The value for the <see cref="Index" /> property.</param>
		/// <param name="nsevent">The value for the <see cref="Nsevent" /> property.</param>
		public IKImageBrowserViewIndexEventEventArgs (IntPtr index, NSEvent nsevent)
		{
			this.Index = index;
			this.Nsevent = nsevent;
		}
		public IntPtr Index { get; set; }
		public NSEvent Nsevent { get; set; }
	}
}
