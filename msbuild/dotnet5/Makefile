TOP = ../..

include $(TOP)/Make.config
include $(TOP)/mk/rules.mk

DOTNET_VERSION=$(shell dotnet --version)
DOTNET_PATH=/usr/local/share/dotnet/sdk/$(DOTNET_VERSION)/Sdks

DIRECTORIES = \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Sdk \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Sdk \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Sdk \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Framework/Xamarin.iOS \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Framework/Xamarin.tvOS \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Framework/Xamarin.watchOS \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/RedistList \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.tvOS/RedistList \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.watchOS/RedistList \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Sdk \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/mono/Xamarin.Mac/RedistList \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Framework/Xamarin.macOS \

IOS_TARGETS = \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Sdk/Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Sdk/Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.Shared.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.Shared.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.Shared.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.Shared.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/RedistList/FrameworkList.xml \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Framework/Xamarin.iOS/v1.0 \

TVOS_TARGETS = \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Sdk/Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Sdk/Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.tvOS.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.tvOS.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.tvOS.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.tvOS.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.Shared.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.Shared.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.Shared.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.Shared.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.tvOS/RedistList/FrameworkList.xml \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Framework/Xamarin.tvOS/v1.0 \

WATCHOS_TARGETS = \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Sdk/Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Sdk/Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.watchOS.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.watchOS.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.watchOS.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.watchOS.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.Shared.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.Shared.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.Shared.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.Shared.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.watchOS/RedistList/FrameworkList.xml \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Framework/Xamarin.watchOS/v1.0 \

MACOS_TARGETS = \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Sdk/Sdk.props \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Sdk/Sdk.targets \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/mono/Xamarin.Mac/RedistList/FrameworkList.xml \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Framework/Xamarin.macOS/v1.0 \

TARGETS = $(IOS_TARGETS) $(TVOS_TARGETS) $(WATCHOS_TARGETS) $(MACOS_TARGETS)

install-symlink:
	sudo ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk $(DOTNET_PATH)/Xamarin.iOS.Sdk
	sudo ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk $(DOTNET_PATH)/Xamarin.tvOS.Sdk
	sudo ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk $(DOTNET_PATH)/Xamarin.watchOS.Sdk
	sudo ln -Fhs $(MAC_TARGETDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk $(DOTNET_PATH)/Xamarin.macOS.Sdk

install-local:: $(TARGETS) install-symlink

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/RedistList/FrameworkList.xml: ../Xamarin.iOS.Tasks.Core/Xamarin.iOS-FrameworkList.xml.in Makefile | $(DIRECTORIES)
	$(Q) sed 's@%TargetFrameworkDirectory%@$(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS@' $< > $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.TVOS/RedistList/FrameworkList.xml: ../Xamarin.iOS.Tasks.Core/Xamarin.tvOS-FrameworkList.xml.in Makefile | $(DIRECTORIES)
	$(Q) sed 's@%TargetFrameworkDirectory%@$(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.TVOS@' $< > $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.WatchOS/RedistList/FrameworkList.xml: ../Xamarin.iOS.Tasks.Core/Xamarin.watchOS-FrameworkList.xml.in Makefile | $(DIRECTORIES)
	$(Q) sed 's@%TargetFrameworkDirectory%@$(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.WatchOS@' $< > $@

$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/mono/Xamarin.Mac/RedistList/FrameworkList.xml: ../Xamarin.Mac.Tasks/Xamarin.Mac-FrameworkList.xml.in Makefile | $(DIRECTORIES)
	$(Q) sed 's@%TargetFrameworkDirectory%@$(MAC_TARGETDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/mono/Xamarin.Mac@' $< > $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Framework/Xamarin.iOS/v1.0: Makefile
	ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Framework/Xamarin.tvOS/v1.0: Makefile
	ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.tvOS $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Framework/Xamarin.watchOS/v1.0: Makefile
	ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.watchOS $@

$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Framework/Xamarin.macOS/v1.0: Makefile
	ln -Fhs $(MAC_TARGETDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/mono/Xamarin.Mac $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/%: % | $(DIRECTORIES)
	$(Q) $(CP) $< $@

$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/%: % | $(DIRECTORIES)
	$(Q) $(CP) $< $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.Shared.%: targets/Xamarin.Shared.% | $(DIRECTORIES)
	$(Q) $(CP) $< $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/targets/Xamarin.Shared.%: targets/Xamarin.Shared.% | $(DIRECTORIES)
	$(Q) $(CP) $< $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/targets/Xamarin.Shared.%: targets/Xamarin.Shared.% | $(DIRECTORIES)
	$(Q) $(CP) $< $@

$(DIRECTORIES):
	$(Q) mkdir -p $@

all-local:: $(TARGETS)