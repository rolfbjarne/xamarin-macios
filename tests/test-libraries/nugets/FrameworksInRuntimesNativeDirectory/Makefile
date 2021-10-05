TOP=../../../..
include $(TOP)/Make.config

include $(TOP)/tests/test.config

unexport MSBUILD_EXE_PATH

NuGet.config global.json:
	$(Q) $(MAKE) -C $(TOP)/tests/dotnet $@
	$(Q) $(CP) $(TOP)/tests/dotnet/$@ .

.libs:
	$(Q) mkdir -p $@


PACKAGE_ID=$(shell grep PackageId FrameworksInRuntimesNativeDirectory.csproj | sed 's_.*<PackageId>\(.*\)</PackageId>.*_\1_')
PACKAGE_VERSION=$(shell grep PackageVersion FrameworksInRuntimesNativeDirectory.csproj | sed 's_.*<PackageVersion>\(.*\)</PackageVersion>.*_\1_')

# Test case for https://github.com/xamarin/xamarin-macios/issues/12440
.libs/FrameworksInRuntimesNativeDirectory.nupkg: FrameworksInRuntimesNativeDirectory.csproj NuGet.config global.json | .libs
	$(Q_GEN) $(DOTNET6) pack /nologo /bl /verbosity:quiet $<
	$(Q) $(CP) bin/Debug/Xamarin.Tests.FrameworksInRuntimesNativeDirectory.$(PACKAGE_VERSION).nupkg $@

.libs/FrameworksInRuntimesNativeDirectory.nupkg.installed: .libs/FrameworksInRuntimesNativeDirectory.nupkg
	if test -d $(NUGET_TEST_FEED)/$(PACKAGE_ID)/$(PACKAGE_VERSION); then nuget delete $(PACKAGE_ID) $(PACKAGE_VERSION) -source $(abspath $(NUGET_TEST_FEED)) -NonInteractive; fi
	nuget add "$<" -source $(abspath $(NUGET_TEST_FEED)) -NonInteractive

all-local:: .libs/FrameworksInRuntimesNativeDirectory.nupkg
