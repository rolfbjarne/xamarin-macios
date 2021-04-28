TOP=../../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

TARGETS=targets
targets:
	$(MAKE) -C ..

clean-start:
	$(MAKE) -C .. $@

LOGFILENAME:=$(HOME)/test/monotouchtest-timings/$(shell date +%Y-%m-%d--%H:%M:%S).log

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
	$(DOTNET6) build $(TOP)/tests/monotouch-test/dotnet/macOS/monotouch-test.csproj /bl:$@.binlog $(BUILD_PARAMETERS) /p:Configuration=$(XAMARIN_RUNTIME) /p:UseMonoRuntime=$(if $(subst MonoVM,,$(XAMARIN_RUNTIME)),false,true) $(MSBUILD_VERBOSITY)

just-build-mono: export XAMARIN_RUNTIME=MonoVM
just-build-mono: $(TARGETS)
	$(MAKE) just-build

just-build-coreclr: export XAMARIN_RUNTIME=CoreCLR
just-build-coreclr: $(TARGETS)
	$(MAKE) just-build

run:
	@echo "Running monotouch-test and writing output to $(LOGFILENAME)..."
	@mkdir -p $(dir $(LOGFILENAME))
	@echo "VM: $(XAMARIN_RUNTIME)" > $(LOGFILENAME)
	@set -o pipefail; (time $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/$(XAMARIN_RUNTIME)/net6.0-macos/osx-*/monotouchtest.app/Contents/MacOS/monotouchtest) $(ARGUMENTS) 2>&1) 2>&1 | stamp >> $(LOGFILENAME) || (echo "❌ Test run failed" && say "Test run failed" && tail -n 50 $(LOGFILENAME) && exit 1)
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
	lldb -- $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/$(XAMARIN_RUNTIME)/net6.0-macos/osx-*/monotouchtest.app/Contents/MacOS/monotouchtest) $(ARGUMENTS)

launch-lldb:
	lldb -o "process launch -s" -o "process handle -s false SIGUSR1 SIGUSR2" -- $(abspath $(TOP)/tests/monotouch-test/dotnet/macOS/bin/$(XAMARIN_RUNTIME)/net6.0-macos/osx-*/monotouchtest.app/Contents/MacOS/monotouchtest) $(ARGUMENTS)

lldb-coreclr: export XAMARIN_RUNTIME=CoreCLR
lldb-coreclr:
	$(MAKE) launch-lldb

monotouch-test-perftest:
	$(MAKE) clean-start
	$(MAKE) just-build-coreclr
	$(MAKE) just-build-mono
	$(MAKE) run-monotouch-test-with-mono run-monotouch-test-with-coreclr -k

run-monotouch-test-perftest:
	$(MAKE) run-monotouch-test-with-mono
	$(MAKE) run-monotouch-test-with-coreclr
