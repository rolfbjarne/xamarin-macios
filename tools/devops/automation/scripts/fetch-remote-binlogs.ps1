Import-Module "$Env:SYSTEM_DEFAULTWORKINGDIRECTORY/xamarin-macios/tools/devops/automation/scripts/MaciosCI.psd1"

# Zip up all the binlogs into one file
Invoke-SshCommand `
  -RemoteHost "$Env:MAC_AGENT_IP" `
  -RemoteUserName "$Env:MAC_AGENT_USER" `
  -ThrowIfError $true `
  -- `
  "$Env:MAC_AGENT_BUILD_SOURCESDIRECTORY/xamarin-macios/tests/dotnet/Windows/collect-binlogs.sh"

# Copy the zip from the remote Mac to this machine
Invoke-SshDownload `
  -RemoteHost "$Env:MAC_AGENT_IP" `
  -RemoteUserName "$Env:MAC_AGENT_USER" `
  -ThrowIfError $true `
  -Source "/Users/$Env:MAC_AGENT_USER/remote_build_testing/windows-remote-logs.zip" `
  -Target "$Env:BUILD_ARTIFACTSTAGINGDIRECTORY/windows-binlogs/windows-remote-logs.zip"
