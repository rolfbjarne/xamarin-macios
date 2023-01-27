TOP=../../..

include $(TOP)/Make.config

build:
	$(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY)

run:
	$(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY) -t:Run

managed-static-registrar msr:
	rm -rf bin obj
	$(DOTNET) build /bl *.csproj $(MSBUILD_VERBOSITY) /p:Registrar=managed-static
	./bin/Debug/net7.0-maccatalyst/maccatalyst-x64/MyCatalystApp.app/Contents/MacOS/MyCatalystApp

reload:
	$(MAKE) -C $(TOP)/tests/dotnet $@

diag:
	$(DOTNET) build /v:diag *.binlog "-consoleLoggerParameters:NoSummary;NoPerformanceSummary;NoItemAndPropertyList;DisableMPLogging;ForceNoAlign"
