# helpful rules to compile things for the various architectures

ifdef ENABLE_CCACHE
# Note the space at the end the line
CCACHE=ccache 
endif

iossimulator_SDK=$(XCODE_DEVELOPER_ROOT)/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator$(IOS_SDK_VERSION).sdk
ios_SDK=$(XCODE_DEVELOPER_ROOT)/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS$(IOS_SDK_VERSION).sdk
tvossimulator_SDK=$(XCODE_DEVELOPER_ROOT)/Platforms/AppleTVSimulator.platform/Developer/SDKs/AppleTVSimulator$(TVOS_SDK_VERSION).sdk
tvos_SDK=$(XCODE_DEVELOPER_ROOT)/Platforms/AppleTVOS.platform/Developer/SDKs/AppleTVOS$(TVOS_SDK_VERSION).sdk
maccatalyst_SDK=$(XCODE_DEVELOPER_ROOT)/Platforms/MacOSX.platform/Developer/SDKs/MacOSX$(MACOS_SDK_VERSION).sdk
macos_SDK=$(XCODE_DEVELOPER_ROOT)/Platforms/MacOSX.platform/Developer/SDKs/MacOSX$(MACOS_SDK_VERSION).sdk

ios_DEFINES=-DMONOTOUCH
tvos_DEFINES=-DMONOTOUCH
maccatalyst_DEFINES=-DMONOTOUCH
macos_DEFINES=-DMONOMAC


# Clang will by default emit objc_msgSend stubs in Xcode 14, which ld from earlier Xcodes doesn't understand.
# We disable this by passing -fno-objc-msgsend-selector-stubs to clang.
# We can probably remove this flag once we require developers to use Xcode 14.
# Ref: https://github.com/xamarin/xamarin-macios/issues/16223
OBJC_CFLAGS=-ObjC++ -std=c++14 -fno-exceptions -fno-objc-msgsend-selector-stubs -fobjc-abi-version=2 -fobjc-legacy-dispatch
CFLAGS= -Wall -fms-extensions -Werror -Wconversion -Wdeprecated -Wuninitialized -fstack-protector-strong -Wformat -Wformat-security -Werror=format-security -g -I.
SWIFTFLAGS=-g -emit-library

SWIFT_TOOLCHAIN_iossimulator=iphonesimulator
SWIFT_TOOLCHAIN_ios=iphoneos
SWIFT_TOOLCHAIN_maccatalyst=macosx
SWIFT_TOOLCHAIN_tvossimulator=appletvsimulator
SWIFT_TOOLCHAIN_tvos=appletvos
SWIFT_TOOLCHAIN_macos=macosx

# iOS

# macOS

# tvOS

# Mac Catalyst

## Mac Catalyst is special :/

maccatalyst_CFLAGS += \
	-isystem $(macos_SDK)/System/iOSSupport/usr/include \
	-iframework $(macos_SDK)/System/iOSSupport/System/Library/Frameworks \

maccatalyst_SWIFTFLAGS += -Fsystem $(macos_SDK)/System/iOSSupport/System/Library/Frameworks

# Common

# 1: xcframework platform
# 2: platform
# 3: PLATFORM (platform uppercased)
define FlagsTemplate1
$(1)_CFLAGS += \
	-isysroot $($(1)_SDK) \
	$(CFLAGS) \
	$($(2)_DEFINES) \
	-L$($(1)_SDK)/usr/lib/swift \
	-L$(XCODE_DEVELOPER_ROOT)/Toolchains/XcodeDefault.xctoolchain/usr/lib/swift/$(SWIFT_TOOLCHAIN_$(1)) \
	-Wno-unused-command-line-argument

$(1)_SWIFTFLAGS += $(SWIFTFLAGS) -sdk $($(1)_SDK)

flags::
	@printf "$(1) = $(2) = $(3) = \n\t$(1)_CFLAGS=$$($(1)_CFLAGS)\n\t$(1)_SWIFTFLAGS=$$($(1)_SWIFTFLAGS)\n"
