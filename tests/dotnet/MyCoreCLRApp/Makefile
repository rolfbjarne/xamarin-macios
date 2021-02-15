TOP=../../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

all-local::
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) -j 8 all || (say core c l r build failed; exit 1)
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) -j 8 install || (say core c l r install failed; exit 1)
	rm -Rf ../packages
	git clean -xfd
	$(DOTNET6) build *.csproj /bl /v:diag && say core c l r test built successfully || (say core c l r test failed; exit 1)

run: all-local
	bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp

run-bare:
	bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp

run-lldb:
	lldb -- bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp --one-line run