using System.Collections.Generic;

#nullable enable

namespace Cecil.Tests {
	public partial class ConstructorTest {
		static HashSet<string> knownFailuresNonDefaultCtorDoesNotCallBaseDefaultCtor = new HashSet<string> {
			"AppKit.ActionDispatcher::.ctor(System.EventHandler)",
			"AppKit.NSAlertDidEndDispatcher::.ctor(System.Action`1<System.IntPtr>)",
			"AppKit.NSGradient::.ctor(AppKit.NSColor[],System.Single[],AppKit.NSColorSpace)",
			"AppKit.NSImage::.ctor(Foundation.NSData,System.Boolean)",
			"AppKit.NSImage::.ctor(System.String,System.Boolean)",
			"AppKit.NSTextContainer::.ctor(CoreGraphics.CGSize,System.Boolean)",
			"AVFoundation.AVAudioRecorder::.ctor(Foundation.NSUrl,AVFoundation.AudioSettings,Foundation.NSError&)",
			"AVFoundation.AVAudioRecorder::.ctor(Foundation.NSUrl,AVFoundation.AVAudioFormat,Foundation.NSError&)",
			"AVFoundation.InternalAVAudioSessionDelegate::.ctor(AVFoundation.AVAudioSession)",
			"CarPlay.CPListSection::.ctor(CarPlay.CPListItem[],System.String,System.String)",
			"CarPlay.CPListSection::.ctor(CarPlay.CPListItem[])",
			"CloudKit.CKSyncEngineFetchChangesScope::.ctor(Foundation.NSSet`1<CloudKit.CKRecordZoneID>,System.Boolean)",
			"CloudKit.CKSyncEngineSendChangesScope::.ctor(Foundation.NSSet`1<CloudKit.CKRecordZoneID>,System.Boolean)",
			"CloudKit.CKUserIdentityLookupInfo::.ctor(System.String,System.Int32)",
			"CoreAnimation.CALayer::.ctor(CoreAnimation.CALayer)",
			"Foundation.InternalNSNotificationHandler::.ctor(Foundation.NSNotificationCenter,System.Action`1<Foundation.NSNotification>)",
			"Foundation.NSActionDispatcher::.ctor(System.Action)",
			"Foundation.NSAppleEventDescriptor::.ctor(Foundation.NSAppleEventDescriptorType)",
			"Foundation.NSAsyncActionDispatcher::.ctor(System.Action)",
			"Foundation.NSAsyncSynchronizationContextDispatcher::.ctor(System.Threading.SendOrPostCallback,System.Object)",
			"Foundation.NSAttributedString::.ctor(Foundation.NSData,Foundation.NSAttributedStringDataType,Foundation.NSDictionary&)",
			"Foundation.NSHttpCookie::.ctor(System.Net.Cookie)",
			"Foundation.NSHttpCookie::.ctor(System.String,System.String,System.String,System.String)",
			"Foundation.NSMutableArray`1::.ctor(TValue[])",
			"Foundation.NSObject::.ctor(Foundation.NSObjectFlag)",
			"Foundation.NSObject::.ctor(ObjCRuntime.NativeHandle,System.Boolean)",
			"Foundation.NSString::.ctor(System.String,System.Int32,System.Int32)",
			"Foundation.NSString::.ctor(System.String)",
			"Foundation.NSSynchronizationContextDispatcher::.ctor(System.Threading.SendOrPostCallback,System.Object)",
			"Foundation.NSThread::.ctor(Foundation.NSObject,ObjCRuntime.Selector,Foundation.NSObject)",
			"Foundation.NSTimerActionDispatcher::.ctor(System.Action`1<Foundation.NSTimer>)",
			"Foundation.NSUserDefaults::.ctor(System.String,Foundation.NSUserDefaultsType)",
			"GameKit.GKScore::.ctor(System.String)",
			"GameplayKit.GKPath::.ctor(System.Numerics.Vector2[],System.Single,System.Boolean)",
			"GameplayKit.GKPath::.ctor(System.Numerics.Vector3[],System.Single,System.Boolean)",
			"HomeKit.HMMatterHome::.ctor(Foundation.NSCoder)",
			"HomeKit.HMMatterHome::.ctor(Foundation.NSObjectFlag)",
			"HomeKit.HMMatterHome::.ctor(Foundation.NSUuid,System.String)",
			"HomeKit.HMMatterHome::.ctor(ObjCRuntime.NativeHandle)",
			"HomeKit.HMMatterRequestHandler::.ctor(Foundation.NSObjectFlag)",
			"HomeKit.HMMatterRequestHandler::.ctor(ObjCRuntime.NativeHandle)",
			"HomeKit.HMMatterRoom::.ctor(Foundation.NSCoder)",
			"HomeKit.HMMatterRoom::.ctor(Foundation.NSObjectFlag)",
			"HomeKit.HMMatterRoom::.ctor(Foundation.NSUuid,System.String)",
			"HomeKit.HMMatterRoom::.ctor(ObjCRuntime.NativeHandle)",
			"HomeKit.HMMatterTopology::.ctor(Foundation.NSCoder)",
			"HomeKit.HMMatterTopology::.ctor(Foundation.NSObjectFlag)",
			"HomeKit.HMMatterTopology::.ctor(HomeKit.HMMatterHome[])",
			"HomeKit.HMMatterTopology::.ctor(ObjCRuntime.NativeHandle)",
			"Intents.INPriceRange::.ctor(Intents.INPriceRangeOption,Foundation.NSDecimalNumber,System.String)",
			"Intents.INSaveProfileInCarIntent::.ctor(Foundation.NSNumber,System.String)",
			"Intents.INSetProfileInCarIntent::.ctor(Foundation.NSNumber,System.String,Foundation.NSNumber)",
			"MapKit.MKMapCameraZoomRange::.ctor(System.Double,MapKit.MKMapCameraZoomRangeType)",
			"MapKit.MKPointOfInterestFilter::.ctor(MapKit.MKPointOfInterestCategory[],MapKit.MKPointOfInterestFilterType)",
			"ModelIO.MDLMesh::.ctor(ModelIO.MDLMesh,System.Int32,System.UInt32,ModelIO.IMDLMeshBufferAllocator)",
			"ModelIO.MDLMesh::.ctor(System.Numerics.Vector3,CoreGraphics.NVector2i,ModelIO.MDLGeometryType,ModelIO.IMDLMeshBufferAllocator)",
			"ModelIO.MDLMesh::.ctor(System.Numerics.Vector3,CoreGraphics.NVector2i,System.Boolean,ModelIO.MDLGeometryType,ModelIO.IMDLMeshBufferAllocator,System.Nullable`1<System.Int32>,System.Nullable`1<System.Boolean>,System.Nullable`1<System.Boolean>)",
			"ModelIO.MDLMesh::.ctor(System.Numerics.Vector3,CoreGraphics.NVector2i,System.Boolean,System.Boolean,System.Boolean,ModelIO.MDLGeometryType,ModelIO.IMDLMeshBufferAllocator)",
			"ModelIO.MDLMesh::.ctor(System.Numerics.Vector3,CoreGraphics.NVector3i,System.Boolean,ModelIO.MDLGeometryType,ModelIO.IMDLMeshBufferAllocator)",
			"ModelIO.MDLMesh::.ctor(System.Numerics.Vector3,System.Boolean,ModelIO.MDLGeometryType,ModelIO.IMDLMeshBufferAllocator)",
			"ModelIO.MDLNoiseTexture::.ctor(System.Single,System.String,CoreGraphics.NVector2i,ModelIO.MDLTextureChannelEncoding,ModelIO.MDLNoiseTextureType)",
			"NetworkExtension.NEHotspotConfiguration::.ctor(System.String,System.Boolean)",
			"NetworkExtension.NEHotspotConfiguration::.ctor(System.String,System.String,System.Boolean,System.Boolean)",
			"NetworkExtension.NEHotspotConfiguration::.ctor(System.String,System.String,System.Boolean)",
			"NetworkExtension.NEHotspotConfiguration::.ctor(System.String)",
			"SpriteKit.SKUniform::.ctor(System.String,System.Numerics.Vector2)",
			"SpriteKit.SKUniform::.ctor(System.String,System.Numerics.Vector3)",
			"SpriteKit.SKUniform::.ctor(System.String,System.Numerics.Vector4)",
			"SpriteKit.SKVideoNode::.ctor(Foundation.NSUrl)",
			"SpriteKit.SKVideoNode::.ctor(System.String)",
			"SpriteKit.SKWarpGeometryGrid::.ctor(System.IntPtr,System.IntPtr,System.Numerics.Vector2[],System.Numerics.Vector2[])",
			"UIKit.UIControlEventProxy::.ctor(UIKit.UIControl,System.EventHandler)",
			"UIKit.UIImageStatusDispatcher::.ctor(UIKit.UIImage/SaveStatus)",
			"UIKit.UIVideoStatusDispatcher::.ctor(UIKit.UIVideo/SaveStatus)",
		};

