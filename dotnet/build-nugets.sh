#!/bin/bash -eux

set -o pipefail

if test -z "$TOP"; then echo "TOP not set"; exit 1; fi
if test -z "$MACOS_DOTNET_DESTDIR"; then echo "MACOS_DOTNET_DESTDIR not set"; exit 1; fi
if test -z "$IOS_DOTNET_DESTDIR"; then echo "IOS_DOTNET_DESTDIR not set"; exit 1; fi
if test -z "$TVOS_DOTNET_DESTDIR"; then echo "TVOS_DOTNET_DESTDIR not set"; exit 1; fi
if test -z "$WATCHOS_DOTNET_DESTDIR"; then echo "WATCHOS_DOTNET_DESTDIR not set"; exit 1; fi
if test -z "$MAC_DESTDIR"; then echo "MAC_DESTDIR not set"; exit 1; fi
if test -z "$IOS_DESTDIR"; then echo "IOS_DESTDIR not set"; exit 1; fi
if test -z "$MAC_FRAMEWORK_DIR"; then echo "MAC_FRAMEWORK_DIR not set"; exit 1; fi
if test -z "$MONOTOUCH_PREFIX"; then echo "MONOTOUCH_PREFIX not set"; exit 1; fi

cp="cp -c"

copy_files ()
{
	local dotnet_destdir=$1
	local destdir=$2
	local platform=$3
	#shellcheck disable=SC2155
	local platform_lower=$(echo "$platform" | tr '[:upper:]' '[:lower:]')
	local arches_64=$4
	local arches_32=$5
	local assembly_infix=$6

	echo "$dotnet_destdir"

	mkdir -p "$dotnet_destdir"
	mkdir -p "$dotnet_destdir/bin"
	for arch in $arches_32 $arches_64; do
		mkdir -p "$dotnet_destdir/bin/$arch"
	done
	mkdir -p "$dotnet_destdir/runtimes"
	mkdir -p "$dotnet_destdir/targets"
	mkdir -p "$dotnet_destdir/tools"
	mkdir -p "$dotnet_destdir/Sdk"
	mkdir -p "$dotnet_destdir/tools"
	mkdir -p "$dotnet_destdir/tools/lib"

	$cp "$destdir/Version" "$dotnet_destdir/"
	$cp "$destdir/buildinfo" "$dotnet_destdir/tools/"

	$cp "$TOP/msbuild/dotnet5/Xamarin.$platform.Sdk/Sdk/"* "$dotnet_destdir/Sdk/"
	$cp "$TOP/msbuild/dotnet5/targets/"* "$dotnet_destdir/targets/"
	$cp "$TOP/msbuild/dotnet5/Xamarin.$platform.Sdk/targets/"* "$dotnet_destdir/targets/"

	$cp -r "$destdir/lib/msbuild" "$dotnet_destdir/tools/"

	if test -n "$arches_64" -a -n "$arches_32"; then
		for arch in $arches_64; do
			mkdir -p "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10"
			$cp "$TOP/src/build/dotnet/$platform_lower/64/Xamarin.$assembly_infix.dll" "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10/"
			$cp "$TOP/src/build/dotnet/$platform_lower/64/Xamarin.$assembly_infix.pdb" "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10/"
		done

		for arch in $arches_32; do
			mkdir -p "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10"
			$cp "$TOP/src/build/dotnet/$platform_lower/32/Xamarin.$assembly_infix.dll" "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10/"
			$cp "$TOP/src/build/dotnet/$platform_lower/32/Xamarin.$assembly_infix.pdb" "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10/"
		done
	else
		for arch in $arches_32 $arches_64; do
			mkdir -p "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10"
			$cp "$TOP/src/build/dotnet/$platform_lower/Xamarin.$assembly_infix.dll" "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10/"
			$cp "$TOP/src/build/dotnet/$platform_lower/Xamarin.$assembly_infix.pdb" "$dotnet_destdir/runtimes/$platform_lower-$arch/lib/xamarinios10/"
		done
	fi


	if [[ "$platform" == "iOS" ]]; then
		$cp "$TOP/builds/downloads/ios/ios/netcoreapp5.0-iOS-Release-arm64/"* "$dotnet_destdir/runtimes/$platform_lower-arm64/lib/xamarinios10/"
		$cp "$TOP/builds/downloads/ios/ios/netcoreapp5.0-iOS-Release-arm/"* "$dotnet_destdir/runtimes/$platform_lower-armv7/lib/xamarinios10/"
		$cp "$TOP/builds/downloads/ios/ios/netcoreapp5.0-iOS-Release-arm/"* "$dotnet_destdir/runtimes/$platform_lower-armv7s/lib/xamarinios10/"
		$cp "$TOP/builds/downloads/ios/ios/netcoreapp5.0-iOS-Release-x64/"* "$dotnet_destdir/runtimes/$platform_lower-x64/lib/xamarinios10/"
		# FIXME: pending x86
	fi

    # <!-- simlauncher -->
    # <Content Include="$(_iOSCurrentPath)\bin\simlauncher-*" Condition=" '$(_PlatformName)' == 'iOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
	if [[ "$platform" != "macOS" ]]; then
		$cp "$destdir/bin/simlauncher"* "$dotnet_destdir/bin/"
	fi

    # <!-- generator -->
    # <Content Include="$(_iOSCurrentPath)\bin\bgen">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\lib\bgen\**">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\lib\bgen</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\bin\btouch" Condition=" '$(_PlatformName)' == 'iOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\bin\btv" Condition=" '$(_PlatformName)' == 'tvOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\bin\bwatch" Condition=" '$(_PlatformName)' == 'watchOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    $cp "$destdir/bin/bgen" "$dotnet_destdir/bin/"
    $cp -r "$destdir/lib/bgen" "$dotnet_destdir/tools/lib/"
    if [[ "$platform" == "iOS" ]]; then
    	$cp "$destdir/bin/btouch" "$dotnet_destdir/bin/"
    fi
	if [[ "$platform" == "tvOS" ]]; then
        $cp "$destdir/bin/btv" "$dotnet_destdir/bin/"
    fi
	if [[ "$platform" == "watchOS" ]]; then
        $cp "$destdir/bin/bwatch" "$dotnet_destdir/bin/"
    fi
	if [[ "$platform" == "macOS" ]]; then
        $cp "$destdir/bin/bmac" "$dotnet_destdir/bin/"
    fi

    # <!-- mtouch -->
    # <Content Include="$(_iOSCurrentPath)\bin\mtouch" Condition=" '$(_PlatformName)' != 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\lib\mtouch\**" Condition=" '$(_PlatformName)' != 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\lib\mtouch</PackagePath>
    # </Content>
	if [[ "$platform" != "macOS" ]]; then
		$cp "$destdir/bin/mtouch"* "$dotnet_destdir/bin/"
    	$cp -r "$destdir/lib/mtouch" "$dotnet_destdir/tools/lib/"
	fi

    # <!-- mmp -->
    # <Content Include="$(_macOSCurrentPath)\bin\mmp" Condition=" '$(_PlatformName)' == 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_macOSCurrentPath)\lib\mmp\**" Condition=" '$(_PlatformName)' == 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\lib\mmp</PackagePath>
    # </Content>
	if [[ "$platform" == "macOS" ]]; then
		$cp "$destdir/bin/mmp"* "$dotnet_destdir/bin/"
    	$cp -r "$destdir/lib/mmp" "$dotnet_destdir/tools/lib/"
	fi
    # <!-- mlaunch -->
    # <Content Include="$(_iOSCurrentPath)\bin\mlaunch" Condition=" '$(_PlatformName)' != 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\lib\mlaunch\**" Condition=" '$(_PlatformName)' != 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\lib\mlaunch</PackagePath>
    # </Content>
   	if [[ "$platform" != "macOS" ]]; then
		$cp "$destdir/bin/mlaunch"* "$dotnet_destdir/bin/"
    	$cp -r "$destdir/lib/mlaunch" "$dotnet_destdir/tools/lib/"
	fi

    # <!-- AOT compilers -->
    # <Content Include="$(_iOSCurrentPath)\bin\arm64-darwin-mono-sgen" Condition=" '$(_PlatformName)' == 'iOS' Or '$(_PlatformName)' == 'tvOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\bin\arm-darwin-mono-sgen" Condition=" '$(_PlatformName)' == 'iOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\bin\arm64_32-darwin-mono-sgen" Condition=" '$(_PlatformName)' == 'watchOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\bin\armv7k-unknown-darwin-mono-sgen" Condition=" '$(_PlatformName)' == 'watchOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>$(_BinDir)</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\LLVM\bin\llc;$(_iOSCurrentPath)\LLVM\bin\opt">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\LLVM\bin\</PackagePath>
    # </Content>

    # <!-- SDK frameworks -->
    # <Content Include="$(_iOSCurrentPath)\SDKs\MonoTouch.iphonesimulator.sdk\**" Condition=" '$(_PlatformName)' == 'iOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\SDKS\MonoTouch.iphonesimulator.sdk</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\SDKs\MonoTouch.iphoneos.sdk\**" Condition=" '$(_PlatformName)' == 'iOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\SDKS\MonoTouch.iphoneos.sdk</PackagePath>
    # </Content>

    if [[ "$platform" == "iOS" ]]; then
    	for arch in $arches_64; do
			mkdir -p "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/Xamarin.$platform.registrar.a" "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libapp.a"                      "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libextension.a"                "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libtvextension.a"              "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libwatchextension.a"           "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libxamarin-debug.a"            "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libxamarin-debug.dylib"        "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libxamarin.a"                  "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libxamarin.dylib"              "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"

	    	$cp -r "$destdir"/SDKs/MonoTouch.iphoneos.sdk/Frameworks/Xamarin*.framework*     "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    done
    	for arch in $arches_32; do
			mkdir -p "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/Xamarin.$platform.registrar.a" "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libapp.a"                      "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libextension.a"                "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libtvextension.a"              "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libwatchextension.a"           "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libxamarin-debug.a"            "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libxamarin-debug.dylib"        "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libxamarin.a"                  "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    	$cp "$destdir/SDKs/MonoTouch.iphonesimulator.sdk/usr/lib/libxamarin.dylib"              "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"

	    	$cp -r "$destdir"/SDKs/MonoTouch.iphonesimulator.sdk/Frameworks/Xamarin*.framework*     "$dotnet_destdir/runtimes/$platform_lower-$arch/native/"
	    done

	    unzip -oj -d "$dotnet_destdir/runtimes/$platform_lower-x64/native/"    "$TOP/builds/downloads/ios/ios/runtime.ios-x64.Microsoft.NETCore.Runtime.Mono.5.0.0-dev.nupkg"   'runtimes/ios-x64/native/libmono.*'
	    unzip -oj -d "$dotnet_destdir/runtimes/$platform_lower-armv7/native/"  "$TOP/builds/downloads/ios/ios/runtime.ios-arm.Microsoft.NETCore.Runtime.Mono.5.0.0-dev.nupkg"   'runtimes/ios-arm/native/libmono.*'
	    unzip -oj -d "$dotnet_destdir/runtimes/$platform_lower-armv7s/native/" "$TOP/builds/downloads/ios/ios/runtime.ios-arm.Microsoft.NETCore.Runtime.Mono.5.0.0-dev.nupkg"   'runtimes/ios-arm/native/libmono.*'
	    unzip -oj -d "$dotnet_destdir/runtimes/$platform_lower-arm64/native/"  "$TOP/builds/downloads/ios/ios/runtime.ios-arm64.Microsoft.NETCore.Runtime.Mono.5.0.0-dev.nupkg" 'runtimes/ios-arm64/native/libmono.*'

	    unzip -oj -d "$dotnet_destdir/bin/arm64/"  "$TOP/builds/downloads/ios/ios/runtime.ios-arm64.Microsoft.NETCore.Tool.MonoAOT.5.0.0-dev.nupkg" 'tools/mono-aot-cross'
	    unzip -oj -d "$dotnet_destdir/bin/armv7/"  "$TOP/builds/downloads/ios/ios/runtime.ios-arm.Microsoft.NETCore.Tool.MonoAOT.5.0.0-dev.nupkg"   'tools/mono-aot-cross'
	    unzip -oj -d "$dotnet_destdir/bin/armv7s/" "$TOP/builds/downloads/ios/ios/runtime.ios-arm.Microsoft.NETCore.Tool.MonoAOT.5.0.0-dev.nupkg"   'tools/mono-aot-cross'
	fi


    # <Content Include="$(_iOSCurrentPath)\SDKs\Xamarin.AppleTVSimulator.sdk\**" Condition=" '$(_PlatformName)' == 'tvOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\SDKS\Xamarin.AppleTVSimulator.sdk</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\SDKs\Xamarin.AppleTVOS.sdk\**" Condition=" '$(_PlatformName)' == 'tvOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\SDKS\Xamarin.AppleTVOS.sdk</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\SDKs\Xamarin.WatchSimulator.sdk\**" Condition=" '$(_PlatformName)' == 'watchOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\SDKS\Xamarin.WachSimulator.sdk</PackagePath>
    # </Content>
    # <Content Include="$(_iOSCurrentPath)\SDKs\Xamarin.WatchOS.sdk\**" Condition=" '$(_PlatformName)' == 'watchOS'">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\SDKS\Xamarin.WatchOS.sdk</PackagePath>
    # </Content>
    # <Content Include="$(_macOSCurrentPath)\lib\*.dylib;$(_macOSCurrentPath)\lib\*.a" Condition=" '$(_PlatformName)' == 'macOS' ">
    #   <Pack>true</Pack>
    #   <PackagePath>tools\lib</PackagePath>
    # </Content>
}

copy_files "$MACOS_DOTNET_DESTDIR"   "$MAC_DESTDIR$MAC_FRAMEWORK_DIR/Versions/Current" macOS    "x64"       ""                    Mac
copy_files "$IOS_DOTNET_DESTDIR"     "$IOS_DESTDIR$MONOTOUCH_PREFIX"                   iOS      "x64 arm64" "x86 armv7 armv7s"    iOS
copy_files "$TVOS_DOTNET_DESTDIR"    "$IOS_DESTDIR$MONOTOUCH_PREFIX"                   tvOS     "x64 arm64" ""                    TVOS
copy_files "$WATCHOS_DOTNET_DESTDIR" "$IOS_DESTDIR$MONOTOUCH_PREFIX"                   watchOS  ""          "x86 armv7k arm64_32" WatchOS

