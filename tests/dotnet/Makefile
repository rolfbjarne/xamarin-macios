TOP=../..

include $(TOP)/Make.config

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

DEVNAME=c0814eeda0e071c4ed07f194ce9582674259fc4b
DEVNAME=a87b763bf8da1fcc094cbc01811a17eacf2279e5
DEVNAME=00008030-000879200CC0802E
test: $(TARGETS)
	cd MyInterpretedApp && rm -Rf bin obj
	rm -Rf packages
	$(DOTNET6) build MyInterpretedApp/*.csproj /p:RuntimeIdentifier=ios-arm64 /bl /v:diag || (openbinlog msbuild.binlog && exit 1)
	mlaunch --installdev MyInterpretedApp/bin/Debug/net6.0-ios/ios-arm64/MyInterpretedApp.app --devname "$(DEVNAME)"
	mlaunch --launchdev MyInterpretedApp/bin/Debug/net6.0-ios/ios-arm64/MyInterpretedApp.app --wait-for-unlock --wait-for-exit --devname "$(DEVNAME)"
	sync-crash-reports.sh "$(DEVNAME)"

test2: $(TARGETS)
	cd MySingleView && rm -Rf bin obj
	rm -Rf packages
	$(DOTNET6) build MySingleView/*.csproj /p:RuntimeIdentifier=ios-arm64 /bl /v:diag
	mlaunch --installdev MySingleView/bin/Debug/net6.0-ios/ios-arm64/MySingleView.app --devname "$(DEVNAME)"
	mlaunch --launchdev MySingleView/bin/Debug/net6.0-ios/ios-arm64/MySingleView.app --wait-for-unlock --wait-for-exit --devname "$(DEVNAME)"
	sync-crash-reports.sh "$(DEVNAME)"


forms: $(TARGETS)
	cd MyXamarinFormsApp && rm -Rf bin obj
	rm -Rf packages
	$(DOTNET6) build MyXamarinFormsApp/*.csproj /p:RuntimeIdentifier=ios-arm64 /bl /v:diag /p:MtouchLink=Full
	mlaunch --installdev MyXamarinFormsApp/bin/Debug/net6.0-ios/ios-arm64/MyXamarinFormsApp.app --devname "$(DEVNAME)"
	mlaunch --launchdev MyXamarinFormsApp/bin/Debug/net6.0-ios/ios-arm64/MyXamarinFormsApp.app --wait-for-unlock --wait-for-exit --devname "$(DEVNAME)"
	sync-crash-reports.sh "$(DEVNAME)"



sim:
	$(DOTNET5) build MyInterpretedApp/*.csproj /bl /v:diag
	launch-in-sim MyInterpretedApp/bin/Debug/net5.0-ios/ios-x64/MyInterpretedApp.app
