# FSharp

## Build cache

We store a cached version of the build in Azure.

The cached version is hashed based on:

* The MD5 of most of the Makefile (excluding the `ARTIFACT_ZIP_URL` and `ARTIFACT_MD5` variable definitions).
* The git commit hash of the fsharp repository.

Which means that either changing the Makefile or bumping the fsharp repository
requires a new cached build.

The first build will try to download the cached version, and store both a
success and failure (so that any subsequent builds will not try to download
again if the download failed).

The environment variable `FSHARP_USE_BINARY_CACHE` can be used to override the
behavior: setting it to `0` will disable the binary cache altogether, and
setting it to `1` will force the binary cache to be used (which will fail the
build if it can't be downloaded, or the MD5 checksum doesn't match).

### New cached build creation

These instructions assume the current directory is xamarin-macios/fsharp.

1. Create the zip by executing this in a terminal:

```shell
make create-cached-build
```

2. Upload the zip using xampubbot (PM `@xampubbot help` to `@xampubbot` for help).

3. Update the `ARTIFACT_ZIP_URL` variable in `Makefile` to point to the URL (maintain the `$(ARTIFACT_HASH)` part of the URL). The `ARTIFACT_MD5` variable was automatically updated in the previous step, and both these changes must be committed:

```shell
git add Makefile
git commit -m "Create a new F# cached build."
```

3. Test that the cached build works:

```shell
git clean -xfd
make # this should not build from source, but download the cached build.
```
