#!/bin/bash -eux

set -o pipefail
IFS=$'\n\t'

cd "$(dirname "${BASH_SOURCE[0]}")"

if [[ "${1:-}" != "--skip-clean" ]]; then
	git clean -xfd
	RUNTIME_PATH=../../../../dotnet/runtime
	RUNTIME_PATH=$(cd $RUNTIME_PATH && pwd)
	./configure --disable-all-platforms --enable-ios --disable-simulator --custom-dotnet=$RUNTIME_PATH
	make reset
fi

make all -j8
make install -j8
./builds/downloads/dotnet/dotnet workload install maui-tizen --skip-manifest-update

cd tests/dotnet/MyMauiApp/iOS

make build

if test -z "${DEVNAME:-}"; then
	DEVNAME="Rolf's iPhone 13"
fi
export DEVNAME

if test -z "${MLAUNCH:-}"; then
	MLAUNCH=$(dotnet build -getProperty:MlaunchPath -f net10.0-ios)
fi


$MLAUNCH --installdev bin/Debug/net10.0-ios/ios-arm64/*.app --devname "$DEVNAME"

# Add '--setenv=DOTNET_InterpDump=*!*' to the command below to get the interpreter dump.
$MLAUNCH --launchdev bin/Debug/net10.0-ios/ios-arm64/*.app --devname "$DEVNAME" --wait-for-exit
