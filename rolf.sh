#!/bin/bash -eux

set -o pipefail
IFS=$'\n\t'

cd "$(dirname "${BASH_SOURCE[0]}")"

if [[ "${1:-}" != "--skip-clean" ]]; then
	git clean -xfd
	./configure --disable-all-platforms --enable-ios --custom-dotnet=/Users/rolf/work/dotnet/runtime
	make reset
fi

make all -j8
make install -j8

cd tests/dotnet/MySimpleApp/iOS

make build

export DEVNAME="Rolf's iPhone 13"
MLAUNCH=$(dotnet build -getProperty:MlaunchPath)
$MLAUNCH --installdev bin/Debug/net10.0-ios/ios-arm64/MySimpleApp.app --devname "$DEVNAME"
$MLAUNCH --launchdev bin/Debug/net10.0-ios/ios-arm64/MySimpleApp.app --devname "$DEVNAME" --wait-for-exit
