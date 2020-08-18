TOP=../..

include $(TOP)/Make.config
include $(TOP)/mk/rules.mk

BUILD_DIR=bin/Debug/net5.0

DOTNET_TARGETS += \
	$(BUILD_DIR)/dotnet-linker.dll \
	$(foreach platform,$(DOTNET_PLATFORMS),$(DOTNET_DESTDIR)/Microsoft.$(platform).Sdk/tools/dotnet-linker/dotnet-linker.dll) \
	$(foreach platform,$(DOTNET_PLATFORMS),$(DOTNET_DESTDIR)/Microsoft.$(platform).Sdk/tools/dotnet-linker/dotnet-linker.pdb) \

DOTNET_DIRECTORIES += \
	$(foreach platform,$(DOTNET_PLATFORMS),$(DOTNET_DESTDIR)/Microsoft.$(platform).Sdk/tools/dotnet-linker) \

# dotnet-linker.csproj.inc contains the dotnet_linker_dependencies variable used to determine if mtouch needs to be rebuilt or not.
dotnet-linker.csproj.inc: export BUILD_EXECUTABLE=$(DOTNET5) build
dotnet-linker.csproj.inc: global.json
-include dotnet-linker.csproj.inc

$(BUILD_DIR)/dotnet-linker%dll $(BUILD_DIR)/dotnet-linker%pdb: Makefile global.json $(dotnet_linker_dependencies)
	$(Q_DOTNET_BUILD) $(DOTNET5) build $(XBUILD_VERBOSITY)

$(DOTNET_DESTDIR)/Microsoft.iOS.Sdk/tools/dotnet-linker/%: $(BUILD_DIR)/% | $(DOTNET_DESTDIR)/Microsoft.iOS.Sdk/tools/dotnet-linker
	$(Q) $(CP) $< $@

$(DOTNET_DESTDIR)/Microsoft.tvOS.Sdk/tools/dotnet-linker/%: $(BUILD_DIR)/% | $(DOTNET_DESTDIR)/Microsoft.tvOS.Sdk/tools/dotnet-linker
	$(Q) $(CP) $< $@

$(DOTNET_DESTDIR)/Microsoft.watchOS.Sdk/tools/dotnet-linker/%: $(BUILD_DIR)/% | $(DOTNET_DESTDIR)/Microsoft.watchOS.Sdk/tools/dotnet-linker
	$(Q) $(CP) $< $@

$(DOTNET_DESTDIR)/Microsoft.macOS.Sdk/tools/dotnet-linker/%: $(BUILD_DIR)/% | $(DOTNET_DESTDIR)/Microsoft.macOS.Sdk/tools/dotnet-linker
	$(Q) $(CP) $< $@

$(DOTNET_DIRECTORIES):
	$(Q) mkdir -p $@

PLATFORMS:=$(shell echo $(DOTNET_PLATFORMS) | tr a-z A-Z)
CURRENT_HASH_LONG:=$(shell git log -1 --pretty=%H)
Constants.generated.cs: Constants.cs.in $(TOP)/Make.config.inc Makefile $(TOP)/.git/HEAD $(TOP)/.git/index
	$(Q_GEN) sed \
		$(foreach platform,$(PLATFORMS),-e "s/@$(platform)_NUGET_VERSION@/$($(platform)_NUGET_VERSION)/g") \
		$(foreach platform,$(PLATFORMS),-e "s/@$(platform)_NUGET_VERSION_NO_METADATA@/$($(platform)_NUGET_VERSION_NO_METADATA)/g") \
		$(foreach platform,$(PLATFORMS),-e "s/@$(platform)_NUGET_VERSION_FULL@/$($(platform)_NUGET_VERSION_FULL)/g") \
		-e "s/@CURRENT_BRANCH@/$(CURRENT_BRANCH_SED_ESCAPED)/g" \
		-e "s/@CURRENT_HASH_LONG@/$(CURRENT_HASH_LONG)/g" \
	$< > $@

# This tells NuGet to use the exact same dotnet version we've configured in Make.config
global.json: $(TOP)/Make.config.inc Makefile $(TOP)/.git/HEAD $(TOP)/.git/index
	$(Q_GEN) \
		printf "{\n" > $@; \
		printf "\t\"sdk\": { \"version\": \"$(DOTNET5_VERSION)\" }\n" >> $@; \
		printf "}\n" >> $@

all-local:: $(DOTNET_TARGETS)
install-local:: $(DOTNET_TARGETS)
