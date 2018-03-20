#!/bin/bash -ex

cd xamarin-macios

./configure --enable-xamarin
make reset
make print-versions

mkdir -p ../package
echo "PACKAGE!" > ../package/xamarin-ios-dummy-package.pkg

exit 1

make -j8
make install -j8
make package
