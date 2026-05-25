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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>WKWebExtensionControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "WKWebExtensionControllerDelegate", WrapperType = typeof (WKWebExtensionControllerDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenWindows", Selector = "webExtensionController:openWindowsForExtensionContext:", ReturnType = typeof (WebKit.IWKWebExtensionWindow[]), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFocusedWindow", Selector = "webExtensionController:focusedWindowForExtensionContext:", ReturnType = typeof (WebKit.IWKWebExtensionWindow), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenNewWindow", Selector = "webExtensionController:openNewWindowUsingConfiguration:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionWindowConfiguration), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegateOpenNewWindowCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewWindowCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenNewTab", Selector = "webExtensionController:openNewTabUsingConfiguration:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionTabConfiguration), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegateOpenNewTabCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenOptions", Selector = "webExtensionController:openOptionsPageForExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegateOpenOptionsCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenOptionsCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PromptForPermissions", Selector = "webExtensionController:promptForPermissions:inTab:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (global::Foundation.NSSet<NSString>), typeof (WebKit.IWKWebExtensionTab), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegatePromptForPermissionsCallback) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PromptForPermissionsToAccessUrls", Selector = "webExtensionController:promptForPermissionToAccessURLs:inTab:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (global::Foundation.NSSet<NSUrl>), typeof (WebKit.IWKWebExtensionTab), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PromptForPermissionMatchPatterns", Selector = "webExtensionController:promptForPermissionMatchPatterns:inTab:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (global::Foundation.NSSet<global::WebKit.WKWebExtensionMatchPattern>), typeof (WebKit.IWKWebExtensionTab), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAction", Selector = "webExtensionController:didUpdateAction:forExtensionContext:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionAction), typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentPopupForAction", Selector = "webExtensionController:presentPopupForAction:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionAction), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegatePresentPopupForActionCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePresentPopupForActionCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SendMessage", Selector = "webExtensionController:sendMessage:toApplicationWithIdentifier:forExtensionContext:replyHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (NSObject), typeof (string), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegateSendMessageCallback) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateSendMessageCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Connect", Selector = "webExtensionController:connectUsingMessagePort:forExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionController), typeof (WebKit.WKWebExtensionMessagePort), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionControllerDelegateConnectCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateConnectCallback) })]
	public partial interface IWKWebExtensionControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:openWindowsForExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow[] OpenWindows (WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			return _OpenWindows (this, controller, extensionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IWKWebExtensionWindow[] _OpenWindows (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			IWKWebExtensionWindow[]? ret;
			ret = CFArray.ArrayFromHandle<IWKWebExtensionWindow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:openWindowsForExtensionContext:"), controller__handle__, extensionContext__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (extensionContext);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:focusedWindowForExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow? GetFocusedWindow (WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			return _GetFocusedWindow (this, controller, extensionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IWKWebExtensionWindow? _GetFocusedWindow (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			IWKWebExtensionWindow? ret;
			ret =  Runtime.GetINativeObject<IWKWebExtensionWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:focusedWindowForExtensionContext:"), controller__handle__, extensionContext__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (extensionContext);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:openNewWindowUsingConfiguration:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenNewWindow (WKWebExtensionController controller, WKWebExtensionWindowConfiguration configuration, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewWindowCallback))]WKWebExtensionControllerDelegateOpenNewWindowCallback completionHandler)
		{
			_OpenNewWindow (this, controller, configuration, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<IWKWebExtensionWindow> OpenNewWindowAsync (WKWebExtensionController controller, WKWebExtensionWindowConfiguration configuration, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<IWKWebExtensionWindow> ();
			OpenNewWindow(controller, configuration, extensionContext, (newWindow_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (newWindow_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _OpenNewWindow (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionWindowConfiguration configuration, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewWindowCallback))]WKWebExtensionControllerDelegateOpenNewWindowCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegateOpenNewWindowCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:openNewWindowUsingConfiguration:forExtensionContext:completionHandler:"), controller__handle__, configuration__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (configuration);
			GC.KeepAlive (extensionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:openNewTabUsingConfiguration:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenNewTab (WKWebExtensionController controller, WKWebExtensionTabConfiguration configuration, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewTabCallback))]WKWebExtensionControllerDelegateOpenNewTabCallback completionHandler)
		{
			_OpenNewTab (this, controller, configuration, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<IWKWebExtensionTab> OpenNewTabAsync (WKWebExtensionController controller, WKWebExtensionTabConfiguration configuration, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<IWKWebExtensionTab> ();
			OpenNewTab(controller, configuration, extensionContext, (newWindow_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (newWindow_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _OpenNewTab (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionTabConfiguration configuration, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewTabCallback))]WKWebExtensionControllerDelegateOpenNewTabCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegateOpenNewTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:openNewTabUsingConfiguration:forExtensionContext:completionHandler:"), controller__handle__, configuration__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (configuration);
			GC.KeepAlive (extensionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:openOptionsPageForExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenOptions (WKWebExtensionController controller, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenOptionsCallback))]WKWebExtensionControllerDelegateOpenOptionsCallback completionHandler)
		{
			_OpenOptions (this, controller, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task OpenOptionsAsync (WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<bool> ();
			OpenOptions(controller, extensionContext, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _OpenOptions (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenOptionsCallback))]WKWebExtensionControllerDelegateOpenOptionsCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegateOpenOptionsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:openOptionsPageForExtensionContext:completionHandler:"), controller__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (extensionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:promptForPermissions:inTab:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PromptForPermissions (WKWebExtensionController controller, NSSet<NSString> permissions, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsCallback))]WKWebExtensionControllerDelegatePromptForPermissionsCallback completionHandler)
		{
			_PromptForPermissions (this, controller, permissions, tab, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PromptForPermissions (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, NSSet<NSString> permissions, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsCallback))]WKWebExtensionControllerDelegatePromptForPermissionsCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var permissions__handle__ = permissions!.GetNonNullHandle (nameof (permissions));
			var tab__handle__ = tab.GetHandle ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegatePromptForPermissionsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:promptForPermissions:inTab:forExtensionContext:completionHandler:"), controller__handle__, permissions__handle__, tab__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (permissions);
			GC.KeepAlive (tab);
			GC.KeepAlive (extensionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:promptForPermissionToAccessURLs:inTab:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PromptForPermissionsToAccessUrls (WKWebExtensionController controller, NSSet<NSUrl> urls, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback))]WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback completionHandler)
		{
			_PromptForPermissionsToAccessUrls (this, controller, urls, tab, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PromptForPermissionsToAccessUrls (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, NSSet<NSUrl> urls, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback))]WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var urls__handle__ = urls!.GetNonNullHandle (nameof (urls));
			var tab__handle__ = tab.GetHandle ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:promptForPermissionToAccessURLs:inTab:forExtensionContext:completionHandler:"), controller__handle__, urls__handle__, tab__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (urls);
			GC.KeepAlive (tab);
			GC.KeepAlive (extensionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:promptForPermissionMatchPatterns:inTab:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PromptForPermissionMatchPatterns (WKWebExtensionController controller, NSSet<WKWebExtensionMatchPattern> matchPatterns, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback))]WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback completionHandler)
		{
			_PromptForPermissionMatchPatterns (this, controller, matchPatterns, tab, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PromptForPermissionMatchPatterns (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, NSSet<WKWebExtensionMatchPattern> matchPatterns, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback))]WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var matchPatterns__handle__ = matchPatterns!.GetNonNullHandle (nameof (matchPatterns));
			var tab__handle__ = tab.GetHandle ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:promptForPermissionMatchPatterns:inTab:forExtensionContext:completionHandler:"), controller__handle__, matchPatterns__handle__, tab__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (matchPatterns);
			GC.KeepAlive (tab);
			GC.KeepAlive (extensionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:didUpdateAction:forExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAction (WKWebExtensionController controller, WKWebExtensionAction action, WKWebExtensionContext context)
		{
			_DidUpdateAction (this, controller, action, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAction (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionAction action, WKWebExtensionContext context)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:didUpdateAction:forExtensionContext:"), controller__handle__, action__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (action);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:presentPopupForAction:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentPopupForAction (WKWebExtensionController controller, WKWebExtensionAction action, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePresentPopupForActionCallback))]WKWebExtensionControllerDelegatePresentPopupForActionCallback completionHandler)
		{
			_PresentPopupForAction (this, controller, action, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PresentPopupForAction (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionAction action, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePresentPopupForActionCallback))]WKWebExtensionControllerDelegatePresentPopupForActionCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegatePresentPopupForActionCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:presentPopupForAction:forExtensionContext:completionHandler:"), controller__handle__, action__handle__, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (action);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:sendMessage:toApplicationWithIdentifier:forExtensionContext:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendMessage (WKWebExtensionController controller, NSObject message, string? applicationIdentifier, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateSendMessageCallback))]WKWebExtensionControllerDelegateSendMessageCallback replyHandler)
		{
			_SendMessage (this, controller, message, applicationIdentifier, extensionContext, replyHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> SendMessageAsync (WKWebExtensionController controller, NSObject message, string? applicationIdentifier, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			SendMessage(controller, message, applicationIdentifier, extensionContext, (replyMessage_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (replyMessage_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SendMessage (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, NSObject message, string? applicationIdentifier, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateSendMessageCallback))]WKWebExtensionControllerDelegateSendMessageCallback replyHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			var nsapplicationIdentifier = CFString.CreateNative (applicationIdentifier);
			using var block_replyHandler = Trampolines.SDWKWebExtensionControllerDelegateSendMessageCallback.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:sendMessage:toApplicationWithIdentifier:forExtensionContext:replyHandler:"), controller__handle__, message__handle__, nsapplicationIdentifier, extensionContext__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (message);
			GC.KeepAlive (extensionContext);
			CFString.ReleaseNative (nsapplicationIdentifier);
		}
		[global::Foundation.OptionalMember]
		[Export ("webExtensionController:connectUsingMessagePort:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Connect (WKWebExtensionController controller, WKWebExtensionMessagePort port, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateConnectCallback))]WKWebExtensionControllerDelegateConnectCallback completionHandler)
		{
			_Connect (this, controller, port, extensionContext, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ConnectAsync (WKWebExtensionController controller, WKWebExtensionMessagePort port, WKWebExtensionContext extensionContext)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Connect(controller, port, extensionContext, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Connect (IWKWebExtensionControllerDelegate This, WKWebExtensionController controller, WKWebExtensionMessagePort port, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateConnectCallback))]WKWebExtensionControllerDelegateConnectCallback completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var port__handle__ = port!.GetNonNullHandle (nameof (port));
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionControllerDelegateConnectCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webExtensionController:connectUsingMessagePort:forExtensionContext:completionHandler:"), controller__handle__, port__handle__, extensionContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (port);
			GC.KeepAlive (extensionContext);
		}
		[DynamicDependencyAttribute ("Connect(WebKit.WKWebExtensionController,WebKit.WKWebExtensionMessagePort,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegateConnectCallback)")]
		[DynamicDependencyAttribute ("DidUpdateAction(WebKit.WKWebExtensionController,WebKit.WKWebExtensionAction,WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetFocusedWindow(WebKit.WKWebExtensionController,WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("OpenNewTab(WebKit.WKWebExtensionController,WebKit.WKWebExtensionTabConfiguration,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegateOpenNewTabCallback)")]
		[DynamicDependencyAttribute ("OpenNewWindow(WebKit.WKWebExtensionController,WebKit.WKWebExtensionWindowConfiguration,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegateOpenNewWindowCallback)")]
		[DynamicDependencyAttribute ("OpenOptions(WebKit.WKWebExtensionController,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegateOpenOptionsCallback)")]
		[DynamicDependencyAttribute ("OpenWindows(WebKit.WKWebExtensionController,WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("PresentPopupForAction(WebKit.WKWebExtensionController,WebKit.WKWebExtensionAction,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegatePresentPopupForActionCallback)")]
		[DynamicDependencyAttribute ("PromptForPermissionMatchPatterns(WebKit.WKWebExtensionController,Foundation.NSSet{WebKit.WKWebExtensionMatchPattern},WebKit.IWKWebExtensionTab,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback)")]
		[DynamicDependencyAttribute ("PromptForPermissions(WebKit.WKWebExtensionController,Foundation.NSSet{Foundation.NSString},WebKit.IWKWebExtensionTab,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegatePromptForPermissionsCallback)")]
		[DynamicDependencyAttribute ("PromptForPermissionsToAccessUrls(WebKit.WKWebExtensionController,Foundation.NSSet{Foundation.NSUrl},WebKit.IWKWebExtensionTab,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback)")]
		[DynamicDependencyAttribute ("SendMessage(WebKit.WKWebExtensionController,Foundation.NSObject,System.String,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionControllerDelegateSendMessageCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKWebExtensionControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKWebExtensionControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKWebExtensionControllerDelegateWrapper : BaseWrapper, IWKWebExtensionControllerDelegate {
		public WKWebExtensionControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKWebExtensionControllerDelegateWrapper))]
		static WKWebExtensionControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWKWebExtensionControllerDelegate" /> (for the protocol <c>WKWebExtensionControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWKWebExtensionControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WKWebExtensionControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe partial class WKWebExtensionControllerDelegate : NSObject, IWKWebExtensionControllerDelegate {
		/// <summary>Creates a new <see cref="WKWebExtensionControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WKWebExtensionControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
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
		protected WKWebExtensionControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal WKWebExtensionControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("webExtensionController:connectUsingMessagePort:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Connect (WKWebExtensionController controller, WKWebExtensionMessagePort port, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateConnectCallback))]WKWebExtensionControllerDelegateConnectCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:didUpdateAction:forExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAction (WKWebExtensionController controller, WKWebExtensionAction action, WKWebExtensionContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:focusedWindowForExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow? GetFocusedWindow (WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:openNewTabUsingConfiguration:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenNewTab (WKWebExtensionController controller, WKWebExtensionTabConfiguration configuration, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewTabCallback))]WKWebExtensionControllerDelegateOpenNewTabCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:openNewWindowUsingConfiguration:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenNewWindow (WKWebExtensionController controller, WKWebExtensionWindowConfiguration configuration, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenNewWindowCallback))]WKWebExtensionControllerDelegateOpenNewWindowCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:openOptionsPageForExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenOptions (WKWebExtensionController controller, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateOpenOptionsCallback))]WKWebExtensionControllerDelegateOpenOptionsCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:openWindowsForExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow[] OpenWindows (WKWebExtensionController controller, WKWebExtensionContext extensionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:presentPopupForAction:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentPopupForAction (WKWebExtensionController controller, WKWebExtensionAction action, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePresentPopupForActionCallback))]WKWebExtensionControllerDelegatePresentPopupForActionCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:promptForPermissionMatchPatterns:inTab:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PromptForPermissionMatchPatterns (WKWebExtensionController controller, NSSet<WKWebExtensionMatchPattern> matchPatterns, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback))]WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:promptForPermissions:inTab:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PromptForPermissions (WKWebExtensionController controller, NSSet<NSString> permissions, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsCallback))]WKWebExtensionControllerDelegatePromptForPermissionsCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:promptForPermissionToAccessURLs:inTab:forExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PromptForPermissionsToAccessUrls (WKWebExtensionController controller, NSSet<NSUrl> urls, IWKWebExtensionTab? tab, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback))]WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webExtensionController:sendMessage:toApplicationWithIdentifier:forExtensionContext:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendMessage (WKWebExtensionController controller, NSObject message, string? applicationIdentifier, WKWebExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionControllerDelegateSendMessageCallback))]WKWebExtensionControllerDelegateSendMessageCallback replyHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WKWebExtensionControllerDelegate */
}
