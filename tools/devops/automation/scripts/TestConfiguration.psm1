class TestConfiguration {
    [object] $testConfigurations
    [object] $supportedPlatforms
    [string] $testsLabels
    [string] $statusContext
    [string] $testPrefix

    TestConfiguration (
        [object] $testConfigurations,
        [object] $supportedPlatforms,
        [string] $testsLabels,
        [string] $statusContext,
        [string] $testPrefix) {
        $this.testConfigurations = $testConfigurations
        $this.supportedPlatforms = $supportedPlatforms
        $this.testsLabels = $testsLabels
        $this.statusContext = $statusContext
        $this.testPrefix = $testPrefix
    }

    [string] Create() {
        $rv = [ordered]@{}
        foreach ($config in $this.testConfigurations) {
            $label = $config.label
            $underscoredLabel = $label.Replace('-','_')
            $splitByPlatforms = $config.splitByPlatforms

            $vars = [ordered]@{}
            # set common variables
            $vars["LABEL"] = $label
            $vars["TESTS_LABELS"] = "$($this.testsLabels),run-$($label)-tests"
            if ($splitByPlatforms -eq "True") {
                foreach ($platformConfig in $this.supportedPlatforms) {
                    $platform = $platformConfig.platform

                    $runThisPlatform = $false
                    if ($config.containsDotNetTests -and $platformConfig.isDotNetPlatform) {
                        $runThisPlatform = $true
                    } elseif ($config.containsLegacyTests -and $platformConfig.isLegacyPlatform) {
                        $runThisPlatform = $true
                    }
                    if (!$runThisPlatform) {
                        Write-Host "Running $($platform): $($runThisPlatform)"
                        continue
                    }

                    # create a clone of the general dictionary
                    $platformVars = [ordered]@{}
                    foreach ($pair in $vars.GetEnumerator()) {
                        $platformVars[$pair.Key] = $pair.Value
                    }
                    # set platform-specific variables
                    $platformVars["STATUS_CONTEXT"] = "$($this.statusContext) - $($label) - $($platform)"
                    $platformVars["TEST_PREFIX"] = "$($this.testPrefix)$($underscoredLabel)_$($platform)"
                    if ($platform -eq "Multiple") {
                        $platformVars["TEST_PLATFORM"] = ""
                        $platformVars["TEST_CATEGORY"] = "Multiple"
                    } else {
                        $platformVars["TEST_PLATFORM"] = $platform
                    }
                    $platformLabel = "$($label)_$($platform)"
                    $rv[$platformLabel] = $platformVars
                }
            } else {
                # set non-platform specific variables
                $vars["STATUS_CONTEXT"] = "$($this.statusContext) - $($label)"
                $vars["TEST_PREFIX"] = "$($this.testPrefix)$($underscoredLabel)"
                $vars["TEST_PLATFORM"] = ""
                $rv[$label] = $vars
            }
        }

        Write-Host $rv

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
        $SupportedPlatforms,

        [string]
        $TestsLabels,

        [string]
        $StatusContext,

        [string]
        $TestPrefix
    )

    $objTestConfigurations = ConvertFrom-Json -InputObject $TestConfigurations
    $objSupportedPlatforms = ConvertFrom-Json -InputObject $SupportedPlatforms

    $config = [TestConfiguration]::new($objTestConfigurations, $objSupportedPlatforms, $TestsLabels, $StatusContext, $TestPrefix)
    return $config.Create()
}

# export public functions, other functions are private and should not be used outside the module.
Export-ModuleMember -Function Get-TestConfiguration
