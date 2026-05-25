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
	[Register("NSTextAttachmentCell", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTextAttachmentCell : NSCell, INSTextAttachmentCellProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachmentX = "attachment";
		static readonly NativeHandle selAttachmentXHandle = Selector.GetHandle ("attachment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellBaselineOffsetX = "cellBaselineOffset";
		static readonly NativeHandle selCellBaselineOffsetXHandle = Selector.GetHandle ("cellBaselineOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_X = "cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:";
		static readonly NativeHandle selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle = Selector.GetHandle ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellSizeX = "cellSize";
		static readonly NativeHandle selCellSizeXHandle = Selector.GetHandle ("cellSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithFrame_InView_X = "drawWithFrame:inView:";
		static readonly NativeHandle selDrawWithFrame_InView_XHandle = Selector.GetHandle ("drawWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithFrame_InView_CharacterIndex_X = "drawWithFrame:inView:characterIndex:";
		static readonly NativeHandle selDrawWithFrame_InView_CharacterIndex_XHandle = Selector.GetHandle ("drawWithFrame:inView:characterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithFrame_InView_CharacterIndex_LayoutManager_X = "drawWithFrame:inView:characterIndex:layoutManager:";
		static readonly NativeHandle selDrawWithFrame_InView_CharacterIndex_LayoutManager_XHandle = Selector.GetHandle ("drawWithFrame:inView:characterIndex:layoutManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlight_WithFrame_InView_X = "highlight:withFrame:inView:";
		static readonly NativeHandle selHighlight_WithFrame_InView_XHandle = Selector.GetHandle ("highlight:withFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitImageCell_X = "initImageCell:";
		static readonly NativeHandle selInitImageCell_XHandle = Selector.GetHandle ("initImageCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitTextCell_X = "initTextCell:";
		static readonly NativeHandle selInitTextCell_XHandle = Selector.GetHandle ("initTextCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttachment_X = "setAttachment:";
		static readonly NativeHandle selSetAttachment_XHandle = Selector.GetHandle ("setAttachment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_X = "trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:";
		static readonly NativeHandle selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_XHandle = Selector.GetHandle ("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackMouse_InRect_OfView_UntilMouseUp_X = "trackMouse:inRect:ofView:untilMouseUp:";
		static readonly NativeHandle selTrackMouse_InRect_OfView_UntilMouseUp_XHandle = Selector.GetHandle ("trackMouse:inRect:ofView:untilMouseUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWantsToTrackMouseX = "wantsToTrackMouse";
		static readonly NativeHandle selWantsToTrackMouseXHandle = Selector.GetHandle ("wantsToTrackMouse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_X = "wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:";
		static readonly NativeHandle selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_XHandle = Selector.GetHandle ("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextAttachmentCell");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTextAttachmentCell" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextAttachmentCell () : base (NSObjectFlag.Empty)
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
		public NSTextAttachmentCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTextAttachmentCell (NSObjectFlag t) : base (t)
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
		protected internal NSTextAttachmentCell (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initImageCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextAttachmentCell (NSImage image)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitImageCell_XHandle, image__handle__), "initImageCell:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitImageCell_XHandle, image__handle__), "initImageCell:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("initTextCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextAttachmentCell (string aString)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitTextCell_XHandle, nsaString), "initTextCell:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitTextCell_XHandle, nsaString), "initTextCell:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
		}
		[Export ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect CellFrameForTextContainer (NSTextContainer textContainer, CGRect lineFrag, CGPoint position, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, textContainer__handle__, lineFrag, position, charIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, textContainer__handle__, lineFrag, position, charIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_CGRect_CGPoint_UIntPtr (&__objc_super__, selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, textContainer__handle__, lineFrag, position, charIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_CGRect_CGPoint_UIntPtr (&__objc_super__, selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, textContainer__handle__, lineFrag, position, charIndex);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[Export ("drawWithFrame:inView:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView? controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selDrawWithFrame_InView_XHandle, cellFrame, controlView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selDrawWithFrame_InView_XHandle, cellFrame, controlView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlView);
		}
		[Export ("drawWithFrame:inView:characterIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView? controlView, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr (this.Handle, selDrawWithFrame_InView_CharacterIndex_XHandle, cellFrame, controlView__handle__, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_UIntPtr (&__objc_super__, selDrawWithFrame_InView_CharacterIndex_XHandle, cellFrame, controlView__handle__, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlView);
		}
		[Export ("drawWithFrame:inView:characterIndex:layoutManager:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView? controlView, nuint charIndex, NSLayoutManager layoutManager)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr_NativeHandle (this.Handle, selDrawWithFrame_InView_CharacterIndex_LayoutManager_XHandle, cellFrame, controlView__handle__, charIndex, layoutManager__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selDrawWithFrame_InView_CharacterIndex_LayoutManager_XHandle, cellFrame, controlView__handle__, charIndex, layoutManager__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlView);
			GC.KeepAlive (layoutManager);
		}
		[Export ("highlight:withFrame:inView:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Highlight (bool highlight, CGRect cellFrame, NSView controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_CGRect_NativeHandle (this.Handle, selHighlight_WithFrame_InView_XHandle, highlight ? (byte) 1 : (byte) 0, cellFrame, controlView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_CGRect_NativeHandle (&__objc_super__, selHighlight_WithFrame_InView_XHandle, highlight ? (byte) 1 : (byte) 0, cellFrame, controlView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlView);
		}
		[Export ("trackMouse:inRect:ofView:untilMouseUp:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_bool (this.Handle, selTrackMouse_InRect_OfView_UntilMouseUp_XHandle, theEvent__handle__, cellFrame, controlView__handle__, untilMouseUp ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle_bool (&__objc_super__, selTrackMouse_InRect_OfView_UntilMouseUp_XHandle, theEvent__handle__, cellFrame, controlView__handle__, untilMouseUp ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[Export ("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_UIntPtr_bool (this.Handle, selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_XHandle, theEvent__handle__, cellFrame, controlView__handle__, charIndex, untilMouseUp ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle_UIntPtr_bool (&__objc_super__, selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_XHandle, theEvent__handle__, cellFrame, controlView__handle__, charIndex, untilMouseUp ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[Export ("wantsToTrackMouse")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WantsToTrackMouse ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWantsToTrackMouseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWantsToTrackMouseXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WantsToTrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_UIntPtr (this.Handle, selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_XHandle, theEvent__handle__, cellFrame, controlView__handle__, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle_UIntPtr (&__objc_super__, selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_XHandle, theEvent__handle__, cellFrame, controlView__handle__, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSTextAttachment? Attachment {
			[Export ("attachment")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextAttachment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextAttachment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttachmentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextAttachment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttachmentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttachment:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttachment_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttachment_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGPoint CellBaselineOffset {
			[Export ("cellBaselineOffset")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selCellBaselineOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selCellBaselineOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGSize CellSize {
			[Export ("cellSize")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		}
	} /* class NSTextAttachmentCell */
}
