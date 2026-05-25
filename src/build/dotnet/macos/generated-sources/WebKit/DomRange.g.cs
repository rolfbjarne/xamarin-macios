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
namespace WebKit {
	[Register("DOMRange", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class DomRange : DomObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloneContentsX = "cloneContents";
		static readonly NativeHandle selCloneContentsXHandle = Selector.GetHandle ("cloneContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloneRangeX = "cloneRange";
		static readonly NativeHandle selCloneRangeXHandle = Selector.GetHandle ("cloneRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollapse_X = "collapse:";
		static readonly NativeHandle selCollapse_XHandle = Selector.GetHandle ("collapse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollapsedX = "collapsed";
		static readonly NativeHandle selCollapsedXHandle = Selector.GetHandle ("collapsed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommonAncestorContainerX = "commonAncestorContainer";
		static readonly NativeHandle selCommonAncestorContainerXHandle = Selector.GetHandle ("commonAncestorContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareBoundaryPoints_SourceRange_X = "compareBoundaryPoints:sourceRange:";
		static readonly NativeHandle selCompareBoundaryPoints_SourceRange_XHandle = Selector.GetHandle ("compareBoundaryPoints:sourceRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareNode_X = "compareNode:";
		static readonly NativeHandle selCompareNode_XHandle = Selector.GetHandle ("compareNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComparePoint_Offset_X = "comparePoint:offset:";
		static readonly NativeHandle selComparePoint_Offset_XHandle = Selector.GetHandle ("comparePoint:offset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateContextualFragment_X = "createContextualFragment:";
		static readonly NativeHandle selCreateContextualFragment_XHandle = Selector.GetHandle ("createContextualFragment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteContentsX = "deleteContents";
		static readonly NativeHandle selDeleteContentsXHandle = Selector.GetHandle ("deleteContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetachX = "detach";
		static readonly NativeHandle selDetachXHandle = Selector.GetHandle ("detach");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndContainerX = "endContainer";
		static readonly NativeHandle selEndContainerXHandle = Selector.GetHandle ("endContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndOffsetX = "endOffset";
		static readonly NativeHandle selEndOffsetXHandle = Selector.GetHandle ("endOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtractContentsX = "extractContents";
		static readonly NativeHandle selExtractContentsXHandle = Selector.GetHandle ("extractContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertNode_X = "insertNode:";
		static readonly NativeHandle selInsertNode_XHandle = Selector.GetHandle ("insertNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectsNode_X = "intersectsNode:";
		static readonly NativeHandle selIntersectsNode_XHandle = Selector.GetHandle ("intersectsNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPointInRange_Offset_X = "isPointInRange:offset:";
		static readonly NativeHandle selIsPointInRange_Offset_XHandle = Selector.GetHandle ("isPointInRange:offset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectNode_X = "selectNode:";
		static readonly NativeHandle selSelectNode_XHandle = Selector.GetHandle ("selectNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectNodeContents_X = "selectNodeContents:";
		static readonly NativeHandle selSelectNodeContents_XHandle = Selector.GetHandle ("selectNodeContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnd_Offset_X = "setEnd:offset:";
		static readonly NativeHandle selSetEnd_Offset_XHandle = Selector.GetHandle ("setEnd:offset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEndAfter_X = "setEndAfter:";
		static readonly NativeHandle selSetEndAfter_XHandle = Selector.GetHandle ("setEndAfter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEndBefore_X = "setEndBefore:";
		static readonly NativeHandle selSetEndBefore_XHandle = Selector.GetHandle ("setEndBefore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStart_Offset_X = "setStart:offset:";
		static readonly NativeHandle selSetStart_Offset_XHandle = Selector.GetHandle ("setStart:offset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStartAfter_X = "setStartAfter:";
		static readonly NativeHandle selSetStartAfter_XHandle = Selector.GetHandle ("setStartAfter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStartBefore_X = "setStartBefore:";
		static readonly NativeHandle selSetStartBefore_XHandle = Selector.GetHandle ("setStartBefore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartContainerX = "startContainer";
		static readonly NativeHandle selStartContainerXHandle = Selector.GetHandle ("startContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartOffsetX = "startOffset";
		static readonly NativeHandle selStartOffsetXHandle = Selector.GetHandle ("startOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSurroundContents_X = "surroundContents:";
		static readonly NativeHandle selSurroundContents_XHandle = Selector.GetHandle ("surroundContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextX = "text";
		static readonly NativeHandle selTextXHandle = Selector.GetHandle ("text");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToStringX = "toString";
		static readonly NativeHandle selToStringXHandle = Selector.GetHandle ("toString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("DOMRange");
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
		protected DomRange (NSObjectFlag t) : base (t)
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
		protected internal DomRange (NativeHandle handle) : base (handle)
		{
		}

		[Export ("cloneContents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocumentFragment CloneContents ()
		{
			DomDocumentFragment ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCloneContentsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCloneContentsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("cloneRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomRange CloneRange ()
		{
			DomRange ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCloneRangeXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCloneRangeXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("collapse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Collapse (bool toStart)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selCollapse_XHandle, toStart ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selCollapse_XHandle, toStart ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("compareBoundaryPoints:sourceRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short CompareBoundaryPoints (DomRangeCompareHow how, DomRange sourceRange)
		{
			var sourceRange__handle__ = sourceRange!.GetNonNullHandle (nameof (sourceRange));
			short ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.short_objc_msgSend_UInt16_NativeHandle (this.Handle, selCompareBoundaryPoints_SourceRange_XHandle, (UInt16)how, sourceRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper_UInt16_NativeHandle (&__objc_super__, selCompareBoundaryPoints_SourceRange_XHandle, (UInt16)how, sourceRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceRange);
			return ret!;
		}
		[Export ("compareNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short CompareNode (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			short ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.short_objc_msgSend_NativeHandle (this.Handle, selCompareNode_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompareNode_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
			return ret!;
		}
		[Export ("comparePoint:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short ComparePoint (DomNode refNode, int offset)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			short ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.short_objc_msgSend_NativeHandle_int (this.Handle, selComparePoint_Offset_XHandle, refNode__handle__, offset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selComparePoint_Offset_XHandle, refNode__handle__, offset);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
			return ret!;
		}
		[Export ("createContextualFragment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocumentFragment CreateContextualFragment (string html)
		{
			if (html is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (html));
			var nshtml = CFString.CreateNative (html);
			DomDocumentFragment? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateContextualFragment_XHandle, nshtml), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateContextualFragment_XHandle, nshtml), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nshtml);
			return ret!;
		}
		[Export ("deleteContents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteContents ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeleteContentsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDeleteContentsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("detach")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Detach ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDetachXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDetachXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("extractContents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocumentFragment ExtractContents ()
		{
			DomDocumentFragment ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtractContentsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtractContentsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertNode (DomNode newNode)
		{
			var newNode__handle__ = newNode!.GetNonNullHandle (nameof (newNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInsertNode_XHandle, newNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInsertNode_XHandle, newNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newNode);
		}
		[Export ("intersectsNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IntersectsNode (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIntersectsNode_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntersectsNode_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
			return ret != 0;
		}
		[Export ("isPointInRange:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPointInRange (DomNode refNode, int offset)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_int (this.Handle, selIsPointInRange_Offset_XHandle, refNode__handle__, offset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selIsPointInRange_Offset_XHandle, refNode__handle__, offset);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
			return ret != 0;
		}
		[Export ("selectNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectNode (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectNode_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectNode_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("selectNodeContents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectNodeContents (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectNodeContents_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectNodeContents_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("setEnd:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEnd (DomNode refNode, int offset)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int (this.Handle, selSetEnd_Offset_XHandle, refNode__handle__, offset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selSetEnd_Offset_XHandle, refNode__handle__, offset);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("setEndAfter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEndAfter (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetEndAfter_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetEndAfter_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("setEndBefore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEndBefore (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetEndBefore_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetEndBefore_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("setStart:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStart (DomNode refNode, int offset)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int (this.Handle, selSetStart_Offset_XHandle, refNode__handle__, offset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selSetStart_Offset_XHandle, refNode__handle__, offset);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("setStartAfter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStartAfter (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStartAfter_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStartAfter_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("setStartBefore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStartBefore (DomNode refNode)
		{
			var refNode__handle__ = refNode!.GetNonNullHandle (nameof (refNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStartBefore_XHandle, refNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStartBefore_XHandle, refNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (refNode);
		}
		[Export ("surroundContents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SurroundContents (DomNode newParent)
		{
			var newParent__handle__ = newParent!.GetNonNullHandle (nameof (newParent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSurroundContents_XHandle, newParent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSurroundContents_XHandle, newParent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newParent);
		}
		[Export ("toString")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ToString ()
		{
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToStringXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToStringXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Collapsed {
			[Export ("collapsed")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCollapsedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCollapsedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode CommonAncestorContainer {
			[Export ("commonAncestorContainer", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommonAncestorContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommonAncestorContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode EndContainer {
			[Export ("endContainer", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEndContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEndContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int EndOffset {
			[Export ("endOffset")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selEndOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selEndOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode StartContainer {
			[Export ("startContainer", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStartContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStartContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int StartOffset {
			[Export ("startOffset")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStartOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selStartOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Text {
			[Export ("text", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class DomRange */
}
