class APIScanConfiguration {
    [string[]] $enabledPlatforms

    APIScanConfiguration (
        [string[]] $enabledPlatforms) {
        $this.enabledPlatforms = $enabledPlatforms
    }

    [string] Create() {
        $vars = [ordered]@{}
        Write-Host "enabledPlatforms: $($this.enabledPlatforms)"

        foreach ($platform in $this.enabledPlatforms) {
            # each platform has its version in an environment variable, we need to get it, this
            # could have been inlined when assigning the dictionary but we want to be cleaner.
            $platformVersionEnvVar = "CONFIGURE_PLATFORMS_$($platform.toUpper().Trim())_NUGET_OS_VERSION"
            $platformVersion = (Get-Item -Path env:$platformVersionEnvVar).Value
            # dictionary with the secrets needed by each matrix
            $platformVars = [ordered]@{
                CLIENT_ID = $Env:API_SCAN_CLIENT_ID;
                TENANT = $Env:API_SCAN_TENANT;
                SECRET = "`$(API_SCAN_SECRET_$($platform.ToUpper().Trim()))";
                PLATFORM = $platform.ToUpper().Trim();
                VERSION = $platformVersion.Trim();
            }
            $vars[$platform] = $platformVars
        }

        return $vars | ConvertTo-Json
    }

}

function Get-APIScanConfiguration {
    param
    (
        [Parameter(Mandatory)]
        [string]
        [AllowEmptyString()]
        $EnabledPlatforms
    )

    $arrEnabledPlatforms = -split $EnabledPlatforms
    $config = [APIScanConfiguration]::new($arrEnabledPlatforms)
    return $config.Create()
}

# export public functions, other functions are private and should not be used outside the module.
Export-ModuleMember -Function Get-APIScanConfiguration
