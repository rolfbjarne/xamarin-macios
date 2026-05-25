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
namespace SafariServices {
	[Register("SFSafariExtensionHandler", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class SFSafariExtensionHandler : NSObject, INSExtensionRequestHandling, ISFSafariExtensionHandling {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdditionalRequestHeadersForURL_CompletionHandler_X = "additionalRequestHeadersForURL:completionHandler:";
		static readonly NativeHandle selAdditionalRequestHeadersForURL_CompletionHandler_XHandle = Selector.GetHandle ("additionalRequestHeadersForURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginRequestWithExtensionContext_X = "beginRequestWithExtensionContext:";
		static readonly NativeHandle selBeginRequestWithExtensionContext_XHandle = Selector.GetHandle ("beginRequestWithExtensionContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_X = "contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:";
		static readonly NativeHandle selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_XHandle = Selector.GetHandle ("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextMenuItemSelectedWithCommand_InPage_UserInfo_X = "contextMenuItemSelectedWithCommand:inPage:userInfo:";
		static readonly NativeHandle selContextMenuItemSelectedWithCommand_InPage_UserInfo_XHandle = Selector.GetHandle ("contextMenuItemSelectedWithCommand:inPage:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMessageReceivedFromContainingAppWithName_UserInfo_X = "messageReceivedFromContainingAppWithName:userInfo:";
		static readonly NativeHandle selMessageReceivedFromContainingAppWithName_UserInfo_XHandle = Selector.GetHandle ("messageReceivedFromContainingAppWithName:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMessageReceivedWithName_FromPage_UserInfo_X = "messageReceivedWithName:fromPage:userInfo:";
		static readonly NativeHandle selMessageReceivedWithName_FromPage_UserInfo_XHandle = Selector.GetHandle ("messageReceivedWithName:fromPage:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPage_WillNavigateToURL_X = "page:willNavigateToURL:";
		static readonly NativeHandle selPage_WillNavigateToURL_XHandle = Selector.GetHandle ("page:willNavigateToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopoverDidCloseInWindow_X = "popoverDidCloseInWindow:";
		static readonly NativeHandle selPopoverDidCloseInWindow_XHandle = Selector.GetHandle ("popoverDidCloseInWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopoverViewControllerX = "popoverViewController";
		static readonly NativeHandle selPopoverViewControllerXHandle = Selector.GetHandle ("popoverViewController");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopoverWillShowInWindow_X = "popoverWillShowInWindow:";
		static readonly NativeHandle selPopoverWillShowInWindow_XHandle = Selector.GetHandle ("popoverWillShowInWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarItemClickedInWindow_X = "toolbarItemClickedInWindow:";
		static readonly NativeHandle selToolbarItemClickedInWindow_XHandle = Selector.GetHandle ("toolbarItemClickedInWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_X = "validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:";
		static readonly NativeHandle selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_XHandle = Selector.GetHandle ("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateToolbarItemInWindow_ValidationHandler_X = "validateToolbarItemInWindow:validationHandler:";
		static readonly NativeHandle selValidateToolbarItemInWindow_ValidationHandler_XHandle = Selector.GetHandle ("validateToolbarItemInWindow:validationHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SFSafariExtensionHandler");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SFSafariExtensionHandler" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SFSafariExtensionHandler () : base (NSObjectFlag.Empty)
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
		protected SFSafariExtensionHandler (NSObjectFlag t) : base (t)
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
		protected internal SFSafariExtensionHandler (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("additionalRequestHeadersForURL:completionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AdditionalRequestHeaders (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V109))]global::System.Action<NSDictionary<NSString, NSString>> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V109.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAdditionalRequestHeadersForURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAdditionalRequestHeadersForURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="context">The <see cref="T:Foundation.NSExtensionContext" /> containing extension-relevant data.</param><summary>Developers can implement this method to prepare their extension for the host application request.</summary><remarks><para>Developers who implement this method must call <c>base.BeginRequestWithExtensionContext(context)</c> within their implementation.</para></remarks>
		[Export ("beginRequestWithExtensionContext:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginRequestWithExtensionContext (NSExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selBeginRequestWithExtensionContext_XHandle, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selBeginRequestWithExtensionContext_XHandle, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentBlocker (string contentBlockerIdentifier, NSUrl[] urls, SFSafariPage page)
		{
			if (contentBlockerIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentBlockerIdentifier));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var nscontentBlockerIdentifier = CFString.CreateNative (contentBlockerIdentifier);
			using var nsa_urls = NSArray.FromNSObjects (urls);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_XHandle, nscontentBlockerIdentifier, nsa_urls.Handle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selContentBlockerWithIdentifier_BlockedResourcesWithURLs_OnPage_XHandle, nscontentBlockerIdentifier, nsa_urls.Handle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			CFString.ReleaseNative (nscontentBlockerIdentifier);
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contextMenuItemSelectedWithCommand:inPage:userInfo:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextMenuItemSelected (string command, SFSafariPage page, NSDictionary? userInfo)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nscommand = CFString.CreateNative (command);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selContextMenuItemSelectedWithCommand_InPage_UserInfo_XHandle, nscommand, page__handle__, userInfo__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selContextMenuItemSelectedWithCommand_InPage_UserInfo_XHandle, nscommand, page__handle__, userInfo__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nscommand);
		}
		/// <param name="messageName">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("messageReceivedWithName:fromPage:userInfo:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageReceived (string messageName, SFSafariPage page, NSDictionary? userInfo)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selMessageReceivedWithName_FromPage_UserInfo_XHandle, nsmessageName, page__handle__, userInfo__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selMessageReceivedWithName_FromPage_UserInfo_XHandle, nsmessageName, page__handle__, userInfo__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
		}
		/// <param name="messageName">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("messageReceivedFromContainingAppWithName:userInfo:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageReceivedFromContainingApp (string messageName, NSDictionary<NSString, NSObject>? userInfo)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMessageReceivedFromContainingAppWithName_UserInfo_XHandle, nsmessageName, userInfo__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMessageReceivedFromContainingAppWithName_UserInfo_XHandle, nsmessageName, userInfo__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popoverDidCloseInWindow:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopoverDidClose (SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPopoverDidCloseInWindow_XHandle, window__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPopoverDidCloseInWindow_XHandle, window__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popoverWillShowInWindow:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopoverWillShow (SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPopoverWillShowInWindow_XHandle, window__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPopoverWillShowInWindow_XHandle, window__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("toolbarItemClickedInWindow:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToolbarItemClicked (SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToolbarItemClickedInWindow_XHandle, window__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarItemClickedInWindow_XHandle, window__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateContextMenuItem (string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFExtensionValidationHandler))]SFExtensionValidationHandler validationHandler)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			if (validationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (validationHandler));
			var nscommand = CFString.CreateNative (command);
			using var block_validationHandler = Trampolines.SDSFExtensionValidationHandler.CreateBlock (validationHandler);
			BlockLiteral *block_ptr_validationHandler = &block_validationHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_XHandle, nscommand, page__handle__, userInfo__handle__, (IntPtr) block_ptr_validationHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selValidateContextMenuItemWithCommand_InPage_UserInfo_ValidationHandler_XHandle, nscommand, page__handle__, userInfo__handle__, (IntPtr) block_ptr_validationHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nscommand);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<SFExtensionValidationResult> ValidateContextMenuItemAsync (string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo)
		{
			var tcs = new TaskCompletionSource<SFExtensionValidationResult> ();
			ValidateContextMenuItem(command, page, userInfo, (shouldHide_, text_) => {
				tcs.SetResult (new SFExtensionValidationResult (shouldHide_!, text_!));
			});
			return tcs.Task;
		}
		/// <param name="window">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("validateToolbarItemInWindow:validationHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateToolbarItem (SFSafariWindow window, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V134))]global::System.Action<bool, NSString> validationHandler)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (validationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (validationHandler));
			using var block_validationHandler = Trampolines.SDActionArity2V134.CreateBlock (validationHandler);
			BlockLiteral *block_ptr_validationHandler = &block_validationHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selValidateToolbarItemInWindow_ValidationHandler_XHandle, window__handle__, (IntPtr) block_ptr_validationHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selValidateToolbarItemInWindow_ValidationHandler_XHandle, window__handle__, (IntPtr) block_ptr_validationHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<SFValidationResult> ValidateToolbarItemAsync (SFSafariWindow window)
		{
			var tcs = new TaskCompletionSource<SFValidationResult> ();
			ValidateToolbarItem(window, (arg1_, arg2_) => {
				tcs.SetResult (new SFValidationResult (arg1_!, arg2_!));
			});
			return tcs.Task;
		}
		[Export ("page:willNavigateToURL:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillNavigate (SFSafariPage page, NSUrl? url)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var url__handle__ = url.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPage_WillNavigateToURL_XHandle, page__handle__, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPage_WillNavigateToURL_XHandle, page__handle__, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			GC.KeepAlive (url);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual SFSafariExtensionViewController PopoverViewController {
			[Export ("popoverViewController")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				SFSafariExtensionViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SFSafariExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPopoverViewControllerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SFSafariExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPopoverViewControllerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SFSafariExtensionHandler */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class SFExtensionValidationResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool ShouldHide { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSString Text { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="shouldHide">Result value from an asynchronous operation.</param>
		/// <param name="text">Result value from an asynchronous operation.</param>
		public SFExtensionValidationResult (bool shouldHide, NSString text) {
			this.ShouldHide = shouldHide;
			this.Text = text;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class SFValidationResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool Arg1 { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSString Arg2 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		/// <param name="arg2">Result value from an asynchronous operation.</param>
		public SFValidationResult (bool arg1, NSString arg2) {
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			Initialize ();
		}
	}
}
