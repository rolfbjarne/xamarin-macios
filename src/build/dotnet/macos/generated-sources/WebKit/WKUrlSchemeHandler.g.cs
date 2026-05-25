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
	/// <summary>Interface for handling arbitrary URL schemes.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKURLSchemeHandler", WrapperType = typeof (WKUrlSchemeHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartUrlSchemeTask", Selector = "webView:startURLSchemeTask:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.IWKUrlSchemeTask) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopUrlSchemeTask", Selector = "webView:stopURLSchemeTask:", ParameterType = new Type [] { typeof (WebKit.WKWebView), typeof (WebKit.IWKUrlSchemeTask) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IWKUrlSchemeHandler : INativeObject, IDisposable
	{
		/// <param name="webView">The web view that is making the request.</param><param name="urlSchemeTask">The task for which to load data.</param><summary>Starts a URL scheme task that processes a URL and loads data for the specified <paramref name="webView" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("webView:startURLSchemeTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartUrlSchemeTask (WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">The web view that is making the request.</param><param name="urlSchemeTask">The task for which to load data.</param><summary>Starts a URL scheme task that processes a URL and loads data for the specified <paramref name="webView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartUrlSchemeTask (IWKUrlSchemeHandler This, WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var urlSchemeTask__handle__ = urlSchemeTask!.GetNonNullHandle (nameof (urlSchemeTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:startURLSchemeTask:"), webView__handle__, urlSchemeTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (urlSchemeTask);
		}
		/// <param name="webView">The web view that is making the request.</param><param name="urlSchemeTask">The task for which to stop loading data.</param><summary>Stops a URL scheme task that processes a URL and loads data for the specified <paramref name="webView" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("webView:stopURLSchemeTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopUrlSchemeTask (WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">The web view that is making the request.</param><param name="urlSchemeTask">The task for which to stop loading data.</param><summary>Stops a URL scheme task that processes a URL and loads data for the specified <paramref name="webView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StopUrlSchemeTask (IWKUrlSchemeHandler This, WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var urlSchemeTask__handle__ = urlSchemeTask!.GetNonNullHandle (nameof (urlSchemeTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:stopURLSchemeTask:"), webView__handle__, urlSchemeTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (urlSchemeTask);
		}
		[DynamicDependencyAttribute ("StartUrlSchemeTask(WebKit.WKWebView,WebKit.IWKUrlSchemeTask)")]
		[DynamicDependencyAttribute ("StopUrlSchemeTask(WebKit.WKWebView,WebKit.IWKUrlSchemeTask)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKUrlSchemeHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKUrlSchemeHandler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKUrlSchemeHandlerWrapper : BaseWrapper, IWKUrlSchemeHandler {
		public WKUrlSchemeHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKUrlSchemeHandlerWrapper))]
		static WKUrlSchemeHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="webView">The web view that is making the request.</param><param name="urlSchemeTask">The task for which to load data.</param><summary>Starts a URL scheme task that processes a URL and loads data for the specified <paramref name="webView" />.</summary><remarks>To be added.</remarks>
		[Export ("webView:startURLSchemeTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartUrlSchemeTask (WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var urlSchemeTask__handle__ = urlSchemeTask!.GetNonNullHandle (nameof (urlSchemeTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("webView:startURLSchemeTask:"), webView__handle__, urlSchemeTask__handle__);
			GC.KeepAlive (webView);
			GC.KeepAlive (urlSchemeTask);
		}
		/// <param name="webView">The web view that is making the request.</param><param name="urlSchemeTask">The task for which to stop loading data.</param><summary>Stops a URL scheme task that processes a URL and loads data for the specified <paramref name="webView" />.</summary><remarks>To be added.</remarks>
		[Export ("webView:stopURLSchemeTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StopUrlSchemeTask (WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var urlSchemeTask__handle__ = urlSchemeTask!.GetNonNullHandle (nameof (urlSchemeTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("webView:stopURLSchemeTask:"), webView__handle__, urlSchemeTask__handle__);
			GC.KeepAlive (webView);
			GC.KeepAlive (urlSchemeTask);
		}
	}
}
