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
	[Register("NSFormCell", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSFormCell : NSActionCell {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedTitleX = "attributedTitle";
		static readonly NativeHandle selAttributedTitleXHandle = Selector.GetHandle ("attributedTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitImageCell_X = "initImageCell:";
		static readonly NativeHandle selInitImageCell_XHandle = Selector.GetHandle ("initImageCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitTextCell_X = "initTextCell:";
		static readonly NativeHandle selInitTextCell_XHandle = Selector.GetHandle ("initTextCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOpaqueX = "isOpaque";
		static readonly NativeHandle selIsOpaqueXHandle = Selector.GetHandle ("isOpaque");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderAttributedStringX = "placeholderAttributedString";
		static readonly NativeHandle selPlaceholderAttributedStringXHandle = Selector.GetHandle ("placeholderAttributedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderStringX = "placeholderString";
		static readonly NativeHandle selPlaceholderStringXHandle = Selector.GetHandle ("placeholderString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredTextFieldWidthX = "preferredTextFieldWidth";
		static readonly NativeHandle selPreferredTextFieldWidthXHandle = Selector.GetHandle ("preferredTextFieldWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributedTitle_X = "setAttributedTitle:";
		static readonly NativeHandle selSetAttributedTitle_XHandle = Selector.GetHandle ("setAttributedTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlaceholderAttributedString_X = "setPlaceholderAttributedString:";
		static readonly NativeHandle selSetPlaceholderAttributedString_XHandle = Selector.GetHandle ("setPlaceholderAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlaceholderString_X = "setPlaceholderString:";
		static readonly NativeHandle selSetPlaceholderString_XHandle = Selector.GetHandle ("setPlaceholderString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredTextFieldWidth_X = "setPreferredTextFieldWidth:";
		static readonly NativeHandle selSetPreferredTextFieldWidth_XHandle = Selector.GetHandle ("setPreferredTextFieldWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitleAlignment_X = "setTitleAlignment:";
		static readonly NativeHandle selSetTitleAlignment_XHandle = Selector.GetHandle ("setTitleAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitleBaseWritingDirection_X = "setTitleBaseWritingDirection:";
		static readonly NativeHandle selSetTitleBaseWritingDirection_XHandle = Selector.GetHandle ("setTitleBaseWritingDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitleFont_X = "setTitleFont:";
		static readonly NativeHandle selSetTitleFont_XHandle = Selector.GetHandle ("setTitleFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitleWidth_X = "setTitleWidth:";
		static readonly NativeHandle selSetTitleWidth_XHandle = Selector.GetHandle ("setTitleWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitleWithMnemonic_X = "setTitleWithMnemonic:";
		static readonly NativeHandle selSetTitleWithMnemonic_XHandle = Selector.GetHandle ("setTitleWithMnemonic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleAlignmentX = "titleAlignment";
		static readonly NativeHandle selTitleAlignmentXHandle = Selector.GetHandle ("titleAlignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleBaseWritingDirectionX = "titleBaseWritingDirection";
		static readonly NativeHandle selTitleBaseWritingDirectionXHandle = Selector.GetHandle ("titleBaseWritingDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleFontX = "titleFont";
		static readonly NativeHandle selTitleFontXHandle = Selector.GetHandle ("titleFont");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleWidthX = "titleWidth";
		static readonly NativeHandle selTitleWidthXHandle = Selector.GetHandle ("titleWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleWidth_X = "titleWidth:";
		static readonly NativeHandle selTitleWidth_XHandle = Selector.GetHandle ("titleWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFormCell");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFormCell" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFormCell () : base (NSObjectFlag.Empty)
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
		public NSFormCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSFormCell (NSObjectFlag t) : base (t)
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
		protected internal NSFormCell (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initTextCell:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFormCell (string aString)
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
		[Export ("initImageCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFormCell (NSImage image)
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
		[Export ("setTitleWithMnemonic:")]
		[ObsoletedOSPlatform ("macos10.8", "Set Title instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitleWithMnemonic (string stringWithAmpersand)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringWithAmpersand is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringWithAmpersand));
			var nsstringWithAmpersand = CFString.CreateNative (stringWithAmpersand);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitleWithMnemonic_XHandle, nsstringWithAmpersand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitleWithMnemonic_XHandle, nsstringWithAmpersand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstringWithAmpersand);
		}
		[Export ("titleWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat TitleWidthConstraintedToSize (CGSize aSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_CGSize (this.Handle, selTitleWidth_XHandle, aSize);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_CGSize (&__objc_super__, selTitleWidth_XHandle, aSize);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString AttributedTitle {
			[Export ("attributedTitle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttributedTitle_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributedTitle_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsOpaque {
			[Export ("isOpaque")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOpaqueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsOpaqueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString PlaceholderAttributedString {
			[Export ("placeholderAttributedString", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderAttributedStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderAttributedStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPlaceholderAttributedString:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPlaceholderAttributedString_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPlaceholderAttributedString_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PlaceholderString {
			[Export ("placeholderString")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPlaceholderString:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPlaceholderString_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPlaceholderString_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat PreferredTextFieldWidth {
			[Export ("preferredTextFieldWidth")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selPreferredTextFieldWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selPreferredTextFieldWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredTextFieldWidth:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetPreferredTextFieldWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetPreferredTextFieldWidth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextAlignment TitleAlignment {
			[Export ("titleAlignment")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextAlignment ret;
				if (IsDirectBinding) {
					ret = NSTextAlignmentExtensions.ToManaged ((nuint) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTitleAlignmentXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSTextAlignmentExtensions.ToManaged ((nuint) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTitleAlignmentXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTitleAlignment:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetTitleAlignment_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (value));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetTitleAlignment_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (value));
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWritingDirection TitleBaseWritingDirection {
			[Export ("titleBaseWritingDirection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWritingDirection ret;
				if (IsDirectBinding) {
					ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitleBaseWritingDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTitleBaseWritingDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTitleBaseWritingDirection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitleBaseWritingDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTitleBaseWritingDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont TitleFont {
			[Export ("titleFont", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFont? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleFontXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleFontXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTitleFont:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitleFont_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitleFont_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat TitleWidth {
			[Export ("titleWidth")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selTitleWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selTitleWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitleWidth:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetTitleWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetTitleWidth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSFormCell */
}
