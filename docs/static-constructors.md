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

The initial high-impact inventory contained 11,184 platform/type pairs. After the field-initializer and generated-native-constant changes merged into `main`, 67 entries have been removed and 11,117 remain:

| Platform     | Reported |
|--------------|---------:|
| iOS          |    3,285 |
| tvOS         |    2,045 |
| Mac Catalyst |    3,063 |
| macOS        |    2,724 |

The baseline is the authoritative per-type inventory. The categories below explain whether each constructor can reasonably be removed and provide representative source links. The exact platform/type membership remains in `StaticConstructors.KnownFailures.txt`.

| Category            | Entries |
|---------------------|--------:|
| `linker marker`     |   7,501 |
| `protocol marker`   |   3,592 |
| `other`             |      24 |

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

Hand-written or specialized generated initialization. All nine remaining distinct types are listed below; links point to the constructor source when sequence points are available.

#### Field initializer candidates

These three types can replace their explicit static constructors with field or property initializers. This retains the cached values and generated initialization method, but lets the compiler mark the type `beforefieldinit`, removing the stricter initialization checks that this inventory targets.

The following two constructors contain only assignments that can move directly to their field or property declarations:

- [`CoreFoundation.CFDictionary`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFDictionary.cs#L48)
- [`CoreMedia.CMTime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CMTime.cs#L461)

[`CoreMedia.CMTimeRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CoreMedia.cs#L86) is also a candidate, but its conditional `kCMTimeMappingInvalid` lookup needs a small helper that returns the default value when the symbol is unavailable.

The other six types are not candidates for this conversion. `<Module>` performs required module startup, and the four generated AppKit delegates plus `Foundation.NSTimer` need explicit constructors to retain trimming attributes. Their selector and class-handle fields are already initialized inline.

#### Required module initialization

Keep. This calls `RegistrarHelper.Initialize`, which is required module startup.

- [`<Module>`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/ObjCRuntime/RegistrarHelper.cs#L56)

#### Migrated AddressBook constants

Removed by [#26290](https://github.com/dotnet/macios/pull/26290). These constants now use generated `[Field]` accessors. This eliminates the shared `InitConstants` coordinator and the strict constructors that called it while preserving the existing public property and readonly-field shapes. The historical source links document the replaced implementation.

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

`CoreMedia.CMTime` and `CoreMedia.CMTimeRange` remain field-initializer candidates.

- [`CoreMedia.CMTime`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CMTime.cs#L47)
- [`CoreMedia.CMTimeRange`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreMedia/CoreMedia.cs#L88)

#### Native callbacks, symbols, and sentinels

`CoreFoundation.CFDictionary` remains a field-initializer candidate.

- [`CoreFoundation.CFDictionary`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/CoreFoundation/CFDictionary.cs#L50)

#### Remaining native constant-loader limitations

The source-tree audit found the following native constant paths that cannot move to generated `[Field]` accessors without changing semantics or the shipped API:

- `CoreFoundation.CFArray`, `CoreFoundation.CFDictionary`, and dispatch queue symbols require the address of a native symbol through `Dlfcn.GetIndirect`. bgen's pointer field support dereferences the symbol with `Dlfcn.GetIntPtr` instead. `CFDictionary` also exposes mutable public callback-pointer fields.
- `CoreMedia.CMTime` and `CoreMedia.CMTimeRange` are partial structs, and bgen cannot add fields to them. `CMTimeRange` also conditionally handles an unavailable `kCMTimeMappingInvalid` symbol.
- `CoreTelephony.CTCall` exposes the call-state constants as nullable instance `string` properties. Generated fields are static and use `NSString`, so migration would break the managed API.
- `CoreAnimation.CAFrameRateRange`, `CoreGraphics.CGRect`, `CoreVideo.CVTime`, `UIKit.UIPointerAccessoryPosition`, and Nearby Interaction sentinel values require custom struct marshaling from symbol addresses, which generated fields do not support.

#### Runtime and framework state

Keep the explicit `Foundation.NSTimer` constructor because it carries trimming metadata; its class handle is already initialized inline.

- [`Foundation.NSTimer`](https://github.com/dotnet/macios/blob/d8946aa51f156632a75a2540eaa84a9c7b154f21/src/foundation.cs#L7365)

## Removed

| Type                                               | Previous work                                           | Resolution |
|----------------------------------------------------|---------------------------------------------------------|------------|
| `Registrar.Registrar/ObjCType`                     | Allocated a fixed array of invalid selector chars       | Use a constant string as a span, avoiding the array allocation and its generated constructor. |
| `Registrar.SharedDynamic/<>c`                      | Initialized the singleton for one lambda                | Use a named predicate; the compiler's lazy delegate cache does not require a constructor. |
| `CoreAnimation.CATransform3D`                      | Initialized the identity transform                      | [#26264](https://github.com/dotnet/macios/pull/26264) initializes `Identity` directly at its declaration. |
| `CoreGraphics.CGFunction`                          | Initialized native callback pointers                    | [#26264](https://github.com/dotnet/macios/pull/26264) initializes `cbacks` directly at its declaration. |
| `CoreGraphics.CGPattern`                           | Initialized native callback pointers                    | [#26264](https://github.com/dotnet/macios/pull/26264) initializes `callbacks` directly at its declaration. |
| `CoreVideo.CVPixelFormatDescription`               | Initialized obsolete aliases for pixel format keys      | [#26264](https://github.com/dotnet/macios/pull/26264) initializes each alias directly at its declaration. |
| `UIKit.DraggingEventArgs`                          | Initialized shared Boolean event data                   | [#26264](https://github.com/dotnet/macios/pull/26264) initializes `True` and `False` directly at their declarations. |
| AddressBook constant types and `InitConstants`     | Loaded and coordinated AddressBook constants by hand    | [#26290](https://github.com/dotnet/macios/pull/26290) generates `[Field]` accessors and removes the shared coordinator and strict constructors. |
| `CoreFoundation.CFErrorDomain`                     | Loaded four `NSString` constants in a strict constructor | [#26290](https://github.com/dotnet/macios/pull/26290) generates `[Field]` accessors while retaining the public readonly fields. |
| `CoreFoundation.CFExceptionDataKey`                | Loaded five `NSString` constants in a strict constructor | [#26290](https://github.com/dotnet/macios/pull/26290) generates `[Field]` accessors while retaining the public readonly fields. |
| `CoreFoundation.CFPreferences`                     | Loaded `CurrentApplication` in a strict constructor     | [#26290](https://github.com/dotnet/macios/pull/26290) generates a `[Field]` accessor while retaining the public readonly field. |
| `OpenGLES.EAGLColorFormat`, `EAGLDrawableProperty` | Loaded four `NSString` constants in strict constructors | [#26290](https://github.com/dotnet/macios/pull/26290) generates `[Field]` accessors while retaining the public readonly fields. |

The next broad optimization should target the `linker marker` category with a post-mark or post-sweep cleanup.
