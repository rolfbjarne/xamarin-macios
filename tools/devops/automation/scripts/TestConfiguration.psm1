class TestConfiguration {
    [object] $testConfigurations
    [object] $supportedPlatforms

    TestConfiguration (
        [object] $testConfigurations,
        [object] $supportedPlatforms) {
        $this.testConfigurations = $testConfigurations
        $this.supportedPlatforms = $supportedPlatforms
    }

    [string] Create() {
        return "?"
    }
}

function Get-TestConfiguration {
    param
    (
        [Parameter(Mandatory)]
        [string]
        $TestConfigurations,

        [Parameter(Mandatory)]
        [string]
        $SupportedPlatforms
    )

    $objTestConfigurations = ConvertFrom-Json -InputObject $TestConfigurations
    $objSupportedPlatforms = ConvertFrom-Json -InputObject $SupportedPlatforms

    $config = [TestConfiguration]::new($objTestConfigurations, $objSupportedPlatforms)
    return $config.Create()
}

# export public functions, other functions are private and should not be used ouside the module.
Export-ModuleMember -Function Get-TestConfiguration
