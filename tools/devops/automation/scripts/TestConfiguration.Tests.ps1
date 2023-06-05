<#
TestConfiguration unit tests.
#>

Import-Module ./TestConfiguration -Force

Describe 'Get-TestConfiguration' {
    Context 'import' {
        It 'gets the right values' {
            $TestConfigurations = '{}'
            $SupportedPlatforms = '{}'

            $config = Get-TestConfiguration -TestConfigurations $TestConfigurations -SupportedPlatforms $SupportedPlatforms

            Write-Host "Test Config: $config"
        }

    }
}
