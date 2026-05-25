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
namespace SharedWithYou {
	[Register("SWAttributionView", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class SWAttributionView : global::AppKit.NSView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundStyleX = "backgroundStyle";
		static readonly NativeHandle selBackgroundStyleXHandle = Selector.GetHandle ("backgroundStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayContextX = "displayContext";
		static readonly NativeHandle selDisplayContextXHandle = Selector.GetHandle ("displayContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightX = "highlight";
		static readonly NativeHandle selHighlightXHandle = Selector.GetHandle ("highlight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightMenuX = "highlightMenu";
		static readonly NativeHandle selHighlightMenuXHandle = Selector.GetHandle ("highlightMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizontalAlignmentX = "horizontalAlignment";
		static readonly NativeHandle selHorizontalAlignmentXHandle = Selector.GetHandle ("horizontalAlignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuTitleForHideActionX = "menuTitleForHideAction";
		static readonly NativeHandle selMenuTitleForHideActionXHandle = Selector.GetHandle ("menuTitleForHideAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMaxLayoutWidthX = "preferredMaxLayoutWidth";
		static readonly NativeHandle selPreferredMaxLayoutWidthXHandle = Selector.GetHandle ("preferredMaxLayoutWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundStyle_X = "setBackgroundStyle:";
		static readonly NativeHandle selSetBackgroundStyle_XHandle = Selector.GetHandle ("setBackgroundStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayContext_X = "setDisplayContext:";
		static readonly NativeHandle selSetDisplayContext_XHandle = Selector.GetHandle ("setDisplayContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighlight_X = "setHighlight:";
		static readonly NativeHandle selSetHighlight_XHandle = Selector.GetHandle ("setHighlight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHorizontalAlignment_X = "setHorizontalAlignment:";
		static readonly NativeHandle selSetHorizontalAlignment_XHandle = Selector.GetHandle ("setHorizontalAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMenuTitleForHideAction_X = "setMenuTitleForHideAction:";
		static readonly NativeHandle selSetMenuTitleForHideAction_XHandle = Selector.GetHandle ("setMenuTitleForHideAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredMaxLayoutWidth_X = "setPreferredMaxLayoutWidth:";
		static readonly NativeHandle selSetPreferredMaxLayoutWidth_XHandle = Selector.GetHandle ("setPreferredMaxLayoutWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupplementalMenu_X = "setSupplementalMenu:";
		static readonly NativeHandle selSetSupplementalMenu_XHandle = Selector.GetHandle ("setSupplementalMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupplementalMenuX = "supplementalMenu";
		static readonly NativeHandle selSupplementalMenuXHandle = Selector.GetHandle ("supplementalMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SWAttributionView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SWAttributionView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWAttributionView () : base (NSObjectFlag.Empty)
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
		public SWAttributionView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SWAttributionView (NSObjectFlag t) : base (t)
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
		protected internal SWAttributionView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SWAttributionView (CGRect frame)
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SWAttributionViewBackgroundStyle BackgroundStyle {
			[Export ("backgroundStyle", ArgumentSemantic.Assign)]
			get {
				SWAttributionViewBackgroundStyle ret;
				if (IsDirectBinding) {
					ret = (SharedWithYou.SWAttributionViewBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SharedWithYou.SWAttributionViewBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBackgroundStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBackgroundStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SWAttributionViewDisplayContext DisplayContext {
			[Export ("displayContext", ArgumentSemantic.Assign)]
			get {
				SWAttributionViewDisplayContext ret;
				if (IsDirectBinding) {
					ret = (SharedWithYou.SWAttributionViewDisplayContext) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayContextXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SharedWithYou.SWAttributionViewDisplayContext) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDisplayContextXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayContext:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayContext_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDisplayContext_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SWHighlight? Highlight {
			[Export ("highlight", ArgumentSemantic.Retain)]
			get {
				SWHighlight? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SWHighlight> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHighlightXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SWHighlight> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHighlightXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHighlight:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHighlight_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHighlight_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenu HighlightMenu {
			[Export ("highlightMenu", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSMenu? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHighlightMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHighlightMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SWAttributionViewHorizontalAlignment HorizontalAlignment {
			[Export ("horizontalAlignment", ArgumentSemantic.Assign)]
			get {
				SWAttributionViewHorizontalAlignment ret;
				if (IsDirectBinding) {
					ret = (SharedWithYou.SWAttributionViewHorizontalAlignment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHorizontalAlignmentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SharedWithYou.SWAttributionViewHorizontalAlignment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selHorizontalAlignmentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHorizontalAlignment:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHorizontalAlignment_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetHorizontalAlignment_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MenuTitleForHideAction {
			[Export ("menuTitleForHideAction", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMenuTitleForHideActionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMenuTitleForHideActionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMenuTitleForHideAction:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMenuTitleForHideAction_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMenuTitleForHideAction_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat PreferredMaxLayoutWidth {
			[Export ("preferredMaxLayoutWidth")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selPreferredMaxLayoutWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selPreferredMaxLayoutWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredMaxLayoutWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetPreferredMaxLayoutWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetPreferredMaxLayoutWidth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenu? SupplementalMenu {
			[Export ("supplementalMenu", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSMenu? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupplementalMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupplementalMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSupplementalMenu:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSupplementalMenu_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSupplementalMenu_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class SWAttributionView */
}
