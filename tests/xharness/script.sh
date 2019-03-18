#!/bin/bash -ex

rm -f /tmp/mtouch-lldb-prep-cmds

make all -j8 -C /work/maccore/arm32_64/xamarin-macios/
make install -j8 -C /work/maccore/arm32_64/xamarin-macios/
rm -Rf '/work/maccore/arm32_64/xamarin-macios/tests/xharness/tmp-test-dir/*/*/bin'

say building app
MSBuildExtensionsPathFallbackPathsOverride=/work/maccore/arm32_64/xamarin-macios/_ios-build/Library/Frameworks/Mono.framework/External/xbuild \
TargetFrameworkFallbackSearchPaths=/work/maccore/arm32_64/xamarin-macios/_ios-build/Library/Frameworks/Mono.framework/External/xbuild-frameworks \
MD_MTOUCH_SDK_ROOT=/work/maccore/arm32_64/xamarin-macios/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current \
MD_APPLE_SDK_ROOT=/Applications/Xcode101.app \
/work/maccore/arm32_64/xamarin-macios/tools/xibuild/xibuild -- /verbosity:diagnostic /p:Platform=iPhone /p:Configuration=Release32 '/work/maccore/arm32_64/xamarin-macios/tests/xharness/tmp-test-dir/link all/2913/link all-watchos.csproj'

say installing

/work/maccore/arm32_64/xamarin-macios/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/bin/mlaunch \
	--sdkroot /Applications/Xcode101.app -v  --installdev "/work/maccore/arm32_64/xamarin-macios/tests/xharness/tmp-test-dir/link all/2913/bin/iPhone/Release32-watchos/Container.app"  --devname "Rolf's iPhone 7 - iOS 11.4.1" --device ios,watchos

say installed, now launching

/work/maccore/arm32_64/xamarin-macios/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/bin/mlaunch \
	--sdkroot /Applications/Xcode101.app -v  -argument=-connection-mode -argument=none -argument=-app-arg:-autostart -setenv=NUNIT_AUTOSTART=true \
	-argument=-app-arg:-autoexit -setenv=NUNIT_AUTOEXIT=true -argument=-app-arg:-enablenetwork -setenv=NUNIT_ENABLE_NETWORK=true -argument=-app-arg:-hostname:192.168.2.128,fe80::1461:7f3e:fec5:5c93,fe80::aede:48ff:fe00:1122,fe80::6323:97f6:a21e:c5f7 \
	-setenv=NUNIT_HOSTNAME=192.168.2.128,fe80::1461:7f3e:fec5:5c93,fe80::aede:48ff:fe00:1122,fe80::6323:97f6:a21e:c5f7 -argument=-app-arg:-transport:HTTP -setenv=NUNIT_TRANSPORT=HTTP -argument=-app-arg:-hostport:52382 -setenv=NUNIT_HOSTPORT=52382 \
	--debugdev '/work/maccore/arm32_64/xamarin-macios/tests/xharness/tmp-test-dir/link all/2913/bin/iPhone/Release32-watchos/Container.app/Watch/App.app' --disable-memory-limits --attach-native-debugger --devname Rolf-S2-4.3.1
