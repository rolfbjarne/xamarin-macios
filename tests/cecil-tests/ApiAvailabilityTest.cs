using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Mono.Cecil;

using Xamarin.Utils;
using Xamarin.Tests;

#nullable enable

namespace Cecil.Tests {
	[TestFixture]
	public class ApiAvailabilityTest {
		// This test will flag any API that's only obsoleted on some platforms.
		[Test]
		public void FindMissingObsoleteAttributes ()
		{
			Configuration.IgnoreIfAnyIgnoredPlatforms ();

			var harvestedInfo = Helper.MappedNetApi;

			var failures = new List<(string Key, ICustomAttributeProvider Api, OSPlatformAttributes [] Obsoleted, OSPlatformAttributes [] Supported)> ();
			var mismatchedObsoleteMessages = new List<string> ();
			foreach (var kvp in harvestedInfo) {
				var attributes = kvp.Value.Select (v => v.Api.GetAvailabilityAttributes (v.Platform) ?? new OSPlatformAttributes (v.Api, v.Platform) ?? new OSPlatformAttributes (v.Api, v.Platform)).ToArray ();
				var obsoleted = attributes.Where (v => v?.Obsoleted is not null).ToArray ();

				// No obsoleted, nothing to check
				if (obsoleted.Length == 0)
					continue;

				// All obsoleted, nothing to check
				if (obsoleted.Length == attributes.Length)
					continue;

				// If the non-obsoleted APIs are all unsupported, then there's nothing to do.
				var notObsoletedNorUnsupported = attributes.Where (v => v?.Obsoleted is null && v?.Unsupported is null).ToArray ();
				if (!notObsoletedNorUnsupported.Any ())
					continue;

				var failure = (kvp.Key, kvp.Value.First ().Api, obsoleted, notObsoletedNorUnsupported);
				failures.Add (failure);

				var obsoleteMessages = obsoleted.Select (v => v.Obsoleted?.Message).Distinct ().ToArray ();
				if (obsoleteMessages.Length > 1) {
					var obsoleteFailure = new StringBuilder ();
					obsoleteFailure.AppendLine ($"{failure.Key}: Found different {obsoleteMessages.Length} obsolete messages:");
					foreach (var msg in obsoleteMessages)
						obsoleteFailure.AppendLine ($"    {(msg is null ? "null" : (msg.Length == 0 ? "<empty string>" : "\"" + msg + "\""))}");
					mismatchedObsoleteMessages.Add (obsoleteFailure.ToString ());
					Console.WriteLine (obsoleteFailure);
				}
			}

			var newFailures = failures.Where (v => !knownFailuresInMissingObsoleteAttributes.Contains (v.Key)).ToArray ();
			var fixedFailures = knownFailuresInMissingObsoleteAttributes.Except (failures.Select (v => v.Key).ToHashSet ());

			var sb = new StringBuilder ();
			if (newFailures.Any ()) {
				sb.AppendLine ($"Got {newFailures.Length} failures:");
				foreach (var failure in newFailures.OrderBy (v => v.Key)) {
					sb.AppendLine ($"{failure.Key}: {failure.Api.RenderLocation ()}");
					sb.AppendLine ($"    Obsoleted in: {string.Join (", ", failure.Obsoleted.Select (v => v!.Obsoleted!.PlatformName))}");
					sb.AppendLine ($"    Not obsoleted in: {string.Join (", ", failure.Supported.Select (v => v?.Supported?.PlatformName ?? v?.Platform.ToString ()))}");
				}
				Console.WriteLine (sb);
			}

			var printKnownFailures = newFailures.Any () || fixedFailures.Any ();
			if (printKnownFailures) {
				Console.WriteLine ("Printing all known failures because they seems out of date:");
				Console.WriteLine ("\t\tstatic HashSet<string> knownFailuresInMissingObsoleteAttributes = new HashSet<string> {");
				foreach (var failure in failures.OrderBy (v => v.Key))
					Console.WriteLine ($"\t\t\t\"{failure.Key}\",");
				Console.WriteLine ("\t\t};");
			}

