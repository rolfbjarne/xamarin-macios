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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
	/// <summary>A delegate object that allows presenting native UI elements on behalf of a Web page.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKUIDelegate_Ref/index.html">Apple documentation for <c>WKUIDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKUIDelegate", WrapperType = typeof (WKUIDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateWebView", Selector = "webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:", ReturnType = typeof (WebKit.WKWebView), ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKWebViewConfiguration), typeof (WebKit.WKNavigationAction), typeof (WebKit.WKWindowFeatures) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunJavaScriptAlertPanel", Selector = "webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (string), typeof (WebKit.WKFrameInfo), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunJavaScriptConfirmPanel", Selector = "webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (string), typeof (WebKit.WKFrameInfo), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunJavaScriptTextInputPanel", Selector = "webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (string), typeof (string), typeof (WebKit.WKFrameInfo), typeof (global::System.Action<string>) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V58) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunOpenPanel", Selector = "webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKOpenPanelParameters), typeof (WebKit.WKFrameInfo), typeof (global::System.Action<NSUrl[]>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V245) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "webViewDidClose:", ParameterType = new Type [] { typeof (WebKit.WKWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPreviewElement", Selector = "webView:shouldPreviewElement:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKPreviewElementInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewingViewController", Selector = "webView:previewingViewControllerForElement:defaultActions:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKPreviewElementInfo), typeof (WebKit.IWKPreviewActionItem[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CommitPreviewingViewController", Selector = "webView:commitPreviewingViewController:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetContextMenuConfiguration", Selector = "webView:contextMenuConfigurationForElement:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKContextMenuElementInfo), typeof (global::System.Action<global::UIKit.UIContextMenuConfiguration>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V270) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCommitContextMenu", Selector = "webView:contextMenuForElement:willCommitWithAnimator:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKContextMenuElementInfo), typeof (IUIContextMenuInteractionCommitAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContextMenuWillPresent", Selector = "webView:contextMenuWillPresentForElement:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKContextMenuElementInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContextMenuDidEnd", Selector = "webView:contextMenuDidEndForElement:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKContextMenuElementInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestDeviceOrientationAndMotionPermission", Selector = "webView:requestDeviceOrientationAndMotionPermissionForOrigin:initiatedByFrame:decisionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKSecurityOrigin), typeof (WebKit.WKFrameInfo), typeof (global::System.Action<global::WebKit.WKPermissionDecision>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V271) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestMediaCapturePermission", Selector = "webView:requestMediaCapturePermissionForOrigin:initiatedByFrame:type:decisionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKSecurityOrigin), typeof (WebKit.WKFrameInfo), typeof (WebKit.WKMediaCaptureType), typeof (global::System.Action<global::WebKit.WKPermissionDecision>) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V271) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowLockDownMode", Selector = "webView:showLockdownModeFirstUseMessage:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (string), typeof (global::System.Action<global::WebKit.WKDialogResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V272) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentEditMenu", Selector = "webView:willPresentEditMenuWithAnimator:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (IUIEditMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissEditMenu", Selector = "webView:willDismissEditMenuWithAnimator:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (IUIEditMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IWKUIDelegate : INativeObject, IDisposable
	{
		/// <param name="webView">To be added.</param><param name="configuration">To be added.</param><param name="navigationAction">To be added.</param><param name="windowFeatures">To be added.</param><summary>Creates and configures a new <see cref="T:WebKit.WKWebView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebView? CreateWebView (WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
		{
			return _CreateWebView (this, webView, configuration, navigationAction, windowFeatures);
		}
		/// <param name="webView">To be added.</param><param name="configuration">To be added.</param><param name="navigationAction">To be added.</param><param name="windowFeatures">To be added.</param><summary>Creates and configures a new <see cref="T:WebKit.WKWebView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WKWebView? _CreateWebView (IWKUIDelegate This, WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var windowFeatures__handle__ = windowFeatures!.GetNonNullHandle (nameof (windowFeatures));
			WKWebView? ret;
			ret =  Runtime.GetNSObject<WKWebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:"), webView__handle__, configuration__handle__, navigationAction__handle__, windowFeatures__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (navigationAction);
			GC.KeepAlive (windowFeatures);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript alert to the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunJavaScriptAlertPanel (WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_RunJavaScriptAlertPanel (this, webView, message, frame, completionHandler);
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript alert to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RunJavaScriptAlertPanel (IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmessage = CFString.CreateNative (message);
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:"), webView__handle__, nsmessage, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (frame);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript confirmation dialog to the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunJavaScriptConfirmPanel (WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			_RunJavaScriptConfirmPanel (this, webView, message, frame, completionHandler);
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript confirmation dialog to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RunJavaScriptConfirmPanel (IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmessage = CFString.CreateNative (message);
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:"), webView__handle__, nsmessage, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (frame);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="webView">To be added.</param><param name="prompt">To be added.</param><param name="defaultText"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript text input box to the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:")]
		[Obsolete ("It's not possible to call the completion handler with a null value using this method. Please see https://github.com/dotnet/macios/issues/15728 for a workaround.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunJavaScriptTextInputPanel (WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V58))]global::System.Action<string> completionHandler)
		{
			_RunJavaScriptTextInputPanel (this, webView, prompt, defaultText, frame, completionHandler);
		}
		/// <param name="webView">To be added.</param><param name="prompt">To be added.</param><param name="defaultText"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript text input box to the user.</summary><remarks>To be added.</remarks>
		[Obsolete ("It's not possible to call the completion handler with a null value using this method. Please see https://github.com/dotnet/macios/issues/15728 for a workaround.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RunJavaScriptTextInputPanel (IWKUIDelegate This, WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V58))]global::System.Action<string> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (prompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prompt));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsprompt = CFString.CreateNative (prompt);
			var nsdefaultText = CFString.CreateNative (defaultText);
			using var block_completionHandler = Trampolines.SDActionArity1V58.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:"), webView__handle__, nsprompt, nsdefaultText, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (frame);
			CFString.ReleaseNative (nsprompt);
			CFString.ReleaseNative (nsdefaultText);
		}
		/// <param name="webView">To be added.</param><param name="parameters">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:")]
		[SupportedOSPlatform ("ios18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunOpenPanel (WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V245))]global::System.Action<NSUrl[]> completionHandler)
		{
			_RunOpenPanel (this, webView, parameters, frame, completionHandler);
		}
		/// <param name="webView">To be added.</param><param name="parameters">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RunOpenPanel (IWKUIDelegate This, WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V245))]global::System.Action<NSUrl[]> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V245.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:"), webView__handle__, parameters__handle__, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (parameters);
			GC.KeepAlive (frame);
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when <paramref name="webView" /> closes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewDidClose:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (WKWebView webView)
		{
			_DidClose (this, webView);
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when <paramref name="webView" /> closes.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidClose (IWKUIDelegate This, WKWebView webView)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewDidClose:"), webView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><summary>Method that is called to find out if the element should provide a preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:shouldPreviewElement:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPreviewElement (WKWebView webView, WKPreviewElementInfo elementInfo)
		{
			return _ShouldPreviewElement (this, webView, elementInfo);
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><summary>Method that is called to find out if the element should provide a preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPreviewElement (IWKUIDelegate This, WKWebView webView, WKPreviewElementInfo elementInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:shouldPreviewElement:"), webView__handle__, elementInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
			return ret != 0;
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><param name="previewActions">To be added.</param><summary>Method that is called when the user peeks at content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:previewingViewControllerForElement:defaultActions:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController? GetPreviewingViewController (WKWebView webView, WKPreviewElementInfo elementInfo, IWKPreviewActionItem[] previewActions)
		{
			return _GetPreviewingViewController (this, webView, elementInfo, previewActions);
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><param name="previewActions">To be added.</param><summary>Method that is called when the user peeks at content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIViewController? _GetPreviewingViewController (IWKUIDelegate This, WKWebView webView, WKPreviewElementInfo elementInfo, IWKPreviewActionItem[] previewActions)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			if (previewActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previewActions));
			using var nsa_previewActions = NSArray.FromNSObjects (previewActions);
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:previewingViewControllerForElement:defaultActions:"), webView__handle__, elementInfo__handle__, nsa_previewActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="previewingViewController">To be added.</param><summary>Method that is called to respond when the user pops a preview action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:commitPreviewingViewController:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitPreviewingViewController (WKWebView webView, global::UIKit.UIViewController previewingViewController)
		{
			_CommitPreviewingViewController (this, webView, previewingViewController);
		}
		/// <param name="webView">To be added.</param><param name="previewingViewController">To be added.</param><summary>Method that is called to respond when the user pops a preview action.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CommitPreviewingViewController (IWKUIDelegate This, WKWebView webView, global::UIKit.UIViewController previewingViewController)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var previewingViewController__handle__ = previewingViewController!.GetNonNullHandle (nameof (previewingViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:commitPreviewingViewController:"), webView__handle__, previewingViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (previewingViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:contextMenuConfigurationForElement:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetContextMenuConfiguration (WKWebView webView, WKContextMenuElementInfo elementInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<global::UIKit.UIContextMenuConfiguration> completionHandler)
		{
			_SetContextMenuConfiguration (this, webView, elementInfo, completionHandler);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetContextMenuConfiguration (IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<global::UIKit.UIContextMenuConfiguration> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V270.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuConfigurationForElement:completionHandler:"), webView__handle__, elementInfo__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:contextMenuForElement:willCommitWithAnimator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillCommitContextMenu (WKWebView webView, WKContextMenuElementInfo elementInfo, global::UIKit.IUIContextMenuInteractionCommitAnimating animator)
		{
			_WillCommitContextMenu (this, webView, elementInfo, animator);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillCommitContextMenu (IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo, global::UIKit.IUIContextMenuInteractionCommitAnimating animator)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuForElement:willCommitWithAnimator:"), webView__handle__, elementInfo__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:contextMenuWillPresentForElement:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextMenuWillPresent (WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			_ContextMenuWillPresent (this, webView, elementInfo);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContextMenuWillPresent (IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuWillPresentForElement:"), webView__handle__, elementInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:contextMenuDidEndForElement:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextMenuDidEnd (WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			_ContextMenuDidEnd (this, webView, elementInfo);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContextMenuDidEnd (IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuDidEndForElement:"), webView__handle__, elementInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:requestDeviceOrientationAndMotionPermissionForOrigin:initiatedByFrame:decisionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestDeviceOrientationAndMotionPermission (WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			_RequestDeviceOrientationAndMotionPermission (this, webView, origin, frame, decisionHandler);
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKPermissionDecision> RequestDeviceOrientationAndMotionPermissionAsync (WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame)
		{
			var tcs = new TaskCompletionSource<WKPermissionDecision> ();
			RequestDeviceOrientationAndMotionPermission(webView, origin, frame, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestDeviceOrientationAndMotionPermission (IWKUIDelegate This, WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var origin__handle__ = origin!.GetNonNullHandle (nameof (origin));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V271.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:requestDeviceOrientationAndMotionPermissionForOrigin:initiatedByFrame:decisionHandler:"), webView__handle__, origin__handle__, frame__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (origin);
			GC.KeepAlive (frame);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:requestMediaCapturePermissionForOrigin:initiatedByFrame:type:decisionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestMediaCapturePermission (WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, WKMediaCaptureType type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			_RequestMediaCapturePermission (this, webView, origin, frame, type, decisionHandler);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKPermissionDecision> RequestMediaCapturePermissionAsync (WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, WKMediaCaptureType type)
		{
			var tcs = new TaskCompletionSource<WKPermissionDecision> ();
			RequestMediaCapturePermission(webView, origin, frame, type, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestMediaCapturePermission (IWKUIDelegate This, WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, WKMediaCaptureType type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var origin__handle__ = origin!.GetNonNullHandle (nameof (origin));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V271.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("webView:requestMediaCapturePermissionForOrigin:initiatedByFrame:type:decisionHandler:"), webView__handle__, origin__handle__, frame__handle__, (IntPtr) (long) type, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (origin);
			GC.KeepAlive (frame);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:showLockdownModeFirstUseMessage:completionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowLockDownMode (WKWebView webView, string firstUseMessage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V272))]global::System.Action<WKDialogResult> completionHandler)
		{
			_ShowLockDownMode (this, webView, firstUseMessage, completionHandler);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKDialogResult> ShowLockDownModeAsync (WKWebView webView, string firstUseMessage)
		{
			var tcs = new TaskCompletionSource<WKDialogResult> ();
			ShowLockDownMode(webView, firstUseMessage, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ShowLockDownMode (IWKUIDelegate This, WKWebView webView, string firstUseMessage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V272))]global::System.Action<WKDialogResult> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (firstUseMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (firstUseMessage));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsfirstUseMessage = CFString.CreateNative (firstUseMessage);
			using var block_completionHandler = Trampolines.SDActionArity1V272.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:showLockdownModeFirstUseMessage:completionHandler:"), webView__handle__, nsfirstUseMessage, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			CFString.ReleaseNative (nsfirstUseMessage);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			_WillPresentEditMenu (this, webView, animator);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentEditMenu (IWKUIDelegate This, WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPresentEditMenuWithAnimator:"), webView__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			_WillDismissEditMenu (this, webView, animator);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissEditMenu (IWKUIDelegate This, WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willDismissEditMenuWithAnimator:"), webView__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (animator);
		}
		[DynamicDependencyAttribute ("CommitPreviewingViewController(WebKit.WKWebView,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("ContextMenuDidEnd(WebKit.WKWebView,WebKit.WKContextMenuElementInfo)")]
		[DynamicDependencyAttribute ("ContextMenuWillPresent(WebKit.WKWebView,WebKit.WKContextMenuElementInfo)")]
		[DynamicDependencyAttribute ("CreateWebView(WebKit.WKWebView,WebKit.WKWebViewConfiguration,WebKit.WKNavigationAction,WebKit.WKWindowFeatures)")]
		[DynamicDependencyAttribute ("DidClose(WebKit.WKWebView)")]
		[DynamicDependencyAttribute ("GetPreviewingViewController(WebKit.WKWebView,WebKit.WKPreviewElementInfo,WebKit.IWKPreviewActionItem[])")]
		[DynamicDependencyAttribute ("RequestDeviceOrientationAndMotionPermission(WebKit.WKWebView,WebKit.WKSecurityOrigin,WebKit.WKFrameInfo,System.Action{WebKit.WKPermissionDecision})")]
		[DynamicDependencyAttribute ("RequestMediaCapturePermission(WebKit.WKWebView,WebKit.WKSecurityOrigin,WebKit.WKFrameInfo,WebKit.WKMediaCaptureType,System.Action{WebKit.WKPermissionDecision})")]
		[DynamicDependencyAttribute ("RunJavaScriptAlertPanel(WebKit.WKWebView,System.String,WebKit.WKFrameInfo,System.Action)")]
		[DynamicDependencyAttribute ("RunJavaScriptConfirmPanel(WebKit.WKWebView,System.String,WebKit.WKFrameInfo,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("RunJavaScriptTextInputPanel(WebKit.WKWebView,System.String,System.String,WebKit.WKFrameInfo,System.Action{System.String})")]
		[DynamicDependencyAttribute ("RunOpenPanel(WebKit.WKWebView,WebKit.WKOpenPanelParameters,WebKit.WKFrameInfo,System.Action{Foundation.NSUrl[]})")]
		[DynamicDependencyAttribute ("SetContextMenuConfiguration(WebKit.WKWebView,WebKit.WKContextMenuElementInfo,System.Action{UIKit.UIContextMenuConfiguration})")]
		[DynamicDependencyAttribute ("ShouldPreviewElement(WebKit.WKWebView,WebKit.WKPreviewElementInfo)")]
		[DynamicDependencyAttribute ("ShowLockDownMode(WebKit.WKWebView,System.String,System.Action{WebKit.WKDialogResult})")]
		[DynamicDependencyAttribute ("WillCommitContextMenu(WebKit.WKWebView,WebKit.WKContextMenuElementInfo,UIKit.IUIContextMenuInteractionCommitAnimating)")]
		[DynamicDependencyAttribute ("WillDismissEditMenu(WebKit.WKWebView,UIKit.IUIEditMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillPresentEditMenu(WebKit.WKWebView,UIKit.IUIEditMenuInteractionAnimating)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKUIDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKUIDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWKUIDelegate" /> interface to support all the methods from the WKUIDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWKUIDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WKUIDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WKUIDelegate_Extensions {
		/// <param name="webView">To be added.</param><param name="configuration">To be added.</param><param name="navigationAction">To be added.</param><param name="windowFeatures">To be added.</param><summary>Creates and configures a new <see cref="T:WebKit.WKWebView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WKWebView? CreateWebView (this IWKUIDelegate This, WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var windowFeatures__handle__ = windowFeatures!.GetNonNullHandle (nameof (windowFeatures));
			WKWebView? ret;
			ret =  Runtime.GetNSObject<WKWebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:"), webView__handle__, configuration__handle__, navigationAction__handle__, windowFeatures__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (navigationAction);
			GC.KeepAlive (windowFeatures);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript alert to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RunJavaScriptAlertPanel (this IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmessage = CFString.CreateNative (message);
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:"), webView__handle__, nsmessage, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (frame);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript confirmation dialog to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RunJavaScriptConfirmPanel (this IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmessage = CFString.CreateNative (message);
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:"), webView__handle__, nsmessage, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (frame);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="webView">To be added.</param><param name="prompt">To be added.</param><param name="defaultText"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript text input box to the user.</summary><remarks>To be added.</remarks>
		[Obsolete ("It's not possible to call the completion handler with a null value using this method. Please see https://github.com/dotnet/macios/issues/15728 for a workaround.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RunJavaScriptTextInputPanel (this IWKUIDelegate This, WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V58))]global::System.Action<string> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (prompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prompt));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsprompt = CFString.CreateNative (prompt);
			var nsdefaultText = CFString.CreateNative (defaultText);
			using var block_completionHandler = Trampolines.SDActionArity1V58.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:"), webView__handle__, nsprompt, nsdefaultText, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (frame);
			CFString.ReleaseNative (nsprompt);
			CFString.ReleaseNative (nsdefaultText);
		}
		/// <param name="webView">To be added.</param><param name="parameters">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RunOpenPanel (this IWKUIDelegate This, WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V245))]global::System.Action<NSUrl[]> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V245.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:"), webView__handle__, parameters__handle__, frame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (parameters);
			GC.KeepAlive (frame);
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when <paramref name="webView" /> closes.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClose (this IWKUIDelegate This, WKWebView webView)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewDidClose:"), webView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><summary>Method that is called to find out if the element should provide a preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPreviewElement (this IWKUIDelegate This, WKWebView webView, WKPreviewElementInfo elementInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:shouldPreviewElement:"), webView__handle__, elementInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
			return ret != 0;
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><param name="previewActions">To be added.</param><summary>Method that is called when the user peeks at content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController? GetPreviewingViewController (this IWKUIDelegate This, WKWebView webView, WKPreviewElementInfo elementInfo, IWKPreviewActionItem[] previewActions)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			if (previewActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previewActions));
			using var nsa_previewActions = NSArray.FromNSObjects (previewActions);
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:previewingViewControllerForElement:defaultActions:"), webView__handle__, elementInfo__handle__, nsa_previewActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="previewingViewController">To be added.</param><summary>Method that is called to respond when the user pops a preview action.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CommitPreviewingViewController (this IWKUIDelegate This, WKWebView webView, global::UIKit.UIViewController previewingViewController)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var previewingViewController__handle__ = previewingViewController!.GetNonNullHandle (nameof (previewingViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:commitPreviewingViewController:"), webView__handle__, previewingViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (previewingViewController);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetContextMenuConfiguration (this IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<global::UIKit.UIContextMenuConfiguration> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V270.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuConfigurationForElement:completionHandler:"), webView__handle__, elementInfo__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillCommitContextMenu (this IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo, global::UIKit.IUIContextMenuInteractionCommitAnimating animator)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuForElement:willCommitWithAnimator:"), webView__handle__, elementInfo__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContextMenuWillPresent (this IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuWillPresentForElement:"), webView__handle__, elementInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContextMenuDidEnd (this IWKUIDelegate This, WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var elementInfo__handle__ = elementInfo!.GetNonNullHandle (nameof (elementInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuDidEndForElement:"), webView__handle__, elementInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (elementInfo);
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestDeviceOrientationAndMotionPermission (this IWKUIDelegate This, WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var origin__handle__ = origin!.GetNonNullHandle (nameof (origin));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V271.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:requestDeviceOrientationAndMotionPermissionForOrigin:initiatedByFrame:decisionHandler:"), webView__handle__, origin__handle__, frame__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (origin);
			GC.KeepAlive (frame);
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<WKPermissionDecision> RequestDeviceOrientationAndMotionPermissionAsync (this IWKUIDelegate This, WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame)
		{
			var tcs = new TaskCompletionSource<WKPermissionDecision> ();
			This.RequestDeviceOrientationAndMotionPermission(webView, origin, frame, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestMediaCapturePermission (this IWKUIDelegate This, WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, WKMediaCaptureType type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var origin__handle__ = origin!.GetNonNullHandle (nameof (origin));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V271.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("webView:requestMediaCapturePermissionForOrigin:initiatedByFrame:type:decisionHandler:"), webView__handle__, origin__handle__, frame__handle__, (IntPtr) (long) type, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (origin);
			GC.KeepAlive (frame);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<WKPermissionDecision> RequestMediaCapturePermissionAsync (this IWKUIDelegate This, WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, WKMediaCaptureType type)
		{
			var tcs = new TaskCompletionSource<WKPermissionDecision> ();
			This.RequestMediaCapturePermission(webView, origin, frame, type, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ShowLockDownMode (this IWKUIDelegate This, WKWebView webView, string firstUseMessage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V272))]global::System.Action<WKDialogResult> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (firstUseMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (firstUseMessage));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsfirstUseMessage = CFString.CreateNative (firstUseMessage);
			using var block_completionHandler = Trampolines.SDActionArity1V272.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:showLockdownModeFirstUseMessage:completionHandler:"), webView__handle__, nsfirstUseMessage, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			CFString.ReleaseNative (nsfirstUseMessage);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<WKDialogResult> ShowLockDownModeAsync (this IWKUIDelegate This, WKWebView webView, string firstUseMessage)
		{
			var tcs = new TaskCompletionSource<WKDialogResult> ();
			This.ShowLockDownMode(webView, firstUseMessage, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentEditMenu (this IWKUIDelegate This, WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPresentEditMenuWithAnimator:"), webView__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (animator);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissEditMenu (this IWKUIDelegate This, WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willDismissEditMenuWithAnimator:"), webView__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (animator);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKUIDelegateWrapper : BaseWrapper, IWKUIDelegate {
		public WKUIDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKUIDelegateWrapper))]
		static WKUIDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>A delegate object that allows presenting native UI elements on behalf of a Web page.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKUIDelegate_Ref/index.html">Apple documentation for <c>WKUIDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__WebKit_WKUIDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKUIDelegate : NSObject, IWKUIDelegate {
		/// <summary>Creates a new <see cref="WKUIDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WKUIDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected WKUIDelegate (NSObjectFlag t) : base (t)
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
		protected internal WKUIDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="webView">To be added.</param><param name="previewingViewController">To be added.</param><summary>Method that is called to respond when the user pops a preview action.</summary><remarks>To be added.</remarks>
		[Export ("webView:commitPreviewingViewController:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillCommitContextMenu' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitPreviewingViewController (WKWebView webView, global::UIKit.UIViewController previewingViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:contextMenuDidEndForElement:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextMenuDidEnd (WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:contextMenuWillPresentForElement:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextMenuWillPresent (WKWebView webView, WKContextMenuElementInfo elementInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="configuration">To be added.</param><param name="navigationAction">To be added.</param><param name="windowFeatures">To be added.</param><summary>Creates and configures a new <see cref="T:WebKit.WKWebView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebView? CreateWebView (WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when <paramref name="webView" /> closes.</summary><remarks>To be added.</remarks>
		[Export ("webViewDidClose:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (WKWebView webView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><param name="previewActions">To be added.</param><summary>Method that is called when the user peeks at content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:previewingViewControllerForElement:defaultActions:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController? GetPreviewingViewController (WKWebView webView, WKPreviewElementInfo elementInfo, IWKPreviewActionItem[] previewActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:requestDeviceOrientationAndMotionPermissionForOrigin:initiatedByFrame:decisionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestDeviceOrientationAndMotionPermission (WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:requestMediaCapturePermissionForOrigin:initiatedByFrame:type:decisionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestMediaCapturePermission (WKWebView webView, WKSecurityOrigin origin, WKFrameInfo frame, WKMediaCaptureType type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V271))]global::System.Action<WKPermissionDecision> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript alert to the user.</summary><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunJavaScriptAlertPanel (WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="message">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript confirmation dialog to the user.</summary><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunJavaScriptConfirmPanel (WKWebView webView, string message, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="prompt">To be added.</param><param name="defaultText"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>Shows a JavaScript text input box to the user.</summary><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:")]
		[Obsolete ("It's not possible to call the completion handler with a null value using this method. Please see https://github.com/dotnet/macios/issues/15728 for a workaround.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunJavaScriptTextInputPanel (WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V58))]global::System.Action<string> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="parameters">To be added.</param><param name="frame">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:")]
		[SupportedOSPlatform ("ios18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunOpenPanel (WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V245))]global::System.Action<NSUrl[]> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:contextMenuConfigurationForElement:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetContextMenuConfiguration (WKWebView webView, WKContextMenuElementInfo elementInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<global::UIKit.UIContextMenuConfiguration> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="elementInfo">To be added.</param><summary>Method that is called to find out if the element should provide a preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:shouldPreviewElement:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPreviewElement (WKWebView webView, WKPreviewElementInfo elementInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:showLockdownModeFirstUseMessage:completionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowLockDownMode (WKWebView webView, string firstUseMessage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V272))]global::System.Action<WKDialogResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:contextMenuForElement:willCommitWithAnimator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillCommitContextMenu (WKWebView webView, WKContextMenuElementInfo elementInfo, global::UIKit.IUIContextMenuInteractionCommitAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (WKWebView webView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WKUIDelegate */
}
