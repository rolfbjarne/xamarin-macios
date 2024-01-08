Import-Module "$Env:SYSTEM_DEFAULTWORKINGDIRECTORY/xamarin-macios/tools/devops/automation/scripts/MaciosCI.psd1"

$Env:DOTNET = "$BUILD_SOURCESDIRECTORY\xamarin-macios\tests\dotnet\Windows\bin\dotnet\dotnet.exe"

# Zip up all the binlogs into one file
Invoke-SshEnvCommand `
  -SourcesDirectory "$Env:BUILD_SOURCESDIRECTORY" `
  -DotNet "$Env:DOTNET" `
  -RemoteHost "$Env:MAC_AGENT_IP" `
  -RemoteUserName "builder" `
  -RemotePasswordEnvironmentVariable "XMA_PASSWORD" `
  -ThrowIfError $true `
  -- `
  "$Env:MAC_AGENT_BUILD_SOURCESDIRECTORY/xamarin-macios/tests/dotnet/Windows/collect-binlogs.sh" "$Env:MAC_AGENT_BUILD_SOURCESDIRECTORY/xamarin-macios" "$Env:MAC_AGENT_BUILD_SOURCESDIRECTORY/maccore"

# Copy the zip from the remote Mac to this machine
Invoke-SshEnvDownload `
  -SourcesDirectory "$Env:BUILD_SOURCESDIRECTORY" `
  -DotNet "$Env:DOTNET" `
  -RemoteHost "$Env:MAC_AGENT_IP" `
  -RemoteUserName "builder" `
  -RemotePasswordEnvironmentVariable "XMA_PASSWORD" `
  -ThrowIfError $true `
  -Source "/Users/builder/remote_build_testing/windows-remote-logs.zip" `
  -Target "$Env:BUILD_ARTIFACTSTAGINGDIRECTORY/windows-binlogs/windows-remote-logs.zip"
