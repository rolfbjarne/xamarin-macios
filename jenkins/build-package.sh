#!/bin/bash -ex

exit 0

cd xamarin-macios

./configure --enable-xamarin
make reset
make print-versions

mkdir -p ../package
echo "PACKAGE!" > ../package/xamarin-ios-dummy-package.pkg

exit 0

make -j8
make install -j8
make package
