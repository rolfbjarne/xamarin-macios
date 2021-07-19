TOP=../../../..

include $(TOP)/Make.config

build:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY)

run:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY) -t:Run

reload:
	$(Q) rm -Rf $(TOP)/tests/dotnet/packages
	$(Q) $(MAKE) -C $(TOP) -j8 all
	$(Q) $(MAKE) -C $(TOP) -j8 install
	$(Q) git clean -xfdq

