TOP=../../..

include $(TOP)/Make.config

prepare:
	cd .. && $(MAKE) global.json NuGet.config
	rm -Rf */bin */obj
	make all -j8 -C $(TOP)
	make install -j8 -C $(TOP)

all-ios: prepare
	$(DOTNET6) build iOS/*.csproj /bl

all-mac: prepare install-stuff
	$(MAKE) build-mac

build-mac:
	$(DOTNET6) build macOS/*.csproj /bl $(MSBUILD_VERBOSITY)
	ls -la macOS/bin/Debug/net6.0-macos/*.app

run-mac:
	./macOS/bin/Debug/net6.0-macos/osx-x64/$(notdir $(CURDIR)).app/Contents/MacOS/$(notdir $(CURDIR))

diag:
	cd .. && $(MAKE) global.json NuGet.config
	$(DOTNET6) build /v:diag *binlog

install-stuff:
	$(MAKE) -C $(TOP)/dotnet
