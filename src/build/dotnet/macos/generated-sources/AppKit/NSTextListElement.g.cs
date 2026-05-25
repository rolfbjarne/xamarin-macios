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
	[Register("NSTextListElement", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSTextListElement : NSTextParagraph {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringX = "attributedString";
		static readonly NativeHandle selAttributedStringXHandle = Selector.GetHandle ("attributedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildElementsX = "childElements";
		static readonly NativeHandle selChildElementsXHandle = Selector.GetHandle ("childElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsX = "contents";
		static readonly NativeHandle selContentsXHandle = Selector.GetHandle ("contents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAttributedString_X = "initWithAttributedString:";
		static readonly NativeHandle selInitWithAttributedString_XHandle = Selector.GetHandle ("initWithAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithParentElement_TextList_Contents_MarkerAttributes_ChildElements_X = "initWithParentElement:textList:contents:markerAttributes:childElements:";
		static readonly NativeHandle selInitWithParentElement_TextList_Contents_MarkerAttributes_ChildElements_XHandle = Selector.GetHandle ("initWithParentElement:textList:contents:markerAttributes:childElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTextContentManager_X = "initWithTextContentManager:";
		static readonly NativeHandle selInitWithTextContentManager_XHandle = Selector.GetHandle ("initWithTextContentManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMarkerAttributesX = "markerAttributes";
		static readonly NativeHandle selMarkerAttributesXHandle = Selector.GetHandle ("markerAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentElementX = "parentElement";
		static readonly NativeHandle selParentElementXHandle = Selector.GetHandle ("parentElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextListX = "textList";
		static readonly NativeHandle selTextListXHandle = Selector.GetHandle ("textList");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextListElementWithChildElements_TextList_NestingLevel_X = "textListElementWithChildElements:textList:nestingLevel:";
		static readonly NativeHandle selTextListElementWithChildElements_TextList_NestingLevel_XHandle = Selector.GetHandle ("textListElementWithChildElements:textList:nestingLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextListElementWithContents_MarkerAttributes_TextList_ChildElements_X = "textListElementWithContents:markerAttributes:textList:childElements:";
		static readonly NativeHandle selTextListElementWithContents_MarkerAttributes_TextList_ChildElements_XHandle = Selector.GetHandle ("textListElementWithContents:markerAttributes:textList:childElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextListElement");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTextListElement" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextListElement () : base (NSObjectFlag.Empty)
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
		protected NSTextListElement (NSObjectFlag t) : base (t)
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
		protected internal NSTextListElement (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithAttributedString:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextListElement (NSAttributedString? attributedString)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributedString__handle__ = attributedString.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithAttributedString_XHandle, attributedString__handle__), "initWithAttributedString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithAttributedString_XHandle, attributedString__handle__), "initWithAttributedString:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributedString);
		}
		[Export ("initWithTextContentManager:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextListElement (NSTextContentManager? textContentManager)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContentManager__handle__ = textContentManager.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithTextContentManager_XHandle, textContentManager__handle__), "initWithTextContentManager:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithTextContentManager_XHandle, textContentManager__handle__), "initWithTextContentManager:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textContentManager);
		}
		[Export ("initWithParentElement:textList:contents:markerAttributes:childElements:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextListElement (NSTextListElement? parent, NSTextList textList, NSAttributedString? contents, NSDictionary? markerAttributes, NSTextListElement[]? children)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var parent__handle__ = parent.GetHandle ();
			var textList__handle__ = textList!.GetNonNullHandle (nameof (textList));
			var contents__handle__ = contents.GetHandle ();
			var markerAttributes__handle__ = markerAttributes.GetHandle ();
			using var nsa_children = children is null ? null : NSArray.FromNSObjects (children);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithParentElement_TextList_Contents_MarkerAttributes_ChildElements_XHandle, parent__handle__, textList__handle__, contents__handle__, markerAttributes__handle__, nsa_children.GetHandle ()), "initWithParentElement:textList:contents:markerAttributes:childElements:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithParentElement_TextList_Contents_MarkerAttributes_ChildElements_XHandle, parent__handle__, textList__handle__, contents__handle__, markerAttributes__handle__, nsa_children.GetHandle ()), "initWithParentElement:textList:contents:markerAttributes:childElements:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parent);
			GC.KeepAlive (textList);
			GC.KeepAlive (contents);
			GC.KeepAlive (markerAttributes);
		}
		[Export ("textListElementWithContents:markerAttributes:textList:childElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextListElement Create (NSAttributedString contents, NSDictionary? markerAttributes, NSTextList textList, NSTextListElement[]? children)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contents__handle__ = contents!.GetNonNullHandle (nameof (contents));
			var markerAttributes__handle__ = markerAttributes.GetHandle ();
			var textList__handle__ = textList!.GetNonNullHandle (nameof (textList));
			using var nsa_children = children is null ? null : NSArray.FromNSObjects (children);
			NSTextListElement? ret;
			ret =  Runtime.GetNSObject<NSTextListElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selTextListElementWithContents_MarkerAttributes_TextList_ChildElements_XHandle, contents__handle__, markerAttributes__handle__, textList__handle__, nsa_children.GetHandle ()), false)!;
			GC.KeepAlive (contents);
			GC.KeepAlive (markerAttributes);
			GC.KeepAlive (textList);
			return ret!;
		}
		[Export ("textListElementWithChildElements:textList:nestingLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextListElement? Create (NSTextListElement[] children, NSTextList textList, nint nestingLevel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (children is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (children));
			var textList__handle__ = textList!.GetNonNullHandle (nameof (textList));
			using var nsa_children = NSArray.FromNSObjects (children);
			NSTextListElement? ret;
			ret =  Runtime.GetNSObject<NSTextListElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selTextListElementWithChildElements_TextList_NestingLevel_XHandle, nsa_children.Handle, textList__handle__, nestingLevel), false)!;
			GC.KeepAlive (textList);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString AttributedString {
			[Export ("attributedString", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextListElement[] ChildElements {
			[Export ("childElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextListElement[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextListElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextListElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? Contents {
			[Export ("contents", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ParentElement_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextListElement? ParentElement {
			[Export ("parentElement", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextListElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextListElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextListElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ParentElement_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextList TextList {
			[Export ("textList", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextList? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextListXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextListXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? WeakMarkerAttributes {
			[Export ("markerAttributes", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMarkerAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMarkerAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParentElement_var = null;
			}
		}
	} /* class NSTextListElement */
}
