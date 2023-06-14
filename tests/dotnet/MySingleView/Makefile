TOP=../../..

include $(TOP)/Make.config

build:
	$(DOTNET) build /bl $(MSBULD_VERBOSITY)

run:
	$(DOTNET) build /bl $(MSBUILD_VERBOSITY) /t:Run

reload:
	$(MAKE) -C $(TOP)/tests/dotnet $@

nativeaot:
	$(Q) donut publish /p:RuntimeIdentifier=ios-arm64 /p:PublishAot=true /p:Configuration=Release /bl:$@.binlog

run-nativeaot:
	$(Q) $(MAKE) build BUILD_ARGUMENTS="/p:RuntimeIdentifier=ios-arm64 /p:PublishAot=true /p:_IsPublishing=true /p:Configuration=Release /bl:$@.binlog /t:Run"
