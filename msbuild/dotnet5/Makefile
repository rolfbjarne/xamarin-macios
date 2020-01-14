TOP = ../..

include $(TOP)/Make.config
include $(TOP)/mk/rules.mk

DOTNET_VERSION=$(shell dotnet --version)
DOTNET_PATH=/usr/local/share/dotnet/sdk/$(DOTNET_VERSION)/Sdks

DIRECTORIES = \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Sdk \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.tvOS.Sdk/Sdk \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.watchOS.Sdk/Sdk \
	$(MAC_DESTDIR)$(MAC_FRAMEWORK_CURRENT_DIR)/lib/dotnet5/Xamarin.macOS.Sdk/Sdk \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/RedistList \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Framework/Xamarin.iOS \

TARGETS = \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Sdk/Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Sdk/Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.TargetFrameworkInference.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.Sdk.DefaultItems.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.Sdk.targets \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/targets/Xamarin.iOS.Sdk.props \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/RedistList/FrameworkList.xml \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Framework/Xamarin.iOS/v1.0 \

install-symlink:
	sudo rm -f $(DOTNET_PATH)/Xamarin.iOS.Sdk
	sudo ln -s $(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk $(DOTNET_PATH)/Xamarin.iOS.Sdk

install-local:: $(TARGETS) install-symlink

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/RedistList/FrameworkList.xml: ../Xamarin.iOS.Tasks.Core/Xamarin.iOS-FrameworkList.xml.in Makefile | $(DIRECTORIES)
	$(Q) sed 's@%TargetFrameworkDirectory%@$(IOS_TARGETDIR)/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.iOS@' $< > $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/Xamarin.iOS.Sdk/Framework/Xamarin.iOS/v1.0: Makefile
	ln -Fhs $(IOS_TARGETDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS $@

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/dotnet5/%: % | $(DIRECTORIES)
	$(Q) $(CP) $< $@

$(DIRECTORIES):
	$(Q) mkdir -p $@

all-local:: $(TARGETS)