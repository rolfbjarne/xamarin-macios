#!/bin/bash -ex

cd xamarin-macios

./configure --enable-xamarin
make reset
make print-versions
