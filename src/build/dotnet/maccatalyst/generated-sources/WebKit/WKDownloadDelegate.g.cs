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
	/// <summary>This interface represents the Objective-C protocol <c>WKDownloadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.5")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKDownloadDelegate", WrapperType = typeof (WKDownloadDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DecideDestination", Selector = "download:decideDestinationUsingResponse:suggestedFilename:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (NSUrlResponse), typeof (string), typeof (global::System.Action<NSUrl>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V45) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformHttpRedirection", Selector = "download:willPerformHTTPRedirection:newRequest:decisionHandler:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (NSHttpUrlResponse), typeof (NSUrlRequest), typeof (global::System.Action<global::WebKit.WKDownloadRedirectPolicy>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V266) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveAuthenticationChallenge", Selector = "download:didReceiveAuthenticationChallenge:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (NSUrlAuthenticationChallenge), typeof (global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V7) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "downloadDidFinish:", ParameterType = new Type [] { typeof (WebKit.WKDownload) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "download:didFailWithError:resumeData:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (NSError), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePlaceholderPolicy", Selector = "download:decidePlaceholderPolicy:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (WebKit.WKDownloadDelegateDecidePlaceholderPolicyCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKDownloadDelegateDecidePlaceholderPolicyCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceivePlaceholderUrl", Selector = "download:didReceivePlaceholderURL:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (NSUrl), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveFinalUrl", Selector = "download:didReceiveFinalURL:", ParameterType = new Type [] { typeof (WebKit.WKDownload), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IWKDownloadDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("download:decideDestinationUsingResponse:suggestedFilename:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecideDestination (WKDownload download, NSUrlResponse response, string suggestedFilename, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V45))]global::System.Action<NSUrl> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecideDestination (IWKDownloadDelegate This, WKDownload download, NSUrlResponse response, string suggestedFilename, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V45))]global::System.Action<NSUrl> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (suggestedFilename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedFilename));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssuggestedFilename = CFString.CreateNative (suggestedFilename);
			using var block_completionHandler = Trampolines.SDActionArity1V45.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:decideDestinationUsingResponse:suggestedFilename:completionHandler:"), download__handle__, response__handle__, nssuggestedFilename, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
			CFString.ReleaseNative (nssuggestedFilename);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:willPerformHTTPRedirection:newRequest:decisionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPerformHttpRedirection (WKDownload download, NSHttpUrlResponse response, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V266))]global::System.Action<WKDownloadRedirectPolicy> decisionHandler)
		{
			_WillPerformHttpRedirection (this, download, response, request, decisionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillPerformHttpRedirection (IWKDownloadDelegate This, WKDownload download, NSHttpUrlResponse response, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V266))]global::System.Action<WKDownloadRedirectPolicy> decisionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V266.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:willPerformHTTPRedirection:newRequest:decisionHandler:"), download__handle__, response__handle__, request__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
			GC.KeepAlive (request);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:didReceiveAuthenticationChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveAuthenticationChallenge (WKDownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			_DidReceiveAuthenticationChallenge (this, download, challenge, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveAuthenticationChallenge (IWKDownloadDelegate This, WKDownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V7.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveAuthenticationChallenge:completionHandler:"), download__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (WKDownload download)
		{
			_DidFinish (this, download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IWKDownloadDelegate This, WKDownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidFinish:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:didFailWithError:resumeData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (WKDownload download, NSError error, NSData? resumeData)
		{
			_DidFail (this, download, error, resumeData);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (IWKDownloadDelegate This, WKDownload download, NSError error, NSData? resumeData)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var resumeData__handle__ = resumeData.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didFailWithError:resumeData:"), download__handle__, error__handle__, resumeData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
			GC.KeepAlive (resumeData);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:decidePlaceholderPolicy:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePlaceholderPolicy (WKDownload download, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKDownloadDelegateDecidePlaceholderPolicyCallback))]WKDownloadDelegateDecidePlaceholderPolicyCallback completionHandler)
		{
			_DecidePlaceholderPolicy (this, download, completionHandler);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecidePlaceholderPolicy (IWKDownloadDelegate This, WKDownload download, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKDownloadDelegateDecidePlaceholderPolicyCallback))]WKDownloadDelegateDecidePlaceholderPolicyCallback completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKDownloadDelegateDecidePlaceholderPolicyCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:decidePlaceholderPolicy:"), download__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:didReceivePlaceholderURL:completionHandler:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceivePlaceholderUrl (WKDownload download, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_DidReceivePlaceholderUrl (this, download, url, completionHandler);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceivePlaceholderUrl (IWKDownloadDelegate This, WKDownload download, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceivePlaceholderURL:completionHandler:"), download__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (url);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:didReceiveFinalURL:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveFinalUrl (WKDownload download, NSUrl url)
		{
			_DidReceiveFinalUrl (this, download, url);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveFinalUrl (IWKDownloadDelegate This, WKDownload download, NSUrl url)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveFinalURL:"), download__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (url);
		}
		[DynamicDependencyAttribute ("DecideDestination(WebKit.WKDownload,Foundation.NSUrlResponse,System.String,System.Action{Foundation.NSUrl})")]
		[DynamicDependencyAttribute ("DecidePlaceholderPolicy(WebKit.WKDownload,WebKit.WKDownloadDelegateDecidePlaceholderPolicyCallback)")]
		[DynamicDependencyAttribute ("DidFail(WebKit.WKDownload,Foundation.NSError,Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidFinish(WebKit.WKDownload)")]
		[DynamicDependencyAttribute ("DidReceiveAuthenticationChallenge(WebKit.WKDownload,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})")]
		[DynamicDependencyAttribute ("DidReceiveFinalUrl(WebKit.WKDownload,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidReceivePlaceholderUrl(WebKit.WKDownload,Foundation.NSUrl,System.Action)")]
		[DynamicDependencyAttribute ("WillPerformHttpRedirection(WebKit.WKDownload,Foundation.NSHttpUrlResponse,Foundation.NSUrlRequest,System.Action{WebKit.WKDownloadRedirectPolicy})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKDownloadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKDownloadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWKDownloadDelegate" /> interface to support all the methods from the WKDownloadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWKDownloadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WKDownloadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WKDownloadDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillPerformHttpRedirection (this IWKDownloadDelegate This, WKDownload download, NSHttpUrlResponse response, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V266))]global::System.Action<WKDownloadRedirectPolicy> decisionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (decisionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (decisionHandler));
			using var block_decisionHandler = Trampolines.SDActionArity1V266.CreateBlock (decisionHandler);
			BlockLiteral *block_ptr_decisionHandler = &block_decisionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:willPerformHTTPRedirection:newRequest:decisionHandler:"), download__handle__, response__handle__, request__handle__, (IntPtr) block_ptr_decisionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
			GC.KeepAlive (request);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveAuthenticationChallenge (this IWKDownloadDelegate This, WKDownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V7.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveAuthenticationChallenge:completionHandler:"), download__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this IWKDownloadDelegate This, WKDownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidFinish:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFail (this IWKDownloadDelegate This, WKDownload download, NSError error, NSData? resumeData)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var resumeData__handle__ = resumeData.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didFailWithError:resumeData:"), download__handle__, error__handle__, resumeData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
			GC.KeepAlive (resumeData);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DecidePlaceholderPolicy (this IWKDownloadDelegate This, WKDownload download, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKDownloadDelegateDecidePlaceholderPolicyCallback))]WKDownloadDelegateDecidePlaceholderPolicyCallback completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKDownloadDelegateDecidePlaceholderPolicyCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:decidePlaceholderPolicy:"), download__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceivePlaceholderUrl (this IWKDownloadDelegate This, WKDownload download, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceivePlaceholderURL:completionHandler:"), download__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveFinalUrl (this IWKDownloadDelegate This, WKDownload download, NSUrl url)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveFinalURL:"), download__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (url);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKDownloadDelegateWrapper : BaseWrapper, IWKDownloadDelegate {
		public WKDownloadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKDownloadDelegateWrapper))]
		static WKDownloadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("download:decideDestinationUsingResponse:suggestedFilename:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DecideDestination (WKDownload download, NSUrlResponse response, string suggestedFilename, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V45))]global::System.Action<NSUrl> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (suggestedFilename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedFilename));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssuggestedFilename = CFString.CreateNative (suggestedFilename);
			using var block_completionHandler = Trampolines.SDActionArity1V45.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("download:decideDestinationUsingResponse:suggestedFilename:completionHandler:"), download__handle__, response__handle__, nssuggestedFilename, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
			CFString.ReleaseNative (nssuggestedFilename);
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWKDownloadDelegate" /> (for the protocol <c>WKDownloadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWKDownloadDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__WebKit_WKDownloadDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios14.5")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class WKDownloadDelegate : NSObject, IWKDownloadDelegate {
		/// <summary>Creates a new <see cref="WKDownloadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WKDownloadDelegate () : base (NSObjectFlag.Empty)
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
		protected WKDownloadDelegate (NSObjectFlag t) : base (t)
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
		protected internal WKDownloadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("download:decideDestinationUsingResponse:suggestedFilename:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecideDestination (WKDownload download, NSUrlResponse response, string suggestedFilename, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V45))]global::System.Action<NSUrl> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:decidePlaceholderPolicy:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecidePlaceholderPolicy (WKDownload download, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKDownloadDelegateDecidePlaceholderPolicyCallback))]WKDownloadDelegateDecidePlaceholderPolicyCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:didFailWithError:resumeData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (WKDownload download, NSError error, NSData? resumeData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("downloadDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (WKDownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:didReceiveAuthenticationChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveAuthenticationChallenge (WKDownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:didReceiveFinalURL:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveFinalUrl (WKDownload download, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:didReceivePlaceholderURL:completionHandler:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceivePlaceholderUrl (WKDownload download, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:willPerformHTTPRedirection:newRequest:decisionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPerformHttpRedirection (WKDownload download, NSHttpUrlResponse response, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V266))]global::System.Action<WKDownloadRedirectPolicy> decisionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WKDownloadDelegate */
}
