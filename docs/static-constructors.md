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

The baseline is the authoritative per-type inventory. Every reported entry has one of these evaluations:

| Category            | Entries | Evaluation |
|---------------------|--------:|------------|
| `class handle only` |  11,739 | Generated `class_ptr` initialization. The optional static-registrar class-handle rewriter can remove eligible instances, but normal Release configurations do not universally enable it. Do not hand-edit individual bindings; enabling or replacing that pipeline is the reasonable removal path. |
| `binding handles`   |   3,725 | Generated Objective-C class and selector caches, predominantly in macOS bindings. A generator-wide selector inlining or lazy lookup change is the reasonable removal path. |
| `linker marker`     |   7,501 | Generated `GC.KeepAlive (null)` bodies used as homes for trimming annotations. The executable body does no useful work. These are the highest-value broad removal candidate: remove the methods after marking, once every consumer of their attributes has run. |
| `protocol marker`   |   3,592 | Protocol-interface variants of the linker marker. Release static-registrar builds can eliminate optimizable instances through `SetBeforeFieldInitStep` and `OptimizeGeneratedCode`; they remain in this raw baseline because that transformation is configuration-dependent. |
| `compiler cache`    |     594 | Compiler-generated singleton and delegate caches. Replace one-off lambdas with named methods when that is allocation-neutral, as done for `Registrar.SharedDynamic`; keep caches that prevent repeated delegate or closure allocation. |
| `smart enum`        |     789 | Generated smart-enum handle arrays. Keep until the generator can move this cache to shared or lazy storage without adding per-call native lookups or changing API behavior. |
| `library handle`    |     391 | Cached `dlopen` handles for native frameworks. Keep: removing these constructors without another cache would repeat native library lookups, while a lazy cache retains equivalent synchronization and initialization cost. |
| `other`             |     291 | Hand-written or specialized generated initialization. These 291 platform entries represent the 96 distinct types evaluated below. |

### `other` types

The 96 exceptional types fall into the following groups. The exact platform/type membership remains in `StaticConstructors.KnownFailures.txt`.

