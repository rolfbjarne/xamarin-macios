TOP=../../..
include $(TOP)/Make.config

NAMES+=FrameworksInRuntimesNativeDirectory1 FrameworksInRuntimesNativeDirectory2
NAMES+=FrameworkTest1 FrameworkTest2 FrameworkTest3 FrameworkTest4 FrameworkTest5

# a few lookup tables, because the data we have is not always in the format we need it

COMMON_DYLIB_ARGS=-g -dynamiclib -gdwarf-2 -fms-extensions shared.c -Wall -framework Foundation -lz
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

$(1)_$(3)_TARGETS += \
	.libs/$(3)/$(1).framework$($(2)_BINARY_INFIX)/$(1) \
	.libs/$(3)/$(1).framework$($(2)_INFO_PLIST_INFIX)/Info.plist \
	.libs/$(3)/lib$(1).dylib \
	.libs/$(3)/$(1).framework \

ifeq ($($(2)_SYMLINKS),1)
$(1)_$(3)_TARGETS += \
	.libs/$(3)/$(1).framework/$(1) \
	.libs/$(3)/$(1).framework/Resources \
	.libs/$(3)/$(1).framework/Versions/Current \
	.libs/$(3)/$(1).framework/Versions/A/Resources/Info.plist \

endif

$(3)_TARGETS += \
	$($(1)_$(3)_TARGETS) \
	.libs/$(3)/$(1).framework.stamp \

all-local:: $$($(3)_TARGETS)

.libs/$(3)/$(1).framework.stamp: $$($(1)_$(3)_TARGETS)
	$$(Q) touch $$@

.libs/$(3)/lib$(1).dylib: shared.c | .libs/$(3)
	$$(call Q_2,CC,    [$(3)]) $$(XCODE_CC) -o $$@ $$(foreach arch,$$($(3)_ARCHITECTURES),-arch $$(arch)) $$($(2)_DYLIB_FLAGS) $$($(3)_DYLIB_FLAGS) -DNAME=$(1)
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/install_name_tool -id @rpath/lib$(1).dylib $$@

.libs/$(3)/$(1).framework$($(2)_BINARY_INFIX)/$(1): .libs/$(3)/lib$(1).dylib | .libs/$(3)/$(1).framework$($(2)_BINARY_INFIX)
	$$(Q) $(CP) $$^ $$@
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/install_name_tool -id @rpath/$(1).framework/$(1) $$@

.libs/$(3)/$(1).framework$($(2)_INFO_PLIST_INFIX)/Info.plist: Info-$(2).plist | .libs/$(3)/$(1).framework$($(2)_INFO_PLIST_INFIX)
	$$(Q) sed 's/%NAME%/$(1)/g' $$^ > $$@

$(3)_$(1)_DIRECTORIES = \
	.libs/$(3)/$(1).framework \
	.libs/$(3)/$(1).framework/Versions \

$$($(3)_$(1)_DIRECTORIES):
	$$(Q) mkdir -p $$@

.libs/$(3)/$(1).framework.zip: $$($(3)_TARGETS)
	$$(Q) cd $$(dir $$@) && zip -9r $$(notdir $$@) $(1).framework

ZIPPED_TARGETS += .libs/$(3)/$(1).framework.zip

# some additional targets if the framework has macOS-like structure (i.e. has symlinks)
ifeq ($($(2)_SYMLINKS),1)
.libs/$(3)/$(1).framework$($(2)_BINARY_INFIX) .libs/$(3)/$(1).framework$($(2)_INFO_PLIST_INFIX):
	$$(Q) mkdir -p $$@

.libs/$(3)/$(1).framework/$(1): | .libs/$(3)/$(1).framework
	$$(Q) ln -fs Versions/A/$(1) $$@

.libs/$(3)/$(1).framework/Resources: | .libs/$(3)/$(1).framework
	$$(Q) ln -fs Versions/Current/Resources $$@

.libs/$(3)/$(1).framework/Versions/Current: | .libs/$(3)/$(1).framework/Versions
	$$(Q) ln -fs A $$@
endif

endef

