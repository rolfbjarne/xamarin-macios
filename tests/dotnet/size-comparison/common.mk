TOP=../../../..

include $(TOP)/Make.config

TARGETS += \
	.config.stamp

.config.stamp: Makefile
	$(Q) $(MAKE) -C ../.. NuGet.config global.json
	$(Q) touch $@

all-local:: compare

compare compare-size: $(TARGETS)
	rm -rf ../../packages
	git clean -xfdq
	time $(MAKE) build-oldnet
	time $(MAKE) build-dotnet
	$(MAKE) report

PROJECT_OLD_NAME?=$(PROJECT)
PROJECT_NEW_NAME?=$(PROJECT)

PROJECT_OLD_FILE?=./oldnet/$(PROJECT_OLD_NAME).csproj
PROJECT_NEW_FILE?=./dotnet/$(PROJECT_NEW_NAME).csproj

PROJECT_OLD_APP?=./oldnet/bin/iPhone/Release/$(PROJECT_NEW_NAME).app
PROJECT_NEW_APP?=./dotnet/bin/iPhone/Release/net6.0-ios/ios-arm64/$(PROJECT).app

report:
	appcompare \
		$(abspath $(PROJECT_OLD_APP)) \
		$(abspath $(PROJECT_NEW_APP)) \
		--output-markdown $(abspath ./report.md) \
		--gist \
		--mapping-file $(abspath ./$(PROJECT).map) \

COMMON_ARGS=/p:Platform=iPhone /p:Configuration=Release $(MSBUILD_VERBOSITY)
build-oldnet:
	$(SYSTEM_MSBUILD) $(PROJECT_OLD_FILE) $(COMMON_ARGS) /bl:$@.binlog /r

build-dotnet: $(TARGETS)
	$(DOTNET6) build $(PROJECT_NEW_FILE) $(COMMON_ARGS) /bl:$@.binlog --runtime ios-arm64
