TOP=../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

# This tells NuGet to use the nupkgs we're building locally,
# and to put any extracted packages in the 'packages' directory (to not clutter up ~/.nuget/packages)
NuGet.config: $(TOP)/NuGet.config Makefile $(TOP)/configure.inc
	$(Q) $(CP) $< $@.tmp
	$(Q) nuget sources add -Name local-dotnet-feed -Source $(abspath $(DOTNET_FEED_DIR)) -ConfigFile $@.tmp
ifdef CUSTOM_DOTNET
	$(Q) nuget sources add -Name dev-runtime-feed -Source $(abspath $(CUSTOM_DOTNET_PATH)/packages/Release/Shipping) -ConfigFile $@.tmp
endif
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

export MSBuildEnableWorkloadResolver=true

compare compare-size: $(TARGETS)
	cd size-comparison && git clean -xfdq
	time $(MAKE) build-oldnet
	time $(MAKE) build-dotnet
	$(MAKE) report

report:
	cd ../../tools/app-compare && dotnet run $(abspath size-comparison/MySingleView/oldnet/bin/iPhone/Release/MySingleView.app) $(abspath size-comparison/MySingleView/dotnet/bin/iPhone/Release/net6.0-ios/ios-arm64/MySingleView.app) > $(CURDIR)/report.md
	gist $(CURDIR)/report.md

COMMON_ARGS=/p:Platform=iPhone /p:Configuration=Release
build-oldnet:
	$(SYSTEM_MSBUILD) $(XBUILD_VERBOSITY) size-comparison/MySingleView/oldnet/MySingleView.csproj $(COMMON_ARGS) /bl:$@.binlog

build-dotnet: $(TARGETS)
	$(DOTNET6) build size-comparison/MySingleView/dotnet/MySingleView.csproj --runtime ios-arm64 $(COMMON_ARGS) /bl:$@.binlog

run-dotnet: build-dotnet
	$(DOTNET6) build -t:Run size-comparison/MySingleView/dotnet/MySingleView.csproj

build-mysingleview:
	$(DOTNET6) build MySingleView/*.csproj

run-mysingleview:
	$(DOTNET6) build -t:Run MySingleView/*.csproj /p:_DeviceName=:v2:udid=03B4B310-6A00-4218-BA15-31312D6707DA /v:diag

clean-start: $(TARGETS)
	rm -f *.binlog
	rm -Rf $(TOP)/_build $(TOP)/_ios-build $(TOP)/_mac-build
	rm -f $(DOTNET6_DIR)/sdk-manifests/$(DOTNET6_VERSION_BAND)/Microsoft.NET.Workload.*
	cd $(TOP)/dotnet && git clean -xfd
	cd $(TOP)/tests/monotouch-test/dotnet && git clean -xfd
	cd $(TOP)/tests/EmbeddedResources/dotnet && git clean -xfd
	cd $(TOUCH_UNIT_PATH) && git clean -xfd
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) all -j8
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) install -j8
	$(MAKE) copy-stuff

copy-stuff:
	$(CP) -c NuGet.config global.json $(TOP)/tests/monotouch-test/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/tests/fsharplibrary/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/tests/EmbeddedResources/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/tests/bindings-test/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/external/Touch.Unit/Touch.Client/dotnet
	rm -Rf packages $(TOP)/tests/monotouch-test/dotnet/macOS/packages

dotnet6:
	@echo $(abspath $(DOTNET6))

# Deprecated targets for monotouch-test
run-monotouch-test-perftest monotouch-test-perftest lldb-coreclr launch-lldb run-lldb run-monotouch-test-with-coreclr run-monotouch-test-with-mono run just-build-coreclr just-build-mono just-build build-monotouch-test-with-coreclr build-monotouch-test-with-mono build-monotouch-test:
	@echo "ℹ️  The target $@ has moved to the monotouch-test subdirectory. Go run 'make $@' there instead.  ℹ️"
	@sleep 3
	$(MAKE) -C monotouch-test $@
