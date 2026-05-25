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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace JavaScriptCore {
	/// <summary>Encapsulates a JavaScript engine.</summary><remarks><para>
	/// The <see cref="T:JavaScriptCore.JSContext" /> is the central object of the <c>JavaScriptCore</c> namespace.
	/// The <see cref="T:JavaScriptCore.JSContext" /> maintains a JavaScript environment (manipulated by the
	/// <see cref="JavaScriptCore.JSContext.this[Foundation.NSObject]" /> property) and evaluates scripts with
	/// the <see cref="M:JavaScriptCore.JSContext.EvaluateScript(System.String,Foundation.NSUrl)" /> method.
	/// </para><para>
	/// Application developers will often want to assign a delegate to the <see cref="P:JavaScriptCore.JSContext.ExceptionHandler" />
	/// property to gain access, in their Xamarin.iOS code, of exceptions raised in the JavaScript realm.
	/// </para><para>
	/// The following example shows the basic use of <see cref="T:JavaScriptCore.JSContext" />. The context is
	/// instantiated and a simple exception handler is assigned. One of the <see cref="M:JavaScriptCore.JSValue.From(Foundation.NSObject,JavaScriptCore.JSContext)" />
	/// method overloads is used to assign values to the JavaScript variables <c>arg1</c> and <c>arg2</c>.
	/// The <see cref="M:JavaScriptCore.JSContext.EvaluateScript(System.String,Foundation.NSUrl)" /> method
	/// evaluates the JavaScript and returns the result, which is converted back into a .NET object with the
	/// <see cref="M:JavaScriptCore.JSValue.ToInt32" /> method.
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// jsContext = new JSContext();
	/// 
	/// jsContext.ExceptionHandler = (context, exception) => {
	/// 	Console.WriteLine(exception);
	/// };
	/// 
	/// jsContext[new NSString("arg1")] = JSValue.From(2, jsContext);
	/// jsContext[new NSString("arg2")] = JSValue.From(2, jsContext);
	/// 
	/// var jsResult = jsContext.EvaluateScript("arg1 + arg2;");
	/// 
	/// var four = jsResult.ToInt32();
	/// ]]></code></example><para>The <see cref="T:JavaScriptCore.JSContext" /> contains the global JavaScript context, including variables set by JavaScript calculations, as shown in the following example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// jsContext.EvaluateScript("sum = 2 + 2;");
	/// var four = jsContext[(NSString)"sum"].ToInt32();
	/// ]]></code></example><format type="text/html"><h3>Calling C# code from JavaScript</h3></format><para>
	/// Developers can extend the <see cref="IJSExport" /> interface to define methods that can be called from JavaScript.
	/// Developers must mark that interface with the <see cref="T:Foundation.ProtocolAttribute" /> attribute and must mark
	/// JavaScript-callable methods with the <see cref="T:Foundation.ExportAttribute" /> attribute. They must also set the
	/// MSBuild property <c>Registrar</c> to "static" or "managed-static" in the project files. For example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// [Protocol ()]
	/// interface IMyJSVisibleProtocol : IJSExport {
	/// [Export ("myFunc")]
	/// int MyFunc ();
	/// 
	/// [Export ("Arity2:With:")]
	/// NSObject Arity2With(NSObject arg1, NSObject arg2);
	/// }
	/// 
	/// class MyJSExporter : NSObject, IMyJSVisibleProtocol
	/// {
	/// public int MyFunc ()
	/// {
	/// Console.WriteLine ("Called!");
	/// return 42;
	/// }
	/// 
	/// public NSObject Arity2With(NSObject arg1, NSObject arg2)
	/// {
	/// Console.WriteLine ("Arity 2 function called with " + arg1 + " " + arg2);
	/// return (NSNumber) 42;
	/// }
	/// }
	/// ]]></code></example><para>The above example:
	/// <list type="bullet"><item><term>Defines <c>IMyJSVisibleProtocol</c> as extending <see cref="JavaScriptCore.IJSExport" />;</term></item><item><term>Decorates <c>IMyJSVisibleProtocol</c> and it's method <c>MyFunc</c> with the <see cref="T:Foundation.ProtocolAttribute" /> and <see cref="T:Foundation.ExportAttribute" /> attributes;</term></item><item><term>Implements the interface</term></item></list></para><para>
	/// To expose the <c>IMyJSVisibleProtocol</c> to JavaScript, the developer could use code like the following in the <see cref="M:UIKit.UIViewController.ViewDidLoad" /> method of their <see cref="T:UIKit.UIViewController" />:
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// webView = new UIWebView(UIScreen.MainScreen.Bounds);
	/// var context = (JSContext) webView.ValueForKeyPath ((NSString) "documentView.webView.mainFrame.javaScriptContext");
	/// context.ExceptionHandler = (JSContext context2, JSValue exception) => 
	/// {
	/// Console.WriteLine ("JS exception: {0}", exception);
	/// };
	/// var myExporter = new MyJSExporter ();
	/// context [(NSString) "myCSharpObject"] = JSValue.From (myExporter, context);
	/// webView.LoadRequest(NSUrlRequest.FromUrl(new NSUrl("MyHtmlFile.html", false)));
	/// ]]></code></example><para>The above C# code:
	/// <list type="bullet"><item><term>Creates a <see cref="T:UIKit.UIWebView" /> which will be displayed to the end user;</term></item><item><term>Gets the <see cref="T:JavaScriptCore.JSContext" /> of the <see cref="T:UIKit.UIWebView" /> object's main frame;</term></item><item><term>Adds an exception handler so that JavaScript trouble will be visible to the Xamarin project;</term></item><item><term>Instantiates a new <c>MyJSExporter</c> object that, as described above, implements the <c>IMyJSVisibleProtocol</c>;</term></item><item><term>Adds that object to the <see cref="T:JavaScriptCore.JSContext" /> with the name <c>myCSharpObject</c>;</term></item><item><term>Loads an HTML file (see below)</term></item></list></para><para>
	/// Finally, the HTML file that is loaded into the <see cref="T:UIKit.UIWebView" /> and into whose <see cref="T:JavaScriptCore.JSContext" /> the <c>MyJSExporter</c> object has been placed can access the object from within JavaScript:
	/// </para><example><code lang="HTML"><![CDATA[
	/// <html>
	/// <head>
	/// <title></title>
	/// <script type="text/javascript">
	/// function callXamObject() {
	/// // `myCSharpObject` injected into JS context by C# code `context [(NSString) "myCSharpObject"] = JSValue.From (...etc...`
	/// var resultCalculatedInCSharp = myCSharpObject.myFunc();
	/// document.getElementById("Output").innerHTML = resultCalculatedInCSharp;
	/// }
	/// 
	/// function callArity2Method() {
	/// //Note how this is mapped by [Export ("Arity2:With:")]
	/// var result = myCSharpObject.Arity2With("foo", "bar");
	/// }
	/// </script>
	/// </head>
	/// <body>
	/// <div onclick="callXamObject()" class="button">
	/// Click Me
	/// </div>
	/// <div id="Output">Value</div>
	/// </body>
	/// </html>
	/// ]]></code></example><para>In order to export a C# object so that it is visible to JavaScript, the developer must add the <c>--registrar:static</c> argument to the arguments used by <c>mtouch</c>. In Xamarin Studio, this is done in the Project Options dialog, in the Build Options / iOS Build pane:</para><para><img href="~/xml/JavaScriptCore/_images/JSContext.StaticRegistrar.png" alt="Screenshot of compiler options" /></para><para>Another technique for calling C# code from Xamarin.iOS is to use REST, as shown in the following: </para><para>In the JavaScript code, use <c>XMLHttpRequest</c> and standard JSON techniques to post and parse a query to a REST service running on the local device:</para><example><code lang="JavaScript"><![CDATA[
	/// <html>
	/// <head>
	/// <title></title>
	/// <script type="text/javascript">
	/// function callCSharp(msg) {
	/// var request = new XMLHttpRequest();
	/// request.open('GET','http://127.0.0.1:1711/', false);
	/// request.send();
	/// 
	/// if(request.status == 200){
	/// alert(JSON.parse(request.responseText));
	/// }else{
	/// alert("Error");
	/// }
	/// }
	/// </script>
	/// </head>
	/// <body>
	/// <div onclick="callCSharp('this is a test')" class="button">
	/// Click Me
	/// </div>
	/// </body>
	/// </html>
	/// ]]></code></example><para>In the application, use <see cref="T:System.Net.HttpListener" /> to listen and respond to that request: </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //Wire up listener
	/// listener = new HttpListener();
	/// listener.Prefixes.Add("http://*:1711/");
	/// listener.Start();
	/// listener.BeginGetContext(new AsyncCallback(Callback), listener);
	/// 
	/// //....etc...
	/// 
	/// void Callback(IAsyncResult result)
	/// {
	/// 	//Get the listener context
	/// 	var context = listener.EndGetContext(result);
	/// 
	/// 	//Start listening for the next request
	/// 	listener.BeginGetContext(new AsyncCallback(Callback), listener);
	/// 
	/// 	var response = CalculateResponse();
	/// 	var responseBytes = System.Text.Encoding.UTF8.GetBytes(response);
	/// 
	/// 	context.Response.ContentType = "text/json";
	/// 	context.Response.StatusCode = HttpStatusCode.OK;
	/// 	context.Response.ContentLength64 = responseBytes.Length;
	/// 	context.Response.OutputStream.Write(responseBytes, 0, responseBytes.Length);
	/// 	context.Response.OutputStream.Close();
	/// }
	/// ]]></code></example><para>Finally, a third technique is to poll the <see cref="T:JavaScriptCore.JSContext" /> for a flag set by a JavaScript calculation.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/JavaScriptCore/JSContext">Apple documentation for <c>JSContext</c></related>
	[Register("JSContext", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class JSContext : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("JSContext");
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
		protected JSContext (NSObjectFlag t) : base (t)
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
		protected internal JSContext (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public JSContext ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("init")), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithVirtualMachine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public JSContext (JSVirtualMachine virtualMachine)
			: base (NSObjectFlag.Empty)
		{
			var virtualMachine__handle__ = virtualMachine!.GetNonNullHandle (nameof (virtualMachine));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithVirtualMachine:"), virtualMachine__handle__), "initWithVirtualMachine:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithVirtualMachine:"), virtualMachine__handle__), "initWithVirtualMachine:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (virtualMachine);
		}
		[Export ("evaluateScript:withSourceURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue EvaluateScript (string script, NSUrl sourceUrl)
		{
			if (script is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (script));
			var sourceUrl__handle__ = sourceUrl!.GetNonNullHandle (nameof (sourceUrl));
			var nsscript = CFString.CreateNative (script);
			JSValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("evaluateScript:withSourceURL:"), nsscript, sourceUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("evaluateScript:withSourceURL:"), nsscript, sourceUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceUrl);
			CFString.ReleaseNative (nsscript);
			return ret!;
		}
		[Export ("evaluateScript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue EvaluateScript (string script)
		{
			if (script is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (script));
			var nsscript = CFString.CreateNative (script);
			JSValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("evaluateScript:"), nsscript), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("evaluateScript:"), nsscript), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsscript);
			return ret!;
		}
		[Export ("contextWithJSGlobalContextRef:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSContext FromJSGlobalContextRef (nint nativeJsGlobalContextRef)
		{
			JSContext ret;
			ret =  Runtime.GetNSObject<JSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("contextWithJSGlobalContextRef:"), nativeJsGlobalContextRef), false)!;
			return ret;
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual JSValue _GetObject (NSObject key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			JSValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectForKeyedSubscript:"), key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("setObject:forKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetObject (JSValue obj, NSObject key)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setObject:forKeyedSubscript:"), obj__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setObject:forKeyedSubscript:"), obj__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			GC.KeepAlive (key);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue[] CurrentArguments {
			[Export ("currentArguments")]
			get {
				JSValue[]? ret;
				ret = CFArray.ArrayFromHandle<JSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("currentArguments")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static JSValue CurrentCallee {
			[Export ("currentCallee")]
			get {
				JSValue? ret;
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("currentCallee")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSContext CurrentContext {
			[Export ("currentContext")]
			get {
				JSContext? ret;
				ret =  Runtime.GetNSObject<JSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("currentContext")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CurrentThis {
			[Export ("currentThis")]
			get {
				JSValue? ret;
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("currentThis")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue? Exception {
			[Export ("exception", ArgumentSemantic.Retain)]
			get {
				JSValue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("exception")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("exception")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setException:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setException:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setException:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual JSContextExceptionHandler ExceptionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDJSContextExceptionHandler))]
			[Export ("exceptionHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("exceptionHandler"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("exceptionHandler"));
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDJSContextExceptionHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDJSContextExceptionHandler))]
			[Export ("setExceptionHandler:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = Trampolines.SDJSContextExceptionHandler.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setExceptionHandler:"), (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setExceptionHandler:"), (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue GlobalObject {
			[Export ("globalObject")]
			get {
				JSValue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("globalObject")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("globalObject")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public virtual bool Inspectable {
			[Export ("isInspectable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInspectable"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isInspectable"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setInspectable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setInspectable:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setInspectable:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint JSGlobalContextRefPtr {
			[Export ("JSGlobalContextRef")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("JSGlobalContextRef"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("JSGlobalContextRef"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("name")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setName:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSVirtualMachine VirtualMachine {
			[Export ("virtualMachine", ArgumentSemantic.Retain)]
			get {
				JSVirtualMachine? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<JSVirtualMachine> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("virtualMachine")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<JSVirtualMachine> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("virtualMachine")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class JSContext */
}
