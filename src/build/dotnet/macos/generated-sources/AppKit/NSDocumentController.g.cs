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
	[Register("NSDocumentController", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSDocumentController : NSObject, INSCoding, INSMenuItemValidation, INSUserInterfaceValidations, INSWindowRestoration {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsFromRunningOpenPanelX = "URLsFromRunningOpenPanel";
		static readonly NativeHandle selURLsFromRunningOpenPanelXHandle = Selector.GetHandle ("URLsFromRunningOpenPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddDocument_X = "addDocument:";
		static readonly NativeHandle selAddDocument_XHandle = Selector.GetHandle ("addDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsAutomaticShareMenuX = "allowsAutomaticShareMenu";
		static readonly NativeHandle selAllowsAutomaticShareMenuXHandle = Selector.GetHandle ("allowsAutomaticShareMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavingDelayX = "autosavingDelay";
		static readonly NativeHandle selAutosavingDelayXHandle = Selector.GetHandle ("autosavingDelay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginOpenPanel_ForTypes_CompletionHandler_X = "beginOpenPanel:forTypes:completionHandler:";
		static readonly NativeHandle selBeginOpenPanel_ForTypes_CompletionHandler_XHandle = Selector.GetHandle ("beginOpenPanel:forTypes:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginOpenPanelWithCompletionHandler_X = "beginOpenPanelWithCompletionHandler:";
		static readonly NativeHandle selBeginOpenPanelWithCompletionHandler_XHandle = Selector.GetHandle ("beginOpenPanelWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearRecentDocuments_X = "clearRecentDocuments:";
		static readonly NativeHandle selClearRecentDocuments_XHandle = Selector.GetHandle ("clearRecentDocuments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_X = "closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:";
		static readonly NativeHandle selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_XHandle = Selector.GetHandle ("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDirectoryX = "currentDirectory";
		static readonly NativeHandle selCurrentDirectoryXHandle = Selector.GetHandle ("currentDirectory");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDocumentX = "currentDocument";
		static readonly NativeHandle selCurrentDocumentXHandle = Selector.GetHandle ("currentDocument");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultTypeX = "defaultType";
		static readonly NativeHandle selDefaultTypeXHandle = Selector.GetHandle ("defaultType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameForType_X = "displayNameForType:";
		static readonly NativeHandle selDisplayNameForType_XHandle = Selector.GetHandle ("displayNameForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentClassForType_X = "documentClassForType:";
		static readonly NativeHandle selDocumentClassForType_XHandle = Selector.GetHandle ("documentClassForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentClassNamesX = "documentClassNames";
		static readonly NativeHandle selDocumentClassNamesXHandle = Selector.GetHandle ("documentClassNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentForURL_X = "documentForURL:";
		static readonly NativeHandle selDocumentForURL_XHandle = Selector.GetHandle ("documentForURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentForWindow_X = "documentForWindow:";
		static readonly NativeHandle selDocumentForWindow_XHandle = Selector.GetHandle ("documentForWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentsX = "documents";
		static readonly NativeHandle selDocumentsXHandle = Selector.GetHandle ("documents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_X = "duplicateDocumentWithContentsOfURL:copying:displayName:error:";
		static readonly NativeHandle selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_XHandle = Selector.GetHandle ("duplicateDocumentWithContentsOfURL:copying:displayName:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasEditedDocumentsX = "hasEditedDocuments";
		static readonly NativeHandle selHasEditedDocumentsXHandle = Selector.GetHandle ("hasEditedDocuments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeDocumentForURL_WithContentsOfURL_OfType_Error_X = "makeDocumentForURL:withContentsOfURL:ofType:error:";
		static readonly NativeHandle selMakeDocumentForURL_WithContentsOfURL_OfType_Error_XHandle = Selector.GetHandle ("makeDocumentForURL:withContentsOfURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeDocumentWithContentsOfURL_OfType_Error_X = "makeDocumentWithContentsOfURL:ofType:error:";
		static readonly NativeHandle selMakeDocumentWithContentsOfURL_OfType_Error_XHandle = Selector.GetHandle ("makeDocumentWithContentsOfURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeUntitledDocumentOfType_Error_X = "makeUntitledDocumentOfType:error:";
		static readonly NativeHandle selMakeUntitledDocumentOfType_Error_XHandle = Selector.GetHandle ("makeUntitledDocumentOfType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumRecentDocumentCountX = "maximumRecentDocumentCount";
		static readonly NativeHandle selMaximumRecentDocumentCountXHandle = Selector.GetHandle ("maximumRecentDocumentCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewDocument_X = "newDocument:";
		static readonly NativeHandle selNewDocument_XHandle = Selector.GetHandle ("newDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoteNewRecentDocument_X = "noteNewRecentDocument:";
		static readonly NativeHandle selNoteNewRecentDocument_XHandle = Selector.GetHandle ("noteNewRecentDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoteNewRecentDocumentURL_X = "noteNewRecentDocumentURL:";
		static readonly NativeHandle selNoteNewRecentDocumentURL_XHandle = Selector.GetHandle ("noteNewRecentDocumentURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenDocument_X = "openDocument:";
		static readonly NativeHandle selOpenDocument_XHandle = Selector.GetHandle ("openDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenDocumentWithContentsOfURL_Display_CompletionHandler_X = "openDocumentWithContentsOfURL:display:completionHandler:";
		static readonly NativeHandle selOpenDocumentWithContentsOfURL_Display_CompletionHandler_XHandle = Selector.GetHandle ("openDocumentWithContentsOfURL:display:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenDocumentWithContentsOfURL_Display_Error_X = "openDocumentWithContentsOfURL:display:error:";
		static readonly NativeHandle selOpenDocumentWithContentsOfURL_Display_Error_XHandle = Selector.GetHandle ("openDocumentWithContentsOfURL:display:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenUntitledDocumentAndDisplay_Error_X = "openUntitledDocumentAndDisplay:error:";
		static readonly NativeHandle selOpenUntitledDocumentAndDisplay_Error_XHandle = Selector.GetHandle ("openUntitledDocumentAndDisplay:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentError_X = "presentError:";
		static readonly NativeHandle selPresentError_XHandle = Selector.GetHandle ("presentError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_X = "presentError:modalForWindow:delegate:didPresentSelector:contextInfo:";
		static readonly NativeHandle selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_XHandle = Selector.GetHandle ("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecentDocumentURLsX = "recentDocumentURLs";
		static readonly NativeHandle selRecentDocumentURLsXHandle = Selector.GetHandle ("recentDocumentURLs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDocument_X = "removeDocument:";
		static readonly NativeHandle selRemoveDocument_XHandle = Selector.GetHandle ("removeDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_X = "reopenDocumentForURL:withContentsOfURL:display:completionHandler:";
		static readonly NativeHandle selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_XHandle = Selector.GetHandle ("reopenDocumentForURL:withContentsOfURL:display:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReopenDocumentForURL_WithContentsOfURL_Error_X = "reopenDocumentForURL:withContentsOfURL:error:";
		static readonly NativeHandle selReopenDocumentForURL_WithContentsOfURL_Error_XHandle = Selector.GetHandle ("reopenDocumentForURL:withContentsOfURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestoreWindowWithIdentifier_State_CompletionHandler_X = "restoreWindowWithIdentifier:state:completionHandler:";
		static readonly NativeHandle selRestoreWindowWithIdentifier_State_CompletionHandler_XHandle = Selector.GetHandle ("restoreWindowWithIdentifier:state:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_X = "reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:";
		static readonly NativeHandle selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_XHandle = Selector.GetHandle ("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalOpenPanel_ForTypes_X = "runModalOpenPanel:forTypes:";
		static readonly NativeHandle selRunModalOpenPanel_ForTypes_XHandle = Selector.GetHandle ("runModalOpenPanel:forTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveAllDocuments_X = "saveAllDocuments:";
		static readonly NativeHandle selSaveAllDocuments_XHandle = Selector.GetHandle ("saveAllDocuments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosavingDelay_X = "setAutosavingDelay:";
		static readonly NativeHandle selSetAutosavingDelay_XHandle = Selector.GetHandle ("setAutosavingDelay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedDocumentControllerX = "sharedDocumentController";
		static readonly NativeHandle selSharedDocumentControllerXHandle = Selector.GetHandle ("sharedDocumentController");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardShareMenuItemX = "standardShareMenuItem";
		static readonly NativeHandle selStandardShareMenuItemXHandle = Selector.GetHandle ("standardShareMenuItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeForContentsOfURL_Error_X = "typeForContentsOfURL:error:";
		static readonly NativeHandle selTypeForContentsOfURL_Error_XHandle = Selector.GetHandle ("typeForContentsOfURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateMenuItem_X = "validateMenuItem:";
		static readonly NativeHandle selValidateMenuItem_XHandle = Selector.GetHandle ("validateMenuItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillPresentError_X = "willPresentError:";
		static readonly NativeHandle selWillPresentError_XHandle = Selector.GetHandle ("willPresentError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSDocumentController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSDocumentController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDocumentController () : base (NSObjectFlag.Empty)
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
		public NSDocumentController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSDocumentController (NSObjectFlag t) : base (t)
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
		protected internal NSDocumentController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddDocument (NSDocument document)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var document__handle__ = document!.GetNonNullHandle (nameof (document));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddDocument_XHandle, document__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddDocument_XHandle, document__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (document);
		}
		[Export ("beginOpenPanel:forTypes:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginOpenPanel (NSOpenPanel openPanel, NSArray inTypes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentControllerOpenPanelResultHandler))]NSDocumentControllerOpenPanelResultHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var openPanel__handle__ = openPanel!.GetNonNullHandle (nameof (openPanel));
			var inTypes__handle__ = inTypes!.GetNonNullHandle (nameof (inTypes));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentControllerOpenPanelResultHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selBeginOpenPanel_ForTypes_CompletionHandler_XHandle, openPanel__handle__, inTypes__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selBeginOpenPanel_ForTypes_CompletionHandler_XHandle, openPanel__handle__, inTypes__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (openPanel);
			GC.KeepAlive (inTypes);
		}
		[Export ("beginOpenPanelWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginOpenPanelWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentControllerOpenPanelWithCompletionHandler))]NSDocumentControllerOpenPanelWithCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentControllerOpenPanelWithCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selBeginOpenPanelWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selBeginOpenPanelWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("clearRecentDocuments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearRecentDocuments (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selClearRecentDocuments_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selClearRecentDocuments_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CloseAllDocuments (NSObject delegateObject, Selector didCloseAllSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject!.GetNonNullHandle (nameof (delegateObject));
			var didCloseAllSelector__handle__ = didCloseAllSelector!.GetNonNullHandle (nameof (didCloseAllSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_XHandle, delegateObject__handle__, didCloseAllSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_XHandle, delegateObject__handle__, didCloseAllSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didCloseAllSelector);
		}
		[Export ("displayNameForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DisplayNameForType (string typeName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDisplayNameForType_XHandle, nstypeName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisplayNameForType_XHandle, nstypeName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			return ret!;
		}
		[Export ("documentClassForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class DocumentClassForType (string typeName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			Class? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDocumentClassForType_XHandle, nstypeName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDocumentClassForType_XHandle, nstypeName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			return ret!;
		}
		[Export ("documentForURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDocument DocumentForUrl (NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSDocument? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDocumentForURL_XHandle, url__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDocumentForURL_XHandle, url__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("documentForWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDocument DocumentForWindow (NSWindow window)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			NSDocument? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDocumentForWindow_XHandle, window__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDocumentForWindow_XHandle, window__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
			return ret!;
		}
		[Export ("duplicateDocumentWithContentsOfURL:copying:displayName:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDocument DuplicateDocumentWithContentsOfUrl (NSUrl url, bool duplicateByCopying, string? displayName, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			var nsdisplayName = CFString.CreateNative (displayName);
			NSDocument? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle_ref_NativeHandle (this.Handle, selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_XHandle, url__handle__, duplicateByCopying ? (byte) 1 : (byte) 0, nsdisplayName, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool_NativeHandle_ref_NativeHandle (&__objc_super__, selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_XHandle, url__handle__, duplicateByCopying ? (byte) 1 : (byte) 0, nsdisplayName, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nsdisplayName);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("makeDocumentWithContentsOfURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject MakeDocument (NSUrl url, string typeName, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selMakeDocumentWithContentsOfURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selMakeDocumentWithContentsOfURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("makeDocumentForURL:withContentsOfURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject MakeDocument (NSUrl? urlOrNil, NSUrl contentsUrl, string typeName, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var urlOrNil__handle__ = urlOrNil.GetHandle ();
			var contentsUrl__handle__ = contentsUrl!.GetNonNullHandle (nameof (contentsUrl));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selMakeDocumentForURL_WithContentsOfURL_OfType_Error_XHandle, urlOrNil__handle__, contentsUrl__handle__, nstypeName, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selMakeDocumentForURL_WithContentsOfURL_OfType_Error_XHandle, urlOrNil__handle__, contentsUrl__handle__, nstypeName, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (urlOrNil);
			GC.KeepAlive (contentsUrl);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("makeUntitledDocumentOfType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject MakeUntitledDocument (string typeName, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle errorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selMakeUntitledDocumentOfType_Error_XHandle, nstypeName, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selMakeUntitledDocumentOfType_Error_XHandle, nstypeName, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NewDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selNewDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selNewDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("noteNewRecentDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NoteNewRecentDocument (NSDocument document)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var document__handle__ = document!.GetNonNullHandle (nameof (document));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selNoteNewRecentDocument_XHandle, document__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selNoteNewRecentDocument_XHandle, document__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (document);
		}
		[Export ("noteNewRecentDocumentURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NoteNewRecentDocumentURL (NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selNoteNewRecentDocumentURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selNoteNewRecentDocumentURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("openDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOpenDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOpenDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("openDocumentWithContentsOfURL:display:error:")]
		[ObsoletedOSPlatform ("macos10.7", "Use 'OpenDocument (NSUrl, bool, OpenDocumentCompletionHandler)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject OpenDocument (NSUrl url, bool displayDocument, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle outErrorValue = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, selOpenDocumentWithContentsOfURL_Display_Error_XHandle, url__handle__, displayDocument ? (byte) 1 : (byte) 0, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selOpenDocumentWithContentsOfURL_Display_Error_XHandle, url__handle__, displayDocument ? (byte) 1 : (byte) 0, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("openDocumentWithContentsOfURL:display:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenDocument (NSUrl url, bool display, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOpenDocumentCompletionHandler))]OpenDocumentCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDOpenDocumentCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selOpenDocumentWithContentsOfURL_Display_CompletionHandler_XHandle, url__handle__, display ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selOpenDocumentWithContentsOfURL_Display_CompletionHandler_XHandle, url__handle__, display ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("openUntitledDocumentAndDisplay:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject OpenUntitledDocument (bool displayDocument, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NativeHandle outErrorValue = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool_ref_NativeHandle (this.Handle, selOpenUntitledDocumentAndDisplay_Error_XHandle, displayDocument ? (byte) 1 : (byte) 0, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool_ref_NativeHandle (&__objc_super__, selOpenUntitledDocumentAndDisplay_Error_XHandle, displayDocument ? (byte) 1 : (byte) 0, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentError (NSError error, NSWindow window, NSObject? delegateObject, Selector? didPresentSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didPresentSelector__handle__ = didPresentSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_XHandle, error__handle__, window__handle__, delegateObject__handle__, didPresentSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_XHandle, error__handle__, window__handle__, delegateObject__handle__, didPresentSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
			GC.KeepAlive (window);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didPresentSelector);
		}
		[Export ("presentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PresentError (NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPresentError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
			return ret != 0;
		}
		[Export ("removeDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDocument (NSDocument document)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var document__handle__ = document!.GetNonNullHandle (nameof (document));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveDocument_XHandle, document__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveDocument_XHandle, document__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (document);
		}
		[Export ("reopenDocumentForURL:withContentsOfURL:error:")]
		[ObsoletedOSPlatform ("macos10.7", "Use 'NSDocumentController.ReopenDocumentForUrl (NSUrl, NSUrl, bool, OpenDocumentCompletionHandler)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ReopenDocument (NSUrl url, NSUrl contentsUrl, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var contentsUrl__handle__ = contentsUrl!.GetNonNullHandle (nameof (contentsUrl));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selReopenDocumentForURL_WithContentsOfURL_Error_XHandle, url__handle__, contentsUrl__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selReopenDocumentForURL_WithContentsOfURL_Error_XHandle, url__handle__, contentsUrl__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (contentsUrl);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("reopenDocumentForURL:withContentsOfURL:display:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReopenDocumentForUrl (NSUrl? url, NSUrl contentsUrl, bool displayDocument, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOpenDocumentCompletionHandler))]OpenDocumentCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url.GetHandle ();
			var contentsUrl__handle__ = contentsUrl!.GetNonNullHandle (nameof (contentsUrl));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDOpenDocumentCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (this.Handle, selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_XHandle, url__handle__, contentsUrl__handle__, displayDocument ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool_NativeHandle (&__objc_super__, selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_XHandle, url__handle__, contentsUrl__handle__, displayDocument ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (contentsUrl);
		}
		[Export ("restoreWindowWithIdentifier:state:completionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RestoreWindow (string identifier, NSCoder state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWindowCompletionHandler))]NSWindowCompletionHandler onCompletion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			if (onCompletion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onCompletion));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_onCompletion = Trampolines.SDNSWindowCompletionHandler.CreateBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = &block_onCompletion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selRestoreWindowWithIdentifier_State_CompletionHandler_XHandle, nsidentifier, state__handle__, (IntPtr) block_ptr_onCompletion);
			GC.KeepAlive (state);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReviewUnsavedDocuments (string title, bool cancellable, NSObject delegateObject, Selector didReviewAllSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var delegateObject__handle__ = delegateObject!.GetNonNullHandle (nameof (delegateObject));
			var didReviewAllSelector__handle__ = didReviewAllSelector!.GetNonNullHandle (nameof (didReviewAllSelector));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle_NativeHandle_IntPtr (this.Handle, selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_XHandle, nstitle, cancellable ? (byte) 1 : (byte) 0, delegateObject__handle__, didReviewAllSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_XHandle, nstitle, cancellable ? (byte) 1 : (byte) 0, delegateObject__handle__, didReviewAllSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didReviewAllSelector);
			CFString.ReleaseNative (nstitle);
		}
		[Export ("runModalOpenPanel:forTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RunModalOpenPanel (NSOpenPanel openPanel, string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var openPanel__handle__ = openPanel!.GetNonNullHandle (nameof (openPanel));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRunModalOpenPanel_ForTypes_XHandle, openPanel__handle__, nsa_types.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRunModalOpenPanel_ForTypes_XHandle, openPanel__handle__, nsa_types.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (openPanel);
			return ret!;
		}
		[Export ("saveAllDocuments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveAllDocuments (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveAllDocuments_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveAllDocuments_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("typeForContentsOfURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string TypeForUrl (NSUrl url, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle outErrorValue = IntPtr.Zero;
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selTypeForContentsOfURL_Error_XHandle, url__handle__, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selTypeForContentsOfURL_Error_XHandle, url__handle__, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("URLsFromRunningOpenPanel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] UrlsFromRunningOpenPanel ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSUrl[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLsFromRunningOpenPanelXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLsFromRunningOpenPanelXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateMenuItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateMenuItem (NSMenuItem menuItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menuItem__handle__ = menuItem!.GetNonNullHandle (nameof (menuItem));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateMenuItem_XHandle, menuItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateMenuItem_XHandle, menuItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menuItem);
			return ret != 0;
		}
		[Export ("validateUserInterfaceItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateUserInterfaceItem (INSValidatedUserInterfaceItem anItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateUserInterfaceItem_XHandle, anItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateUserInterfaceItem_XHandle, anItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anItem);
			return ret != 0;
		}
		[Export ("willPresentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError WillPresentError (NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			NSError? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selWillPresentError_XHandle, error__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selWillPresentError_XHandle, error__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsAutomaticShareMenu {
			[Export ("allowsAutomaticShareMenu")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsAutomaticShareMenuXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsAutomaticShareMenuXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double AutosavingDelay {
			[Export ("autosavingDelay")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selAutosavingDelayXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selAutosavingDelayXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAutosavingDelay:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetAutosavingDelay_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetAutosavingDelay_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CurrentDirectory {
			[Export ("currentDirectory")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentDirectoryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentDirectoryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDocument CurrentDocument {
			[Export ("currentDocument")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDocument? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DefaultType {
			[Export ("defaultType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] DocumentClassNames {
			[Export ("documentClassNames")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentClassNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentClassNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDocument[] Documents {
			[Export ("documents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDocument[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSDocument>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSDocument>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasEditedDocuments {
			[Export ("hasEditedDocuments")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasEditedDocumentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasEditedDocumentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual nint MaximumRecentDocumentCount {
			[Export ("maximumRecentDocumentCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaximumRecentDocumentCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaximumRecentDocumentCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] RecentDocumentUrls {
			[Export ("recentDocumentURLs")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecentDocumentURLsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecentDocumentURLsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDocumentController SharedDocumentController {
			[Export ("sharedDocumentController")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDocumentController? ret;
				ret =  Runtime.GetNSObject<NSDocumentController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedDocumentControllerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSMenuItem StandardShareMenuItem {
			[Export ("standardShareMenuItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenuItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandardShareMenuItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandardShareMenuItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSDocumentController */
}
