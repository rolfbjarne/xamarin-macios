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
		echo A > A.txt; \
		echo B > B.dll; \
		echo C > C.pdb; \
		echo D > D.exe; \
		echo E > E.dylib; \
		echo F > F.a; \
		mkdir -p Sub; \
		echo G > Sub/G.txt; \
		echo I > I.txt; \
		echo J > J.txt; \
		echo K > K.txt; \
		echo L > L.txt; \
		echo M > M.txt; \
		echo N > N.txt; \
		echo O > O.txt; \
		echo P > P.txt; \
		echo Q > Q.txt; \
		echo R > R.txt; \
		echo S > S.txt; \
		echo T > T.txt; \
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
