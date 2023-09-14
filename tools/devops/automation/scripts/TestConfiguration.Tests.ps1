<#
TestConfiguration unit tests.
#>

Import-Module ./TestConfiguration -Force

Describe 'Get-TestConfiguration' {
    Context 'import' {
        It 'gets the right values' {
            $TestConfigurations = @"
[
  {
    "label": "cecil",
    "splitByPlatforms": "False"
  },
  {
    "label": "dotnettests",
    "splitByPlatforms": "True"
  }
]
"@

            $SupportedPlatforms = @"
[
  {
    "platform": "iOS",
    "conditionVariable": "INCLUDE_IOS",
    "isDotNetPlatform": "True",
    "isLegacyPlatform": "True"
  },
  {
    "platform": "macOS",
    "conditionVariable": "INCLUDE_MAC",
    "isDotNetPlatform": "True",
    "isLegacyPlatform": "True"
  },
  {
    "platform": "tvOS",
    "conditionVariable": "INCLUDE_TVOS",
    "isDotNetPlatform": "True",
    "isLegacyPlatform": "True"
  },
  {
    "platform": "watchOS",
    "conditionVariable": "INCLUDE_WATCH",
    "isDotNetPlatform": "False",
    "isLegacyPlatform": "True"
  },
  {
    "platform": "MacCatalyst",
    "conditionVariable": "INCLUDE_DOTNET_MACCATALYST",
    "isDotNetPlatform": "True",
    "isLegacyPlatform": "False"
  },
  {
    "platform": "All",
    "conditionVariableDotNet": "All",
    "conditionVariableLegacy": "All",
    "isDotNetPlatform": "True",
    "isLegacyPlatform": "True"
  }
]
"@

            $config = Get-TestConfiguration -TestConfigurations $TestConfigurations -SupportedPlatforms $SupportedPlatforms

            Write-Host "Test Config: $config"
        }

    }
}
