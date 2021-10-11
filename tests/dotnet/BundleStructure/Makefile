TOP=../../..

include $(TOP)/Make.config

prepare:
	cd .. && $(MAKE) global.json NuGet.config
	rm -Rf */bin */obj

all-ios: prepare
	$(DOTNET6) build iOS/*.csproj /bl

all-mac: prepare
	$(DOTNET6) build macOS/*.csproj /bl

run-mac:
	./macOS/bin/Debug/net6.0-macos/osx-x64/$(notdir $(CURDIR)).app/Contents/MacOS/$(notdir $(CURDIR))

diag:
	cd .. && $(MAKE) global.json NuGet.config
	$(DOTNET6) build /v:diag *binlog

create-files:
	echo H > H.txt
	echo NoneH > NoneH.txt
	for i in iOS tvOS macOS MacCatalyst; do \
		cd "$$i"; \
		echo NoneA > NoneA.txt; \
		echo NoneB > NoneB.dll; \
		echo NoneC > NoneC.pdb; \
		echo NoneD > NoneD.exe; \
		echo NoneE > NoneE.dylib; \
		echo NoneF > NoneF.a; \
		mkdir -p Sub; \
		echo NoneG > Sub/NoneG.txt; \
		echo NoneI > NoneI.txt; \
		echo NoneJ > NoneJ.txt; \
		echo NoneK > NoneK.txt; \
		echo NoneL > NoneL.config; \
		echo NoneM > NoneM.unknown; \
		echo ContentA > ContentA.txt; \
		echo ContentB > ContentB.txt; \
		echo ContentC > ContentC.txt; \
		echo EmbeddedResourceA > EmbeddedResourceA.txt; \
		echo EmbeddedResourceB > EmbeddedResourceB.txt; \
		echo EmbeddedResourceC > EmbeddedResourceC.txt; \
		echo BundleResourceA > BundleResourceA.txt; \
		echo BundleResourceB > BundleResourceB.txt; \
		echo BundleResourceC > BundleResourceC.txt; \
		cd ..; \
	done
