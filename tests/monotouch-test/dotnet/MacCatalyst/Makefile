include ../shared.mk

llvm:
	$(Q) $(MAKE) build BUILD_ARGUMENTS="/p:RuntimeIdentifier=maccatalyst-arm64 /p:MtouchUseLlvm=true /p:MtouchLink=SdkOnly /p:Configuration=Release-llvm /bl:$@.binlog"

run-llvm:
	$(Q) $(MAKE) build BUILD_ARGUMENTS="/p:RuntimeIdentifier=maccatalyst-arm64 /p:MtouchUseLlvm=true /p:MtouchLink=SdkOnly /p:Configuration=Release-llvm /bl:$@.binlog /t:Run"

managed-static-registrar msr:
	rm -rf bin obj
	if ! $(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY) /p:Registrar=managed-static; then make diag > x.log; tail -n 200 x.log; exit 1; fi
	MONO_TRACE=E:all ./bin/Debug/net7.0-maccatalyst/maccatalyst-x64/monotouchtest.app/Contents/MacOS/monotouchtest --autostart --autoexit

registrar-tests:
	./bin/Debug/net7.0-maccatalyst/maccatalyst-x64/monotouchtest.app/Contents/MacOS/monotouchtest --autostart --autoexit --test MonoTouchFixtures.ObjCRuntime.RegistrarTest

lldb:
	MONO_DEBUG=disable_omit_fp,explicit-null-checks lldb -- ./bin/Debug/net7.0-maccatalyst/maccatalyst-x64/monotouchtest.app/Contents/MacOS/monotouchtest --autostart --autoexit --test MonoTouchFixtures.ObjCRuntime.RegistrarTest

clean-build:
	$(MAKE) -C $(TOP) git-clean-all
	$(MAKE) -C $(TOP) all -j8
	$(MAKE) -C $(TOP) install -j8
