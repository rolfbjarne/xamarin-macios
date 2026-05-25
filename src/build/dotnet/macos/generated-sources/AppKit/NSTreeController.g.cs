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
	[Register("NSTreeController", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTreeController : NSObjectController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdd_X = "add:";
		static readonly NativeHandle selAdd_XHandle = Selector.GetHandle ("add:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddChild_X = "addChild:";
		static readonly NativeHandle selAddChild_XHandle = Selector.GetHandle ("addChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSelectionIndexPaths_X = "addSelectionIndexPaths:";
		static readonly NativeHandle selAddSelectionIndexPaths_XHandle = Selector.GetHandle ("addSelectionIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlwaysUsesMultipleValuesMarkerX = "alwaysUsesMultipleValuesMarker";
		static readonly NativeHandle selAlwaysUsesMultipleValuesMarkerXHandle = Selector.GetHandle ("alwaysUsesMultipleValuesMarker");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArrangedObjectsX = "arrangedObjects";
		static readonly NativeHandle selArrangedObjectsXHandle = Selector.GetHandle ("arrangedObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvoidsEmptySelectionX = "avoidsEmptySelection";
		static readonly NativeHandle selAvoidsEmptySelectionXHandle = Selector.GetHandle ("avoidsEmptySelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddChildX = "canAddChild";
		static readonly NativeHandle selCanAddChildXHandle = Selector.GetHandle ("canAddChild");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanInsertX = "canInsert";
		static readonly NativeHandle selCanInsertXHandle = Selector.GetHandle ("canInsert");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanInsertChildX = "canInsertChild";
		static readonly NativeHandle selCanInsertChildXHandle = Selector.GetHandle ("canInsertChild");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildrenKeyPathX = "childrenKeyPath";
		static readonly NativeHandle selChildrenKeyPathXHandle = Selector.GetHandle ("childrenKeyPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildrenKeyPathForNode_X = "childrenKeyPathForNode:";
		static readonly NativeHandle selChildrenKeyPathForNode_XHandle = Selector.GetHandle ("childrenKeyPathForNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentX = "content";
		static readonly NativeHandle selContentXHandle = Selector.GetHandle ("content");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountKeyPathX = "countKeyPath";
		static readonly NativeHandle selCountKeyPathXHandle = Selector.GetHandle ("countKeyPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountKeyPathForNode_X = "countKeyPathForNode:";
		static readonly NativeHandle selCountKeyPathForNode_XHandle = Selector.GetHandle ("countKeyPathForNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsert_X = "insert:";
		static readonly NativeHandle selInsert_XHandle = Selector.GetHandle ("insert:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertChild_X = "insertChild:";
		static readonly NativeHandle selInsertChild_XHandle = Selector.GetHandle ("insertChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertObject_AtArrangedObjectIndexPath_X = "insertObject:atArrangedObjectIndexPath:";
		static readonly NativeHandle selInsertObject_AtArrangedObjectIndexPath_XHandle = Selector.GetHandle ("insertObject:atArrangedObjectIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertObjects_AtArrangedObjectIndexPaths_X = "insertObjects:atArrangedObjectIndexPaths:";
		static readonly NativeHandle selInsertObjects_AtArrangedObjectIndexPaths_XHandle = Selector.GetHandle ("insertObjects:atArrangedObjectIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeafKeyPathX = "leafKeyPath";
		static readonly NativeHandle selLeafKeyPathXHandle = Selector.GetHandle ("leafKeyPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeafKeyPathForNode_X = "leafKeyPathForNode:";
		static readonly NativeHandle selLeafKeyPathForNode_XHandle = Selector.GetHandle ("leafKeyPathForNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveNode_ToIndexPath_X = "moveNode:toIndexPath:";
		static readonly NativeHandle selMoveNode_ToIndexPath_XHandle = Selector.GetHandle ("moveNode:toIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveNodes_ToIndexPath_X = "moveNodes:toIndexPath:";
		static readonly NativeHandle selMoveNodes_ToIndexPath_XHandle = Selector.GetHandle ("moveNodes:toIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreservesSelectionX = "preservesSelection";
		static readonly NativeHandle selPreservesSelectionXHandle = Selector.GetHandle ("preservesSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRearrangeObjectsX = "rearrangeObjects";
		static readonly NativeHandle selRearrangeObjectsXHandle = Selector.GetHandle ("rearrangeObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemove_X = "remove:";
		static readonly NativeHandle selRemove_XHandle = Selector.GetHandle ("remove:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectAtArrangedObjectIndexPath_X = "removeObjectAtArrangedObjectIndexPath:";
		static readonly NativeHandle selRemoveObjectAtArrangedObjectIndexPath_XHandle = Selector.GetHandle ("removeObjectAtArrangedObjectIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectsAtArrangedObjectIndexPaths_X = "removeObjectsAtArrangedObjectIndexPaths:";
		static readonly NativeHandle selRemoveObjectsAtArrangedObjectIndexPaths_XHandle = Selector.GetHandle ("removeObjectsAtArrangedObjectIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveSelectionIndexPaths_X = "removeSelectionIndexPaths:";
		static readonly NativeHandle selRemoveSelectionIndexPaths_XHandle = Selector.GetHandle ("removeSelectionIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedNodesX = "selectedNodes";
		static readonly NativeHandle selSelectedNodesXHandle = Selector.GetHandle ("selectedNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedObjectsX = "selectedObjects";
		static readonly NativeHandle selSelectedObjectsXHandle = Selector.GetHandle ("selectedObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionIndexPathX = "selectionIndexPath";
		static readonly NativeHandle selSelectionIndexPathXHandle = Selector.GetHandle ("selectionIndexPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionIndexPathsX = "selectionIndexPaths";
		static readonly NativeHandle selSelectionIndexPathsXHandle = Selector.GetHandle ("selectionIndexPaths");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectsInsertedObjectsX = "selectsInsertedObjects";
		static readonly NativeHandle selSelectsInsertedObjectsXHandle = Selector.GetHandle ("selectsInsertedObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlwaysUsesMultipleValuesMarker_X = "setAlwaysUsesMultipleValuesMarker:";
		static readonly NativeHandle selSetAlwaysUsesMultipleValuesMarker_XHandle = Selector.GetHandle ("setAlwaysUsesMultipleValuesMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAvoidsEmptySelection_X = "setAvoidsEmptySelection:";
		static readonly NativeHandle selSetAvoidsEmptySelection_XHandle = Selector.GetHandle ("setAvoidsEmptySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetChildrenKeyPath_X = "setChildrenKeyPath:";
		static readonly NativeHandle selSetChildrenKeyPath_XHandle = Selector.GetHandle ("setChildrenKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContent_X = "setContent:";
		static readonly NativeHandle selSetContent_XHandle = Selector.GetHandle ("setContent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCountKeyPath_X = "setCountKeyPath:";
		static readonly NativeHandle selSetCountKeyPath_XHandle = Selector.GetHandle ("setCountKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLeafKeyPath_X = "setLeafKeyPath:";
		static readonly NativeHandle selSetLeafKeyPath_XHandle = Selector.GetHandle ("setLeafKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreservesSelection_X = "setPreservesSelection:";
		static readonly NativeHandle selSetPreservesSelection_XHandle = Selector.GetHandle ("setPreservesSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionIndexPath_X = "setSelectionIndexPath:";
		static readonly NativeHandle selSetSelectionIndexPath_XHandle = Selector.GetHandle ("setSelectionIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionIndexPaths_X = "setSelectionIndexPaths:";
		static readonly NativeHandle selSetSelectionIndexPaths_XHandle = Selector.GetHandle ("setSelectionIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectsInsertedObjects_X = "setSelectsInsertedObjects:";
		static readonly NativeHandle selSetSelectsInsertedObjects_XHandle = Selector.GetHandle ("setSelectsInsertedObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSortDescriptors_X = "setSortDescriptors:";
		static readonly NativeHandle selSetSortDescriptors_XHandle = Selector.GetHandle ("setSortDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortDescriptorsX = "sortDescriptors";
		static readonly NativeHandle selSortDescriptorsXHandle = Selector.GetHandle ("sortDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTreeController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTreeController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTreeController () : base (NSObjectFlag.Empty)
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
		public NSTreeController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTreeController (NSObjectFlag t) : base (t)
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
		protected internal NSTreeController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("add:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Add (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAdd_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAdd_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("addChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChild (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddChild_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddChild_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("addSelectionIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddSelectionIndexPaths (NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAddSelectionIndexPaths_XHandle, nsa_indexPaths.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddSelectionIndexPaths_XHandle, nsa_indexPaths.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("childrenKeyPathForNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ChildrenKeyPathForNode (NSTreeNode node)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selChildrenKeyPathForNode_XHandle, node__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selChildrenKeyPathForNode_XHandle, node__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("countKeyPathForNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CountKeyPathForNode (NSTreeNode node)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCountKeyPathForNode_XHandle, node__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCountKeyPathForNode_XHandle, node__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("selectionIndexPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSIndexPath GetSelectionIndexPath ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSIndexPath ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionIndexPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionIndexPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("selectionIndexPaths")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSIndexPath[] GetSelectionIndexPaths ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSIndexPath[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionIndexPathsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionIndexPathsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Insert (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInsert_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInsert_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("insertChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertChild (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInsertChild_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInsertChild_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("insertObject:atArrangedObjectIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertObject (NSObject object1, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertObject_AtArrangedObjectIndexPath_XHandle, object1__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertObject_AtArrangedObjectIndexPath_XHandle, object1__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
			GC.KeepAlive (indexPath);
		}
		[Export ("insertObjects:atArrangedObjectIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertObjects (NSObject[] objects, NSArray indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertObjects_AtArrangedObjectIndexPaths_XHandle, nsa_objects.Handle, indexPaths__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertObjects_AtArrangedObjectIndexPaths_XHandle, nsa_objects.Handle, indexPaths__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		[Export ("leafKeyPathForNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LeafKeyPathForNode (NSTreeNode node)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLeafKeyPathForNode_XHandle, node__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLeafKeyPathForNode_XHandle, node__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("moveNode:toIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveNode (NSTreeNode node, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveNode_ToIndexPath_XHandle, node__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveNode_ToIndexPath_XHandle, node__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			GC.KeepAlive (indexPath);
		}
		[Export ("moveNodes:toIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveNodes (NSTreeNode[] nodes, NSIndexPath startingIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			var startingIndexPath__handle__ = startingIndexPath!.GetNonNullHandle (nameof (startingIndexPath));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveNodes_ToIndexPath_XHandle, nsa_nodes.Handle, startingIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveNodes_ToIndexPath_XHandle, nsa_nodes.Handle, startingIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startingIndexPath);
		}
		[Export ("rearrangeObjects")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RearrangeObjects ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRearrangeObjectsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRearrangeObjectsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("remove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemove_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemove_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("removeObjectAtArrangedObjectIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjectAtArrangedObjectIndexPath (NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectAtArrangedObjectIndexPath_XHandle, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObjectAtArrangedObjectIndexPath_XHandle, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
		}
		[Export ("removeObjectsAtArrangedObjectIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjectsAtArrangedObjectIndexPaths (NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectsAtArrangedObjectIndexPaths_XHandle, nsa_indexPaths.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObjectsAtArrangedObjectIndexPaths_XHandle, nsa_indexPaths.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeSelectionIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveSelectionIndexPaths (NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selRemoveSelectionIndexPaths_XHandle, nsa_indexPaths.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveSelectionIndexPaths_XHandle, nsa_indexPaths.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("setSelectionIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual bool SetSelectionIndexPath (NSIndexPath index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var index__handle__ = index!.GetNonNullHandle (nameof (index));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSetSelectionIndexPath_XHandle, index__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectionIndexPath_XHandle, index__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (index);
			return ret != 0;
		}
		[Export ("setSelectionIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual bool SetSelectionIndexPaths (NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSetSelectionIndexPaths_XHandle, nsa_indexPaths.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectionIndexPaths_XHandle, nsa_indexPaths.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AlwaysUsesMultipleValuesMarker {
			[Export ("alwaysUsesMultipleValuesMarker")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAlwaysUsesMultipleValuesMarkerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAlwaysUsesMultipleValuesMarkerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAlwaysUsesMultipleValuesMarker:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAlwaysUsesMultipleValuesMarker_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAlwaysUsesMultipleValuesMarker_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTreeNode ArrangedObjects {
			[Export ("arrangedObjects")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTreeNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTreeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selArrangedObjectsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTreeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selArrangedObjectsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AvoidsEmptySelection {
			[Export ("avoidsEmptySelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAvoidsEmptySelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAvoidsEmptySelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAvoidsEmptySelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAvoidsEmptySelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAvoidsEmptySelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddChild {
			[Export ("canAddChild")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanAddChildXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanAddChildXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanInsert {
			[Export ("canInsert")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanInsertXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanInsertXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanInsertChild {
			[Export ("canInsertChild")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanInsertChildXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanInsertChildXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ChildrenKeyPath {
			[Export ("childrenKeyPath")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildrenKeyPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildrenKeyPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setChildrenKeyPath:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetChildrenKeyPath_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetChildrenKeyPath_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Content {
			[Export ("content", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContent:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContent_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContent_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CountKeyPath {
			[Export ("countKeyPath")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCountKeyPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCountKeyPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCountKeyPath:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCountKeyPath_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCountKeyPath_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LeafKeyPath {
			[Export ("leafKeyPath")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeafKeyPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeafKeyPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLeafKeyPath:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLeafKeyPath_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLeafKeyPath_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PreservesSelection {
			[Export ("preservesSelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPreservesSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPreservesSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPreservesSelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPreservesSelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPreservesSelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTreeNode[] SelectedNodes {
			[Export ("selectedNodes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTreeNode[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTreeNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedNodesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTreeNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedNodesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectsInsertedObjects {
			[Export ("selectsInsertedObjects")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSelectsInsertedObjectsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSelectsInsertedObjectsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSelectsInsertedObjects:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSelectsInsertedObjects_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSelectsInsertedObjects_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSortDescriptor[] SortDescriptors {
			[Export ("sortDescriptors", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSortDescriptor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSSortDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSortDescriptorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSSortDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSortDescriptorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSortDescriptors:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSortDescriptors_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSortDescriptors_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSTreeController */
}
