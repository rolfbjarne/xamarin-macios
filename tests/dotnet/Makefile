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

build-mysingleview:
	$(DOTNET6) build MySingleView/*.csproj

run-mysingleview:
	$(DOTNET6) build -t:Run MySingleView/*.csproj /p:_DeviceName=:v2:udid=03B4B310-6A00-4218-BA15-31312D6707DA /v:diag

LOGFILENAME:=$(HOME)/test/monotouchtest-timings/$(shell date +%Y-%m-%d--%H:%M:%S).log

clean-start: $(TARGETS)
	rm -f *.binlog
	rm -Rf $(TOP)/_build $(TOP)/_ios-build $(TOP)/_mac-build
	cd $(TOP)/dotnet && git clean -xfd
	cd $(TOP)/tests/monotouch-test/dotnet && git clean -xfd
	cd $(TOP)/tests/EmbeddedResources/dotnet && git clean -xfd
	cd $(TOUCH_UNIT_PATH) && git clean -xfd
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) all -j8
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) install -j8
	$(CP) -c NuGet.config global.json $(TOP)/tests/monotouch-test/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/tests/fsharplibrary/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/tests/EmbeddedResources/dotnet/macOS
	$(CP) -c NuGet.config global.json $(TOP)/tests/bindings-test/dotnet/macOS
	rm -Rf packages $(TOP)/tests/monotouch-test/dotnet/macOS/packages

build-monotouch-test: $(TARGETS)
	$(MAKE) clean-start
	$(MAKE) just-build
	$(MAKE) run

build-monotouch-test-with-mono: export XAMARIN_RUNTIME=MonoVM
build-monotouch-test-with-mono: $(TARGETS)
	$(MAKE) build-monotouch-test

build-monotouch-test-with-coreclr: export XAMARIN_RUNTIME=CoreCLR
build-monotouch-test-with-coreclr: $(TARGETS)
	$(MAKE) build-monotouch-test

just-build:
	$(DOTNET6) build $(TOP)/tests/monotouch-test/dotnet/macOS/monotouch-test.csproj /bl:$@.binlog $(BUILD_PARAMETERS) /p:Configuration=$(XAMARIN_RUNTIME) /p:_XamarinRuntime=$(XAMARIN_RUNTIME)

just-build-mono: export XAMARIN_RUNTIME=MonoVM
just-build-mono: $(TARGETS)
	$(MAKE) just-build

just-build-coreclr: export XAMARIN_RUNTIME=CoreCLR
just-build-coreclr: $(TARGETS)
	$(MAKE) just-build

run:
	@echo "Running monotouch-test and writing output to $(LOGFILENAME)..."
	@echo "VM: $(XAMARIN_RUNTIME)" > $(LOGFILENAME)
	@set -o pipefail; (time $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/$(XAMARIN_RUNTIME)/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest) $(ARGUMENTS) 2>&1) 2>&1 | stamp >> $(LOGFILENAME) || (echo "❌ Test run failed" && say "Test run failed" && tail -n 50 $(LOGFILENAME) && exit 1)
	@echo "✅ Test run succeeded"
	@say "Test run succeeded"
	tail -n 5 $(LOGFILENAME)

run-monotouch-test-with-mono: export XAMARIN_RUNTIME=MonoVM
run-monotouch-test-with-mono: $(TARGETS)
	$(MAKE) run

run-monotouch-test-with-coreclr: export XAMARIN_RUNTIME=CoreCLR
run-monotouch-test-with-coreclr: $(TARGETS)
	$(MAKE) run

run-lldb:
	lldb -- $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/$(XAMARIN_RUNTIME)/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest) $(ARGUMENTS)

launch-lldb:
	lldb -o "process launch -s" -o "process handle -s false SIGUSR1 SIGUSR2" -- $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/$(XAMARIN_RUNTIME)/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest) $(ARGUMENTS)

bindings-test: export XAMARIN_RUNTIME=CoreCLR
bindings-test:
	#cd $(TOP)/tests/bindings-test/dotnet/macOS && $(DOTNET6) restore bindings-test.csproj /bl:$(abspath $@).binlog /p:_XamarinRuntime=CoreCLR
	cd $(TOP)/tests/bindings-test/dotnet/macOS && $(DOTNET6) build bindings-test.csproj /bl:$(abspath $@).binlog $(BUILD_PARAMETERS) /p:Configuration=$(XAMARIN_RUNTIME) /p:_XamarinRuntime=$(XAMARIN_RUNTIME)

lldb-coreclr: export XAMARIN_RUNTIME=CoreCLR
lldb-coreclr:
	$(MAKE) launch-lldb

perftest:
	$(MAKE) clean-start
	$(MAKE) just-build-coreclr
	$(MAKE) just-build-mono
	$(MAKE) run-monotouch-test-with-coreclr
	$(MAKE) run-monotouch-test-with-mono

dotnet6:
	@echo $(abspath $(DOTNET6))
