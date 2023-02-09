include ../shared.mk

llvm:
	$(Q) $(MAKE) build BUILD_ARGUMENTS="/p:RuntimeIdentifier=maccatalyst-arm64 /p:MtouchUseLlvm=true /p:MtouchLink=SdkOnly /p:Configuration=Release-llvm /bl:$@.binlog"

run-llvm:
	$(Q) $(MAKE) build BUILD_ARGUMENTS="/p:RuntimeIdentifier=maccatalyst-arm64 /p:MtouchUseLlvm=true /p:MtouchLink=SdkOnly /p:Configuration=Release-llvm /bl:$@.binlog /t:Run"

managed-static-registrar msr:
	rm -rf bin obj
	if ! $(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY) /p:Registrar=managed-static; then make diag; exit 1; fi
	./bin/Debug/net7.0-maccatalyst/maccatalyst-x64/monotouchtest.app/Contents/MacOS/monotouchtest --autostart --autoexit

clean-build:
	$(MAKE) -C $(TOP) git-clean-all
	$(MAKE) -C $(TOP) all -j8
	$(MAKE) -C $(TOP) install -j8
