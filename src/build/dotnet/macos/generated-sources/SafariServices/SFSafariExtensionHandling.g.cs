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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SFSafariExtensionHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "SFSafariExtensionHandling", WrapperType = typeof (SFSafariExtensionHandlingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageReceived", Selector = "messageReceivedWithName:fromPage:userInfo:", ParameterType = new Type [] { typeof (string), typeof (SafariServices.SFSafariPage), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToolbarItemClicked", Selector = "toolbarItemClickedInWindow:", ParameterType = new Type [] { typeof (SafariServices.SFSafariWindow) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateToolbarItem", Selector = "validateToolbarItemInWindow:validationHandler:", ParameterType = new Type [] { typeof (SafariServices.SFSafariWindow), typeof (global::System.Action<bool, NSString>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V134) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContextMenuItemSelected", Selector = "contextMenuItemSelectedWithCommand:inPage:userInfo:", ParameterType = new Type [] { typeof (string), typeof (SafariServices.SFSafariPage), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PopoverWillShow", Selector = "popoverWillShowInWindow:", ParameterType = new Type [] { typeof (SafariServices.SFSafariWindow) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PopoverDidClose", Selector = "popoverDidCloseInWindow:", ParameterType = new Type [] { typeof (SafariServices.SFSafariWindow) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateContextMenuItem", Selector = "validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:", ParameterType = new Type [] { typeof (string), typeof (SafariServices.SFSafariPage), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (SafariServices.SFExtensionValidationHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDSFExtensionValidationHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageReceivedFromContainingApp", Selector = "messageReceivedFromContainingAppWithName:userInfo:", ParameterType = new Type [] { typeof (string), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AdditionalRequestHeaders", Selector = "additionalRequestHeadersForURL:completionHandler:", ParameterType = new Type [] { typeof (NSUrl), typeof (global::System.Action<NSDictionary<NSString, NSString>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V109) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentBlocker", Selector = "contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:", ParameterType = new Type [] { typeof (string), typeof (NSUrl[]), typeof (SafariServices.SFSafariPage) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillNavigate", Selector = "page:willNavigateToURL:", ParameterType = new Type [] { typeof (SafariServices.SFSafariPage), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PopoverViewController", Selector = "popoverViewController", PropertyType = typeof (SafariServices.SFSafariExtensionViewController), GetterSelector = "popoverViewController", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISFSafariExtensionHandling : INativeObject, IDisposable
	{
		/// <param name="messageName">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("messageReceivedWithName:fromPage:userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageReceived (string messageName, SFSafariPage page, NSDictionary? userInfo)
		{
			_MessageReceived (this, messageName, page, userInfo);
		}
		/// <param name="messageName">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MessageReceived (ISFSafariExtensionHandling This, string messageName, SFSafariPage page, NSDictionary? userInfo)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("messageReceivedWithName:fromPage:userInfo:"), nsmessageName, page__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbarItemClickedInWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToolbarItemClicked (SFSafariWindow window)
		{
			_ToolbarItemClicked (this, window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ToolbarItemClicked (ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarItemClickedInWindow:"), window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="window">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("validateToolbarItemInWindow:validationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateToolbarItem (SFSafariWindow window, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V134))]global::System.Action<bool, NSString> validationHandler)
		{
			_ValidateToolbarItem (this, window, validationHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<SFValidationResult> ValidateToolbarItemAsync (SFSafariWindow window)
		{
			var tcs = new TaskCompletionSource<SFValidationResult> ();
			ValidateToolbarItem(window, (arg1_, arg2_) => {
				tcs.SetResult (new SFValidationResult (arg1_!, arg2_!));
			});
			return tcs.Task;
		}
		/// <param name="window">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ValidateToolbarItem (ISFSafariExtensionHandling This, SFSafariWindow window, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V134))]global::System.Action<bool, NSString> validationHandler)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (validationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (validationHandler));
			using var block_validationHandler = Trampolines.SDActionArity2V134.CreateBlock (validationHandler);
			BlockLiteral *block_ptr_validationHandler = &block_validationHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("validateToolbarItemInWindow:validationHandler:"), window__handle__, (IntPtr) block_ptr_validationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contextMenuItemSelectedWithCommand:inPage:userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextMenuItemSelected (string command, SFSafariPage page, NSDictionary? userInfo)
		{
			_ContextMenuItemSelected (this, command, page, userInfo);
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContextMenuItemSelected (ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary? userInfo)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nscommand = CFString.CreateNative (command);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuItemSelectedWithCommand:inPage:userInfo:"), nscommand, page__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nscommand);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverWillShowInWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopoverWillShow (SFSafariWindow window)
		{
			_PopoverWillShow (this, window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PopoverWillShow (ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverWillShowInWindow:"), window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverDidCloseInWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopoverDidClose (SFSafariWindow window)
		{
			_PopoverDidClose (this, window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PopoverDidClose (ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverDidCloseInWindow:"), window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateContextMenuItem (string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFExtensionValidationHandler))]SFExtensionValidationHandler validationHandler)
		{
			_ValidateContextMenuItem (this, command, page, userInfo, validationHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<SFExtensionValidationResult> ValidateContextMenuItemAsync (string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo)
		{
			var tcs = new TaskCompletionSource<SFExtensionValidationResult> ();
			ValidateContextMenuItem(command, page, userInfo, (shouldHide_, text_) => {
				tcs.SetResult (new SFExtensionValidationResult (shouldHide_!, text_!));
			});
			return tcs.Task;
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ValidateContextMenuItem (ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFExtensionValidationHandler))]SFExtensionValidationHandler validationHandler)
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:"), nscommand, page__handle__, userInfo__handle__, (IntPtr) block_ptr_validationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nscommand);
		}
		/// <param name="messageName">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("messageReceivedFromContainingAppWithName:userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageReceivedFromContainingApp (string messageName, NSDictionary<NSString, NSObject>? userInfo)
		{
			_MessageReceivedFromContainingApp (this, messageName, userInfo);
		}
		/// <param name="messageName">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MessageReceivedFromContainingApp (ISFSafariExtensionHandling This, string messageName, NSDictionary<NSString, NSObject>? userInfo)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("messageReceivedFromContainingAppWithName:userInfo:"), nsmessageName, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("additionalRequestHeadersForURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AdditionalRequestHeaders (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V109))]global::System.Action<NSDictionary<NSString, NSString>> completionHandler)
		{
			_AdditionalRequestHeaders (this, url, completionHandler);
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AdditionalRequestHeaders (ISFSafariExtensionHandling This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V109))]global::System.Action<NSDictionary<NSString, NSString>> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V109.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("additionalRequestHeadersForURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		[global::Foundation.OptionalMember]
		[Export ("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentBlocker (string contentBlockerIdentifier, NSUrl[] urls, SFSafariPage page)
		{
			_ContentBlocker (this, contentBlockerIdentifier, urls, page);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContentBlocker (ISFSafariExtensionHandling This, string contentBlockerIdentifier, NSUrl[] urls, SFSafariPage page)
		{
			if (contentBlockerIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentBlockerIdentifier));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var nscontentBlockerIdentifier = CFString.CreateNative (contentBlockerIdentifier);
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:"), nscontentBlockerIdentifier, nsa_urls.Handle, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			CFString.ReleaseNative (nscontentBlockerIdentifier);
		}
		[global::Foundation.OptionalMember]
		[Export ("page:willNavigateToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillNavigate (SFSafariPage page, NSUrl? url)
		{
			_WillNavigate (this, page, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillNavigate (ISFSafariExtensionHandling This, SFSafariPage page, NSUrl? url)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var url__handle__ = url.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("page:willNavigateToURL:"), page__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (url);
		}
		[DynamicDependencyAttribute ("AdditionalRequestHeaders(Foundation.NSUrl,System.Action{Foundation.NSDictionary{Foundation.NSString,Foundation.NSString}})")]
		[DynamicDependencyAttribute ("ContentBlocker(System.String,Foundation.NSUrl[],SafariServices.SFSafariPage)")]
		[DynamicDependencyAttribute ("ContextMenuItemSelected(System.String,SafariServices.SFSafariPage,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("MessageReceived(System.String,SafariServices.SFSafariPage,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("MessageReceivedFromContainingApp(System.String,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("PopoverDidClose(SafariServices.SFSafariWindow)")]
		[DynamicDependencyAttribute ("PopoverViewController")]
		[DynamicDependencyAttribute ("PopoverWillShow(SafariServices.SFSafariWindow)")]
		[DynamicDependencyAttribute ("ToolbarItemClicked(SafariServices.SFSafariWindow)")]
		[DynamicDependencyAttribute ("ValidateContextMenuItem(System.String,SafariServices.SFSafariPage,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},SafariServices.SFExtensionValidationHandler)")]
		[DynamicDependencyAttribute ("ValidateToolbarItem(SafariServices.SFSafariWindow,System.Action{System.Boolean,Foundation.NSString})")]
		[DynamicDependencyAttribute ("WillNavigate(SafariServices.SFSafariPage,Foundation.NSUrl)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFSafariExtensionHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISFSafariExtensionHandling ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual SFSafariExtensionViewController PopoverViewController {
			[Export ("popoverViewController")]
			get {
				return _GetPopoverViewController (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SFSafariExtensionViewController _GetPopoverViewController (ISFSafariExtensionHandling This)
		{
			SFSafariExtensionViewController ret;
			ret =  Runtime.GetNSObject<SFSafariExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("popoverViewController")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISFSafariExtensionHandling" /> interface to support all the methods from the SFSafariExtensionHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISFSafariExtensionHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SFSafariExtensionHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SFSafariExtensionHandling_Extensions {
		/// <param name="messageName">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MessageReceived (this ISFSafariExtensionHandling This, string messageName, SFSafariPage page, NSDictionary? userInfo)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("messageReceivedWithName:fromPage:userInfo:"), nsmessageName, page__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToolbarItemClicked (this ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarItemClickedInWindow:"), window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="window">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ValidateToolbarItem (this ISFSafariExtensionHandling This, SFSafariWindow window, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V134))]global::System.Action<bool, NSString> validationHandler)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (validationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (validationHandler));
			using var block_validationHandler = Trampolines.SDActionArity2V134.CreateBlock (validationHandler);
			BlockLiteral *block_ptr_validationHandler = &block_validationHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("validateToolbarItemInWindow:validationHandler:"), window__handle__, (IntPtr) block_ptr_validationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<SFValidationResult> ValidateToolbarItemAsync (this ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var tcs = new TaskCompletionSource<SFValidationResult> ();
			This.ValidateToolbarItem(window, (arg1_, arg2_) => {
				tcs.SetResult (new SFValidationResult (arg1_!, arg2_!));
			});
			return tcs.Task;
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContextMenuItemSelected (this ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary? userInfo)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nscommand = CFString.CreateNative (command);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuItemSelectedWithCommand:inPage:userInfo:"), nscommand, page__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nscommand);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PopoverWillShow (this ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverWillShowInWindow:"), window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PopoverDidClose (this ISFSafariExtensionHandling This, SFSafariWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverDidCloseInWindow:"), window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
		}
		/// <param name="command">To be added.</param><param name="page">To be added.</param><param name="userInfo">To be added.</param><param name="validationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ValidateContextMenuItem (this ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFExtensionValidationHandler))]SFExtensionValidationHandler validationHandler)
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:"), nscommand, page__handle__, userInfo__handle__, (IntPtr) block_ptr_validationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nscommand);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<SFExtensionValidationResult> ValidateContextMenuItemAsync (this ISFSafariExtensionHandling This, string command, SFSafariPage page, NSDictionary<NSString, NSObject>? userInfo)
		{
			var tcs = new TaskCompletionSource<SFExtensionValidationResult> ();
			This.ValidateContextMenuItem(command, page, userInfo, (shouldHide_, text_) => {
				tcs.SetResult (new SFExtensionValidationResult (shouldHide_!, text_!));
			});
			return tcs.Task;
		}
		/// <param name="messageName">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MessageReceivedFromContainingApp (this ISFSafariExtensionHandling This, string messageName, NSDictionary<NSString, NSObject>? userInfo)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("messageReceivedFromContainingAppWithName:userInfo:"), nsmessageName, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AdditionalRequestHeaders (this ISFSafariExtensionHandling This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V109))]global::System.Action<NSDictionary<NSString, NSString>> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V109.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("additionalRequestHeadersForURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContentBlocker (this ISFSafariExtensionHandling This, string contentBlockerIdentifier, NSUrl[] urls, SFSafariPage page)
		{
			if (contentBlockerIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentBlockerIdentifier));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var nscontentBlockerIdentifier = CFString.CreateNative (contentBlockerIdentifier);
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:"), nscontentBlockerIdentifier, nsa_urls.Handle, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			CFString.ReleaseNative (nscontentBlockerIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillNavigate (this ISFSafariExtensionHandling This, SFSafariPage page, NSUrl? url)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var url__handle__ = url.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("page:willNavigateToURL:"), page__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (page);
			GC.KeepAlive (url);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SFSafariExtensionViewController GetPopoverViewController (this ISFSafariExtensionHandling This)
		{
			SFSafariExtensionViewController ret;
			ret =  Runtime.GetNSObject<SFSafariExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("popoverViewController")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SFSafariExtensionHandlingWrapper : BaseWrapper, ISFSafariExtensionHandling {
		public SFSafariExtensionHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFSafariExtensionHandlingWrapper))]
		static SFSafariExtensionHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
