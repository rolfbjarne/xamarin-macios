<#
System scripts unit tests. 
#>

Import-Module ./RemoteMac.psm1 -Force

Describe 'Invoke-SshEnvCommand' {
    Context 'default' {
        It 'tries to do the right thing' {
            $sourcesDirectory = [System.Environment]::CurrentDirectory
            while (-Not (Test-Path -Path "$sourcesDirectory/.git")) {
                $sourcesDirectory = [System.IO.Path]::GetDirectoryName($sourcesDirectory)
            }
            $sourcesDirectory = [System.IO.Path]::GetDirectoryName($sourcesDirectory)

            $SharedArguments = @{
                SourcesDirectory = $SourcesDirectory
                DotNet = "donut"
                RemoteHost = "127.0.0.1"
                RemoteUserName = "$Env:USER"
                RemotePasswordEnvironmentVariable = "USER"
            }

            Invoke-SshEnvCommand @SharedArguments ls -la
        }
    }
}