endef
$(foreach xcframeworkPlatform,$(XCFRAMEWORK_PLATFORMS),$(eval $(call FlagsTemplate1,$(xcframeworkPlatform),$(DOTNET_$(xcframeworkPlatform)_PLATFORM),$(shell echo $(DOTNET_$(xcframeworkPlatform)_PLATFORM) | tr 'a-z' 'A-Z'))))

# 1: xcframework platform
# 2: platform
# 3: PLATFORM (platform uppercased)
# 4: runtime identifier
define FlagsTemplate2
$(4)_CFLAGS += $$($(1)_CFLAGS) -arch $(DOTNET_$(4)_ARCHITECTURES) $(CLANG_$(4)_VERSION_MIN)
$(4)_OBJC_FLAGS += $$($(4)_CFLAGS) $(OBJC_CFLAGS)
$(4)_SWIFTFLAGS += $$($(1)_SWIFTFLAGS) $(SWIFTC_$(4)_VERSION_MIN)

flags::
	@printf "$(1) = $(2) = $(3) = $(4)\n\t$(4)_CFLAGS=$$($(4)_CFLAGS)\n\t$(4)_OBJC_FLAGS=$$($(4)_OBJC_FLAGS)\n\t$(4)_SWIFTFLAGS=$$($(4)_SWIFTFLAGS)\n"
endef
$(foreach xcframeworkPlatform,$(XCFRAMEWORK_PLATFORMS),$(foreach rid,$(XCFRAMEWORK_$(xcframeworkPlatform)_RUNTIME_IDENTIFIERS),$(eval $(call FlagsTemplate2,$(xcframeworkPlatform),$(DOTNET_$(xcframeworkPlatform)_PLATFORM),$(shell echo $(DOTNET_$(xcframeworkPlatform)_PLATFORM) | tr 'a-z' 'A-Z'),$(rid)))))

DEBUG_FLAGS=-DDEBUG -D_LIBCPP_HARDENING_MODE=_LIBCPP_HARDENING_MODE_DEBUG
RELEASE_FLAGS=-O2 -D_LIBCPP_HARDENING_MODE=_LIBCPP_HARDENING_MODE_FAST

# 1: xcframework platform
# 2: platform
# 3: PLATFORM (platform uppercased)
# 1: runtime identifier
# 2: suffix
# 3: additional compiler flags
define NativeCompilationTemplate
# Compile Objective-C source (.m) into object file (.o)
.libs/$(1)/%$(2).o: %.m $(EXTRA_DEPENDENCIES) | .libs/$(1)
	$$(call Q_2,OBJC,  [$(1)]) $(CLANG) $$($(1)_OBJC_FLAGS) $$(EXTRA_DEFINES) $(3) -c $$< -o $$@

# Compile C source (.c) into object file (.o)
.libs/$(1)/%$(2).o: %.c $(EXTRA_DEPENDENCIES) | .libs/$(1)
	$$(call Q_2,CC,    [$(1)]) $(CLANG) $$($(1)_CFLAGS) $$(EXTRA_DEFINES) $(3) -c $$< -o $$@

# Compile Assembly source (.s) into object file (.o)
.libs/$(1)/%$(2).o: %.s $(EXTRA_DEPENDENCIES) | .libs/$(1)
	$$(call Q_2,ASM,   [$(1)]) $(CLANG) $$($(1)_CFLAGS)                   $(3) -c $$< -o $$@

# Compile Swift source (.swift) into dynamic library (.dylib)
.libs/$(1)/%$(2).dylib: %.swift | .libs/$(1)
	$$(call Q_2,SWIFT, [$(1)]) $(SWIFTC) $$($(1)_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS) $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# Compile Swift source (.swift) into object file (.o)
.libs/$(1)/%$(2).o: %.swift | .libs/$(1)
	$$(call Q_2,SWIFT, [$(1)]) $(SWIFTC) $$($(1)_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS) $$< -o $$@ -emit-object

# Compile anything into dynamic library (.dylib) using clang.
# Set the dependencies for this target to add source code to be compiled or other libraries or object files to be linked into the resulting dylib.
.libs/$(1)/%$(2).dylib: | .libs/$(1)
	$$(call Q_2,LD,    [$(1)]) $(CLANG) $$($(1)_CFLAGS) $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation
