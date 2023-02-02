# Custom Linker Steps

All steps: https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/dotnet/targets/Xamarin.Shared.Sdk.targets#L576-L624

## pre-mark custom steps

### Xamarin.SetupStep

Initial step to configure everything. Not needed if all the other steps are removed.

### Xamarin.Linker.CollectAssembliesStep

Loads all the assemblies in the linker, so that we know the entire set of assemblies in later steps.

This would not be needed if LinkContext.GetAssemblies () was exposed to us.

### MonoTouch.Tuner.CoreTypeMapStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/CoreTypeMapStep.cs

This step computes information we need in a later optimization.

Example code:

```cs
// Microsoft.iOS.dll

class NSObject {
    public property IsCustomSubclass {
        get {
            return GetType ().Assembly == typeof (NSObject).Assembly;
        }
    }
}

class A : NSObject {
    public void DoSomething ()
    {
        if (IsCustomSubclass) {
            DoX ();
        } else {
            DoY ();
        }
    }
}

class B : NSObject {
    public void DoSomething ()
    {
        if (IsCustomSubclass) {
            DoX ();
        } else {
            DoY ();
        }
    }
}

// User code
class MyObject : A {}
class Z {
    public static void Main ()
    {
        var myObject = new MyObject ();
        myObject.DoSomething ();
        var b = new B ();
        b.DoSomething ();
    }
}
```

would get optimized to:

```cs
// Microsoft.iOS.dll

class NSObject {
    public property IsCustomSubclass {
        get {
            // Special implementation, but essentially:
            return GetType ().Assembly == typeof (NSObject).Assembly;
        }
    }
}

class A : NSObject {
    public void DoSomething ()
    {
        if (IsCustomSubclass) {
            DoX ();
        } else {
            DoY ();
        }
    }
}

class B : NSObject {
    public void DoSomething ()
    {
        DoY ();
    }
}

// User code
class MyObject : A {}
class Z {
    public static void Main ()
    {
        var myObject = new MyObject ();
        myObject.DoSomething ();
        var b = new B ();
        b.DoSomething ();
    }
}
```

Note how the implementation of `B.DoSomething()` got simplified, because we were
able to determine that `IsCustomSubclass` would always return false, because
there's no subclass of B.

### MonoTouch.Tuner.RegistrarRemovalTrackingStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/RegistrarRemovalTrackingStep.cs

Removes the runtime code for the dynamic registrar if certain conditions are met:

* The static registrar is selected.
* Nothing calls the following methods:
    * ObjCRuntime.Runtime.ConnectMethod
    * ObjCRuntime.Runtime.RegisterAssembly
    * ObjCRuntime.BlockLiteral.SetupBlock[Unsafe]: unless the assembly in question is linked (because in another custom linker step we rewrite calls to these methods so that they don't require the runtime code for the dynamic registrar).
    * ObjCRuntime.TypeConverter.ToManaged

### Xamarin.Linker.Steps.PreMarkDispatcher

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/PreMarkDispatcher.cs

Executes the next two steps.

#### CollectUnmarkedMembersSubStep 

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/CollectUnmarkedMembers.cs#L10

The trimmer might remove members the static registrar needs, so store those members somewhere accessible for the static registrar later.

#### StoreAttributesStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/StoreAttributesStep.cs#L7

The trimmer might remove some of the attributes the static registrar needs, so store those attributes somewhere accessible for the static registrar later.

### Xamarin.Linker.Steps.PreserveBlockCodeHandler

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/PreserveBlockCodeHandler.cs

For the following code:

```cs
static internal class SDInnerBlock 

    // this field is not preserved by other means, but it must not be linked away
    static internal readonly DInnerBlock Handler = Invoke;
    [MonoPInvokeCallback (typeof (DInnerBlock))]
    static internal void Invoke (IntPtr block, int magic_number)
    {
    }
}
```

The `SDInnerBlock.Handler` field is accessed by reflection, so this step marks the field (and the method).

Note: this will probably not be needed with the static registrar changes for NativeAOT.

### Xamarin.Linker.OptimizeGeneratedCodeHandler

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/CoreOptimizeGeneratedCode.cs

This step optimizes code in various ways.

A full description can be found here: https://github.com/xamarin/xamarin-macios/blob/main/docs/website/optimizations.md

### Xamarin.Linker.BackingFieldDelayHandler

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/BackingFieldDelayHandler.cs

This step makes it so that this code:

```cs
class SomeObject : IDisposable {
    IDisposable field1;
    IDisposable field2;

    void Dispose ()
    {
        field1?.Dispose ();
        field1 = null;
        field2?.Dispose ();
        field2 = null;
    }
}
```

is optimized to:

```cs
class SomeObject : IDisposable {}
```

The problem is that the fields aren't removed because they're referenced in the Dispose method (but not anywhere else).

The step handles this by removing the body of the Dispose method before the linker marks anything, and if there any fields left after the mark step is complete, then new code is added to the Dispose method to call Dispose on those fields (only).

### Xamarin.Linker.MarkIProtocolHandler

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/MarkIProtocolHandler.cs

For the following code:

```cs
class NSObject {}
[Protocol]
interface IProtocol {}
class MyObject : NSObject, IProtocol
{
}
class Program {
    static void Main ()
    {
        var obj = new MyObject ();
    }
}
```

If we're not using the static registrar, this this step will mark the `IProtocol` interface (and not remove it from the list of interfaces `MyObject` implements), because at runtime we need to be able to know all the interfaces with a [Protocol] attribute every class implements.

It might be possible to do this with a DynamicDependency attribute instead.

### Xamarin.Linker.Steps.MarkDispatcher

Runs the two next steps

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/MarkDispatcher.cs

#### Xamarin.Linker.Steps.MarkNSObjects

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/MarkNSObjects.cs#L42

Marks:

* For all types that either subclasses NSObject (directly or indirectly) or implements the INativeObject interface:
    * If the type is in a user assembly, mark the entire type.
    * If the type is in our platform assembly, then it preserves:
        * For all methods with an [Export] attribute, and the method has been overridden in user code, preserves the method (conditioned on the type with the override being marked)
        * Preserve a specific constructor we need (conditioned on the type with the override being marked)

#### Xamarin.Linker.Steps.ApplyPreserveAttribute 

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/ApplyPreserveAttribute.cs#L14

Marks anything with a [Preserve] attribute.

### Xamarin.Linker.Steps.PreserveSmartEnumConversionsHandler

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/MonoTouch.Tuner/PreserveSmartEnumConversions.cs

For the following code:

```cs
[return: BindAs (typeof (SomeEnum))]
public SomeEnum DoSomething () {}
```

will preserve the following extension methods:

```cs
public static class SomeEnum_Extensions {
    public static SomeEnum GetValue (this NSString constant) {}
    public static NSString GetConstant (this SomeEnum value) {}
}
```

because we need these methods at runtime to convert between the native representation (an NSString) and the managed representation (an enum).

Note: this can probably be expressed using linker dependency attributes instead.
Note 2: this will probably also not be needed with the static registrar changes for NativeAOT.

### Xamarin.Linker.ManagedRegistrarStep

Post-mark, Pre-sweep

New registrar code for NativeAOT.

This step needs to know which API has been kept, and also needs to inspect API that may have been trimmed away.

### Xamarin.Linker.Steps.PostSweepDispatcher

Post-sweep, pre output

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/PostSweepDispatcher.cs

Runs the next step.

#### RemoveAttributesStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/RemoveAttributesStep.cs#L23

Removes attributes we don't care about anymore. A comment in the code explains why the trimmer's built-in attribute removal logic isn't easy to adopt.

### Xamarin.Linker.LoadNonSkippedAssembliesStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/LoadNonSkippedAssembliesStep.cs

Post-sweep, pre output

Saves the list of assemblies that haven't been linked away for use in later steps.

### Xamarin.Linker.ExtractBindingLibrariesStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/ExtractBindingLibrariesStep.cs

Post-sweep, pre output

Extracts and removes certain resources from assemblies.

Note that we only do this for assemblies that have not been linked away (see LoadNonSkippedAssembliesStep).)

