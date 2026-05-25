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
	/// <summary>Describes media data, especially video data. (Wraps <see cref="T:CoreMedia.CMFormatDescription" />.)</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureDeviceFormat_Class/index.html">Apple documentation for <c>AVCaptureDeviceFormat</c></related>
	[Register("AVCaptureDeviceFormat", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCaptureDeviceFormat : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoFocusSystemX = "autoFocusSystem";
		static readonly NativeHandle selAutoFocusSystemXHandle = Selector.GetHandle ("autoFocusSystem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultSimulatedApertureX = "defaultSimulatedAperture";
		static readonly NativeHandle selDefaultSimulatedApertureXHandle = Selector.GetHandle ("defaultSimulatedAperture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatDescriptionX = "formatDescription";
		static readonly NativeHandle selFormatDescriptionXHandle = Selector.GetHandle ("formatDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutoVideoFrameRateSupportedX = "isAutoVideoFrameRateSupported";
		static readonly NativeHandle selIsAutoVideoFrameRateSupportedXHandle = Selector.GetHandle ("isAutoVideoFrameRateSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBackgroundReplacementSupportedX = "isBackgroundReplacementSupported";
		static readonly NativeHandle selIsBackgroundReplacementSupportedXHandle = Selector.GetHandle ("isBackgroundReplacementSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCameraLensSmudgeDetectionSupportedX = "isCameraLensSmudgeDetectionSupported";
		static readonly NativeHandle selIsCameraLensSmudgeDetectionSupportedXHandle = Selector.GetHandle ("isCameraLensSmudgeDetectionSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCenterStageSupportedX = "isCenterStageSupported";
		static readonly NativeHandle selIsCenterStageSupportedXHandle = Selector.GetHandle ("isCenterStageSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCinematicVideoCaptureSupportedX = "isCinematicVideoCaptureSupported";
		static readonly NativeHandle selIsCinematicVideoCaptureSupportedXHandle = Selector.GetHandle ("isCinematicVideoCaptureSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEdgeLightSupportedX = "isEdgeLightSupported";
		static readonly NativeHandle selIsEdgeLightSupportedXHandle = Selector.GetHandle ("isEdgeLightSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHighPhotoQualitySupportedX = "isHighPhotoQualitySupported";
		static readonly NativeHandle selIsHighPhotoQualitySupportedXHandle = Selector.GetHandle ("isHighPhotoQualitySupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPortraitEffectSupportedX = "isPortraitEffectSupported";
		static readonly NativeHandle selIsPortraitEffectSupportedXHandle = Selector.GetHandle ("isPortraitEffectSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSpatialVideoCaptureSupportedX = "isSpatialVideoCaptureSupported";
		static readonly NativeHandle selIsSpatialVideoCaptureSupportedXHandle = Selector.GetHandle ("isSpatialVideoCaptureSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStudioLightSupportedX = "isStudioLightSupported";
		static readonly NativeHandle selIsStudioLightSupportedXHandle = Selector.GetHandle ("isStudioLightSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxSimulatedApertureX = "maxSimulatedAperture";
		static readonly NativeHandle selMaxSimulatedApertureXHandle = Selector.GetHandle ("maxSimulatedAperture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaTypeX = "mediaType";
		static readonly NativeHandle selMediaTypeXHandle = Selector.GetHandle ("mediaType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinSimulatedApertureX = "minSimulatedAperture";
		static readonly NativeHandle selMinSimulatedApertureXHandle = Selector.GetHandle ("minSimulatedAperture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReactionEffectsSupportedX = "reactionEffectsSupported";
		static readonly NativeHandle selReactionEffectsSupportedXHandle = Selector.GetHandle ("reactionEffectsSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryNativeResolutionZoomFactorsX = "secondaryNativeResolutionZoomFactors";
		static readonly NativeHandle selSecondaryNativeResolutionZoomFactorsXHandle = Selector.GetHandle ("secondaryNativeResolutionZoomFactors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedColorSpacesX = "supportedColorSpaces";
		static readonly NativeHandle selSupportedColorSpacesXHandle = Selector.GetHandle ("supportedColorSpaces");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedMaxPhotoDimensionsX = "supportedMaxPhotoDimensions";
		static readonly NativeHandle selSupportedMaxPhotoDimensionsXHandle = Selector.GetHandle ("supportedMaxPhotoDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedVideoZoomFactorsForDepthDataDeliveryX = "supportedVideoZoomFactorsForDepthDataDelivery";
		static readonly NativeHandle selSupportedVideoZoomFactorsForDepthDataDeliveryXHandle = Selector.GetHandle ("supportedVideoZoomFactorsForDepthDataDelivery");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedVideoZoomRangesForDepthDataDeliveryX = "supportedVideoZoomRangesForDepthDataDelivery";
		static readonly NativeHandle selSupportedVideoZoomRangesForDepthDataDeliveryXHandle = Selector.GetHandle ("supportedVideoZoomRangesForDepthDataDelivery");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemRecommendedExposureBiasRangeX = "systemRecommendedExposureBiasRange";
		static readonly NativeHandle selSystemRecommendedExposureBiasRangeXHandle = Selector.GetHandle ("systemRecommendedExposureBiasRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemRecommendedVideoZoomRangeX = "systemRecommendedVideoZoomRange";
		static readonly NativeHandle selSystemRecommendedVideoZoomRangeXHandle = Selector.GetHandle ("systemRecommendedVideoZoomRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoFrameRateRangeForBackgroundReplacementX = "videoFrameRateRangeForBackgroundReplacement";
		static readonly NativeHandle selVideoFrameRateRangeForBackgroundReplacementXHandle = Selector.GetHandle ("videoFrameRateRangeForBackgroundReplacement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoFrameRateRangeForCenterStageX = "videoFrameRateRangeForCenterStage";
		static readonly NativeHandle selVideoFrameRateRangeForCenterStageXHandle = Selector.GetHandle ("videoFrameRateRangeForCenterStage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoFrameRateRangeForCinematicVideoX = "videoFrameRateRangeForCinematicVideo";
		static readonly NativeHandle selVideoFrameRateRangeForCinematicVideoXHandle = Selector.GetHandle ("videoFrameRateRangeForCinematicVideo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoFrameRateRangeForPortraitEffectX = "videoFrameRateRangeForPortraitEffect";
		static readonly NativeHandle selVideoFrameRateRangeForPortraitEffectXHandle = Selector.GetHandle ("videoFrameRateRangeForPortraitEffect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoFrameRateRangeForReactionEffectsInProgressX = "videoFrameRateRangeForReactionEffectsInProgress";
		static readonly NativeHandle selVideoFrameRateRangeForReactionEffectsInProgressXHandle = Selector.GetHandle ("videoFrameRateRangeForReactionEffectsInProgress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoFrameRateRangeForStudioLightX = "videoFrameRateRangeForStudioLight";
		static readonly NativeHandle selVideoFrameRateRangeForStudioLightXHandle = Selector.GetHandle ("videoFrameRateRangeForStudioLight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoMaxZoomFactorForCenterStageX = "videoMaxZoomFactorForCenterStage";
		static readonly NativeHandle selVideoMaxZoomFactorForCenterStageXHandle = Selector.GetHandle ("videoMaxZoomFactorForCenterStage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoMaxZoomFactorForCinematicVideoX = "videoMaxZoomFactorForCinematicVideo";
		static readonly NativeHandle selVideoMaxZoomFactorForCinematicVideoXHandle = Selector.GetHandle ("videoMaxZoomFactorForCinematicVideo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoMinZoomFactorForCenterStageX = "videoMinZoomFactorForCenterStage";
		static readonly NativeHandle selVideoMinZoomFactorForCenterStageXHandle = Selector.GetHandle ("videoMinZoomFactorForCenterStage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoMinZoomFactorForCinematicVideoX = "videoMinZoomFactorForCinematicVideo";
		static readonly NativeHandle selVideoMinZoomFactorForCinematicVideoXHandle = Selector.GetHandle ("videoMinZoomFactorForCinematicVideo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoSupportedFrameRateRangesX = "videoSupportedFrameRateRanges";
		static readonly NativeHandle selVideoSupportedFrameRateRangesXHandle = Selector.GetHandle ("videoSupportedFrameRateRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupportedX = "zoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupported";
		static readonly NativeHandle selZoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupportedXHandle = Selector.GetHandle ("zoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureDeviceFormat");
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
		protected AVCaptureDeviceFormat (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureDeviceFormat (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureAutoFocusSystem AutoFocusSystem {
			[Export ("autoFocusSystem")]
			get {
				AVCaptureAutoFocusSystem ret;
				if (IsDirectBinding) {
					ret = (AVCaptureAutoFocusSystem) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAutoFocusSystemXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureAutoFocusSystem) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAutoFocusSystemXHandle);
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
		public virtual bool AutoVideoFrameRateSupported {
			[Export ("isAutoVideoFrameRateSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoVideoFrameRateSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutoVideoFrameRateSupportedXHandle);
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
		public virtual bool BackgroundReplacementSupported {
			[Export ("isBackgroundReplacementSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBackgroundReplacementSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBackgroundReplacementSupportedXHandle);
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
		public virtual bool CameraLensSmudgeDetectionSupported {
			[Export ("isCameraLensSmudgeDetectionSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCameraLensSmudgeDetectionSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCameraLensSmudgeDetectionSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool CenterStageSupported {
			[Export ("isCenterStageSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCenterStageSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCenterStageSupportedXHandle);
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
		public virtual bool CinematicVideoCaptureSupported {
			[Export ("isCinematicVideoCaptureSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCinematicVideoCaptureSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCinematicVideoCaptureSupportedXHandle);
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
		public virtual float DefaultSimulatedAperture {
			[Export ("defaultSimulatedAperture")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDefaultSimulatedApertureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selDefaultSimulatedApertureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		public virtual bool EdgeLightSupported {
			[Export ("isEdgeLightSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEdgeLightSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEdgeLightSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMFormatDescription FormatDescription {
			[Export ("formatDescription", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMFormatDescription ret;
				if (IsDirectBinding) {
					ret = CMFormatDescription.Create (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CMFormatDescription.Create (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool HighPhotoQualitySupported {
			[Export ("isHighPhotoQualitySupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighPhotoQualitySupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHighPhotoQualitySupportedXHandle);
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
		public virtual float MaxSimulatedAperture {
			[Export ("maxSimulatedAperture")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaxSimulatedApertureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaxSimulatedApertureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString MediaType {
			[Export ("mediaType", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaTypeXHandle), false)!;
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
		public virtual float MinSimulatedAperture {
			[Export ("minSimulatedAperture")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinSimulatedApertureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinSimulatedApertureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		public virtual bool PortraitEffectSupported {
			[Export ("isPortraitEffectSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPortraitEffectSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPortraitEffectSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ReactionEffectsSupported {
			[Export ("reactionEffectsSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReactionEffectsSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReactionEffectsSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindAs (typeof (nfloat[]), OriginalType = typeof (NSNumber[]))]
		public virtual nfloat[] SecondaryNativeResolutionZoomFactors {
			[Export ("secondaryNativeResolutionZoomFactors")]
			get {
				nfloat[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <nfloat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSecondaryNativeResolutionZoomFactorsXHandle), NSNumber.ToNFloat, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <nfloat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSecondaryNativeResolutionZoomFactorsXHandle), NSNumber.ToNFloat, false)!;
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
		public virtual bool SpatialVideoCaptureSupported {
			[Export ("isSpatialVideoCaptureSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSpatialVideoCaptureSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSpatialVideoCaptureSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public virtual bool StudioLightSupported {
			[Export ("isStudioLightSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStudioLightSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsStudioLightSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindAs (typeof (AVCaptureColorSpace[]), OriginalType = typeof (NSNumber[]))]
		public virtual global::AVFoundation.AVCaptureColorSpace[] SupportedColorSpaces {
			[Export ("supportedColorSpaces")]
			get {
				global::AVFoundation.AVCaptureColorSpace[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVCaptureColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedColorSpacesXHandle), ptr => (global::AVFoundation.AVCaptureColorSpace) NSNumber.ToInt64 (ptr), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVCaptureColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedColorSpacesXHandle), ptr => (global::AVFoundation.AVCaptureColorSpace) NSNumber.ToInt64 (ptr), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindAs (typeof (global::CoreMedia.CMVideoDimensions[]), OriginalType = typeof (NSValue[]))]
		public virtual global::CoreMedia.CMVideoDimensions[] SupportedMaxPhotoDimensions {
			[Export ("supportedMaxPhotoDimensions")]
			get {
				global::CoreMedia.CMVideoDimensions[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::CoreMedia.CMVideoDimensions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedMaxPhotoDimensionsXHandle), NSValue.ToCMVideoDimensions, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::CoreMedia.CMVideoDimensions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedMaxPhotoDimensionsXHandle), NSValue.ToCMVideoDimensions, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios17.2")]
		[ObsoletedOSPlatform ("tvos17.2")]
		[ObsoletedOSPlatform ("maccatalyst17.2")]
		[ObsoletedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindAs (typeof (nfloat[]), OriginalType = typeof (NSNumber[]))]
		public virtual nfloat[] SupportedVideoZoomFactorsForDepthDataDelivery {
			[Export ("supportedVideoZoomFactorsForDepthDataDelivery")]
			get {
				nfloat[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <nfloat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedVideoZoomFactorsForDepthDataDeliveryXHandle), NSNumber.ToNFloat, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <nfloat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedVideoZoomFactorsForDepthDataDeliveryXHandle), NSNumber.ToNFloat, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		public virtual AVZoomRange[] SupportedVideoZoomRangesForDepthDataDelivery {
			[Export ("supportedVideoZoomRangesForDepthDataDelivery")]
			get {
				AVZoomRange[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVZoomRange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedVideoZoomRangesForDepthDataDeliveryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVZoomRange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedVideoZoomRangesForDepthDataDeliveryXHandle), false)!;
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
		public virtual AVExposureBiasRange? SystemRecommendedExposureBiasRange {
			[Export ("systemRecommendedExposureBiasRange")]
			get {
				AVExposureBiasRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVExposureBiasRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSystemRecommendedExposureBiasRangeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVExposureBiasRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSystemRecommendedExposureBiasRangeXHandle), false)!;
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
		public virtual AVZoomRange? SystemRecommendedVideoZoomRange {
			[Export ("systemRecommendedVideoZoomRange")]
			get {
				AVZoomRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVZoomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSystemRecommendedVideoZoomRangeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVZoomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSystemRecommendedVideoZoomRangeXHandle), false)!;
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
		public virtual AVFrameRateRange? VideoFrameRateRangeForBackgroundReplacement {
			[Export ("videoFrameRateRangeForBackgroundReplacement")]
			get {
				AVFrameRateRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoFrameRateRangeForBackgroundReplacementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoFrameRateRangeForBackgroundReplacementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVFrameRateRange? VideoFrameRateRangeForCenterStage {
			[Export ("videoFrameRateRangeForCenterStage")]
			get {
				AVFrameRateRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoFrameRateRangeForCenterStageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoFrameRateRangeForCenterStageXHandle), false)!;
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
		public virtual AVFrameRateRange? VideoFrameRateRangeForCinematicVideo {
			[Export ("videoFrameRateRangeForCinematicVideo")]
			get {
				AVFrameRateRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoFrameRateRangeForCinematicVideoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoFrameRateRangeForCinematicVideoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVFrameRateRange? VideoFrameRateRangeForPortraitEffect {
			[Export ("videoFrameRateRangeForPortraitEffect")]
			get {
				AVFrameRateRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoFrameRateRangeForPortraitEffectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoFrameRateRangeForPortraitEffectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual AVFrameRateRange? VideoFrameRateRangeForReactionEffectsInProgress {
			[Export ("videoFrameRateRangeForReactionEffectsInProgress")]
			get {
				AVFrameRateRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoFrameRateRangeForReactionEffectsInProgressXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoFrameRateRangeForReactionEffectsInProgressXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public virtual AVFrameRateRange? VideoFrameRateRangeForStudioLight {
			[Export ("videoFrameRateRangeForStudioLight")]
			get {
				AVFrameRateRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoFrameRateRangeForStudioLightXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVFrameRateRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoFrameRateRangeForStudioLightXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual nfloat VideoMaxZoomFactorForCenterStage {
			[Export ("videoMaxZoomFactorForCenterStage")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selVideoMaxZoomFactorForCenterStageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selVideoMaxZoomFactorForCenterStageXHandle);
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
		public virtual nfloat VideoMaxZoomFactorForCinematicVideo {
			[Export ("videoMaxZoomFactorForCinematicVideo")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selVideoMaxZoomFactorForCinematicVideoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selVideoMaxZoomFactorForCinematicVideoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual nfloat VideoMinZoomFactorForCenterStage {
			[Export ("videoMinZoomFactorForCenterStage")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selVideoMinZoomFactorForCenterStageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selVideoMinZoomFactorForCenterStageXHandle);
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
		public virtual nfloat VideoMinZoomFactorForCinematicVideo {
			[Export ("videoMinZoomFactorForCinematicVideo")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selVideoMinZoomFactorForCinematicVideoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selVideoMinZoomFactorForCinematicVideoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVFrameRateRange[] VideoSupportedFrameRateRanges {
			[Export ("videoSupportedFrameRateRanges", ArgumentSemantic.Copy)]
			get {
				AVFrameRateRange[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVFrameRateRange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoSupportedFrameRateRangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVFrameRateRange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoSupportedFrameRateRangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		public virtual bool ZoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupported {
			[Export ("zoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selZoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selZoomFactorsOutsideOfVideoZoomRangesForDepthDeliverySupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class AVCaptureDeviceFormat */
}
