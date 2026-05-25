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
	[Register("NSOutlineView", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSOutlineView : NSTableView, INSAccessibilityElementProtocol, INSAccessibilityGroup, INSAccessibilityOutline, INSAccessibilityTable {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnHeaderUIElementsX = "accessibilityColumnHeaderUIElements";
		static readonly NativeHandle selAccessibilityColumnHeaderUIElementsXHandle = Selector.GetHandle ("accessibilityColumnHeaderUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnsX = "accessibilityColumns";
		static readonly NativeHandle selAccessibilityColumnsXHandle = Selector.GetHandle ("accessibilityColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFrameX = "accessibilityFrame";
		static readonly NativeHandle selAccessibilityFrameXHandle = Selector.GetHandle ("accessibilityFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHeaderGroupX = "accessibilityHeaderGroup";
		static readonly NativeHandle selAccessibilityHeaderGroupXHandle = Selector.GetHandle ("accessibilityHeaderGroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIdentifierX = "accessibilityIdentifier";
		static readonly NativeHandle selAccessibilityIdentifierXHandle = Selector.GetHandle ("accessibilityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLabelX = "accessibilityLabel";
		static readonly NativeHandle selAccessibilityLabelXHandle = Selector.GetHandle ("accessibilityLabel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityParentX = "accessibilityParent";
		static readonly NativeHandle selAccessibilityParentXHandle = Selector.GetHandle ("accessibilityParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowHeaderUIElementsX = "accessibilityRowHeaderUIElements";
		static readonly NativeHandle selAccessibilityRowHeaderUIElementsXHandle = Selector.GetHandle ("accessibilityRowHeaderUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowsX = "accessibilityRows";
		static readonly NativeHandle selAccessibilityRowsXHandle = Selector.GetHandle ("accessibilityRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedCellsX = "accessibilitySelectedCells";
		static readonly NativeHandle selAccessibilitySelectedCellsXHandle = Selector.GetHandle ("accessibilitySelectedCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedColumnsX = "accessibilitySelectedColumns";
		static readonly NativeHandle selAccessibilitySelectedColumnsXHandle = Selector.GetHandle ("accessibilitySelectedColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedRowsX = "accessibilitySelectedRows";
		static readonly NativeHandle selAccessibilitySelectedRowsXHandle = Selector.GetHandle ("accessibilitySelectedRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleCellsX = "accessibilityVisibleCells";
		static readonly NativeHandle selAccessibilityVisibleCellsXHandle = Selector.GetHandle ("accessibilityVisibleCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleColumnsX = "accessibilityVisibleColumns";
		static readonly NativeHandle selAccessibilityVisibleColumnsXHandle = Selector.GetHandle ("accessibilityVisibleColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleRowsX = "accessibilityVisibleRows";
		static readonly NativeHandle selAccessibilityVisibleRowsXHandle = Selector.GetHandle ("accessibilityVisibleRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoresizesOutlineColumnX = "autoresizesOutlineColumn";
		static readonly NativeHandle selAutoresizesOutlineColumnXHandle = Selector.GetHandle ("autoresizesOutlineColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosaveExpandedItemsX = "autosaveExpandedItems";
		static readonly NativeHandle selAutosaveExpandedItemsXHandle = Selector.GetHandle ("autosaveExpandedItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChild_OfItem_X = "child:ofItem:";
		static readonly NativeHandle selChild_OfItem_XHandle = Selector.GetHandle ("child:ofItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildIndexForItem_X = "childIndexForItem:";
		static readonly NativeHandle selChildIndexForItem_XHandle = Selector.GetHandle ("childIndexForItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollapseItem_X = "collapseItem:";
		static readonly NativeHandle selCollapseItem_XHandle = Selector.GetHandle ("collapseItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollapseItem_CollapseChildren_X = "collapseItem:collapseChildren:";
		static readonly NativeHandle selCollapseItem_CollapseChildren_XHandle = Selector.GetHandle ("collapseItem:collapseChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpandItem_X = "expandItem:";
		static readonly NativeHandle selExpandItem_XHandle = Selector.GetHandle ("expandItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpandItem_ExpandChildren_X = "expandItem:expandChildren:";
		static readonly NativeHandle selExpandItem_ExpandChildren_XHandle = Selector.GetHandle ("expandItem:expandChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameOfOutlineCellAtRow_X = "frameOfOutlineCellAtRow:";
		static readonly NativeHandle selFrameOfOutlineCellAtRow_XHandle = Selector.GetHandle ("frameOfOutlineCellAtRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndentationMarkerFollowsCellX = "indentationMarkerFollowsCell";
		static readonly NativeHandle selIndentationMarkerFollowsCellXHandle = Selector.GetHandle ("indentationMarkerFollowsCell");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndentationPerLevelX = "indentationPerLevel";
		static readonly NativeHandle selIndentationPerLevelXHandle = Selector.GetHandle ("indentationPerLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertItemsAtIndexes_InParent_WithAnimation_X = "insertItemsAtIndexes:inParent:withAnimation:";
		static readonly NativeHandle selInsertItemsAtIndexes_InParent_WithAnimation_XHandle = Selector.GetHandle ("insertItemsAtIndexes:inParent:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertRowsAtIndexes_WithAnimation_X = "insertRowsAtIndexes:withAnimation:";
		static readonly NativeHandle selInsertRowsAtIndexes_WithAnimation_XHandle = Selector.GetHandle ("insertRowsAtIndexes:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityFocusedX = "isAccessibilityFocused";
		static readonly NativeHandle selIsAccessibilityFocusedXHandle = Selector.GetHandle ("isAccessibilityFocused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExpandable_X = "isExpandable:";
		static readonly NativeHandle selIsExpandable_XHandle = Selector.GetHandle ("isExpandable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsItemExpanded_X = "isItemExpanded:";
		static readonly NativeHandle selIsItemExpanded_XHandle = Selector.GetHandle ("isItemExpanded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtRow_X = "itemAtRow:";
		static readonly NativeHandle selItemAtRow_XHandle = Selector.GetHandle ("itemAtRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLevelForItem_X = "levelForItem:";
		static readonly NativeHandle selLevelForItem_XHandle = Selector.GetHandle ("levelForItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLevelForRow_X = "levelForRow:";
		static readonly NativeHandle selLevelForRow_XHandle = Selector.GetHandle ("levelForRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveItemAtIndex_InParent_ToIndex_InParent_X = "moveItemAtIndex:inParent:toIndex:inParent:";
		static readonly NativeHandle selMoveItemAtIndex_InParent_ToIndex_InParent_XHandle = Selector.GetHandle ("moveItemAtIndex:inParent:toIndex:inParent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveRowAtIndex_ToIndex_X = "moveRowAtIndex:toIndex:";
		static readonly NativeHandle selMoveRowAtIndex_ToIndex_XHandle = Selector.GetHandle ("moveRowAtIndex:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfChildrenOfItem_X = "numberOfChildrenOfItem:";
		static readonly NativeHandle selNumberOfChildrenOfItem_XHandle = Selector.GetHandle ("numberOfChildrenOfItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutlineTableColumnX = "outlineTableColumn";
		static readonly NativeHandle selOutlineTableColumnXHandle = Selector.GetHandle ("outlineTableColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentForItem_X = "parentForItem:";
		static readonly NativeHandle selParentForItem_XHandle = Selector.GetHandle ("parentForItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadItem_X = "reloadItem:";
		static readonly NativeHandle selReloadItem_XHandle = Selector.GetHandle ("reloadItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadItem_ReloadChildren_X = "reloadItem:reloadChildren:";
		static readonly NativeHandle selReloadItem_ReloadChildren_XHandle = Selector.GetHandle ("reloadItem:reloadChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemsAtIndexes_InParent_WithAnimation_X = "removeItemsAtIndexes:inParent:withAnimation:";
		static readonly NativeHandle selRemoveItemsAtIndexes_InParent_WithAnimation_XHandle = Selector.GetHandle ("removeItemsAtIndexes:inParent:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveRowsAtIndexes_WithAnimation_X = "removeRowsAtIndexes:withAnimation:";
		static readonly NativeHandle selRemoveRowsAtIndexes_WithAnimation_XHandle = Selector.GetHandle ("removeRowsAtIndexes:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowForItem_X = "rowForItem:";
		static readonly NativeHandle selRowForItem_XHandle = Selector.GetHandle ("rowForItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedRows_X = "setAccessibilitySelectedRows:";
		static readonly NativeHandle selSetAccessibilitySelectedRows_XHandle = Selector.GetHandle ("setAccessibilitySelectedRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoresizesOutlineColumn_X = "setAutoresizesOutlineColumn:";
		static readonly NativeHandle selSetAutoresizesOutlineColumn_XHandle = Selector.GetHandle ("setAutoresizesOutlineColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosaveExpandedItems_X = "setAutosaveExpandedItems:";
		static readonly NativeHandle selSetAutosaveExpandedItems_XHandle = Selector.GetHandle ("setAutosaveExpandedItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataSource_X = "setDataSource:";
		static readonly NativeHandle selSetDataSource_XHandle = Selector.GetHandle ("setDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDropItem_DropChildIndex_X = "setDropItem:dropChildIndex:";
		static readonly NativeHandle selSetDropItem_DropChildIndex_XHandle = Selector.GetHandle ("setDropItem:dropChildIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndentationMarkerFollowsCell_X = "setIndentationMarkerFollowsCell:";
		static readonly NativeHandle selSetIndentationMarkerFollowsCell_XHandle = Selector.GetHandle ("setIndentationMarkerFollowsCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndentationPerLevel_X = "setIndentationPerLevel:";
		static readonly NativeHandle selSetIndentationPerLevel_XHandle = Selector.GetHandle ("setIndentationPerLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutlineTableColumn_X = "setOutlineTableColumn:";
		static readonly NativeHandle selSetOutlineTableColumn_XHandle = Selector.GetHandle ("setOutlineTableColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStronglyReferencesItems_X = "setStronglyReferencesItems:";
		static readonly NativeHandle selSetStronglyReferencesItems_XHandle = Selector.GetHandle ("setStronglyReferencesItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInterfaceLayoutDirection_X = "setUserInterfaceLayoutDirection:";
		static readonly NativeHandle selSetUserInterfaceLayoutDirection_XHandle = Selector.GetHandle ("setUserInterfaceLayoutDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldCollapseAutoExpandedItemsForDeposited_X = "shouldCollapseAutoExpandedItemsForDeposited:";
		static readonly NativeHandle selShouldCollapseAutoExpandedItemsForDeposited_XHandle = Selector.GetHandle ("shouldCollapseAutoExpandedItemsForDeposited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStronglyReferencesItemsX = "stronglyReferencesItems";
		static readonly NativeHandle selStronglyReferencesItemsXHandle = Selector.GetHandle ("stronglyReferencesItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInterfaceLayoutDirectionX = "userInterfaceLayoutDirection";
		static readonly NativeHandle selUserInterfaceLayoutDirectionXHandle = Selector.GetHandle ("userInterfaceLayoutDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSOutlineView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSOutlineView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSOutlineView () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		public NSOutlineView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSOutlineView (NSObjectFlag t) : base (t)
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
		protected internal NSOutlineView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSOutlineView (CGRect frameRect)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("collapseItem:collapseChildren:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollapseItem (NSObject? item, bool collapseChildren)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selCollapseItem_CollapseChildren_XHandle, item__handle__, collapseChildren ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selCollapseItem_CollapseChildren_XHandle, item__handle__, collapseChildren ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("collapseItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollapseItem (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCollapseItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCollapseItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("expandItem:expandChildren:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExpandItem (NSObject? item, bool expandChildren)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selExpandItem_ExpandChildren_XHandle, item__handle__, expandChildren ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selExpandItem_ExpandChildren_XHandle, item__handle__, expandChildren ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("expandItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExpandItem (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selExpandItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selExpandItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("frameOfOutlineCellAtRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect FrameOfOutlineCellAtRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selFrameOfOutlineCellAtRow_XHandle, row);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selFrameOfOutlineCellAtRow_XHandle, row);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selFrameOfOutlineCellAtRow_XHandle, row);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selFrameOfOutlineCellAtRow_XHandle, row);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("child:ofItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetChild (nint index, NSObject? parentItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var parentItem__handle__ = parentItem.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, selChild_OfItem_XHandle, index, parentItem__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selChild_OfItem_XHandle, index, parentItem__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parentItem);
			return ret!;
		}
		[Export ("childIndexForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetChildIndex (NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selChildIndexForItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selChildIndexForItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("parentForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetParent (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selParentForItem_XHandle, item__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selParentForItem_XHandle, item__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("insertItemsAtIndexes:inParent:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertItems (NSIndexSet indexes, NSObject? parent, NSTableViewAnimation animationOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var parent__handle__ = parent.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selInsertItemsAtIndexes_InParent_WithAnimation_XHandle, indexes__handle__, parent__handle__, (UIntPtr) (ulong) animationOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selInsertItemsAtIndexes_InParent_WithAnimation_XHandle, indexes__handle__, parent__handle__, (UIntPtr) (ulong) animationOptions);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
			GC.KeepAlive (parent);
		}
		[Export ("insertRowsAtIndexes:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertRows (NSIndexSet indexes, NSTableViewAnimation animationOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInsertRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInsertRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("isExpandable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsExpandable (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsExpandable_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsExpandable_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[Export ("isItemExpanded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsItemExpanded (NSObject item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsItemExpanded_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsItemExpanded_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[Export ("itemAtRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ItemAtRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selItemAtRow_XHandle, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selItemAtRow_XHandle, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("levelForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint LevelForItem (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selLevelForItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selLevelForItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("levelForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint LevelForRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLevelForRow_XHandle, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selLevelForRow_XHandle, row);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("moveItemAtIndex:inParent:toIndex:inParent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItem (nint fromIndex, NSObject? oldParent, nint toIndex, NSObject? newParent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldParent__handle__ = oldParent.GetHandle ();
			var newParent__handle__ = newParent.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_IntPtr_NativeHandle (this.Handle, selMoveItemAtIndex_InParent_ToIndex_InParent_XHandle, fromIndex, oldParent__handle__, toIndex, newParent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selMoveItemAtIndex_InParent_ToIndex_InParent_XHandle, fromIndex, oldParent__handle__, toIndex, newParent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldParent);
			GC.KeepAlive (newParent);
		}
		[Export ("moveRowAtIndex:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveRow (nint oldIndex, nint newIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveRowAtIndex_ToIndex_XHandle, oldIndex, newIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMoveRowAtIndex_ToIndex_XHandle, oldIndex, newIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("numberOfChildrenOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfChildren (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selNumberOfChildrenOfItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNumberOfChildrenOfItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("reloadItem:reloadChildren:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadItem (NSObject? item, bool reloadChildren)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selReloadItem_ReloadChildren_XHandle, item__handle__, reloadChildren ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selReloadItem_ReloadChildren_XHandle, item__handle__, reloadChildren ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("reloadItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadItem (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("removeItemsAtIndexes:inParent:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveItems (NSIndexSet indexes, NSObject? parent, NSTableViewAnimation animationOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var parent__handle__ = parent.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selRemoveItemsAtIndexes_InParent_WithAnimation_XHandle, indexes__handle__, parent__handle__, (UIntPtr) (ulong) animationOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selRemoveItemsAtIndexes_InParent_WithAnimation_XHandle, indexes__handle__, parent__handle__, (UIntPtr) (ulong) animationOptions);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
			GC.KeepAlive (parent);
		}
		[Export ("removeRowsAtIndexes:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveRows (NSIndexSet indexes, NSTableViewAnimation animationOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selRemoveRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selRemoveRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("rowForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowForItem (NSObject? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selRowForItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRowForItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("setDropItem:dropChildIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDropItem (NSObject? item, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetDropItem_DropChildIndex_XHandle, item__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetDropItem_DropChildIndex_XHandle, item__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("shouldCollapseAutoExpandedItemsForDeposited:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCollapseAutoExpandedItems (bool forDeposited)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selShouldCollapseAutoExpandedItemsForDeposited_XHandle, forDeposited ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (&__objc_super__, selShouldCollapseAutoExpandedItemsForDeposited_XHandle, forDeposited ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityColumnHeaderUIElements {
			[Export ("accessibilityColumnHeaderUIElements")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnHeaderUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnHeaderUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityColumns {
			[Export ("accessibilityColumns")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityFocused {
			[Export ("isAccessibilityFocused")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityFocusedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityFocusedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selAccessibilityFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selAccessibilityFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selAccessibilityFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selAccessibilityFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'AccessibilityHeader' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccessibilityHeaderGroup {
			[Export ("accessibilityHeaderGroup")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'AccessibilityHeader' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHeaderGroupXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHeaderGroupXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccessibilityIdentifier {
			[Export ("accessibilityIdentifier")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityParent {
			[Export ("accessibilityParent")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityRowHeaderUIElements {
			[Export ("accessibilityRowHeaderUIElements")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRowHeaderUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRowHeaderUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual INSAccessibilityRow[]? AccessibilityRows {
			[Export ("accessibilityRows")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilitySelectedCells {
			[Export ("accessibilitySelectedCells")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilitySelectedColumns {
			[Export ("accessibilitySelectedColumns")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual INSAccessibilityRow[]? AccessibilitySelectedRows {
			[Export ("accessibilitySelectedRows")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedRows:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedRows_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedRows_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityVisibleCells {
			[Export ("accessibilityVisibleCells")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityVisibleColumns {
			[Export ("accessibilityVisibleColumns")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual INSAccessibilityRow[] AccessibilityVisibleRows {
			[Export ("accessibilityVisibleRows")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoresizesOutlineColumn {
			[Export ("autoresizesOutlineColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoresizesOutlineColumnXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutoresizesOutlineColumnXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoresizesOutlineColumn:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoresizesOutlineColumn_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoresizesOutlineColumn_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutosaveExpandedItems {
			[Export ("autosaveExpandedItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutosaveExpandedItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutosaveExpandedItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutosaveExpandedItems:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutosaveExpandedItems_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutosaveExpandedItems_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSOutlineViewDataSource? DataSource {
			get {
				return (WeakDataSource as INSOutlineViewDataSource)!;
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
		public INSOutlineViewDelegate? Delegate {
			get {
				return (WeakDelegate as INSOutlineViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IndentationMarkerFollowsCell {
			[Export ("indentationMarkerFollowsCell")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIndentationMarkerFollowsCellXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIndentationMarkerFollowsCellXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIndentationMarkerFollowsCell:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIndentationMarkerFollowsCell_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIndentationMarkerFollowsCell_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat IndentationPerLevel {
			[Export ("indentationPerLevel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selIndentationPerLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selIndentationPerLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIndentationPerLevel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetIndentationPerLevel_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetIndentationPerLevel_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableColumn? OutlineTableColumn {
			[Export ("outlineTableColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableColumn? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTableColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutlineTableColumnXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTableColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutlineTableColumnXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutlineTableColumn:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutlineTableColumn_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutlineTableColumn_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StronglyReferencesItems {
			[Export ("stronglyReferencesItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStronglyReferencesItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStronglyReferencesItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setStronglyReferencesItems:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStronglyReferencesItems_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetStronglyReferencesItems_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection {
			[Export ("userInterfaceLayoutDirection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUserInterfaceLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (NSUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserInterfaceLayoutDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selUserInterfaceLayoutDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserInterfaceLayoutDirection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserInterfaceLayoutDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetUserInterfaceLayoutDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
			[Export ("setDataSource:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnDidMoveNotification;
		/// <summary>Notification constant for ColumnDidMove</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveColumnDidMove(NSObject,EventHandler{NSViewColumnMoveEventArgs})" />
		///     or <see cref="Notifications.ObserveColumnDidMove(EventHandler{NSViewColumnMoveEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveColumnDidMove ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSViewColumnMoveEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveColumnDidMove (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.ColumnDidMoveNotification, (notification) => { Console.WriteLine ("Received the notification ColumnDidMove", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ColumnDidMove", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.ColumnDidMoveNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewColumnDidMoveNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveColumnDidMove helper method instead.")]
		public static NSString ColumnDidMoveNotification {
			get {
				if (_ColumnDidMoveNotification is null)
					_ColumnDidMoveNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewColumnDidMoveNotification")!;
				return _ColumnDidMoveNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnDidResizeNotification;
		/// <summary>Notification constant for ColumnDidResize</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveColumnDidResize(NSObject,EventHandler{NSViewColumnResizeEventArgs})" />
		///     or <see cref="Notifications.ObserveColumnDidResize(EventHandler{NSViewColumnResizeEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveColumnDidResize ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSViewColumnResizeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveColumnDidResize (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.ColumnDidResizeNotification, (notification) => { Console.WriteLine ("Received the notification ColumnDidResize", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ColumnDidResize", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.ColumnDidResizeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewColumnDidResizeNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveColumnDidResize helper method instead.")]
		public static NSString ColumnDidResizeNotification {
			get {
				if (_ColumnDidResizeNotification is null)
					_ColumnDidResizeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewColumnDidResizeNotification")!;
				return _ColumnDidResizeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemDidCollapseNotification;
		/// <summary>Notification constant for ItemDidCollapse</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveItemDidCollapse(NSObject,EventHandler{NSOutlineViewItemEventArgs})" />
		///     or <see cref="Notifications.ObserveItemDidCollapse(EventHandler{NSOutlineViewItemEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveItemDidCollapse ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSOutlineViewItemEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveItemDidCollapse (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.ItemDidCollapseNotification, (notification) => { Console.WriteLine ("Received the notification ItemDidCollapse", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ItemDidCollapse", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.ItemDidCollapseNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewItemDidCollapseNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveItemDidCollapse helper method instead.")]
		public static NSString ItemDidCollapseNotification {
			get {
				if (_ItemDidCollapseNotification is null)
					_ItemDidCollapseNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewItemDidCollapseNotification")!;
				return _ItemDidCollapseNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemDidExpandNotification;
		/// <summary>Notification constant for ItemDidExpand</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveItemDidExpand(NSObject,EventHandler{NSOutlineViewItemEventArgs})" />
		///     or <see cref="Notifications.ObserveItemDidExpand(EventHandler{NSOutlineViewItemEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveItemDidExpand ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSOutlineViewItemEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveItemDidExpand (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.ItemDidExpandNotification, (notification) => { Console.WriteLine ("Received the notification ItemDidExpand", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ItemDidExpand", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.ItemDidExpandNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewItemDidExpandNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveItemDidExpand helper method instead.")]
		public static NSString ItemDidExpandNotification {
			get {
				if (_ItemDidExpandNotification is null)
					_ItemDidExpandNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewItemDidExpandNotification")!;
				return _ItemDidExpandNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemWillCollapseNotification;
		/// <summary>Notification constant for ItemWillCollapse</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveItemWillCollapse(NSObject,EventHandler{NSOutlineViewItemEventArgs})" />
		///     or <see cref="Notifications.ObserveItemWillCollapse(EventHandler{NSOutlineViewItemEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveItemWillCollapse ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSOutlineViewItemEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveItemWillCollapse (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.ItemWillCollapseNotification, (notification) => { Console.WriteLine ("Received the notification ItemWillCollapse", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ItemWillCollapse", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.ItemWillCollapseNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewItemWillCollapseNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveItemWillCollapse helper method instead.")]
		public static NSString ItemWillCollapseNotification {
			get {
				if (_ItemWillCollapseNotification is null)
					_ItemWillCollapseNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewItemWillCollapseNotification")!;
				return _ItemWillCollapseNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemWillExpandNotification;
		/// <summary>Notification constant for ItemWillExpand</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveItemWillExpand(NSObject,EventHandler{NSOutlineViewItemEventArgs})" />
		///     or <see cref="Notifications.ObserveItemWillExpand(EventHandler{NSOutlineViewItemEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveItemWillExpand ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSOutlineViewItemEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveItemWillExpand (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.ItemWillExpandNotification, (notification) => { Console.WriteLine ("Received the notification ItemWillExpand", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ItemWillExpand", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.ItemWillExpandNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewItemWillExpandNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveItemWillExpand helper method instead.")]
		public static NSString ItemWillExpandNotification {
			get {
				if (_ItemWillExpandNotification is null)
					_ItemWillExpandNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewItemWillExpandNotification")!;
				return _ItemWillExpandNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionDidChangeNotification;
		/// <summary>Notification constant for SelectionDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectionDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectionDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveSelectionDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveSelectionDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.SelectionDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification SelectionDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectionDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.SelectionDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewSelectionDidChangeNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveSelectionDidChange helper method instead.")]
		public static NSString SelectionDidChangeNotification {
			get {
				if (_SelectionDidChangeNotification is null)
					_SelectionDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewSelectionDidChangeNotification")!;
				return _SelectionDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionIsChangingNotification;
		/// <summary>Notification constant for SelectionIsChanging</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectionIsChanging(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectionIsChanging(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSOutlineView.Notifications.ObserveSelectionIsChanging ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSOutlineView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSOutlineView.Notifications.ObserveSelectionIsChanging (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSOutlineView.SelectionIsChangingNotification, (notification) => { Console.WriteLine ("Received the notification SelectionIsChanging", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectionIsChanging", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSOutlineView.SelectionIsChangingNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSOutlineViewSelectionIsChangingNotification",  "AppKit")]
		[Advice ("Use NSOutlineView.Notifications.ObserveSelectionIsChanging helper method instead.")]
		public static NSString SelectionIsChangingNotification {
			get {
				if (_SelectionIsChangingNotification is null)
					_SelectionIsChangingNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSOutlineViewSelectionIsChangingNotification")!;
				return _SelectionIsChangingNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSOutlineView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ColumnDidMoveNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ColumnDidMoveNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveColumnDidMove ((notification) => {
			///   Console.WriteLine ("Observed ColumnDidMoveNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidMove (EventHandler<AppKit.NSViewColumnMoveEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidMoveNotification, notification => handler (null, new AppKit.NSViewColumnMoveEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ColumnDidMoveNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ColumnDidMoveNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveColumnDidMove (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ColumnDidMoveNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidMove (NSObject objectToObserve, EventHandler<AppKit.NSViewColumnMoveEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidMoveNotification, notification => handler (null, new AppKit.NSViewColumnMoveEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ColumnDidResizeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ColumnDidResizeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveColumnDidResize ((notification) => {
			///   Console.WriteLine ("Observed ColumnDidResizeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidResize (EventHandler<AppKit.NSViewColumnResizeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidResizeNotification, notification => handler (null, new AppKit.NSViewColumnResizeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ColumnDidResizeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ColumnDidResizeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveColumnDidResize (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ColumnDidResizeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidResize (NSObject objectToObserve, EventHandler<AppKit.NSViewColumnResizeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidResizeNotification, notification => handler (null, new AppKit.NSViewColumnResizeEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemDidCollapseNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemDidCollapseNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveItemDidCollapse ((notification) => {
			///   Console.WriteLine ("Observed ItemDidCollapseNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemDidCollapse (EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemDidCollapseNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemDidCollapseNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemDidCollapseNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveItemDidCollapse (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ItemDidCollapseNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemDidCollapse (NSObject objectToObserve, EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemDidCollapseNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemDidExpandNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemDidExpandNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveItemDidExpand ((notification) => {
			///   Console.WriteLine ("Observed ItemDidExpandNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemDidExpand (EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemDidExpandNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemDidExpandNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemDidExpandNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveItemDidExpand (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ItemDidExpandNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemDidExpand (NSObject objectToObserve, EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemDidExpandNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemWillCollapseNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemWillCollapseNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveItemWillCollapse ((notification) => {
			///   Console.WriteLine ("Observed ItemWillCollapseNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemWillCollapse (EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemWillCollapseNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemWillCollapseNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemWillCollapseNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveItemWillCollapse (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ItemWillCollapseNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemWillCollapse (NSObject objectToObserve, EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemWillCollapseNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemWillExpandNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemWillExpandNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveItemWillExpand ((notification) => {
			///   Console.WriteLine ("Observed ItemWillExpandNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemWillExpand (EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemWillExpandNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.ItemWillExpandNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.ItemWillExpandNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveItemWillExpand (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ItemWillExpandNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemWillExpand (NSObject objectToObserve, EventHandler<AppKit.NSOutlineViewItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemWillExpandNotification, notification => handler (null, new AppKit.NSOutlineViewItemEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.SelectionDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.SelectionDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveSelectionDidChange ((notification) => {
			///   Console.WriteLine ("Observed SelectionDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.SelectionDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.SelectionDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveSelectionDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectionDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.SelectionIsChangingNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.SelectionIsChangingNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSOutlineView.Notifications.ObserveSelectionIsChanging ((notification) => {
			///   Console.WriteLine ("Observed SelectionIsChangingNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionIsChanging (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionIsChangingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSOutlineView.SelectionIsChangingNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSOutlineView.SelectionIsChangingNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSOutlineView.Notifications.ObserveSelectionIsChanging (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectionIsChangingNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionIsChanging (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionIsChangingNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSOutlineView */
}
