#!/bin/bash -e

env
ls -la

CURDIR=$(pwd)
cd ..
mv $CURDIR xamarin-macios
ln -s $CURDIR/../xamarin-macios $CURDIR

ls -la
cd xamarin-macios
./configure --enable-xamarin
make reset
make print-versions