endef
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),,-O2)))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-debug,$(DEBUG_FLAGS))))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-dotnet,$(RELEASE_FLAGS) -DDOTNET)))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-dotnet-debug,$(DEBUG_FLAGS) -DDOTNET)))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-dotnet-coreclr,$(RELEASE_FLAGS) -DCORECLR_RUNTIME -DDOTNET)))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-dotnet-coreclr-debug,$(DEBUG_FLAGS) -DCORECLR_RUNTIME -DDOTNET)))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-dotnet-nativeaot,$(RELEASE_FLAGS) -DCORECLR_RUNTIME -DDOTNET -DNATIVEAOT)))
$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),$(eval $(call NativeCompilationTemplate,$(rid),-dotnet-nativeaot-debug,$(DEBUG_FLAGS) -DCORECLR_RUNTIME -DDOTNET -DNATIVEAOT)))

# define NativeCompilationTemplate

# ## ios simulator

# ### X64

# .libs/iossimulator-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/iossimulator-x64
# 	$$(call Q_2,OBJC,  [iossimulator-x64]) $(CLANG) $(SIMULATOR64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/iossimulator-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/iossimulator-x64
# 	$$(call Q_2,CC,    [iossimulator-x64]) $(CLANG) $(SIMULATOR64_CFLAGS)      $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/iossimulator-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/iossimulator-x64
# 	$$(call Q_2,ASM,   [iossimulator-x64]) $(CLANG) $(SIMULATOR64_CFLAGS)      $(2) -c $$< -o $$@

# .libs/iossimulator-x64/%$(1).dylib: %.swift | .libs/iossimulator-x64
# 	$$(call Q_2,SWIFT, [iossimulator-x64]) $(SWIFTC)       $(IOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                 $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/iossimulator-x64/%$(1).o: %.swift | .libs/iossimulator-x64
# 	$$(call Q_2,SWIFT, [iossimulator-x64]) $(SWIFTC)       $(IOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                 $$< -o $$@ -emit-object

# .libs/iossimulator-x64/%$(1).dylib: | .libs/iossimulator-x64
# 	$$(call Q_2,LD,    [iossimulator-x64]) $(CLANG) $(SIMULATOR64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ### ARM64

# .libs/iossimulator-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/iossimulator-arm64
# 	$$(call Q_2,OBJC,  [iossimulator-arm64]) $(CLANG) $(SIMULATOR_ARM64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/iossimulator-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/iossimulator-arm64
# 	$$(call Q_2,CC,    [iossimulator-arm64]) $(CLANG) $(SIMULATOR_ARM64_CFLAGS)      $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/iossimulator-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/iossimulator-arm64
# 	$$(call Q_2,ASM,   [iossimulator-arm64]) $(CLANG) $(SIMULATOR_ARM64_CFLAGS)      $(2) -c $$< -o $$@

# .libs/iossimulator-arm64/%$(1).dylib: %.swift | .libs/iossimulator-arm64
# 	$$(call Q_2,SWIFT, [iossimulator-arm64]) $(SWIFTC)       $(IOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/iossimulator-arm64/%$(1).o: %.swift | .libs/iossimulator-arm64
# 	$$(call Q_2,SWIFT, [iossimulator-arm64]) $(SWIFTC)       $(IOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                    $$< -o $$@ -emit-object

# .libs/iossimulator-arm64/%$(1).dylib: | .libs/iossimulator-arm64
# 	$$(call Q_2,LD,    [iossimulator-arm64]) $(CLANG) $(SIMULATOR_ARM64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ## ios device

# .libs/ios-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/ios-arm64
# 	$$(call Q_2,OBJC,  [ios-arm64]) $(CLANG) $(DEVICE64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/ios-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/ios-arm64
# 	$$(call Q_2,CC,    [ios-arm64]) $(CLANG) $(DEVICE64_CFLAGS)      $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/ios-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/ios-arm64
# 	$$(call Q_2,ASM,   [ios-arm64]) $(CLANG) $(DEVICE64_CFLAGS)      $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/ios-arm64/%$(1).dylib: %.swift | .libs/ios-arm64
# 	$$(call Q_2,SWIFT, [ios-arm64]) $(SWIFTC)    $(IOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                  $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/ios-arm64/%$(1).o: %.swift | .libs/ios-arm64
# 	$$(call Q_2,SWIFT, [ios-arm64]) $(SWIFTC)    $(IOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                  $$< -o $$@ -emit-object

