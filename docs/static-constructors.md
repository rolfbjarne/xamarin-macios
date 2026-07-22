<!--
Copyright (c) Microsoft Corporation.
Licensed under the MIT License.
-->

# Static constructor evaluation

Issue [#16672](https://github.com/dotnet/macios/issues/16672) tracks reducing the runtime and size cost of static constructors in the platform assemblies.

## Test strategy

`tests/cecil-tests/StaticConstructors.cs` inspects the complete implementation assemblies for iOS, tvOS, Mac Catalyst, and macOS. Unlike an app-based test, this covers every binding type whether or not a sample app happens to use it. It reports the raw constructor set without assuming that an optional registrar or trimmer optimization ran.

`AppSizeTest` remains the complementary end-to-end check. It inspects platform assemblies from published Release apps, so it verifies the constructors that actually survive each tested trimming and interpreter configuration. Its inventory is necessarily limited to types retained by `SizeTestApp`; the Cecil inventory closes that coverage gap.

The Cecil test narrowly recognizes common IL shapes for evaluation categories, but categories do not suppress failures. The known-failures file is platform-qualified because the implementation and constructor set differ by platform.

Set `WRITE_KNOWN_FAILURES=1` when an intentional change requires regenerating the file. Each line includes an evaluation category, so changes that move a constructor from one recognized role to another are reviewed even when the type still has a constructor. The test is not intended to detect arbitrary IL changes that remain within the same category.

## Inventory

The initial complete inventory contains 28,622 platform/type pairs:

| Platform     | Reported |
|--------------|---------:|
| iOS          |    8,339 |
| tvOS         |    5,377 |
| Mac Catalyst |    7,845 |
| macOS        |    7,061 |

The baseline is the authoritative per-type inventory. The categories below explain whether each constructor can reasonably be removed and provide representative source links. The exact platform/type membership remains in `StaticConstructors.KnownFailures.txt`.

| Category            | Entries |
|---------------------|--------:|
| `class handle only` |  11,739 |
| `binding handles`   |   3,725 |
| `linker marker`     |   7,501 |
| `protocol marker`   |   3,592 |
| `compiler cache`    |     594 |
| `smart enum`        |     789 |
| `library handle`    |     391 |
| `other`             |     291 |

### `class handle only`

Generated `class_ptr` initialization. These links point to the binding declarations that generate the constructors. The optional static-registrar class-handle rewriter can remove eligible instances, but normal Release configurations do not universally enable it.

Representative types:

- [`ARKit.ARAnchor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L362)
- [`ARKit.ARAppClipCodeAnchor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2717)
- [`ARKit.ARBody2D`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2117)
- [`ARKit.ARBodyAnchor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2126)
- [`ARKit.ARBodyTrackingConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2204)
- [`ARKit.ARCamera`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L397)
- [`ARKit.ARCoachingOverlayView`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2143)
- [`ARKit.ARCollaborationData`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2196)
- [`ARKit.ARConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1149)
- [`ARKit.ARDepthData`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2606)
- [`ARKit.ARDirectionalLightEstimate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1917)
- [`ARKit.AREnvironmentProbeAnchor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1991)
- [`ARKit.ARFaceAnchor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1801)
- [`ARKit.ARFaceGeometry`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1842)
- [`ARKit.ARFaceTrackingConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1337)
- [`ARKit.ARFrame`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L471)
- [`ARKit.ARGeoAnchor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2616)
- [`ARKit.ARGeoTrackingConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2645)
- [`ARKit.ARGeoTrackingStatus`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2703)
- [`ARKit.ARGeometryElement`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2553)

### `binding handles`

Generated Objective-C class and selector caches, predominantly in macOS bindings. These links point to the binding declarations that generate the caches. A generator-wide selector-inlining or lazy-lookup change is the reasonable removal path.

Representative types:

- [`AVFoundation.AVAUPresetEvent`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L25665)
- [`AVFoundation.AVAggregateAssetDownloadTask`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22589)
- [`AVFoundation.AVAsset`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L5391)
- [`AVFoundation.AVAssetCache`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L7369)
- [`AVFoundation.AVAssetDownloadConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L24511)
- [`AVFoundation.AVAssetDownloadContentConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L24539)
- [`AVFoundation.AVAssetDownloadStorageManagementPolicy`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22536)
- [`AVFoundation.AVAssetDownloadStorageManager`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22518)
- [`AVFoundation.AVAssetDownloadTask`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22565)
- [`AVFoundation.AVAssetDownloadUrlSession`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22657)
- [`AVFoundation.AVAssetExportSession`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L13972)
- [`AVFoundation.AVAssetImageGenerator`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6280)
- [`AVFoundation.AVAssetPlaybackAssistant`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L25482)
- [`AVFoundation.AVAssetReader`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6389)
- [`AVFoundation.AVAssetReaderAudioMixOutput`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6550)
- [`AVFoundation.AVAssetReaderOutput`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6430)
- [`AVFoundation.AVAssetReaderOutputCaptionAdaptor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L24939)
- [`AVFoundation.AVAssetReaderOutputMetadataAdaptor`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6457)
- [`AVFoundation.AVAssetReaderSampleReferenceOutput`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6477)
- [`AVFoundation.AVAssetReaderTrackOutput`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6494)

### `linker marker`

Generated wrapper types whose constructors host trimming annotations and execute only `GC.KeepAlive (null)`. Wrapper names link to the protocol declarations that generate them. These are candidates for post-mark or post-sweep removal.

Representative types:

- [`ARKit.ARAnchorCopyingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L353)
- [`ARKit.ARCoachingOverlayViewDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2181)
- [`ARKit.ARSCNViewDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L841)
- [`ARKit.ARSKViewDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L916)
- [`ARKit.ARSessionDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1116)
- [`ARKit.ARSessionObserverWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1059)
- [`ARKit.ARSessionProvidingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2341)
- [`ARKit.ARTrackableWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1324)
- [`AVFoundation.AVAssetDownloadDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22715)
- [`AVFoundation.AVAssetReaderCaptionValidationHandlingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L24931)
- [`AVFoundation.AVAssetResourceLoaderDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6688)
- [`AVFoundation.AVAssetWriterDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6871)
- [`AVFoundation.AVAsynchronousKeyValueLoadingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L21738)
- [`AVFoundation.AVAudio3DMixingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L1768)
- [`AVFoundation.AVAudioMixingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L1830)
- [`AVFoundation.AVAudioPlayerDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L2379)
- [`AVFoundation.AVAudioRecorderDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L2849)
- [`AVFoundation.AVAudioSessionDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L4440)
- [`AVFoundation.AVAudioStereoMixingWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L1870)
- [`AVFoundation.AVCaptureAudioDataOutputSampleBufferDelegateWrapper`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L16263)

### `protocol marker`

Generated protocol interfaces whose constructors host trimming annotations and execute only `GC.KeepAlive (null)`. Managed interface names link to their source protocol declarations. Eligible constructors can disappear in static-registrar Release builds, but the raw Cecil inventory retains them.

Representative types:

- [`ARKit.IARAnchorCopying`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L353)
- [`ARKit.IARCoachingOverlayViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2181)
- [`ARKit.IARSCNViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L841)
- [`ARKit.IARSKViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L916)
- [`ARKit.IARSessionDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1116)
- [`ARKit.IARSessionObserver`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1059)
- [`ARKit.IARSessionProviding`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2341)
- [`ARKit.IARTrackable`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L1324)
- [`AVFoundation.IAVAssetDownloadDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L22715)
- [`AVFoundation.IAVAssetReaderCaptionValidationHandling`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L24931)
- [`AVFoundation.IAVAssetResourceLoaderDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6688)
- [`AVFoundation.IAVAssetWriterDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6871)
- [`AVFoundation.IAVAsynchronousKeyValueLoading`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L21738)
- [`AVFoundation.IAVAudio3DMixing`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L1768)
- [`AVFoundation.IAVAudioMixing`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L1830)
- [`AVFoundation.IAVAudioPlayerDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L2379)
- [`AVFoundation.IAVAudioRecorderDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L2849)
- [`AVFoundation.IAVAudioSessionDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L4440)
- [`AVFoundation.IAVAudioStereoMixing`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L1870)
- [`AVFoundation.IAVCaptureAudioDataOutputSampleBufferDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L16263)

### `compiler cache`

Compiler-generated singleton and delegate caches. Generated names link to their containing source types. Replace one-off lambdas with named methods when allocation-neutral; keep caches that prevent repeated delegate or closure allocation.

Representative types:

- [`AVFoundation.AVAssetTrack/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L7566)
- [`AVFoundation.AVCaptureDeviceDiscoverySession/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L17692)
- [`AVFoundation.AVCaptureDeviceFormat/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L19019)
- [`AVFoundation.AVCapturePhotoOutput/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L17052)
- [`AVFoundation.AVCapturePhotoSettings/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L16543)
- [`AVFoundation.AVCaptureSlider/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L26289)
- [`AVFoundation.AVCaptureVideoDataOutput/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L16069)
- [`AVFoundation.AVCompressionProperties/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L20792)
- [`AVFoundation.AVMutableVideoComposition/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L14645)
- [`AVFoundation.AVMutableVideoCompositionInstruction/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L14797)
- [`AVFoundation.AVPlayerItemIntegratedTimeline/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L26502)
- [`AVFoundation.AVPlayerItemVideoOutputSettings/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L20816)
- [`AVFoundation.AVPlayerMediaSelectionCriteria/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L19774)
- [``AddressBook.ABMultiValue`1/<>c``](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABMultiValue.cs#L267)
- [`AddressBook.ABPerson/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L837)
- [``AddressBook.ABPerson/<>c__95`1``](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L837)
- [`AddressBookUI.ABNewPersonViewController/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/addressbookui.cs#L24)
- [`AddressBookUI.ABPeoplePickerNavigationController/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/addressbookui.cs#L97)
- [`AddressBookUI.ABPersonViewController/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/addressbookui.cs#L241)
- [`AddressBookUI.ABUnknownPersonViewController/<>c`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/addressbookui.cs#L512)

### `smart enum`

Generated smart-enum handle arrays. Extension-class names link to their source enum declarations. Keep these until the generator can move the cache to shared or lazy storage without repeated native lookups or API changes.

Representative types:

- [`ARKit.ARSkeletonJointNameExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L2445)
- [`AVFoundation.AVAssetDownloadedAssetEvictionPriorityExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1591)
- [`AVFoundation.AVAssetExportSessionPresetExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1277)
- [`AVFoundation.AVAssetImageGeneratorDynamicRangePolicyExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L6377)
- [`AVFoundation.AVAssetPlaybackConfigurationOptionExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L2224)
- [`AVFoundation.AVAssetWriterInputMediaDataLocationExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1602)
- [`AVFoundation.AVAudioSessionCategoryExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L4240)
- [`AVFoundation.AVAudioSessionModeExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L4289)
- [`AVFoundation.AVCaptionConversionAdjustmentTypeExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L25379)
- [`AVFoundation.AVCaptionConversionWarningTypeExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L25318)
- [`AVFoundation.AVCaptureAspectRatioExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L2325)
- [`AVFoundation.AVCaptureDeviceTypeExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L17709)
- [`AVFoundation.AVCaptureReactionTypeExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/AVCaptureReactionType.rgen.cs#L15)
- [`AVFoundation.AVCaptureSceneMonitoringStatusExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L18962)
- [`AVFoundation.AVCaptureSystemPressureLevelExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/avfoundation.cs#L18971)
- [`AVFoundation.AVCaptureWhiteBalanceTemperatureAndTintValueExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L2344)
- [`AVFoundation.AVContentKeyRequestRetryReasonExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1238)
- [`AVFoundation.AVContentKeySystemExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1253)
- [`AVFoundation.AVCoordinatedPlaybackSuspensionReasonExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1909)
- [`AVFoundation.AVFileTypeProfileExtensions`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AVFoundation/Enums.cs#L1829)

### `library handle`

Cached `dlopen` handles for native frameworks. All links point to the generator code that emits these nested types. Keep them: removing the constructors without another cache would repeat native library lookups.

Representative types:

- [`ObjCRuntime.Libraries/ARKit`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AVFoundation`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AVKit`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AVRouting`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/Accessibility`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AccessorySetupKit`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/Accounts`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AdServices`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AddressBook`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AddressBookUI`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AppClip`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AppKit`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AudioToolbox`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AuthenticationServices`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/AutomaticAssessmentConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/BackgroundAssets`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/BackgroundTasks`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/BrowserEngineKit`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/BusinessChat`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)
- [`ObjCRuntime.Libraries/CFNetwork`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L1787)

### `other`

Hand-written or specialized generated initialization. All 96 distinct types are listed below; links point to the constructor source when sequence points are available.

#### Required module initialization

Keep. This calls `RegistrarHelper.Initialize`, which is required module startup.

- [`<Module>`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/RegistrarHelper.cs#L56)

#### AddressBook constants

Keep for compatibility. These types initialize and share native AddressBook constants. A future conversion should replace the shared initialization design as a unit.

- [`AddressBook.ABAddressBook`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABAddressBook.cs#L233)
- [`AddressBook.ABGroupProperty`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABGroup.cs#L53)
- [`AddressBook.ABLabel`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L818)
- [`AddressBook.ABPersonAddressKey`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L240)
- [`AddressBook.ABPersonDateLabel`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L274)
- [`AddressBook.ABPersonInstantMessageKey`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L614)
- [`AddressBook.ABPersonInstantMessageService`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L568)
- [`AddressBook.ABPersonKindId`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L295)
- [`AddressBook.ABPersonPhoneLabel`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L454)
- [`AddressBook.ABPersonPropertyId`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L77)
- [`AddressBook.ABPersonRelatedNamesLabel`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L752)
- [`AddressBook.ABPersonSocialProfile`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L338)
- [`AddressBook.ABPersonSocialProfileService`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L379)
- [`AddressBook.ABPersonUrlLabel`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L644)
- [`AddressBook.ABSourcePropertyId`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABSource.cs#L90)
- [`AddressBook.InitConstants`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABAddressBook.cs#L130)

#### Dispatchers and delegate helpers

Keep unless the dispatcher implementation is redesigned. These cache selectors, callbacks, or shared delegate state; making the state lazy does not remove the initialization requirement.

- [`AppKit.ActionDispatcher`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AppKit/ActionDispatcher.cs#L40)
- [`AppKit.NSAlertDidEndDispatcher`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AppKit/NSAlert.cs#L39)
- [`AppKit.NSApplication/_NSApplicationDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L642)
- [`AppKit.NSPageController/_NSPageControllerDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L20179)
- [`AppKit.NSTableView/_NSTableViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L20516)
- [`AppKit.NSTextView/_NSTextViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L22976)
- [`Foundation.NSDispatcher`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSAction.cs#L35)
- [`Foundation.NSTimerActionDispatcher`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSAction.cs#L85)
- [`Foundation.NSUrlSessionHandler/NSUrlSessionHandlerDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSUrlSessionHandler.cs#L1256)
- [`System.Net.Http.NSUrlSessionHandler/NSUrlSessionHandlerDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSUrlSessionHandler.cs#L1256)
- [`UIKit.UIAccessibilityCustomAction/FuncBoolDispatcher`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIAccessibilityCustomAction.cs#L39)

#### Canonical values and native constants

Keep. These initialize public or internal canonical values and native constants. Computed properties could change APIs or repeat nontrivial construction; moving the values to another cache only relocates the constructor.

- [`AudioToolbox.AudioStreamBasicDescription`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioToolbox/AudioType.cs#L294)
- [`AudioToolbox.MusicSequence`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioToolbox/MusicSequence.cs#L55)
- [`AudioToolbox.SystemSound`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioToolbox/SystemSound.cs#L52)
- [`AudioUnit.AudioComponentConfigurationInfo`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioUnit/AudioComponent.cs#L730)
- [`AudioUnit.AudioComponentInfo`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioUnit/AudioComponent.cs#L136)
- [`AudioUnit.AudioComponentValidationParameter`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioUnit/AudioComponent.cs#L705)
- [`AudioUnit.AudioUnitConfigurationInfo`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioUnit/AudioUnit.cs#L1684)
- [`AudioUnit.ResourceUsageInfo`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AudioUnit/AudioComponent.cs#L59)
- [`CoreAnimation.CATransform3D`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreAnimation/CATransform3D.cs#L49)
- [`CoreGraphics.NMatrix2`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Simd/MatrixFloat2x2.cs#L45)
- [`CoreGraphics.NMatrix3`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Simd/MatrixFloat3x3.cs#L73)
- [`CoreGraphics.NMatrix4`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Simd/MatrixFloat4x4.cs#L45)
- [`CoreGraphics.NMatrix4d`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Simd/MatrixDouble4x4.cs#L45)
- [`CoreGraphics.NVector3d`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Simd/VectorDouble3.cs#L104)
- [`CoreGraphics.RMatrix3`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Simd/MatrixFloat3x3RM.cs#L84)
- [`CoreMedia.CMTime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CMTime.cs#L47)
- [`CoreMedia.CMTimeRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CoreMedia.cs#L88)
- [`CoreMedia.CMTimeScale`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CoreMedia.cs#L237)
- [`Foundation.NSRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSRange.cs#L41)
- [`MapKit.MKMapRect`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/MapKit/MapKit.cs#L341)
- [`OpenGLES.EAGLColorFormat`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/OpenGLES/EAGLConsts.cs#L49)
- [`OpenGLES.EAGLDrawableProperty`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/OpenGLES/EAGLConsts.cs#L25)
- [`SceneKit.SCNMatrix4`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/SceneKit/SCNMatrix4_dotnet.cs#L98)
- [`SceneKit.SCNQuaternion`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/SceneKit/SCNQuaternion.cs#L248)
- [`SceneKit.SCNVector3`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/SceneKit/SCNVector3.cs#L218)
- [`SceneKit.SCNVector4`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/SceneKit/SCNVector4.cs#L79)
- [`UIKit.UIFloatRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UITypes.cs#L205)
- [`UIKit.UIFontFeature`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIFontFeature.cs#L17)
- [`UIKit.UIListSeparatorConfiguration`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIListSeparatorConfiguration.cs#L15)

#### Native callbacks, symbols, and sentinels

Keep for now. These cache native callbacks, symbols, dictionaries, or sentinel values. Each requires a framework-specific lazy or generated-constant design; there is no benign source-only removal that avoids equivalent work.

- [`CoreFoundation.CFArray`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFArray.cs#L46)
- [`CoreFoundation.CFDictionary`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFDictionary.cs#L50)
- [`CoreFoundation.CFErrorDomain`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFException.cs#L55)
- [`CoreFoundation.CFExceptionDataKey`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFException.cs#L90)
- [`CoreFoundation.CFMessagePort`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFMessagePort.cs#L73)
- [`CoreFoundation.CFPreferences`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFPreferences.cs#L38)
- [`CoreFoundation.CFPropertyList`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFPropertyList.cs#L19)
- [`CoreFoundation.DispatchTime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/Dispatch.cs#L856)
- [`CoreGraphics.CGEvent`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGEvent.cs#L36)
- [`CoreGraphics.CGFunction`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGFunction.cs#L48)
- [`CoreGraphics.CGPattern`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGPattern.cs#L95)
- [`CoreServices.FSEventStream`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreServices/FSEvents.cs#L425)
- [`CoreVideo.CVPixelFormatDescription`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreVideo/CVPixelFormatDescription.cs#L233)
- [`Foundation.NSDate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSDate.cs#L41)
- [`Foundation.NSDateComponents`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSDateComponents.cs#L5)
- [`Foundation.NSScriptCommandArgumentDescriptionKeys`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSScriptCommandArgumentDescription.cs#L25)
- [`Foundation.NSScriptCommandDescriptionDictionaryKeys`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSScriptCommandDescriptionDictionary.cs#L10)
- [`Foundation.NSScriptCommonKeys`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSScriptCommandDescription.cs#L12)
- [`Foundation.NSZone`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSZone.cs#L59)
- [`MediaToolbox.MTAudioProcessingTap`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/MediaToolbox/MTAudioProcessingTap.cs#L74)
- [`MetalPerformanceShaders.MPSImageScale`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/MetalPerformanceShaders/MPSImageScale.cs#L10)
- [`Vision.VNUtils`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Vision/VNUtils.cs#L29)

#### Runtime and framework state

Keep for now. These own runtime defaults, object-map/disposal state, selector tables, architecture data, messaging metadata, or framework singleton state. Splitting class-handle initialization may reduce bodies, but the remaining initialization is observable or stateful.

- [`AppKit.NSApplication`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AppKit/NSApplication.cs#L37)
- [`AppKit.NSGestureRecognizer`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AppKit/NSGestureRecognizer.cs#L19)
- [`AppKit.NSGraphics`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AppKit/NSGraphics.cs#L39)
- [`Foundation.NSObject`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSObject.mac.cs#L37)
- [`Foundation.NSObject/NSObject_Disposer`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSObject2.cs#L1174)
- [`Foundation.NSString`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/Foundation/NSString.cs#L54)
- [`Foundation.NSTimer`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/foundation.cs#L7365)
- [`ObjCRuntime.Class`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/Class.cs#L50)
- [`ObjCRuntime.IntPtrTypeValueTuple`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/Runtime.cs#L2929)
- [`ObjCRuntime.Messaging`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/Messaging.cs#L125)
- [`ObjCRuntime.NMath`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/NativeTypes/NMath.cs#L20)
- [`ObjCRuntime.Runtime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/Runtime.iOS.cs#L44)
- [`ObjCRuntime.Selector`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/Selector.mac.cs#L32)
- [`ObjCRuntime.TypeMaps`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/TypeMaps.cs#L210)
- [`UIKit.DraggingEventArgs`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIScrollView.cs#L22)
- [`UIKit.UIApplication`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIApplication.cs#L49)
- [`WebKit.WKWebView`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/webkit.cs#L6174)
## Removed in this change

| Type                           | Previous work                                     | Resolution |
|--------------------------------|---------------------------------------------------|------------|
| `Registrar.Registrar/ObjCType` | Allocated a fixed array of invalid selector chars | Use a constant string as a span, avoiding the array allocation and its generated constructor. |
| `Registrar.SharedDynamic/<>c`  | Initialized the singleton for one lambda          | Use a named predicate; the compiler's lazy delegate cache does not require a constructor. |

The next broad optimization should target the `linker marker` category with a post-mark or post-sweep cleanup. The `class handle only` and `binding handles` categories should be addressed in the generator or class/selector-handle rewriting pipeline rather than through thousands of individual binding edits.
