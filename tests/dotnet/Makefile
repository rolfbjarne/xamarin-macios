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
x: $(TARGETS)
	rm -Rf packages
	cd UnitTests && dotnet test --filter 'FullyQualifiedName~BuildBindingsTest'

y: $(TARGETS)
	$(MAKE) -C $(TOP) -j all install
	rm -Rf packages
	$(CP) NuGet.config global.json $(TOP)/tests/bindings-test/dotnet/MacCatalyst
	$(DOTNET6) build $(TOP)/tests/bindings-test/dotnet/MacCatalyst/bindings-test.csproj /p:MtouchExtraArgs=-v /p:MonoBundlingExtraArgs=-v /bl

z: $(TARGETS)
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) -j all
	unset MSBuildEnableWorkloadResolver && $(MAKE) -C $(TOP) -j install
	rm -Rf packages
	cd MyCatalystApp && git clean -xfdq
	$(DOTNET6) build MyCatalystApp/*.csproj /bl:z.binlog /p:TargetPlatformIdentifier=MacCatalyst /p:SelfContained=true /p:UseAppHost=false /p:_RuntimeIdentifierUsesAppHost=false /v:diag  /p:RestoreProjectStyle=PackageReference /p:MtouchExtraArgs=--marshal-objectivec-exceptions=disable
	./MyCatalystApp/bin/Debug/net6.0/maccatalyst-x64/MyCatalystApp.*/Contents/MacOS/MyCatalystApp

q: $(TARGETS)
	rm -Rf packages
	cd MySingleView && git clean -xfdq
	$(DOTNET6) restore MySingleView/*.csproj /bl:q.binlog /v:diag
	#$(DOTNET6) build MyCatalystApp/*.csproj /bl /p:TargetPlatformIdentifier=MacCatalyst /p:SelfContained=true /p:UseAppHost=false /p:_RuntimeIdentifierUsesAppHost=false /v:diag

