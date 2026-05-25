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
	/// <summary>Delegate object for <see cref="T:WebKit.WKNavigation" /> objects, provides methods relating to navigation and load policies.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKNavigationDelegate_Ref/index.html">Apple documentation for <c>WKNavigationDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKNavigationDelegate", WrapperType = typeof (WKNavigationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicy", Selector = "webView:decidePolicyForNavigationAction:decisionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigationAction), typeof (global::System.Action<global::WebKit.WKNavigationActionPolicy>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V268) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicy", Selector = "webView:decidePolicyForNavigationResponse:decisionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigationResponse), typeof (global::System.Action<global::WebKit.WKNavigationResponsePolicy>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V269) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicy", Selector = "webView:decidePolicyForNavigationAction:preferences:decisionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigationAction), typeof (WebKit.WKWebpagePreferences), typeof (global::System.Action<global::WebKit.WKNavigationActionPolicy, global::WebKit.WKWebpagePreferences>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V173) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartProvisionalNavigation", Selector = "webView:didStartProvisionalNavigation:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveServerRedirectForProvisionalNavigation", Selector = "webView:didReceiveServerRedirectForProvisionalNavigation:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailProvisionalNavigation", Selector = "webView:didFailProvisionalNavigation:withError:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigation), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCommitNavigation", Selector = "webView:didCommitNavigation:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishNavigation", Selector = "webView:didFinishNavigation:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailNavigation", Selector = "webView:didFailNavigation:withError:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigation), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveAuthenticationChallenge", Selector = "webView:didReceiveAuthenticationChallenge:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (NSUrlAuthenticationChallenge), typeof (global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V7) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentProcessDidTerminate", Selector = "webViewWebContentProcessDidTerminate:", ParameterType = new Type [] { typeof (WebKit.WKWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAllowDeprecatedTls", Selector = "webView:authenticationChallenge:shouldAllowDeprecatedTLS:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (NSUrlAuthenticationChallenge), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NavigationActionDidBecomeDownload", Selector = "webView:navigationAction:didBecomeDownload:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigationAction), typeof (WebKit.WKDownload) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NavigationResponseDidBecomeDownload", Selector = "webView:navigationResponse:didBecomeDownload:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKNavigationResponse), typeof (WebKit.WKDownload) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGoToBackForwardListItem", Selector = "webView:shouldGoToBackForwardListItem:willUseInstantBack:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.WKBackForwardListItem), typeof (bool), typeof (WebKit.WKNavigationDelegateShouldGoToBackForwardListItemCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDWKNavigationDelegateShouldGoToBackForwardListItemCallback) })]
	public partial interface IWKNavigationDelegate : INativeObject, IDisposable
	{
		/// <param name="webView">To be added.</param><param name="navigationAction">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationAction" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:decidePolicyForNavigationAction:decisionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePolicy (WKWebView webView, WKNavigationAction navigationAction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V268))]global::System.Action<WKNavigationActionPolicy> decisionHandler)
		{
			_DecidePolicy (this, webView, navigationAction, decisionHandler);
		}
		/// <param name="webView">To be added.</param><param name="navigationAction">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationAction" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecidePolicy (IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V268))]global::System.Action<WKNavigationActionPolicy> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V268.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationAction:decisionHandler:"), webView__handle__, navigationAction__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationAction);
		}
		/// <param name="webView">To be added.</param><param name="navigationResponse">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationResponse" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:decidePolicyForNavigationResponse:decisionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePolicy (WKWebView webView, WKNavigationResponse navigationResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<WKNavigationResponsePolicy> decisionHandler)
		{
			_DecidePolicy (this, webView, navigationResponse, decisionHandler);
		}
		/// <param name="webView">To be added.</param><param name="navigationResponse">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationResponse" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecidePolicy (IWKNavigationDelegate This, WKWebView webView, WKNavigationResponse navigationResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<WKNavigationResponsePolicy> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationResponse__handle__ = navigationResponse!.GetNonNullHandle (nameof (navigationResponse));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V269.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationResponse:decisionHandler:"), webView__handle__, navigationResponse__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationResponse);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:decidePolicyForNavigationAction:preferences:decisionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePolicy (WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V173))]global::System.Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
		{
			_DecidePolicy (this, webView, navigationAction, preferences, decisionHandler);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecidePolicy (IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V173))]global::System.Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var preferences__handle__ = preferences!.GetNonNullHandle (nameof (preferences));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity2V173.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationAction:preferences:decisionHandler:"), webView__handle__, navigationAction__handle__, preferences__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationAction);
			GC.KeepAlive (preferences);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when data begins to load.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didStartProvisionalNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartProvisionalNavigation (WKWebView webView, WKNavigation navigation)
		{
			_DidStartProvisionalNavigation (this, webView, navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when data begins to load.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartProvisionalNavigation (IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didStartProvisionalNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when a server redirect is received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didReceiveServerRedirectForProvisionalNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveServerRedirectForProvisionalNavigation (WKWebView webView, WKNavigation navigation)
		{
			_DidReceiveServerRedirectForProvisionalNavigation (this, webView, navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when a server redirect is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveServerRedirectForProvisionalNavigation (IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveServerRedirectForProvisionalNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails after data has begun to load.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didFailProvisionalNavigation:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailProvisionalNavigation (WKWebView webView, WKNavigation navigation, NSError error)
		{
			_DidFailProvisionalNavigation (this, webView, navigation, error);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails after data has begun to load.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailProvisionalNavigation (IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation, NSError error)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailProvisionalNavigation:withError:"), webView__handle__, navigation__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
			GC.KeepAlive (error);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when content begins to load.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didCommitNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCommitNavigation (WKWebView webView, WKNavigation navigation)
		{
			_DidCommitNavigation (this, webView, navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when content begins to load.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCommitNavigation (IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCommitNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when all the data is loaded.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didFinishNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishNavigation (WKWebView webView, WKNavigation navigation)
		{
			_DidFinishNavigation (this, webView, navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when all the data is loaded.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishNavigation (IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFinishNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didFailNavigation:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailNavigation (WKWebView webView, WKNavigation navigation, NSError error)
		{
			_DidFailNavigation (this, webView, navigation, error);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailNavigation (IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation, NSError error)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailNavigation:withError:"), webView__handle__, navigation__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
			GC.KeepAlive (error);
		}
		/// <param name="webView">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called when an authentication challenge is issued.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didReceiveAuthenticationChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveAuthenticationChallenge (WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			_DidReceiveAuthenticationChallenge (this, webView, challenge, completionHandler);
		}
		/// <param name="webView">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called when an authentication challenge is issued.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveAuthenticationChallenge (IWKNavigationDelegate This, WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V7.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveAuthenticationChallenge:completionHandler:"), webView__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (challenge);
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when a web view's content is terminated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webViewWebContentProcessDidTerminate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentProcessDidTerminate (WKWebView webView)
		{
			_ContentProcessDidTerminate (this, webView);
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when a web view's content is terminated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContentProcessDidTerminate (IWKNavigationDelegate This, WKWebView webView)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewWebContentProcessDidTerminate:"), webView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:authenticationChallenge:shouldAllowDeprecatedTLS:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShouldAllowDeprecatedTls (WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> decisionHandler)
		{
			_ShouldAllowDeprecatedTls (this, webView, challenge, decisionHandler);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ShouldAllowDeprecatedTls (IWKNavigationDelegate This, WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V2.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:authenticationChallenge:shouldAllowDeprecatedTLS:"), webView__handle__, challenge__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:navigationAction:didBecomeDownload:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NavigationActionDidBecomeDownload (WKWebView webView, WKNavigationAction navigationAction, WKDownload download)
		{
			_NavigationActionDidBecomeDownload (this, webView, navigationAction, download);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NavigationActionDidBecomeDownload (IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, WKDownload download)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:navigationAction:didBecomeDownload:"), webView__handle__, navigationAction__handle__, download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationAction);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:navigationResponse:didBecomeDownload:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NavigationResponseDidBecomeDownload (WKWebView webView, WKNavigationResponse navigationResponse, WKDownload download)
		{
			_NavigationResponseDidBecomeDownload (this, webView, navigationResponse, download);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NavigationResponseDidBecomeDownload (IWKNavigationDelegate This, WKWebView webView, WKNavigationResponse navigationResponse, WKDownload download)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationResponse__handle__ = navigationResponse!.GetNonNullHandle (nameof (navigationResponse));
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:navigationResponse:didBecomeDownload:"), webView__handle__, navigationResponse__handle__, download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationResponse);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("webView:shouldGoToBackForwardListItem:willUseInstantBack:completionHandler:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShouldGoToBackForwardListItem (WKWebView webView, WKBackForwardListItem backForwardListItem, bool willUseInstantBack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKNavigationDelegateShouldGoToBackForwardListItemCallback))]WKNavigationDelegateShouldGoToBackForwardListItemCallback completionHandler)
		{
			_ShouldGoToBackForwardListItem (this, webView, backForwardListItem, willUseInstantBack, completionHandler);
		}
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ShouldGoToBackForwardListItem (IWKNavigationDelegate This, WKWebView webView, WKBackForwardListItem backForwardListItem, bool willUseInstantBack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKNavigationDelegateShouldGoToBackForwardListItemCallback))]WKNavigationDelegateShouldGoToBackForwardListItemCallback completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var backForwardListItem__handle__ = backForwardListItem!.GetNonNullHandle (nameof (backForwardListItem));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKNavigationDelegateShouldGoToBackForwardListItemCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("webView:shouldGoToBackForwardListItem:willUseInstantBack:completionHandler:"), webView__handle__, backForwardListItem__handle__, willUseInstantBack ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (backForwardListItem);
		}
		[DynamicDependencyAttribute ("ContentProcessDidTerminate(WebKit.WKWebView)")]
		[DynamicDependencyAttribute ("DecidePolicy(WebKit.WKWebView,WebKit.WKNavigationAction,System.Action{WebKit.WKNavigationActionPolicy})")]
		[DynamicDependencyAttribute ("DecidePolicy(WebKit.WKWebView,WebKit.WKNavigationAction,WebKit.WKWebpagePreferences,System.Action{WebKit.WKNavigationActionPolicy,WebKit.WKWebpagePreferences})")]
		[DynamicDependencyAttribute ("DecidePolicy(WebKit.WKWebView,WebKit.WKNavigationResponse,System.Action{WebKit.WKNavigationResponsePolicy})")]
		[DynamicDependencyAttribute ("DidCommitNavigation(WebKit.WKWebView,WebKit.WKNavigation)")]
		[DynamicDependencyAttribute ("DidFailNavigation(WebKit.WKWebView,WebKit.WKNavigation,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFailProvisionalNavigation(WebKit.WKWebView,WebKit.WKNavigation,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishNavigation(WebKit.WKWebView,WebKit.WKNavigation)")]
		[DynamicDependencyAttribute ("DidReceiveAuthenticationChallenge(WebKit.WKWebView,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})")]
		[DynamicDependencyAttribute ("DidReceiveServerRedirectForProvisionalNavigation(WebKit.WKWebView,WebKit.WKNavigation)")]
		[DynamicDependencyAttribute ("DidStartProvisionalNavigation(WebKit.WKWebView,WebKit.WKNavigation)")]
		[DynamicDependencyAttribute ("NavigationActionDidBecomeDownload(WebKit.WKWebView,WebKit.WKNavigationAction,WebKit.WKDownload)")]
		[DynamicDependencyAttribute ("NavigationResponseDidBecomeDownload(WebKit.WKWebView,WebKit.WKNavigationResponse,WebKit.WKDownload)")]
		[DynamicDependencyAttribute ("ShouldAllowDeprecatedTls(WebKit.WKWebView,Foundation.NSUrlAuthenticationChallenge,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("ShouldGoToBackForwardListItem(WebKit.WKWebView,WebKit.WKBackForwardListItem,System.Boolean,WebKit.WKNavigationDelegateShouldGoToBackForwardListItemCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKNavigationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKNavigationDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWKNavigationDelegate" /> interface to support all the methods from the WKNavigationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWKNavigationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WKNavigationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WKNavigationDelegate_Extensions {
		/// <param name="webView">To be added.</param><param name="navigationAction">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationAction" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DecidePolicy (this IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V268))]global::System.Action<WKNavigationActionPolicy> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V268.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationAction:decisionHandler:"), webView__handle__, navigationAction__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationAction);
		}
		/// <param name="webView">To be added.</param><param name="navigationResponse">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationResponse" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DecidePolicy (this IWKNavigationDelegate This, WKWebView webView, WKNavigationResponse navigationResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<WKNavigationResponsePolicy> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationResponse__handle__ = navigationResponse!.GetNonNullHandle (nameof (navigationResponse));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V269.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationResponse:decisionHandler:"), webView__handle__, navigationResponse__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationResponse);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DecidePolicy (this IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V173))]global::System.Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var preferences__handle__ = preferences!.GetNonNullHandle (nameof (preferences));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity2V173.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationAction:preferences:decisionHandler:"), webView__handle__, navigationAction__handle__, preferences__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationAction);
			GC.KeepAlive (preferences);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when data begins to load.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartProvisionalNavigation (this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didStartProvisionalNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when a server redirect is received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveServerRedirectForProvisionalNavigation (this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveServerRedirectForProvisionalNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails after data has begun to load.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailProvisionalNavigation (this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation, NSError error)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailProvisionalNavigation:withError:"), webView__handle__, navigation__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
			GC.KeepAlive (error);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when content begins to load.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCommitNavigation (this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCommitNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when all the data is loaded.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishNavigation (this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFinishNavigation:"), webView__handle__, navigation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailNavigation (this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation, NSError error)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigation__handle__ = navigation!.GetNonNullHandle (nameof (navigation));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailNavigation:withError:"), webView__handle__, navigation__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigation);
			GC.KeepAlive (error);
		}
		/// <param name="webView">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called when an authentication challenge is issued.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveAuthenticationChallenge (this IWKNavigationDelegate This, WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V7.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveAuthenticationChallenge:completionHandler:"), webView__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (challenge);
		}
		/// <param name="webView">To be added.</param><summary>Method that is called when a web view's content is terminated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContentProcessDidTerminate (this IWKNavigationDelegate This, WKWebView webView)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewWebContentProcessDidTerminate:"), webView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ShouldAllowDeprecatedTls (this IWKNavigationDelegate This, WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> decisionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V2.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:authenticationChallenge:shouldAllowDeprecatedTLS:"), webView__handle__, challenge__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (challenge);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NavigationActionDidBecomeDownload (this IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, WKDownload download)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:navigationAction:didBecomeDownload:"), webView__handle__, navigationAction__handle__, download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationAction);
			GC.KeepAlive (download);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NavigationResponseDidBecomeDownload (this IWKNavigationDelegate This, WKWebView webView, WKNavigationResponse navigationResponse, WKDownload download)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var navigationResponse__handle__ = navigationResponse!.GetNonNullHandle (nameof (navigationResponse));
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:navigationResponse:didBecomeDownload:"), webView__handle__, navigationResponse__handle__, download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (navigationResponse);
			GC.KeepAlive (download);
		}
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ShouldGoToBackForwardListItem (this IWKNavigationDelegate This, WKWebView webView, WKBackForwardListItem backForwardListItem, bool willUseInstantBack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKNavigationDelegateShouldGoToBackForwardListItemCallback))]WKNavigationDelegateShouldGoToBackForwardListItemCallback completionHandler)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var backForwardListItem__handle__ = backForwardListItem!.GetNonNullHandle (nameof (backForwardListItem));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKNavigationDelegateShouldGoToBackForwardListItemCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("webView:shouldGoToBackForwardListItem:willUseInstantBack:completionHandler:"), webView__handle__, backForwardListItem__handle__, willUseInstantBack ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (backForwardListItem);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKNavigationDelegateWrapper : BaseWrapper, IWKNavigationDelegate {
		public WKNavigationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKNavigationDelegateWrapper))]
		static WKNavigationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>Delegate object for <see cref="T:WebKit.WKNavigation" /> objects, provides methods relating to navigation and load policies.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKNavigationDelegate_Ref/index.html">Apple documentation for <c>WKNavigationDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__WebKit_WKNavigationDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKNavigationDelegate : NSObject, IWKNavigationDelegate {
		/// <summary>Creates a new <see cref="WKNavigationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WKNavigationDelegate () : base (NSObjectFlag.Empty)
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
		protected WKNavigationDelegate (NSObjectFlag t) : base (t)
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
		protected internal WKNavigationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="webView">To be added.</param><summary>Method that is called when a web view's content is terminated.</summary><remarks>To be added.</remarks>
		[Export ("webViewWebContentProcessDidTerminate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentProcessDidTerminate (WKWebView webView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigationAction">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationAction" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[Export ("webView:decidePolicyForNavigationAction:decisionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePolicy (WKWebView webView, WKNavigationAction navigationAction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V268))]global::System.Action<WKNavigationActionPolicy> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigationResponse">To be added.</param><param name="decisionHandler">To be added.</param><summary>Assigns an action to be taken after the specified <paramref name="navigationResponse" /> has been either canceled or allowed.</summary><remarks>To be added.</remarks>
		[Export ("webView:decidePolicyForNavigationResponse:decisionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePolicy (WKWebView webView, WKNavigationResponse navigationResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<WKNavigationResponsePolicy> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:decidePolicyForNavigationAction:preferences:decisionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePolicy (WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V173))]global::System.Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when content begins to load.</summary><remarks>To be added.</remarks>
		[Export ("webView:didCommitNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCommitNavigation (WKWebView webView, WKNavigation navigation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails.</summary><remarks>To be added.</remarks>
		[Export ("webView:didFailNavigation:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailNavigation (WKWebView webView, WKNavigation navigation, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><param name="error">To be added.</param><summary>Method that is called when a committed navigation fails after data has begun to load.</summary><remarks>To be added.</remarks>
		[Export ("webView:didFailProvisionalNavigation:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailProvisionalNavigation (WKWebView webView, WKNavigation navigation, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when all the data is loaded.</summary><remarks>To be added.</remarks>
		[Export ("webView:didFinishNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishNavigation (WKWebView webView, WKNavigation navigation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called when an authentication challenge is issued.</summary><remarks>To be added.</remarks>
		[Export ("webView:didReceiveAuthenticationChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveAuthenticationChallenge (WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when a server redirect is received.</summary><remarks>To be added.</remarks>
		[Export ("webView:didReceiveServerRedirectForProvisionalNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveServerRedirectForProvisionalNavigation (WKWebView webView, WKNavigation navigation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="navigation">To be added.</param><summary>Method that is called when data begins to load.</summary><remarks>To be added.</remarks>
		[Export ("webView:didStartProvisionalNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartProvisionalNavigation (WKWebView webView, WKNavigation navigation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:navigationAction:didBecomeDownload:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NavigationActionDidBecomeDownload (WKWebView webView, WKNavigationAction navigationAction, WKDownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:navigationResponse:didBecomeDownload:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NavigationResponseDidBecomeDownload (WKWebView webView, WKNavigationResponse navigationResponse, WKDownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:authenticationChallenge:shouldAllowDeprecatedTLS:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShouldAllowDeprecatedTls (WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("webView:shouldGoToBackForwardListItem:willUseInstantBack:completionHandler:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShouldGoToBackForwardListItem (WKWebView webView, WKBackForwardListItem backForwardListItem, bool willUseInstantBack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKNavigationDelegateShouldGoToBackForwardListItemCallback))]WKNavigationDelegateShouldGoToBackForwardListItemCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WKNavigationDelegate */
}
