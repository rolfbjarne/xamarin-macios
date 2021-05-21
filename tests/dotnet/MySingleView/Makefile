TOP=../../..

include $(TOP)/Make.config

build:
	$(DOTNET6) build *.csproj /bl $(MSBUILD_VERBOSITY)

run:
	$(DOTNET6) build *.csproj /bl $(MSBUILD_VERBOSITY) /t:Run