# .libs/ios-arm64/%$(1).dylib: | .libs/ios-arm64
# 	$$(call Q_2,LD,    [ios-arm64]) $(CLANG) $(DEVICE64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ## maccatalyst (ios on macOS / Catalyst)

# .libs/maccatalyst-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-x64
# 	$$(call Q_2,OBJC,  [maccatalyst-x64]) $(CLANG) $(MACCATALYST_X86_64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/maccatalyst-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-x64
# 	$$(call Q_2,CC,    [maccatalyst-x64]) $(CLANG) $(MACCATALYST_X86_64_CFLAGS)      $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/maccatalyst-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-x64
# 	$$(call Q_2,ASM,   [maccatalyst-x64]) $(CLANG) $(MACCATALYST_X86_64_CFLAGS)                        $(2) -c $$< -o $$@

# .libs/maccatalyst-x64/%$(1).dylib: %.swift | .libs/maccatalyst-x64
# 	$$(call Q_2,SWIFT, [maccatalyst-x64]) $(SWIFTC)   $(MACCATALYST_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                              $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/maccatalyst-x64/%$(1).o: %.swift | .libs/maccatalyst-x64
# 	$$(call Q_2,SWIFT, [maccatalyst-x64]) $(SWIFTC)   $(MACCATALYST_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                              $$< -o $$@ -emit-object

# .libs/maccatalyst-x64/%$(1).dylib: | .libs/maccatalyst-x64
# 	$$(call Q_2,LD,    [maccatalyst-x64]) $(CLANG) $(MACCATALYST_X86_64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# .libs/maccatalyst-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-arm64
# 	$$(call Q_2,OBJC,  [maccatalyst-arm64]) $(CLANG) $(MACCATALYST_ARM64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/maccatalyst-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-arm64
# 	$$(call Q_2,CC,    [maccatalyst-arm64]) $(CLANG) $(MACCATALYST_ARM64_CFLAGS)      $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/maccatalyst-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-arm64
# 	$$(call Q_2,ASM,   [maccatalyst-arm64]) $(CLANG) $(MACCATALYST_ARM64_CFLAGS)                        $(2) -c $$< -o $$@

# .libs/maccatalyst-arm64/%$(1).dylib: %.swift | .libs/maccatalyst-arm64
# 	$$(call Q_2,SWIFT, [maccatalyst-arm64]) $(SWIFTC)   $(MACCATALYST_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                           $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/maccatalyst-arm64/%$(1).o: %.swift | .libs/maccatalyst-arm64
# 	$$(call Q_2,SWIFT, [maccatalyst-arm64]) $(SWIFTC)   $(MACCATALYST_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                           $$< -o $$@ -emit-object

# .libs/maccatalyst-arm64/%$(1).dylib: | .libs/maccatalyst-arm64
# 	$$(call Q_2,LD,    [maccatalyst-arm64]) $(CLANG) $(MACCATALYST_ARM64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ## tv simulator

# ### X64

# .libs/tvossimulator-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-x64
# 	$$(call Q_2,OBJC,  [tvossimulator-x64]) $(CLANG) $(SIMULATORTV_OBJC_CFLAGS)    $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/tvossimulator-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-x64
# 	$$(call Q_2,CC,    [tvossimulator-x64]) $(CLANG) $(SIMULATORTV_CFLAGS)         $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/tvossimulator-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-x64
# 	$$(call Q_2,ASM,   [tvossimulator-x64]) $(CLANG) $(SIMULATORTV_CFLAGS)         $$(EXTRA_DEFINES) $(2) -c $$< -o $$@

