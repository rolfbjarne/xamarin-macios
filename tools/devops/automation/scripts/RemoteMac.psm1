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

        [Parameter(Mandatory)]
        [bool]
        $ThrowIfError,

        [Parameter(Mandatory, ValueFromRemainingArguments)]
        [string[]]
        $CommandArguments
    )

    $cmd = [System.String]::Join(" ", $CommandArguments)

    Write-Host "Command is: $cmd"
    Write-Host "There are $($CommandArguments.Length) arguments in the command."

    & $DotNet `
      run `
      --project "$SourcesDirectory\xamarin-macios\tools\sshenv\sshenv.csproj" `
      -- `
      --host $RemoteHost `
      --user $RemoteUserName `
      --penv $RemotePasswordEnvironmentVariable `
      @CommandArguments

    if ($ThrowIfError) {
        if ($LastExitCode -ne 0) {
            throw [System.Exception]::new("Failed to execute sshenv command, exit code: $LastExitCode")
        }
    }
    Write-Host "sshenv command returned exit code: $LastExitCode"
}

<#
    .SYNOPSIS
        Uploads a file or directory to a remote machine using sshenv
#>
function Invoke-SshEnvDownload {
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
        [bool]
        $ThrowIfError,

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
      --mode download `
      --source $Source `
      --target $Target

    if ($ThrowIfError) {
        if ($LastExitCode -ne 0) {
            throw [System.Exception]::new("Failed to execute sshenv command, exit code: $LastExitCode")
        }
    }
    Write-Host "sshenv command returned exit code: $LastExitCode"
}

Export-ModuleMember -Function Invoke-SshEnvCommand
Export-ModuleMember -Function Invoke-SshEnvDownload
