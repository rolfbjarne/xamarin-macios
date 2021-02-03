# CoreCLR

## How to build

You need a custom built version of dotnet/runtime:

```shell
git clone https://github.com/AaronRobinsonMSFT/runtime
cd runtime
git checkout managed_native_exception
RUNTIME_DIR=$(pwd)
```

Build it like this:

```shell
./build.sh clr+libs+host+packs+mono -configuration release -arch arm64 -cross /p:UseCrossGen2=false
./build.sh libs+host+packs+mono -configuration release -arch arm64 -cross /p:UseCrossGen2=false
./build.sh clr+libs+host+packs+mono -configuration release
./build.sh libs+host+packs+mono -configuration release
```

Then you need to point xamarin-macios at your dotnet/runtime (RUNTIME_DIR is from above, adjust according to your local setup):

```shell
cd where-is/xamarin-macios
./configure --enable-dotnet --enable-dotnet-windows --disable-legacy-xamarin --custom-dotnet=$RUNTIME_DIR/artifacts
```

Now build xamarin-macios:

```shell
make all -j8
make install -j8
```

If this doesn't work, ping rolf with the build log.

## The fun part

Build & run monotouch-test with CoreCLR:

```shell
make -C tests/dotnet/monotouch-test build-monotouch-test-with-coreclr
```

Build & run monotouch-test with MonoVM:

```shell
make -C tests/dotnet/monotouch-test build-monotouch-test-with-mono
```

Build & run monotouch-test with both CoreCLR and MonoVM:

```shell
make -C tests/dotnet/monotouch-test monotouch-test-perftest
```

All test runs will write output to `~/test/monotouchtest-timings`.

## Performance testing

Build & run the performance tests with both CoreCLR and MonoVM:

```shell
make -C tests/dotnet/CoreCLRPerfTest run-perftest
```
