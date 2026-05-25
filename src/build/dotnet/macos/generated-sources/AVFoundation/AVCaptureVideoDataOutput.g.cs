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
	/// <summary>AVCaptureOutput that captures frames from the video being recorded.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureVideoDataOutput_Class/index.html">Apple documentation for <c>AVCaptureVideoDataOutput</c></related>
	[Register("AVCaptureVideoDataOutput", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCaptureVideoDataOutput : AVCaptureOutput {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlwaysDiscardsLateVideoFramesX = "alwaysDiscardsLateVideoFrames";
		static readonly NativeHandle selAlwaysDiscardsLateVideoFramesXHandle = Selector.GetHandle ("alwaysDiscardsLateVideoFrames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableVideoCVPixelFormatTypesX = "availableVideoCVPixelFormatTypes";
		static readonly NativeHandle selAvailableVideoCVPixelFormatTypesXHandle = Selector.GetHandle ("availableVideoCVPixelFormatTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableVideoCodecTypesX = "availableVideoCodecTypes";
		static readonly NativeHandle selAvailableVideoCodecTypesXHandle = Selector.GetHandle ("availableVideoCodecTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_X = "availableVideoCodecTypesForAssetWriterWithOutputFileType:";
		static readonly NativeHandle selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_XHandle = Selector.GetHandle ("availableVideoCodecTypesForAssetWriterWithOutputFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinFrameDurationX = "minFrameDuration";
		static readonly NativeHandle selMinFrameDurationXHandle = Selector.GetHandle ("minFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreservesDynamicHDRMetadataX = "preservesDynamicHDRMetadata";
		static readonly NativeHandle selPreservesDynamicHDRMetadataXHandle = Selector.GetHandle ("preservesDynamicHDRMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecommendedMediaTimeScaleForAssetWriterX = "recommendedMediaTimeScaleForAssetWriter";
		static readonly NativeHandle selRecommendedMediaTimeScaleForAssetWriterXHandle = Selector.GetHandle ("recommendedMediaTimeScaleForAssetWriter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecommendedMovieMetadataForVideoCodecType_AssetWriterOutputFileType_X = "recommendedMovieMetadataForVideoCodecType:assetWriterOutputFileType:";
		static readonly NativeHandle selRecommendedMovieMetadataForVideoCodecType_AssetWriterOutputFileType_XHandle = Selector.GetHandle ("recommendedMovieMetadataForVideoCodecType:assetWriterOutputFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecommendedVideoSettingsForAssetWriterWithOutputFileType_X = "recommendedVideoSettingsForAssetWriterWithOutputFileType:";
		static readonly NativeHandle selRecommendedVideoSettingsForAssetWriterWithOutputFileType_XHandle = Selector.GetHandle ("recommendedVideoSettingsForAssetWriterWithOutputFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_X = "recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:";
		static readonly NativeHandle selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_XHandle = Selector.GetHandle ("recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_OutputFileURL_X = "recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:outputFileURL:";
		static readonly NativeHandle selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_OutputFileURL_XHandle = Selector.GetHandle ("recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:outputFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleBufferCallbackQueueX = "sampleBufferCallbackQueue";
		static readonly NativeHandle selSampleBufferCallbackQueueXHandle = Selector.GetHandle ("sampleBufferCallbackQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleBufferDelegateX = "sampleBufferDelegate";
		static readonly NativeHandle selSampleBufferDelegateXHandle = Selector.GetHandle ("sampleBufferDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlwaysDiscardsLateVideoFrames_X = "setAlwaysDiscardsLateVideoFrames:";
		static readonly NativeHandle selSetAlwaysDiscardsLateVideoFrames_XHandle = Selector.GetHandle ("setAlwaysDiscardsLateVideoFrames:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinFrameDuration_X = "setMinFrameDuration:";
		static readonly NativeHandle selSetMinFrameDuration_XHandle = Selector.GetHandle ("setMinFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreservesDynamicHDRMetadata_X = "setPreservesDynamicHDRMetadata:";
		static readonly NativeHandle selSetPreservesDynamicHDRMetadata_XHandle = Selector.GetHandle ("setPreservesDynamicHDRMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSampleBufferDelegate_Queue_X = "setSampleBufferDelegate:queue:";
		static readonly NativeHandle selSetSampleBufferDelegate_Queue_XHandle = Selector.GetHandle ("setSampleBufferDelegate:queue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVideoSettings_X = "setVideoSettings:";
		static readonly NativeHandle selSetVideoSettings_XHandle = Selector.GetHandle ("setVideoSettings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoSettingsX = "videoSettings";
		static readonly NativeHandle selVideoSettingsXHandle = Selector.GetHandle ("videoSettings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureVideoDataOutput");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVCaptureVideoDataOutput" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCaptureVideoDataOutput () : base (NSObjectFlag.Empty)
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
		protected AVCaptureVideoDataOutput (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureVideoDataOutput (NativeHandle handle) : base (handle)
		{
		}

		[Export ("availableVideoCodecTypesForAssetWriterWithOutputFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetAvailableVideoCodecTypes (string outputFileType)
		{
			if (outputFileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputFileType));
			var nsoutputFileType = CFString.CreateNative (outputFileType);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_XHandle, nsoutputFileType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_XHandle, nsoutputFileType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsoutputFileType);
			return ret!;
		}
		/// <param name="videoCodecType">The codec to check.</param><param name="outputFileType">The output file type to check.</param><summary>Returns the recommended settings for the specified codec type and output file type.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerItemVideoOutputSettings? GetRecommendedVideoSettings (string videoCodecType, string outputFileType)
		{
			return new AVPlayerItemVideoOutputSettings (GetWeakRecommendedVideoSettings (videoCodecType, outputFileType)!);
		}
		[Export ("recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:outputFileURL:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? GetRecommendedVideoSettings (string videoCodecType, string outputFileType, NSUrl? outputFileUrl)
		{
			if (videoCodecType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (videoCodecType));
			if (outputFileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputFileType));
			var outputFileUrl__handle__ = outputFileUrl.GetHandle ();
			var nsvideoCodecType = CFString.CreateNative (videoCodecType);
			var nsoutputFileType = CFString.CreateNative (outputFileType);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_OutputFileURL_XHandle, nsvideoCodecType, nsoutputFileType, outputFileUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_OutputFileURL_XHandle, nsvideoCodecType, nsoutputFileType, outputFileUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputFileUrl);
			CFString.ReleaseNative (nsvideoCodecType);
			CFString.ReleaseNative (nsoutputFileType);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerItemVideoOutputSettings? GetRecommendedVideoSettings ([BindAs (typeof (AVVideoCodecType), OriginalType = typeof (NSString))] global::AVFoundation.AVVideoCodecType videoCodecType, [BindAs (typeof (AVFileTypes), OriginalType = typeof (NSString))] global::AVFoundation.AVFileTypes outputFileType, NSUrl? outputFileUrl)
		{
			return new AVPlayerItemVideoOutputSettings (GetRecommendedVideoSettings ((string) videoCodecType.GetConstant ()!, (string) outputFileType.GetConstant ()!, outputFileUrl)!);
		}
		[Export ("recommendedVideoSettingsForAssetWriterWithOutputFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? GetRecommendedVideoSettingsForAssetWriter (string outputFileType)
		{
			if (outputFileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputFileType));
			var nsoutputFileType = CFString.CreateNative (outputFileType);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selRecommendedVideoSettingsForAssetWriterWithOutputFileType_XHandle, nsoutputFileType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selRecommendedVideoSettingsForAssetWriterWithOutputFileType_XHandle, nsoutputFileType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsoutputFileType);
			return ret!;
		}
		[Export ("recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSDictionary? GetWeakRecommendedVideoSettings (string videoCodecType, string outputFileType)
		{
			if (videoCodecType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (videoCodecType));
			if (outputFileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputFileType));
			var nsvideoCodecType = CFString.CreateNative (videoCodecType);
			var nsoutputFileType = CFString.CreateNative (outputFileType);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_XHandle, nsvideoCodecType, nsoutputFileType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_XHandle, nsvideoCodecType, nsoutputFileType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvideoCodecType);
			CFString.ReleaseNative (nsoutputFileType);
			return ret!;
		}
		[Export ("recommendedMovieMetadataForVideoCodecType:assetWriterOutputFileType:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem[]? RecommendedMovieMetadata (string videoCodecType, string outputFileType)
		{
			if (videoCodecType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (videoCodecType));
			if (outputFileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputFileType));
			var nsvideoCodecType = CFString.CreateNative (videoCodecType);
			var nsoutputFileType = CFString.CreateNative (outputFileType);
			AVMetadataItem[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRecommendedMovieMetadataForVideoCodecType_AssetWriterOutputFileType_XHandle, nsvideoCodecType, nsoutputFileType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRecommendedMovieMetadataForVideoCodecType_AssetWriterOutputFileType_XHandle, nsvideoCodecType, nsoutputFileType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvideoCodecType);
			CFString.ReleaseNative (nsoutputFileType);
			return ret!;
		}
		[Export ("setSampleBufferDelegate:queue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSampleBufferDelegate (IAVCaptureVideoDataOutputSampleBufferDelegate? sampleBufferDelegate, global::CoreFoundation.DispatchQueue? sampleBufferCallbackQueue)
		{
			var sampleBufferDelegate__handle__ = sampleBufferDelegate.GetHandle ();
			var sampleBufferCallbackQueue__handle__ = sampleBufferCallbackQueue.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetSampleBufferDelegate_Queue_XHandle, sampleBufferDelegate__handle__, sampleBufferCallbackQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetSampleBufferDelegate_Queue_XHandle, sampleBufferDelegate__handle__, sampleBufferCallbackQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleBufferDelegate);
			GC.KeepAlive (sampleBufferCallbackQueue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AlwaysDiscardsLateVideoFrames {
			[Export ("alwaysDiscardsLateVideoFrames")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAlwaysDiscardsLateVideoFramesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAlwaysDiscardsLateVideoFramesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAlwaysDiscardsLateVideoFrames:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAlwaysDiscardsLateVideoFrames_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAlwaysDiscardsLateVideoFrames_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (global::CoreVideo.CVPixelFormatType[]), OriginalType = typeof (NSNumber[]))]
		public virtual global::CoreVideo.CVPixelFormatType[] AvailableVideoCVPixelFormatTypes {
			[Export ("availableVideoCVPixelFormatTypes")]
			get {
				global::CoreVideo.CVPixelFormatType[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::CoreVideo.CVPixelFormatType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableVideoCVPixelFormatTypesXHandle), ptr => (global::CoreVideo.CVPixelFormatType) NSNumber.ToUInt32 (ptr), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::CoreVideo.CVPixelFormatType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableVideoCVPixelFormatTypesXHandle), ptr => (global::CoreVideo.CVPixelFormatType) NSNumber.ToUInt32 (ptr), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] AvailableVideoCodecTypes {
			[Export ("availableVideoCodecTypes")]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableVideoCodecTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableVideoCodecTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVVideoSettingsCompressed CompressedVideoSetting {
			get {
				var src = WeakVideoSettings is not null ? new NSMutableDictionary (WeakVideoSettings) : null;
				return src is null ? null! : new AVVideoSettingsCompressed(src);
			}
			set {
				WeakVideoSettings = value.GetDictionary ()!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios5.0", "Use 'AVCaptureConnection.MinVideoFrameDuration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVCaptureConnection.MinVideoFrameDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreMedia.CMTime MinFrameDuration {
			[Export ("minFrameDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selMinFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selMinFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selMinFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selMinFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setMinFrameDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetMinFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetMinFrameDuration_XHandle, value);
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
		public virtual bool PreservesDynamicHdrMetadata {
			[Export ("preservesDynamicHDRMetadata")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPreservesDynamicHDRMetadataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPreservesDynamicHDRMetadataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPreservesDynamicHDRMetadata:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPreservesDynamicHDRMetadata_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPreservesDynamicHDRMetadata_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual int RecommendedMediaTimeScaleForAssetWriter {
			[Export ("recommendedMediaTimeScaleForAssetWriter")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selRecommendedMediaTimeScaleForAssetWriterXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selRecommendedMediaTimeScaleForAssetWriterXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreFoundation.DispatchQueue? SampleBufferCallbackQueue {
			[Export ("sampleBufferCallbackQueue")]
			get {
				global::CoreFoundation.DispatchQueue ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSampleBufferCallbackQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSampleBufferCallbackQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAVCaptureVideoDataOutputSampleBufferDelegate? SampleBufferDelegate {
			[Export ("sampleBufferDelegate")]
			get {
				IAVCaptureVideoDataOutputSampleBufferDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAVCaptureVideoDataOutputSampleBufferDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSampleBufferDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVCaptureVideoDataOutputSampleBufferDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSampleBufferDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVVideoSettingsUncompressed UncompressedVideoSetting {
			get {
				var src = WeakVideoSettings is not null ? new NSMutableDictionary (WeakVideoSettings) : null;
				return src is null ? null! : new AVVideoSettingsUncompressed(src);
			}
			set {
				WeakVideoSettings = value.GetDictionary ()!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? WeakVideoSettings {
			[Export ("videoSettings", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoSettingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoSettingsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoSettings:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVideoSettings_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVideoSettings_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class AVCaptureVideoDataOutput */
}
