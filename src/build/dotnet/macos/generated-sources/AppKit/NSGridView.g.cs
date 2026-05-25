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
	[Register("NSGridView", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSGridView : NSView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddColumnWithViews_X = "addColumnWithViews:";
		static readonly NativeHandle selAddColumnWithViews_XHandle = Selector.GetHandle ("addColumnWithViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRowWithViews_X = "addRowWithViews:";
		static readonly NativeHandle selAddRowWithViews_XHandle = Selector.GetHandle ("addRowWithViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellAtColumnIndex_RowIndex_X = "cellAtColumnIndex:rowIndex:";
		static readonly NativeHandle selCellAtColumnIndex_RowIndex_XHandle = Selector.GetHandle ("cellAtColumnIndex:rowIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellForView_X = "cellForView:";
		static readonly NativeHandle selCellForView_XHandle = Selector.GetHandle ("cellForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnAtIndex_X = "columnAtIndex:";
		static readonly NativeHandle selColumnAtIndex_XHandle = Selector.GetHandle ("columnAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnSpacingX = "columnSpacing";
		static readonly NativeHandle selColumnSpacingXHandle = Selector.GetHandle ("columnSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGridViewWithNumberOfColumns_Rows_X = "gridViewWithNumberOfColumns:rows:";
		static readonly NativeHandle selGridViewWithNumberOfColumns_Rows_XHandle = Selector.GetHandle ("gridViewWithNumberOfColumns:rows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGridViewWithViews_X = "gridViewWithViews:";
		static readonly NativeHandle selGridViewWithViews_XHandle = Selector.GetHandle ("gridViewWithViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfColumn_X = "indexOfColumn:";
		static readonly NativeHandle selIndexOfColumn_XHandle = Selector.GetHandle ("indexOfColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfRow_X = "indexOfRow:";
		static readonly NativeHandle selIndexOfRow_XHandle = Selector.GetHandle ("indexOfRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertColumnAtIndex_WithViews_X = "insertColumnAtIndex:withViews:";
		static readonly NativeHandle selInsertColumnAtIndex_WithViews_XHandle = Selector.GetHandle ("insertColumnAtIndex:withViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertRowAtIndex_WithViews_X = "insertRowAtIndex:withViews:";
		static readonly NativeHandle selInsertRowAtIndex_WithViews_XHandle = Selector.GetHandle ("insertRowAtIndex:withViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMergeCellsInHorizontalRange_VerticalRange_X = "mergeCellsInHorizontalRange:verticalRange:";
		static readonly NativeHandle selMergeCellsInHorizontalRange_VerticalRange_XHandle = Selector.GetHandle ("mergeCellsInHorizontalRange:verticalRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveColumnAtIndex_ToIndex_X = "moveColumnAtIndex:toIndex:";
		static readonly NativeHandle selMoveColumnAtIndex_ToIndex_XHandle = Selector.GetHandle ("moveColumnAtIndex:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveRowAtIndex_ToIndex_X = "moveRowAtIndex:toIndex:";
		static readonly NativeHandle selMoveRowAtIndex_ToIndex_XHandle = Selector.GetHandle ("moveRowAtIndex:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColumnsX = "numberOfColumns";
		static readonly NativeHandle selNumberOfColumnsXHandle = Selector.GetHandle ("numberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRowsX = "numberOfRows";
		static readonly NativeHandle selNumberOfRowsXHandle = Selector.GetHandle ("numberOfRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveColumnAtIndex_X = "removeColumnAtIndex:";
		static readonly NativeHandle selRemoveColumnAtIndex_XHandle = Selector.GetHandle ("removeColumnAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveRowAtIndex_X = "removeRowAtIndex:";
		static readonly NativeHandle selRemoveRowAtIndex_XHandle = Selector.GetHandle ("removeRowAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowAlignmentX = "rowAlignment";
		static readonly NativeHandle selRowAlignmentXHandle = Selector.GetHandle ("rowAlignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowAtIndex_X = "rowAtIndex:";
		static readonly NativeHandle selRowAtIndex_XHandle = Selector.GetHandle ("rowAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowSpacingX = "rowSpacing";
		static readonly NativeHandle selRowSpacingXHandle = Selector.GetHandle ("rowSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColumnSpacing_X = "setColumnSpacing:";
		static readonly NativeHandle selSetColumnSpacing_XHandle = Selector.GetHandle ("setColumnSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowAlignment_X = "setRowAlignment:";
		static readonly NativeHandle selSetRowAlignment_XHandle = Selector.GetHandle ("setRowAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowSpacing_X = "setRowSpacing:";
		static readonly NativeHandle selSetRowSpacing_XHandle = Selector.GetHandle ("setRowSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetXPlacement_X = "setXPlacement:";
		static readonly NativeHandle selSetXPlacement_XHandle = Selector.GetHandle ("setXPlacement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetYPlacement_X = "setYPlacement:";
		static readonly NativeHandle selSetYPlacement_XHandle = Selector.GetHandle ("setYPlacement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXPlacementX = "xPlacement";
		static readonly NativeHandle selXPlacementXHandle = Selector.GetHandle ("xPlacement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYPlacementX = "yPlacement";
		static readonly NativeHandle selYPlacementXHandle = Selector.GetHandle ("yPlacement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSGridView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSGridView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSGridView () : base (NSObjectFlag.Empty)
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
		public NSGridView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSGridView (NSObjectFlag t) : base (t)
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
		protected internal NSGridView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSGridView (CGRect frameRect)
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
		[Export ("addColumnWithViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridColumn AddColumn (NSView[] views)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			NSGridColumn ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAddColumnWithViews_XHandle, nsa_views.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddColumnWithViews_XHandle, nsa_views.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("addRowWithViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridRow AddRow (NSView[] views)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			NSGridRow ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridRow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAddRowWithViews_XHandle, nsa_views.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridRow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddRowWithViews_XHandle, nsa_views.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("gridViewWithNumberOfColumns:rows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGridView Create (nint columnCount, nint rowCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSGridView ret;
			ret =  Runtime.GetNSObject<NSGridView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, selGridViewWithNumberOfColumns_Rows_XHandle, columnCount, rowCount), false)!;
			return ret;
		}
		[Export ("gridViewWithViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGridView Create (NSView[][] rowsAndColumns)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (rowsAndColumns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rowsAndColumns));
			using var nsa_rowsAndColumns = NSArray.FromNSObjects (rowsAndColumns);
			NSGridView ret;
			ret =  Runtime.GetNSObject<NSGridView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGridViewWithViews_XHandle, nsa_rowsAndColumns.Handle), false)!;
			return ret;
		}
		[Export ("gridViewWithViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGridView Create (NSView[,] rowsAndColumns)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (rowsAndColumns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rowsAndColumns));
			using var nsa_rowsAndColumns = NSArray.FromNSObjects (rowsAndColumns);
			NSGridView ret;
			ret =  Runtime.GetNSObject<NSGridView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGridViewWithViews_XHandle, nsa_rowsAndColumns.Handle), false)!;
			return ret;
		}
		[Export ("cellAtColumnIndex:rowIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridCell GetCell (nint columnIndex, nint rowIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSGridCell ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selCellAtColumnIndex_RowIndex_XHandle, columnIndex, rowIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selCellAtColumnIndex_RowIndex_XHandle, columnIndex, rowIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("cellForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridCell? GetCell (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSGridCell? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCellForView_XHandle, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCellForView_XHandle, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("columnAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridColumn GetColumn (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSGridColumn ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selColumnAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selColumnAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("indexOfRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndex (NSGridRow row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var row__handle__ = row!.GetNonNullHandle (nameof (row));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfRow_XHandle, row__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfRow_XHandle, row__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (row);
			return ret!;
		}
		[Export ("indexOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndex (NSGridColumn column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var column__handle__ = column!.GetNonNullHandle (nameof (column));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfColumn_XHandle, column__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfColumn_XHandle, column__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (column);
			return ret!;
		}
		[Export ("rowAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridRow GetRow (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSGridRow ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridRow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selRowAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridRow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selRowAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertColumnAtIndex:withViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridColumn InsertColumn (nint index, NSView[] views)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			NSGridColumn ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, selInsertColumnAtIndex_WithViews_XHandle, index, nsa_views.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selInsertColumnAtIndex_WithViews_XHandle, index, nsa_views.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertRowAtIndex:withViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridRow InsertRow (nint index, NSView[] views)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			NSGridRow ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGridRow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, selInsertRowAtIndex_WithViews_XHandle, index, nsa_views.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGridRow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selInsertRowAtIndex_WithViews_XHandle, index, nsa_views.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("mergeCellsInHorizontalRange:verticalRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MergeCells (NSRange hRange, NSRange vRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NSRange (this.Handle, selMergeCellsInHorizontalRange_VerticalRange_XHandle, hRange, vRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NSRange (&__objc_super__, selMergeCellsInHorizontalRange_VerticalRange_XHandle, hRange, vRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveColumnAtIndex:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveColumn (nint fromIndex, nint toIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveColumnAtIndex_ToIndex_XHandle, fromIndex, toIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMoveColumnAtIndex_ToIndex_XHandle, fromIndex, toIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveRowAtIndex:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveRow (nint fromIndex, nint toIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveRowAtIndex_ToIndex_XHandle, fromIndex, toIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMoveRowAtIndex_ToIndex_XHandle, fromIndex, toIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeColumnAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveColumn (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveColumnAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveColumnAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeRowAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveRow (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveRowAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveRowAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColumnCount {
			[Export ("numberOfColumns")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ColumnSpacing {
			[Export ("columnSpacing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selColumnSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selColumnSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColumnSpacing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetColumnSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetColumnSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridRowAlignment RowAlignment {
			[Export ("rowAlignment", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGridRowAlignment ret;
				if (IsDirectBinding) {
					ret = (NSGridRowAlignment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRowAlignmentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSGridRowAlignment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRowAlignmentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRowAlignment:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRowAlignment_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetRowAlignment_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowCount {
			[Export ("numberOfRows")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RowSpacing {
			[Export ("rowSpacing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selRowSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selRowSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRowSpacing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetRowSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetRowSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridCellPlacement X {
			[Export ("xPlacement", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGridCellPlacement ret;
				if (IsDirectBinding) {
					ret = (NSGridCellPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selXPlacementXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSGridCellPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selXPlacementXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setXPlacement:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetXPlacement_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetXPlacement_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGridCellPlacement Y {
			[Export ("yPlacement", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGridCellPlacement ret;
				if (IsDirectBinding) {
					ret = (NSGridCellPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selYPlacementXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSGridCellPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selYPlacementXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setYPlacement:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetYPlacement_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetYPlacement_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSGridViewSizeForContent",  "AppKit")]
		public static nfloat SizeForContent {
			get {
				return Dlfcn.GetNFloat (Libraries.AppKit.Handle, "NSGridViewSizeForContent");
			}
		}
	} /* class NSGridView */
}
