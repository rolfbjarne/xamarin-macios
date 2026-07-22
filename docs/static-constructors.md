<!--
Copyright (c) Microsoft Corporation.
Licensed under the MIT License.
-->

# Static constructor evaluation

Issue [#16672](https://github.com/dotnet/macios/issues/16672) tracks reducing the runtime and size cost of static constructors in the platform assemblies.

## Test strategy

`AppSizeTest` inspects the platform assembly in the published Release app bundle and compares its static constructors with the corresponding `*-static-constructors.txt` file. This is intentionally done after trimming:

- Constructors and types removed by the trimmer are not reported.
- Constructors converted to types without a `.cctor` by `cctor-beforefieldinit` or another optimization are not reported.
- A surviving `.cctor` is reported even when its type is marked `BeforeFieldInit`, because the initialization code and metadata still remain.
- The MonoVM and MonoVM interpreter configurations cover iOS, tvOS, and Mac Catalyst. NativeAOT does not leave managed assemblies to inspect, while the current CoreCLR size-test configurations are not trimmed.

The test only inspects `Microsoft.iOS.dll`, `Microsoft.tvOS.dll`, or `Microsoft.MacCatalyst.dll`; static constructors in the application and the BCL are outside the scope of this issue.

## Removed in this change

| Type                              | Previous work                                    | Resolution                                                                                   |
|-----------------------------------|--------------------------------------------------|----------------------------------------------------------------------------------------------|
| `Registrar.Registrar/ObjCType`    | Allocated a fixed array of invalid selector chars | Use a constant string as a span, avoiding the array allocation and its generated `.cctor`.   |
| `Registrar.SharedDynamic/<>c`     | Initialized the singleton for one lambda          | Use a named predicate; the compiler's lazy delegate cache does not require a `.cctor`.        |

Both types were only present in interpreter builds.

## Remaining constructors

`All` below means both MonoVM configurations on iOS, tvOS, and Mac Catalyst.

| Type                                      | Release configurations  | Work performed                                               | Evaluation                                                                                              |
|-------------------------------------------|-------------------------|--------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|
| `<Module>`                                | All                     | Calls `RegistrarHelper.Initialize`.                           | Keep. This is required module startup for registrar initialization.                                     |
| `CoreFoundation.CFArray`                  | All                     | Caches the native `kCFNull` handle.                           | Keep. Removing it would repeat a native field lookup or require another cache with the same semantics.   |
| `Foundation.NSAutoreleasePool`            | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `Foundation.NSDictionary`                 | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `Foundation.NSException`                  | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `Foundation.NSObject`                     | All                     | Initializes `PlatformAssembly` and `class_ptr`.               | Keep for now. Class-handle redirection can remove part of it, but the public assembly field remains.     |
| `Foundation.NSObject/NSObject_Disposer`   | All                     | Creates drain lists, a lock, and its Objective-C class handle. | Keep. This is stateful one-time initialization used by the disposer.                                    |
| `Foundation.NSString`                     | Interpreter only        | Creates the singleton `Empty` string and initializes `class_ptr`. | Keep. `Empty` is a public field whose eager singleton behavior should not change casually.            |
| `ObjCRuntime.Class`                       | All                     | Sets public `ThrowOnInitFailure` to `true`.                   | Keep. Moving or inverting this default would risk an observable API behavior change.                     |
| `ObjCRuntime.Libraries/CoreFoundation`    | All                     | Opens and caches the CoreFoundation library handle.           | Keep. A property would repeat `dlopen`; another lazy cache would retain equivalent initialization.       |
| `ObjCRuntime.Protocol`                    | Interpreter only        | Runs only `GC.KeepAlive (null)` after linker marking.         | Remove in a post-mark linker cleanup once its `DynamicDependency` annotations have served their purpose. |
| `ObjCRuntime.Runtime`                     | iOS/tvOS, both modes    | Stores the runtime architecture; the linker folds it to a constant. | Candidate for a linker rewrite, but the public readonly field makes a source change inappropriate.  |
| `ObjCRuntime.Selector`                    | All                     | Runs only `GC.KeepAlive (null)` after linker marking.         | Remove in the same post-mark linker cleanup as `ObjCRuntime.Protocol`.                                  |
| `UIKit.UIApplication`                     | All                     | Sets two public validation defaults and initializes `class_ptr`. | Keep for now. Class-handle redirection removes only part of the required initialization.              |
| `UIKit.UIApplicationDelegate`             | All                     | Runs only `GC.KeepAlive (null)` after linker marking.         | Remove in the same post-mark linker cleanup as `ObjCRuntime.Protocol`.                                  |
| `UIKit.UIButton`                          | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `UIKit.UIControl`                         | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `UIKit.UIResponder`                       | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `UIKit.UIScreen`                          | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `UIKit.UIView`                            | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `UIKit.UIViewController`                  | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |
| `UIKit.UIWindow`                          | All                     | Initializes `class_ptr`.                                      | Remove when class-handle redirection is available for this configuration.                               |

The safest next optimization is the post-mark cleanup of the three no-op constructors. The class-handle-only group should be handled by extending or enabling the existing class-handle rewriter rather than by changing each generated binding independently.