# 1: name
# 2: sdk platform (iphoneos, iphonesimulator, tvos, tvsimulator, maccatalyst, mac)
# 3: runtime identifier
$(foreach name,$(NAMES),$(foreach platform,$(DOTNET_PLATFORMS),$(foreach rid,$(DOTNET_$(platform)_RUNTIME_IDENTIFIERS),$(eval $(call DotNetTemplate,$(name),$(DOTNET_$(rid)_SDK_PLATFORM),$(rid))))))

# For XCFrameworks, we have to lipo some of the RID-specific frameworks together (the ones with multiple RIDs just below)
iphonesimulator_XC_RUNTIMEIDENTIFIERS=iossimulator-x86 iossimulator-x64
iphoneos_XC_RUNTIMEIDENTIFIERS=ios-arm ios-arm64
tvsimulator_XC_RUNTIMEIDENTIFIERS=tvossimulator-x64
tvos_XC_RUNTIMEIDENTIFIERS=tvos-arm64
mac_XC_RUNTIMEIDENTIFIERS=osx-x64 osx-arm64
maccatalyst_XC_RUNTIMEIDENTIFIERS=maccatalyst-x64 maccatalyst-arm64

define DotNetXCTemplate
.libs/$(3)/$(1).framework.stamp: $$(foreach rid,$$($(3)_XC_RUNTIMEIDENTIFIERS),.libs/$$(rid)/$(1).framework.stamp) | .libs/$(3)
	$$(Q) rm -Rf .libs/$(3)/$(1).framework
	$$(Q) $(CP) -R .libs/$$(firstword $$($(3)_XC_RUNTIMEIDENTIFIERS))/$(1).framework .libs/$(3)/$(1).framework
ifneq ($$(words $($(3)_XC_RUNTIMEIDENTIFIERS)),1)
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/lipo $$(foreach rid,$$($(3)_XC_RUNTIMEIDENTIFIERS),.libs/$$(rid)/$(1).framework$($(3)_BINARY_INFIX)/$(1)) -create -output .libs/$(3)/$(1).framework$($(3)_BINARY_INFIX)/$(1)
endif
	$$(Q) touch $$@

$(1)_XCPLATFORMS += $(3)
$(1)_XCTARGETS += .libs/$(3)/$(1).framework.stamp
$(1)_XCFRAMEWORKS += -framework .libs/$(3)/$(1).framework
endef

# 1: name
# 2: sdk platform (iphoneos, iphonesimulator, tvos, tvsimulator, maccatalyst, mac)
# 3: platform as used by xcframework
$(foreach name,$(NAMES),$(foreach platform,$(DOTNET_PLATFORMS),$(foreach xcplatform,$(DOTNET_$(platform)_SDK_PLATFORMS),$(eval $(call DotNetXCTemplate,$(name),$(platform),$(xcplatform))))))

$(foreach platform,$(DOTNET_PLATFORMS),$(foreach xcplatform,$(DOTNET_$(platform)_SDK_PLATFORMS),.libs/$(xcplatform))):
	$(Q) mkdir -p $@

$(foreach platform,$(DOTNET_PLATFORMS),$(foreach rid,$(DOTNET_$(platform)_RUNTIME_IDENTIFIERS),.libs/$(rid))):
	$(Q) mkdir -p $@

define DotNetXCFrameworkTemplate
.libs/$(1).xcframework.stamp: $$($(1)_XCTARGETS) Makefile
	$$(Q) rm -rf .libs/$(1).xcframework
	$$(Q_GEN) $(XCODE_DEVELOPER_ROOT)/usr/bin/xcodebuild -quiet -create-xcframework $$($(1)_XCFRAMEWORKS) -output .libs/$(1).xcframework
	$$(Q) touch $$@

.libs/$(1).xcframework.zip: .libs/$(1).xcframework.stamp
	$$(Q) cd $$(dir $$@) && zip -9r $$(notdir $$@) $(1).xcframework

ZIPPED_TARGETS += .libs/$(1).xcframework.zip

all-local:: .libs/$(1).xcframework.stamp
endef

$(foreach name,$(NAMES),$(eval $(call DotNetXCFrameworkTemplate,$(name))))

zip: $(ZIPPED_TARGETS)
all-local:: $(ZIPPED_TARGETS)
