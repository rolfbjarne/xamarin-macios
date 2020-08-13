TOP=../..

include $(TOP)/Make.config

# This tells NuGet to use the nupkgs we're building locally,
# and to put any extracted packages in the 'packages' directory (to not clutter up ~/.nuget/packages)
NuGet.config: $(TOP)/NuGet.config Makefile
	$(Q) $(CP) $< $@.tmp
	$(Q) nuget sources add -Name local-dotnet-feed -Source $(abspath $(DOTNET_FEED_DIR)) -ConfigFile $@.tmp
	$(Q) nuget sources add -Name dotnet5 -Source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json" -ConfigFile $@.tmp
	$(Q) nuget config -Set globalPackagesFolder=$(abspath $(CURDIR)/packages) -Config $@.tmp
	$(Q) nuget config -Set repositorypath=$(abspath $(CURDIR)/packages) -Config $@.tmp
	$(Q) mv $@.tmp $@

# This tells NuGet to use the version we're building locally.
global.json: $(TOP)/Make.config.inc Makefile $(TOP)/.git/HEAD $(TOP)/.git/index
	$(Q_GEN) \
		printf "{\n" > $@; \
		printf "\t\"sdk\": { \"version\": \"$(DOTNET5_VERSION)\" },\n" >> $@; \
		printf "\t\"msbuild-sdks\": {\n" >> $@; \
		printf "\t\t\"Microsoft.iOS.Sdk\": \"$(IOS_NUGET_VERSION_NO_METADATA)\",\n" >> $@; \
		printf "\t\t\"Microsoft.tvOS.Sdk\": \"$(TVOS_NUGET_VERSION_NO_METADATA)\",\n" >> $@; \
		printf "\t\t\"Microsoft.watchOS.Sdk\": \"$(WATCHOS_NUGET_VERSION_NO_METADATA)\",\n" >> $@; \
		printf "\t\t\"Microsoft.macOS.Sdk\": \"$(MACOS_NUGET_VERSION_NO_METADATA)\"\n" >> $@; \
		printf "\t}\n}\n" >> $@

TARGETS += \
	NuGet.config \
	global.json \

all-local:: $(TARGETS)

DOTNET_ARGS=/v:diag /property:GenerateFullPaths=true "/consoleloggerparameters:ForceNoAlign;DisableMPLogging"

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

build-project: $(TARGETS)
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
	$(MAKE) all     -C $(TOP) -j8
	$(MAKE) install -C $(TOP) -j8
	if test -f $(TOP)/tests/"$(PROJECT_NAME)"/dotnet/iOS/*.csproj; then \
		$(DOTNET5) build $(TOP)/tests/"$(PROJECT_NAME)"/dotnet/iOS/*.csproj "/bl:$(notdir $(PROJECT_NAME)).binlog" $(DOTNET_ARGS); \
	else \
		$(DOTNET5) build $(TOP)/tests/"$(PROJECT_NAME)"/*-dotnet.csproj "/bl:$(notdir $(PROJECT_NAME)).binlog" $(DOTNET_ARGS); \
	fi
	rm -f "$(TOP)/tests/NuGet.config" \
		"$(TOP)/tests/global.json" \
		"$(TOP)/external/Touch.Unit/Touch.Client/dotnet/NuGet.config" \
		"$(TOP)/external/Touch.Unit/Touch.Client/dotnet/global.json" \
		"$(TOP)/external/Touch.Unit/Touch.Client/NuGet.config" \
		"$(TOP)/external/Touch.Unit/Touch.Client/global.json"
	if test -f $(TOP)/tests/"$(PROJECT_NAME)"/dotnet/iOS/*.csproj; then \
		launch-in-sim $(PWD)/../"$(PROJECT_NAME)"/dotnet/iOS/bin/Debug/net5.0/ios-x64/*.app; \
	else \
		launch-in-sim $(PWD)/../"$(PROJECT_NAME)"/bin/Debug/net5.0*/ios-x64/*.app; \
	fi

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
	rm -Rf $(TOP)/_build
