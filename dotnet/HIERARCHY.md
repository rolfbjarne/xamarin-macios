# File hierarchy

## Microsoft._platform_.Workload

* WorkloadManifest.json: workload manifest that describes the different
  workloads for _platform_.
* WorkloadManifest.targets: imports Microsoft._platform_.Sdk if we're building
  for _platform_ (based on `TargetPlatformIdentifier`).

### Documentation

* [.NET Optional SDK
  Workloads](https://github.com/dotnet/designs/blob/main/accepted/2020/workloads/workloads.md)
* [Workload
  resolvers](https://github.com/dotnet/designs/blob/main/accepted/2020/workloads/workload-resolvers.md)
* [Workload manifests](https://github.com/dotnet/designs/pull/120)

## Microsoft._platform_.Sdk

* Sdk/AutoImport.props: imported into _every build_ that references
  Microsoft.NET.Sdk. It has strict restrictions on what it can do, to make
  sure it doesn't break builds for other SDKs.
* Sdk/Sdk.targets: imported by WorkloadManifest.targets (after the customer's
  csproj).

* Microsoft._platform_.Sdk.DefaultItems.props: imported into _every build_
  that references Microsoft.NET.Sdk (because it's imported by
  AutoImport.props). This file contains the default inclusion definitions
  specific to _platform_.
* Xamarin.Shared.Sdk.DefaultItems.props: imported into _every build_ that
  references Microsoft.NET.Sdk (because it's imported by *
  Microsoft._platform_.Sdk.DefaultItems.props). This file contains the default
  inclusion definitions identical for all platforms.

* Microsoft._platform_.Sdk.SupportedTargetPlatforms.targets: lists which
  versions of _platform_ are supported
* Microsoft._platform_.Sdk.targets: contains logic specific to _platform_.
* Microsoft._platform_.TargetFrameworkInference.targets: contains logic
  specific to _platform_.
* Xamarin.Shared.Sdk.DefaultItems.targets: contains logic to enable the
  default behavior we want.
* Xamarin.Shared.Sdk.TargetFrameworkInference.targets: some TargetFramework
  logic.
* Xamarin.Shared.Sdk.Versions.targets: declares various properties related to
  version information.
* Xamarin.Shared.Sdk.targets: all of the build logic shared between all
  platforms.

## Microsoft._platform_.Ref

Contains reference assemblies.

## Microsoft._platform_.Runtime.[runtimeIdentifier]

Contains implementation assemblies and native bits.
