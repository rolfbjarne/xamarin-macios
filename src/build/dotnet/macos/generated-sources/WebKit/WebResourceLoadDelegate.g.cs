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
	/// <summary>This interface represents the Objective-C protocol <c>WebResourceLoadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WebResourceLoadDelegate", WrapperType = typeof (WebResourceLoadDelegateWrapper), FormalSince = "10.11")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnIdentifierForInitialRequest", Selector = "webView:identifierForInitialRequest:fromDataSource:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSUrlRequest), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSendRequest", Selector = "webView:resource:willSendRequest:redirectResponse:fromDataSource:", ReturnType = typeof (NSUrlRequest), ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (NSUrlRequest), typeof (NSUrlResponse), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReceivedAuthenticationChallenge", Selector = "webView:resource:didReceiveAuthenticationChallenge:fromDataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (NSUrlAuthenticationChallenge), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCancelledAuthenticationChallenge", Selector = "webView:resource:didCancelAuthenticationChallenge:fromDataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (NSUrlAuthenticationChallenge), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReceivedResponse", Selector = "webView:resource:didReceiveResponse:fromDataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (NSUrlResponse), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReceivedContentLength", Selector = "webView:resource:didReceiveContentLength:fromDataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (IntPtr), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFinishedLoading", Selector = "webView:resource:didFinishLoadingFromDataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFailedLoading", Selector = "webView:resource:didFailLoadingWithError:fromDataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSObject), typeof (NSError), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlugInFailed", Selector = "webView:plugInFailedWithError:dataSource:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSError), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IWebResourceLoadDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:identifierForInitialRequest:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject OnIdentifierForInitialRequest (WebView sender, NSUrlRequest request, WebDataSource dataSource)
		{
			return _OnIdentifierForInitialRequest (this, sender, request, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _OnIdentifierForInitialRequest (IWebResourceLoadDelegate This, WebView sender, NSUrlRequest request, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:identifierForInitialRequest:fromDataSource:"), sender__handle__, request__handle__, dataSource__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (request);
			GC.KeepAlive (dataSource);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:willSendRequest:redirectResponse:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest OnSendRequest (WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
		{
			return _OnSendRequest (this, sender, identifier, request, redirectResponse, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlRequest _OnSendRequest (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var redirectResponse__handle__ = redirectResponse!.GetNonNullHandle (nameof (redirectResponse));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			NSUrlRequest? ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:willSendRequest:redirectResponse:fromDataSource:"), sender__handle__, identifier__handle__, request__handle__, redirectResponse__handle__, dataSource__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (request);
			GC.KeepAlive (redirectResponse);
			GC.KeepAlive (dataSource);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnReceivedAuthenticationChallenge (WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			_OnReceivedAuthenticationChallenge (this, sender, identifier, challenge, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnReceivedAuthenticationChallenge (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:"), sender__handle__, identifier__handle__, challenge__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (challenge);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:didCancelAuthenticationChallenge:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnCancelledAuthenticationChallenge (WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			_OnCancelledAuthenticationChallenge (this, sender, identifier, challenge, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnCancelledAuthenticationChallenge (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didCancelAuthenticationChallenge:fromDataSource:"), sender__handle__, identifier__handle__, challenge__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (challenge);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="responseReceived">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:didReceiveResponse:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnReceivedResponse (WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
		{
			_OnReceivedResponse (this, sender, identifier, responseReceived, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="responseReceived">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnReceivedResponse (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var responseReceived__handle__ = responseReceived!.GetNonNullHandle (nameof (responseReceived));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didReceiveResponse:fromDataSource:"), sender__handle__, identifier__handle__, responseReceived__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (responseReceived);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="length">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:didReceiveContentLength:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnReceivedContentLength (WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
		{
			_OnReceivedContentLength (this, sender, identifier, length, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="length">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnReceivedContentLength (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didReceiveContentLength:fromDataSource:"), sender__handle__, identifier__handle__, length, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:didFinishLoadingFromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFinishedLoading (WebView sender, NSObject identifier, WebDataSource dataSource)
		{
			_OnFinishedLoading (this, sender, identifier, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnFinishedLoading (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didFinishLoadingFromDataSource:"), sender__handle__, identifier__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="withError">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:resource:didFailLoadingWithError:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFailedLoading (WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
		{
			_OnFailedLoading (this, sender, identifier, withError, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="withError">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnFailedLoading (IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var withError__handle__ = withError!.GetNonNullHandle (nameof (withError));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didFailLoadingWithError:fromDataSource:"), sender__handle__, identifier__handle__, withError__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (withError);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:plugInFailedWithError:dataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnPlugInFailed (WebView sender, NSError error, WebDataSource dataSource)
		{
			_OnPlugInFailed (this, sender, error, dataSource);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnPlugInFailed (IWebResourceLoadDelegate This, WebView sender, NSError error, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:plugInFailedWithError:dataSource:"), sender__handle__, error__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (error);
			GC.KeepAlive (dataSource);
		}
		[DynamicDependencyAttribute ("OnCancelledAuthenticationChallenge(WebKit.WebView,Foundation.NSObject,Foundation.NSUrlAuthenticationChallenge,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnFailedLoading(WebKit.WebView,Foundation.NSObject,Foundation.NSError,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnFinishedLoading(WebKit.WebView,Foundation.NSObject,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnIdentifierForInitialRequest(WebKit.WebView,Foundation.NSUrlRequest,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnPlugInFailed(WebKit.WebView,Foundation.NSError,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnReceivedAuthenticationChallenge(WebKit.WebView,Foundation.NSObject,Foundation.NSUrlAuthenticationChallenge,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnReceivedContentLength(WebKit.WebView,Foundation.NSObject,System.IntPtr,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnReceivedResponse(WebKit.WebView,Foundation.NSObject,Foundation.NSUrlResponse,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("OnSendRequest(WebKit.WebView,Foundation.NSObject,Foundation.NSUrlRequest,Foundation.NSUrlResponse,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebResourceLoadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWebResourceLoadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWebResourceLoadDelegate" /> interface to support all the methods from the WebResourceLoadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWebResourceLoadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WebResourceLoadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WebResourceLoadDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject OnIdentifierForInitialRequest (this IWebResourceLoadDelegate This, WebView sender, NSUrlRequest request, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:identifierForInitialRequest:fromDataSource:"), sender__handle__, request__handle__, dataSource__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (request);
			GC.KeepAlive (dataSource);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrlRequest OnSendRequest (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var redirectResponse__handle__ = redirectResponse!.GetNonNullHandle (nameof (redirectResponse));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			NSUrlRequest? ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:willSendRequest:redirectResponse:fromDataSource:"), sender__handle__, identifier__handle__, request__handle__, redirectResponse__handle__, dataSource__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (request);
			GC.KeepAlive (redirectResponse);
			GC.KeepAlive (dataSource);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnReceivedAuthenticationChallenge (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:"), sender__handle__, identifier__handle__, challenge__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (challenge);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnCancelledAuthenticationChallenge (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didCancelAuthenticationChallenge:fromDataSource:"), sender__handle__, identifier__handle__, challenge__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (challenge);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="responseReceived">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnReceivedResponse (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var responseReceived__handle__ = responseReceived!.GetNonNullHandle (nameof (responseReceived));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didReceiveResponse:fromDataSource:"), sender__handle__, identifier__handle__, responseReceived__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (responseReceived);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="length">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnReceivedContentLength (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didReceiveContentLength:fromDataSource:"), sender__handle__, identifier__handle__, length, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnFinishedLoading (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didFinishLoadingFromDataSource:"), sender__handle__, identifier__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="withError">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnFailedLoading (this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			var withError__handle__ = withError!.GetNonNullHandle (nameof (withError));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:resource:didFailLoadingWithError:fromDataSource:"), sender__handle__, identifier__handle__, withError__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (identifier);
			GC.KeepAlive (withError);
			GC.KeepAlive (dataSource);
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnPlugInFailed (this IWebResourceLoadDelegate This, WebView sender, NSError error, WebDataSource dataSource)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:plugInFailedWithError:dataSource:"), sender__handle__, error__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (error);
			GC.KeepAlive (dataSource);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WebResourceLoadDelegateWrapper : BaseWrapper, IWebResourceLoadDelegate {
		public WebResourceLoadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebResourceLoadDelegateWrapper))]
		static WebResourceLoadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWebResourceLoadDelegate" /> (for the protocol <c>WebResourceLoadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWebResourceLoadDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WebResourceLoadDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebResourceLoadDelegate : NSObject, IWebResourceLoadDelegate {
		/// <summary>Creates a new <see cref="WebResourceLoadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebResourceLoadDelegate () : base (NSObjectFlag.Empty)
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
		protected WebResourceLoadDelegate (NSObjectFlag t) : base (t)
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
		protected internal WebResourceLoadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:resource:didCancelAuthenticationChallenge:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnCancelledAuthenticationChallenge (WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="withError">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:resource:didFailLoadingWithError:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFailedLoading (WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:resource:didFinishLoadingFromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFinishedLoading (WebView sender, NSObject identifier, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="request">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:identifierForInitialRequest:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject OnIdentifierForInitialRequest (WebView sender, NSUrlRequest request, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:plugInFailedWithError:dataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnPlugInFailed (WebView sender, NSError error, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="challenge">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnReceivedAuthenticationChallenge (WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="length">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:resource:didReceiveContentLength:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnReceivedContentLength (WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="responseReceived">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:resource:didReceiveResponse:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnReceivedResponse (WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="identifier">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("webView:resource:willSendRequest:redirectResponse:fromDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest OnSendRequest (WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WebResourceLoadDelegate */
}
