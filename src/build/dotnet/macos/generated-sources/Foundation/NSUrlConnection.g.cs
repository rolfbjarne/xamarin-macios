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
namespace Foundation {
	[Register("NSURLConnection", true)]
	public unsafe partial class NSUrlConnection : NSObject, INSUrlAuthenticationChallengeSender {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanHandleRequest_X = "canHandleRequest:";
		static readonly NativeHandle selCanHandleRequest_XHandle = Selector.GetHandle ("canHandleRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelAuthenticationChallenge_X = "cancelAuthenticationChallenge:";
		static readonly NativeHandle selCancelAuthenticationChallenge_XHandle = Selector.GetHandle ("cancelAuthenticationChallenge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectionWithRequest_Delegate_X = "connectionWithRequest:delegate:";
		static readonly NativeHandle selConnectionWithRequest_Delegate_XHandle = Selector.GetHandle ("connectionWithRequest:delegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContinueWithoutCredentialForAuthenticationChallenge_X = "continueWithoutCredentialForAuthenticationChallenge:";
		static readonly NativeHandle selContinueWithoutCredentialForAuthenticationChallenge_XHandle = Selector.GetHandle ("continueWithoutCredentialForAuthenticationChallenge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRequest_Delegate_X = "initWithRequest:delegate:";
		static readonly NativeHandle selInitWithRequest_Delegate_XHandle = Selector.GetHandle ("initWithRequest:delegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRequest_Delegate_StartImmediately_X = "initWithRequest:delegate:startImmediately:";
		static readonly NativeHandle selInitWithRequest_Delegate_StartImmediately_XHandle = Selector.GetHandle ("initWithRequest:delegate:startImmediately:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformDefaultHandlingForAuthenticationChallenge_X = "performDefaultHandlingForAuthenticationChallenge:";
		static readonly NativeHandle selPerformDefaultHandlingForAuthenticationChallenge_XHandle = Selector.GetHandle ("performDefaultHandlingForAuthenticationChallenge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRejectProtectionSpaceAndContinueWithChallenge_X = "rejectProtectionSpaceAndContinueWithChallenge:";
		static readonly NativeHandle selRejectProtectionSpaceAndContinueWithChallenge_XHandle = Selector.GetHandle ("rejectProtectionSpaceAndContinueWithChallenge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleInRunLoop_ForMode_X = "scheduleInRunLoop:forMode:";
		static readonly NativeHandle selScheduleInRunLoop_ForMode_XHandle = Selector.GetHandle ("scheduleInRunLoop:forMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendAsynchronousRequest_Queue_CompletionHandler_X = "sendAsynchronousRequest:queue:completionHandler:";
		static readonly NativeHandle selSendAsynchronousRequest_Queue_CompletionHandler_XHandle = Selector.GetHandle ("sendAsynchronousRequest:queue:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendSynchronousRequest_ReturningResponse_Error_X = "sendSynchronousRequest:returningResponse:error:";
		static readonly NativeHandle selSendSynchronousRequest_ReturningResponse_Error_XHandle = Selector.GetHandle ("sendSynchronousRequest:returningResponse:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegateQueue_X = "setDelegateQueue:";
		static readonly NativeHandle selSetDelegateQueue_XHandle = Selector.GetHandle ("setDelegateQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartX = "start";
		static readonly NativeHandle selStartXHandle = Selector.GetHandle ("start");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnscheduleFromRunLoop_ForMode_X = "unscheduleFromRunLoop:forMode:";
		static readonly NativeHandle selUnscheduleFromRunLoop_ForMode_XHandle = Selector.GetHandle ("unscheduleFromRunLoop:forMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseCredential_ForAuthenticationChallenge_X = "useCredential:forAuthenticationChallenge:";
		static readonly NativeHandle selUseCredential_ForAuthenticationChallenge_XHandle = Selector.GetHandle ("useCredential:forAuthenticationChallenge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSURLConnection");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSUrlConnection" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlConnection () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected NSUrlConnection (NSObjectFlag t) : base (t)
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
		protected internal NSUrlConnection (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithRequest:delegate:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlSession' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrlConnection (NSUrlRequest request, INSUrlConnectionDelegate? connectionDelegate)
			: base (NSObjectFlag.Empty)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var connectionDelegate__handle__ = connectionDelegate.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithRequest_Delegate_XHandle, request__handle__, connectionDelegate__handle__), "initWithRequest:delegate:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithRequest_Delegate_XHandle, request__handle__, connectionDelegate__handle__), "initWithRequest:delegate:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (connectionDelegate);
		}
		[Export ("initWithRequest:delegate:startImmediately:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlSession' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrlConnection (NSUrlRequest request, INSUrlConnectionDelegate? connectionDelegate, bool startImmediately)
			: base (NSObjectFlag.Empty)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var connectionDelegate__handle__ = connectionDelegate.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selInitWithRequest_Delegate_StartImmediately_XHandle, request__handle__, connectionDelegate__handle__, startImmediately ? (byte) 1 : (byte) 0), "initWithRequest:delegate:startImmediately:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selInitWithRequest_Delegate_StartImmediately_XHandle, request__handle__, connectionDelegate__handle__, startImmediately ? (byte) 1 : (byte) 0), "initWithRequest:delegate:startImmediately:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (connectionDelegate);
		}
		[Export ("canHandleRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanHandleRequest (NSUrlRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanHandleRequest_XHandle, request__handle__);
			GC.KeepAlive (request);
			return ret != 0;
		}
		[Export ("cancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelAuthenticationChallenge (NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCancelAuthenticationChallenge_XHandle, challenge__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCancelAuthenticationChallenge_XHandle, challenge__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (challenge);
		}
		[Export ("continueWithoutCredentialForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueWithoutCredential (NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selContinueWithoutCredentialForAuthenticationChallenge_XHandle, challenge__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selContinueWithoutCredentialForAuthenticationChallenge_XHandle, challenge__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (challenge);
		}
		[Export ("connectionWithRequest:delegate:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlSession' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlSession' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrlConnection? FromRequest (NSUrlRequest request, INSUrlConnectionDelegate? connectionDelegate)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var connectionDelegate__handle__ = connectionDelegate.GetHandle ();
			NSUrlConnection? ret;
			ret =  Runtime.GetNSObject<NSUrlConnection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selConnectionWithRequest_Delegate_XHandle, request__handle__, connectionDelegate__handle__), false)!;
			GC.KeepAlive (request);
			GC.KeepAlive (connectionDelegate);
			return ret!;
		}
		[Export ("performDefaultHandlingForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDefaultHandling (NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformDefaultHandlingForAuthenticationChallenge_XHandle, challenge__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformDefaultHandlingForAuthenticationChallenge_XHandle, challenge__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (challenge);
		}
		[Export ("rejectProtectionSpaceAndContinueWithChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RejectProtectionSpaceAndContinue (NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRejectProtectionSpaceAndContinueWithChallenge_XHandle, challenge__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRejectProtectionSpaceAndContinueWithChallenge_XHandle, challenge__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (challenge);
		}
		[Export ("scheduleInRunLoop:forMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Schedule (NSRunLoop aRunLoop, NSString forMode)
		{
			var aRunLoop__handle__ = aRunLoop!.GetNonNullHandle (nameof (aRunLoop));
			var forMode__handle__ = forMode!.GetNonNullHandle (nameof (forMode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selScheduleInRunLoop_ForMode_XHandle, aRunLoop__handle__, forMode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selScheduleInRunLoop_ForMode_XHandle, aRunLoop__handle__, forMode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aRunLoop);
			GC.KeepAlive (forMode);
		}
		/// <param name="aRunLoop">To be added.</param><param name="forMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Schedule (NSRunLoop aRunLoop, NSRunLoopMode forMode)
		{
			Schedule (aRunLoop, forMode.GetConstant ()!);
		}
		[Export ("sendAsynchronousRequest:queue:completionHandler:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SendAsynchronousRequest (NSUrlRequest request, NSOperationQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSUrlConnectionDataResponse))]NSUrlConnectionDataResponse completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSUrlConnectionDataResponse.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selSendAsynchronousRequest_Queue_CompletionHandler_XHandle, request__handle__, queue__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (request);
			GC.KeepAlive (queue);
		}
		/// <param name="request">Request to perform</param>
		/// <param name="queue">Operation queue to dispatch the completion to.</param>
		/// <summary>Loads the data and invokes a method upon completion.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous SendAsynchronousRequest operation. The value of the TResult parameter is of type <c>Action&lt;Foundation.NSUrlAsyncResult&gt;</c>.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The SendRequestAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlSession.CreateDataTask' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSUrlAsyncResult> SendRequestAsync (NSUrlRequest request, NSOperationQueue queue)
		{
			var tcs = new TaskCompletionSource<NSUrlAsyncResult> ();
			SendAsynchronousRequest(request, queue, (response_, data_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSUrlAsyncResult (response_!, data_!));
			});
			return tcs.Task;
		}
		[Export ("sendSynchronousRequest:returningResponse:error:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlSession' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlSession' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlSession' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? SendSynchronousRequest (NSUrlRequest request, out NSUrlResponse response, out NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle responseValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle_ref_NativeHandle (class_ptr, selSendSynchronousRequest_ReturningResponse_Error_XHandle, request__handle__, &responseValue, &errorValue), false)!;
			GC.KeepAlive (request);
			response = Runtime.GetNSObject<NSUrlResponse> (responseValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("setDelegateQueue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDelegateQueue (NSOperationQueue queue)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegateQueue_XHandle, queue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegateQueue_XHandle, queue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (queue);
		}
		[Export ("start")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Start ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unscheduleFromRunLoop:forMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Unschedule (NSRunLoop aRunLoop, NSString forMode)
		{
			var aRunLoop__handle__ = aRunLoop!.GetNonNullHandle (nameof (aRunLoop));
			var forMode__handle__ = forMode!.GetNonNullHandle (nameof (forMode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selUnscheduleFromRunLoop_ForMode_XHandle, aRunLoop__handle__, forMode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selUnscheduleFromRunLoop_ForMode_XHandle, aRunLoop__handle__, forMode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aRunLoop);
			GC.KeepAlive (forMode);
		}
		/// <param name="aRunLoop">To be added.</param><param name="forMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Unschedule (NSRunLoop aRunLoop, NSRunLoopMode forMode)
		{
			Unschedule (aRunLoop, forMode.GetConstant ()!);
		}
		[Export ("useCredential:forAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseCredential (NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
		{
			var credential__handle__ = credential!.GetNonNullHandle (nameof (credential));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selUseCredential_ForAuthenticationChallenge_XHandle, credential__handle__, challenge__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selUseCredential_ForAuthenticationChallenge_XHandle, credential__handle__, challenge__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (credential);
			GC.KeepAlive (challenge);
		}
	} /* class NSUrlConnection */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class NSUrlAsyncResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSUrlResponse Response { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Data { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="response">Result value from an asynchronous operation.</param>
		/// <param name="data">Result value from an asynchronous operation.</param>
		public NSUrlAsyncResult (NSUrlResponse response, NSData data) {
			this.Response = response;
			this.Data = data;
			Initialize ();
		}
	}
}