| Types | Evaluation |
|-------|------------|
| `<Module>` | Keep. It calls `RegistrarHelper.Initialize`, which is required module startup. |
| `AddressBook.ABAddressBook`, `AddressBook.ABGroupProperty`, `AddressBook.ABLabel`, `AddressBook.ABPersonAddressKey`, `AddressBook.ABPersonDateLabel`, `AddressBook.ABPersonInstantMessageKey`, `AddressBook.ABPersonInstantMessageService`, `AddressBook.ABPersonKindId`, `AddressBook.ABPersonPhoneLabel`, `AddressBook.ABPersonPropertyId`, `AddressBook.ABPersonRelatedNamesLabel`, `AddressBook.ABPersonSocialProfile`, `AddressBook.ABPersonSocialProfileService`, `AddressBook.ABPersonUrlLabel`, `AddressBook.ABSourcePropertyId`, `AddressBook.InitConstants` | Keep for compatibility. These initialize and share native AddressBook constants. A future conversion should replace the shared initialization design as a unit, not move the same work into every accessor. |
| `AppKit.ActionDispatcher`, `AppKit.NSAlertDidEndDispatcher`, `AppKit.NSApplication/_NSApplicationDelegate`, `AppKit.NSPageController/_NSPageControllerDelegate`, `AppKit.NSTableView/_NSTableViewDelegate`, `AppKit.NSTextView/_NSTextViewDelegate`, `Foundation.NSDispatcher`, `Foundation.NSTimerActionDispatcher`, `Foundation.NSUrlSessionHandler/NSUrlSessionHandlerDelegate`, `System.Net.Http.NSUrlSessionHandler/NSUrlSessionHandlerDelegate`, `UIKit.UIAccessibilityCustomAction/FuncBoolDispatcher` | Keep unless the dispatcher implementation is redesigned. They cache selectors, callbacks, or shared delegate state; making the state lazy does not remove the initialization requirement. |
| `AudioToolbox.AudioStreamBasicDescription`, `AudioToolbox.MusicSequence`, `AudioToolbox.SystemSound`, `AudioUnit.AudioComponentConfigurationInfo`, `AudioUnit.AudioComponentInfo`, `AudioUnit.AudioComponentValidationParameter`, `AudioUnit.AudioUnitConfigurationInfo`, `AudioUnit.ResourceUsageInfo`, `CoreAnimation.CATransform3D`, `CoreGraphics.NMatrix2`, `CoreGraphics.NMatrix3`, `CoreGraphics.NMatrix4`, `CoreGraphics.NMatrix4d`, `CoreGraphics.NVector3d`, `CoreGraphics.RMatrix3`, `CoreMedia.CMTime`, `CoreMedia.CMTimeRange`, `CoreMedia.CMTimeScale`, `Foundation.NSRange`, `MapKit.MKMapRect`, `OpenGLES.EAGLColorFormat`, `OpenGLES.EAGLDrawableProperty`, `SceneKit.SCNMatrix4`, `SceneKit.SCNQuaternion`, `SceneKit.SCNVector3`, `SceneKit.SCNVector4`, `UIKit.UIFloatRange`, `UIKit.UIFontFeature`, `UIKit.UIListSeparatorConfiguration` | Keep. These initialize public or internal canonical values and native constants. Replacing fields with computed properties could be an API change or repeat nontrivial construction; moving the values to another cache would only relocate the constructor. |
| `CoreFoundation.CFArray`, `CoreFoundation.CFDictionary`, `CoreFoundation.CFErrorDomain`, `CoreFoundation.CFExceptionDataKey`, `CoreFoundation.CFMessagePort`, `CoreFoundation.CFPreferences`, `CoreFoundation.CFPropertyList`, `CoreFoundation.DispatchTime`, `CoreGraphics.CGEvent`, `CoreGraphics.CGFunction`, `CoreGraphics.CGPattern`, `CoreServices.FSEventStream`, `CoreVideo.CVPixelFormatDescription`, `Foundation.NSDate`, `Foundation.NSDateComponents`, `Foundation.NSScriptCommandArgumentDescriptionKeys`, `Foundation.NSScriptCommandDescriptionDictionaryKeys`, `Foundation.NSScriptCommonKeys`, `Foundation.NSZone`, `MediaToolbox.MTAudioProcessingTap`, `MetalPerformanceShaders.MPSImageScale`, `Vision.VNUtils` | Keep for now. These cache native callbacks, symbols, dictionaries, or sentinel values. Each would need a framework-specific lazy or generated-constant design; there is no benign source-only removal that avoids equivalent work. |
| `AppKit.NSApplication`, `AppKit.NSGestureRecognizer`, `AppKit.NSGraphics`, `Foundation.NSObject`, `Foundation.NSObject/NSObject_Disposer`, `Foundation.NSString`, `Foundation.NSTimer`, `ObjCRuntime.Class`, `ObjCRuntime.IntPtrTypeValueTuple`, `ObjCRuntime.Messaging`, `ObjCRuntime.NMath`, `ObjCRuntime.Runtime`, `ObjCRuntime.Selector`, `ObjCRuntime.TypeMaps`, `UIKit.DraggingEventArgs`, `UIKit.UIApplication`, `WebKit.WKWebView` | Keep for now. These own runtime defaults, object-map/disposal state, selector tables, architecture data, messaging metadata, or framework singleton state. Splitting out class-handle initialization may reduce individual bodies, but the remaining initialization is observable or stateful. |

## Removed in this change

| Type                           | Previous work                                     | Resolution |
|--------------------------------|---------------------------------------------------|------------|
| `Registrar.Registrar/ObjCType` | Allocated a fixed array of invalid selector chars | Use a constant string as a span, avoiding the array allocation and its generated constructor. |
| `Registrar.SharedDynamic/<>c`  | Initialized the singleton for one lambda          | Use a named predicate; the compiler's lazy delegate cache does not require a constructor. |

The next broad optimization should target the `linker marker` category with a post-mark or post-sweep cleanup. The `class handle only` and `binding handles` categories should be addressed in the generator or class/selector-handle rewriting pipeline rather than through thousands of individual binding edits.
