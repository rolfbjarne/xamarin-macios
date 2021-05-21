TOP=../../..

include $(TOP)/Make.config

prepare:
	cd .. && $(MAKE) global.json NuGet.config
	rm -Rf */bin */obj
	make all -j8 -C $(TOP)
	make install -j8 -C $(TOP)

all-ios: prepare install-stuff
	$(MAKE) build-ios

build-ios:
	rm -Rf iOS/bin iOS/obj
	$(DOTNET6) build iOS/*.csproj /bl $(MSBUILD_VERBOSITY)
	ls -laR iOS/bin/Debug/net6.0-ios/*.app

build-iossimulator:
	rm -Rf iOS/bin iOS/obj
	$(DOTNET6) build iOS/*.csproj /bl /p:Platform=iPhoneSimulator $(MSBUILD_VERBOSITY)
	ls -laR iOS/bin/Debug/net6.0-ios/*.app

all-mac: prepare install-stuff
	$(MAKE) build-mac

build-mac:
	rm -Rf macOS/bin macOS/obj
	$(DOTNET6) build macOS/*.csproj /bl $(MSBUILD_VERBOSITY)
	ls -laR macOS/bin/Debug/net6.0-macos/*.app

run-mac:
	./macOS/bin/Debug/net6.0-macos/osx-x64/$(notdir $(CURDIR)).app/Contents/MacOS/$(notdir $(CURDIR))

diag:
	cd .. && $(MAKE) global.json NuGet.config
	$(DOTNET6) build /v:diag *binlog

install-stuff:
	$(MAKE) -C $(TOP)/dotnet
