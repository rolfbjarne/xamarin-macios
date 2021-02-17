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

# This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
# Ref: https://github.com/dotnet/sdk/issues/13849
export MSBuildEnableWorkloadResolver=true

t: $(TARGETS)
	cd $(TOP) && mai
	cd "/Users/rolf/work/maccore/onedotnet/xamarin-macios/tests/xharness/tmp-test-dir/link all28" && rm -Rf bin obj
	MSBuildExtensionsPathFallbackPathsOverride= MD_MTOUCH_SDK_ROOT=/Users/rolf/work/maccore/onedotnet/xamarin-macios/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current TargetFrameworkFallbackSearchPaths= MSBUILD_EXE_PATH= /Users/rolf/work/maccore/onedotnet/xamarin-macios/builds/downloads/dotnet-sdk-6.0.100-preview.2.21114.3-osx-x64/dotnet build /verbosity:diagnostic /bl:/Users/rolf/work/maccore/onedotnet/xamarin-macios/jenkins-results/tests/20210217_081006/link-all/83/build-iOS_Unified-20210217_081027.binlog /p:Platform=iPhoneSimulator /p:Configuration=Debug "/Users/rolf/work/maccore/onedotnet/xamarin-macios/tests/xharness/tmp-test-dir/link all28/link all.csproj"