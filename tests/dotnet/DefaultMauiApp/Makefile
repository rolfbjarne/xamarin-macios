TOP=../../..

include $(TOP)/Make.config
include $(TOP)/mk/quiet.mk

build:
	$(DOTNET) publish -bl:MauiiOS.binlog -f $(DOTNET_TFM)-ios -r ios-arm64 -c Release /p:EnableCodeSigning=false $(MSBUILD_VERBOSITY)
	$(Q) mv ./bin/Release/$(DOTNET_TFM)-ios/ios-arm64/publish/*.ipa ./DefaultMauiApp.ipa

clean:
	rm -rf *.ipa bin obj
