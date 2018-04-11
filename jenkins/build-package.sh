#!/bin/bash -ex

./system-dependencies.sh --provision-all
./configure --enable-xamarin
make reset
make print-versions

make -j8
make install -j8
make package
