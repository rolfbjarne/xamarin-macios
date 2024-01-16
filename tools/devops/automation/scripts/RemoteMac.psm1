<#
    .SYNOPSIS
        Executes a command on a remote machine using scp
#>

function Invoke-SshCommand {
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

    ssh -v -i "$Env:ID_RSA_PATH" -o StrictHostKeyChecking=no "$RemoteUserName@$RemoteHost" @CommandArguments

    if ($ThrowIfError) {
        if ($LastExitCode -ne 0) {
            throw [System.Exception]::new("Failed to execute ssh command, exit code: $LastExitCode")
        }
    }
    Write-Host "sshenv command returned exit code: $LastExitCode"
}

<#
    .SYNOPSIS
        Uploads a file or directory to a remote machine using scp
#>
function Invoke-SshDownload {
    param (
        [Parameter(Mandatory)]
        [string]
        $RemoteHost,

        [Parameter(Mandatory)]
        [string]
        $RemoteUserName,

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

    scp -v -i "$Env:ID_RSA_PATH" -o StrictHostKeyChecking=no "$RemoteUserName@$RemoteHost":$Source $Target

    if ($ThrowIfError) {
        if ($LastExitCode -ne 0) {
            throw [System.Exception]::new("Failed to execute sshenv command, exit code: $LastExitCode")
        }
    }
    Write-Host "sshenv command returned exit code: $LastExitCode"
}

Export-ModuleMember -Function Invoke-SshCommand
Export-ModuleMember -Function Invoke-SshDownload