			Assert.That (sb.ToString (), Is.Empty, "Failures");
			Assert.IsEmpty (fixedFailures, "Known failures that aren't failing anymore - remove these from the list of known failures");
			Assert.IsEmpty (mismatchedObsoleteMessages, "Mismatched obsolete messages");
		}

		static HashSet<string> knownFailuresInMissingObsoleteAttributes = new HashSet<string> {
			"AppKit.NSCursor.IsSetOnMouseEntered()",
			"AppKit.NSCursor.IsSetOnMouseExited()",
			"AppKit.NSCursor.SetOnMouseEntered(System.Boolean)",
			"AppKit.NSCursor.SetOnMouseExited(System.Boolean)",
			"AppKit.NSImage.get_Flipped()",
			"AppKit.NSImage.get_ImageFileTypes()",
			"AppKit.NSImage.ImageUnfilteredFileTypes()",
			"AppKit.NSImage.set_Flipped(System.Boolean)",
			"AppKit.NSToolbarItem.get_MaxSize()",
			"AppKit.NSToolbarItem.get_MinSize()",
			"AppKit.NSToolbarItem.set_MaxSize(CoreGraphics.CGSize)",
			"AppKit.NSToolbarItem.set_MinSize(CoreGraphics.CGSize)",
			"AudioToolbox.AudioFormatFlags AudioToolbox.AudioStreamBasicDescription::AudioFormatFlagsAudioUnitCanonical",
			"AudioToolbox.AudioFormatProperty AudioToolbox.AudioFormatProperty::HardwareCodecCapabilities",
			"AudioToolbox.AudioSessionActiveFlags",
			"AudioToolbox.AudioSessionProperty AudioToolbox.AudioSessionProperty::AudioRoute",
			"AudioToolbox.AudioSessionProperty AudioToolbox.AudioSessionProperty::OtherMixableAudioShouldDuck",
			"AudioUnit.AudioTypeConverter AudioUnit.AudioTypeConverter::AUiPodTime",
			"AudioUnit.AudioTypeEffect AudioUnit.AudioTypeEffect::DCFilter",
			"AudioUnit.AudioUnitPropertyIDType AudioUnit.AudioUnitPropertyIDType::AttenuationCurve",
			"AudioUnit.AudioUnitPropertyIDType AudioUnit.AudioUnitPropertyIDType::DistanceParams",
			"AudioUnit.AudioUnitPropertyIDType AudioUnit.AudioUnitPropertyIDType::RenderingFlags",
			"AudioUnit.AUGraph",
			"AudioUnit.SpatialMixerRenderingFlags AudioUnit.SpatialMixerRenderingFlags::DistanceAttenuation",
			"AVFoundation.AVAssetDownloadUrlSession.GetAssetDownloadTask(AVFoundation.AVUrlAsset, Foundation.NSUrl, Foundation.NSDictionary)",
			"AVFoundation.AVCaptureConnection.get_SupportsVideoMaxFrameDuration()",
			"AVFoundation.AVCaptureConnection.get_SupportsVideoMinFrameDuration()",
			"AVFoundation.AVCaptureConnection.get_VideoMaxFrameDuration()",
			"AVFoundation.AVCaptureConnection.get_VideoMinFrameDuration()",
			"AVFoundation.AVCaptureConnection.set_VideoMaxFrameDuration(CoreMedia.CMTime)",
			"AVFoundation.AVCaptureConnection.set_VideoMinFrameDuration(CoreMedia.CMTime)",
			"AVFoundation.AVCaptureDevice.get_FlashMode()",
			"AVFoundation.AVCaptureDevice.IsFlashModeSupported(AVFoundation.AVCaptureFlashMode)",
			"AVFoundation.AVCaptureDevice.set_FlashMode(AVFoundation.AVCaptureFlashMode)",
			"AVFoundation.AVCaptureFlashMode AVFoundation.AVCaptureDevice::FlashMode()",
			"AVFoundation.AVCapturePhotoSettings.get_AutoDualCameraFusionEnabled()",
			"AVFoundation.AVCapturePhotoSettings.get_DualCameraDualPhotoDeliveryEnabled()",
			"AVFoundation.AVCapturePhotoSettings.set_AutoDualCameraFusionEnabled(System.Boolean)",
			"AVFoundation.AVCapturePhotoSettings.set_DualCameraDualPhotoDeliveryEnabled(System.Boolean)",
			"AVFoundation.AVCaptureResolvedPhotoSettings.get_DualCameraFusionEnabled()",
			"AVFoundation.AVCaptureVideoDataOutput.get_MinFrameDuration()",
			"AVFoundation.AVCaptureVideoDataOutput.set_MinFrameDuration(CoreMedia.CMTime)",
			"CFNetwork.CFHTTPStream",
			"CoreBluetooth.CBCentralManagerState",
			"CoreBluetooth.CBPeripheralManagerState",
			"CoreData.NSPersistentStoreCoordinator.get_DidImportUbiquitousContentChangesNotification()",
			"CoreData.NSPersistentStoreCoordinator.get_PersistentStoreUbiquitousContentNameKey()",
			"CoreData.NSPersistentStoreCoordinator.get_PersistentStoreUbiquitousContentUrlKey()",
			"CoreFoundation.DispatchQueue CoreFoundation.DispatchQueue::CurrentQueue()",
			"CoreGraphics.CGColorSpace.CreateIccProfile(Foundation.NSData)",
			"CoreGraphics.CGColorSpace.GetIccProfile()",
			"CoreGraphics.CGContext.SelectFont(System.String, System.Runtime.InteropServices.NFloat, CoreGraphics.CGTextEncoding)",
			"CoreGraphics.CGContext.ShowGlyphs(System.UInt16[])",
			"CoreGraphics.CGContext.ShowGlyphs(System.UInt16[], System.Int32)",
			"CoreGraphics.CGContext.ShowGlyphsAtPoint(System.Runtime.InteropServices.NFloat, System.Runtime.InteropServices.NFloat, System.UInt16[])",
			"CoreGraphics.CGContext.ShowGlyphsAtPoint(System.Runtime.InteropServices.NFloat, System.Runtime.InteropServices.NFloat, System.UInt16[], System.Int32)",
			"CoreGraphics.CGContext.ShowGlyphsWithAdvances(System.UInt16[], CoreGraphics.CGSize[], System.Int32)",
			"CoreGraphics.CGContext.ShowText(System.Byte[])",
			"CoreGraphics.CGContext.ShowText(System.Byte[], System.Int32)",
			"CoreGraphics.CGContext.ShowText(System.String)",
			"CoreGraphics.CGContext.ShowText(System.String, System.Int32)",
			"CoreGraphics.CGContext.ShowTextAtPoint(System.Runtime.InteropServices.NFloat, System.Runtime.InteropServices.NFloat, System.String)",
			"CoreGraphics.CGContext.ShowTextAtPoint(System.Runtime.InteropServices.NFloat, System.Runtime.InteropServices.NFloat, System.String, System.Int32)",
			"CoreGraphics.CGImage PassKit.PKShareablePassMetadata::PassThumbnailImage()",
			"CoreGraphics.CGSize AppKit.NSToolbarItem::MaxSize()",
			"CoreGraphics.CGSize AppKit.NSToolbarItem::MinSize()",
			"CoreImage.CIRawFilterKeys.get_InputLocalToneMapAmountKey()",
			"CoreLocation.CLAuthorizationStatus CoreLocation.CLAuthorizationStatus::Authorized",
			"CoreLocation.CLAuthorizationStatus CoreLocation.CLAuthorizationStatus::AuthorizedWhenInUse",
			"CoreLocation.CLLocationManagerDelegate.UpdatedLocation(CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation)",
			"CoreLocation.CLLocationManagerDelegate_Extensions.UpdatedLocation(CoreLocation.ICLLocationManagerDelegate, CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation)",
			"CoreMedia.CMTime AVFoundation.AVCaptureConnection::VideoMaxFrameDuration()",
			"CoreMedia.CMTime AVFoundation.AVCaptureConnection::VideoMinFrameDuration()",
			"CoreMedia.CMTime AVFoundation.AVCaptureVideoDataOutput::MinFrameDuration()",
			"CoreMidi.MidiClient.CreateVirtualDestination(System.String, out CoreMidi.MidiError&)",
			"CoreMidi.MidiClient.CreateVirtualSource(System.String, out CoreMidi.MidiError&)",
			"CoreMidi.MidiDevice.Add(System.String, System.Boolean, System.UIntPtr, System.UIntPtr, CoreMidi.MidiEntity)",
			"CoreMidi.MidiEndpoint.Received(CoreMidi.MidiPacket[])",
			"CoreMidi.MidiPort.Send(CoreMidi.MidiEndpoint, CoreMidi.MidiPacket[])",
			"CoreText.CTFontFeatureLetterCase",
			"CoreText.CTFontManager.RegisterFontsForUrl(Foundation.NSUrl[], CoreText.CTFontManagerScope)",
			"CoreText.CTFontManager.UnregisterFontsForUrl(Foundation.NSUrl[], CoreText.CTFontManagerScope)",
			"CoreText.CTFontManagerAutoActivation CoreText.CTFontManagerAutoActivation::PromptUser",
			"CoreText.CTTypesetterOptionKey.get_DisableBidiProcessing()",
			"CoreText.FontFeatureGroup CoreText.FontFeatureGroup::LetterCase",
			"EventKit.EKParticipant.GetRecord(AddressBook.ABAddressBook)",
			"Foundation.NSData HealthKit.HKVerifiableClinicalRecord::JwsRepresentation()",
			"Foundation.NSDate HealthKit.HKWorkoutEvent::Date()",
			"Foundation.NSString CoreData.NSPersistentStoreCoordinator::DidImportUbiquitousContentChangesNotification()",
			"Foundation.NSString CoreData.NSPersistentStoreCoordinator::PersistentStoreUbiquitousContentNameKey()",
			"Foundation.NSString CoreData.NSPersistentStoreCoordinator::PersistentStoreUbiquitousContentUrlKey()",
			"Foundation.NSString CoreImage.CIRawFilterKeys::InputLocalToneMapAmountKey()",
			"Foundation.NSString CoreText.CTTypesetterOptionKey::DisableBidiProcessing()",
			"Foundation.NSString Foundation.NSUrl::UbiquitousItemIsDownloadingKey()",
			"Foundation.NSString MobileCoreServices.UTType::UniversalSceneDescriptionMobile()",
			"Foundation.NSUrl.get_UbiquitousItemIsDownloadingKey()",
			"Foundation.NSUrlSessionConfiguration.BackgroundSessionConfiguration(System.String)",
			"Foundation.NSUserDefaults..ctor(System.String)",
			"GameController.GCGamepadSnapShotDataV100",
			"GameController.GCMicroGamepadSnapshot.TryGetSnapshotData(Foundation.NSData, out GameController.GCMicroGamepadSnapshotData&)",
			"GameController.GCMicroGamepadSnapshot.TryGetSnapshotData(Foundation.NSData, out GameController.GCMicroGamepadSnapShotDataV100&)",
			"GameController.GCMicroGamepadSnapshotData",
			"GameController.GCMicroGamepadSnapshotData.ToNSData()",
			"GameController.GCMicroGamepadSnapShotDataV100",
			"GameKit.GKVoiceChatService",
			"HealthKit.HKActivitySummary.get_AppleExerciseTimeGoal()",
			"HealthKit.HKActivitySummary.get_AppleStandHoursGoal()",
			"HealthKit.HKActivitySummary.set_AppleExerciseTimeGoal(HealthKit.HKQuantity)",
			"HealthKit.HKActivitySummary.set_AppleStandHoursGoal(HealthKit.HKQuantity)",
			"HealthKit.HKAnchoredObjectQuery..ctor(HealthKit.HKSampleType, Foundation.NSPredicate, System.UIntPtr, System.UIntPtr, HealthKit.HKAnchoredObjectResultHandler)",
			"HealthKit.HKCategoryValueOvulationTestResult HealthKit.HKCategoryValueOvulationTestResult::Positive",
			"HealthKit.HKCumulativeQuantitySeriesSample",
			"HealthKit.HKCumulativeQuantitySeriesSample.get_Sum()",
			"HealthKit.HKHealthStore.GetDateOfBirth(out Foundation.NSError&)",
			"HealthKit.HKHealthStore.SplitTotalEnergy(HealthKit.HKQuantity, Foundation.NSDate, Foundation.NSDate, System.Action`3<HealthKit.HKQuantity,HealthKit.HKQuantity,Foundation.NSError>)",
			"HealthKit.HKObject.get_Source()",
			"HealthKit.HKQuantity HealthKit.HKActivitySummary::AppleExerciseTimeGoal()",
			"HealthKit.HKQuantity HealthKit.HKActivitySummary::AppleStandHoursGoal()",
			"HealthKit.HKQuantity HealthKit.HKCumulativeQuantitySeriesSample::Sum()",
			"HealthKit.HKQuantityAggregationStyle HealthKit.HKQuantityAggregationStyle::Discrete",
			"HealthKit.HKQuantitySeriesSampleQuery..ctor(HealthKit.HKQuantitySample, HealthKit.HKQuantitySeriesSampleQueryQuantityDelegate)",
			"HealthKit.HKQuery.get_SampleType()",
			"HealthKit.HKSampleType HealthKit.HKQuery::SampleType()",
			"HealthKit.HKSource HealthKit.HKObject::Source()",
			"HealthKit.HKUnit HealthKit.HKUnit::Calorie()",
			"HealthKit.HKUnit.get_Calorie()",
			"HealthKit.HKVerifiableClinicalRecord.get_JwsRepresentation()",
			"HealthKit.HKWorkoutActivityType HealthKit.HKWorkoutActivityType::DanceInspiredTraining",
			"HealthKit.HKWorkoutActivityType HealthKit.HKWorkoutActivityType::MixedMetabolicCardioTraining",
			"HealthKit.HKWorkoutEvent.Create(HealthKit.HKWorkoutEventType, Foundation.NSDate)",
			"HealthKit.HKWorkoutEvent.Create(HealthKit.HKWorkoutEventType, Foundation.NSDate, Foundation.NSDictionary)",
			"HealthKit.HKWorkoutEvent.Create(HealthKit.HKWorkoutEventType, Foundation.NSDate, HealthKit.HKMetadata)",
			"HealthKit.HKWorkoutEvent.get_Date()",
			"HomeKit.HMEventTrigger.CreatePredicateForEvaluatingTriggerOccurringAfterSignificantEvent(HomeKit.HMSignificantEvent, Foundation.NSDateComponents)",
			"HomeKit.HMEventTrigger.CreatePredicateForEvaluatingTriggerOccurringBeforeSignificantEvent(HomeKit.HMSignificantEvent, Foundation.NSDateComponents)",
			"Intents.INCallRecord..ctor(System.String, Foundation.NSDate, Intents.INPerson, Intents.INCallRecordType, Intents.INCallCapability, System.Nullable`1<System.Double>, System.Nullable`1<System.Boolean>, System.Nullable`1<System.Int32>)",
			"Intents.INCallRecordType Intents.INStartCallIntent::RecordTypeForRedialing()",
			"Intents.INSetClimateSettingsInCarIntent..ctor(System.Nullable`1<System.Boolean>, System.Nullable`1<System.Boolean>, System.Nullable`1<System.Boolean>, System.Nullable`1<System.Boolean>, Intents.INCarAirCirculationMode, Foundation.NSNumber, Foundation.NSNumber, Intents.INRelativeSetting, Foundation.NSMeasurement`1<Foundation.NSUnitTemperature>, Intents.INRelativeSetting, Intents.INCarSeat)",
			"Intents.INSetDefrosterSettingsInCarIntent..ctor(System.Nullable`1<System.Boolean>, Intents.INCarDefroster)",
			"Intents.INSetProfileInCarIntent..ctor(Foundation.NSNumber, System.String, Foundation.NSNumber)",
			"Intents.INSetProfileInCarIntent..ctor(Foundation.NSNumber, System.String, System.Nullable`1<System.Boolean>)",
			"Intents.INSetSeatSettingsInCarIntent..ctor(System.Nullable`1<System.Boolean>, System.Nullable`1<System.Boolean>, System.Nullable`1<System.Boolean>, Intents.INCarSeat, Foundation.NSNumber, Intents.INRelativeSetting)",
			"Intents.INStartCallIntent..ctor(Intents.INCallAudioRoute, Intents.INCallDestinationType, Intents.INPerson[], Intents.INCallRecordType, Intents.INCallCapability)",
			"Intents.INStartCallIntent.get_RecordTypeForRedialing()",
			"MapKit.MKOverlayView",
			"MapKit.MKPinAnnotationColor",
			"MediaPlayer.MPMoviePlayerController",
			"MediaPlayer.MPMoviePlayerViewController",
			"MediaPlayer.MPVolumeSettings.AlertHide()",
			"MediaPlayer.MPVolumeSettings.AlertIsVisible()",
			"MediaPlayer.MPVolumeSettings.AlertShow()",
			"Metal.IMTLResource Metal.MTLTextureWrapper::RootResource()",
			"Metal.MTLTextureWrapper.get_RootResource()",
			"MetalPerformanceShaders.MPSCnnConvolution.get_Neuron()",
			"MetalPerformanceShaders.MPSCnnConvolutionDescriptor.get_Neuron()",
			"MetalPerformanceShaders.MPSCnnConvolutionDescriptor.GetConvolutionDescriptor(System.UIntPtr, System.UIntPtr, System.UIntPtr, System.UIntPtr, MetalPerformanceShaders.MPSCnnNeuron)",
			"MetalPerformanceShaders.MPSCnnConvolutionDescriptor.set_Neuron(MetalPerformanceShaders.MPSCnnNeuron)",
			"MetalPerformanceShaders.MPSCnnFullyConnected..ctor(Metal.IMTLDevice, MetalPerformanceShaders.MPSCnnConvolutionDescriptor, System.Single[], System.Single[], MetalPerformanceShaders.MPSCnnConvolutionFlags)",
			"MetalPerformanceShaders.MPSCnnNeuron MetalPerformanceShaders.MPSCnnConvolution::Neuron()",
			"MetalPerformanceShaders.MPSCnnNeuron MetalPerformanceShaders.MPSCnnConvolutionDescriptor::Neuron()",
			"MetalPerformanceShaders.MPSCnnNeuronPReLU..ctor(Metal.IMTLDevice, System.Single[])",
			"MetalPerformanceShaders.MPSMatrixDescriptor.Create(System.UIntPtr, System.UIntPtr, System.UIntPtr, MetalPerformanceShaders.MPSDataType)",
			"MetalPerformanceShaders.MPSMatrixDescriptor.GetRowBytesFromColumns(System.UIntPtr, MetalPerformanceShaders.MPSDataType)",
			"MobileCoreServices.UTType.CopyAllTags(System.String, System.String)",
			"MobileCoreServices.UTType.Equals(Foundation.NSString, Foundation.NSString)",
			"MobileCoreServices.UTType.get_UniversalSceneDescriptionMobile()",
			"MobileCoreServices.UTType.IsDeclared(System.String)",
			"MobileCoreServices.UTType.IsDynamic(System.String)",
			"NetworkExtension.NEFilterProviderConfiguration.get_FilterBrowsers()",
			"NetworkExtension.NEFilterProviderConfiguration.set_FilterBrowsers(System.Boolean)",
			"PassKit.PKAddShareablePassConfiguration.get_ProvisioningPolicyIdentifier()",
			"PassKit.PKShareablePassMetadata..ctor(System.String, System.String, CoreGraphics.CGImage, System.String, System.String, System.String, System.String, System.String, System.Boolean)",
			"PassKit.PKShareablePassMetadata..ctor(System.String, System.String, System.String, CoreGraphics.CGImage, System.String, System.String)",
			"PassKit.PKShareablePassMetadata.get_LocalizedDescription()",
			"PassKit.PKShareablePassMetadata.get_OwnerDisplayName()",
			"PassKit.PKShareablePassMetadata.get_PassThumbnailImage()",
			"PassKit.PKShareablePassMetadata.get_TemplateIdentifier()",
			"Security.Authorization.ExecuteWithPrivileges(System.String, Security.AuthorizationFlags, System.String[])",
			"Security.SecAccessible Security.SecAccessible::Always",
			"Security.SecAccessible Security.SecAccessible::AlwaysThisDeviceOnly",
			"Security.SecCertificate.GetSerialNumber()",
			"Security.SecKey.Decrypt(Security.SecPadding, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr&)",
			"Security.SecKey.Encrypt(Security.SecPadding, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr&)",
			"Security.SecKey.RawSign(Security.SecPadding, System.IntPtr, System.Int32, out System.Byte[]&)",
			"Security.SecKey.RawVerify(Security.SecPadding, System.IntPtr, System.Int32, System.IntPtr, System.Int32)",
			"Security.SecProtocolOptions.AddTlsCipherSuiteGroup(Security.SslCipherSuiteGroup)",
			"Security.SecProtocolOptions.SetTlsDiffieHellmanParameters(CoreFoundation.DispatchData)",
			"Security.SecSharedCredential.RequestSharedWebCredential(System.String, System.String, System.Action`2<Security.SecSharedCredentialInfo[],Foundation.NSError>)",
			"Security.SecTrust.Evaluate()",
			"Security.SecTrust.Evaluate(CoreFoundation.DispatchQueue, Security.SecTrustCallback)",
			"Security.SecTrust.GetPublicKey()",
			"Security.SslContext",
			"Security.SslContext.GetAlpnProtocols()",
			"Security.SslContext.GetAlpnProtocols(out System.Int32&)",
			"Security.SslContext.GetRequestedPeerName()",
			"Security.SslContext.ReHandshake()",
			"Security.SslContext.SetAlpnProtocols(System.String[])",
			"Security.SslContext.SetEncryptionCertificate(Security.SecIdentity, System.Collections.Generic.IEnumerable`1<Security.SecCertificate>)",
			"Security.SslContext.SetError(Security.SecStatusCode)",
			"Security.SslContext.SetOcspResponse(Foundation.NSData)",
			"Security.SslContext.SetSessionConfig(Foundation.NSString)",
			"Security.SslContext.SetSessionConfig(Security.SslSessionConfig)",
			"Security.SslContext.SetSessionStrengthPolicy(Security.SslSessionStrengthPolicy)",
			"Security.SslContext.SetSessionTickets(System.Boolean)",
			"Security.SslProtocol Security.SecProtocolMetadata::NegotiatedProtocolVersion()",
			"Speech.SFSpeechRecognitionRequest.get_InteractionIdentifier()",
			"Speech.SFSpeechRecognitionRequest.set_InteractionIdentifier(System.String)",
			"Speech.SFTranscription.get_AveragePauseDuration()",
			"Speech.SFTranscription.get_SpeakingRate()",
			"Speech.SFTranscriptionSegment.get_VoiceAnalytics()",
			"Speech.SFVoiceAnalytics Speech.SFTranscriptionSegment::VoiceAnalytics()",
			"StoreKit.SKCloudServiceController.RequestPersonalizationToken(System.String, System.Action`2<Foundation.NSString,Foundation.NSError>)",
			"StoreKit.SKCloudServiceController.RequestPersonalizationTokenAsync(System.String)",
			"StoreKit.SKDownload.DeleteContentForProduct(System.String)",
			"StoreKit.SKDownload.GetContentUrlForProduct(System.String)",
			"StoreKit.SKMutablePayment.PaymentWithProduct(System.String)",
			"StoreKit.SKProduct.get_ContentVersion()",
			"StoreKit.SKStoreReviewController.RequestReview()",
			"System.Boolean AppKit.NSImage::Flipped()",
			"System.Boolean AVFoundation.AVCaptureConnection::SupportsVideoMaxFrameDuration()",
			"System.Boolean AVFoundation.AVCaptureConnection::SupportsVideoMinFrameDuration()",
			"System.Boolean AVFoundation.AVCapturePhotoSettings::AutoDualCameraFusionEnabled()",
			"System.Boolean AVFoundation.AVCapturePhotoSettings::DualCameraDualPhotoDeliveryEnabled()",
			"System.Boolean AVFoundation.AVCaptureResolvedPhotoSettings::DualCameraFusionEnabled()",
			"System.Boolean CoreGraphics.CGColorSpace::IsHdr()",
			"System.Boolean CoreText.CTTypesetterOptions::DisableBidiProcessing()",
			"System.Boolean NetworkExtension.NEFilterProviderConfiguration::FilterBrowsers()",
			"System.Boolean Security.SecRecord::UseNoAuthenticationUI()",
			"System.Double Speech.SFTranscription::AveragePauseDuration()",
			"System.Double Speech.SFTranscription::SpeakingRate()",
			"System.EventHandler AVFoundation.AVAudioSession::BeginInterruption (event)",
			"System.EventHandler AVFoundation.AVAudioSession::EndInterruption (event)",
			"System.EventHandler`1<AVFoundation.AVCategoryEventArgs> AVFoundation.AVAudioSession::CategoryChanged (event)",
			"System.EventHandler`1<AVFoundation.AVChannelsEventArgs> AVFoundation.AVAudioSession::InputChannelsChanged (event)",
			"System.EventHandler`1<AVFoundation.AVChannelsEventArgs> AVFoundation.AVAudioSession::OutputChannelsChanged (event)",
			"System.EventHandler`1<AVFoundation.AVSampleRateEventArgs> AVFoundation.AVAudioSession::SampleRateChanged (event)",
			"System.EventHandler`1<AVFoundation.AVStatusEventArgs> AVFoundation.AVAudioSession::InputAvailabilityChanged (event)",
			"System.String PassKit.PKAddShareablePassConfiguration::ProvisioningPolicyIdentifier()",
			"System.String PassKit.PKShareablePassMetadata::LocalizedDescription()",
			"System.String PassKit.PKShareablePassMetadata::OwnerDisplayName()",
			"System.String PassKit.PKShareablePassMetadata::TemplateIdentifier()",
			"System.String Speech.SFSpeechRecognitionRequest::InteractionIdentifier()",
			"System.String StoreKit.SKProduct::ContentVersion()",
			"System.String UserNotifications.UNMutableNotificationContent::SummaryArgument()",
			"System.String UserNotifications.UNNotificationContent::SummaryArgument()",
			"System.String[] AppKit.NSImage::ImageFileTypes()",
			"System.UIntPtr UserNotifications.UNMutableNotificationContent::SummaryArgumentCount()",
			"System.UIntPtr UserNotifications.UNNotificationContent::SummaryArgumentCount()",
			"SystemConfiguration.CaptiveNetwork.MarkPortalOffline(System.String)",
			"SystemConfiguration.CaptiveNetwork.MarkPortalOnline(System.String)",
			"SystemConfiguration.CaptiveNetwork.SetSupportedSSIDs(System.String[])",
			"SystemConfiguration.CaptiveNetwork.TryGetSupportedInterfaces(out System.String[]&)",
			"UIKit.UIGestureRecognizer UIKit.UIScrollView::DirectionalPressGestureRecognizer()",
			"UIKit.UIGraphicsRendererFormat UIKit.UIGraphicsRendererFormat::DefaultFormat()",
			"UIKit.UIGraphicsRendererFormat.get_DefaultFormat()",
			"UIKit.UIScrollView.get_DirectionalPressGestureRecognizer()",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGPoint, System.Runtime.InteropServices.NFloat, UIKit.UIFont, System.Runtime.InteropServices.NFloat, System.Runtime.InteropServices.NFloat&, UIKit.UILineBreakMode, UIKit.UIBaselineAdjustment)",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGPoint, System.Runtime.InteropServices.NFloat, UIKit.UIFont, System.Runtime.InteropServices.NFloat, UIKit.UILineBreakMode, UIKit.UIBaselineAdjustment)",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGPoint, System.Runtime.InteropServices.NFloat, UIKit.UIFont, UIKit.UILineBreakMode)",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGPoint, UIKit.UIFont)",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGRect, UIKit.UIFont)",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGRect, UIKit.UIFont, UIKit.UILineBreakMode)",
			"UIKit.UIStringDrawing.DrawString(System.String, CoreGraphics.CGRect, UIKit.UIFont, UIKit.UILineBreakMode, UIKit.UITextAlignment)",
			"UIKit.UIStringDrawing.StringSize(System.String, UIKit.UIFont)",
			"UIKit.UIStringDrawing.StringSize(System.String, UIKit.UIFont, CoreGraphics.CGSize)",
			"UIKit.UIStringDrawing.StringSize(System.String, UIKit.UIFont, CoreGraphics.CGSize, UIKit.UILineBreakMode)",
			"UIKit.UIStringDrawing.StringSize(System.String, UIKit.UIFont, System.Runtime.InteropServices.NFloat, System.Runtime.InteropServices.NFloat&, System.Runtime.InteropServices.NFloat, UIKit.UILineBreakMode)",
			"UIKit.UIStringDrawing.StringSize(System.String, UIKit.UIFont, System.Runtime.InteropServices.NFloat, UIKit.UILineBreakMode)",
			"UserNotifications.UNMutableNotificationContent.get_SummaryArgument()",
			"UserNotifications.UNMutableNotificationContent.get_SummaryArgumentCount()",
			"UserNotifications.UNMutableNotificationContent.set_SummaryArgument(System.String)",
			"UserNotifications.UNMutableNotificationContent.set_SummaryArgumentCount(System.UIntPtr)",
			"UserNotifications.UNNotificationContent.get_SummaryArgument()",
			"UserNotifications.UNNotificationContent.get_SummaryArgumentCount()",
		};

		// This test verifies that the SupportedOSPlatform and UnavailableOSPlatform/ObsoletedOSplatform attributes are consistent.
		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformAssemblyDefinitions))]
		public void AttributeConsistency (AssemblyInfo info)
		{
			var assembly = info.Assembly;
			var platform = info.Platform;
			var failures = new List<string> ();

			foreach (var api in assembly.EnumerateAttributeProviders ()) {
				var availability = api.GetAvailabilityAttributes (platform);

				var apiSupportedVersion = availability?.Supported?.Version;
				var apiObsoletedVersion = availability?.Obsoleted?.Version;
				var apiUnsupportedVersion = availability?.Unsupported?.Version;
				var apiSupportedAttribute = availability?.Supported?.Attribute;
				var apiObsoletedAttribute = availability?.Obsoleted?.Attribute;
				var apiUnsupportedAttribute = availability?.Unsupported?.Attribute;
				var supportedPlatformName = availability?.Supported?.PlatformName;
				var obsoletedPlatformName = availability?.Obsoleted?.PlatformName;
				var unsupportedPlatformName = availability?.Unsupported?.PlatformName;

				// Verify that any SupportedOSPlatform attributes don't specify a version that is
				// either earlier than our minimum deployment target, or later than the current OS version.
				if (apiSupportedVersion is not null && !(api is AssemblyDefinition)) {
					var minimum = Xamarin.SdkVersions.GetMinVersion (platform);
					var maximum = Xamarin.SdkVersions.GetVersion (platform);

					if (apiSupportedVersion <= minimum)
						failures.Add ($"[FAIL] {apiSupportedVersion} <= {minimum} (Min) on '{api.AsFullName ()}'.");
					if (apiSupportedVersion > maximum)
						failures.Add ($"[FAIL] {apiSupportedVersion} > {maximum} (Max) on '{api.AsFullName ()}'.");
				}

				// APIs shouldn't become unsupported in the same version they become supported.
				//     [SupportedOSPlatform ("ios12.0")]
				//     [UnsupportedOSPlatform ("ios12.0")]
				// Exceptions:
				// * Apple introduced numerous already deprecated frameworks in Mac Catalyst 13.* and Mac Catalyst 14.0, so it's correct to declare those
				//   both supported and unsupported in the same version - so we skip any APIs introduced in Mac Catalyst 14.0 or earlier.
				if (apiSupportedVersion is not null && apiUnsupportedVersion is not null && supportedPlatformName == unsupportedPlatformName) {
					var macCatalystEarlyBirds = platform == ApplePlatform.MacCatalyst && apiUnsupportedVersion == new Version (14, 0);
					if (!macCatalystEarlyBirds)
						failures.Add ($"[FAIL] {api.AsFullName ()} is marked both supported and unsupported in the same version ({supportedPlatformName})");
				}

				// APIs shouldn't become obsolete in the same version they become supported, although Apple does that somewhat frequently, so we have an escape hatch here.
				//     [SupportedOSPlatform("ios12.0")]
				//     [ObsoletedOSPlatform("ios12.0")]
				if (apiSupportedVersion is not null && apiObsoletedVersion is not null && supportedPlatformName == obsoletedPlatformName && !SkipSupportedAndObsoleteAtTheSameTime (api, platform, apiObsoletedVersion))
					failures.Add ($"[FAIL] {api.AsFullName ()} is marked both supported and obsoleted in the same version ({supportedPlatformName})");

				// If there's an ObsoleteOSPlatform, there must also be a SupportedOSPlatform.
				if (apiSupportedAttribute is null && apiObsoletedAttribute is not null)
					failures.Add ($"[FAIL] {api.AsFullName ()} is obsoleted (in {obsoletedPlatformName}), but does not have a SupportedOSPlatform attribute.");

				// If there's an UnsupportedOSPlatform with version, there must also be a SupportedOSPlatform.
				if (apiSupportedAttribute is null && apiUnsupportedVersion is not null)
					failures.Add ($"[FAIL] {api.AsFullName ()} is unsupported (in {apiUnsupportedVersion}), but does not have a SupportedOSPlatform attribute.");

				// APIs are first obsoleted, then unsupported.
				// Invalid (unsupported before obsoleted)
				//     [ObsoletedOSPlatform ("ios12.0")]
				//     [UnsupportedOSPlatform ("ios11.0")]
				// or (unsupported at the same time as obsoleted)
				//     [ObsoletedOSPlatform ("ios12.0")]
				//     [UnsupportedOSPlatform ("ios12.0")]
				if (apiUnsupportedVersion is not null && apiObsoletedVersion is not null && apiUnsupportedVersion <= apiObsoletedVersion)
					failures.Add ($"[FAIL] {api.AsFullName ()} can only be marked unsupported (in {unsupportedPlatformName}) after it's obsoleted (in {obsoletedPlatformName})");

				// If an API is just unavailable, it shouldn't be here in the first place.
				//     [UnsupportedOSPlatform ("ios")]
				if (apiUnsupportedAttribute is not null && string.IsNullOrEmpty (unsupportedPlatformName))
					failures.Add ($"[FAIL] {api.AsFullName ()} is marked unsupported");

				// The subsequent tests are limited to members of the current API, so just continue looping if we're not a type.
				if (!(api is TypeDefinition type))
					continue;

				// Verify that no the members in a type don't contradict attributes on the type.
				foreach (var member in type.EnumerateAttributeProviders ()) {
					var memberAvailability = member.GetAvailabilityAttributes (platform);
					if (memberAvailability is null)
						continue;

					var memberSupportedAttribute = memberAvailability.Supported?.Attribute;
					var memberUnsupportedAttribute = memberAvailability.Unsupported?.Attribute;
					var memberSupportedVersion = memberAvailability.Supported?.Version;

					// Check that the member must be marked unsupported if the type is
					if (apiUnsupportedAttribute is not null && memberSupportedAttribute is not null && memberUnsupportedAttribute is null)
						failures.Add ($"[FAIL] {member.AsFullName ()} is marked available in {memberSupportedVersion} with '{memberSupportedAttribute.AsOSPlatformAttributeString ()}', but the declaring type {type.FullName} is marked unavailable in {apiUnsupportedVersion} with '{apiUnsupportedAttribute.AsOSPlatformAttributeString ()}'");

					// Check that the member isn't supported before the type.
					// FIXME: we hit this a lot with inlined protocol members, so it's disabled for now.
					//if (apiSupportedVersion is not null && memberSupportedVersion is not null && memberSupportedVersion < apiSupportedVersion)
					//	failures.Add($"[FAIL] in {member.AsFullName()} is marked available with '{memberSupportedVersion}', but the declaring type {type.FullName} is only available in '{apiSupportedVersion}'");
				}
			}

			if (failures.Count == 0)
				return;
			var msg = $"{failures.Count} API with inconsistent availability attributes:" + "\n\t" + string.Join ("\n\t", failures);
			Console.WriteLine (msg);
			Assert.Fail (msg);
		}

		bool SkipSupportedAndObsoleteAtTheSameTime (ICustomAttributeProvider api, ApplePlatform platform, Version version)
		{
			var fullname = api.AsFullName ();
			switch (platform) {
			case ApplePlatform.iOS:
				switch (fullname) {
				case "CarPlay.CPApplicationDelegate.DidDiscardSceneSessions(UIKit.UIApplication, Foundation.NSSet`1<UIKit.UISceneSession>)":
				case "CarPlay.CPApplicationDelegate.GetConfiguration(UIKit.UIApplication, UIKit.UISceneSession, UIKit.UISceneConnectionOptions)":
				case "Intents.INNoteContentTypeResolutionResult.GetConfirmationRequired(Foundation.NSObject, System.IntPtr)":
				case "Intents.INNoteContentTypeResolutionResult.GetUnsupported(System.IntPtr)":
				case "PdfKit.PdfAnnotation..ctor(CoreGraphics.CGRect)":
				case "SceneKit.SCNAnimationPlayer.GetAnimation(Foundation.NSString)":
				case "SceneKit.SCNAnimationPlayer.IsAnimationPaused(Foundation.NSString)":
				case "SceneKit.SCNAnimationPlayer.PauseAnimation(Foundation.NSString)":
				case "SceneKit.SCNAnimationPlayer.RemoveAnimation(Foundation.NSString, System.Runtime.InteropServices.NFloat)":
				case "SceneKit.SCNAnimationPlayer.ResumeAnimation(Foundation.NSString)":
					return true;
				}
				break;
			case ApplePlatform.TVOS:
				switch (fullname) {
				case "SceneKit.SCNAnimationPlayer.GetAnimation(Foundation.NSString)":
				case "SceneKit.SCNAnimationPlayer.IsAnimationPaused(Foundation.NSString)":
				case "SceneKit.SCNAnimationPlayer.PauseAnimation(Foundation.NSString)":
				case "SceneKit.SCNAnimationPlayer.RemoveAnimation(Foundation.NSString, System.Runtime.InteropServices.NFloat)":
				case "SceneKit.SCNAnimationPlayer.ResumeAnimation(Foundation.NSString)":
					return true;
				}
				break;
			case ApplePlatform.MacOSX:
				switch (fullname) {
				case "HealthKit.HKQuantity HealthKit.HKWorkout::TotalDistance()":
				case "HealthKit.HKQuantity HealthKit.HKWorkout::TotalEnergyBurned()":
				case "HealthKit.HKQuantity HealthKit.HKWorkout::TotalFlightsClimbed()":
				case "HealthKit.HKQuantity HealthKit.HKWorkout::TotalSwimmingStrokeCount()":
				case "HealthKit.HKWorkout.get_TotalDistance()":
				case "HealthKit.HKWorkout.get_TotalEnergyBurned()":
				case "HealthKit.HKWorkout.get_TotalFlightsClimbed()":
				case "HealthKit.HKWorkout.get_TotalSwimmingStrokeCount()":
				case "HealthKit.HKCumulativeQuantitySeriesSample":
				case "HealthKit.HKCumulativeQuantitySeriesSample.get_Sum()":
				case "HealthKit.HKQuantity HealthKit.HKCumulativeQuantitySeriesSample::Sum()":
				case "Intents.INCallRecord.get_Caller()":
				case "Intents.INPerson Intents.INCallRecord::Caller()":
				case "Intents.INSendMessageIntent..ctor(Intents.INPerson[], System.String, Intents.INSpeakableString, System.String, System.String, Intents.INPerson)":
				case "Intents.INSendMessageIntent..ctor(Intents.INPerson[], System.String, System.String, System.String, Intents.INPerson)":
				case "Intents.INSendMessageIntent.get_GroupName()":
				case "Intents.INSendMessageIntentHandling_Extensions.ResolveGroupName(Intents.IINSendMessageIntentHandling, Intents.INSendMessageIntent, System.Action`1<Intents.INStringResolutionResult>)":
				case "Security.SecSharedCredential.RequestSharedWebCredential(System.String, System.String, System.Action`2<Security.SecSharedCredentialInfo[],Foundation.NSError>)":
				case "System.String Intents.INSendMessageIntent::GroupName()":
					return true;
				}
				break;
			case ApplePlatform.MacCatalyst:
				// Apple added a lot of new frameworks to Mac Catalyst 13.1 and 14.0 that already had obsoleted
				// API from other platforms, so just ignore anything that was obsoleted in Mac Catalyst 14.0 or earlier.
				if (version <= new Version (14, 0))
					return true;
				break;
			}

			// Common for all platforms.
			switch (fullname) {
			case "GameKit.GKScore.ReportLeaderboardScores(GameKit.GKLeaderboardScore[], GameKit.GKChallenge[], System.Action`1<Foundation.NSError>)":
			case "GameKit.GKScore.ReportLeaderboardScoresAsync(GameKit.GKLeaderboardScore[], GameKit.GKChallenge[])":
				return true;
			}

			// Print out the line to potentially add here.
			Console.WriteLine ($"case \"{fullname}\":");

			return false;
		}
	}
}
