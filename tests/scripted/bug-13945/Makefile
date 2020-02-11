TOP=../../..
include $(TOP)/Make.config

all-local:: bug-13945

bug-13945:
	$(Q) git clean -xfdq
	$(Q) echo "void foo () {}" > nativeA.m
	$(Q) echo "void bar () {}" > nativeB.m
	$(Q) mkdir -p .libs
	$(Q) $(MAKE) .libs/iphoneos/nativeA.arm64.o
	$(Q) $(MAKE) .libs/iphoneos/nativeB.arm64.o
	$(Q) rm -Rf TheApp.app cache cache-first
	$(Q) mkdir -p TheApp.app
	$(Q) mkdir -p cache

	$(Q) cp .libs/iphoneos/nativeA.arm64.o libNative.a
	$(Q) $(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/bin/btouch-native binding.cs --link-with=libNative.a,Native -s:managed.cs -o:binding.dll
	$(Q) $(SYSTEM_CSC) app.cs -r:$(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/Xamarin.iOS.dll -r:binding.dll -out:app.exe
	$(Q) $(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/bin/mtouch -r:binding.dll app.exe --abi=arm64  -sdk "$(IOS_SDK_VERSION)"  -dev:TheApp.app -sdkroot $(XCODE_DEVELOPER_ROOT) --cache=$(shell pwd)/cache -r:$(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/Xamarin.iOS.dll

	$(Q) cp -Rp cache cache-first

	$(Q) cp .libs/iphoneos/nativeB.arm64.o libNative.a
	$(Q) $(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/bin/btouch-native binding.cs --link-with=libNative.a,Native -s:managed.cs -o:binding.dll
	# do not rebuild the .exe
	$(Q) $(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/bin/mtouch -r:binding.dll app.exe --abi=arm64  -sdk "$(IOS_SDK_VERSION)"  -dev:TheApp.app -sdkroot $(XCODE_DEVELOPER_ROOT) --cache=$(shell pwd)/cache -r:$(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/Xamarin.iOS.dll

	# this will verify that binding.dll wasn't AOT'ed again - if binding.dll.arm64.s differ then the AOT compiler executed.
	$(Q) diff -u cache-first/arm64/binding.dll.s cache/arm64/binding.dll.s
	$(Q) echo "$$(Q) : Success"

include $(TOP)/mk/rules.mk
