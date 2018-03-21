#!/bin/bash -ex

# create dummy package

mkdir -p Library
echo foo > Library/foo
pkgbuild --identifier com.xamarin.foo --nopayload --root Library foo.pkg

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
