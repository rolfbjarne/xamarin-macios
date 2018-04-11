#!/bin/bash -ex

./configure --enable-xamarin
make reset
make print-versions

make -j8
make install -j8
make package
