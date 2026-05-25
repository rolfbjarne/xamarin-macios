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
	[Register("NSPageLayout", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPageLayout : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessoryControllersX = "accessoryControllers";
		static readonly NativeHandle selAccessoryControllersXHandle = Selector.GetHandle ("accessoryControllers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAccessoryController_X = "addAccessoryController:";
		static readonly NativeHandle selAddAccessoryController_XHandle = Selector.GetHandle ("addAccessoryController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginSheetUsingPrintInfo_OnWindow_CompletionHandler_X = "beginSheetUsingPrintInfo:onWindow:completionHandler:";
		static readonly NativeHandle selBeginSheetUsingPrintInfo_OnWindow_CompletionHandler_XHandle = Selector.GetHandle ("beginSheetUsingPrintInfo:onWindow:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_X = "beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageLayoutX = "pageLayout";
		static readonly NativeHandle selPageLayoutXHandle = Selector.GetHandle ("pageLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintInfoX = "printInfo";
		static readonly NativeHandle selPrintInfoXHandle = Selector.GetHandle ("printInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAccessoryController_X = "removeAccessoryController:";
		static readonly NativeHandle selRemoveAccessoryController_XHandle = Selector.GetHandle ("removeAccessoryController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalX = "runModal";
		static readonly NativeHandle selRunModalXHandle = Selector.GetHandle ("runModal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalWithPrintInfo_X = "runModalWithPrintInfo:";
		static readonly NativeHandle selRunModalWithPrintInfo_XHandle = Selector.GetHandle ("runModalWithPrintInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPageLayout");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSPageLayout" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPageLayout () : base (NSObjectFlag.Empty)
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
		protected NSPageLayout (NSObjectFlag t) : base (t)
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
		protected internal NSPageLayout (NativeHandle handle) : base (handle)
		{
		}

		[Export ("accessoryControllers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController[] AccessoryControllers ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSViewController[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessoryControllersXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessoryControllersXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("addAccessoryController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAccessoryController (NSViewController accessoryController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var accessoryController__handle__ = accessoryController!.GetNonNullHandle (nameof (accessoryController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddAccessoryController_XHandle, accessoryController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddAccessoryController_XHandle, accessoryController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (accessoryController);
		}
		[Export ("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSheet (NSPrintInfo printInfo, NSWindow docWindow, NSObject? del, Selector? didEndSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			var docWindow__handle__ = docWindow!.GetNonNullHandle (nameof (docWindow));
			var del__handle__ = del.GetHandle ();
			var didEndSelector__handle__ = didEndSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_XHandle, printInfo__handle__, docWindow__handle__, del__handle__, didEndSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_XHandle, printInfo__handle__, docWindow__handle__, del__handle__, didEndSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
			GC.KeepAlive (docWindow);
			GC.KeepAlive (del);
			GC.KeepAlive (didEndSelector);
		}
		[Export ("beginSheetUsingPrintInfo:onWindow:completionHandler:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginSheet (NSPrintInfo printInfo, NSWindow parentWindow, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V18))]global::System.Action<NSPageLayoutResult>? handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			var parentWindow__handle__ = parentWindow!.GetNonNullHandle (nameof (parentWindow));
			using var block_handler = Trampolines.SDActionArity1V18.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selBeginSheetUsingPrintInfo_OnWindow_CompletionHandler_XHandle, printInfo__handle__, parentWindow__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selBeginSheetUsingPrintInfo_OnWindow_CompletionHandler_XHandle, printInfo__handle__, parentWindow__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
			GC.KeepAlive (parentWindow);
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSPageLayoutResult> BeginSheetAsync (NSPrintInfo printInfo, NSWindow parentWindow)
		{
			var tcs = new TaskCompletionSource<NSPageLayoutResult> ();
			BeginSheet(printInfo, parentWindow, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("removeAccessoryController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAccessoryController (NSViewController accessoryController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var accessoryController__handle__ = accessoryController!.GetNonNullHandle (nameof (accessoryController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAccessoryController_XHandle, accessoryController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAccessoryController_XHandle, accessoryController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (accessoryController);
		}
		[Export ("runModal")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RunModal ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRunModalXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRunModalXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("runModalWithPrintInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RunModalWithPrintInfo (NSPrintInfo printInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selRunModalWithPrintInfo_XHandle, printInfo__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRunModalWithPrintInfo_XHandle, printInfo__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPageLayout PageLayout {
			[Export ("pageLayout")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPageLayout? ret;
				ret =  Runtime.GetNSObject<NSPageLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPageLayoutXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPrintInfo PrintInfo {
			[Export ("printInfo")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintInfo? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrintInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrintInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSPageLayout */
}
