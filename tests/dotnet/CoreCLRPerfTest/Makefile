TOP=../../..

include $(TOP)/Make.config

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

TARGETS=targets
targets:
	$(Q) $(MAKE) -C ..

clean-start:
	$(Q) $(MAKE) -C .. $@

build-perftest-with-mono: export XAMARIN_RUNTIME=MonoVM
build-perftest-with-mono: $(TARGETS)
	$(Q) $(MAKE) build-perf-test

build-perftest-with-coreclr: export XAMARIN_RUNTIME=CoreCLR
build-perftest-with-coreclr: $(TARGETS)
	$(Q) $(MAKE) build-perf-test

ifeq ("$(BENCHMARK_OUTPUT_PATH)","")
BENCHMARK_OUTPUT_PATH:=$(abspath $(HOME)/test/CoreCLRPerfTest/output/$(shell date +%Y-%m-%d--%H:%M:%S))
endif
export BENCHMARK_OUTPUT_PATH

RUNTIME_IDENTIFIER?=osx-x64

BINLOG_TIMESTAMP:=$(shell date +%Y-%m-%d--%H:%M:%S)
build-perf-test: $(TARGETS)
	$(Q) test -n "$(XAMARIN_RUNTIME)" || ( echo "❌ XAMARIN_RUNTIME must be set! ❌"; exit 1)
	$(Q) rm -Rf bin/$(XAMARIN_RUNTIME) obj/$(XAMARIN_RUNTIME)
	if ! $(DOTNET6) build $(abspath CoreCLRPerfTest.csproj) "/bl:$@-$(BINLOG_TIMESTAMP).binlog" $(BUILD_PARAMETERS) /p:Configuration=$(XAMARIN_RUNTIME) /p:_XamarinRuntime=$(XAMARIN_RUNTIME) /p:RuntimeIdentifier=$(RUNTIME_IDENTIFIER) $(MSBUILD_VERBOSITY); then \
		$(DOTNET6) build /v:diag "$@-$(BINLOG_TIMESTAMP).binlog"; \
		echo "Performance test build failed" & \
		exit 1; \
	fi

run-perftest-with-mono: export XAMARIN_RUNTIME=MonoVM
run-perftest-with-mono: $(TARGETS)
	$(Q) $(MAKE) run-perftest-with-runtime

run-perftest-with-coreclr: export XAMARIN_RUNTIME=CoreCLR
run-perftest-with-coreclr: $(TARGETS)
	$(Q) $(MAKE) run-perftest-with-runtime

perftest-with-mono: $(TARGETS)
	$(Q) $(MAKE) build-perftest-with-mono
	$(Q) $(MAKE) run-perftest-with-mono

perftest-with-coreclr: $(TARGETS)
	$(Q) $(MAKE) build-perftest-with-coreclr
	$(Q) $(MAKE) run-perftest-with-coreclr

run-perftest:
	$(Q) $(MAKE) build-perftest-with-coreclr
	$(Q) $(MAKE) build-perftest-with-mono
	$(Q) $(MAKE) run-perftest-with-mono
	$(Q) $(MAKE) run-perftest-with-coreclr
	@echo "Log files were stored in $(BENCHMARK_OUTPUT_PATH)"

perftest-arm64: export RUNTIME_IDENTIFIER=osx-arm64
perftest-arm64: $(TARGETS)
	$(Q) $(MAKE) build-perftest-with-coreclr
	$(Q) $(MAKE) run-perftest-with-coreclr

PERFLOGFILENAME:=$(BENCHMARK_OUTPUT_PATH)/perflog-$(shell date +%Y-%m-%d--%H:%M:%S).log
run-perftest-with-runtime: $(TARGETS)
	@echo "Running CoreCLRPerfTest and writing output to $(PERFLOGFILENAME)..."
	$(Q) mkdir -p $(BENCHMARK_OUTPUT_PATH)
	$(Q) echo "VM: $(XAMARIN_RUNTIME)" > $(PERFLOGFILENAME)
	(time $(abspath bin/$(XAMARIN_RUNTIME)/net6.0-macos/$(RUNTIME_IDENTIFIER)/CoreCLRPerfTest.app/Contents/MacOS/CoreCLRPerfTest) $(ARGUMENTS) 2>&1) 2>&1 | stamp | tee -a $(PERFLOGFILENAME)
