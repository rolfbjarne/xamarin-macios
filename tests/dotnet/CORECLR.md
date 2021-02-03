# CoreCLR

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
