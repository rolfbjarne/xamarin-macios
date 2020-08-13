TOP=../..

include $(TOP)/Make.config

# This tells NuGet to use the nupkgs we're building locally,
# and to put any extracted packages in the 'packages' directory (to not clutter up ~/.nuget/packages)
NuGet.config: $(TOP)/NuGet.config Makefile
	$(Q) $(CP) $< $@.tmp
	$(Q) nuget sources add -Name local-dotnet-feed -Source $(abspath $(DOTNET_FEED_DIR)) -ConfigFile $@.tmp
	$(Q) nuget sources add -Name dotnet5 -Source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json" -ConfigFile $@.tmp
	$(Q) nuget config -Set globalPackagesFolder=packages -Config $@.tmp
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

DIRS=\
	tests/interdependent-binding-projects \
	tests/EmbeddedResources \
	tests/bindings-test \
	tests/bindings-test2 \
	external/Touch.Unit/Touch.Client \

DOTNET_ARGS=/v:diag /property:GenerateFullPaths=true "/consoleloggerparameters:ForceNoAlign;DisableMPLogging"

build-project:
	test -n "$(PROJECT_NAME)" || exit 1
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	for dir in $(DIRS); do \
		cd "$(TOP)/$$dir/dotnet" && git clean -qxfd && rm -Rf packages ../packages && cd "$(CURDIR)"; \
		$(CP) NuGet.config global.json "$(TOP)/$$dir/dotnet"; \
	done
	$(CP) NuGet.config global.json "$(TOP)/tests"
	$(CP) NuGet.config global.json "$(TOP)/external/Touch.Unit/Touch.Client/dotnet"
	make -C $(TOP)/tests/test-libraries -j
	dotnet build $(TOP)/tests/$(PROJECT_NAME)/dotnet/iOS/*.csproj "/bl:$(PROJECT_NAME).binlog" $(DOTNET_ARGS)
	rm -f "$(TOP)/tests/NuGet.config" "$(TOP)/tests/global.json" "$(TOP)/external/Touch.Unit/Touch.Client/dotnet/NuGet.config" "$(TOP)/external/Touch.Unit/Touch.Client/dotnet/global.json"
	launch-in-sim $(PWD)/../$(PROJECT_NAME)/dotnet/iOS/bin/Debug/net5.0/ios-x64/*.app

interdependent-binding-projects:
	$(MAKE) build-project PROJECT_NAME=interdependent-binding-projects
