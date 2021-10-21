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
		echo NoneB.dll > NoneB.dll; \
		echo NoneB.pdb > NoneB.pdb; \
		echo NoneB.dll.mdb > NoneB.dll.mdb; \
		echo NoneB.config > NoneB.config; \
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
		echo UnknownA > UnknownA.bin; \
		echo UnknownB > UnknownB.bin; \
		echo UnknownC > UnknownC.bin; \
		echo UnknownD > UnknownD.bin; \
		echo UnknownE.bin > UnknownE.bin; zip -9 UnknownE.bin.zip UnknownE.bin; mv UnknownE.bin.zip UnknownE.bin; \
		echo UnknownF > UnknownF.bin; \
		echo UnknownG > UnknownG.bin; \
		echo UnknownH.bin > UnknownH.bin; zip -9 UnknownH.bin.zip UnknownH.bin; mv UnknownH.bin.zip UnknownH.bin; \
		echo UnknownI > UnknownI.bin; \
		echo UnknownJ > UnknownJ.bin; \
		echo SomewhatUnknownA > SomewhatUnknownA.bin; \
		echo SomewhatUnknownB > SomewhatUnknownB.bin; \
		echo SomewhatUnknownC > SomewhatUnknownC.bin; \
		echo SomewhatUnknownD > SomewhatUnknownD.bin; \
		echo SomewhatUnknownE.bin > SomewhatUnknownE.bin; zip -9 SomewhatUnknownE.bin.zip SomewhatUnknownE.bin; mv SomewhatUnknownE.bin.zip SomewhatUnknownE.bin; \
		echo SomewhatUnknownF > SomewhatUnknownF.bin; \
		echo SomewhatUnknownG > SomewhatUnknownG.bin; \
		echo SomewhatUnknownH.bin > SomewhatUnknownH.bin; zip -9 SomewhatUnknownH.bin.zip SomewhatUnknownH.bin; mv SomewhatUnknownH.bin.zip SomewhatUnknownH.bin; \
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
