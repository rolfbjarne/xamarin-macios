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
	[Register("NSTextCheckingController", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTextCheckingController : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeSpelling_X = "changeSpelling:";
		static readonly NativeHandle selChangeSpelling_XHandle = Selector.GetHandle ("changeSpelling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckSpelling_X = "checkSpelling:";
		static readonly NativeHandle selCheckSpelling_XHandle = Selector.GetHandle ("checkSpelling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckTextInDocument_X = "checkTextInDocument:";
		static readonly NativeHandle selCheckTextInDocument_XHandle = Selector.GetHandle ("checkTextInDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckTextInRange_Types_Options_X = "checkTextInRange:types:options:";
		static readonly NativeHandle selCheckTextInRange_Types_Options_XHandle = Selector.GetHandle ("checkTextInRange:types:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckTextInSelection_X = "checkTextInSelection:";
		static readonly NativeHandle selCheckTextInSelection_XHandle = Selector.GetHandle ("checkTextInSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClientX = "client";
		static readonly NativeHandle selClientXHandle = Selector.GetHandle ("client");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConsiderTextCheckingForRange_X = "considerTextCheckingForRange:";
		static readonly NativeHandle selConsiderTextCheckingForRange_XHandle = Selector.GetHandle ("considerTextCheckingForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeSelectedRangeX = "didChangeSelectedRange";
		static readonly NativeHandle selDidChangeSelectedRangeXHandle = Selector.GetHandle ("didChangeSelectedRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeTextInRange_X = "didChangeTextInRange:";
		static readonly NativeHandle selDidChangeTextInRange_XHandle = Selector.GetHandle ("didChangeTextInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoreSpelling_X = "ignoreSpelling:";
		static readonly NativeHandle selIgnoreSpelling_XHandle = Selector.GetHandle ("ignoreSpelling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithClient_X = "initWithClient:";
		static readonly NativeHandle selInitWithClient_XHandle = Selector.GetHandle ("initWithClient:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertedTextInRange_X = "insertedTextInRange:";
		static readonly NativeHandle selInsertedTextInRange_XHandle = Selector.GetHandle ("insertedTextInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateX = "invalidate";
		static readonly NativeHandle selInvalidateXHandle = Selector.GetHandle ("invalidate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuAtIndex_ClickedOnSelection_EffectiveRange_X = "menuAtIndex:clickedOnSelection:effectiveRange:";
		static readonly NativeHandle selMenuAtIndex_ClickedOnSelection_EffectiveRange_XHandle = Selector.GetHandle ("menuAtIndex:clickedOnSelection:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontSubstitutionsPanel_X = "orderFrontSubstitutionsPanel:";
		static readonly NativeHandle selOrderFrontSubstitutionsPanel_XHandle = Selector.GetHandle ("orderFrontSubstitutionsPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpellCheckerDocumentTag_X = "setSpellCheckerDocumentTag:";
		static readonly NativeHandle selSetSpellCheckerDocumentTag_XHandle = Selector.GetHandle ("setSpellCheckerDocumentTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowGuessPanel_X = "showGuessPanel:";
		static readonly NativeHandle selShowGuessPanel_XHandle = Selector.GetHandle ("showGuessPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpellCheckerDocumentTagX = "spellCheckerDocumentTag";
		static readonly NativeHandle selSpellCheckerDocumentTagXHandle = Selector.GetHandle ("spellCheckerDocumentTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateCandidatesX = "updateCandidates";
		static readonly NativeHandle selUpdateCandidatesXHandle = Selector.GetHandle ("updateCandidates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidAnnotationsX = "validAnnotations";
		static readonly NativeHandle selValidAnnotationsXHandle = Selector.GetHandle ("validAnnotations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextCheckingController");
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
		protected NSTextCheckingController (NSObjectFlag t) : base (t)
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
		protected internal NSTextCheckingController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithClient:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextCheckingController (INSTextCheckingClient client)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var client__handle__ = client!.GetNonNullHandle (nameof (client));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithClient_XHandle, client__handle__), "initWithClient:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithClient_XHandle, client__handle__), "initWithClient:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (client);
		}
		[Export ("changeSpelling:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeSpelling (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeSpelling_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeSpelling_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("checkSpelling:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckSpelling (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckSpelling_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckSpelling_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("checkTextInRange:types:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckText (NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UInt64_NativeHandle (this.Handle, selCheckTextInRange_Types_Options_XHandle, range, (UInt64)checkingTypes, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UInt64_NativeHandle (&__objc_super__, selCheckTextInRange_Types_Options_XHandle, range, (UInt64)checkingTypes, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CheckText (NSRange range, NSTextCheckingTypes checkingTypes, NSTextCheckingOptions options)
		{
			CheckText (range, checkingTypes, options.GetDictionary ()!);
		}
		[Export ("checkTextInDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckTextInDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckTextInDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckTextInDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("checkTextInSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckTextInSelection (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckTextInSelection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckTextInSelection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("considerTextCheckingForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsiderTextChecking (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selConsiderTextCheckingForRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selConsiderTextCheckingForRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didChangeSelectedRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelectedRange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidChangeSelectedRangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDidChangeSelectedRangeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didChangeTextInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeText (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selDidChangeTextInRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selDidChangeTextInRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("menuAtIndex:clickedOnSelection:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSMenu? GetMenu (nuint location, bool clickedOnSelection, ref NSRange effectiveRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			NSMenu ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_bool_ref_NSRange (this.Handle, selMenuAtIndex_ClickedOnSelection_EffectiveRange_XHandle, location, clickedOnSelection ? (byte) 1 : (byte) 0, effectiveRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_bool_ref_NSRange (&__objc_super__, selMenuAtIndex_ClickedOnSelection_EffectiveRange_XHandle, location, clickedOnSelection ? (byte) 1 : (byte) 0, effectiveRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("ignoreSpelling:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IgnoreSpelling (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selIgnoreSpelling_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selIgnoreSpelling_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("insertedTextInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertedText (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selInsertedTextInRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selInsertedTextInRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvalidateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("orderFrontSubstitutionsPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontSubstitutionsPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontSubstitutionsPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontSubstitutionsPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("showGuessPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowGuessPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selShowGuessPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selShowGuessPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("updateCandidates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateCandidates ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateCandidatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateCandidatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextCheckingClient Client {
			[Export ("client")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSTextCheckingClient? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INSTextCheckingClient> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClientXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<INSTextCheckingClient> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClientXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SpellCheckerDocumentTag {
			[Export ("spellCheckerDocumentTag")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpellCheckerDocumentTagXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSpellCheckerDocumentTagXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpellCheckerDocumentTag:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSpellCheckerDocumentTag_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSpellCheckerDocumentTag_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ValidAnnotations {
			[Export ("validAnnotations")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValidAnnotationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValidAnnotationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSTextCheckingController */
}
