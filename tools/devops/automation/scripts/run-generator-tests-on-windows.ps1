# Dump the environment to see what we're working with.
& "$(System.DefaultWorkingDirectory)\xamarin-macios\tools\devops\automation\scripts\show_env.ps1"

# Set a few variables
$Env:DOTNET = "$(Build.SourcesDirectory)\xamarin-macios\tests\dotnet\Windows\bin\dotnet\dotnet.exe"
$Env:DOTNET_DIR = "$(Build.SourcesDirectory)\xamarin-macios\tests\dotnet\Windows\bin\dotnet\"
$Env:TESTS_USE_SYSTEM = "1"

# Compute the <platform>_NUGET_VERSION_NO_METADATA variables and set them in the environment
$configurationDotNetPlatforms = $Env:CONFIGURATION_DOTNET_PLATFORMS
$dotnetPlatforms = $configurationDotNetPlatforms.Split(' ', [StringSplitOptions]::RemoveEmptyEntries)
foreach ($platform in $dotnetPlatforms) {
  $manifestPath = "$(Build.SourcesDirectory)\artifacts\AssetManifests\$($platform)\AssetManifest.xml"
  $productVersion = Select-Xml -Path "$manifestPath" -XPath "/Build/Package[@Id='Microsoft.$($platform).Sdk']/@Version" | ForEach-Object { $_.Node.Value }
  $variableName = "$($platform.ToUpper())_NUGET_VERSION_NO_METADATA"
  [Environment]::SetEnvironmentVariable($variableName, $productVersion)
  Write-Host "$variableName = $productVersion"
}

# Tell the tests how they can execute the C# compiler
$csc = Get-ChildItem "$(Build.SourcesDirectory)\xamarin-macios\tests\dotnet\Windows\bin\dotnet" -Include csc.dll -Recurse -File | %{$_.FullName}
$Env:DOTNET_CSC_COMMAND = "$Env:DOTNET exec $csc".Replace("\", "/")
Write-Host "DOTNET_CSC_COMMAND: $Env:DOTNET_CSC_COMMAND"

# Tell the tests where the BCL is
$Env:DOTNET_BCL_DIR = Get-ChildItem "$(Build.SourcesDirectory)\xamarin-macios\tests\dotnet\Windows\bin\dotnet\packs\Microsoft.NETCore.App.Ref" -Include System.dll -Recurse -File | %{$_.DirectoryName}
Write-Host "DOTNET_BCL_DIR: $Env:DOTNET_BCL_DIR"

# Finally we can run the tests
& $(Build.SourcesDirectory)\xamarin-macios\tests\dotnet\Windows\bin\dotnet\dotnet.exe `
    test `
    "$(Build.SourcesDirectory)/xamarin-macios/tests/bgen/bgen-tests.csproj" `
    "--results-directory:$(Build.SourcesDirectory)/xamarin-macios/jenkins-results/windows/bgen-tests/" `
    "--logger:console;verbosity=detailed" `
    "--logger:trx;LogFileName=$(Build.SourcesDirectory)/xamarin-macios/jenkins-results/windows/bgen-tests/results.trx" `
    "--logger:html;LogFileName=$(Build.SourcesDirectory)/xamarin-macios/jenkins-results/windows/bgen-tests/results.html" `
    "-bl:$(Build.SourcesDirectory)/xamarin-macios/jenkins-results/windows/bgen-tests/results.binlog"
