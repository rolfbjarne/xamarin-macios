TOP=../../../..
include $(TOP)/Make.config

NuGet.config global.json:
	$(Q) $(MAKE) -C $(TOP)/tests/dotnet $@
	$(Q) $(CP) $(TOP)/tests/dotnet/$@ .

prepare: NuGet.config global.json

.libs:
	$(Q) mkdir -p $@

# Test case for https://github.com/xamarin/xamarin-macios/issues/12440
.libs/FrameworksInRuntimesNativeDirectory.nupkg: FrameworksInRuntimesNativeDirectory.csproj prepare .libs
	$(Q_GEN) $(DOTNET6) pack /nologo /bl /verbosity:quiet $<
	$(Q) $(CP) bin/Debug/Xamarin.Tests.FrameworksInRuntimesNativeDirectory.1.0.0.nupkg $@

all-local:: .libs/FrameworksInRuntimesNativeDirectory.nupkg
