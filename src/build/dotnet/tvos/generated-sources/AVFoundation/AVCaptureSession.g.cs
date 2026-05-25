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
namespace AVFoundation {
	/// <summary>Coordinates a recording session.</summary><remarks><para>
	/// The AVCaptureSession object coordinates the recording of video
	/// or audio input and passing the recorded information to one or
	/// more output objects.  As the iOS line has advanced, different devices
	/// have gained multiple capture devices (in particular, gained multiple cameras).
	/// Application developers can use <see cref="M:AVFoundation.AVCaptureDevice.GetDefaultDevice(AVFoundation.AVMediaTypes)" /> or
	/// <see cref="M:AVFoundation.AVCaptureDevice.DevicesWithMediaType(System.String)" />, passing in the constants defined in <see cref="T:AVFoundation.AVMediaTypes" />.
	/// </para><para>
	/// Configuring capture consists of setting the <see cref="P:AVFoundation.AVCaptureSession.Inputs" /> and <see cref="P:AVFoundation.AVCaptureSession.Outputs" /> properties of the <see cref="T:AVFoundation.AVCaptureSession" />. Notice that multiple <see cref="T:AVFoundation.AVCaptureInput" />s and <see cref="T:AVFoundation.AVCaptureOutput" />s are possible. For instance, to capture both audio and video, one would use two capture inputs:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var session = new AVCaptureSession();
	/// 
	/// var camera = AVCaptureDevice.GetDefaultDevice(AVMediaType.Video);
	/// var mic = AVCaptureDevice.GetDefaultDevice(AVMediaType.Audio);
	/// if(camera == null || mic == null){
	/// throw new Exception("Can't find devices");
	/// }
	/// 
	/// var cameraInput = AVCaptureDeviceInput.FromDevice (camera);
	/// //info.plist _must_ contain NSMicrophoneUsageDescription key
	/// var micInput = AVCaptureDeviceInput.FromDevice (mic);
	/// 
	/// if(session.CanAddInput(cameraInput)){
	/// session.AddInput(cameraInput);
	/// }
	/// if(session.CanAddInput(micInput)){
	/// session.AddInput(micInput);
	/// }
	/// ]]></code></example><para>Note that permission to access the microphone (and in some regions, the camera) must be given by the user, requiring the developer to add the <c>NSMicrophoneUsageDescription</c> to the application's info.plist file.</para><para>Video can be captured directly to file with <see cref="T:AVFoundation.AVCaptureMovieFileOutput" />. However, this class has no display-able data and cannot be used simultaneously with <see cref="T:AVFoundation.AVCaptureVideoDataOutput" />. Instead, application developers can use it in combination with a <see cref="T:AVFoundation.AVCaptureVideoPreviewLayer" />, as shown in the following example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var layer = new AVCaptureVideoPreviewLayer (session);
	/// layer.VideoGravity = AVLayerVideoGravity.ResizeAspectFill;
	/// 
	/// var cameraView = new UIView ();
	/// cameraView.Layer.AddSublayer (layer);
	/// 
	/// var filePath = Path.Combine (Path.GetTempPath (), "temporary.mov");
	/// var fileUrl = NSUrl.FromFilename (filePath);
	/// 
	/// var movieFileOutput = new AVCaptureMovieFileOutput ();
	/// var recordingDelegate = new MyRecordingDelegate ();
	/// session.AddOutput (movieFileOutput);
	/// 
	/// movieFileOutput.StartRecordingToOutputFile (fileUrl, recordingDelegate);
	/// ]]></code></example><para>
	/// Application developers should note that the function <see cref="M:AVFoundation.AVCaptureFileOutput.StopRecording" /> is asynchronous;
	/// developers should wait until the <see cref="M:AVFoundation.AVCaptureFileOutputRecordingDelegate.FinishedRecording(AVFoundation.AVCaptureFileOutput,Foundation.NSUrl,Foundation.NSObject[],Foundation.NSError)" /> delegate method
	/// before manipulating the file.
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public class MyRecordingDelegate : AVCaptureFileOutputRecordingDelegate
	/// {
	/// public override void FinishedRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject [] connections, NSError error)
	/// {
	/// if (UIVideo.IsCompatibleWithSavedPhotosAlbum (outputFileUrl.Path))
	/// {
	/// var library = new ALAssetsLibrary ();
	/// library.WriteVideoToSavedPhotosAlbum (outputFileUrl, (path, e2) =>
	/// {
	/// if (e2 != null)
	/// {
	/// new UIAlertView ("Error", e2.ToString (), null, "OK", null).Show ();
	/// }
	/// else
	/// {
	/// new UIAlertView ("Saved", "Saved to Photos", null, "OK", null).Show ();
	/// File.Delete (outputFileUrl.Path);
	/// }
	/// });
	/// }
	/// else
	/// {
	/// new UIAlertView ("Incompatible", "Incompatible", null, "OK", null).Show ();
	/// }
	/// 
	/// }
	/// }          ]]></code></example><para>
	/// 	Application developers can configure one or more output ports for the
	/// 	captured data, and these can be still frames, video frames
	/// 	with timing information, audio samples, quicktime movie files, or can be rendered directly to a CoreAnimation layer.
	/// 
	/// </para><para>
	/// 	Once the input and output components of
	/// 	the session are set, the actual processing is begun by calling the
	/// 	<see cref="M:AVFoundation.AVCaptureSession.StartRunning" />
	/// 	method.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// 
	/// void SetupCapture ()
	/// 	/ configure the capture session for low resolution, change this if your code
	/// 	// can cope with more data or volume
	/// 	session = new AVCaptureSession () {
	/// 	        SessionPreset = AVCaptureSession.PresetMedium
	/// 	};
	/// 	
	/// 	// create a device input and attach it to the session
	/// 	var captureDevice = AVCaptureDevice.GetDefaultDevice (AVMediaTypes.Video);
	/// 	var input = AVCaptureDeviceInput.FromDevice (captureDevice);
	/// 	if (input == null){
	/// 	        Console.WriteLine ("No video input device");
	/// 	        return false;
	/// 	}
	/// 	session.AddInput (input);
	/// 	
	/// 	// create a VideoDataOutput and add it to the sesion
	/// 	var output = new AVCaptureVideoDataOutput () {
	/// 	        VideoSettings = new AVVideoSettings (CVPixelFormatType.CV32BGRA),
	/// 	
	/// 	        // If you want to cap the frame rate at a given speed, in this sample: 15 frames per second
	/// 	        MinFrameDuration = new CMTime (1, 15)
	/// 	};
	/// 	
	/// 	// configure the output
	/// 	queue = new MonoTouch.CoreFoundation.DispatchQueue ("myQueue");
	/// 	outputRecorder = new OutputRecorder ();
	/// 	output.SetSampleBufferDelegateAndQueue (outputRecorder, queue);
	/// 	session.AddOutput (output);
	/// 	
	/// 	session.StartRunning ();
	/// }
	/// 
	/// public class OutputRecorder : AVCaptureVideoDataOutputSampleBufferDelegate {
	/// public override void DidOutputSampleBuffer (AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
	/// {
	/// try {
	/// var image = ImageFromSampleBuffer (sampleBuffer);
	/// 
	/// // Do something with the image, we just stuff it in our main view.
	/// AppDelegate.ImageView.BeginInvokeOnMainThread (delegate {
	/// AppDelegate.ImageView.Image = image;
	/// });
	/// 
	/// //
	/// // Although this looks innocent "Oh, he is just optimizing this case away"
	/// // this is incredibly important to call on this callback, because the AVFoundation
	/// // has a fixed number of buffers and if it runs out of free buffers, it will stop
	/// // delivering frames.
	/// //
	/// sampleBuffer.Dispose ();
	/// } catch (Exception e){
	/// Console.WriteLine (e);
	/// }
	/// }
	/// 
	/// UIImage ImageFromSampleBuffer (CMSampleBuffer sampleBuffer)
	/// {
	/// // Get the CoreVideo image
	/// using (var pixelBuffer = sampleBuffer.GetImageBuffer () as CVPixelBuffer){
	/// // Lock the base address
	/// pixelBuffer.Lock (0);
	/// // Get the number of bytes per row for the pixel buffer
	/// var baseAddress = pixelBuffer.BaseAddress;
	/// int bytesPerRow = pixelBuffer.BytesPerRow;
	/// int width = pixelBuffer.Width;
	/// int height = pixelBuffer.Height;
	/// var flags = CGBitmapFlags.PremultipliedFirst | CGBitmapFlags.ByteOrder32Little;
	/// // Create a CGImage on the RGB colorspace from the configured parameter above
	/// using (var cs = CGColorSpace.CreateDeviceRGB ())
	/// using (var context = new CGBitmapContext (baseAddress,width, height, 8, bytesPerRow, cs, (CGImageAlphaInfo) flags))
	/// using (var cgImage = context.ToImage ()){
	/// pixelBuffer.Unlock (0);
	/// return UIImage.FromImage (cgImage);
	/// }
	/// }
	/// }
	/// }
	/// 
	/// 	]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureSession_Class/index.html">Apple documentation for <c>AVCaptureSession</c></related>
	[Register("AVCaptureSession", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCaptureSession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureSession");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVCaptureSession" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCaptureSession () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected AVCaptureSession (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureSession (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addConnection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddConnection (AVCaptureConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addConnection:"), connection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addConnection:"), connection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (connection);
		}
		[Export ("addControl:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddControl (AVCaptureControl control)
		{
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addControl:"), control__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addControl:"), control__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (control);
		}
		[Export ("addInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddInput (AVCaptureInput input)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addInput:"), input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addInput:"), input__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
		}
		[Export ("addInputWithNoConnections:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddInputWithNoConnections (AVCaptureInput input)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addInputWithNoConnections:"), input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addInputWithNoConnections:"), input__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
		}
		[Export ("addOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOutput (AVCaptureOutput output)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addOutput:"), output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addOutput:"), output__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (output);
		}
		[Export ("addOutputWithNoConnections:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOutputWithNoConnections (AVCaptureOutput output)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addOutputWithNoConnections:"), output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addOutputWithNoConnections:"), output__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (output);
		}
		[Export ("beginConfiguration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginConfiguration ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginConfiguration"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("beginConfiguration"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("canAddConnection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddConnection (AVCaptureConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canAddConnection:"), connection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canAddConnection:"), connection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (connection);
			return ret != 0;
		}
		[Export ("canAddControl:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddControl (AVCaptureControl control)
		{
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canAddControl:"), control__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canAddControl:"), control__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (control);
			return ret != 0;
		}
		[Export ("canAddInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddInput (AVCaptureInput input)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canAddInput:"), input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canAddInput:"), input__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
			return ret != 0;
		}
		[Export ("canAddOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddOutput (AVCaptureOutput output)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canAddOutput:"), output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canAddOutput:"), output__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (output);
			return ret != 0;
		}
		[Export ("canSetSessionPreset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanSetSessionPreset (NSString preset)
		{
			var preset__handle__ = preset!.GetNonNullHandle (nameof (preset));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canSetSessionPreset:"), preset__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canSetSessionPreset:"), preset__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preset);
			return ret != 0;
		}
		[Export ("commitConfiguration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitConfiguration ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("commitConfiguration"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("commitConfiguration"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeConnection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveConnection (AVCaptureConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeConnection:"), connection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeConnection:"), connection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (connection);
		}
		[Export ("removeControl:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveControl (AVCaptureControl control)
		{
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeControl:"), control__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeControl:"), control__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (control);
		}
		[Export ("removeInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveInput (AVCaptureInput input)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeInput:"), input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeInput:"), input__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
		}
		[Export ("removeOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOutput (AVCaptureOutput output)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeOutput:"), output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeOutput:"), output__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (output);
		}
		[Export ("runDeferredStartWhenNeeded")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunDeferredStartWhenNeeded ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("runDeferredStartWhenNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("runDeferredStartWhenNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setControlsDelegate:queue:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetControlsDelegate (IAVCaptureSessionControlsDelegate? controlsDelegate, global::CoreFoundation.DispatchQueue? controlsDelegateCallbackQueue)
		{
			var controlsDelegate__handle__ = controlsDelegate.GetHandle ();
			var controlsDelegateCallbackQueue__handle__ = controlsDelegateCallbackQueue.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setControlsDelegate:queue:"), controlsDelegate__handle__, controlsDelegateCallbackQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setControlsDelegate:queue:"), controlsDelegate__handle__, controlsDelegateCallbackQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlsDelegate);
			GC.KeepAlive (controlsDelegateCallbackQueue);
		}
		[Export ("setDeferredStartDelegate:deferredStartDelegateCallbackQueue:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDeferredStartDelegate (IAVCaptureSessionDeferredStartDelegate? deferredStartDelegate, global::CoreFoundation.DispatchQueue? deferredStartDelegateCallbackQueue)
		{
			var deferredStartDelegate__handle__ = deferredStartDelegate.GetHandle ();
			var deferredStartDelegateCallbackQueue__handle__ = deferredStartDelegateCallbackQueue.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setDeferredStartDelegate:deferredStartDelegateCallbackQueue:"), deferredStartDelegate__handle__, deferredStartDelegateCallbackQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setDeferredStartDelegate:deferredStartDelegateCallbackQueue:"), deferredStartDelegate__handle__, deferredStartDelegateCallbackQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (deferredStartDelegate);
			GC.KeepAlive (deferredStartDelegateCallbackQueue);
		}
		[Export ("startRunning")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRunning ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startRunning"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("startRunning"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopRunning")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRunning ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopRunning"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stopRunning"));
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool AutomaticallyConfiguresApplicationAudioSession {
			[Export ("automaticallyConfiguresApplicationAudioSession")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyConfiguresApplicationAudioSession"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyConfiguresApplicationAudioSession"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyConfiguresApplicationAudioSession:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyConfiguresApplicationAudioSession:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyConfiguresApplicationAudioSession:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool AutomaticallyConfiguresCaptureDeviceForWideColor {
			[Export ("automaticallyConfiguresCaptureDeviceForWideColor")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyConfiguresCaptureDeviceForWideColor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyConfiguresCaptureDeviceForWideColor"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyConfiguresCaptureDeviceForWideColor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyConfiguresCaptureDeviceForWideColor:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyConfiguresCaptureDeviceForWideColor:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool AutomaticallyRunsDeferredStart {
			[Export ("automaticallyRunsDeferredStart")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyRunsDeferredStart"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyRunsDeferredStart"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyRunsDeferredStart:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyRunsDeferredStart:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyRunsDeferredStart:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual bool ConfiguresApplicationAudioSessionToMixWithOthers {
			[Export ("configuresApplicationAudioSessionToMixWithOthers")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("configuresApplicationAudioSessionToMixWithOthers"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configuresApplicationAudioSessionToMixWithOthers"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setConfiguresApplicationAudioSessionToMixWithOthers:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setConfiguresApplicationAudioSessionToMixWithOthers:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setConfiguresApplicationAudioSessionToMixWithOthers:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureConnection[] Connections {
			[Export ("connections")]
			get {
				AVCaptureConnection[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureConnection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("connections")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureConnection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("connections")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual AVCaptureControl[] Controls {
			[Export ("controls")]
			get {
				AVCaptureControl[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureControl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("controls")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureControl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("controls")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IAVCaptureSessionControlsDelegate ControlsDelegate {
			get {
				return (WeakControlsDelegate as IAVCaptureSessionControlsDelegate)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual global::CoreFoundation.DispatchQueue? ControlsDelegateCallbackQueue {
			[Export ("controlsDelegateCallbackQueue")]
			get {
				global::CoreFoundation.DispatchQueue ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("controlsDelegateCallbackQueue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("controlsDelegateCallbackQueue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual IAVCaptureSessionDeferredStartDelegate? DeferredStartDelegate {
			[Export ("deferredStartDelegate")]
			get {
				IAVCaptureSessionDeferredStartDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAVCaptureSessionDeferredStartDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("deferredStartDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVCaptureSessionDeferredStartDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("deferredStartDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual global::CoreFoundation.DispatchQueue? DeferredStartDelegateCallbackQueue {
			[Export ("deferredStartDelegateCallbackQueue")]
			get {
				global::CoreFoundation.DispatchQueue ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("deferredStartDelegateCallbackQueue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("deferredStartDelegateCallbackQueue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual float HardwareCost {
			[Export ("hardwareCost")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("hardwareCost"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hardwareCost"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureInput[] Inputs {
			[Export ("inputs")]
			get {
				AVCaptureInput[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureInput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputs")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureInput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputs")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the session has been interrupted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool Interrupted {
			[Export ("isInterrupted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInterrupted"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isInterrupted"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool ManualDeferredStartSupported {
			[Export ("isManualDeferredStartSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isManualDeferredStartSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isManualDeferredStartSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual nint MaxControlsCount {
			[Export ("maxControlsCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxControlsCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maxControlsCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool MultitaskingCameraAccessEnabled {
			[Export ("isMultitaskingCameraAccessEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMultitaskingCameraAccessEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isMultitaskingCameraAccessEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMultitaskingCameraAccessEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMultitaskingCameraAccessEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setMultitaskingCameraAccessEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool MultitaskingCameraAccessSupported {
			[Export ("isMultitaskingCameraAccessSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMultitaskingCameraAccessSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isMultitaskingCameraAccessSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureOutput[] Outputs {
			[Export ("outputs")]
			get {
				AVCaptureOutput[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureOutput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("outputs")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureOutput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("outputs")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the capture session is currently running.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Running {
			[Export ("isRunning")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRunning"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isRunning"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString SessionPreset {
			[Export ("sessionPreset", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sessionPreset")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sessionPreset")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSessionPreset:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSessionPreset:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSessionPreset:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual bool SupportsControls {
			[Export ("supportsControls")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsControls"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("supportsControls"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual global::CoreMedia.CMClock? SynchronizationClock {
			[Export ("synchronizationClock")]
			get {
				global::CoreMedia.CMClock ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("synchronizationClock")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("synchronizationClock")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool UsesApplicationAudioSession {
			[Export ("usesApplicationAudioSession")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesApplicationAudioSession"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("usesApplicationAudioSession"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesApplicationAudioSession:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesApplicationAudioSession:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUsesApplicationAudioSession:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual NSObject? WeakControlsDelegate {
			[Export ("controlsDelegate")]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("controlsDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("controlsDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidStartRunningNotification;
		/// <summary>Notification constant for DidStartRunning</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidStartRunning(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidStartRunning(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = AVCaptureSession.Notifications.ObserveDidStartRunning ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, AVCaptureSession.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureSession.Notifications.ObserveDidStartRunning (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     AVCaptureSession.DidStartRunningNotification, (notification) => { Console.WriteLine ("Received the notification DidStartRunning", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidStartRunning", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureSession.DidStartRunningNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureSessionDidStartRunningNotification",  "AVFoundation")]
		[Advice ("Use AVCaptureSession.Notifications.ObserveDidStartRunning helper method instead.")]
		public static NSString DidStartRunningNotification {
			get {
				if (_DidStartRunningNotification is null)
					_DidStartRunningNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionDidStartRunningNotification")!;
				return _DidStartRunningNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidStopRunningNotification;
		/// <summary>Notification constant for DidStopRunning</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidStopRunning(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidStopRunning(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = AVCaptureSession.Notifications.ObserveDidStopRunning ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, AVCaptureSession.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureSession.Notifications.ObserveDidStopRunning (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     AVCaptureSession.DidStopRunningNotification, (notification) => { Console.WriteLine ("Received the notification DidStopRunning", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidStopRunning", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureSession.DidStopRunningNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureSessionDidStopRunningNotification",  "AVFoundation")]
		[Advice ("Use AVCaptureSession.Notifications.ObserveDidStopRunning helper method instead.")]
		public static NSString DidStopRunningNotification {
			get {
				if (_DidStopRunningNotification is null)
					_DidStopRunningNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionDidStopRunningNotification")!;
				return _DidStopRunningNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorKey;
		/// <summary>Represents the value associated with the constant AVCaptureSessionErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionErrorKey",  "AVFoundation")]
		public static NSString ErrorKey {
			get {
				if (_ErrorKey is null)
					_ErrorKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionErrorKey")!;
				return _ErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InterruptionEndedNotification;
		/// <summary>Notification constant for InterruptionEnded</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveInterruptionEnded(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveInterruptionEnded(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = AVCaptureSession.Notifications.ObserveInterruptionEnded ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, AVCaptureSession.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureSession.Notifications.ObserveInterruptionEnded (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     AVCaptureSession.InterruptionEndedNotification, (notification) => { Console.WriteLine ("Received the notification InterruptionEnded", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification InterruptionEnded", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureSession.InterruptionEndedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureSessionInterruptionEndedNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[Advice ("Use AVCaptureSession.Notifications.ObserveInterruptionEnded helper method instead.")]
		public static NSString InterruptionEndedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_InterruptionEndedNotification is null)
					_InterruptionEndedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionInterruptionEndedNotification")!;
				return _InterruptionEndedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InterruptionReasonKey;
		/// <summary>Gets a key that accesses the reason that a capture session was interrupted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionInterruptionReasonKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString InterruptionReasonKey {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_InterruptionReasonKey is null)
					_InterruptionReasonKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionInterruptionReasonKey")!;
				return _InterruptionReasonKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InterruptionSystemPressureStateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionInterruptionSystemPressureStateKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString InterruptionSystemPressureStateKey {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_InterruptionSystemPressureStateKey is null)
					_InterruptionSystemPressureStateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionInterruptionSystemPressureStateKey")!;
				return _InterruptionSystemPressureStateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset1280x720;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPreset1280x720</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPreset1280x720",  "AVFoundation")]
		public static NSString Preset1280x720 {
			get {
				if (_Preset1280x720 is null)
					_Preset1280x720 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset1280x720")!;
				return _Preset1280x720;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset1920x1080;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPreset1920x1080</summary><value></value><remarks></remarks>
		[Field ("AVCaptureSessionPreset1920x1080",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString Preset1920x1080 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_Preset1920x1080 is null)
					_Preset1920x1080 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset1920x1080")!;
				return _Preset1920x1080;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset352x288;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPreset352x288</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPreset352x288",  "AVFoundation")]
		public static NSString Preset352x288 {
			get {
				if (_Preset352x288 is null)
					_Preset352x288 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset352x288")!;
				return _Preset352x288;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset3840x2160;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPreset3840x2160.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPreset3840x2160",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString Preset3840x2160 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_Preset3840x2160 is null)
					_Preset3840x2160 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset3840x2160")!;
				return _Preset3840x2160;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset640x480;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPreset640x480</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPreset640x480",  "AVFoundation")]
		public static NSString Preset640x480 {
			get {
				if (_Preset640x480 is null)
					_Preset640x480 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset640x480")!;
				return _Preset640x480;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHigh;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetHigh</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetHigh",  "AVFoundation")]
		public static NSString PresetHigh {
			get {
				if (_PresetHigh is null)
					_PresetHigh = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetHigh")!;
				return _PresetHigh;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetInputPriority;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetInputPriority</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetInputPriority",  "AVFoundation")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString PresetInputPriority {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_PresetInputPriority is null)
					_PresetInputPriority = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetInputPriority")!;
				return _PresetInputPriority;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetLow;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetLow</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetLow",  "AVFoundation")]
		public static NSString PresetLow {
			get {
				if (_PresetLow is null)
					_PresetLow = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetLow")!;
				return _PresetLow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetMedium;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetMedium</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetMedium",  "AVFoundation")]
		public static NSString PresetMedium {
			get {
				if (_PresetMedium is null)
					_PresetMedium = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetMedium")!;
				return _PresetMedium;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetPhoto;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetPhoto</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetPhoto",  "AVFoundation")]
		public static NSString PresetPhoto {
			get {
				if (_PresetPhoto is null)
					_PresetPhoto = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetPhoto")!;
				return _PresetPhoto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetiFrame1280x720;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetiFrame1280x720</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetiFrame1280x720",  "AVFoundation")]
		public static NSString PresetiFrame1280x720 {
			get {
				if (_PresetiFrame1280x720 is null)
					_PresetiFrame1280x720 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetiFrame1280x720")!;
				return _PresetiFrame1280x720;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetiFrame960x540;
		/// <summary>Represents the value associated with the constant AVCaptureSessionPresetiFrame960x540</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPresetiFrame960x540",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString PresetiFrame960x540 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_PresetiFrame960x540 is null)
					_PresetiFrame960x540 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPresetiFrame960x540")!;
				return _PresetiFrame960x540;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RuntimeErrorNotification;
		/// <summary>Notification constant for RuntimeError</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRuntimeError(NSObject,EventHandler{AVCaptureSessionRuntimeErrorEventArgs})" />
		///     or <see cref="Notifications.ObserveRuntimeError(EventHandler{AVCaptureSessionRuntimeErrorEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = AVCaptureSession.Notifications.ObserveRuntimeError ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, AVCaptureSession.AVCaptureSessionRuntimeErrorEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureSession.Notifications.ObserveRuntimeError (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     AVCaptureSession.RuntimeErrorNotification, (notification) => { Console.WriteLine ("Received the notification RuntimeError", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RuntimeError", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureSession.RuntimeErrorNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureSessionRuntimeErrorNotification",  "AVFoundation")]
		[Advice ("Use AVCaptureSession.Notifications.ObserveRuntimeError helper method instead.")]
		public static NSString RuntimeErrorNotification {
			get {
				if (_RuntimeErrorNotification is null)
					_RuntimeErrorNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionRuntimeErrorNotification")!;
				return _RuntimeErrorNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WasInterruptedNotification;
		/// <summary>Notification constant for WasInterrupted</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWasInterrupted(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWasInterrupted(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = AVCaptureSession.Notifications.ObserveWasInterrupted ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, AVCaptureSession.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureSession.Notifications.ObserveWasInterrupted (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     AVCaptureSession.WasInterruptedNotification, (notification) => { Console.WriteLine ("Received the notification WasInterrupted", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WasInterrupted", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureSession.WasInterruptedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureSessionWasInterruptedNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[Advice ("Use AVCaptureSession.Notifications.ObserveWasInterrupted helper method instead.")]
		public static NSString WasInterruptedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_WasInterruptedNotification is null)
					_WasInterruptedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionWasInterruptedNotification")!;
				return _WasInterruptedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVCaptureSession" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.DidStartRunningNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.DidStartRunningNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureSession.Notifications.ObserveDidStartRunning ((notification) => {
			///   Console.WriteLine ("Observed DidStartRunningNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidStartRunning (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartRunningNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.DidStartRunningNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.DidStartRunningNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureSession.Notifications.ObserveDidStartRunning (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidStartRunningNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidStartRunning (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartRunningNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.DidStopRunningNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.DidStopRunningNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureSession.Notifications.ObserveDidStopRunning ((notification) => {
			///   Console.WriteLine ("Observed DidStopRunningNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidStopRunning (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStopRunningNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.DidStopRunningNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.DidStopRunningNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureSession.Notifications.ObserveDidStopRunning (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidStopRunningNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidStopRunning (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStopRunningNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.InterruptionEndedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.InterruptionEndedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureSession.Notifications.ObserveInterruptionEnded ((notification) => {
			///   Console.WriteLine ("Observed InterruptionEndedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveInterruptionEnded (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InterruptionEndedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.InterruptionEndedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.InterruptionEndedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureSession.Notifications.ObserveInterruptionEnded (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed InterruptionEndedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveInterruptionEnded (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InterruptionEndedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.RuntimeErrorNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.RuntimeErrorNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureSession.Notifications.ObserveRuntimeError ((notification) => {
			///   Console.WriteLine ("Observed RuntimeErrorNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRuntimeError (EventHandler<AVFoundation.AVCaptureSessionRuntimeErrorEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RuntimeErrorNotification, notification => handler (null, new AVFoundation.AVCaptureSessionRuntimeErrorEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.RuntimeErrorNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.RuntimeErrorNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureSession.Notifications.ObserveRuntimeError (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RuntimeErrorNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRuntimeError (NSObject objectToObserve, EventHandler<AVFoundation.AVCaptureSessionRuntimeErrorEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RuntimeErrorNotification, notification => handler (null, new AVFoundation.AVCaptureSessionRuntimeErrorEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.WasInterruptedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.WasInterruptedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureSession.Notifications.ObserveWasInterrupted ((notification) => {
			///   Console.WriteLine ("Observed WasInterruptedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasInterrupted (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasInterruptedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureSession.WasInterruptedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureSession.WasInterruptedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureSession.Notifications.ObserveWasInterrupted (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WasInterruptedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasInterrupted (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasInterruptedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVCaptureSession */
}
