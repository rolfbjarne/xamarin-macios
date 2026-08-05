<!--
Copyright (c) Microsoft Corporation.
Licensed under the MIT License.
-->

# Static constructor evaluation

Issue [#16672](https://github.com/dotnet/macios/issues/16672) tracks reducing the runtime and size cost of static constructors in the platform assemblies.

## Test strategy

`tests/cecil-tests/StaticConstructors.cs` inspects the complete implementation assemblies for iOS, tvOS, Mac Catalyst, and macOS. Unlike an app-based test, this covers every binding type whether or not a sample app happens to use it. It reports constructors on types without `beforefieldinit`, because these constructors have strict initialization semantics and the highest performance impact. It does not assume that an optional registrar or trimmer optimization ran.

`AppSizeTest` remains the complementary end-to-end check. It inspects platform assemblies from published Release apps, so it verifies the constructors without `beforefieldinit` that actually survive each tested trimming and interpreter configuration. Its inventory is necessarily limited to types retained by `SizeTestApp`; the Cecil inventory closes that coverage gap.

The Cecil test narrowly recognizes common IL shapes for evaluation categories, but categories do not suppress failures. The known-failures file is platform-qualified because the implementation and constructor set differ by platform.

Set `WRITE_KNOWN_FAILURES=1` when an intentional change requires regenerating the file. Each line includes an evaluation category, so changes that move a constructor from one recognized role to another are reviewed even when the type still has a constructor. The test is not intended to detect arbitrary IL changes that remain within the same category.

## Inventory

The initial high-impact inventory contained 11,184 platform/type pairs. After the field-initializer and generated-native-constant changes merged into `main`, 79 entries have been removed and 11,105 remain:

| Platform     | Reported |
|--------------|---------:|
| iOS          |    3,282 |
| tvOS         |    2,042 |
| Mac Catalyst |    3,060 |
| macOS        |    2,721 |

The baseline is the authoritative per-type inventory. The categories below explain whether each constructor can reasonably be removed and provide representative source links. The exact platform/type membership remains in `StaticConstructors.KnownFailures.txt`.

| Category            | Entries |
|---------------------|--------:|
| `linker marker`     |   7,501 |
| `protocol marker`   |   3,592 |
| `other`             |      12 |

### `linker marker`

Generated wrapper types whose constructors host trimming annotations and execute only `GC.KeepAlive (null)`. Wrapper names link to the protocol declarations that generate them. These are candidates for post-mark or post-sweep removal.

For example, bgen generates the following constructors from the [`ARAnchorCopying` protocol declaration](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/arkit.cs#L350-L356). The interface constructor represents the `protocol marker` category, while the wrapper constructor represents the `linker marker` category:

```csharp
[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARAnchorCopyingWrapper))]
[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
static IARAnchorCopying ()
{
	GC.KeepAlive (null);
}

[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARAnchorCopyingWrapper))]
static ARAnchorCopyingWrapper ()
{
	GC.KeepAlive (null);
}
```

The corresponding [bgen implementation](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L5169-L5178) emits the interface constructor and separately [emits the wrapper constructor](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/bgen/Generator.cs#L5292-L5296).

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

### `other`

Hand-written or specialized generated initialization. All six remaining distinct types are required: `<Module>` performs module startup, and the four generated AppKit delegates plus `Foundation.NSTimer` retain trimming metadata. Their selector and class-handle fields are already initialized inline.

#### Required module initialization

Keep. This calls `RegistrarHelper.Initialize`, which is required module startup.

- [`<Module>`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/RegistrarHelper.cs#L56)

#### Dispatchers and delegate helpers

Keep unless the dispatcher implementation is redesigned. These cache selectors, callbacks, or shared delegate state; making the state lazy does not remove the initialization requirement.

- [`AppKit.NSApplication/_NSApplicationDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L642)
- [`AppKit.NSPageController/_NSPageControllerDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L20179)
- [`AppKit.NSTableView/_NSTableViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L20516)
- [`AppKit.NSTextView/_NSTextViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L22976)

#### Runtime and framework state

Keep the explicit `Foundation.NSTimer` constructor because it carries trimming metadata; its class handle is already initialized inline.

- [`Foundation.NSTimer`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/foundation.cs#L7365)
