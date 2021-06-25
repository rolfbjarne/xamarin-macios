TOP=../../..

include $(TOP)/Make.config

prepare-and-build:
	rm -Rf $(TOP)/tests/packages
	$(MAKE) -C $(TOP) -j8 all
	$(MAKE) -C $(TOP) -j8 install
	git clean -xfdq
	$(MAKE) -C $(TOP)/tests/dotnet
	cp $(TOP)/tests/dotnet/global.json $(TOP)/tests/dotnet/NuGet.config .
	$(MAKE) build

build:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY)

run:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY) -t:Run
