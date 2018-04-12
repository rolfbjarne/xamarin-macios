#!/bin/bash -ex

./system-dependencies.sh --provision-all
./configure --enable-xamarin
make reset
make git-clean-all
make print-versions

make -j8
make install -j8

rm -Rf ../package
make package
