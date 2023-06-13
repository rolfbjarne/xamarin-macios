<#
    .SYNOPSIS
        Executes a command on a remote machine using sshenv
#>

function Invoke-SshEnvCommand {
    param (
        [Parameter(Mandatory)]
        [string]
        $SourcesDirectory,

        [Parameter(Mandatory)]
        [string]
        $DotNet,

        [Parameter(Mandatory)]
        [string]
        $RemoteHost,

        [Parameter(Mandatory)]
        [string]
        $RemoteUserName,

        [Parameter(Mandatory)]
        [string]
        $RemotePasswordEnvironmentVariable,

        [Parameter(Mandatory, ValueFromRemainingArguments)]
        [string[]]
        $CommandArguments
    )

    $cmd = [System.String]::Join(" ", $CommandArguments)

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      $cmd
    if ($LastExitCode -ne 0) {
        throw [System.Exception]::new("Failed to execute sshenv command")
    }
}

<#
    .SYNOPSIS
        Uploads a file or directory to a remote machine using sshenv
#>
function Invoke-SshEnvUpload {
    param (
        [Parameter(Mandatory)]
        [string]
        $SourcesDirectory,

        [Parameter(Mandatory)]
        [string]
        $DotNet,

        [Parameter(Mandatory)]
        [string]
        $RemoteHost,

        [Parameter(Mandatory)]
        [string]
        $RemoteUserName,

        [Parameter(Mandatory)]
        [string]
        $RemotePasswordEnvironmentVariable,

        [Parameter(Mandatory)]
        [string]
        $Source,

        [Parameter(Mandatory)]
        [string]
        $Target
    )

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      --mode upload `
      --source $Source `
      --target $Target `
    if ($LastExitCode -ne 0) {
        throw [System.Exception]::new("Failed to execute sshenv upload")
    }
}

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

    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable ls -la "/Users/$RemoteUserName"
    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable rm -rf "/Users/$RemoteUserName/remote_build_testing"
    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable ls -la "/Users/$RemoteUserName"

    Invoke-SshEnvUpload  -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable -Source $UploadDirectory -Target "/Users/$RemoteUserName/remote_build_testing"

    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable ls -la "/Users/$RemoteUserName/remote_build_testing"
    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable "chmod +x /Users/$RemoteUserName/remote_build_testing/install-on-mac.sh"
    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable "/Users/$RemoteUserName/remote_build_testing/install-on-mac.sh"
    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable ls -la "/Users/$RemoteUserName"
    Invoke-SshEnvCommand -DotNet $DotNet -RemoteHost $RemoteHost -RemoteUserName $RemoteUserName -RemotePasswordEnvironmentVariable $RemotePasswordEnvironmentVariable ls -la "/Users/$RemoteUserName/remote_build_testing"
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
