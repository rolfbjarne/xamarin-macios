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
	[Register("AVPlayerItem", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVPlayerItem : NSObject, IAVMetricEventStreamPublisher, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessLogX = "accessLog";
		static readonly NativeHandle selAccessLogXHandle = Selector.GetHandle ("accessLog");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddMediaDataCollector_X = "addMediaDataCollector:";
		static readonly NativeHandle selAddMediaDataCollector_XHandle = Selector.GetHandle ("addMediaDataCollector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOutput_X = "addOutput:";
		static readonly NativeHandle selAddOutput_XHandle = Selector.GetHandle ("addOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowedAudioSpatializationFormatsX = "allowedAudioSpatializationFormats";
		static readonly NativeHandle selAllowedAudioSpatializationFormatsXHandle = Selector.GetHandle ("allowedAudioSpatializationFormats");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppliesPerFrameHDRDisplayMetadataX = "appliesPerFrameHDRDisplayMetadata";
		static readonly NativeHandle selAppliesPerFrameHDRDisplayMetadataXHandle = Selector.GetHandle ("appliesPerFrameHDRDisplayMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetX = "asset";
		static readonly NativeHandle selAssetXHandle = Selector.GetHandle ("asset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioMixX = "audioMix";
		static readonly NativeHandle selAudioMixXHandle = Selector.GetHandle ("audioMix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioTimePitchAlgorithmX = "audioTimePitchAlgorithm";
		static readonly NativeHandle selAudioTimePitchAlgorithmXHandle = Selector.GetHandle ("audioTimePitchAlgorithm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyLoadedAssetKeysX = "automaticallyLoadedAssetKeys";
		static readonly NativeHandle selAutomaticallyLoadedAssetKeysXHandle = Selector.GetHandle ("automaticallyLoadedAssetKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyPreservesTimeOffsetFromLiveX = "automaticallyPreservesTimeOffsetFromLive";
		static readonly NativeHandle selAutomaticallyPreservesTimeOffsetFromLiveXHandle = Selector.GetHandle ("automaticallyPreservesTimeOffsetFromLive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPlayFastForwardX = "canPlayFastForward";
		static readonly NativeHandle selCanPlayFastForwardXHandle = Selector.GetHandle ("canPlayFastForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPlayFastReverseX = "canPlayFastReverse";
		static readonly NativeHandle selCanPlayFastReverseXHandle = Selector.GetHandle ("canPlayFastReverse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPlayReverseX = "canPlayReverse";
		static readonly NativeHandle selCanPlayReverseXHandle = Selector.GetHandle ("canPlayReverse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPlaySlowForwardX = "canPlaySlowForward";
		static readonly NativeHandle selCanPlaySlowForwardXHandle = Selector.GetHandle ("canPlaySlowForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPlaySlowReverseX = "canPlaySlowReverse";
		static readonly NativeHandle selCanPlaySlowReverseXHandle = Selector.GetHandle ("canPlaySlowReverse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanStepBackwardX = "canStepBackward";
		static readonly NativeHandle selCanStepBackwardXHandle = Selector.GetHandle ("canStepBackward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanStepForwardX = "canStepForward";
		static readonly NativeHandle selCanStepForwardXHandle = Selector.GetHandle ("canStepForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanUseNetworkResourcesForLiveStreamingWhilePausedX = "canUseNetworkResourcesForLiveStreamingWhilePaused";
		static readonly NativeHandle selCanUseNetworkResourcesForLiveStreamingWhilePausedXHandle = Selector.GetHandle ("canUseNetworkResourcesForLiveStreamingWhilePaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelPendingSeeksX = "cancelPendingSeeks";
		static readonly NativeHandle selCancelPendingSeeksXHandle = Selector.GetHandle ("cancelPendingSeeks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfiguredTimeOffsetFromLiveX = "configuredTimeOffsetFromLive";
		static readonly NativeHandle selConfiguredTimeOffsetFromLiveXHandle = Selector.GetHandle ("configuredTimeOffsetFromLive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyX = "copy";
		static readonly NativeHandle selCopyXHandle = Selector.GetHandle ("copy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDateX = "currentDate";
		static readonly NativeHandle selCurrentDateXHandle = Selector.GetHandle ("currentDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentMediaSelectionX = "currentMediaSelection";
		static readonly NativeHandle selCurrentMediaSelectionXHandle = Selector.GetHandle ("currentMediaSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentTimeX = "currentTime";
		static readonly NativeHandle selCurrentTimeXHandle = Selector.GetHandle ("currentTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomVideoCompositorX = "customVideoCompositor";
		static readonly NativeHandle selCustomVideoCompositorXHandle = Selector.GetHandle ("customVideoCompositor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEffectiveMediaPresentationSettingsForMediaSelectionGroup_X = "effectiveMediaPresentationSettingsForMediaSelectionGroup:";
		static readonly NativeHandle selEffectiveMediaPresentationSettingsForMediaSelectionGroup_XHandle = Selector.GetHandle ("effectiveMediaPresentationSettingsForMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorX = "error";
		static readonly NativeHandle selErrorXHandle = Selector.GetHandle ("error");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorLogX = "errorLog";
		static readonly NativeHandle selErrorLogXHandle = Selector.GetHandle ("errorLog");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForwardPlaybackEndTimeX = "forwardPlaybackEndTime";
		static readonly NativeHandle selForwardPlaybackEndTimeXHandle = Selector.GetHandle ("forwardPlaybackEndTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAsset_X = "initWithAsset:";
		static readonly NativeHandle selInitWithAsset_XHandle = Selector.GetHandle ("initWithAsset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAsset_AutomaticallyLoadedAssetKeys_X = "initWithAsset:automaticallyLoadedAssetKeys:";
		static readonly NativeHandle selInitWithAsset_AutomaticallyLoadedAssetKeys_XHandle = Selector.GetHandle ("initWithAsset:automaticallyLoadedAssetKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_X = "initWithURL:";
		static readonly NativeHandle selInitWithURL_XHandle = Selector.GetHandle ("initWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntegratedTimelineX = "integratedTimeline";
		static readonly NativeHandle selIntegratedTimelineXHandle = Selector.GetHandle ("integratedTimeline");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterstitialEventIdentifierX = "interstitialEventIdentifier";
		static readonly NativeHandle selInterstitialEventIdentifierXHandle = Selector.GetHandle ("interstitialEventIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAudioSpatializationAllowedX = "isAudioSpatializationAllowed";
		static readonly NativeHandle selIsAudioSpatializationAllowedXHandle = Selector.GetHandle ("isAudioSpatializationAllowed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlaybackBufferEmptyX = "isPlaybackBufferEmpty";
		static readonly NativeHandle selIsPlaybackBufferEmptyXHandle = Selector.GetHandle ("isPlaybackBufferEmpty");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlaybackBufferFullX = "isPlaybackBufferFull";
		static readonly NativeHandle selIsPlaybackBufferFullXHandle = Selector.GetHandle ("isPlaybackBufferFull");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlaybackLikelyToKeepUpX = "isPlaybackLikelyToKeepUp";
		static readonly NativeHandle selIsPlaybackLikelyToKeepUpXHandle = Selector.GetHandle ("isPlaybackLikelyToKeepUp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadedTimeRangesX = "loadedTimeRanges";
		static readonly NativeHandle selLoadedTimeRangesXHandle = Selector.GetHandle ("loadedTimeRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaDataCollectorsX = "mediaDataCollectors";
		static readonly NativeHandle selMediaDataCollectorsXHandle = Selector.GetHandle ("mediaDataCollectors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputsX = "outputs";
		static readonly NativeHandle selOutputsXHandle = Selector.GetHandle ("outputs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerItemWithAsset_X = "playerItemWithAsset:";
		static readonly NativeHandle selPlayerItemWithAsset_XHandle = Selector.GetHandle ("playerItemWithAsset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerItemWithAsset_AutomaticallyLoadedAssetKeys_X = "playerItemWithAsset:automaticallyLoadedAssetKeys:";
		static readonly NativeHandle selPlayerItemWithAsset_AutomaticallyLoadedAssetKeys_XHandle = Selector.GetHandle ("playerItemWithAsset:automaticallyLoadedAssetKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerItemWithURL_X = "playerItemWithURL:";
		static readonly NativeHandle selPlayerItemWithURL_XHandle = Selector.GetHandle ("playerItemWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredCustomMediaSelectionSchemesX = "preferredCustomMediaSelectionSchemes";
		static readonly NativeHandle selPreferredCustomMediaSelectionSchemesXHandle = Selector.GetHandle ("preferredCustomMediaSelectionSchemes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredForwardBufferDurationX = "preferredForwardBufferDuration";
		static readonly NativeHandle selPreferredForwardBufferDurationXHandle = Selector.GetHandle ("preferredForwardBufferDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMaximumResolutionX = "preferredMaximumResolution";
		static readonly NativeHandle selPreferredMaximumResolutionXHandle = Selector.GetHandle ("preferredMaximumResolution");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMaximumResolutionForExpensiveNetworksX = "preferredMaximumResolutionForExpensiveNetworks";
		static readonly NativeHandle selPreferredMaximumResolutionForExpensiveNetworksXHandle = Selector.GetHandle ("preferredMaximumResolutionForExpensiveNetworks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredPeakBitRateX = "preferredPeakBitRate";
		static readonly NativeHandle selPreferredPeakBitRateXHandle = Selector.GetHandle ("preferredPeakBitRate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredPeakBitRateForExpensiveNetworksX = "preferredPeakBitRateForExpensiveNetworks";
		static readonly NativeHandle selPreferredPeakBitRateForExpensiveNetworksXHandle = Selector.GetHandle ("preferredPeakBitRateForExpensiveNetworks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentationSizeX = "presentationSize";
		static readonly NativeHandle selPresentationSizeXHandle = Selector.GetHandle ("presentationSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecommendedTimeOffsetFromLiveX = "recommendedTimeOffsetFromLive";
		static readonly NativeHandle selRecommendedTimeOffsetFromLiveXHandle = Selector.GetHandle ("recommendedTimeOffsetFromLive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveMediaDataCollector_X = "removeMediaDataCollector:";
		static readonly NativeHandle selRemoveMediaDataCollector_XHandle = Selector.GetHandle ("removeMediaDataCollector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveOutput_X = "removeOutput:";
		static readonly NativeHandle selRemoveOutput_XHandle = Selector.GetHandle ("removeOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReversePlaybackEndTimeX = "reversePlaybackEndTime";
		static readonly NativeHandle selReversePlaybackEndTimeXHandle = Selector.GetHandle ("reversePlaybackEndTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToDate_X = "seekToDate:";
		static readonly NativeHandle selSeekToDate_XHandle = Selector.GetHandle ("seekToDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToDate_CompletionHandler_X = "seekToDate:completionHandler:";
		static readonly NativeHandle selSeekToDate_CompletionHandler_XHandle = Selector.GetHandle ("seekToDate:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_X = "seekToTime:";
		static readonly NativeHandle selSeekToTime_XHandle = Selector.GetHandle ("seekToTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_CompletionHandler_X = "seekToTime:completionHandler:";
		static readonly NativeHandle selSeekToTime_CompletionHandler_XHandle = Selector.GetHandle ("seekToTime:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_ToleranceBefore_ToleranceAfter_X = "seekToTime:toleranceBefore:toleranceAfter:";
		static readonly NativeHandle selSeekToTime_ToleranceBefore_ToleranceAfter_XHandle = Selector.GetHandle ("seekToTime:toleranceBefore:toleranceAfter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_X = "seekToTime:toleranceBefore:toleranceAfter:completionHandler:";
		static readonly NativeHandle selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_XHandle = Selector.GetHandle ("seekToTime:toleranceBefore:toleranceAfter:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekableTimeRangesX = "seekableTimeRanges";
		static readonly NativeHandle selSeekableTimeRangesXHandle = Selector.GetHandle ("seekableTimeRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekingWaitsForVideoCompositionRenderingX = "seekingWaitsForVideoCompositionRendering";
		static readonly NativeHandle selSeekingWaitsForVideoCompositionRenderingXHandle = Selector.GetHandle ("seekingWaitsForVideoCompositionRendering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectMediaOption_InMediaSelectionGroup_X = "selectMediaOption:inMediaSelectionGroup:";
		static readonly NativeHandle selSelectMediaOption_InMediaSelectionGroup_XHandle = Selector.GetHandle ("selectMediaOption:inMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectMediaOptionAutomaticallyInMediaSelectionGroup_X = "selectMediaOptionAutomaticallyInMediaSelectionGroup:";
		static readonly NativeHandle selSelectMediaOptionAutomaticallyInMediaSelectionGroup_XHandle = Selector.GetHandle ("selectMediaOptionAutomaticallyInMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectMediaPresentationLanguage_ForMediaSelectionGroup_X = "selectMediaPresentationLanguage:forMediaSelectionGroup:";
		static readonly NativeHandle selSelectMediaPresentationLanguage_ForMediaSelectionGroup_XHandle = Selector.GetHandle ("selectMediaPresentationLanguage:forMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectMediaPresentationSetting_ForMediaSelectionGroup_X = "selectMediaPresentationSetting:forMediaSelectionGroup:";
		static readonly NativeHandle selSelectMediaPresentationSetting_ForMediaSelectionGroup_XHandle = Selector.GetHandle ("selectMediaPresentationSetting:forMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedMediaOptionInMediaSelectionGroup_X = "selectedMediaOptionInMediaSelectionGroup:";
		static readonly NativeHandle selSelectedMediaOptionInMediaSelectionGroup_XHandle = Selector.GetHandle ("selectedMediaOptionInMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedMediaPresentationLanguageForMediaSelectionGroup_X = "selectedMediaPresentationLanguageForMediaSelectionGroup:";
		static readonly NativeHandle selSelectedMediaPresentationLanguageForMediaSelectionGroup_XHandle = Selector.GetHandle ("selectedMediaPresentationLanguageForMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedMediaPresentationSettingsForMediaSelectionGroup_X = "selectedMediaPresentationSettingsForMediaSelectionGroup:";
		static readonly NativeHandle selSelectedMediaPresentationSettingsForMediaSelectionGroup_XHandle = Selector.GetHandle ("selectedMediaPresentationSettingsForMediaSelectionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowedAudioSpatializationFormats_X = "setAllowedAudioSpatializationFormats:";
		static readonly NativeHandle selSetAllowedAudioSpatializationFormats_XHandle = Selector.GetHandle ("setAllowedAudioSpatializationFormats:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAppliesPerFrameHDRDisplayMetadata_X = "setAppliesPerFrameHDRDisplayMetadata:";
		static readonly NativeHandle selSetAppliesPerFrameHDRDisplayMetadata_XHandle = Selector.GetHandle ("setAppliesPerFrameHDRDisplayMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioMix_X = "setAudioMix:";
		static readonly NativeHandle selSetAudioMix_XHandle = Selector.GetHandle ("setAudioMix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioSpatializationAllowed_X = "setAudioSpatializationAllowed:";
		static readonly NativeHandle selSetAudioSpatializationAllowed_XHandle = Selector.GetHandle ("setAudioSpatializationAllowed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioTimePitchAlgorithm_X = "setAudioTimePitchAlgorithm:";
		static readonly NativeHandle selSetAudioTimePitchAlgorithm_XHandle = Selector.GetHandle ("setAudioTimePitchAlgorithm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticallyPreservesTimeOffsetFromLive_X = "setAutomaticallyPreservesTimeOffsetFromLive:";
		static readonly NativeHandle selSetAutomaticallyPreservesTimeOffsetFromLive_XHandle = Selector.GetHandle ("setAutomaticallyPreservesTimeOffsetFromLive:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_X = "setCanUseNetworkResourcesForLiveStreamingWhilePaused:";
		static readonly NativeHandle selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_XHandle = Selector.GetHandle ("setCanUseNetworkResourcesForLiveStreamingWhilePaused:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConfiguredTimeOffsetFromLive_X = "setConfiguredTimeOffsetFromLive:";
		static readonly NativeHandle selSetConfiguredTimeOffsetFromLive_XHandle = Selector.GetHandle ("setConfiguredTimeOffsetFromLive:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetForwardPlaybackEndTime_X = "setForwardPlaybackEndTime:";
		static readonly NativeHandle selSetForwardPlaybackEndTime_XHandle = Selector.GetHandle ("setForwardPlaybackEndTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredCustomMediaSelectionSchemes_X = "setPreferredCustomMediaSelectionSchemes:";
		static readonly NativeHandle selSetPreferredCustomMediaSelectionSchemes_XHandle = Selector.GetHandle ("setPreferredCustomMediaSelectionSchemes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredForwardBufferDuration_X = "setPreferredForwardBufferDuration:";
		static readonly NativeHandle selSetPreferredForwardBufferDuration_XHandle = Selector.GetHandle ("setPreferredForwardBufferDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredMaximumResolution_X = "setPreferredMaximumResolution:";
		static readonly NativeHandle selSetPreferredMaximumResolution_XHandle = Selector.GetHandle ("setPreferredMaximumResolution:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredMaximumResolutionForExpensiveNetworks_X = "setPreferredMaximumResolutionForExpensiveNetworks:";
		static readonly NativeHandle selSetPreferredMaximumResolutionForExpensiveNetworks_XHandle = Selector.GetHandle ("setPreferredMaximumResolutionForExpensiveNetworks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredPeakBitRate_X = "setPreferredPeakBitRate:";
		static readonly NativeHandle selSetPreferredPeakBitRate_XHandle = Selector.GetHandle ("setPreferredPeakBitRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredPeakBitRateForExpensiveNetworks_X = "setPreferredPeakBitRateForExpensiveNetworks:";
		static readonly NativeHandle selSetPreferredPeakBitRateForExpensiveNetworks_XHandle = Selector.GetHandle ("setPreferredPeakBitRateForExpensiveNetworks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReversePlaybackEndTime_X = "setReversePlaybackEndTime:";
		static readonly NativeHandle selSetReversePlaybackEndTime_XHandle = Selector.GetHandle ("setReversePlaybackEndTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSeekingWaitsForVideoCompositionRendering_X = "setSeekingWaitsForVideoCompositionRendering:";
		static readonly NativeHandle selSetSeekingWaitsForVideoCompositionRendering_XHandle = Selector.GetHandle ("setSeekingWaitsForVideoCompositionRendering:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStartsOnFirstEligibleVariant_X = "setStartsOnFirstEligibleVariant:";
		static readonly NativeHandle selSetStartsOnFirstEligibleVariant_XHandle = Selector.GetHandle ("setStartsOnFirstEligibleVariant:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextStyleRules_X = "setTextStyleRules:";
		static readonly NativeHandle selSetTextStyleRules_XHandle = Selector.GetHandle ("setTextStyleRules:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVariantPreferences_X = "setVariantPreferences:";
		static readonly NativeHandle selSetVariantPreferences_XHandle = Selector.GetHandle ("setVariantPreferences:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVideoApertureMode_X = "setVideoApertureMode:";
		static readonly NativeHandle selSetVideoApertureMode_XHandle = Selector.GetHandle ("setVideoApertureMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVideoComposition_X = "setVideoComposition:";
		static readonly NativeHandle selSetVideoComposition_XHandle = Selector.GetHandle ("setVideoComposition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartsOnFirstEligibleVariantX = "startsOnFirstEligibleVariant";
		static readonly NativeHandle selStartsOnFirstEligibleVariantXHandle = Selector.GetHandle ("startsOnFirstEligibleVariant");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStepByCount_X = "stepByCount:";
		static readonly NativeHandle selStepByCount_XHandle = Selector.GetHandle ("stepByCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextStyleRulesX = "textStyleRules";
		static readonly NativeHandle selTextStyleRulesXHandle = Selector.GetHandle ("textStyleRules");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimebaseX = "timebase";
		static readonly NativeHandle selTimebaseXHandle = Selector.GetHandle ("timebase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimedMetadataX = "timedMetadata";
		static readonly NativeHandle selTimedMetadataXHandle = Selector.GetHandle ("timedMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksX = "tracks";
		static readonly NativeHandle selTracksXHandle = Selector.GetHandle ("tracks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVariantPreferencesX = "variantPreferences";
		static readonly NativeHandle selVariantPreferencesXHandle = Selector.GetHandle ("variantPreferences");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoApertureModeX = "videoApertureMode";
		static readonly NativeHandle selVideoApertureModeXHandle = Selector.GetHandle ("videoApertureMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionX = "videoComposition";
		static readonly NativeHandle selVideoCompositionXHandle = Selector.GetHandle ("videoComposition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayerItem");
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
		protected AVPlayerItem (NSObjectFlag t) : base (t)
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
		protected internal AVPlayerItem (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerItem (NSUrl URL)
			: base (NSObjectFlag.Empty)
		{
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithURL_XHandle, URL__handle__), "initWithURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithURL_XHandle, URL__handle__), "initWithURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (URL);
		}
		[Export ("initWithAsset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerItem (AVAsset asset)
			: base (NSObjectFlag.Empty)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithAsset_XHandle, asset__handle__), "initWithAsset:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithAsset_XHandle, asset__handle__), "initWithAsset:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
		}
		[Export ("initWithAsset:automaticallyLoadedAssetKeys:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerItem (AVAsset asset, params NSString[]? automaticallyLoadedAssetKeys)
			: base (NSObjectFlag.Empty)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			using var nsa_automaticallyLoadedAssetKeys = automaticallyLoadedAssetKeys is null ? null : NSArray.FromNSObjects (automaticallyLoadedAssetKeys);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithAsset_AutomaticallyLoadedAssetKeys_XHandle, asset__handle__, nsa_automaticallyLoadedAssetKeys.GetHandle ()), "initWithAsset:automaticallyLoadedAssetKeys:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithAsset_AutomaticallyLoadedAssetKeys_XHandle, asset__handle__, nsa_automaticallyLoadedAssetKeys.GetHandle ()), "initWithAsset:automaticallyLoadedAssetKeys:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
		}
		[Export ("addMediaDataCollector:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMediaDataCollector (AVPlayerItemMediaDataCollector collector)
		{
			var collector__handle__ = collector!.GetNonNullHandle (nameof (collector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddMediaDataCollector_XHandle, collector__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddMediaDataCollector_XHandle, collector__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collector);
		}
		[Export ("addOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOutput (AVPlayerItemOutput output)
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
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("cancelPendingSeeks")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelPendingSeeks ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelPendingSeeksXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelPendingSeeksXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("copy")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy ()
		{
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCopyXHandle), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCopyXHandle), true)!;
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		[Export ("playerItemWithAsset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPlayerItem FromAsset (AVAsset? asset)
		{
			var asset__handle__ = asset.GetHandle ();
			AVPlayerItem? ret;
			ret =  Runtime.GetNSObject<AVPlayerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPlayerItemWithAsset_XHandle, asset__handle__), false)!;
			GC.KeepAlive (asset);
			return ret!;
		}
		[Export ("playerItemWithAsset:automaticallyLoadedAssetKeys:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPlayerItem FromAsset (AVAsset? asset, NSString[]? automaticallyLoadedAssetKeys)
		{
			var asset__handle__ = asset.GetHandle ();
			using var nsa_automaticallyLoadedAssetKeys = automaticallyLoadedAssetKeys is null ? null : NSArray.FromNSObjects (automaticallyLoadedAssetKeys);
			AVPlayerItem? ret;
			ret =  Runtime.GetNSObject<AVPlayerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPlayerItemWithAsset_AutomaticallyLoadedAssetKeys_XHandle, asset__handle__, nsa_automaticallyLoadedAssetKeys.GetHandle ()), false)!;
			GC.KeepAlive (asset);
			return ret!;
		}
		[Export ("playerItemWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPlayerItem FromUrl (NSUrl URL)
		{
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			AVPlayerItem? ret;
			ret =  Runtime.GetNSObject<AVPlayerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPlayerItemWithURL_XHandle, URL__handle__), false)!;
			GC.KeepAlive (URL);
			return ret!;
		}
		[Export ("effectiveMediaPresentationSettingsForMediaSelectionGroup:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<AVMediaPresentationSelector, NSObject> GetEffectiveMediaPresentationSettings (AVMediaSelectionGroup mediaSelectionGroup)
		{
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			NSDictionary<AVMediaPresentationSelector, NSObject>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<AVMediaPresentationSelector, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selEffectiveMediaPresentationSettingsForMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<AVMediaPresentationSelector, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selEffectiveMediaPresentationSettingsForMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaSelectionGroup);
			return ret!;
		}
		[Export ("selectedMediaPresentationLanguageForMediaSelectionGroup:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetSelectedMediaPresentationLanguage (AVMediaSelectionGroup mediaSelectionGroup)
		{
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSelectedMediaPresentationLanguageForMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectedMediaPresentationLanguageForMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaSelectionGroup);
			return ret!;
		}
		[Export ("selectedMediaPresentationSettingsForMediaSelectionGroup:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<AVMediaPresentationSelector, NSObject> GetSelectedMediaPresentationSettings (AVMediaSelectionGroup mediaSelectionGroup)
		{
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			NSDictionary<AVMediaPresentationSelector, NSObject>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<AVMediaPresentationSelector, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSelectedMediaPresentationSettingsForMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<AVMediaPresentationSelector, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectedMediaPresentationSettingsForMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaSelectionGroup);
			return ret!;
		}
		[Export ("removeMediaDataCollector:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveMediaDataCollector (AVPlayerItemMediaDataCollector collector)
		{
			var collector__handle__ = collector!.GetNonNullHandle (nameof (collector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveMediaDataCollector_XHandle, collector__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveMediaDataCollector_XHandle, collector__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collector);
		}
		[Export ("removeOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOutput (AVPlayerItemOutput output)
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
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("seekToDate:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'Seek (NSDate, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'Seek (NSDate, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'Seek (NSDate, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Seek (NSDate, AVCompletion)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Seek (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSeekToDate_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSeekToDate_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret != 0;
		}
		[Export ("seekToTime:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'Seek (CMTime, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'Seek (CMTime, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'Seek (CMTime, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Seek (CMTime, AVCompletion)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Seek (global::CoreMedia.CMTime time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSeekToTime_XHandle, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSeekToTime_XHandle, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("seekToTime:toleranceBefore:toleranceAfter:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'Seek (CMTime, CMTime, CMTime, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'Seek (CMTime, CMTime, CMTime, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'Seek (CMTime, CMTime, CMTime, AVCompletion)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Seek (CMTime, CMTime, CMTime, AVCompletion)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Seek (global::CoreMedia.CMTime time, global::CoreMedia.CMTime toleranceBefore, global::CoreMedia.CMTime toleranceAfter)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_CMTime_CMTime (this.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_XHandle, time, toleranceBefore, toleranceAfter);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime (&__objc_super__, selSeekToTime_ToleranceBefore_ToleranceAfter_XHandle, time, toleranceBefore, toleranceAfter);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("seekToTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Seek (global::CoreMedia.CMTime time, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion? completion)
		{
			using var block_completion = Trampolines.SDAVCompletion.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (this.Handle, selSeekToTime_CompletionHandler_XHandle, time, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime_NativeHandle (&__objc_super__, selSeekToTime_CompletionHandler_XHandle, time, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="time">Seek time target.</param>
		/// <summary>Seeks to a specific location in the playback stream</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Seek operation.   The value of the TResult parameter is a <see cref="AVFoundation.AVCompletion" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (global::CoreMedia.CMTime time)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Seek(time, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("seekToTime:toleranceBefore:toleranceAfter:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Seek (global::CoreMedia.CMTime time, global::CoreMedia.CMTime toleranceBefore, global::CoreMedia.CMTime toleranceAfter, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion? completion)
		{
			using var block_completion = Trampolines.SDAVCompletion.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_CMTime_CMTime_NativeHandle (this.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_XHandle, time, toleranceBefore, toleranceAfter, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime_NativeHandle (&__objc_super__, selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_XHandle, time, toleranceBefore, toleranceAfter, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="time">Seek time target.</param>
		/// <param name="toleranceBefore">To be added.</param>
		/// <param name="toleranceAfter">To be added.</param>
		/// <summary>Asynchronously seeks to the specified <paramref name="time" />, within the specified tolerances..</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (global::CoreMedia.CMTime time, global::CoreMedia.CMTime toleranceBefore, global::CoreMedia.CMTime toleranceAfter)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Seek(time, toleranceBefore, toleranceAfter, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("seekToDate:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Seek (NSDate date, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion completion)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAVCompletion.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSeekToDate_CompletionHandler_XHandle, date__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSeekToDate_CompletionHandler_XHandle, date__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret != 0;
		}
		/// <param name="date">Date to seek to.</param>
		/// <summary>Seeks the player to the specified date.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Seek operation.   The value of the TResult parameter is a <see cref="AVFoundation.AVCompletion" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The SeekAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (NSDate date)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Seek(date, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		/// <param name="date">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>Asynchronously seeks to the specified <paramref name="date" /> and indicates if it succeeded.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (NSDate date, out bool result)
		{
			var tcs = new TaskCompletionSource<bool> ();
			result = Seek(date, (finished_) => {
				tcs.SetResult (finished_!);
			})!;
			return tcs.Task;
		}
		[Export ("selectMediaOption:inMediaSelectionGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectMediaOption (AVMediaSelectionOption? mediaSelectionOption, AVMediaSelectionGroup mediaSelectionGroup)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSelectMediaOption_InMediaSelectionGroup_XHandle, mediaSelectionOption__handle__, mediaSelectionGroup__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSelectMediaOption_InMediaSelectionGroup_XHandle, mediaSelectionOption__handle__, mediaSelectionGroup__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaSelectionOption);
			GC.KeepAlive (mediaSelectionGroup);
		}
		[Export ("selectMediaOptionAutomaticallyInMediaSelectionGroup:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectMediaOptionAutomaticallyInMediaSelectionGroup (AVMediaSelectionGroup mediaSelectionGroup)
		{
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectMediaOptionAutomaticallyInMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectMediaOptionAutomaticallyInMediaSelectionGroup_XHandle, mediaSelectionGroup__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaSelectionGroup);
		}
		[Export ("selectMediaPresentationLanguage:forMediaSelectionGroup:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectMediaPresentationLanguage (string language, AVMediaSelectionGroup mediaSelectionGroup)
		{
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			var nslanguage = CFString.CreateNative (language);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSelectMediaPresentationLanguage_ForMediaSelectionGroup_XHandle, nslanguage, mediaSelectionGroup__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSelectMediaPresentationLanguage_ForMediaSelectionGroup_XHandle, nslanguage, mediaSelectionGroup__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaSelectionGroup);
			CFString.ReleaseNative (nslanguage);
		}
		[Export ("selectMediaPresentationSetting:forMediaSelectionGroup:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectMediaPresentationSetting (AVMediaPresentationSetting mediaPresentationSetting, AVMediaSelectionGroup mediaSelectionGroup)
		{
			var mediaPresentationSetting__handle__ = mediaPresentationSetting!.GetNonNullHandle (nameof (mediaPresentationSetting));
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSelectMediaPresentationSetting_ForMediaSelectionGroup_XHandle, mediaPresentationSetting__handle__, mediaSelectionGroup__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSelectMediaPresentationSetting_ForMediaSelectionGroup_XHandle, mediaPresentationSetting__handle__, mediaSelectionGroup__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaPresentationSetting);
			GC.KeepAlive (mediaSelectionGroup);
		}
		[Export ("selectedMediaOptionInMediaSelectionGroup:")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CurrentMediaSelection' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CurrentMediaSelection' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'CurrentMediaSelection' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CurrentMediaSelection' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMediaSelectionOption? SelectedMediaOption (AVMediaSelectionGroup inMediaSelectionGroup)
		{
			var inMediaSelectionGroup__handle__ = inMediaSelectionGroup!.GetNonNullHandle (nameof (inMediaSelectionGroup));
			AVMediaSelectionOption? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVMediaSelectionOption> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSelectedMediaOptionInMediaSelectionGroup_XHandle, inMediaSelectionGroup__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVMediaSelectionOption> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectedMediaOptionInMediaSelectionGroup_XHandle, inMediaSelectionGroup__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inMediaSelectionGroup);
			return ret!;
		}
		/// <param name="stepCount">To be added.</param><summary>Moves the playback head by <paramref name="stepCount" /> steps.</summary><remarks>To be added.</remarks>
		[Export ("stepByCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StepByCount (nint stepCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStepByCount_XHandle, stepCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selStepByCount_XHandle, stepCount);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerItemAccessLog? AccessLog {
			[Export ("accessLog")]
			get {
				AVPlayerItemAccessLog? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVPlayerItemAccessLog> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessLogXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVPlayerItemAccessLog> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessLogXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAudioSpatializationFormats AllowedAudioSpatializationFormats {
			[Export ("allowedAudioSpatializationFormats", ArgumentSemantic.Assign)]
			get {
				AVAudioSpatializationFormats ret;
				if (IsDirectBinding) {
					ret = (AVAudioSpatializationFormats) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAllowedAudioSpatializationFormatsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAudioSpatializationFormats) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAllowedAudioSpatializationFormatsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAllowedAudioSpatializationFormats:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAllowedAudioSpatializationFormats_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAllowedAudioSpatializationFormats_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AppliesPerFrameHdrDisplayMetadata {
			[Export ("appliesPerFrameHDRDisplayMetadata")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAppliesPerFrameHDRDisplayMetadataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAppliesPerFrameHDRDisplayMetadataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAppliesPerFrameHDRDisplayMetadata:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAppliesPerFrameHDRDisplayMetadata_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAppliesPerFrameHDRDisplayMetadata_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAsset Asset {
			[Export ("asset")]
			get {
				AVAsset? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAssetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAssetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioMix? AudioMix {
			[Export ("audioMix", ArgumentSemantic.Copy)]
			get {
				AVAudioMix? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioMix> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioMixXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioMix> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioMixXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudioMix:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudioMix_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudioMix_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'AllowedAudioSpatializationFormats' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'AllowedAudioSpatializationFormats' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'AllowedAudioSpatializationFormats' instead.")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AudioSpatializationAllowed {
			[Export ("isAudioSpatializationAllowed")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAudioSpatializationAllowedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAudioSpatializationAllowedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAudioSpatializationAllowed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAudioSpatializationAllowed_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAudioSpatializationAllowed_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString AudioTimePitchAlgorithm {
			[Export ("audioTimePitchAlgorithm", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioTimePitchAlgorithmXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioTimePitchAlgorithmXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudioTimePitchAlgorithm:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudioTimePitchAlgorithm_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudioTimePitchAlgorithm_XHandle, value__handle__);
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
		[SupportedOSPlatform ("tvos")]
		public virtual NSString[] AutomaticallyLoadedAssetKeys {
			[Export ("automaticallyLoadedAssetKeys", ArgumentSemantic.Copy)]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAutomaticallyLoadedAssetKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAutomaticallyLoadedAssetKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AutomaticallyPreservesTimeOffsetFromLive {
			[Export ("automaticallyPreservesTimeOffsetFromLive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutomaticallyPreservesTimeOffsetFromLiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutomaticallyPreservesTimeOffsetFromLiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyPreservesTimeOffsetFromLive:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticallyPreservesTimeOffsetFromLive_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticallyPreservesTimeOffsetFromLive_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPlayFastForward {
			[Export ("canPlayFastForward")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPlayFastForwardXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPlayFastForwardXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPlayFastReverse {
			[Export ("canPlayFastReverse")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPlayFastReverseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPlayFastReverseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPlayReverse {
			[Export ("canPlayReverse")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPlayReverseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPlayReverseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPlaySlowForward {
			[Export ("canPlaySlowForward")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPlaySlowForwardXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPlaySlowForwardXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPlaySlowReverse {
			[Export ("canPlaySlowReverse")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPlaySlowReverseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPlaySlowReverseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanStepBackward {
			[Export ("canStepBackward")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanStepBackwardXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanStepBackwardXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanStepForward {
			[Export ("canStepForward")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanStepForwardXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanStepForwardXHandle);
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
		[SupportedOSPlatform ("tvos")]
		public virtual bool CanUseNetworkResourcesForLiveStreamingWhilePaused {
			[Export ("canUseNetworkResourcesForLiveStreamingWhilePaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanUseNetworkResourcesForLiveStreamingWhilePausedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanUseNetworkResourcesForLiveStreamingWhilePausedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanUseNetworkResourcesForLiveStreamingWhilePaused:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::CoreMedia.CMTime ConfiguredTimeOffsetFromLive {
			[Export ("configuredTimeOffsetFromLive", ArgumentSemantic.Assign)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selConfiguredTimeOffsetFromLiveXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selConfiguredTimeOffsetFromLiveXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selConfiguredTimeOffsetFromLiveXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selConfiguredTimeOffsetFromLiveXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setConfiguredTimeOffsetFromLive:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetConfiguredTimeOffsetFromLive_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetConfiguredTimeOffsetFromLive_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? CurrentDate {
			[Export ("currentDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentDateXHandle), false)!;
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
		[SupportedOSPlatform ("tvos")]
		public virtual AVMediaSelection CurrentMediaSelection {
			[Export ("currentMediaSelection")]
			get {
				AVMediaSelection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVMediaSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentMediaSelectionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVMediaSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentMediaSelectionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime CurrentTime {
			[Export ("currentTime")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selCurrentTimeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selCurrentTimeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selCurrentTimeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selCurrentTimeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IAVVideoCompositing? CustomVideoCompositor {
			[Export ("customVideoCompositor", ArgumentSemantic.Copy)]
			get {
				IAVVideoCompositing? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAVVideoCompositing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomVideoCompositorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVVideoCompositing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomVideoCompositorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime Duration {
			[Export ("duration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError? Error {
			[Export ("error")]
			get {
				NSError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selErrorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selErrorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerItemErrorLog? ErrorLog {
			[Export ("errorLog")]
			get {
				AVPlayerItemErrorLog? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVPlayerItemErrorLog> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selErrorLogXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVPlayerItemErrorLog> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selErrorLogXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime ForwardPlaybackEndTime {
			[Export ("forwardPlaybackEndTime")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selForwardPlaybackEndTimeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selForwardPlaybackEndTimeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selForwardPlaybackEndTimeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selForwardPlaybackEndTimeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setForwardPlaybackEndTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetForwardPlaybackEndTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetForwardPlaybackEndTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual AVPlayerItemIntegratedTimeline IntegratedTimeline {
			[Export ("integratedTimeline")]
			get {
				AVPlayerItemIntegratedTimeline? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVPlayerItemIntegratedTimeline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIntegratedTimelineXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVPlayerItemIntegratedTimeline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIntegratedTimelineXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		public virtual string? InterstitialEventIdentifier {
			[Export ("interstitialEventIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInterstitialEventIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInterstitialEventIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] LoadedTimeRanges {
			[Export ("loadedTimeRanges")]
			get {
				NSValue[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLoadedTimeRangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLoadedTimeRangesXHandle), false)!;
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
		[SupportedOSPlatform ("tvos")]
		public virtual AVPlayerItemMediaDataCollector[] MediaDataCollectors {
			[Export ("mediaDataCollectors")]
			get {
				AVPlayerItemMediaDataCollector[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVPlayerItemMediaDataCollector>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaDataCollectorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVPlayerItemMediaDataCollector>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaDataCollectorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerItemOutput[] Outputs {
			[Export ("outputs")]
			get {
				AVPlayerItemOutput[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVPlayerItemOutput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVPlayerItemOutput>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the playback buffer is currently empty.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PlaybackBufferEmpty {
			[Export ("isPlaybackBufferEmpty")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlaybackBufferEmptyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlaybackBufferEmptyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the playback buffer is currently full.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PlaybackBufferFull {
			[Export ("isPlaybackBufferFull")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlaybackBufferFullXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlaybackBufferFullXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Predicts whether the current loading rate and playback buffer status is sufficient to play from the <see cref="P:AVFoundation.AVPlayerItem.CurrentTime" /> to the end without requiring a buffering pause.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PlaybackLikelyToKeepUp {
			[Export ("isPlaybackLikelyToKeepUp")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlaybackLikelyToKeepUpXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlaybackLikelyToKeepUpXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual AVCustomMediaSelectionScheme[] PreferredCustomMediaSelectionSchemes {
			[Export ("preferredCustomMediaSelectionSchemes", ArgumentSemantic.Copy)]
			get {
				AVCustomMediaSelectionScheme[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCustomMediaSelectionScheme>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredCustomMediaSelectionSchemesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCustomMediaSelectionScheme>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredCustomMediaSelectionSchemesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredCustomMediaSelectionSchemes:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreferredCustomMediaSelectionSchemes_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreferredCustomMediaSelectionSchemes_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double PreferredForwardBufferDuration {
			[Export ("preferredForwardBufferDuration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selPreferredForwardBufferDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selPreferredForwardBufferDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredForwardBufferDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetPreferredForwardBufferDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetPreferredForwardBufferDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGSize PreferredMaximumResolution {
			[Export ("preferredMaximumResolution", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selPreferredMaximumResolutionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selPreferredMaximumResolutionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredMaximumResolution:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetPreferredMaximumResolution_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetPreferredMaximumResolution_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGSize PreferredMaximumResolutionForExpensiveNetworks {
			[Export ("preferredMaximumResolutionForExpensiveNetworks", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selPreferredMaximumResolutionForExpensiveNetworksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selPreferredMaximumResolutionForExpensiveNetworksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredMaximumResolutionForExpensiveNetworks:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetPreferredMaximumResolutionForExpensiveNetworks_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetPreferredMaximumResolutionForExpensiveNetworks_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double PreferredPeakBitRate {
			[Export ("preferredPeakBitRate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selPreferredPeakBitRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selPreferredPeakBitRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredPeakBitRate:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetPreferredPeakBitRate_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetPreferredPeakBitRate_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual double PreferredPeakBitRateForExpensiveNetworks {
			[Export ("preferredPeakBitRateForExpensiveNetworks")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selPreferredPeakBitRateForExpensiveNetworksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selPreferredPeakBitRateForExpensiveNetworksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredPeakBitRateForExpensiveNetworks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetPreferredPeakBitRateForExpensiveNetworks_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetPreferredPeakBitRateForExpensiveNetworks_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize PresentationSize {
			[Export ("presentationSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selPresentationSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selPresentationSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::CoreMedia.CMTime RecommendedTimeOffsetFromLive {
			[Export ("recommendedTimeOffsetFromLive")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selRecommendedTimeOffsetFromLiveXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selRecommendedTimeOffsetFromLiveXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selRecommendedTimeOffsetFromLiveXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selRecommendedTimeOffsetFromLiveXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime ReversePlaybackEndTime {
			[Export ("reversePlaybackEndTime")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selReversePlaybackEndTimeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selReversePlaybackEndTimeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selReversePlaybackEndTimeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selReversePlaybackEndTimeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setReversePlaybackEndTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetReversePlaybackEndTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetReversePlaybackEndTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] SeekableTimeRanges {
			[Export ("seekableTimeRanges")]
			get {
				NSValue[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSeekableTimeRangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSeekableTimeRangesXHandle), false)!;
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
		[SupportedOSPlatform ("tvos")]
		public virtual bool SeekingWaitsForVideoCompositionRendering {
			[Export ("seekingWaitsForVideoCompositionRendering")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSeekingWaitsForVideoCompositionRenderingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSeekingWaitsForVideoCompositionRenderingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSeekingWaitsForVideoCompositionRendering:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSeekingWaitsForVideoCompositionRendering_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSeekingWaitsForVideoCompositionRendering_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool StartsOnFirstEligibleVariant {
			[Export ("startsOnFirstEligibleVariant")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStartsOnFirstEligibleVariantXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStartsOnFirstEligibleVariantXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setStartsOnFirstEligibleVariant:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStartsOnFirstEligibleVariant_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetStartsOnFirstEligibleVariant_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerItemStatus Status {
			[Export ("status")]
			get {
				AVPlayerItemStatus ret;
				if (IsDirectBinding) {
					ret = (AVPlayerItemStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVPlayerItemStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
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
		[SupportedOSPlatform ("tvos")]
		public virtual AVTextStyleRule[]? TextStyleRules {
			[Export ("textStyleRules", ArgumentSemantic.Copy)]
			get {
				AVTextStyleRule[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVTextStyleRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextStyleRulesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVTextStyleRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextStyleRulesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextStyleRules:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextStyleRules_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextStyleRules_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimebase? Timebase {
			[Export ("timebase")]
			get {
				global::CoreMedia.CMTimebase ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMTimebase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimebaseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMTimebase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimebaseXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[ObsoletedOSPlatform ("macos10.15", "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSObject[]? TimedMetadata {
			[Export ("timedMetadata")]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimedMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimedMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerItemTrack[] Tracks {
			[Export ("tracks")]
			get {
				AVPlayerItemTrack[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVPlayerItemTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTracksXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVPlayerItemTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTracksXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVVariantPreferences VariantPreferences {
			[Export ("variantPreferences", ArgumentSemantic.Assign)]
			get {
				AVVariantPreferences ret;
				if (IsDirectBinding) {
					ret = (AVVariantPreferences) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selVariantPreferencesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVVariantPreferences) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selVariantPreferencesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVariantPreferences:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetVariantPreferences_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetVariantPreferences_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVVideoComposition? VideoComposition {
			[Export ("videoComposition", ArgumentSemantic.Copy)]
			get {
				AVVideoComposition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoCompositionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoCompositionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoComposition:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVideoComposition_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVideoComposition_XHandle, value__handle__);
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
		[SupportedOSPlatform ("tvos")]
		internal virtual NSString _VideoApertureMode {
			[Export ("videoApertureMode")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoApertureModeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoApertureModeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoApertureMode:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVideoApertureMode_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVideoApertureMode_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidPlayToEndTimeNotification;
		/// <summary>Notification constant for DidPlayToEndTime</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidPlayToEndTime(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidPlayToEndTime(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveDidPlayToEndTime ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveDidPlayToEndTime (Callback);
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
		///     AVPlayerItem.DidPlayToEndTimeNotification, (notification) => { Console.WriteLine ("Received the notification DidPlayToEndTime", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidPlayToEndTime", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.DidPlayToEndTimeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemDidPlayToEndTimeNotification",  "AVFoundation")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveDidPlayToEndTime helper method instead.")]
		public static NSString DidPlayToEndTimeNotification {
			get {
				if (_DidPlayToEndTimeNotification is null)
					_DidPlayToEndTimeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemDidPlayToEndTimeNotification")!;
				return _DidPlayToEndTimeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemFailedToPlayToEndTimeErrorKey;
		/// <summary>Represents the value associated with the constant AVPlayerItemFailedToPlayToEndTimeErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVPlayerItemFailedToPlayToEndTimeErrorKey",  "AVFoundation")]
		public static NSString ItemFailedToPlayToEndTimeErrorKey {
			get {
				if (_ItemFailedToPlayToEndTimeErrorKey is null)
					_ItemFailedToPlayToEndTimeErrorKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeErrorKey")!;
				return _ItemFailedToPlayToEndTimeErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemFailedToPlayToEndTimeNotification;
		/// <summary>Notification constant for ItemFailedToPlayToEndTime</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveItemFailedToPlayToEndTime(NSObject,EventHandler{AVPlayerItemErrorEventArgs})" />
		///     or <see cref="Notifications.ObserveItemFailedToPlayToEndTime(EventHandler{AVPlayerItemErrorEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveItemFailedToPlayToEndTime ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.AVPlayerItemErrorEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveItemFailedToPlayToEndTime (Callback);
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
		///     AVPlayerItem.ItemFailedToPlayToEndTimeNotification, (notification) => { Console.WriteLine ("Received the notification ItemFailedToPlayToEndTime", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ItemFailedToPlayToEndTime", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.ItemFailedToPlayToEndTimeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemFailedToPlayToEndTimeNotification",  "AVFoundation")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveItemFailedToPlayToEndTime helper method instead.")]
		public static NSString ItemFailedToPlayToEndTimeNotification {
			get {
				if (_ItemFailedToPlayToEndTimeNotification is null)
					_ItemFailedToPlayToEndTimeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeNotification")!;
				return _ItemFailedToPlayToEndTimeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSelectionDidChangeNotification;
		/// <summary>Notification constant for MediaSelectionDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMediaSelectionDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMediaSelectionDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveMediaSelectionDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveMediaSelectionDidChange (Callback);
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
		///     AVPlayerItem.MediaSelectionDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification MediaSelectionDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MediaSelectionDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.MediaSelectionDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemMediaSelectionDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveMediaSelectionDidChange helper method instead.")]
		public static NSString MediaSelectionDidChangeNotification {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MediaSelectionDidChangeNotification is null)
					_MediaSelectionDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemMediaSelectionDidChangeNotification")!;
				return _MediaSelectionDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NewAccessLogEntryNotification;
		/// <summary>Notification constant for NewAccessLogEntry</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveNewAccessLogEntry(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveNewAccessLogEntry(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveNewAccessLogEntry ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveNewAccessLogEntry (Callback);
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
		///     AVPlayerItem.NewAccessLogEntryNotification, (notification) => { Console.WriteLine ("Received the notification NewAccessLogEntry", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification NewAccessLogEntry", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.NewAccessLogEntryNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemNewAccessLogEntryNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveNewAccessLogEntry helper method instead.")]
		public static NSString NewAccessLogEntryNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NewAccessLogEntryNotification is null)
					_NewAccessLogEntryNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemNewAccessLogEntryNotification")!;
				return _NewAccessLogEntryNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NewErrorLogEntryNotification;
		/// <summary>Notification constant for NewErrorLogEntry</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveNewErrorLogEntry(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveNewErrorLogEntry(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveNewErrorLogEntry ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveNewErrorLogEntry (Callback);
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
		///     AVPlayerItem.NewErrorLogEntryNotification, (notification) => { Console.WriteLine ("Received the notification NewErrorLogEntry", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification NewErrorLogEntry", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.NewErrorLogEntryNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemNewErrorLogEntryNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveNewErrorLogEntry helper method instead.")]
		public static NSString NewErrorLogEntryNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NewErrorLogEntryNotification is null)
					_NewErrorLogEntryNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemNewErrorLogEntryNotification")!;
				return _NewErrorLogEntryNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaybackStalledNotification;
		/// <summary>Notification constant for PlaybackStalled</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePlaybackStalled(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePlaybackStalled(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObservePlaybackStalled ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObservePlaybackStalled (Callback);
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
		///     AVPlayerItem.PlaybackStalledNotification, (notification) => { Console.WriteLine ("Received the notification PlaybackStalled", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PlaybackStalled", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.PlaybackStalledNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemPlaybackStalledNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVPlayerItem.Notifications.ObservePlaybackStalled helper method instead.")]
		public static NSString PlaybackStalledNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PlaybackStalledNotification is null)
					_PlaybackStalledNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemPlaybackStalledNotification")!;
				return _PlaybackStalledNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecommendedTimeOffsetFromLiveDidChangeNotification;
		/// <summary>Notification constant for RecommendedTimeOffsetFromLiveDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange (Callback);
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
		///     AVPlayerItem.RecommendedTimeOffsetFromLiveDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification RecommendedTimeOffsetFromLiveDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RecommendedTimeOffsetFromLiveDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.RecommendedTimeOffsetFromLiveDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemRecommendedTimeOffsetFromLiveDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange helper method instead.")]
		public static NSString RecommendedTimeOffsetFromLiveDidChangeNotification {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RecommendedTimeOffsetFromLiveDidChangeNotification is null)
					_RecommendedTimeOffsetFromLiveDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemRecommendedTimeOffsetFromLiveDidChangeNotification")!;
				return _RecommendedTimeOffsetFromLiveDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeJumpedNotification;
		/// <summary>Notification constant for TimeJumped</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTimeJumped(NSObject,EventHandler{AVPlayerItemTimeJumpedEventArgs})" />
		///     or <see cref="Notifications.ObserveTimeJumped(EventHandler{AVPlayerItemTimeJumpedEventArgs})" /> methods,
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
		/// notification = AVPlayerItem.Notifications.ObserveTimeJumped ((sender, args) => {
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
		/// void Callback (object sender, AVPlayerItem.AVPlayerItemTimeJumpedEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayerItem.Notifications.ObserveTimeJumped (Callback);
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
		///     AVPlayerItem.TimeJumpedNotification, (notification) => { Console.WriteLine ("Received the notification TimeJumped", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TimeJumped", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayerItem.TimeJumpedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerItemTimeJumpedNotification",  "AVFoundation")]
		[Advice ("Use AVPlayerItem.Notifications.ObserveTimeJumped helper method instead.")]
		public static NSString TimeJumpedNotification {
			get {
				if (_TimeJumpedNotification is null)
					_TimeJumpedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerItemTimeJumpedNotification")!;
				return _TimeJumpedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVPlayerItem" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.DidPlayToEndTimeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.DidPlayToEndTimeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveDidPlayToEndTime ((notification) => {
			///   Console.WriteLine ("Observed DidPlayToEndTimeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidPlayToEndTime (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidPlayToEndTimeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.DidPlayToEndTimeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.DidPlayToEndTimeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveDidPlayToEndTime (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidPlayToEndTimeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidPlayToEndTime (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidPlayToEndTimeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.ItemFailedToPlayToEndTimeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.ItemFailedToPlayToEndTimeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveItemFailedToPlayToEndTime ((notification) => {
			///   Console.WriteLine ("Observed ItemFailedToPlayToEndTimeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemFailedToPlayToEndTime (EventHandler<AVFoundation.AVPlayerItemErrorEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemFailedToPlayToEndTimeNotification, notification => handler (null, new AVFoundation.AVPlayerItemErrorEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.ItemFailedToPlayToEndTimeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.ItemFailedToPlayToEndTimeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveItemFailedToPlayToEndTime (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ItemFailedToPlayToEndTimeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveItemFailedToPlayToEndTime (NSObject objectToObserve, EventHandler<AVFoundation.AVPlayerItemErrorEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ItemFailedToPlayToEndTimeNotification, notification => handler (null, new AVFoundation.AVPlayerItemErrorEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.MediaSelectionDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.MediaSelectionDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveMediaSelectionDidChange ((notification) => {
			///   Console.WriteLine ("Observed MediaSelectionDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaSelectionDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaSelectionDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.MediaSelectionDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.MediaSelectionDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveMediaSelectionDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MediaSelectionDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaSelectionDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaSelectionDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.NewAccessLogEntryNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.NewAccessLogEntryNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveNewAccessLogEntry ((notification) => {
			///   Console.WriteLine ("Observed NewAccessLogEntryNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNewAccessLogEntry (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NewAccessLogEntryNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.NewAccessLogEntryNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.NewAccessLogEntryNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveNewAccessLogEntry (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NewAccessLogEntryNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNewAccessLogEntry (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NewAccessLogEntryNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.NewErrorLogEntryNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.NewErrorLogEntryNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveNewErrorLogEntry ((notification) => {
			///   Console.WriteLine ("Observed NewErrorLogEntryNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNewErrorLogEntry (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NewErrorLogEntryNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.NewErrorLogEntryNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.NewErrorLogEntryNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveNewErrorLogEntry (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NewErrorLogEntryNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNewErrorLogEntry (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NewErrorLogEntryNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.PlaybackStalledNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.PlaybackStalledNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObservePlaybackStalled ((notification) => {
			///   Console.WriteLine ("Observed PlaybackStalledNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePlaybackStalled (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PlaybackStalledNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.PlaybackStalledNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.PlaybackStalledNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObservePlaybackStalled (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PlaybackStalledNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePlaybackStalled (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PlaybackStalledNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.RecommendedTimeOffsetFromLiveDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.RecommendedTimeOffsetFromLiveDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange ((notification) => {
			///   Console.WriteLine ("Observed RecommendedTimeOffsetFromLiveDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRecommendedTimeOffsetFromLiveDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RecommendedTimeOffsetFromLiveDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.RecommendedTimeOffsetFromLiveDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.RecommendedTimeOffsetFromLiveDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RecommendedTimeOffsetFromLiveDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRecommendedTimeOffsetFromLiveDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RecommendedTimeOffsetFromLiveDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.TimeJumpedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.TimeJumpedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayerItem.Notifications.ObserveTimeJumped ((notification) => {
			///   Console.WriteLine ("Observed TimeJumpedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTimeJumped (EventHandler<AVFoundation.AVPlayerItemTimeJumpedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TimeJumpedNotification, notification => handler (null, new AVFoundation.AVPlayerItemTimeJumpedEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayerItem.TimeJumpedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayerItem.TimeJumpedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayerItem.Notifications.ObserveTimeJumped (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TimeJumpedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTimeJumped (NSObject objectToObserve, EventHandler<AVFoundation.AVPlayerItemTimeJumpedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TimeJumpedNotification, notification => handler (null, new AVFoundation.AVPlayerItemTimeJumpedEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVPlayerItem */
}
