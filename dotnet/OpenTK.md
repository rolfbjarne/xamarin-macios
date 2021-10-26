# Types in the OpenTK namespace

We want to remove types from the OpenTK namespace, and these types fall in three categories:

1. Types we can replace with an existing .NET type
2. Types that don't have an equivalent .NET type, so we have to come up with an alternative type.
3. Types we don't need, so we can remove them.

One important question is which namespace to use for 2. Options:

1. Keep using `OpenTK`. This is not an option, because that's exactly what we're trying to move away from.
2. `ObjCRuntime`: not really very math-like, and this namespace shouldn't become a catch-all for everything that doesn't fit elsewhere either.
3. `CoreNumerics`: A mix of Apple's Core* frameworks with System.Numerics.
4. `CoreMath`: same as 3.
5. Something else? Unfortunately there's no good match in Apple's frameworks.

Ref: https://github.com/xamarin/xamarin-macios/pull/2571
Ref: https://bugzilla.xamarin.com/show_bug.cgi?id=58599

## Different type

The following types have an equivalent in .NET, so the proposal is to use that type instead:

| OpenTK type       | .NET type                            |
| ----------------- | ------------------------------------ |
| OpenTK.Matrix4    | System.Numerics.Matrix4x4            |
| OpenTK.Quaternion | System.Numerics.Quaternion           |
| OpenTK.Vector2    | System.Numerics.Vector2              |
| OpenTK.Vector2d   | System.Numerics.Vector&lt;double&gt; |
| OpenTK.Vector2i   | System.Numerics.Vector&lt;int&gt;    |
| OpenTK.Vector3    | System.Numerics.Vector3              |
| OpenTK.Vector3d   | System.Numerics.Vector&lt;double&gt; |
| OpenTK.Vector3i   | System.Numerics.Vector&lt;int&gt;    |
| OpenTK.Vector4    | System.Numerics.Vector4              |
| OpenTK.Vector4d   | System.Numerics.Vector&lt;double&gt; |
| OpenTK.Vector4i   | System.Numerics.Vector&lt;int&gt;    |

## Different namespace

The following OpenTK types have no equivalent in .NET, so the proposal is to copy the OpenTK implementation, but use a different namespace.

* OpenTK.Matrix2
* OpenTK.Matrix3
* OpenTK.Matrix4d
* OpenTK.Quaterniond

The following are types that we created ourselves, but put in the OpenTK namespace.

* OpenTK.NMatrix4d
* OpenTK.NMatrix2
* OpenTK.NMatrix3
* OpenTK.NMatrix4x3
* OpenTK.NMatrix4
* OpenTK.NVector3d
* OpenTK.NVector3

## Removed types

??	OpenTK.MathHelper : System.Object (public abstract beforefieldinit sealed) 14 methods, 10 fields, 0 properties, 0 events, False nested types

The following types are not used by any other API, so they will be removed.

* OpenTK.Box2
* OpenTK.Functions
* OpenTK.Half
* OpenTK.Vector2h
* OpenTK.Vector3h
* OpenTK.Vector4h
* OpenTK.BezierCurve
* OpenTK.BezierCurveCubic
* OpenTK.BezierCurveQuadric
