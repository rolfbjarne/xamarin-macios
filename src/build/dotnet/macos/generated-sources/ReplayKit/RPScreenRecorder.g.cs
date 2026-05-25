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
namespace ReplayKit {
	/// <summary>Enables the user to record visual and audio output of applications, with simultaneous recorded audio (screencasts).</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ReplayKit/Reference/RPScreenRecorder_Ref/index.html">Apple documentation for <c>RPScreenRecorder</c></related>
	[Register("RPScreenRecorder", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe sealed partial class RPScreenRecorder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraPositionX = "cameraPosition";
		static readonly NativeHandle selCameraPositionXHandle = Selector.GetHandle ("cameraPosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraPreviewViewX = "cameraPreviewView";
		static readonly NativeHandle selCameraPreviewViewXHandle = Selector.GetHandle ("cameraPreviewView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscardRecordingWithHandler_X = "discardRecordingWithHandler:";
		static readonly NativeHandle selDiscardRecordingWithHandler_XHandle = Selector.GetHandle ("discardRecordingWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportClipToURL_Duration_CompletionHandler_X = "exportClipToURL:duration:completionHandler:";
		static readonly NativeHandle selExportClipToURL_Duration_CompletionHandler_XHandle = Selector.GetHandle ("exportClipToURL:duration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAvailableX = "isAvailable";
		static readonly NativeHandle selIsAvailableXHandle = Selector.GetHandle ("isAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCameraEnabledX = "isCameraEnabled";
		static readonly NativeHandle selIsCameraEnabledXHandle = Selector.GetHandle ("isCameraEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMicrophoneEnabledX = "isMicrophoneEnabled";
		static readonly NativeHandle selIsMicrophoneEnabledXHandle = Selector.GetHandle ("isMicrophoneEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRecordingX = "isRecording";
		static readonly NativeHandle selIsRecordingXHandle = Selector.GetHandle ("isRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraEnabled_X = "setCameraEnabled:";
		static readonly NativeHandle selSetCameraEnabled_XHandle = Selector.GetHandle ("setCameraEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraPosition_X = "setCameraPosition:";
		static readonly NativeHandle selSetCameraPosition_XHandle = Selector.GetHandle ("setCameraPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMicrophoneEnabled_X = "setMicrophoneEnabled:";
		static readonly NativeHandle selSetMicrophoneEnabled_XHandle = Selector.GetHandle ("setMicrophoneEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedRecorderX = "sharedRecorder";
		static readonly NativeHandle selSharedRecorderXHandle = Selector.GetHandle ("sharedRecorder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartCaptureWithHandler_CompletionHandler_X = "startCaptureWithHandler:completionHandler:";
		static readonly NativeHandle selStartCaptureWithHandler_CompletionHandler_XHandle = Selector.GetHandle ("startCaptureWithHandler:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartClipBufferingWithCompletionHandler_X = "startClipBufferingWithCompletionHandler:";
		static readonly NativeHandle selStartClipBufferingWithCompletionHandler_XHandle = Selector.GetHandle ("startClipBufferingWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartRecordingWithHandler_X = "startRecordingWithHandler:";
		static readonly NativeHandle selStartRecordingWithHandler_XHandle = Selector.GetHandle ("startRecordingWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopCaptureWithHandler_X = "stopCaptureWithHandler:";
		static readonly NativeHandle selStopCaptureWithHandler_XHandle = Selector.GetHandle ("stopCaptureWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopClipBufferingWithCompletionHandler_X = "stopClipBufferingWithCompletionHandler:";
		static readonly NativeHandle selStopClipBufferingWithCompletionHandler_XHandle = Selector.GetHandle ("stopClipBufferingWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopRecordingWithHandler_X = "stopRecordingWithHandler:";
		static readonly NativeHandle selStopRecordingWithHandler_XHandle = Selector.GetHandle ("stopRecordingWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopRecordingWithOutputURL_CompletionHandler_X = "stopRecordingWithOutputURL:completionHandler:";
		static readonly NativeHandle selStopRecordingWithOutputURL_CompletionHandler_XHandle = Selector.GetHandle ("stopRecordingWithOutputURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("RPScreenRecorder");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		internal RPScreenRecorder (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = true;
		}

		[Export ("discardRecordingWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DiscardRecording ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDiscardRecordingWithHandler_XHandle, (IntPtr) block_ptr_handler);
		}
		/// <summary>Discards the recording.</summary>
		/// <returns>A task that represents the asynchronous DiscardRecording operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task DiscardRecordingAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			DiscardRecording(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("exportClipToURL:duration:completionHandler:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExportClip (NSUrl url, double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double_NativeHandle (this.Handle, selExportClipToURL_Duration_CompletionHandler_XHandle, url__handle__, duration, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task ExportClipAsync (NSUrl url, double duration)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ExportClip(url, duration, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("startCaptureWithHandler:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StartCapture ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V18))]global::System.Action<global::CoreMedia.CMSampleBuffer, RPSampleBufferType, NSError>? captureHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			using var block_captureHandler = Trampolines.SDActionArity3V18.CreateNullableBlock (captureHandler);
			BlockLiteral *block_ptr_captureHandler = null;
			if (captureHandler is not null)
				block_ptr_captureHandler = &block_captureHandler;
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStartCaptureWithHandler_CompletionHandler_XHandle, (IntPtr) block_ptr_captureHandler, (IntPtr) block_ptr_completionHandler);
		}
		/// <param name="captureHandler">To be added.</param>
		/// <summary>Starts recording.</summary>
		/// <returns>A task that represents the asynchronous StartCapture operation</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StartCaptureAsync ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V18))]global::System.Action<global::CoreMedia.CMSampleBuffer, RPSampleBufferType, NSError>? captureHandler)
		{
			var tcs = new TaskCompletionSource<bool> ();
			StartCapture(captureHandler, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("startClipBufferingWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StartClipBuffering ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartClipBufferingWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StartClipBufferingAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			StartClipBuffering((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("startRecordingWithHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StartRecording ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity1V16.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartRecordingWithHandler_XHandle, (IntPtr) block_ptr_handler);
		}
		/// <summary>Starts the recording and runs a handler when the recording starts.</summary>
		/// <returns>A task that represents the asynchronous StartRecording operation</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StartRecordingAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			StartRecording((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("stopCaptureWithHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StopCapture ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity1V16.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopCaptureWithHandler_XHandle, (IntPtr) block_ptr_handler);
		}
		/// <summary>Stops screen and audio recording.</summary>
		/// <returns>A task that represents the asynchronous StopCapture operation</returns>
		/// <remarks>
		///           <para copied="true">The StopCaptureAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StopCaptureAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			StopCapture((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("stopClipBufferingWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StopClipBuffering ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopClipBufferingWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StopClipBufferingAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			StopClipBuffering((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("stopRecordingWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StopRecording ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V132))]global::System.Action<RPPreviewViewController, NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity2V132.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopRecordingWithHandler_XHandle, (IntPtr) block_ptr_handler);
		}
		/// <summary>Stops the recording and runs a handler when the recording stops.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous StopRecording operation.  The value of the TResult parameter is of type System.Action&lt;ReplayKit.RPPreviewViewController,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<RPPreviewViewController> StopRecordingAsync ()
		{
			var tcs = new TaskCompletionSource<RPPreviewViewController> ();
			StopRecording((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("stopRecordingWithOutputURL:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StopRecording (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStopRecordingWithOutputURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StopRecordingAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<bool> ();
			StopRecording(url, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <summary>Gets a Boolean value that tells whether the screen recorder is available.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Available {
			[Export ("isAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>Gets or sest a Boolean value that controls whether the camera enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public bool CameraEnabled {
			[Export ("isCameraEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCameraEnabledXHandle);
				return ret != 0;
			}
			[Export ("setCameraEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCameraEnabled_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public RPCameraPosition CameraPosition {
			[Export ("cameraPosition", ArgumentSemantic.Assign)]
			get {
				RPCameraPosition ret;
				ret = (ReplayKit.RPCameraPosition) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCameraPositionXHandle);
				return ret!;
			}
			[Export ("setCameraPosition:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCameraPosition_XHandle, (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public global::AppKit.NSView? CameraPreviewView {
			[Export ("cameraPreviewView")]
			get {
				global::AppKit.NSView? ret;
				ret =  Runtime.GetNSObject<global::AppKit.NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCameraPreviewViewXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IRPScreenRecorderDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IRPScreenRecorderDelegate? ret;
				ret =  Runtime.GetINativeObject<IRPScreenRecorderDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		/// <summary>Gets or sets a Boolean value that enables or disables the microphone.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public bool MicrophoneEnabled {
			[Export ("isMicrophoneEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMicrophoneEnabledXHandle);
				return ret != 0;
			}
			[Export ("setMicrophoneEnabled:")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMicrophoneEnabled_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>Gets a Boolean that tells whether the screen is being recording.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Recording {
			[Export ("isRecording")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRecordingXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static RPScreenRecorder SharedRecorder {
			[Export ("sharedRecorder")]
			get {
				RPScreenRecorder? ret;
				ret =  Runtime.GetNSObject<RPScreenRecorder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedRecorderXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class RPScreenRecorder */
}
