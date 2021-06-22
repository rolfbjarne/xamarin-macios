TOP=../../../..

include $(TOP)/Make.config
include $(TOP)/mk/colors.mk

TARGETS=prepare
prepare:
	$(MAKE) -C $(TOP)/tests/dotnet all copy-dotnet-config

build: prepare
	$(DOTNET6) build /bl:$@.binlog *.csproj $(MSBUILD_VERBOSITY)

build-fat-device: prepare
	$(DOTNET6) build /bl:$@.binlog *.csproj $(MSBUILD_VERBOSITY) '/p:RuntimeIdentifiers="ios-arm64;ios-arm"' /p:MtouchLink=SdkOnly

run-fat-device: prepare
	$(DOTNET6) build /bl:$@.binlog *.csproj $(MSBUILD_VERBOSITY) '/p:RuntimeIdentifiers="ios-arm64;ios-arm"' /p:MtouchLink=SdkOnly -t:Run

run-device: prepare
	$(DOTNET6) build /bl:$@.binlog *.csproj $(MSBUILD_VERBOSITY) '/p:RuntimeIdentifier="ios-arm64"' /p:MtouchLink=SdkOnly -t:Run

diag:
	$(DOTNET6) build /v:diag *.binlog
