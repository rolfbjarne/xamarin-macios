TOP=../../..

include $(TOP)/Make.config

all:
	$(DOTNET6) build /bl *.csproj $(MSBUILD_VERBOSITY)
	$(PWD)/bin/MacCatalyst/Debug/MyCatalystApp.app/Contents/MacOS/MyCatalystApp
