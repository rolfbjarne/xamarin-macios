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
	/// <summary>Displays a Web page.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKWebView_Ref/index.html">Apple documentation for <c>WKWebView</c></related>
	[Register("WKWebView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKWebView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKWebView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public WKWebView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected WKWebView (NSObjectFlag t) : base (t)
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
		protected internal WKWebView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:configuration:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKWebView (CGRect frame, WKWebViewConfiguration configuration)
			: base (NSObjectFlag.Empty)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("initWithFrame:configuration:"), frame, configuration__handle__), "initWithFrame:configuration:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithFrame:configuration:"), frame, configuration__handle__), "initWithFrame:configuration:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
		}
		[Export ("callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CallAsyncJavaScript (string functionBody, NSDictionary<NSString, NSObject>? arguments, WKFrameInfo? frame, WKContentWorld contentWorld, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V78))]global::System.Action<NSObject, NSError>? completionHandler)
		{
			if (functionBody is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionBody));
			var arguments__handle__ = arguments.GetHandle ();
			var frame__handle__ = frame.GetHandle ();
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			var nsfunctionBody = CFString.CreateNative (functionBody);
			using var block_completionHandler = Trampolines.SDActionArity2V78.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:"), nsfunctionBody, arguments__handle__, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:"), nsfunctionBody, arguments__handle__, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (arguments);
			GC.KeepAlive (frame);
			GC.KeepAlive (contentWorld);
			CFString.ReleaseNative (nsfunctionBody);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> CallAsyncJavaScriptAsync (string functionBody, NSDictionary<NSString, NSObject>? arguments, WKFrameInfo? frame, WKContentWorld contentWorld)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			CallAsyncJavaScript(functionBody, arguments, frame, contentWorld, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("closeAllMediaPresentationsWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CloseAllMediaPresentations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("closeAllMediaPresentationsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("closeAllMediaPresentationsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task CloseAllMediaPresentationsAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			CloseAllMediaPresentations(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("createPDFWithConfiguration:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreatePdf (WKPdfConfiguration? pdfConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			var pdfConfiguration__handle__ = pdfConfiguration.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createPDFWithConfiguration:completionHandler:"), pdfConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("createPDFWithConfiguration:completionHandler:"), pdfConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pdfConfiguration);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> CreatePdfAsync (WKPdfConfiguration? pdfConfiguration)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			CreatePdf(pdfConfiguration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("createWebArchiveDataWithCompletionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateWebArchive ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("createWebArchiveDataWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("createWebArchiveDataWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> CreateWebArchiveAsync ()
		{
			var tcs = new TaskCompletionSource<NSData> ();
			CreateWebArchive((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("evaluateJavaScript:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateJavaScript (NSString javascript, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKJavascriptEvaluationResult))]WKJavascriptEvaluationResult? completionHandler)
		{
			var javascript__handle__ = javascript!.GetNonNullHandle (nameof (javascript));
			using var block_completionHandler = Trampolines.SDWKJavascriptEvaluationResult.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("evaluateJavaScript:completionHandler:"), javascript__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("evaluateJavaScript:completionHandler:"), javascript__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (javascript);
		}
		/// <param name="javascript">The JavaScript string to evaluate</param>
		/// <summary>Evaluates the given JavaScript string.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous EvaluateJavaScript operation.   The value of the TResult parameter is a <see cref="WebKit.WKJavascriptEvaluationResult" />.</para>
		///         </returns>
		/// <remarks>
		///           <para>This method will throw a <see cref="Foundation.NSErrorException" /> if the JavaScript is not evaluated successfully.</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// var result = await wk.EvaluateJavaScriptAsync(js); //== "bar"
		///     ]]></code>
		///           </example>
		///           <para>The EvaluateJavaScriptAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para>The arguments to the handler are an <see cref="Foundation.NSObject" /> containing the results of the evaluation and an <see cref="Foundation.NSError" /> if an error. If an error occurred, the <c>result</c> argument will be <see langword="null" />. If no error occurred, the <c>error</c> argument will be <see langword="null" />.</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// WKJavascriptEvaluationResult handler = (NSObject result, NSError err) => { 
		///   if(err is not null)
		///   {
		///     System.Console.WriteLine(err);
		///   }
		///   if(result is not null)
		///   {
		///      System.Console.WriteLine(result);
		///   }
		/// };
		/// wk.EvaluateJavaScript(js, handler);
		///     ]]></code>
		///           </example>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> EvaluateJavaScriptAsync (NSString javascript)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			EvaluateJavaScript(javascript, (result_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (result_!);
			});
			return tcs.Task;
		}
		/// <param name="javascript">To be added.</param><param name="completionHandler">To be added.</param><summary>Evaluates JavaScript and calls back into C# with the results.</summary><remarks><para>The system calls <paramref name="completionHandler" /> after evaluation. The arguments to the handler are an <see cref="T:Foundation.NSObject" /> containing the results of the evaluation and an <see cref="T:Foundation.NSError" /> if an error. If an error occurred, the <c>result</c> argument will be <see langword="null" />. If no error occurred, the <c>error</c> argument will be <see langword="null" />.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// WKJavascriptEvaluationResult handler = (NSObject result, NSError err) => { 
		/// if(err != null)
		/// {
		/// System.Console.WriteLine(err);
		/// }
		/// if(result != null)
		/// {
		/// System.Console.WriteLine(result);
		/// }
		/// };
		/// wk.EvaluateJavaScript(js, handler);
		/// ]]></code></example></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EvaluateJavaScript (string javascript, WKJavascriptEvaluationResult completionHandler)
		{
			EvaluateJavaScript ((NSString)javascript, completionHandler);
		}
		/// <param name="javascript">A well-formed JavaScript expression.</param>
		/// <summary>Evaluates the given JavaScript string.</summary>
		/// <returns>A task that represents the asynchronous EvaluateJavaScript operation. The TResult holds the results of the evaluation.</returns>
		/// <remarks>
		///           <para>This method will throw a <see cref="Foundation.NSErrorException" /> if the JavaScript is not evaluated successfully.</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// var result = await wk.EvaluateJavaScriptAsync(js); //== "bar"
		///     ]]></code>
		///           </example>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<NSObject> EvaluateJavaScriptAsync (string javascript)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			EvaluateJavaScript(javascript, (result_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (result_!);
			});
			return tcs.Task;
		}
		[Export ("evaluateJavaScript:inFrame:inContentWorld:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateJavaScript (string javaScriptString, WKFrameInfo? frame, WKContentWorld contentWorld, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V78))]global::System.Action<NSObject, NSError>? completionHandler)
		{
			if (javaScriptString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (javaScriptString));
			var frame__handle__ = frame.GetHandle ();
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			var nsjavaScriptString = CFString.CreateNative (javaScriptString);
			using var block_completionHandler = Trampolines.SDActionArity2V78.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("evaluateJavaScript:inFrame:inContentWorld:completionHandler:"), nsjavaScriptString, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("evaluateJavaScript:inFrame:inContentWorld:completionHandler:"), nsjavaScriptString, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (frame);
			GC.KeepAlive (contentWorld);
			CFString.ReleaseNative (nsjavaScriptString);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> EvaluateJavaScriptAsync (string javaScriptString, WKFrameInfo? frame, WKContentWorld contentWorld)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			EvaluateJavaScript(javaScriptString, frame, contentWorld, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchDataOfTypes:completionHandler:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchData (WKWebViewDataType dataTypes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebViewFetchDataHandler))]WKWebViewFetchDataHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebViewFetchDataHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("fetchDataOfTypes:completionHandler:"), (UIntPtr) (ulong) dataTypes, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("fetchDataOfTypes:completionHandler:"), (UIntPtr) (ulong) dataTypes, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> FetchDataAsync (WKWebViewDataType dataTypes)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			FetchData(dataTypes, (data_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (data_!);
			});
			return tcs.Task;
		}
		[Export ("findString:withConfiguration:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Find (string @string, WKFindConfiguration? configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<WKFindResult> completionHandler)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var configuration__handle__ = configuration.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsstring = CFString.CreateNative (@string);
			using var block_completionHandler = Trampolines.SDActionArity1V273.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("findString:withConfiguration:completionHandler:"), nsstring, configuration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("findString:withConfiguration:completionHandler:"), nsstring, configuration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
			CFString.ReleaseNative (nsstring);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKFindResult> FindAsync (string @string, WKFindConfiguration? configuration)
		{
			var tcs = new TaskCompletionSource<WKFindResult> ();
			Find(@string, configuration, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("goBack")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? GoBack ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("goBack")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("goBack")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("goForward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? GoForward ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("goForward")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("goForward")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("goToBackForwardListItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? GoTo (WKBackForwardListItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("goToBackForwardListItem:"), item__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("goToBackForwardListItem:"), item__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("handlesURLScheme:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandlesUrlScheme (string urlScheme)
		{
			if (urlScheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlScheme));
			var nsurlScheme = CFString.CreateNative (urlScheme);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("handlesURLScheme:"), nsurlScheme);
			CFString.ReleaseNative (nsurlScheme);
			return ret != 0;
		}
		[Export ("loadData:MIMEType:characterEncodingName:baseURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadData (NSData data, string mimeType, string characterEncodingName, NSUrl baseUrl)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			if (characterEncodingName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (characterEncodingName));
			var baseUrl__handle__ = baseUrl!.GetNonNullHandle (nameof (baseUrl));
			var nsmimeType = CFString.CreateNative (mimeType);
			var nscharacterEncodingName = CFString.CreateNative (characterEncodingName);
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadData:MIMEType:characterEncodingName:baseURL:"), data__handle__, nsmimeType, nscharacterEncodingName, baseUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadData:MIMEType:characterEncodingName:baseURL:"), data__handle__, nsmimeType, nscharacterEncodingName, baseUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmimeType);
			CFString.ReleaseNative (nscharacterEncodingName);
			return ret!;
		}
		[Export ("loadFileRequest:allowingReadAccessToURL:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation LoadFileRequest (NSUrlRequest request, NSUrl readAccessURL)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var readAccessURL__handle__ = readAccessURL!.GetNonNullHandle (nameof (readAccessURL));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadFileRequest:allowingReadAccessToURL:"), request__handle__, readAccessURL__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadFileRequest:allowingReadAccessToURL:"), request__handle__, readAccessURL__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (readAccessURL);
			return ret!;
		}
		[Export ("loadFileURL:allowingReadAccessToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadFileUrl (NSUrl url, NSUrl readAccessUrl)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var readAccessUrl__handle__ = readAccessUrl!.GetNonNullHandle (nameof (readAccessUrl));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadFileURL:allowingReadAccessToURL:"), url__handle__, readAccessUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadFileURL:allowingReadAccessToURL:"), url__handle__, readAccessUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (readAccessUrl);
			return ret!;
		}
		[Export ("loadHTMLString:baseURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadHtmlString (NSString htmlString, NSUrl? baseUrl)
		{
			var htmlString__handle__ = htmlString!.GetNonNullHandle (nameof (htmlString));
			var baseUrl__handle__ = baseUrl.GetHandle ();
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadHTMLString:baseURL:"), htmlString__handle__, baseUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadHTMLString:baseURL:"), htmlString__handle__, baseUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (htmlString);
			GC.KeepAlive (baseUrl);
			return ret!;
		}
		/// <param name="htmlString">To be added.</param><param name="baseUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKNavigation? LoadHtmlString (string htmlString, NSUrl baseUrl)
		{
			return LoadHtmlString ((NSString)htmlString, baseUrl);
		}
		[Export ("loadRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadRequest (NSUrlRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadRequest:"), request__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadRequest:"), request__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			return ret!;
		}
		[Export ("loadSimulatedRequest:response:responseData:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation LoadSimulatedRequest (NSUrlRequest request, NSUrlResponse response, NSData data)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadSimulatedRequest:response:responseData:"), request__handle__, response__handle__, data__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadSimulatedRequest:response:responseData:"), request__handle__, response__handle__, data__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (response);
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("loadSimulatedRequest:responseHTMLString:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation LoadSimulatedRequest (NSUrlRequest request, string htmlString)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (htmlString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (htmlString));
			var nshtmlString = CFString.CreateNative (htmlString);
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadSimulatedRequest:responseHTMLString:"), request__handle__, nshtmlString), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadSimulatedRequest:responseHTMLString:"), request__handle__, nshtmlString), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			CFString.ReleaseNative (nshtmlString);
			return ret!;
		}
		[Export ("reload")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? Reload ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reload")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reload")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("reloadFromOrigin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? ReloadFromOrigin ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reloadFromOrigin")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reloadFromOrigin")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("requestMediaPlaybackStateWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestMediaPlaybackState ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V274))]global::System.Action<WKMediaPlaybackState> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V274.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("requestMediaPlaybackStateWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("requestMediaPlaybackStateWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKMediaPlaybackState> RequestMediaPlaybackStateAsync ()
		{
			var tcs = new TaskCompletionSource<WKMediaPlaybackState> ();
			RequestMediaPlaybackState((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("restoreData:completionHandler:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreData (NSData data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebViewRestoreDataHandler))]WKWebViewRestoreDataHandler completionHandler)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebViewRestoreDataHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("restoreData:completionHandler:"), data__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("restoreData:completionHandler:"), data__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RestoreDataAsync (NSData data)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RestoreData(data, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("resumeDownloadFromResumeData:completionHandler:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResumeDownload (NSData resumeData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V275))]global::System.Action<WKDownload> completionHandler)
		{
			var resumeData__handle__ = resumeData!.GetNonNullHandle (nameof (resumeData));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V275.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resumeDownloadFromResumeData:completionHandler:"), resumeData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("resumeDownloadFromResumeData:completionHandler:"), resumeData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resumeData);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKDownload> ResumeDownloadAsync (NSData resumeData)
		{
			var tcs = new TaskCompletionSource<WKDownload> ();
			ResumeDownload(resumeData, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("setAllMediaPlaybackSuspended:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetAllMediaPlaybackSuspended (bool suspended, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, Selector.GetHandle ("setAllMediaPlaybackSuspended:completionHandler:"), suspended ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("setAllMediaPlaybackSuspended:completionHandler:"), suspended ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetAllMediaPlaybackSuspendedAsync (bool suspended)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetAllMediaPlaybackSuspended(suspended, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setCameraCaptureState:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetCameraCaptureState (WKMediaCaptureState state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setCameraCaptureState:completionHandler:"), (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("setCameraCaptureState:completionHandler:"), (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetCameraCaptureStateAsync (WKMediaCaptureState state)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetCameraCaptureState(state, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setMicrophoneCaptureState:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetMicrophoneCaptureState (WKMediaCaptureState state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setMicrophoneCaptureState:completionHandler:"), (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("setMicrophoneCaptureState:completionHandler:"), (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetMicrophoneCaptureStateAsync (WKMediaCaptureState state)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetMicrophoneCaptureState(state, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setMinimumViewportInset:maximumViewportInset:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewportInsets (global::UIKit.UIEdgeInsets minimumViewportInset, global::UIKit.UIEdgeInsets maximumViewportInset)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets_UIEdgeInsets (this.Handle, Selector.GetHandle ("setMinimumViewportInset:maximumViewportInset:"), minimumViewportInset, maximumViewportInset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setMinimumViewportInset:maximumViewportInset:"), minimumViewportInset, maximumViewportInset);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startDownloadUsingRequest:completionHandler:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartDownload (NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V275))]global::System.Action<WKDownload> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V275.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("startDownloadUsingRequest:completionHandler:"), request__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("startDownloadUsingRequest:completionHandler:"), request__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKDownload> StartDownloadAsync (NSUrlRequest request)
		{
			var tcs = new TaskCompletionSource<WKDownload> ();
			StartDownload(request, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("stopLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopLoading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopLoading"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stopLoading"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("takeSnapshotWithConfiguration:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TakeSnapshot (WKSnapshotConfiguration? snapshotConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V175))]global::System.Action<global::UIKit.UIImage, NSError> completionHandler)
		{
			var snapshotConfiguration__handle__ = snapshotConfiguration.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V175.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("takeSnapshotWithConfiguration:completionHandler:"), snapshotConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("takeSnapshotWithConfiguration:completionHandler:"), snapshotConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (snapshotConfiguration);
		}
		/// <param name="snapshotConfiguration">The snapshot configuration to use.This parameter can be .</param>
		/// <summary>Asynchronously takes a snapshot of the current viewport.</summary>
		/// <returns>
		///           <para>The result is of type System.Tasks.Task&lt;AppKit.NSImage&gt; on MacOS and System.Tasks.Task&lt;UIKit.UIImage&gt; on iOS.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The TakeSnapshotAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::UIKit.UIImage> TakeSnapshotAsync (WKSnapshotConfiguration? snapshotConfiguration)
		{
			var tcs = new TaskCompletionSource<global::UIKit.UIImage> ();
			TakeSnapshot(snapshotConfiguration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("pauseAllMediaPlaybackWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _NewPauseAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pauseAllMediaPlaybackWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pauseAllMediaPlaybackWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _NewPauseAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_NewPauseAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("closeAllMediaPresentations")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _OldCloseAllMediaPresentations ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("closeAllMediaPresentations"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("closeAllMediaPresentations"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("pauseAllMediaPlayback:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _OldPauseAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pauseAllMediaPlayback:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pauseAllMediaPlayback:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _OldPauseAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_OldPauseAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("resumeAllMediaPlayback:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _OldResumeAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("resumeAllMediaPlayback:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("resumeAllMediaPlayback:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _OldResumeAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_OldResumeAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("suspendAllMediaPlayback:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _OldSuspendAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("suspendAllMediaPlayback:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("suspendAllMediaPlayback:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _OldSuspendAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_OldSuspendAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsBackForwardNavigationGestures {
			[Export ("allowsBackForwardNavigationGestures")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsBackForwardNavigationGestures"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsBackForwardNavigationGestures"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsBackForwardNavigationGestures:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsBackForwardNavigationGestures:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsBackForwardNavigationGestures:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsLinkPreview {
			[Export ("allowsLinkPreview")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsLinkPreview"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsLinkPreview"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsLinkPreview:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsLinkPreview:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsLinkPreview:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKBackForwardList BackForwardList {
			[Export ("backForwardList", ArgumentSemantic.Retain)]
			get {
				WKBackForwardList? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKBackForwardList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("backForwardList")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKBackForwardList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("backForwardList")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual WKMediaCaptureState CameraCaptureState {
			[Export ("cameraCaptureState")]
			get {
				WKMediaCaptureState ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraCaptureState"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraCaptureState"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoBack {
			[Export ("canGoBack")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canGoBack"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canGoBack"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoForward {
			[Export ("canGoForward")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canGoForward"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canGoForward"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'ServerTrust' property.")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'ServerTrust' property.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ServerTrust' property.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Security.SecCertificate[] CertificateChain {
			[Export ("certificateChain", ArgumentSemantic.Copy)]
			get {
				global::Security.SecCertificate[] ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::Security.SecCertificate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("certificateChain")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::Security.SecCertificate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("certificateChain")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebViewConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				WKWebViewConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKWebViewConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKWebViewConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configuration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? CustomUserAgent {
			[Export ("customUserAgent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customUserAgent")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("customUserAgent")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomUserAgent:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomUserAgent:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCustomUserAgent:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EstimatedProgress {
			[Export ("estimatedProgress")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("estimatedProgress"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("estimatedProgress"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual global::UIKit.UIFindInteraction? FindInteraction {
			[Export ("findInteraction")]
			get {
				global::UIKit.UIFindInteraction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFindInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("findInteraction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIFindInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("findInteraction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual bool FindInteractionEnabled {
			[Export ("isFindInteractionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFindInteractionEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isFindInteractionEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFindInteractionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFindInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setFindInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual WKFullscreenState FullscreenState {
			[Export ("fullscreenState")]
			get {
				WKFullscreenState ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKFullscreenState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fullscreenState"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKFullscreenState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fullscreenState"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasOnlySecureContent {
			[Export ("hasOnlySecureContent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasOnlySecureContent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasOnlySecureContent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("ios16.4")]
		[UnsupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? InteractionState {
			[Export ("interactionState", ArgumentSemantic.Copy)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("interactionState")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("interactionState")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInteractionState:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInteractionState:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInteractionState:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool IsBlockedByScreenTime {
			[Export ("isBlockedByScreenTime")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBlockedByScreenTime"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isBlockedByScreenTime"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>A Boolean value indicating whether the view is currently loading content.</summary><value><para /></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLoading {
			[Export ("isLoading")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLoading"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isLoading"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual global::UIKit.UIEdgeInsets MaximumViewportInset {
			[Export ("maximumViewportInset")]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("maximumViewportInset"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("maximumViewportInset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumViewportInset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("maximumViewportInset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? MediaType {
			[Export ("mediaType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediaType")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mediaType")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMediaType:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMediaType:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMediaType:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual WKMediaCaptureState MicrophoneCaptureState {
			[Export ("microphoneCaptureState")]
			get {
				WKMediaCaptureState ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("microphoneCaptureState"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("microphoneCaptureState"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual global::UIKit.UIEdgeInsets MinimumViewportInset {
			[Export ("minimumViewportInset")]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("minimumViewportInset"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("minimumViewportInset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumViewportInset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("minimumViewportInset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>The web view's navigation delegate.</summary><value><para>This value can be <see langword="null" />.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para></para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWKNavigationDelegate NavigationDelegate {
			get {
				return (WeakNavigationDelegate as IWKNavigationDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakNavigationDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual global::UIKit.UIEdgeInsets ObscuredContentInsets {
			[Export ("obscuredContentInsets", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("obscuredContentInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("obscuredContentInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("obscuredContentInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("obscuredContentInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setObscuredContentInsets:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setObscuredContentInsets:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setObscuredContentInsets:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nfloat PageZoom {
			[Export ("pageZoom")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pageZoom"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pageZoom"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPageZoom:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPageZoom:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPageZoom:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual global::UIKit.UIScrollView ScrollView {
			[Export ("scrollView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIScrollView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("scrollView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("scrollView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Security.SecTrust? ServerTrust {
			[Export ("serverTrust")]
			get {
				global::Security.SecTrust ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::Security.SecTrust> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("serverTrust")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Security.SecTrust> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("serverTrust")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIColor? ThemeColor {
			[Export ("themeColor")]
			get {
				global::UIKit.UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("themeColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("themeColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("title")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The web view's user interface delegate. </summary><value><para>This value can be <see langword="null" />.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para></para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWKUIDelegate UIDelegate {
			get {
				return (WeakUIDelegate as IWKUIDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakUIDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIColor? UnderPageBackgroundColor {
			[Export ("underPageBackgroundColor", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("underPageBackgroundColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("underPageBackgroundColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUnderPageBackgroundColor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUnderPageBackgroundColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setUnderPageBackgroundColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? Url {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("URL")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("URL")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakNavigationDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakNavigationDelegate {
			[Export ("navigationDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("navigationDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("navigationDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakNavigationDelegate_var = ret;
				return ret!;
			}
			[Export ("setNavigationDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNavigationDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setNavigationDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakNavigationDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakUIDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakUIDelegate {
			[Export ("UIDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("UIDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("UIDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakUIDelegate_var = ret;
				return ret!;
			}
			[Export ("setUIDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUIDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setUIDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakUIDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool WritingToolsActive {
			[Export ("isWritingToolsActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isWritingToolsActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isWritingToolsActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakNavigationDelegate_var = null;
				__mt_WeakUIDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::WebKit.WKWebView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::WebKit.WKWebView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::WebKit.WKWebView.Appearance" /> property or by calling <see cref="global::WebKit.WKWebView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class WKWebViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal WKWebViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::WebKit.WKWebView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::WebKit.WKWebView" />, they should use the <see cref="global::WebKit.WKWebView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new WKWebViewAppearance Appearance {
			get { return new WKWebViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::WebKit.WKWebView.WKWebViewAppearance" /> for the subclass of <see cref="global::WebKit.WKWebView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::WebKit.WKWebView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::WebKit.WKWebView.Appearance" /> property, or the <see cref="global::WebKit.WKWebView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = WKWebView.GetAppearance<MyWKWebViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new WKWebViewAppearance GetAppearance<T> () where T: WKWebView {
			return new WKWebViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::WebKit.WKWebView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::WebKit.WKWebView" />, they should use the <see cref="global::WebKit.WKWebView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new WKWebViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new WKWebViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::WebKit.WKWebView.WKWebViewAppearance" /> for <see cref="global::WebKit.WKWebView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = WKWebView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::WebKit.WKWebView" />, they should use the <see cref="global::WebKit.WKWebView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new WKWebViewAppearance GetAppearance (UITraitCollection traits) {
			return new WKWebViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::WebKit.WKWebView.WKWebViewAppearance" /> for <see cref="global::WebKit.WKWebView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = WKWebView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::WebKit.WKWebView" />, they should use the <see cref="global::WebKit.WKWebView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new WKWebViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new WKWebViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::WebKit.WKWebView.WKWebViewAppearance" /> for the subclass of <see cref="global::WebKit.WKWebView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::WebKit.WKWebView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::WebKit.WKWebView.Appearance" /> property, or the <see cref="global::WebKit.WKWebView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = WKWebView.GetAppearance<MyWKWebViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new WKWebViewAppearance GetAppearance<T> (UITraitCollection traits) where T: WKWebView {
			return new WKWebViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::WebKit.WKWebView.WKWebViewAppearance" /> for the subclass of <see cref="global::WebKit.WKWebView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::WebKit.WKWebView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::WebKit.WKWebView.Appearance" /> property, or the <see cref="global::WebKit.WKWebView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = WKWebView.GetAppearance<MyWKWebViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new WKWebViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: WKWebView{
			return new WKWebViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class WKWebView */
}
