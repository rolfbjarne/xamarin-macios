# Managed static registrar

The managed static registrar is a variation of the static registrar where we
don't use features the NativeAOT compiler doesn't support (most notably
metadata tokens).

It also takes advantage of new features in C# and managed code since the
original static registrar code was written - in particular it tries to do as
much as possible in managed code instead of native code, as well as various
other performance improvements. The actual performance characteristics
compared to the original static registrar will vary between the specific
exported method signatures, but in general it's expected that method calls
from native code to managed code will be faster.

In order to make the managed static registrar easily testable and debuggable,
it's also implemented for the other runtimes as well (Mono and CoreCLR as
well), as well as when not using AOT in any form.

## Design

For each method exported to Objective-C, the managed static registrar will
generate a managed method we'll call directly from native code, and which does
all the marshalling.

This method will have the [UnmanagedCallersOnly] attribute, so that it doesn't
need any additional marshalling from the managed runtime - which makes it
possible to obtain a native function pointer for it. It will also have a
native entry point, which means that for AOT we can just directly call it from
the generated Objective-C code.

Given the following method:

```csharp
class AppDelegate : NSObject, IUIApplicationDelegate {
    // this method is written by the app developer
    public override bool FinishedLaunching (UIApplication app, NSDictionary options)
    {
        // ...
    }
```

The managed static registrar will add the following method to the `AppDelegate` class:

```csharp
    [UnmanagedCallersOnly (EntryPoint = "__registrar__uiapplicationdelegate_didFinishLaunching")]
    static byte __registrar__DidFinishLaunchingWithOptions (IntPtr handle, IntPtr selector, IntPtr p0, IntPtr p1)
    {
        var obj = Runtime.GetNSObject (handle);
        var p0Obj = (UIApplication) Runtime.GetNSObject (p0);
        var p1Obj = (NSDictionary) Runtime.GetNSObject (p1);
        var rv = obj.DidFinishLaunchingWithOptions (p0Obj, p1Obj);
        return rv ? (byte) 1 : (byte) 0;
    }
}
```

and the generated Objective-C code will look something like this:

```objective-c
extern BOOL __registrar__uiapplicationdelegate_init (AppDelegate self, SEL _cmd, UIApplication* p0, NSDictionary* p1);

@interface AppDelegate : NSObject<UIApplicationDelegate, UIApplicationDelegate> {
}
    -(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
@end
@implementation AppDelegate {
}
    -(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1
    {
        return __registrar__uiapplicationdelegate_didFinishLaunching (self, _cmd, p0, p1);
    }
@end
```

Note: the actual code is somewhat more complex in order to properly support
managed exceptions and a few other corner cases.

### Type mapping

The runtime needs to quickly and efficiently do lookups between an Objective-C
type and the corresponding managed type. In order to support this, the managed
static registrar will add lookup tables in each assembly. The managed static
registrar will create a numeric ID for each managed type, which is then
emitted into the generated Objective-C code, and which we can use to look up
the corresponding managed type. There is also a table in Objective-C that maps
between the numeric ID and the corresponding Objective-C type.

We also need to be able to find the wrapper type for interfaces representing
Objective-C protocols - this is accomplished by generating a table in
unmanaged code that maps the ID for the interface to the ID for the wrapper
type.

This is all supported by the `ObjCRuntime.IManagedRegistrar.LookTypeId` and
`ObjCRuntime.IManagedRegistrar.Lookup` methods.

## Interpreter / JIT

When not using the AOT compiler, we need to look up the native entry points
for UnmanagedCallersOnly methods at runtime. In order to support this, the
managed static registrar will add lookup tables in each assembly. The managed
static registrar will create a numeric ID for each UnmanagedCallersOnly
method, which is then emitted into the generated Objective-C code, and which
we can use to look up the managed UnmanagedCallersOnly method at runtime (in
the lookup table).

This is the `ObjCRuntime.IManagedRegistrar.LookupUnmanagedFunction` method.

## References

* https://github.com/dotnet/runtime/issues/80912
