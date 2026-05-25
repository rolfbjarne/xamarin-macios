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
	[Register("WebFrame", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebFrame : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDOMDocumentX = "DOMDocument";
		static readonly NativeHandle selDOMDocumentXHandle = Selector.GetHandle ("DOMDocument");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildFramesX = "childFrames";
		static readonly NativeHandle selChildFramesXHandle = Selector.GetHandle ("childFrames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindFrameNamed_X = "findFrameNamed:";
		static readonly NativeHandle selFindFrameNamed_XHandle = Selector.GetHandle ("findFrameNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameElementX = "frameElement";
		static readonly NativeHandle selFrameElementXHandle = Selector.GetHandle ("frameElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameViewX = "frameView";
		static readonly NativeHandle selFrameViewXHandle = Selector.GetHandle ("frameView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlobalContextX = "globalContext";
		static readonly NativeHandle selGlobalContextXHandle = Selector.GetHandle ("globalContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_WebFrameView_WebView_X = "initWithName:webFrameView:webView:";
		static readonly NativeHandle selInitWithName_WebFrameView_WebView_XHandle = Selector.GetHandle ("initWithName:webFrameView:webView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJavaScriptContextX = "javaScriptContext";
		static readonly NativeHandle selJavaScriptContextXHandle = Selector.GetHandle ("javaScriptContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_X = "loadAlternateHTMLString:baseURL:forUnreachableURL:";
		static readonly NativeHandle selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_XHandle = Selector.GetHandle ("loadAlternateHTMLString:baseURL:forUnreachableURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadArchive_X = "loadArchive:";
		static readonly NativeHandle selLoadArchive_XHandle = Selector.GetHandle ("loadArchive:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadData_MIMEType_TextEncodingName_BaseURL_X = "loadData:MIMEType:textEncodingName:baseURL:";
		static readonly NativeHandle selLoadData_MIMEType_TextEncodingName_BaseURL_XHandle = Selector.GetHandle ("loadData:MIMEType:textEncodingName:baseURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadHTMLString_BaseURL_X = "loadHTMLString:baseURL:";
		static readonly NativeHandle selLoadHTMLString_BaseURL_XHandle = Selector.GetHandle ("loadHTMLString:baseURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadRequest_X = "loadRequest:";
		static readonly NativeHandle selLoadRequest_XHandle = Selector.GetHandle ("loadRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentFrameX = "parentFrame";
		static readonly NativeHandle selParentFrameXHandle = Selector.GetHandle ("parentFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProvisionalDataSourceX = "provisionalDataSource";
		static readonly NativeHandle selProvisionalDataSourceXHandle = Selector.GetHandle ("provisionalDataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadX = "reload";
		static readonly NativeHandle selReloadXHandle = Selector.GetHandle ("reload");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadFromOriginX = "reloadFromOrigin";
		static readonly NativeHandle selReloadFromOriginXHandle = Selector.GetHandle ("reloadFromOrigin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopLoadingX = "stopLoading";
		static readonly NativeHandle selStopLoadingXHandle = Selector.GetHandle ("stopLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWebViewX = "webView";
		static readonly NativeHandle selWebViewXHandle = Selector.GetHandle ("webView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowObjectX = "windowObject";
		static readonly NativeHandle selWindowObjectXHandle = Selector.GetHandle ("windowObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WebFrame");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected WebFrame (NSObjectFlag t) : base (t)
		{
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
		protected internal WebFrame (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithName:webFrameView:webView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WebFrame (string name, WebFrameView view, WebView webView)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithName_WebFrameView_WebView_XHandle, nsname, view__handle__, webView__handle__), "initWithName:webFrameView:webView:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithName_WebFrameView_WebView_XHandle, nsname, view__handle__, webView__handle__), "initWithName:webFrameView:webView:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (webView);
			CFString.ReleaseNative (nsname);
		}
		[Export ("findFrameNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebFrame FindFrameNamed (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			WebFrame? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFindFrameNamed_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFindFrameNamed_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("loadAlternateHTMLString:baseURL:forUnreachableURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadAlternateHtmlString (string htmlString, NSUrl baseURL, NSUrl forUnreachableURL)
		{
			if (htmlString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (htmlString));
			var baseURL__handle__ = baseURL!.GetNonNullHandle (nameof (baseURL));
			var forUnreachableURL__handle__ = forUnreachableURL!.GetNonNullHandle (nameof (forUnreachableURL));
			var nshtmlString = CFString.CreateNative (htmlString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_XHandle, nshtmlString, baseURL__handle__, forUnreachableURL__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_XHandle, nshtmlString, baseURL__handle__, forUnreachableURL__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (baseURL);
			GC.KeepAlive (forUnreachableURL);
			CFString.ReleaseNative (nshtmlString);
		}
		[Export ("loadArchive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadArchive (WebArchive archive)
		{
			var archive__handle__ = archive!.GetNonNullHandle (nameof (archive));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadArchive_XHandle, archive__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadArchive_XHandle, archive__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (archive);
		}
		[Export ("loadData:MIMEType:textEncodingName:baseURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadData (NSData data, string mimeType, string textDncodingName, NSUrl baseUrl)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			if (textDncodingName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textDncodingName));
			var baseUrl__handle__ = baseUrl!.GetNonNullHandle (nameof (baseUrl));
			var nsmimeType = CFString.CreateNative (mimeType);
			var nstextDncodingName = CFString.CreateNative (textDncodingName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLoadData_MIMEType_TextEncodingName_BaseURL_XHandle, data__handle__, nsmimeType, nstextDncodingName, baseUrl__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLoadData_MIMEType_TextEncodingName_BaseURL_XHandle, data__handle__, nsmimeType, nstextDncodingName, baseUrl__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmimeType);
			CFString.ReleaseNative (nstextDncodingName);
		}
		[Export ("loadHTMLString:baseURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadHtmlString (NSString htmlString, NSUrl? baseUrl)
		{
			var htmlString__handle__ = htmlString!.GetNonNullHandle (nameof (htmlString));
			var baseUrl__handle__ = baseUrl.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadHTMLString_BaseURL_XHandle, htmlString__handle__, baseUrl__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadHTMLString_BaseURL_XHandle, htmlString__handle__, baseUrl__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (htmlString);
			GC.KeepAlive (baseUrl);
		}
		[Export ("loadRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRequest (NSUrlRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadRequest_XHandle, request__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadRequest_XHandle, request__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[Export ("reload")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reload ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReloadXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("reloadFromOrigin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadFromOrigin ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadFromOriginXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReloadFromOriginXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopLoading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopLoadingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopLoadingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebFrame[] ChildFrames {
			[Export ("childFrames")]
			get {
				WebFrame[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<WebFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildFramesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<WebFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildFramesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebDataSource DataSource {
			[Export ("dataSource")]
			get {
				WebDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocument DomDocument {
			[Export ("DOMDocument")]
			get {
				DomDocument? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDOMDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDOMDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlElement FrameElement {
			[Export ("frameElement")]
			get {
				DomHtmlElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFrameElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFrameElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebFrameView FrameView {
			[Export ("frameView")]
			get {
				WebFrameView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebFrameView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFrameViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebFrameView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFrameViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GlobalContext {
			[Export ("globalContext")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGlobalContextXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selGlobalContextXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::JavaScriptCore.JSContext JavaScriptContext {
			[Export ("javaScriptContext", ArgumentSemantic.Retain)]
			get {
				global::JavaScriptCore.JSContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selJavaScriptContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selJavaScriptContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebFrame ParentFrame {
			[Export ("parentFrame")]
			get {
				WebFrame? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentFrameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentFrameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebDataSource ProvisionalDataSource {
			[Export ("provisionalDataSource")]
			get {
				WebDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProvisionalDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProvisionalDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebView WebView {
			[Export ("webView")]
			get {
				WebView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWebViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWebViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebScriptObject WindowObject {
			[Export ("windowObject")]
			get {
				WebScriptObject? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebScriptObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWindowObjectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebScriptObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWindowObjectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class WebFrame */
}
