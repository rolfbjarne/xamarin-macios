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

DIRS=tests/monotouch-test tests/EmbeddedResources tests/BundledResources tests/bindings-test external/Touch.Unit/Touch.Client tests/linker/ios/dont\ link/dotnet  tests/linker/ios/link\ all/dotnet

introspection: $(TARGETS)
	cd $(TOP)/tests/introspection && git clean -xfd
	$(CP) NuGet.config global.json $(TOP)/tests/introspection/iOS
	$(CP) NuGet.config global.json $(TOP)/external/Touch.Unit/Touch.Client
	dotnet build $(TOP)/tests/introspection/iOS/introspection-ios-dotnet.csproj /v:diag /bl:introspection.binlog
	$(Q) rm -f $(TOP)/external/Touch.Unit/Touch.Client/NuGet.config $(TOP)/external/Touch.Unit/Touch.Client/global.json
	$(Q) rm -f $(TOP)/tests/introspection/iOS/NuGet.config $(TOP)/tests/introspection/iOS/global.json
	launch-in-sim $(PWD)/../introspection/iOS/bin/Debug/net5.0/ios-x64/introspection.app

dontlink: $(TARGETS)
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	cd $(TOP)/tests/linker/ios/dont\ link/dotnet && git clean -xfd
	for dir in $(DIRS); do \
		cd "$(TOP)/$$dir" && git clean -qxfd && rm -Rf ../packages && cd "$(CURDIR)"; \
		$(CP) NuGet.config global.json "$(TOP)/$$dir"; \
	done
	dotnet build $(TOP)/tests/linker/ios/dont\ link/dotnet/*.csproj /v:diag "/bl:$@.binlog" /property:GenerateFullPaths=true "/consoleloggerparameters:ForceNoAlign;DisableMPLogging"
	rm -f $(foreach dir,$(DIRS),$(TOP)/$(dir)/NuGet.config $(TOP)/$(dir)/global.json)
	launch-in-sim $(PWD)/../linker/ios/dont\ link/dotnet/bin/Debug/net5.0/ios-x64/dont\ link.app

linkall: $(TARGETS)
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	cd $(TOP)/tests/linker/ios/link\ all/dotnet && git clean -xfd
	for dir in $(DIRS); do \
		cd "$(TOP)/$$dir" && git clean -qxfd && rm -Rf ../packages && cd "$(CURDIR)"; \
		$(CP) NuGet.config global.json "$(TOP)/$$dir"; \
	done
	make -C $(TOP)/tests/test-libraries -j
	dotnet build $(TOP)/tests/linker/ios/link\ all/dotnet/*.csproj /v:diag "/bl:$@.binlog" /property:GenerateFullPaths=true "/consoleloggerparameters:ForceNoAlign;DisableMPLogging"
	rm -f $(foreach dir,$(DIRS),$(TOP)/$(dir)/NuGet.config $(TOP)/$(dir)/global.json)
	launch-in-sim $(PWD)/../linker/ios/link\ all/dotnet/bin/Debug/net5.0/ios-x64/link\ all.app

linksdk: $(TARGETS)
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	cd $(TOP)/tests/linker/ios/link\ sdk/dotnet && git clean -xfd
	for dir in $(DIRS); do \
		cd "$(TOP)/$$dir" && git clean -qxfd && rm -Rf ../packages && cd "$(CURDIR)"; \
		$(CP) NuGet.config global.json "$(TOP)/$$dir"; \
	done
	make -C $(TOP)/tests/test-libraries -j
	dotnet build $(TOP)/tests/linker/ios/link\ sdk/dotnet/*.csproj /v:diag "/bl:$@.binlog" /property:GenerateFullPaths=true "/consoleloggerparameters:ForceNoAlign;DisableMPLogging"
	rm -f $(foreach dir,$(DIRS),$(TOP)/$(dir)/NuGet.config $(TOP)/$(dir)/global.json)
	launch-in-sim $(PWD)/../linker/ios/link\ sdk/dotnet/bin/Debug/net5.0/ios-x64/link\ sdk.app

monotouch-test monotouchtest: $(TARGETS)
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	for dir in $(DIRS); do \
		cd $(TOP)/$$dir && git clean -qxfd && rm -Rf ../packages && cd $(CURDIR); \
		$(CP) NuGet.config global.json $(TOP)/$$dir; \
	done
	$(MAKE) all -j8 -C $(TOP) && $(MAKE) install -j8 -C $(TOP)
	$(MAKE) all -j8 -C $(TOP)/dotnet && $(MAKE) install -j8 -C $(TOP)/dotnet
	dotnet build $(TOP)/tests/monotouch-test/monotouch-test-dotnet.csproj /v:diag /bl:monotouch-test.binlog /property:GenerateFullPaths=true "/consoleloggerparameters:NoSummary;ForceNoAlign;DisableMPLogging"
	rm -f $(foreach dir,$(DIRS),$(TOP)/$(dir)/NuGet.config $(TOP)/$(dir)/global.json)
	launch-in-sim $(PWD)/../monotouch-test/bin/Debug/net5.0/ios-x64/monotouchtest.app

monotouch-test-simple monotouchtest-simple: $(TARGETS)
	rm -f *.binlog
	-pkill -f MSBuild.dll.*nodemode # yay :/
	for dir in $(DIRS); do \
		$(CP) NuGet.config global.json $(TOP)/$$dir; \
	done
	make -C ../test-libraries -j
	dotnet build $(TOP)/tests/monotouch-test/monotouch-test-dotnet.csproj /v:diag /bl:$@.binlog /property:GenerateFullPaths=true "/consoleloggerparameters:NoSummary;ForceNoAlign;DisableMPLogging"
	launch-in-sim $(PWD)/../monotouch-test/bin/Debug/net5.0/ios-x64/monotouchtest.app

all-local:: $(TARGETS)
