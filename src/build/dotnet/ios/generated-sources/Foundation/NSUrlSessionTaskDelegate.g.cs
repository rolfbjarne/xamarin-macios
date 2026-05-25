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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLSessionTaskDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSURLSessionTaskDelegate", WrapperType = typeof (NSUrlSessionTaskDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformHttpRedirection", Selector = "URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (NSHttpUrlResponse), typeof (NSUrlRequest), typeof (global::System.Action<NSUrlRequest>) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V3) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveChallenge", Selector = "URLSession:task:didReceiveChallenge:completionHandler:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (NSUrlAuthenticationChallenge), typeof (global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V11) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedNewBodyStream", Selector = "URLSession:task:needNewBodyStream:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (global::System.Action<NSInputStream>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSendBodyData", Selector = "URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (long), typeof (long), typeof (long) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteWithError", Selector = "URLSession:task:didCompleteWithError:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishCollectingMetrics", Selector = "URLSession:task:didFinishCollectingMetrics:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (NSUrlSessionTaskMetrics) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginDelayedRequest", Selector = "URLSession:task:willBeginDelayedRequest:completionHandler:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (NSUrlRequest), typeof (global::System.Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V12) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TaskIsWaitingForConnectivity", Selector = "URLSession:taskIsWaitingForConnectivity:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCreateTask", Selector = "URLSession:didCreateTask:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveInformationalResponse", Selector = "URLSession:task:didReceiveInformationalResponse:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (NSHttpUrlResponse) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedNewBodyStream", Selector = "URLSession:task:needNewBodyStreamFromOffset:completionHandler:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionTask), typeof (long), typeof (global::System.Action<NSInputStream>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	public partial interface INSUrlSessionTaskDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlSessionDelegate
	{
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="response">To be added.</param><param name="newRequest">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPerformHttpRedirection (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<NSUrlRequest> completionHandler)
		{
			_WillPerformHttpRedirection (this, session, task, response, newRequest, completionHandler);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="response">To be added.</param><param name="newRequest">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillPerformHttpRedirection (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<NSUrlRequest> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var newRequest__handle__ = newRequest!.GetNonNullHandle (nameof (newRequest));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V3.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:"), session__handle__, task__handle__, response__handle__, newRequest__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (response);
			GC.KeepAlive (newRequest);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:didReceiveChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveChallenge (NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			_DidReceiveChallenge (this, session, task, challenge, completionHandler);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveChallenge (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V11.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didReceiveChallenge:completionHandler:"), session__handle__, task__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (challenge);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:needNewBodyStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NeedNewBodyStream (NSUrlSession session, NSUrlSessionTask task, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			_NeedNewBodyStream (this, session, task, completionHandler);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _NeedNewBodyStream (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:needNewBodyStream:"), session__handle__, task__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="bytesSent">To be added.</param><param name="totalBytesSent">To be added.</param><param name="totalBytesExpectedToSend">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSendBodyData (NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
		{
			_DidSendBodyData (this, session, task, bytesSent, totalBytesSent, totalBytesExpectedToSend);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="bytesSent">To be added.</param><param name="totalBytesSent">To be added.</param><param name="totalBytesExpectedToSend">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSendBodyData (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:"), session__handle__, task__handle__, bytesSent, totalBytesSent, totalBytesExpectedToSend);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:didCompleteWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteWithError (NSUrlSession session, NSUrlSessionTask task, NSError? error)
		{
			_DidCompleteWithError (this, session, task, error);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteWithError (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didCompleteWithError:"), session__handle__, task__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="metrics">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:didFinishCollectingMetrics:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishCollectingMetrics (NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
		{
			_DidFinishCollectingMetrics (this, session, task, metrics);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="metrics">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishCollectingMetrics (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var metrics__handle__ = metrics!.GetNonNullHandle (nameof (metrics));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didFinishCollectingMetrics:"), session__handle__, task__handle__, metrics__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (metrics);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="request">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:willBeginDelayedRequest:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillBeginDelayedRequest (NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V12))]global::System.Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
		{
			_WillBeginDelayedRequest (this, session, task, request, completionHandler);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="request">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillBeginDelayedRequest (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V12))]global::System.Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V12.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:willBeginDelayedRequest:completionHandler:"), session__handle__, task__handle__, request__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (request);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:taskIsWaitingForConnectivity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TaskIsWaitingForConnectivity (NSUrlSession session, NSUrlSessionTask task)
		{
			_TaskIsWaitingForConnectivity (this, session, task);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TaskIsWaitingForConnectivity (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:taskIsWaitingForConnectivity:"), session__handle__, task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:didCreateTask:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateTask (NSUrlSession session, NSUrlSessionTask task)
		{
			_DidCreateTask (this, session, task);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCreateTask (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:didCreateTask:"), session__handle__, task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:didReceiveInformationalResponse:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveInformationalResponse (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response)
		{
			_DidReceiveInformationalResponse (this, session, task, response);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveInformationalResponse (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didReceiveInformationalResponse:"), session__handle__, task__handle__, response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (response);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:task:needNewBodyStreamFromOffset:completionHandler:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NeedNewBodyStream (NSUrlSession session, NSUrlSessionTask task, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			_NeedNewBodyStream (this, session, task, offset, completionHandler);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _NeedNewBodyStream (INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:needNewBodyStreamFromOffset:completionHandler:"), session__handle__, task__handle__, offset, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		[DynamicDependencyAttribute ("DidCompleteWithError(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidCreateTask(Foundation.NSUrlSession,Foundation.NSUrlSessionTask)")]
		[DynamicDependencyAttribute ("DidFinishCollectingMetrics(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,Foundation.NSUrlSessionTaskMetrics)")]
		[DynamicDependencyAttribute ("DidReceiveChallenge(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})")]
		[DynamicDependencyAttribute ("DidReceiveInformationalResponse(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,Foundation.NSHttpUrlResponse)")]
		[DynamicDependencyAttribute ("DidSendBodyData(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,System.Int64,System.Int64,System.Int64)")]
		[DynamicDependencyAttribute ("NeedNewBodyStream(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,System.Action{Foundation.NSInputStream})")]
		[DynamicDependencyAttribute ("NeedNewBodyStream(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,System.Int64,System.Action{Foundation.NSInputStream})")]
		[DynamicDependencyAttribute ("TaskIsWaitingForConnectivity(Foundation.NSUrlSession,Foundation.NSUrlSessionTask)")]
		[DynamicDependencyAttribute ("WillBeginDelayedRequest(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,Foundation.NSUrlRequest,System.Action{Foundation.NSUrlSessionDelayedRequestDisposition,Foundation.NSUrlRequest})")]
		[DynamicDependencyAttribute ("WillPerformHttpRedirection(Foundation.NSUrlSession,Foundation.NSUrlSessionTask,Foundation.NSHttpUrlResponse,Foundation.NSUrlRequest,System.Action{Foundation.NSUrlRequest})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionTaskDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlSessionTaskDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlSessionTaskDelegate" /> interface to support all the methods from the NSURLSessionTaskDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlSessionTaskDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLSessionTaskDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlSessionTaskDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="response">To be added.</param><param name="newRequest">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillPerformHttpRedirection (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<NSUrlRequest> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var newRequest__handle__ = newRequest!.GetNonNullHandle (nameof (newRequest));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V3.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:"), session__handle__, task__handle__, response__handle__, newRequest__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (response);
			GC.KeepAlive (newRequest);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveChallenge (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V11.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didReceiveChallenge:completionHandler:"), session__handle__, task__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (challenge);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void NeedNewBodyStream (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:needNewBodyStream:"), session__handle__, task__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="bytesSent">To be added.</param><param name="totalBytesSent">To be added.</param><param name="totalBytesExpectedToSend">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSendBodyData (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:"), session__handle__, task__handle__, bytesSent, totalBytesSent, totalBytesExpectedToSend);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteWithError (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didCompleteWithError:"), session__handle__, task__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (error);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="metrics">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishCollectingMetrics (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var metrics__handle__ = metrics!.GetNonNullHandle (nameof (metrics));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didFinishCollectingMetrics:"), session__handle__, task__handle__, metrics__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (metrics);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="request">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillBeginDelayedRequest (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V12))]global::System.Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V12.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:willBeginDelayedRequest:completionHandler:"), session__handle__, task__handle__, request__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (request);
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TaskIsWaitingForConnectivity (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:taskIsWaitingForConnectivity:"), session__handle__, task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCreateTask (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:didCreateTask:"), session__handle__, task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveInformationalResponse (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:didReceiveInformationalResponse:"), session__handle__, task__handle__, response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
			GC.KeepAlive (response);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void NeedNewBodyStream (this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:task:needNewBodyStreamFromOffset:completionHandler:"), session__handle__, task__handle__, offset, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (task);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlSessionTaskDelegateWrapper : BaseWrapper, INSUrlSessionTaskDelegate {
		public NSUrlSessionTaskDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionTaskDelegateWrapper))]
		static NSUrlSessionTaskDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlSessionTaskDelegate" /> (for the protocol <c>NSURLSessionTaskDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlSessionTaskDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__Foundation_NSUrlSessionTaskDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUrlSessionTaskDelegate : NSUrlSessionDelegate, INSUrlSessionTaskDelegate {
		/// <summary>Creates a new <see cref="NSUrlSessionTaskDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlSessionTaskDelegate () : base (NSObjectFlag.Empty)
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
		protected NSUrlSessionTaskDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlSessionTaskDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didCompleteWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteWithError (NSUrlSession session, NSUrlSessionTask task, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:didCreateTask:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateTask (NSUrlSession session, NSUrlSessionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="metrics">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didFinishCollectingMetrics:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishCollectingMetrics (NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didReceiveChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveChallenge (NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:task:didReceiveInformationalResponse:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveInformationalResponse (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="bytesSent">To be added.</param><param name="totalBytesSent">To be added.</param><param name="totalBytesExpectedToSend">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSendBodyData (NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:needNewBodyStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NeedNewBodyStream (NSUrlSession session, NSUrlSessionTask task, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:task:needNewBodyStreamFromOffset:completionHandler:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NeedNewBodyStream (NSUrlSession session, NSUrlSessionTask task, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSInputStream> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:taskIsWaitingForConnectivity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TaskIsWaitingForConnectivity (NSUrlSession session, NSUrlSessionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="request">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:willBeginDelayedRequest:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillBeginDelayedRequest (NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V12))]global::System.Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="response">To be added.</param><param name="newRequest">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPerformHttpRedirection (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<NSUrlRequest> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlSessionTaskDelegate */
}
