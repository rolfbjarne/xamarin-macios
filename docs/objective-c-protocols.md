# Protocoolizer 3000XXX.

This document describes how we bind Objective-C protocols in C#, and in
particular improvements we've done in .NET 8.

## Objective-C protocols

Objective-C protocols are quite similar to C# interfaces, except when they're
not, and that makes binding them somewhat complicated.

### Optional/required members

Objective-C protocols can have both optional and required members. It's always
been possible to represent required members in a C# interface (any interface
member would be required), but optional members were not possible until C# added
support for default interface members in C# 8.

In the past (before .NET 8) we represented optional members in two ways:

* As an extension method on the interface (useful when calling the optional member).
* As an IDE feature that would show any optional members from an interface by
  typing 'override ...' in the text editor (useful when implementing an optional member).

This had a few drawbacks:

* There are no extension properties, so optional properties would have to be
  bound as a pair of GetProperty/SetProperty methods.
* The IDE feature was obscure, few people knew about it, it broke on pretty much
  every major release of Visual Studio for Mac, and it was never implemented for
  Visual Studio on Windows. This made it quite hard to implement optional
  members in a managed class extending an Objective-C protocol, since developers
  would have to figure out the correct Export attribute as well as the signature
  (which is quite complicated for more complex signatures, especially if blocks
  are involved).

### Changing requiredness

It's entirely possible to change a member from being required to being optional
in Objective-C. Technically it's also a breaking change to do the opposite (make
an optional member required), but Apple does it all the time.

Before .NET 8 we had no way of changing requiredness in the corresponding C#
bindings, because it would be a breaking change. We would just not update the
binding until we're able to do breaking changes (which happens very rarely).

### Static members

Objective-C protocols can have static members. C# didn't allow for static
members in interfaces until C# 11, so there wasn't any good way to bind static
protocol members on a protocol. Our workaround was to inline every static member
in all classes that implemented a given protocol.

### Initializers

Objective-C protocols can have initializers (constructors). C# still doesn't
allow for constructors in interfaces. In the past we haven't bound any protocol
initializer at all, we've completely ignored them.

## Binding in C#

### Optional/required members and changing requiredness

Given the following API definition:

```cs
[Protocol]
public interface Protocol {
    [Abstract]
    [Export ("requiredMethod")]
    void RequiredMethod ();

    [Export ("optionalMethod")]
    void OptionalMethod ();
}
```

we're binding it like this:

```cs
[Protocol ("Protocol")]
public interface IProtocol : INativeObject {
    [Required]
    [Export ("requiredMethod")]
    public void RequiredMethod () { /* default implementation */ }

    [Optional]
    [Export ("optionalMethod")]
    public void OptionalMethod () { /* default implementation */ }
}
```

The only difference between them is that the required method has a `[Required]`
attribute, and the optional method as an `[Optional]` attribute.

This way it won't be a breaking change to make a required member optional, and
vice versa.

The downside is that the C# compiler won't enforce that required members are
implemented (note that in many cases it's possible to not implement a required
member in Objective-C - you'll get a compiler warning, but you may get away with
it at runtime, depending on the code that uses your protocol implementation).

Instead we emit a warning at build time from our own build tools (linker steps),
that lets the developer know about required members that haven't been
implemented. It's possible to either ignore these warnings, or make them errors
[TODO: explain exactly how].

### Static members

Given the following API definition:

```cs
[Protocol]
public interface Protocol {
    [Abstract]
    [Static]
    [Export ("requiredStaticMethod")]
    void RequiredStaticMethod ();

    [Static]
    [Export ("optionalStaticMethod")]
    void OptionalStaticMethod ();

    [Abstract]
    [Static]
    [Export ("requiredStaticProperty")]
    IntPtr RequiredStaticProperty { get; set; }

    [Static]
    [Export ("optionalStaticProperty")]
    IntPtr OptionalStaticProperty { get; set; }
}
```

we're binding it like this:

```cs
[Protocol ("Protocol")]
public interface IProtocol : INativeObject {
    [Required]
    [Export ("requiredStaticMethod")]
    public static void RequiredStaticMethod<T> () where T: class, IProtocol { /* default implementation */ }

    [Optional]
    [Export ("optionalStaticMethod")]
    public static void OptionalStaticMethod<T> () where T: class, IProtocol { /* default implementation */ }

    [Property ("RequiredStaticProperty")]
    [Required]
    [Export ("requiredStaticProperty")]
    public static IntPtr GetRequiredStaticProperty<T> () where T: class, IProtocol { /* default implementation */ }
    
    [Property ("RequiredStaticProperty")]
    [Required]
    [Export ("setRequiredStaticProperty:")]
    public static void SetRequiredStaticProperty<T> (IntPtr value) where T: class, IProtocol { /* default implementation */ }
    
    [Property ("OptionalStaticProperty")]
    [Optional]
    [Export ("optionalStaticProperty")]
    public static IntPtr GetOptionalStaticProperty<T> () where T: class, IProtocol { /* default implementation */ }

    [Property ("OptionalStaticProperty")]
    [Optional]
    [Export ("setOptionalStaticProperty:")]
    public static void SetOptionalStaticProperty<T> (IntPtr value) where T: class, IProtocol { /* default implementation */ }
}
```

