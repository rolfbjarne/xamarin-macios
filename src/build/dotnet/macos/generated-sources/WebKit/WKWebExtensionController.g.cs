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
	[Register("WKWebExtensionController", true)]
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe partial class WKWebExtensionController : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllExtensionDataTypesX = "allExtensionDataTypes";
		static readonly NativeHandle selAllExtensionDataTypesXHandle = Selector.GetHandle ("allExtensionDataTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfigurationX = "configuration";
		static readonly NativeHandle selConfigurationXHandle = Selector.GetHandle ("configuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidActivateTab_PreviousActiveTab_X = "didActivateTab:previousActiveTab:";
		static readonly NativeHandle selDidActivateTab_PreviousActiveTab_XHandle = Selector.GetHandle ("didActivateTab:previousActiveTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeTabProperties_ForTab_X = "didChangeTabProperties:forTab:";
		static readonly NativeHandle selDidChangeTabProperties_ForTab_XHandle = Selector.GetHandle ("didChangeTabProperties:forTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidCloseTab_WindowIsClosing_X = "didCloseTab:windowIsClosing:";
		static readonly NativeHandle selDidCloseTab_WindowIsClosing_XHandle = Selector.GetHandle ("didCloseTab:windowIsClosing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidCloseWindow_X = "didCloseWindow:";
		static readonly NativeHandle selDidCloseWindow_XHandle = Selector.GetHandle ("didCloseWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidDeselectTabs_X = "didDeselectTabs:";
		static readonly NativeHandle selDidDeselectTabs_XHandle = Selector.GetHandle ("didDeselectTabs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidFocusWindow_X = "didFocusWindow:";
		static readonly NativeHandle selDidFocusWindow_XHandle = Selector.GetHandle ("didFocusWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidMoveTab_FromIndex_InWindow_X = "didMoveTab:fromIndex:inWindow:";
		static readonly NativeHandle selDidMoveTab_FromIndex_InWindow_XHandle = Selector.GetHandle ("didMoveTab:fromIndex:inWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidOpenTab_X = "didOpenTab:";
		static readonly NativeHandle selDidOpenTab_XHandle = Selector.GetHandle ("didOpenTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidOpenWindow_X = "didOpenWindow:";
		static readonly NativeHandle selDidOpenWindow_XHandle = Selector.GetHandle ("didOpenWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidReplaceTab_WithTab_X = "didReplaceTab:withTab:";
		static readonly NativeHandle selDidReplaceTab_WithTab_XHandle = Selector.GetHandle ("didReplaceTab:withTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidSelectTabs_X = "didSelectTabs:";
		static readonly NativeHandle selDidSelectTabs_XHandle = Selector.GetHandle ("didSelectTabs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtensionContextForExtension_X = "extensionContextForExtension:";
		static readonly NativeHandle selExtensionContextForExtension_XHandle = Selector.GetHandle ("extensionContextForExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtensionContextForURL_X = "extensionContextForURL:";
		static readonly NativeHandle selExtensionContextForURL_XHandle = Selector.GetHandle ("extensionContextForURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtensionContextsX = "extensionContexts";
		static readonly NativeHandle selExtensionContextsXHandle = Selector.GetHandle ("extensionContexts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtensionsX = "extensions";
		static readonly NativeHandle selExtensionsXHandle = Selector.GetHandle ("extensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchDataRecordOfTypes_ForExtensionContext_CompletionHandler_X = "fetchDataRecordOfTypes:forExtensionContext:completionHandler:";
		static readonly NativeHandle selFetchDataRecordOfTypes_ForExtensionContext_CompletionHandler_XHandle = Selector.GetHandle ("fetchDataRecordOfTypes:forExtensionContext:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchDataRecordsOfTypes_CompletionHandler_X = "fetchDataRecordsOfTypes:completionHandler:";
		static readonly NativeHandle selFetchDataRecordsOfTypes_CompletionHandler_XHandle = Selector.GetHandle ("fetchDataRecordsOfTypes:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithConfiguration_X = "initWithConfiguration:";
		static readonly NativeHandle selInitWithConfiguration_XHandle = Selector.GetHandle ("initWithConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadExtensionContext_Error_X = "loadExtensionContext:error:";
		static readonly NativeHandle selLoadExtensionContext_Error_XHandle = Selector.GetHandle ("loadExtensionContext:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDataOfTypes_FromDataRecords_CompletionHandler_X = "removeDataOfTypes:fromDataRecords:completionHandler:";
		static readonly NativeHandle selRemoveDataOfTypes_FromDataRecords_CompletionHandler_XHandle = Selector.GetHandle ("removeDataOfTypes:fromDataRecords:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnloadExtensionContext_Error_X = "unloadExtensionContext:error:";
		static readonly NativeHandle selUnloadExtensionContext_Error_XHandle = Selector.GetHandle ("unloadExtensionContext:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKWebExtensionController");
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
		protected WKWebExtensionController (NSObjectFlag t) : base (t)
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
		protected internal WKWebExtensionController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKWebExtensionController ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithConfiguration:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKWebExtensionController (WKWebExtensionControllerConfiguration configuration)
			: base (NSObjectFlag.Empty)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithConfiguration_XHandle, configuration__handle__), "initWithConfiguration:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithConfiguration_XHandle, configuration__handle__), "initWithConfiguration:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
		}
		[Export ("didActivateTab:previousActiveTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateTab (IWKWebExtensionTab activatedTab, IWKWebExtensionTab? previousTab)
		{
			var activatedTab__handle__ = activatedTab!.GetNonNullHandle (nameof (activatedTab));
			var previousTab__handle__ = previousTab.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDidActivateTab_PreviousActiveTab_XHandle, activatedTab__handle__, previousTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDidActivateTab_PreviousActiveTab_XHandle, activatedTab__handle__, previousTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (activatedTab);
			GC.KeepAlive (previousTab);
		}
		[Export ("didChangeTabProperties:forTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeTabProperties (WKWebExtensionTabChangedProperties properties, IWKWebExtensionTab changedTab)
		{
			var changedTab__handle__ = changedTab!.GetNonNullHandle (nameof (changedTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selDidChangeTabProperties_ForTab_XHandle, (UIntPtr) (ulong) properties, changedTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selDidChangeTabProperties_ForTab_XHandle, (UIntPtr) (ulong) properties, changedTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (changedTab);
		}
		[Export ("didCloseTab:windowIsClosing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseTab (IWKWebExtensionTab closedTab, bool windowIsClosing)
		{
			var closedTab__handle__ = closedTab!.GetNonNullHandle (nameof (closedTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selDidCloseTab_WindowIsClosing_XHandle, closedTab__handle__, windowIsClosing ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selDidCloseTab_WindowIsClosing_XHandle, closedTab__handle__, windowIsClosing ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (closedTab);
		}
		[Export ("didCloseWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseWindow (IWKWebExtensionWindow closedWindow)
		{
			var closedWindow__handle__ = closedWindow!.GetNonNullHandle (nameof (closedWindow));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidCloseWindow_XHandle, closedWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidCloseWindow_XHandle, closedWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (closedWindow);
		}
		[Export ("didDeselectTabs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeselectTabs (IWKWebExtensionTab[] deselectedTabs)
		{
			if (deselectedTabs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deselectedTabs));
			using var nsa_deselectedTabs = NSArray.FromNSObjects (deselectedTabs);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidDeselectTabs_XHandle, nsa_deselectedTabs.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidDeselectTabs_XHandle, nsa_deselectedTabs.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didFocusWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFocusWindow (IWKWebExtensionWindow? focusedWindow)
		{
			var focusedWindow__handle__ = focusedWindow.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidFocusWindow_XHandle, focusedWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidFocusWindow_XHandle, focusedWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (focusedWindow);
		}
		[Export ("didMoveTab:fromIndex:inWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMoveTab (IWKWebExtensionTab movedTab, nuint index, IWKWebExtensionWindow? oldWindow)
		{
			var movedTab__handle__ = movedTab!.GetNonNullHandle (nameof (movedTab));
			var oldWindow__handle__ = oldWindow.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selDidMoveTab_FromIndex_InWindow_XHandle, movedTab__handle__, index, oldWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selDidMoveTab_FromIndex_InWindow_XHandle, movedTab__handle__, index, oldWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (movedTab);
			GC.KeepAlive (oldWindow);
		}
		[Export ("didOpenTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenTab (IWKWebExtensionTab newTab)
		{
			var newTab__handle__ = newTab!.GetNonNullHandle (nameof (newTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidOpenTab_XHandle, newTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidOpenTab_XHandle, newTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newTab);
		}
		[Export ("didOpenWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenWindow (IWKWebExtensionWindow newWindow)
		{
			var newWindow__handle__ = newWindow!.GetNonNullHandle (nameof (newWindow));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidOpenWindow_XHandle, newWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidOpenWindow_XHandle, newWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newWindow);
		}
		[Export ("didReplaceTab:withTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReplaceTab (IWKWebExtensionTab oldTab, IWKWebExtensionTab newTab)
		{
			var oldTab__handle__ = oldTab!.GetNonNullHandle (nameof (oldTab));
			var newTab__handle__ = newTab!.GetNonNullHandle (nameof (newTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDidReplaceTab_WithTab_XHandle, oldTab__handle__, newTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDidReplaceTab_WithTab_XHandle, oldTab__handle__, newTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldTab);
			GC.KeepAlive (newTab);
		}
		[Export ("didSelectTabs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectTabs (IWKWebExtensionTab[] selectedTabs)
		{
			if (selectedTabs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (selectedTabs));
			using var nsa_selectedTabs = NSArray.FromNSObjects (selectedTabs);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidSelectTabs_XHandle, nsa_selectedTabs.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidSelectTabs_XHandle, nsa_selectedTabs.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("fetchDataRecordOfTypes:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchDataRecord (NSSet<NSString> dataTypes, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDataRecordCallback))]WKWebExtensionControllerDataRecordCallback completionHandler)
		{
			var dataTypes__handle__ = dataTypes!.GetNonNullHandle (nameof (dataTypes));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDataRecordCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selFetchDataRecordOfTypes_ForExtensionContext_CompletionHandler_XHandle, dataTypes__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selFetchDataRecordOfTypes_ForExtensionContext_CompletionHandler_XHandle, dataTypes__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataTypes);
			GC.KeepAlive (extensionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKWebExtensionDataRecord> FetchDataRecordAsync (NSSet<NSString> dataTypes, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<WKWebExtensionDataRecord> ();
			FetchDataRecord(dataTypes, extensionContext, (dataRecord_) => {
				tcs.SetResult (dataRecord_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FetchDataRecord (WKWebExtensionDataType dataTypes, WKWebExtensionContext extensionContext, WKWebExtensionControllerDataRecordCallback completionHandler)
		{
			FetchDataRecord (new NSSet<NSString> (dataTypes.ToArray ()), extensionContext, completionHandler);;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<WKWebExtensionDataRecord> FetchDataRecordAsync (WKWebExtensionDataType dataTypes, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<WKWebExtensionDataRecord> ();
			FetchDataRecord(dataTypes, extensionContext, (dataRecord_) => {
				tcs.SetResult (dataRecord_!);
			});
			return tcs.Task;
		}
		[Export ("fetchDataRecordsOfTypes:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchDataRecords (NSSet<NSString> dataTypes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDataRecordsCallback))]WKWebExtensionControllerDataRecordsCallback completionHandler)
		{
			var dataTypes__handle__ = dataTypes!.GetNonNullHandle (nameof (dataTypes));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDataRecordsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchDataRecordsOfTypes_CompletionHandler_XHandle, dataTypes__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchDataRecordsOfTypes_CompletionHandler_XHandle, dataTypes__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataTypes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKWebExtensionDataRecord[]> FetchDataRecordsAsync (NSSet<NSString> dataTypes)
		{
			var tcs = new TaskCompletionSource<WKWebExtensionDataRecord[]> ();
			FetchDataRecords(dataTypes, (dataRecords_) => {
				tcs.SetResult (dataRecords_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FetchDataRecords (WKWebExtensionDataType dataTypes, WKWebExtensionControllerDataRecordsCallback completionHandler)
		{
			FetchDataRecords (new NSSet<NSString> (dataTypes.ToArray ()), completionHandler);;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<WKWebExtensionDataRecord[]> FetchDataRecordsAsync (WKWebExtensionDataType dataTypes)
		{
			var tcs = new TaskCompletionSource<WKWebExtensionDataRecord[]> ();
			FetchDataRecords(dataTypes, (dataRecords_) => {
				tcs.SetResult (dataRecords_!);
			});
			return tcs.Task;
		}
		[Export ("extensionContextForExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContext? GetExtensionContext (WKWebExtension extension)
		{
			var extension__handle__ = extension!.GetNonNullHandle (nameof (extension));
			WKWebExtensionContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKWebExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selExtensionContextForExtension_XHandle, extension__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKWebExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selExtensionContextForExtension_XHandle, extension__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (extension);
			return ret!;
		}
		[Export ("extensionContextForURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContext? GetExtensionContext (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			WKWebExtensionContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKWebExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selExtensionContextForURL_XHandle, url__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKWebExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selExtensionContextForURL_XHandle, url__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("loadExtensionContext:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool LoadExtensionContext (WKWebExtensionContext extensionContext, out NSError? error)
		{
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selLoadExtensionContext_Error_XHandle, extensionContext__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selLoadExtensionContext_Error_XHandle, extensionContext__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (extensionContext);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("removeDataOfTypes:fromDataRecords:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveData (NSSet<NSString> dataTypes, WKWebExtensionDataRecord[] dataRecords, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var dataTypes__handle__ = dataTypes!.GetNonNullHandle (nameof (dataTypes));
			if (dataRecords is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataRecords));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_dataRecords = NSArray.FromNSObjects (dataRecords);
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRemoveDataOfTypes_FromDataRecords_CompletionHandler_XHandle, dataTypes__handle__, nsa_dataRecords.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRemoveDataOfTypes_FromDataRecords_CompletionHandler_XHandle, dataTypes__handle__, nsa_dataRecords.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataTypes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RemoveDataAsync (NSSet<NSString> dataTypes, WKWebExtensionDataRecord[] dataRecords)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveData(dataTypes, dataRecords, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RemoveData (WKWebExtensionDataType dataTypes, WKWebExtensionDataRecord[] dataRecords, global::System.Action completionHandler)
		{
			RemoveData (new NSSet<NSString> (dataTypes.ToArray ()), dataRecords, completionHandler);;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task RemoveDataAsync (WKWebExtensionDataType dataTypes, WKWebExtensionDataRecord[] dataRecords)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveData(dataTypes, dataRecords, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("unloadExtensionContext:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool UnloadExtensionContext (WKWebExtensionContext extensionContext, out NSError? error)
		{
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selUnloadExtensionContext_Error_XHandle, extensionContext__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selUnloadExtensionContext_Error_XHandle, extensionContext__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (extensionContext);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WKWebExtensionDataType AllExtensionDataTypes {
			get {
				return WKWebExtensionDataTypeExtensions.ToFlags (WeakAllExtensionDataTypes);;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionControllerConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				WKWebExtensionControllerConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKWebExtensionControllerConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKWebExtensionControllerConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWKWebExtensionControllerDelegate? Delegate {
			get {
				return (WeakDelegate as IWKWebExtensionControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<WKWebExtensionContext> ExtensionContexts {
			[Export ("extensionContexts", ArgumentSemantic.Copy)]
			get {
				NSSet<WKWebExtensionContext>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<WKWebExtensionContext>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtensionContextsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<WKWebExtensionContext>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtensionContextsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<WKWebExtension> Extensions {
			[Export ("extensions", ArgumentSemantic.Copy)]
			get {
				NSSet<WKWebExtension>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<WKWebExtension>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtensionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<WKWebExtension>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtensionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet<NSString> WeakAllExtensionDataTypes {
			[Export ("allExtensionDataTypes", ArgumentSemantic.Copy)]
			get {
				NSSet<NSString>? ret;
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAllExtensionDataTypesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class WKWebExtensionController */
}
