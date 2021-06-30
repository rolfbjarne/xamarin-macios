TOP=../../../..
include $(TOP)/Make.config

prepare:
	rm -Rf $(TOP)/tests/dotnet/packages
	$(MAKE) -C $(TOP) -j8 all
	$(MAKE) -C $(TOP) -j8 install
	git clean -xfdq

prepare-and-build: prepare
	$(MAKE) build

prepare-and-run: prepare
	$(MAKE) run

build:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY)

dev:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY) /p:RuntimeIdentifier=ios-arm64

run:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY) -t:Run

diag:
	$(DOTNET6) build /v:diag msbuild.binlog
