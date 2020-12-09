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

compare compare-size: $(TARGETS)
	time $(MAKE) build-oldnet
	time $(MAKE) build-dotnet
	$(MAKE) report

report:
	@echo
	@echo "## App sizes"
	@echo
	@echo "### Xamarin.iOS"
	@echo
	du -hs size-comparison/MySingleView/oldnet/bin/iPhone/Release/MySingleView.app
	@echo
	@echo "### .NET 6"
	@echo
	du -hs size-comparison/MySingleView/dotnet/bin/iPhone/Release/net6.0-ios/ios-arm64/*.app
	@echo
	@echo "## Assembly sizes"
	@echo
	@echo "### Xamarin.iOS"
	@echo
	ls -lahS size-comparison/MySingleView/oldnet/bin/iPhone/Release/MySingleView.app/*.dll size-comparison/MySingleView/oldnet/bin/iPhone/Release/MySingleView.app/*.exe
	@echo
	@echo "### .NET 6"
	@echo
	ls -lahS size-comparison/MySingleView/dotnet/bin/iPhone/Release/net6.0-ios/ios-arm64/*.app/*.dll


COMMON_ARGS=/p:Platform=iPhone /p:Configuration=Release
build-oldnet:
	$(SYSTEM_MSBUILD) $(XBUILD_VERBOSITY) size-comparison/MySingleView/oldnet/MySingleView.csproj $(COMMON_ARGS) /bl:$@.binlog

build-dotnet: $(TARGETS)
	$(DOTNET6) build size-comparison/MySingleView/dotnet/MySingleView.csproj --runtime ios-arm64 $(COMMON_ARGS) /bl:$@.binlog