# .libs/tvossimulator-x64/%$(1).dylib: %.swift | .libs/tvossimulator-x64
# 	$$(call Q_2,SWIFT, [tvossimulator-x64]) $(SWIFTC)      $(TVOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                        $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/tvossimulator-x64/%$(1).o: %.swift | .libs/tvossimulator-x64
# 	$$(call Q_2,SWIFT, [tvossimulator-x64]) $(SWIFTC)      $(TVOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                        $$< -o $$@ -emit-object

# .libs/tvossimulator-x64/%$(1).dylib: | .libs/tvossimulator-x64
# 	$$(call Q_2,LD,    [tvossimulator-x64]) $(CLANG) $(SIMULATORTV_CFLAGS)         $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ### ARM64

# .libs/tvossimulator-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-arm64
# 	$$(call Q_2,OBJC,  [tvossimulator-arm64]) $(CLANG) $(SIMULATORTV_ARM64_OBJC_CFLAGS)    $$(EXTRA_DEFINES) -g $(2) -c $$< -o $$@

# .libs/tvossimulator-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-arm64
# 	$$(call Q_2,CC,    [tvossimulator-arm64]) $(CLANG) $(SIMULATORTV_ARM64_CFLAGS)         $$(EXTRA_DEFINES) -g $(2) -c $$< -o $$@

# .libs/tvossimulator-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-arm64
# 	$$(call Q_2,ASM,   [tvossimulator-arm64]) $(CLANG) $(SIMULATORTV_ARM64_CFLAGS)         $$(EXTRA_DEFINES) -g $(2) -c $$< -o $$@

# .libs/tvossimulator-arm64/%$(1).dylib: %.swift | .libs/tvossimulator-arm64
# 	$$(call Q_2,SWIFT, [tvossimulator-arm64]) $(SWIFTC)      $(TVOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                  $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/tvossimulator-arm64/%$(1).o: %.swift | .libs/tvossimulator-arm64
# 	$$(call Q_2,SWIFT, [tvossimulator-arm64]) $(SWIFTC)      $(TVOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                  $$< -o $$@ -emit-object

# .libs/tvossimulator-arm64/%$(1).dylib: | .libs/tvossimulator-arm64
# 	$$(call Q_2,LD,    [tvossimulator-arm64]) $(CLANG) $(SIMULATORTV_ARM64_CFLAGS)         $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ## tv device

# .libs/tvos-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/tvos-arm64
# 	$$(call Q_2,OBJC,  [tvos-arm64]) $(CLANG)    $(DEVICETV_OBJC_CFLAGS)       $$(EXTRA_DEFINES) -c $$< -o $$@

# .libs/tvos-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/tvos-arm64
# 	$$(call Q_2,CC,    [tvos-arm64]) $(CLANG)    $(DEVICETV_CFLAGS)            $$(EXTRA_DEFINES) -c $$< -o $$@

# .libs/tvos-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/tvos-arm64
# 	$$(call Q_2,ASM,   [tvos-arm64]) $(CLANG)    $(DEVICETV_CFLAGS)            $$(EXTRA_DEFINES) -c $$< -o $$@

# .libs/tvos-arm64/%$(1).dylib: %.swift | .libs/tvos-arm64
# 	$$(call Q_2,SWIFT, [tvos-arm64]) $(SWIFTC)      $(TVOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                         $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/tvos-arm64/%$(1).o: %.swift | .libs/tvos-arm64
# 	$$(call Q_2,SWIFT, [tvos-arm64]) $(SWIFTC)      $(TVOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                         $$< -o $$@ -emit-object

# .libs/tvos-arm64/%$(1).dylib: | .libs/tvos-arm64
# 	$$(call Q_2,LD,    [tvos-arm64]) $(CLANG)    $(DEVICETV_CFLAGS)            $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# ## macOS

# .libs/osx-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/osx-x64
# 	$$(call Q_2,OBJC,  [osx-x64]) $(MAC_CC) $(MAC_OBJC_CFLAGS) $$(EXTRA_DEFINES) -arch x86_64 $(2) -c $$< -o $$@

# .libs/osx-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/osx-x64
# 	$$(call Q_2,CC,    [osx-x64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_DEFINES) -arch x86_64 $(2) -c $$< -o $$@

