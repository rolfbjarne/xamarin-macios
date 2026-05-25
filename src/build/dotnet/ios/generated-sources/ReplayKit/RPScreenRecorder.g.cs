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
namespace ReplayKit {
	/// <summary>Enables the user to record visual and audio output of applications, with simultaneous recorded audio (screencasts).</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ReplayKit/Reference/RPScreenRecorder_Ref/index.html">Apple documentation for <c>RPScreenRecorder</c></related>
	[Register("RPScreenRecorder", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe sealed partial class RPScreenRecorder : NSObject {
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("discardRecordingWithHandler:"), (IntPtr) block_ptr_handler);
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
		public unsafe void ExportClip (NSUrl url, double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double_NativeHandle (this.Handle, Selector.GetHandle ("exportClipToURL:duration:completionHandler:"), url__handle__, duration, (IntPtr) block_ptr_completionHandler);
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
		public unsafe void StartCapture ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V21))]global::System.Action<global::CoreMedia.CMSampleBuffer, RPSampleBufferType, NSError>? captureHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? completionHandler)
		{
			using var block_captureHandler = Trampolines.SDActionArity3V21.CreateNullableBlock (captureHandler);
			BlockLiteral *block_ptr_captureHandler = null;
			if (captureHandler is not null)
				block_ptr_captureHandler = &block_captureHandler;
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("startCaptureWithHandler:completionHandler:"), (IntPtr) block_ptr_captureHandler, (IntPtr) block_ptr_completionHandler);
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
		public unsafe Task StartCaptureAsync ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V21))]global::System.Action<global::CoreMedia.CMSampleBuffer, RPSampleBufferType, NSError>? captureHandler)
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
		public unsafe void StartClipBuffering ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("startClipBufferingWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		[Export ("startRecordingWithMicrophoneEnabled:handler:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'StartRecording (Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'StartRecording (Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'StartRecording (Action<NSError>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StartRecording (bool microphoneEnabled, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity1V0.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, Selector.GetHandle ("startRecordingWithMicrophoneEnabled:handler:"), microphoneEnabled ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
		}
		/// <param name="microphoneEnabled">To be added.</param>
		/// <summary>Asynchronously starts recording the screen, controlling whether recording is enabled.</summary>
		/// <returns>A task that represents the asynchronous StartRecording operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'StartRecording (Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'StartRecording (Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'StartRecording (Action<NSError>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task StartRecordingAsync (bool microphoneEnabled)
		{
			var tcs = new TaskCompletionSource<bool> ();
			StartRecording(microphoneEnabled, (obj_) => {
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
		public unsafe void StartRecording ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity1V0.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("startRecordingWithHandler:"), (IntPtr) block_ptr_handler);
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
		public unsafe void StopCapture ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity1V0.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stopCaptureWithHandler:"), (IntPtr) block_ptr_handler);
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
		public unsafe void StopClipBuffering ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stopClipBufferingWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		public unsafe void StopRecording ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V154))]global::System.Action<RPPreviewViewController, NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity2V154.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stopRecordingWithHandler:"), (IntPtr) block_ptr_handler);
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
		public unsafe void StopRecording (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError>? completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("stopRecordingWithOutputURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAvailable"));
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCameraEnabled"));
				return ret != 0;
			}
			[Export ("setCameraEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCameraEnabled:"), value ? (byte) 1 : (byte) 0);
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
				ret = (ReplayKit.RPCameraPosition) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraPosition"));
				return ret!;
			}
			[Export ("setCameraPosition:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCameraPosition:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public global::UIKit.UIView? CameraPreviewView {
			[Export ("cameraPreviewView")]
			get {
				global::UIKit.UIView? ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cameraPreviewView")), false)!;
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
				ret =  Runtime.GetINativeObject<IRPScreenRecorderDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMicrophoneEnabled"));
				return ret != 0;
			}
			[Export ("setMicrophoneEnabled:")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMicrophoneEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>Gets a Boolean that tells whether the screen is being recording.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Recording {
			[Export ("isRecording")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRecording"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static RPScreenRecorder SharedRecorder {
			[Export ("sharedRecorder")]
			get {
				RPScreenRecorder? ret;
				ret =  Runtime.GetNSObject<RPScreenRecorder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedRecorder")), false)!;
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
