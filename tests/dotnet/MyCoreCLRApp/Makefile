TOP=../../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

all-local::
	$(DOTNET6) build *.csproj /bl

run: all-local
	open bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app

run-bare: all-local
	bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp
