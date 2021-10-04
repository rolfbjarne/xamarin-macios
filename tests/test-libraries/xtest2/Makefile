TOP=../../..
include $(TOP)/Make.config

NAME=XTest2

# a few lookup tables, because the data we have is not always in the format we need it

COMMON_DYLIB_ARGS=-g -dynamiclib -gdwarf-2 -fms-extensions $(NAME).c -Wall -framework Foundation -lz
iphonesimulator_DYLIB_FLAGS=$(COMMON_DYLIB_ARGS) -mios-simulator-version-min=8.0 -isysroot $(SIMULATOR_SDK)
iphoneos_DYLIB_FLAGS=$(COMMON_DYLIB_ARGS) -miphoneos-version-min=8.0 -isysroot $(DEVICE_SDK)
tvsimulator_DYLIB_FLAGS=$(COMMON_DYLIB_ARGS) -mtvos-simulator-version-min=9.0 -isysroot $(SIMULATORTV_SDK)
tvos_DYLIB_FLAGS=$(COMMON_DYLIB_ARGS) -mtvos-version-min=9.0 -fembed-bitcode -isysroot $(DEVICETV_SDK)
maccatalyst_DYLIB_FLAGS=$(COMMON_DYLIB_ARGS) $(MACCATALYST_COMMON_CFLAGS)
mac_DYLIB_FLAGS=$(COMMON_DYLIB_ARGS) -mmacosx-version-min=$(MIN_OSX_VERSION_FOR_MAC) -isysroot $(XCODE_DEVELOPER_ROOT)/Platforms/MacOSX.platform/Developer/SDKs/MacOSX$(OSX_SDK_VERSION).sdk

maccatalyst-x64_DYLIB_FLAGS=$(MACCATALYST_X86_64_CFLAGS)
maccatalyst-arm64_DYLIB_FLAGS=$(MACCATALYST_ARM64_CFLAGS)

iossimulator-x64_ARCHITECTURES=x86_64
iossimulator-x86_ARCHITECTURES=i386
ios-arm_ARCHITECTURES=armv7 armv7s
ios-arm64_ARCHITECTURES=arm64
tvossimulator-x64_ARCHITECTURES=x86_64
tvos-arm64_ARCHITECTURES=arm64
osx-x64_ARCHITECTURES=x86_64
osx-arm64_ARCHITECTURES=arm64
maccatalyst-x64_ARCHITECTURES=x86_64
maccatalyst-arm64_ARCHITECTURES=arm64

mac_SYMLINKS=1
mac_INFO_PLIST_INFIX=/Versions/A/Resources
mac_BINARY_INFIX=/Versions/A
maccatalyst_SYMLINKS=1
maccatalyst_INFO_PLIST_INFIX=/Versions/A/Resources
maccatalyst_BINARY_INFIX=/Versions/A

define DotNetTemplate

$(2)_$(NAME)_TARGETS += \
	.libs/$(2)/$(NAME).framework$($(1)_BINARY_INFIX)/$(NAME) \
	.libs/$(2)/$(NAME).framework$($(1)_INFO_PLIST_INFIX)/Info.plist \
	.libs/$(2)/lib$(NAME).dylib \
	.libs/$(2)/$(NAME).framework \

ifeq ($($(1)_SYMLINKS),1)
$(2)_$(NAME)_TARGETS += \
	.libs/$(2)/$(NAME).framework/$(NAME) \
	.libs/$(2)/$(NAME).framework/Resources \
	.libs/$(2)/$(NAME).framework/Versions/Current \
	.libs/$(2)/$(NAME).framework/Versions/A/Resources/Info.plist \

endif

$(2)_TARGETS += \
	$($(2)_$(NAME)_TARGETS) \
	.libs/$(2)/$(NAME).framework.stamp \

all-local:: $$($(2)_TARGETS)

.libs/$(2)/$(NAME).framework.stamp: $$($(2)_$(NAME)_TARGETS)
	$$(Q) touch $$@

.libs/$(2)/lib$(NAME).dylib: $(NAME).c | .libs/$(2)
	$$(call Q_2,CC,    [$(1)]) $$(XCODE_CC) -o $$@ $$(foreach arch,$$($(2)_ARCHITECTURES),-arch $$(arch)) $$($(1)_DYLIB_FLAGS) $$($(2)_DYLIB_FLAGS)
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/install_name_tool -id @rpath/lib$(NAME).dylib $$@

.libs/$(2)/$(NAME).framework$($(1)_BINARY_INFIX)/$(NAME): .libs/$(2)/lib$(NAME).dylib | .libs/$(2)/$(NAME).framework$($(1)_BINARY_INFIX)
	$$(Q) $(CP) $$^ $$@
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/install_name_tool -id @rpath/$(NAME).framework/$(NAME) $$@

.libs/$(2)/$(NAME).framework$($(1)_INFO_PLIST_INFIX)/Info.plist: $(NAME)-Info-$(1).plist | .libs/$(2)/$(NAME).framework$($(1)_INFO_PLIST_INFIX)
	$$(Q) $(CP) $$^ $$@

$(2)_$(NAME)_DIRECTORIES = \
	.libs/$(2) \
	.libs/$(2)/$(NAME).framework \
	.libs/$(2)/$(NAME).framework/Versions \

$$($(2)_$(NAME)_DIRECTORIES):
	$$(Q) mkdir -p $$@

.libs/$(2)/$(NAME).framework.zip: $$($(2)_TARGETS)
	$$(Q) cd $$(dir $$@) && zip -9r $$(notdir $$@) $(NAME).framework

ZIPPED_TARGETS += .libs/$(2)/$(NAME).framework.zip

# some additional targets if the framework has macOS-like structure (i.e. has symlinks)
ifeq ($($(1)_SYMLINKS),1)
.libs/$(2)/$(NAME).framework$($(1)_BINARY_INFIX) .libs/$(2)/$(NAME).framework$($(1)_INFO_PLIST_INFIX):
	$$(Q) mkdir -p $$@

.libs/$(2)/$(NAME).framework/$(NAME): | .libs/$(2)/$(NAME).framework
	$$(Q) ln -fs Versions/A/$(NAME) $$@

.libs/$(2)/$(NAME).framework/Resources: | .libs/$(2)/$(NAME).framework
	$$(Q) ln -fs Versions/Current/Resources $$@

.libs/$(2)/$(NAME).framework/Versions/Current: | .libs/$(2)/$(NAME).framework/Versions
	$$(Q) ln -fs A $$@
endif

endef

# 1: sdk platform (iphoneos, iphonesimulator, tvos, tvsimulator, maccatalyst, mac)
# 2: runtime identifier
$(foreach platform,$(DOTNET_PLATFORMS),$(foreach rid,$(DOTNET_$(platform)_RUNTIME_IDENTIFIERS),$(eval $(call DotNetTemplate,$(DOTNET_$(rid)_SDK_PLATFORM),$(rid)))))

# For XCFrameworks, we have to lipo some of the RID-specific frameworks together (the ones with multiple RIDs just below)
iphonesimulator_XC_RUNTIMEIDENTIFIERS=iossimulator-x86 iossimulator-x64
iphoneos_XC_RUNTIMEIDENTIFIERS=ios-arm ios-arm64
tvsimulator_XC_RUNTIMEIDENTIFIERS=tvossimulator-x64
tvos_XC_RUNTIMEIDENTIFIERS=tvos-arm64
mac_XC_RUNTIMEIDENTIFIERS=osx-x64 osx-arm64
maccatalyst_XC_RUNTIMEIDENTIFIERS=maccatalyst-x64 maccatalyst-arm64

define DotNetXCTemplate
.libs/$(2)/$(NAME).framework.stamp: $$(foreach rid,$$($(2)_XC_RUNTIMEIDENTIFIERS),.libs/$$(rid)/$(NAME).framework.stamp) .libs/$(2)
	$$(Q) rm -Rf .libs/$(2)/$(NAME).framework
	$$(Q) $(CP) -R .libs/$$(firstword $$($(2)_XC_RUNTIMEIDENTIFIERS))/$(NAME).framework .libs/$(2)/$(NAME).framework
ifneq ($$(words $($(2)_XC_RUNTIMEIDENTIFIERS)),1)
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/lipo $$(foreach rid,$$($(2)_XC_RUNTIMEIDENTIFIERS),.libs/$$(rid)/$(NAME).framework$($(2)_BINARY_INFIX)/$(NAME)) -create -output .libs/$(2)/$(NAME).framework$($(2)_BINARY_INFIX)/$(NAME)
endif
	$$(Q) touch $$@

.libs/$(2):
	$$(Q) mkdir -p $$@

XCPLATFORMS += $(2)
XCTARGETS += .libs/$(2)/$(NAME).framework.stamp
XCFRAMEWORKS += -framework .libs/$(2)/$(NAME).framework
endef

$(foreach platform,$(DOTNET_PLATFORMS),$(foreach xcplatform,$(DOTNET_$(platform)_SDK_PLATFORMS),$(eval $(call DotNetXCTemplate,$(platform),$(xcplatform)))))

zip: $(ZIPPED_TARGETS)
all-local:: $(ZIPPED_TARGETS)

.libs/$(NAME).xcframework.stamp: $(XCTARGETS) Makefile
	$(Q) rm -rf .libs/$(NAME).xcframework
	$(Q_GEN) $(XCODE_DEVELOPER_ROOT)/usr/bin/xcodebuild -quiet -create-xcframework $(XCFRAMEWORKS) -output .libs/$(NAME).xcframework
	$(Q) touch $@

all-local:: .libs/$(NAME).xcframework.stamp
