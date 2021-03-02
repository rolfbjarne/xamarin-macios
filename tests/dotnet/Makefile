TOP=../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

# This tells NuGet to use the nupkgs we're building locally,
# and to put any extracted packages in the 'packages' directory (to not clutter up ~/.nuget/packages)
NuGet.config: $(TOP)/NuGet.config Makefile
	$(Q) $(CP) $< $@.tmp
	$(Q) nuget sources add -Name local-dotnet-feed -Source $(abspath $(DOTNET_FEED_DIR)) -ConfigFile $@.tmp
	$(Q) nuget config -Set globalPackagesFolder=$(abspath $(CURDIR)/packages) -Config $@.tmp
	$(Q) nuget config -Set repositorypath=$(abspath $(CURDIR)/packages) -Config $@.tmp
	$(Q) mv $@.tmp $@

# This tells NuGet to use the exact same dotnet version we've configured in Make.config
global.json: $(TOP)/global6.json
	$(CP) $< $@

../bgen/global.json: global.json
	$(Q) $(CP) $< $@

../bgen/NuGet.config: NuGet.config
	$(Q) $(CP) $< $@

TARGETS += \
	NuGet.config \
	global.json \
	../bgen/NuGet.config \
	../bgen/global.json \

# Example TEST_FILTER:
#    TEST_FILTER="--filter FullyQualifiedName~BuildMyCocoaApp"
# Docs: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test#filter-option-details
run-unit-tests:
	cd UnitTests && $(DOTNET) test DotNetUnitTests.csproj $(TEST_FILTER)

all-local:: $(TARGETS)

build-mysingleview:
	$(DOTNET6) build MySingleView/*.csproj

run-mysingleview:
	$(DOTNET6) build -t:Run MySingleView/*.csproj /p:_DeviceName=:v2:udid=03B4B310-6A00-4218-BA15-31312D6707DA /v:diag

export XAMARIN_RUNTIME=CoreCLR

build-monotouch-test-with-mono: $(TARGETS)
	rm -Rf $(TOP)/_build $(TOP)/_ios-build $(TOP)/_mac-build
	cd $(TOP)/dotnet && git clean -xfd
	cd $(TOP)/tests/monotouch-test/dotnet && git clean -xfd
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) all -j8
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) install -j8
	$(CP) -c NuGet.config global.json $(TOP)/tests/monotouch-test/dotnet/macOS
	cd $(TOP)/tests/monotouch-test/dotnet/macOS && rm -Rf bin obj
	rm -Rf packages $(TOP)/tests/monotouch-test/dotnet/macOS/packages
	$(DOTNET6) build $(TOP)/tests/monotouch-test/dotnet/macOS/monotouch-test.csproj /bl:$@.binlog $(BUILD_PARAMETERS)
	$(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/Debug/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest)

build-monotouch-test-with-coreclr: $(TARGETS)
	$(MAKE) build-monotouch-test-with-mono BUILD_PARAMETERS=/p:XamarinRuntime=CoreCLR

run:
	$(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/Debug/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest)

run-lldb:
	lldb -- $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/Debug/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest)

launch-lldb:
	lldb -o "process launch -s" -o "process handle -s false SIGUSR1 SIGUSR2" -- $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/Debug/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest)
