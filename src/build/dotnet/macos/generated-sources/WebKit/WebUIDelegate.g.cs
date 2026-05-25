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
	/// <summary>This interface represents the Objective-C protocol <c>WebUIDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WebUIDelegate", WrapperType = typeof (WebUIDelegateWrapper), FormalSince = "10.11")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UICreateWebView", Selector = "webView:createWebViewWithRequest:", ReturnType = typeof (WebKit.WebView), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSUrlRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIShow", Selector = "webViewShow:", ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UICreateModalDialog", Selector = "webView:createWebViewModalDialogWithRequest:", ReturnType = typeof (WebKit.WebView), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSUrlRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunModal", Selector = "webViewRunModal:", ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIClose", Selector = "webViewClose:", ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIFocus", Selector = "webViewFocus:", ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIUnfocus", Selector = "webViewUnfocus:", ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetFirstResponder", Selector = "webViewFirstResponder:", ReturnType = typeof (NSResponder), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIMakeFirstResponder", Selector = "webView:makeFirstResponder:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSResponder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetStatusText", Selector = "webView:setStatusText:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetStatusText", Selector = "webViewStatusText:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIAreToolbarsVisible", Selector = "webViewAreToolbarsVisible:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetToolbarsVisible", Selector = "webView:setToolbarsVisible:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIIsStatusBarVisible", Selector = "webViewIsStatusBarVisible:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetStatusBarVisible", Selector = "webView:setStatusBarVisible:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIIsResizable", Selector = "webViewIsResizable:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetResizable", Selector = "webView:setResizable:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetFrame", Selector = "webView:setFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetFrame", Selector = "webViewFrame:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptAlertPanelMessage", Selector = "webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptConfirmationPanel", Selector = "webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptTextInputPanelWithFrame", Selector = "webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (string), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunBeforeUnload", Selector = "webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunOpenPanelForFileButton", Selector = "webView:runOpenPanelForFileButtonWithResultListener:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.IWebOpenPanelResultListener) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIMouseDidMoveOverElement", Selector = "webView:mouseDidMoveOverElement:modifierFlags:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSDictionary), typeof (NSEventModifierMask) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetContextMenuItems", Selector = "webView:contextMenuItemsForElement:defaultMenuItems:", ReturnType = typeof (NSMenuItem[]), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSDictionary), typeof (NSMenuItem[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIValidateUserInterfaceItem", Selector = "webView:validateUserInterfaceItem:defaultValidation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIShouldPerformAction", Selector = "webView:shouldPerformAction:fromSender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (Selector), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetDragDestinationActionMask", Selector = "webView:dragDestinationActionMaskForDraggingInfo:", ReturnType = typeof (WebKit.WebDragDestinationAction), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIWillPerformDragDestination", Selector = "webView:willPerformDragDestinationAction:forDraggingInfo:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebDragDestinationAction), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIDragSourceActionMask", Selector = "webView:dragSourceActionMaskForPoint:", ReturnType = typeof (WebKit.WebDragSourceAction), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIWillPerformDragSource", Selector = "webView:willPerformDragSourceAction:fromPoint:withPasteboard:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebDragSourceAction), typeof (CGPoint), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIPrintFrameView", Selector = "webView:printFrameView:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrameView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetHeaderHeight", Selector = "webViewHeaderHeight:", ReturnType = typeof (float), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetFooterHeight", Selector = "webViewFooterHeight:", ReturnType = typeof (float), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIDrawHeaderInRect", Selector = "webView:drawHeaderInRect:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIDrawFooterInRect", Selector = "webView:drawFooterInRect:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptAlertPanel", Selector = "webView:runJavaScriptAlertPanelWithMessage:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptConfirmPanel", Selector = "webView:runJavaScriptConfirmPanelWithMessage:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIRunJavaScriptTextInputPanel", Selector = "webView:runJavaScriptTextInputPanelWithPrompt:defaultText:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UISetContentRect", Selector = "webView:setContentRect:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UIGetContentRect", Selector = "webViewContentRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (WebKit.WebView) }, ParameterByRef = new bool [] { false })]
	public partial interface IWebUIDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:createWebViewWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebView UICreateWebView (WebView sender, NSUrlRequest request)
		{
			return _UICreateWebView (this, sender, request);
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WebView _UICreateWebView (IWebUIDelegate This, WebView sender, NSUrlRequest request)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			WebView? ret;
			ret =  Runtime.GetNSObject<WebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:createWebViewWithRequest:"), sender__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (request);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIShow (WebView sender)
		{
			_UIShow (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIShow (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewShow:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:createWebViewModalDialogWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebView UICreateModalDialog (WebView sender, NSUrlRequest request)
		{
			return _UICreateModalDialog (this, sender, request);
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WebView _UICreateModalDialog (IWebUIDelegate This, WebView sender, NSUrlRequest request)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			WebView? ret;
			ret =  Runtime.GetNSObject<WebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:createWebViewModalDialogWithRequest:"), sender__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (request);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewRunModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunModal (WebView sender)
		{
			_UIRunModal (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIRunModal (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewRunModal:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIClose (WebView sender)
		{
			_UIClose (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIClose (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewClose:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewFocus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIFocus (WebView sender)
		{
			_UIFocus (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIFocus (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFocus:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewUnfocus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIUnfocus (WebView sender)
		{
			_UIUnfocus (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIUnfocus (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewUnfocus:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewFirstResponder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSResponder UIGetFirstResponder (WebView sender)
		{
			return _UIGetFirstResponder (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSResponder _UIGetFirstResponder (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::AppKit.NSResponder? ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSResponder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFirstResponder:"), sender__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="newResponder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:makeFirstResponder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIMakeFirstResponder (WebView sender, global::AppKit.NSResponder newResponder)
		{
			_UIMakeFirstResponder (this, sender, newResponder);
		}
		/// <param name="sender">To be added.</param><param name="newResponder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIMakeFirstResponder (IWebUIDelegate This, WebView sender, global::AppKit.NSResponder newResponder)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var newResponder__handle__ = newResponder!.GetNonNullHandle (nameof (newResponder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:makeFirstResponder:"), sender__handle__, newResponder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (newResponder);
		}
		/// <param name="sender">To be added.</param><param name="text">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:setStatusText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetStatusText (WebView sender, string text)
		{
			_UISetStatusText (this, sender, text);
		}
		/// <param name="sender">To be added.</param><param name="text">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UISetStatusText (IWebUIDelegate This, WebView sender, string text)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:setStatusText:"), sender__handle__, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstext);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewStatusText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UIGetStatusText (WebView sender)
		{
			return _UIGetStatusText (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _UIGetStatusText (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewStatusText:"), sender__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewAreToolbarsVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIAreToolbarsVisible (WebView sender)
		{
			return _UIAreToolbarsVisible (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIAreToolbarsVisible (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewAreToolbarsVisible:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:setToolbarsVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetToolbarsVisible (WebView sender, bool visible)
		{
			_UISetToolbarsVisible (this, sender, visible);
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UISetToolbarsVisible (IWebUIDelegate This, WebView sender, bool visible)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:setToolbarsVisible:"), sender__handle__, visible ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewIsStatusBarVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIIsStatusBarVisible (WebView sender)
		{
			return _UIIsStatusBarVisible (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIIsStatusBarVisible (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewIsStatusBarVisible:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:setStatusBarVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetStatusBarVisible (WebView sender, bool visible)
		{
			_UISetStatusBarVisible (this, sender, visible);
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UISetStatusBarVisible (IWebUIDelegate This, WebView sender, bool visible)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:setStatusBarVisible:"), sender__handle__, visible ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewIsResizable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIIsResizable (WebView sender)
		{
			return _UIIsResizable (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIIsResizable (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewIsResizable:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="resizable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:setResizable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetResizable (WebView sender, bool resizable)
		{
			_UISetResizable (this, sender, resizable);
		}
		/// <param name="sender">To be added.</param><param name="resizable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UISetResizable (IWebUIDelegate This, WebView sender, bool resizable)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:setResizable:"), sender__handle__, resizable ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="newFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:setFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetFrame (WebView sender, CGRect newFrame)
		{
			_UISetFrame (this, sender, newFrame);
		}
		/// <param name="sender">To be added.</param><param name="newFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UISetFrame (IWebUIDelegate This, WebView sender, CGRect newFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:setFrame:"), sender__handle__, newFrame);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect UIGetFrame (WebView sender)
		{
			return _UIGetFrame (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _UIGetFrame (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFrame:"), sender__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("webViewFrame:"), sender__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunJavaScriptAlertPanelMessage (WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			_UIRunJavaScriptAlertPanelMessage (this, sender, withMessage, initiatedByFrame);
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIRunJavaScriptAlertPanelMessage (IWebUIDelegate This, WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (withMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (withMessage));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nswithMessage = CFString.CreateNative (withMessage);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:"), sender__handle__, nswithMessage, initiatedByFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nswithMessage);
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIRunJavaScriptConfirmationPanel (WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			return _UIRunJavaScriptConfirmationPanel (this, sender, withMessage, initiatedByFrame);
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIRunJavaScriptConfirmationPanel (IWebUIDelegate This, WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (withMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (withMessage));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nswithMessage = CFString.CreateNative (withMessage);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:"), sender__handle__, nswithMessage, initiatedByFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nswithMessage);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UIRunJavaScriptTextInputPanelWithFrame (WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
		{
			return _UIRunJavaScriptTextInputPanelWithFrame (this, sender, prompt, defaultText, initiatedByFrame);
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _UIRunJavaScriptTextInputPanelWithFrame (IWebUIDelegate This, WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (prompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prompt));
			if (defaultText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultText));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nsprompt = CFString.CreateNative (prompt);
			var nsdefaultText = CFString.CreateNative (defaultText);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:"), sender__handle__, nsprompt, nsdefaultText, initiatedByFrame__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nsprompt);
			CFString.ReleaseNative (nsdefaultText);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIRunBeforeUnload (WebView sender, string message, WebFrame initiatedByFrame)
		{
			return _UIRunBeforeUnload (this, sender, message, initiatedByFrame);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIRunBeforeUnload (IWebUIDelegate This, WebView sender, string message, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nsmessage = CFString.CreateNative (message);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:"), sender__handle__, nsmessage, initiatedByFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nsmessage);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="resultListener">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runOpenPanelForFileButtonWithResultListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunOpenPanelForFileButton (WebView sender, IWebOpenPanelResultListener resultListener)
		{
			_UIRunOpenPanelForFileButton (this, sender, resultListener);
		}
		/// <param name="sender">To be added.</param><param name="resultListener">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIRunOpenPanelForFileButton (IWebUIDelegate This, WebView sender, IWebOpenPanelResultListener resultListener)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var resultListener__handle__ = resultListener!.GetNonNullHandle (nameof (resultListener));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runOpenPanelForFileButtonWithResultListener:"), sender__handle__, resultListener__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (resultListener);
		}
		/// <param name="sender">To be added.</param><param name="elementInformation">To be added.</param><param name="modifierFlags">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:mouseDidMoveOverElement:modifierFlags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIMouseDidMoveOverElement (WebView sender, NSDictionary elementInformation, global::AppKit.NSEventModifierMask modifierFlags)
		{
			_UIMouseDidMoveOverElement (this, sender, elementInformation, modifierFlags);
		}
		/// <param name="sender">To be added.</param><param name="elementInformation">To be added.</param><param name="modifierFlags">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIMouseDidMoveOverElement (IWebUIDelegate This, WebView sender, NSDictionary elementInformation, global::AppKit.NSEventModifierMask modifierFlags)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var elementInformation__handle__ = elementInformation!.GetNonNullHandle (nameof (elementInformation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("webView:mouseDidMoveOverElement:modifierFlags:"), sender__handle__, elementInformation__handle__, (UIntPtr) (ulong) modifierFlags);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (elementInformation);
		}
		/// <param name="sender">To be added.</param><param name="forElement">To be added.</param><param name="defaultMenuItems">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:contextMenuItemsForElement:defaultMenuItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenuItem[] UIGetContextMenuItems (WebView sender, NSDictionary forElement, global::AppKit.NSMenuItem[] defaultMenuItems)
		{
			return _UIGetContextMenuItems (this, sender, forElement, defaultMenuItems);
		}
		/// <param name="sender">To be added.</param><param name="forElement">To be added.</param><param name="defaultMenuItems">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSMenuItem[] _UIGetContextMenuItems (IWebUIDelegate This, WebView sender, NSDictionary forElement, global::AppKit.NSMenuItem[] defaultMenuItems)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forElement__handle__ = forElement!.GetNonNullHandle (nameof (forElement));
			if (defaultMenuItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultMenuItems));
			using var nsa_defaultMenuItems = NSArray.FromNSObjects (defaultMenuItems);
			global::AppKit.NSMenuItem[]? ret;
			ret = CFArray.ArrayFromHandle<global::AppKit.NSMenuItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuItemsForElement:defaultMenuItems:"), sender__handle__, forElement__handle__, nsa_defaultMenuItems.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forElement);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="validatedUserInterfaceItem">To be added.</param><param name="defaultValidation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:validateUserInterfaceItem:defaultValidation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIValidateUserInterfaceItem (WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
		{
			return _UIValidateUserInterfaceItem (this, webView, validatedUserInterfaceItem, defaultValidation);
		}
		/// <param name="webView">To be added.</param><param name="validatedUserInterfaceItem">To be added.</param><param name="defaultValidation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIValidateUserInterfaceItem (IWebUIDelegate This, WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var validatedUserInterfaceItem__handle__ = validatedUserInterfaceItem!.GetNonNullHandle (nameof (validatedUserInterfaceItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:validateUserInterfaceItem:defaultValidation:"), webView__handle__, validatedUserInterfaceItem__handle__, defaultValidation ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (validatedUserInterfaceItem);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:shouldPerformAction:fromSender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIShouldPerformAction (WebView webView, Selector action, NSObject sender)
		{
			return _UIShouldPerformAction (this, webView, action, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIShouldPerformAction (IWebUIDelegate This, WebView webView, Selector action, NSObject sender)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:shouldPerformAction:fromSender:"), webView__handle__, action.Handle, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (action);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:dragDestinationActionMaskForDraggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebDragDestinationAction UIGetDragDestinationActionMask (WebView webView, global::AppKit.INSDraggingInfo draggingInfo)
		{
			return _UIGetDragDestinationActionMask (this, webView, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WebDragDestinationAction _UIGetDragDestinationActionMask (IWebUIDelegate This, WebView webView, global::AppKit.INSDraggingInfo draggingInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			WebDragDestinationAction ret;
			ret = (WebDragDestinationAction) global::ObjCRuntime.Messaging.UInt64_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:dragDestinationActionMaskForDraggingInfo:"), webView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (draggingInfo);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:willPerformDragDestinationAction:forDraggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIWillPerformDragDestination (WebView webView, WebDragDestinationAction action, global::AppKit.INSDraggingInfo draggingInfo)
		{
			_UIWillPerformDragDestination (this, webView, action, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIWillPerformDragDestination (IWebUIDelegate This, WebView webView, WebDragDestinationAction action, global::AppKit.INSDraggingInfo draggingInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPerformDragDestinationAction:forDraggingInfo:"), webView__handle__, (UInt64)action, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (draggingInfo);
		}
		/// <param name="webView">To be added.</param><param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:dragSourceActionMaskForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebDragSourceAction UIDragSourceActionMask (WebView webView, CGPoint point)
		{
			return _UIDragSourceActionMask (this, webView, point);
		}
		/// <param name="webView">To be added.</param><param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WebDragSourceAction _UIDragSourceActionMask (IWebUIDelegate This, WebView webView, CGPoint point)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			WebDragSourceAction ret;
			ret = (WebDragSourceAction) global::ObjCRuntime.Messaging.UInt64_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("webView:dragSourceActionMaskForPoint:"), webView__handle__, point);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="action">To be added.</param><param name="sourcePoint">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:willPerformDragSourceAction:fromPoint:withPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIWillPerformDragSource (WebView webView, WebDragSourceAction action, CGPoint sourcePoint, global::AppKit.NSPasteboard pasteboard)
		{
			_UIWillPerformDragSource (this, webView, action, sourcePoint, pasteboard);
		}
		/// <param name="webView">To be added.</param><param name="action">To be added.</param><param name="sourcePoint">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIWillPerformDragSource (IWebUIDelegate This, WebView webView, WebDragSourceAction action, CGPoint sourcePoint, global::AppKit.NSPasteboard pasteboard)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPerformDragSourceAction:fromPoint:withPasteboard:"), webView__handle__, (UInt64)action, sourcePoint, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (pasteboard);
		}
		/// <param name="sender">To be added.</param><param name="frameView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:printFrameView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIPrintFrameView (WebView sender, WebFrameView frameView)
		{
			_UIPrintFrameView (this, sender, frameView);
		}
		/// <param name="sender">To be added.</param><param name="frameView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIPrintFrameView (IWebUIDelegate This, WebView sender, WebFrameView frameView)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var frameView__handle__ = frameView!.GetNonNullHandle (nameof (frameView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:printFrameView:"), sender__handle__, frameView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (frameView);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewHeaderHeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float UIGetHeaderHeight (WebView sender)
		{
			return _UIGetHeaderHeight (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _UIGetHeaderHeight (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewHeaderHeight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewFooterHeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float UIGetFooterHeight (WebView sender)
		{
			return _UIGetFooterHeight (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _UIGetFooterHeight (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFooterHeight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:drawHeaderInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIDrawHeaderInRect (WebView sender, CGRect rect)
		{
			_UIDrawHeaderInRect (this, sender, rect);
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIDrawHeaderInRect (IWebUIDelegate This, WebView sender, CGRect rect)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:drawHeaderInRect:"), sender__handle__, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:drawFooterInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIDrawFooterInRect (WebView sender, CGRect rect)
		{
			_UIDrawFooterInRect (this, sender, rect);
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIDrawFooterInRect (IWebUIDelegate This, WebView sender, CGRect rect)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:drawFooterInRect:"), sender__handle__, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptAlertPanelWithMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunJavaScriptAlertPanel (WebView sender, string message)
		{
			_UIRunJavaScriptAlertPanel (this, sender, message);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UIRunJavaScriptAlertPanel (IWebUIDelegate This, WebView sender, string message)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptAlertPanelWithMessage:"), sender__handle__, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptConfirmPanelWithMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIRunJavaScriptConfirmPanel (WebView sender, string message)
		{
			return _UIRunJavaScriptConfirmPanel (this, sender, message);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UIRunJavaScriptConfirmPanel (IWebUIDelegate This, WebView sender, string message)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptConfirmPanelWithMessage:"), sender__handle__, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsmessage);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UIRunJavaScriptTextInputPanel (WebView sender, string prompt, string defaultText)
		{
			return _UIRunJavaScriptTextInputPanel (this, sender, prompt, defaultText);
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _UIRunJavaScriptTextInputPanel (IWebUIDelegate This, WebView sender, string prompt, string defaultText)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (prompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prompt));
			if (defaultText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultText));
			var nsprompt = CFString.CreateNative (prompt);
			var nsdefaultText = CFString.CreateNative (defaultText);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:"), sender__handle__, nsprompt, nsdefaultText), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsprompt);
			CFString.ReleaseNative (nsdefaultText);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:setContentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetContentRect (WebView sender, CGRect frame)
		{
			_UISetContentRect (this, sender, frame);
		}
		/// <param name="sender">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UISetContentRect (IWebUIDelegate This, WebView sender, CGRect frame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:setContentRect:"), sender__handle__, frame);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewContentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect UIGetContentRect (WebView sender)
		{
			return _UIGetContentRect (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _UIGetContentRect (IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewContentRect:"), sender__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("webViewContentRect:"), sender__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (sender);
			return ret!;
		}
		[DynamicDependencyAttribute ("UIAreToolbarsVisible(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIClose(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UICreateModalDialog(WebKit.WebView,Foundation.NSUrlRequest)")]
		[DynamicDependencyAttribute ("UICreateWebView(WebKit.WebView,Foundation.NSUrlRequest)")]
		[DynamicDependencyAttribute ("UIDragSourceActionMask(WebKit.WebView,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("UIDrawFooterInRect(WebKit.WebView,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("UIDrawHeaderInRect(WebKit.WebView,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("UIFocus(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIGetContentRect(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIGetContextMenuItems(WebKit.WebView,Foundation.NSDictionary,AppKit.NSMenuItem[])")]
		[DynamicDependencyAttribute ("UIGetDragDestinationActionMask(WebKit.WebView,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("UIGetFirstResponder(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIGetFooterHeight(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIGetFrame(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIGetHeaderHeight(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIGetStatusText(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIIsResizable(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIIsStatusBarVisible(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIMakeFirstResponder(WebKit.WebView,AppKit.NSResponder)")]
		[DynamicDependencyAttribute ("UIMouseDidMoveOverElement(WebKit.WebView,Foundation.NSDictionary,AppKit.NSEventModifierMask)")]
		[DynamicDependencyAttribute ("UIPrintFrameView(WebKit.WebView,WebKit.WebFrameView)")]
		[DynamicDependencyAttribute ("UIRunBeforeUnload(WebKit.WebView,System.String,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("UIRunJavaScriptAlertPanel(WebKit.WebView,System.String)")]
		[DynamicDependencyAttribute ("UIRunJavaScriptAlertPanelMessage(WebKit.WebView,System.String,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("UIRunJavaScriptConfirmationPanel(WebKit.WebView,System.String,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("UIRunJavaScriptConfirmPanel(WebKit.WebView,System.String)")]
		[DynamicDependencyAttribute ("UIRunJavaScriptTextInputPanel(WebKit.WebView,System.String,System.String)")]
		[DynamicDependencyAttribute ("UIRunJavaScriptTextInputPanelWithFrame(WebKit.WebView,System.String,System.String,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("UIRunModal(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIRunOpenPanelForFileButton(WebKit.WebView,WebKit.IWebOpenPanelResultListener)")]
		[DynamicDependencyAttribute ("UISetContentRect(WebKit.WebView,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("UISetFrame(WebKit.WebView,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("UISetResizable(WebKit.WebView,System.Boolean)")]
		[DynamicDependencyAttribute ("UISetStatusBarVisible(WebKit.WebView,System.Boolean)")]
		[DynamicDependencyAttribute ("UISetStatusText(WebKit.WebView,System.String)")]
		[DynamicDependencyAttribute ("UISetToolbarsVisible(WebKit.WebView,System.Boolean)")]
		[DynamicDependencyAttribute ("UIShouldPerformAction(WebKit.WebView,ObjCRuntime.Selector,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("UIShow(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIUnfocus(WebKit.WebView)")]
		[DynamicDependencyAttribute ("UIValidateUserInterfaceItem(WebKit.WebView,Foundation.NSObject,System.Boolean)")]
		[DynamicDependencyAttribute ("UIWillPerformDragDestination(WebKit.WebView,WebKit.WebDragDestinationAction,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("UIWillPerformDragSource(WebKit.WebView,WebKit.WebDragSourceAction,CoreGraphics.CGPoint,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebUIDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWebUIDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWebUIDelegate" /> interface to support all the methods from the WebUIDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWebUIDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WebUIDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WebUIDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WebView UICreateWebView (this IWebUIDelegate This, WebView sender, NSUrlRequest request)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			WebView? ret;
			ret =  Runtime.GetNSObject<WebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:createWebViewWithRequest:"), sender__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (request);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIShow (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewShow:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WebView UICreateModalDialog (this IWebUIDelegate This, WebView sender, NSUrlRequest request)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			WebView? ret;
			ret =  Runtime.GetNSObject<WebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:createWebViewModalDialogWithRequest:"), sender__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (request);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIRunModal (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewRunModal:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIClose (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewClose:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIFocus (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFocus:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIUnfocus (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewUnfocus:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSResponder UIGetFirstResponder (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::AppKit.NSResponder? ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSResponder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFirstResponder:"), sender__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="newResponder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIMakeFirstResponder (this IWebUIDelegate This, WebView sender, global::AppKit.NSResponder newResponder)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var newResponder__handle__ = newResponder!.GetNonNullHandle (nameof (newResponder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:makeFirstResponder:"), sender__handle__, newResponder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (newResponder);
		}
		/// <param name="sender">To be added.</param><param name="text">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UISetStatusText (this IWebUIDelegate This, WebView sender, string text)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:setStatusText:"), sender__handle__, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstext);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UIGetStatusText (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewStatusText:"), sender__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIAreToolbarsVisible (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewAreToolbarsVisible:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UISetToolbarsVisible (this IWebUIDelegate This, WebView sender, bool visible)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:setToolbarsVisible:"), sender__handle__, visible ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIIsStatusBarVisible (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewIsStatusBarVisible:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UISetStatusBarVisible (this IWebUIDelegate This, WebView sender, bool visible)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:setStatusBarVisible:"), sender__handle__, visible ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIIsResizable (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewIsResizable:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="resizable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UISetResizable (this IWebUIDelegate This, WebView sender, bool resizable)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:setResizable:"), sender__handle__, resizable ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="newFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UISetFrame (this IWebUIDelegate This, WebView sender, CGRect newFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:setFrame:"), sender__handle__, newFrame);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect UIGetFrame (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFrame:"), sender__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("webViewFrame:"), sender__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIRunJavaScriptAlertPanelMessage (this IWebUIDelegate This, WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (withMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (withMessage));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nswithMessage = CFString.CreateNative (withMessage);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:"), sender__handle__, nswithMessage, initiatedByFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nswithMessage);
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIRunJavaScriptConfirmationPanel (this IWebUIDelegate This, WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (withMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (withMessage));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nswithMessage = CFString.CreateNative (withMessage);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:"), sender__handle__, nswithMessage, initiatedByFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nswithMessage);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UIRunJavaScriptTextInputPanelWithFrame (this IWebUIDelegate This, WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (prompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prompt));
			if (defaultText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultText));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nsprompt = CFString.CreateNative (prompt);
			var nsdefaultText = CFString.CreateNative (defaultText);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:"), sender__handle__, nsprompt, nsdefaultText, initiatedByFrame__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nsprompt);
			CFString.ReleaseNative (nsdefaultText);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIRunBeforeUnload (this IWebUIDelegate This, WebView sender, string message, WebFrame initiatedByFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var initiatedByFrame__handle__ = initiatedByFrame!.GetNonNullHandle (nameof (initiatedByFrame));
			var nsmessage = CFString.CreateNative (message);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:"), sender__handle__, nsmessage, initiatedByFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (initiatedByFrame);
			CFString.ReleaseNative (nsmessage);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="resultListener">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIRunOpenPanelForFileButton (this IWebUIDelegate This, WebView sender, IWebOpenPanelResultListener resultListener)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var resultListener__handle__ = resultListener!.GetNonNullHandle (nameof (resultListener));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runOpenPanelForFileButtonWithResultListener:"), sender__handle__, resultListener__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (resultListener);
		}
		/// <param name="sender">To be added.</param><param name="elementInformation">To be added.</param><param name="modifierFlags">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIMouseDidMoveOverElement (this IWebUIDelegate This, WebView sender, NSDictionary elementInformation, global::AppKit.NSEventModifierMask modifierFlags)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var elementInformation__handle__ = elementInformation!.GetNonNullHandle (nameof (elementInformation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("webView:mouseDidMoveOverElement:modifierFlags:"), sender__handle__, elementInformation__handle__, (UIntPtr) (ulong) modifierFlags);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (elementInformation);
		}
		/// <param name="sender">To be added.</param><param name="forElement">To be added.</param><param name="defaultMenuItems">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSMenuItem[] UIGetContextMenuItems (this IWebUIDelegate This, WebView sender, NSDictionary forElement, global::AppKit.NSMenuItem[] defaultMenuItems)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forElement__handle__ = forElement!.GetNonNullHandle (nameof (forElement));
			if (defaultMenuItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultMenuItems));
			using var nsa_defaultMenuItems = NSArray.FromNSObjects (defaultMenuItems);
			global::AppKit.NSMenuItem[]? ret;
			ret = CFArray.ArrayFromHandle<global::AppKit.NSMenuItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:contextMenuItemsForElement:defaultMenuItems:"), sender__handle__, forElement__handle__, nsa_defaultMenuItems.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forElement);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="validatedUserInterfaceItem">To be added.</param><param name="defaultValidation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIValidateUserInterfaceItem (this IWebUIDelegate This, WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var validatedUserInterfaceItem__handle__ = validatedUserInterfaceItem!.GetNonNullHandle (nameof (validatedUserInterfaceItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("webView:validateUserInterfaceItem:defaultValidation:"), webView__handle__, validatedUserInterfaceItem__handle__, defaultValidation ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (validatedUserInterfaceItem);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIShouldPerformAction (this IWebUIDelegate This, WebView webView, Selector action, NSObject sender)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:shouldPerformAction:fromSender:"), webView__handle__, action.Handle, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (action);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WebDragDestinationAction UIGetDragDestinationActionMask (this IWebUIDelegate This, WebView webView, global::AppKit.INSDraggingInfo draggingInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			WebDragDestinationAction ret;
			ret = (WebDragDestinationAction) global::ObjCRuntime.Messaging.UInt64_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:dragDestinationActionMaskForDraggingInfo:"), webView__handle__, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (draggingInfo);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIWillPerformDragDestination (this IWebUIDelegate This, WebView webView, WebDragDestinationAction action, global::AppKit.INSDraggingInfo draggingInfo)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPerformDragDestinationAction:forDraggingInfo:"), webView__handle__, (UInt64)action, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (draggingInfo);
		}
		/// <param name="webView">To be added.</param><param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WebDragSourceAction UIDragSourceActionMask (this IWebUIDelegate This, WebView webView, CGPoint point)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			WebDragSourceAction ret;
			ret = (WebDragSourceAction) global::ObjCRuntime.Messaging.UInt64_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("webView:dragSourceActionMaskForPoint:"), webView__handle__, point);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			return ret!;
		}
		/// <param name="webView">To be added.</param><param name="action">To be added.</param><param name="sourcePoint">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIWillPerformDragSource (this IWebUIDelegate This, WebView webView, WebDragSourceAction action, CGPoint sourcePoint, global::AppKit.NSPasteboard pasteboard)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPerformDragSourceAction:fromPoint:withPasteboard:"), webView__handle__, (UInt64)action, sourcePoint, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (pasteboard);
		}
		/// <param name="sender">To be added.</param><param name="frameView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIPrintFrameView (this IWebUIDelegate This, WebView sender, WebFrameView frameView)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var frameView__handle__ = frameView!.GetNonNullHandle (nameof (frameView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:printFrameView:"), sender__handle__, frameView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (frameView);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float UIGetHeaderHeight (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewHeaderHeight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float UIGetFooterHeight (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewFooterHeight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIDrawHeaderInRect (this IWebUIDelegate This, WebView sender, CGRect rect)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:drawHeaderInRect:"), sender__handle__, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIDrawFooterInRect (this IWebUIDelegate This, WebView sender, CGRect rect)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:drawFooterInRect:"), sender__handle__, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UIRunJavaScriptAlertPanel (this IWebUIDelegate This, WebView sender, string message)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptAlertPanelWithMessage:"), sender__handle__, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UIRunJavaScriptConfirmPanel (this IWebUIDelegate This, WebView sender, string message)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptConfirmPanelWithMessage:"), sender__handle__, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsmessage);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UIRunJavaScriptTextInputPanel (this IWebUIDelegate This, WebView sender, string prompt, string defaultText)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (prompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prompt));
			if (defaultText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultText));
			var nsprompt = CFString.CreateNative (prompt);
			var nsdefaultText = CFString.CreateNative (defaultText);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:"), sender__handle__, nsprompt, nsdefaultText), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsprompt);
			CFString.ReleaseNative (nsdefaultText);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UISetContentRect (this IWebUIDelegate This, WebView sender, CGRect frame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("webView:setContentRect:"), sender__handle__, frame);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect UIGetContentRect (this IWebUIDelegate This, WebView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewContentRect:"), sender__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("webViewContentRect:"), sender__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (sender);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WebUIDelegateWrapper : BaseWrapper, IWebUIDelegate {
		public WebUIDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebUIDelegateWrapper))]
		static WebUIDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWebUIDelegate" /> (for the protocol <c>WebUIDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWebUIDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WebUIDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebUIDelegate : NSObject, IWebUIDelegate {
		/// <summary>Creates a new <see cref="WebUIDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebUIDelegate () : base (NSObjectFlag.Empty)
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
		protected WebUIDelegate (NSObjectFlag t) : base (t)
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
		protected internal WebUIDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewAreToolbarsVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIAreToolbarsVisible (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webViewClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIClose (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:createWebViewModalDialogWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebView UICreateModalDialog (WebView sender, NSUrlRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:createWebViewWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebView UICreateWebView (WebView sender, NSUrlRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:dragSourceActionMaskForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebDragSourceAction UIDragSourceActionMask (WebView webView, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:drawFooterInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIDrawFooterInRect (WebView sender, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:drawHeaderInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIDrawHeaderInRect (WebView sender, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webViewFocus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIFocus (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewContentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect UIGetContentRect (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forElement">To be added.</param><param name="defaultMenuItems">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:contextMenuItemsForElement:defaultMenuItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenuItem[] UIGetContextMenuItems (WebView sender, NSDictionary forElement, global::AppKit.NSMenuItem[] defaultMenuItems)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:dragDestinationActionMaskForDraggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebDragDestinationAction UIGetDragDestinationActionMask (WebView webView, global::AppKit.INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewFirstResponder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSResponder UIGetFirstResponder (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewFooterHeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float UIGetFooterHeight (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect UIGetFrame (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewHeaderHeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float UIGetHeaderHeight (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewStatusText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UIGetStatusText (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewIsResizable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIIsResizable (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webViewIsStatusBarVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIIsStatusBarVisible (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="newResponder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:makeFirstResponder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIMakeFirstResponder (WebView sender, global::AppKit.NSResponder newResponder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="elementInformation">To be added.</param><param name="modifierFlags">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:mouseDidMoveOverElement:modifierFlags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIMouseDidMoveOverElement (WebView sender, NSDictionary elementInformation, global::AppKit.NSEventModifierMask modifierFlags)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="frameView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:printFrameView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIPrintFrameView (WebView sender, WebFrameView frameView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIRunBeforeUnload (WebView sender, string message, WebFrame initiatedByFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptAlertPanelWithMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunJavaScriptAlertPanel (WebView sender, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunJavaScriptAlertPanelMessage (WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptConfirmPanelWithMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIRunJavaScriptConfirmPanel (WebView sender, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="withMessage">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIRunJavaScriptConfirmationPanel (WebView sender, string withMessage, WebFrame initiatedByFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UIRunJavaScriptTextInputPanel (WebView sender, string prompt, string defaultText)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="prompt">To be added.</param><param name="defaultText">To be added.</param><param name="initiatedByFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UIRunJavaScriptTextInputPanelWithFrame (WebView sender, string prompt, string defaultText, WebFrame initiatedByFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webViewRunModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunModal (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="resultListener">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:runOpenPanelForFileButtonWithResultListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIRunOpenPanelForFileButton (WebView sender, IWebOpenPanelResultListener resultListener)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:setContentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetContentRect (WebView sender, CGRect frame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="newFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:setFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetFrame (WebView sender, CGRect newFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="resizable">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:setResizable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetResizable (WebView sender, bool resizable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:setStatusBarVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetStatusBarVisible (WebView sender, bool visible)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="text">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:setStatusText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetStatusText (WebView sender, string text)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="visible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:setToolbarsVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UISetToolbarsVisible (WebView sender, bool visible)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:shouldPerformAction:fromSender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIShouldPerformAction (WebView webView, Selector action, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webViewShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIShow (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webViewUnfocus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIUnfocus (WebView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="validatedUserInterfaceItem">To be added.</param><param name="defaultValidation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:validateUserInterfaceItem:defaultValidation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UIValidateUserInterfaceItem (WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:willPerformDragDestinationAction:forDraggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIWillPerformDragDestination (WebView webView, WebDragDestinationAction action, global::AppKit.INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="action">To be added.</param><param name="sourcePoint">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:willPerformDragSourceAction:fromPoint:withPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UIWillPerformDragSource (WebView webView, WebDragSourceAction action, CGPoint sourcePoint, global::AppKit.NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WebUIDelegate */
}
