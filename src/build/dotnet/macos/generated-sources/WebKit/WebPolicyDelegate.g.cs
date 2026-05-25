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
	/// <summary>This interface represents the Objective-C protocol <c>WebPolicyDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WebPolicyDelegate", WrapperType = typeof (WebPolicyDelegateWrapper), FormalSince = "10.11")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicyForNavigation", Selector = "webView:decidePolicyForNavigationAction:request:frame:decisionListener:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSDictionary), typeof (NSUrlRequest), typeof (WebKit.WebFrame), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicyForNewWindow", Selector = "webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSDictionary), typeof (NSUrlRequest), typeof (string), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicyForMimeType", Selector = "webView:decidePolicyForMIMEType:request:frame:decisionListener:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (string), typeof (NSUrlRequest), typeof (WebKit.WebFrame), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnableToImplementPolicy", Selector = "webView:unableToImplementPolicyWithError:frame:", ParameterType = new Type [] { typeof (WebKit.WebView), typeof (NSError), typeof (WebKit.WebFrame) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IWebPolicyDelegate : INativeObject, IDisposable
	{
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecidePolicyForNavigation (WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			_DecidePolicyForNavigation (this, webView, actionInformation, request, frame, decisionToken);
		}
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecidePolicyForNavigation (IWebPolicyDelegate This, WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var actionInformation__handle__ = actionInformation!.GetNonNullHandle (nameof (actionInformation));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			var decisionToken__handle__ = decisionToken!.GetNonNullHandle (nameof (decisionToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationAction:request:frame:decisionListener:"), webView__handle__, actionInformation__handle__, request__handle__, frame__handle__, decisionToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (actionInformation);
			GC.KeepAlive (request);
			GC.KeepAlive (frame);
			GC.KeepAlive (decisionToken);
		}
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="newFrameName">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecidePolicyForNewWindow (WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			_DecidePolicyForNewWindow (this, webView, actionInformation, request, newFrameName, decisionToken);
		}
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="newFrameName">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecidePolicyForNewWindow (IWebPolicyDelegate This, WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var actionInformation__handle__ = actionInformation!.GetNonNullHandle (nameof (actionInformation));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (newFrameName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newFrameName));
			var decisionToken__handle__ = decisionToken!.GetNonNullHandle (nameof (decisionToken));
			var nsnewFrameName = CFString.CreateNative (newFrameName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:"), webView__handle__, actionInformation__handle__, request__handle__, nsnewFrameName, decisionToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (actionInformation);
			GC.KeepAlive (request);
			GC.KeepAlive (decisionToken);
			CFString.ReleaseNative (nsnewFrameName);
		}
		/// <param name="webView">To be added.</param><param name="mimeType">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:decidePolicyForMIMEType:request:frame:decisionListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecidePolicyForMimeType (WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			_DecidePolicyForMimeType (this, webView, mimeType, request, frame, decisionToken);
		}
		/// <param name="webView">To be added.</param><param name="mimeType">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecidePolicyForMimeType (IWebPolicyDelegate This, WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			var decisionToken__handle__ = decisionToken!.GetNonNullHandle (nameof (decisionToken));
			var nsmimeType = CFString.CreateNative (mimeType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForMIMEType:request:frame:decisionListener:"), webView__handle__, nsmimeType, request__handle__, frame__handle__, decisionToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (request);
			GC.KeepAlive (frame);
			GC.KeepAlive (decisionToken);
			CFString.ReleaseNative (nsmimeType);
		}
		/// <param name="webView">To be added.</param><param name="error">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("webView:unableToImplementPolicyWithError:frame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnableToImplementPolicy (WebView webView, NSError error, WebFrame frame)
		{
			_UnableToImplementPolicy (this, webView, error, frame);
		}
		/// <param name="webView">To be added.</param><param name="error">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnableToImplementPolicy (IWebPolicyDelegate This, WebView webView, NSError error, WebFrame frame)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:unableToImplementPolicyWithError:frame:"), webView__handle__, error__handle__, frame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (error);
			GC.KeepAlive (frame);
		}
		[DynamicDependencyAttribute ("DecidePolicyForMimeType(WebKit.WebView,System.String,Foundation.NSUrlRequest,WebKit.WebFrame,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("DecidePolicyForNavigation(WebKit.WebView,Foundation.NSDictionary,Foundation.NSUrlRequest,WebKit.WebFrame,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("DecidePolicyForNewWindow(WebKit.WebView,Foundation.NSDictionary,Foundation.NSUrlRequest,System.String,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("UnableToImplementPolicy(WebKit.WebView,Foundation.NSError,WebKit.WebFrame)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebPolicyDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWebPolicyDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWebPolicyDelegate" /> interface to support all the methods from the WebPolicyDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWebPolicyDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WebPolicyDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WebPolicyDelegate_Extensions {
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecidePolicyForNavigation (this IWebPolicyDelegate This, WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var actionInformation__handle__ = actionInformation!.GetNonNullHandle (nameof (actionInformation));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			var decisionToken__handle__ = decisionToken!.GetNonNullHandle (nameof (decisionToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNavigationAction:request:frame:decisionListener:"), webView__handle__, actionInformation__handle__, request__handle__, frame__handle__, decisionToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (actionInformation);
			GC.KeepAlive (request);
			GC.KeepAlive (frame);
			GC.KeepAlive (decisionToken);
		}
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="newFrameName">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecidePolicyForNewWindow (this IWebPolicyDelegate This, WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var actionInformation__handle__ = actionInformation!.GetNonNullHandle (nameof (actionInformation));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (newFrameName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newFrameName));
			var decisionToken__handle__ = decisionToken!.GetNonNullHandle (nameof (decisionToken));
			var nsnewFrameName = CFString.CreateNative (newFrameName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:"), webView__handle__, actionInformation__handle__, request__handle__, nsnewFrameName, decisionToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (actionInformation);
			GC.KeepAlive (request);
			GC.KeepAlive (decisionToken);
			CFString.ReleaseNative (nsnewFrameName);
		}
		/// <param name="webView">To be added.</param><param name="mimeType">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecidePolicyForMimeType (this IWebPolicyDelegate This, WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			var decisionToken__handle__ = decisionToken!.GetNonNullHandle (nameof (decisionToken));
			var nsmimeType = CFString.CreateNative (mimeType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:decidePolicyForMIMEType:request:frame:decisionListener:"), webView__handle__, nsmimeType, request__handle__, frame__handle__, decisionToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (request);
			GC.KeepAlive (frame);
			GC.KeepAlive (decisionToken);
			CFString.ReleaseNative (nsmimeType);
		}
		/// <param name="webView">To be added.</param><param name="error">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnableToImplementPolicy (this IWebPolicyDelegate This, WebView webView, NSError error, WebFrame frame)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("webView:unableToImplementPolicyWithError:frame:"), webView__handle__, error__handle__, frame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (webView);
			GC.KeepAlive (error);
			GC.KeepAlive (frame);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WebPolicyDelegateWrapper : BaseWrapper, IWebPolicyDelegate {
		public WebPolicyDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebPolicyDelegateWrapper))]
		static WebPolicyDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWebPolicyDelegate" /> (for the protocol <c>WebPolicyDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWebPolicyDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WebPolicyDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebPolicyDelegate : NSObject, IWebPolicyDelegate {
		/// <summary>Creates a new <see cref="WebPolicyDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebPolicyDelegate () : base (NSObjectFlag.Empty)
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
		protected WebPolicyDelegate (NSObjectFlag t) : base (t)
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
		protected internal WebPolicyDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="webView">To be added.</param><param name="mimeType">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:decidePolicyForMIMEType:request:frame:decisionListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecidePolicyForMimeType (WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="frame">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecidePolicyForNavigation (WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="actionInformation">To be added.</param><param name="request">To be added.</param><param name="newFrameName">To be added.</param><param name="decisionToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecidePolicyForNewWindow (WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="webView">To be added.</param><param name="error">To be added.</param><param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("webView:unableToImplementPolicyWithError:frame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnableToImplementPolicy (WebView webView, NSError error, WebFrame frame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebActionButtonKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("WebActionButtonKey",  "WebKit")]
		public static NSString WebActionButtonKey {
			get {
				if (_WebActionButtonKey is null)
					_WebActionButtonKey = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WebActionButtonKey")!;
				return _WebActionButtonKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebActionElementKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("WebActionElementKey",  "WebKit")]
		public static NSString WebActionElementKey {
			get {
				if (_WebActionElementKey is null)
					_WebActionElementKey = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WebActionElementKey")!;
				return _WebActionElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebActionModifierFlagsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("WebActionModifierFlagsKey",  "WebKit")]
		public static NSString WebActionModifierFlagsKey {
			get {
				if (_WebActionModifierFlagsKey is null)
					_WebActionModifierFlagsKey = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WebActionModifierFlagsKey")!;
				return _WebActionModifierFlagsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebActionNavigationTypeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("WebActionNavigationTypeKey",  "WebKit")]
		public static NSString WebActionNavigationTypeKey {
			get {
				if (_WebActionNavigationTypeKey is null)
					_WebActionNavigationTypeKey = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WebActionNavigationTypeKey")!;
				return _WebActionNavigationTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebActionOriginalUrlKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("WebActionOriginalURLKey",  "WebKit")]
		public static NSString WebActionOriginalUrlKey {
			get {
				if (_WebActionOriginalUrlKey is null)
					_WebActionOriginalUrlKey = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WebActionOriginalURLKey")!;
				return _WebActionOriginalUrlKey;
			}
		}
	} /* class WebPolicyDelegate */
}
