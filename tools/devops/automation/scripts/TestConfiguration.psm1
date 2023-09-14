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
        return @"
{
    'cecil': {
        LABEL: 'cecil',
        TESTS_LABELS: 'cecil-tests',
        STATUS_CONTEXT: 'cecil - all platforms',
        TEST_PREFIX: 'cecil',
        TEST_PLATFORM: ''
    },
    'dotnettests_iOS' {
        LABEL: 'dotnettests_iOS',
        TESTS_LABELS: 'dotnettests',
        STATUS_CONTEXT: 'dotnettests - iOS',
        TEST_PREFIX: 'dotnettests_iOS',
        TEST_PLATFORM: 'iOS'
    }
}
"@
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
    return $config.Create() | ConvertTo-Json -Compress
}

# export public functions, other functions are private and should not be used ouside the module.
Export-ModuleMember -Function Get-TestConfiguration
