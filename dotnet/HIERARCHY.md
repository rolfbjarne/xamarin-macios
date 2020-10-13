# File hierarchy

## Microsoft.[platform].Workload

* WorkloadManifest.json: workload manifest that describes the different workloads for [platform].
* WorkloadManifest.targets: imports Microsoft.[platform].Sdk if we're building for [platform] (based on `TargetPlatformIdentifier`).

### Documentation

* [.NET Optional SDK Workloads](https://github.com/dotnet/designs/blob/main/accepted/2020/workloads/workloads.md)
* [Workload resolvers](https://github.com/dotnet/designs/blob/main/accepted/2020/workloads/workload-resolvers.md)
* [Workload manifests](https://github.com/dotnet/designs/pull/120)

## Microsoft.[platform].Sdk

* Sdk/AutoImport.props: imported into _every build_ that references Microsoft.NET.Sdk. It has struct restrictions on what it can do, to make sure it doesn't break builds for other sdks.
* Sdk/Sdk.targets: imported after the customer's csproj.
* \+ other files

## Microsoft.[platform].Ref

Contains reference assemblies.

## Microsoft.[platform].Runtime.[runtimeIdentifier]

Contains implementation assemblies and native bits.
