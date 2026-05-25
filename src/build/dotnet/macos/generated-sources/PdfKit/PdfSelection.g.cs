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
namespace PdfKit {
	/// <summary>A text selection in a PDF document.</summary>
	[Register("PDFSelection", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PdfSelection : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSelection_X = "addSelection:";
		static readonly NativeHandle selAddSelection_XHandle = Selector.GetHandle ("addSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSelections_X = "addSelections:";
		static readonly NativeHandle selAddSelections_XHandle = Selector.GetHandle ("addSelections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringX = "attributedString";
		static readonly NativeHandle selAttributedStringXHandle = Selector.GetHandle ("attributedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsForPage_X = "boundsForPage:";
		static readonly NativeHandle selBoundsForPage_XHandle = Selector.GetHandle ("boundsForPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorX = "color";
		static readonly NativeHandle selColorXHandle = Selector.GetHandle ("color");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawForPage_Active_X = "drawForPage:active:";
		static readonly NativeHandle selDrawForPage_Active_XHandle = Selector.GetHandle ("drawForPage:active:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawForPage_WithBox_Active_X = "drawForPage:withBox:active:";
		static readonly NativeHandle selDrawForPage_WithBox_Active_XHandle = Selector.GetHandle ("drawForPage:withBox:active:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendSelectionAtEnd_X = "extendSelectionAtEnd:";
		static readonly NativeHandle selExtendSelectionAtEnd_XHandle = Selector.GetHandle ("extendSelectionAtEnd:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendSelectionAtStart_X = "extendSelectionAtStart:";
		static readonly NativeHandle selExtendSelectionAtStart_XHandle = Selector.GetHandle ("extendSelectionAtStart:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendSelectionForLineBoundariesX = "extendSelectionForLineBoundaries";
		static readonly NativeHandle selExtendSelectionForLineBoundariesXHandle = Selector.GetHandle ("extendSelectionForLineBoundaries");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDocument_X = "initWithDocument:";
		static readonly NativeHandle selInitWithDocument_XHandle = Selector.GetHandle ("initWithDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfTextRangesOnPage_X = "numberOfTextRangesOnPage:";
		static readonly NativeHandle selNumberOfTextRangesOnPage_XHandle = Selector.GetHandle ("numberOfTextRangesOnPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPagesX = "pages";
		static readonly NativeHandle selPagesXHandle = Selector.GetHandle ("pages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeAtIndex_OnPage_X = "rangeAtIndex:onPage:";
		static readonly NativeHandle selRangeAtIndex_OnPage_XHandle = Selector.GetHandle ("rangeAtIndex:onPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionsByLineX = "selectionsByLine";
		static readonly NativeHandle selSelectionsByLineXHandle = Selector.GetHandle ("selectionsByLine");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColor_X = "setColor:";
		static readonly NativeHandle selSetColor_XHandle = Selector.GetHandle ("setColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringX = "string";
		static readonly NativeHandle selStringXHandle = Selector.GetHandle ("string");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PDFSelection");
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
		protected PdfSelection (NSObjectFlag t) : base (t)
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
		protected internal PdfSelection (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="document">To be added.</param><summary>Creates a new, empty, PDF selection object.</summary><remarks>To be added.</remarks>
		[Export ("initWithDocument:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfSelection (PdfDocument document)
			: base (NSObjectFlag.Empty)
		{
			var document__handle__ = document!.GetNonNullHandle (nameof (document));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDocument_XHandle, document__handle__), "initWithDocument:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDocument_XHandle, document__handle__), "initWithDocument:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (document);
		}
		/// <param name="selection">To be added.</param><summary>Adds the provided <paramref name="selection" /> to this selection.</summary><remarks>To be added.</remarks>
		[Export ("addSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSelection (PdfSelection selection)
		{
			var selection__handle__ = selection!.GetNonNullHandle (nameof (selection));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddSelection_XHandle, selection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddSelection_XHandle, selection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selection);
		}
		/// <param name="selections">To be added.</param><summary>Adds the provided <paramref name="selections" /> to this selection.</summary><remarks>To be added.</remarks>
		[Export ("addSelections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSelections (PdfSelection[] selections)
		{
			if (selections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (selections));
			using var nsa_selections = NSArray.FromNSObjects (selections);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddSelections_XHandle, nsa_selections.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddSelections_XHandle, nsa_selections.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="page">To be added.</param><param name="active">To be added.</param><summary>Draws the default highlight rectangle in the current highlight color.</summary><remarks>To be added.</remarks>
		[Export ("drawForPage:active:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw (PdfPage page, bool active)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selDrawForPage_Active_XHandle, page__handle__, active ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selDrawForPage_Active_XHandle, page__handle__, active ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="page">To be added.</param><param name="box">To be added.</param><param name="active">To be added.</param><summary>Draws the specified highlight rectangle (<paramref name="box" />) in the current highlight color.</summary><remarks>To be added.</remarks>
		[Export ("drawForPage:withBox:active:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw (PdfPage page, PdfDisplayBox box, bool active)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_bool (this.Handle, selDrawForPage_WithBox_Active_XHandle, page__handle__, (IntPtr) (long) box, active ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_bool (&__objc_super__, selDrawForPage_WithBox_Active_XHandle, page__handle__, (IntPtr) (long) box, active ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="succeed">To be added.</param><summary>Extends the end of the selection to the position that is indicated by <paramref name="succeed" />.</summary><remarks>To be added.</remarks>
		[Export ("extendSelectionAtEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExtendSelectionAtEnd (nint succeed)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selExtendSelectionAtEnd_XHandle, succeed);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selExtendSelectionAtEnd_XHandle, succeed);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="precede">To be added.</param><summary>Extends the beginning of the selection to the position that is indicated by <paramref name="precede" />.</summary><remarks>To be added.</remarks>
		[Export ("extendSelectionAtStart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExtendSelectionAtStart (nint precede)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selExtendSelectionAtStart_XHandle, precede);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selExtendSelectionAtStart_XHandle, precede);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("extendSelectionForLineBoundaries")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExtendSelectionForLineBoundaries ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selExtendSelectionForLineBoundariesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selExtendSelectionForLineBoundariesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="page">To be added.</param><summary>Returns the selection bounds for the portion of the selection that is on the specified <paramref name="page" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundsForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundsForPage (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, selBoundsForPage_XHandle, page__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, selBoundsForPage_XHandle, page__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, selBoundsForPage_XHandle, page__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, selBoundsForPage_XHandle, page__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="page">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfTextRangesOnPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetNumberOfTextRanges (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selNumberOfTextRangesOnPage_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNumberOfTextRangesOnPage_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="index">To be added.</param><param name="page">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangeAtIndex:onPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRange (nuint index, PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selRangeAtIndex_OnPage_XHandle, index, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selRangeAtIndex_OnPage_XHandle, index, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <summary>Returns an array that contains the selected lines.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionsByLine")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection[] SelectionsByLine ()
		{
			PdfSelection[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<PdfSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionsByLineXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<PdfSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionsByLineXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Returns an attributed string for this selection.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? AttributedString {
			[Export ("attributedString")]
			get {
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the color with which to draw the selection.</summary><value><para>This overrides both the active and inactive selection drawing colors.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSColor? Color {
			[Export ("color", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Returns the pages that are in the selection.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfPage[] Pages {
			[Export ("pages")]
			get {
				PdfPage[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PdfPage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPagesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PdfPage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPagesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the text of the selection.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Text {
			[Export ("string")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class PdfSelection */
}
