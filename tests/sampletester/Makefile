TOP=../..

include $(TOP)/Make.config

ifneq ('$(IOS_DESTDIR)','')
export MD_APPLE_SDK_ROOT=$(abspath $(XCODE_DEVELOPER_ROOT)/../..)
export MD_MTOUCH_SDK_ROOT=$(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)
export TargetFrameworkFallbackSearchPaths=$(IOS_DESTDIR)/Library/Frameworks/Mono.framework/External/xbuild-frameworks
export MSBuildExtensionsPathFallbackPathsOverride=$(IOS_DESTDIR)/Library/Frameworks/Mono.framework/External/xbuild
else
unexport MD_APPLE_SDK_ROOT
unexport MD_MTOUCH_SDK_ROOT
unexport TargetFrameworkFallbackSearchPaths
unexport MSBuildExtensionsPathFallbackPathsOverride
endif

ifneq ('$(MAC_DESTDIR)','')
export XAMMAC_FRAMEWORK_PATH=$(MAC_DESTDIR)/Library/Frameworks/Xamarin.Mac.framework/Versions/Current
export XamarinMacFrameworkRoot=$(MAC_DESTDIR)/Library/Frameworks/Xamarin.Mac.framework/Versions/Current
else
unexport XAMMAC_FRAMEWORK_PATH
unexport XamarinMacFrameworkRoot
unexport TargetFrameworkFallbackSearchPaths
unexport MSBuildExtensionsPathFallbackPathsOverride
endif

NUNIT_MSBUILD_DIR=$(TOP)/packages/NUnit.ConsoleRunner.3.9.0/tools/

all-local::
	$(MAKE) build
	$(MAKE) run-tests

ifneq ($(TEST_CATEGORY),)
WHERE_CONDITION=/where "cat == $(TEST_CATEGORY)"
endif

run-tests:
	@rm -f .failed-stamp
	mono64 --debug $(NUNIT_MSBUILD_DIR)/nunit3-console.exe $(WHERE_CONDITION) $(abspath $(CURDIR)/bin/Debug/sampletester.dll) "--result=$(abspath $(CURDIR)/TestResult.xml)" $${TEST_FIXTURE:+"$$TEST_FIXTURE"} --labels=All || touch $(CURDIR)/.failed-stamp
	xsltproc HtmlReport.xslt TestResult.xml > index.html
	@[[ ! -e .failed-stamp ]]

run-tests-system:
	$(MAKE) IOS_DESTDIR="/" IOS_TARGETDIR=/ MAC_DESTDIR=/ MAC_TARGETDIR=/

build:
	$(Q) $(SYSTEM_MONO) /Library/Frameworks//Mono.framework/Versions/Current/lib/mono/nuget/NuGet.exe restore ../tests.sln
	$(SYSTEM_MSBUILD) sampletester.csproj $(MSBUILD_VERBOSITY)
	$(Q) rm -f .failed-stamp
