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
        $rv = [ordered]@{}
        foreach ($config in $this.testConfigurations) {
            $label = $config.label
            $splitByPlatforms = $config.splitByPlatforms

            $vars = [ordered]@{}
            if ($splitByPlatforms -eq "True") {
                foreach ($platformConfig in $this.supportedPlatforms) {
                    $platformVars = [ordered]@{}
                    $platform = $platformConfig.platform
                    $platformVars["PLATFORM"] = $platform
                    $platformLabel = "$($label)_$($platform)"
                    $rv[$platformLabel] = $platformVars
                }
            } else {
                $vars["PLATFORM"] = "All"
                $rv[$label] = $vars
            }
        }

        return $rv | ConvertTo-Json
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

# export public functions, other functions are private and should not be used outside the module.
Export-ModuleMember -Function Get-TestConfiguration
