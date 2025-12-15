#!/bin/bash -ex

./configure --disable-all-platforms --enable-maccatalyst
make all -j8
make install -j8
make build TEST_VARIATION=coreclr -C tests/monotouch-test/dotnet/MacCatalyst
./tests/monotouch-test/dotnet/MacCatalyst/bin/Debug/net11.0-maccatalyst/maccatalyst-x64/monotouchtest.app/Contents/MacOS/monotouchtest --autostart --autoexit --test MonoTouchFixtures.HealthKit.CdaDocumentSampleTest
