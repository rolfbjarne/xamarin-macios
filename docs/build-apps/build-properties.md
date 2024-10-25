---
title: .NET for iOS, Mac Catalyst, macOS, and tvOS Build Properties
description: .NET for iOS, Mac Catalyst, macOS, and tvOS Build Properties
ms.date: 09/19/2024
---

# Build Properties

MSBuild properties control the behavior of the
[targets](build-targets.md).
They're specified within the project file, for example **MyApp.csproj**, within
an MSBuild PropertyGroup.

## AppIcon

The `AppIcon` item group can be used to specify an app icon for the app.

The value of the property must point to the filename of an `.appiconset` (for
iOS, macOS and Mac Catalyst) or `.brandassets` (for tvOS) image resource
inside an asset catalog.

Example:

```xml
<PropertyGroup>
    <!-- The value to put in here for the "Resources/MyImages.xcassets/MyAppIcon.appiconset" resource would be "MyAppIcon" -->
    <AppIcon>MyAppIcon</AppIcon>
</PropertyGroup>
```

See also:

* The [AlternateAppIcon](build-items.md#AlternateAppIcon) item group.
* The [IncludeAllAppIcons](#IncludeAllAppIcons) property.

## DittoPath

The full path to the `ditto` executable.

The default behavior is to use `/usr/bin/ditto`.

## IncludeAllAppIcons

Set the `IncludeAllAppIcons` property to true to automatically include all app
icons from all asset catalogs in the app.

Example:

```xml
<PropertyGroup>
    <IncludeAllAppIcons>true</IncludeAllAppIcons>
</PropertyGroup>
```

See also:

* The [AlternateAppIcon](build-items.md#AlternateAppIcon) item group.
* The [AppIcon](#AppIcon) property.
>>>>>>> 085031cbc4 ([msbuild] Add support for inlucing alternate app icons in the compiled asset catalog.)

## MaciOSPrepareForBuildDependsOn

A semi-colon delimited property that can be used to extend the build process.
MSBuild targets added to this property will execute early in the build for both
application and library project types. This property is empty by default.

Example:

```xml
<PropertyGroup>
  <MaciOSPrepareForBuildDependsOn>MyCustomTarget</MaciOSPrepareForBuildDependsOn>
</PropertyGroup>

<Target Name="MyCustomTarget" >
  <Message Text="Running target: 'MyCustomTarget'" Importance="high"  />
</Target>
```

This property was introduced in .NET 9.

## MetalLibPath

The full path to the `metallib` tool (the Metal Linker).

The default behavior is to use `xcrun metallib`.

## MetalPath

The full path to the Metal compiler.

The default behavior is to use `xcrun metal`.
