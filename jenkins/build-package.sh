#!/bin/bash -ex

cd xamarin-macios

./configure --enable-xamarin
make reset
make print-versions

make -j8
make install -j8
make package
