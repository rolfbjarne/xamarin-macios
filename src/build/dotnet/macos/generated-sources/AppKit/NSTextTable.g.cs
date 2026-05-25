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
	[Register("NSTextTable", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTextTable : NSTextBlock {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_X = "boundsRectForBlock:contentRect:inRect:textContainer:characterRange:";
		static readonly NativeHandle selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_XHandle = Selector.GetHandle ("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollapsesBordersX = "collapsesBorders";
		static readonly NativeHandle selCollapsesBordersXHandle = Selector.GetHandle ("collapsesBorders");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_X = "drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:";
		static readonly NativeHandle selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_XHandle = Selector.GetHandle ("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHidesEmptyCellsX = "hidesEmptyCells";
		static readonly NativeHandle selHidesEmptyCellsXHandle = Selector.GetHandle ("hidesEmptyCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAlgorithmX = "layoutAlgorithm";
		static readonly NativeHandle selLayoutAlgorithmXHandle = Selector.GetHandle ("layoutAlgorithm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColumnsX = "numberOfColumns";
		static readonly NativeHandle selNumberOfColumnsXHandle = Selector.GetHandle ("numberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_X = "rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:";
		static readonly NativeHandle selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_XHandle = Selector.GetHandle ("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCollapsesBorders_X = "setCollapsesBorders:";
		static readonly NativeHandle selSetCollapsesBorders_XHandle = Selector.GetHandle ("setCollapsesBorders:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHidesEmptyCells_X = "setHidesEmptyCells:";
		static readonly NativeHandle selSetHidesEmptyCells_XHandle = Selector.GetHandle ("setHidesEmptyCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutAlgorithm_X = "setLayoutAlgorithm:";
		static readonly NativeHandle selSetLayoutAlgorithm_XHandle = Selector.GetHandle ("setLayoutAlgorithm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNumberOfColumns_X = "setNumberOfColumns:";
		static readonly NativeHandle selSetNumberOfColumns_XHandle = Selector.GetHandle ("setNumberOfColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextTable");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTextTable" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextTable () : base (NSObjectFlag.Empty)
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
		public NSTextTable (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTextTable (NSObjectFlag t) : base (t)
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
		protected internal NSTextTable (NativeHandle handle) : base (handle)
		{
		}

		[Export ("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawBackground (NSTextTableBlock block, CGRect frameRect, NSView controlView, NSRange charRange, NSLayoutManager layoutManager)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_NativeHandle_NSRange_NativeHandle (this.Handle, selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_XHandle, block__handle__, frameRect, controlView__handle__, charRange, layoutManager__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle_NSRange_NativeHandle (&__objc_super__, selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_XHandle, block__handle__, frameRect, controlView__handle__, charRange, layoutManager__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (block);
			GC.KeepAlive (controlView);
			GC.KeepAlive (layoutManager);
		}
		[Export ("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundsRect (NSTextTableBlock block, CGRect contentRect, CGRect rect, NSTextContainer textContainer, NSRange charRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGRect_NativeHandle_NSRange (this.Handle, selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_XHandle, block__handle__, contentRect, rect, textContainer__handle__, charRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGRect_NativeHandle_NSRange (this.Handle, selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_XHandle, block__handle__, contentRect, rect, textContainer__handle__, charRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_CGRect_CGRect_NativeHandle_NSRange (&__objc_super__, selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_XHandle, block__handle__, contentRect, rect, textContainer__handle__, charRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_CGRect_CGRect_NativeHandle_NSRange (&__objc_super__, selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_XHandle, block__handle__, contentRect, rect, textContainer__handle__, charRange);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (block);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[Export ("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetRectForBlock (NSTextTableBlock block, CGPoint startingPoint, CGRect rect, NSTextContainer textContainer, NSRange charRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGPoint_CGRect_NativeHandle_NSRange (this.Handle, selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_XHandle, block__handle__, startingPoint, rect, textContainer__handle__, charRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGPoint_CGRect_NativeHandle_NSRange (this.Handle, selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_XHandle, block__handle__, startingPoint, rect, textContainer__handle__, charRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_CGPoint_CGRect_NativeHandle_NSRange (&__objc_super__, selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_XHandle, block__handle__, startingPoint, rect, textContainer__handle__, charRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_CGPoint_CGRect_NativeHandle_NSRange (&__objc_super__, selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_XHandle, block__handle__, startingPoint, rect, textContainer__handle__, charRange);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (block);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CollapsesBorders {
			[Export ("collapsesBorders")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCollapsesBordersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCollapsesBordersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCollapsesBorders:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCollapsesBorders_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCollapsesBorders_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Columns {
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
			[Export ("setNumberOfColumns:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNumberOfColumns_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetNumberOfColumns_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HidesEmptyCells {
			[Export ("hidesEmptyCells")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHidesEmptyCellsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHidesEmptyCellsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidesEmptyCells:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHidesEmptyCells_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHidesEmptyCells_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextTableLayoutAlgorithm LayoutAlgorithm {
			[Export ("layoutAlgorithm")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextTableLayoutAlgorithm ret;
				if (IsDirectBinding) {
					ret = (NSTextTableLayoutAlgorithm) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLayoutAlgorithmXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextTableLayoutAlgorithm) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLayoutAlgorithmXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLayoutAlgorithm:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetLayoutAlgorithm_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetLayoutAlgorithm_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSTextTable */
}
