IOS_BUILD_DIR=foobar/ios
IOS_DESTDIR=../tools/comparison/_ios-build
MONOTOUCH_PREFIX=/Library/Frameworks/Xamarin.iOS.framework/Versions/Current

foobar/Xamarin.iOS.dll: foobar
	echo AAA

foobar/Xamarin.iOS.pdb: foobar
	echo CCC

$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/%: foobar/%
	echo BBB

foobar:
	echo EEE

IOS_TARGETS += \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/Xamarin.iOS.dll \
	$(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/Xamarin.iOS.pdb \

all-ios: $(IOS_TARGETS)

.SECONDARY: foobar $(IOS_DESTDIR)$(MONOTOUCH_PREFIX)/lib/mono/Xamarin.iOS/Xamarin.iOS.pdb foobar/Xamarin.iOS.pdb
