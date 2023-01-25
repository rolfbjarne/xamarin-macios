TOP=../../..

include $(TOP)/Make.config

build:
	$(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY)

run:
	$(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY) -t:Run

managed-static-registrar msr:
	rm -rf bin obj
	$(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY) /p:Registrar=managed-static /t:Run
