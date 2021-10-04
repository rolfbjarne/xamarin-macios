TOP=../../..
include $(TOP)/Make.config

NAME=XTest2

define Template

$(1)_$(NAME)_TARGETS += \
	.libs/$(1)/$(NAME).framework$($(2)_BINARY_INFIX)/$(NAME) \
	.libs/$(1)/$(NAME).framework$($(2)_INFO_PLIST_INFIX)/Info.plist \
	.libs/$(1)/lib$(NAME).dylib \
	.libs/$(1)/$(NAME).framework \

$(1)_TARGETS += \
	$($(1)_$(NAME)_TARGETS) \
	.libs/$(1)/$(NAME).framework.stamp \

all-local:: $$($(1)_TARGETS)

.libs/$(1)/$(NAME).framework.stamp: $$($(1)_$(NAME)_TARGETS)
	$$(Q) touch $$@

COMMON_DYLIB_ARGS=-g -dynamiclib -gdwarf-2 -fms-extensions $(NAME).c -o $$@ -Wall -framework Foundation -lz
.libs/$(1)/x86/lib$(NAME).dylib: ARCH=i386
.libs/$(1)/%/lib$(NAME).dylib: $(NAME).c | .libs/$(1)/%
	$$(call Q_2,CC,    [$(1)]) $$(XCODE_CC) $$(COMMON_DYLIB_ARGS) -arch $$(if $$(ARCH),$$(ARCH),$$*) $(4) $$($(2)_$$(shell echo $$* | tr a-z A-Z)_OBJC_CFLAGS)
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/install_name_tool -id @rpath/libtest.dylib $$@

.libs/$(1)/lib$(NAME).dylib: $$(foreach arch,$(3),.libs/$(1)/$$(arch)/lib$(NAME).dylib)
	$$(call Q_2,LIPO   [$(1)]) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/lipo $$^ -create -output $$@

.libs/$(1)/$(NAME).framework$($(2)_BINARY_INFIX)/$(NAME): .libs/$(1)/lib$(NAME).dylib | .libs/$(1)/$(NAME).framework$($(2)_BINARY_INFIX)
	$$(Q) $(CP) $$^ $$@
	$$(Q) $(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/bin/install_name_tool -id @rpath/$(NAME).framework/$(NAME) $$@

.libs/$(1)/$(NAME).framework$($(2)_INFO_PLIST_INFIX)/Info.plist: $(NAME)-Info-$(1).plist | .libs/$(1)/$(NAME).framework$($(2)_INFO_PLIST_INFIX)
	$$(Q) $(CP) $$^ $$@

$(1)_XTEST2_DIRECTORIES = \
	.libs/$(1)/$(NAME).framework \
	.libs/$(1)/$(NAME).framework/Versions \
	$$(foreach arch,$(3),.libs/$(1)/$$(arch)) \

$$($(1)_XTEST2_DIRECTORIES):
	$$(Q) mkdir -p $$@

endef

# 1: platform infix
# 2: platform variable
# 3: architectures
# 4: extra clang arguments
ifdef INCLUDE_IOS
$(eval $(call Template,iphonesimulator,IOSSIMULATOR,x86 x86_64,-mios-simulator-version-min=8.0 -isysroot $(SIMULATOR_SDK)))
$(eval $(call Template,iphoneos,IPHONEOS,armv7 armv7s arm64,-miphoneos-version-min=8.0 -isysroot $(DEVICE_SDK)))
XCPLATFORMS+= iphoneos iphonesimulator
endif
ifdef INCLUDE_TVOS
$(eval $(call Template,tvsimulator,TVSIMULATOR,x86_64,-mtvos-simulator-version-min=9.0 -isysroot $(SIMULATORTV_SDK)))
$(eval $(call Template,tvos,TVOS,arm64,-mtvos-version-min=9.0 -fembed-bitcode -isysroot $(DEVICETV_SDK)))
XCPLATFORMS+= tvos tvsimulator
endif
ifdef INCLUDE_WATCH
$(eval $(call Template,watchsimulator,WATCHSIMULATOR,x86 x86_64,-mwatchos-simulator-version-min=2.0 -isysroot $(SIMULATORWATCH_SDK)))
$(eval $(call Template,watchos,WATCHOS,armv7k arm64_32,-mwatchos-version-min=2.0 -fembed-bitcode -isysroot $(DEVICEWATCH_SDK)))
XCPLATFORMS+= watchos watchsimulator
endif
ifdef INCLUDE_MAC
$(eval $(call Template,macos,MACOS,x86_64 arm64,-mmacosx-version-min=$(MIN_OSX_VERSION_FOR_MAC) -isysroot $(XCODE_DEVELOPER_ROOT)/Platforms/MacOSX.platform/Developer/SDKs/MacOSX$(OSX_SDK_VERSION).sdk))
XCPLATFORMS+= macos
endif
ifdef INCLUDE_MACCATALYST
$(eval $(call Template,maccatalyst,MACCATALYST,x86_64 arm64,$(MACCATALYST_COMMON_CFLAGS)))
XCPLATFORMS+= maccatalyst
endif

$(NAME)_XCFRAMEWORKS = $(foreach platform,$(XCPLATFORMS),-framework .libs/$(platform)/$(NAME).framework)
$(NAME)_XCTARGETS = $(foreach platform,$(XCPLATFORMS),.libs/$(platform)/$(NAME).framework.stamp) \

.libs/$(NAME).xcframework: $($(NAME)_XCTARGETS) Makefile
	$(Q) rm -rf $@
	$(Q_GEN) $(XCODE_DEVELOPER_ROOT)/usr/bin/xcodebuild -quiet -create-xcframework $($(NAME)_XCFRAMEWORKS) -output $@

all-local:: .libs/$(NAME).xcframework

include $(TOP)/mk/rules.mk