		static HashSet<string> knownFailuresCtorsWithOutNSErrorParameter = new HashSet<string> {
			"AppKit.NSDocument::.ctor(Foundation.NSUrl,Foundation.NSUrl,System.String,Foundation.NSError&)",
			"AppKit.NSDocument::.ctor(Foundation.NSUrl,System.String,Foundation.NSError&)",
			"AppKit.NSDocument::.ctor(System.String,Foundation.NSError&)",
			"ARKit.ARReferenceObject::.ctor(Foundation.NSUrl,Foundation.NSError&)",
			"AudioUnit.AUAudioUnit::.ctor(AudioUnit.AudioComponentDescription,AudioUnit.AudioComponentInstantiationOptions,Foundation.NSError&)",
			"AudioUnit.AUAudioUnit::.ctor(AudioUnit.AudioComponentDescription,Foundation.NSError&)",
			"AudioUnit.AUAudioUnitBus::.ctor(AVFoundation.AVAudioFormat,Foundation.NSError&)",
			"AVFoundation.AVAssetReader::.ctor(AVFoundation.AVAsset,Foundation.NSError&)",
			"AVFoundation.AVAssetWriter::.ctor(Foundation.NSUrl,System.String,Foundation.NSError&)",
			"AVFoundation.AVAudioFile::.ctor(Foundation.NSUrl,AVFoundation.AudioSettings,AVFoundation.AVAudioCommonFormat,System.Boolean,Foundation.NSError&)",
			"AVFoundation.AVAudioFile::.ctor(Foundation.NSUrl,AVFoundation.AudioSettings,Foundation.NSError&)",
			"AVFoundation.AVAudioFile::.ctor(Foundation.NSUrl,AVFoundation.AVAudioCommonFormat,System.Boolean,Foundation.NSError&)",
			"AVFoundation.AVAudioFile::.ctor(Foundation.NSUrl,Foundation.NSDictionary,AVFoundation.AVAudioCommonFormat,System.Boolean,Foundation.NSError&)",
			"AVFoundation.AVAudioFile::.ctor(Foundation.NSUrl,Foundation.NSDictionary,Foundation.NSError&)",
			"AVFoundation.AVAudioFile::.ctor(Foundation.NSUrl,Foundation.NSError&)",
			"AVFoundation.AVAudioPlayer::.ctor(Foundation.NSData,System.String,Foundation.NSError&)",
			"AVFoundation.AVAudioPlayer::.ctor(Foundation.NSUrl,System.String,Foundation.NSError&)",
			"AVFoundation.AVAudioRecorder::.ctor(Foundation.NSUrl,AVFoundation.AudioSettings,Foundation.NSError&)",
			"AVFoundation.AVAudioRecorder::.ctor(Foundation.NSUrl,AVFoundation.AVAudioFormat,Foundation.NSError&)",
			"AVFoundation.AVCaptureDeviceInput::.ctor(AVFoundation.AVCaptureDevice,Foundation.NSError&)",
			"AVFoundation.AVMidiPlayer::.ctor(Foundation.NSData,Foundation.NSUrl,Foundation.NSError&)",
			"AVFoundation.AVMidiPlayer::.ctor(Foundation.NSUrl,Foundation.NSUrl,Foundation.NSError&)",
			"AVFoundation.AVMutableMovie::.ctor(AVFoundation.AVMovie,Foundation.NSDictionary`2<Foundation.NSString,Foundation.NSObject>,Foundation.NSError&)",
			"AVFoundation.AVMutableMovie::.ctor(Foundation.NSData,Foundation.NSDictionary`2<Foundation.NSString,Foundation.NSObject>,Foundation.NSError&)",
			"AVFoundation.AVMutableMovie::.ctor(Foundation.NSUrl,Foundation.NSDictionary`2<Foundation.NSString,Foundation.NSObject>,Foundation.NSError&)",
			"BrowserEngineKit.BEMediaEnvironment::.ctor(Foundation.NSObject,Foundation.NSError&)",
			"CoreHaptics.CHHapticEngine::.ctor(AVFoundation.AVAudioSession,Foundation.NSError&)",
			"CoreHaptics.CHHapticEngine::.ctor(Foundation.NSError&)",
			"CoreHaptics.CHHapticPattern::.ctor(CoreHaptics.CHHapticEvent[],CoreHaptics.CHHapticDynamicParameter[],Foundation.NSError&)",
			"CoreHaptics.CHHapticPattern::.ctor(CoreHaptics.CHHapticEvent[],CoreHaptics.CHHapticParameterCurve[],Foundation.NSError&)",
			"CoreHaptics.CHHapticPattern::.ctor(CoreHaptics.CHHapticPatternDefinition,Foundation.NSError&)",
			"CoreHaptics.CHHapticPattern::.ctor(Foundation.NSDictionary,Foundation.NSError&)",
			"CoreHaptics.CHHapticPattern::.ctor(Foundation.NSUrl,Foundation.NSError&)",
			"CoreML.MLArrayBatchProvider::.ctor(Foundation.NSDictionary`2<Foundation.NSString,Foundation.NSArray>,Foundation.NSError&)",
			"CoreML.MLCustomModel::.ctor(CoreML.MLModelDescription,Foundation.NSDictionary`2<Foundation.NSString,Foundation.NSObject>,Foundation.NSError&)",
			"CoreML.MLDictionaryFeatureProvider::.ctor(Foundation.NSDictionary`2<Foundation.NSString,Foundation.NSObject>,Foundation.NSError&)",
			"CoreML.MLMultiArray::.ctor(Foundation.NSNumber[],CoreML.MLMultiArrayDataType,Foundation.NSError&)",
			"CoreML.MLMultiArray::.ctor(System.IntPtr,Foundation.NSNumber[],CoreML.MLMultiArrayDataType,Foundation.NSNumber[],System.Action`1<System.IntPtr>,Foundation.NSError&)",
			"CoreML.MLMultiArray::.ctor(System.IntPtr,System.IntPtr[],CoreML.MLMultiArrayDataType,System.IntPtr[],System.Action`1<System.IntPtr>,Foundation.NSError&)",
			"CoreML.MLMultiArray::.ctor(System.IntPtr[],CoreML.MLMultiArrayDataType,Foundation.NSError&)",
			"Foundation.NSDataDetector::.ctor(Foundation.NSTextCheckingType,Foundation.NSError&)",
			"Foundation.NSDataDetector::.ctor(Foundation.NSTextCheckingTypes,Foundation.NSError&)",
			"Foundation.NSDictionary::.ctor(Foundation.NSUrl,Foundation.NSError&)",
			"Foundation.NSFileWrapper::.ctor(Foundation.NSUrl,Foundation.NSFileWrapperReadingOptions,Foundation.NSError&)",
			"Foundation.NSKeyedUnarchiver::.ctor(Foundation.NSData,Foundation.NSError&)",
			"Foundation.NSRegularExpression::.ctor(Foundation.NSString,Foundation.NSRegularExpressionOptions,Foundation.NSError&)",
			"Foundation.NSUrl::.ctor(Foundation.NSData,Foundation.NSUrlBookmarkResolutionOptions,Foundation.NSUrl,System.Boolean&,Foundation.NSError&)",
			"GLKit.GLKMesh::.ctor(ModelIO.MDLMesh,Foundation.NSError&)",
			"HealthKit.HKAudiogramSensitivityTest::.ctor(HealthKit.HKQuantity,HealthKit.HKAudiogramConductionType,System.Boolean,HealthKit.HKAudiogramSensitivityTestSide,HealthKit.HKAudiogramSensitivityPointClampingRange,Foundation.NSError&)",
			"HealthKit.HKWorkoutSession::.ctor(HealthKit.HKHealthStore,HealthKit.HKWorkoutConfiguration,Foundation.NSError&)",
			"HealthKit.HKWorkoutSession::.ctor(HealthKit.HKWorkoutConfiguration,Foundation.NSError&)",
			"iTunesLibrary.ITLibrary::.ctor(System.String,Foundation.NSError&)",
			"iTunesLibrary.ITLibrary::.ctor(System.String,iTunesLibrary.ITLibInitOptions,Foundation.NSError&)",
			"Messages.MSSticker::.ctor(Foundation.NSUrl,System.String,Foundation.NSError&)",
			"MetalKit.MTKMesh::.ctor(ModelIO.MDLMesh,Metal.IMTLDevice,Foundation.NSError&)",
			"MetalPerformanceShaders.MPSKeyedUnarchiver::.ctor(Foundation.NSData,Metal.IMTLDevice,Foundation.NSError&)",
			"ModelIO.MDLAsset::.ctor(Foundation.NSUrl,ModelIO.MDLVertexDescriptor,ModelIO.IMDLMeshBufferAllocator,System.Boolean,Foundation.NSError&)",
			"NaturalLanguage.NLGazetteer::.ctor(Foundation.NSData,Foundation.NSError&)",
			"NaturalLanguage.NLGazetteer::.ctor(Foundation.NSDictionary,Foundation.NSString,Foundation.NSError&)",
			"NaturalLanguage.NLGazetteer::.ctor(Foundation.NSUrl,Foundation.NSError&)",
			"NaturalLanguage.NLGazetteer::.ctor(NaturalLanguage.NLStrongDictionary,System.Nullable`1<NaturalLanguage.NLLanguage>,Foundation.NSError&)",
			"NearbyInteraction.NINearbyAccessoryConfiguration::.ctor(Foundation.NSData,Foundation.NSError&)",
			"NearbyInteraction.NINearbyAccessoryConfiguration::.ctor(Foundation.NSData,Foundation.NSUuid,Foundation.NSError&)",
			"PassKit.PKAddPassesViewController::.ctor(Foundation.NSData,Foundation.NSData,Foundation.NSError&)",
			"PassKit.PKPass::.ctor(Foundation.NSData,Foundation.NSError&)",
			"PencilKit.PKDrawing::.ctor(Foundation.NSData,Foundation.NSError&)",
			"Phase.PhaseSoundEvent::.ctor(Phase.PhaseEngine,System.String,Foundation.NSError&)",
			"Phase.PhaseSoundEvent::.ctor(Phase.PhaseEngine,System.String,Phase.PhaseMixerParameters,Foundation.NSError&)",
			"ScreenTime.STWebHistory::.ctor(System.String,Foundation.NSError&)",
			"ShazamKit.SHCustomCatalog::.ctor(Foundation.NSData,Foundation.NSError&)",
			"ShazamKit.SHSignature::.ctor(Foundation.NSData,Foundation.NSError&)",
			"SoundAnalysis.SNAudioFileAnalyzer::.ctor(Foundation.NSUrl,Foundation.NSError&)",
			"SoundAnalysis.SNClassifySoundRequest::.ctor(CoreML.MLModel,Foundation.NSError&)",
			"SoundAnalysis.SNClassifySoundRequest::.ctor(System.String,Foundation.NSError&)",
		};
	}
}