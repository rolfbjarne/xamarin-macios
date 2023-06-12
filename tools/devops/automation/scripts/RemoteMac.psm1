<#
    .SYNOPSIS
        Installs .NET on a remote Mac, together with our workloads.
#>
function Install-DotNetOnRemoteMac {
    param (
        [Parameter(Mandatory)]
        [string]
        $SourcesDirectory,

        [Parameter(Mandatory)]
        [string]
        $DotNet,

        [Parameter(Mandatory)]
        [string]
        $UploadDirectory,

        [Parameter(Mandatory)]
        [string]
        $RemoteHost,

        [Parameter(Mandatory)]
        [string]
        $RemoteUserName,

        [Parameter(Mandatory)]
        [string]
        $RemotePasswordEnvironmentVariable
    )

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      ls -la "/Users/$RemoteUserName"

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      rm -rf "/Users/$RemoteUserName/remote_build_testing"

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      ls -la "/Users/$RemoteUserName"

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      --mode upload `
      --source $UploadDirectory `
      --target "/Users/$RemoteUserName/remote_build_testing"

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      "/Users/$RemoteUserName/remote_build_testing/install-on-mac.sh"

    return
}

<#
    .SYNOPSIS
        Creates a directory of files needed to install workloads on a remote mac.
#>
function New-RemoteMacInstallDirectory {
    param (
        [Parameter(Mandatory)]
        [string]
        $SourcesDirectory,

        [Parameter(Mandatory)]
        [string]
        $ArtifactsDirectory
    )

    $uploadDirectory = "$ArtifactsDirectory/remote-mac-upload"
    New-Item -Path $uploadDirectory -ItemType "directory"
    New-Item -Path "$uploadDirectory/nupkg" -ItemType "directory"

    Copy-Item -Path "$SourcesDirectory/xamarin-macios/NuGet.config" -Destination "$uploadDirectory/NuGet.config"
    Copy-Item -Path "$SourcesDirectory/xamarin-macios/global.json" -Destination "$uploadDirectory/global.json"
    Copy-Item -Path "$SourcesDirectory/xamarin-macios/tests/dotnet/Windows/install-on-mac.sh" -Destination "$uploadDirectory/install-on-mac.sh"
    Copy-Item -Path "$ArtifactsDirectory/WorkloadRollback/WorkloadRollback.json" -Destination "$uploadDirectory/WorkloadRollback.json"
    Copy-Item -Path "$ArtifactsDirectory/build-configuration/configuration.json" -Destination "$uploadDirectory/configuration.json"
    Copy-Item -Path "$ArtifactsDirectory/not-signed-package/*.nupkg" -Destination "$uploadDirectory/nupkg"

    # Get-ChildItem -Path $uploadDirectory | Write-Host

    return $uploadDirectory
}

Export-ModuleMember -Function New-RemoteMacInstallDirectory
Export-ModuleMember -Function Install-DotNetOnRemoteMac
