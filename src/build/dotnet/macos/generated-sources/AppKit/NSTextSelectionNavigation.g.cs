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
	[Register("NSTextSelectionNavigation", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSTextSelectionNavigation : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsNonContiguousRangesX = "allowsNonContiguousRanges";
		static readonly NativeHandle selAllowsNonContiguousRangesXHandle = Selector.GetHandle ("allowsNonContiguousRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeletionRangesForTextSelection_Direction_Destination_AllowsDecomposition_X = "deletionRangesForTextSelection:direction:destination:allowsDecomposition:";
		static readonly NativeHandle selDeletionRangesForTextSelection_Direction_Destination_AllowsDecomposition_XHandle = Selector.GetHandle ("deletionRangesForTextSelection:direction:destination:allowsDecomposition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationSelectionForTextSelection_Direction_Destination_Extending_Confined_X = "destinationSelectionForTextSelection:direction:destination:extending:confined:";
		static readonly NativeHandle selDestinationSelectionForTextSelection_Direction_Destination_Extending_Confined_XHandle = Selector.GetHandle ("destinationSelectionForTextSelection:direction:destination:extending:confined:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlushLayoutCacheX = "flushLayoutCache";
		static readonly NativeHandle selFlushLayoutCacheXHandle = Selector.GetHandle ("flushLayoutCache");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDataSource_X = "initWithDataSource:";
		static readonly NativeHandle selInitWithDataSource_XHandle = Selector.GetHandle ("initWithDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolvedInsertionLocationForTextSelection_WritingDirection_X = "resolvedInsertionLocationForTextSelection:writingDirection:";
		static readonly NativeHandle selResolvedInsertionLocationForTextSelection_WritingDirection_XHandle = Selector.GetHandle ("resolvedInsertionLocationForTextSelection:writingDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotatesCoordinateSystemForLayoutOrientationX = "rotatesCoordinateSystemForLayoutOrientation";
		static readonly NativeHandle selRotatesCoordinateSystemForLayoutOrientationXHandle = Selector.GetHandle ("rotatesCoordinateSystemForLayoutOrientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsNonContiguousRanges_X = "setAllowsNonContiguousRanges:";
		static readonly NativeHandle selSetAllowsNonContiguousRanges_XHandle = Selector.GetHandle ("setAllowsNonContiguousRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRotatesCoordinateSystemForLayoutOrientation_X = "setRotatesCoordinateSystemForLayoutOrientation:";
		static readonly NativeHandle selSetRotatesCoordinateSystemForLayoutOrientation_XHandle = Selector.GetHandle ("setRotatesCoordinateSystemForLayoutOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSelectionDataSourceX = "textSelectionDataSource";
		static readonly NativeHandle selTextSelectionDataSourceXHandle = Selector.GetHandle ("textSelectionDataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSelectionForSelectionGranularity_EnclosingPoint_InContainerAtLocation_X = "textSelectionForSelectionGranularity:enclosingPoint:inContainerAtLocation:";
		static readonly NativeHandle selTextSelectionForSelectionGranularity_EnclosingPoint_InContainerAtLocation_XHandle = Selector.GetHandle ("textSelectionForSelectionGranularity:enclosingPoint:inContainerAtLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSelectionForSelectionGranularity_EnclosingTextSelection_X = "textSelectionForSelectionGranularity:enclosingTextSelection:";
		static readonly NativeHandle selTextSelectionForSelectionGranularity_EnclosingTextSelection_XHandle = Selector.GetHandle ("textSelectionForSelectionGranularity:enclosingTextSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSelectionsInteractingAtPoint_InContainerAtLocation_Anchors_Modifiers_Selecting_Bounds_X = "textSelectionsInteractingAtPoint:inContainerAtLocation:anchors:modifiers:selecting:bounds:";
		static readonly NativeHandle selTextSelectionsInteractingAtPoint_InContainerAtLocation_Anchors_Modifiers_Selecting_Bounds_XHandle = Selector.GetHandle ("textSelectionsInteractingAtPoint:inContainerAtLocation:anchors:modifiers:selecting:bounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextSelectionNavigation");
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
		protected NSTextSelectionNavigation (NSObjectFlag t) : base (t)
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
		protected internal NSTextSelectionNavigation (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDataSource:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextSelectionNavigation (INSTextSelectionDataSource dataSource)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDataSource_XHandle, dataSource__handle__), "initWithDataSource:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDataSource_XHandle, dataSource__handle__), "initWithDataSource:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataSource);
		}
		[Export ("flushLayoutCache")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FlushLayoutCache ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlushLayoutCacheXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFlushLayoutCacheXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deletionRangesForTextSelection:direction:destination:allowsDecomposition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange[] GetDeletionRanges (NSTextSelection textSelection, NSTextSelectionNavigationDirection direction, NSTextSelectionNavigationDestination destination, bool allowsDecomposition)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textSelection__handle__ = textSelection!.GetNonNullHandle (nameof (textSelection));
			NSTextRange[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTextRange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_bool (this.Handle, selDeletionRangesForTextSelection_Direction_Destination_AllowsDecomposition_XHandle, textSelection__handle__, (IntPtr) (long) direction, (IntPtr) (long) destination, allowsDecomposition ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTextRange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr_bool (&__objc_super__, selDeletionRangesForTextSelection_Direction_Destination_AllowsDecomposition_XHandle, textSelection__handle__, (IntPtr) (long) direction, (IntPtr) (long) destination, allowsDecomposition ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textSelection);
			return ret!;
		}
		[Export ("destinationSelectionForTextSelection:direction:destination:extending:confined:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelection? GetDestinationSelection (NSTextSelection textSelection, NSTextSelectionNavigationDirection direction, NSTextSelectionNavigationDestination destination, bool extending, bool confined)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textSelection__handle__ = textSelection!.GetNonNullHandle (nameof (textSelection));
			NSTextSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_bool_bool (this.Handle, selDestinationSelectionForTextSelection_Direction_Destination_Extending_Confined_XHandle, textSelection__handle__, (IntPtr) (long) direction, (IntPtr) (long) destination, extending ? (byte) 1 : (byte) 0, confined ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr_bool_bool (&__objc_super__, selDestinationSelectionForTextSelection_Direction_Destination_Extending_Confined_XHandle, textSelection__handle__, (IntPtr) (long) direction, (IntPtr) (long) destination, extending ? (byte) 1 : (byte) 0, confined ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textSelection);
			return ret!;
		}
		[Export ("resolvedInsertionLocationForTextSelection:writingDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextLocation? GetResolvedInsertionLocation (NSTextSelection textSelection, NSTextSelectionNavigationWritingDirection writingDirection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textSelection__handle__ = textSelection!.GetNonNullHandle (nameof (textSelection));
			INSTextLocation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selResolvedInsertionLocationForTextSelection_WritingDirection_XHandle, textSelection__handle__, (IntPtr) (long) writingDirection), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selResolvedInsertionLocationForTextSelection_WritingDirection_XHandle, textSelection__handle__, (IntPtr) (long) writingDirection), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textSelection);
			return ret!;
		}
		[Export ("textSelectionForSelectionGranularity:enclosingTextSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelection GetTextSelection (NSTextSelectionGranularity selectionGranularity, NSTextSelection textSelection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textSelection__handle__ = textSelection!.GetNonNullHandle (nameof (textSelection));
			NSTextSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, selTextSelectionForSelectionGranularity_EnclosingTextSelection_XHandle, (IntPtr) (long) selectionGranularity, textSelection__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selTextSelectionForSelectionGranularity_EnclosingTextSelection_XHandle, (IntPtr) (long) selectionGranularity, textSelection__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textSelection);
			return ret!;
		}
		[Export ("textSelectionForSelectionGranularity:enclosingPoint:inContainerAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelection? GetTextSelection (NSTextSelectionGranularity selectionGranularity, CGPoint point, INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_CGPoint_NativeHandle (this.Handle, selTextSelectionForSelectionGranularity_EnclosingPoint_InContainerAtLocation_XHandle, (IntPtr) (long) selectionGranularity, point, location__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_CGPoint_NativeHandle (&__objc_super__, selTextSelectionForSelectionGranularity_EnclosingPoint_InContainerAtLocation_XHandle, (IntPtr) (long) selectionGranularity, point, location__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("textSelectionsInteractingAtPoint:inContainerAtLocation:anchors:modifiers:selecting:bounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelection[] GetTextSelectionsInteracting (CGPoint point, INSTextLocation containerLocation, NSTextSelection[] anchors, NSTextSelectionNavigationModifier modifiers, bool selecting, CGRect bounds)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var containerLocation__handle__ = containerLocation!.GetNonNullHandle (nameof (containerLocation));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			NSTextSelection[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTextSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle_NativeHandle_UIntPtr_bool_CGRect (this.Handle, selTextSelectionsInteractingAtPoint_InContainerAtLocation_Anchors_Modifiers_Selecting_Bounds_XHandle, point, containerLocation__handle__, nsa_anchors.Handle, (UIntPtr) (ulong) modifiers, selecting ? (byte) 1 : (byte) 0, bounds), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTextSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_NativeHandle_NativeHandle_UIntPtr_bool_CGRect (&__objc_super__, selTextSelectionsInteractingAtPoint_InContainerAtLocation_Anchors_Modifiers_Selecting_Bounds_XHandle, point, containerLocation__handle__, nsa_anchors.Handle, (UIntPtr) (ulong) modifiers, selecting ? (byte) 1 : (byte) 0, bounds), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (containerLocation);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsNonContiguousRanges {
			[Export ("allowsNonContiguousRanges")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsNonContiguousRangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsNonContiguousRangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsNonContiguousRanges:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsNonContiguousRanges_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsNonContiguousRanges_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RotatesCoordinateSystemForLayoutOrientation {
			[Export ("rotatesCoordinateSystemForLayoutOrientation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRotatesCoordinateSystemForLayoutOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRotatesCoordinateSystemForLayoutOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRotatesCoordinateSystemForLayoutOrientation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRotatesCoordinateSystemForLayoutOrientation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRotatesCoordinateSystemForLayoutOrientation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSTextSelectionDataSource? TextSelectionDataSource {
			get {
				return (WeakTextSelectionDataSource as INSTextSelectionDataSource)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakTextSelectionDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakTextSelectionDataSource {
			[Export ("textSelectionDataSource", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextSelectionDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextSelectionDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakTextSelectionDataSource_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakTextSelectionDataSource_var = null;
			}
		}
	} /* class NSTextSelectionNavigation */
}
