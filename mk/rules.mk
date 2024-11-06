# helpful rules to compile things for the various architectures

COMMON_I:= -I.
SIM32_I := $(COMMON_I)
SIM64_I := $(COMMON_I)
SIM_ARM64_I := $(COMMON_I)
DEV7_I  := $(COMMON_I)
DEV7s_I := $(COMMON_I)
DEV64_I := $(COMMON_I)

SIMW_I  := $(COMMON_I)
SIMW64_I  := $(COMMON_I)
DEVW_I  := $(COMMON_I)
DEVW64_32_I := $(COMMON_I)

SIM_TV_I:= $(COMMON_I)
SIM_ARM64_TV_I := $(COMMON_I)
DEV_TV_I:= $(COMMON_I)

define NativeCompilationTemplate

## ios simulator

### X64

.libs/iossimulator-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/iossimulator-x64
	$$(call Q_2,OBJC,  [iossimulator-x64]) $(SIMULATOR_CC) $(SIMULATOR64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(SIM64_I) -g $(2) -c $$< -o $$@

.libs/iossimulator-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/iossimulator-x64
	$$(call Q_2,CC,    [iossimulator-x64]) $(SIMULATOR_CC) $(SIMULATOR64_CFLAGS)      $$(EXTRA_DEFINES) $(SIM64_I) -g $(2) -c $$< -o $$@

.libs/iossimulator-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/iossimulator-x64
	$$(call Q_2,ASM,   [iossimulator-x64]) $(SIMULATOR_CC) $(SIMULATOR64_CFLAGS)      $(SIM64_I) -g $(2) -c $$< -o $$@

.libs/iossimulator-x64/%$(1).dylib: %.swift | .libs/iossimulator-x64
	$$(call Q_2,SWIFT, [iossimulator-x64$(1)]) $(SWIFTC)       $(IOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                 $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/iossimulator-x64/%$(1).o: %.swift | .libs/iossimulator-x64
	$$(call Q_2,SWIFT, [iossimulator-x64$(1)]) $(SWIFTC)       $(IOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                 $$< -o $$@ -emit-object

.libs/iossimulator-x64/%$(1).dylib: | .libs/iossimulator-x64
	$$(call Q_2,LD,    [iossimulator-x64]) $(SIMULATOR_CC) $(SIMULATOR64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

### ARM64

.libs/iossimulator-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/iossimulator-arm64
	$$(call Q_2,OBJC,  [iossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATOR_ARM64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(SIM_ARM64_I) -g $(2) -c $$< -o $$@

.libs/iossimulator-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/iossimulator-arm64
	$$(call Q_2,CC,    [iossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATOR_ARM64_CFLAGS)      $$(EXTRA_DEFINES) $(SIM_ARM64_I) -g $(2) -c $$< -o $$@

.libs/iossimulator-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/iossimulator-arm64
	$$(call Q_2,ASM,   [iossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATOR_ARM64_CFLAGS)      $(SIM64_I) -g $(2) -c $$< -o $$@

.libs/iossimulator-arm64/%$(1).dylib: %.swift | .libs/iossimulator-arm64
	$$(call Q_2,SWIFT, [iossimulator-arm64]) $(SWIFTC)       $(IOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/iossimulator-arm64/%$(1).o: %.swift | .libs/iossimulator-arm64
	$$(call Q_2,SWIFT, [iossimulator-arm64]) $(SWIFTC)       $(IOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                    $$< -o $$@ -emit-object

.libs/iossimulator-arm64/%$(1).dylib: | .libs/iossimulator-arm64
	$$(call Q_2,LD,    [iossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATOR_ARM64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

## ios device

.libs/ios-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/ios-arm64
	$$(call Q_2,OBJC,  [ios-arm64]) $(DEVICE_CC) $(DEVICE64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(DEV64_I) -g $(2) -c $$< -o $$@

.libs/ios-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/ios-arm64
	$$(call Q_2,CC,    [ios-arm64]) $(DEVICE_CC) $(DEVICE64_CFLAGS)      $$(EXTRA_DEFINES) $(DEV64_I) -g $(2) -c $$< -o $$@

.libs/ios-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/ios-arm64
	$$(call Q_2,ASM,   [ios-arm64]) $(DEVICE_CC) $(DEVICE64_CFLAGS)      $$(EXTRA_DEFINES) $(DEV64_I) -g $(2) -c $$< -o $$@

.libs/ios-arm64/%$(1).dylib: %.swift | .libs/ios-arm64
	$$(call Q_2,SWIFT, [ios-arm64]) $(SWIFTC)    $(IOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                  $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/ios-arm64/%$(1).o: %.swift | .libs/ios-arm64
	$$(call Q_2,SWIFT, [ios-arm64]) $(SWIFTC)    $(IOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                  $$< -o $$@ -emit-object

.libs/ios-arm64/%$(1).dylib: | .libs/ios-arm64
	$$(call Q_2,LD,    [ios-arm64]) $(DEVICE_CC) $(DEVICE64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

## maccatalyst (ios on macOS / Catalyst)

.libs/maccatalyst-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-x64
	$$(call Q_2,OBJC,  [maccatalyst-x64]) $(XCODE_CC) $(MACCATALYST_X86_64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/maccatalyst-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-x64
	$$(call Q_2,CC,    [maccatalyst-x64]) $(XCODE_CC) $(MACCATALYST_X86_64_CFLAGS)      $$(EXTRA_DEFINES) $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/maccatalyst-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-x64
	$$(call Q_2,ASM,   [maccatalyst-x64]) $(XCODE_CC) $(MACCATALYST_X86_64_CFLAGS)                        $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/maccatalyst-x64/%$(1).dylib: %.swift | .libs/maccatalyst-x64
	$$(call Q_2,SWIFT, [maccatalyst-x64]) $(SWIFTC)   $(MACCATALYST_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                              $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/maccatalyst-x64/%$(1).o: %.swift | .libs/maccatalyst-x64
	$$(call Q_2,SWIFT, [maccatalyst-x64]) $(SWIFTC)   $(MACCATALYST_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                              $$< -o $$@ -emit-object

.libs/maccatalyst-x64/%$(1).dylib: | .libs/maccatalyst-x64
	$$(call Q_2,LD,    [maccatalyst-x64]) $(XCODE_CC) $(MACCATALYST_X86_64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

.libs/maccatalyst-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-arm64
	$$(call Q_2,OBJC,  [maccatalyst-arm64]) $(XCODE_CC) $(MACCATALYST_ARM64_OBJC_CFLAGS) $$(EXTRA_DEFINES) $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/maccatalyst-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-arm64
	$$(call Q_2,CC,    [maccatalyst-arm64]) $(XCODE_CC) $(MACCATALYST_ARM64_CFLAGS)      $$(EXTRA_DEFINES) $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/maccatalyst-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/maccatalyst-arm64
	$$(call Q_2,ASM,   [maccatalyst-arm64]) $(XCODE_CC) $(MACCATALYST_ARM64_CFLAGS)                        $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/maccatalyst-arm64/%$(1).dylib: %.swift | .libs/maccatalyst-arm64
	$$(call Q_2,SWIFT, [maccatalyst-arm64]) $(SWIFTC)   $(MACCATALYST_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                           $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/maccatalyst-arm64/%$(1).o: %.swift | .libs/maccatalyst-arm64
	$$(call Q_2,SWIFT, [maccatalyst-arm64]) $(SWIFTC)   $(MACCATALYST_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                           $$< -o $$@ -emit-object

.libs/maccatalyst-arm64/%$(1).dylib: | .libs/maccatalyst-arm64
	$$(call Q_2,LD,    [maccatalyst-arm64]) $(XCODE_CC) $(MACCATALYST_ARM64_CFLAGS)      $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

## tv simulator

### X64

.libs/tvossimulator-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-x64
	$$(call Q_2,OBJC,  [tvossimulator-x64]) $(SIMULATOR_CC) $(SIMULATORTV_OBJC_CFLAGS)    $$(EXTRA_DEFINES) $(SIM_TV_I) -g $(2) -c $$< -o $$@

.libs/tvossimulator-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-x64
	$$(call Q_2,CC,    [tvossimulator-x64]) $(SIMULATOR_CC) $(SIMULATORTV_CFLAGS)         $$(EXTRA_DEFINES) $(SIM_TV_I) -g $(2) -c $$< -o $$@

.libs/tvossimulator-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-x64
	$$(call Q_2,ASM,   [tvossimulator-x64]) $(SIMULATOR_CC) $(SIMULATORTV_CFLAGS)         $$(EXTRA_DEFINES) $(SIM_TV_I) -g $(2) -c $$< -o $$@

.libs/tvossimulator-x64/%$(1).dylib: %.swift | .libs/tvossimulator-x64
	$$(call Q_2,SWIFT, [tvossimulator-x64]) $(SWIFTC)      $(TVOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                        $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/tvossimulator-x64/%$(1).o: %.swift | .libs/tvossimulator-x64
	$$(call Q_2,SWIFT, [tvossimulator-x64]) $(SWIFTC)      $(TVOS_SIMULATOR_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                        $$< -o $$@ -emit-object

.libs/tvossimulator-x64/%$(1).dylib: | .libs/tvossimulator-x64
	$$(call Q_2,LD,    [tvossimulator-x64]) $(SIMULATOR_CC) $(SIMULATORTV_CFLAGS)         $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

### ARM64

.libs/tvossimulator-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-arm64
	$$(call Q_2,OBJC,  [tvossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATORTV_ARM64_OBJC_CFLAGS)    $$(EXTRA_DEFINES) $(SIM_ARM64_TV_I) -g $(2) -c $$< -o $$@

.libs/tvossimulator-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-arm64
	$$(call Q_2,CC,    [tvossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATORTV_ARM64_CFLAGS)         $$(EXTRA_DEFINES) $(SIM_ARM64_TV_I) -g $(2) -c $$< -o $$@

.libs/tvossimulator-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/tvossimulator-arm64
	$$(call Q_2,ASM,   [tvossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATORTV_ARM64_CFLAGS)         $$(EXTRA_DEFINES) $(SIM_ARM64_TV_I) -g $(2) -c $$< -o $$@

.libs/tvossimulator-arm64/%$(1).dylib: %.swift | .libs/tvossimulator-arm64
	$$(call Q_2,SWIFT, [tvossimulator-arm64]) $(SWIFTC)      $(TVOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                  $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/tvossimulator-arm64/%$(1).o: %.swift | .libs/tvossimulator-arm64
	$$(call Q_2,SWIFT, [tvossimulator-arm64]) $(SWIFTC)      $(TVOS_SIMULATOR_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                  $$< -o $$@ -emit-object

.libs/tvossimulator-arm64/%$(1).dylib: | .libs/tvossimulator-arm64
	$$(call Q_2,LD,    [tvossimulator-arm64]) $(SIMULATOR_CC) $(SIMULATORTV_ARM64_CFLAGS)         $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

## tv device

.libs/tvos-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/tvos-arm64
	$$(call Q_2,OBJC,  [tvos-arm64]) $(DEVICE_CC)       $(DEVICETV_OBJC_CFLAGS)       $$(EXTRA_DEFINES) $(DEV_TV_I) -g $(2) -c $$< -o $$@

.libs/tvos-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/tvos-arm64
	$$(call Q_2,CC,    [tvos-arm64]) $(DEVICE_CC)    $(DEVICETV_CFLAGS)            $$(EXTRA_DEFINES) $(DEV_TV_I) -g $(2) -c $$< -o $$@

.libs/tvos-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/tvos-arm64
	$$(call Q_2,ASM,   [tvos-arm64]) $(DEVICE_CC)    $(DEVICETV_CFLAGS)            $$(EXTRA_DEFINES) $(DEV_TV_I) -g $(2) -c $$< -o $$@

.libs/tvos-arm64/%$(1).dylib: %.swift | .libs/tvos-arm64
	$$(call Q_2,SWIFT, [tvos-arm64]) $(SWIFTC)      $(TVOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                         $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/tvos-arm64/%$(1).o: %.swift | .libs/tvos-arm64
	$$(call Q_2,SWIFT, [tvos-arm64]) $(SWIFTC)      $(TVOS_DEVICE_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                         $$< -o $$@ -emit-object

.libs/tvos-arm64/%$(1).dylib: | .libs/tvos-arm64
	$$(call Q_2,LD,    [tvos-arm64]) $(DEVICE_CC)    $(DEVICETV_CFLAGS)            $$(EXTRA_FLAGS) -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

## macOS

.libs/osx-x64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/osx-x64
	$$(call Q_2,OBJC,  [osx-x64]) $(MAC_CC) $(MAC_OBJC_CFLAGS) $$(EXTRA_DEFINES) -arch x86_64 $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/osx-x64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/osx-x64
	$$(call Q_2,CC,    [osx-x64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_DEFINES) -arch x86_64 $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/osx-x64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/osx-x64
	$$(call Q_2,ASM,   [osx-x64]) $(MAC_CC) $(MAC_CFLAGS)                        -arch x86_64  $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/osx-x64/%$(1).dylib: %.swift | .libs/osx-x64
	$$(call Q_2,SWIFT, [osx-x64]) $(SWIFTC) $(MACOS_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                 $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/osx-x64/%$(1).o: %.swift | .libs/osx-x64
	$$(call Q_2,SWIFT, [osx-x64]) $(SWIFTC) $(MACOS_X64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                 $$< -o $$@ -emit-object

.libs/osx-x64/%$(1).dylib: | .libs/osx-x64
	$$(call Q_2,LD,    [osx-x64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_FLAGS) -arch x86_64 -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation

.libs/osx-arm64/%$(1).o: %.m $(EXTRA_DEPENDENCIES) | .libs/osx-arm64
	$$(call Q_2,OBJC,  [osx-arm64]) $(MAC_CC) $(MAC_OBJC_CFLAGS) $$(EXTRA_DEFINES) -arch arm64 $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/osx-arm64/%$(1).o: %.c $(EXTRA_DEPENDENCIES) | .libs/osx-arm64
	$$(call Q_2,CC,    [osx-arm64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_DEFINES) -arch arm64 $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/osx-arm64/%$(1).o: %.s $(EXTRA_DEPENDENCIES) | .libs/osx-arm64
	$$(call Q_2,ASM,   [osx-arm64]) $(MAC_CC) $(MAC_CFLAGS)                        -arch arm64  $(COMMON_I) -g $(2) -c $$< -o $$@

.libs/osx-arm64/%$(1).dylib: %.swift | .libs/osx-arm64
	$$(call Q_2,SWIFT, [osx-arm64]) $(SWIFTC) $(MACOS_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                $$< -o $$@ -emit-module -L$$(dir $$@) -I$$(dir $$@) -module-name $$*

.libs/osx-arm64/%$(1).o: %.swift | .libs/osx-arm64
	$$(call Q_2,SWIFT, [osx-arm64]) $(SWIFTC) $(MACOS_ARM64_SWIFTFLAGS) $(EXTRA_SWIFTFLAGS) $$(EXTRA_$$*_FLAGS)                                                $$< -o $$@ -emit-object

.libs/osx-arm64/%$(1).dylib: | .libs/osx-arm64
	$$(call Q_2,LD,    [osx-arm64]) $(MAC_CC) $(MAC_CFLAGS)      $$(EXTRA_FLAGS) -arch arm64 -dynamiclib -o $$@ $$^ -fapplication-extension -framework Foundation
endef

DEBUG_FLAGS=-DDEBUG -D_LIBCPP_HARDENING_MODE=_LIBCPP_HARDENING_MODE_DEBUG
RELEASE_FLAGS=-O2 -D_LIBCPP_HARDENING_MODE=_LIBCPP_HARDENING_MODE_FAST

$(eval $(call NativeCompilationTemplate,,-O2))
$(eval $(call NativeCompilationTemplate,-debug,$(DEBUG_FLAGS)))
$(eval $(call NativeCompilationTemplate,-dotnet,$(RELEASE_FLAGS) -DDOTNET))
$(eval $(call NativeCompilationTemplate,-dotnet-debug,$(DEBUG_FLAGS) -DDOTNET))
$(eval $(call NativeCompilationTemplate,-dotnet-coreclr,$(RELEASE_FLAGS) -DCORECLR_RUNTIME -DDOTNET))
$(eval $(call NativeCompilationTemplate,-dotnet-coreclr-debug,$(DEBUG_FLAGS) -DCORECLR_RUNTIME -DDOTNET))
$(eval $(call NativeCompilationTemplate,-dotnet-nativeaot,$(RELEASE_FLAGS) -DCORECLR_RUNTIME -DDOTNET -DNATIVEAOT))
$(eval $(call NativeCompilationTemplate,-dotnet-nativeaot-debug,$(DEBUG_FLAGS) -DCORECLR_RUNTIME -DDOTNET -DNATIVEAOT))

.libs/iphoneos .libs/iphonesimulator .libs/tvos .libs/tvsimulator .libs/maccatalyst .libs/mac:
	$(Q) mkdir -p $@

%.csproj.inc: %.csproj $(TOP)/Make.config $(TOP)/mk/mono.mk $(TOP)/tools/common/create-makefile-fragment.sh
	$(Q) $(TOP)/tools/common/create-makefile-fragment.sh $(abspath $<) $(abspath $@)

$(foreach rid,$(DOTNET_RUNTIME_IDENTIFIERS),.libs/$(rid)):
	$(Q) mkdir -p $@
