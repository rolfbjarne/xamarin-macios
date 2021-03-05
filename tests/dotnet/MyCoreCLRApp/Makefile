TOP=../../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

export XAMARIN_RUNTIME=CoreCLR

all-local::
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) -j 8 all || (say core c l r build failed & exit 1)
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) -j 8 install || (say core c l r install failed & exit 1)
	rm -Rf ../packages
	$(MAKE) build

build:
	git clean -xfd
	if $(DOTNET6) build *.csproj /bl /v:diag; then \
		say core c l r test built successfully & \
	else \
		say core c l r test failed; \
		exit 1; \
	fi

run: all-local
	$(MAKE) run-bare

run-bare:
	bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp || EC=$$?; \
	if [[ "x$$EC" == "x139" || "x$$EC" == "x134" ]]; then \
		say "dotnet test app crashed, re-launching with lldb." & \
		echo "Re-launching with lldb since it crashed"; \
		$(MAKE) run-lldb; \
	else \
		exit $$EC; \
	fi \

run-single:
	bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp

run-lldb:
	lldb --one-line run --one-line bt -- bin/Debug/net6.0-macos/osx-x64/MyCoreCLRApp.app/Contents/MacOS/MyCoreCLRApp
