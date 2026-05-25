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
	/// <summary>This interface represents the Objective-C protocol <c>WebFrameLoadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WebFrameLoadDelegate", WrapperType = typeof (WebFrameLoadDelegateWrapper), FormalSince = "10.11")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartedProvisionalLoad", Selector = "webView:didStartProvisionalLoadForFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedServerRedirectForProvisionalLoad", Selector = "webView:didReceiveServerRedirectForProvisionalLoadForFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedProvisionalLoad", Selector = "webView:didFailProvisionalLoadWithError:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSError), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CommitedLoad", Selector = "webView:didCommitLoadForFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedTitle", Selector = "webView:didReceiveTitle:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedIcon", Selector = "webView:didReceiveIcon:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSImage), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedLoad", Selector = "webView:didFinishLoadForFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedLoadWithError", Selector = "webView:didFailLoadWithError:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSError), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedLocationWithinPage", Selector = "webView:didChangeLocationWithinPageForFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformClientRedirect", Selector = "webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSUrl), typeof (double), typeof (NSDate), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanceledClientRedirect", Selector = "webView:didCancelClientRedirectForFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCloseFrame", Selector = "webView:willCloseFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClearedWindowObject", Selector = "webView:didClearWindowObject:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebScriptObject), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WindowScriptObjectAvailable", Selector = "webView:windowScriptObjectAvailable:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (WebKit.WebScriptObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCreateJavaScriptContext", Selector = "webView:didCreateJavaScriptContext:forFrame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (JavaScriptCore.JSContext), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IWebFrameLoadDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didStartProvisionalLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartedProvisionalLoad (WebView sender, WebFrame forFrame)
		{
			_StartedProvisionalLoad (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartedProvisionalLoad (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didStartProvisionalLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didReceiveServerRedirectForProvisionalLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedServerRedirectForProvisionalLoad (WebView sender, WebFrame forFrame)
		{
			_ReceivedServerRedirectForProvisionalLoad (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedServerRedirectForProvisionalLoad (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveServerRedirectForProvisionalLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didFailProvisionalLoadWithError:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedProvisionalLoad (WebView sender, NSError error, WebFrame forFrame)
		{
			_FailedProvisionalLoad (this, sender, error, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedProvisionalLoad (IWebFrameLoadDelegate This, WebView sender, NSError error, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailProvisionalLoadWithError:forFrame:"), sender__handle__, error__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (error);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didCommitLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitedLoad (WebView sender, WebFrame forFrame)
		{
			_CommitedLoad (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CommitedLoad (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCommitLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didReceiveTitle:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedTitle (WebView sender, string title, WebFrame forFrame)
		{
			_ReceivedTitle (this, sender, title, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedTitle (IWebFrameLoadDelegate This, WebView sender, string title, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			var nstitle = CFString.CreateNative (title);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveTitle:forFrame:"), sender__handle__, nstitle, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
			CFString.ReleaseNative (nstitle);
		}
		/// <param name="sender">To be added.</param><param name="image">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didReceiveIcon:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedIcon (WebView sender, global::AppKit.NSImage image, WebFrame forFrame)
		{
			_ReceivedIcon (this, sender, image, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="image">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedIcon (IWebFrameLoadDelegate This, WebView sender, global::AppKit.NSImage image, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveIcon:forFrame:"), sender__handle__, image__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (image);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didFinishLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoad (WebView sender, WebFrame forFrame)
		{
			_FinishedLoad (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedLoad (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFinishLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didFailLoadWithError:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedLoadWithError (WebView sender, NSError error, WebFrame forFrame)
		{
			_FailedLoadWithError (this, sender, error, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedLoadWithError (IWebFrameLoadDelegate This, WebView sender, NSError error, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailLoadWithError:forFrame:"), sender__handle__, error__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (error);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didChangeLocationWithinPageForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedLocationWithinPage (WebView sender, WebFrame forFrame)
		{
			_ChangedLocationWithinPage (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangedLocationWithinPage (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didChangeLocationWithinPageForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="toUrl">To be added.</param><param name="secondsDelay">To be added.</param><param name="fireDate">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformClientRedirect (WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
		{
			_WillPerformClientRedirect (this, sender, toUrl, secondsDelay, fireDate, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="toUrl">To be added.</param><param name="secondsDelay">To be added.</param><param name="fireDate">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPerformClientRedirect (IWebFrameLoadDelegate This, WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var toUrl__handle__ = toUrl!.GetNonNullHandle (nameof (toUrl));
			var fireDate__handle__ = fireDate!.GetNonNullHandle (nameof (fireDate));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:"), sender__handle__, toUrl__handle__, secondsDelay, fireDate__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (toUrl);
			GC.KeepAlive (fireDate);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didCancelClientRedirectForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanceledClientRedirect (WebView sender, WebFrame forFrame)
		{
			_CanceledClientRedirect (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CanceledClientRedirect (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCancelClientRedirectForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:willCloseFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillCloseFrame (WebView sender, WebFrame forFrame)
		{
			_WillCloseFrame (this, sender, forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillCloseFrame (IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willCloseFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="webView">To be added.</param><param name="windowObject">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didClearWindowObject:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearedWindowObject (WebView webView, WebScriptObject windowObject, WebFrame forFrame)
		{
			_ClearedWindowObject (this, webView, windowObject, forFrame);
		}
		/// <param name="webView">To be added.</param><param name="windowObject">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ClearedWindowObject (IWebFrameLoadDelegate This, WebView webView, WebScriptObject windowObject, WebFrame forFrame)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var windowObject__handle__ = windowObject!.GetNonNullHandle (nameof (windowObject));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didClearWindowObject:forFrame:"), webView__handle__, windowObject__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (windowObject);
			GC.KeepAlive (forFrame);
		}
		/// <param name="webView">To be added.</param><param name="windowScriptObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:windowScriptObjectAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WindowScriptObjectAvailable (WebView webView, WebScriptObject windowScriptObject)
		{
			_WindowScriptObjectAvailable (this, webView, windowScriptObject);
		}
		/// <param name="webView">To be added.</param><param name="windowScriptObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WindowScriptObjectAvailable (IWebFrameLoadDelegate This, WebView webView, WebScriptObject windowScriptObject)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var windowScriptObject__handle__ = windowScriptObject!.GetNonNullHandle (nameof (windowScriptObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:windowScriptObjectAvailable:"), webView__handle__, windowScriptObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (windowScriptObject);
		}
		/// <param name="webView">To be added.</param><param name="context">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:didCreateJavaScriptContext:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateJavaScriptContext (WebView webView, global::JavaScriptCore.JSContext context, WebFrame frame)
		{
			_DidCreateJavaScriptContext (this, webView, context, frame);
		}
		/// <param name="webView">To be added.</param><param name="context">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCreateJavaScriptContext (IWebFrameLoadDelegate This, WebView webView, global::JavaScriptCore.JSContext context, WebFrame frame)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCreateJavaScriptContext:forFrame:"), webView__handle__, context__handle__, frame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (context);
			GC.KeepAlive (frame);
		}
		[DynamicDependencyAttribute ("CanceledClientRedirect(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("ChangedLocationWithinPage(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("ClearedWindowObject(WebKit.WebView,WebKit.WebScriptObject,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("CommitedLoad(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("DidCreateJavaScriptContext(WebKit.WebView,JavaScriptCore.JSContext,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("FailedLoadWithError(WebKit.WebView,Foundation.NSError,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("FailedProvisionalLoad(WebKit.WebView,Foundation.NSError,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("FinishedLoad(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("ReceivedIcon(WebKit.WebView,AppKit.NSImage,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("ReceivedServerRedirectForProvisionalLoad(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("ReceivedTitle(WebKit.WebView,System.String,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("StartedProvisionalLoad(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("WillCloseFrame(WebKit.WebView,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("WillPerformClientRedirect(WebKit.WebView,Foundation.NSUrl,System.Double,Foundation.NSDate,WebKit.WebFrame)")]
		[DynamicDependencyAttribute ("WindowScriptObjectAvailable(WebKit.WebView,WebKit.WebScriptObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebFrameLoadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWebFrameLoadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWebFrameLoadDelegate" /> interface to support all the methods from the WebFrameLoadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWebFrameLoadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WebFrameLoadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WebFrameLoadDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartedProvisionalLoad (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didStartProvisionalLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedServerRedirectForProvisionalLoad (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveServerRedirectForProvisionalLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedProvisionalLoad (this IWebFrameLoadDelegate This, WebView sender, NSError error, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailProvisionalLoadWithError:forFrame:"), sender__handle__, error__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (error);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CommitedLoad (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCommitLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedTitle (this IWebFrameLoadDelegate This, WebView sender, string title, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			var nstitle = CFString.CreateNative (title);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveTitle:forFrame:"), sender__handle__, nstitle, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
			CFString.ReleaseNative (nstitle);
		}
		/// <param name="sender">To be added.</param><param name="image">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedIcon (this IWebFrameLoadDelegate This, WebView sender, global::AppKit.NSImage image, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didReceiveIcon:forFrame:"), sender__handle__, image__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (image);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishedLoad (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFinishLoadForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedLoadWithError (this IWebFrameLoadDelegate This, WebView sender, NSError error, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didFailLoadWithError:forFrame:"), sender__handle__, error__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (error);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangedLocationWithinPage (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didChangeLocationWithinPageForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="toUrl">To be added.</param><param name="secondsDelay">To be added.</param><param name="fireDate">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPerformClientRedirect (this IWebFrameLoadDelegate This, WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var toUrl__handle__ = toUrl!.GetNonNullHandle (nameof (toUrl));
			var fireDate__handle__ = fireDate!.GetNonNullHandle (nameof (fireDate));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:"), sender__handle__, toUrl__handle__, secondsDelay, fireDate__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (toUrl);
			GC.KeepAlive (fireDate);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CanceledClientRedirect (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCancelClientRedirectForFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillCloseFrame (this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:willCloseFrame:"), sender__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (forFrame);
		}
		/// <param name="webView">To be added.</param><param name="windowObject">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClearedWindowObject (this IWebFrameLoadDelegate This, WebView webView, WebScriptObject windowObject, WebFrame forFrame)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var windowObject__handle__ = windowObject!.GetNonNullHandle (nameof (windowObject));
			var forFrame__handle__ = forFrame!.GetNonNullHandle (nameof (forFrame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didClearWindowObject:forFrame:"), webView__handle__, windowObject__handle__, forFrame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (windowObject);
			GC.KeepAlive (forFrame);
		}
		/// <param name="webView">To be added.</param><param name="windowScriptObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WindowScriptObjectAvailable (this IWebFrameLoadDelegate This, WebView webView, WebScriptObject windowScriptObject)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var windowScriptObject__handle__ = windowScriptObject!.GetNonNullHandle (nameof (windowScriptObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:windowScriptObjectAvailable:"), webView__handle__, windowScriptObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (windowScriptObject);
		}
		/// <param name="webView">To be added.</param><param name="context">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCreateJavaScriptContext (this IWebFrameLoadDelegate This, WebView webView, global::JavaScriptCore.JSContext context, WebFrame frame)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:didCreateJavaScriptContext:forFrame:"), webView__handle__, context__handle__, frame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (context);
			GC.KeepAlive (frame);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WebFrameLoadDelegateWrapper : BaseWrapper, IWebFrameLoadDelegate {
		public WebFrameLoadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebFrameLoadDelegateWrapper))]
		static WebFrameLoadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWebFrameLoadDelegate" /> (for the protocol <c>WebFrameLoadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWebFrameLoadDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WebFrameLoadDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebFrameLoadDelegate : NSObject, IWebFrameLoadDelegate {
		/// <summary>Creates a new <see cref="WebFrameLoadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebFrameLoadDelegate () : base (NSObjectFlag.Empty)
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
		protected WebFrameLoadDelegate (NSObjectFlag t) : base (t)
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
		protected internal WebFrameLoadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didCancelClientRedirectForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanceledClientRedirect (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didChangeLocationWithinPageForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedLocationWithinPage (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="windowObject">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didClearWindowObject:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearedWindowObject (WebView webView, WebScriptObject windowObject, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didCommitLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitedLoad (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="context">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didCreateJavaScriptContext:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateJavaScriptContext (WebView webView, global::JavaScriptCore.JSContext context, WebFrame frame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didFailLoadWithError:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedLoadWithError (WebView sender, NSError error, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didFailProvisionalLoadWithError:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedProvisionalLoad (WebView sender, NSError error, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didFinishLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoad (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="image">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didReceiveIcon:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedIcon (WebView sender, global::AppKit.NSImage image, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didReceiveServerRedirectForProvisionalLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedServerRedirectForProvisionalLoad (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="title">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didReceiveTitle:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedTitle (WebView sender, string title, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:didStartProvisionalLoadForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartedProvisionalLoad (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:willCloseFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillCloseFrame (WebView sender, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="toUrl">To be added.</param><param name="secondsDelay">To be added.</param><param name="fireDate">To be added.</param><param name="forFrame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformClientRedirect (WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="windowScriptObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:windowScriptObjectAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WindowScriptObjectAvailable (WebView webView, WebScriptObject windowScriptObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WebFrameLoadDelegate */
}
