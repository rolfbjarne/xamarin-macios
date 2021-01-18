TOP=../..

include $(TOP)/Make.config

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
export MSBuildEnableWorkloadResolver=true

RUNTIME_IDENTIFIER=ios-arm64
DOTNET_ARGS=/v:diag /property:GenerateFullPaths=true "/consoleloggerparameters:ForceNoAlign;DisableMPLogging" /p:RuntimeIdentifier=$(RUNTIME_IDENTIFIER)

DIRS=\
	tests/monotouch-test \
	tests/interdependent-binding-projects \
	tests/BundledResources \
	tests/EmbeddedResources \
	tests/bindings-test \
	tests/bindings-test2 \
	tests/linker/ios/dont\ link \
	tests/linker/ios/link\ all \
	external/Touch.Unit/Touch.Client \

singleview: $(TARGETS)
	$(DOTNET6) build        MySingleView/*.csproj /p:RuntimeIdentifier=$(RUNTIME_IDENTIFIER) "/bl:MySingleView.binlog" $(DOTNET_ARGS)
	$(DOTNET6) build /t:Run MySingleView/*.csproj /p:RuntimeIdentifier=$(RUNTIME_IDENTIFIER) /verbosity:diag

introspection: $(TARGETS)
	$(MAKE) build-project PROJECT_NAME=introspection/iOS

introspection-old: $(TARGETS)
	cd $(TOP)/tests/introspection && git clean -xfd
	$(CP) NuGet.config global.json $(TOP)/tests/introspection/iOS
	$(CP) NuGet.config global.json $(TOP)/external/Touch.Unit/Touch.Client
	dotnet build $(TOP)/tests/introspection/iOS/introspection-ios-dotnet.csproj /v:diag /bl:introspection.binlog
	$(Q) rm -f $(TOP)/external/Touch.Unit/Touch.Client/NuGet.config $(TOP)/external/Touch.Unit/Touch.Client/global.json
	$(Q) rm -f $(TOP)/tests/introspection/iOS/NuGet.config $(TOP)/tests/introspection/iOS/global.json
	launch-in-sim $(PWD)/../introspection/iOS/bin/Debug/net5.0/ios-x64/introspection.app

build: $(TARGETS)
	$(MAKE) all     -C $(TOP) -j8
	$(MAKE) install -C $(TOP) -j8

build-project: build
	test -n "$(PROJECT_NAME)" || exit 1
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	for dir in $(DIRS); do \
		if test -d "$(TOP)/$$dir/dotnet"; then \
			cd "$(TOP)/$$dir/dotnet" && git clean -qxfd && rm -Rf packages ../packages && cd "$(CURDIR)"; \
			$(CP) NuGet.config global.json "$(TOP)/$$dir/dotnet"; \
		else \
			rm -Rf "$(TOP)/$$dir/bin" "$(TOP)/$$dir/obj packages ../packages"; \
			$(CP) NuGet.config global.json "$(TOP)/$$dir"; \
		fi; \
	done
	$(CP) NuGet.config global.json "$(TOP)/tests"
	$(CP) NuGet.config global.json "$(TOP)/external/Touch.Unit/Touch.Client/dotnet"
	$(DOTNET6) build $(TOP)/tests/"$(PROJECT_NAME)"/dotnet/iOS/*.csproj "/bl:$(notdir $(PROJECT_NAME)).binlog" $(DOTNET_ARGS)
	test -n "$$SKIP_LAUNCH" || $(DOTNET6) build /t:Run $(TOP)/tests/"$(PROJECT_NAME)"/dotnet/iOS/*.csproj /p:RuntimeIdentifier=$(RUNTIME_IDENTIFIER) /verbosity:diag "/consoleloggerparameters:ForceNoAlign;DisableMPLogging,NoSummary,PerformanceSummary=false"
	rm -f "$(TOP)/tests/NuGet.config" \
		"$(TOP)/tests/global.json" \
		"$(TOP)/external/Touch.Unit/Touch.Client/dotnet/NuGet.config" \
		"$(TOP)/external/Touch.Unit/Touch.Client/dotnet/global.json" \
		"$(TOP)/external/Touch.Unit/Touch.Client/NuGet.config" \
		"$(TOP)/external/Touch.Unit/Touch.Client/global.json"
	for dir in $(DIRS); do rm -f "$(TOP)/$$dir/dotnet/NuGet.config" "$(TOP)/$$dir/dotnet/global.json"; done

run-project:
	$(DOTNET6) build /t:Run $(TOP)/tests/"$(PROJECT_NAME)"/dotnet/iOS/*.csproj /p:RuntimeIdentifier=$(RUNTIME_IDENTIFIER) /verbosity:diag "/consoleloggerparameters:ForceNoAlign;DisableMPLogging,NoSummary,PerformanceSummary=false"

run-linksdk:
	$(MAKE) run-project PROJECT_NAME=linker/ios/link\ sdk

linksdk link\ sdk:
	$(MAKE) build-project PROJECT_NAME=linker/ios/link\ sdk

linkall link\ all:
	$(MAKE) build-project PROJECT_NAME=linker/ios/link\ all

dontlink dont\ link:
	$(MAKE) build-project PROJECT_NAME=linker/ios/dont\ link

monotouch-test monotouchtest: $(TARGETS)
	$(MAKE) build-project PROJECT_NAME=monotouch-test

interdependent-binding-projects:
	$(MAKE) build-project PROJECT_NAME=interdependent-binding-projects

test-clean clean-test:
	cd $(TOP)/tests && git clean -xfdq
	cd $(TOP)/dotnet && git clean -xfdq
	cd $(TOP)/msbuild && git clean -xfdq
	rm -Rf $(TOP)/_build

