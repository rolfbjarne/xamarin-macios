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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#nullable enable
	public delegate void AVAssetImageGenerateAsynchronouslyForTimeCompletionHandler (CGImage? imageRef, CMTime actualTime, NSError? error);
	/// <param name="requestedTime">To be added.</param><param name="imageRef">To be added.</param><param name="actualTime">To be added.</param><param name="result">To be added.</param><param name="error">To be added.</param><summary>A delegate that defines the handler for <see cref="M:AVFoundation.AVAssetImageGenerator.GenerateCGImagesAsynchronously(Foundation.NSValue[],AVFoundation.AVAssetImageGeneratorCompletionHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void AVAssetImageGeneratorCompletionHandler (CMTime requestedTime, IntPtr imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, NSError? error);
	public delegate void AVAssetImageGeneratorCompletionHandler2 (CMTime requestedTime, CGImage? imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, NSError? error);
	public delegate void AVAssetPlaybackAssistantLoadPlaybackConfigurationOptionsHandler (String[] playbackConfigurationOptions);
	public delegate AVAudioBuffer AVAudioConverterInputHandler (uint inNumberOfPackets, out AVAudioConverterInputStatus outStatus);
	public delegate AVAudioEngineManualRenderingStatus AVAudioEngineManualRenderingBlock (uint numberOfFrames, AudioToolbox.AudioBuffers outBuffer, ref int outError);
	public delegate AudioToolbox.AudioBuffers AVAudioIONodeInputBlock (uint frameCount);
	public delegate void AVAudioInputNodeMutedSpeechEventListener (AVAudioVoiceProcessingSpeechActivityEvent @event);
	/// <param name="buffer">To be added.</param><param name="when">To be added.</param><summary>Delegate that receives copies of the output of a <see cref="T:AVFoundation.AVAudioNode" /></summary><remarks>To be added.</remarks>
	public delegate void AVAudioNodeTapBlock (AVAudioPcmBuffer buffer, AVAudioTime when);
	public delegate void AVAudioSequencerUserCallback (AVMusicTrack track, NSData userData, double timeStamp);
	public delegate int AVAudioSinkNodeReceiverHandlerRaw (IntPtr timestamp, uint frameCount, IntPtr inputData);
	/// <summary>The delegate that will be called in a callback from <see cref="T:AVFoundation.AVAudioSourceNode" />.</summary><returns>An OSStatus result code. Return 0 to indicate success.</returns><param name="isSilence">Indicates whether the supplied audio data only contains silence. This is a pointer to a <see cref="T:System.Byte" /> value.</param><param name="timestamp">The timestamp the audio renders (HAL time). This is a pointer to an <see cref="T:AudioToolbox.AudioTimeStamp" /> value.</param><param name="frameCount">The number of frames of audio to supply.</param><param name="outputData">The <see cref="T:AudioToolbox.AudioBuffers" /> that contains the supplied audio data when the callback returns. This is a handle for an <see cref="T:AudioToolbox.AudioBuffers" /> value.</param>
	public delegate int AVAudioSourceNodeRenderHandlerRaw (IntPtr isSilence, IntPtr timestamp, uint frameCount, IntPtr outputData);
	public delegate bool AVAudioUnitComponentFilter (AVAudioUnitComponent comp, ref bool stop);
	/// <summary>A delegate for the completion handler of <see cref="M:AVFoundation.AVCaptureStillImageOutput.CaptureStillImageAsynchronously(AVFoundation.AVCaptureConnection,AVFoundation.AVCaptureCompletionHandler)" />.</summary>
	public delegate void AVCaptureCompletionHandler (CMSampleBuffer imageDataSampleBuffer, NSError? error);
	public delegate void AVCaptureDeskViewApplicationPresentHandler (NSError? error);
	public delegate void AVCaptureDeviceSetDynamicAspectRatioCallback (CMTime syncTime, NSError? error);
	public delegate void AVCaptureIndexPickerCallback (IntPtr newValue);
	public delegate string AVCaptureIndexPickerTitleTransform (IntPtr index);
	public delegate void AVCaptureSliderCallback (float newValue);
	public delegate void AVCaptureSystemExposureBiasSliderCallback (NFloat exposureTargetBias);
	public delegate void AVCaptureSystemZoomSliderCallback (NFloat videoZoomFactor);
	/// <param name="finished">To be added.</param><summary>A delegate that defines the completion handler for various methods in <see cref="T:AVFoundation.AVPlayer" /> and <see cref="T:AVFoundation.AVPlayerItem" /></summary><remarks>To be added.</remarks>
	public delegate void AVCompletion (bool finished);
	public delegate void AVExternalStorageDeviceRequestAccessCallback (bool granted);
	public delegate void AVMusicEventEnumerationBlock (AVMusicEvent @event, out double timeStamp, out bool removeEvent);
	public delegate void AVMutableCompositionInsertHandler (NSError? error);
	public delegate void AVMutableVideoCompositionCreateApplier (AVAsynchronousCIImageFilteringRequest request);
	public delegate void AVMutableVideoCompositionCreateCallback (AVMutableVideoComposition? videoComposition, NSError? error);
	/// <summary>The delegate for <see cref="M:AVFoundation.AVAudioSession.RequestRecordPermission(AVFoundation.AVPermissionGranted)" />.</summary>
	public delegate void AVPermissionGranted (bool granted);
	public delegate void AVPlayerItemIntegratedTimelineAddBoundaryTimeObserverCallback (bool success);
	public delegate void AVPlayerItemIntegratedTimelineAddPeriodicTimeObserverCallback (CMTime time);
	public delegate void AVPlayerItemIntegratedTimelineSeekCallback (bool success);
	/// <summary>The delegate for <see cref="AVFoundation.AVCaptureDevice.RequestAccessForMediaTypeAsync(Foundation.NSString)" />.</summary>
	public delegate void AVRequestAccessStatus (bool accessGranted);
	public delegate void AVSampleBufferGeneratorBatchMakeReadyCallback (NSError? error);
	public delegate void AVSampleBufferVideoRendererLoadVideoPerformanceMetricsCallback (AVVideoPerformanceMetrics? videoPerformanceMetrics);
	public delegate void AVSpeechSynthesisProviderOutputBlock (AVSpeechSynthesisMarker[] markers, AVSpeechSynthesisProviderRequest request);
	public delegate void AVSpeechSynthesizerBufferCallback (AVAudioBuffer buffer);
	public delegate void AVSpeechSynthesizerMarkerCallback (AVSpeechSynthesisMarker[] markers);
	public delegate void AVSpeechSynthesizerRequestPersonalVoiceAuthorizationCallback (AVSpeechSynthesisPersonalVoiceAuthorizationStatus status);
	public delegate void AVVideoCompositionCreateApplier (AVAsynchronousCIImageFilteringRequest applier);
	public delegate void AVVideoCompositionCreateCallback (AVVideoComposition? videoComposition, NSError? error);
	public delegate void AVVideoCompositionDetermineValidityCallback (bool isValid, NSError? error);
}
namespace AVKit {
	#nullable enable
	public delegate void AVCustomRoutingControllerDelegateCompletionHandler (bool success);
}
namespace Accessibility {
	#nullable enable
	public delegate NSString ValueDescriptionProviderHandler (double dataValue);
}
namespace Accounts {
	#nullable enable
	/// <param name="success"><see langword="true" /> if the account was removed. Otherwise, <see langword="false" />.</param><param name="error">The error that was encountered, or <see langword="null" /> if no error was encountered.</param><summary>A handler to be run when an attempt is made to remove an account from the store.</summary>
	public delegate void ACAccountStoreRemoveCompletionHandler (bool success, NSError? error);
	/// <summary>A delegate that specifies the completion handler in calls to the <see cref="M:Accounts.ACAccountStore.SaveAccount(Accounts.ACAccount,Accounts.ACAccountStoreSaveCompletionHandler)" /> method.</summary>
	public delegate void ACAccountStoreSaveCompletionHandler (bool success, NSError? error);
	/// <summary>A delegate that specifies the handler executed at the completion of calls to <see cref="Accounts.ACAccountStore.RequestAccessAsync(Accounts.ACAccountType,Foundation.NSDictionary)" />s.</summary>
	public delegate void ACRequestCompletionHandler (bool granted, NSError? error);
}
namespace AppKit {
	#nullable enable
	public delegate bool NSCustomImageRepDrawingHandler (CGRect dstRect);
	public delegate bool NSToolbarCanInsert (NSToolbar toolbar, string itemIdentifier, IntPtr index);
	public delegate String[] NSToolbarIdentifiers (NSToolbar toolbar);
	public delegate global::Foundation.NSSet<NSString> NSToolbarImmovableItemIdentifiers (NSToolbar toolbar);
	public delegate NSToolbarItem? NSToolbarWillInsert (NSToolbar toolbar, string itemIdentifier, bool willBeInserted);
	public delegate NSTouchBarItem? NSTouchBarMakeItem (NSTouchBar touchBar, string identifier);
}
namespace AudioUnit {
	#nullable enable
	/// <param name="transportStateFlags">The state of the audio transport.</param><param name="currentSamplePosition">The host sample position, in audio unit samples.</param><param name="cycleStartBeatPosition">The starting beat position for the cycle. <see langword="null" /> if not cycling.</param><param name="cycleEndBeatPosition">The ending beat position for the cycle. <see langword="null" /> if not cycling.</param><summary>A delegate block that a host uses to provide information about its transport state.</summary><returns><para><see langword="true" /> if the state was successfully retrieved. Otherwise, <see langword="false" />.</para></returns><remarks><para>Developers may optionally assign an instance of this class to the <see cref="P:AudioUnit.AUAudioUnit.TransportStateBlock" /> property so that they can call it at the beginning of render cycles to get the transport state at the cycle start.</para></remarks>
	public delegate bool AUHostTransportStateBlock (ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition);
	/// <param name="node">The parameter node for which to get a possibly shortened name.</param><param name="desiredLength">The maximum desired length of the display name.</param><summary>A delegate that returns the display name, possibly shortened to <paramref name="desiredLength" /> characters.</summary><returns>The display name, possibly shortened to <paramref name="desiredLength" /> characters.</returns>
	public delegate string AUImplementorDisplayNameWithLengthCallback (AUParameterNode node, IntPtr desiredLength);
	public delegate string AUImplementorStringFromValueCallback (AUParameter param, ref global::System.Nullable<float> value);
	/// <param name="param">The parameter that will be assigned to the value that is converted from <paramref name="str" />.</param><param name="str">The string to convert.</param><summary>Converts <paramref name="str" /> to the appropriate type and assigns it to <paramref name="param" />.</summary><returns>The new audio unit value.</returns>
	public delegate float AUImplementorValueFromStringCallback (AUParameter param, string str);
	/// <param name="param">The parameter that changed.</param><param name="value">The new parameter value.</param><summary>A delegate that notifies the audio unit when a parameter value changes.</summary>
	public delegate void AUImplementorValueObserver (AUParameter param, float value);
	/// <param name="param">The parameter whose value to get.</param><summary>A delegate that retrieves a parameter value.</summary><returns>The value of the parameter that is identified by <paramref name="param" />.</returns>
	public delegate float AUImplementorValueProvider (AUParameter param);
	/// <param name="actionFlags">The action flags that configure the audio unit rendering process.</param><param name="timestamp">The unconverted, uncompressed HAL time when the input will render.</param><param name="frameCount">The number of available audio frames.</param><param name="inputBusNumber">The input bus index.</param><summary>Delegate that tells an I/O host when input is available.</summary>
	public delegate void AUInputHandler (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr inputBusNumber);
	public delegate AudioUnitStatus AUInternalRenderBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr outputBusNumber, AudioToolbox.AudioBuffers outputData, AURenderEventEnumerator realtimeEventListHead, [BlockCallback] AURenderPullInputBlock? pullInputBlock);
	public delegate void AUMidiCIProfileChangedCallback (byte cable, byte channel, CoreMidi.MidiCIProfile profile, bool enabled);
	public delegate int AUMidiOutputEventBlock (long eventSampleTime, byte cable, IntPtr length, IntPtr midiBytes);
	public delegate void AUParameterAutomationObserver (ulong address, float value);
	/// <param name="address">The parameter address.</param><param name="value">The current parameter value.</param><summary>Observer that notifies an audio unit when a parameter value changes.</summary>
	public delegate void AUParameterObserver (ulong address, float value);
	/// <param name="numberOfEvents">The number of automation events.</param><param name="events">The delivered events.</param><summary>Delegate that records parameter changes as automation events.</summary>
	public delegate void AUParameterRecordingObserver (IntPtr numberOfEvents, ref AURecordedParameterEvent events);
	public delegate AudioUnitStatus AURenderBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr outputBusNumber, AudioToolbox.AudioBuffers outputData, [BlockCallback] AURenderPullInputBlock? pullInputBlock);
	public delegate AudioUnitStatus AURenderPullInputBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr inputBusNumber, AudioToolbox.AudioBuffers inputData);
	public delegate void AUScheduleParameterBlock (AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value);
}
namespace AuthenticationServices {
	#nullable enable
	/// <summary>Delegate used in callbacks by <see cref="T:AuthenticationServices.ASCredentialIdentityStore" />.</summary>
	public delegate void ASCredentialIdentityStoreCompletionHandler (bool success, NSError? error);
	public delegate void ASCredentialIdentityStoreGetCredentialIdentitiesHandler (AuthenticationServices.IASCredentialIdentity[] credentialIdentities);
	/// <summary>Delegate object for completion handlers in methods within <see cref="T:AuthenticationServices.ASCredentialProviderExtensionContext" />.</summary>
	public delegate void ASCredentialProviderExtensionRequestCompletionHandler (bool expired);
	public delegate void ASSettingsHelperRequestToTurnOnCredentialProviderExtensionCallback (bool appWasEnabledForAutofill);
	/// <param name="callbackUrl">To be added.</param><param name="error">To be added.</param><summary>Delegate method used in <see cref="T:AuthenticationServices.ASWebAuthenticationSession" /> interactions.</summary><remarks>To be added.</remarks>
	public delegate void ASWebAuthenticationSessionCompletionHandler (NSUrl? callbackUrl, NSError? error);
}
namespace BackgroundAssets {
	#nullable enable
	public delegate void BAAssetPackManagerCheckForUpdatesCompletionHandler (global::Foundation.NSSet<NSString>? updatingIdentifiers, global::Foundation.NSSet<NSString>? removedIdentifiers, NSError? error);
	public delegate void BAAssetPackManagerEnsureLocalAvailabilityCompletionHandler (NSError? error);
	public delegate void BAAssetPackManagerGetAllAssetPacksCompletionHandler (global::Foundation.NSSet<global::BackgroundAssets.BAAssetPack>? assetPacks, NSError? error);
	public delegate void BAAssetPackManagerGetAssetPackCompletionHandler (BackgroundAssets.BAAssetPack? assetPack, NSError? error);
	/// <summary>Completion handler invoked with the local status of an asset pack.</summary><param name="status">The <see cref="T:BackgroundAssets.BAAssetPackStatus" /> of the asset pack on the local device.</param>
	public delegate void BAAssetPackManagerGetLocalStatusCompletionHandler (BackgroundAssets.BAAssetPackStatus status);
	public delegate void BAAssetPackManagerGetStatusCompletionHandler (BackgroundAssets.BAAssetPackStatus status, NSError? error);
	public delegate void BAAssetPackManagerRemoveAssetPackCompletionHandler (NSError? error);
}
namespace Cinematic {
	#nullable enable
	public delegate void CNAssetSpatialAudioInfoCheckIfContainsSpatialAudioCallback (bool result);
	public delegate void CNAssetSpatialAudioInfoLoadCallback (Cinematic.CNAssetSpatialAudioInfo? assetInfo, NSError? error);
}
namespace ClassKit {
	#nullable enable
	/// <summary>Completion handler for <see cref="M:ClassKit.CLSDataStore.CheckIsAssignedDocument(Foundation.NSUrl,ClassKit.CLSDataStoreCheckAssignedDocumentCompletionHandler)" />.</summary>
	public delegate void CLSDataStoreCheckAssignedDocumentCompletionHandler (bool isAssigned, NSError? error);
}
namespace CloudKit {
	#nullable enable
	public delegate void CKAcceptPerShareCompletionHandler (CKShareMetadata shareMetadata, CKShare? acceptedShare, NSError? error);
	/// <param name="subscriptionId">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:CloudKit.CKDatabase.DeleteSubscription(System.String,CloudKit.CKDatabaseDeleteSubscriptionHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void CKDatabaseDeleteSubscriptionHandler (string? subscriptionId, NSError? error);
	public delegate void CKFetchDatabaseChangesCompletionHandler (CKServerChangeToken? serverChangeToken, bool moreComing, NSError? operationError);
	public delegate void CKFetchPerShareMetadataHandler (NSUrl shareURL, CKShareMetadata? shareMetadata, NSError? error);
	/// <param name="serverChangeToken">To be added.</param><param name="clientChangeTokenData">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchRecordChangesOperation.AllChangesReported" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKFetchRecordChangesHandler (CKServerChangeToken? serverChangeToken, NSData? clientChangeTokenData, NSError? operationError);
	public delegate void CKFetchRecordZoneChangesFetchCompletedHandler (CKRecordZoneID? recordZoneID, CKServerChangeToken? serverChangeToken, NSData? clientChangeTokenData, bool moreComing, NSError? recordZoneError);
	public delegate void CKFetchRecordZoneChangesRecordWasChangedHandler (CKRecordID? recordId, CKRecord? record, NSError? error);
	public delegate void CKFetchRecordZoneChangesTokensUpdatedHandler (CKRecordZoneID? recordZoneID, CKServerChangeToken? serverChangeToken, NSData? clientChangeTokenData);
	public delegate void CKFetchRecordZoneChangesWithIDWasDeletedHandler (CKRecordID recordID, NSString recordType);
	/// <param name="recordsByRecordId">To be added.</param><param name="error">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchRecordsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKFetchRecordsCompletedHandler (NSDictionary? recordsByRecordId, NSError? error);
	public delegate void CKFetchShareParticipantsOperationPerShareParticipantCompletionHandler (CKUserIdentityLookupInfo? identityLookupInfo, CKShareParticipant? participant, NSError? error);
	/// <param name="subscriptionsBySubscriptionId">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchSubscriptionsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKFetchSubscriptionsCompleteHandler (NSDictionary? subscriptionsBySubscriptionId, NSError? operationError);
	public delegate void CKFetchSubscriptionsPerSubscriptionCompletionHandler (NSString? subscriptionId, CKSubscription? subscription, NSError? error);
	public delegate void CKFetchWebAuthTokenOperationHandler (string? webAuthToken, NSError? operationError);
	/// <param name="savedRecordZones">To be added.</param><param name="deletedRecordZoneIds">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKModifyRecordZonesOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKModifyRecordZonesHandler (CKRecordZone[]? savedRecordZones, CKRecordZoneID[]? deletedRecordZoneIds, NSError? operationError);
	public delegate void CKModifyRecordZonesPerRecordZoneDeleteHandler (CKRecordZoneID? zoneId, NSError? error);
	public delegate void CKModifyRecordZonesPerRecordZoneSaveHandler (CKRecordZoneID? zoneId, CKRecordZone? zone, NSError? error);
	/// <param name="savedRecords">To be added.</param><param name="deletedRecordIds">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKModifyRecordsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKModifyRecordsOperationHandler (CKRecord[]? savedRecords, CKRecordID[]? deletedRecordIds, NSError? operationError);
	public delegate void CKModifyRecordsOperationPerRecordDeleteHandler (CKRecordID? recordId, NSError? error);
	public delegate void CKModifyRecordsOperationPerRecordSaveHandler (CKRecordID? recordId, CKRecord? record, NSError? error);
	/// <param name="savedSubscriptions">To be added.</param><param name="deletedSubscriptionIds">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKModifySubscriptionsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKModifySubscriptionsHandler (CKSubscription[]? savedSubscriptions, String[]? deletedSubscriptionIds, NSError? operationError);
	public delegate void CKModifySubscriptionsPerSubscriptionDeleteHandler (NSString? subscriptionId, NSError? error);
	public delegate void CKModifySubscriptionsPerSubscriptionSaveHandler (NSString? subscriptionId, CKSubscription? subscription, NSError? error);
	public delegate void CKQueryOperationRecordMatchedHandler (CKRecordID? recordId, CKRecord? record, NSError? error);
	/// <param name="recordZonesByZoneId">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchRecordZonesOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKRecordZoneCompleteHandler (NSDictionary? recordZonesByZoneId, NSError? operationError);
	public delegate void CKRecordZonePerRecordZoneCompletionHandler (CKRecordZoneID? recordZoneId, CKRecordZone? recordZone, NSError? error);
	public delegate void CKShareRequestAccessOperationPerShareAccessRequestCompletionHandler (NSUrl shareUrl, NSError? error);
	public delegate void CKShareRequestAccessOperationShareRequestAccessCompletionHandler (NSError? error);
}
namespace Contacts {
	#nullable enable
	public delegate void CNContactStoreListContactsHandler (CNContact contact, ref bool stop);
	/// <summary>Completion handler for calls to <see cref="M:Contacts.CNContactStore.RequestAccess(Contacts.CNEntityType,Contacts.CNContactStoreRequestAccessHandler)" /></summary>
	public delegate void CNContactStoreRequestAccessHandler (bool granted, NSError? error);
}
namespace CoreData {
	#nullable enable
	public delegate bool NSBatchInsertRequestDictionaryHandler (NSMutableDictionary dictionary);
	public delegate bool NSBatchInsertRequestManagedObjectHandler (CoreData.NSManagedObject managedObject);
	public delegate void NSPersistentCloudKitContainerAcceptShareInvitationsHandler (global::Foundation.NSArray<global::CloudKit.CKShareMetadata>? acceptedShareMetadatas, NSError? error);
	public delegate void NSPersistentCloudKitContainerFetchParticipantsMatchingLookupInfosHandler (global::Foundation.NSArray<global::CloudKit.CKShareParticipant>? fetchedParticipants, NSError? error);
	public delegate void NSPersistentCloudKitContainerPersistUpdatedShareHandler (CKShare? persistedShare, NSError? error);
	public delegate void NSPersistentCloudKitContainerPurgeObjectsAndRecordsInZoneHandler (CKRecordZoneID? purgedZoneId, NSError? error);
	public delegate void NSPersistentCloudKitContainerShareManagedObjectsHandler (global::Foundation.NSSet<global::CoreData.NSManagedObjectID>? sharedObjectIds, CKShare? share, CKContainer? container, NSError? error);
}
namespace CoreImage {
	#nullable enable
	/// <summary>Completion handler for deterimining a region of interest in the source image.</summary>
	public delegate CGRect CIKernelRoiCallback (int index, CGRect rect);
}
namespace CoreLocation {
	#nullable enable
	public delegate void CLBackgroundActivitySessionCreateHandler (CLBackgroundActivitySessionDiagnostic diagnostic);
	/// <summary>A delegate that is the <c>completionHandler</c> for various asynchronous methods in <see cref="T:CoreLocation.CLGeocoder" />.</summary><param name="placemarks">Returns null on error, otherwise the list of placemark locations.   Typically one, but could be more than one if the location is known by multiple names.</param><param name="error">Error information.</param>
	public delegate void CLGeocodeCompletionHandler (CLPlacemark[]? placemarks, NSError? error);
	public delegate bool CLLocationManagerEventArgs (CLLocationManager manager);
	public delegate void CLServiceSessionCreateHandler (CLServiceSessionDiagnostic diagnostic);
}
namespace CoreML {
	#nullable enable
	public delegate void MLModelAssetGetFunctionNamesCompletionHandler (String[]? functionNames, NSError? error);
	public delegate void MLModelAssetGetModelDescriptionCompletionHandler (MLModelDescription? modelDescription, NSError? error);
	public delegate void MLStateGetMultiArrayForStateHandler (MLMultiArray buffer);
	public delegate void MLStateGetPredictionCompletionHandler (IMLFeatureProvider? output, NSError? error);
}
namespace CoreMidi {
	#nullable enable
	public delegate void MidiCIDiscoveryResponseDelegate (CoreMidi.MidiCIDiscoveredNode[] discoveredNodes);
	public delegate void MidiCIProfileChangedHandler (CoreMidi.MidiCISession session, byte channel, CoreMidi.MidiCIProfile profile, bool enabled);
	public delegate void MidiCIProfileSpecificDataHandler (CoreMidi.MidiCISession session, byte channel, CoreMidi.MidiCIProfile profile, NSData data);
	public delegate void MidiCISessionDisconnectHandler (CoreMidi.MidiCISession? session, NSError? error);
	public delegate void MidiReceiveBlock (IntPtr eventList, IntPtr srcConnRefCon);
}
namespace CoreMotion {
	#nullable enable
	/// <param name="data">The accelerometer data for this event.</param><param name="error">An error, or null if there have been no errors.</param><summary>A delegate signature used to receive events from <see cref="T:CoreMotion.CMMotionManager" /></summary><remarks><para>
	/// This signature is used as an argument to the <see cref="T:CoreMotion.CMMotionManager" />'s StartAccelerometerUpdates.  
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var motionManager = new CMMotionManager ();
	/// motionManager.AccelerometerUpdateInterval = 0.01; // 100Hz
	/// motionManager.StartAccelerometerUpdates (NSOperationQueue.CurrentQueue, (data, error) => {
	/// Console.WriteLine ("Got an acceleration event {0}", data.Acceleration.X);
	/// });
	/// ]]></code></example></remarks>
	public delegate void CMAccelerometerHandler (CMAccelerometerData? data, NSError? error);
	/// <param name="motion">The device motion for this event (attitude, rotation rate and acceleration for the device).</param><param name="error">The error if any, or null if there are no errors to report.</param><summary>A delegate signature used to receive events from <see cref="T:CoreMotion.CMMotionManager" /></summary><remarks><para>
	/// This signature is used as an argument to the <see cref="T:CoreMotion.CMMotionManager" />'s StartDeviceMotionUpdates.  
	/// </para><para>
	/// 		For example:
	/// 	</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var motionManager = new CMMotionManager ();
	/// motionManager.AccelerometerUpdateInterval = 0.01; // 100Hz
	/// motionManager.StartDeviceMotionUpdates (NSOperationQueue.CurrentQueue, (motion, error) => {
	/// Console.WriteLine ("RotationRate={0} Gravity={1} UserAcceleration={2} Attitude={3}", motion.RotationRate, motion.Gravity, motion.UserAcceleration, motion.Attitude);
	/// });
	/// ]]></code></example></remarks>
	public delegate void CMDeviceMotionHandler (CMDeviceMotion? motion, NSError? error);
	/// <param name="gyroData">The gyroscope data for this event.</param><param name="error">Error or null if there are no errors.</param><summary>A delegate signature used to receive events from <see cref="T:CoreMotion.CMMotionManager" /></summary><remarks><para>
	/// This signature is used as an argument to the <see cref="T:CoreMotion.CMMotionManager" />'s StartGyroUpdates.  
	/// </para><para>
	/// For example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var motionManager = new CMMotionManager ();
	/// motionManager.AccelerometerUpdateInterval = 0.01; // 100Hz
	/// motionManager.StartDeviceMotionUpdates (NSOperationQueue.CurrentQueue, (gyroData, error) => {
	/// Console.WriteLine ("RotationRate={0}", gyroData.RotationRate);
	/// });
	/// ]]></code></example></remarks>
	public delegate void CMGyroHandler (CMGyroData? gyroData, NSError? error);
	public delegate void CMHeadphoneActivityHandler (CMMotionActivity? activity, NSError? error);
	public delegate void CMHeadphoneActivityStatusHandler (CMHeadphoneActivityStatus status, NSError? error);
	public delegate void CMHeadphoneDeviceMotionHandler (CMDeviceMotion? motion, NSError? error);
	/// <param name="magnetometerData">
	/// 
	/// 
	/// The magnetometer data being provider
	/// 	   
	/// 	   </param><param name="error">
	/// 
	/// 
	/// Error, if any.
	/// 	   
	/// 	   </param><summary>A delegate that is the <c>handler</c> for the <see cref="M:CoreMotion.CMMotionManager.StartMagnetometerUpdates(Foundation.NSOperationQueue,CoreMotion.CMMagnetometerHandler)" /> method.</summary><remarks>Signature for a method that can receive magnetometer data from the CMMotionManager.</remarks>
	public delegate void CMMagnetometerHandler (CMMagnetometerData? magnetometerData, NSError? error);
	/// <summary>The delegate that acts as the handler for <see cref="M:CoreMotion.CMMotionActivityManager.QueryActivity(Foundation.NSDate,Foundation.NSDate,Foundation.NSOperationQueue,CoreMotion.CMMotionActivityQueryHandler)" />.</summary>
	public delegate void CMMotionActivityHandler (CMMotionActivity? activity);
	/// <summary>The delegate that is the handler for <see cref="M:CoreMotion.CMMotionActivityManager.StartActivityUpdates(Foundation.NSOperationQueue,CoreMotion.CMMotionActivityHandler)" />.</summary>
	public delegate void CMMotionActivityQueryHandler (CMMotionActivity[]? activities, NSError? error);
	/// <summary>The delegate for use with <see cref="M:CoreMotion.CMStepCounter.QueryStepCount(Foundation.NSDate,Foundation.NSDate,Foundation.NSOperationQueue,CoreMotion.CMStepQueryHandler)" />.</summary>
	public delegate void CMStepQueryHandler (IntPtr numberOfSteps, NSError? error);
	/// <summary>The delegate used with <see cref="M:CoreMotion.CMStepCounter.StartStepCountingUpdates(Foundation.NSOperationQueue,System.IntPtr,CoreMotion.CMStepUpdateHandler)" />.</summary>
	public delegate void CMStepUpdateHandler (IntPtr numberOfSteps, NSDate timestamp, NSError? error);
}
namespace CoreNFC {
	#nullable enable
	public delegate void NFCFeliCaPollingCompletionHandler (NSData pmm, NSData requestData, NSError? error);
	public delegate void NFCFeliCaReadWithoutEncryptionCompletionHandler (IntPtr statusFlag1, IntPtr statusFlag2, NSData[] blockData, NSError? error);
	public delegate void NFCFeliCaRequestServiceV2CompletionHandler (IntPtr statusFlag1, IntPtr statusFlag2, CoreNFC.NFCFeliCaEncryptionId encryptionIdentifier, NSData[] nodeKeyVersionListAes, NSData[] nodeKeyVersionListDes, NSError? error);
	public delegate void NFCFeliCaRequestSpecificationVersionCompletionHandler (IntPtr statusFlag1, IntPtr statusFlag2, NSData basicVersion, NSData optionVersion, NSError? error);
	public delegate void NFCFeliCaStatus1Status2CompletionHandler (IntPtr statusFlag1, IntPtr statusFlag2, NSError? error);
	public delegate void NFCGetSystemInfoCompletionHandler (IntPtr dsfid, IntPtr afi, IntPtr blockSize, IntPtr blockCount, IntPtr icReference, NSError? error);
	public delegate void NFCIso15693TagGetMultipleBlockSecurityStatusCallback (NSNumber[] securityStatus, NSError? error);
	public delegate void NFCIso15693TagGetSystemInfoAndUidCallback (NSData uid, IntPtr dsfid, IntPtr afi, IntPtr blockSize, IntPtr blockCount, IntPtr icReference, NSError? error);
	public delegate void NFCIso15693TagReadMultipleBlocksCallback (NSData[] dataBlocks, NSError? error);
	public delegate void NFCIso15693TagResponseCallback (CoreNFC.NFCIso15693ResponseFlag responseFlag, NSData response, NSError? error);
	public delegate void NFCIso7816SendCompletionHandler (NSData responseData, byte sw1, byte sw2, NSError? error);
	public delegate void NFCQueryNdefStatusCompletionHandler (CoreNFC.NFCNdefStatus status, UIntPtr capacity, NSError error);
}
namespace CoreSpotlight {
	#nullable enable
	public delegate void CSSearchableIndexDelegateGetSearchableItemsHandler (CoreSpotlight.CSSearchableItem[] items);
	public delegate void CSSearchableIndexEndIndexHandler (NSError? error);
	/// <summary>Completion handler used in <see cref="CoreSpotlight.CSSearchableIndex_CSOptionalBatchingExtension.FetchLastClientState(CoreSpotlight.CSSearchableIndex,CoreSpotlight.CSSearchableIndexFetchHandler)" />.</summary>
	public delegate void CSSearchableIndexFetchHandler (NSData clientState, NSError? error);
}
namespace CoreTelephony {
	#nullable enable
	public delegate void CTCellularPlanProvisioningUpdateCellularPlanCompletionHandler (NSError? error);
	public delegate void CTCellularPlanStatusCheckValidityCompletionHandler (bool isValid, NSError? error);
	public delegate void CTCellularPlanStatusGetTokenCompletionHandler (string? token, NSError? error);
}
namespace CryptoTokenKit {
	#nullable enable
	public delegate void TKGetSlotCallback (CryptoTokenKit.TKSmartCardSlot? slot);
	public delegate bool TKSmartCardExecuteCallback (out NSError? error);
	public delegate void TKSmartCardSendCallback (NSData? replyData, UInt16 sq, NSError? error);
}
namespace DeviceCheck {
	#nullable enable
	/// <param name="token">The generated token.</param><param name="error">The error that was encountered, or <see langword="null" /> if no error occurred.</param><summary>A completion handler for DeviceCheck token generation.</summary>
	public delegate void DCDeviceGenerateTokenCompletionHandler (NSData? token, NSError? error);
}
namespace EventKit {
	#nullable enable
	/// <param name="theEvent">The matching event.</param><param name="stop">If you set this ref value to true, the enumeration will stop.</param><summary>Delegate signature for the event enumeration method in <see cref="T:EventKit.EKEventStore" /></summary><remarks>The method will be invoked repeatedly, once for each event that matches the provided NSPredicate.</remarks>
	public delegate void EKEventSearchCallback (EventKit.EKEvent theEvent, ref bool stop);
	public delegate void EKEventStoreRequestAccessCompletionHandler (bool didRequestAccess, NSError? error);
	public delegate void VirtualConferenceHandler (EventKit.EKVirtualConferenceDescriptor? virtualConferenceDescriptor, NSError? error);
	public delegate void VirtualConferenceRoomTypeHandler (global::Foundation.NSArray<global::EventKit.EKVirtualConferenceRoomTypeDescriptor>? virtualConferenceRoomTypeDescriptor, NSError? error);
}
namespace EventKitUI {
	#nullable enable
	public delegate EventKit.EKCalendar EKEventEditController (EventKitUI.EKEventEditViewController controller);
}
namespace Foundation {
	#nullable enable
	/// <param name="date">To be added.</param><param name="exactMatch">To be added.</param><param name="stop">To be added.</param><summary>Completion handler for the <see cref="M:Foundation.NSCalendar.EnumerateDatesStartingAfterDate(Foundation.NSDate,Foundation.NSDateComponents,Foundation.NSCalendarOptions,Foundation.EnumerateDatesCallback)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void EnumerateDatesCallback (NSDate date, bool exactMatch, ref bool stop);
	/// <param name="idx">To be added.</param><param name="stop">To be added.</param><summary>Defines the enumerator callback in calls to <see cref="M:Foundation.NSIndexSet.EnumerateIndexes(Foundation.NSRange,Foundation.NSEnumerationOptions,Foundation.EnumerateIndexSetCallback)" />.</summary><remarks>To be added.</remarks>
	public delegate void EnumerateIndexSetCallback (UIntPtr idx, ref bool stop);
	public delegate void ItemProviderDataCompletionHandler (NSData? data, NSError? error);
	public delegate void LinguisticTagEnumerator (string tag, NSRange tokenRange, bool stop);
	public delegate void LoadFileRepresentationHandler (NSUrl? fileUrl, bool openInPlace, NSError? error);
	public delegate void LoadInPlaceFileRepresentationHandler (NSUrl? fileUrl, bool isInPlace, NSError? error);
	/// <param name="attrs">To be added.</param><param name="range">To be added.</param><param name="stop">To be added.</param><summary>A delegate that specifies the callback for the <see cref="M:Foundation.NSAttributedString.EnumerateAttributes(Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedRangeCallback)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void NSAttributedRangeCallback (NSDictionary attrs, NSRange range, ref bool stop);
	/// <param name="value">To be added.</param><param name="range">To be added.</param><param name="stop">To be added.</param><summary>A delegate that specifies the callback for the <see cref="M:Foundation.NSAttributedString.EnumerateAttribute(Foundation.NSString,Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedStringCallback)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void NSAttributedStringCallback (NSObject value, NSRange range, ref bool stop);
	public delegate void NSAttributedStringCompletionHandler (NSAttributedString? attributedString, global::Foundation.NSDictionary<NSString, NSObject>? attributes, NSError? error);
	/// <param name="obj1">To be added.</param><param name="obj2">To be added.</param><summary>A delegate that defines the comparison function to be used with functions such as <see cref="M:Foundation.NSArray.Sort(Foundation.NSComparator)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate NSComparisonResult NSComparator (NSObject obj1, NSObject obj2);
	/// <param name="bytes">To be added.</param><param name="range">To be added.</param><param name="stop">To be added.</param><summary>The delegate used to enumerate in calls to <see cref="M:Foundation.NSData.EnumerateByteRange(Foundation.NSDataByteRangeEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSDataByteRangeEnumerator (IntPtr bytes, NSRange range, ref bool stop);
	public delegate NSObject NSDecoderCallback (NSKeyedUnarchiver unarchiver, NSObject obj);
	public delegate Class NSDecoderHandler (NSKeyedUnarchiver unarchiver, string klass, String[] classes);
	public delegate void NSDictionaryEnumerator (NSObject key, NSObject obj, ref bool stop);
	public delegate bool NSDictionaryKeyFilter (NSObject key, NSObject obj, ref bool stop);
	public delegate NSObject NSEncodeHook (NSKeyedArchiver archiver, NSObject obj);
	/// <param name="url">To be added.</param><param name="error">To be added.</param><summary>A delegate that specifies the error handler for use in <see cref="M:Foundation.NSFileManager.GetEnumerator(Foundation.NSUrl,Foundation.NSString[],Foundation.NSDirectoryEnumerationOptions,Foundation.NSEnumerateErrorHandler)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate bool NSEnumerateErrorHandler (NSUrl url, NSError error);
	/// <param name="tag">To be added.</param><param name="tokenRange">To be added.</param><param name="sentenceRange">To be added.</param><param name="stop">To be added.</param><summary>An enumerator to pass to methods in the <see cref="T:Foundation.NSLinguisticAnalysis" /> class.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate bool NSEnumerateLinguisticTagsEnumerator (NSString? tag, NSRange tokenRange, NSRange sentenceRange, ref bool stop);
	/// <param name="error">To be added.</param><param name="userInfoKey">To be added.</param><summary>Delegate returned by <see cref="M:Foundation.NSError.GetUserInfoValueProvider(System.String)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate NSObject NSErrorUserInfoValueProvider (NSError error, NSString userInfoKey);
	public delegate NSObject NSExpressionCallbackHandler (NSObject? evaluatedObject, NSExpression[] expressions, NSMutableDictionary? context);
	/// <param name="newReadingUrl">To be added.</param><param name="newWritingUrl">To be added.</param><summary>A delegate that used with a number of coordinated read-and-write functions in <see cref="T:Foundation.NSFileCoordinator" />.</summary><remarks>To be added.</remarks>
	public delegate void NSFileCoordinatorWorkerRW (NSUrl newReadingUrl, NSUrl newWritingUrl);
	public delegate void NSFileManagerFetchLatestRemoteVersionOfItemHandler (NSFileVersion? latestRemoteVersion, NSError? error);
	public delegate void NSFileManagerSyncForUbiquitousItemHandler (NSError? error);
	public delegate void NSFileManagerUploadLocalVersionOfUbiquitousItemHandler (NSFileVersion? uploadedVersion, NSError? error);
	/// <param name="reacquirer">To be added.</param><summary>Completion handler for relinquishing a file to a reader.</summary><remarks>To be added.</remarks>
	public delegate void NSFilePresenterReacquirer ([BlockCallback] Action reacquirer);
	public delegate void NSFileVersionNonlocalVersionsCompletionHandler (NSFileVersion[]? nonlocalFileVersions, NSError? error);
	/// <param name="itemBeingLoaded">To be added.</param><param name="error">To be added.</param><summary>The completion handler used with <see cref="T:Foundation.NSItemProviderLoadHandler" /> delegates.</summary><remarks>To be added.</remarks>
	public delegate void NSItemProviderCompletionHandler (INSSecureCoding itemBeingLoaded, NSError error);
	/// <param name="completionHandler">To be added.</param><param name="expectedValueClass">To be added.</param><param name="options">To be added.</param><summary>Defines the load handler for use with the <see cref="M:Foundation.NSItemProvider.RegisterItemForTypeIdentifier(System.String,Foundation.NSItemProviderLoadHandler)" /> and <see cref="M:Foundation.NSItemProvider.SetPreviewImageHandler(Foundation.NSItemProviderLoadHandler)" /> methods.</summary><remarks>To be added.</remarks>
	public delegate void NSItemProviderLoadHandler ([BlockCallback] NSItemProviderCompletionHandler? completionHandler, Class? expectedValueClass, NSDictionary? options);
	public delegate NSProgress NSItemProviderUTTypeLoadDelegate ([BlockCallback] ItemProviderDataCompletionHandler completionHandler);
	/// <param name="tag">To be added.</param><param name="tokenRange">To be added.</param><param name="sentenceRange">To be added.</param><param name="stop">To be added.</param><summary>A delegate that enumerates values for <see cref="M:Foundation.NSLinguisticTagger.EnumerateTagsInRange(Foundation.NSRange,Foundation.NSString,Foundation.NSLinguisticTaggerOptions,Foundation.NSLingusticEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSLingusticEnumerator (NSString? tag, NSRange tokenRange, NSRange sentenceRange, ref bool stop);
	/// <param name="result">To be added.</param><param name="flags">To be added.</param><param name="stop">To be added.</param><summary>Delegate applied to results in <see cref="M:Foundation.NSRegularExpression.EnumerateMatches(Foundation.NSString,Foundation.NSMatchingOptions,Foundation.NSRange,Foundation.NSMatchEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSMatchEnumerator (NSTextCheckingResult result, NSMatchingFlags flags, ref bool stop);
	/// <param name="result">To be added.</param><param name="idx">To be added.</param><param name="stop">To be added.</param><summary>The delegate used as the callback in calls to <see cref="M:Foundation.NSMetadataQuery.EnumerateResultsUsingBlock(Foundation.NSMetadataQueryEnumerationCallback)" /> and <see cref="M:Foundation.NSMetadataQuery.EnumerateResultsWithOptions(Foundation.NSEnumerationOptions,Foundation.NSMetadataQueryEnumerationCallback)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSMetadataQueryEnumerationCallback (NSObject result, UIntPtr idx, ref bool stop);
	public delegate NSObject NSMetadataQueryObject (NSMetadataQuery query, NSMetadataItem result);
	public delegate NSObject NSMetadataQueryValue (NSMetadataQuery query, string attributeName, NSObject value);
	/// <param name="evaluatedObject">To be added.</param><param name="bindings">To be added.</param><summary>A delegate that represents the expression to use with <see cref="M:Foundation.NSPredicate.FromExpression(Foundation.NSPredicateEvaluator)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate bool NSPredicateEvaluator (NSObject? evaluatedObject, NSDictionary? bindings);
	/// <param name="range">To be added.</param><param name="stop">To be added.</param><summary>A delegate used to specify the iterator used by <see cref="M:Foundation.NSIndexSet.EnumerateRanges(Foundation.NSRange,Foundation.NSEnumerationOptions,Foundation.NSRangeIterator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSRangeIterator (NSRange range, ref bool stop);
	/// <param name="obj">To be added.</param><param name="stop">To be added.</param><summary>A delegate that specifies the enumerator used by <see cref="M:Foundation.NSSet.Enumerate(Foundation.NSSetEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSSetEnumerator (NSObject obj, ref bool stop);
	/// <param name="response">To be added.</param><param name="data">To be added.</param><param name="error">To be added.</param><summary>The delegate used as the completion handler for <see cref="M:Foundation.NSUrlConnection.SendAsynchronousRequest(Foundation.NSUrlRequest,Foundation.NSOperationQueue,Foundation.NSUrlConnectionDataResponse)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSUrlConnectionDataResponse (NSUrlResponse? response, NSData? data, NSError? error);
	/// <param name="location">To be added.</param><param name="response">To be added.</param><param name="error">To be added.</param><summary>Completion handler for calls to <see cref="M:Foundation.NSUrlSession.CreateDownloadTask(Foundation.NSUrlRequest)" /> and <see cref="M:Foundation.NSUrlSession.CreateDownloadTaskFromResumeData(Foundation.NSData,Foundation.NSUrlDownloadSessionResponse)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSUrlDownloadSessionResponse (NSUrl? location, NSUrlResponse? response, NSError? error);
	public delegate void NSUrlSessionAllPendingTasks (NSUrlSessionTask[] tasks);
	public delegate void NSUrlSessionDataRead (NSData? data, bool atEof, NSError? error);
	/// <param name="dataTasks">To be added.</param><param name="uploadTasks">To be added.</param><param name="downloadTasks">To be added.</param><summary>The delegate that serves as the completion handler for <see cref="M:Foundation.NSUrlSession.GetTasks(Foundation.NSUrlSessionPendingTasks)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSUrlSessionPendingTasks (NSUrlSessionTask[] dataTasks, NSUrlSessionTask[] uploadTasks, NSUrlSessionTask[] downloadTasks);
	/// <param name="data">Data that was received.</param><param name="response">The object representing the response.</param><param name="error">Error code, if any.</param><summary>Signature for callbacks invoked by NSUrlSession for various background operations.</summary><remarks></remarks>
	public delegate void NSUrlSessionResponse (NSData? data, NSUrlResponse? response, NSError? error);
	public delegate NSProgress RegisterDataRepresentationLoadHandler ([BlockCallback] ItemProviderDataCompletionHandler completionHandler);
	public delegate void RegisterFileRepresentationCompletionHandler (NSUrl fileUrl, bool coordinated, NSError error);
	public delegate NSProgress RegisterFileRepresentationLoadHandler ([BlockCallback] RegisterFileRepresentationCompletionHandler completionHandler);
	public delegate void RegisterObjectRepresentationCompletionHandler (INSItemProviderWriting @object, NSError error);
	public delegate NSProgress RegisterObjectRepresentationLoadHandler ([BlockCallback] RegisterObjectRepresentationCompletionHandler completionHandler);
}
namespace GameController {
	#nullable enable
	public delegate void ElementValueDidChangeHandler (GameController.IGCDevicePhysicalInput physicalInput, GameController.IGCPhysicalInputElement element);
	public delegate void GCAxis2DInputValueDidChangeCallback (GameController.IGCPhysicalInputElement element, GameController.IGCAxis2DInput input, GameController.GCPoint2 point);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCControllerAxisInput.ValueChangedHandler" />.</summary>
	public delegate void GCControllerAxisValueChangedHandler (GameController.GCControllerAxisInput axis, float value);
	public delegate void GCControllerButtonTouchedChanged (GameController.GCControllerButtonInput button, float value, bool pressed, bool touched);
	/// <summary>Delegate for <see cref="P:GameController.GCControllerButtonInput.ValueChangedHandler" /> and <see cref="P:GameController.GCControllerButtonInput.PressedChangedHandler" />.</summary>
	public delegate void GCControllerButtonValueChanged (GameController.GCControllerButtonInput button, float buttonValue, bool pressed);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCControllerDirectionPad.ValueChangedHandler" />.</summary>
	public delegate void GCControllerDirectionPadValueChangedHandler (GameController.GCControllerDirectionPad dpad, float xValue, float yValue);
	public delegate void GCControllerTouchpadHandler (GameController.GCControllerTouchpad touchpad, float xValue, float yValue, float buttonValue, bool buttonPressed);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCExtendedGamepad.ValueChangedHandler" />.</summary>
	public delegate void GCExtendedGamepadValueChangedHandler (GameController.GCExtendedGamepad gamepad, GameController.GCControllerElement element);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCGamepad.ValueChangedHandler" />.</summary>
	public delegate void GCGamepadValueChangedHandler (GameController.GCGamepad gamepad, GameController.GCControllerElement element);
	public delegate void GCKeyboardValueChangedHandler (GameController.GCKeyboardInput keyboard, GameController.GCControllerButtonInput key, IntPtr keyCode, bool pressed);
	/// <param name="gamepad">The profile that contains the changed element.</param><param name="element">The element that changed.</param><summary>A handler that is called whenever any single element of a controller changes.</summary><remarks><para>This handler is called once for each element change. It is only called for directly attached elements.</para></remarks>
	public delegate void GCMicroGamepadValueChangedHandler (GameController.GCMicroGamepad gamepad, GameController.GCControllerElement element);
	public delegate void GCMouseMoved (GameController.GCMouseInput mouse, float deltaX, float deltaY);
	public delegate GameController.GCVirtualControllerElementConfiguration GCVirtualControllerElementUpdateBlock (GameController.GCVirtualControllerElementConfiguration configuration);
	public delegate void InputStateAvailableHandler (GameController.IGCDevicePhysicalInput physicalInput);
}
namespace GameKit {
	#nullable enable
	/// <param name="descriptions">To be added.</param><param name="error">To be added.</param><summary>A delegate that is called by <see cref="M:GameKit.GKAchievementDescription.LoadAchievementDescriptions(GameKit.GKAchievementDescriptionHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void GKAchievementDescriptionHandler (GameKit.GKAchievementDescription[]? descriptions, NSError? error);
	/// <summary>A delegate that is called by <see cref="M:GameKit.GKLeaderboard.LoadCategories(GameKit.GKCategoryHandler)" />.</summary>
	public delegate void GKCategoryHandler (String[]? categories, String[]? titles, NSError? error);
	/// <param name="composeController">To be added.</param><param name="issuedChallenge">To be added.</param><param name="sentPlayerIDs">To be added.</param><summary>Completion handler for for the <see cref="GameKit.GKScore.ChallengeComposeControllerAsync(System.String,GameKit.GKPlayer[],out UIKit.UIViewController)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKChallengeComposeHandler (UIViewController composeController, bool issuedChallenge, String[] sentPlayerIDs);
	public delegate void GKChallengeComposeHandler2 (UIViewController composeController, bool issuedChallenge, GameKit.GKPlayer[]? sentPlayers);
	public delegate void GKChallengeDefinitionHasActiveChallengesHandler (bool hasActiveChallenges, NSError? error);
	public delegate void GKChallengeDefinitionLoadDefinitionsHandler (GameKit.GKChallengeDefinition[] definitions, NSError? error);
	public delegate void GKChallengeDefinitionLoadImageHandler (UIImage? image, NSError? error);
	public delegate bool GKChallengePredicate (GameKit.GKChallenge challenge);
	/// <param name="achivements">To be added.</param><param name="error">To be added.</param><summary>A delegate passed to <see cref="M:GameKit.GKAchievement.LoadAchievements(GameKit.GKCompletionHandler)" /> that specifies behavior after the downloading of achievements from Game Center is completed.</summary><remarks>To be added.</remarks>
	public delegate void GKCompletionHandler (GameKit.GKAchievement[]? achivements, NSError? error);
	public delegate void GKEntriesForPlayerScopeHandler (GameKit.GKLeaderboardEntry? localPlayerEntry, GameKit.GKLeaderboardEntry[]? entries, IntPtr totalPlayerCount, NSError? error);
	public delegate void GKEntriesForPlayersHandler (GameKit.GKLeaderboardEntry? localPlayerEntry, GameKit.GKLeaderboardEntry[]? entries, NSError? error);
	public delegate void GKFetchItemsForIdentityVerificationSignatureCompletionHandler (NSUrl? publicKeyUrl, NSData? signature, NSData? salt, ulong timestamp, NSError? error);
	/// <summary>A delegate used with <see cref="M:GameKit.GKLocalPlayer.LoadFriends(GameKit.GKFriendsHandler)" /> and <see cref="M:GameKit.GKMatchmaker.FindPlayers(GameKit.GKMatchRequest,GameKit.GKFriendsHandler)" /> that defines behavior after the request completes.</summary>
	public delegate void GKFriendsHandler (String[]? friends, NSError? error);
	public delegate void GKGameActivityCheckPendingGameActivityExistenceHandler (bool pendingGameActivityExists);
	public delegate void GKGameActivityDefinitionLoadAchievementDescriptionsHandler (GameKit.GKAchievementDescription[]? descriptions, NSError? error);
	public delegate void GKGameActivityDefinitionLoadGameActivityDefinitionsHandler (GameKit.GKGameActivityDefinition[]? definitions, NSError? error);
	public delegate void GKGameActivityDefinitionLoadImageHandler (UIImage? image, NSError? error);
	public delegate void GKGameActivityDefinitionLoadLeaderboardsHandler (GameKit.GKLeaderboard[]? leaderboards, NSError? error);
	public delegate void GKGameActivityFindMatchHandler (GameKit.GKMatch? match, NSError? error);
	public delegate void GKGameActivityFindPlayersForHostedMatchHandler (GameKit.GKPlayer? match, NSError? error);
	/// <param name="publicKeyUrl">To be added.</param><param name="signature">To be added.</param><param name="salt">To be added.</param><param name="timestamp">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:GameKit.GKLocalPlayer.GenerateIdentityVerificationSignature(GameKit.GKIdentityVerificationSignatureHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKIdentityVerificationSignatureHandler (NSUrl? publicKeyUrl, NSData? signature, NSData? salt, ulong timestamp, NSError? error);
	/// <param name="image">To be added.</param><param name="error">To be added.</param><summary>A delegate passed to <see cref="T:GameKit.GKAchievementDescription" /> that defines behavior after the image has been loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKImageLoadedHandler (UIImage image, NSError error);
	/// <summary>A delegate that is used to define behavior after a response to a <see cref="T:GameKit.GKInvite" />.</summary>
	public delegate void GKInviteHandler (GameKit.GKInvite invite, String[]? playerIDs);
	/// <param name="leaderboardSets">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:GameKit.GKLeaderboardSet.LoadLeaderboardSets(GameKit.GKLeaderboardSetsHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKLeaderboardSetsHandler (GameKit.GKLeaderboardSet[]? leaderboardSets, NSError? error);
	/// <param name="leaderboards">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:GameKit.GKLeaderboardSet.LoadLeaderboards(GameKit.GKLeaderboardsHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKLeaderboardsHandler (GameKit.GKLeaderboard[]? leaderboards, NSError? error);
	public delegate bool GKMatchReinvitation (GameKit.GKMatch match, string playerId);
	public delegate bool GKMatchReinvitationForDisconnectedPlayer (GameKit.GKMatch match, GameKit.GKPlayer player);
	/// <param name="match">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKMatchmaker.FindMatch(GameKit.GKMatchRequest,GameKit.GKNotificationMatch)" /> that specifies behavior after a match has been made.</summary><remarks>To be added.</remarks>
	public delegate void GKNotificationMatch (GameKit.GKMatch? match, NSError? error);
	/// <param name="photo">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKPlayer.LoadPhoto(GameKit.GKPhotoSize,GameKit.GKPlayerPhotoLoaded)" /> to specify behavior after the photo is loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKPlayerPhotoLoaded (UIImage photo, NSError error);
	/// <summary>A delegate used with <see cref="P:GameKit.GKVoiceChat.PlayerStateUpdateHandler" /> that specifies behavior when the player's <see cref="T:GameKit.GKVoiceChatPlayerState" /> changes.</summary>
	public delegate void GKPlayerStateUpdateHandler (string playerId, GameKit.GKVoiceChatPlayerState state);
	/// <param name="players">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKPlayer.LoadPlayersForIdentifiers(System.String[],GameKit.GKPlayersHandler)" /> to specify behavior to happen after the players are loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKPlayersHandler (GameKit.GKPlayer[]? players, NSError? error);
	/// <param name="activity">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKMatchmaker.QueryActivity(GameKit.GKQueryHandler)" /> and <see cref="M:GameKit.GKMatchmaker.QueryPlayerGroupActivity(System.IntPtr,GameKit.GKQueryHandler)" /> to specify behavior after the query is completed.</summary><remarks>To be added.</remarks>
	public delegate void GKQueryHandler (IntPtr activity, NSError? error);
	/// <param name="scoreArray">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKLeaderboard.LoadScores(GameKit.GKScoresLoadedHandler)" /> that specifies behavior after the scores are loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKScoresLoadedHandler (GameKit.GKScore[]? scoreArray, NSError? error);
	/// <param name="matchData">To be added.</param><param name="error">To be added.</param><summary>A delegate that is used with <see cref="M:GameKit.GKTurnBasedMatch.LoadMatchData(GameKit.GKTurnBasedMatchData)" /> to specify behavior after the data is loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKTurnBasedMatchData (NSData? matchData, NSError? error);
	/// <param name="match">To be added.</param><param name="error">To be added.</param><summary>A delegate that specifies the completion handler for <see cref="M:GameKit.GKTurnBasedMatch.FindMatch(GameKit.GKMatchRequest,GameKit.GKTurnBasedMatchRequest)" />.</summary><remarks>To be added.</remarks>
	public delegate void GKTurnBasedMatchRequest (GameKit.GKTurnBasedMatch? match, NSError? error);
	/// <param name="matches">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKTurnBasedMatch.LoadMatches(GameKit.GKTurnBasedMatchesRequest)" /> to specify behavior after the matches have been loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKTurnBasedMatchesRequest (GameKit.GKTurnBasedMatch[]? matches, NSError? error);
}
namespace HealthKit {
	#nullable enable
	/// <summary>The completion handler for <see cref="HealthKit.HKAnchoredObjectQuery.HKAnchoredObjectQuery(HealthKit.HKSampleType,Foundation.NSPredicate,System.UIntPtr,System.UIntPtr,HealthKit.HKAnchoredObjectResultHandler)" />.</summary><summary>Completion handler for anchored object queries.</summary>
	public delegate void HKAnchoredObjectResultHandler (HealthKit.HKAnchoredObjectQuery query, HealthKit.HKSample[]? results, UIntPtr newAnchor, NSError? error);
	public delegate void HKAnchoredObjectUpdateHandler (HealthKit.HKAnchoredObjectQuery query, HealthKit.HKSample[]? addedObjects, HealthKit.HKDeletedObject[]? deletedObjects, HealthKit.HKQueryAnchor? newAnchor, NSError? error);
	public delegate void HKAttachmentStoreCompletionHandler (bool success, NSError? error);
	public delegate void HKAttachmentStoreDataHandler (NSData? dataChunk, NSError? error, bool done);
	public delegate void HKAttachmentStoreGetAttachmentCompletionHandler (HealthKit.HKAttachment[]? attachments, NSError? error);
	/// <summary>Completion handler for <see cref="T:HealthKit.HKCorrelationQuery" />.</summary>
	public delegate void HKCorrelationQueryResultHandler (HealthKit.HKCorrelationQuery query, HealthKit.HKCorrelation[]? correlations, NSError? error);
	public delegate void HKElectrocardiogramQueryDataHandler (HealthKit.HKElectrocardiogramQuery query, HealthKit.HKElectrocardiogramVoltageMeasurement? voltageMeasurement, bool done, NSError? error);
	public delegate void HKHealthStoreCompletionHandler (bool success, NSError? error);
	/// <param name="requestStatus">The resulting request status.</param><param name="error">The error, if one occurred..</param><summary>Handler to pass to <see cref="M:HealthKit.HKHealthStore.GetRequestStatusForAuthorizationToShare(Foundation.NSSet{HealthKit.HKSampleType},Foundation.NSSet{HealthKit.HKObjectType},HealthKit.HKHealthStoreGetRequestStatusForAuthorizationToShareHandler)" />.</summary>
	public delegate void HKHealthStoreGetRequestStatusForAuthorizationToShareHandler (HealthKit.HKAuthorizationRequestStatus requestStatus, NSError? error);
	public delegate void HKHeartbeatSeriesBuilderCompletionHandler (bool success, NSError? error);
	public delegate void HKHeartbeatSeriesQueryDataHandler (HealthKit.HKHeartbeatSeriesQuery query, double timeSinceSeriesStart, bool precededByGap, bool done, NSError? error);
	public delegate void HKObserverQueryDescriptorUpdateHandler (HealthKit.HKObserverQuery query, global::Foundation.NSSet<global::HealthKit.HKSampleType>? samples, [BlockCallback] Action completion, NSError? error);
	/// <summary>Update handler for <see cref="T:HealthKit.HKObserverQuery" /> objects.</summary>
	public delegate void HKObserverQueryUpdateHandler (HealthKit.HKObserverQuery query, [BlockCallback] Action completion, NSError? error);
	/// <param name="samples">The samples that were added.</param><param name="error">The error, if one occurred.</param><summary>Completion handler for <see cref="M:HealthKit.HKQuantitySeriesSampleBuilder.FinishSeries(Foundation.NSDictionary,HealthKit.HKQuantitySeriesSampleBuilderFinishSeriesDelegate)" />.</summary>
	public delegate void HKQuantitySeriesSampleBuilderFinishSeriesDelegate (HealthKit.HKQuantitySample[]? samples, NSError? error);
	/// <summary>A handler to pass to <see cref="HealthKit.HKQuantitySeriesSampleQuery.HKQuantitySeriesSampleQuery(HealthKit.HKQuantitySample,HealthKit.HKQuantitySeriesSampleQueryQuantityDelegate)" />.</summary>
	public delegate void HKQuantitySeriesSampleQueryQuantityDelegate (HealthKit.HKQuantitySeriesSampleQuery query, HealthKit.HKQuantity? quantity, NSDate? date, bool done, NSError? error);
	public delegate void HKQuantitySeriesSampleQueryQuantityHandler (HealthKit.HKQuantitySeriesSampleQuery query, HealthKit.HKQuantity? quantity, NSDateInterval? date, bool done, NSError? error);
	/// <summary>Result handler for <see cref="T:HealthKit.HKSampleQuery" />.</summary>
	public delegate void HKSampleQueryResultsHandler (HealthKit.HKSampleQuery query, HealthKit.HKSample[]? results, NSError? error);
	/// <summary>Completion handler for <see cref="T:HealthKit.HKSourceQuery" />.</summary>
	public delegate void HKSourceQueryCompletionHandler (HealthKit.HKSourceQuery query, NSSet? sources, NSError? error);
	/// <summary>Delegate handler for <see cref="M:HealthKit.HKStatisticsCollection.EnumerateStatistics(Foundation.NSDate,Foundation.NSDate,HealthKit.HKStatisticsCollectionEnumerator)" />.</summary>
	public delegate void HKStatisticsCollectionEnumerator (HealthKit.HKStatistics result, bool stop);
	/// <summary>The delegate for <see cref="P:HealthKit.HKStatisticsCollectionQuery.InitialResultsHandler" />.</summary>
	public delegate void HKStatisticsCollectionQueryInitialResultsHandler (HealthKit.HKStatisticsCollectionQuery query, HealthKit.HKStatisticsCollection? result, NSError? error);
	/// <summary>The delegate for <see cref="P:HealthKit.HKStatisticsCollectionQuery.StatisticsUpdated" />.</summary>
	public delegate void HKStatisticsCollectionQueryStatisticsUpdateHandler (HealthKit.HKStatisticsCollectionQuery query, HealthKit.HKStatistics? statistics, HealthKit.HKStatisticsCollection? collection, NSError? error);
	/// <summary>Results handler for <see cref="T:HealthKit.HKStatisticsQuery" />.</summary>
	public delegate void HKStatisticsQueryHandler (HealthKit.HKStatisticsQuery query, HealthKit.HKStatistics? result, NSError? error);
	/// <summary>Completion handler for <see cref="M:HealthKit.HKHealthStore.AddSamples(HealthKit.HKSample[],HealthKit.HKWorkout,HealthKit.HKStoreSampleAddedCallback)" />.</summary>
	public delegate void HKStoreSampleAddedCallback (bool success, NSError? error);
	public delegate void HKUserAnnotatedMedicationQueryCallback (HealthKit.HKUserAnnotatedMedicationQuery query, HealthKit.HKUserAnnotatedMedication? userAnnotatedMedication, bool done, NSError? error);
	public delegate void HKVerifiableClinicalRecordQueryResultHandler (HealthKit.HKVerifiableClinicalRecordQuery query, global::Foundation.NSArray<global::HealthKit.HKVerifiableClinicalRecord>? records, NSError? error);
	/// <param name="success">Whether the operation succeeded.</param><param name="error">The error that occurred, if <paramref name="success" /> was <see langword="false" />.</param><summary>Completion handler for adding metadata with <see cref="HealthKit.HKWorkoutRouteQuery.HKWorkoutRouteQuery(HealthKit.HKWorkoutRoute,HealthKit.HKWorkoutRouteBuilderDataHandler)" />.</summary>
	public delegate void HKWorkoutBuilderCompletionHandler (bool success, NSError? error);
	public delegate void HKWorkoutEffortRelationshipQueryResultsHandler (HealthKit.HKWorkoutEffortRelationshipQuery query, HealthKit.HKWorkoutEffortRelationship[]? relationships, HealthKit.HKQueryAnchor? newAnchor, NSError? error);
	public delegate void HKWorkoutRelationshipCallback (bool success, NSError? error);
	/// <param name="success">Whether the operation succeeded.</param><param name="error">The error that occurred, if <paramref name="success" /> was <see langword="false" />.</param><summary>Completion handler for adding metadata with <see cref="HealthKit.HKWorkoutRouteQuery.HKWorkoutRouteQuery(HealthKit.HKWorkoutRoute,HealthKit.HKWorkoutRouteBuilderDataHandler)" />.</summary>
	public delegate void HKWorkoutRouteBuilderAddMetadataHandler (bool success, NSError? error);
	public delegate void HKWorkoutRouteBuilderDataHandler (HealthKit.HKWorkoutRouteQuery query, CLLocation[]? routeData, bool done, NSError? error);
	public delegate void HKWorkoutRouteQueryDataHandler (HealthKit.HKWorkoutRouteQuery query, CLLocation[]? routeData, bool done, NSError? error);
}
namespace HomeKit {
	#nullable enable
	public delegate void HMHomeManagerFindVendorAccessoryCallback (HomeKit.HMAccessory? accessory, NSError? error);
}
namespace Intents {
	#nullable enable
	public delegate void INVoiceShortcutCenterGetVoiceShortcutsHandler (Intents.INVoiceShortcut[]? voiceShortcuts, NSError? error);
}
namespace IntentsUI {
	#nullable enable
	public delegate void INUIHostedViewControllingConfigureViewHandler (bool success, global::Foundation.NSSet<global::Intents.INParameter> configuredParameters, CGSize desiredSize);
}
namespace JavaScriptCore {
	#nullable enable
	/// <summary>The delegate that can be used as the <see cref="P:JavaScriptCore.JSContext.ExceptionHandler" />.</summary>
	public delegate void JSContextExceptionHandler (JavaScriptCore.JSContext? context, JavaScriptCore.JSValue? exception);
	public delegate void JSPromiseCreationExecutor (JavaScriptCore.JSValue? resolve, JavaScriptCore.JSValue? rejected);
}
namespace LocalAuthentication {
	#nullable enable
	/// <summary>Signature for a function to be invoked in response to a <see cref="M:LocalAuthentication.LAContext.EvaluatePolicy(LocalAuthentication.LAPolicy,System.String,LocalAuthentication.LAContextReplyHandler)" /> invocation.</summary><remarks>The method when invoked returns a boolean indicating if the policy evaluation was successful, and on failure a detailed description of the error in the error parameter.</remarks>
	public delegate void LAContextReplyHandler (bool success, NSError? error);
	public delegate void LAPrivateKeyCompletionHandler (NSData? data, NSError? error);
	public delegate void LAPublicKeyCompletionHandler (NSData? data, NSError? error);
	public delegate void LAPublicKeyVerifyDataCompletionHandler (NSError? error);
	public delegate void LARightAuthorizeCompletionHandler (NSError? error);
	public delegate void LARightStoreCompletionHandler (LocalAuthentication.LAPersistedRight? right, NSError? error);
	public delegate void LARightStoreRemoveRightCompletionHandler (NSError? error);
	public delegate void LASecretCompletionHandler (NSData? data, NSError? error);
}
namespace MLCompute {
	#nullable enable
	public delegate void MLCGraphCompletionHandler (MLCompute.MLCTensor? resultTensor, NSError? error, double executionTime);
}
namespace MapKit {
	#nullable enable
	public delegate MKClusterAnnotation MKCreateClusterAnnotation (MKMapView mapView, IMKAnnotation[] memberAnnotations);
	/// <param name="response">Returned if the routing request was successful</param><param name="error">If not <see langword="null" />, an error occurred with the request.</param><summary>The completion handler for calls to <see cref="M:MapKit.MKDirections.CalculateDirections(MapKit.MKDirectionsHandler)" />.</summary><remarks>To be added.</remarks><altmember cref="T:MapKit.MKDirectionsRequest" />
	public delegate void MKDirectionsHandler (MKDirectionsResponse? response, NSError? error);
	/// <param name="response">Returned if the request was successful.</param><param name="error">If not <see langword="null" />, an error occurred with the request.</param><summary>The completion handler for calls to <see cref="M:MapKit.MKDirections.CalculateETA(MapKit.MKETAHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void MKETAHandler (MKETAResponse? response, NSError? error);
	public delegate void MKGeocodingRequestGetMapItemsCompletionHandler (MKMapItem[]? mapItems, NSError? error);
	/// <param name="response">To be added.</param><param name="error">To be added.</param><summary>A delegate that is used to handle the results of a map-based search.</summary><remarks>To be added.</remarks><altmember cref="T:MapKit.MKLocalSearch" />
	public delegate void MKLocalSearchCompletionHandler (MKLocalSearchResponse? response, NSError? error);
	/// <param name="snapshot">The newly-created <see cref="T:MapKit.MKMapSnapshot" /></param><param name="error">If not <see langword="null" />, an error occurred with the request.</param><summary>The completion handler for <see cref="MapKit.MKMapSnapshotter.StartAsync(CoreFoundation.DispatchQueue)" />.</summary><remarks>To be added.</remarks>
	public delegate void MKMapSnapshotCompletionHandler (MKMapSnapshot? snapshot, NSError? error);
	public delegate MKAnnotationView? MKMapViewAnnotation (MKMapView mapView, IMKAnnotation annotation);
	public delegate MKSelectionAccessory? MKMapViewDelegateGetSelectionAccessory (MKMapView mapView, IMKAnnotation annotation);
	public delegate MKOverlayView MKMapViewOverlay (MKMapView mapView, IMKOverlay overlay);
	public delegate MKOverlayRenderer MKRendererForOverlayDelegate (MKMapView mapView, IMKOverlay overlay);
	public delegate void MKReverseGeocodingRequestGetMapItemsCompletionHandler (MKMapItem[]? mapItems, NSError? error);
	/// <param name="tileData">To be added.</param><param name="error">To be added.</param><summary>The completion handler for <see cref="M:MapKit.MKTileOverlay.LoadTileAtPath(MapKit.MKTileOverlayPath,MapKit.MKTileOverlayLoadTileCompletionHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void MKTileOverlayLoadTileCompletionHandler (NSData? tileData, NSError? error);
}
namespace MediaAccessibility {
	#nullable enable
	public delegate void MAMusicHapticTrackAvailabilityCallback (bool musicHapticsAvailable);
	public delegate void MAMusicHapticTrackStatusObserver (string internationalStandardRecordingCode, bool musicHapticsActive);
}
namespace MediaPlayer {
	#nullable enable
	public delegate void MPMediaItemAnimatedArtworkPreviewImageRequestCallback (UIImage? image);
	public delegate void MPMediaItemAnimatedArtworkPreviewImageRequestHandler (CGSize size, [BlockCallback] MPMediaItemAnimatedArtworkPreviewImageRequestCallback completionHandler);
	public delegate void MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestCallback (NSUrl? image);
	public delegate void MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestHandler (CGSize size, [BlockCallback] MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestCallback completionHandler);
	/// <param name="property">The property kind.</param><param name="value">The value associated with the property</param><param name="stop">Reference value, can be used to stop the enumeration.</param><summary>The delegate to be used as the <c>enumerator</c> argument to <see cref="M:MediaPlayer.MPMediaEntity.EnumerateValues(Foundation.NSSet,MediaPlayer.MPMediaItemEnumerator)" />.</summary>
	public delegate void MPMediaItemEnumerator (string property, NSObject value, ref bool stop);
}
namespace Metal {
	#nullable enable
	public delegate void MTL4CommitFeedbackHandler (IMTL4CommitFeedback commitFeedback);
	public delegate void MTL4CreateBinaryFunctionCompletionHandler (IMTL4BinaryFunction? function, NSError? error);
	public delegate void MTL4CreateMachineLearningPipelineStateCompletionHandler (IMTL4MachineLearningPipelineState? mlPipelineState, NSError? error);
	public delegate void MTLCreateComputePipelineStateCompletionHandler (IMTLComputePipelineState? computePipelineState, NSError? error);
	public delegate void MTLCreateDynamicLibraryCompletionHandler (IMTLDynamicLibrary? library, NSError? error);
	public delegate void MTLCreateLibraryCompletionHandler (IMTLLibrary? library, NSError? error);
	public delegate void MTLCreateRenderPipelineStateCompletionHandler (IMTLRenderPipelineState? renderPipelineState, NSError? error);
	/// <summary>Completion handler for deallocating a buffer.</summary>
	public delegate void MTLDeallocator (IntPtr pointer, UIntPtr length);
	public delegate void MTLLogStateLogHandler (string? subSystem, string? category, MTLLogLevel logLevel, string message);
	public delegate void MTLNewComputePipelineStateWithReflectionCompletionHandler (IMTLComputePipelineState? computePipelineState, MTLComputePipelineReflection? reflection, NSError? error);
	public delegate void MTLNewRenderPipelineStateWithReflectionCompletionHandler (IMTLRenderPipelineState? renderPipelineState, MTLRenderPipelineReflection? reflection, NSError? error);
	public delegate void MTLSharedEventNotificationBlock (IMTLSharedEvent @event, ulong value);
}
namespace MetalKit {
	#nullable enable
	public delegate void MTKTextureLoaderArrayCallback (IMTLTexture[] textures, NSError? error);
	/// <summary>Completion handler for textures loaded with <see cref="T:MetalKit.MTKTextureLoader" />.</summary>
	public delegate void MTKTextureLoaderCallback (IMTLTexture? texture, NSError? error);
}
namespace MetalPerformanceShaders {
	#nullable enable
	public delegate void MPSAccelerationStructureCompletionHandler (MetalPerformanceShaders.MPSAccelerationStructure? structure);
	public delegate void MPSGradientNodeHandler (MetalPerformanceShaders.MPSNNFilterNode gradientNode, MetalPerformanceShaders.MPSNNFilterNode inferenceNode, MetalPerformanceShaders.MPSNNImageNode inferenceSource, MetalPerformanceShaders.MPSNNImageNode gradientSource);
}
namespace MetalPerformanceShadersGraph {
	#nullable enable
	public delegate void MPSGraphCompilationCompletionHandler (MPSGraphExecutable executable, NSError? error);
	public delegate void MPSGraphCompletionHandler (global::Foundation.NSDictionary<global::MetalPerformanceShadersGraph.MPSGraphTensor, global::MetalPerformanceShadersGraph.MPSGraphTensorData> resultsDictionary, NSError? error);
	public delegate MPSGraphTensor[] MPSGraphControlFlowDependencyBlock ();
	public delegate void MPSGraphExecutableCompletionHandler (MPSGraphTensorData[] results, NSError? error);
	public delegate void MPSGraphExecutableScheduledHandler (MPSGraphTensorData[] results, NSError? error);
	public delegate MPSGraphTensor[] MPSGraphForLoopBodyBlock (MPSGraphTensor index, MPSGraphTensor[] iterationArguments);
	public delegate MPSGraphTensor[] MPSGraphIfThenElseBlock ();
	public delegate void MPSGraphScheduledHandler (global::Foundation.NSDictionary<global::MetalPerformanceShadersGraph.MPSGraphTensor, global::MetalPerformanceShadersGraph.MPSGraphTensorData> resultsDictionary, NSError? error);
	public delegate MPSGraphTensor[] MPSGraphWhileAfterBlock (MPSGraphTensor[] bodyBlockArguments);
	public delegate MPSGraphTensor MPSGraphWhileBeforeBlock (MPSGraphTensor[] inputTensors, global::Foundation.NSMutableArray<global::MetalPerformanceShadersGraph.MPSGraphTensor> resultTensors);
}
namespace ModelIO {
	#nullable enable
	public delegate void MDLObjectHandler (MDLObject mdlObject, ref bool stop);
}
namespace MultipeerConnectivity {
	#nullable enable
	/// <param name="accept"><see langword="true" /> if the invitation should be accepted.</param><param name="session">The session to which the peer shouldbe connected.</param><summary>The delegate that serves as the invitation handler in calls to <see cref="M:MultipeerConnectivity.MCNearbyServiceAdvertiserDelegate.DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,MultipeerConnectivity.MCPeerID,Foundation.NSData,MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler)" />.</summary>
	public delegate void MCNearbyServiceAdvertiserInvitationHandler (bool accept, MultipeerConnectivity.MCSession? session);
	/// <summary>A delegate that serves as the completion handler for <see cref="M:MultipeerConnectivity.MCSession.NearbyConnectionDataForPeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler)" />.</summary>
	public delegate void MCSessionNearbyConnectionDataForPeerCompletionHandler (NSData? connectionData, NSError? error);
}
namespace NaturalLanguage {
	#nullable enable
	public delegate void NLEnumerateNeighborsHandler (string neighbor, double distance, ref bool stop);
	/// <param name="tag">The tag on which to operate.</param><param name="tokenRange">The token range to process.</param><param name="stop"><see langword="false" /> to stop enumerating.</param><summary>Delegate to apply to tokens as they are enumerated by <see cref="M:NaturalLanguage.NLTagger.EnumerateTags(Foundation.NSRange,NaturalLanguage.NLTokenUnit,NaturalLanguage.NLTagScheme,NaturalLanguage.NLTaggerOptions,NaturalLanguage.NLTaggerEnumerateTagsContinuationHandler)" />.</summary>
	public delegate void NLTaggerEnumerateTagsContinuationHandler (NSString tag, NSRange tokenRange, out bool stop);
	/// <param name="tokenRange">The range of tokens to which to apply the delegate.</param><param name="flags">Tokenizer hints.</param><param name="stop"><see langword="false" /> to stop enumerating.</param><summary>Delegate to apply to tokens as they are enumerated by <see cref="M:NaturalLanguage.NLTokenizer.EnumerateTokens(Foundation.NSRange,NaturalLanguage.NLTokenizerEnumerateContinuationHandler)" />.</summary>
	public delegate void NLTokenizerEnumerateContinuationHandler (NSRange tokenRange, NaturalLanguage.NLTokenizerAttributes flags, out bool stop);
	public delegate void TokenVectorEnumeratorHandler (global::Foundation.NSArray<NSNumber> tokenVector, NSRange tokenRange, out bool stop);
}
namespace NetworkExtension {
	#nullable enable
	public delegate void NEAppProxyFlowOpenCallback (NSError? completionHandler);
	public delegate void NEDatagramAndFlowEndpointsRead (NSData[]? datagrams, global::Network.NWEndpoint[]? remoteEndpoints, NSError? error);
	public delegate void NEDatagramRead (NSData[]? datagrams, global::NetworkExtension.NWEndpoint[]? remoteEndpoints, NSError? error);
	public delegate void NEDatagramWriteResult (NSError? error);
	/// <summary>A command handler block for a Hotspot Helper.</summary>
	public delegate void NEHotspotHelperHandler (NEHotspotHelperCommand cmd);
	public delegate void NERelayManagerGetLastClientErrorsCallback (NSError[]? errors);
}
namespace PassKit {
	#nullable enable
	public delegate void PKAddIdentityDocumentConfigurationGetConfigurationCompletionHandler (PassKit.PKAddIdentityDocumentConfiguration? credentialConfiguration, NSError? error);
	public delegate void PKInformationRequestCompletionBlock (PassKit.PKBarcodeEventMetadataResponse response);
	public delegate void PKPassLibrarySignDataCompletionHandler (NSData? signedData, NSData? signature, NSError? error);
	/// <summary>Delegate called when the user has selected a shipping address.</summary>
	public delegate void PKPaymentShippingAddressSelected (PassKit.PKPaymentAuthorizationStatus status, PassKit.PKShippingMethod[] shippingMethods, PassKit.PKPaymentSummaryItem[] summaryItems);
	/// <summary>Delegate called when the user has selected a shipping method.</summary>
	public delegate void PKPaymentShippingMethodSelected (PassKit.PKPaymentAuthorizationStatus status, PassKit.PKPaymentSummaryItem[] summaryItems);
	public delegate void PKSignatureRequestCompletionBlock (PassKit.PKBarcodeEventSignatureResponse response);
}
namespace PdfKit {
	#nullable enable
	public delegate Class ClassForAnnotationTypeDelegate (string annotationType);
}
namespace PencilKit {
	#nullable enable
	public delegate void PKInterpolatedPointsEnumeratorHandler (PencilKit.PKStrokePoint strokePoint, out bool stop);
	public delegate UIImage PKToolPickerCustomItemConfigurationImageProviderCallback (PencilKit.PKToolPickerCustomItem toolPickerItem);
	public delegate UIViewController PKToolPickerCustomItemConfigurationViewControllerProvider (PencilKit.PKToolPickerCustomItem toolPickerItem);
}
namespace Phase {
	#nullable enable
	/// <summary>This is a delegate to provide audio data to a <see cref="T:Phase.PhasePullStreamNode" />.</summary><param name="isSilence">It's possible to hint to the receiver of the buffer that the returned audio samples are silence. Note that since this is  just a hint, the returned audio samples should also be silence.</param><param name="timeStamp">The HAL time when the sample is to be rendered.</param><param name="frameCount">The number of sample frames requested.</param><param name="outputData"><para>The list of audio buffers where to store the returned audio samples.</para><para>
	/// The caller will provide the list of audio buffers, but the callback may replace the
	/// <see cref="F:AudioToolbox.AudioBuffer.Data" /> pointer (and update the <see cref="F:AudioToolbox.AudioBuffer.DataByteSize" /> value)
	/// with a pointer to a memory location that the callback owns, and which will be valid until
	/// the next render cycle.
	/// </para></param><returns>0 in case of success, otherwise an OSStatus error code. The audio data will be assumed to be invalid in case of an error.</returns>
	public unsafe delegate int PhasePullStreamRenderBlock (Byte* isSilence, AudioToolbox.AudioTimeStamp* timeStamp, uint frameCount, AudioToolbox.AudioBufferList* outputData);
}
namespace Photos {
	#nullable enable
	/// <summary>A continuation handler for that is called by the Photos application to show progress for an image request.</summary>
	public delegate void PHAssetImageProgressHandler (double progress, NSError? error, out bool stop, NSDictionary? info);
	/// <summary>Delegate type used with <see cref="P:Photos.PHVideoRequestOptions.ProgressHandler" />.</summary>
	public delegate void PHAssetVideoProgressHandler (double progress, NSError? error, out bool stop, NSDictionary? info);
	/// <summary>Enumerates differences between snapshots of the object at the specified indices.</summary>
	public delegate void PHChangeDetailEnumerator (UIntPtr fromIndex, UIntPtr toIndex);
	/// <summary>Completion handler for the <see cref="Photos.PHAssetContentEditingInputExtensions.RequestContentEditingInput(Photos.PHAsset,Photos.PHContentEditingInputRequestOptions,Photos.PHContentEditingHandler)" /> method.</summary>
	public delegate void PHContentEditingHandler (PHContentEditingInput? contentEditingInput, NSDictionary requestStatusInfo);
	/// <summary>Enumerates the assets in a fetch result.</summary>
	public delegate void PHFetchResultEnumerator (NSObject element, UIntPtr elementIndex, out bool stop);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestImageData(Photos.PHAsset,Photos.PHImageRequestOptions,Photos.PHImageDataHandler)" /> method.</summary>
	public delegate void PHImageDataHandler (NSData data, NSString dataUti, UIImageOrientation orientation, NSDictionary info);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestAVAsset(Photos.PHAsset,Photos.PHVideoRequestOptions,Photos.PHImageManagerRequestAVAssetHandler)" /> method.</summary>
	public delegate void PHImageManagerRequestAVAssetHandler (AVAsset? asset, AVAudioMix? audioMix, NSDictionary? info);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestExportSession(Photos.PHAsset,Photos.PHVideoRequestOptions,System.String,Photos.PHImageManagerRequestExportHandler)" /> method.</summary>
	public delegate void PHImageManagerRequestExportHandler (AVAssetExportSession? exportSession, NSDictionary? info);
	public delegate void PHImageManagerRequestImageDataHandler (NSData? imageData, string? dataUti, ImageIO.CGImagePropertyOrientation orientation, NSDictionary? info);
	/// <summary>The result handler delegate for calls to <see cref="M:Photos.PHImageManager.RequestLivePhoto(Photos.PHAsset,CoreGraphics.CGSize,Photos.PHImageContentMode,Photos.PHLivePhotoRequestOptions,Photos.PHImageManagerRequestLivePhoto)" />.</summary>
	public delegate void PHImageManagerRequestLivePhoto (PHLivePhoto? livePhoto, NSDictionary? info);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestPlayerItem(Photos.PHAsset,Photos.PHVideoRequestOptions,Photos.PHImageManagerRequestPlayerHandler)" /> method.</summary>
	public delegate void PHImageManagerRequestPlayerHandler (AVPlayerItem? playerItem, NSDictionary? info);
	/// <param name="result">The requested image.</param><param name="info">Keys and values are defined in <see cref="T:Photos.PHImageKeys" />.</param><summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestImageForAsset(Photos.PHAsset,CoreGraphics.CGSize,Photos.PHImageContentMode,Photos.PHImageRequestOptions,Photos.PHImageResultHandler)" /> method.</summary>
	public delegate void PHImageResultHandler (UIImage? result, NSDictionary? info);
	/// <param name="frame">The video frame to process.</param><param name="error">An error in which to record problems that occurred while processing the frame.</param><summary>Delegate that is called on every frame of a Live Photo as it is processed.</summary><returns>A processed image that represents the frame.</returns>
	public delegate CIImage PHLivePhotoFrameProcessingBlock (IPHLivePhotoFrame frame, ref NSError error);
	public delegate void PHPersistentChangeFetchResultEnumerator (PHPersistentChange change, ref bool stop);
	/// <summary>Continuation handler for tracking image operation progress.</summary>
	public delegate void PHProgressHandler (double progress, ref bool stop);
}
namespace QuickLook {
	#nullable enable
	public delegate QLPreviewItemEditingMode QLEditingMode (QLPreviewController controller, IQLPreviewItem previewItem);
	public delegate CGRect QLFrame (QLPreviewController controller, IQLPreviewItem item, ref UIView view);
	public delegate bool QLOpenUrl (QLPreviewController controller, NSUrl url, IQLPreviewItem item);
	public delegate NSData QLPreviewReplyDataCreationHandler (QLPreviewReply reply, out NSError error);
	public delegate bool QLPreviewReplyDrawingHandler (CGContext context, QLPreviewReply reply, out NSError error);
	public delegate CGPDFDocument QLPreviewReplyUIDocumentCreationHandler (QLPreviewReply reply, out NSError error);
	public delegate UIImage? QLTransition (QLPreviewController controller, IQLPreviewItem item, CGRect contentRect);
	public delegate UIView? QLTransitionView (QLPreviewController controller, IQLPreviewItem item);
}
namespace ReplayKit {
	#nullable enable
	/// <param name="bundleID">The bundle ID of the newly loaded broadcasting service.</param><param name="displayName">The display name of the newly loaded broadcasting service.</param><param name="appIcon">The application icon of the newly loaded broadcasting service.</param><summary>Delegate that specifies the signature of the completion handler in calls to the <see cref="ReplayKit.NSExtensionContext_RPBroadcastExtension.LoadBroadcastingApplicationInfo(Foundation.NSExtensionContext,ReplayKit.LoadBroadcastingHandler)" /> method.</summary>
	public delegate void LoadBroadcastingHandler (string bundleID, string displayName, UIImage? appIcon);
}
namespace SafariServices {
	#nullable enable
	/// <param name="callbackUrl">A custom URL scheme.</param><param name="error">The error object if an error occurred.</param><summary>Delegate for handling the result of a user action in a <see cref="T:SafariServices.SFAuthenticationSession" />.</summary>
	public delegate void SFAuthenticationCompletionHandler (NSUrl? callbackUrl, NSError? error);
	public delegate void SFSafariExtensionManagerHandler (SafariServices.SFSafariExtensionState? state, NSError? error);
}
namespace SafetyKit {
	#nullable enable
	public delegate void SACrashDetectionManagerRequestAuthorizationCompletionHandler (SafetyKit.SAAuthorizationStatus status, NSError? error);
	public delegate void SAEmergencyResponseManagerDialVoiceCallCompletionHandler (bool requestAccepted, NSError? error);
}
namespace SceneKit {
	#nullable enable
	/// <summary>Completion handler used with <see cref="M:SceneKit.SCNAction.CustomAction(System.Double,SceneKit.SCNActionNodeWithElapsedTimeHandler)" />.</summary>
	public delegate void SCNActionNodeWithElapsedTimeHandler (SCNNode node, NFloat elapsedTime);
	public delegate void SCNAnimationDidStartHandler (SCNAnimation animation, ISCNAnimatable receiver);
	public delegate void SCNAnimationDidStopHandler (SCNAnimation animation, ISCNAnimatable receiver, bool completed);
	/// <summary>Completion handler for use with <see cref="M:SceneKit.SCNAnimationEvent.Create(System.Runtime.InteropServices.NFloat,SceneKit.SCNAnimationEventHandler)" />.</summary>
	public delegate void SCNAnimationEventHandler (ISCNAnimationProtocol animation, NSObject animatedObject, bool playingBackward);
	/// <summary>Completion handler used with <see cref="M:SceneKit.SCNShadable.HandleBinding(System.String,SceneKit.SCNBindingHandler)" />.</summary>
	public delegate void SCNBindingHandler (uint programId, uint location, SCNNode? renderedNode, SCNRenderer renderer);
	public delegate void SCNBufferBindingHandler (ISCNBufferStream buffer, SCNNode node, ISCNShadable shadable, SCNRenderer renderer);
	/// <summary>Delegate for the <see cref="M:SceneKit.SCNPhysicsField.CustomField(SceneKit.SCNFieldForceEvaluator)" /> method.</summary>
	public delegate SCNVector3 SCNFieldForceEvaluator (SCNVector3 position, SCNVector3 velocity, float mass, float charge, double timeInSeconds);
	public delegate void SCNNodeHandler (SCNNode node, out bool stop);
	/// <param name="node">The current <see cref="T:SceneKit.SCNNode" />.</param><param name="stop">An <c>out</c> parameter that, when set to true, stops the enumeration.</param><summary>Delegate for use with <see cref="M:SceneKit.SCNNode.FindNodes(SceneKit.SCNNodePredicate)" />.</summary>
	public delegate bool SCNNodePredicate (SCNNode node, out bool stop);
	/// <summary>Completion handler for use with <see cref="M:SceneKit.SCNParticleSystem.HandleEvent(SceneKit.SCNParticleEvent,Foundation.NSString[],SceneKit.SCNParticleEventHandler)" />.</summary>
	public delegate void SCNParticleEventHandler (IntPtr data, IntPtr dataStride, IntPtr indices, IntPtr count);
	/// <summary>Delegate used as the <c>handler</c> in <see cref="M:SceneKit.SCNParticleSystem.AddModifier(Foundation.NSString[],SceneKit.SCNParticleModifierStage,SceneKit.SCNParticleModifierHandler)" />.</summary>
	public delegate void SCNParticleModifierHandler (IntPtr data, IntPtr dataStride, IntPtr start, IntPtr end, float deltaTime);
	/// <param name="totalProgress">A number in [0,1.0] that indicates the relative progress of the export operation.</param><param name="error">An error that occurred.</param><param name="stop">Developers set this to true to cancel processing.</param><summary>Continuation handler that SceneKit repeatedly calls when exporting a scene.</summary>
	public delegate void SCNSceneExportProgressHandler (float totalProgress, NSError? error, out bool stop);
	/// <summary>Delegate that tests objects in the scene for inclusion.</summary>
	public delegate bool SCNSceneSourceFilter (NSObject entry, NSString identifier, ref bool stop);
	/// <summary>Callback used to reflect progress during execution of <see cref="M:SceneKit.SCNSceneSource.SceneFromOptions(SceneKit.SCNSceneLoadingOptions,SceneKit.SCNSceneSourceStatusHandler)" />.</summary>
	public delegate void SCNSceneSourceStatusHandler (float totalProgress, SCNSceneSourceStatus status, NSError? error, ref bool stopLoading);
	/// <summary>Delegate used in calls to <see cref="M:SceneKit.SCNTransformConstraint.Create(System.Boolean,SceneKit.SCNTransformConstraintHandler)" />.</summary>
	public delegate SCNMatrix4 SCNTransformConstraintHandler (SCNNode node, SCNMatrix4 transform);
}
namespace ScreenCaptureKit {
	#nullable enable
	public delegate void SCScreenshotManagerCaptureImageCallback (CGImage? image, NSError? error);
	public delegate void SCScreenshotManagerCaptureScreenshotCallback (ScreenCaptureKit.SCScreenshotOutput? output, NSError? error);
}
namespace ScreenTime {
	#nullable enable
	public delegate void STWebHistoryFetchHistoryCallback (global::Foundation.NSSet<NSUrl>? urls, NSError? error);
}
namespace Security {
	#nullable enable
	public delegate void SecProtocolChallenge (SecProtocolMetadata metadata, [BlockCallback] SecProtocolChallengeComplete challengeComplete);
	public delegate void SecProtocolChallengeComplete (SecIdentity2 identity);
	public delegate void SecProtocolKeyUpdate (SecProtocolMetadata metadata, [BlockCallback] Action complete);
	public delegate void SecProtocolPreSharedKeySelection (SecProtocolMetadata metadata, DispatchData? psk_identity_hint, [BlockCallback] SecProtocolPreSharedKeySelectionComplete complete);
	public delegate void SecProtocolPreSharedKeySelectionComplete (DispatchData? psk_identity);
	public delegate void SecProtocolVerify (SecProtocolMetadata metadata, SecTrust2 trust, [BlockCallback] SecProtocolVerifyComplete verifyComplete);
	public delegate void SecProtocolVerifyComplete (bool complete);
}
namespace SoundAnalysis {
	#nullable enable
	public delegate void SNAudioFileAnalyzerAnalyzeHandler (bool didReachEndOfFile);
}
namespace Speech {
	#nullable enable
	public delegate void SFSpeechLanguageModelPrepareCustomModelHandler (NSError? error);
}
namespace SpriteKit {
	#nullable enable
	/// <summary>The delegate for a custom action, used with <see cref="M:SpriteKit.SKAction.CustomActionWithDuration(System.Double,SpriteKit.SKActionDurationHandler)" />.</summary>
	public delegate void SKActionDurationHandler (SKNode node, NFloat elapsedTime);
	/// <summary>A method that maps <paramref name="time" />, a value between 0 and 1, to a return value between 0 snd 1.</summary><remarks>Application developers should assign this delegate to a method that returns 0 for a <paramref name="time" /> value of 0, and 1 for a <paramref name="time" /> value of 1.</remarks>
	public delegate float SKActionTimingFunction (float time);
	/// <summary>A method that maps <paramref name="time" />, a value between 0 and 1, to a return value between 0 snd 1.</summary><remarks>Application developers should assign this delegate to a method that returns 0 for a <paramref name="time" /> value of 0, and 1 for a <paramref name="time" /> value of 1.</remarks>
	public delegate float SKActionTimingFunction2 (float time);
	/// <summary>A method that derives a force by applying the physics of a field to a body that is within the field.</summary>
	public delegate System.Numerics.Vector3 SKFieldForceEvaluator (System.Numerics.Vector4 position, System.Numerics.Vector4 velocity, float mass, float charge, double time);
	/// <summary>The delegate that acts as the enumeration handler for <see cref="M:SpriteKit.SKNode.EnumerateChildNodes(System.String,SpriteKit.SKNodeChildEnumeratorHandler)" />.</summary>
	public delegate void SKNodeChildEnumeratorHandler (SKNode node, out bool stop);
	/// <summary>The delegate used for enumerating bodies that fall along a ray when used with <see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGPoint,CoreGraphics.CGPoint,SpriteKit.SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler)" />.</summary>
	public delegate void SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler (SKPhysicsBody body, CGPoint point, CGVector normal, out bool stop);
	/// <summary>The delegate used to enumerate <see cref="T:SpriteKit.SKPhysicsBody" />s with <see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGPoint,SpriteKit.SKPhysicsWorldBodiesEnumeratorHandler)" /> and <see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGRect,SpriteKit.SKPhysicsWorldBodiesEnumeratorHandler)" /></summary><remarks><para> Note that because <paramref name="stop" /> is an <c>out</c> parameter, this cannot be specified using lambda syntax.</para></remarks>
	public delegate void SKPhysicsWorldBodiesEnumeratorHandler (SKPhysicsBody body, out bool stop);
	public delegate void SKTextureAtlasLoadCallback (NSError? error, SKTextureAtlas foundAtlases);
	/// <summary>A method that modifies a texture in place.</summary>
	public delegate void SKTextureModify (IntPtr pixelData, UIntPtr lengthInBytes);
}
namespace StoreKit {
	#nullable enable
	public delegate void SKArcadeServiceRegisterHandler (NSData? randomFromFP, uint randomFromFPLength, NSData? cmacOfAppPid, uint cmacOfAppPidLength, NSError? error);
	public delegate void SKArcadeServiceSubscriptionHandler (NSData? subscriptionStatus, uint subscriptionStatusLength, NSData? cmacOfNonce, uint cmacOfNonceLength, NSError? error);
}
namespace UIKit {
	#nullable enable
	public delegate NSObject? AXObjectReturnBlock ();
	public delegate NSCollectionLayoutGroupCustomItem[] NSCollectionLayoutGroupCustomItemProvider (INSCollectionLayoutEnvironment layoutEnvironment);
	public delegate void NSCollectionLayoutSectionVisibleItemsInvalidationHandler (INSCollectionLayoutVisibleItem[] visibleItems, CGPoint contentOffset, INSCollectionLayoutEnvironment layoutEnvironment);
	/// <summary>A delegate used as the callback in <see cref="M:UIKit.NSLayoutManager.EnumerateEnclosingRects(Foundation.NSRange,Foundation.NSRange,UIKit.NSTextContainer,UIKit.NSTextLayoutEnumerateEnclosingRects)" />.</summary>
	public delegate void NSTextLayoutEnumerateEnclosingRects (CGRect rect, out bool stop);
	/// <summary>A delegate used as the callback in <see cref="M:UIKit.NSLayoutManager.EnumerateLineFragments(Foundation.NSRange,UIKit.NSTextLayoutEnumerateLineFragments)" />.</summary>
	public delegate void NSTextLayoutEnumerateLineFragments (CGRect rect, CGRect usedRectangle, NSTextContainer textContainer, NSRange glyphRange, out bool stop);
	public delegate bool NSTextLayoutManagerEnumerateRenderingAttributesDelegate (NSTextLayoutManager textLayoutManager, global::Foundation.NSDictionary<NSString, NSObject> attributes, NSTextRange textRange);
	public delegate bool NSTextLayoutManagerEnumerateTextSegmentsDelegate (NSTextRange? textSegmentRange, CGRect textSegmentFrame, NFloat baselinePosition, NSTextContainer textContainer);
	public delegate void NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate (NFloat caretOffset, INSTextLocation location, bool leadingEdge, out bool stop);
	public delegate void NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate (INSTextLocation location, out bool stop);
	public delegate void NSTextSelectionDataSourceEnumerateSubstringsDelegate (NSString? substring, NSTextRange substringRange, NSTextRange? enclodingRange, out bool stop);
	public delegate UIMenu? OptionsMenuProviderHandler (UIMenuElement[] elements);
	public delegate bool ShouldDismiss (UIPopoverPresentationController popoverPresentationController);
	public delegate bool UIAccessibilityCustomActionHandler (UIAccessibilityCustomAction customAction);
	public delegate UIAccessibilityCustomRotorItemResult? UIAccessibilityCustomRotorSearch (UIAccessibilityCustomRotorSearchPredicate predicate);
	public delegate void UIActionHandler (UIAction action);
	public delegate NSObject? UIActivityItemsConfigurationMetadataProviderHandler (NSString activityItemsConfigurationMetadataKey);
	public delegate NSObject? UIActivityItemsConfigurationPerItemMetadataProviderHandler (IntPtr index, NSString activityItemsConfigurationMetadataKey);
	public delegate NSObject? UIActivityItemsConfigurationPreviewProviderHandler (IntPtr index, NSString activityItemsConfigurationPreviewIntent, CGSize suggestedSize);
	/// <summary>The callback executed after a <see cref="T:UIKit.UIActivityViewController" /> is dismissed.</summary>
	public delegate void UIActivityViewControllerCompletion (NSString? activityType, bool completed, NSExtensionItem[]? returnedItems, NSError? error);
	public delegate bool UIAlertViewPredicate (UIAlertView alertView);
	/// <param name="uidocumentOrResponderObjects">To be added.</param><summary>Delegate of <see cref="M:UIKit.UIApplicationDelegate.ContinueUserActivity(UIKit.UIApplication,Foundation.NSUserActivity,UIKit.UIApplicationRestorationHandler)" /> method. Can manipulate objects created or retrieved by the activity.</summary><remarks><para>Must be called from the main thread.</para></remarks>
	public delegate void UIApplicationRestorationHandler (NSObject[] uidocumentOrResponderObjects);
	public delegate bool UIBandSelectionInteractionShouldBeginHandler (UIBandSelectionInteraction interaction, CGPoint point);
	public delegate void UIButtonConfigurationUpdateHandler (UIButton button);
	public delegate UIPointerStyle? UIButtonPointerStyleProvider (UIButton button, UIPointerEffect proposedEffect, UIPointerShape proposedShape);
	public delegate UIntPtr UICellAccessoryPosition (UICellAccessory[] accessories);
	public delegate void UICloudSharingControllerPreparationCompletionHandler (CKShare? share, CKContainer? container, NSError? error);
	public delegate void UICloudSharingControllerPreparationHandler (UICloudSharingController controller, [BlockCallback] UICloudSharingControllerPreparationCompletionHandler completion);
	public delegate UIListSeparatorConfiguration UICollectionLayoutListItemSeparatorHandler (NSIndexPath indexPath, UIListSeparatorConfiguration sectionSeparatorConfiguration);
	public delegate UISwipeActionsConfiguration? UICollectionLayoutListSwipeActionsConfigurationProvider (NSIndexPath indexPath);
	public delegate void UICollectionViewCellConfigurationUpdateHandler (UICollectionViewCell cell, UICellConfigurationState state);
	public delegate void UICollectionViewCellRegistrationConfigurationHandler (UICollectionViewCell cell, NSIndexPath indexPath, NSObject item);
	public delegate NSCollectionLayoutSection? UICollectionViewCompositionalLayoutSectionProvider (IntPtr section, INSCollectionLayoutEnvironment layoutEnvironment);
	public delegate UICollectionViewCell? UICollectionViewDiffableDataSourceCellProvider (UICollectionView collectionView, NSIndexPath indexPath, NSObject itemIdentifier);
	public delegate UICollectionReusableView? UICollectionViewDiffableDataSourceSupplementaryViewProvider (UICollectionView collectionView, string elementKind, NSIndexPath indexPath);
	/// <param name="completed">To be added.</param><param name="finished">To be added.</param><summary>A delegate used as the completion handler for <see cref="M:UIKit.UICollectionView.StartInteractiveTransition(UIKit.UICollectionViewLayout,UIKit.UICollectionViewLayoutInteractiveTransitionCompletion)" />.</summary><remarks>To be added.</remarks>
	public delegate void UICollectionViewLayoutInteractiveTransitionCompletion (bool completed, bool finished);
	public delegate void UICollectionViewSupplementaryRegistrationConfigurationHandler (UICollectionReusableView supplementaryView, string elementKind, NSIndexPath indexPath);
	/// <param name="finished"><see langword="true" /> if the calculation concluded successfully.</param><summary>A strongly-typed delegate called at completion of certain lengthy calculations.</summary><remarks><para>
	/// This strongly-typed delegate is called at the end of certain lengthy calculations. It's <paramref name="finished" /> parameter will be <see langword="true" /> if the calculation finished without interruption.
	/// </para></remarks><altmember cref="M:UIKit.UICollectionView.PerformBatchUpdates(System.Action,UIKit.UICompletionHandler)" /><altmember cref="M:UIKit.UIPageViewController.SetViewControllers(UIKit.UIViewController[],UIKit.UIPageViewControllerNavigationDirection,System.Boolean,UIKit.UICompletionHandler)" /><altmember cref="M:UIKit.UIView.AnimateNotify(System.Double,System.Action,UIKit.UICompletionHandler)" /><altmember cref="M:UIKit.UIView.TransitionNotify(UIKit.UIView,UIKit.UIView,System.Double,UIKit.UIViewAnimationOptions,UIKit.UICompletionHandler)" /><altmember cref="M:UIKit.UIViewController.Transition(UIKit.UIViewController,UIKit.UIViewController,System.Double,UIKit.UIViewAnimationOptions,System.Action,UIKit.UICompletionHandler)" />
	public delegate void UICompletionHandler (bool finished);
	public delegate UIColor UIConfigurationColorTransformerHandler (UIColor color);
	public delegate NSDictionary UIConfigurationTextAttributesTransformerHandler (NSDictionary textAttributes);
	public delegate UIMenu? UIContextMenuActionProvider (UIMenuElement[] suggestedActions);
	public delegate UIViewController? UIContextMenuContentPreviewProvider ();
	/// <summary>An action to run after a <see cref="T:UIKit.UIContextualActionHandler" /> completes.</summary>
	public delegate void UIContextualActionCompletionHandler (bool finished);
	/// <summary>An action to run when the user presses a <see cref="T:UIKit.UIContextualAction" /> button.</summary>
	public delegate void UIContextualActionHandler (UIContextualAction action, UIView sourceView, [BlockCallback] UIContextualActionCompletionHandler completionHandler);
	public delegate void UIControlEnumerateEventsIteratorHandler (UIAction? actionHandler, NSObject? target, Selector? action, UIControlEvent controlEvents, out bool stop);
	public delegate void UIDeferredMenuElementCompletionHandler (UIMenuElement[] elements);
	public delegate void UIDeferredMenuElementProviderHandler ([BlockCallback] UIDeferredMenuElementCompletionHandler completion);
	public delegate bool UIDocumentInteractionProbe (UIDocumentInteractionController controller, Selector? action);
	public delegate CGRect UIDocumentInteractionRectangle (UIDocumentInteractionController controller);
	public delegate UIViewController UIDocumentViewController (UIDocumentInteractionController controller);
	public delegate UIView UIDocumentViewForPreview (UIDocumentInteractionController controller);
	public delegate CGVector UIFieldCustomEvaluator (UIFieldBehavior field, CGPoint position, CGVector velocity, NFloat mass, NFloat charge, double deltaTime);
	public delegate bool UIGestureProbe (UIGestureRecognizer recognizer);
	public delegate bool UIGesturesEvent (UIGestureRecognizer gestureRecognizer, UIEvent @event);
	public delegate bool UIGesturesPress (UIGestureRecognizer gestureRecognizer, UIPress press);
	public delegate bool UIGesturesProbe (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
	public delegate void UIMainMenuSystemBuildHandler (IUIMenuBuilder builder);
	public delegate void UIMenuElementProviderCompletion (UIMenuElement[] element);
	public delegate void UIMenuElementProviderCreateHandler ([BlockCallback] UIMenuElementProviderCompletion handler);
	/// <param name="success">Typically, <see langword="true" /> if the associated method completed successfully.</param><summary>A delegate used at the completion of operations.</summary>
	public delegate void UIOperationHandler (bool success);
	public delegate IntPtr UIPageViewGetNumber (UIPageViewController pageViewController);
	public delegate UIViewController UIPageViewGetViewController (UIPageViewController pageViewController, UIViewController referenceViewController);
	public delegate UIPageViewControllerSpineLocation UIPageViewSpineLocationCallback (UIPageViewController pageViewController, UIInterfaceOrientation orientation);
	public delegate bool UIPopoverControllerCondition (UIPopoverController popoverController);
	public delegate void UIPreviewHandler (UIPreviewAction action, UIViewController previewViewController);
	public delegate UIViewController UIPrintInteraction (UIPrintInteractionController printInteractionController);
	/// <summary>A delegate executed after printing completes or after a printing error occurs.</summary>
	public delegate void UIPrintInteractionCompletionHandler (UIPrintInteractionController? printInteractionController, bool completed, NSError? error);
	public delegate UIPrinterCutterBehavior UIPrintInteractionCutterBehavior (UIPrintInteractionController printInteractionController, NSNumber[] availableBehaviors);
	public delegate UIPrintPaper UIPrintInteractionPaperList (UIPrintInteractionController printInteractionController, UIPrintPaper[] paperList);
	/// <param name="available"><see langword="true" /> if the printer is available for printing.</param><summary>Completion handler used with <see cref="M:UIKit.UIPrinter.ContactPrinter(UIKit.UIPrinterContactPrinterHandler)" />.</summary>
	public delegate void UIPrinterContactPrinterHandler (bool available);
	/// <summary>Completion handler used with various <see cref="T:UIKit.UIPrinterPickerController" /> presentation methods.</summary>
	public delegate void UIPrinterPickerCompletionHandler (UIPrinterPickerController? printerPickerController, bool userDidSelect, NSError? error);
	public delegate NSDictionary UIScreenshotServiceDelegatePdfHandler (NSData? pdfData, IntPtr indexOfCurrentPage, CGRect rectInCurrentPage);
	public delegate bool UIScrollViewCondition (UIScrollView scrollView);
	public delegate UIView UIScrollViewGetZoomView (UIScrollView scrollView);
	public delegate bool UISearchBarPredicate (UISearchBar searchBar);
	public delegate bool UISearchBarRangeEventArgs (UISearchBar searchBar, NSRange range, string text);
	public delegate bool UISplitViewControllerCanCollapsePredicate (UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController);
	public delegate bool UISplitViewControllerDisplayEvent (UISplitViewController splitViewController, UIViewController vc, NSObject sender);
	public delegate UISplitViewControllerDisplayMode UISplitViewControllerFetchTargetForActionHandler (UISplitViewController svc);
	public delegate UISplitViewControllerDisplayMode UISplitViewControllerGetDisplayModeForExpanding (UISplitViewController splitViewController, UISplitViewControllerDisplayMode proposedDisplayMode);
	public delegate UIViewController UISplitViewControllerGetSecondaryViewController (UISplitViewController splitViewController, UIViewController primaryViewController);
	public delegate UISplitViewControllerColumn UISplitViewControllerGetTopColumnForCollapsing (UISplitViewController splitViewController, UISplitViewControllerColumn proposedTopColumn);
	public delegate UIViewController UISplitViewControllerGetViewController (UISplitViewController splitViewController);
	public delegate bool UISplitViewControllerHidePredicate (UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation);
	public delegate UIViewController? UIStoryboardViewControllerCreator (NSCoder coder);
	public delegate UIViewController[] UITabBarGetDisplayedViewControllers (UITabBarController tabBarController, UITab tab, UIViewController[] proposedViewControllers);
	public delegate bool UITabBarSelection (UITabBarController tabBarController, UIViewController viewController);
	public delegate bool UITabBarTabSelection (UITabBarController tabBarController, UITab tab);
	public delegate void UITableViewCellConfigurationUpdateHandler (UITableViewCell cell, UICellConfigurationState state);
	public delegate UITableViewCell? UITableViewDiffableDataSourceCellProvider (UITableView tableView, NSIndexPath indexPath, NSObject obj);
	public delegate void UITableViewHeaderFooterViewConfigurationUpdateHandler (UITableViewHeaderFooterView headerFooterView, UIViewConfigurationState state);
	public delegate NSDictionary UITextAttributesConversionHandler (NSDictionary textAttributes);
	public delegate IUITextInput? UITextInputReturnHandler ();
	public delegate bool UITextViewChange (UITextView textView, NSRange range, string text);
	public delegate bool UITextViewCondition (UITextView textView);
	public delegate bool UITextViewDelegateShouldInteractTextDelegate (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange, UITextItemInteraction interaction);
	public delegate bool UITextViewDelegateShouldInteractUrlDelegate (UITextView textView, NSUrl url, NSRange characterRange, UITextItemInteraction interaction);
	public delegate NSValue[] UITextViewRange (UITextView textView, NSRange enclosingRange);
	public delegate bool UITouchEventArgs (UIGestureRecognizer recognizer, UITouch touch);
	public delegate void UITraitMutations (IUIMutableTraits mutableTraits);
	public delegate UIBarButtonItem? UIViewControllerTransitionZoomBarButtonHandler (UIZoomTransitionSourceViewProviderContext context);
	public delegate UIWindowSceneActivationConfiguration? UIWindowSceneActivationActionConfigurationProvider (UIWindowSceneActivationAction action);
	public delegate UIWindowSceneActivationConfiguration? UIWindowSceneActivationInteractionConfigurationProvider (UIWindowSceneActivationInteraction interaction, CGPoint location);
	public delegate void UIWritingToolsCoordinatorDelegateReplaceRangeCallback (NSAttributedString? replacementText);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback (UIBezierPath[] paths);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsContextsCallback (UIWritingToolsCoordinatorContext[] contexts);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback (UIView view);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback (UIView? view);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsRangeCallback (NSRange range, NSUuid contextId);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback (NSValue[] ranges);
	public delegate void UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback (UIBezierPath[] paths);
}
namespace VideoToolbox {
	#nullable enable
	public delegate void VTFrameProcessorProcessFrameOutputHandler (VideoToolbox.IVTFrameProcessorParameters parameters, CMTime presentationTimeStamp, bool isFinalOutput, NSError? error);
	public delegate void VTFrameProcessorProcessHandler (VideoToolbox.IVTFrameProcessorParameters parameters, NSError? error);
	public delegate void VTSuperResolutionScalerConfigurationDownloadConfigurationModelCallback (NSError? error);
}
namespace Vision {
	#nullable enable
	/// <param name="request">The <see cref="T:Vision.VNRequest" /> for which this is the delegate.</param><param name="error">If not <see langword="null" />, an error that occurred during vision processing.</param><summary>A delegate that is called once for each feature detected in a <see cref="T:Vision.VNRequest" />.</summary><remarks><para>Developers will typically downcast the <paramref name="request" /> to the expected subtype and retrieve relevant data from the downcast value:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var findFacesRequest = new VNDetectFaceRectanglesRequest((request, error) =>
	/// {
	/// if (error is not null)
	/// {
	/// 	   HandleError(error);
	/// }
	/// else
	/// {
	/// 		var frs = request as VNDetectFaceRectanglesRequest;
	/// 		// Assert frs == findFacesRequest  
	/// 		var rs = frs.GetResults<VNFaceObservation>();
	/// 		foreach (var fo in rs)
	/// 		{ // ... etc ...
	/// ]]></code></example></remarks>
	public delegate void VNRequestCompletionHandler (Vision.VNRequest request, NSError? error);
	public delegate void VNRequestProgressHandler (Vision.VNRequest request, double fractionCompleted, NSError? error);
}
namespace WebKit {
	#nullable enable
	public delegate void WKDownloadDelegateDecidePlaceholderPolicyCallback (WebKit.WKDownloadPlaceholderPolicy policy, NSUrl? url);
	/// <param name="result">The result of a successful evaluation. <see langword="null" /> if error occurred.</param><param name="error">The exception that occurred. <see langword="null" /> if evaluation succeeded.</param><summary>The result of evaluating JavaScript code.</summary><remarks><para>If evaluation was successful, <paramref name="error" /> will be <see langword="null" />. If an error occurred, <paramref name="result" /> will be <see langword="null" />.</para></remarks>
	public delegate void WKJavascriptEvaluationResult (NSObject? result, NSError? error);
	public delegate void WKNavigationDelegateShouldGoToBackForwardListItemCallback (bool shouldGoToItem);
	public delegate void WKWebExtensionContextCallback (NSError? error);
	public delegate void WKWebExtensionControllerDataRecordCallback (WebKit.WKWebExtensionDataRecord? dataRecord);
	public delegate void WKWebExtensionControllerDataRecordsCallback (WebKit.WKWebExtensionDataRecord[] dataRecords);
	public delegate void WKWebExtensionControllerDelegateConnectCallback (NSError? error);
	public delegate void WKWebExtensionControllerDelegateOpenNewTabCallback (WebKit.IWKWebExtensionTab? newWindow, NSError? error);
	public delegate void WKWebExtensionControllerDelegateOpenNewWindowCallback (WebKit.IWKWebExtensionWindow? newWindow, NSError? error);
	public delegate void WKWebExtensionControllerDelegateOpenOptionsCallback (NSError? error);
	public delegate void WKWebExtensionControllerDelegatePresentPopupForActionCallback (NSError? error);
	public delegate void WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback (global::Foundation.NSSet<global::WebKit.WKWebExtensionMatchPattern> allowedMatchPatterns, NSDate? expirationDate);
	public delegate void WKWebExtensionControllerDelegatePromptForPermissionsCallback (global::Foundation.NSSet<NSString> allowedPermissions, NSDate? expirationDate);
	public delegate void WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback (global::Foundation.NSSet<NSUrl> allowedUrls, NSDate? expirationDate);
	public delegate void WKWebExtensionControllerDelegateSendMessageCallback (NSObject? replyMessage, NSError? error);
	public delegate void WKWebExtensionCreateCallback (WebKit.WKWebExtension? extension, NSError? error);
	public delegate void WKWebExtensionMessagePortDisconnectHandlerCallback (NSError? error);
	public delegate void WKWebExtensionMessagePortMessageHandlerCallback (NSObject? message, NSError? error);
	public delegate void WKWebExtensionMessagePortSendMessageCallback (NSError? error);
	public delegate void WKWebExtensionTabCallback (NSError? error);
	public delegate void WKWebExtensionTabDetectLocaleCallback (NSLocale? locale, NSError? error);
	public delegate void WKWebExtensionTabDuplicateCallback (WebKit.IWKWebExtensionTab? duplicatedTab, NSError? error);
	public delegate void WKWebExtensionTabTakeSnapshotCallback (UIImage? webpageImage, NSError? error);
	public delegate void WKWebExtensionWindowCallback (NSError? error);
	public delegate void WKWebViewFetchDataHandler (NSData? data, NSError? error);
	public delegate void WKWebViewRestoreDataHandler (NSError? error);
	public delegate void WKWebsiteDataStoreFetchDataHandler (NSData? data, NSError? error);
	public delegate void WKWebsiteDataStoreRestoreDataHandler (NSError? error);
}
