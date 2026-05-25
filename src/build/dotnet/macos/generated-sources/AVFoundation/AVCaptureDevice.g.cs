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
	/// <summary>Support for accessing the audio and video capture hardware for AVCaptureSession.</summary><remarks><para>Once a capture session has begun, application developers must bracket configuration changes with calls to <see cref="M:AVFoundation.AVCaptureDevice.LockForConfiguration(Foundation.NSError@)" /> and <see cref="M:AVFoundation.AVCaptureDevice.UnlockForConfiguration" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureDevice_Class/index.html">Apple documentation for <c>AVCaptureDevice</c></related>
	[Register("AVCaptureDevice", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCaptureDevice : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveColorSpaceX = "activeColorSpace";
		static readonly NativeHandle selActiveColorSpaceXHandle = Selector.GetHandle ("activeColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveFormatX = "activeFormat";
		static readonly NativeHandle selActiveFormatXHandle = Selector.GetHandle ("activeFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveInputSourceX = "activeInputSource";
		static readonly NativeHandle selActiveInputSourceXHandle = Selector.GetHandle ("activeInputSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveMicrophoneModeX = "activeMicrophoneMode";
		static readonly NativeHandle selActiveMicrophoneModeXHandle = Selector.GetHandle ("activeMicrophoneMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivePrimaryConstituentDeviceX = "activePrimaryConstituentDevice";
		static readonly NativeHandle selActivePrimaryConstituentDeviceXHandle = Selector.GetHandle ("activePrimaryConstituentDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsX = "activePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions";
		static readonly NativeHandle selActivePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsXHandle = Selector.GetHandle ("activePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivePrimaryConstituentDeviceSwitchingBehaviorX = "activePrimaryConstituentDeviceSwitchingBehavior";
		static readonly NativeHandle selActivePrimaryConstituentDeviceSwitchingBehaviorXHandle = Selector.GetHandle ("activePrimaryConstituentDeviceSwitchingBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveVideoMaxFrameDurationX = "activeVideoMaxFrameDuration";
		static readonly NativeHandle selActiveVideoMaxFrameDurationXHandle = Selector.GetHandle ("activeVideoMaxFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveVideoMinFrameDurationX = "activeVideoMinFrameDuration";
		static readonly NativeHandle selActiveVideoMinFrameDurationXHandle = Selector.GetHandle ("activeVideoMinFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusForMediaType_X = "authorizationStatusForMediaType:";
		static readonly NativeHandle selAuthorizationStatusForMediaType_XHandle = Selector.GetHandle ("authorizationStatusForMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableReactionTypesX = "availableReactionTypes";
		static readonly NativeHandle selAvailableReactionTypesXHandle = Selector.GetHandle ("availableReactionTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraLensSmudgeDetectionIntervalX = "cameraLensSmudgeDetectionInterval";
		static readonly NativeHandle selCameraLensSmudgeDetectionIntervalXHandle = Selector.GetHandle ("cameraLensSmudgeDetectionInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraLensSmudgeDetectionStatusX = "cameraLensSmudgeDetectionStatus";
		static readonly NativeHandle selCameraLensSmudgeDetectionStatusXHandle = Selector.GetHandle ("cameraLensSmudgeDetectionStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPerformReactionEffectsX = "canPerformReactionEffects";
		static readonly NativeHandle selCanPerformReactionEffectsXHandle = Selector.GetHandle ("canPerformReactionEffects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenterStageControlModeX = "centerStageControlMode";
		static readonly NativeHandle selCenterStageControlModeXHandle = Selector.GetHandle ("centerStageControlMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenterStageRectOfInterestX = "centerStageRectOfInterest";
		static readonly NativeHandle selCenterStageRectOfInterestXHandle = Selector.GetHandle ("centerStageRectOfInterest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCinematicVideoCaptureSceneMonitoringStatusesX = "cinematicVideoCaptureSceneMonitoringStatuses";
		static readonly NativeHandle selCinematicVideoCaptureSceneMonitoringStatusesXHandle = Selector.GetHandle ("cinematicVideoCaptureSceneMonitoringStatuses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompanionDeskViewCameraX = "companionDeskViewCamera";
		static readonly NativeHandle selCompanionDeskViewCameraXHandle = Selector.GetHandle ("companionDeskViewCamera");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultDeviceWithDeviceType_MediaType_Position_X = "defaultDeviceWithDeviceType:mediaType:position:";
		static readonly NativeHandle selDefaultDeviceWithDeviceType_MediaType_Position_XHandle = Selector.GetHandle ("defaultDeviceWithDeviceType:mediaType:position:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultDeviceWithMediaType_X = "defaultDeviceWithMediaType:";
		static readonly NativeHandle selDefaultDeviceWithMediaType_XHandle = Selector.GetHandle ("defaultDeviceWithMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRectForExposurePointOfInterest_X = "defaultRectForExposurePointOfInterest:";
		static readonly NativeHandle selDefaultRectForExposurePointOfInterest_XHandle = Selector.GetHandle ("defaultRectForExposurePointOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRectForFocusPointOfInterest_X = "defaultRectForFocusPointOfInterest:";
		static readonly NativeHandle selDefaultRectForFocusPointOfInterest_XHandle = Selector.GetHandle ("defaultRectForFocusPointOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceTypeX = "deviceType";
		static readonly NativeHandle selDeviceTypeXHandle = Selector.GetHandle ("deviceType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceWithUniqueID_X = "deviceWithUniqueID:";
		static readonly NativeHandle selDeviceWithUniqueID_XHandle = Selector.GetHandle ("deviceWithUniqueID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDevicesX = "devices";
		static readonly NativeHandle selDevicesXHandle = Selector.GetHandle ("devices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDevicesWithMediaType_X = "devicesWithMediaType:";
		static readonly NativeHandle selDevicesWithMediaType_XHandle = Selector.GetHandle ("devicesWithMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayVideoZoomFactorMultiplierX = "displayVideoZoomFactorMultiplier";
		static readonly NativeHandle selDisplayVideoZoomFactorMultiplierXHandle = Selector.GetHandle ("displayVideoZoomFactorMultiplier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposureModeX = "exposureMode";
		static readonly NativeHandle selExposureModeXHandle = Selector.GetHandle ("exposureMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposurePointOfInterestX = "exposurePointOfInterest";
		static readonly NativeHandle selExposurePointOfInterestXHandle = Selector.GetHandle ("exposurePointOfInterest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposureRectOfInterestX = "exposureRectOfInterest";
		static readonly NativeHandle selExposureRectOfInterestXHandle = Selector.GetHandle ("exposureRectOfInterest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFallbackPrimaryConstituentDevicesX = "fallbackPrimaryConstituentDevices";
		static readonly NativeHandle selFallbackPrimaryConstituentDevicesXHandle = Selector.GetHandle ("fallbackPrimaryConstituentDevices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlashModeX = "flashMode";
		static readonly NativeHandle selFlashModeXHandle = Selector.GetHandle ("flashMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusModeX = "focusMode";
		static readonly NativeHandle selFocusModeXHandle = Selector.GetHandle ("focusMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusPointOfInterestX = "focusPointOfInterest";
		static readonly NativeHandle selFocusPointOfInterestXHandle = Selector.GetHandle ("focusPointOfInterest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusRectOfInterestX = "focusRectOfInterest";
		static readonly NativeHandle selFocusRectOfInterestXHandle = Selector.GetHandle ("focusRectOfInterest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatsX = "formats";
		static readonly NativeHandle selFormatsXHandle = Selector.GetHandle ("formats");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasFlashX = "hasFlash";
		static readonly NativeHandle selHasFlashXHandle = Selector.GetHandle ("hasFlash");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasMediaType_X = "hasMediaType:";
		static readonly NativeHandle selHasMediaType_XHandle = Selector.GetHandle ("hasMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasTorchX = "hasTorch";
		static readonly NativeHandle selHasTorchXHandle = Selector.GetHandle ("hasTorch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputSourcesX = "inputSources";
		static readonly NativeHandle selInputSourcesXHandle = Selector.GetHandle ("inputSources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAdjustingExposureX = "isAdjustingExposure";
		static readonly NativeHandle selIsAdjustingExposureXHandle = Selector.GetHandle ("isAdjustingExposure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAdjustingFocusX = "isAdjustingFocus";
		static readonly NativeHandle selIsAdjustingFocusXHandle = Selector.GetHandle ("isAdjustingFocus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAdjustingWhiteBalanceX = "isAdjustingWhiteBalance";
		static readonly NativeHandle selIsAdjustingWhiteBalanceXHandle = Selector.GetHandle ("isAdjustingWhiteBalance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutoVideoFrameRateEnabledX = "isAutoVideoFrameRateEnabled";
		static readonly NativeHandle selIsAutoVideoFrameRateEnabledXHandle = Selector.GetHandle ("isAutoVideoFrameRateEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBackgroundReplacementActiveX = "isBackgroundReplacementActive";
		static readonly NativeHandle selIsBackgroundReplacementActiveXHandle = Selector.GetHandle ("isBackgroundReplacementActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBackgroundReplacementEnabledX = "isBackgroundReplacementEnabled";
		static readonly NativeHandle selIsBackgroundReplacementEnabledXHandle = Selector.GetHandle ("isBackgroundReplacementEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCameraLensSmudgeDetectionEnabledX = "isCameraLensSmudgeDetectionEnabled";
		static readonly NativeHandle selIsCameraLensSmudgeDetectionEnabledXHandle = Selector.GetHandle ("isCameraLensSmudgeDetectionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCenterStageActiveX = "isCenterStageActive";
		static readonly NativeHandle selIsCenterStageActiveXHandle = Selector.GetHandle ("isCenterStageActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCenterStageEnabledX = "isCenterStageEnabled";
		static readonly NativeHandle selIsCenterStageEnabledXHandle = Selector.GetHandle ("isCenterStageEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConnectedX = "isConnected";
		static readonly NativeHandle selIsConnectedXHandle = Selector.GetHandle ("isConnected");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContinuityCameraX = "isContinuityCamera";
		static readonly NativeHandle selIsContinuityCameraXHandle = Selector.GetHandle ("isContinuityCamera");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEdgeLightActiveX = "isEdgeLightActive";
		static readonly NativeHandle selIsEdgeLightActiveXHandle = Selector.GetHandle ("isEdgeLightActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEdgeLightEnabledX = "isEdgeLightEnabled";
		static readonly NativeHandle selIsEdgeLightEnabledXHandle = Selector.GetHandle ("isEdgeLightEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExposureModeSupported_X = "isExposureModeSupported:";
		static readonly NativeHandle selIsExposureModeSupported_XHandle = Selector.GetHandle ("isExposureModeSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExposurePointOfInterestSupportedX = "isExposurePointOfInterestSupported";
		static readonly NativeHandle selIsExposurePointOfInterestSupportedXHandle = Selector.GetHandle ("isExposurePointOfInterestSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExposureRectOfInterestSupportedX = "isExposureRectOfInterestSupported";
		static readonly NativeHandle selIsExposureRectOfInterestSupportedXHandle = Selector.GetHandle ("isExposureRectOfInterestSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFlashAvailableX = "isFlashAvailable";
		static readonly NativeHandle selIsFlashAvailableXHandle = Selector.GetHandle ("isFlashAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFlashModeSupported_X = "isFlashModeSupported:";
		static readonly NativeHandle selIsFlashModeSupported_XHandle = Selector.GetHandle ("isFlashModeSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFocusModeSupported_X = "isFocusModeSupported:";
		static readonly NativeHandle selIsFocusModeSupported_XHandle = Selector.GetHandle ("isFocusModeSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFocusPointOfInterestSupportedX = "isFocusPointOfInterestSupported";
		static readonly NativeHandle selIsFocusPointOfInterestSupportedXHandle = Selector.GetHandle ("isFocusPointOfInterestSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFocusRectOfInterestSupportedX = "isFocusRectOfInterestSupported";
		static readonly NativeHandle selIsFocusRectOfInterestSupportedXHandle = Selector.GetHandle ("isFocusRectOfInterestSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFollowingExternalSyncDeviceX = "isFollowingExternalSyncDevice";
		static readonly NativeHandle selIsFollowingExternalSyncDeviceXHandle = Selector.GetHandle ("isFollowingExternalSyncDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInUseByAnotherApplicationX = "isInUseByAnotherApplication";
		static readonly NativeHandle selIsInUseByAnotherApplicationXHandle = Selector.GetHandle ("isInUseByAnotherApplication");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPortraitEffectActiveX = "isPortraitEffectActive";
		static readonly NativeHandle selIsPortraitEffectActiveXHandle = Selector.GetHandle ("isPortraitEffectActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPortraitEffectEnabledX = "isPortraitEffectEnabled";
		static readonly NativeHandle selIsPortraitEffectEnabledXHandle = Selector.GetHandle ("isPortraitEffectEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStudioLightActiveX = "isStudioLightActive";
		static readonly NativeHandle selIsStudioLightActiveXHandle = Selector.GetHandle ("isStudioLightActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStudioLightEnabledX = "isStudioLightEnabled";
		static readonly NativeHandle selIsStudioLightEnabledXHandle = Selector.GetHandle ("isStudioLightEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSuspendedX = "isSuspended";
		static readonly NativeHandle selIsSuspendedXHandle = Selector.GetHandle ("isSuspended");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsTorchActiveX = "isTorchActive";
		static readonly NativeHandle selIsTorchActiveXHandle = Selector.GetHandle ("isTorchActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsTorchAvailableX = "isTorchAvailable";
		static readonly NativeHandle selIsTorchAvailableXHandle = Selector.GetHandle ("isTorchAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsTorchModeSupported_X = "isTorchModeSupported:";
		static readonly NativeHandle selIsTorchModeSupported_XHandle = Selector.GetHandle ("isTorchModeSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVideoFrameDurationLockedX = "isVideoFrameDurationLocked";
		static readonly NativeHandle selIsVideoFrameDurationLockedXHandle = Selector.GetHandle ("isVideoFrameDurationLocked");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsWhiteBalanceModeSupported_X = "isWhiteBalanceModeSupported:";
		static readonly NativeHandle selIsWhiteBalanceModeSupported_XHandle = Selector.GetHandle ("isWhiteBalanceModeSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkedDevicesX = "linkedDevices";
		static readonly NativeHandle selLinkedDevicesXHandle = Selector.GetHandle ("linkedDevices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameX = "localizedName";
		static readonly NativeHandle selLocalizedNameXHandle = Selector.GetHandle ("localizedName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLockForConfiguration_X = "lockForConfiguration:";
		static readonly NativeHandle selLockForConfiguration_XHandle = Selector.GetHandle ("lockForConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManufacturerX = "manufacturer";
		static readonly NativeHandle selManufacturerXHandle = Selector.GetHandle ("manufacturer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinExposureRectOfInterestSizeX = "minExposureRectOfInterestSize";
		static readonly NativeHandle selMinExposureRectOfInterestSizeXHandle = Selector.GetHandle ("minExposureRectOfInterestSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinFocusRectOfInterestSizeX = "minFocusRectOfInterestSize";
		static readonly NativeHandle selMinFocusRectOfInterestSizeXHandle = Selector.GetHandle ("minFocusRectOfInterestSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinSupportedExternalSyncFrameDurationX = "minSupportedExternalSyncFrameDuration";
		static readonly NativeHandle selMinSupportedExternalSyncFrameDurationXHandle = Selector.GetHandle ("minSupportedExternalSyncFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinSupportedLockedVideoFrameDurationX = "minSupportedLockedVideoFrameDuration";
		static readonly NativeHandle selMinSupportedLockedVideoFrameDurationXHandle = Selector.GetHandle ("minSupportedLockedVideoFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumFocusDistanceX = "minimumFocusDistance";
		static readonly NativeHandle selMinimumFocusDistanceXHandle = Selector.GetHandle ("minimumFocusDistance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModelIDX = "modelID";
		static readonly NativeHandle selModelIDXHandle = Selector.GetHandle ("modelID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNominalFocalLengthIn35mmFilmX = "nominalFocalLengthIn35mmFilm";
		static readonly NativeHandle selNominalFocalLengthIn35mmFilmXHandle = Selector.GetHandle ("nominalFocalLengthIn35mmFilm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformEffectForReaction_X = "performEffectForReaction:";
		static readonly NativeHandle selPerformEffectForReaction_XHandle = Selector.GetHandle ("performEffectForReaction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionX = "position";
		static readonly NativeHandle selPositionXHandle = Selector.GetHandle ("position");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMicrophoneModeX = "preferredMicrophoneMode";
		static readonly NativeHandle selPreferredMicrophoneModeXHandle = Selector.GetHandle ("preferredMicrophoneMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsX = "primaryConstituentDeviceRestrictedSwitchingBehaviorConditions";
		static readonly NativeHandle selPrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsXHandle = Selector.GetHandle ("primaryConstituentDeviceRestrictedSwitchingBehaviorConditions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryConstituentDeviceSwitchingBehaviorX = "primaryConstituentDeviceSwitchingBehavior";
		static readonly NativeHandle selPrimaryConstituentDeviceSwitchingBehaviorXHandle = Selector.GetHandle ("primaryConstituentDeviceSwitchingBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReactionEffectGesturesEnabledX = "reactionEffectGesturesEnabled";
		static readonly NativeHandle selReactionEffectGesturesEnabledXHandle = Selector.GetHandle ("reactionEffectGesturesEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReactionEffectsEnabledX = "reactionEffectsEnabled";
		static readonly NativeHandle selReactionEffectsEnabledXHandle = Selector.GetHandle ("reactionEffectsEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReactionEffectsInProgressX = "reactionEffectsInProgress";
		static readonly NativeHandle selReactionEffectsInProgressXHandle = Selector.GetHandle ("reactionEffectsInProgress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAccessForMediaType_CompletionHandler_X = "requestAccessForMediaType:completionHandler:";
		static readonly NativeHandle selRequestAccessForMediaType_CompletionHandler_XHandle = Selector.GetHandle ("requestAccessForMediaType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActiveColorSpace_X = "setActiveColorSpace:";
		static readonly NativeHandle selSetActiveColorSpace_XHandle = Selector.GetHandle ("setActiveColorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActiveFormat_X = "setActiveFormat:";
		static readonly NativeHandle selSetActiveFormat_XHandle = Selector.GetHandle ("setActiveFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActiveInputSource_X = "setActiveInputSource:";
		static readonly NativeHandle selSetActiveInputSource_XHandle = Selector.GetHandle ("setActiveInputSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActiveVideoMaxFrameDuration_X = "setActiveVideoMaxFrameDuration:";
		static readonly NativeHandle selSetActiveVideoMaxFrameDuration_XHandle = Selector.GetHandle ("setActiveVideoMaxFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActiveVideoMinFrameDuration_X = "setActiveVideoMinFrameDuration:";
		static readonly NativeHandle selSetActiveVideoMinFrameDuration_XHandle = Selector.GetHandle ("setActiveVideoMinFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoVideoFrameRateEnabled_X = "setAutoVideoFrameRateEnabled:";
		static readonly NativeHandle selSetAutoVideoFrameRateEnabled_XHandle = Selector.GetHandle ("setAutoVideoFrameRateEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraLensSmudgeDetectionEnabled_DetectionInterval_X = "setCameraLensSmudgeDetectionEnabled:detectionInterval:";
		static readonly NativeHandle selSetCameraLensSmudgeDetectionEnabled_DetectionInterval_XHandle = Selector.GetHandle ("setCameraLensSmudgeDetectionEnabled:detectionInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenterStageControlMode_X = "setCenterStageControlMode:";
		static readonly NativeHandle selSetCenterStageControlMode_XHandle = Selector.GetHandle ("setCenterStageControlMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenterStageEnabled_X = "setCenterStageEnabled:";
		static readonly NativeHandle selSetCenterStageEnabled_XHandle = Selector.GetHandle ("setCenterStageEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenterStageRectOfInterest_X = "setCenterStageRectOfInterest:";
		static readonly NativeHandle selSetCenterStageRectOfInterest_XHandle = Selector.GetHandle ("setCenterStageRectOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCinematicVideoFixedFocusAtPoint_FocusMode_X = "setCinematicVideoFixedFocusAtPoint:focusMode:";
		static readonly NativeHandle selSetCinematicVideoFixedFocusAtPoint_FocusMode_XHandle = Selector.GetHandle ("setCinematicVideoFixedFocusAtPoint:focusMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCinematicVideoTrackingFocusAtPoint_FocusMode_X = "setCinematicVideoTrackingFocusAtPoint:focusMode:";
		static readonly NativeHandle selSetCinematicVideoTrackingFocusAtPoint_FocusMode_XHandle = Selector.GetHandle ("setCinematicVideoTrackingFocusAtPoint:focusMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCinematicVideoTrackingFocusWithDetectedObjectID_FocusMode_X = "setCinematicVideoTrackingFocusWithDetectedObjectID:focusMode:";
		static readonly NativeHandle selSetCinematicVideoTrackingFocusWithDetectedObjectID_FocusMode_XHandle = Selector.GetHandle ("setCinematicVideoTrackingFocusWithDetectedObjectID:focusMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposureMode_X = "setExposureMode:";
		static readonly NativeHandle selSetExposureMode_XHandle = Selector.GetHandle ("setExposureMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposurePointOfInterest_X = "setExposurePointOfInterest:";
		static readonly NativeHandle selSetExposurePointOfInterest_XHandle = Selector.GetHandle ("setExposurePointOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposureRectOfInterest_X = "setExposureRectOfInterest:";
		static readonly NativeHandle selSetExposureRectOfInterest_XHandle = Selector.GetHandle ("setExposureRectOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFallbackPrimaryConstituentDevices_X = "setFallbackPrimaryConstituentDevices:";
		static readonly NativeHandle selSetFallbackPrimaryConstituentDevices_XHandle = Selector.GetHandle ("setFallbackPrimaryConstituentDevices:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFlashMode_X = "setFlashMode:";
		static readonly NativeHandle selSetFlashMode_XHandle = Selector.GetHandle ("setFlashMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocusMode_X = "setFocusMode:";
		static readonly NativeHandle selSetFocusMode_XHandle = Selector.GetHandle ("setFocusMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocusPointOfInterest_X = "setFocusPointOfInterest:";
		static readonly NativeHandle selSetFocusPointOfInterest_XHandle = Selector.GetHandle ("setFocusPointOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocusRectOfInterest_X = "setFocusRectOfInterest:";
		static readonly NativeHandle selSetFocusRectOfInterest_XHandle = Selector.GetHandle ("setFocusRectOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryConstituentDeviceSwitchingBehavior_RestrictedSwitchingBehaviorConditions_X = "setPrimaryConstituentDeviceSwitchingBehavior:restrictedSwitchingBehaviorConditions:";
		static readonly NativeHandle selSetPrimaryConstituentDeviceSwitchingBehavior_RestrictedSwitchingBehaviorConditions_XHandle = Selector.GetHandle ("setPrimaryConstituentDeviceSwitchingBehavior:restrictedSwitchingBehaviorConditions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTorchMode_X = "setTorchMode:";
		static readonly NativeHandle selSetTorchMode_XHandle = Selector.GetHandle ("setTorchMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTorchModeOnWithLevel_Error_X = "setTorchModeOnWithLevel:error:";
		static readonly NativeHandle selSetTorchModeOnWithLevel_Error_XHandle = Selector.GetHandle ("setTorchModeOnWithLevel:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransportControlsPlaybackMode_Speed_X = "setTransportControlsPlaybackMode:speed:";
		static readonly NativeHandle selSetTransportControlsPlaybackMode_Speed_XHandle = Selector.GetHandle ("setTransportControlsPlaybackMode:speed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserPreferredCamera_X = "setUserPreferredCamera:";
		static readonly NativeHandle selSetUserPreferredCamera_XHandle = Selector.GetHandle ("setUserPreferredCamera:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWhiteBalanceMode_X = "setWhiteBalanceMode:";
		static readonly NativeHandle selSetWhiteBalanceMode_XHandle = Selector.GetHandle ("setWhiteBalanceMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowSystemUserInterface_X = "showSystemUserInterface:";
		static readonly NativeHandle selShowSystemUserInterface_XHandle = Selector.GetHandle ("showSystemUserInterface:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpatialCaptureDiscomfortReasonsX = "spatialCaptureDiscomfortReasons";
		static readonly NativeHandle selSpatialCaptureDiscomfortReasonsXHandle = Selector.GetHandle ("spatialCaptureDiscomfortReasons");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedFallbackPrimaryConstituentDevicesX = "supportedFallbackPrimaryConstituentDevices";
		static readonly NativeHandle selSupportedFallbackPrimaryConstituentDevicesXHandle = Selector.GetHandle ("supportedFallbackPrimaryConstituentDevices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportsAVCaptureSessionPreset_X = "supportsAVCaptureSessionPreset:";
		static readonly NativeHandle selSupportsAVCaptureSessionPreset_XHandle = Selector.GetHandle ("supportsAVCaptureSessionPreset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemPreferredCameraX = "systemPreferredCamera";
		static readonly NativeHandle selSystemPreferredCameraXHandle = Selector.GetHandle ("systemPreferredCamera");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTorchLevelX = "torchLevel";
		static readonly NativeHandle selTorchLevelXHandle = Selector.GetHandle ("torchLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTorchModeX = "torchMode";
		static readonly NativeHandle selTorchModeXHandle = Selector.GetHandle ("torchMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransportControlsPlaybackModeX = "transportControlsPlaybackMode";
		static readonly NativeHandle selTransportControlsPlaybackModeXHandle = Selector.GetHandle ("transportControlsPlaybackMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransportControlsSpeedX = "transportControlsSpeed";
		static readonly NativeHandle selTransportControlsSpeedXHandle = Selector.GetHandle ("transportControlsSpeed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransportControlsSupportedX = "transportControlsSupported";
		static readonly NativeHandle selTransportControlsSupportedXHandle = Selector.GetHandle ("transportControlsSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransportTypeX = "transportType";
		static readonly NativeHandle selTransportTypeXHandle = Selector.GetHandle ("transportType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniqueIDX = "uniqueID";
		static readonly NativeHandle selUniqueIDXHandle = Selector.GetHandle ("uniqueID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockForConfigurationX = "unlockForConfiguration";
		static readonly NativeHandle selUnlockForConfigurationXHandle = Selector.GetHandle ("unlockForConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserPreferredCameraX = "userPreferredCamera";
		static readonly NativeHandle selUserPreferredCameraXHandle = Selector.GetHandle ("userPreferredCamera");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWhiteBalanceModeX = "whiteBalanceMode";
		static readonly NativeHandle selWhiteBalanceModeXHandle = Selector.GetHandle ("whiteBalanceMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureDevice");
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
		protected AVCaptureDevice (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureDevice (NativeHandle handle) : base (handle)
		{
		}

		[Export ("deviceWithUniqueID:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureDevice? DeviceWithUniqueID (string deviceUniqueID)
		{
			if (deviceUniqueID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deviceUniqueID));
			var nsdeviceUniqueID = CFString.CreateNative (deviceUniqueID);
			AVCaptureDevice? ret;
			ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDeviceWithUniqueID_XHandle, nsdeviceUniqueID), false)!;
			CFString.ReleaseNative (nsdeviceUniqueID);
			return ret!;
		}
		[Export ("devicesWithMediaType:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureDevice[] DevicesWithMediaType (string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVCaptureDevice[]? ret;
			ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDevicesWithMediaType_XHandle, nsmediaType), false)!;
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAuthorizationStatus GetAuthorizationStatus (AVAuthorizationMediaType mediaType)
		{
			return GetAuthorizationStatus (mediaType == AVAuthorizationMediaType.Video ? AVMediaTypes.Video.GetConstant ()! : AVMediaTypes.Audio.GetConstant ()!);
		}
		[Export ("authorizationStatusForMediaType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAuthorizationStatus GetAuthorizationStatus (NSString avMediaTypeToken)
		{
			var avMediaTypeToken__handle__ = avMediaTypeToken!.GetNonNullHandle (nameof (avMediaTypeToken));
			AVAuthorizationStatus ret;
			ret = (AVAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, selAuthorizationStatusForMediaType_XHandle, avMediaTypeToken__handle__);
			GC.KeepAlive (avMediaTypeToken);
			return ret!;
		}
		[Export ("defaultDeviceWithMediaType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureDevice? GetDefaultDevice (NSString mediaType)
		{
			var mediaType__handle__ = mediaType!.GetNonNullHandle (nameof (mediaType));
			AVCaptureDevice? ret;
			ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDefaultDeviceWithMediaType_XHandle, mediaType__handle__), false)!;
			GC.KeepAlive (mediaType);
			return ret!;
		}
		/// <param name="mediaType">The media type for which to get the default device.</param><summary>Returns the default device for the provided media type.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureDevice? GetDefaultDevice (AVMediaTypes mediaType)
		{
			return GetDefaultDevice (mediaType.GetConstant ()!);
		}
		/// <param name="deviceType">The device type to use for capture.</param><param name="mediaType">The media type for which to get the default device.</param><param name="position">Whether the device is front facing, back facing, or unspecified.</param><summary>Returns the default device for the provided device and media types and front or back facing position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureDevice? GetDefaultDevice (AVCaptureDeviceType deviceType, string mediaType, AVCaptureDevicePosition position)
		{
			return AVCaptureDevice._DefaultDeviceWithDeviceType (deviceType.GetConstant ()!, mediaType, position);
		}
		[Export ("defaultDeviceWithDeviceType:mediaType:position:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureDevice? GetDefaultDevice ([BindAs (typeof (AVCaptureDeviceType), OriginalType = typeof (NSString))] global::AVFoundation.AVCaptureDeviceType deviceType, [BindAs (typeof (AVMediaTypes), OriginalType = typeof (NSString))] global::AVFoundation.AVMediaTypes mediaType, AVCaptureDevicePosition position)
		{
			using var nsb_deviceType = global::AVFoundation.AVCaptureDeviceTypeExtensions.GetConstant (deviceType);
			using var nsb_mediaType = global::AVFoundation.AVMediaTypesExtensions.GetConstant (mediaType);
			AVCaptureDevice ret;
			ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selDefaultDeviceWithDeviceType_MediaType_Position_XHandle, nsb_deviceType.GetHandle (), nsb_mediaType.GetHandle (), (IntPtr) (long) position), false)!;
			return ret;
		}
		[Export ("defaultRectForExposurePointOfInterest:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetDefaultRectForExposurePointOfInterest (CGPoint exposurePointOfInterest)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGPoint (this.Handle, selDefaultRectForExposurePointOfInterest_XHandle, exposurePointOfInterest);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGPoint (this.Handle, selDefaultRectForExposurePointOfInterest_XHandle, exposurePointOfInterest);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGPoint (&__objc_super__, selDefaultRectForExposurePointOfInterest_XHandle, exposurePointOfInterest);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGPoint (&__objc_super__, selDefaultRectForExposurePointOfInterest_XHandle, exposurePointOfInterest);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("defaultRectForFocusPointOfInterest:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetDefaultRectForFocusPointOfInterest (CGPoint focusPointOfInterest)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGPoint (this.Handle, selDefaultRectForFocusPointOfInterest_XHandle, focusPointOfInterest);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGPoint (this.Handle, selDefaultRectForFocusPointOfInterest_XHandle, focusPointOfInterest);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGPoint (&__objc_super__, selDefaultRectForFocusPointOfInterest_XHandle, focusPointOfInterest);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGPoint (&__objc_super__, selDefaultRectForFocusPointOfInterest_XHandle, focusPointOfInterest);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("hasMediaType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMediaType (string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasMediaType_XHandle, nsmediaType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasMediaType_XHandle, nsmediaType);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaType);
			return ret != 0;
		}
		/// <param name="mediaType">The media type to check.</param><summary>Whether the device can provide the <paramref name="mediaType" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HasMediaType (AVMediaTypes mediaType)
		{
			return HasMediaType ((string) mediaType.GetConstant ()!);
		}
		[Export ("isExposureModeSupported:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsExposureModeSupported (AVCaptureExposureMode exposureMode)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsExposureModeSupported_XHandle, (IntPtr) (long) exposureMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsExposureModeSupported_XHandle, (IntPtr) (long) exposureMode);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isFlashModeSupported:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'AVCapturePhotoOutput.SupportedFlashModes' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVCapturePhotoOutput.SupportedFlashModes' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFlashModeSupported (AVCaptureFlashMode flashMode)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsFlashModeSupported_XHandle, (IntPtr) (long) flashMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsFlashModeSupported_XHandle, (IntPtr) (long) flashMode);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isFocusModeSupported:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFocusModeSupported (AVCaptureFocusMode focusMode)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsFocusModeSupported_XHandle, (IntPtr) (long) focusMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsFocusModeSupported_XHandle, (IntPtr) (long) focusMode);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isTorchModeSupported:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsTorchModeSupported (AVCaptureTorchMode torchMode)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsTorchModeSupported_XHandle, (IntPtr) (long) torchMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsTorchModeSupported_XHandle, (IntPtr) (long) torchMode);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isWhiteBalanceModeSupported:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsWhiteBalanceModeSupported (AVCaptureWhiteBalanceMode whiteBalanceMode)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsWhiteBalanceModeSupported_XHandle, (IntPtr) (long) whiteBalanceMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsWhiteBalanceModeSupported_XHandle, (IntPtr) (long) whiteBalanceMode);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("lockForConfiguration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool LockForConfiguration (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selLockForConfiguration_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selLockForConfiguration_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("performEffectForReaction:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformEffect (string reactionType)
		{
			if (reactionType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reactionType));
			var nsreactionType = CFString.CreateNative (reactionType);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformEffectForReaction_XHandle, nsreactionType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformEffectForReaction_XHandle, nsreactionType);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsreactionType);
		}
		/// <param name="mediaType">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestAccessForMediaType (AVAuthorizationMediaType mediaType, AVRequestAccessStatus completion)
		{
			RequestAccessForMediaType (mediaType == AVAuthorizationMediaType.Video ? AVMediaTypes.Video.GetConstant ()! : AVMediaTypes.Audio.GetConstant ()!, completion);
		}
		/// <param name="mediaType">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> RequestAccessForMediaTypeAsync (AVAuthorizationMediaType mediaType)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RequestAccessForMediaType(mediaType, (accessGranted_) => {
				tcs.SetResult (accessGranted_!);
			});
			return tcs.Task;
		}
		[Export ("requestAccessForMediaType:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestAccessForMediaType (NSString avMediaTypeToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVRequestAccessStatus))]AVRequestAccessStatus completion)
		{
			var avMediaTypeToken__handle__ = avMediaTypeToken!.GetNonNullHandle (nameof (avMediaTypeToken));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAVRequestAccessStatus.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selRequestAccessForMediaType_CompletionHandler_XHandle, avMediaTypeToken__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (avMediaTypeToken);
		}
		/// <param name="avMediaTypeToken">The type of media for which access is being requested. Should be a value defined in .</param>
		/// <summary>Requests the application user's permission, if necessary, to capture the <paramref name="avMediaTypeToken" />.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous RequestAccessForMediaType operation.   The value of the TResult parameter is a AVFoundation.AVRequestAccessStatus.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> RequestAccessForMediaTypeAsync (NSString avMediaTypeToken)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RequestAccessForMediaType(avMediaTypeToken, (accessGranted_) => {
				tcs.SetResult (accessGranted_!);
			});
			return tcs.Task;
		}
		[Export ("setCameraLensSmudgeDetectionEnabled:detectionInterval:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCameraLensSmudgeDetectionEnabled (bool cameraLensSmudgeDetectionEnabled, global::CoreMedia.CMTime detectionInterval)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_CMTime (this.Handle, selSetCameraLensSmudgeDetectionEnabled_DetectionInterval_XHandle, cameraLensSmudgeDetectionEnabled ? (byte) 1 : (byte) 0, detectionInterval);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_CMTime (&__objc_super__, selSetCameraLensSmudgeDetectionEnabled_DetectionInterval_XHandle, cameraLensSmudgeDetectionEnabled ? (byte) 1 : (byte) 0, detectionInterval);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setCinematicVideoFixedFocusAtPoint:focusMode:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCinematicVideoFixedFocus (CGPoint point, AVCaptureCinematicVideoFocusMode focusMode)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr (this.Handle, selSetCinematicVideoFixedFocusAtPoint_FocusMode_XHandle, point, (IntPtr) (long) focusMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_IntPtr (&__objc_super__, selSetCinematicVideoFixedFocusAtPoint_FocusMode_XHandle, point, (IntPtr) (long) focusMode);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setCinematicVideoTrackingFocusWithDetectedObjectID:focusMode:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCinematicVideoTrackingFocus (nint detectedObjectId, AVCaptureCinematicVideoFocusMode focusMode)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetCinematicVideoTrackingFocusWithDetectedObjectID_FocusMode_XHandle, detectedObjectId, (IntPtr) (long) focusMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selSetCinematicVideoTrackingFocusWithDetectedObjectID_FocusMode_XHandle, detectedObjectId, (IntPtr) (long) focusMode);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setCinematicVideoTrackingFocusAtPoint:focusMode:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCinematicVideoTrackingFocus (CGPoint point, AVCaptureCinematicVideoFocusMode focusMode)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr (this.Handle, selSetCinematicVideoTrackingFocusAtPoint_FocusMode_XHandle, point, (IntPtr) (long) focusMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_IntPtr (&__objc_super__, selSetCinematicVideoTrackingFocusAtPoint_FocusMode_XHandle, point, (IntPtr) (long) focusMode);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setPrimaryConstituentDeviceSwitchingBehavior:restrictedSwitchingBehaviorConditions:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPrimaryConstituentDeviceSwitchingBehavior (AVCapturePrimaryConstituentDeviceSwitchingBehavior switchingBehavior, AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions restrictedSwitchingBehaviorConditions)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, selSetPrimaryConstituentDeviceSwitchingBehavior_RestrictedSwitchingBehaviorConditions_XHandle, (IntPtr) (long) switchingBehavior, (UIntPtr) (ulong) restrictedSwitchingBehaviorConditions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selSetPrimaryConstituentDeviceSwitchingBehavior_RestrictedSwitchingBehaviorConditions_XHandle, (IntPtr) (long) switchingBehavior, (UIntPtr) (ulong) restrictedSwitchingBehaviorConditions);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setTorchModeOnWithLevel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetTorchModeLevel (float torchLevel, out NSError outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_float_ref_NativeHandle (this.Handle, selSetTorchModeOnWithLevel_Error_XHandle, torchLevel, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_float_ref_NativeHandle (&__objc_super__, selSetTorchModeOnWithLevel_Error_XHandle, torchLevel, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("setTransportControlsPlaybackMode:speed:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTransportControlsPlaybackMode (AVCaptureDeviceTransportControlsPlaybackMode mode, float speed)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_float (this.Handle, selSetTransportControlsPlaybackMode_Speed_XHandle, (IntPtr) (long) mode, speed);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_float (&__objc_super__, selSetTransportControlsPlaybackMode_Speed_XHandle, (IntPtr) (long) mode, speed);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("showSystemUserInterface:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowSystemUserInterface (AVCaptureSystemUserInterface systemUserInterface)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selShowSystemUserInterface_XHandle, (IntPtr) (long) systemUserInterface);
		}
		[Export ("supportsAVCaptureSessionPreset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsAVCaptureSessionPreset (string preset)
		{
			if (preset is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (preset));
			var nspreset = CFString.CreateNative (preset);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSupportsAVCaptureSessionPreset_XHandle, nspreset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSupportsAVCaptureSessionPreset_XHandle, nspreset);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspreset);
			return ret != 0;
		}
		[Export ("unlockForConfiguration")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnlockForConfiguration ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnlockForConfigurationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUnlockForConfigurationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("defaultDeviceWithDeviceType:mediaType:position:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVCaptureDevice? _DefaultDeviceWithDeviceType (NSString deviceType, string? mediaType, AVCaptureDevicePosition position)
		{
			var deviceType__handle__ = deviceType!.GetNonNullHandle (nameof (deviceType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVCaptureDevice? ret;
			ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selDefaultDeviceWithDeviceType_MediaType_Position_XHandle, deviceType__handle__, nsmediaType, (IntPtr) (long) position), false)!;
			GC.KeepAlive (deviceType);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureColorSpace ActiveColorSpace {
			[Export ("activeColorSpace", ArgumentSemantic.Assign)]
			get {
				AVCaptureColorSpace ret;
				if (IsDirectBinding) {
					ret = (AVCaptureColorSpace) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActiveColorSpaceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureColorSpace) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selActiveColorSpaceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setActiveColorSpace:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetActiveColorSpace_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetActiveColorSpace_XHandle, (IntPtr) (long) value);
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
		public virtual AVCaptureDeviceFormat ActiveFormat {
			[Export ("activeFormat", ArgumentSemantic.Retain)]
			get {
				AVCaptureDeviceFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureDeviceFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActiveFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureDeviceFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActiveFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setActiveFormat:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetActiveFormat_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetActiveFormat_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVCaptureDeviceInputSource? ActiveInputSource {
			[Export ("activeInputSource", ArgumentSemantic.Retain)]
			get {
				AVCaptureDeviceInputSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureDeviceInputSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActiveInputSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureDeviceInputSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActiveInputSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setActiveInputSource:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetActiveInputSource_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetActiveInputSource_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static AVCaptureMicrophoneMode ActiveMicrophoneMode {
			[Export ("activeMicrophoneMode")]
			get {
				AVCaptureMicrophoneMode ret;
				ret = (AVCaptureMicrophoneMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selActiveMicrophoneModeXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureDevice? ActivePrimaryConstituentDevice {
			[Export ("activePrimaryConstituentDevice")]
			get {
				AVCaptureDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActivePrimaryConstituentDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActivePrimaryConstituentDeviceXHandle), false)!;
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
		public virtual AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions ActivePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions {
			[Export ("activePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions")]
			get {
				AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions ret;
				if (IsDirectBinding) {
					ret = (AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selActivePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selActivePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsXHandle);
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
		public virtual AVCapturePrimaryConstituentDeviceSwitchingBehavior ActivePrimaryConstituentDeviceSwitchingBehavior {
			[Export ("activePrimaryConstituentDeviceSwitchingBehavior")]
			get {
				AVCapturePrimaryConstituentDeviceSwitchingBehavior ret;
				if (IsDirectBinding) {
					ret = (AVCapturePrimaryConstituentDeviceSwitchingBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActivePrimaryConstituentDeviceSwitchingBehaviorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePrimaryConstituentDeviceSwitchingBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selActivePrimaryConstituentDeviceSwitchingBehaviorXHandle);
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
		[SupportedOSPlatform ("tvos17.0")]
		public virtual global::CoreMedia.CMTime ActiveVideoMaxFrameDuration {
			[Export ("activeVideoMaxFrameDuration", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selActiveVideoMaxFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selActiveVideoMaxFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selActiveVideoMaxFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selActiveVideoMaxFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setActiveVideoMaxFrameDuration:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetActiveVideoMaxFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetActiveVideoMaxFrameDuration_XHandle, value);
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
		public virtual global::CoreMedia.CMTime ActiveVideoMinFrameDuration {
			[Export ("activeVideoMinFrameDuration", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selActiveVideoMinFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selActiveVideoMinFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selActiveVideoMinFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selActiveVideoMinFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setActiveVideoMinFrameDuration:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetActiveVideoMinFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetActiveVideoMinFrameDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the device is currently adjusting its exposure setting.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool AdjustingExposure {
			[Export ("isAdjustingExposure")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAdjustingExposureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAdjustingExposureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the device is currently adjusting its focus.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool AdjustingFocus {
			[Export ("isAdjustingFocus")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAdjustingFocusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAdjustingFocusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the device is currently adjusting its white balance.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool AdjustingWhiteBalance {
			[Export ("isAdjustingWhiteBalance")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAdjustingWhiteBalanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAdjustingWhiteBalanceXHandle);
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
		public virtual bool AutoVideoFrameRateEnabled {
			[Export ("isAutoVideoFrameRateEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoVideoFrameRateEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutoVideoFrameRateEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoVideoFrameRateEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoVideoFrameRateEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoVideoFrameRateEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual NSSet<NSString> AvailableReactionTypes {
			[Export ("availableReactionTypes")]
			get {
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableReactionTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableReactionTypesXHandle), false)!;
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
		public virtual bool BackgroundReplacementActive {
			[Export ("isBackgroundReplacementActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBackgroundReplacementActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBackgroundReplacementActiveXHandle);
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
		public static bool BackgroundReplacementEnabled {
			[Export ("isBackgroundReplacementEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsBackgroundReplacementEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool CameraLensSmudgeDetectionEnabled {
			[Export ("isCameraLensSmudgeDetectionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCameraLensSmudgeDetectionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCameraLensSmudgeDetectionEnabledXHandle);
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
		public virtual global::CoreMedia.CMTime CameraLensSmudgeDetectionInterval {
			[Export ("cameraLensSmudgeDetectionInterval")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selCameraLensSmudgeDetectionIntervalXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selCameraLensSmudgeDetectionIntervalXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selCameraLensSmudgeDetectionIntervalXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selCameraLensSmudgeDetectionIntervalXHandle);
							GC.KeepAlive (this);
						}
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
		public virtual AVCaptureCameraLensSmudgeDetectionStatus CameraLensSmudgeDetectionStatus {
			[Export ("cameraLensSmudgeDetectionStatus")]
			get {
				AVCaptureCameraLensSmudgeDetectionStatus ret;
				if (IsDirectBinding) {
					ret = (AVCaptureCameraLensSmudgeDetectionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCameraLensSmudgeDetectionStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureCameraLensSmudgeDetectionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCameraLensSmudgeDetectionStatusXHandle);
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
		public virtual bool CanPerformReactionEffects {
			[Export ("canPerformReactionEffects")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPerformReactionEffectsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPerformReactionEffectsXHandle);
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
		public virtual bool CenterStageActive {
			[Export ("isCenterStageActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCenterStageActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCenterStageActiveXHandle);
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
		public static AVCaptureCenterStageControlMode CenterStageControlMode {
			[Export ("centerStageControlMode", ArgumentSemantic.Assign)]
			get {
				AVCaptureCenterStageControlMode ret;
				ret = (AVCaptureCenterStageControlMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selCenterStageControlModeXHandle);
				return ret!;
			}
			[Export ("setCenterStageControlMode:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetCenterStageControlMode_XHandle, (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("tvos17.0")]
		public static bool CenterStageEnabled {
			[Export ("isCenterStageEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsCenterStageEnabledXHandle);
				return ret != 0;
			}
			[Export ("setCenterStageEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetCenterStageEnabled_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		public virtual CGRect CenterStageRectOfInterest {
			[Export ("centerStageRectOfInterest", ArgumentSemantic.Assign)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selCenterStageRectOfInterestXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selCenterStageRectOfInterestXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selCenterStageRectOfInterestXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selCenterStageRectOfInterestXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setCenterStageRectOfInterest:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetCenterStageRectOfInterest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetCenterStageRectOfInterest_XHandle, value);
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
		public AVCaptureCinematicVideoFocusMode CinematicVideoCaptureSceneMonitoringStatuses {
			get {
				return (AVCaptureCinematicVideoFocusMode) (AVCaptureSceneMonitoringStatusExtensions.ToFlags (WeakCinematicVideoCaptureSceneMonitoringStatuses));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public virtual AVCaptureDevice? CompanionDeskViewCamera {
			[Export ("companionDeskViewCamera")]
			get {
				AVCaptureDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCompanionDeskViewCameraXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCompanionDeskViewCameraXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the <see cref="T:AVFoundation.AVCaptureDevice" /> is available for use.</summary><value>To be added.</value><remarks><para>Although this value may change from <see langword="true" /> to <see langword="false" /> when a device is disconnected, it will not change from <see langword="false" /> to <see langword="true" /> when the device is reconnected. In that situation, the physical device will be represented by a different instance of <see cref="T:AVFoundation.AVCaptureDevice" />.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool Connected {
			[Export ("isConnected")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConnectedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConnectedXHandle);
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
		public virtual bool ContinuityCamera {
			[Export ("isContinuityCamera")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContinuityCameraXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContinuityCameraXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets the <see cref="T:AVFoundation.AVCaptureDeviceType" /> of the capturing device.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public AVCaptureDeviceType DeviceType {
			get {
				return (AVCaptureDeviceType) (AVCaptureDeviceTypeExtensions.GetValue (_DeviceType));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static AVCaptureDevice[] Devices {
			[Export ("devices")]
			get {
				AVCaptureDevice[]? ret;
				ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDevicesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual nfloat DisplayVideoZoomFactorMultiplier {
			[Export ("displayVideoZoomFactorMultiplier")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDisplayVideoZoomFactorMultiplierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDisplayVideoZoomFactorMultiplierXHandle);
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
		public static bool EdgeLightActive {
			[Export ("isEdgeLightActive")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsEdgeLightActiveXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		public static bool EdgeLightEnabled {
			[Export ("isEdgeLightEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsEdgeLightEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureExposureMode ExposureMode {
			[Export ("exposureMode", ArgumentSemantic.Assign)]
			get {
				AVCaptureExposureMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureExposureMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExposureModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureExposureMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selExposureModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setExposureMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetExposureMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetExposureMode_XHandle, (IntPtr) (long) value);
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
		public virtual CGPoint ExposurePointOfInterest {
			[Export ("exposurePointOfInterest")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selExposurePointOfInterestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selExposurePointOfInterestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExposurePointOfInterest:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetExposurePointOfInterest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetExposurePointOfInterest_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the device supports the <see cref="P:AVFoundation.AVCaptureDevice.ExposurePointOfInterest" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool ExposurePointOfInterestSupported {
			[Export ("isExposurePointOfInterestSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsExposurePointOfInterestSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsExposurePointOfInterestSupportedXHandle);
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
		public virtual CGRect ExposureRectOfInterest {
			[Export ("exposureRectOfInterest", ArgumentSemantic.Assign)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selExposureRectOfInterestXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selExposureRectOfInterestXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selExposureRectOfInterestXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selExposureRectOfInterestXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setExposureRectOfInterest:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetExposureRectOfInterest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetExposureRectOfInterest_XHandle, value);
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
		public virtual bool ExposureRectOfInterestSupported {
			[Export ("isExposureRectOfInterestSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsExposureRectOfInterestSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsExposureRectOfInterestSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_FallbackPrimaryConstituentDevices_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureDevice[] FallbackPrimaryConstituentDevices {
			[Export ("fallbackPrimaryConstituentDevices", ArgumentSemantic.Assign)]
			get {
				AVCaptureDevice[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFallbackPrimaryConstituentDevicesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFallbackPrimaryConstituentDevicesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_FallbackPrimaryConstituentDevices_var = ret;
				return ret!;
			}
			[Export ("setFallbackPrimaryConstituentDevices:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFallbackPrimaryConstituentDevices_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFallbackPrimaryConstituentDevices_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_FallbackPrimaryConstituentDevices_var = value;
			}
		}
		/// <summary>Whether the flash is available for use.</summary><value></value><remarks>True if the device has a flash.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool FlashAvailable {
			[Export ("isFlashAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFlashAvailableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFlashAvailableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'AVCapturePhotoSettings.FlashMode' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVCapturePhotoSettings.FlashMode' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual AVCaptureFlashMode FlashMode {
			[Export ("flashMode")]
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
			[Export ("setFlashMode:")]
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureFocusMode FocusMode {
			[Export ("focusMode", ArgumentSemantic.Assign)]
			get {
				AVCaptureFocusMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureFocusMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFocusModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureFocusMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFocusModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFocusMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFocusMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetFocusMode_XHandle, (IntPtr) (long) value);
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
		public virtual CGPoint FocusPointOfInterest {
			[Export ("focusPointOfInterest", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selFocusPointOfInterestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selFocusPointOfInterestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFocusPointOfInterest:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetFocusPointOfInterest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetFocusPointOfInterest_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether <see cref="P:AVFoundation.AVCaptureDevice.FocusPointOfInterest" /> is available.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool FocusPointOfInterestSupported {
			[Export ("isFocusPointOfInterestSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFocusPointOfInterestSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFocusPointOfInterestSupportedXHandle);
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
		public virtual CGRect FocusRectOfInterest {
			[Export ("focusRectOfInterest", ArgumentSemantic.Assign)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selFocusRectOfInterestXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selFocusRectOfInterestXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selFocusRectOfInterestXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selFocusRectOfInterestXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setFocusRectOfInterest:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetFocusRectOfInterest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetFocusRectOfInterest_XHandle, value);
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
		public virtual bool FocusRectOfInterestSupported {
			[Export ("isFocusRectOfInterestSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFocusRectOfInterestSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFocusRectOfInterestSupportedXHandle);
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
		public virtual bool FollowingExternalSyncDevice {
			[Export ("isFollowingExternalSyncDevice")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFollowingExternalSyncDeviceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFollowingExternalSyncDeviceXHandle);
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
		public virtual AVCaptureDeviceFormat[] Formats {
			[Export ("formats")]
			get {
				AVCaptureDeviceFormat[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureDeviceFormat>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureDeviceFormat>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatsXHandle), false)!;
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
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool HasFlash {
			[Export ("hasFlash")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasFlashXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasFlashXHandle);
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
		public virtual bool HasTorch {
			[Export ("hasTorch")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasTorchXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasTorchXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool InUseByAnotherApplication {
			[Export ("isInUseByAnotherApplication")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInUseByAnotherApplicationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInUseByAnotherApplicationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVCaptureDeviceInputSource[] InputSources {
			[Export ("inputSources")]
			get {
				AVCaptureDeviceInputSource[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureDeviceInputSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputSourcesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureDeviceInputSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputSourcesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureDevice[] LinkedDevices {
			[Export ("linkedDevices")]
			get {
				AVCaptureDevice[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLinkedDevicesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLinkedDevicesXHandle), false)!;
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
		[SupportedOSPlatform ("tvos17.0")]
		public virtual string LocalizedName {
			[Export ("localizedName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual string Manufacturer {
			[Export ("manufacturer")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selManufacturerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selManufacturerXHandle), false)!;
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
		public virtual CGSize MinExposureRectOfInterestSize {
			[Export ("minExposureRectOfInterestSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selMinExposureRectOfInterestSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selMinExposureRectOfInterestSizeXHandle);
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
		public virtual CGSize MinFocusRectOfInterestSize {
			[Export ("minFocusRectOfInterestSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selMinFocusRectOfInterestSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selMinFocusRectOfInterestSizeXHandle);
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
		public virtual global::CoreMedia.CMTime MinSupportedExternalSyncFrameDuration {
			[Export ("minSupportedExternalSyncFrameDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selMinSupportedExternalSyncFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selMinSupportedExternalSyncFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selMinSupportedExternalSyncFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selMinSupportedExternalSyncFrameDurationXHandle);
							GC.KeepAlive (this);
						}
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
		public virtual global::CoreMedia.CMTime MinSupportedLockedVideoFrameDuration {
			[Export ("minSupportedLockedVideoFrameDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selMinSupportedLockedVideoFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selMinSupportedLockedVideoFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selMinSupportedLockedVideoFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selMinSupportedLockedVideoFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual nint MinimumFocusDistance {
			[Export ("minimumFocusDistance")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMinimumFocusDistanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMinimumFocusDistanceXHandle);
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
		public virtual string ModelID {
			[Export ("modelID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selModelIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selModelIDXHandle), false)!;
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
		public virtual float NominalFocalLengthIn35mmFilm {
			[Export ("nominalFocalLengthIn35mmFilm")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNominalFocalLengthIn35mmFilmXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNominalFocalLengthIn35mmFilmXHandle);
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
		public virtual bool PortraitEffectActive {
			[Export ("isPortraitEffectActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPortraitEffectActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPortraitEffectActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static bool PortraitEffectEnabled {
			[Export ("isPortraitEffectEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsPortraitEffectEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureDevicePosition Position {
			[Export ("position")]
			get {
				AVCaptureDevicePosition ret;
				if (IsDirectBinding) {
					ret = (AVCaptureDevicePosition) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureDevicePosition) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static AVCaptureMicrophoneMode PreferredMicrophoneMode {
			[Export ("preferredMicrophoneMode")]
			get {
				AVCaptureMicrophoneMode ret;
				ret = (AVCaptureMicrophoneMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPreferredMicrophoneModeXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions PrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions {
			[Export ("primaryConstituentDeviceRestrictedSwitchingBehaviorConditions")]
			get {
				AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions ret;
				if (IsDirectBinding) {
					ret = (AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePrimaryConstituentDeviceRestrictedSwitchingBehaviorConditions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryConstituentDeviceRestrictedSwitchingBehaviorConditionsXHandle);
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
		public virtual AVCapturePrimaryConstituentDeviceSwitchingBehavior PrimaryConstituentDeviceSwitchingBehavior {
			[Export ("primaryConstituentDeviceSwitchingBehavior")]
			get {
				AVCapturePrimaryConstituentDeviceSwitchingBehavior ret;
				if (IsDirectBinding) {
					ret = (AVCapturePrimaryConstituentDeviceSwitchingBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrimaryConstituentDeviceSwitchingBehaviorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePrimaryConstituentDeviceSwitchingBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryConstituentDeviceSwitchingBehaviorXHandle);
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
		public static bool ReactionEffectGesturesEnabled {
			[Export ("reactionEffectGesturesEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selReactionEffectGesturesEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static bool ReactionEffectsEnabled {
			[Export ("reactionEffectsEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selReactionEffectsEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual AVCaptureReactionEffectState[] ReactionEffectsInProgress {
			[Export ("reactionEffectsInProgress")]
			get {
				AVCaptureReactionEffectState[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureReactionEffectState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReactionEffectsInProgressXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureReactionEffectState>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReactionEffectsInProgressXHandle), false)!;
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
		public virtual NSSet<NSString> SpatialCaptureDiscomfortReasons {
			[Export ("spatialCaptureDiscomfortReasons")]
			get {
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpatialCaptureDiscomfortReasonsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpatialCaptureDiscomfortReasonsXHandle), false)!;
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
		public virtual bool StudioLightActive {
			[Export ("isStudioLightActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStudioLightActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsStudioLightActiveXHandle);
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
		public static bool StudioLightEnabled {
			[Export ("isStudioLightEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsStudioLightEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureDevice[] SupportedFallbackPrimaryConstituentDevices {
			[Export ("supportedFallbackPrimaryConstituentDevices")]
			get {
				AVCaptureDevice[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedFallbackPrimaryConstituentDevicesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureDevice>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedFallbackPrimaryConstituentDevicesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool Suspended {
			[Export ("isSuspended")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSuspendedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSuspendedXHandle);
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
		[SupportedOSPlatform ("ios17.0")]
		public static AVCaptureDevice? SystemPreferredCamera {
			[Export ("systemPreferredCamera")]
			get {
				AVCaptureDevice? ret;
				ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemPreferredCameraXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Whether the torch / flashlight is active.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool TorchActive {
			[Export ("isTorchActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTorchActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsTorchActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the <see cref="T:AVFoundation.AVCaptureDevice" /> has a torch / flashlight.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool TorchAvailable {
			[Export ("isTorchAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTorchAvailableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsTorchAvailableXHandle);
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
		public virtual float TorchLevel {
			[Export ("torchLevel")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTorchLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selTorchLevelXHandle);
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
		public virtual AVCaptureTorchMode TorchMode {
			[Export ("torchMode", ArgumentSemantic.Assign)]
			get {
				AVCaptureTorchMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureTorchMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTorchModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureTorchMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTorchModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTorchMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTorchMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTorchMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVCaptureDeviceTransportControlsPlaybackMode TransportControlsPlaybackMode {
			[Export ("transportControlsPlaybackMode")]
			get {
				AVCaptureDeviceTransportControlsPlaybackMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureDeviceTransportControlsPlaybackMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTransportControlsPlaybackModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureDeviceTransportControlsPlaybackMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTransportControlsPlaybackModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual float TransportControlsSpeed {
			[Export ("transportControlsSpeed")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTransportControlsSpeedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selTransportControlsSpeedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool TransportControlsSupported {
			[Export ("transportControlsSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTransportControlsSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTransportControlsSupportedXHandle);
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
		public virtual string UniqueID {
			[Export ("uniqueID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUniqueIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUniqueIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static AVCaptureDevice? UserPreferredCamera {
			[Export ("userPreferredCamera", ArgumentSemantic.Assign)]
			get {
				AVCaptureDevice? ret;
				ret =  Runtime.GetNSObject<AVCaptureDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUserPreferredCameraXHandle), false)!;
				return ret!;
			}
			[Export ("setUserPreferredCamera:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetUserPreferredCamera_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool VideoFrameDurationLocked {
			[Export ("isVideoFrameDurationLocked")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVideoFrameDurationLockedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVideoFrameDurationLockedXHandle);
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
		public virtual NSSet<NSString> WeakCinematicVideoCaptureSceneMonitoringStatuses {
			[Export ("cinematicVideoCaptureSceneMonitoringStatuses")]
			get {
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCinematicVideoCaptureSceneMonitoringStatusesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCinematicVideoCaptureSceneMonitoringStatusesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual int WeakTransportType {
			[Export ("transportType")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTransportTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selTransportTypeXHandle);
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
		public virtual AVCaptureWhiteBalanceMode WhiteBalanceMode {
			[Export ("whiteBalanceMode", ArgumentSemantic.Assign)]
			get {
				AVCaptureWhiteBalanceMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureWhiteBalanceMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWhiteBalanceModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureWhiteBalanceMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selWhiteBalanceModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setWhiteBalanceMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWhiteBalanceMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetWhiteBalanceMode_XHandle, (IntPtr) (long) value);
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
		internal virtual NSString _DeviceType {
			[Export ("deviceType")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Represents the value associated with the constant AVCaptureMaxAvailableTorchLevel</summary><value></value><remarks><para>
		/// 	    Torch mode is a mode in which the flash light can be used continuously in low-intensity mode (typically to illuminate videos).
		/// 	  </para></remarks>
		[Field ("AVCaptureMaxAvailableTorchLevel",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public static float MaxAvailableTorchLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				return Dlfcn.GetFloat (Libraries.AVFoundation.Handle, "AVCaptureMaxAvailableTorchLevel");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WasConnectedNotification;
		/// <summary>Notification constant for WasConnected</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWasConnected(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWasConnected(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVCaptureDevice.Notifications.ObserveWasConnected ((sender, args) => {
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
		/// void Callback (object sender, AVCaptureDevice.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureDevice.Notifications.ObserveWasConnected (Callback);
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
		///     AVCaptureDevice.WasConnectedNotification, (notification) => { Console.WriteLine ("Received the notification WasConnected", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WasConnected", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureDevice.WasConnectedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureDeviceWasConnectedNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[Advice ("Use AVCaptureDevice.Notifications.ObserveWasConnected helper method instead.")]
		public static NSString WasConnectedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_WasConnectedNotification is null)
					_WasConnectedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureDeviceWasConnectedNotification")!;
				return _WasConnectedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WasDisconnectedNotification;
		/// <summary>Notification constant for WasDisconnected</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWasDisconnected(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWasDisconnected(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVCaptureDevice.Notifications.ObserveWasDisconnected ((sender, args) => {
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
		/// void Callback (object sender, AVCaptureDevice.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVCaptureDevice.Notifications.ObserveWasDisconnected (Callback);
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
		///     AVCaptureDevice.WasDisconnectedNotification, (notification) => { Console.WriteLine ("Received the notification WasDisconnected", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WasDisconnected", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVCaptureDevice.WasDisconnectedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVCaptureDeviceWasDisconnectedNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[Advice ("Use AVCaptureDevice.Notifications.ObserveWasDisconnected helper method instead.")]
		public static NSString WasDisconnectedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_WasDisconnectedNotification is null)
					_WasDisconnectedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptureDeviceWasDisconnectedNotification")!;
				return _WasDisconnectedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FallbackPrimaryConstituentDevices_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVCaptureDevice" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureDevice.WasConnectedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureDevice.WasConnectedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureDevice.Notifications.ObserveWasConnected ((notification) => {
			///   Console.WriteLine ("Observed WasConnectedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasConnected (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasConnectedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureDevice.WasConnectedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureDevice.WasConnectedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureDevice.Notifications.ObserveWasConnected (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WasConnectedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasConnected (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasConnectedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureDevice.WasDisconnectedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureDevice.WasDisconnectedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVCaptureDevice.Notifications.ObserveWasDisconnected ((notification) => {
			///   Console.WriteLine ("Observed WasDisconnectedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasDisconnected (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasDisconnectedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVCaptureDevice.WasDisconnectedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVCaptureDevice.WasDisconnectedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVCaptureDevice.Notifications.ObserveWasDisconnected (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WasDisconnectedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasDisconnected (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasDisconnectedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVCaptureDevice */
}
