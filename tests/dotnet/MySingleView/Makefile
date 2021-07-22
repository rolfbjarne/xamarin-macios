TOP=../../..

include $(TOP)/Make.config

build:
	$(DOTNET6) build /bl $(MSBULD_VERBOSITY)

run:
	$(DOTNET6) build /bl $(MSBUILD_VERBOSITY) /t:Run

run-dev:
	rm -Rf bin obj
	$(DOTNET6) build /bl:build.binlog $(MSBUILD_VERBOSITY) /p:RuntimeIdentifier=ios-arm64
	$(DOTNET6) build /bl:run.binlog   /v:diag              /p:RuntimeIdentifier=ios-arm64 /t:Run

run-llvm:
	rm -Rf bin obj
	$(DOTNET6) build /bl:build.binlog $(MSBUILD_VERBOSITY) /p:RuntimeIdentifier=ios-arm64         /p:MtouchUseLlvm=true
	$(DOTNET6) build /bl:run.binlog   /v:diag              /p:RuntimeIdentifier=ios-arm64 /t:Run  /p:MtouchUseLlvm=true
