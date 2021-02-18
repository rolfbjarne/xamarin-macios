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

all-local:: $(TARGETS)

build-mysingleview:
	$(DOTNET6) build MySingleView/*.csproj

run-mysingleview:
	$(DOTNET6) build -t:Run MySingleView/*.csproj /p:_DeviceName=:v2:udid=03B4B310-6A00-4218-BA15-31312D6707DA /v:diag

build-monotouch-test-with-mono: $(TARGETS)
	$(MAKE) -C $(TOP) all -j8
	$(MAKE) -C $(TOP) install -j8
	$(CP) -c NuGet.config global.json $(TOP)/tests/monotouch-test/dotnet/macOS
	cd $(TOP)/tests/monotouch-test/dotnet/macOS && rm -Rf bin obj
	rm -Rf packages
	$(DOTNET6) build $(TOP)/tests/monotouch-test/dotnet/macOS/monotouch-test.csproj /bl:$@.binlog
	$(TOP)/tests/monotouch-test/dotnet/macOS/bin/Debug/net6.0-macos/osx-x64/monotouchtest.app/Contents/MacOS/monotouchtest

build-monotouch-test-with-coreclr: $(TARGETS)
	$(DOTNET6) build $(TOP)/tests/monotouch-test/dotnet/macOS/monotouch-test.csproj /bl:$@.binlog /p:XamarinRuntime=CoreCLR