### Xamarin.Linker.Steps.ListExportedSymbols

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/MonoTouch.Tuner/ListExportedSymbols.cs

Post-sweep, pre output

Creates a list of:

* All P/Invokes to __Internal.
* Managed classes that represent Objective-C classes from third-party bindings.
* Fields with the [Field](https://learn.microsoft.com/en-us/dotnet/api/foundation.fieldattribute) attribute.
* Native dynamic libraries and frameworks we want to link (natively) with.

These lists are used to ask the native linker to not remove the corresponding native symbols (and as such these lists should only be created after the trimmer has executed).

It also:

* Modifies some P/Invokes to call our own custom native wrapper function instead.

### Xamarin.Linker.Steps.PreOutputDispatcher

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/PreOutputDispatcher.cs

Post-sweep, pre output

Runs the next two steps:

* RemoveUserResourcesSubStep
* BackingFieldReintroductionSubStep

#### Xamarin.Linker.RemoveUserResourcesSubStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/linker/RemoveUserResourcesSubStep.cs#L16

Removes certain resources from assemblies.

#### Xamarin.Linker.BackingFieldReintroductionSubStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/BackingFieldDelayHandler.cs#L96

The second part of Xamarin.Linker.BackingFieldDelayHandler.

### Xamarin.Linker.RegistrarStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/RegistrarStep.cs

Post-output.

Run the static registrar.

This step needs to know which API has been kept, and also needs to inspect API that may have been trimmed away, and also has to run after the assemblies have been saved to disk (because that's when the metadata tokens are created in Cecil).

### Xamarin.GenerateMainStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/GenerateMainStep.cs

Post-output.

Generate the native main function.

### Xamarin.GenerateReferencesStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/GenerateReferencesStep.cs

Post-output.

Generates native code based on the output from the ListExportedSymbols step.

### Xamarin.GatherFrameworksStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/GatherFrameworksStep.cs

Post-output.

Computes all the frameworks the app needs to link (natively) with.

### Xamarin.Linker.ComputeNativeBuildFlagsStep

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/ComputeNativeBuildFlagsStep.cs

Post-output.

Computes flags we need to pass to clang to build the native executable.

### Xamarin.Linker.ComputeAOTArguments

https://github.com/xamarin/xamarin-macios/blob/d27667f48a4379e851c79de505a098b77a30074f/tools/dotnet-linker/Steps/ComputeAOTArguments.cs

Post-output.

Computes the arguments we need to pass to the AOT compiler.

### Xamarin.Linker.DoneStep

Final cleanup.

Saves the output from some of the other steps to disk.

Not needed if all the other steps are removed.
