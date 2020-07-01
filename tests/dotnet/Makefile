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

introspection: $(TARGETS)
	cd $(TOP)/tests/introspection && git clean -xfd
	$(CP) NuGet.config global.json $(TOP)/tests/introspection/iOS
	$(CP) NuGet.config global.json $(TOP)/external/Touch.Unit/Touch.Client
	dotnet build $(TOP)/tests/introspection/iOS/introspection-ios-dotnet.csproj /v:diag /bl:introspection.binlog
	$(Q) rm -f $(TOP)/external/Touch.Unit/Touch.Client/NuGet.config $(TOP)/external/Touch.Unit/Touch.Client/global.json
	$(Q) rm -f $(TOP)/tests/introspection/iOS/NuGet.config $(TOP)/tests/introspection/iOS/global.json
	launch-in-sim $(PWD)/../introspection/iOS/bin/Debug/net5.0/ios-x64/introspection.app

DIRS=tests/monotouch-test tests/EmbeddedResources tests/bindings-test external/Touch.Unit/Touch.Client
monotouch-test monotouchtest: $(TARGETS)
	for dir in $(DIRS); do \
		cd $(TOP)/$$dir && git clean -qxfd && cd $(CURDIR); \
		$(CP) NuGet.config global.json $(TOP)/$$dir; \
	done
	make all install -j8 -C $(TOP)
	dotnet build $(TOP)/tests/bindings-test/bindings-test-dotnet.csproj /v:diag /bl:bindings-test.binlog
	#dotnet build $(TOP)/tests/monotouch-test/monotouch-test-dotnet.csproj /v:diag /bl:monotouch-test.binlog
	for dir in $(DIRS); do \
		rm -f $$dir/NuGet.config $$dir/global.json $(TOP)/$$dir; \
	done
	launch-in-sim $(PWD)/../monotouch-test/bin/Debug/net5.0/ios-x64/monotouchtest.app

all-local:: $(TARGETS)
