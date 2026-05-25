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
	[Register("DOMKeyboardEvent", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class DomKeyboardEvent : DomUIEvent {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAltGraphKeyX = "altGraphKey";
		static readonly NativeHandle selAltGraphKeyXHandle = Selector.GetHandle ("altGraphKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAltKeyX = "altKey";
		static readonly NativeHandle selAltKeyXHandle = Selector.GetHandle ("altKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharCodeX = "charCode";
		static readonly NativeHandle selCharCodeXHandle = Selector.GetHandle ("charCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCtrlKeyX = "ctrlKey";
		static readonly NativeHandle selCtrlKeyXHandle = Selector.GetHandle ("ctrlKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetModifierState_X = "getModifierState:";
		static readonly NativeHandle selGetModifierState_XHandle = Selector.GetHandle ("getModifierState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_X = "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:";
		static readonly NativeHandle selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_XHandle = Selector.GetHandle ("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_X = "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:";
		static readonly NativeHandle selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_XHandle = Selector.GetHandle ("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyCodeX = "keyCode";
		static readonly NativeHandle selKeyCodeXHandle = Selector.GetHandle ("keyCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyIdentifierX = "keyIdentifier";
		static readonly NativeHandle selKeyIdentifierXHandle = Selector.GetHandle ("keyIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyLocationX = "keyLocation";
		static readonly NativeHandle selKeyLocationXHandle = Selector.GetHandle ("keyLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetaKeyX = "metaKey";
		static readonly NativeHandle selMetaKeyXHandle = Selector.GetHandle ("metaKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShiftKeyX = "shiftKey";
		static readonly NativeHandle selShiftKeyXHandle = Selector.GetHandle ("shiftKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("DOMKeyboardEvent");
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
		protected DomKeyboardEvent (NSObjectFlag t) : base (t)
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
		protected internal DomKeyboardEvent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public DomKeyboardEvent (string eventType, bool canBubble, bool cancelable, DomAbstractView view, string keyIdentifier, DomKeyLocation keyLocation, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, bool altGraphKey)
			: base (NSObjectFlag.Empty)
		{
			if (eventType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventType));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (keyIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyIdentifier));
			var nseventType = CFString.CreateNative (eventType);
			var nskeyIdentifier = CFString.CreateNative (keyIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_bool_NativeHandle_NativeHandle_UInt32_bool_bool_bool_bool_bool (this.Handle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_XHandle, nseventType, canBubble ? (byte) 1 : (byte) 0, cancelable ? (byte) 1 : (byte) 0, view__handle__, nskeyIdentifier, (UInt32)keyLocation, ctrlKey ? (byte) 1 : (byte) 0, altKey ? (byte) 1 : (byte) 0, shiftKey ? (byte) 1 : (byte) 0, metaKey ? (byte) 1 : (byte) 0, altGraphKey ? (byte) 1 : (byte) 0), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool_bool_NativeHandle_NativeHandle_UInt32_bool_bool_bool_bool_bool (&__objc_super__, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_XHandle, nseventType, canBubble ? (byte) 1 : (byte) 0, cancelable ? (byte) 1 : (byte) 0, view__handle__, nskeyIdentifier, (UInt32)keyLocation, ctrlKey ? (byte) 1 : (byte) 0, altKey ? (byte) 1 : (byte) 0, shiftKey ? (byte) 1 : (byte) 0, metaKey ? (byte) 1 : (byte) 0, altGraphKey ? (byte) 1 : (byte) 0), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			CFString.ReleaseNative (nseventType);
			CFString.ReleaseNative (nskeyIdentifier);
		}
		[Export ("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public DomKeyboardEvent (string eventType, bool canBubble, bool cancelable, DomAbstractView view, string keyIdentifier, DomKeyLocation keyLocation, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
			: base (NSObjectFlag.Empty)
		{
			if (eventType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventType));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (keyIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyIdentifier));
			var nseventType = CFString.CreateNative (eventType);
			var nskeyIdentifier = CFString.CreateNative (keyIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_bool_NativeHandle_NativeHandle_UInt32_bool_bool_bool_bool (this.Handle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_XHandle, nseventType, canBubble ? (byte) 1 : (byte) 0, cancelable ? (byte) 1 : (byte) 0, view__handle__, nskeyIdentifier, (UInt32)keyLocation, ctrlKey ? (byte) 1 : (byte) 0, altKey ? (byte) 1 : (byte) 0, shiftKey ? (byte) 1 : (byte) 0, metaKey ? (byte) 1 : (byte) 0), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool_bool_NativeHandle_NativeHandle_UInt32_bool_bool_bool_bool (&__objc_super__, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_XHandle, nseventType, canBubble ? (byte) 1 : (byte) 0, cancelable ? (byte) 1 : (byte) 0, view__handle__, nskeyIdentifier, (UInt32)keyLocation, ctrlKey ? (byte) 1 : (byte) 0, altKey ? (byte) 1 : (byte) 0, shiftKey ? (byte) 1 : (byte) 0, metaKey ? (byte) 1 : (byte) 0), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			CFString.ReleaseNative (nseventType);
			CFString.ReleaseNative (nskeyIdentifier);
		}
		[Export ("getModifierState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetModifierState (string keyIdentifier)
		{
			if (keyIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyIdentifier));
			var nskeyIdentifier = CFString.CreateNative (keyIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selGetModifierState_XHandle, nskeyIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetModifierState_XHandle, nskeyIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskeyIdentifier);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AltGraphKey {
			[Export ("altGraphKey")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAltGraphKeyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAltGraphKeyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AltKey {
			[Export ("altKey")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAltKeyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAltKeyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int CharCode {
			[Export ("charCode")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCharCodeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selCharCodeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CtrlKey {
			[Export ("ctrlKey")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCtrlKeyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCtrlKeyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int KeyCode {
			[Export ("keyCode")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selKeyCodeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selKeyCodeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string KeyIdentifier {
			[Export ("keyIdentifier", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomKeyLocation KeyLocation {
			[Export ("keyLocation")]
			get {
				DomKeyLocation ret;
				if (IsDirectBinding) {
					ret = (DomKeyLocation) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selKeyLocationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (DomKeyLocation) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selKeyLocationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MetaKey {
			[Export ("metaKey")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMetaKeyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMetaKeyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShiftKey {
			[Export ("shiftKey")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShiftKeyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShiftKeyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class DomKeyboardEvent */
}
