TOP=../../../..

include $(TOP)/Make.config

prepare-dotnet:
	rm -Rf $(TOP)/tests/dotnet/packages
	$(MAKE) -C $(TOP)/tests/dotnet global.json NuGet.config
	$(CP) $(TOP)/tests/dotnet/global.json $(TOP)/tests/dotnet/NuGet.config ..

prepare: prepare-dotnet
	rm -Rf bin obj
	make all -j8 -C $(TOP)
	make install -j8 -C $(TOP)

all-ios: prepare install-stuff
	$(MAKE) build-ios

build-fat-ios: prepare-dotnet
	rm -Rf bin obj
	$(DOTNET6) build *.csproj /bl "/p:RuntimeIdentifiers=ios-arm%3Bios-arm64" $(MSBUILD_VERBOSITY)
	ls -laR bin/Debug/net6.0-ios/*.app

build-fat-iossimulator: prepare-dotnet
	rm -Rf bin obj
	$(DOTNET6) build *.csproj /bl "/p:Configuration=iPhoneSimulator" $(MSBUILD_VERBOSITY)
	ls -laR bin/iPhoneSimulator/Debug/net6.0-ios/*.app

diag:
	cd $(TOP)/tests/dotnet && $(MAKE) global.json NuGet.config
	$(DOTNET6) build /v:diag *binlog

install-stuff:
	$(MAKE) -C $(TOP)/dotnet