There are two points of interest here:

1. Each method has a generic type argument that specifies which type's static
   member should be called.
2. Properties have been turned into a pair of Get/Set methods - this is because
   properties can't have type arguments the way methods can.

Example consuming code:

```cs
public class MyClass : NSObject, IProtocol {}

// Call a required method:
IProtocol.RequiredStaticMethod<MyClass> ();
```

### Initializers

Given the following API definition:

```cs
[Protocol]
public interface Protocol {
    [Abstract]
    [Export ("init")]
    IntPtr Constructor ();

    [Export ("initWithValue:")]
    IntPtr Constructor (IntPtr value);

    [BindAs ("Create")]
    [Export ("initWithPlanet:")]
    IntPtr Constructor ();
}
```

we're binding it like this:

```cs
[Protocol ("Protocol")]
public interface IProtocol : INativeObject {
    [Required]
    [Export ("init")]
    public static T CreateInstance<T> () where T: class, IProtocol { /* default implementation */ }

    [Optional]
    [Export ("initWithValue:")]
    public static T CreateInstance<T> () where T: class, IProtocol { /* default implementation */ }

    [Optional]
    [Export ("initWithPlanet:")]
    public static T Create<T> () where T: class, IProtocol { /* default implementation */ }
}
```

We bind initializers as a static C# factory method that takes a generic type
argument specifying the type to instantiate.

### Coping with C# quirks

An interface member is not accesible from a variable typed as a class that
implements the interface. This means that a variable must be cast to the
interface before calling any members on it.

Example:

```cs
interface I {
    public void DoSomething () {}
}
class C : I {
}
class Program {
    static void Main ()
    {
        var c = new C ();
        c.DoSomething (); // this doesn't work: CS1061: 'C' does not contain a definition for 'DoSomething' and no accessible extension method 'DoSomething' accepting a first argument of type 'C' could be found (are you missing a using directive or an assembly reference?)
        ((I) c).DoSomething (); // this works
    }
}
```

We improve this by inlining all protocol members in any implementing class.


Given the following API definition:

```cs
[Protocol]
public interface Protocol {
    [Abstract]
    [Export ("requiredMethod")]
    void RequiredMethod ();

    [Export ("optionalMethod")]
    void OptionalMethod ();
}

[BaseType (NSObject)]
public interface MyObject : Protocol {
}
```

we're binding it like this:

```cs
[Protocol ("Protocol")]
public interface IProtocol : INativeObject {
    [Required]
    [Export ("requiredMethod")]
    public void RequiredMethod () { /* default implementation */ }

    [Optional]
    [Export ("optionalMethod")]
    public void OptionalMethod () { /* default implementation */ }
}

public class MyObject : NSObject, IProtocol {
    public virtual void RequiredMethod ()
    {
        ((IProtocol) this).RequiredMethod (); // just forward to the default implementation
    }

    public virtual void OptionalMethod ()
    {
        ((IProtocol) this).OptionalMethod (); // just forward to the default implementation
    }
}
```

## Backwards compatibility

### Pre-NET 8 extension class

Before .NET 8, we generated an extension class for optional members. This is no
longer needed, but we still need to do it for existing protocols (to not break
backwards compatibility).

The Protocol attribute used by the generator will have a new property to reflect
that the extension class is not needed anymore:

```cs
class ProtocolAttribute : Attribute
{
#if !XAMCORE_5_0 && GENERATOR
    public ProtocolAttribute (bool mustBeBackwardsCompatible = true)
    {
        this.MustBeBackwardsCompatible = mustBeBackwardsCompatible;
    }

    public bool MustBeBackwardsCompatible { get; set; }
#endif
}
```

This property will default to true (that way we don't have to change existing
code), and then the next time we can do an API break (the `XAMCORE_5_0` define),
we'll remove the property since we no longer need to be backwards compatible.

### Pre-NET 8 attributes

Before .NET 8, we generated a ProtocolMember attribute on the interface for all
members on the protocol, with enough information for our runtime to be able to
do the right thing.

This is no longer necessary, since we have all the required information on the
interface members.

We'll keep generating these attributes for protocols defined with
`MustBeBackwardsCompatible`.


## Notable consequences

Since every member in a C# interface binding a protocol will have a default
implementation, the compiler won't enforce required members anymore.

As a result, the IDE (at least Visual Studio for Mac) won't show a quick action
to implement these interface members. However, Intellisense will show up if you
do this:

```cs
public class MyObject : IProtocol {
    void IProtocol.[list of members on IProtocol will show up]
}
```
