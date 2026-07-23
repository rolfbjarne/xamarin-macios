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

The initial high-impact inventory contains 11,184 platform/type pairs:

| Platform     | Reported |
|--------------|---------:|
| iOS          |    3,311 |
| tvOS         |    2,055 |
| Mac Catalyst |    3,087 |
| macOS        |    2,731 |

The baseline is the authoritative per-type inventory. The categories below explain whether each constructor can reasonably be removed and provide representative source links. The exact platform/type membership remains in `StaticConstructors.KnownFailures.txt`.

| Category            | Entries |
|---------------------|--------:|
| `linker marker`     |   7,501 |
| `protocol marker`   |   3,592 |
| `other`             |      91 |

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

### `other`

Hand-written or specialized generated initialization. All 35 distinct types are listed below; links point to the constructor source when sequence points are available.

#### Field initializer candidates

These 16 types can replace their explicit static constructors with field or property initializers. This retains the cached values and generated initialization method, but lets the compiler mark the type `beforefieldinit`, removing the stricter initialization checks that this inventory targets.

The following 15 constructors contain only assignments that can move directly to their field or property declarations:

- [`AddressBook.ABAddressBook`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABAddressBook.cs#L231)
- [`AddressBook.ABPersonSocialProfile`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L336)
- [`AddressBook.ABPersonSocialProfileService`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/AddressBook/ABPerson.cs#L377)
- [`CoreAnimation.CATransform3D`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreAnimation/CATransform3D.cs#L47)
- [`CoreFoundation.CFDictionary`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFDictionary.cs#L48)
- [`CoreFoundation.CFErrorDomain`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFException.cs#L53)
- [`CoreFoundation.CFExceptionDataKey`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFException.cs#L88)
- [`CoreFoundation.CFPreferences`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFPreferences.cs#L36)
- [`CoreGraphics.CGFunction`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGFunction.cs#L46)
- [`CoreGraphics.CGPattern`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGPattern.cs#L92)
- [`CoreMedia.CMTime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CMTime.cs#L461)
- [`CoreVideo.CVPixelFormatDescription`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreVideo/CVPixelFormatDescription.cs#L231)
- [`OpenGLES.EAGLColorFormat`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/OpenGLES/EAGLConsts.cs#L47)
- [`OpenGLES.EAGLDrawableProperty`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/OpenGLES/EAGLConsts.cs#L23)
- [`UIKit.DraggingEventArgs`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIScrollView.cs#L20)

[`CoreMedia.CMTimeRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CoreMedia.cs#L86) is also a candidate, but its conditional `kCMTimeMappingInvalid` lookup needs a small helper that returns the default value when the symbol is unavailable.

The other 19 types are not candidates for this conversion. Twelve AddressBook types deliberately trigger the ordered initialization coordinated by `InitConstants`; `<Module>` performs required module startup; and the four generated AppKit delegates plus `Foundation.NSTimer` need explicit constructors to retain trimming attributes. Their selector and class-handle fields are already initialized inline.

#### Required module initialization

Keep. This calls `RegistrarHelper.Initialize`, which is required module startup.

- [`<Module>`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/RegistrarHelper.cs#L56)

#### AddressBook constants

Keep the 13-type `InitConstants` design for compatibility: 12 types invoke the coordinator, which initializes and shares the native AddressBook constants as an ordered unit. The three standalone assignment-only types are field-initializer candidates listed above.

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

- [`AppKit.NSApplication/_NSApplicationDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L642)
- [`AppKit.NSPageController/_NSPageControllerDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L20179)
- [`AppKit.NSTableView/_NSTableViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L20516)
- [`AppKit.NSTextView/_NSTextViewDelegate`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/appkit.cs#L22976)

#### Canonical values and native constants

Keep the cached values, but move their assignment to field initializers as described above.

- [`CoreAnimation.CATransform3D`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreAnimation/CATransform3D.cs#L49)
- [`CoreMedia.CMTime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CMTime.cs#L47)
- [`CoreMedia.CMTimeRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CoreMedia.cs#L88)
- [`OpenGLES.EAGLColorFormat`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/OpenGLES/EAGLConsts.cs#L49)
- [`OpenGLES.EAGLDrawableProperty`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/OpenGLES/EAGLConsts.cs#L25)

#### Native callbacks, symbols, and sentinels

Keep the cached callbacks, symbols, dictionaries, and sentinel values, but move their assignment to field initializers as described above.

- [`CoreFoundation.CFDictionary`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFDictionary.cs#L50)
- [`CoreFoundation.CFErrorDomain`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFException.cs#L55)
- [`CoreFoundation.CFExceptionDataKey`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFException.cs#L90)
- [`CoreFoundation.CFPreferences`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFPreferences.cs#L38)
- [`CoreGraphics.CGFunction`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGFunction.cs#L48)
- [`CoreGraphics.CGPattern`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreGraphics/CGPattern.cs#L95)
- [`CoreVideo.CVPixelFormatDescription`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreVideo/CVPixelFormatDescription.cs#L233)

#### Runtime and framework state

`UIKit.DraggingEventArgs` is a direct field-initializer candidate. Keep the explicit `Foundation.NSTimer` constructor because it carries trimming metadata; its class handle is already initialized inline.

- [`Foundation.NSTimer`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/foundation.cs#L7365)
- [`UIKit.DraggingEventArgs`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/UIKit/UIScrollView.cs#L22)

## Removed in this change

| Type                           | Previous work                                     | Resolution |
|--------------------------------|---------------------------------------------------|------------|
| `Registrar.Registrar/ObjCType` | Allocated a fixed array of invalid selector chars | Use a constant string as a span, avoiding the array allocation and its generated constructor. |
| `Registrar.SharedDynamic/<>c`  | Initialized the singleton for one lambda          | Use a named predicate; the compiler's lazy delegate cache does not require a constructor. |

The next broad optimization should target the `linker marker` category with a post-mark or post-sweep cleanup.