# .libs/osx-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/osx-x64
# 	$$(call Q_2,ASM,   [osx-x64]) $(MAC_CC) $(MAC_CFLAGS)                        -arch x86_64 $(2) -c $$< -o $$@

# .libs/osx-x64/%$(1).dylib: %.swift | .libs/osx-x64
# 	$$(call Q_2,SWIFT, [osx-x64]) $(SWIFTC) $(MACOS_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                 $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/osx-x64/%$(1).o: %.swift | .libs/osx-x64
# 	$$(call Q_2,SWIFT, [osx-x64]) $(SWIFTC) $(MACOS_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                 $$< -o $$@ -emit-object

# .libs/osx-x64/%$(1).dylib: | .libs/osx-x64
# 	$$(call Q_2,LD,    [osx-x64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_FLAGS) -arch x86_64 -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

# .libs/osx-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/osx-arm64
# 	$$(call Q_2,OBJC,  [osx-arm64]) $(MAC_CC) $(MAC_OBJC_CFLAGS) $$(EXTRA_DEFINES) -arch arm64 $(2) -c $$< -o $$@

# .libs/osx-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/osx-arm64
# 	$$(call Q_2,CC,    [osx-arm64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_DEFINES) -arch arm64 $(2) -c $$< -o $$@

# .libs/osx-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/osx-arm64
# 	$$(call Q_2,ASM,   [osx-arm64]) $(MAC_CC) $(MAC_CFLAGS)                        -arch arm64 $(2) -c $$< -o $$@

# .libs/osx-arm64/%$(1).dylib: %.swift | .libs/osx-arm64
# 	$$(call Q_2,SWIFT, [osx-arm64]) $(SWIFTC) $(MACOS_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

# .libs/osx-arm64/%$(1).o: %.swift | .libs/osx-arm64
# 	$$(call Q_2,SWIFT, [osx-arm64]) $(SWIFTC) $(MACOS_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                $$< -o $$@ -emit-object

# .libs/osx-arm64/%$(1).dylib: | .libs/osx-arm64
# 	$$(call Q_2,LD,    [osx-arm64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_FLAGS) -arch arm64 -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation
# endef

# $(eval $(call NativeCompilationTemplate,,-O2))
# $(eval $(call NativeCompilationTemplate,-debug,$(DEBUG_FLAGS)))
# $(eval $(call NativeCompilationTemplate,-dotnet,$(RELEASE_FLAGS) -DDOTNET))
# $(eval $(call NativeCompilationTemplate,-dotnet-debug,$(DEBUG_FLAGS) -DDOTNET))
# $(eval $(call NativeCompilationTemplate,-dotnet-coreclr,$(RELEASE_FLAGS) -DCORECLR_RUNTIME -DDOTNET))
# $(eval $(call NativeCompilationTemplate,-dotnet-coreclr-debug,$(DEBUG_FLAGS) -DCORECLR_RUNTIME -DDOTNET))
# $(eval $(call NativeCompilationTemplate,-dotnet-nativeaot,$(RELEASE_FLAGS) -DCORECLR_RUNTIME -DDOTNET -DNATIVEAOT))
# $(eval $(call NativeCompilationTemplate,-dotnet-nativeaot-debug,$(DEBUG_FLAGS) -DCORECLR_RUNTIME -DDOTNET -DNATIVEAOT))

%.csproj.inc: %.csproj $(TOP)/Make.config $(TOP)/mk/mono.mk $(TOP)/tools/common/create-makefile-fragment.sh
	$(Q) $(TOP)/tools/common/create-makefile-fragment.sh $(abspath $<) $(abspath $@)

DIRS = \
	$(foreach xcframeworkPlatform,$(XCFRAMEWORK_PLATFORMS),.libs/$(xcframeworkPlatform)) \
	$(foreach platform,$(DOTNET_PLATFORMS),$(foreach xcplatform,$(DOTNET_$(platform)_SDK_PLATFORMS),.libs/$(xcplatform))) \
	$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),.libs/$(rid)) \

$(sort $(DIRS)):
	$(Q) mkdir -p $@
