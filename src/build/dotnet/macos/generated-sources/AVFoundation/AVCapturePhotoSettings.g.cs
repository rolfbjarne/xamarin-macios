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
	/// <summary>Contains settings for capturing photos.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/AVFoundation/AVCapturePhotoSettings">Apple documentation for <c>AVCapturePhotoSettings</c></related>
	[Register("AVCapturePhotoSettings", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCapturePhotoSettings : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableEmbeddedThumbnailPhotoCodecTypesX = "availableEmbeddedThumbnailPhotoCodecTypes";
		static readonly NativeHandle selAvailableEmbeddedThumbnailPhotoCodecTypesXHandle = Selector.GetHandle ("availableEmbeddedThumbnailPhotoCodecTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailablePreviewPhotoPixelFormatTypesX = "availablePreviewPhotoPixelFormatTypes";
		static readonly NativeHandle selAvailablePreviewPhotoPixelFormatTypesXHandle = Selector.GetHandle ("availablePreviewPhotoPixelFormatTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEmbeddedThumbnailPhotoFormatX = "embeddedThumbnailPhotoFormat";
		static readonly NativeHandle selEmbeddedThumbnailPhotoFormatXHandle = Selector.GetHandle ("embeddedThumbnailPhotoFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEmbedsDepthDataInPhotoX = "embedsDepthDataInPhoto";
		static readonly NativeHandle selEmbedsDepthDataInPhotoXHandle = Selector.GetHandle ("embedsDepthDataInPhoto");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlashModeX = "flashMode";
		static readonly NativeHandle selFlashModeXHandle = Selector.GetHandle ("flashMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatX = "format";
		static readonly NativeHandle selFormatXHandle = Selector.GetHandle ("format");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutoDualCameraFusionEnabledX = "isAutoDualCameraFusionEnabled";
		static readonly NativeHandle selIsAutoDualCameraFusionEnabledXHandle = Selector.GetHandle ("isAutoDualCameraFusionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCameraCalibrationDataDeliveryEnabledX = "isCameraCalibrationDataDeliveryEnabled";
		static readonly NativeHandle selIsCameraCalibrationDataDeliveryEnabledXHandle = Selector.GetHandle ("isCameraCalibrationDataDeliveryEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConstantColorEnabledX = "isConstantColorEnabled";
		static readonly NativeHandle selIsConstantColorEnabledXHandle = Selector.GetHandle ("isConstantColorEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConstantColorFallbackPhotoDeliveryEnabledX = "isConstantColorFallbackPhotoDeliveryEnabled";
		static readonly NativeHandle selIsConstantColorFallbackPhotoDeliveryEnabledXHandle = Selector.GetHandle ("isConstantColorFallbackPhotoDeliveryEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDepthDataDeliveryEnabledX = "isDepthDataDeliveryEnabled";
		static readonly NativeHandle selIsDepthDataDeliveryEnabledXHandle = Selector.GetHandle ("isDepthDataDeliveryEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDepthDataFilteredX = "isDepthDataFiltered";
		static readonly NativeHandle selIsDepthDataFilteredXHandle = Selector.GetHandle ("isDepthDataFiltered");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDualCameraDualPhotoDeliveryEnabledX = "isDualCameraDualPhotoDeliveryEnabled";
		static readonly NativeHandle selIsDualCameraDualPhotoDeliveryEnabledXHandle = Selector.GetHandle ("isDualCameraDualPhotoDeliveryEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHighResolutionPhotoEnabledX = "isHighResolutionPhotoEnabled";
		static readonly NativeHandle selIsHighResolutionPhotoEnabledXHandle = Selector.GetHandle ("isHighResolutionPhotoEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsShutterSoundSuppressionEnabledX = "isShutterSoundSuppressionEnabled";
		static readonly NativeHandle selIsShutterSoundSuppressionEnabledXHandle = Selector.GetHandle ("isShutterSoundSuppressionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLivePhotoMovieFileURLX = "livePhotoMovieFileURL";
		static readonly NativeHandle selLivePhotoMovieFileURLXHandle = Selector.GetHandle ("livePhotoMovieFileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLivePhotoMovieMetadataX = "livePhotoMovieMetadata";
		static readonly NativeHandle selLivePhotoMovieMetadataXHandle = Selector.GetHandle ("livePhotoMovieMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLivePhotoVideoCodecTypeX = "livePhotoVideoCodecType";
		static readonly NativeHandle selLivePhotoVideoCodecTypeXHandle = Selector.GetHandle ("livePhotoVideoCodecType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxPhotoDimensionsX = "maxPhotoDimensions";
		static readonly NativeHandle selMaxPhotoDimensionsXHandle = Selector.GetHandle ("maxPhotoDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataX = "metadata";
		static readonly NativeHandle selMetadataXHandle = Selector.GetHandle ("metadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoQualityPrioritizationX = "photoQualityPrioritization";
		static readonly NativeHandle selPhotoQualityPrioritizationXHandle = Selector.GetHandle ("photoQualityPrioritization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoSettingsX = "photoSettings";
		static readonly NativeHandle selPhotoSettingsXHandle = Selector.GetHandle ("photoSettings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoSettingsFromPhotoSettings_X = "photoSettingsFromPhotoSettings:";
		static readonly NativeHandle selPhotoSettingsFromPhotoSettings_XHandle = Selector.GetHandle ("photoSettingsFromPhotoSettings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoSettingsWithFormat_X = "photoSettingsWithFormat:";
		static readonly NativeHandle selPhotoSettingsWithFormat_XHandle = Selector.GetHandle ("photoSettingsWithFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoSettingsWithRawPixelFormatType_X = "photoSettingsWithRawPixelFormatType:";
		static readonly NativeHandle selPhotoSettingsWithRawPixelFormatType_XHandle = Selector.GetHandle ("photoSettingsWithRawPixelFormatType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoSettingsWithRawPixelFormatType_ProcessedFormat_X = "photoSettingsWithRawPixelFormatType:processedFormat:";
		static readonly NativeHandle selPhotoSettingsWithRawPixelFormatType_ProcessedFormat_XHandle = Selector.GetHandle ("photoSettingsWithRawPixelFormatType:processedFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhotoSettingsWithRawPixelFormatType_RawFileType_ProcessedFormat_ProcessedFileType_X = "photoSettingsWithRawPixelFormatType:rawFileType:processedFormat:processedFileType:";
		static readonly NativeHandle selPhotoSettingsWithRawPixelFormatType_RawFileType_ProcessedFormat_ProcessedFileType_XHandle = Selector.GetHandle ("photoSettingsWithRawPixelFormatType:rawFileType:processedFormat:processedFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewPhotoFormatX = "previewPhotoFormat";
		static readonly NativeHandle selPreviewPhotoFormatXHandle = Selector.GetHandle ("previewPhotoFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessedFileTypeX = "processedFileType";
		static readonly NativeHandle selProcessedFileTypeXHandle = Selector.GetHandle ("processedFileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRawFileTypeX = "rawFileType";
		static readonly NativeHandle selRawFileTypeXHandle = Selector.GetHandle ("rawFileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRawPhotoPixelFormatTypeX = "rawPhotoPixelFormatType";
		static readonly NativeHandle selRawPhotoPixelFormatTypeXHandle = Selector.GetHandle ("rawPhotoPixelFormatType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoDualCameraFusionEnabled_X = "setAutoDualCameraFusionEnabled:";
		static readonly NativeHandle selSetAutoDualCameraFusionEnabled_XHandle = Selector.GetHandle ("setAutoDualCameraFusionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraCalibrationDataDeliveryEnabled_X = "setCameraCalibrationDataDeliveryEnabled:";
		static readonly NativeHandle selSetCameraCalibrationDataDeliveryEnabled_XHandle = Selector.GetHandle ("setCameraCalibrationDataDeliveryEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstantColorEnabled_X = "setConstantColorEnabled:";
		static readonly NativeHandle selSetConstantColorEnabled_XHandle = Selector.GetHandle ("setConstantColorEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstantColorFallbackPhotoDeliveryEnabled_X = "setConstantColorFallbackPhotoDeliveryEnabled:";
		static readonly NativeHandle selSetConstantColorFallbackPhotoDeliveryEnabled_XHandle = Selector.GetHandle ("setConstantColorFallbackPhotoDeliveryEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDepthDataDeliveryEnabled_X = "setDepthDataDeliveryEnabled:";
		static readonly NativeHandle selSetDepthDataDeliveryEnabled_XHandle = Selector.GetHandle ("setDepthDataDeliveryEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDepthDataFiltered_X = "setDepthDataFiltered:";
		static readonly NativeHandle selSetDepthDataFiltered_XHandle = Selector.GetHandle ("setDepthDataFiltered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDualCameraDualPhotoDeliveryEnabled_X = "setDualCameraDualPhotoDeliveryEnabled:";
		static readonly NativeHandle selSetDualCameraDualPhotoDeliveryEnabled_XHandle = Selector.GetHandle ("setDualCameraDualPhotoDeliveryEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEmbeddedThumbnailPhotoFormat_X = "setEmbeddedThumbnailPhotoFormat:";
		static readonly NativeHandle selSetEmbeddedThumbnailPhotoFormat_XHandle = Selector.GetHandle ("setEmbeddedThumbnailPhotoFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEmbedsDepthDataInPhoto_X = "setEmbedsDepthDataInPhoto:";
		static readonly NativeHandle selSetEmbedsDepthDataInPhoto_XHandle = Selector.GetHandle ("setEmbedsDepthDataInPhoto:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFlashMode_X = "setFlashMode:";
		static readonly NativeHandle selSetFlashMode_XHandle = Selector.GetHandle ("setFlashMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighResolutionPhotoEnabled_X = "setHighResolutionPhotoEnabled:";
		static readonly NativeHandle selSetHighResolutionPhotoEnabled_XHandle = Selector.GetHandle ("setHighResolutionPhotoEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLivePhotoMovieFileURL_X = "setLivePhotoMovieFileURL:";
		static readonly NativeHandle selSetLivePhotoMovieFileURL_XHandle = Selector.GetHandle ("setLivePhotoMovieFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLivePhotoMovieMetadata_X = "setLivePhotoMovieMetadata:";
		static readonly NativeHandle selSetLivePhotoMovieMetadata_XHandle = Selector.GetHandle ("setLivePhotoMovieMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLivePhotoVideoCodecType_X = "setLivePhotoVideoCodecType:";
		static readonly NativeHandle selSetLivePhotoVideoCodecType_XHandle = Selector.GetHandle ("setLivePhotoVideoCodecType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxPhotoDimensions_X = "setMaxPhotoDimensions:";
		static readonly NativeHandle selSetMaxPhotoDimensions_XHandle = Selector.GetHandle ("setMaxPhotoDimensions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMetadata_X = "setMetadata:";
		static readonly NativeHandle selSetMetadata_XHandle = Selector.GetHandle ("setMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPhotoQualityPrioritization_X = "setPhotoQualityPrioritization:";
		static readonly NativeHandle selSetPhotoQualityPrioritization_XHandle = Selector.GetHandle ("setPhotoQualityPrioritization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreviewPhotoFormat_X = "setPreviewPhotoFormat:";
		static readonly NativeHandle selSetPreviewPhotoFormat_XHandle = Selector.GetHandle ("setPreviewPhotoFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShutterSoundSuppressionEnabled_X = "setShutterSoundSuppressionEnabled:";
		static readonly NativeHandle selSetShutterSoundSuppressionEnabled_XHandle = Selector.GetHandle ("setShutterSoundSuppressionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniqueIDX = "uniqueID";
		static readonly NativeHandle selUniqueIDXHandle = Selector.GetHandle ("uniqueID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCapturePhotoSettings");
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
		protected AVCapturePhotoSettings (NSObjectFlag t) : base (t)
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
		protected internal AVCapturePhotoSettings (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("photoSettings")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCapturePhotoSettings Create ()
		{
			AVCapturePhotoSettings ret;
			ret =  Runtime.GetNSObject<AVCapturePhotoSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPhotoSettingsXHandle), false)!;
			return ret;
		}
		[Export ("photoSettingsWithFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCapturePhotoSettings FromFormat (NSDictionary<NSString, NSObject>? format)
		{
			var format__handle__ = format.GetHandle ();
			AVCapturePhotoSettings? ret;
			ret =  Runtime.GetNSObject<AVCapturePhotoSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPhotoSettingsWithFormat_XHandle, format__handle__), false)!;
			GC.KeepAlive (format);
			return ret!;
		}
		[Export ("photoSettingsFromPhotoSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCapturePhotoSettings FromPhotoSettings (AVCapturePhotoSettings photoSettings)
		{
			var photoSettings__handle__ = photoSettings!.GetNonNullHandle (nameof (photoSettings));
			AVCapturePhotoSettings? ret;
			ret =  Runtime.GetNSObject<AVCapturePhotoSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPhotoSettingsFromPhotoSettings_XHandle, photoSettings__handle__), false)!;
			GC.KeepAlive (photoSettings);
			return ret!;
		}
		[Export ("photoSettingsWithRawPixelFormatType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCapturePhotoSettings FromRawPixelFormatType (uint rawPixelFormatType)
		{
			AVCapturePhotoSettings ret;
			ret =  Runtime.GetNSObject<AVCapturePhotoSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (class_ptr, selPhotoSettingsWithRawPixelFormatType_XHandle, rawPixelFormatType), false)!;
			return ret;
		}
		[Export ("photoSettingsWithRawPixelFormatType:processedFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCapturePhotoSettings FromRawPixelFormatType (uint rawPixelFormatType, NSDictionary<NSString, NSObject>? processedFormat)
		{
			var processedFormat__handle__ = processedFormat.GetHandle ();
			AVCapturePhotoSettings? ret;
			ret =  Runtime.GetNSObject<AVCapturePhotoSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_NativeHandle (class_ptr, selPhotoSettingsWithRawPixelFormatType_ProcessedFormat_XHandle, rawPixelFormatType, processedFormat__handle__), false)!;
			GC.KeepAlive (processedFormat);
			return ret!;
		}
		[Export ("photoSettingsWithRawPixelFormatType:rawFileType:processedFormat:processedFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCapturePhotoSettings FromRawPixelFormatType (uint rawPixelFormatType, string? rawFileType, NSDictionary<NSString, NSObject>? processedFormat, string? processedFileType)
		{
			var processedFormat__handle__ = processedFormat.GetHandle ();
			var nsrawFileType = CFString.CreateNative (rawFileType);
			var nsprocessedFileType = CFString.CreateNative (processedFileType);
			AVCapturePhotoSettings? ret;
			ret =  Runtime.GetNSObject<AVCapturePhotoSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPhotoSettingsWithRawPixelFormatType_RawFileType_ProcessedFormat_ProcessedFileType_XHandle, rawPixelFormatType, nsrawFileType, processedFormat__handle__, nsprocessedFileType), false)!;
			GC.KeepAlive (processedFormat);
			CFString.ReleaseNative (nsrawFileType);
			CFString.ReleaseNative (nsprocessedFileType);
			return ret!;
		}
		/// <summary>Gets or sets a Boolean value that controls whether images from two built-in cameras will automatically be combined into one high quality image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AutoVirtualDeviceFusionEnabled' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AutoVirtualDeviceFusionEnabled' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool AutoDualCameraFusionEnabled {
			[Export ("isAutoDualCameraFusionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoDualCameraFusionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutoDualCameraFusionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoDualCameraFusionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoDualCameraFusionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoDualCameraFusionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the list of supported photo codec types.</summary><value>Te list of supported photo codec types.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVVideoCodecType[] AvailableEmbeddedThumbnailPhotoCodecTypes {
			get {
				return (Array.ConvertAll (_GetAvailableEmbeddedThumbnailPhotoCodecTypes, s => AVVideoCodecTypeExtensions.GetValue (s)) as AVVideoCodecType[])!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] AvailablePreviewPhotoPixelFormatTypes {
			[Export ("availablePreviewPhotoPixelFormatTypes")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailablePreviewPhotoPixelFormatTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailablePreviewPhotoPixelFormatTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool CameraCalibrationDataDeliveryEnabled {
			[Export ("isCameraCalibrationDataDeliveryEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCameraCalibrationDataDeliveryEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCameraCalibrationDataDeliveryEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCameraCalibrationDataDeliveryEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCameraCalibrationDataDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCameraCalibrationDataDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual bool ConstantColorEnabled {
			[Export ("isConstantColorEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConstantColorEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConstantColorEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setConstantColorEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetConstantColorEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetConstantColorEnabled_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual bool ConstantColorFallbackPhotoDeliveryEnabled {
			[Export ("isConstantColorFallbackPhotoDeliveryEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConstantColorFallbackPhotoDeliveryEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConstantColorFallbackPhotoDeliveryEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setConstantColorFallbackPhotoDeliveryEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetConstantColorFallbackPhotoDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetConstantColorFallbackPhotoDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool DepthDataDeliveryEnabled {
			[Export ("isDepthDataDeliveryEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDepthDataDeliveryEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDepthDataDeliveryEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDepthDataDeliveryEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDepthDataDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDepthDataDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool DepthDataFiltered {
			[Export ("isDepthDataFiltered")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDepthDataFilteredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDepthDataFilteredXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDepthDataFiltered:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDepthDataFiltered_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDepthDataFiltered_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'VirtualDeviceConstituentPhotoDeliveryEnabled' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'VirtualDeviceConstituentPhotoDeliveryEnabled' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'VirtualDeviceConstituentPhotoDeliveryEnabled' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool DualCameraDualPhotoDeliveryEnabled {
			[Export ("isDualCameraDualPhotoDeliveryEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDualCameraDualPhotoDeliveryEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDualCameraDualPhotoDeliveryEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDualCameraDualPhotoDeliveryEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDualCameraDualPhotoDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDualCameraDualPhotoDeliveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public AVCapturePhotoSettingsThumbnailFormat EmbeddedThumbnailPhotoFormat {
			get {
				var src = WeakEmbeddedThumbnailPhotoFormat is not null ? new NSMutableDictionary (WeakEmbeddedThumbnailPhotoFormat) : null;
				return src is null ? null! : new AVCapturePhotoSettingsThumbnailFormat(src);
			}
			set {
				WeakEmbeddedThumbnailPhotoFormat = value.GetDictionary ()!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool EmbedsDepthDataInPhoto {
			[Export ("embedsDepthDataInPhoto")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEmbedsDepthDataInPhotoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEmbedsDepthDataInPhotoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEmbedsDepthDataInPhoto:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEmbedsDepthDataInPhoto_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEmbedsDepthDataInPhoto_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureFlashMode FlashMode {
			[Export ("flashMode", ArgumentSemantic.Assign)]
			get {
				AVCaptureFlashMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureFlashMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFlashModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureFlashMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFlashModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFlashMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFlashMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetFlashMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? Format {
			[Export ("format", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the highest available resolution will be used when capturing images.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios16.0", "Use 'MaxPhotoDimensions' instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use 'MaxPhotoDimensions' instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use 'MaxPhotoDimensions' instead.")]
		[ObsoletedOSPlatform ("macos13.0", "Use 'MaxPhotoDimensions' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool IsHighResolutionPhotoEnabled {
			[Export ("isHighResolutionPhotoEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighResolutionPhotoEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHighResolutionPhotoEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHighResolutionPhotoEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHighResolutionPhotoEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHighResolutionPhotoEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? LivePhotoMovieFileUrl {
			[Export ("livePhotoMovieFileURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLivePhotoMovieFileURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLivePhotoMovieFileURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLivePhotoMovieFileURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLivePhotoMovieFileURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLivePhotoMovieFileURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem[]? LivePhotoMovieMetadata {
			[Export ("livePhotoMovieMetadata", ArgumentSemantic.Copy)]
			get {
				AVMetadataItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLivePhotoMovieMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLivePhotoMovieMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLivePhotoMovieMetadata:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLivePhotoMovieMetadata_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLivePhotoMovieMetadata_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual string LivePhotoVideoCodecType {
			[Export ("livePhotoVideoCodecType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLivePhotoVideoCodecTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLivePhotoVideoCodecTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLivePhotoVideoCodecType:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLivePhotoVideoCodecType_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLivePhotoVideoCodecType_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual global::CoreMedia.CMVideoDimensions MaxPhotoDimensions {
			[Export ("maxPhotoDimensions")]
			get {
				global::CoreMedia.CMVideoDimensions ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (this.Handle, selMaxPhotoDimensionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSendSuper (&__objc_super__, selMaxPhotoDimensionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxPhotoDimensions:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMVideoDimensions (this.Handle, selSetMaxPhotoDimensions_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMVideoDimensions (&__objc_super__, selSetMaxPhotoDimensions_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMetadata:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMetadata_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMetadata_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCapturePhotoQualityPrioritization PhotoQualityPrioritization {
			[Export ("photoQualityPrioritization", ArgumentSemantic.Assign)]
			get {
				AVCapturePhotoQualityPrioritization ret;
				if (IsDirectBinding) {
					ret = (AVCapturePhotoQualityPrioritization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPhotoQualityPrioritizationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePhotoQualityPrioritization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPhotoQualityPrioritizationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPhotoQualityPrioritization:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPhotoQualityPrioritization_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPhotoQualityPrioritization_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? PreviewPhotoFormat {
			[Export ("previewPhotoFormat", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewPhotoFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewPhotoFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreviewPhotoFormat:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreviewPhotoFormat_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreviewPhotoFormat_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual string? ProcessedFileType {
			[Export ("processedFileType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProcessedFileTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProcessedFileTypeXHandle), false)!;
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
		[SupportedOSPlatform ("tvos17.0")]
		public virtual string? RawFileType {
			[Export ("rawFileType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRawFileTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRawFileTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint RawPhotoPixelFormatType {
			[Export ("rawPhotoPixelFormatType")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRawPhotoPixelFormatTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selRawPhotoPixelFormatTypeXHandle);
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
		public virtual bool ShutterSoundSuppressionEnabled {
			[Export ("isShutterSoundSuppressionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShutterSoundSuppressionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsShutterSoundSuppressionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShutterSoundSuppressionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShutterSoundSuppressionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShutterSoundSuppressionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long UniqueID {
			[Export ("uniqueID")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selUniqueIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selUniqueIDXHandle);
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
		[SupportedOSPlatform ("tvos17.0")]
		public virtual NSDictionary? WeakEmbeddedThumbnailPhotoFormat {
			[Export ("embeddedThumbnailPhotoFormat", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEmbeddedThumbnailPhotoFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEmbeddedThumbnailPhotoFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setEmbeddedThumbnailPhotoFormat:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetEmbeddedThumbnailPhotoFormat_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetEmbeddedThumbnailPhotoFormat_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		internal virtual NSString[] _GetAvailableEmbeddedThumbnailPhotoCodecTypes {
			[Export ("availableEmbeddedThumbnailPhotoCodecTypes")]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableEmbeddedThumbnailPhotoCodecTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableEmbeddedThumbnailPhotoCodecTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVCapturePhotoSettings */
}
