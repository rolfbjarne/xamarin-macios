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
		const string selAddConnection_X = "addConnection:";
		static readonly NativeHandle selAddConnection_XHandle = Selector.GetHandle ("addConnection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddControl_X = "addControl:";
		static readonly NativeHandle selAddControl_XHandle = Selector.GetHandle ("addControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddInput_X = "addInput:";
		static readonly NativeHandle selAddInput_XHandle = Selector.GetHandle ("addInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddInputWithNoConnections_X = "addInputWithNoConnections:";
		static readonly NativeHandle selAddInputWithNoConnections_XHandle = Selector.GetHandle ("addInputWithNoConnections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOutput_X = "addOutput:";
		static readonly NativeHandle selAddOutput_XHandle = Selector.GetHandle ("addOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOutputWithNoConnections_X = "addOutputWithNoConnections:";
		static readonly NativeHandle selAddOutputWithNoConnections_XHandle = Selector.GetHandle ("addOutputWithNoConnections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyRunsDeferredStartX = "automaticallyRunsDeferredStart";
		static readonly NativeHandle selAutomaticallyRunsDeferredStartXHandle = Selector.GetHandle ("automaticallyRunsDeferredStart");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginConfigurationX = "beginConfiguration";
		static readonly NativeHandle selBeginConfigurationXHandle = Selector.GetHandle ("beginConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddConnection_X = "canAddConnection:";
		static readonly NativeHandle selCanAddConnection_XHandle = Selector.GetHandle ("canAddConnection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddControl_X = "canAddControl:";
		static readonly NativeHandle selCanAddControl_XHandle = Selector.GetHandle ("canAddControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddInput_X = "canAddInput:";
		static readonly NativeHandle selCanAddInput_XHandle = Selector.GetHandle ("canAddInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddOutput_X = "canAddOutput:";
		static readonly NativeHandle selCanAddOutput_XHandle = Selector.GetHandle ("canAddOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanSetSessionPreset_X = "canSetSessionPreset:";
		static readonly NativeHandle selCanSetSessionPreset_XHandle = Selector.GetHandle ("canSetSessionPreset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommitConfigurationX = "commitConfiguration";
		static readonly NativeHandle selCommitConfigurationXHandle = Selector.GetHandle ("commitConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectionsX = "connections";
		static readonly NativeHandle selConnectionsXHandle = Selector.GetHandle ("connections");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlsX = "controls";
		static readonly NativeHandle selControlsXHandle = Selector.GetHandle ("controls");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlsDelegateX = "controlsDelegate";
		static readonly NativeHandle selControlsDelegateXHandle = Selector.GetHandle ("controlsDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlsDelegateCallbackQueueX = "controlsDelegateCallbackQueue";
		static readonly NativeHandle selControlsDelegateCallbackQueueXHandle = Selector.GetHandle ("controlsDelegateCallbackQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeferredStartDelegateX = "deferredStartDelegate";
		static readonly NativeHandle selDeferredStartDelegateXHandle = Selector.GetHandle ("deferredStartDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeferredStartDelegateCallbackQueueX = "deferredStartDelegateCallbackQueue";
		static readonly NativeHandle selDeferredStartDelegateCallbackQueueXHandle = Selector.GetHandle ("deferredStartDelegateCallbackQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputsX = "inputs";
		static readonly NativeHandle selInputsXHandle = Selector.GetHandle ("inputs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsManualDeferredStartSupportedX = "isManualDeferredStartSupported";
		static readonly NativeHandle selIsManualDeferredStartSupportedXHandle = Selector.GetHandle ("isManualDeferredStartSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRunningX = "isRunning";
		static readonly NativeHandle selIsRunningXHandle = Selector.GetHandle ("isRunning");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMasterClockX = "masterClock";
		static readonly NativeHandle selMasterClockXHandle = Selector.GetHandle ("masterClock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxControlsCountX = "maxControlsCount";
		static readonly NativeHandle selMaxControlsCountXHandle = Selector.GetHandle ("maxControlsCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputsX = "outputs";
		static readonly NativeHandle selOutputsXHandle = Selector.GetHandle ("outputs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveConnection_X = "removeConnection:";
		static readonly NativeHandle selRemoveConnection_XHandle = Selector.GetHandle ("removeConnection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveControl_X = "removeControl:";
		static readonly NativeHandle selRemoveControl_XHandle = Selector.GetHandle ("removeControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveInput_X = "removeInput:";
		static readonly NativeHandle selRemoveInput_XHandle = Selector.GetHandle ("removeInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveOutput_X = "removeOutput:";
		static readonly NativeHandle selRemoveOutput_XHandle = Selector.GetHandle ("removeOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunDeferredStartWhenNeededX = "runDeferredStartWhenNeeded";
		static readonly NativeHandle selRunDeferredStartWhenNeededXHandle = Selector.GetHandle ("runDeferredStartWhenNeeded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSessionPresetX = "sessionPreset";
		static readonly NativeHandle selSessionPresetXHandle = Selector.GetHandle ("sessionPreset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticallyRunsDeferredStart_X = "setAutomaticallyRunsDeferredStart:";
		static readonly NativeHandle selSetAutomaticallyRunsDeferredStart_XHandle = Selector.GetHandle ("setAutomaticallyRunsDeferredStart:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlsDelegate_Queue_X = "setControlsDelegate:queue:";
		static readonly NativeHandle selSetControlsDelegate_Queue_XHandle = Selector.GetHandle ("setControlsDelegate:queue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeferredStartDelegate_DeferredStartDelegateCallbackQueue_X = "setDeferredStartDelegate:deferredStartDelegateCallbackQueue:";
		static readonly NativeHandle selSetDeferredStartDelegate_DeferredStartDelegateCallbackQueue_XHandle = Selector.GetHandle ("setDeferredStartDelegate:deferredStartDelegateCallbackQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSessionPreset_X = "setSessionPreset:";
		static readonly NativeHandle selSetSessionPreset_XHandle = Selector.GetHandle ("setSessionPreset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartRunningX = "startRunning";
		static readonly NativeHandle selStartRunningXHandle = Selector.GetHandle ("startRunning");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopRunningX = "stopRunning";
		static readonly NativeHandle selStopRunningXHandle = Selector.GetHandle ("stopRunning");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportsControlsX = "supportsControls";
		static readonly NativeHandle selSupportsControlsXHandle = Selector.GetHandle ("supportsControls");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizationClockX = "synchronizationClock";
		static readonly NativeHandle selSynchronizationClockXHandle = Selector.GetHandle ("synchronizationClock");
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddConnection_XHandle, connection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddConnection_XHandle, connection__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddControl_XHandle, control__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddControl_XHandle, control__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddInput_XHandle, input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddInput_XHandle, input__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddInputWithNoConnections_XHandle, input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddInputWithNoConnections_XHandle, input__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddOutput_XHandle, output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOutput_XHandle, output__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddOutputWithNoConnections_XHandle, output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOutputWithNoConnections_XHandle, output__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBeginConfigurationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selBeginConfigurationXHandle);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanAddConnection_XHandle, connection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanAddConnection_XHandle, connection__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanAddControl_XHandle, control__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanAddControl_XHandle, control__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanAddInput_XHandle, input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanAddInput_XHandle, input__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanAddOutput_XHandle, output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanAddOutput_XHandle, output__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanSetSessionPreset_XHandle, preset__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanSetSessionPreset_XHandle, preset__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCommitConfigurationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCommitConfigurationXHandle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveConnection_XHandle, connection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveConnection_XHandle, connection__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveControl_XHandle, control__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveControl_XHandle, control__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveInput_XHandle, input__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveInput_XHandle, input__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveOutput_XHandle, output__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveOutput_XHandle, output__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRunDeferredStartWhenNeededXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRunDeferredStartWhenNeededXHandle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetControlsDelegate_Queue_XHandle, controlsDelegate__handle__, controlsDelegateCallbackQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetControlsDelegate_Queue_XHandle, controlsDelegate__handle__, controlsDelegateCallbackQueue__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDeferredStartDelegate_DeferredStartDelegateCallbackQueue_XHandle, deferredStartDelegate__handle__, deferredStartDelegateCallbackQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDeferredStartDelegate_DeferredStartDelegateCallbackQueue_XHandle, deferredStartDelegate__handle__, deferredStartDelegateCallbackQueue__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartRunningXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartRunningXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopRunning")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRunning ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopRunningXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopRunningXHandle);
					GC.KeepAlive (this);
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutomaticallyRunsDeferredStartXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutomaticallyRunsDeferredStartXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyRunsDeferredStart:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticallyRunsDeferredStart_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticallyRunsDeferredStart_XHandle, value ? (byte) 1 : (byte) 0);
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
					ret = CFArray.ArrayFromHandle<AVCaptureConnection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConnectionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureConnection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConnectionsXHandle), false)!;
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
					ret = CFArray.ArrayFromHandle<AVCaptureControl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selControlsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureControl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selControlsXHandle), false)!;
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
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selControlsDelegateCallbackQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selControlsDelegateCallbackQueueXHandle), false)!;
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
					ret =  Runtime.GetINativeObject<IAVCaptureSessionDeferredStartDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeferredStartDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVCaptureSessionDeferredStartDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeferredStartDelegateXHandle), false)!;
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
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeferredStartDelegateCallbackQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeferredStartDelegateCallbackQueueXHandle), false)!;
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
					ret = CFArray.ArrayFromHandle<AVCaptureInput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureInput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputsXHandle), false)!;
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
		public virtual bool ManualDeferredStartSupported {
			[Export ("isManualDeferredStartSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsManualDeferredStartSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsManualDeferredStartSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos12.3", "Use 'SynchronizationClock' instead.")]
		[ObsoletedOSPlatform ("ios15.4", "Use 'SynchronizationClock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.4", "Use 'SynchronizationClock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreMedia.CMClock? MasterClock {
			[Export ("masterClock")]
			get {
				global::CoreMedia.CMClock ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMasterClockXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMasterClockXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
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
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxControlsCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaxControlsCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureOutput[] Outputs {
			[Export ("outputs")]
			get {
				AVCaptureOutput[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureOutput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureOutput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputsXHandle), false)!;
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRunningXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRunningXHandle);
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
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSessionPresetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSessionPresetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSessionPreset:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSessionPreset_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSessionPreset_XHandle, value__handle__);
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSupportsControlsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSupportsControlsXHandle);
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
					ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSynchronizationClockXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSynchronizationClockXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
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
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selControlsDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selControlsDelegateXHandle), false)!;
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
		static NSString? _Preset320x240;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPreset320x240",  "AVFoundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString Preset320x240 {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Preset320x240 is null)
					_Preset320x240 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset320x240")!;
				return _Preset320x240;
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
		static NSString? _Preset960x540;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVCaptureSessionPreset960x540",  "AVFoundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString Preset960x540 {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Preset960x540 is null)
					_Preset960x540 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureSessionPreset960x540")!;
				return _Preset960x540;
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
